namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200001A")]
public class Character : TextElement
{

	[Address(RVA = "0x3171CF0", Offset = "0x31710F0", Length = "0x2C")]
	[Token(Token = "0x6000050")]
	public Character() { }

	[Address(RVA = "0x3171D20", Offset = "0x3171120", Length = "0x9B")]
	[Token(Token = "0x6000051")]
	public Character(uint unicode, FontAsset fontAsset, Glyph glyph) { }

	[Address(RVA = "0x3171C70", Offset = "0x3171070", Length = "0x78")]
	[Token(Token = "0x6000052")]
	internal Character(uint unicode, uint glyphIndex) { }

}

