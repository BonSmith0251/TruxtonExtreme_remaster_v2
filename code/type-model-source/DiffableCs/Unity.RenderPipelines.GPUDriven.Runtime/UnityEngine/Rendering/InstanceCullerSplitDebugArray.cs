namespace UnityEngine.Rendering;

[Token(Token = "0x2000047")]
internal struct InstanceCullerSplitDebugArray : IDisposable
{
	[Token(Token = "0x2000048")]
	public struct Info
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000141")]
		public BatchCullingViewType viewType; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000142")]
		public int viewInstanceID; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000143")]
		public int splitIndex; //Field offset: 0x8

	}

	[Token(Token = "0x400013D")]
	private const int MaxSplitCount = 64; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013E")]
	private NativeList<Info> m_Info; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400013F")]
	private NativeArray<Int32> m_Counters; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000140")]
	private NativeQueue<JobHandle> m_CounterSync; //Field offset: 0x18

	[Token(Token = "0x17000022")]
	public NativeArray<Int32> Counters
	{
		[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
		[Token(Token = "0x6000140")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2CCEE30", Offset = "0x2CCE230", Length = "0x65")]
	[Token(Token = "0x6000144")]
	public void AddSync(int baseIndex, JobHandle jobHandle) { }

	[Address(RVA = "0x2CCEEA0", Offset = "0x2CCE2A0", Length = "0x71")]
	[Token(Token = "0x6000142")]
	public override void Dispose() { }

	[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
	[Token(Token = "0x6000140")]
	public NativeArray<Int32> get_Counters() { }

	[Address(RVA = "0x2CCEF20", Offset = "0x2CCE320", Length = "0xDC")]
	[Token(Token = "0x6000141")]
	public void Init() { }

	[Address(RVA = "0x2CCF000", Offset = "0x2CCE400", Length = "0x237")]
	[Token(Token = "0x6000145")]
	public void MoveToDebugStatsAndClear(DebugRendererBatcherStats debugStats) { }

	[Address(RVA = "0x2CCF240", Offset = "0x2CCE640", Length = "0xDA")]
	[Token(Token = "0x6000143")]
	public int TryAddSplits(BatchCullingViewType viewType, int viewInstanceID, int splitCount) { }

}

