namespace Unity.Jobs;

[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
[Token(Token = "0x2000018")]
public struct JobHandle : IEquatable<JobHandle>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000D")]
	internal ulong jobGroup; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400000E")]
	internal int version; //Field offset: 0x8

	[Token(Token = "0x17000001")]
	public bool IsCompleted
	{
		[Address(RVA = "0x2FE2940", Offset = "0x2FE1D40", Length = "0x33")]
		[Token(Token = "0x600002B")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x2FE2840", Offset = "0x2FE1C40", Length = "0x6A")]
	[Token(Token = "0x600002F")]
	public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1) { }

	[Address(RVA = "0x2FE26D0", Offset = "0x2FE1AD0", Length = "0xA2")]
	[Token(Token = "0x6000030")]
	public static JobHandle CombineDependencies(NativeArray<JobHandle> jobs) { }

	[Address(RVA = "0x2FE2780", Offset = "0x2FE1B80", Length = "0xBE")]
	[Token(Token = "0x6000031")]
	public static JobHandle CombineDependencies(NativeSlice<JobHandle> jobs) { }

	[Address(RVA = "0x2FE25C0", Offset = "0x2FE19C0", Length = "0x5B")]
	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000032")]
	private static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1) { }

	[Address(RVA = "0x2FE2560", Offset = "0x2FE1960", Length = "0x52")]
	[Token(Token = "0x6000035")]
	private static void CombineDependenciesInternal2_Injected(ref JobHandle job0, ref JobHandle job1, out JobHandle ret) { }

	[Address(RVA = "0x2FE2670", Offset = "0x2FE1A70", Length = "0x5A")]
	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000033")]
	internal static JobHandle CombineDependenciesInternalPtr(Void* jobs, int count) { }

	[Address(RVA = "0x2FE2620", Offset = "0x2FE1A20", Length = "0x50")]
	[Token(Token = "0x6000036")]
	private static void CombineDependenciesInternalPtr_Injected(Void* jobs, int count, out JobHandle ret) { }

	[Address(RVA = "0x2FE28B0", Offset = "0x2FE1CB0", Length = "0x3F")]
	[Token(Token = "0x600002A")]
	public void Complete() { }

	[Address(RVA = "0x2FE28F0", Offset = "0x2FE1CF0", Length = "0xC")]
	[Token(Token = "0x6000034")]
	public override bool Equals(JobHandle other) { }

	[Address(RVA = "0x2FE2940", Offset = "0x2FE1D40", Length = "0x33")]
	[Token(Token = "0x600002B")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x2FE2980", Offset = "0x2FE1D80", Length = "0x2A")]
	[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x600002C")]
	public static void ScheduleBatchedJobs() { }

	[Address(RVA = "0x2FE2900", Offset = "0x2FE1D00", Length = "0x33")]
	[NativeMethod("ScheduleBatchedScriptingJobsAndComplete", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600002D")]
	private static void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	[Address(RVA = "0x2FE2940", Offset = "0x2FE1D40", Length = "0x33")]
	[NativeMethod("ScheduleBatchedScriptingJobsAndIsCompleted", IsFreeFunction = True, IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x600002E")]
	private static bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job) { }

}

