namespace System;

[DefaultMember("Item")]
[IsReadOnly]
[Token(Token = "0x2000124")]
internal struct ParamsArray
{
	[Token(Token = "0x4000427")]
	private static readonly Object[] s_oneArgArray; //Field offset: 0x0
	[Token(Token = "0x4000428")]
	private static readonly Object[] s_twoArgArray; //Field offset: 0x8
	[Token(Token = "0x4000429")]
	private static readonly Object[] s_threeArgArray; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400042A")]
	private readonly object _arg0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400042B")]
	private readonly object _arg1; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400042C")]
	private readonly object _arg2; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400042D")]
	private readonly Object[] _args; //Field offset: 0x18

	[Token(Token = "0x17000098")]
	public object Item
	{
		[Address(RVA = "0x2044D40", Offset = "0x2044140", Length = "0xA4")]
		[Token(Token = "0x6000960")]
		 get { } //Length: 164
	}

	[Token(Token = "0x17000097")]
	public int Length
	{
		[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
		[Token(Token = "0x600095F")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x2044970", Offset = "0x2043D70", Length = "0xE2")]
	[Token(Token = "0x6000962")]
	private static ParamsArray() { }

	[Address(RVA = "0x2044B30", Offset = "0x2043F30", Length = "0x99")]
	[Token(Token = "0x600095B")]
	public ParamsArray(object arg0) { }

	[Address(RVA = "0x2044C90", Offset = "0x2044090", Length = "0xAB")]
	[Token(Token = "0x600095C")]
	public ParamsArray(object arg0, object arg1) { }

	[Address(RVA = "0x2044BD0", Offset = "0x2043FD0", Length = "0xB5")]
	[Token(Token = "0x600095D")]
	public ParamsArray(object arg0, object arg1, object arg2) { }

	[Address(RVA = "0x2044A60", Offset = "0x2043E60", Length = "0xC5")]
	[Token(Token = "0x600095E")]
	public ParamsArray(Object[] args) { }

	[Address(RVA = "0x2044D40", Offset = "0x2044140", Length = "0xA4")]
	[Token(Token = "0x6000960")]
	public object get_Item(int index) { }

	[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
	[Token(Token = "0x600095F")]
	public int get_Length() { }

	[Address(RVA = "0x2044920", Offset = "0x2043D20", Length = "0x47")]
	[Token(Token = "0x6000961")]
	private object GetAtSlow(int index) { }

}

