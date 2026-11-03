namespace System.Net;

[Token(Token = "0x200024E")]
public sealed class HttpContinueDelegate : MulticastDelegate
{

	[Address(RVA = "0x60A180", Offset = "0x609580", Length = "0xA6")]
	[Token(Token = "0x6000F81")]
	public HttpContinueDelegate(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000F82")]
	public override void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }

}

