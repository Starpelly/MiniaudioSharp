using System.Runtime.InteropServices;

namespace MiniaudioSharp;

public partial struct ma_resource_manager_data_source
{
    [NativeTypeName("union (anonymous union at miniaudio/vendor/miniaudio.h:10160:5)")]
    public _backend_e__Union backend;

    [NativeTypeName("ma_uint32")]
    public uint flags;

    [NativeTypeName("ma_uint32")]
    public uint executionCounter;

    [NativeTypeName("ma_uint32")]
    public uint executionPointer;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _backend_e__Union
    {
        [FieldOffset(0)]
        public ma_resource_manager_data_buffer buffer;

        [FieldOffset(0)]
        public ma_resource_manager_data_stream stream;
    }
}
