namespace MiniaudioSharp
{
    public partial struct ma_splitter_node_config
    {
        public ma_node_config nodeConfig;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint outputBusCount;
    }
}
