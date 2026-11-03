namespace System.Net;

[Token(Token = "0x2000239")]
internal class FtpWebRequestCreator : IWebRequestCreate
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000F2C")]
	internal FtpWebRequestCreator() { }

	[Address(RVA = "0x26A1730", Offset = "0x26A0B30", Length = "0x54")]
	[Token(Token = "0x6000F2D")]
	public override WebRequest Create(Uri uri) { }

}

