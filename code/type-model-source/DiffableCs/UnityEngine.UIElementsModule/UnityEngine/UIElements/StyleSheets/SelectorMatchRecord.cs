namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x200063A")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct SelectorMatchRecord : IEquatable<SelectorMatchRecord>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001768")]
	public StyleSheet sheet; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001769")]
	public int styleSheetIndexInStack; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400176A")]
	public StyleComplexSelector complexSelector; //Field offset: 0x10

	[Address(RVA = "0x334F5F0", Offset = "0x334E9F0", Length = "0x30")]
	[Token(Token = "0x6002C61")]
	public SelectorMatchRecord(StyleSheet sheet, int styleSheetIndexInStack) { }

	[Address(RVA = "0x334F2E0", Offset = "0x334E6E0", Length = "0x14A")]
	[Token(Token = "0x6002C62")]
	public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b) { }

	[Address(RVA = "0x334F430", Offset = "0x334E830", Length = "0x6F")]
	[Token(Token = "0x6002C63")]
	public override bool Equals(SelectorMatchRecord other) { }

	[Address(RVA = "0x334F4A0", Offset = "0x334E8A0", Length = "0xCB")]
	[Token(Token = "0x6002C64")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x334F570", Offset = "0x334E970", Length = "0x7C")]
	[Token(Token = "0x6002C65")]
	public virtual int GetHashCode() { }

}

