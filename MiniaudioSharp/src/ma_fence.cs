namespace MiniaudioSharp
{
    public unsafe partial struct ma_fence
    {
        [NativeTypeName("ma_event")]
        public void* e;

        [NativeTypeName("ma_uint32")]
        public uint counter;
    }
}
