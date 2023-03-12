namespace MiniaudioSharp;

public partial struct ma_notch2_config
{
    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    [NativeTypeName("ma_uint32")]
    public uint sampleRate;

    public double q;

    public double frequency;
}
