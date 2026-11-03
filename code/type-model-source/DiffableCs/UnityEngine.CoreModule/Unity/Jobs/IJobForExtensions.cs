namespace Unity.Jobs;

[Extension]
[Token(Token = "0x2000011")]
public static class IJobForExtensions
{
	[Token(Token = "0x2000012")]
	public struct ForJobStruct
	{
		[Token(Token = "0x2000013")]
		internal sealed class ExecuteJobFunction : MulticastDelegate
		{

			[Address(RVA = "0x1BB00E0", Offset = "0x1BAF4E0", Length = "0xB5")]
			[Token(Token = "0x600001E")]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
			[Token(Token = "0x600001F")]
			public override void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		[Token(Token = "0x400000B")]
		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[Address(RVA = "0xAC8B00", Offset = "0xAC7F00", Length = "0x8F")]
		[Token(Token = "0x600001D")]
		private static ForJobStruct`1() { }

		[Address(RVA = "0x1C0BB60", Offset = "0x1C0AF60", Length = "0xDC")]
		[Token(Token = "0x600001C")]
		public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[Address(RVA = "0x1C0CCD0", Offset = "0x1C0C0D0", Length = "0x259")]
		[BurstDiscard]
		[Token(Token = "0x600001B")]
		internal static void Initialize() { }

	}


	[Address(RVA = "0x820680", Offset = "0x81FA80", Length = "0x51")]
	[Token(Token = "0x6000017")]
	public static void EarlyJobInit() { }

	[Address(RVA = "0x824EA0", Offset = "0x8242A0", Length = "0xA2")]
	[Token(Token = "0x6000018")]
	private static IntPtr GetReflectionData() { }

	[Address(RVA = "0x825B80", Offset = "0x824F80", Length = "0x152")]
	[Extension]
	[Token(Token = "0x6000019")]
	public static JobHandle ScheduleParallel(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependency) { }

	[Address(RVA = "0x825840", Offset = "0x824C40", Length = "0xEC")]
	[Extension]
	[Token(Token = "0x600001A")]
	public static JobHandle ScheduleParallelByRef(ref T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependency) { }

}

