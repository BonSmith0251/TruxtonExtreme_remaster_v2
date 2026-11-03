namespace System.Net.Security;

[Token(Token = "0x2000320")]
internal sealed class ServerCertSelectionCallback : MulticastDelegate
{

	[Address(RVA = "0x10DF120", Offset = "0x10DE520", Length = "0xB4")]
	[Token(Token = "0x60014CD")]
	public ServerCertSelectionCallback(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x60014CE")]
	public override X509Certificate Invoke(string hostName) { }

}

