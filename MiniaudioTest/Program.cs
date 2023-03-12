using MiniaudioSharp;

using System.Text;

namespace MiniaudioTest
{
    internal unsafe class Program
    {
        static unsafe void Main(string[] args)
        {
            ma_result result;
            ma_decoder decoder;
            ma_decoder* decoderP = &decoder;
            ma_device_config deviceConfig;
            ma_device device;

            var file = @"C:\Users\Braedon\Music\Greippi - Krem Kaakkuja (Second Flight Remix).wav";
            var bytes = Encoding.ASCII.GetBytes(file);
            fixed (byte* buffer = bytes)
            {
                sbyte* sp = (sbyte*)buffer;
                result = Miniaudio.ma_decoder_init_file(sp, null, decoderP);
                if (result != ma_result.MA_SUCCESS)
                {
                    Console.WriteLine("could not load file");
                    return;
                }
                Console.WriteLine("Successfully initialized file!");
            }
            Console.ReadLine();
        }
    }
}