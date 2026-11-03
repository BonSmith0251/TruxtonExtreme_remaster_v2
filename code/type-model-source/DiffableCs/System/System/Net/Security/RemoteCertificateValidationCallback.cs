namespace System.Net.Security;

[Token(Token = "0x200031D")]
public sealed class RemoteCertificateValidationCallback : MulticastDelegate
{

	[Address(RVA = "0x25E1870", Offset = "0x25E0C70", Length = "0x125")]
	[Token(Token = "0x60014C9")]
	public RemoteCertificateValidationCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
	[Token(Token = "0x60014CA")]
	public override bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

