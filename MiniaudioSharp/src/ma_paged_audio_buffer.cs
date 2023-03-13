namespace MiniaudioSharp
{
    public unsafe partial struct ma_paged_audio_buffer
    {
        public ma_data_source_base ds;

        public ma_paged_audio_buffer_data* pData;

        public ma_paged_audio_buffer_page* pCurrent;

        [NativeTypeName("ma_uint64")]
        public ulong relativeCursor;

        [NativeTypeName("ma_uint64")]
        public ulong absoluteCursor;
    }
}
