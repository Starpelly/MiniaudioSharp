using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ma_result ma_encoder_seek_proc(ma_encoder* pEncoder, [NativeTypeName("ma_int64")] long offset, ma_seek_origin origin);
}
