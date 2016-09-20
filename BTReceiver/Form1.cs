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
           // bluetoothClient.SetPin("1234");
            bluetoothClient.BeginConnect(device.DeviceAddress, BluetoothService.RFCommProtocol, new AsyncCallback(DeviceConnectedCallback),
                device);
            Console.WriteLine("Connected:"+selectedDevice);
        }

        private void DeviceConnectedCallback(IAsyncResult result)
        {
            if (result.IsCompleted)
            {
                   //

                this.BeginInvoke(new MethodInvoker(delegate { enableWritingToBtUI(); }));
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
            var devices = bluetoothClient.DiscoverDevices();
            Console.WriteLine("Bluetooth devices:");
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

        private void btnAskDevice_Click(object sender, EventArgs e)
        {
            const bool IS_FLOATING_POINT = false;
            const int CHANNEL_COUNT = 2;
            const int BIT_DEPTH = 16;
            const int SAMPLE_RATE = 22050;
       

            var watch = System.Diagnostics.Stopwatch.StartNew();
            int totalBytesReaded = 0;
            using (FileStream fsSource = new FileStream("test.wav",
                FileMode.OpenOrCreate, FileAccess.Write))
            {
                ZigzagAudioLibrary.WriteWavHeader(fsSource, IS_FLOATING_POINT, CHANNEL_COUNT,
                    BIT_DEPTH, SAMPLE_RATE, 0);

                while (bluetoothClient.GetStream().DataAvailable)
                {
                    int readed = bluetoothClient.GetStream().Read(btReceiverBuffer, 0, btReceiverBuffer.Length);
                    Console.WriteLine("received bytes:" + readed);
                    Console.Write("bytes:");
                /*    foreach (byte b in btReceiverBuffer)
                    {
                        Console.Write(b+" ");
                    }*/
                    Console.WriteLine();
                    fsSource.Write(btReceiverBuffer,0,readed);
                    totalBytesReaded += readed;
                }
                int totalSampleCount = totalBytesReaded/BIT_DEPTH;
                Console.WriteLine("totalSampleCount:"+ totalSampleCount);
                //Записуєм розмір сирих аудіоданих
                ZigzagAudioLibrary.writeSubChunc2Size(fsSource,BIT_DEPTH, totalSampleCount);
                double elapsedMs = watch.Elapsed.TotalMilliseconds;
                Console.WriteLine("receiving time:" + elapsedMs);
                fsSource.Flush();
               fsSource.Close();
               
            }
            watch.Stop();
          

        }

        private void btnWriteToBt_Click(object sender, EventArgs e)
        {
            byte[] arr = new byte[1];
            arr[0] = 53;
            bluetoothClient.GetStream().Write(arr, 0, 1);
        }
    }
}
