namespace MiniaudioSharp
{
    public partial struct ma_biquad_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        public double b0;

        public double b1;

        public double b2;

        public double a0;

        public double a1;

        public double a2;
    }
}
