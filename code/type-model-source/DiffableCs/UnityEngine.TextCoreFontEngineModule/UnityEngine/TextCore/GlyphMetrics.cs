namespace UnityEngine.TextCore;

[Token(Token = "0x2000005")]
[UsedByNativeCode]
public struct GlyphMetrics : IEquatable<GlyphMetrics>
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("width")]
	[SerializeField]
	[Token(Token = "0x4000021")]
	private float m_Width; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("height")]
	[SerializeField]
	[Token(Token = "0x4000022")]
	private float m_Height; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("horizontalBearingX")]
	[SerializeField]
	[Token(Token = "0x4000023")]
	private float m_HorizontalBearingX; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("horizontalBearingY")]
	[SerializeField]
	[Token(Token = "0x4000024")]
	private float m_HorizontalBearingY; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("horizontalAdvance")]
	[SerializeField]
	[Token(Token = "0x4000025")]
	private float m_HorizontalAdvance; //Field offset: 0x10

	[Token(Token = "0x1700001B")]
	public float height
	{
		[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
		[Token(Token = "0x6000025")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001E")]
	public float horizontalAdvance
	{
		[Address(RVA = "0x2FB4C90", Offset = "0x2FB4090", Length = "0x8")]
		[Token(Token = "0x6000028")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001C")]
	public float horizontalBearingX
	{
		[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001D")]
	public float horizontalBearingY
	{
		[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001A")]
	public float width
	{
		[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x3171350", Offset = "0x3170750", Length = "0x25")]
	[Token(Token = "0x6000029")]
	public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance) { }

	[Address(RVA = "0x3171280", Offset = "0x3170680", Length = "0x65")]
	[Token(Token = "0x600002B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x31711F0", Offset = "0x31705F0", Length = "0x88")]
	[Token(Token = "0x600002C")]
	public override bool Equals(GlyphMetrics other) { }

	[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
	[Token(Token = "0x6000025")]
	public float get_height() { }

	[Address(RVA = "0x2FB4C90", Offset = "0x2FB4090", Length = "0x8")]
	[Token(Token = "0x6000028")]
	public float get_horizontalAdvance() { }

	[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
	[Token(Token = "0x6000026")]
	public float get_horizontalBearingX() { }

	[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
	[Token(Token = "0x6000027")]
	public float get_horizontalBearingY() { }

	[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
	[Token(Token = "0x6000024")]
	public float get_width() { }

	[Address(RVA = "0x31712F0", Offset = "0x31706F0", Length = "0x55")]
	[Token(Token = "0x600002A")]
	public virtual int GetHashCode() { }

}

