using System.Runtime.InteropServices;

namespace MiniaudioSharp;

public partial struct ma_resource_manager_data_supply
{
    public ma_resource_manager_data_supply_type type;

    [NativeTypeName("union (anonymous union at include/miniaudio.h:10070:5)")]
    public _backend_e__Union backend;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _backend_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:10072:9)")]
        public _encoded_e__Struct encoded;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:10077:9)")]
        public _decoded_e__Struct decoded;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:10086:9)")]
        public _decodedPaged_e__Struct decodedPaged;

        public unsafe partial struct _encoded_e__Struct
        {
            [NativeTypeName("const void *")]
            public void* pData;

            [NativeTypeName("size_t")]
            public nuint sizeInBytes;
        }

        public unsafe partial struct _decoded_e__Struct
        {
            [NativeTypeName("const void *")]
            public void* pData;

            [NativeTypeName("ma_uint64")]
            public ulong totalFrameCount;

            [NativeTypeName("ma_uint64")]
            public ulong decodedFrameCount;

            public ma_format format;

            [NativeTypeName("ma_uint32")]
            public uint channels;

            [NativeTypeName("ma_uint32")]
            public uint sampleRate;
        }

        public partial struct _decodedPaged_e__Struct
        {
            public ma_paged_audio_buffer_data data;

            [NativeTypeName("ma_uint64")]
            public ulong decodedFrameCount;

            [NativeTypeName("ma_uint32")]
            public uint sampleRate;
        }
    }
}
