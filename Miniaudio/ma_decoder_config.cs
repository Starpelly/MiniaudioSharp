namespace MiniaudioSharp;

public unsafe partial struct ma_decoder_config
{
    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    [NativeTypeName("ma_uint32")]
    public uint sampleRate;

    [NativeTypeName("ma_channel *")]
    public byte* pChannelMap;

    public ma_channel_mix_mode channelMixMode;

    public ma_dither_mode ditherMode;

    public ma_resampler_config resampling;

    public ma_allocation_callbacks allocationCallbacks;

    public ma_encoding_format encodingFormat;

    [NativeTypeName("ma_uint32")]
    public uint seekPointCount;

    public ma_decoding_backend_vtable** ppCustomBackendVTables;

    [NativeTypeName("ma_uint32")]
    public uint customBackendCount;

    public void* pCustomBackendUserData;
}
