namespace Newtonsoft.Json.Utilities;

[DefaultMember("Item")]
[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000EE")]
internal struct StringReference
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004C7")]
	private readonly Char[] _chars; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004C8")]
	private readonly int _startIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40004C9")]
	private readonly int _length; //Field offset: 0xC

	[Token(Token = "0x170000E1")]
	public Char[] Chars
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60006F9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000E0")]
	public char Item
	{
		[Address(RVA = "0x2152B10", Offset = "0x2151F10", Length = "0x2B")]
		[Token(Token = "0x60006F8")]
		 get { } //Length: 43
	}

	[Token(Token = "0x170000E3")]
	public int Length
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x60006FB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000E2")]
	public int StartIndex
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60006FA")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xD0EDF0", Offset = "0xD0E1F0", Length = "0x36")]
	[Token(Token = "0x60006FC")]
	public StringReference(Char[] chars, int startIndex, int length) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60006F9")]
	public Char[] get_Chars() { }

	[Address(RVA = "0x2152B10", Offset = "0x2151F10", Length = "0x2B")]
	[Token(Token = "0x60006F8")]
	public char get_Item(int i) { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x60006FB")]
	public int get_Length() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60006FA")]
	public int get_StartIndex() { }

	[Address(RVA = "0x2152AE0", Offset = "0x2151EE0", Length = "0x24")]
	[Token(Token = "0x60006FD")]
	public virtual string ToString() { }

}

