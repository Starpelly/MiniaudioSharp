namespace MiniaudioSharp
{
    public unsafe partial struct ma_IMMNotificationClient
    {
        public void* lpVtbl;

        [NativeTypeName("ma_uint32")]
        public uint counter;

        public ma_device* pDevice;
    }
}
