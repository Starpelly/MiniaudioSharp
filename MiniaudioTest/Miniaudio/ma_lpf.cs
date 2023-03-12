namespace MiniaudioSharp;

public unsafe partial struct ma_lpf
{
    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    [NativeTypeName("ma_uint32")]
    public uint sampleRate;

    [NativeTypeName("ma_uint32")]
    public uint lpf1Count;

    [NativeTypeName("ma_uint32")]
    public uint lpf2Count;

    public ma_lpf1* pLPF1;

    public ma_lpf2* pLPF2;

    public void* _pHeap;

    [NativeTypeName("ma_bool32")]
    public uint _ownsHeap;
}
