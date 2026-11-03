namespace Unity.Jobs;

[Extension]
[Token(Token = "0x200000D")]
public static class IJobExtensions
{
	[Token(Token = "0x200000E")]
	public struct JobStruct
	{
		[Token(Token = "0x200000F")]
		public sealed class ExecuteJobFunction : MulticastDelegate
		{

			[Address(RVA = "0x1BB00E0", Offset = "0x1BAF4E0", Length = "0xB5")]
			[Token(Token = "0x6000014")]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
			[Token(Token = "0x6000015")]
			public override void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		[Token(Token = "0x400000A")]
		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[Address(RVA = "0xAC8B00", Offset = "0xAC7F00", Length = "0x8F")]
		[Token(Token = "0x6000013")]
		private static JobStruct`1() { }

		[Address(RVA = "0xAC4350", Offset = "0xAC3750", Length = "0x3B")]
		[Token(Token = "0x6000012")]
		public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[Address(RVA = "0xAC4860", Offset = "0xAC3C60", Length = "0x259")]
		[BurstDiscard]
		[Token(Token = "0x6000011")]
		internal static void Initialize() { }

	}


	[Address(RVA = "0x8206E0", Offset = "0x81FAE0", Length = "0x50")]
	[Token(Token = "0x600000E")]
	public static void EarlyJobInit() { }

	[Address(RVA = "0x821A50", Offset = "0x820E50", Length = "0xA2")]
	[Token(Token = "0x600000F")]
	private static IntPtr GetReflectionData() { }

	[Address(RVA = "0x823840", Offset = "0x822C40", Length = "0x140")]
	[Extension]
	[Token(Token = "0x6000010")]
	public static JobHandle Schedule(T jobData, JobHandle dependsOn = null) { }

}

