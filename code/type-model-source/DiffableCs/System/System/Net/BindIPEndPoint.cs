namespace System.Net;

[Token(Token = "0x2000291")]
public sealed class BindIPEndPoint : MulticastDelegate
{

	[Address(RVA = "0x26B39C0", Offset = "0x26B2DC0", Length = "0x125")]
	[Token(Token = "0x6001136")]
	public BindIPEndPoint(object object, IntPtr method) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6001137")]
	public override IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }

}

