using System;

namespace MiniaudioSharp
{
    public partial struct ma_backend_callbacks
    {
        [NativeTypeName("ma_result (*)(ma_context *, const ma_context_config *, ma_backend_callbacks *)")]
        public IntPtr onContextInit;

        [NativeTypeName("ma_result (*)(ma_context *)")]
        public IntPtr onContextUninit;

        [NativeTypeName("ma_result (*)(ma_context *, ma_enum_devices_callback_proc, void *)")]
        public IntPtr onContextEnumerateDevices;

        [NativeTypeName("ma_result (*)(ma_context *, ma_device_type, const ma_device_id *, ma_device_info *)")]
        public IntPtr onContextGetDeviceInfo;

        [NativeTypeName("ma_result (*)(ma_device *, const ma_device_config *, ma_device_descriptor *, ma_device_descriptor *)")]
        public IntPtr onDeviceInit;

        [NativeTypeName("ma_result (*)(ma_device *)")]
        public IntPtr onDeviceUninit;

        [NativeTypeName("ma_result (*)(ma_device *)")]
        public IntPtr onDeviceStart;

        [NativeTypeName("ma_result (*)(ma_device *)")]
        public IntPtr onDeviceStop;

        [NativeTypeName("ma_result (*)(ma_device *, void *, ma_uint32, ma_uint32 *)")]
        public IntPtr onDeviceRead;

        [NativeTypeName("ma_result (*)(ma_device *, const void *, ma_uint32, ma_uint32 *)")]
        public IntPtr onDeviceWrite;

        [NativeTypeName("ma_result (*)(ma_device *)")]
        public IntPtr onDeviceDataLoop;

        [NativeTypeName("ma_result (*)(ma_device *)")]
        public IntPtr onDeviceDataLoopWakeup;

        [NativeTypeName("ma_result (*)(ma_device *, ma_device_type, ma_device_info *)")]
        public IntPtr onDeviceGetInfo;
    }
}
