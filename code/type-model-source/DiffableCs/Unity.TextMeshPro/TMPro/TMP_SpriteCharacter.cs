namespace TMPro;

[Token(Token = "0x200008E")]
public class TMP_SpriteCharacter : TMP_TextElement
{
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40004A2")]
	private string m_Name; //Field offset: 0x30

	[Token(Token = "0x17000109")]
	public string name
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60004BF")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60004C0")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2F12CF0", Offset = "0x2F120F0", Length = "0x1A")]
	[Token(Token = "0x60004C1")]
	public TMP_SpriteCharacter() { }

	[Address(RVA = "0x2F12C80", Offset = "0x2F12080", Length = "0x63")]
	[Token(Token = "0x60004C2")]
	public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph) { }

	[Address(RVA = "0x2F12D10", Offset = "0x2F12110", Length = "0x80")]
	[Token(Token = "0x60004C3")]
	public TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph) { }

	[Address(RVA = "0x2F12C20", Offset = "0x2F12020", Length = "0x5F")]
	[Token(Token = "0x60004C4")]
	internal TMP_SpriteCharacter(uint unicode, uint glyphIndex) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60004BF")]
	public string get_name() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60004C0")]
	public void set_name(string value) { }

}

