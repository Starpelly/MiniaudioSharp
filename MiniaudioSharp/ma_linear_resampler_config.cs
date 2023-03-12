namespace MiniaudioSharp;

public partial struct ma_linear_resampler_config
{
    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    [NativeTypeName("ma_uint32")]
    public uint sampleRateIn;

    [NativeTypeName("ma_uint32")]
    public uint sampleRateOut;

    [NativeTypeName("ma_uint32")]
    public uint lpfOrder;

    public double lpfNyquistFactor;
}
