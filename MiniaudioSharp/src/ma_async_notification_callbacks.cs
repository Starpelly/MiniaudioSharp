using System;

namespace MiniaudioSharp
{
    public partial struct ma_async_notification_callbacks
    {
        [NativeTypeName("void (*)(ma_async_notification *)")]
        public IntPtr onSignal;
    }
}
