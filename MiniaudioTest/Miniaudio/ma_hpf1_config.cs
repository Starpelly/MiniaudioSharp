namespace MiniaudioSharp;

public partial struct ma_hpf1_config
{
    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    [NativeTypeName("ma_uint32")]
    public uint sampleRate;

    public double cutoffFrequency;

    public double q;
}
