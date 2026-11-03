namespace UnityEngine.Rendering;

[Extension]
[Token(Token = "0x20000EB")]
internal static class ParallelSortExtensions
{
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x20000ED")]
	public struct RadixSortBatchPrefixSumJob : IJobFor
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x4000451")]
		public int radix; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[ReadOnly]
		[Token(Token = "0x4000452")]
		public int jobsCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		[Token(Token = "0x4000453")]
		public NativeArray<Int32> array; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x4000454")]
		public NativeArray<Int32> counter; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x4000455")]
		public NativeArray<Int32> indicesSum; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x4000456")]
		public NativeArray<Int32> buckets; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x4000457")]
		public NativeArray<Int32> indices; //Field offset: 0x48

		[Address(RVA = "0x2CFF290", Offset = "0x2CFE690", Length = "0x59")]
		[Token(Token = "0x60003D2")]
		private static int AtomicIncrement(NativeArray<Int32> counter) { }

		[Address(RVA = "0x2CFF2F0", Offset = "0x2CFE6F0", Length = "0x152")]
		[Token(Token = "0x60003D4")]
		public override void Execute(int index) { }

		[Address(RVA = "0x2CFF450", Offset = "0x2CFE850", Length = "0x49")]
		[Token(Token = "0x60003D3")]
		private int JobIndexPrefixSum(int sum, int i) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x20000EC")]
	public struct RadixSortBucketCountJob : IJobFor
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x400044C")]
		public int radix; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[ReadOnly]
		[Token(Token = "0x400044D")]
		public int jobsCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x400044E")]
		public int batchSize; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		[Token(Token = "0x400044F")]
		public NativeArray<Int32> array; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x4000450")]
		public NativeArray<Int32> buckets; //Field offset: 0x20

		[Address(RVA = "0x2CFF4A0", Offset = "0x2CFE8A0", Length = "0x7C")]
		[Token(Token = "0x60003D1")]
		public override void Execute(int index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x20000EF")]
	public struct RadixSortBucketSortJob : IJobFor
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x400045B")]
		public int radix; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[ReadOnly]
		[Token(Token = "0x400045C")]
		public int batchSize; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		[Token(Token = "0x400045D")]
		public NativeArray<Int32> array; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x400045E")]
		public NativeArray<Int32> indices; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x400045F")]
		public NativeArray<Int32> arraySorted; //Field offset: 0x28

		[Address(RVA = "0x2CFF520", Offset = "0x2CFE920", Length = "0xA3")]
		[Token(Token = "0x60003D6")]
		public override void Execute(int index) { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x20000EE")]
	public struct RadixSortPrefixSumJob : IJobFor
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x4000458")]
		public int jobsCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x4000459")]
		public NativeArray<Int32> indicesSum; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x400045A")]
		public NativeArray<Int32> indices; //Field offset: 0x18

		[Address(RVA = "0x2CFF5D0", Offset = "0x2CFE9D0", Length = "0x70")]
		[Token(Token = "0x60003D5")]
		public override void Execute(int index) { }

	}

	[Token(Token = "0x400044A")]
	private const int kMinRadixSortArraySize = 2048; //Field offset: 0x0
	[Token(Token = "0x400044B")]
	private const int kMinRadixSortBatchSize = 256; //Field offset: 0x0

	[Address(RVA = "0x2CFE670", Offset = "0x2CFDA70", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60003D0")]
	internal static void <ParallelSort>g__Swap|2_0(ref NativeArray<Int32>& a, ref NativeArray<Int32>& b) { }

	[Address(RVA = "0x2CFE060", Offset = "0x2CFD460", Length = "0x60D")]
	[Extension]
	[Token(Token = "0x60003CF")]
	internal static JobHandle ParallelSort(NativeArray<Int32> array) { }

}

