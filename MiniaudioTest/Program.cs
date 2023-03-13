using System.Runtime.InteropServices;
using System.Text;

using MiniaudioSharp;

namespace MiniaudioTest
{
    internal unsafe class Program
    {
        public delegate void dataCallback(ma_device* pDevice, void* pOutput, void* pInput, uint frameCount);

        public static unsafe void Main(string[] args)
        {
            ma_result result;
            ma_decoder decoder;
            ma_device_config deviceConfig;
            ma_device device;

            var file = @"Resources/mudstep_atomicbeats_old.wav";
            var bytes = Encoding.ASCII.GetBytes(file);
            fixed (byte* buffer = bytes)
            {
                sbyte* sp = (sbyte*)buffer;
                result =  Miniaudio.ma_decoder_init_file(sp, null, &decoder);
            }


            deviceConfig = Miniaudio.ma_device_config_init(ma_device_type.ma_device_type_playback);
            deviceConfig.playback.format = decoder.outputFormat;
            deviceConfig.playback.channels = decoder.outputChannels;
            deviceConfig.sampleRate = decoder.outputSampleRate;
            deviceConfig.dataCallback = Marshal.GetFunctionPointerForDelegate<dataCallback>(new dataCallback(DataCallback)); ;
            deviceConfig.pUserData = &decoder;

            if (Miniaudio.ma_device_init(null, &deviceConfig, &device) != ma_result.MA_SUCCESS)
            {
                Console.WriteLine("Failed to open playback device.\n");
                Miniaudio.ma_decoder_uninit(&decoder);
                return;
            }

            if (Miniaudio.ma_device_start(&device) != ma_result.MA_SUCCESS)
            {
                Console.WriteLine("Failed to start playback device.\n");
                Miniaudio.ma_device_uninit(&device);
                Miniaudio.ma_decoder_uninit(&decoder);
                return;
            }

            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();

            Miniaudio.ma_device_uninit(&device);
            Miniaudio.ma_decoder_uninit(&decoder);
        }

        static void DataCallback(ma_device* pDevice, void* pOutput, void* pInput, uint frameCount)
        {
            ma_decoder* pDecoder = (ma_decoder*)pDevice->pUserData;
            if (pDecoder == null)
                return;

            Miniaudio.ma_decoder_read_pcm_frames(pDecoder, pOutput, frameCount, null);
        }
    }
}