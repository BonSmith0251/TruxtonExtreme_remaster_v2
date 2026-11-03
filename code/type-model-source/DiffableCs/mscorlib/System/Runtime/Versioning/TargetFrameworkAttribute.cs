namespace System.Runtime.Versioning;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False, Inherited = False)]
[Token(Token = "0x20003D0")]
public sealed class TargetFrameworkAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F1E")]
	private string _frameworkName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F1F")]
	private string _frameworkDisplayName; //Field offset: 0x18

	[Token(Token = "0x170003A0")]
	public string FrameworkDisplayName
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6001D7B")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1F157D0", Offset = "0x1F14BD0", Length = "0x7E")]
	[Token(Token = "0x6001D7A")]
	public TargetFrameworkAttribute(string frameworkName) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6001D7B")]
	public void set_FrameworkDisplayName(string value) { }

}

