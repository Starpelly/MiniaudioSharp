using System.Runtime.InteropServices;

namespace MiniaudioSharp;

public unsafe partial struct ma_noise
{
    public ma_data_source_vtable ds;

    public ma_noise_config config;

    public ma_lcg lcg;

    [NativeTypeName("union (anonymous union at include/miniaudio.h:9929:5)")]
    public _state_e__Union state;

    public void* _pHeap;

    [NativeTypeName("ma_bool32")]
    public uint _ownsHeap;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _state_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:9931:9)")]
        public _pink_e__Struct pink;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:9937:9)")]
        public _brownian_e__Struct brownian;

        public unsafe partial struct _pink_e__Struct
        {
            public double** bin;

            public double* accumulation;

            [NativeTypeName("ma_uint32 *")]
            public uint* counter;
        }

        public unsafe partial struct _brownian_e__Struct
        {
            public double* accumulation;
        }
    }
}
