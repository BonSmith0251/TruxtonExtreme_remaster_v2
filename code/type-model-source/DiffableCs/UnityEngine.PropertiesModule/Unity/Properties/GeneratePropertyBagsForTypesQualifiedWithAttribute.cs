namespace Unity.Properties;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
[Token(Token = "0x200000D")]
public class GeneratePropertyBagsForTypesQualifiedWithAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001B")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001C")]
	private readonly TypeGenerationOptions <Options>k__BackingField; //Field offset: 0x18

	[Address(RVA = "0x31421D0", Offset = "0x31415D0", Length = "0x116")]
	[Token(Token = "0x600001D")]
	public GeneratePropertyBagsForTypesQualifiedWithAttribute(Type type, TypeGenerationOptions options = 6) { }

}

