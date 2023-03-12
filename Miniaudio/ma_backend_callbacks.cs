namespace MiniaudioSharp;

public unsafe partial struct ma_backend_callbacks
{
    [NativeTypeName("ma_result (*)(ma_context *, const ma_context_config *, ma_backend_callbacks *)")]
    public delegate* unmanaged[Cdecl]<ma_context*, ma_context_config*, ma_backend_callbacks*, ma_result> onContextInit;

    [NativeTypeName("ma_result (*)(ma_context *)")]
    public delegate* unmanaged[Cdecl]<ma_context*, ma_result> onContextUninit;

    [NativeTypeName("ma_result (*)(ma_context *, ma_enum_devices_callback_proc, void *)")]
    public delegate* unmanaged[Cdecl]<ma_context*, delegate* unmanaged[Cdecl]<ma_context*, ma_device_type, ma_device_info*, void*, uint>, void*, ma_result> onContextEnumerateDevices;

    [NativeTypeName("ma_result (*)(ma_context *, ma_device_type, const ma_device_id *, ma_device_info *)")]
    public delegate* unmanaged[Cdecl]<ma_context*, ma_device_type, ma_device_id*, ma_device_info*, ma_result> onContextGetDeviceInfo;

    [NativeTypeName("ma_result (*)(ma_device *, const ma_device_config *, ma_device_descriptor *, ma_device_descriptor *)")]
    public delegate* unmanaged[Cdecl]<ma_device*, ma_device_config*, ma_device_descriptor*, ma_device_descriptor*, ma_result> onDeviceInit;

    [NativeTypeName("ma_result (*)(ma_device *)")]
    public delegate* unmanaged[Cdecl]<ma_device*, ma_result> onDeviceUninit;

    [NativeTypeName("ma_result (*)(ma_device *)")]
    public delegate* unmanaged[Cdecl]<ma_device*, ma_result> onDeviceStart;

    [NativeTypeName("ma_result (*)(ma_device *)")]
    public delegate* unmanaged[Cdecl]<ma_device*, ma_result> onDeviceStop;

    [NativeTypeName("ma_result (*)(ma_device *, void *, ma_uint32, ma_uint32 *)")]
    public delegate* unmanaged[Cdecl]<ma_device*, void*, uint, uint*, ma_result> onDeviceRead;

    [NativeTypeName("ma_result (*)(ma_device *, const void *, ma_uint32, ma_uint32 *)")]
    public delegate* unmanaged[Cdecl]<ma_device*, void*, uint, uint*, ma_result> onDeviceWrite;

    [NativeTypeName("ma_result (*)(ma_device *)")]
    public delegate* unmanaged[Cdecl]<ma_device*, ma_result> onDeviceDataLoop;

    [NativeTypeName("ma_result (*)(ma_device *)")]
    public delegate* unmanaged[Cdecl]<ma_device*, ma_result> onDeviceDataLoopWakeup;

    [NativeTypeName("ma_result (*)(ma_device *, ma_device_type, ma_device_info *)")]
    public delegate* unmanaged[Cdecl]<ma_device*, ma_device_type, ma_device_info*, ma_result> onDeviceGetInfo;
}
