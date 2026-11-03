namespace System.Resources;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False)]
[Token(Token = "0x20004BB")]
public sealed class SatelliteContractVersionAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012B8")]
	private readonly string <Version>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x1F42130", Offset = "0x1F41530", Length = "0x7E")]
	[Token(Token = "0x60021B0")]
	public SatelliteContractVersionAttribute(string version) { }

}

