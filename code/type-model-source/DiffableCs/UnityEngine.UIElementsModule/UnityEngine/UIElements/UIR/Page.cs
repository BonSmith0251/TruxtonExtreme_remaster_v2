namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200058E")]
internal class Page : IDisposable
{
	[Token(Token = "0x200058F")]
	internal class DataSet : IDisposable
	{
		[Token(Token = "0x40012D9")]
		private static readonly MemoryLabel s_CpuMemoryLabel; //Field offset: 0x0
		[Token(Token = "0x40012DA")]
		private static readonly MemoryLabel s_RangesMemoryLabel; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012DB")]
		private bool <disposed>k__BackingField; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012DC")]
		public GPUBuffer<T> gpuData; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012DD")]
		public NativeArray<T> cpuData; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012DE")]
		public NativeArray<GfxUpdateBufferRange> updateRanges; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012DF")]
		public GPUBufferAllocator allocator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012E0")]
		private readonly uint m_UpdateRangePoolSize; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012E1")]
		private uint m_ElemStride; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012E2")]
		private uint m_UpdateRangeMin; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012E3")]
		private uint m_UpdateRangeMax; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012E4")]
		private uint m_UpdateRangesEnqueued; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012E5")]
		private uint m_UpdateRangesBatchStart; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012E6")]
		private bool m_UpdateRangesSaturated; //Field offset: 0x0

		[Token(Token = "0x17000A3E")]
		protected private bool disposed
		{
			[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600284E")]
			 get { } //Length: 5
			[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x600284F")]
			private set { } //Length: 4
		}

		[Address(RVA = "0x17CD0B0", Offset = "0x17CC4B0", Length = "0x136")]
		[Token(Token = "0x6002858")]
		private static DataSet`1() { }

		[Address(RVA = "0x17CD330", Offset = "0x17CC730", Length = "0x23F")]
		[Token(Token = "0x600284D")]
		public DataSet`1(GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize) { }

		[Address(RVA = "0x17CB9A0", Offset = "0x17CADA0", Length = "0xCF")]
		[Token(Token = "0x6002850")]
		public override void Dispose() { }

		[Address(RVA = "0x17CB6F0", Offset = "0x17CAAF0", Length = "0x98")]
		[Token(Token = "0x6002851")]
		public void Dispose(bool disposing) { }

		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600284E")]
		protected bool get_disposed() { }

		[Address(RVA = "0x17CBAF0", Offset = "0x17CAEF0", Length = "0x40")]
		[Token(Token = "0x6002853")]
		private bool HasMappedBufferRange() { }

		[Address(RVA = "0x17CBF50", Offset = "0x17CB350", Length = "0x1FE")]
		[Token(Token = "0x6002852")]
		public void RegisterUpdate(uint start, uint size) { }

		[Address(RVA = "0x17CC150", Offset = "0x17CB550", Length = "0x2F")]
		[Token(Token = "0x6002857")]
		private void ResetUpdateState() { }

		[Address(RVA = "0x17CC2D0", Offset = "0x17CB6D0", Length = "0x13E")]
		[Token(Token = "0x6002855")]
		public void SendFullRange() { }

		[Address(RVA = "0x17CC550", Offset = "0x17CB950", Length = "0x212")]
		[Token(Token = "0x6002856")]
		public void SendPartialRanges() { }

		[Address(RVA = "0x17CCD40", Offset = "0x17CC140", Length = "0x1AF")]
		[Token(Token = "0x6002854")]
		public void SendUpdates() { }

		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600284F")]
		private void set_disposed(bool value) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012D4")]
	private bool <disposed>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012D5")]
	public DataSet<Vertex> vertices; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012D6")]
	public DataSet<UInt16> indices; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012D7")]
	public Page next; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012D8")]
	public int framesEmpty; //Field offset: 0x30

	[Token(Token = "0x17000A3C")]
	protected private bool disposed
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002848")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002849")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000A3D")]
	public bool isEmpty
	{
		[Address(RVA = "0x32FEE50", Offset = "0x32FE250", Length = "0x7A")]
		[Token(Token = "0x600284C")]
		 get { } //Length: 122
	}

	[Address(RVA = "0x32FED00", Offset = "0x32FE100", Length = "0x144")]
	[Token(Token = "0x6002847")]
	public Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount) { }

	[Address(RVA = "0x32FEC90", Offset = "0x32FE090", Length = "0x61")]
	[Token(Token = "0x600284A")]
	public override void Dispose() { }

	[Address(RVA = "0x32FEC00", Offset = "0x32FE000", Length = "0x81")]
	[Token(Token = "0x600284B")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002848")]
	protected bool get_disposed() { }

	[Address(RVA = "0x32FEE50", Offset = "0x32FE250", Length = "0x7A")]
	[Token(Token = "0x600284C")]
	public bool get_isEmpty() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002849")]
	private void set_disposed(bool value) { }

}

