namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x200064B")]
internal struct ExpressionMultiplier
{
	[Token(Token = "0x40017B1")]
	public const int Infinity = 100; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017B2")]
	private ExpressionMultiplierType m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40017B3")]
	public int min; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40017B4")]
	public int max; //Field offset: 0x8

	[Token(Token = "0x17000B5F")]
	public ExpressionMultiplierType type
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6002CAD")]
		 get { } //Length: 5
		[Address(RVA = "0x33624F0", Offset = "0x33618F0", Length = "0x8")]
		[Token(Token = "0x6002CAE")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x33624D0", Offset = "0x33618D0", Length = "0x18")]
	[Token(Token = "0x6002CAF")]
	public ExpressionMultiplier(ExpressionMultiplierType type = 0) { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6002CAD")]
	public ExpressionMultiplierType get_type() { }

	[Address(RVA = "0x33624F0", Offset = "0x33618F0", Length = "0x8")]
	[Token(Token = "0x6002CAE")]
	public void set_type(ExpressionMultiplierType value) { }

	[Address(RVA = "0x3362450", Offset = "0x3361850", Length = "0x60")]
	[Token(Token = "0x6002CB0")]
	private void SetType(ExpressionMultiplierType value) { }

}

