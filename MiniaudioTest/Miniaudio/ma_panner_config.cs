namespace MiniaudioSharp;

public partial struct ma_panner_config
{
    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    public ma_pan_mode mode;

    public float pan;
}
