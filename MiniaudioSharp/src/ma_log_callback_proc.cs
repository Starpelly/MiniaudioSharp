using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ma_log_callback_proc(void* pUserData, [NativeTypeName("ma_uint32")] uint level, [NativeTypeName("const char *")] sbyte* pMessage);
}
