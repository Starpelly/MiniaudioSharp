namespace MiniaudioSharp
{
    public unsafe partial struct ma_resource_manager_pipeline_stage_notification
    {
        [NativeTypeName("ma_async_notification *")]
        public void* pNotification;

        public ma_fence* pFence;
    }
}
