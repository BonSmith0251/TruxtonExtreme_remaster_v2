namespace TMPro;

[ExcludeFromPreset]
[Token(Token = "0x2000032")]
public class TMP_ColorGradient : ScriptableObject
{
	[Token(Token = "0x4000175")]
	private const ColorMode k_DefaultColorMode = 3; //Field offset: 0x0
	[Token(Token = "0x4000176")]
	private static readonly Color k_DefaultColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000170")]
	public ColorMode colorMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000171")]
	public Color topLeft; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000172")]
	public Color topRight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000173")]
	public Color bottomLeft; //Field offset: 0x3C
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000174")]
	public Color bottomRight; //Field offset: 0x4C

	[Address(RVA = "0x2EAF8E0", Offset = "0x2EAECE0", Length = "0x3E")]
	[Token(Token = "0x6000179")]
	private static TMP_ColorGradient() { }

	[Address(RVA = "0x2EAF920", Offset = "0x2EAED20", Length = "0xAF")]
	[Token(Token = "0x6000176")]
	public TMP_ColorGradient() { }

	[Address(RVA = "0x2EAF9D0", Offset = "0x2EAEDD0", Length = "0x43")]
	[Token(Token = "0x6000177")]
	public TMP_ColorGradient(Color color) { }

	[Address(RVA = "0x2EAFA20", Offset = "0x2EAEE20", Length = "0x6B")]
	[Token(Token = "0x6000178")]
	public TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3) { }

}

