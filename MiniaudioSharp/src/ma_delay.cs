namespace MiniaudioSharp
{
    public unsafe partial struct ma_delay
    {
        public ma_delay_config config;

        [NativeTypeName("ma_uint32")]
        public uint cursor;

        [NativeTypeName("ma_uint32")]
        public uint bufferSizeInFrames;

        public float* pBuffer;
    }
}
