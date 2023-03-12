namespace MiniaudioSharp;

public unsafe partial struct ma_audio_buffer_config
{
    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    [NativeTypeName("ma_uint32")]
    public uint sampleRate;

    [NativeTypeName("ma_uint64")]
    public ulong sizeInFrames;

    [NativeTypeName("const void *")]
    public void* pData;

    public ma_allocation_callbacks allocationCallbacks;
}
