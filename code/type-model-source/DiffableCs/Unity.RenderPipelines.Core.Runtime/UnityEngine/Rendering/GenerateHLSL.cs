namespace UnityEngine.Rendering;

[AttributeUsage(28)]
[Token(Token = "0x2000174")]
public class GenerateHLSL : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400070B")]
	public PackingRules packingRules; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400070C")]
	public bool containsPackedFields; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x400070D")]
	public bool needAccessors; //Field offset: 0x15
	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x400070E")]
	public bool needSetters; //Field offset: 0x16
	[FieldOffset(Offset = "0x17")]
	[Token(Token = "0x400070F")]
	public bool needParamDebug; //Field offset: 0x17
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000710")]
	public int paramDefinesStart; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000711")]
	public bool omitStructDeclaration; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x4000712")]
	public bool generateCBuffer; //Field offset: 0x1D
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000713")]
	public int constantRegister; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000714")]
	public string sourcePath; //Field offset: 0x28

	[Address(RVA = "0x2C238A0", Offset = "0x2C22CA0", Length = "0x8B")]
	[Token(Token = "0x6000B7F")]
	public GenerateHLSL(PackingRules rules = 0, bool needAccessors = true, bool needSetters = false, bool needParamDebug = false, int paramDefinesStart = 1, bool omitStructDeclaration = false, bool containsPackedFields = false, bool generateCBuffer = false, int constantRegister = -1, string sourcePath = null) { }

}

