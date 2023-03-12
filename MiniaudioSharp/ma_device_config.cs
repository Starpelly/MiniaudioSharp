namespace MiniaudioSharp;

public unsafe partial struct ma_device_config
{
    public ma_device_type deviceType;

    [NativeTypeName("ma_uint32")]
    public uint sampleRate;

    [NativeTypeName("ma_uint32")]
    public uint periodSizeInFrames;

    [NativeTypeName("ma_uint32")]
    public uint periodSizeInMilliseconds;

    [NativeTypeName("ma_uint32")]
    public uint periods;

    public ma_performance_profile performanceProfile;

    [NativeTypeName("ma_bool8")]
    public byte noPreSilencedOutputBuffer;

    [NativeTypeName("ma_bool8")]
    public byte noClip;

    [NativeTypeName("ma_bool8")]
    public byte noDisableDenormals;

    [NativeTypeName("ma_bool8")]
    public byte noFixedSizedCallback;

    [NativeTypeName("ma_device_data_proc")]
    public delegate* unmanaged[Cdecl]<ma_device*, void*, void*, uint, void> dataCallback;

    [NativeTypeName("ma_device_notification_proc")]
    public delegate* unmanaged[Cdecl]<ma_device_notification*, void> notificationCallback;

    [NativeTypeName("ma_stop_proc")]
    public delegate* unmanaged[Cdecl]<ma_device*, void> stopCallback;

    public void* pUserData;

    public ma_resampler_config resampling;

    [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6646:5)")]
    public _playback_e__Struct playback;

    [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6656:5)")]
    public _capture_e__Struct capture;

    [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6667:5)")]
    public _wasapi_e__Struct wasapi;

    [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6677:5)")]
    public _alsa_e__Struct alsa;

    [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6684:5)")]
    public _pulse_e__Struct pulse;

    [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6689:5)")]
    public _coreaudio_e__Struct coreaudio;

    [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6693:5)")]
    public _opensl_e__Struct opensl;

    [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6698:5)")]
    public _aaudio_e__Struct aaudio;

    public unsafe partial struct _playback_e__Struct
    {
        [NativeTypeName("const ma_device_id *")]
        public ma_device_id* pDeviceID;

        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_channel *")]
        public byte* pChannelMap;

        public ma_channel_mix_mode channelMixMode;

        [NativeTypeName("ma_bool32")]
        public uint calculateLFEFromSpatialChannels;

        public ma_share_mode shareMode;
    }

    public unsafe partial struct _capture_e__Struct
    {
        [NativeTypeName("const ma_device_id *")]
        public ma_device_id* pDeviceID;

        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_channel *")]
        public byte* pChannelMap;

        public ma_channel_mix_mode channelMixMode;

        [NativeTypeName("ma_bool32")]
        public uint calculateLFEFromSpatialChannels;

        public ma_share_mode shareMode;
    }

    public partial struct _wasapi_e__Struct
    {
        public ma_wasapi_usage usage;

        [NativeTypeName("ma_bool8")]
        public byte noAutoConvertSRC;

        [NativeTypeName("ma_bool8")]
        public byte noDefaultQualitySRC;

        [NativeTypeName("ma_bool8")]
        public byte noAutoStreamRouting;

        [NativeTypeName("ma_bool8")]
        public byte noHardwareOffloading;

        [NativeTypeName("ma_uint32")]
        public uint loopbackProcessID;

        [NativeTypeName("ma_bool8")]
        public byte loopbackProcessExclude;
    }

    public partial struct _alsa_e__Struct
    {
        [NativeTypeName("ma_bool32")]
        public uint noMMap;

        [NativeTypeName("ma_bool32")]
        public uint noAutoFormat;

        [NativeTypeName("ma_bool32")]
        public uint noAutoChannels;

        [NativeTypeName("ma_bool32")]
        public uint noAutoResample;
    }

    public unsafe partial struct _pulse_e__Struct
    {
        [NativeTypeName("const char *")]
        public sbyte* pStreamNamePlayback;

        [NativeTypeName("const char *")]
        public sbyte* pStreamNameCapture;
    }

    public partial struct _coreaudio_e__Struct
    {
        [NativeTypeName("ma_bool32")]
        public uint allowNominalSampleRateChange;
    }

    public partial struct _opensl_e__Struct
    {
        public ma_opensl_stream_type streamType;

        public ma_opensl_recording_preset recordingPreset;
    }

    public partial struct _aaudio_e__Struct
    {
        public ma_aaudio_usage usage;

        public ma_aaudio_content_type contentType;

        public ma_aaudio_input_preset inputPreset;

        [NativeTypeName("ma_bool32")]
        public uint noAutoStartAfterReroute;
    }
}
