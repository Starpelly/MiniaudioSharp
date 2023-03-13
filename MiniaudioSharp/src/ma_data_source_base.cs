using System;

namespace MiniaudioSharp
{
    public unsafe partial struct ma_data_source_base
    {
        [NativeTypeName("const ma_data_source_vtable *")]
        public ma_data_source_vtable* vtable;

        [NativeTypeName("ma_uint64")]
        public ulong rangeBegInFrames;

        [NativeTypeName("ma_uint64")]
        public ulong rangeEndInFrames;

        [NativeTypeName("ma_uint64")]
        public ulong loopBegInFrames;

        [NativeTypeName("ma_uint64")]
        public ulong loopEndInFrames;

        [NativeTypeName("ma_data_source *")]
        public void* pCurrent;

        [NativeTypeName("ma_data_source *")]
        public void* pNext;

        [NativeTypeName("ma_data_source_get_next_proc")]
        public IntPtr onGetNext;

        [NativeTypeName("ma_bool32")]
        public uint isLooping;
    }
}
