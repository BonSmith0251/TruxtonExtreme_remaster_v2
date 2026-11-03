namespace TMPro;

[Token(Token = "0x20000AA")]
public class TMP_TextElement
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000636")]
	internal TextElementType m_ElementType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000637")]
	internal uint m_Unicode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000638")]
	internal TMP_Asset m_TextAsset; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000639")]
	internal Glyph m_Glyph; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400063A")]
	internal uint m_GlyphIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400063B")]
	internal float m_Scale; //Field offset: 0x2C

	[Token(Token = "0x1700018D")]
	public TextElementType elementType
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x600067A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000190")]
	public Glyph glyph
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600067F")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000680")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000191")]
	public uint glyphIndex
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000681")]
		 get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x6000682")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000192")]
	public float scale
	{
		[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
		[Token(Token = "0x6000683")]
		 get { } //Length: 6
		[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
		[Token(Token = "0x6000684")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700018F")]
	public TMP_Asset textAsset
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600067D")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600067E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700018E")]
	public uint unicode
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x600067B")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x600067C")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000685")]
	public TMP_TextElement() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x600067A")]
	public TextElementType get_elementType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600067F")]
	public Glyph get_glyph() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000681")]
	public uint get_glyphIndex() { }

	[Address(RVA = "0x2721910", Offset = "0x2720D10", Length = "0x6")]
	[Token(Token = "0x6000683")]
	public float get_scale() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600067D")]
	public TMP_Asset get_textAsset() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x600067B")]
	public uint get_unicode() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000680")]
	public void set_glyph(Glyph value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x6000682")]
	public void set_glyphIndex(uint value) { }

	[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
	[Token(Token = "0x6000684")]
	public void set_scale(float value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x600067E")]
	public void set_textAsset(TMP_Asset value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x600067C")]
	public void set_unicode(uint value) { }

}

