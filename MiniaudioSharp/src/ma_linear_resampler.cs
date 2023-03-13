using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    public unsafe partial struct ma_linear_resampler
    {
        public ma_linear_resampler_config config;

        [NativeTypeName("ma_uint32")]
        public uint inAdvanceInt;

        [NativeTypeName("ma_uint32")]
        public uint inAdvanceFrac;

        [NativeTypeName("ma_uint32")]
        public uint inTimeInt;

        [NativeTypeName("ma_uint32")]
        public uint inTimeFrac;

        [NativeTypeName("union (anonymous union at miniaudio/vendor/miniaudio.h:5099:5)")]
        public _x0_e__Union x0;

        [NativeTypeName("union (anonymous union at miniaudio/vendor/miniaudio.h:5104:5)")]
        public _x1_e__Union x1;

        public ma_lpf lpf;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _x0_e__Union
        {
            [FieldOffset(0)]
            public float* f32;

            [FieldOffset(0)]
            [NativeTypeName("ma_int16 *")]
            public short* s16;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _x1_e__Union
        {
            [FieldOffset(0)]
            public float* f32;

            [FieldOffset(0)]
            [NativeTypeName("ma_int16 *")]
            public short* s16;
        }
    }
}
