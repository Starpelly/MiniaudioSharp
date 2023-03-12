using System.Runtime.InteropServices;

namespace MiniaudioSharp;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct ma_device_id
{
    [FieldOffset(0)]
    [NativeTypeName("wchar_t [64]")]
    public fixed ushort wasapi[64];

    [FieldOffset(0)]
    [NativeTypeName("ma_uint8 [16]")]
    public fixed byte dsound[16];

    [FieldOffset(0)]
    [NativeTypeName("ma_uint32")]
    public uint winmm;

    [FieldOffset(0)]
    [NativeTypeName("char [256]")]
    public fixed sbyte alsa[256];

    [FieldOffset(0)]
    [NativeTypeName("char [256]")]
    public fixed sbyte pulse[256];

    [FieldOffset(0)]
    public int jack;

    [FieldOffset(0)]
    [NativeTypeName("char [256]")]
    public fixed sbyte coreaudio[256];

    [FieldOffset(0)]
    [NativeTypeName("char [256]")]
    public fixed sbyte sndio[256];

    [FieldOffset(0)]
    [NativeTypeName("char [256]")]
    public fixed sbyte audio4[256];

    [FieldOffset(0)]
    [NativeTypeName("char [64]")]
    public fixed sbyte oss[64];

    [FieldOffset(0)]
    [NativeTypeName("ma_int32")]
    public int aaudio;

    [FieldOffset(0)]
    [NativeTypeName("ma_uint32")]
    public uint opensl;

    [FieldOffset(0)]
    [NativeTypeName("char [32]")]
    public fixed sbyte webaudio[32];

    [FieldOffset(0)]
    [NativeTypeName("union (anonymous union at include/miniaudio.h:6592:5)")]
    public _custom_e__Union custom;

    [FieldOffset(0)]
    public int nullbackend;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _custom_e__Union
    {
        [FieldOffset(0)]
        public int i;

        [FieldOffset(0)]
        [NativeTypeName("char [256]")]
        public fixed sbyte s[256];

        [FieldOffset(0)]
        public void* p;
    }
}
