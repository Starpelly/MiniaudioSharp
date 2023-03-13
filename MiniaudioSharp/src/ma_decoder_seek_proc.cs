using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ma_result ma_decoder_seek_proc(ma_decoder* pDecoder, [NativeTypeName("ma_int64")] long byteOffset, ma_seek_origin origin);
}
