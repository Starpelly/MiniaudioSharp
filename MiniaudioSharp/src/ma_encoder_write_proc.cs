using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ma_result ma_encoder_write_proc(ma_encoder* pEncoder, [NativeTypeName("const void *")] void* pBufferIn, [NativeTypeName("size_t")] ulong bytesToWrite, [NativeTypeName("size_t *")] ulong* pBytesWritten);
}
