using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTReceiver
{
    class ZigzagAudioLibrary
    {
        
        // totalSampleCount needs to be the combined count of samples of all channels. So if the left and right channels contain 1000 samples each, then totalSampleCount should be 2000.
        // isFloatingPoint should only be true if the audio data is in 32-bit floating-point format.
        public static void writeSubChunc2Size(FileStream fsSource, int bitDepth, int totalSampleCount,bool returnToHeader = true)
        {
            long position = fsSource.Position;
            if (returnToHeader) { 
            fsSource.Position = 40;//Write data size;
            }
            fsSource.Write(BitConverter.GetBytes((bitDepth / 8) * totalSampleCount), 0, 4);
            if (returnToHeader)
            {
                fsSource.Position = position;
            }
        }
        public static void WriteWavHeader(FileStream stream, bool isFloatingPoint, ushort channelCount, ushort bitDepth, int sampleRate, int totalSampleCount)
        {
            stream.Position = 0;

            // RIFF header.
            // Chunk ID.
            stream.Write(Encoding.ASCII.GetBytes("RIFF"), 0, 4); //4 bytes

            // Chunk size.
            stream.Write(BitConverter.GetBytes(((bitDepth / 8) * totalSampleCount) + 36), 0, 4);//8 bytes

            // Format.
            stream.Write(Encoding.ASCII.GetBytes("WAVE"), 0, 4);//12 bytes



            // Sub-chunk 1.
            // Sub-chunk 1 ID.
            stream.Write(Encoding.ASCII.GetBytes("fmt "), 0, 4);//16 bytes

            // Sub-chunk 1 size.
            stream.Write(BitConverter.GetBytes(16), 0, 4); //20 bytes

            // Audio format (floating point (3) or PCM (1)). Any other format indicates compression.
            stream.Write(BitConverter.GetBytes((ushort)(isFloatingPoint ? 3 : 1)), 0, 2);//22 bytes

            // Channels.
            stream.Write(BitConverter.GetBytes(channelCount), 0, 2);//24 bytes

            // Sample rate.
            stream.Write(BitConverter.GetBytes(sampleRate), 0, 4);//28 bytes

            // Bytes rate.
            stream.Write(BitConverter.GetBytes(sampleRate * channelCount * (bitDepth / 8)), 0, 4);//32 bytes

            // Block align.
            stream.Write(BitConverter.GetBytes((ushort)channelCount * (bitDepth / 8)), 0, 2);//34 bytes

            // Bits per sample.
            stream.Write(BitConverter.GetBytes(bitDepth), 0, 2);//36 bytes



            // Sub-chunk 2.
            // Sub-chunk 2 ID.
            byte[] data = Encoding.ASCII.GetBytes("data");
            stream.Write(data, 0, 4);

            // Sub-chunk 2 size. (raw sound data size)
            writeSubChunc2Size(stream, bitDepth, totalSampleCount, false);
            //stream.Write(BitConverter.GetBytes((bitDepth / 8) * totalSampleCount), 0, 4);
        }
    }
}
