namespace System.Text.RegularExpressions;

[Token(Token = "0x20000F4")]
public abstract class RegexRunnerFactory
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000607")]
	protected RegexRunnerFactory() { }

	[Token(Token = "0x6000608")]
	protected private abstract RegexRunner CreateInstance() { }

}

