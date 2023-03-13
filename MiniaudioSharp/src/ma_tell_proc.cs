using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ma_result ma_tell_proc(void* pUserData, [NativeTypeName("ma_int64 *")] long* pCursor);
}
