namespace MiniaudioSharp;

public unsafe partial struct ma_hpf1
{
    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    public ma_biquad_coefficient a;

    public ma_biquad_coefficient* pR1;

    public void* _pHeap;

    [NativeTypeName("ma_bool32")]
    public uint _ownsHeap;
}
