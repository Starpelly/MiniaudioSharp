namespace MiniaudioSharp;

public unsafe partial struct ma_spatializer_listener_config
{
    [NativeTypeName("ma_uint32")]
    public uint channelsOut;

    [NativeTypeName("ma_channel *")]
    public byte* pChannelMapOut;

    public ma_handedness handedness;

    public float coneInnerAngleInRadians;

    public float coneOuterAngleInRadians;

    public float coneOuterGain;

    public float speedOfSound;

    public ma_vec3f worldUp;
}
