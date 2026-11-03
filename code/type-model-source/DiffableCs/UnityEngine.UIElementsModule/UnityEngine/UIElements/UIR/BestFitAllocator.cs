namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200058A")]
internal class BestFitAllocator
{
	[Token(Token = "0x200058C")]
	private class Block : LinkedPoolItem<Block>
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40012CB")]
		public uint start; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40012CC")]
		public uint end; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40012CD")]
		public Block prev; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40012CE")]
		public Block next; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40012CF")]
		public Block prevAvailable; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40012D0")]
		public Block nextAvailable; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40012D1")]
		public bool allocated; //Field offset: 0x40

		[Token(Token = "0x17000A3A")]
		public uint size
		{
			[Address(RVA = "0x32F1890", Offset = "0x32F0C90", Length = "0x9")]
			[Token(Token = "0x6002840")]
			 get { } //Length: 9
		}

		[Address(RVA = "0x32F1850", Offset = "0x32F0C50", Length = "0x39")]
		[Token(Token = "0x6002841")]
		public Block() { }

		[Address(RVA = "0x32F1890", Offset = "0x32F0C90", Length = "0x9")]
		[Token(Token = "0x6002840")]
		public uint get_size() { }

	}

	[Token(Token = "0x200058B")]
	private class BlockPool : LinkedPool<Block>
	{

		[Address(RVA = "0x32F1770", Offset = "0x32F0B70", Length = "0xD4")]
		[Token(Token = "0x600283F")]
		public BlockPool() { }

		[Address(RVA = "0x32F1700", Offset = "0x32F0B00", Length = "0x65")]
		[Token(Token = "0x600283D")]
		private static Block CreateBlock() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600283E")]
		private static void ResetBlock(Block block) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012C6")]
	private readonly uint <totalSize>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012C7")]
	private Block m_FirstBlock; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012C8")]
	private Block m_FirstAvailableBlock; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012C9")]
	private BlockPool m_BlockPool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012CA")]
	private uint m_HighWatermark; //Field offset: 0x30

	[Token(Token = "0x17000A39")]
	public uint highWatermark
	{
		[Address(RVA = "0x32F16F0", Offset = "0x32F0AF0", Length = "0x6")]
		[Token(Token = "0x6002837")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000A38")]
	public uint totalSize
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6002836")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x32F1560", Offset = "0x32F0960", Length = "0x189")]
	[Token(Token = "0x6002835")]
	public BestFitAllocator(uint size) { }

	[Address(RVA = "0x32F0CD0", Offset = "0x32F00D0", Length = "0x33D")]
	[Token(Token = "0x6002838")]
	public Alloc Allocate(uint size) { }

	[Address(RVA = "0x32F1010", Offset = "0x32F0410", Length = "0x3F")]
	[Token(Token = "0x600283B")]
	private Block BestFitFindAvailableBlock(uint size) { }

	[Address(RVA = "0x32F1050", Offset = "0x32F0450", Length = "0x13B")]
	[Token(Token = "0x600283A")]
	private Block CoalesceBlockWithPrevious(Block block) { }

	[Address(RVA = "0x32F1190", Offset = "0x32F0590", Length = "0x25F")]
	[Token(Token = "0x6002839")]
	public void Free(Alloc alloc) { }

	[Address(RVA = "0x32F16F0", Offset = "0x32F0AF0", Length = "0x6")]
	[Token(Token = "0x6002837")]
	public uint get_highWatermark() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6002836")]
	public uint get_totalSize() { }

	[Address(RVA = "0x32F13F0", Offset = "0x32F07F0", Length = "0x160")]
	[Token(Token = "0x600283C")]
	private void SplitBlock(Block block, uint size) { }

}

