using System;

namespace MiniaudioSharp
{
    public unsafe partial struct ma_log_callback
    {
        [NativeTypeName("ma_log_callback_proc")]
        public IntPtr onLog;

        public void* pUserData;
    }
}
