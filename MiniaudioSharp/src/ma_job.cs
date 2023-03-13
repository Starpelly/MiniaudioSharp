using System;
using System.Runtime.InteropServices;

namespace MiniaudioSharp
{
    public partial struct ma_job
    {
        [NativeTypeName("union (anonymous union at miniaudio/vendor/miniaudio.h:5965:5)")]
        public _toc_e__Union toc;

        [NativeTypeName("ma_uint64")]
        public ulong next;

        [NativeTypeName("ma_uint32")]
        public uint order;

        [NativeTypeName("union (anonymous union at miniaudio/vendor/miniaudio.h:5978:5)")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _toc_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:5967:9)")]
            public _breakup_e__Struct breakup;

            [FieldOffset(0)]
            [NativeTypeName("ma_uint64")]
            public ulong allocation;

            public partial struct _breakup_e__Struct
            {
                [NativeTypeName("ma_uint16")]
                public ushort code;

                [NativeTypeName("ma_uint16")]
                public ushort slot;

                [NativeTypeName("ma_uint32")]
                public uint refcount;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _data_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:5981:9)")]
            public _custom_e__Struct custom;

            [FieldOffset(0)]
            [NativeTypeName("union (anonymous union at miniaudio/vendor/miniaudio.h:5989:9)")]
            public _resourceManager_e__Union resourceManager;

            [FieldOffset(0)]
            [NativeTypeName("union (anonymous union at miniaudio/vendor/miniaudio.h:6067:9)")]
            public _device_e__Union device;

            public partial struct _custom_e__Struct
            {
                [NativeTypeName("ma_job_proc")]
                public IntPtr proc;

                [NativeTypeName("ma_uintptr")]
                public ulong data0;

                [NativeTypeName("ma_uintptr")]
                public ulong data1;
            }

            [StructLayout(LayoutKind.Explicit)]
            public partial struct _resourceManager_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:5991:13)")]
                public _loadDataBufferNode_e__Struct loadDataBufferNode;

                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6003:13)")]
                public _freeDataBufferNode_e__Struct freeDataBufferNode;

                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6010:13)")]
                public _pageDataBufferNode_e__Struct pageDataBufferNode;

                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6019:13)")]
                public _loadDataBuffer_e__Struct loadDataBuffer;

                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6032:13)")]
                public _freeDataBuffer_e__Struct freeDataBuffer;

                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6039:13)")]
                public _loadDataStream_e__Struct loadDataStream;

                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6048:13)")]
                public _freeDataStream_e__Struct freeDataStream;

                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6054:13)")]
                public _pageDataStream_e__Struct pageDataStream;

                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6059:13)")]
                public _seekDataStream_e__Struct seekDataStream;

                public unsafe partial struct _loadDataBufferNode_e__Struct
                {
                    public void* pResourceManager;

                    public void* pDataBufferNode;

                    [NativeTypeName("char *")]
                    public sbyte* pFilePath;

                    [NativeTypeName("wchar_t *")]
                    public ushort* pFilePathW;

                    [NativeTypeName("ma_uint32")]
                    public uint flags;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pInitNotification;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pInitFence;

                    public ma_fence* pDoneFence;
                }

                public unsafe partial struct _freeDataBufferNode_e__Struct
                {
                    public void* pResourceManager;

                    public void* pDataBufferNode;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pDoneFence;
                }

                public unsafe partial struct _pageDataBufferNode_e__Struct
                {
                    public void* pResourceManager;

                    public void* pDataBufferNode;

                    public void* pDecoder;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pDoneFence;
                }

                public unsafe partial struct _loadDataBuffer_e__Struct
                {
                    public void* pDataBuffer;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pInitNotification;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pInitFence;

                    public ma_fence* pDoneFence;

                    [NativeTypeName("ma_uint64")]
                    public ulong rangeBegInPCMFrames;

                    [NativeTypeName("ma_uint64")]
                    public ulong rangeEndInPCMFrames;

                    [NativeTypeName("ma_uint64")]
                    public ulong loopPointBegInPCMFrames;

                    [NativeTypeName("ma_uint64")]
                    public ulong loopPointEndInPCMFrames;

                    [NativeTypeName("ma_uint32")]
                    public uint isLooping;
                }

                public unsafe partial struct _freeDataBuffer_e__Struct
                {
                    public void* pDataBuffer;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pDoneFence;
                }

                public unsafe partial struct _loadDataStream_e__Struct
                {
                    public void* pDataStream;

                    [NativeTypeName("char *")]
                    public sbyte* pFilePath;

                    [NativeTypeName("wchar_t *")]
                    public ushort* pFilePathW;

                    [NativeTypeName("ma_uint64")]
                    public ulong initialSeekPoint;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pInitNotification;

                    public ma_fence* pInitFence;
                }

                public unsafe partial struct _freeDataStream_e__Struct
                {
                    public void* pDataStream;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pDoneFence;
                }

                public unsafe partial struct _pageDataStream_e__Struct
                {
                    public void* pDataStream;

                    [NativeTypeName("ma_uint32")]
                    public uint pageIndex;
                }

                public unsafe partial struct _seekDataStream_e__Struct
                {
                    public void* pDataStream;

                    [NativeTypeName("ma_uint64")]
                    public ulong frameIndex;
                }
            }

            [StructLayout(LayoutKind.Explicit)]
            public partial struct _device_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("union (anonymous union at miniaudio/vendor/miniaudio.h:6069:13)")]
                public _aaudio_e__Union aaudio;

                [StructLayout(LayoutKind.Explicit)]
                public partial struct _aaudio_e__Union
                {
                    [FieldOffset(0)]
                    [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6071:17)")]
                    public _reroute_e__Struct reroute;

                    public unsafe partial struct _reroute_e__Struct
                    {
                        public void* pDevice;

                        [NativeTypeName("ma_uint32")]
                        public uint deviceType;
                    }
                }
            }
        }
    }
}
