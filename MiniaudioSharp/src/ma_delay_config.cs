namespace MiniaudioSharp
{
    public partial struct ma_delay_config
    {
        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_uint32")]
        public uint delayInFrames;

        [NativeTypeName("ma_bool32")]
        public uint delayStart;

        public float wet;

        public float dry;

        public float decay;
    }
}
