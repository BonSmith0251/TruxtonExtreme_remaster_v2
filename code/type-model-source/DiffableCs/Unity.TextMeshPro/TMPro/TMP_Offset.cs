namespace TMPro;

[Token(Token = "0x200002E")]
public struct TMP_Offset
{
	[Token(Token = "0x400013F")]
	private static readonly TMP_Offset k_ZeroOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013B")]
	private float m_Left; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400013C")]
	private float m_Right; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400013D")]
	private float m_Top; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400013E")]
	private float m_Bottom; //Field offset: 0xC

	[Token(Token = "0x1700003D")]
	public float bottom
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[Token(Token = "0x6000160")]
		 get { } //Length: 6
		[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
		[Token(Token = "0x6000161")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700003E")]
	public float horizontal
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x6000162")]
		 get { } //Length: 5
		[Address(RVA = "0x2ACB220", Offset = "0x2ACA620", Length = "0xA")]
		[Token(Token = "0x6000163")]
		 set { } //Length: 10
	}

	[Token(Token = "0x1700003A")]
	public float left
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x600015A")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x600015B")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700003B")]
	public float right
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[Token(Token = "0x600015C")]
		 get { } //Length: 388
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[Token(Token = "0x600015D")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700003C")]
	public float top
	{
		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[Token(Token = "0x600015E")]
		 get { } //Length: 229
		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[Token(Token = "0x600015F")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700003F")]
	public float vertical
	{
		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[Token(Token = "0x6000164")]
		 get { } //Length: 229
		[Address(RVA = "0x2EC3CA0", Offset = "0x2EC30A0", Length = "0xB")]
		[Token(Token = "0x6000165")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000040")]
	public static TMP_Offset zero
	{
		[Address(RVA = "0x2EC3B90", Offset = "0x2EC2F90", Length = "0x5A")]
		[Token(Token = "0x6000166")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x2EC3B30", Offset = "0x2EC2F30", Length = "0x39")]
	[Token(Token = "0x600016F")]
	private static TMP_Offset() { }

	[Address(RVA = "0x2EC3B70", Offset = "0x2EC2F70", Length = "0x14")]
	[Token(Token = "0x6000168")]
	public TMP_Offset(float horizontal, float vertical) { }

	[Address(RVA = "0x27F69A0", Offset = "0x27F5DA0", Length = "0x1A")]
	[Token(Token = "0x6000167")]
	public TMP_Offset(float left, float right, float top, float bottom) { }

	[Address(RVA = "0x2EC3A80", Offset = "0x2EC2E80", Length = "0x5E")]
	[Token(Token = "0x600016D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2EC3A00", Offset = "0x2EC2E00", Length = "0x7A")]
	[Token(Token = "0x600016E")]
	public bool Equals(TMP_Offset other) { }

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[Token(Token = "0x6000160")]
	public float get_bottom() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x6000162")]
	public float get_horizontal() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x600015A")]
	public float get_left() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[Token(Token = "0x600015C")]
	public float get_right() { }

	[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
	[Token(Token = "0x600015E")]
	public float get_top() { }

	[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
	[Token(Token = "0x6000164")]
	public float get_vertical() { }

	[Address(RVA = "0x2EC3B90", Offset = "0x2EC2F90", Length = "0x5A")]
	[Token(Token = "0x6000166")]
	public static TMP_Offset get_zero() { }

	[Address(RVA = "0x2EC3AE0", Offset = "0x2EC2EE0", Length = "0x4E")]
	[Token(Token = "0x600016C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23DE6F0", Offset = "0x23DDAF0", Length = "0x38")]
	[Token(Token = "0x6000169")]
	public static bool op_Equality(TMP_Offset lhs, TMP_Offset rhs) { }

	[Address(RVA = "0x2EC3BF0", Offset = "0x2EC2FF0", Length = "0xAC")]
	[Token(Token = "0x600016A")]
	public static bool op_Inequality(TMP_Offset lhs, TMP_Offset rhs) { }

	[Address(RVA = "0x2AE1150", Offset = "0x2AE0550", Length = "0x11")]
	[Token(Token = "0x600016B")]
	public static TMP_Offset op_Multiply(TMP_Offset a, float b) { }

	[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
	[Token(Token = "0x6000161")]
	public void set_bottom(float value) { }

	[Address(RVA = "0x2ACB220", Offset = "0x2ACA620", Length = "0xA")]
	[Token(Token = "0x6000163")]
	public void set_horizontal(float value) { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x600015B")]
	public void set_left(float value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[Token(Token = "0x600015D")]
	public void set_right(float value) { }

	[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
	[Token(Token = "0x600015F")]
	public void set_top(float value) { }

	[Address(RVA = "0x2EC3CA0", Offset = "0x2EC30A0", Length = "0xB")]
	[Token(Token = "0x6000165")]
	public void set_vertical(float value) { }

}

