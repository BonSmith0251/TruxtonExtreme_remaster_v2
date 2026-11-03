namespace System.Xml;

[Token(Token = "0x200002E")]
internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter
{

	[Token(Token = "0x17000041")]
	public bool Namespaces
	{
		[Token(Token = "0x6000174")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000040")]
	public bool Normalization
	{
		[Token(Token = "0x6000173")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700003F")]
	public bool V1CompatibilityMode
	{
		[Token(Token = "0x6000172")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000174")]
	public bool get_Namespaces() { }

	[Token(Token = "0x6000173")]
	public bool get_Normalization() { }

	[Token(Token = "0x6000172")]
	public bool get_V1CompatibilityMode() { }

}

