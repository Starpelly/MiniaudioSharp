namespace MiniaudioSharp;

public partial struct ma_loshelf_node_config
{
    public ma_node_config nodeConfig;

    [NativeTypeName("ma_loshelf_config")]
    public ma_loshelf2_config loshelf;
}
