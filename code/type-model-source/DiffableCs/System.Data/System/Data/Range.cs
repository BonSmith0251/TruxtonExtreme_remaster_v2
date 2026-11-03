namespace System.Data;

[Token(Token = "0x2000079")]
internal struct Range
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000259")]
	private int _min; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400025A")]
	private int _max; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400025B")]
	private bool _isNotNull; //Field offset: 0x8

	[Token(Token = "0x17000100")]
	public int Count
	{
		[Address(RVA = "0x234B180", Offset = "0x234A580", Length = "0x11")]
		[Token(Token = "0x6000676")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000101")]
	public bool IsNull
	{
		[Address(RVA = "0x234B1A0", Offset = "0x234A5A0", Length = "0x8")]
		[Token(Token = "0x6000677")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000102")]
	public int Min
	{
		[Address(RVA = "0x234B1B0", Offset = "0x234A5B0", Length = "0x3C")]
		[Token(Token = "0x6000678")]
		 get { } //Length: 60
	}

	[Address(RVA = "0x234B130", Offset = "0x234A530", Length = "0x4E")]
	[Token(Token = "0x6000675")]
	public Range(int min, int max) { }

	[Address(RVA = "0x234B0F0", Offset = "0x234A4F0", Length = "0x3A")]
	[Token(Token = "0x6000679")]
	internal void CheckNull() { }

	[Address(RVA = "0x234B180", Offset = "0x234A580", Length = "0x11")]
	[Token(Token = "0x6000676")]
	public int get_Count() { }

	[Address(RVA = "0x234B1A0", Offset = "0x234A5A0", Length = "0x8")]
	[Token(Token = "0x6000677")]
	public bool get_IsNull() { }

	[Address(RVA = "0x234B1B0", Offset = "0x234A5B0", Length = "0x3C")]
	[Token(Token = "0x6000678")]
	public int get_Min() { }

}

