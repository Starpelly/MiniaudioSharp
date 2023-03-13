namespace MiniaudioSharp
{
    public unsafe partial struct ma_resource_manager_data_buffer_node
    {
        [NativeTypeName("ma_uint32")]
        public uint hashedName32;

        [NativeTypeName("ma_uint32")]
        public uint refCount;

        public ma_result result;

        [NativeTypeName("ma_uint32")]
        public uint executionCounter;

        [NativeTypeName("ma_uint32")]
        public uint executionPointer;

        [NativeTypeName("ma_bool32")]
        public uint isDataOwnedByResourceManager;

        public ma_resource_manager_data_supply data;

        public ma_resource_manager_data_buffer_node* pParent;

        public ma_resource_manager_data_buffer_node* pChildLo;

        public ma_resource_manager_data_buffer_node* pChildHi;
    }
}
