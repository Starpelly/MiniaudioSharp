using System.Runtime.CompilerServices;

namespace MiniaudioSharp
{
    public unsafe partial struct ma_device_info
    {
        public ma_device_id id;

        [NativeTypeName("char [256]")]
        public fixed sbyte name[256];

        [NativeTypeName("ma_bool32")]
        public uint isDefault;

        [NativeTypeName("ma_uint32")]
        public uint nativeDataFormatCount;

        [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6620:5) [64]")]
        public _nativeDataFormats_e__FixedBuffer nativeDataFormats;

        public partial struct _Anonymous_e__Struct
        {
            public ma_format format;

            [NativeTypeName("ma_uint32")]
            public uint channels;

            [NativeTypeName("ma_uint32")]
            public uint sampleRate;

            [NativeTypeName("ma_uint32")]
            public uint flags;
        }

        public partial struct _nativeDataFormats_e__FixedBuffer
        {
            public _Anonymous_e__Struct e0;
            public _Anonymous_e__Struct e1;
            public _Anonymous_e__Struct e2;
            public _Anonymous_e__Struct e3;
            public _Anonymous_e__Struct e4;
            public _Anonymous_e__Struct e5;
            public _Anonymous_e__Struct e6;
            public _Anonymous_e__Struct e7;
            public _Anonymous_e__Struct e8;
            public _Anonymous_e__Struct e9;
            public _Anonymous_e__Struct e10;
            public _Anonymous_e__Struct e11;
            public _Anonymous_e__Struct e12;
            public _Anonymous_e__Struct e13;
            public _Anonymous_e__Struct e14;
            public _Anonymous_e__Struct e15;
            public _Anonymous_e__Struct e16;
            public _Anonymous_e__Struct e17;
            public _Anonymous_e__Struct e18;
            public _Anonymous_e__Struct e19;
            public _Anonymous_e__Struct e20;
            public _Anonymous_e__Struct e21;
            public _Anonymous_e__Struct e22;
            public _Anonymous_e__Struct e23;
            public _Anonymous_e__Struct e24;
            public _Anonymous_e__Struct e25;
            public _Anonymous_e__Struct e26;
            public _Anonymous_e__Struct e27;
            public _Anonymous_e__Struct e28;
            public _Anonymous_e__Struct e29;
            public _Anonymous_e__Struct e30;
            public _Anonymous_e__Struct e31;
            public _Anonymous_e__Struct e32;
            public _Anonymous_e__Struct e33;
            public _Anonymous_e__Struct e34;
            public _Anonymous_e__Struct e35;
            public _Anonymous_e__Struct e36;
            public _Anonymous_e__Struct e37;
            public _Anonymous_e__Struct e38;
            public _Anonymous_e__Struct e39;
            public _Anonymous_e__Struct e40;
            public _Anonymous_e__Struct e41;
            public _Anonymous_e__Struct e42;
            public _Anonymous_e__Struct e43;
            public _Anonymous_e__Struct e44;
            public _Anonymous_e__Struct e45;
            public _Anonymous_e__Struct e46;
            public _Anonymous_e__Struct e47;
            public _Anonymous_e__Struct e48;
            public _Anonymous_e__Struct e49;
            public _Anonymous_e__Struct e50;
            public _Anonymous_e__Struct e51;
            public _Anonymous_e__Struct e52;
            public _Anonymous_e__Struct e53;
            public _Anonymous_e__Struct e54;
            public _Anonymous_e__Struct e55;
            public _Anonymous_e__Struct e56;
            public _Anonymous_e__Struct e57;
            public _Anonymous_e__Struct e58;
            public _Anonymous_e__Struct e59;
            public _Anonymous_e__Struct e60;
            public _Anonymous_e__Struct e61;
            public _Anonymous_e__Struct e62;
            public _Anonymous_e__Struct e63;

            public unsafe ref _Anonymous_e__Struct this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (_Anonymous_e__Struct* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
