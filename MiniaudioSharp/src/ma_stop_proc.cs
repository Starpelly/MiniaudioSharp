using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ma_stop_proc(ma_device* pDevice);
}
