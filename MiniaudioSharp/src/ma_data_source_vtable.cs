using System;

namespace MiniaudioSharp
{
    public partial struct ma_data_source_vtable
    {
        [NativeTypeName("ma_result (*)(ma_data_source *, void *, ma_uint64, ma_uint64 *)")]
        public IntPtr onRead;

        [NativeTypeName("ma_result (*)(ma_data_source *, ma_uint64)")]
        public IntPtr onSeek;

        [NativeTypeName("ma_result (*)(ma_data_source *, ma_format *, ma_uint32 *, ma_uint32 *, ma_channel *, size_t)")]
        public IntPtr onGetDataFormat;

        [NativeTypeName("ma_result (*)(ma_data_source *, ma_uint64 *)")]
        public IntPtr onGetCursor;

        [NativeTypeName("ma_result (*)(ma_data_source *, ma_uint64 *)")]
        public IntPtr onGetLength;

        [NativeTypeName("ma_result (*)(ma_data_source *, ma_bool32)")]
        public IntPtr onSetLooping;

        [NativeTypeName("ma_uint32")]
        public uint flags;
    }
}
