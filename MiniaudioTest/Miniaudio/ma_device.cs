using System.Runtime.InteropServices;

namespace MiniaudioSharp;

public unsafe partial struct ma_device
{
    public ma_context* pContext;

    public ma_device_type type;

    [NativeTypeName("ma_uint32")]
    public uint sampleRate;

    public ma_device_state state;

    [NativeTypeName("ma_device_data_proc")]
    public delegate* unmanaged[Cdecl]<ma_device*, void*, void*, uint, void> onData;

    [NativeTypeName("ma_device_notification_proc")]
    public delegate* unmanaged[Cdecl]<ma_device_notification*, void> onNotification;

    [NativeTypeName("ma_stop_proc")]
    public delegate* unmanaged[Cdecl]<ma_device*, void> onStop;

    public void* pUserData;

    [NativeTypeName("ma_mutex")]
    public void* startStopLock;

    [NativeTypeName("ma_event")]
    public void* wakeupEvent;

    [NativeTypeName("ma_event")]
    public void* startEvent;

    [NativeTypeName("ma_event")]
    public void* stopEvent;

    [NativeTypeName("ma_thread")]
    public void* thread;

    public ma_result workResult;

    [NativeTypeName("ma_bool8")]
    public byte isOwnerOfContext;

    [NativeTypeName("ma_bool8")]
    public byte noPreSilencedOutputBuffer;

    [NativeTypeName("ma_bool8")]
    public byte noClip;

    [NativeTypeName("ma_bool8")]
    public byte noDisableDenormals;

    [NativeTypeName("ma_bool8")]
    public byte noFixedSizedCallback;

    public float masterVolumeFactor;

    public ma_duplex_rb duplexRB;

    [NativeTypeName("struct (anonymous struct at miniaudio/src/miniaudio.h:7331:5)")]
    public _resampling_e__Struct resampling;

    [NativeTypeName("struct (anonymous struct at miniaudio/src/miniaudio.h:7341:5)")]
    public _playback_e__Struct playback;

    [NativeTypeName("struct (anonymous struct at miniaudio/src/miniaudio.h:7367:5)")]
    public _capture_e__Struct capture;

    [NativeTypeName("ma_device::(anonymous union at miniaudio/src/miniaudio.h:7390:5)")]
    public _Anonymous_e__Union Anonymous;

    public ref _Anonymous_e__Union._wasapi_e__Struct wasapi
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.wasapi, 1));
        }
    }

    public ref _Anonymous_e__Union._dsound_e__Struct dsound
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dsound, 1));
        }
    }

    public ref _Anonymous_e__Union._winmm_e__Struct winmm
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.winmm, 1));
        }
    }

    public ref _Anonymous_e__Union._jack_e__Struct jack
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.jack, 1));
        }
    }

    public ref _Anonymous_e__Union._null_device_e__Struct null_device
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.null_device, 1));
        }
    }

    public unsafe partial struct _resampling_e__Struct
    {
        public ma_resample_algorithm algorithm;

        public ma_resampling_backend_vtable* pBackendVTable;

        public void* pBackendUserData;

        [NativeTypeName("struct (anonymous struct at miniaudio/src/miniaudio.h:7336:9)")]
        public _linear_e__Struct linear;

        public partial struct _linear_e__Struct
        {
            [NativeTypeName("ma_uint32")]
            public uint lpfOrder;
        }
    }

    public unsafe partial struct _playback_e__Struct
    {
        public ma_device_id* pID;

        public ma_device_id id;

        [NativeTypeName("char [256]")]
        public fixed sbyte name[256];

        public ma_share_mode shareMode;

        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_channel [254]")]
        public fixed byte channelMap[254];

        public ma_format internalFormat;

        [NativeTypeName("ma_uint32")]
        public uint internalChannels;

        [NativeTypeName("ma_uint32")]
        public uint internalSampleRate;

        [NativeTypeName("ma_channel [254]")]
        public fixed byte internalChannelMap[254];

        [NativeTypeName("ma_uint32")]
        public uint internalPeriodSizeInFrames;

        [NativeTypeName("ma_uint32")]
        public uint internalPeriods;

        public ma_channel_mix_mode channelMixMode;

        [NativeTypeName("ma_bool32")]
        public uint calculateLFEFromSpatialChannels;

        public ma_data_converter converter;

        public void* pIntermediaryBuffer;

        [NativeTypeName("ma_uint32")]
        public uint intermediaryBufferCap;

        [NativeTypeName("ma_uint32")]
        public uint intermediaryBufferLen;

        public void* pInputCache;

        [NativeTypeName("ma_uint64")]
        public ulong inputCacheCap;

        [NativeTypeName("ma_uint64")]
        public ulong inputCacheConsumed;

        [NativeTypeName("ma_uint64")]
        public ulong inputCacheRemaining;
    }

    public unsafe partial struct _capture_e__Struct
    {
        public ma_device_id* pID;

        public ma_device_id id;

        [NativeTypeName("char [256]")]
        public fixed sbyte name[256];

        public ma_share_mode shareMode;

        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_channel [254]")]
        public fixed byte channelMap[254];

        public ma_format internalFormat;

        [NativeTypeName("ma_uint32")]
        public uint internalChannels;

        [NativeTypeName("ma_uint32")]
        public uint internalSampleRate;

        [NativeTypeName("ma_channel [254]")]
        public fixed byte internalChannelMap[254];

        [NativeTypeName("ma_uint32")]
        public uint internalPeriodSizeInFrames;

        [NativeTypeName("ma_uint32")]
        public uint internalPeriods;

        public ma_channel_mix_mode channelMixMode;

        [NativeTypeName("ma_bool32")]
        public uint calculateLFEFromSpatialChannels;

        public ma_data_converter converter;

        public void* pIntermediaryBuffer;

        [NativeTypeName("ma_uint32")]
        public uint intermediaryBufferCap;

        [NativeTypeName("ma_uint32")]
        public uint intermediaryBufferLen;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at miniaudio/src/miniaudio.h:7393:9)")]
        public _wasapi_e__Struct wasapi;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at miniaudio/src/miniaudio.h:7433:9)")]
        public _dsound_e__Struct dsound;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at miniaudio/src/miniaudio.h:7443:9)")]
        public _winmm_e__Struct winmm;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at miniaudio/src/miniaudio.h:7486:9)")]
        public _jack_e__Struct jack;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at miniaudio/src/miniaudio.h:7577:9)")]
        public _null_device_e__Struct null_device;

        public unsafe partial struct _wasapi_e__Struct
        {
            [NativeTypeName("ma_ptr")]
            public void* pAudioClientPlayback;

            [NativeTypeName("ma_ptr")]
            public void* pAudioClientCapture;

            [NativeTypeName("ma_ptr")]
            public void* pRenderClient;

            [NativeTypeName("ma_ptr")]
            public void* pCaptureClient;

            [NativeTypeName("ma_ptr")]
            public void* pDeviceEnumerator;

            public ma_IMMNotificationClient notificationClient;

            [NativeTypeName("ma_handle")]
            public void* hEventPlayback;

            [NativeTypeName("ma_handle")]
            public void* hEventCapture;

            [NativeTypeName("ma_uint32")]
            public uint actualBufferSizeInFramesPlayback;

            [NativeTypeName("ma_uint32")]
            public uint actualBufferSizeInFramesCapture;

            [NativeTypeName("ma_uint32")]
            public uint originalPeriodSizeInFrames;

            [NativeTypeName("ma_uint32")]
            public uint originalPeriodSizeInMilliseconds;

            [NativeTypeName("ma_uint32")]
            public uint originalPeriods;

            public ma_performance_profile originalPerformanceProfile;

            [NativeTypeName("ma_uint32")]
            public uint periodSizeInFramesPlayback;

            [NativeTypeName("ma_uint32")]
            public uint periodSizeInFramesCapture;

            public void* pMappedBufferCapture;

            [NativeTypeName("ma_uint32")]
            public uint mappedBufferCaptureCap;

            [NativeTypeName("ma_uint32")]
            public uint mappedBufferCaptureLen;

            public void* pMappedBufferPlayback;

            [NativeTypeName("ma_uint32")]
            public uint mappedBufferPlaybackCap;

            [NativeTypeName("ma_uint32")]
            public uint mappedBufferPlaybackLen;

            [NativeTypeName("ma_bool32")]
            public uint isStartedCapture;

            [NativeTypeName("ma_bool32")]
            public uint isStartedPlayback;

            [NativeTypeName("ma_uint32")]
            public uint loopbackProcessID;

            [NativeTypeName("ma_bool8")]
            public byte loopbackProcessExclude;

            [NativeTypeName("ma_bool8")]
            public byte noAutoConvertSRC;

            [NativeTypeName("ma_bool8")]
            public byte noDefaultQualitySRC;

            [NativeTypeName("ma_bool8")]
            public byte noHardwareOffloading;

            [NativeTypeName("ma_bool8")]
            public byte allowCaptureAutoStreamRouting;

            [NativeTypeName("ma_bool8")]
            public byte allowPlaybackAutoStreamRouting;

            [NativeTypeName("ma_bool8")]
            public byte isDetachedPlayback;

            [NativeTypeName("ma_bool8")]
            public byte isDetachedCapture;

            public ma_wasapi_usage usage;

            public void* hAvrtHandle;
        }

        public unsafe partial struct _dsound_e__Struct
        {
            [NativeTypeName("ma_ptr")]
            public void* pPlayback;

            [NativeTypeName("ma_ptr")]
            public void* pPlaybackPrimaryBuffer;

            [NativeTypeName("ma_ptr")]
            public void* pPlaybackBuffer;

            [NativeTypeName("ma_ptr")]
            public void* pCapture;

            [NativeTypeName("ma_ptr")]
            public void* pCaptureBuffer;
        }

        public unsafe partial struct _winmm_e__Struct
        {
            [NativeTypeName("ma_handle")]
            public void* hDevicePlayback;

            [NativeTypeName("ma_handle")]
            public void* hDeviceCapture;

            [NativeTypeName("ma_handle")]
            public void* hEventPlayback;

            [NativeTypeName("ma_handle")]
            public void* hEventCapture;

            [NativeTypeName("ma_uint32")]
            public uint fragmentSizeInFrames;

            [NativeTypeName("ma_uint32")]
            public uint iNextHeaderPlayback;

            [NativeTypeName("ma_uint32")]
            public uint iNextHeaderCapture;

            [NativeTypeName("ma_uint32")]
            public uint headerFramesConsumedPlayback;

            [NativeTypeName("ma_uint32")]
            public uint headerFramesConsumedCapture;

            [NativeTypeName("ma_uint8 *")]
            public byte* pWAVEHDRPlayback;

            [NativeTypeName("ma_uint8 *")]
            public byte* pWAVEHDRCapture;

            [NativeTypeName("ma_uint8 *")]
            public byte* pIntermediaryBufferPlayback;

            [NativeTypeName("ma_uint8 *")]
            public byte* pIntermediaryBufferCapture;

            [NativeTypeName("ma_uint8 *")]
            public byte* _pHeapData;
        }

        public unsafe partial struct _jack_e__Struct
        {
            [NativeTypeName("ma_ptr")]
            public void* pClient;

            [NativeTypeName("ma_ptr *")]
            public void** ppPortsPlayback;

            [NativeTypeName("ma_ptr *")]
            public void** ppPortsCapture;

            public float* pIntermediaryBufferPlayback;

            public float* pIntermediaryBufferCapture;
        }

        public unsafe partial struct _null_device_e__Struct
        {
            [NativeTypeName("ma_thread")]
            public void* deviceThread;

            [NativeTypeName("ma_event")]
            public void* operationEvent;

            [NativeTypeName("ma_event")]
            public void* operationCompletionEvent;

            [NativeTypeName("ma_semaphore")]
            public void* operationSemaphore;

            [NativeTypeName("ma_uint32")]
            public uint operation;

            public ma_result operationResult;

            public ma_timer timer;

            public double priorRunTime;

            [NativeTypeName("ma_uint32")]
            public uint currentPeriodFramesRemainingPlayback;

            [NativeTypeName("ma_uint32")]
            public uint currentPeriodFramesRemainingCapture;

            [NativeTypeName("ma_uint64")]
            public ulong lastProcessedFramePlayback;

            [NativeTypeName("ma_uint64")]
            public ulong lastProcessedFrameCapture;

            [NativeTypeName("ma_bool32")]
            public uint isStarted;
        }
    }
}
