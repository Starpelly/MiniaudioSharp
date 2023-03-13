namespace MiniaudioSharp
{
    public unsafe partial struct ma_data_source_node_config
    {
        public ma_node_config nodeConfig;

        [NativeTypeName("ma_data_source *")]
        public void* pDataSource;
    }
}
