namespace MiniaudioSharp;

public partial struct ma_pcm_rb
{
    public ma_rb rb;

    public ma_format format;

    [NativeTypeName("ma_uint32")]
    public uint channels;
}
