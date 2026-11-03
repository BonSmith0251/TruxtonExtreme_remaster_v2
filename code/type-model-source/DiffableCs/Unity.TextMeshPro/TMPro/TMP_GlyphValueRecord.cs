namespace TMPro;

[Token(Token = "0x200005B")]
public struct TMP_GlyphValueRecord
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400026A")]
	internal float m_XPlacement; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x400026B")]
	internal float m_YPlacement; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x400026C")]
	internal float m_XAdvance; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[Token(Token = "0x400026D")]
	internal float m_YAdvance; //Field offset: 0xC

	[Token(Token = "0x17000085")]
	public float xAdvance
	{
		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[Token(Token = "0x60002D0")]
		 get { } //Length: 229
		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[Token(Token = "0x60002D1")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000083")]
	public float xPlacement
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x60002CC")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x60002CD")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000086")]
	public float yAdvance
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[Token(Token = "0x60002D2")]
		 get { } //Length: 6
		[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
		[Token(Token = "0x60002D3")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000084")]
	public float yPlacement
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[Token(Token = "0x60002CE")]
		 get { } //Length: 388
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[Token(Token = "0x60002CF")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x27F69A0", Offset = "0x27F5DA0", Length = "0x1A")]
	[Token(Token = "0x60002D4")]
	public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	[Address(RVA = "0x2A8B9E0", Offset = "0x2A8ADE0", Length = "0x17")]
	[Token(Token = "0x60002D5")]
	internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord) { }

	[Address(RVA = "0x2EC56E0", Offset = "0x2EC4AE0", Length = "0x56")]
	[Token(Token = "0x60002D6")]
	internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord) { }

	[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
	[Token(Token = "0x60002D0")]
	public float get_xAdvance() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x60002CC")]
	public float get_xPlacement() { }

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[Token(Token = "0x60002D2")]
	public float get_yAdvance() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[Token(Token = "0x60002CE")]
	public float get_yPlacement() { }

	[Address(RVA = "0x2EC88F0", Offset = "0x2EC7CF0", Length = "0x11")]
	[Token(Token = "0x60002D7")]
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }

	[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
	[Token(Token = "0x60002D1")]
	public void set_xAdvance(float value) { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x60002CD")]
	public void set_xPlacement(float value) { }

	[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
	[Token(Token = "0x60002D3")]
	public void set_yAdvance(float value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[Token(Token = "0x60002CF")]
	public void set_yPlacement(float value) { }

}

