namespace System.Resources;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False)]
[Token(Token = "0x20004B8")]
public sealed class NeutralResourcesLanguageAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400129B")]
	private readonly string <CultureName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400129C")]
	private readonly UltimateResourceFallbackLocation <Location>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000416")]
	public string CultureName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60021A2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000417")]
	public UltimateResourceFallbackLocation Location
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60021A3")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1F39610", Offset = "0x1F38A10", Length = "0x86")]
	[Token(Token = "0x60021A1")]
	public NeutralResourcesLanguageAttribute(string cultureName) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60021A2")]
	public string get_CultureName() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60021A3")]
	public UltimateResourceFallbackLocation get_Location() { }

}

