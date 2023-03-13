namespace MiniaudioSharp
{
    public unsafe partial struct ma_paged_audio_buffer_data
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        public ma_paged_audio_buffer_page head;

        public ma_paged_audio_buffer_page* pTail;
    }
}
