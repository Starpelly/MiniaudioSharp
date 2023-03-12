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
            ma_engine engine;

            result = Miniaudio.ma_engine_init(null, &engine);
            if (result != ma_result.MA_SUCCESS)
            {
                throw new Exception("Failed to initialize audio engine.");
            }

            var file = @"Resources/mudstep_atomicbeats_old.wav";
            var bytes = Encoding.ASCII.GetBytes(file);
            fixed (byte* buffer = bytes)
            {
                sbyte* sp = (sbyte*)buffer;
                Miniaudio.ma_engine_play_sound(&engine, sp, null);
            }


            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();

            Miniaudio.ma_engine_uninit(&engine);
        }
    }
}