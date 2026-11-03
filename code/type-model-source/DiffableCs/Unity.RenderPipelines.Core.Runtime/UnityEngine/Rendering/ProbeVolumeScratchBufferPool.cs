namespace UnityEngine.Rendering;

[Token(Token = "0x200013D")]
internal class ProbeVolumeScratchBufferPool
{
	[CompilerGenerated]
	[Token(Token = "0x200013F")]
	private sealed class <>c
	{
		[Token(Token = "0x4000605")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000606")]
		public static Predicate<ScratchBufferPool> <>9__26_0; //Field offset: 0x8
		[Token(Token = "0x4000607")]
		public static Predicate<ScratchBufferPool> <>9__27_0; //Field offset: 0x10

		[Address(RVA = "0x2C39190", Offset = "0x2C38590", Length = "0x354")]
		[Token(Token = "0x6000AC4")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000AC5")]
		public <>c() { }

		[Address(RVA = "0x2C38290", Offset = "0x2C37690", Length = "0x4B")]
		[Token(Token = "0x6000AC6")]
		internal bool <AllocateScratchBuffer>b__26_0(ScratchBufferPool o) { }

		[Address(RVA = "0x2C38FF0", Offset = "0x2C383F0", Length = "0x4B")]
		[Token(Token = "0x6000AC7")]
		internal bool <ReleaseScratchBuffer>b__27_0(ScratchBufferPool o) { }

	}

	[DebuggerDisplay("ChunkCount = {chunkCount} ElementCount = {pool.Count}")]
	[Token(Token = "0x200013E")]
	private class ScratchBufferPool : IComparable<ScratchBufferPool>
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000603")]
		public int chunkCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000604")]
		public Stack<CellStreamingScratchBuffer> pool; //Field offset: 0x18

		[Address(RVA = "0x2C36560", Offset = "0x2C35960", Length = "0x8E")]
		[Token(Token = "0x6000AC1")]
		public ScratchBufferPool(int chunkCount) { }

		[Address(RVA = "0x2C365F0", Offset = "0x2C359F0", Length = "0x7E")]
		[Token(Token = "0x6000AC2")]
		private ScratchBufferPool() { }

		[Address(RVA = "0x2C36520", Offset = "0x2C35920", Length = "0x30")]
		[Token(Token = "0x6000AC3")]
		public override int CompareTo(ScratchBufferPool other) { }

	}

	[Token(Token = "0x4000602")]
	private static int s_ChunkCount; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F5")]
	private int <chunkSize>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40005F6")]
	private int <maxChunkCount>k__BackingField; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005F7")]
	private int m_L0Size; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40005F8")]
	private int m_L1Size; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005F9")]
	private int m_ValiditySize; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40005FA")]
	private int m_ValidityLayerCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005FB")]
	private int m_L2Size; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40005FC")]
	private int m_ProbeOcclusionSize; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005FD")]
	private int m_SkyOcclusionSize; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40005FE")]
	private int m_SkyShadingDirectionSize; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005FF")]
	private int m_CurrentlyAllocatedChunkCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000600")]
	private List<ScratchBufferPool> m_Pools; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000601")]
	private Dictionary<Int32, CellStreamingScratchBufferLayout> m_Layouts; //Field offset: 0x48

	[Token(Token = "0x1700013D")]
	public int allocatedMemory
	{
		[Address(RVA = "0x2C30920", Offset = "0x2C2FD20", Length = "0x8")]
		[Token(Token = "0x6000ABA")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700013B")]
	public private int chunkSize
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000AB6")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AB7")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700013C")]
	public private int maxChunkCount
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AB8")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AB9")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2C307D0", Offset = "0x2C2FBD0", Length = "0x143")]
	[Token(Token = "0x6000ABB")]
	public ProbeVolumeScratchBufferPool(ProbeVolumeBakingSet bakingSet, ProbeVolumeSHBands shBands) { }

	[Address(RVA = "0x2C2FBF0", Offset = "0x2C2EFF0", Length = "0x458")]
	[Token(Token = "0x6000ABE")]
	public bool AllocateScratchBuffer(int chunkCount, out CellStreamingScratchBuffer scratchBuffer, out CellStreamingScratchBufferLayout layout, bool allocateGraphicsBuffers) { }

	[Address(RVA = "0x2C30050", Offset = "0x2C2F450", Length = "0x1DA")]
	[Token(Token = "0x6000AC0")]
	public void Cleanup() { }

	[Address(RVA = "0x2C30230", Offset = "0x2C2F630", Length = "0x8F")]
	[Token(Token = "0x6000ABD")]
	private CellStreamingScratchBuffer CreateScratchBuffer(int chunkCount, bool allocateGraphicsBuffers) { }

	[Address(RVA = "0x2C30920", Offset = "0x2C2FD20", Length = "0x8")]
	[Token(Token = "0x6000ABA")]
	public int get_allocatedMemory() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000AB6")]
	public int get_chunkSize() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AB8")]
	public int get_maxChunkCount() { }

	[Address(RVA = "0x2C302C0", Offset = "0x2C2F6C0", Length = "0x36D")]
	[Token(Token = "0x6000ABC")]
	private CellStreamingScratchBufferLayout GetOrCreateScratchBufferLayout(int chunkCount) { }

	[Address(RVA = "0x2C30630", Offset = "0x2C2FA30", Length = "0x192")]
	[Token(Token = "0x6000ABF")]
	public void ReleaseScratchBuffer(CellStreamingScratchBuffer scratchBuffer) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AB7")]
	private void set_chunkSize(int value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AB9")]
	private void set_maxChunkCount(int value) { }

}

