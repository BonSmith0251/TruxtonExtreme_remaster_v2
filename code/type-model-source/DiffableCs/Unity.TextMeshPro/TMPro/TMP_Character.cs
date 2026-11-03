namespace TMPro;

[Token(Token = "0x200002C")]
public class TMP_Character : TMP_TextElement
{

	[Address(RVA = "0x2EAF740", Offset = "0x2EAEB40", Length = "0x21")]
	[Token(Token = "0x6000154")]
	public TMP_Character() { }

	[Address(RVA = "0x2EAF7D0", Offset = "0x2EAEBD0", Length = "0x76")]
	[Token(Token = "0x6000155")]
	public TMP_Character(uint unicode, Glyph glyph) { }

	[Address(RVA = "0x2EAF850", Offset = "0x2EAEC50", Length = "0x80")]
	[Token(Token = "0x6000156")]
	public TMP_Character(uint unicode, TMP_FontAsset fontAsset, Glyph glyph) { }

	[Address(RVA = "0x2EAF770", Offset = "0x2EAEB70", Length = "0x5F")]
	[Token(Token = "0x6000157")]
	internal TMP_Character(uint unicode, uint glyphIndex) { }

}

