using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand.Net.Sockets;

namespace BTReceiver
{
    [Serializable]
    class BluetoothDeviceInfoContainer
    {
        public BluetoothDeviceInfo BluetoothDeviceInfo { get; set; }

        public override string ToString()
        {
            return BluetoothDeviceInfo.DeviceName;
        }

        public BluetoothDeviceInfoContainer(BluetoothDeviceInfo info)
        {
            this.BluetoothDeviceInfo = info;
        }
    }
}
