namespace Mono.Security.Interface;

[Token(Token = "0x2000040")]
public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate
{

	[Address(RVA = "0x1E51D80", Offset = "0x1E51180", Length = "0xB5")]
	[Token(Token = "0x600014E")]
	public MonoRemoteCertificateValidationCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
	[Token(Token = "0x600014F")]
	public override bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

}

