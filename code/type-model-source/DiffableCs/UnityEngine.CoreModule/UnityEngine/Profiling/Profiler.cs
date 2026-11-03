namespace UnityEngine.Profiling;

[MovedFrom("UnityEngine")]
[NativeHeader("NativeKernel/Allocator/MemoryManager.h")]
[NativeHeader("Runtime/Profiler/Profiler.h")]
[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
[NativeHeader("Runtime/Profiler/MemoryProfiler.h")]
[NativeHeader("NativeKernel/Utilities/MemoryUtilities.h")]
[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
[Token(Token = "0x2000201")]
[UsedByNativeCode]
public sealed class Profiler
{

	[Token(Token = "0x1700036E")]
	public static bool enabled
	{
		[Address(RVA = "0x3081AD0", Offset = "0x3080ED0", Length = "0x2A")]
		[NativeConditional("ENABLE_PROFILER")]
		[NativeMethod(Name = "profiler_is_enabled", IsFreeFunction = True, IsThreadSafe = True)]
		[Token(Token = "0x6001709")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x3081AD0", Offset = "0x3080ED0", Length = "0x2A")]
	[NativeConditional("ENABLE_PROFILER")]
	[NativeMethod(Name = "profiler_is_enabled", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6001709")]
	public static bool get_enabled() { }

	[Address(RVA = "0x3081A30", Offset = "0x3080E30", Length = "0x97")]
	[NativeMethod(Name = "ProfilerBindings::GetRuntimeMemorySizeLong", IsFreeFunction = True)]
	[Token(Token = "0x600170A")]
	public static long GetRuntimeMemorySizeLong(object o) { }

	[Address(RVA = "0x30819F0", Offset = "0x3080DF0", Length = "0x33")]
	[Token(Token = "0x600170B")]
	private static long GetRuntimeMemorySizeLong_Injected(IntPtr o) { }

}

