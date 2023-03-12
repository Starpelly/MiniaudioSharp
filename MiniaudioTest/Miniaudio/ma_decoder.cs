using System.Runtime.InteropServices;

namespace MiniaudioSharp;

public unsafe partial struct ma_decoder
{
    public ma_data_source_base ds;

    [NativeTypeName("ma_data_source *")]
    public void* pBackend;

    [NativeTypeName("const ma_decoding_backend_vtable *")]
    public ma_decoding_backend_vtable* pBackendVTable;

    public void* pBackendUserData;

    [NativeTypeName("ma_decoder_read_proc")]
    public delegate* unmanaged[Cdecl]<ma_decoder*, void*, nuint, nuint*, ma_result> onRead;

    [NativeTypeName("ma_decoder_seek_proc")]
    public delegate* unmanaged[Cdecl]<ma_decoder*, long, ma_seek_origin, ma_result> onSeek;

    [NativeTypeName("ma_decoder_tell_proc")]
    public delegate* unmanaged[Cdecl]<ma_decoder*, long*, ma_result> onTell;

    public void* pUserData;

    [NativeTypeName("ma_uint64")]
    public ulong readPointerInPCMFrames;

    public ma_format outputFormat;

    [NativeTypeName("ma_uint32")]
    public uint outputChannels;

    [NativeTypeName("ma_uint32")]
    public uint outputSampleRate;

    public ma_data_converter converter;

    public void* pInputCache;

    [NativeTypeName("ma_uint64")]
    public ulong inputCacheCap;

    [NativeTypeName("ma_uint64")]
    public ulong inputCacheConsumed;

    [NativeTypeName("ma_uint64")]
    public ulong inputCacheRemaining;

    public ma_allocation_callbacks allocationCallbacks;

    [NativeTypeName("union (anonymous union at include/miniaudio.h:9709:5)")]
    public _data_e__Union data;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _data_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:9711:9)")]
        public _vfs_e__Struct vfs;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:9716:9)")]
        public _memory_e__Struct memory;

        public unsafe partial struct _vfs_e__Struct
        {
            [NativeTypeName("ma_vfs *")]
            public void* pVFS;

            [NativeTypeName("ma_vfs_file")]
            public void* file;
        }

        public unsafe partial struct _memory_e__Struct
        {
            [NativeTypeName("const ma_uint8 *")]
            public byte* pData;

            [NativeTypeName("size_t")]
            public nuint dataSize;

            [NativeTypeName("size_t")]
            public nuint currentReadPos;
        }
    }
}
