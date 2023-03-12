# MiniaudioSharp
Auto generated C# bindings for miniaudio

MiniaudioSharp targets net6.0

## Installation - NuGet
This is the prefered method to get started - The package is still new so please report any [issues](https://github.com/Starpelly/MiniaudioSharp/issues).
```
dotnet add package MiniaudioSharp --version 1.0.1
```

## Example
```cs
using System.Runtime.InteropServices;
using System.Text;

using MiniaudioSharp;

namespace MiniaudioTest
{
    internal unsafe class Program
    {
        public static unsafe void Main(string[] args)
        {
            ma_result result;
            ma_engine engine;

            result = Miniaudio.ma_engine_init(null, &engine);
            if (result != ma_result.MA_SUCCESS)
            {
                throw new Exception("Failed to initialize audio engine.");
            }

            var file = args[0];
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
```
