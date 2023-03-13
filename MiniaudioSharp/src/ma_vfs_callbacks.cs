using System;

namespace MiniaudioSharp
{
    public partial struct ma_vfs_callbacks
    {
        [NativeTypeName("ma_result (*)(ma_vfs *, const char *, ma_uint32, ma_vfs_file *)")]
        public IntPtr onOpen;

        [NativeTypeName("ma_result (*)(ma_vfs *, const wchar_t *, ma_uint32, ma_vfs_file *)")]
        public IntPtr onOpenW;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file)")]
        public IntPtr onClose;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, void *, size_t, size_t *)")]
        public IntPtr onRead;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, const void *, size_t, size_t *)")]
        public IntPtr onWrite;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, ma_int64, ma_seek_origin)")]
        public IntPtr onSeek;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, ma_int64 *)")]
        public IntPtr onTell;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, ma_file_info *)")]
        public IntPtr onInfo;
    }
}
