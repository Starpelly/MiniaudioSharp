namespace MiniaudioSharp
{
    public unsafe partial struct ma_gainer
    {
        public ma_gainer_config config;

        [NativeTypeName("ma_uint32")]
        public uint t;

        public float* pOldGains;

        public float* pNewGains;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;
    }
}
