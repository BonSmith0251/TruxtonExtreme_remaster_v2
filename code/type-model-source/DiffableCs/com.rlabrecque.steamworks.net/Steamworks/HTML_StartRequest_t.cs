namespace Steamworks;

[CallbackIdentity(4503)]
[Token(Token = "0x2000057")]
public struct HTML_StartRequest_t
{
	[Token(Token = "0x40000AD")]
	public const int k_iCallback = 4503; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AE")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000AF")]
	public string pchURL; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B0")]
	public string pchTarget; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B1")]
	public string pchPostData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000B2")]
	public bool bIsRedirect; //Field offset: 0x20

}

