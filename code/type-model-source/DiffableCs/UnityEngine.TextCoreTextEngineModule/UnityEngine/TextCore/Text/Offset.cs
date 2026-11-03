namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000056")]
internal struct Offset
{
	[Token(Token = "0x4000336")]
	private static readonly Offset k_ZeroOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000332")]
	private float m_Left; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000333")]
	private float m_Right; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000334")]
	private float m_Top; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000335")]
	private float m_Bottom; //Field offset: 0xC

	[Token(Token = "0x17000073")]
	public float bottom
	{
		[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
		[Token(Token = "0x6000241")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000070")]
	public float left
	{
		[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
		[Token(Token = "0x600023E")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000071")]
	public float right
	{
		[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
		[Token(Token = "0x600023F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000072")]
	public float top
	{
		[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
		[Token(Token = "0x6000240")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000074")]
	public static Offset zero
	{
		[Address(RVA = "0x31B03B0", Offset = "0x31AF7B0", Length = "0x60")]
		[Token(Token = "0x6000242")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x31B0370", Offset = "0x31AF770", Length = "0x39")]
	[Token(Token = "0x6000248")]
	private static Offset() { }

	[Address(RVA = "0x27F69A0", Offset = "0x27F5DA0", Length = "0x1A")]
	[Token(Token = "0x6000243")]
	public Offset(float left, float right, float top, float bottom) { }

	[Address(RVA = "0x31B02C0", Offset = "0x31AF6C0", Length = "0x5E")]
	[Token(Token = "0x6000247")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
	[Token(Token = "0x6000241")]
	public float get_bottom() { }

	[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
	[Token(Token = "0x600023E")]
	public float get_left() { }

	[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
	[Token(Token = "0x600023F")]
	public float get_right() { }

	[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
	[Token(Token = "0x6000240")]
	public float get_top() { }

	[Address(RVA = "0x31B03B0", Offset = "0x31AF7B0", Length = "0x60")]
	[Token(Token = "0x6000242")]
	public static Offset get_zero() { }

	[Address(RVA = "0x31B0320", Offset = "0x31AF720", Length = "0x4E")]
	[Token(Token = "0x6000246")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23DE6F0", Offset = "0x23DDAF0", Length = "0x38")]
	[Token(Token = "0x6000244")]
	public static bool op_Equality(Offset lhs, Offset rhs) { }

	[Address(RVA = "0x31B0410", Offset = "0x31AF810", Length = "0x47")]
	[Token(Token = "0x6000245")]
	public static Offset op_Multiply(Offset a, float b) { }

}

