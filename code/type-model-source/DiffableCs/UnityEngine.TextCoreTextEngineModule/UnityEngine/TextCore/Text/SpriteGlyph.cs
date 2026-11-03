namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000039")]
public class SpriteGlyph : Glyph
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400018A")]
	public Sprite sprite; //Field offset: 0x48

	[Address(RVA = "0x2F12F00", Offset = "0x2F12300", Length = "0x7")]
	[Token(Token = "0x6000174")]
	public SpriteGlyph() { }

}

