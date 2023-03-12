using System.Runtime.InteropServices;
using System.Text;

using MiniaudioSharp;

namespace MiniaudioTest
{
    internal unsafe class Program
    {
        static unsafe void Main(string[] args)
        {
            ma_result result;
            ma_decoder decoder;

            var file = @"C:\Users\Braedon\Music\Greippi - Krem Kaakkuja (Second Flight Remix).wav";
            var bytes = Encoding.ASCII.GetBytes(file);
            fixed (byte* buffer = bytes)
            {
                sbyte* sp = (sbyte*)buffer;

                result = Miniaudio.ma_decoder_init_file(sp, null, &decoder);
                Miniaudio.ma_decoder_uninit(&decoder);

                if (result != ma_result.MA_SUCCESS)
                {
                    Console.WriteLine("could not load file");
                    return;
                }

                Console.WriteLine("Successfully initialized file!");
            }

            var deviceConfig = Miniaudio.ma_device_config_init(ma_device_type.ma_device_type_playback);
            deviceConfig.playback.format = decoder.outputFormat;
            deviceConfig.playback.channels = decoder.outputChannels;
            deviceConfig.sampleRate = decoder.outputSampleRate;
            deviceConfig.dataCallback = DataCallback;
            deviceConfig.pUserData = &decoder;

            Console.ReadLine();
        }

        public static void DataCallback()
        {

        }
    }
}