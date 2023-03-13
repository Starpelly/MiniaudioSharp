namespace MiniaudioSharp
{
    public partial struct ma_notch_node_config
    {
        public ma_node_config nodeConfig;

        [NativeTypeName("ma_notch_config")]
        public ma_notch2_config notch;
    }
}
