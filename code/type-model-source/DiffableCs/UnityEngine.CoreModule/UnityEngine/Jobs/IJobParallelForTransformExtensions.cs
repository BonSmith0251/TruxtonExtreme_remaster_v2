namespace UnityEngine.Jobs;

[Extension]
[Token(Token = "0x2000207")]
public static class IJobParallelForTransformExtensions
{
	[Token(Token = "0x2000208")]
	public struct TransformParallelForLoopStruct
	{
		[Token(Token = "0x200020A")]
		internal sealed class ExecuteJobFunction : MulticastDelegate
		{

			[Address(RVA = "0x1BB00E0", Offset = "0x1BAF4E0", Length = "0xB5")]
			[Token(Token = "0x6001728")]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
			[Token(Token = "0x6001729")]
			public override void Invoke(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		[Token(Token = "0x2000209")]
		private struct TransformJobData
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400073C")]
			public IntPtr TransformAccessArray; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400073D")]
			public int IsReadOnly; //Field offset: 0x0

		}

		[Token(Token = "0x400073B")]
		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[Address(RVA = "0x1092B00", Offset = "0x1091F00", Length = "0xAF")]
		[Token(Token = "0x6001727")]
		private static TransformParallelForLoopStruct`1() { }

		[Address(RVA = "0x1090870", Offset = "0x108FC70", Length = "0x3D8")]
		[Token(Token = "0x6001726")]
		public static void Execute(ref T jobData, IntPtr jobData2, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[Address(RVA = "0x1092330", Offset = "0x1091730", Length = "0x27C")]
		[BurstDiscard]
		[Token(Token = "0x6001725")]
		internal static void Initialize() { }

	}


	[Address(RVA = "0x820680", Offset = "0x81FA80", Length = "0x51")]
	[Token(Token = "0x6001722")]
	public static void EarlyJobInit() { }

	[Address(RVA = "0x8210B0", Offset = "0x8204B0", Length = "0xA2")]
	[Token(Token = "0x6001723")]
	private static IntPtr GetReflectionData() { }

	[Address(RVA = "0x82EEC0", Offset = "0x82E2C0", Length = "0xE8")]
	[Extension]
	[Token(Token = "0x6001724")]
	public static JobHandle Schedule(T jobData, TransformAccessArray transforms, JobHandle dependsOn = null) { }

}

