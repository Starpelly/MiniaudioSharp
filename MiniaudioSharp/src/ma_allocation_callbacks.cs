using System;

namespace MiniaudioSharp
{
    public unsafe partial struct ma_allocation_callbacks
    {
        public void* pUserData;

        [NativeTypeName("void *(*)(size_t, void *)")]
        public IntPtr onMalloc;

        [NativeTypeName("void *(*)(void *, size_t, void *)")]
        public IntPtr onRealloc;

        [NativeTypeName("void (*)(void *, void *)")]
        public IntPtr onFree;
    }
}
