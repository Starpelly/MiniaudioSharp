namespace MiniaudioSharp
{
    public partial struct ma_node_graph
    {
        public ma_node_base @base;

        public ma_node_base endpoint;

        [NativeTypeName("ma_uint16")]
        public ushort nodeCacheCapInFrames;

        [NativeTypeName("ma_bool32")]
        public uint isReading;
    }
}
