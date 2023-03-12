namespace MiniaudioSharp;

public partial struct ma_encoder_config
{
    public ma_encoding_format encodingFormat;

    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    [NativeTypeName("ma_uint32")]
    public uint sampleRate;

    public ma_allocation_callbacks allocationCallbacks;
}
