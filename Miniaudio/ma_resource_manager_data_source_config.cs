namespace MiniaudioSharp;

public unsafe partial struct ma_resource_manager_data_source_config
{
    [NativeTypeName("const char *")]
    public sbyte* pFilePath;

    [NativeTypeName("const wchar_t *")]
    public ushort* pFilePathW;

    [NativeTypeName("const ma_resource_manager_pipeline_notifications *")]
    public ma_resource_manager_pipeline_notifications* pNotifications;

    [NativeTypeName("ma_uint64")]
    public ulong initialSeekPointInPCMFrames;

    [NativeTypeName("ma_uint64")]
    public ulong rangeBegInPCMFrames;

    [NativeTypeName("ma_uint64")]
    public ulong rangeEndInPCMFrames;

    [NativeTypeName("ma_uint64")]
    public ulong loopPointBegInPCMFrames;

    [NativeTypeName("ma_uint64")]
    public ulong loopPointEndInPCMFrames;

    [NativeTypeName("ma_bool32")]
    public uint isLooping;

    [NativeTypeName("ma_uint32")]
    public uint flags;
}
