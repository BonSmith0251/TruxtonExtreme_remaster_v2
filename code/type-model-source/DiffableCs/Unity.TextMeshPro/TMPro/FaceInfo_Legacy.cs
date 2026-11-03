namespace TMPro;

[Token(Token = "0x200004C")]
public class FaceInfo_Legacy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000222")]
	public string Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000223")]
	public float PointSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000224")]
	public float Scale; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000225")]
	public int CharacterCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000226")]
	public float LineHeight; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000227")]
	public float Baseline; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000228")]
	public float Ascender; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000229")]
	public float CapHeight; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400022A")]
	public float Descender; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400022B")]
	public float CenterLine; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400022C")]
	public float SuperscriptOffset; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400022D")]
	public float SubscriptOffset; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400022E")]
	public float SubSize; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400022F")]
	public float Underline; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000230")]
	public float UnderlineThickness; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000231")]
	public float strikethrough; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000232")]
	public float strikethroughThickness; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000233")]
	public float TabWidth; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000234")]
	public float Padding; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000235")]
	public float AtlasWidth; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000236")]
	public float AtlasHeight; //Field offset: 0x64

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000298")]
	public FaceInfo_Legacy() { }

}

