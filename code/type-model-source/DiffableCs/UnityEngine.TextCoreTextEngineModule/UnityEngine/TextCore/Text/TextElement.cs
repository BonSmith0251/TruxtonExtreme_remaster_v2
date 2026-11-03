namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000044")]
public abstract class TextElement
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40001CC")]
	protected TextElementType m_ElementType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x40001CD")]
	internal uint m_Unicode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001CE")]
	internal TextAsset m_TextAsset; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001CF")]
	internal Glyph m_Glyph; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40001D0")]
	internal uint m_GlyphIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40001D1")]
	internal float m_Scale; //Field offset: 0x2C

	[Token(Token = "0x1700005C")]
	public TextElementType elementType
	{
		[Address(RVA = "0x2F896E0", Offset = "0x2F88AE0", Length = "0x7")]
		[Token(Token = "0x60001DD")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700005F")]
	public Glyph glyph
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x60001E2")]
		 get { } //Length: 7
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60001E3")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000060")]
	public uint glyphIndex
	{
		[Address(RVA = "0x1073730", Offset = "0x1072B30", Length = "0x6")]
		[Token(Token = "0x60001E4")]
		 get { } //Length: 6
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x60001E5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000061")]
	public float scale
	{
		[Address(RVA = "0x2F92DB0", Offset = "0x2F921B0", Length = "0x8")]
		[Token(Token = "0x60001E6")]
		 get { } //Length: 8
		[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
		[Token(Token = "0x60001E7")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700005E")]
	public TextAsset textAsset
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x60001E0")]
		 get { } //Length: 7
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60001E1")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700005D")]
	public uint unicode
	{
		[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
		[Token(Token = "0x60001DE")]
		 get { } //Length: 6
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x60001DF")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001E8")]
	protected TextElement() { }

	[Address(RVA = "0x2F896E0", Offset = "0x2F88AE0", Length = "0x7")]
	[Token(Token = "0x60001DD")]
	public TextElementType get_elementType() { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x60001E2")]
	public Glyph get_glyph() { }

	[Address(RVA = "0x1073730", Offset = "0x1072B30", Length = "0x6")]
	[Token(Token = "0x60001E4")]
	public uint get_glyphIndex() { }

	[Address(RVA = "0x2F92DB0", Offset = "0x2F921B0", Length = "0x8")]
	[Token(Token = "0x60001E6")]
	public float get_scale() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x60001E0")]
	public TextAsset get_textAsset() { }

	[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
	[Token(Token = "0x60001DE")]
	public uint get_unicode() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60001E3")]
	public void set_glyph(Glyph value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x60001E5")]
	public void set_glyphIndex(uint value) { }

	[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
	[Token(Token = "0x60001E7")]
	public void set_scale(float value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60001E1")]
	public void set_textAsset(TextAsset value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x60001DF")]
	public void set_unicode(uint value) { }

}

