using System;

namespace MiniaudioSharp
{
    public partial struct ma_decoding_backend_vtable
    {
        [NativeTypeName("ma_result (*)(void *, ma_read_proc, ma_seek_proc, ma_tell_proc, void *, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
        public IntPtr onInit;

        [NativeTypeName("ma_result (*)(void *, const char *, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
        public IntPtr onInitFile;

        [NativeTypeName("ma_result (*)(void *, const wchar_t *, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
        public IntPtr onInitFileW;

        [NativeTypeName("ma_result (*)(void *, const void *, size_t, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
        public IntPtr onInitMemory;

        [NativeTypeName("void (*)(void *, ma_data_source *, const ma_allocation_callbacks *)")]
        public IntPtr onUninit;
    }
}
