namespace System.Runtime.Serialization;

[Token(Token = "0x20003ED")]
internal class LongList
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F62")]
	private Int64[] m_values; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F63")]
	private int m_count; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000F64")]
	private int m_totalItems; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F65")]
	private int m_currentItem; //Field offset: 0x20

	[Token(Token = "0x170003C3")]
	internal int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6001E2E")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170003C4")]
	internal long Current
	{
		[Address(RVA = "0x1F1CC00", Offset = "0x1F1C000", Length = "0x2B")]
		[Token(Token = "0x6001E31")]
		internal get { } //Length: 43
	}

	[Address(RVA = "0x1F1CB30", Offset = "0x1F1BF30", Length = "0x5B")]
	[Token(Token = "0x6001E2B")]
	internal LongList() { }

	[Address(RVA = "0x1F1CB90", Offset = "0x1F1BF90", Length = "0x63")]
	[Token(Token = "0x6001E2C")]
	internal LongList(int startingSize) { }

	[Address(RVA = "0x1F1C900", Offset = "0x1F1BD00", Length = "0xC9")]
	[Token(Token = "0x6001E2D")]
	internal void Add(long value) { }

	[Address(RVA = "0x1F1C9D0", Offset = "0x1F1BDD0", Length = "0x81")]
	[Token(Token = "0x6001E33")]
	private void EnlargeArray() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6001E2E")]
	internal int get_Count() { }

	[Address(RVA = "0x1F1CC00", Offset = "0x1F1C000", Length = "0x2B")]
	[Token(Token = "0x6001E31")]
	internal long get_Current() { }

	[Address(RVA = "0x1F1CA60", Offset = "0x1F1BE60", Length = "0x4C")]
	[Token(Token = "0x6001E30")]
	internal bool MoveNext() { }

	[Address(RVA = "0x1F1CAB0", Offset = "0x1F1BEB0", Length = "0x79")]
	[Token(Token = "0x6001E32")]
	internal bool RemoveElement(long value) { }

	[Address(RVA = "0x1960180", Offset = "0x195F580", Length = "0x8")]
	[Token(Token = "0x6001E2F")]
	internal void StartEnumeration() { }

}

