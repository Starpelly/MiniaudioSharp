namespace MiniaudioSharp;

public unsafe partial struct ma_spatializer_config
{
    [NativeTypeName("ma_uint32")]
    public uint channelsIn;

    [NativeTypeName("ma_uint32")]
    public uint channelsOut;

    [NativeTypeName("ma_channel *")]
    public byte* pChannelMapIn;

    public ma_attenuation_model attenuationModel;

    public ma_positioning positioning;

    public ma_handedness handedness;

    public float minGain;

    public float maxGain;

    public float minDistance;

    public float maxDistance;

    public float rolloff;

    public float coneInnerAngleInRadians;

    public float coneOuterAngleInRadians;

    public float coneOuterGain;

    public float dopplerFactor;

    public float directionalAttenuationFactor;

    [NativeTypeName("ma_uint32")]
    public uint gainSmoothTimeInFrames;
}
