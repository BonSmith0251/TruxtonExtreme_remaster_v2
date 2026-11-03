namespace Unity.Jobs;

[Extension]
[Token(Token = "0x2000010")]
public static class IJobParallelForBatchExtensions
{
	[Token(Token = "0x2000011")]
	public struct JobParallelForBatchProducer
	{
		[Token(Token = "0x2000012")]
		public sealed class ExecuteJobFunction : MulticastDelegate
		{

			[Address(RVA = "0x1BB00E0", Offset = "0x1BAF4E0", Length = "0xB5")]
			[Token(Token = "0x6000035")]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[Address(RVA = "0x1BAFFB0", Offset = "0x1BAF3B0", Length = "0xEE")]
			[Token(Token = "0x6000037")]
			public override IAsyncResult BeginInvoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }

			[Address(RVA = "0x1BB00A0", Offset = "0x1BAF4A0", Length = "0x20")]
			[Token(Token = "0x6000038")]
			public override void EndInvoke(ref T jobData, ref JobRanges ranges, IAsyncResult result) { }

			[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
			[Token(Token = "0x6000036")]
			public override void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		[Token(Token = "0x400000B")]
		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[Address(RVA = "0xAC3BF0", Offset = "0xAC2FF0", Length = "0x8F")]
		[Token(Token = "0x6000034")]
		private static JobParallelForBatchProducer`1() { }

		[Address(RVA = "0xAC13D0", Offset = "0xAC07D0", Length = "0xD6")]
		[Token(Token = "0x6000033")]
		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[Address(RVA = "0xAC2DB0", Offset = "0xAC21B0", Length = "0x259")]
		[BurstDiscard]
		[Token(Token = "0x6000032")]
		internal static void Initialize() { }

	}


	[Address(RVA = "0x8267E0", Offset = "0x825BE0", Length = "0x50")]
	[Token(Token = "0x6000026")]
	public static void EarlyJobInit() { }

	[Address(RVA = "0x826C40", Offset = "0x826040", Length = "0xA2")]
	[Token(Token = "0x6000027")]
	private static IntPtr GetReflectionData() { }

	[Address(RVA = "0x8277B0", Offset = "0x826BB0", Length = "0xB5")]
	[Extension]
	[Token(Token = "0x600002E")]
	public static void Run(T jobData, int arrayLength, int indicesPerJobCount) { }

	[Address(RVA = "0x827630", Offset = "0x826A30", Length = "0xBE")]
	[Extension]
	[Token(Token = "0x6000030")]
	public static void RunBatch(T jobData, int arrayLength) { }

	[Address(RVA = "0x8275E0", Offset = "0x8269E0", Length = "0x4B")]
	[Extension]
	[Token(Token = "0x6000031")]
	public static void RunBatchByRef(ref T jobData, int arrayLength) { }

	[Address(RVA = "0x8276F0", Offset = "0x826AF0", Length = "0xB5")]
	[Extension]
	[Token(Token = "0x600002F")]
	public static void RunByRef(ref T jobData, int arrayLength, int indicesPerJobCount) { }

	[Address(RVA = "0x82A810", Offset = "0x829C10", Length = "0xE9")]
	[Extension]
	[Token(Token = "0x6000028")]
	public static JobHandle Schedule(T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[Address(RVA = "0x827910", Offset = "0x826D10", Length = "0x191")]
	[Extension]
	[Token(Token = "0x600002C")]
	public static JobHandle ScheduleBatch(T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[Address(RVA = "0x827870", Offset = "0x826C70", Length = "0x9C")]
	[Extension]
	[Token(Token = "0x600002D")]
	public static JobHandle ScheduleBatchByRef(ref T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[Address(RVA = "0x8292E0", Offset = "0x8286E0", Length = "0xE9")]
	[Extension]
	[Token(Token = "0x6000029")]
	public static JobHandle ScheduleByRef(ref T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[Address(RVA = "0x8294C0", Offset = "0x8288C0", Length = "0x14F")]
	[Extension]
	[Token(Token = "0x600002A")]
	public static JobHandle ScheduleParallel(T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

	[Address(RVA = "0x8293D0", Offset = "0x8287D0", Length = "0xE9")]
	[Extension]
	[Token(Token = "0x600002B")]
	public static JobHandle ScheduleParallelByRef(ref T jobData, int arrayLength, int indicesPerJobCount, JobHandle dependsOn = null) { }

}

