namespace UnityEngine.Experimental.GlobalIllumination;

[Token(Token = "0x200040E")]
public struct LinearColor
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000DC0")]
	private float m_red; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000DC1")]
	private float m_green; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000DC2")]
	private float m_blue; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000DC3")]
	private float m_intensity; //Field offset: 0xC

	[Token(Token = "0x170004A7")]
	public float blue
	{
		[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
		[Token(Token = "0x6001F30")]
		 get { } //Length: 8
		[Address(RVA = "0x30C22B0", Offset = "0x30C16B0", Length = "0xBA")]
		[Token(Token = "0x6001F31")]
		 set { } //Length: 186
	}

	[Token(Token = "0x170004A6")]
	public float green
	{
		[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
		[Token(Token = "0x6001F2E")]
		 get { } //Length: 8
		[Address(RVA = "0x30C2370", Offset = "0x30C1770", Length = "0xBA")]
		[Token(Token = "0x6001F2F")]
		 set { } //Length: 186
	}

	[Token(Token = "0x170004A5")]
	public float red
	{
		[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
		[Token(Token = "0x6001F2C")]
		 get { } //Length: 7
		[Address(RVA = "0x30C2430", Offset = "0x30C1830", Length = "0xB9")]
		[Token(Token = "0x6001F2D")]
		 set { } //Length: 185
	}

	[Address(RVA = "0x30C1F30", Offset = "0x30C1330", Length = "0x24")]
	[Token(Token = "0x6001F33")]
	public static LinearColor Black() { }

	[Address(RVA = "0x30C1F60", Offset = "0x30C1360", Length = "0x349")]
	[Token(Token = "0x6001F32")]
	public static LinearColor Convert(Color color, float intensity) { }

	[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
	[Token(Token = "0x6001F30")]
	public float get_blue() { }

	[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
	[Token(Token = "0x6001F2E")]
	public float get_green() { }

	[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
	[Token(Token = "0x6001F2C")]
	public float get_red() { }

	[Address(RVA = "0x30C22B0", Offset = "0x30C16B0", Length = "0xBA")]
	[Token(Token = "0x6001F31")]
	public void set_blue(float value) { }

	[Address(RVA = "0x30C2370", Offset = "0x30C1770", Length = "0xBA")]
	[Token(Token = "0x6001F2F")]
	public void set_green(float value) { }

	[Address(RVA = "0x30C2430", Offset = "0x30C1830", Length = "0xB9")]
	[Token(Token = "0x6001F2D")]
	public void set_red(float value) { }

}

