namespace MiniaudioSharp
{
    public unsafe partial struct ma_rb
    {
        public void* pBuffer;

        [NativeTypeName("ma_uint32")]
        public uint subbufferSizeInBytes;

        [NativeTypeName("ma_uint32")]
        public uint subbufferCount;

        [NativeTypeName("ma_uint32")]
        public uint subbufferStrideInBytes;

        [NativeTypeName("ma_uint32")]
        public uint encodedReadOffset;

        [NativeTypeName("ma_uint32")]
        public uint encodedWriteOffset;

        [NativeTypeName("ma_bool8")]
        public byte ownsBuffer;

        [NativeTypeName("ma_bool8")]
        public byte clearOnWriteAcquire;

        public ma_allocation_callbacks allocationCallbacks;
    }
}
