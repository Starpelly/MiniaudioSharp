namespace MiniaudioSharp;

public partial struct ma_gainer_config
{
    [NativeTypeName("ma_uint32")]
    public uint channels;

    [NativeTypeName("ma_uint32")]
    public uint smoothTimeInFrames;
}
