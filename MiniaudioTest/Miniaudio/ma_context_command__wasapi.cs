using System.Runtime.InteropServices;

namespace MiniaudioSharp;

public unsafe partial struct ma_context_command__wasapi
{
    public int code;

    [NativeTypeName("ma_event *")]
    public void** pEvent;

    [NativeTypeName("union (anonymous union at include/miniaudio.h:6869:5)")]
    public _data_e__Union data;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _data_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:6871:9)")]
        public _quit_e__Struct quit;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:6875:9)")]
        public _createAudioClient_e__Struct createAudioClient;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:6882:9)")]
        public _releaseAudioClient_e__Struct releaseAudioClient;

        public partial struct _quit_e__Struct
        {
            public int _unused;
        }

        public unsafe partial struct _createAudioClient_e__Struct
        {
            public ma_device_type deviceType;

            public void* pAudioClient;

            public void** ppAudioClientService;

            public ma_result* pResult;
        }

        public unsafe partial struct _releaseAudioClient_e__Struct
        {
            public ma_device* pDevice;

            public ma_device_type deviceType;
        }
    }
}
