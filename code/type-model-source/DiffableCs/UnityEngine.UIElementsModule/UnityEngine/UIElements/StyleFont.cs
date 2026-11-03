namespace UnityEngine.UIElements;

[Token(Token = "0x2000420")]
public struct StyleFont : IStyleValue<Font>, IEquatable<StyleFont>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DC0")]
	private Font m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000DC1")]
	private StyleKeyword m_Keyword; //Field offset: 0x8

	[Token(Token = "0x170008C0")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x6001F65")]
		 get { } //Length: 6
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x6001F66")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008BF")]
	public override Font value
	{
		[Address(RVA = "0x3278D20", Offset = "0x3278120", Length = "0xD")]
		[Token(Token = "0x6001F63")]
		 get { } //Length: 13
		[Address(RVA = "0x2152900", Offset = "0x2151D00", Length = "0x1E")]
		[Token(Token = "0x6001F64")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x327A630", Offset = "0x3279A30", Length = "0xF")]
	[Token(Token = "0x6001F67")]
	public StyleFont(Font v) { }

	[Address(RVA = "0x1F2C5B0", Offset = "0x1F2B9B0", Length = "0x11")]
	[Token(Token = "0x6001F68")]
	public StyleFont(StyleKeyword keyword) { }

	[Address(RVA = "0x327A620", Offset = "0x3279A20", Length = "0xC")]
	[Token(Token = "0x6001F69")]
	internal StyleFont(Font v, StyleKeyword keyword) { }

	[Address(RVA = "0x327A4B0", Offset = "0x32798B0", Length = "0x74")]
	[Token(Token = "0x6001F6D")]
	public override bool Equals(StyleFont other) { }

	[Address(RVA = "0x327A3A0", Offset = "0x32797A0", Length = "0x100")]
	[Token(Token = "0x6001F6E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x6001F65")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x3278D20", Offset = "0x3278120", Length = "0xD")]
	[Token(Token = "0x6001F63")]
	public override Font get_value() { }

	[Address(RVA = "0x327A530", Offset = "0x3279930", Length = "0x8A")]
	[Token(Token = "0x6001F6F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327A640", Offset = "0x3279A40", Length = "0x6F")]
	[Token(Token = "0x6001F6A")]
	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	[Address(RVA = "0x327A6B0", Offset = "0x3279AB0", Length = "0x3B")]
	[Token(Token = "0x6001F6B")]
	public static StyleFont op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x327A6F0", Offset = "0x3279AF0", Length = "0x36")]
	[Token(Token = "0x6001F6C")]
	public static StyleFont op_Implicit(Font v) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x6001F66")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x2152900", Offset = "0x2151D00", Length = "0x1E")]
	[Token(Token = "0x6001F64")]
	public override void set_value(Font value) { }

	[Address(RVA = "0x327A5C0", Offset = "0x32799C0", Length = "0x5F")]
	[Token(Token = "0x6001F70")]
	public virtual string ToString() { }

}

