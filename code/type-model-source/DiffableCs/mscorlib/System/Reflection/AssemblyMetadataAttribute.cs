namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True, Inherited = False)]
[Token(Token = "0x20004D3")]
public sealed class AssemblyMetadataAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012F5")]
	private readonly string <Key>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012F6")]
	private readonly string <Value>k__BackingField; //Field offset: 0x18

	[Address(RVA = "0x1F319D0", Offset = "0x1F30DD0", Length = "0x4E")]
	[Token(Token = "0x600220B")]
	public AssemblyMetadataAttribute(string key, string value) { }

}

