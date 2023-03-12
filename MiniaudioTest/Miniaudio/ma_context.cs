using System;
using System.Runtime.InteropServices;

namespace MiniaudioSharp;

public unsafe partial struct ma_context
{
    public ma_backend_callbacks callbacks;

    public ma_backend backend;

    public ma_log* pLog;

    public ma_log log;

    public ma_thread_priority threadPriority;

    [NativeTypeName("size_t")]
    public nuint threadStackSize;

    public void* pUserData;

    public ma_allocation_callbacks allocationCallbacks;

    [NativeTypeName("ma_mutex")]
    public void* deviceEnumLock;

    [NativeTypeName("ma_mutex")]
    public void* deviceInfoLock;

    [NativeTypeName("ma_uint32")]
    public uint deviceInfoCapacity;

    [NativeTypeName("ma_uint32")]
    public uint playbackDeviceInfoCount;

    [NativeTypeName("ma_uint32")]
    public uint captureDeviceInfoCount;

    public ma_device_info* pDeviceInfos;

    [NativeTypeName("ma_context::(anonymous union at include/miniaudio.h:6907:5)")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("ma_context::(anonymous union at include/miniaudio.h:7260:5)")]
    public _Anonymous2_e__Union Anonymous2;

    public ref _Anonymous1_e__Union._wasapi_e__Struct wasapi
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.wasapi, 1));
        }
    }

    public ref _Anonymous1_e__Union._dsound_e__Struct dsound
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dsound, 1));
        }
    }

    public ref _Anonymous1_e__Union._winmm_e__Struct winmm
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.winmm, 1));
        }
    }

    public ref _Anonymous1_e__Union._jack_e__Struct jack
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.jack, 1));
        }
    }

    public ref _Anonymous1_e__Union._null_backend_e__Struct null_backend
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.null_backend, 1));
        }
    }

    public ref _Anonymous2_e__Union._win32_e__Struct win32
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.win32, 1));
        }
    }

    public ref int _unused
    {
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2._unused, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:6910:9)")]
        public _wasapi_e__Struct wasapi;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:6926:9)")]
        public _dsound_e__Struct dsound;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:6936:9)")]
        public _winmm_e__Struct winmm;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:7106:9)")]
        public _jack_e__Struct jack;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:7253:9)")]
        public _null_backend_e__Struct null_backend;

        public unsafe partial struct _wasapi_e__Struct
        {
            [NativeTypeName("ma_thread")]
            public void* commandThread;

            [NativeTypeName("ma_mutex")]
            public void* commandLock;

            [NativeTypeName("ma_semaphore")]
            public void* commandSem;

            [NativeTypeName("ma_uint32")]
            public uint commandIndex;

            [NativeTypeName("ma_uint32")]
            public uint commandCount;

            [NativeTypeName("ma_context_command__wasapi [4]")]
            public _commands_e__FixedBuffer commands;

            [NativeTypeName("ma_handle")]
            public void* hAvrt;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> AvSetMmThreadCharacteristicsW;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> AvRevertMmThreadcharacteristics;

            [NativeTypeName("ma_handle")]
            public void* hMMDevapi;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> ActivateAudioInterfaceAsync;

            public partial struct _commands_e__FixedBuffer
            {
                public ma_context_command__wasapi e0;
                public ma_context_command__wasapi e1;
                public ma_context_command__wasapi e2;
                public ma_context_command__wasapi e3;

                public ref ma_context_command__wasapi this[int index]
                {
                    get
                    {
                        return ref AsSpan()[index];
                    }
                }

                public Span<ma_context_command__wasapi> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
            }
        }

        public unsafe partial struct _dsound_e__Struct
        {
            [NativeTypeName("ma_handle")]
            public void* hDSoundDLL;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> DirectSoundCreate;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> DirectSoundEnumerateA;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> DirectSoundCaptureCreate;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> DirectSoundCaptureEnumerateA;
        }

        public unsafe partial struct _winmm_e__Struct
        {
            [NativeTypeName("ma_handle")]
            public void* hWinMM;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveOutGetNumDevs;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveOutGetDevCapsA;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveOutOpen;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveOutClose;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveOutPrepareHeader;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveOutUnprepareHeader;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveOutWrite;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveOutReset;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveInGetNumDevs;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveInGetDevCapsA;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveInOpen;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveInClose;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveInPrepareHeader;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveInUnprepareHeader;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveInAddBuffer;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveInStart;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> waveInReset;
        }

        public unsafe partial struct _jack_e__Struct
        {
            [NativeTypeName("ma_handle")]
            public void* jackSO;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_client_open;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_client_close;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_client_name_size;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_set_process_callback;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_set_buffer_size_callback;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_on_shutdown;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_get_sample_rate;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_get_buffer_size;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_get_ports;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_activate;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_deactivate;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_connect;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_port_register;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_port_name;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_port_get_buffer;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> jack_free;

            [NativeTypeName("char *")]
            public sbyte* pClientName;

            [NativeTypeName("ma_bool32")]
            public uint tryStartServer;
        }

        public partial struct _null_backend_e__Struct
        {
            public int _unused;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at include/miniaudio.h:7263:9)")]
        public _win32_e__Struct win32;

        [FieldOffset(0)]
        public int _unused;

        public unsafe partial struct _win32_e__Struct
        {
            [NativeTypeName("ma_handle")]
            public void* hOle32DLL;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> CoInitializeEx;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> CoUninitialize;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> CoCreateInstance;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> CoTaskMemFree;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> PropVariantClear;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> StringFromGUID2;

            [NativeTypeName("ma_handle")]
            public void* hUser32DLL;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> GetForegroundWindow;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> GetDesktopWindow;

            [NativeTypeName("ma_handle")]
            public void* hAdvapi32DLL;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> RegOpenKeyExA;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> RegCloseKey;

            [NativeTypeName("ma_proc")]
            public delegate* unmanaged[Cdecl]<void> RegQueryValueExA;
        }
    }
}
