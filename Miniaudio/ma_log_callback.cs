namespace MiniaudioSharp;

public unsafe partial struct ma_log_callback
{
    [NativeTypeName("ma_log_callback_proc")]
    public delegate* unmanaged[Cdecl]<void*, uint, sbyte*, void> onLog;

    public void* pUserData;
}
