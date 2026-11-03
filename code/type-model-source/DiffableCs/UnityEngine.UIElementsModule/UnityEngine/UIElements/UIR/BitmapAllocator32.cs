namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005EC")]
internal struct BitmapAllocator32
{
	[Token(Token = "0x20005ED")]
	private struct Page
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40015A1")]
		public ushort x; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40015A2")]
		public ushort y; //Field offset: 0x2
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40015A3")]
		public int freeSlots; //Field offset: 0x4

	}

	[Token(Token = "0x400159B")]
	public const int kPageWidth = 32; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400159C")]
	private int m_PageHeight; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400159D")]
	private List<Page> m_Pages; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400159E")]
	private List<UInt32> m_AllocMap; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400159F")]
	private int m_EntryWidth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40015A0")]
	private int m_EntryHeight; //Field offset: 0x1C

	[Token(Token = "0x17000A92")]
	public int entryHeight
	{
		[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
		[Token(Token = "0x6002A77")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000A91")]
	public int entryWidth
	{
		[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
		[Token(Token = "0x6002A76")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x33172D0", Offset = "0x33166D0", Length = "0x44B")]
	[Token(Token = "0x6002A74")]
	public BMPAlloc Allocate(BaseShaderInfoStorage storage) { }

	[Address(RVA = "0x3317720", Offset = "0x3316B20", Length = "0x117")]
	[Token(Token = "0x6002A72")]
	public void Construct(int pageHeight, int entryWidth = 1, int entryHeight = 1) { }

	[Address(RVA = "0x3317840", Offset = "0x3316C40", Length = "0x7C")]
	[Token(Token = "0x6002A79")]
	private static byte CountTrailingZeroes(uint val) { }

	[Address(RVA = "0x33178C0", Offset = "0x3316CC0", Length = "0x1A5")]
	[Token(Token = "0x6002A73")]
	public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY) { }

	[Address(RVA = "0x3317A70", Offset = "0x3316E70", Length = "0x136")]
	[Token(Token = "0x6002A75")]
	public void Free(BMPAlloc alloc) { }

	[Address(RVA = "0x1C18DC0", Offset = "0x1C181C0", Length = "0x6")]
	[Token(Token = "0x6002A77")]
	public int get_entryHeight() { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x6002A76")]
	public int get_entryWidth() { }

	[Address(RVA = "0x3317BB0", Offset = "0x3316FB0", Length = "0x76")]
	[Token(Token = "0x6002A78")]
	internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y) { }

}

