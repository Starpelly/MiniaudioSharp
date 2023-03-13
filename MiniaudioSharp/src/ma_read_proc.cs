using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ma_result ma_read_proc(void* pUserData, void* pBufferOut, [NativeTypeName("size_t")] ulong bytesToRead, [NativeTypeName("size_t *")] ulong* pBytesRead);
}
