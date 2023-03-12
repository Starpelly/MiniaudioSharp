namespace MiniaudioSharp;

public unsafe partial struct ma_node_output_bus
{
    [NativeTypeName("ma_node *")]
    public void* pNode;

    [NativeTypeName("ma_uint8")]
    public byte outputBusIndex;

    [NativeTypeName("ma_uint8")]
    public byte channels;

    [NativeTypeName("ma_uint8")]
    public byte inputNodeInputBusIndex;

    [NativeTypeName("ma_uint32")]
    public uint flags;

    [NativeTypeName("ma_uint32")]
    public uint refCount;

    [NativeTypeName("ma_bool32")]
    public uint isAttached;

    [NativeTypeName("ma_spinlock")]
    public uint @lock;

    public float volume;

    public ma_node_output_bus* pNext;

    public ma_node_output_bus* pPrev;

    [NativeTypeName("ma_node *")]
    public void* pInputNode;
}
