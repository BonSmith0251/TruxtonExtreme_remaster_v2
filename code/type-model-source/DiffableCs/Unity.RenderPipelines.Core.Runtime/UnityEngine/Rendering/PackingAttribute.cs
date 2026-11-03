namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = True)]
[Token(Token = "0x2000177")]
public class PackingAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400071D")]
	public String[] displayNames; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400071E")]
	public Single[] range; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400071F")]
	public FieldPacking packingScheme; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000720")]
	public int offsetInSource; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000721")]
	public int sizeInBits; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000722")]
	public bool isDirection; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4000723")]
	public bool sRGBDisplay; //Field offset: 0x2D
	[FieldOffset(Offset = "0x2E")]
	[Token(Token = "0x4000724")]
	public bool checkIsNormalized; //Field offset: 0x2E
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000725")]
	public string preprocessor; //Field offset: 0x30

	[Address(RVA = "0x2C2F9B0", Offset = "0x2C2EDB0", Length = "0xF7")]
	[Token(Token = "0x6000B83")]
	public PackingAttribute(String[] displayNames, FieldPacking packingScheme = 0, int bitSize = 32, int offsetInSource = 0, float minValue = 0, float maxValue = 1, bool isDirection = false, bool sRGBDisplay = false, bool checkIsNormalized = false, string preprocessor = "") { }

	[Address(RVA = "0x2C2FAB0", Offset = "0x2C2EEB0", Length = "0x13B")]
	[Token(Token = "0x6000B84")]
	public PackingAttribute(string displayName = "", FieldPacking packingScheme = 0, int bitSize = 0, int offsetInSource = 0, float minValue = 0, float maxValue = 1, bool isDirection = false, bool sRGBDisplay = false, bool checkIsNormalized = false, string preprocessor = "") { }

}

