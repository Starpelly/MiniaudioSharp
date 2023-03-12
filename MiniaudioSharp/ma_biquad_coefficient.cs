using System.Runtime.InteropServices;

namespace MiniaudioSharp;

[StructLayout(LayoutKind.Explicit)]
public partial struct ma_biquad_coefficient
{
    [FieldOffset(0)]
    public float f32;

    [FieldOffset(0)]
    [NativeTypeName("ma_int32")]
    public int s32;
}
