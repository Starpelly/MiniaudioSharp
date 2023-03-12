namespace MiniaudioSharp;

public unsafe partial struct ma_vfs_callbacks
{
    [NativeTypeName("ma_result (*)(ma_vfs *, const char *, ma_uint32, ma_vfs_file *)")]
    public delegate* unmanaged[Cdecl]<void*, sbyte*, uint, void**, ma_result> onOpen;

    [NativeTypeName("ma_result (*)(ma_vfs *, const wchar_t *, ma_uint32, ma_vfs_file *)")]
    public delegate* unmanaged[Cdecl]<void*, ushort*, uint, void**, ma_result> onOpenW;

    [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file)")]
    public delegate* unmanaged[Cdecl]<void*, void*, ma_result> onClose;

    [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, void *, size_t, size_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void*, nuint, nuint*, ma_result> onRead;

    [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, const void *, size_t, size_t *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void*, nuint, nuint*, ma_result> onWrite;

    [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, ma_int64, ma_seek_origin)")]
    public delegate* unmanaged[Cdecl]<void*, void*, long, ma_seek_origin, ma_result> onSeek;

    [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, ma_int64 *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, long*, ma_result> onTell;

    [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, ma_file_info *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, ma_file_info*, ma_result> onInfo;
}
