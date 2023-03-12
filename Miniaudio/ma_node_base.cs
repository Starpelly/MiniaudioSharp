using System;
using System.Runtime.InteropServices;

namespace MiniaudioSharp;

public unsafe partial struct ma_node_base
{
    public ma_node_graph* pNodeGraph;

    [NativeTypeName("const ma_node_vtable *")]
    public ma_node_vtable* vtable;

    public float* pCachedData;

    [NativeTypeName("ma_uint16")]
    public ushort cachedDataCapInFramesPerBus;

    [NativeTypeName("ma_uint16")]
    public ushort cachedFrameCountOut;

    [NativeTypeName("ma_uint16")]
    public ushort cachedFrameCountIn;

    [NativeTypeName("ma_uint16")]
    public ushort consumedFrameCountIn;

    public ma_node_state state;

    [NativeTypeName("ma_uint64 [2]")]
    public fixed ulong stateTimes[2];

    [NativeTypeName("ma_uint64")]
    public ulong localTime;

    [NativeTypeName("ma_uint32")]
    public uint inputBusCount;

    [NativeTypeName("ma_uint32")]
    public uint outputBusCount;

    public ma_node_input_bus* pInputBuses;

    public ma_node_output_bus* pOutputBuses;

    [NativeTypeName("ma_node_input_bus [2]")]
    public __inputBuses_e__FixedBuffer _inputBuses;

    [NativeTypeName("ma_node_output_bus [2]")]
    public __outputBuses_e__FixedBuffer _outputBuses;

    public void* _pHeap;

    [NativeTypeName("ma_bool32")]
    public uint _ownsHeap;

    public partial struct __inputBuses_e__FixedBuffer
    {
        public ma_node_input_bus e0;
        public ma_node_input_bus e1;

        public ref ma_node_input_bus this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        public Span<ma_node_input_bus> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }

    public partial struct __outputBuses_e__FixedBuffer
    {
        public ma_node_output_bus e0;
        public ma_node_output_bus e1;

        public ref ma_node_output_bus this[int index]
        {
            get
            {
                return ref AsSpan()[index];
            }
        }

        public Span<ma_node_output_bus> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }
}
