namespace Unity.Jobs;

[Extension]
[Token(Token = "0x2000015")]
public static class IJobParallelForExtensions
{
	[Token(Token = "0x2000016")]
	public struct ParallelForJobStruct
	{
		[Token(Token = "0x2000017")]
		internal sealed class ExecuteJobFunction : MulticastDelegate
		{

			[Address(RVA = "0x1BB00E0", Offset = "0x1BAF4E0", Length = "0xB5")]
			[Token(Token = "0x6000028")]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
			[Token(Token = "0x6000029")]
			public override void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		[Token(Token = "0x400000C")]
		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[Address(RVA = "0xAC8B00", Offset = "0xAC7F00", Length = "0x8F")]
		[Token(Token = "0x6000027")]
		private static ParallelForJobStruct`1() { }

		[Address(RVA = "0xE147E0", Offset = "0xE13BE0", Length = "0xDC")]
		[Token(Token = "0x6000026")]
		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[Address(RVA = "0xE150C0", Offset = "0xE144C0", Length = "0x259")]
		[BurstDiscard]
		[Token(Token = "0x6000025")]
		internal static void Initialize() { }

	}


	[Address(RVA = "0x82ABD0", Offset = "0x829FD0", Length = "0x50")]
	[Token(Token = "0x6000021")]
	public static void EarlyJobInit() { }

	[Address(RVA = "0x82BEE0", Offset = "0x82B2E0", Length = "0xA2")]
	[Token(Token = "0x6000022")]
	private static IntPtr GetReflectionData() { }

	[Address(RVA = "0x82C3C0", Offset = "0x82B7C0", Length = "0x9C")]
	[Extension]
	[Token(Token = "0x6000024")]
	public static void Run(T jobData, int arrayLength) { }

	[Address(RVA = "0x82E070", Offset = "0x82D470", Length = "0x152")]
	[Extension]
	[Token(Token = "0x6000023")]
	public static JobHandle Schedule(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn = null) { }

}

