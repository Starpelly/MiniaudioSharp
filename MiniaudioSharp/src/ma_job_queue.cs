namespace MiniaudioSharp
{
    public unsafe partial struct ma_job_queue
    {
        [NativeTypeName("ma_uint32")]
        public uint flags;

        [NativeTypeName("ma_uint32")]
        public uint capacity;

        [NativeTypeName("ma_uint64")]
        public ulong head;

        [NativeTypeName("ma_uint64")]
        public ulong tail;

        [NativeTypeName("ma_semaphore")]
        public void* sem;

        public ma_slot_allocator allocator;

        public ma_job* pJobs;

        [NativeTypeName("ma_spinlock")]
        public uint @lock;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;
    }
}
