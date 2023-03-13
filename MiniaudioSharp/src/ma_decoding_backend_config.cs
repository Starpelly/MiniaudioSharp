namespace MiniaudioSharp
{
    public partial struct ma_decoding_backend_config
    {
        public ma_format preferredFormat;

        [NativeTypeName("ma_uint32")]
        public uint seekPointCount;
    }
}
