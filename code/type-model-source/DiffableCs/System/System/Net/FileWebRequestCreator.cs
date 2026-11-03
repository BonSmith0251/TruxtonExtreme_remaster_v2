namespace System.Net;

[Token(Token = "0x2000282")]
internal class FileWebRequestCreator : IWebRequestCreate
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60010ED")]
	internal FileWebRequestCreator() { }

	[Address(RVA = "0x26C0F40", Offset = "0x26C0340", Length = "0x1AC")]
	[Token(Token = "0x60010EE")]
	public override WebRequest Create(Uri uri) { }

}

