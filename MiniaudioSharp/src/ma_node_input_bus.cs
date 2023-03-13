namespace MiniaudioSharp
{
    public partial struct ma_node_input_bus
    {
        public ma_node_output_bus head;

        [NativeTypeName("ma_uint32")]
        public uint nextCounter;

        [NativeTypeName("ma_spinlock")]
        public uint @lock;

        [NativeTypeName("ma_uint8")]
        public byte channels;
    }
}
