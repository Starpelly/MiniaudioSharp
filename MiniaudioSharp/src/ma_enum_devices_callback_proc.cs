using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("ma_bool32")]
    public unsafe delegate uint ma_enum_devices_callback_proc(ma_context* pContext, ma_device_type deviceType, [NativeTypeName("const ma_device_info *")] ma_device_info* pInfo, void* pUserData);
}
