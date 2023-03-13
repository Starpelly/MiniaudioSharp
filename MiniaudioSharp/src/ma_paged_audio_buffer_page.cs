namespace MiniaudioSharp
{
    public unsafe partial struct ma_paged_audio_buffer_page
    {
        public ma_paged_audio_buffer_page* pNext;

        [NativeTypeName("ma_uint64")]
        public ulong sizeInFrames;

        [NativeTypeName("ma_uint8 [1]")]
        public fixed byte pAudioData[1];
    }
}
