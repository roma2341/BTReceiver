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
        private volatile bool readActive = false;
        byte[] btReceiverBuffer = new byte[2048];
        private BluetoothClient bluetoothClient;

        public Form1()
        {
            InitializeComponent();
            updateBtAdapters(false);
            initBluetooth();
            disableConnectFunction();
            disableDisconnectFunction();
        }
        private void initStartingUI()
        {
            disableBluetoothFunctions();
            disableIoUI();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="showDebug"></param>
        /// <returns>true if bt adapter finded</returns>
        private bool updateBtAdapters(bool showDebug=true)
        {
            lbInternalBT.Items.Clear();
            disableIoUI();
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
                if (bluetoothClient!=null) { bluetoothClient.Close(); bluetoothClient.Dispose();
                    bluetoothClient = null;
                }
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

        public void disableDisconnectFunction()
        {
            btnDisconnect.Enabled = false;
        }

        public void enableDisconnectFunction()
        {
            btnDisconnect.Enabled = true;
        }

        public void disableUpdateFunction()
        {
            btnUpdate.Enabled = false;
        }

        public void enableUpdateFunction()
        {
            btnUpdate.Enabled = true;
        }

        private void enableBluetoothFunctions()
        {
            btnConnect.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (bluetoothClient == null)
                initBluetooth();
            BluetoothDeviceInfoContainer selectedDevice = (BluetoothDeviceInfoContainer)devicesList.SelectedItem;
            if (selectedDevice == null)
            {
                Console.WriteLine("Cannot connect to null");
                return;
            }
            BluetoothDeviceInfo device = selectedDevice.BluetoothDeviceInfo;
          
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

                this.BeginInvoke(new MethodInvoker(delegate { enableIoUi(); enableDisconnectFunction(); }));          
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

        private void disableReadingToBtUI()
        {
            btnReadFromBt.Enabled = false;
        }
        private void enableReadingToBtUI()
        {
            btnReadFromBt.Enabled = true;
        }

        private void enableIoUi()
        {
            enableWritingToBtUI();
            enableReadingToBtUI();
        }

        private void disableIoUI()
        {
            disableWritingToBtUI();
            disableReadingToBtUI();
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
                    if (!bluetoothClient.Connected)
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

        private void BeginReadDataFromBT(int channelCount, int byteDepth, int samplingRate,String fileName)
        {
            const bool IS_FLOATING_POINT = false;
            int bitDepth = byteDepth*8;
            new Thread(delegate()
            {
                int totalBytesReaded = 0;
                
                var watch = System.Diagnostics.Stopwatch.StartNew();
                using (FileStream fsSource = new FileStream(fileName,
             FileMode.Create, FileAccess.ReadWrite))
                {
                    ZigzagAudioLibrary.WriteWavHeader(fsSource, IS_FLOATING_POINT, channelCount,
                        bitDepth, samplingRate, 0);
                    readActive = true;
                    while (readActive)
                    {
                        try
                        {
                            bool dataAvailable = bluetoothClient.GetStream().DataAvailable;
                            if (!dataAvailable)
                            {
                                Thread.Sleep(50);
                                continue;
                            }
                        }
                        catch (InvalidOperationException e)
                        {
                            this.BeginInvoke(new MethodInvoker(delegate
                            {
                                MessageBox.Show(e.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }));
                            readActive = false;
                        }
                        int readed = 0;
                        try
                        {
                            Console.WriteLine("Read new part started:");
                            readed = bluetoothClient.GetStream().Read(btReceiverBuffer, 0, btReceiverBuffer.Length);
                        }
                        catch (InvalidOperationException e)
                        {
                            this.BeginInvoke(new MethodInvoker(delegate
                            {
                                MessageBox.Show(e.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }));
                            readActive = false;
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
                    double elapsedMs = watch.Elapsed.TotalMilliseconds;
                    int totalSampleCount = totalBytesReaded / bitDepth;
                    Console.WriteLine("totalSampleCount:" + totalSampleCount);
                    //Записуєм розмір сирих аудіоданих
                    ZigzagAudioLibrary.writeSubChunc2Size(fsSource, bitDepth, totalSampleCount);
                    int speedKbPerSec = (int)(totalBytesReaded/elapsedMs);
                    Console.WriteLine("receiving time:" + elapsedMs + " speed:"+ speedKbPerSec + " Kb/s");
                    fsSource.Flush();
                    fsSource.Close();
                    watch.Stop();
                }
            }).Start();
        }

        private void toggleReadButtonMode(bool readMode)
        {
            if (readMode) btnReadFromBt.Text = "Read";
            else btnReadFromBt.Text = "Stop";
        }

        private void btnAskDevice_Click(object sender, EventArgs e)
        {
            if (!readActive)
            {
                int channelCount = 0, byteDepth = 0, samplingRate = 0;
                try
                {
                    channelCount = Int32.Parse(tbChannelsCount.Text);
                    byteDepth = Int32.Parse(tbByteDepth.Text);
                    samplingRate = Int32.Parse(tbSampleRate.Text);
                }
                catch (Exception exc)
                {
                    return;
                }
                BeginReadDataFromBT(channelCount, byteDepth, samplingRate,tbFileName.Text);
                toggleReadButtonMode(false);
            }
            else
            {
                toggleReadButtonMode(true);
                StopReadingBT();
            }
           
        }

        private void StopReadingBT()
        {
            readActive = false;
        }

        private void btnWriteToBt_Click(object sender, EventArgs e)
        {
            string strData = rtbDataToSend.Text;
            byte[] arr = DataParser.parseBytesArray(strData);//53
            try
            {
                bluetoothClient.GetStream().Write(arr,0,arr.Length);
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(exception.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopReadingBT();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            disableDisconnectFunction();
            if (!bluetoothClient.Connected)
            {
                MessageBox.Show("Не можливо розірвати, зєднання не встановлено", "Операція заборонена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bluetoothClient.Close();
            bluetoothClient.Dispose();
            bluetoothClient = null;
            enableConnectFunction();
        }

        private void btnReadRawBytes_Click(object sender, EventArgs e)
        {
            int bytesToReadCount = 0;
            if (tbRawBytesToReadCount.Text.Length == 0) return;
            try
            {
                bytesToReadCount = Int32.Parse(tbRawBytesToReadCount.Text);
            }
            catch (FormatException  exc)
            {
                return;
            }
            if (!readActive)
            {
                int dataToRead = 0;
                try
                {
                    dataToRead = Int32.Parse(tbRawBytesToReadCount.Text);
                }
                catch (Exception exception)
                {
                    
                }
                dataToRead = (dataToRead < btReceiverBuffer.Length) ? dataToRead : btReceiverBuffer.Length;
               int readed = bluetoothClient.GetStream().Read(btReceiverBuffer, 0, dataToRead);
                String receivedData="";
                if (chRepresendDataAsString.Checked)
                {
                    receivedData = System.Text.Encoding.UTF8.GetString(btReceiverBuffer, 0, readed);
                }
                else
                {
                    for (int i = 0; i < readed; i++)
                    {
                        receivedData += btReceiverBuffer[i].ToString()+" ";
                    }
                    
                }

                Console.WriteLine("readed data:"+ receivedData);
                rtbReceivedData.Text = receivedData;
            }
            else
            {
                StopReadingBT();
            }
        }
    }
}
