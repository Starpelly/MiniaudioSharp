namespace MiniaudioSharp;

public unsafe partial struct ma_resampling_backend_vtable
{
    [NativeTypeName("ma_result (*)(void *, const ma_resampler_config *, size_t *)")]
    public delegate* unmanaged[Cdecl]<void*, ma_resampler_config*, nuint*, ma_result> onGetHeapSize;

    [NativeTypeName("ma_result (*)(void *, const ma_resampler_config *, void *, ma_resampling_backend **)")]
    public delegate* unmanaged[Cdecl]<void*, ma_resampler_config*, void*, void**, ma_result> onInit;

    [NativeTypeName("void (*)(void *, ma_resampling_backend *, const ma_allocation_callbacks *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, ma_allocation_callbacks*, void> onUninit;

    [NativeTypeName("ma_result (*)(void *, ma_resampling_backend *, const void *, ma_uint64 *, void *, ma_uint64 *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void*, ulong*, void*, ulong*, ma_result> onProcess;

    [NativeTypeName("ma_result (*)(void *, ma_resampling_backend *, ma_uint32, ma_uint32)")]
    public delegate* unmanaged[Cdecl]<void*, void*, uint, uint, ma_result> onSetRate;

    [NativeTypeName("ma_uint64 (*)(void *, const ma_resampling_backend *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, ulong> onGetInputLatency;

    [NativeTypeName("ma_uint64 (*)(void *, const ma_resampling_backend *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, ulong> onGetOutputLatency;

    [NativeTypeName("ma_result (*)(void *, const ma_resampling_backend *, ma_uint64, ma_uint64 *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, ulong, ulong*, ma_result> onGetRequiredInputFrameCount;

    [NativeTypeName("ma_result (*)(void *, const ma_resampling_backend *, ma_uint64, ma_uint64 *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, ulong, ulong*, ma_result> onGetExpectedOutputFrameCount;

    [NativeTypeName("ma_result (*)(void *, ma_resampling_backend *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, ma_result> onReset;
}
