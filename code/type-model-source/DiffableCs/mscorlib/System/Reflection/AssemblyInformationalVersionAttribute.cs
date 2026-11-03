namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
[Token(Token = "0x20004D1")]
public sealed class AssemblyInformationalVersionAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012F3")]
	private readonly string <InformationalVersion>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6002209")]
	public AssemblyInformationalVersionAttribute(string informationalVersion) { }

}

