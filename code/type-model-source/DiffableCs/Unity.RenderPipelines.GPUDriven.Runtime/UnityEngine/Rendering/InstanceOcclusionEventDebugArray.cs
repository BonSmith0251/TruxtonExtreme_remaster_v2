namespace UnityEngine.Rendering;

[Token(Token = "0x2000049")]
internal struct InstanceOcclusionEventDebugArray : IDisposable
{
	[Token(Token = "0x200004A")]
	public struct Info
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014C")]
		public int viewInstanceID; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400014D")]
		public InstanceOcclusionEventType eventType; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400014E")]
		public int occluderVersion; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400014F")]
		public int subviewMask; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000150")]
		public OcclusionTest occlusionTest; //Field offset: 0x10

		[Address(RVA = "0x2CCEE10", Offset = "0x2CCE210", Length = "0x11")]
		[Token(Token = "0x600014B")]
		public bool HasVersion() { }

	}

	[Token(Token = "0x200004B")]
	public struct Request
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000151")]
		public UnsafeList<Info> info; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000152")]
		public AsyncGPUReadbackRequest readback; //Field offset: 0x18

	}

	[Token(Token = "0x4000144")]
	private const int InitialPassCount = 4; //Field offset: 0x0
	[Token(Token = "0x4000145")]
	private const int MaxPassCount = 64; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000146")]
	private GraphicsBuffer m_CounterBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000147")]
	private UnsafeList<Info> m_PendingInfo; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000148")]
	private NativeQueue<Request> m_Requests; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000149")]
	private UnsafeList<Info> m_LatestInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400014A")]
	private NativeArray<Int32> m_LatestCounters; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400014B")]
	private bool m_HasLatest; //Field offset: 0x50

	[Token(Token = "0x17000023")]
	public GraphicsBuffer CounterBuffer
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000146")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2CD2BB0", Offset = "0x2CD1FB0", Length = "0x129")]
	[Token(Token = "0x6000148")]
	public override void Dispose() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000146")]
	public GraphicsBuffer get_CounterBuffer() { }

	[Address(RVA = "0x2CD2CE0", Offset = "0x2CD20E0", Length = "0x10C")]
	[Token(Token = "0x6000147")]
	public void Init() { }

	[Address(RVA = "0x2CD2DF0", Offset = "0x2CD21F0", Length = "0x521")]
	[Token(Token = "0x600014A")]
	public void MoveToDebugStatsAndClear(DebugRendererBatcherStats debugStats) { }

	[Address(RVA = "0x2CD3320", Offset = "0x2CD2720", Length = "0x10A")]
	[Token(Token = "0x6000149")]
	public int TryAdd(int viewInstanceID, InstanceOcclusionEventType eventType, int occluderVersion, int subviewMask, OcclusionTest occlusionTest) { }

}

