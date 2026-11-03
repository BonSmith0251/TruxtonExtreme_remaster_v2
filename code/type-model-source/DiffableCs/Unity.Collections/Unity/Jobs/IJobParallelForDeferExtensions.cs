namespace Unity.Jobs;

[Extension]
[Token(Token = "0x2000014")]
public static class IJobParallelForDeferExtensions
{
	[Token(Token = "0x2000015")]
	public struct JobParallelForDeferProducer
	{
		[Token(Token = "0x2000016")]
		internal sealed class ExecuteJobFunction : MulticastDelegate
		{

			[Address(RVA = "0x1BB00E0", Offset = "0x1BAF4E0", Length = "0xB5")]
			[Token(Token = "0x6000043")]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[Address(RVA = "0x1BAF080", Offset = "0x1BAE480", Length = "0xF9")]
			[Token(Token = "0x6000045")]
			public override IAsyncResult BeginInvoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }

			[Address(RVA = "0x1BB00A0", Offset = "0x1BAF4A0", Length = "0x20")]
			[Token(Token = "0x6000046")]
			public override void EndInvoke(ref T jobData, ref JobRanges ranges, IAsyncResult result) { }

			[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
			[Token(Token = "0x6000044")]
			public override void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		[Token(Token = "0x400000C")]
		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[Address(RVA = "0xAC3C80", Offset = "0xAC3080", Length = "0xAF")]
		[Token(Token = "0x6000042")]
		private static JobParallelForDeferProducer`1() { }

		[Address(RVA = "0xAC3D30", Offset = "0xAC3130", Length = "0x199")]
		[Token(Token = "0x6000041")]
		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[Address(RVA = "0xAC3ED0", Offset = "0xAC32D0", Length = "0x27C")]
		[BurstDiscard]
		[Token(Token = "0x6000040")]
		internal static void Initialize() { }

	}


	[Address(RVA = "0x820680", Offset = "0x81FA80", Length = "0x51")]
	[Token(Token = "0x600003A")]
	public static void EarlyJobInit() { }

	[Address(RVA = "0x82A900", Offset = "0x829D00", Length = "0xB6")]
	[Extension]
	[Token(Token = "0x600003B")]
	public static JobHandle Schedule(T jobData, NativeList<U> list, int innerloopBatchCount, JobHandle dependsOn = null) { }

	[Address(RVA = "0x82A9C0", Offset = "0x829DC0", Length = "0xA6")]
	[Extension]
	[Token(Token = "0x600003D")]
	public static JobHandle Schedule(T jobData, Int32* forEachCount, int innerloopBatchCount, JobHandle dependsOn = null) { }

	[Address(RVA = "0x82A900", Offset = "0x829D00", Length = "0xB6")]
	[Extension]
	[Token(Token = "0x600003C")]
	public static JobHandle ScheduleByRef(ref T jobData, NativeList<U> list, int innerloopBatchCount, JobHandle dependsOn = null) { }

	[Address(RVA = "0x82A9C0", Offset = "0x829DC0", Length = "0xA6")]
	[Extension]
	[Token(Token = "0x600003E")]
	public static JobHandle ScheduleByRef(ref T jobData, Int32* forEachCount, int innerloopBatchCount, JobHandle dependsOn = null) { }

	[Address(RVA = "0x82AA70", Offset = "0x829E70", Length = "0x15B")]
	[Token(Token = "0x600003F")]
	private static JobHandle ScheduleInternal(ref T jobData, int innerloopBatchCount, Void* forEachListPtr, Void* atomicSafetyHandlePtr, JobHandle dependsOn) { }

}

