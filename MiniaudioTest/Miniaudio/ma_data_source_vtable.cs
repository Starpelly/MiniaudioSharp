namespace MiniaudioSharp;

public unsafe partial struct ma_data_source_vtable
{
    [NativeTypeName("ma_result (*)(ma_data_source *, void *, ma_uint64, ma_uint64 *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, ulong, ulong*, ma_result> onRead;

    [NativeTypeName("ma_result (*)(ma_data_source *, ma_uint64)")]
    public delegate* unmanaged[Cdecl]<void*, ulong, ma_result> onSeek;

    [NativeTypeName("ma_result (*)(ma_data_source *, ma_format *, ma_uint32 *, ma_uint32 *, ma_channel *, size_t)")]
    public delegate* unmanaged[Cdecl]<void*, ma_format*, uint*, uint*, byte*, nuint, ma_result> onGetDataFormat;

    [NativeTypeName("ma_result (*)(ma_data_source *, ma_uint64 *)")]
    public delegate* unmanaged[Cdecl]<void*, ulong*, ma_result> onGetCursor;

    [NativeTypeName("ma_result (*)(ma_data_source *, ma_uint64 *)")]
    public delegate* unmanaged[Cdecl]<void*, ulong*, ma_result> onGetLength;

    [NativeTypeName("ma_result (*)(ma_data_source *, ma_bool32)")]
    public delegate* unmanaged[Cdecl]<void*, uint, ma_result> onSetLooping;

    [NativeTypeName("ma_uint32")]
    public uint flags;
}
