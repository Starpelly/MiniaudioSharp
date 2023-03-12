using System.Runtime.InteropServices;
using static MiniaudioSharp.ma_format;

namespace MiniaudioSharp;

public static unsafe partial class Miniaudio
{
    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_version([NativeTypeName("ma_uint32 *")] uint* pMajor, [NativeTypeName("ma_uint32 *")] uint* pMinor, [NativeTypeName("ma_uint32 *")] uint* pRevision);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ma_version_string();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_log_callback ma_log_callback_init([NativeTypeName("ma_log_callback_proc")] delegate* unmanaged[Cdecl]<void*, uint, sbyte*, void> onLog, void* pUserData);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_log_init([NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_log* pLog);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_log_uninit(ma_log* pLog);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_log_register_callback(ma_log* pLog, ma_log_callback callback);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_log_unregister_callback(ma_log* pLog, ma_log_callback callback);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_log_post(ma_log* pLog, [NativeTypeName("ma_uint32")] uint level, [NativeTypeName("const char *")] sbyte* pMessage);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_log_postv(ma_log* pLog, [NativeTypeName("ma_uint32")] uint level, [NativeTypeName("const char *")] sbyte* pFormat, [NativeTypeName("va_list")] sbyte* args);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_log_postf(ma_log* pLog, [NativeTypeName("ma_uint32")] uint level, [NativeTypeName("const char *")] sbyte* pFormat);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_biquad_config ma_biquad_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, double b0, double b1, double b2, double a0, double a1, double a2);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_biquad_get_heap_size([NativeTypeName("const ma_biquad_config *")] ma_biquad_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_biquad_init_preallocated([NativeTypeName("const ma_biquad_config *")] ma_biquad_config* pConfig, void* pHeap, ma_biquad* pBQ);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_biquad_init([NativeTypeName("const ma_biquad_config *")] ma_biquad_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_biquad* pBQ);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_biquad_uninit(ma_biquad* pBQ, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_biquad_reinit([NativeTypeName("const ma_biquad_config *")] ma_biquad_config* pConfig, ma_biquad* pBQ);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_biquad_clear_cache(ma_biquad* pBQ);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_biquad_process_pcm_frames(ma_biquad* pBQ, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_biquad_get_latency([NativeTypeName("const ma_biquad *")] ma_biquad* pBQ);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_lpf1_config ma_lpf1_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_lpf2_config")]
    public static extern ma_lpf1_config ma_lpf2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, double q);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf1_get_heap_size([NativeTypeName("const ma_lpf1_config *")] ma_lpf1_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf1_init_preallocated([NativeTypeName("const ma_lpf1_config *")] ma_lpf1_config* pConfig, void* pHeap, ma_lpf1* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf1_init([NativeTypeName("const ma_lpf1_config *")] ma_lpf1_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_lpf1* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_lpf1_uninit(ma_lpf1* pLPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf1_reinit([NativeTypeName("const ma_lpf1_config *")] ma_lpf1_config* pConfig, ma_lpf1* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf1_clear_cache(ma_lpf1* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf1_process_pcm_frames(ma_lpf1* pLPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_lpf1_get_latency([NativeTypeName("const ma_lpf1 *")] ma_lpf1* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf2_get_heap_size([NativeTypeName("const ma_lpf2_config *")] ma_lpf1_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf2_init_preallocated([NativeTypeName("const ma_lpf2_config *")] ma_lpf1_config* pConfig, void* pHeap, ma_lpf2* pHPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf2_init([NativeTypeName("const ma_lpf2_config *")] ma_lpf1_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_lpf2* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_lpf2_uninit(ma_lpf2* pLPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf2_reinit([NativeTypeName("const ma_lpf2_config *")] ma_lpf1_config* pConfig, ma_lpf2* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf2_clear_cache(ma_lpf2* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf2_process_pcm_frames(ma_lpf2* pLPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_lpf2_get_latency([NativeTypeName("const ma_lpf2 *")] ma_lpf2* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_lpf_config ma_lpf_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf_get_heap_size([NativeTypeName("const ma_lpf_config *")] ma_lpf_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf_init_preallocated([NativeTypeName("const ma_lpf_config *")] ma_lpf_config* pConfig, void* pHeap, ma_lpf* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf_init([NativeTypeName("const ma_lpf_config *")] ma_lpf_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_lpf* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_lpf_uninit(ma_lpf* pLPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf_reinit([NativeTypeName("const ma_lpf_config *")] ma_lpf_config* pConfig, ma_lpf* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf_clear_cache(ma_lpf* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf_process_pcm_frames(ma_lpf* pLPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_lpf_get_latency([NativeTypeName("const ma_lpf *")] ma_lpf* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_hpf1_config ma_hpf1_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_hpf2_config")]
    public static extern ma_hpf1_config ma_hpf2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, double q);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf1_get_heap_size([NativeTypeName("const ma_hpf1_config *")] ma_hpf1_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf1_init_preallocated([NativeTypeName("const ma_hpf1_config *")] ma_hpf1_config* pConfig, void* pHeap, ma_hpf1* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf1_init([NativeTypeName("const ma_hpf1_config *")] ma_hpf1_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hpf1* pHPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_hpf1_uninit(ma_hpf1* pHPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf1_reinit([NativeTypeName("const ma_hpf1_config *")] ma_hpf1_config* pConfig, ma_hpf1* pHPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf1_process_pcm_frames(ma_hpf1* pHPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_hpf1_get_latency([NativeTypeName("const ma_hpf1 *")] ma_hpf1* pHPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf2_get_heap_size([NativeTypeName("const ma_hpf2_config *")] ma_hpf1_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf2_init_preallocated([NativeTypeName("const ma_hpf2_config *")] ma_hpf1_config* pConfig, void* pHeap, ma_hpf2* pHPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf2_init([NativeTypeName("const ma_hpf2_config *")] ma_hpf1_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hpf2* pHPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_hpf2_uninit(ma_hpf2* pHPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf2_reinit([NativeTypeName("const ma_hpf2_config *")] ma_hpf1_config* pConfig, ma_hpf2* pHPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf2_process_pcm_frames(ma_hpf2* pHPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_hpf2_get_latency([NativeTypeName("const ma_hpf2 *")] ma_hpf2* pHPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_hpf_config ma_hpf_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf_get_heap_size([NativeTypeName("const ma_hpf_config *")] ma_hpf_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf_init_preallocated([NativeTypeName("const ma_hpf_config *")] ma_hpf_config* pConfig, void* pHeap, ma_hpf* pLPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf_init([NativeTypeName("const ma_hpf_config *")] ma_hpf_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hpf* pHPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_hpf_uninit(ma_hpf* pHPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf_reinit([NativeTypeName("const ma_hpf_config *")] ma_hpf_config* pConfig, ma_hpf* pHPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf_process_pcm_frames(ma_hpf* pHPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_hpf_get_latency([NativeTypeName("const ma_hpf *")] ma_hpf* pHPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_bpf2_config ma_bpf2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, double q);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf2_get_heap_size([NativeTypeName("const ma_bpf2_config *")] ma_bpf2_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf2_init_preallocated([NativeTypeName("const ma_bpf2_config *")] ma_bpf2_config* pConfig, void* pHeap, ma_bpf2* pBPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf2_init([NativeTypeName("const ma_bpf2_config *")] ma_bpf2_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_bpf2* pBPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_bpf2_uninit(ma_bpf2* pBPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf2_reinit([NativeTypeName("const ma_bpf2_config *")] ma_bpf2_config* pConfig, ma_bpf2* pBPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf2_process_pcm_frames(ma_bpf2* pBPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_bpf2_get_latency([NativeTypeName("const ma_bpf2 *")] ma_bpf2* pBPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_bpf_config ma_bpf_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf_get_heap_size([NativeTypeName("const ma_bpf_config *")] ma_bpf_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf_init_preallocated([NativeTypeName("const ma_bpf_config *")] ma_bpf_config* pConfig, void* pHeap, ma_bpf* pBPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf_init([NativeTypeName("const ma_bpf_config *")] ma_bpf_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_bpf* pBPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_bpf_uninit(ma_bpf* pBPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf_reinit([NativeTypeName("const ma_bpf_config *")] ma_bpf_config* pConfig, ma_bpf* pBPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf_process_pcm_frames(ma_bpf* pBPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_bpf_get_latency([NativeTypeName("const ma_bpf *")] ma_bpf* pBPF);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_notch2_config ma_notch2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double q, double frequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_notch2_get_heap_size([NativeTypeName("const ma_notch2_config *")] ma_notch2_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_notch2_init_preallocated([NativeTypeName("const ma_notch2_config *")] ma_notch2_config* pConfig, void* pHeap, ma_notch2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_notch2_init([NativeTypeName("const ma_notch2_config *")] ma_notch2_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_notch2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_notch2_uninit(ma_notch2* pFilter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_notch2_reinit([NativeTypeName("const ma_notch2_config *")] ma_notch2_config* pConfig, ma_notch2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_notch2_process_pcm_frames(ma_notch2* pFilter, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_notch2_get_latency([NativeTypeName("const ma_notch2 *")] ma_notch2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_peak2_config ma_peak2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double q, double frequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_peak2_get_heap_size([NativeTypeName("const ma_peak2_config *")] ma_peak2_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_peak2_init_preallocated([NativeTypeName("const ma_peak2_config *")] ma_peak2_config* pConfig, void* pHeap, ma_peak2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_peak2_init([NativeTypeName("const ma_peak2_config *")] ma_peak2_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_peak2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_peak2_uninit(ma_peak2* pFilter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_peak2_reinit([NativeTypeName("const ma_peak2_config *")] ma_peak2_config* pConfig, ma_peak2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_peak2_process_pcm_frames(ma_peak2* pFilter, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_peak2_get_latency([NativeTypeName("const ma_peak2 *")] ma_peak2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_loshelf2_config ma_loshelf2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double shelfSlope, double frequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_loshelf2_get_heap_size([NativeTypeName("const ma_loshelf2_config *")] ma_loshelf2_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_loshelf2_init_preallocated([NativeTypeName("const ma_loshelf2_config *")] ma_loshelf2_config* pConfig, void* pHeap, ma_loshelf2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_loshelf2_init([NativeTypeName("const ma_loshelf2_config *")] ma_loshelf2_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_loshelf2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_loshelf2_uninit(ma_loshelf2* pFilter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_loshelf2_reinit([NativeTypeName("const ma_loshelf2_config *")] ma_loshelf2_config* pConfig, ma_loshelf2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_loshelf2_process_pcm_frames(ma_loshelf2* pFilter, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_loshelf2_get_latency([NativeTypeName("const ma_loshelf2 *")] ma_loshelf2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_hishelf2_config ma_hishelf2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double shelfSlope, double frequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hishelf2_get_heap_size([NativeTypeName("const ma_hishelf2_config *")] ma_hishelf2_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hishelf2_init_preallocated([NativeTypeName("const ma_hishelf2_config *")] ma_hishelf2_config* pConfig, void* pHeap, ma_hishelf2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hishelf2_init([NativeTypeName("const ma_hishelf2_config *")] ma_hishelf2_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hishelf2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_hishelf2_uninit(ma_hishelf2* pFilter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hishelf2_reinit([NativeTypeName("const ma_hishelf2_config *")] ma_hishelf2_config* pConfig, ma_hishelf2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hishelf2_process_pcm_frames(ma_hishelf2* pFilter, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_hishelf2_get_latency([NativeTypeName("const ma_hishelf2 *")] ma_hishelf2* pFilter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_delay_config ma_delay_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, [NativeTypeName("ma_uint32")] uint delayInFrames, float decay);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_delay_init([NativeTypeName("const ma_delay_config *")] ma_delay_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_delay* pDelay);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_delay_uninit(ma_delay* pDelay, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_delay_process_pcm_frames(ma_delay* pDelay, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint32")] uint frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_delay_set_wet(ma_delay* pDelay, float value);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_delay_get_wet([NativeTypeName("const ma_delay *")] ma_delay* pDelay);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_delay_set_dry(ma_delay* pDelay, float value);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_delay_get_dry([NativeTypeName("const ma_delay *")] ma_delay* pDelay);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_delay_set_decay(ma_delay* pDelay, float value);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_delay_get_decay([NativeTypeName("const ma_delay *")] ma_delay* pDelay);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_gainer_config ma_gainer_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint smoothTimeInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_gainer_get_heap_size([NativeTypeName("const ma_gainer_config *")] ma_gainer_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_gainer_init_preallocated([NativeTypeName("const ma_gainer_config *")] ma_gainer_config* pConfig, void* pHeap, ma_gainer* pGainer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_gainer_init([NativeTypeName("const ma_gainer_config *")] ma_gainer_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_gainer* pGainer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_gainer_uninit(ma_gainer* pGainer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_gainer_process_pcm_frames(ma_gainer* pGainer, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_gainer_set_gain(ma_gainer* pGainer, float newGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_gainer_set_gains(ma_gainer* pGainer, float* pNewGains);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_panner_config ma_panner_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_panner_init([NativeTypeName("const ma_panner_config *")] ma_panner_config* pConfig, ma_panner* pPanner);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_panner_process_pcm_frames(ma_panner* pPanner, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_panner_set_mode(ma_panner* pPanner, ma_pan_mode mode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_pan_mode ma_panner_get_mode([NativeTypeName("const ma_panner *")] ma_panner* pPanner);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_panner_set_pan(ma_panner* pPanner, float pan);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_panner_get_pan([NativeTypeName("const ma_panner *")] ma_panner* pPanner);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_fader_config ma_fader_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_fader_init([NativeTypeName("const ma_fader_config *")] ma_fader_config* pConfig, ma_fader* pFader);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_fader_process_pcm_frames(ma_fader* pFader, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_fader_get_data_format([NativeTypeName("const ma_fader *")] ma_fader* pFader, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_fader_set_fade(ma_fader* pFader, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong lengthInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_fader_get_current_volume(ma_fader* pFader);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_spatializer_listener_config ma_spatializer_listener_config_init([NativeTypeName("ma_uint32")] uint channelsOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_spatializer_listener_get_heap_size([NativeTypeName("const ma_spatializer_listener_config *")] ma_spatializer_listener_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_spatializer_listener_init_preallocated([NativeTypeName("const ma_spatializer_listener_config *")] ma_spatializer_listener_config* pConfig, void* pHeap, ma_spatializer_listener* pListener);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_spatializer_listener_init([NativeTypeName("const ma_spatializer_listener_config *")] ma_spatializer_listener_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_spatializer_listener* pListener);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_listener_uninit(ma_spatializer_listener* pListener, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_channel *")]
    public static extern byte* ma_spatializer_listener_get_channel_map(ma_spatializer_listener* pListener);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_listener_set_cone(ma_spatializer_listener* pListener, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_listener_get_cone([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener, float* pInnerAngleInRadians, float* pOuterAngleInRadians, float* pOuterGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_listener_set_position(ma_spatializer_listener* pListener, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_spatializer_listener_get_position([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_listener_set_direction(ma_spatializer_listener* pListener, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_spatializer_listener_get_direction([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_listener_set_velocity(ma_spatializer_listener* pListener, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_spatializer_listener_get_velocity([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_listener_set_speed_of_sound(ma_spatializer_listener* pListener, float speedOfSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_spatializer_listener_get_speed_of_sound([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_listener_set_world_up(ma_spatializer_listener* pListener, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_spatializer_listener_get_world_up([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_listener_set_enabled(ma_spatializer_listener* pListener, [NativeTypeName("ma_bool32")] uint isEnabled);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_spatializer_listener_is_enabled([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_spatializer_config ma_spatializer_config_init([NativeTypeName("ma_uint32")] uint channelsIn, [NativeTypeName("ma_uint32")] uint channelsOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_spatializer_get_heap_size([NativeTypeName("const ma_spatializer_config *")] ma_spatializer_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_spatializer_init_preallocated([NativeTypeName("const ma_spatializer_config *")] ma_spatializer_config* pConfig, void* pHeap, ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_spatializer_init([NativeTypeName("const ma_spatializer_config *")] ma_spatializer_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_uninit(ma_spatializer* pSpatializer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_spatializer_process_pcm_frames(ma_spatializer* pSpatializer, ma_spatializer_listener* pListener, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_spatializer_get_input_channels([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_spatializer_get_output_channels([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_attenuation_model(ma_spatializer* pSpatializer, ma_attenuation_model attenuationModel);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_attenuation_model ma_spatializer_get_attenuation_model([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_positioning(ma_spatializer* pSpatializer, ma_positioning positioning);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_positioning ma_spatializer_get_positioning([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_rolloff(ma_spatializer* pSpatializer, float rolloff);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_spatializer_get_rolloff([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_min_gain(ma_spatializer* pSpatializer, float minGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_spatializer_get_min_gain([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_max_gain(ma_spatializer* pSpatializer, float maxGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_spatializer_get_max_gain([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_min_distance(ma_spatializer* pSpatializer, float minDistance);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_spatializer_get_min_distance([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_max_distance(ma_spatializer* pSpatializer, float maxDistance);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_spatializer_get_max_distance([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_cone(ma_spatializer* pSpatializer, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_get_cone([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer, float* pInnerAngleInRadians, float* pOuterAngleInRadians, float* pOuterGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_doppler_factor(ma_spatializer* pSpatializer, float dopplerFactor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_spatializer_get_doppler_factor([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_directional_attenuation_factor(ma_spatializer* pSpatializer, float directionalAttenuationFactor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_spatializer_get_directional_attenuation_factor([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_position(ma_spatializer* pSpatializer, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_spatializer_get_position([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_direction(ma_spatializer* pSpatializer, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_spatializer_get_direction([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_set_velocity(ma_spatializer* pSpatializer, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_spatializer_get_velocity([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_spatializer_get_relative_position_and_direction([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer, [NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener, ma_vec3f* pRelativePos, ma_vec3f* pRelativeDir);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_linear_resampler_config ma_linear_resampler_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_linear_resampler_get_heap_size([NativeTypeName("const ma_linear_resampler_config *")] ma_linear_resampler_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_linear_resampler_init_preallocated([NativeTypeName("const ma_linear_resampler_config *")] ma_linear_resampler_config* pConfig, void* pHeap, ma_linear_resampler* pResampler);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_linear_resampler_init([NativeTypeName("const ma_linear_resampler_config *")] ma_linear_resampler_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_linear_resampler* pResampler);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_linear_resampler_uninit(ma_linear_resampler* pResampler, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_linear_resampler_process_pcm_frames(ma_linear_resampler* pResampler, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountIn, void* pFramesOut, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_linear_resampler_set_rate(ma_linear_resampler* pResampler, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_linear_resampler_set_rate_ratio(ma_linear_resampler* pResampler, float ratioInOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_linear_resampler_get_input_latency([NativeTypeName("const ma_linear_resampler *")] ma_linear_resampler* pResampler);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_linear_resampler_get_output_latency([NativeTypeName("const ma_linear_resampler *")] ma_linear_resampler* pResampler);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_linear_resampler_get_required_input_frame_count([NativeTypeName("const ma_linear_resampler *")] ma_linear_resampler* pResampler, [NativeTypeName("ma_uint64")] ulong outputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pInputFrameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_linear_resampler_get_expected_output_frame_count([NativeTypeName("const ma_linear_resampler *")] ma_linear_resampler* pResampler, [NativeTypeName("ma_uint64")] ulong inputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pOutputFrameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_linear_resampler_reset(ma_linear_resampler* pResampler);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_resampler_config ma_resampler_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut, ma_resample_algorithm algorithm);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resampler_get_heap_size([NativeTypeName("const ma_resampler_config *")] ma_resampler_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resampler_init_preallocated([NativeTypeName("const ma_resampler_config *")] ma_resampler_config* pConfig, void* pHeap, ma_resampler* pResampler);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resampler_init([NativeTypeName("const ma_resampler_config *")] ma_resampler_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_resampler* pResampler);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_resampler_uninit(ma_resampler* pResampler, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resampler_process_pcm_frames(ma_resampler* pResampler, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountIn, void* pFramesOut, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resampler_set_rate(ma_resampler* pResampler, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resampler_set_rate_ratio(ma_resampler* pResampler, float ratio);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_resampler_get_input_latency([NativeTypeName("const ma_resampler *")] ma_resampler* pResampler);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_resampler_get_output_latency([NativeTypeName("const ma_resampler *")] ma_resampler* pResampler);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resampler_get_required_input_frame_count([NativeTypeName("const ma_resampler *")] ma_resampler* pResampler, [NativeTypeName("ma_uint64")] ulong outputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pInputFrameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resampler_get_expected_output_frame_count([NativeTypeName("const ma_resampler *")] ma_resampler* pResampler, [NativeTypeName("ma_uint64")] ulong inputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pOutputFrameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resampler_reset(ma_resampler* pResampler);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_channel_converter_config ma_channel_converter_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channelsIn, [NativeTypeName("const ma_channel *")] byte* pChannelMapIn, [NativeTypeName("ma_uint32")] uint channelsOut, [NativeTypeName("const ma_channel *")] byte* pChannelMapOut, ma_channel_mix_mode mixingMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_channel_converter_get_heap_size([NativeTypeName("const ma_channel_converter_config *")] ma_channel_converter_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_channel_converter_init_preallocated([NativeTypeName("const ma_channel_converter_config *")] ma_channel_converter_config* pConfig, void* pHeap, ma_channel_converter* pConverter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_channel_converter_init([NativeTypeName("const ma_channel_converter_config *")] ma_channel_converter_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_channel_converter* pConverter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_channel_converter_uninit(ma_channel_converter* pConverter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_channel_converter_process_pcm_frames(ma_channel_converter* pConverter, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_channel_converter_get_input_channel_map([NativeTypeName("const ma_channel_converter *")] ma_channel_converter* pConverter, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_channel_converter_get_output_channel_map([NativeTypeName("const ma_channel_converter *")] ma_channel_converter* pConverter, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_data_converter_config ma_data_converter_config_init_default();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_data_converter_config ma_data_converter_config_init(ma_format formatIn, ma_format formatOut, [NativeTypeName("ma_uint32")] uint channelsIn, [NativeTypeName("ma_uint32")] uint channelsOut, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_converter_get_heap_size([NativeTypeName("const ma_data_converter_config *")] ma_data_converter_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_converter_init_preallocated([NativeTypeName("const ma_data_converter_config *")] ma_data_converter_config* pConfig, void* pHeap, ma_data_converter* pConverter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_converter_init([NativeTypeName("const ma_data_converter_config *")] ma_data_converter_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_data_converter* pConverter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_data_converter_uninit(ma_data_converter* pConverter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_converter_process_pcm_frames(ma_data_converter* pConverter, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountIn, void* pFramesOut, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_converter_set_rate(ma_data_converter* pConverter, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_converter_set_rate_ratio(ma_data_converter* pConverter, float ratioInOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_data_converter_get_input_latency([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_data_converter_get_output_latency([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_converter_get_required_input_frame_count([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter, [NativeTypeName("ma_uint64")] ulong outputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pInputFrameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_converter_get_expected_output_frame_count([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter, [NativeTypeName("ma_uint64")] ulong inputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pOutputFrameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_converter_get_input_channel_map([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_converter_get_output_channel_map([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_converter_reset(ma_data_converter* pConverter);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_u8_to_s16(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_u8_to_s24(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_u8_to_s32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_u8_to_f32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s16_to_u8(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s16_to_s24(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s16_to_s32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s16_to_f32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s24_to_u8(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s24_to_s16(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s24_to_s32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s24_to_f32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s32_to_u8(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s32_to_s16(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s32_to_s24(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_s32_to_f32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_f32_to_u8(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_f32_to_s16(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_f32_to_s24(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_f32_to_s32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_convert(void* pOut, ma_format formatOut, [NativeTypeName("const void *")] void* pIn, ma_format formatIn, [NativeTypeName("ma_uint64")] ulong sampleCount, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_convert_pcm_frames_format(void* pOut, ma_format formatOut, [NativeTypeName("const void *")] void* pIn, ma_format formatIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, ma_dither_mode ditherMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_deinterleave_pcm_frames(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("const void *")] void* pInterleavedPCMFrames, void** ppDeinterleavedPCMFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_interleave_pcm_frames(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("const void **")] void** ppDeinterleavedPCMFrames, void* pInterleavedPCMFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_channel")]
    public static extern byte ma_channel_map_get_channel([NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_uint32")] uint channelCount, [NativeTypeName("ma_uint32")] uint channelIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_channel_map_init_blank([NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_channel_map_init_standard(ma_standard_channel_map standardChannelMap, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_channel_map_copy([NativeTypeName("ma_channel *")] byte* pOut, [NativeTypeName("const ma_channel *")] byte* pIn, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_channel_map_copy_or_default([NativeTypeName("ma_channel *")] byte* pOut, [NativeTypeName("size_t")] nuint channelMapCapOut, [NativeTypeName("const ma_channel *")] byte* pIn, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_channel_map_is_valid([NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_channel_map_is_equal([NativeTypeName("const ma_channel *")] byte* pChannelMapA, [NativeTypeName("const ma_channel *")] byte* pChannelMapB, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_channel_map_is_blank([NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_channel_map_contains_channel_position([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_channel")] byte channelPosition);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_channel_map_find_channel_position([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_channel")] byte channelPosition, [NativeTypeName("ma_uint32 *")] uint* pChannelIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint ma_channel_map_to_string([NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("char *")] sbyte* pBufferOut, [NativeTypeName("size_t")] nuint bufferCap);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ma_channel_position_to_string([NativeTypeName("ma_channel")] byte channel);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_convert_frames(void* pOut, [NativeTypeName("ma_uint64")] ulong frameCountOut, ma_format formatOut, [NativeTypeName("ma_uint32")] uint channelsOut, [NativeTypeName("ma_uint32")] uint sampleRateOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong frameCountIn, ma_format formatIn, [NativeTypeName("ma_uint32")] uint channelsIn, [NativeTypeName("ma_uint32")] uint sampleRateIn);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_convert_frames_ex(void* pOut, [NativeTypeName("ma_uint64")] ulong frameCountOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong frameCountIn, [NativeTypeName("const ma_data_converter_config *")] ma_data_converter_config* pConfig);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_rb_init_ex([NativeTypeName("size_t")] nuint subbufferSizeInBytes, [NativeTypeName("size_t")] nuint subbufferCount, [NativeTypeName("size_t")] nuint subbufferStrideInBytes, void* pOptionalPreallocatedBuffer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_rb_init([NativeTypeName("size_t")] nuint bufferSizeInBytes, void* pOptionalPreallocatedBuffer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_rb_uninit(ma_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_rb_reset(ma_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_rb_acquire_read(ma_rb* pRB, [NativeTypeName("size_t *")] nuint* pSizeInBytes, void** ppBufferOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_rb_commit_read(ma_rb* pRB, [NativeTypeName("size_t")] nuint sizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_rb_acquire_write(ma_rb* pRB, [NativeTypeName("size_t *")] nuint* pSizeInBytes, void** ppBufferOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_rb_commit_write(ma_rb* pRB, [NativeTypeName("size_t")] nuint sizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_rb_seek_read(ma_rb* pRB, [NativeTypeName("size_t")] nuint offsetInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_rb_seek_write(ma_rb* pRB, [NativeTypeName("size_t")] nuint offsetInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_int32")]
    public static extern int ma_rb_pointer_distance(ma_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_rb_available_read(ma_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_rb_available_write(ma_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint ma_rb_get_subbuffer_size(ma_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint ma_rb_get_subbuffer_stride(ma_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint ma_rb_get_subbuffer_offset(ma_rb* pRB, [NativeTypeName("size_t")] nuint subbufferIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* ma_rb_get_subbuffer_ptr(ma_rb* pRB, [NativeTypeName("size_t")] nuint subbufferIndex, void* pBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_pcm_rb_init_ex(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint subbufferSizeInFrames, [NativeTypeName("ma_uint32")] uint subbufferCount, [NativeTypeName("ma_uint32")] uint subbufferStrideInFrames, void* pOptionalPreallocatedBuffer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_pcm_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_pcm_rb_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint bufferSizeInFrames, void* pOptionalPreallocatedBuffer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_pcm_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_rb_uninit(ma_pcm_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_pcm_rb_reset(ma_pcm_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_pcm_rb_acquire_read(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32 *")] uint* pSizeInFrames, void** ppBufferOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_pcm_rb_commit_read(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint sizeInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_pcm_rb_acquire_write(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32 *")] uint* pSizeInFrames, void** ppBufferOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_pcm_rb_commit_write(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint sizeInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_pcm_rb_seek_read(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint offsetInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_pcm_rb_seek_write(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint offsetInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_int32")]
    public static extern int ma_pcm_rb_pointer_distance(ma_pcm_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_pcm_rb_available_read(ma_pcm_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_pcm_rb_available_write(ma_pcm_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_pcm_rb_get_subbuffer_size(ma_pcm_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_pcm_rb_get_subbuffer_stride(ma_pcm_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_pcm_rb_get_subbuffer_offset(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint subbufferIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* ma_pcm_rb_get_subbuffer_ptr(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint subbufferIndex, void* pBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_duplex_rb_init(ma_format captureFormat, [NativeTypeName("ma_uint32")] uint captureChannels, [NativeTypeName("ma_uint32")] uint sampleRate, [NativeTypeName("ma_uint32")] uint captureInternalSampleRate, [NativeTypeName("ma_uint32")] uint captureInternalPeriodSizeInFrames, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_duplex_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_duplex_rb_uninit(ma_duplex_rb* pRB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ma_result_description(ma_result result);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* ma_malloc([NativeTypeName("size_t")] nuint sz, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* ma_calloc([NativeTypeName("size_t")] nuint sz, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* ma_realloc(void* p, [NativeTypeName("size_t")] nuint sz, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_free(void* p, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* ma_aligned_malloc([NativeTypeName("size_t")] nuint sz, [NativeTypeName("size_t")] nuint alignment, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_aligned_free(void* p, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ma_get_format_name(ma_format format);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_blend_f32(float* pOut, float* pInA, float* pInB, float factor, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_get_bytes_per_sample(ma_format format);

    [return: NativeTypeName("ma_uint32")]
    public static uint ma_get_bytes_per_frame(ma_format format, [NativeTypeName("ma_uint32")] uint channels)
    {
        return ma_get_bytes_per_sample(format) * channels;
    }

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ma_log_level_to_string([NativeTypeName("ma_uint32")] uint logLevel);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_spinlock_lock([NativeTypeName("volatile ma_spinlock *")] uint* pSpinlock);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_spinlock_lock_noyield([NativeTypeName("volatile ma_spinlock *")] uint* pSpinlock);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_spinlock_unlock([NativeTypeName("volatile ma_spinlock *")] uint* pSpinlock);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_mutex_init([NativeTypeName("ma_mutex *")] void** pMutex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_mutex_uninit([NativeTypeName("ma_mutex *")] void** pMutex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_mutex_lock([NativeTypeName("ma_mutex *")] void** pMutex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_mutex_unlock([NativeTypeName("ma_mutex *")] void** pMutex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_event_init([NativeTypeName("ma_event *")] void** pEvent);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_event_uninit([NativeTypeName("ma_event *")] void** pEvent);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_event_wait([NativeTypeName("ma_event *")] void** pEvent);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_event_signal([NativeTypeName("ma_event *")] void** pEvent);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_fence_init(ma_fence* pFence);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_fence_uninit(ma_fence* pFence);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_fence_acquire(ma_fence* pFence);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_fence_release(ma_fence* pFence);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_fence_wait(ma_fence* pFence);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_async_notification_signal([NativeTypeName("ma_async_notification *")] void* pNotification);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_async_notification_poll_init(ma_async_notification_poll* pNotificationPoll);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_async_notification_poll_is_signalled([NativeTypeName("const ma_async_notification_poll *")] ma_async_notification_poll* pNotificationPoll);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_async_notification_event_init(ma_async_notification_event* pNotificationEvent);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_async_notification_event_uninit(ma_async_notification_event* pNotificationEvent);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_async_notification_event_wait(ma_async_notification_event* pNotificationEvent);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_async_notification_event_signal(ma_async_notification_event* pNotificationEvent);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_slot_allocator_config ma_slot_allocator_config_init([NativeTypeName("ma_uint32")] uint capacity);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_slot_allocator_get_heap_size([NativeTypeName("const ma_slot_allocator_config *")] ma_slot_allocator_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_slot_allocator_init_preallocated([NativeTypeName("const ma_slot_allocator_config *")] ma_slot_allocator_config* pConfig, void* pHeap, ma_slot_allocator* pAllocator);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_slot_allocator_init([NativeTypeName("const ma_slot_allocator_config *")] ma_slot_allocator_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_slot_allocator* pAllocator);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_slot_allocator_uninit(ma_slot_allocator* pAllocator, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_slot_allocator_alloc(ma_slot_allocator* pAllocator, [NativeTypeName("ma_uint64 *")] ulong* pSlot);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_slot_allocator_free(ma_slot_allocator* pAllocator, [NativeTypeName("ma_uint64")] ulong slot);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_job ma_job_init([NativeTypeName("ma_uint16")] ushort code);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_job_process(ma_job* pJob);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_job_queue_config ma_job_queue_config_init([NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_uint32")] uint capacity);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_job_queue_get_heap_size([NativeTypeName("const ma_job_queue_config *")] ma_job_queue_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_job_queue_init_preallocated([NativeTypeName("const ma_job_queue_config *")] ma_job_queue_config* pConfig, void* pHeap, ma_job_queue* pQueue);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_job_queue_init([NativeTypeName("const ma_job_queue_config *")] ma_job_queue_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_job_queue* pQueue);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_job_queue_uninit(ma_job_queue* pQueue, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_job_queue_post(ma_job_queue* pQueue, [NativeTypeName("const ma_job *")] ma_job* pJob);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_job_queue_next(ma_job_queue* pQueue, ma_job* pJob);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_device_job_thread_config ma_device_job_thread_config_init();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_job_thread_init([NativeTypeName("const ma_device_job_thread_config *")] ma_device_job_thread_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_device_job_thread* pJobThread);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_device_job_thread_uninit(ma_device_job_thread* pJobThread, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_job_thread_post(ma_device_job_thread* pJobThread, [NativeTypeName("const ma_job *")] ma_job* pJob);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_job_thread_next(ma_device_job_thread* pJobThread, ma_job* pJob);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_context_config ma_context_config_init();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_context_init([NativeTypeName("const ma_backend []")] ma_backend* backends, [NativeTypeName("ma_uint32")] uint backendCount, [NativeTypeName("const ma_context_config *")] ma_context_config* pConfig, ma_context* pContext);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_context_uninit(ma_context* pContext);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint ma_context_sizeof();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_log* ma_context_get_log(ma_context* pContext);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_context_enumerate_devices(ma_context* pContext, [NativeTypeName("ma_enum_devices_callback_proc")] delegate* unmanaged[Cdecl]<ma_context*, ma_device_type, ma_device_info*, void*, uint> callback, void* pUserData);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_context_get_devices(ma_context* pContext, ma_device_info** ppPlaybackDeviceInfos, [NativeTypeName("ma_uint32 *")] uint* pPlaybackDeviceCount, ma_device_info** ppCaptureDeviceInfos, [NativeTypeName("ma_uint32 *")] uint* pCaptureDeviceCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_context_get_device_info(ma_context* pContext, ma_device_type deviceType, [NativeTypeName("const ma_device_id *")] ma_device_id* pDeviceID, ma_device_info* pDeviceInfo);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_context_is_loopback_supported(ma_context* pContext);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_device_config ma_device_config_init(ma_device_type deviceType);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_init(ma_context* pContext, [NativeTypeName("const ma_device_config *")] ma_device_config* pConfig, ma_device* pDevice);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_init_ex([NativeTypeName("const ma_backend []")] ma_backend* backends, [NativeTypeName("ma_uint32")] uint backendCount, [NativeTypeName("const ma_context_config *")] ma_context_config* pContextConfig, [NativeTypeName("const ma_device_config *")] ma_device_config* pConfig, ma_device* pDevice);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_device_uninit(ma_device* pDevice);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_context* ma_device_get_context(ma_device* pDevice);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_log* ma_device_get_log(ma_device* pDevice);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_get_info(ma_device* pDevice, ma_device_type type, ma_device_info* pDeviceInfo);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_get_name(ma_device* pDevice, ma_device_type type, [NativeTypeName("char *")] sbyte* pName, [NativeTypeName("size_t")] nuint nameCap, [NativeTypeName("size_t *")] nuint* pLengthNotIncludingNullTerminator);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_start(ma_device* pDevice);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_stop(ma_device* pDevice);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_device_is_started([NativeTypeName("const ma_device *")] ma_device* pDevice);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_device_state ma_device_get_state([NativeTypeName("const ma_device *")] ma_device* pDevice);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_post_init(ma_device* pDevice, ma_device_type deviceType, [NativeTypeName("const ma_device_descriptor *")] ma_device_descriptor* pPlaybackDescriptor, [NativeTypeName("const ma_device_descriptor *")] ma_device_descriptor* pCaptureDescriptor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_set_master_volume(ma_device* pDevice, float volume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_get_master_volume(ma_device* pDevice, float* pVolume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_set_master_volume_db(ma_device* pDevice, float gainDB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_get_master_volume_db(ma_device* pDevice, float* pGainDB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_device_handle_backend_data_callback(ma_device* pDevice, void* pOutput, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("ma_uint32")] uint frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_calculate_buffer_size_in_frames_from_descriptor([NativeTypeName("const ma_device_descriptor *")] ma_device_descriptor* pDescriptor, [NativeTypeName("ma_uint32")] uint nativeSampleRate, ma_performance_profile performanceProfile);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* ma_get_backend_name(ma_backend backend);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_is_backend_enabled(ma_backend backend);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_get_enabled_backends(ma_backend* pBackends, [NativeTypeName("size_t")] nuint backendCap, [NativeTypeName("size_t *")] nuint* pBackendCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_is_loopback_supported(ma_backend backend);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_calculate_buffer_size_in_milliseconds_from_frames([NativeTypeName("ma_uint32")] uint bufferSizeInFrames, [NativeTypeName("ma_uint32")] uint sampleRate);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_calculate_buffer_size_in_frames_from_milliseconds([NativeTypeName("ma_uint32")] uint bufferSizeInMilliseconds, [NativeTypeName("ma_uint32")] uint sampleRate);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_pcm_frames(void* dst, [NativeTypeName("const void *")] void* src, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_silence_pcm_frames(void* p, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void* ma_offset_pcm_frames_ptr(void* p, [NativeTypeName("ma_uint64")] ulong offsetInFrames, ma_format format, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const void *")]
    public static extern void* ma_offset_pcm_frames_const_ptr([NativeTypeName("const void *")] void* p, [NativeTypeName("ma_uint64")] ulong offsetInFrames, ma_format format, [NativeTypeName("ma_uint32")] uint channels);

    public static float* ma_offset_pcm_frames_ptr_f32(float* p, [NativeTypeName("ma_uint64")] ulong offsetInFrames, [NativeTypeName("ma_uint32")] uint channels)
    {
        return (float*)(ma_offset_pcm_frames_ptr((void*)(p), offsetInFrames, ma_format_f32, channels));
    }

    [return: NativeTypeName("const float *")]
    public static float* ma_offset_pcm_frames_const_ptr_f32([NativeTypeName("const float *")] float* p, [NativeTypeName("ma_uint64")] ulong offsetInFrames, [NativeTypeName("ma_uint32")] uint channels)
    {
        return (float*)(ma_offset_pcm_frames_const_ptr((void*)(p), offsetInFrames, ma_format_f32, channels));
    }

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_clip_samples_u8([NativeTypeName("ma_uint8 *")] byte* pDst, [NativeTypeName("const ma_int16 *")] short* pSrc, [NativeTypeName("ma_uint64")] ulong count);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_clip_samples_s16([NativeTypeName("ma_int16 *")] short* pDst, [NativeTypeName("const ma_int32 *")] int* pSrc, [NativeTypeName("ma_uint64")] ulong count);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_clip_samples_s24([NativeTypeName("ma_uint8 *")] byte* pDst, [NativeTypeName("const ma_int64 *")] long* pSrc, [NativeTypeName("ma_uint64")] ulong count);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_clip_samples_s32([NativeTypeName("ma_int32 *")] int* pDst, [NativeTypeName("const ma_int64 *")] long* pSrc, [NativeTypeName("ma_uint64")] ulong count);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_clip_samples_f32(float* pDst, [NativeTypeName("const float *")] float* pSrc, [NativeTypeName("ma_uint64")] ulong count);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_clip_pcm_frames(void* pDst, [NativeTypeName("const void *")] void* pSrc, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_u8([NativeTypeName("ma_uint8 *")] byte* pSamplesOut, [NativeTypeName("const ma_uint8 *")] byte* pSamplesIn, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_s16([NativeTypeName("ma_int16 *")] short* pSamplesOut, [NativeTypeName("const ma_int16 *")] short* pSamplesIn, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_s24(void* pSamplesOut, [NativeTypeName("const void *")] void* pSamplesIn, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_s32([NativeTypeName("ma_int32 *")] int* pSamplesOut, [NativeTypeName("const ma_int32 *")] int* pSamplesIn, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_f32(float* pSamplesOut, [NativeTypeName("const float *")] float* pSamplesIn, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_apply_volume_factor_u8([NativeTypeName("ma_uint8 *")] byte* pSamples, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_apply_volume_factor_s16([NativeTypeName("ma_int16 *")] short* pSamples, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_apply_volume_factor_s24(void* pSamples, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_apply_volume_factor_s32([NativeTypeName("ma_int32 *")] int* pSamples, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_apply_volume_factor_f32(float* pSamples, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_pcm_frames_u8([NativeTypeName("ma_uint8 *")] byte* pFramesOut, [NativeTypeName("const ma_uint8 *")] byte* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_pcm_frames_s16([NativeTypeName("ma_int16 *")] short* pFramesOut, [NativeTypeName("const ma_int16 *")] short* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_pcm_frames_s24(void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_pcm_frames_s32([NativeTypeName("ma_int32 *")] int* pFramesOut, [NativeTypeName("const ma_int32 *")] int* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_pcm_frames_f32(float* pFramesOut, [NativeTypeName("const float *")] float* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_pcm_frames(void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_apply_volume_factor_pcm_frames_u8([NativeTypeName("ma_uint8 *")] byte* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_apply_volume_factor_pcm_frames_s16([NativeTypeName("ma_int16 *")] short* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_apply_volume_factor_pcm_frames_s24(void* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_apply_volume_factor_pcm_frames_s32([NativeTypeName("ma_int32 *")] int* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_apply_volume_factor_pcm_frames_f32(float* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_apply_volume_factor_pcm_frames(void* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels, float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_factor_per_channel_f32(float* pFramesOut, [NativeTypeName("const float *")] float* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float* pChannelGains);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_and_clip_samples_u8([NativeTypeName("ma_uint8 *")] byte* pDst, [NativeTypeName("const ma_int16 *")] short* pSrc, [NativeTypeName("ma_uint64")] ulong count, float volume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_and_clip_samples_s16([NativeTypeName("ma_int16 *")] short* pDst, [NativeTypeName("const ma_int32 *")] int* pSrc, [NativeTypeName("ma_uint64")] ulong count, float volume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_and_clip_samples_s24([NativeTypeName("ma_uint8 *")] byte* pDst, [NativeTypeName("const ma_int64 *")] long* pSrc, [NativeTypeName("ma_uint64")] ulong count, float volume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_and_clip_samples_s32([NativeTypeName("ma_int32 *")] int* pDst, [NativeTypeName("const ma_int64 *")] long* pSrc, [NativeTypeName("ma_uint64")] ulong count, float volume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_and_clip_samples_f32(float* pDst, [NativeTypeName("const float *")] float* pSrc, [NativeTypeName("ma_uint64")] ulong count, float volume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_copy_and_apply_volume_and_clip_pcm_frames(void* pDst, [NativeTypeName("const void *")] void* pSrc, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels, float volume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_volume_linear_to_db(float factor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_volume_db_to_linear(float gain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_data_source_config ma_data_source_config_init();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_init([NativeTypeName("const ma_data_source_config *")] ma_data_source_config* pConfig, [NativeTypeName("ma_data_source *")] void* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_data_source_uninit([NativeTypeName("ma_data_source *")] void* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_read_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_seek_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesSeeked);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_seek_to_pcm_frame([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64")] ulong frameIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_get_data_format([NativeTypeName("ma_data_source *")] void* pDataSource, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_get_cursor_in_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_get_length_in_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_get_cursor_in_seconds([NativeTypeName("ma_data_source *")] void* pDataSource, float* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_get_length_in_seconds([NativeTypeName("ma_data_source *")] void* pDataSource, float* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_set_looping([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_bool32")] uint isLooping);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_data_source_is_looping([NativeTypeName("const ma_data_source *")] void* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_set_range_in_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64")] ulong rangeBegInFrames, [NativeTypeName("ma_uint64")] ulong rangeEndInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_data_source_get_range_in_pcm_frames([NativeTypeName("const ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pRangeBegInFrames, [NativeTypeName("ma_uint64 *")] ulong* pRangeEndInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_set_loop_point_in_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64")] ulong loopBegInFrames, [NativeTypeName("ma_uint64")] ulong loopEndInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_data_source_get_loop_point_in_pcm_frames([NativeTypeName("const ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pLoopBegInFrames, [NativeTypeName("ma_uint64 *")] ulong* pLoopEndInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_set_current([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_data_source *")] void* pCurrentDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_data_source *")]
    public static extern void* ma_data_source_get_current([NativeTypeName("const ma_data_source *")] void* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_set_next([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_data_source *")] void* pNextDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_data_source *")]
    public static extern void* ma_data_source_get_next([NativeTypeName("const ma_data_source *")] void* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_set_next_callback([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_data_source_get_next_proc")] delegate* unmanaged[Cdecl]<void*, void*> onGetNext);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_data_source_get_next_proc")]
    public static extern delegate* unmanaged[Cdecl]<void*, void*> ma_data_source_get_next_callback([NativeTypeName("const ma_data_source *")] void* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_ref_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("const void *")] void* pData, [NativeTypeName("ma_uint64")] ulong sizeInFrames, ma_audio_buffer_ref* pAudioBufferRef);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_audio_buffer_ref_uninit(ma_audio_buffer_ref* pAudioBufferRef);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_ref_set_data(ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("const void *")] void* pData, [NativeTypeName("ma_uint64")] ulong sizeInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_audio_buffer_ref_read_pcm_frames(ma_audio_buffer_ref* pAudioBufferRef, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_bool32")] uint loop);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_ref_seek_to_pcm_frame(ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("ma_uint64")] ulong frameIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_ref_map(ma_audio_buffer_ref* pAudioBufferRef, void** ppFramesOut, [NativeTypeName("ma_uint64 *")] ulong* pFrameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_ref_unmap(ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_audio_buffer_ref_at_end([NativeTypeName("const ma_audio_buffer_ref *")] ma_audio_buffer_ref* pAudioBufferRef);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_ref_get_cursor_in_pcm_frames([NativeTypeName("const ma_audio_buffer_ref *")] ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_ref_get_length_in_pcm_frames([NativeTypeName("const ma_audio_buffer_ref *")] ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("ma_uint64 *")] ulong* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_ref_get_available_frames([NativeTypeName("const ma_audio_buffer_ref *")] ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_audio_buffer_config ma_audio_buffer_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint64")] ulong sizeInFrames, [NativeTypeName("const void *")] void* pData, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_init([NativeTypeName("const ma_audio_buffer_config *")] ma_audio_buffer_config* pConfig, ma_audio_buffer* pAudioBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_init_copy([NativeTypeName("const ma_audio_buffer_config *")] ma_audio_buffer_config* pConfig, ma_audio_buffer* pAudioBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_alloc_and_init([NativeTypeName("const ma_audio_buffer_config *")] ma_audio_buffer_config* pConfig, ma_audio_buffer** ppAudioBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_audio_buffer_uninit(ma_audio_buffer* pAudioBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_audio_buffer_uninit_and_free(ma_audio_buffer* pAudioBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_audio_buffer_read_pcm_frames(ma_audio_buffer* pAudioBuffer, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_bool32")] uint loop);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_seek_to_pcm_frame(ma_audio_buffer* pAudioBuffer, [NativeTypeName("ma_uint64")] ulong frameIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_map(ma_audio_buffer* pAudioBuffer, void** ppFramesOut, [NativeTypeName("ma_uint64 *")] ulong* pFrameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_unmap(ma_audio_buffer* pAudioBuffer, [NativeTypeName("ma_uint64")] ulong frameCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_audio_buffer_at_end([NativeTypeName("const ma_audio_buffer *")] ma_audio_buffer* pAudioBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_get_cursor_in_pcm_frames([NativeTypeName("const ma_audio_buffer *")] ma_audio_buffer* pAudioBuffer, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_get_length_in_pcm_frames([NativeTypeName("const ma_audio_buffer *")] ma_audio_buffer* pAudioBuffer, [NativeTypeName("ma_uint64 *")] ulong* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_audio_buffer_get_available_frames([NativeTypeName("const ma_audio_buffer *")] ma_audio_buffer* pAudioBuffer, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_paged_audio_buffer_data_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, ma_paged_audio_buffer_data* pData);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_paged_audio_buffer_data_uninit(ma_paged_audio_buffer_data* pData, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_paged_audio_buffer_page* ma_paged_audio_buffer_data_get_head(ma_paged_audio_buffer_data* pData);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_paged_audio_buffer_page* ma_paged_audio_buffer_data_get_tail(ma_paged_audio_buffer_data* pData);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_paged_audio_buffer_data_get_length_in_pcm_frames(ma_paged_audio_buffer_data* pData, [NativeTypeName("ma_uint64 *")] ulong* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_paged_audio_buffer_data_allocate_page(ma_paged_audio_buffer_data* pData, [NativeTypeName("ma_uint64")] ulong pageSizeInFrames, [NativeTypeName("const void *")] void* pInitialData, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_paged_audio_buffer_page** ppPage);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_paged_audio_buffer_data_free_page(ma_paged_audio_buffer_data* pData, ma_paged_audio_buffer_page* pPage, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_paged_audio_buffer_data_append_page(ma_paged_audio_buffer_data* pData, ma_paged_audio_buffer_page* pPage);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_paged_audio_buffer_data_allocate_and_append_page(ma_paged_audio_buffer_data* pData, [NativeTypeName("ma_uint32")] uint pageSizeInFrames, [NativeTypeName("const void *")] void* pInitialData, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_paged_audio_buffer_config ma_paged_audio_buffer_config_init(ma_paged_audio_buffer_data* pData);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_paged_audio_buffer_init([NativeTypeName("const ma_paged_audio_buffer_config *")] ma_paged_audio_buffer_config* pConfig, ma_paged_audio_buffer* pPagedAudioBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_paged_audio_buffer_uninit(ma_paged_audio_buffer* pPagedAudioBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_paged_audio_buffer_read_pcm_frames(ma_paged_audio_buffer* pPagedAudioBuffer, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_paged_audio_buffer_seek_to_pcm_frame(ma_paged_audio_buffer* pPagedAudioBuffer, [NativeTypeName("ma_uint64")] ulong frameIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_paged_audio_buffer_get_cursor_in_pcm_frames(ma_paged_audio_buffer* pPagedAudioBuffer, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_paged_audio_buffer_get_length_in_pcm_frames(ma_paged_audio_buffer* pPagedAudioBuffer, [NativeTypeName("ma_uint64 *")] ulong* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_vfs_open([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_uint32")] uint openMode, [NativeTypeName("ma_vfs_file *")] void** pFile);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_vfs_open_w([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("ma_uint32")] uint openMode, [NativeTypeName("ma_vfs_file *")] void** pFile);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_vfs_close([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_vfs_read([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file, void* pDst, [NativeTypeName("size_t")] nuint sizeInBytes, [NativeTypeName("size_t *")] nuint* pBytesRead);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_vfs_write([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file, [NativeTypeName("const void *")] void* pSrc, [NativeTypeName("size_t")] nuint sizeInBytes, [NativeTypeName("size_t *")] nuint* pBytesWritten);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_vfs_seek([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file, [NativeTypeName("ma_int64")] long offset, ma_seek_origin origin);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_vfs_tell([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file, [NativeTypeName("ma_int64 *")] long* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_vfs_info([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file, ma_file_info* pInfo);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_vfs_open_and_read_file([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const char *")] sbyte* pFilePath, void** ppData, [NativeTypeName("size_t *")] nuint* pSize, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_default_vfs_init(ma_default_vfs* pVFS, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_decoding_backend_config ma_decoding_backend_config_init(ma_format preferredFormat, [NativeTypeName("ma_uint32")] uint seekPointCount);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_decoder_config ma_decoder_config_init(ma_format outputFormat, [NativeTypeName("ma_uint32")] uint outputChannels, [NativeTypeName("ma_uint32")] uint outputSampleRate);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_decoder_config ma_decoder_config_init_default();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_init([NativeTypeName("ma_decoder_read_proc")] delegate* unmanaged[Cdecl]<ma_decoder*, void*, nuint, nuint*, ma_result> onRead, [NativeTypeName("ma_decoder_seek_proc")] delegate* unmanaged[Cdecl]<ma_decoder*, long, ma_seek_origin, ma_result> onSeek, void* pUserData, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_init_memory([NativeTypeName("const void *")] void* pData, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_init_vfs([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_init_vfs_w([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_init_file([NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_init_file_w([NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_uninit(ma_decoder* pDecoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_read_pcm_frames(ma_decoder* pDecoder, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_seek_to_pcm_frame(ma_decoder* pDecoder, [NativeTypeName("ma_uint64")] ulong frameIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_get_data_format(ma_decoder* pDecoder, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_get_cursor_in_pcm_frames(ma_decoder* pDecoder, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_get_length_in_pcm_frames(ma_decoder* pDecoder, [NativeTypeName("ma_uint64 *")] ulong* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decoder_get_available_frames(ma_decoder* pDecoder, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decode_from_vfs([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const char *")] sbyte* pFilePath, ma_decoder_config* pConfig, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut, void** ppPCMFramesOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decode_file([NativeTypeName("const char *")] sbyte* pFilePath, ma_decoder_config* pConfig, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut, void** ppPCMFramesOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_decode_memory([NativeTypeName("const void *")] void* pData, [NativeTypeName("size_t")] nuint dataSize, ma_decoder_config* pConfig, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut, void** ppPCMFramesOut);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_encoder_config ma_encoder_config_init(ma_encoding_format encodingFormat, ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_encoder_init([NativeTypeName("ma_encoder_write_proc")] delegate* unmanaged[Cdecl]<ma_encoder*, void*, nuint, nuint*, ma_result> onWrite, [NativeTypeName("ma_encoder_seek_proc")] delegate* unmanaged[Cdecl]<ma_encoder*, long, ma_seek_origin, ma_result> onSeek, void* pUserData, [NativeTypeName("const ma_encoder_config *")] ma_encoder_config* pConfig, ma_encoder* pEncoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_encoder_init_vfs([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("const ma_encoder_config *")] ma_encoder_config* pConfig, ma_encoder* pEncoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_encoder_init_vfs_w([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("const ma_encoder_config *")] ma_encoder_config* pConfig, ma_encoder* pEncoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_encoder_init_file([NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("const ma_encoder_config *")] ma_encoder_config* pConfig, ma_encoder* pEncoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_encoder_init_file_w([NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("const ma_encoder_config *")] ma_encoder_config* pConfig, ma_encoder* pEncoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_encoder_uninit(ma_encoder* pEncoder);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_encoder_write_pcm_frames(ma_encoder* pEncoder, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesWritten);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_waveform_config ma_waveform_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, ma_waveform_type type, double amplitude, double frequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_waveform_init([NativeTypeName("const ma_waveform_config *")] ma_waveform_config* pConfig, ma_waveform* pWaveform);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_waveform_uninit(ma_waveform* pWaveform);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_waveform_read_pcm_frames(ma_waveform* pWaveform, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_waveform_seek_to_pcm_frame(ma_waveform* pWaveform, [NativeTypeName("ma_uint64")] ulong frameIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_waveform_set_amplitude(ma_waveform* pWaveform, double amplitude);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_waveform_set_frequency(ma_waveform* pWaveform, double frequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_waveform_set_type(ma_waveform* pWaveform, ma_waveform_type type);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_waveform_set_sample_rate(ma_waveform* pWaveform, [NativeTypeName("ma_uint32")] uint sampleRate);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_noise_config ma_noise_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, ma_noise_type type, [NativeTypeName("ma_int32")] int seed, double amplitude);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_noise_get_heap_size([NativeTypeName("const ma_noise_config *")] ma_noise_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_noise_init_preallocated([NativeTypeName("const ma_noise_config *")] ma_noise_config* pConfig, void* pHeap, ma_noise* pNoise);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_noise_init([NativeTypeName("const ma_noise_config *")] ma_noise_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_noise* pNoise);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_noise_uninit(ma_noise* pNoise, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_noise_read_pcm_frames(ma_noise* pNoise, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_noise_set_amplitude(ma_noise* pNoise, double amplitude);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_noise_set_seed(ma_noise* pNoise, [NativeTypeName("ma_int32")] int seed);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_noise_set_type(ma_noise* pNoise, ma_noise_type type);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_resource_manager_pipeline_notifications ma_resource_manager_pipeline_notifications_init();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_resource_manager_data_source_config ma_resource_manager_data_source_config_init();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_resource_manager_config ma_resource_manager_config_init();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_init([NativeTypeName("const ma_resource_manager_config *")] ma_resource_manager_config* pConfig, ma_resource_manager* pResourceManager);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_resource_manager_uninit(ma_resource_manager* pResourceManager);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_log* ma_resource_manager_get_log(ma_resource_manager* pResourceManager);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_register_file(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_uint32")] uint flags);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_register_file_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("ma_uint32")] uint flags);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_register_decoded_data(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pName, [NativeTypeName("const void *")] void* pData, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_register_decoded_data_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pName, [NativeTypeName("const void *")] void* pData, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_register_encoded_data(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pName, [NativeTypeName("const void *")] void* pData, [NativeTypeName("size_t")] nuint sizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_register_encoded_data_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pName, [NativeTypeName("const void *")] void* pData, [NativeTypeName("size_t")] nuint sizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_unregister_file(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pFilePath);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_unregister_file_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pFilePath);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_unregister_data(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pName);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_unregister_data_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pName);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_init_ex(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_resource_manager_data_source_config *")] ma_resource_manager_data_source_config* pConfig, ma_resource_manager_data_buffer* pDataBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_init(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_buffer* pDataBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_init_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_buffer* pDataBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_init_copy(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_resource_manager_data_buffer *")] ma_resource_manager_data_buffer* pExistingDataBuffer, ma_resource_manager_data_buffer* pDataBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_uninit(ma_resource_manager_data_buffer* pDataBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_read_pcm_frames(ma_resource_manager_data_buffer* pDataBuffer, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_seek_to_pcm_frame(ma_resource_manager_data_buffer* pDataBuffer, [NativeTypeName("ma_uint64")] ulong frameIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_get_data_format(ma_resource_manager_data_buffer* pDataBuffer, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_get_cursor_in_pcm_frames(ma_resource_manager_data_buffer* pDataBuffer, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_get_length_in_pcm_frames(ma_resource_manager_data_buffer* pDataBuffer, [NativeTypeName("ma_uint64 *")] ulong* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_result([NativeTypeName("const ma_resource_manager_data_buffer *")] ma_resource_manager_data_buffer* pDataBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_set_looping(ma_resource_manager_data_buffer* pDataBuffer, [NativeTypeName("ma_bool32")] uint isLooping);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_resource_manager_data_buffer_is_looping([NativeTypeName("const ma_resource_manager_data_buffer *")] ma_resource_manager_data_buffer* pDataBuffer);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_buffer_get_available_frames(ma_resource_manager_data_buffer* pDataBuffer, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_init_ex(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_resource_manager_data_source_config *")] ma_resource_manager_data_source_config* pConfig, ma_resource_manager_data_stream* pDataStream);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_init(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_stream* pDataStream);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_init_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_stream* pDataStream);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_uninit(ma_resource_manager_data_stream* pDataStream);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_read_pcm_frames(ma_resource_manager_data_stream* pDataStream, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_seek_to_pcm_frame(ma_resource_manager_data_stream* pDataStream, [NativeTypeName("ma_uint64")] ulong frameIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_get_data_format(ma_resource_manager_data_stream* pDataStream, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_get_cursor_in_pcm_frames(ma_resource_manager_data_stream* pDataStream, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_get_length_in_pcm_frames(ma_resource_manager_data_stream* pDataStream, [NativeTypeName("ma_uint64 *")] ulong* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_result([NativeTypeName("const ma_resource_manager_data_stream *")] ma_resource_manager_data_stream* pDataStream);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_set_looping(ma_resource_manager_data_stream* pDataStream, [NativeTypeName("ma_bool32")] uint isLooping);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_resource_manager_data_stream_is_looping([NativeTypeName("const ma_resource_manager_data_stream *")] ma_resource_manager_data_stream* pDataStream);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_stream_get_available_frames(ma_resource_manager_data_stream* pDataStream, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_init_ex(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_resource_manager_data_source_config *")] ma_resource_manager_data_source_config* pConfig, ma_resource_manager_data_source* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_init(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pName, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_source* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_init_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pName, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_source* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_init_copy(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_resource_manager_data_source *")] ma_resource_manager_data_source* pExistingDataSource, ma_resource_manager_data_source* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_uninit(ma_resource_manager_data_source* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_read_pcm_frames(ma_resource_manager_data_source* pDataSource, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_seek_to_pcm_frame(ma_resource_manager_data_source* pDataSource, [NativeTypeName("ma_uint64")] ulong frameIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_get_data_format(ma_resource_manager_data_source* pDataSource, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_get_cursor_in_pcm_frames(ma_resource_manager_data_source* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_get_length_in_pcm_frames(ma_resource_manager_data_source* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_result([NativeTypeName("const ma_resource_manager_data_source *")] ma_resource_manager_data_source* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_set_looping(ma_resource_manager_data_source* pDataSource, [NativeTypeName("ma_bool32")] uint isLooping);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_resource_manager_data_source_is_looping([NativeTypeName("const ma_resource_manager_data_source *")] ma_resource_manager_data_source* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_data_source_get_available_frames(ma_resource_manager_data_source* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_post_job(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_job *")] ma_job* pJob);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_post_job_quit(ma_resource_manager* pResourceManager);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_next_job(ma_resource_manager* pResourceManager, ma_job* pJob);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_process_job(ma_resource_manager* pResourceManager, ma_job* pJob);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_resource_manager_process_next_job(ma_resource_manager* pResourceManager);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_node_config ma_node_config_init();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_get_heap_size(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_node_config *")] ma_node_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_init_preallocated(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_node_config *")] ma_node_config* pConfig, void* pHeap, [NativeTypeName("ma_node *")] void* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_node_config *")] ma_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, [NativeTypeName("ma_node *")] void* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_node_uninit([NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_node_graph* ma_node_get_node_graph([NativeTypeName("const ma_node *")] void* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_node_get_input_bus_count([NativeTypeName("const ma_node *")] void* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_node_get_output_bus_count([NativeTypeName("const ma_node *")] void* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_node_get_input_channels([NativeTypeName("const ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint inputBusIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_node_get_output_channels([NativeTypeName("const ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint outputBusIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_attach_output_bus([NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint outputBusIndex, [NativeTypeName("ma_node *")] void* pOtherNode, [NativeTypeName("ma_uint32")] uint otherNodeInputBusIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_detach_output_bus([NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint outputBusIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_detach_all_output_buses([NativeTypeName("ma_node *")] void* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_set_output_bus_volume([NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint outputBusIndex, float volume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_node_get_output_bus_volume([NativeTypeName("const ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint outputBusIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_set_state([NativeTypeName("ma_node *")] void* pNode, ma_node_state state);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_node_state ma_node_get_state([NativeTypeName("const ma_node *")] void* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_set_state_time([NativeTypeName("ma_node *")] void* pNode, ma_node_state state, [NativeTypeName("ma_uint64")] ulong globalTime);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_node_get_state_time([NativeTypeName("const ma_node *")] void* pNode, ma_node_state state);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_node_state ma_node_get_state_by_time([NativeTypeName("const ma_node *")] void* pNode, [NativeTypeName("ma_uint64")] ulong globalTime);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_node_state ma_node_get_state_by_time_range([NativeTypeName("const ma_node *")] void* pNode, [NativeTypeName("ma_uint64")] ulong globalTimeBeg, [NativeTypeName("ma_uint64")] ulong globalTimeEnd);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_node_get_time([NativeTypeName("const ma_node *")] void* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_set_time([NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("ma_uint64")] ulong localTime);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_node_graph_config ma_node_graph_config_init([NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_graph_init([NativeTypeName("const ma_node_graph_config *")] ma_node_graph_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_node_graph* pNodeGraph);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_node_graph_uninit(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_node *")]
    public static extern void* ma_node_graph_get_endpoint(ma_node_graph* pNodeGraph);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_graph_read_pcm_frames(ma_node_graph* pNodeGraph, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_node_graph_get_channels([NativeTypeName("const ma_node_graph *")] ma_node_graph* pNodeGraph);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_node_graph_get_time([NativeTypeName("const ma_node_graph *")] ma_node_graph* pNodeGraph);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_node_graph_set_time(ma_node_graph* pNodeGraph, [NativeTypeName("ma_uint64")] ulong globalTime);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_data_source_node_config ma_data_source_node_config_init([NativeTypeName("ma_data_source *")] void* pDataSource);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_data_source_node_config *")] ma_data_source_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_data_source_node* pDataSourceNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_data_source_node_uninit(ma_data_source_node* pDataSourceNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_data_source_node_set_looping(ma_data_source_node* pDataSourceNode, [NativeTypeName("ma_bool32")] uint isLooping);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_data_source_node_is_looping(ma_data_source_node* pDataSourceNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_splitter_node_config ma_splitter_node_config_init([NativeTypeName("ma_uint32")] uint channels);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_splitter_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_splitter_node_config *")] ma_splitter_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_splitter_node* pSplitterNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_splitter_node_uninit(ma_splitter_node* pSplitterNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_biquad_node_config ma_biquad_node_config_init([NativeTypeName("ma_uint32")] uint channels, float b0, float b1, float b2, float a0, float a1, float a2);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_biquad_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_biquad_node_config *")] ma_biquad_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_biquad_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_biquad_node_reinit([NativeTypeName("const ma_biquad_config *")] ma_biquad_config* pConfig, ma_biquad_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_biquad_node_uninit(ma_biquad_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_lpf_node_config ma_lpf_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_lpf_node_config *")] ma_lpf_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_lpf_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_lpf_node_reinit([NativeTypeName("const ma_lpf_config *")] ma_lpf_config* pConfig, ma_lpf_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_lpf_node_uninit(ma_lpf_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_hpf_node_config ma_hpf_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_hpf_node_config *")] ma_hpf_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hpf_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hpf_node_reinit([NativeTypeName("const ma_hpf_config *")] ma_hpf_config* pConfig, ma_hpf_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_hpf_node_uninit(ma_hpf_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_bpf_node_config ma_bpf_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_bpf_node_config *")] ma_bpf_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_bpf_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_bpf_node_reinit([NativeTypeName("const ma_bpf_config *")] ma_bpf_config* pConfig, ma_bpf_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_bpf_node_uninit(ma_bpf_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_notch_node_config ma_notch_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double q, double frequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_notch_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_notch_node_config *")] ma_notch_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_notch_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_notch_node_reinit([NativeTypeName("const ma_notch_config *")] ma_notch2_config* pConfig, ma_notch_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_notch_node_uninit(ma_notch_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_peak_node_config ma_peak_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double q, double frequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_peak_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_peak_node_config *")] ma_peak_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_peak_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_peak_node_reinit([NativeTypeName("const ma_peak_config *")] ma_peak2_config* pConfig, ma_peak_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_peak_node_uninit(ma_peak_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_loshelf_node_config ma_loshelf_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double q, double frequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_loshelf_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_loshelf_node_config *")] ma_loshelf_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_loshelf_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_loshelf_node_reinit([NativeTypeName("const ma_loshelf_config *")] ma_loshelf2_config* pConfig, ma_loshelf_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_loshelf_node_uninit(ma_loshelf_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_hishelf_node_config ma_hishelf_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double q, double frequency);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hishelf_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_hishelf_node_config *")] ma_hishelf_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hishelf_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_hishelf_node_reinit([NativeTypeName("const ma_hishelf_config *")] ma_hishelf2_config* pConfig, ma_hishelf_node* pNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_hishelf_node_uninit(ma_hishelf_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_delay_node_config ma_delay_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, [NativeTypeName("ma_uint32")] uint delayInFrames, float decay);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_delay_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_delay_node_config *")] ma_delay_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_delay_node* pDelayNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_delay_node_uninit(ma_delay_node* pDelayNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_delay_node_set_wet(ma_delay_node* pDelayNode, float value);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_delay_node_get_wet([NativeTypeName("const ma_delay_node *")] ma_delay_node* pDelayNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_delay_node_set_dry(ma_delay_node* pDelayNode, float value);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_delay_node_get_dry([NativeTypeName("const ma_delay_node *")] ma_delay_node* pDelayNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_delay_node_set_decay(ma_delay_node* pDelayNode, float value);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_delay_node_get_decay([NativeTypeName("const ma_delay_node *")] ma_delay_node* pDelayNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_engine_node_config ma_engine_node_config_init(ma_engine* pEngine, ma_engine_node_type type, [NativeTypeName("ma_uint32")] uint flags);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_node_get_heap_size([NativeTypeName("const ma_engine_node_config *")] ma_engine_node_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_node_init_preallocated([NativeTypeName("const ma_engine_node_config *")] ma_engine_node_config* pConfig, void* pHeap, ma_engine_node* pEngineNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_node_init([NativeTypeName("const ma_engine_node_config *")] ma_engine_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_engine_node* pEngineNode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_engine_node_uninit(ma_engine_node* pEngineNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_sound_config ma_sound_config_init();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_sound_config ma_sound_config_init_2(ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_sound_group_config")]
    public static extern ma_sound_config ma_sound_group_config_init();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_sound_group_config")]
    public static extern ma_sound_config ma_sound_group_config_init_2(ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_engine_config ma_engine_config_init();

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_init([NativeTypeName("const ma_engine_config *")] ma_engine_config* pConfig, ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_engine_uninit(ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_read_pcm_frames(ma_engine* pEngine, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_node_graph* ma_engine_get_node_graph(ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_resource_manager* ma_engine_get_resource_manager(ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_device* ma_engine_get_device(ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_log* ma_engine_get_log(ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_node *")]
    public static extern void* ma_engine_get_endpoint(ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_engine_get_time([NativeTypeName("const ma_engine *")] ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_set_time(ma_engine* pEngine, [NativeTypeName("ma_uint64")] ulong globalTime);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_engine_get_channels([NativeTypeName("const ma_engine *")] ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_engine_get_sample_rate([NativeTypeName("const ma_engine *")] ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_start(ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_stop(ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_set_volume(ma_engine* pEngine, float volume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_set_gain_db(ma_engine* pEngine, float gainDB);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_engine_get_listener_count([NativeTypeName("const ma_engine *")] ma_engine* pEngine);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_engine_find_closest_listener([NativeTypeName("const ma_engine *")] ma_engine* pEngine, float absolutePosX, float absolutePosY, float absolutePosZ);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_engine_listener_set_position(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_engine_listener_get_position([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_engine_listener_set_direction(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_engine_listener_get_direction([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_engine_listener_set_velocity(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_engine_listener_get_velocity([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_engine_listener_set_cone(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_engine_listener_get_cone([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float* pInnerAngleInRadians, float* pOuterAngleInRadians, float* pOuterGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_engine_listener_set_world_up(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_engine_listener_get_world_up([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_engine_listener_set_enabled(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, [NativeTypeName("ma_bool32")] uint isEnabled);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_engine_listener_is_enabled([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_play_sound_ex(ma_engine* pEngine, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint nodeInputBusIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_engine_play_sound(ma_engine* pEngine, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_init_from_file(ma_engine* pEngine, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_fence* pDoneFence, ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_init_from_file_w(ma_engine* pEngine, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_fence* pDoneFence, ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_init_copy(ma_engine* pEngine, [NativeTypeName("const ma_sound *")] ma_sound* pExistingSound, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_init_from_data_source(ma_engine* pEngine, [NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_init_ex(ma_engine* pEngine, [NativeTypeName("const ma_sound_config *")] ma_sound_config* pConfig, ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_uninit(ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_engine* ma_sound_get_engine([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_data_source *")]
    public static extern void* ma_sound_get_data_source([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_start(ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_stop(ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_volume(ma_sound* pSound, float volume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_get_volume([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_pan(ma_sound* pSound, float pan);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_get_pan([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_pan_mode(ma_sound* pSound, ma_pan_mode panMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_pan_mode ma_sound_get_pan_mode([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_pitch(ma_sound* pSound, float pitch);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_get_pitch([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_spatialization_enabled(ma_sound* pSound, [NativeTypeName("ma_bool32")] uint enabled);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_sound_is_spatialization_enabled([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_pinned_listener_index(ma_sound* pSound, [NativeTypeName("ma_uint32")] uint listenerIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_sound_get_pinned_listener_index([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_sound_get_listener_index([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_sound_get_direction_to_listener([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_position(ma_sound* pSound, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_sound_get_position([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_direction(ma_sound* pSound, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_sound_get_direction([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_velocity(ma_sound* pSound, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_sound_get_velocity([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_attenuation_model(ma_sound* pSound, ma_attenuation_model attenuationModel);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_attenuation_model ma_sound_get_attenuation_model([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_positioning(ma_sound* pSound, ma_positioning positioning);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_positioning ma_sound_get_positioning([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_rolloff(ma_sound* pSound, float rolloff);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_get_rolloff([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_min_gain(ma_sound* pSound, float minGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_get_min_gain([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_max_gain(ma_sound* pSound, float maxGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_get_max_gain([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_min_distance(ma_sound* pSound, float minDistance);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_get_min_distance([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_max_distance(ma_sound* pSound, float maxDistance);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_get_max_distance([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_cone(ma_sound* pSound, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_get_cone([NativeTypeName("const ma_sound *")] ma_sound* pSound, float* pInnerAngleInRadians, float* pOuterAngleInRadians, float* pOuterGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_doppler_factor(ma_sound* pSound, float dopplerFactor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_get_doppler_factor([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_directional_attenuation_factor(ma_sound* pSound, float directionalAttenuationFactor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_get_directional_attenuation_factor([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_fade_in_pcm_frames(ma_sound* pSound, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong fadeLengthInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_fade_in_milliseconds(ma_sound* pSound, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong fadeLengthInMilliseconds);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_get_current_fade_volume(ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_start_time_in_pcm_frames(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_start_time_in_milliseconds(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInMilliseconds);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_stop_time_in_pcm_frames(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_stop_time_in_milliseconds(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInMilliseconds);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_sound_is_playing([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_sound_get_time_in_pcm_frames([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_set_looping(ma_sound* pSound, [NativeTypeName("ma_bool32")] uint isLooping);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_sound_is_looping([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_sound_at_end([NativeTypeName("const ma_sound *")] ma_sound* pSound);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_seek_to_pcm_frame(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong frameIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_get_data_format(ma_sound* pSound, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_get_cursor_in_pcm_frames(ma_sound* pSound, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_get_length_in_pcm_frames(ma_sound* pSound, [NativeTypeName("ma_uint64 *")] ulong* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_get_cursor_in_seconds(ma_sound* pSound, float* pCursor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_get_length_in_seconds(ma_sound* pSound, float* pLength);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_group_init(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_sound_group *")] ma_sound* pParentGroup, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_group_init_ex(ma_engine* pEngine, [NativeTypeName("const ma_sound_group_config *")] ma_sound_config* pConfig, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_uninit([NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_engine* ma_sound_group_get_engine([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_group_start([NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_result ma_sound_group_stop([NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_volume([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float volume);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_group_get_volume([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_pan([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float pan);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_group_get_pan([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_pan_mode([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_pan_mode panMode);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_pan_mode ma_sound_group_get_pan_mode([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_pitch([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float pitch);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_group_get_pitch([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_spatialization_enabled([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_bool32")] uint enabled);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_sound_group_is_spatialization_enabled([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_pinned_listener_index([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_uint32")] uint listenerIndex);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_sound_group_get_pinned_listener_index([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint32")]
    public static extern uint ma_sound_group_get_listener_index([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_sound_group_get_direction_to_listener([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_position([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_sound_group_get_position([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_direction([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_sound_group_get_direction([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_velocity([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float x, float y, float z);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_vec3f ma_sound_group_get_velocity([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_attenuation_model([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_attenuation_model attenuationModel);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_attenuation_model ma_sound_group_get_attenuation_model([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_positioning([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_positioning positioning);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern ma_positioning ma_sound_group_get_positioning([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_rolloff([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float rolloff);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_group_get_rolloff([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_min_gain([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float minGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_group_get_min_gain([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_max_gain([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float maxGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_group_get_max_gain([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_min_distance([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float minDistance);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_group_get_min_distance([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_max_distance([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float maxDistance);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_group_get_max_distance([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_cone([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_get_cone([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup, float* pInnerAngleInRadians, float* pOuterAngleInRadians, float* pOuterGain);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_doppler_factor([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float dopplerFactor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_group_get_doppler_factor([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_directional_attenuation_factor([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float directionalAttenuationFactor);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_group_get_directional_attenuation_factor([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_fade_in_pcm_frames([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong fadeLengthInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_fade_in_milliseconds([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong fadeLengthInMilliseconds);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern float ma_sound_group_get_current_fade_volume([NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_start_time_in_pcm_frames([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_start_time_in_milliseconds([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInMilliseconds);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_stop_time_in_pcm_frames([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInFrames);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void ma_sound_group_set_stop_time_in_milliseconds([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInMilliseconds);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_bool32")]
    public static extern uint ma_sound_group_is_playing([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

    [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("ma_uint64")]
    public static extern ulong ma_sound_group_get_time_in_pcm_frames([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);
}
