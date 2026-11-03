namespace System.Xml;

[Token(Token = "0x200002D")]
internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter
{

	[Token(Token = "0x1700003D")]
	public bool DtdValidation
	{
		[Token(Token = "0x6000170")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700003E")]
	public IValidationEventHandling ValidationEventHandling
	{
		[Token(Token = "0x6000171")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000170")]
	public bool get_DtdValidation() { }

	[Token(Token = "0x6000171")]
	public IValidationEventHandling get_ValidationEventHandling() { }

}

