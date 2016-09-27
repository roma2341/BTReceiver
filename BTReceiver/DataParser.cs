using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTReceiver
{
    class DataParser
    {
        public static byte[] parseBytesArray(string str)
        {
            string[] splittedStr = str.Split(' ');
            byte[] result = new byte[splittedStr.Length];
            int i = 0;
            foreach (string part in splittedStr)
            {
                bool status = byte.TryParse(part, out result[i++]);
                if (!status) return new byte[0];
            }
            return result;
        }
    }
}
