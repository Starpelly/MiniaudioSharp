namespace MiniaudioSharp
{
    public partial struct ma_node_graph_config
    {
        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint16")]
        public ushort nodeCacheCapInFrames;
    }
}
