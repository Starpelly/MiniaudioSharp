using System.Runtime.CompilerServices;

namespace MiniaudioSharp
{
    public unsafe partial struct ma_log
    {
        [NativeTypeName("ma_log_callback [4]")]
        public _callbacks_e__FixedBuffer callbacks;

        [NativeTypeName("ma_uint32")]
        public uint callbackCount;

        public ma_allocation_callbacks allocationCallbacks;

        [NativeTypeName("ma_mutex")]
        public void* @lock;

        public partial struct _callbacks_e__FixedBuffer
        {
            public ma_log_callback e0;
            public ma_log_callback e1;
            public ma_log_callback e2;
            public ma_log_callback e3;

            public unsafe ref ma_log_callback this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (ma_log_callback* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
