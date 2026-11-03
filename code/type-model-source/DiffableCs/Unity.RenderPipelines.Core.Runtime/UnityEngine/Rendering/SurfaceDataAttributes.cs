namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x2000175")]
public class SurfaceDataAttributes : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000715")]
	public String[] displayNames; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000716")]
	public bool isDirection; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000717")]
	public bool sRGBDisplay; //Field offset: 0x19
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000718")]
	public FieldPrecision precision; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000719")]
	public bool checkIsNormalized; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400071A")]
	public string preprocessor; //Field offset: 0x28

	[Address(RVA = "0x2C38130", Offset = "0x2C37530", Length = "0xD0")]
	[Token(Token = "0x6000B80")]
	public SurfaceDataAttributes(string displayName = "", bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = 2, bool checkIsNormalized = false, string preprocessor = "") { }

	[Address(RVA = "0x2C38210", Offset = "0x2C37610", Length = "0x76")]
	[Token(Token = "0x6000B81")]
	public SurfaceDataAttributes(String[] displayNames, bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = 2, bool checkIsNormalized = false, string preprocessor = "") { }

}

