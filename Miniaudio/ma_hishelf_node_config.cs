namespace MiniaudioSharp;

public partial struct ma_hishelf_node_config
{
    public ma_node_config nodeConfig;

    [NativeTypeName("ma_hishelf_config")]
    public ma_hishelf2_config hishelf;
}
