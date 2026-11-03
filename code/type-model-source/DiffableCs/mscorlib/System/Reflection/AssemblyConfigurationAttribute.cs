namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
[Token(Token = "0x20004CA")]
public sealed class AssemblyConfigurationAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012EA")]
	private readonly string <Configuration>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6002203")]
	public AssemblyConfigurationAttribute(string configuration) { }

}

