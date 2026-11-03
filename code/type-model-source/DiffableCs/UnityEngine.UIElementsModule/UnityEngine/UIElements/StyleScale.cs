namespace UnityEngine.UIElements;

[Token(Token = "0x2000428")]
public struct StyleScale : IStyleValue<Scale>, IEquatable<StyleScale>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000DD0")]
	private Scale m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000DD1")]
	private StyleKeyword m_Keyword; //Field offset: 0x10

	[Token(Token = "0x170008D0")]
	public override StyleKeyword keyword
	{
		[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
		[Token(Token = "0x6001FD9")]
		 get { } //Length: 6
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6001FDA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008CF")]
	public override Scale value
	{
		[Address(RVA = "0x327BC20", Offset = "0x327B020", Length = "0x146")]
		[Token(Token = "0x6001FD7")]
		 get { } //Length: 326
		[Address(RVA = "0x1F87700", Offset = "0x1F86B00", Length = "0xE")]
		[Token(Token = "0x6001FD8")]
		 set { } //Length: 14
	}

	[Address(RVA = "0x1F87700", Offset = "0x1F86B00", Length = "0xE")]
	[Token(Token = "0x6001FDB")]
	public StyleScale(Scale v) { }

	[Address(RVA = "0x32799A0", Offset = "0x3278DA0", Length = "0xA")]
	[Token(Token = "0x6001FDC")]
	public StyleScale(StyleKeyword keyword) { }

	[Address(RVA = "0xAEE4F0", Offset = "0xAED8F0", Length = "0xB")]
	[Token(Token = "0x6001FDD")]
	internal StyleScale(Scale v, StyleKeyword keyword) { }

	[Address(RVA = "0x327BA00", Offset = "0x327AE00", Length = "0x65")]
	[Token(Token = "0x6001FE1")]
	public override bool Equals(StyleScale other) { }

	[Address(RVA = "0x327BA70", Offset = "0x327AE70", Length = "0xD8")]
	[Token(Token = "0x6001FE2")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
	[Token(Token = "0x6001FD9")]
	public override StyleKeyword get_keyword() { }

	[Address(RVA = "0x327BC20", Offset = "0x327B020", Length = "0x146")]
	[Token(Token = "0x6001FD7")]
	public override Scale get_value() { }

	[Address(RVA = "0x327BB50", Offset = "0x327AF50", Length = "0x5A")]
	[Token(Token = "0x6001FE3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x327BD70", Offset = "0x327B170", Length = "0x65")]
	[Token(Token = "0x6001FDE")]
	public static bool op_Equality(StyleScale lhs, StyleScale rhs) { }

	[Address(RVA = "0x3279A50", Offset = "0x3278E50", Length = "0xD")]
	[Token(Token = "0x6001FDF")]
	public static StyleScale op_Implicit(StyleKeyword keyword) { }

	[Address(RVA = "0x3279A60", Offset = "0x3278E60", Length = "0x17")]
	[Token(Token = "0x6001FE0")]
	public static StyleScale op_Implicit(Scale v) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6001FDA")]
	public override void set_keyword(StyleKeyword value) { }

	[Address(RVA = "0x1F87700", Offset = "0x1F86B00", Length = "0xE")]
	[Token(Token = "0x6001FD8")]
	public override void set_value(Scale value) { }

	[Address(RVA = "0x327BBB0", Offset = "0x327AFB0", Length = "0x66")]
	[Token(Token = "0x6001FE4")]
	public virtual string ToString() { }

}

