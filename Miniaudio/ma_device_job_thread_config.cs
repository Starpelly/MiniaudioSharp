namespace MiniaudioSharp;

public partial struct ma_device_job_thread_config
{
    [NativeTypeName("ma_bool32")]
    public uint noThread;

    [NativeTypeName("ma_uint32")]
    public uint jobQueueCapacity;

    [NativeTypeName("ma_uint32")]
    public uint jobQueueFlags;
}
