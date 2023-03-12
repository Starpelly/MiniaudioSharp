namespace MiniaudioSharp;

public unsafe partial struct ma_audio_buffer
{
    public ma_audio_buffer_ref @ref;

    public ma_allocation_callbacks allocationCallbacks;

    [NativeTypeName("ma_bool32")]
    public uint ownsData;

    [NativeTypeName("ma_uint8 [1]")]
    public fixed byte _pExtraData[1];
}
