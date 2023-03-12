namespace MiniaudioSharp;

public unsafe partial struct ma_data_source_config
{
    [NativeTypeName("const ma_data_source_vtable *")]
    public ma_data_source_vtable* vtable;
}
