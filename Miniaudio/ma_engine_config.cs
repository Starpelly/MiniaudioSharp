namespace MiniaudioSharp;

public unsafe partial struct ma_engine_config
{
    public ma_resource_manager* pResourceManager;

    public ma_context* pContext;

    public ma_device* pDevice;

    public ma_device_id* pPlaybackDeviceID;

    [NativeTypeName("ma_device_notification_proc")]
    public delegate* unmanaged[Cdecl]<ma_device_notification*, void> notificationCallback;

    public ma_log* pLog;

    [NativeTypeName("ma_uint32")]
    public uint listenerCount;

    [NativeTypeName("ma_uint32")]
    public uint channels;

    [NativeTypeName("ma_uint32")]
    public uint sampleRate;

    [NativeTypeName("ma_uint32")]
    public uint periodSizeInFrames;

    [NativeTypeName("ma_uint32")]
    public uint periodSizeInMilliseconds;

    [NativeTypeName("ma_uint32")]
    public uint gainSmoothTimeInFrames;

    [NativeTypeName("ma_uint32")]
    public uint gainSmoothTimeInMilliseconds;

    public ma_allocation_callbacks allocationCallbacks;

    [NativeTypeName("ma_bool32")]
    public uint noAutoStart;

    [NativeTypeName("ma_bool32")]
    public uint noDevice;

    public ma_mono_expansion_mode monoExpansionMode;

    [NativeTypeName("ma_vfs *")]
    public void* pResourceManagerVFS;
}
