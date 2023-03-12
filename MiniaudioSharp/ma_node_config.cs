namespace MiniaudioSharp;

public unsafe partial struct ma_node_config
{
    [NativeTypeName("const ma_node_vtable *")]
    public ma_node_vtable* vtable;

    public ma_node_state initialState;

    [NativeTypeName("ma_uint32")]
    public uint inputBusCount;

    [NativeTypeName("ma_uint32")]
    public uint outputBusCount;

    [NativeTypeName("const ma_uint32 *")]
    public uint* pInputChannels;

    [NativeTypeName("const ma_uint32 *")]
    public uint* pOutputChannels;
}
