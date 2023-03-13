namespace MiniaudioSharp
{
    public unsafe partial struct ma_async_notification_event
    {
        public ma_async_notification_callbacks cb;

        [NativeTypeName("ma_event")]
        public void* e;
    }
}
