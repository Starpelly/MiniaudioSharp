using System.Runtime.InteropServices;

namespace MiniaudioSharp;

public unsafe partial struct ma_resampler
{
    [NativeTypeName("ma_resampling_backend *")]
    public void* pBackend;

    public ma_resampling_backend_vtable* pBackendVTable;

    public void* pBackendUserData;

    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    [NativeTypeName("ma_uint32")]
    public uint sampleRateIn;

    [NativeTypeName("ma_uint32")]
    public uint sampleRateOut;

    [NativeTypeName("union (anonymous union at miniaudio/vendor/miniaudio.h:5179:5)")]
    public _state_e__Union state;

    public void* _pHeap;

    [NativeTypeName("ma_bool32")]
    public uint _ownsHeap;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _state_e__Union
    {
        [FieldOffset(0)]
        public ma_linear_resampler linear;
    }
}
