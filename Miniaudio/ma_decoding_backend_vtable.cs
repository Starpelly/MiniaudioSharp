namespace MiniaudioSharp;

public unsafe partial struct ma_decoding_backend_vtable
{
    [NativeTypeName("ma_result (*)(void *, ma_read_proc, ma_seek_proc, ma_tell_proc, void *, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
    public delegate* unmanaged[Cdecl]<void*, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint*, ma_result>, delegate* unmanaged[Cdecl]<void*, long, ma_seek_origin, ma_result>, delegate* unmanaged[Cdecl]<void*, long*, ma_result>, void*, ma_decoding_backend_config*, ma_allocation_callbacks*, void**, ma_result> onInit;

    [NativeTypeName("ma_result (*)(void *, const char *, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte*, ma_decoding_backend_config*, ma_allocation_callbacks*, void**, ma_result> onInitFile;

    [NativeTypeName("ma_result (*)(void *, const wchar_t *, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
    public delegate* unmanaged[Cdecl]<void*, ushort*, ma_decoding_backend_config*, ma_allocation_callbacks*, void**, ma_result> onInitFileW;

    [NativeTypeName("ma_result (*)(void *, const void *, size_t, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
    public delegate* unmanaged[Cdecl]<void*, void*, nuint, ma_decoding_backend_config*, ma_allocation_callbacks*, void**, ma_result> onInitMemory;

    [NativeTypeName("void (*)(void *, ma_data_source *, const ma_allocation_callbacks *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, ma_allocation_callbacks*, void> onUninit;
}
