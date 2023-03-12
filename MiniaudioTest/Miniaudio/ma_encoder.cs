using System.Runtime.InteropServices;

namespace MiniaudioSharp;

public unsafe partial struct ma_encoder
{
    public ma_encoder_config config;

    [NativeTypeName("ma_encoder_write_proc")]
    public delegate* unmanaged[Cdecl]<ma_encoder*, void*, nuint, nuint*, ma_result> onWrite;

    [NativeTypeName("ma_encoder_seek_proc")]
    public delegate* unmanaged[Cdecl]<ma_encoder*, long, ma_seek_origin, ma_result> onSeek;

    [NativeTypeName("ma_encoder_init_proc")]
    public delegate* unmanaged[Cdecl]<ma_encoder*, ma_result> onInit;

    [NativeTypeName("ma_encoder_uninit_proc")]
    public delegate* unmanaged[Cdecl]<ma_encoder*, void> onUninit;

    [NativeTypeName("ma_encoder_write_pcm_frames_proc")]
    public delegate* unmanaged[Cdecl]<ma_encoder*, void*, ulong, ulong*, ma_result> onWritePCMFrames;

    public void* pUserData;

    public void* pInternalEncoder;

    [NativeTypeName("union (anonymous union at include/miniaudio.h:9840:5)")]
    public _data_e__Union data;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _data_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:9842:9)")]
        public _vfs_e__Struct vfs;

        public unsafe partial struct _vfs_e__Struct
        {
            [NativeTypeName("ma_vfs *")]
            public void* pVFS;

            [NativeTypeName("ma_vfs_file")]
            public void* file;
        }
    }
}
