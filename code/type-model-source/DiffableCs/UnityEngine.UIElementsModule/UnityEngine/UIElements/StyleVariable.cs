namespace UnityEngine.UIElements;

[Token(Token = "0x2000494")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleVariable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F22")]
	public readonly string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000F23")]
	public readonly StyleSheet sheet; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F24")]
	public readonly StyleValueHandle[] handles; //Field offset: 0x10

	[Address(RVA = "0x13115B0", Offset = "0x13109B0", Length = "0x4F")]
	[Token(Token = "0x6002251")]
	public StyleVariable(string name, StyleSheet sheet, StyleValueHandle[] handles) { }

	[Address(RVA = "0x3292E10", Offset = "0x3292210", Length = "0x90")]
	[Token(Token = "0x6002252")]
	public virtual int GetHashCode() { }

}

