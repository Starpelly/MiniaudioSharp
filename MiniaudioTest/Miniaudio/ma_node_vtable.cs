namespace MiniaudioSharp;

public unsafe partial struct ma_node_vtable
{
    [NativeTypeName("void (*)(ma_node *, const float **, ma_uint32 *, float **, ma_uint32 *)")]
    public delegate* unmanaged[Cdecl]<void*, float**, uint*, float**, uint*, void> onProcess;

    [NativeTypeName("ma_result (*)(ma_node *, ma_uint32, ma_uint32 *)")]
    public delegate* unmanaged[Cdecl]<void*, uint, uint*, ma_result> onGetRequiredInputFrameCount;

    [NativeTypeName("ma_uint8")]
    public byte inputBusCount;

    [NativeTypeName("ma_uint8")]
    public byte outputBusCount;

    [NativeTypeName("ma_uint32")]
    public uint flags;
}
