namespace System.Reflection;

[AttributeUsage(AttributeTargets::Assembly (1), Inherited = False)]
[Token(Token = "0x20004D0")]
public sealed class AssemblyFileVersionAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012F2")]
	private readonly string <Version>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x1F31950", Offset = "0x1F30D50", Length = "0x7E")]
	[Token(Token = "0x6002208")]
	public AssemblyFileVersionAttribute(string version) { }

}

