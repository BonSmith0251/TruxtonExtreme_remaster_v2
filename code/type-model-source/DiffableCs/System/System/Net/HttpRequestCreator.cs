namespace System.Net;

[Token(Token = "0x200029F")]
internal class HttpRequestCreator : IWebRequestCreate
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600117A")]
	internal HttpRequestCreator() { }

	[Address(RVA = "0x26C7A70", Offset = "0x26C6E70", Length = "0x54")]
	[Token(Token = "0x600117B")]
	public override WebRequest Create(Uri uri) { }

}

