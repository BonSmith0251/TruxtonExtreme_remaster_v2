namespace TMPro;

[Token(Token = "0x200008F")]
public class TMP_SpriteGlyph : Glyph
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004A3")]
	public Sprite sprite; //Field offset: 0x48

	[Address(RVA = "0x2F12F00", Offset = "0x2F12300", Length = "0x7")]
	[Token(Token = "0x60004C5")]
	public TMP_SpriteGlyph() { }

	[Address(RVA = "0x2F12E60", Offset = "0x2F12260", Length = "0x9E")]
	[Token(Token = "0x60004C6")]
	public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

	[Address(RVA = "0x2F12DA0", Offset = "0x2F121A0", Length = "0xB3")]
	[Token(Token = "0x60004C7")]
	public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite) { }

}

