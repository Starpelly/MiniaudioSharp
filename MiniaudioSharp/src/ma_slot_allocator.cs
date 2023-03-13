namespace MiniaudioSharp
{
    public unsafe partial struct ma_slot_allocator
    {
        public ma_slot_allocator_group* pGroups;

        [NativeTypeName("ma_uint32 *")]
        public uint* pSlots;

        [NativeTypeName("ma_uint32")]
        public uint count;

        [NativeTypeName("ma_uint32")]
        public uint capacity;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;

        public void* _pHeap;
    }
}
