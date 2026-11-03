namespace TMPro;

[Token(Token = "0x2000089")]
public class TMP_Sprite : TMP_TextElement_Legacy
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400047D")]
	public string name; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400047E")]
	public int hashCode; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400047F")]
	public int unicode; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000480")]
	public Vector2 pivot; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000481")]
	public Sprite sprite; //Field offset: 0x50

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000496")]
	public TMP_Sprite() { }

}

