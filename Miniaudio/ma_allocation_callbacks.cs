namespace MiniaudioSharp;

public unsafe partial struct ma_allocation_callbacks
{
    public void* pUserData;

    [NativeTypeName("void *(*)(size_t, void *)")]
    public delegate* unmanaged[Cdecl]<nuint, void*, void*> onMalloc;

    [NativeTypeName("void *(*)(void *, size_t, void *)")]
    public delegate* unmanaged[Cdecl]<void*, nuint, void*, void*> onRealloc;

    [NativeTypeName("void (*)(void *, void *)")]
    public delegate* unmanaged[Cdecl]<void*, void*, void> onFree;
}
