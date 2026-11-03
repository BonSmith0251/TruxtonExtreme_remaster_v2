namespace System.Net.Configuration;

[Token(Token = "0x2000339")]
public sealed class PerformanceCountersElement : ConfigurationElement
{

	[Token(Token = "0x17000489")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x25E17E0", Offset = "0x25E0BE0", Length = "0x2C")]
		[Token(Token = "0x6001509")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25E17B0", Offset = "0x25E0BB0", Length = "0x2C")]
	[Token(Token = "0x6001508")]
	public PerformanceCountersElement() { }

	[Address(RVA = "0x25E17E0", Offset = "0x25E0BE0", Length = "0x2C")]
	[Token(Token = "0x6001509")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

