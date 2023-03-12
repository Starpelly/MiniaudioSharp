namespace MiniaudioSharp;

public unsafe partial struct ma_sound
{
    public ma_engine_node engineNode;

    [NativeTypeName("ma_data_source *")]
    public void* pDataSource;

    [NativeTypeName("ma_uint64")]
    public ulong seekTarget;

    [NativeTypeName("ma_bool32")]
    public uint atEnd;

    [NativeTypeName("ma_bool8")]
    public byte ownsDataSource;

    public ma_resource_manager_data_source* pResourceManagerDataSource;
}
