using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ma_device_notification_proc([NativeTypeName("const ma_device_notification *")] ma_device_notification* pNotification);
}
