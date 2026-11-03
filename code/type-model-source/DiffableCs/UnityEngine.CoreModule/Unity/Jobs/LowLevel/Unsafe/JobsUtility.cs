namespace Unity.Jobs.LowLevel.Unsafe;

[NativeHeader("Runtime/Jobs/JobSystem.h")]
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
[Token(Token = "0x200001C")]
public static class JobsUtility
{
	[Token(Token = "0x200001D")]
	internal struct JobScheduleParameters
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001A")]
		public JobHandle Dependency; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400001B")]
		public int ScheduleMode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001C")]
		public IntPtr ReflectionData; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400001D")]
		public IntPtr JobDataPtr; //Field offset: 0x20

		[Address(RVA = "0x2FE29B0", Offset = "0x2FE1DB0", Length = "0x3E")]
		[Token(Token = "0x600004C")]
		public JobScheduleParameters(Void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

	}

	[Token(Token = "0x200001E")]
	public sealed class PanicFunction_ : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x600004D")]
		public PanicFunction_(object object, IntPtr method) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x600004E")]
		public override void Invoke() { }

	}

	[Token(Token = "0x4000019")]
	internal static PanicFunction_ PanicFunction; //Field offset: 0x0

	[Token(Token = "0x17000002")]
	public static bool IsExecutingJob
	{
		[Address(RVA = "0x2FE2F70", Offset = "0x2FE2370", Length = "0x2A")]
		[NativeMethod(Name = "GetIsExecutingScriptingJob", IsFreeFunction = True, IsThreadSafe = True)]
		[Token(Token = "0x6000041")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000003")]
	public static bool JobCompilerEnabled
	{
		[Address(RVA = "0x2FE3000", Offset = "0x2FE2400", Length = "0x33")]
		[FreeFunction]
		[Token(Token = "0x6000042")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000004")]
	public static int JobWorkerCount
	{
		[Address(RVA = "0x2FE2B30", Offset = "0x2FE1F30", Length = "0x2A")]
		[Token(Token = "0x6000044")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000005")]
	public static int ThreadIndex
	{
		[Address(RVA = "0x2FE2FD0", Offset = "0x2FE23D0", Length = "0x2A")]
		[BurstAuthorizedExternalMethod]
		[FreeFunction("GetJobWorkerIndex", IsThreadSafe = True)]
		[Token(Token = "0x6000045")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000006")]
	public static int ThreadIndexCount
	{
		[Address(RVA = "0x2FE2FA0", Offset = "0x2FE23A0", Length = "0x2A")]
		[BurstAuthorizedExternalMethod]
		[FreeFunction("GetJobWorkerIndexCount", IsThreadSafe = True)]
		[Token(Token = "0x6000046")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2FE2AD0", Offset = "0x2FE1ED0", Length = "0x5E")]
	[Token(Token = "0x6000040")]
	public static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0) { }

	[Address(RVA = "0x2FE2A60", Offset = "0x2FE1E60", Length = "0x62")]
	[FreeFunction(ThrowsException = True, IsThreadSafe = True)]
	[Token(Token = "0x600003E")]
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	[Address(RVA = "0x2FE29F0", Offset = "0x2FE1DF0", Length = "0x67")]
	[Token(Token = "0x600003F")]
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1 = null, object managedJobFunction2 = null) { }

	[Address(RVA = "0x2FE2F70", Offset = "0x2FE2370", Length = "0x2A")]
	[NativeMethod(Name = "GetIsExecutingScriptingJob", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6000041")]
	public static bool get_IsExecutingJob() { }

	[Address(RVA = "0x2FE2B30", Offset = "0x2FE1F30", Length = "0x2A")]
	[Token(Token = "0x6000044")]
	public static int get_JobWorkerCount() { }

	[Address(RVA = "0x2FE2FD0", Offset = "0x2FE23D0", Length = "0x2A")]
	[BurstAuthorizedExternalMethod]
	[FreeFunction("GetJobWorkerIndex", IsThreadSafe = True)]
	[Token(Token = "0x6000045")]
	public static int get_ThreadIndex() { }

	[Address(RVA = "0x2FE2FA0", Offset = "0x2FE23A0", Length = "0x2A")]
	[BurstAuthorizedExternalMethod]
	[FreeFunction("GetJobWorkerIndexCount", IsThreadSafe = True)]
	[Token(Token = "0x6000046")]
	public static int get_ThreadIndexCount() { }

	[Address(RVA = "0x2FE2B30", Offset = "0x2FE1F30", Length = "0x2A")]
	[FreeFunction("JobSystem::GetJobQueueWorkerThreadCount")]
	[Token(Token = "0x6000043")]
	private static int GetJobQueueWorkerThreadCount() { }

	[Address(RVA = "0x2FE2B60", Offset = "0x2FE1F60", Length = "0x4A")]
	[Token(Token = "0x6000038")]
	public static void GetJobRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[Address(RVA = "0x2FE2BB0", Offset = "0x2FE1FB0", Length = "0x60")]
	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6000039")]
	public static bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	[Address(RVA = "0x2FE2C10", Offset = "0x2FE2010", Length = "0x4E")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000047")]
	private static void InvokePanicFunction() { }

	[Address(RVA = "0x2FE2F20", Offset = "0x2FE2320", Length = "0x4B")]
	[FreeFunction("ScheduleManagedJob", ThrowsException = True, IsThreadSafe = True)]
	[Token(Token = "0x600003A")]
	public static JobHandle Schedule(ref JobScheduleParameters parameters) { }

	[Address(RVA = "0x2FE2ED0", Offset = "0x2FE22D0", Length = "0x42")]
	[Token(Token = "0x6000048")]
	private static void Schedule_Injected(ref JobScheduleParameters parameters, out JobHandle ret) { }

	[Address(RVA = "0x2FE2E60", Offset = "0x2FE2260", Length = "0x6A")]
	[FreeFunction("ScheduleManagedJobParallelFor", ThrowsException = True, IsThreadSafe = True)]
	[Token(Token = "0x600003B")]
	public static JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	[Address(RVA = "0x2FE2E00", Offset = "0x2FE2200", Length = "0x60")]
	[Token(Token = "0x6000049")]
	private static void ScheduleParallelFor_Injected(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

	[Address(RVA = "0x2FE2CC0", Offset = "0x2FE20C0", Length = "0x71")]
	[FreeFunction("ScheduleManagedJobParallelForDeferArraySize", ThrowsException = True, IsThreadSafe = True)]
	[Token(Token = "0x600003C")]
	public static JobHandle ScheduleParallelForDeferArraySize(ref JobScheduleParameters parameters, int innerloopBatchCount, Void* listData, Void* listDataAtomicSafetyHandle) { }

	[Address(RVA = "0x2FE2C60", Offset = "0x2FE2060", Length = "0x60")]
	[Token(Token = "0x600004A")]
	private static void ScheduleParallelForDeferArraySize_Injected(ref JobScheduleParameters parameters, int innerloopBatchCount, Void* listData, Void* listDataAtomicSafetyHandle, out JobHandle ret) { }

	[Address(RVA = "0x2FE2DA0", Offset = "0x2FE21A0", Length = "0x5B")]
	[FreeFunction("ScheduleManagedJobParallelForTransform", ThrowsException = True)]
	[Token(Token = "0x600003D")]
	public static JobHandle ScheduleParallelForTransform(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray) { }

	[Address(RVA = "0x2FE2D40", Offset = "0x2FE2140", Length = "0x52")]
	[Token(Token = "0x600004B")]
	private static void ScheduleParallelForTransform_Injected(ref JobScheduleParameters parameters, IntPtr transfromAccesssArray, out JobHandle ret) { }

	[Address(RVA = "0x2FE3000", Offset = "0x2FE2400", Length = "0x33")]
	[FreeFunction]
	[Token(Token = "0x6000042")]
	public static void set_JobCompilerEnabled(bool value) { }

}

