namespace MiniaudioSharp;

public unsafe partial struct ma_engine_node
{
    public ma_node_base baseNode;

    public ma_engine* pEngine;

    [NativeTypeName("ma_uint32")]
    public uint sampleRate;

    public ma_mono_expansion_mode monoExpansionMode;

    public ma_fader fader;

    public ma_linear_resampler resampler;

    public ma_spatializer spatializer;

    public ma_panner panner;

    public float pitch;

    public float oldPitch;

    public float oldDopplerPitch;

    [NativeTypeName("ma_bool32")]
    public uint isPitchDisabled;

    [NativeTypeName("ma_bool32")]
    public uint isSpatializationDisabled;

    [NativeTypeName("ma_uint32")]
    public uint pinnedListenerIndex;

    [NativeTypeName("ma_bool8")]
    public byte _ownsHeap;

    public void* _pHeap;
}
