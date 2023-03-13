namespace MiniaudioSharp
{
    public unsafe partial struct ma_context_config
    {
        public ma_log* pLog;

        public ma_thread_priority threadPriority;

        [NativeTypeName("size_t")]
        public ulong threadStackSize;

        public void* pUserData;

        public ma_allocation_callbacks allocationCallbacks;

        [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6839:5)")]
        public _alsa_e__Struct alsa;

        [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6843:5)")]
        public _pulse_e__Struct pulse;

        [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6849:5)")]
        public _coreaudio_e__Struct coreaudio;

        [NativeTypeName("struct (anonymous struct at miniaudio/vendor/miniaudio.h:6856:5)")]
        public _jack_e__Struct jack;

        public ma_backend_callbacks custom;

        public partial struct _alsa_e__Struct
        {
            [NativeTypeName("ma_bool32")]
            public uint useVerboseDeviceEnumeration;
        }

        public unsafe partial struct _pulse_e__Struct
        {
            [NativeTypeName("const char *")]
            public sbyte* pApplicationName;

            [NativeTypeName("const char *")]
            public sbyte* pServerName;

            [NativeTypeName("ma_bool32")]
            public uint tryAutoSpawn;
        }

        public partial struct _coreaudio_e__Struct
        {
            public ma_ios_session_category sessionCategory;

            [NativeTypeName("ma_uint32")]
            public uint sessionCategoryOptions;

            [NativeTypeName("ma_bool32")]
            public uint noAudioSessionActivate;

            [NativeTypeName("ma_bool32")]
            public uint noAudioSessionDeactivate;
        }

        public unsafe partial struct _jack_e__Struct
        {
            [NativeTypeName("const char *")]
            public sbyte* pClientName;

            [NativeTypeName("ma_bool32")]
            public uint tryStartServer;
        }
    }
}
