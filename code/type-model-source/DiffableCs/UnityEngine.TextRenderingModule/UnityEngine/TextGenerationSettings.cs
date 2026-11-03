namespace UnityEngine;

[Token(Token = "0x2000004")]
public struct TextGenerationSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000B")]
	public Font font; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400000C")]
	public Color color; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000D")]
	public int fontSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400000E")]
	public float lineSpacing; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000F")]
	public bool richText; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000010")]
	public float scaleFactor; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000011")]
	public FontStyle fontStyle; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000012")]
	public TextAnchor textAnchor; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000013")]
	public bool alignByGeometry; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000014")]
	public bool resizeTextForBestFit; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000015")]
	public int resizeTextMinSize; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000016")]
	public int resizeTextMaxSize; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000017")]
	public bool updateBounds; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000018")]
	public VerticalWrapMode verticalOverflow; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000019")]
	public HorizontalWrapMode horizontalOverflow; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400001A")]
	public Vector2 generationExtents; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400001B")]
	public Vector2 pivot; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400001C")]
	public bool generateOutOfBounds; //Field offset: 0x58

	[Address(RVA = "0x31CB810", Offset = "0x31CAC10", Length = "0x7A")]
	[Token(Token = "0x6000001")]
	private bool CompareColors(Color left, Color right) { }

	[Address(RVA = "0x31CB890", Offset = "0x31CAC90", Length = "0x44")]
	[Token(Token = "0x6000002")]
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	[Address(RVA = "0x31CB8E0", Offset = "0x31CACE0", Length = "0x272")]
	[Token(Token = "0x6000003")]
	public bool Equals(TextGenerationSettings other) { }

}

