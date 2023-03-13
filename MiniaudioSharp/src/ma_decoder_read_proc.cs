using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ma_result ma_decoder_read_proc(ma_decoder* pDecoder, void* pBufferOut, [NativeTypeName("size_t")] ulong bytesToRead, [NativeTypeName("size_t *")] ulong* pBytesRead);
}
