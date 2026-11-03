namespace Unity.Jobs;

[Extension]
[Token(Token = "0x200000B")]
public static class IJobFilterExtensions
{
	[Token(Token = "0x200000C")]
	public struct JobFilterProducer
	{
		[Token(Token = "0x200000E")]
		internal sealed class ExecuteJobFunction : MulticastDelegate
		{

			[Address(RVA = "0x1BB00E0", Offset = "0x1BAF4E0", Length = "0xB5")]
			[Token(Token = "0x6000021")]
			public ExecuteJobFunction(object object, IntPtr method) { }

			[Address(RVA = "0x1BAF910", Offset = "0x1BAED10", Length = "0xF9")]
			[Token(Token = "0x6000023")]
			public override IAsyncResult BeginInvoke(ref JobWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }

			[Address(RVA = "0x1BB00A0", Offset = "0x1BAF4A0", Length = "0x20")]
			[Token(Token = "0x6000024")]
			public override void EndInvoke(ref JobWrapper<T> jobWrapper, ref JobRanges ranges, IAsyncResult result) { }

			[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
			[Token(Token = "0x6000022")]
			public override void Invoke(ref JobWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		}

		[Token(Token = "0x200000D")]
		internal struct JobWrapper
		{
			[FieldOffset(Offset = "0x0")]
			[NativeDisableParallelForRestriction]
			[Token(Token = "0x4000008")]
			public NativeList<Int32> outputIndices; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000009")]
			public int appendCount; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400000A")]
			public T JobData; //Field offset: 0x0

		}

		[Token(Token = "0x4000007")]
		internal static readonly SharedStatic<IntPtr> jobReflectionData; //Field offset: 0x0

		[Address(RVA = "0xAC09A0", Offset = "0xABFDA0", Length = "0xAF")]
		[Token(Token = "0x6000020")]
		private static JobFilterProducer`1() { }

		[Address(RVA = "0xAC0560", Offset = "0xABF960", Length = "0x186")]
		[Token(Token = "0x600001D")]
		public static void Execute(ref JobWrapper<T> jobWrapper, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

		[Address(RVA = "0xABFF30", Offset = "0xABF330", Length = "0x38D")]
		[Token(Token = "0x600001E")]
		public static void ExecuteAppend(ref JobWrapper<T> jobWrapper, IntPtr bufferRangePatchData) { }

		[Address(RVA = "0xAC02C0", Offset = "0xABF6C0", Length = "0x296")]
		[Token(Token = "0x600001F")]
		public static void ExecuteFilter(ref JobWrapper<T> jobWrapper, IntPtr bufferRangePatchData) { }

		[Address(RVA = "0xAC06F0", Offset = "0xABFAF0", Length = "0x2A8")]
		[BurstDiscard]
		[Token(Token = "0x600001C")]
		internal static void Initialize() { }

	}


	[Address(RVA = "0x820680", Offset = "0x81FA80", Length = "0x51")]
	[Token(Token = "0x6000012")]
	public static void EarlyJobInit() { }

	[Address(RVA = "0x823FC0", Offset = "0x8233C0", Length = "0xA2")]
	[Token(Token = "0x6000013")]
	private static IntPtr GetReflectionData() { }

	[Address(RVA = "0x8242D0", Offset = "0x8236D0", Length = "0x5A")]
	[Extension]
	[Token(Token = "0x6000016")]
	public static void RunAppend(T jobData, NativeList<Int32> indices, int arrayLength) { }

	[Address(RVA = "0x824070", Offset = "0x823470", Length = "0x252")]
	[Extension]
	[Token(Token = "0x600001A")]
	public static void RunAppendByRef(ref T jobData, NativeList<Int32> indices, int arrayLength) { }

	[Address(RVA = "0x824580", Offset = "0x823980", Length = "0x4A")]
	[Extension]
	[Token(Token = "0x6000017")]
	public static void RunFilter(T jobData, NativeList<Int32> indices) { }

	[Address(RVA = "0x824330", Offset = "0x823730", Length = "0x24B")]
	[Extension]
	[Token(Token = "0x600001B")]
	public static void RunFilterByRef(ref T jobData, NativeList<Int32> indices) { }

	[Address(RVA = "0x824850", Offset = "0x823C50", Length = "0x9C")]
	[Extension]
	[Token(Token = "0x6000014")]
	public static JobHandle ScheduleAppend(T jobData, NativeList<Int32> indices, int arrayLength, JobHandle dependsOn = null) { }

	[Address(RVA = "0x8245D0", Offset = "0x8239D0", Length = "0x274")]
	[Extension]
	[Token(Token = "0x6000018")]
	public static JobHandle ScheduleAppendByRef(ref T jobData, NativeList<Int32> indices, int arrayLength, JobHandle dependsOn = null) { }

	[Address(RVA = "0x824B70", Offset = "0x823F70", Length = "0x8D")]
	[Extension]
	[Token(Token = "0x6000015")]
	public static JobHandle ScheduleFilter(T jobData, NativeList<Int32> indices, JobHandle dependsOn = null) { }

	[Address(RVA = "0x8248F0", Offset = "0x823CF0", Length = "0x272")]
	[Extension]
	[Token(Token = "0x6000019")]
	public static JobHandle ScheduleFilterByRef(ref T jobData, NativeList<Int32> indices, JobHandle dependsOn = null) { }

}

