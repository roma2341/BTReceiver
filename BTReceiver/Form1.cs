using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.Threading;

namespace BTReceiver
{
    public partial class Form1 : Form
    {
        byte[] btReceiverBuffer = new byte[2048];
        private BluetoothClient bluetoothClient;

        public Form1()
        {
            InitializeComponent();
            updateBtAdapters(false);
            initBluetooth();
            disableConnectFunction();
        }
        private void initStartingUI()
        {
            disableBluetoothFunctions();
            disableWritingToBtUI();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="showDebug"></param>
        /// <returns>true if bt adapter finded</returns>
        private bool updateBtAdapters(bool showDebug=true)
        {
            lbInternalBT.Items.Clear();
            disableWritingToBtUI();
                foreach (BluetoothRadio radio in BluetoothRadio.AllRadios)
                {
                    lbInternalBT.Items.Add(radio);
                }
            if (lbInternalBT.Items.Count < 1)
            {
                if (showDebug)
                    showNoSupportedInternalBTError();
                return false;
            }
            initBluetooth();
            return true;

        }

        private void showNoSupportedInternalBTError()
        {
            MessageBox.Show("не знайдено підтримуємих пристроїв Bluetooth","Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void initBluetooth()
        {
            try
            {
                if (bluetoothClient!=null) bluetoothClient.Close();
                 bluetoothClient = new BluetoothClient();
            }
            catch (PlatformNotSupportedException e)
            {
                showNoSupportedInternalBTError();
                disableBluetoothFunctions();
            }
        }

        private void disableBluetoothFunctions()
        {
            btnConnect.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void disableConnectFunction()
        {
            btnConnect.Enabled = false;
        }

        public void enableConnectFunction()
        {
            btnConnect.Enabled = true;
        }

        private void enableBluetoothFunctions()
        {
            btnConnect.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            BluetoothDeviceInfoContainer selectedDevice = (BluetoothDeviceInfoContainer)devicesList.SelectedItem;
            BluetoothDeviceInfo device = selectedDevice.BluetoothDeviceInfo;
            if (selectedDevice == null)
            {
                Console.WriteLine("Cannot connect to null");
                return;
            }
            bluetoothClient.SetPin("1234");
           // BluetoothSecurity.PairRequest(device.DeviceAddress, "1234");
            bluetoothClient.BeginConnect(device.DeviceAddress, BluetoothService.RFCommProtocol, new AsyncCallback(DeviceConnectedCallback),
                device);
            disableConnectFunction();
 
        }

        private void DeviceConnectedCallback(IAsyncResult result)
        {
            if (result.IsCompleted)
            {
                   //

                this.BeginInvoke(new MethodInvoker(delegate { enableWritingToBtUI(); }));
                Console.WriteLine("Connected");
                //
            }
        }

        private void enableWritingToBtUI()
        {
            btnWriteToBt.Enabled = true;
        }
        private void disableWritingToBtUI()
        {
            btnWriteToBt.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           lblBtOperationStatus.Text = "Триває оновлення пристроїв bluetooth";
            if (rbUpdateDefault.Checked)
               bluetoothClient.BeginDiscoverDevices(10, true, true, true, false, updateBTDeviceList, bluetoothClient);
            else
            bluetoothClient.BeginDiscoverDevices(10, true, true,false,false, updateBTDeviceList, bluetoothClient);
            //var devices = bluetoothClient.DiscoverDevices();
        }
        void updateBTDeviceList(IAsyncResult result)
        {
          //Get back the BluetoothClient which was passed as the state parameter in BeginDiscoverDevices
            BluetoothClient thisDevice = result.AsyncState as BluetoothClient;
        Console.WriteLine("Bluetooth devices:");
            BluetoothDeviceInfo[] devices = thisDevice.EndDiscoverDevices(result);
            this.BeginInvoke(new MethodInvoker(delegate
            {
                enableWritingToBtUI();
                devicesList.Items.Clear();
                foreach (var device in devices)
                {
                    var blueToothInfo =
                        string.Format(
                            "- DeviceName: {0}{1}  Connected: {2}{1}  Address: {3}{1}  Last seen: {4}{1}  Last used: {5}{1}",
                            device.DeviceName, Environment.NewLine, device.Connected, device.DeviceAddress, device.LastSeen,
                            device.LastUsed);
                    blueToothInfo += string.Format("  Class of device{0}   Device: {1}{0}   Major Device: {2}{0}   Service: {3}",
                    Environment.NewLine, device.ClassOfDevice.Device, device.ClassOfDevice.MajorDevice,
                     device.ClassOfDevice.Service);
                    Console.WriteLine(blueToothInfo);
                    Console.WriteLine();
                    devicesList.Items.Add(new BluetoothDeviceInfoContainer(device));

                }
                if (devices.Length > 0)
                {
                    enableConnectFunction();
                }
                else
                {
                    disableConnectFunction();
                }
                lblBtOperationStatus.Text = "";
            }));
        
        }

        private void serializeDeviceListToFile()
        {
            List<BluetoothDeviceInfoContainer> items = devicesList.Items.Cast<BluetoothDeviceInfoContainer>().ToList();
            Serializer.WriteToJsonFile<List<BluetoothDeviceInfoContainer>>("omeClass.txt", items);
        }

        private void deserializeDeviceListFromFile()
        {
            List<BluetoothDeviceInfoContainer> items = Serializer.ReadFromJsonFile<List<BluetoothDeviceInfoContainer>>("omeClass.txt");
            devicesList.Items.AddRange(items.ToArray());
        }

        private void btnUpdateBtAdapters_Click(object sender, EventArgs e)
        {
           bool btAdaptersSupported = updateBtAdapters();
            if (btAdaptersSupported)
            {
                enableBluetoothFunctions();
            }
        }

        private void BeginReadDataFromBT()
        {
            const bool IS_FLOATING_POINT = false;
            const int CHANNEL_COUNT = 2;
            const int BIT_DEPTH = 16;
            const int SAMPLE_RATE = 22050;
           
            new Thread(delegate()
            {
                int totalBytesReaded = 0;
                bool dataAvailable = true;
                var watch = System.Diagnostics.Stopwatch.StartNew();
                using (FileStream fsSource = new FileStream("test.wav",
             FileMode.OpenOrCreate, FileAccess.Write))
                {
                    ZigzagAudioLibrary.WriteWavHeader(fsSource, IS_FLOATING_POINT, CHANNEL_COUNT,
                        BIT_DEPTH, SAMPLE_RATE, 0);
                   
                    while (dataAvailable)
                    {
                        try
                        {
                            dataAvailable = bluetoothClient.GetStream().DataAvailable;
                        }
                        catch (InvalidOperationException e)
                        {
                            this.BeginInvoke(new MethodInvoker(delegate
                            {
                                MessageBox.Show(e.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }));
                            dataAvailable = false;
                            return;
                        }
                        int readed = 0;
                        try
                        {
                            readed = bluetoothClient.GetStream().Read(btReceiverBuffer, 0, btReceiverBuffer.Length);
                        }
                        catch (InvalidOperationException e)
                        {
                            this.BeginInvoke(new MethodInvoker(delegate
                            {
                                MessageBox.Show(e.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }));
                            dataAvailable = false;
                            return;
                        }
                     
                        Console.WriteLine("received bytes:" + readed);
                        Console.Write("bytes:");
                        /*    foreach (byte b in btReceiverBuffer)
                            {
                                Console.Write(b+" ");
                            }*/
                        Console.WriteLine();
                        fsSource.Write(btReceiverBuffer, 0, readed);
                        totalBytesReaded += readed;
                    }
                    int totalSampleCount = totalBytesReaded / BIT_DEPTH;
                    Console.WriteLine("totalSampleCount:" + totalSampleCount);
                    //Записуєм розмір сирих аудіоданих
                    ZigzagAudioLibrary.writeSubChunc2Size(fsSource, BIT_DEPTH, totalSampleCount);
                    double elapsedMs = watch.Elapsed.TotalMilliseconds;
                    Console.WriteLine("receiving time:" + elapsedMs);
                    fsSource.Flush();
                    fsSource.Close();
                    watch.Stop();
                }
            }).Start();
        }

        private void btnAskDevice_Click(object sender, EventArgs e)
        {
            BeginReadDataFromBT();
        }

        private void btnWriteToBt_Click(object sender, EventArgs e)
        {
            byte[] arr = new byte[1];
            arr[0] = 53;
            try
            {
                bluetoothClient.GetStream().Write(arr, 0, 1);
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(exception.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
