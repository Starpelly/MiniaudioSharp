using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ma_result ma_decoder_tell_proc(ma_decoder* pDecoder, [NativeTypeName("ma_int64 *")] long* pCursor);
}
