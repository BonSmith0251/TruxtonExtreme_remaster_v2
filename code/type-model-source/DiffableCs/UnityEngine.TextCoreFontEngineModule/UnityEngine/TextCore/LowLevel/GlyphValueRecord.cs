namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000011")]
[UsedByNativeCode]
public struct GlyphValueRecord : IEquatable<GlyphValueRecord>
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("xPlacement")]
	[SerializeField]
	[Token(Token = "0x4000084")]
	private float m_XPlacement; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("yPlacement")]
	[SerializeField]
	[Token(Token = "0x4000085")]
	private float m_YPlacement; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("xAdvance")]
	[SerializeField]
	[Token(Token = "0x4000086")]
	private float m_XAdvance; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("yAdvance")]
	[SerializeField]
	[Token(Token = "0x4000087")]
	private float m_YAdvance; //Field offset: 0xC

	[Token(Token = "0x17000026")]
	public float xAdvance
	{
		[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
		[Token(Token = "0x600008A")]
		 get { } //Length: 8
		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[Token(Token = "0x600008B")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000024")]
	public float xPlacement
	{
		[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
		[Token(Token = "0x6000086")]
		 get { } //Length: 7
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x6000087")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000027")]
	public float yAdvance
	{
		[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
		[Token(Token = "0x600008C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000025")]
	public float yPlacement
	{
		[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
		[Token(Token = "0x6000088")]
		 get { } //Length: 8
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[Token(Token = "0x6000089")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x27F69A0", Offset = "0x27F5DA0", Length = "0x1A")]
	[Token(Token = "0x600008D")]
	public GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	[Address(RVA = "0x3171740", Offset = "0x3170B40", Length = "0x5E")]
	[Token(Token = "0x6000090")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x31717A0", Offset = "0x3170BA0", Length = "0x7A")]
	[Token(Token = "0x6000091")]
	public override bool Equals(GlyphValueRecord other) { }

	[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
	[Token(Token = "0x600008A")]
	public float get_xAdvance() { }

	[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
	[Token(Token = "0x6000086")]
	public float get_xPlacement() { }

	[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
	[Token(Token = "0x600008C")]
	public float get_yAdvance() { }

	[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
	[Token(Token = "0x6000088")]
	public float get_yPlacement() { }

	[Address(RVA = "0x3171820", Offset = "0x3170C20", Length = "0x4E")]
	[Token(Token = "0x600008F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3171870", Offset = "0x3170C70", Length = "0x13")]
	[Token(Token = "0x600008E")]
	public static GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
	[Token(Token = "0x600008B")]
	public void set_xAdvance(float value) { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x6000087")]
	public void set_xPlacement(float value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[Token(Token = "0x6000089")]
	public void set_yPlacement(float value) { }

}

