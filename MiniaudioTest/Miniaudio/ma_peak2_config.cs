namespace MiniaudioSharp;

public partial struct ma_peak2_config
{
    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    [NativeTypeName("ma_uint32")]
    public uint sampleRate;

    public double gainDB;

    public double q;

    public double frequency;
}
