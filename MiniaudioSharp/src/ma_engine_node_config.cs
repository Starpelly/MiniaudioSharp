namespace MiniaudioSharp
{
    public unsafe partial struct ma_engine_node_config
    {
        public ma_engine* pEngine;

        public ma_engine_node_type type;

        [NativeTypeName("ma_uint32")]
        public uint channelsIn;

        [NativeTypeName("ma_uint32")]
        public uint channelsOut;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public ma_mono_expansion_mode monoExpansionMode;

        [NativeTypeName("ma_bool8")]
        public byte isPitchDisabled;

        [NativeTypeName("ma_bool8")]
        public byte isSpatializationDisabled;

        [NativeTypeName("ma_uint8")]
        public byte pinnedListenerIndex;
    }
}
