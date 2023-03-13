using System;

namespace MiniaudioSharp
{
    public partial struct ma_resampling_backend_vtable
    {
        [NativeTypeName("ma_result (*)(void *, const ma_resampler_config *, size_t *)")]
        public IntPtr onGetHeapSize;

        [NativeTypeName("ma_result (*)(void *, const ma_resampler_config *, void *, ma_resampling_backend **)")]
        public IntPtr onInit;

        [NativeTypeName("void (*)(void *, ma_resampling_backend *, const ma_allocation_callbacks *)")]
        public IntPtr onUninit;

        [NativeTypeName("ma_result (*)(void *, ma_resampling_backend *, const void *, ma_uint64 *, void *, ma_uint64 *)")]
        public IntPtr onProcess;

        [NativeTypeName("ma_result (*)(void *, ma_resampling_backend *, ma_uint32, ma_uint32)")]
        public IntPtr onSetRate;

        [NativeTypeName("ma_uint64 (*)(void *, const ma_resampling_backend *)")]
        public IntPtr onGetInputLatency;

        [NativeTypeName("ma_uint64 (*)(void *, const ma_resampling_backend *)")]
        public IntPtr onGetOutputLatency;

        [NativeTypeName("ma_result (*)(void *, const ma_resampling_backend *, ma_uint64, ma_uint64 *)")]
        public IntPtr onGetRequiredInputFrameCount;

        [NativeTypeName("ma_result (*)(void *, const ma_resampling_backend *, ma_uint64, ma_uint64 *)")]
        public IntPtr onGetExpectedOutputFrameCount;

        [NativeTypeName("ma_result (*)(void *, ma_resampling_backend *)")]
        public IntPtr onReset;
    }
}
