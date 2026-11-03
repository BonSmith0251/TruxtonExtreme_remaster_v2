namespace Mono.Security.X509;

[Token(Token = "0x2000014")]
public class X509Chain
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000062")]
	private X509CertificateCollection roots; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000063")]
	private X509CertificateCollection certs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000064")]
	private X509Certificate _root; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000065")]
	private X509CertificateCollection _chain; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000066")]
	private X509ChainStatusFlags _status; //Field offset: 0x30

	[Token(Token = "0x1700003D")]
	public X509CertificateCollection TrustAnchors
	{
		[Address(RVA = "0x1E42280", Offset = "0x1E41680", Length = "0x96")]
		[Token(Token = "0x60000BC")]
		 get { } //Length: 150
	}

	[Address(RVA = "0x1E42210", Offset = "0x1E41610", Length = "0x66")]
	[Token(Token = "0x60000BB")]
	public X509Chain() { }

	[Address(RVA = "0x1E416A0", Offset = "0x1E40AA0", Length = "0x3DF")]
	[Token(Token = "0x60000BE")]
	public bool Build(X509Certificate leaf) { }

	[Address(RVA = "0x1E41A80", Offset = "0x1E40E80", Length = "0x1D5")]
	[Token(Token = "0x60000C1")]
	private X509Certificate FindCertificateParent(X509Certificate child) { }

	[Address(RVA = "0x1E41C60", Offset = "0x1E41060", Length = "0x1EB")]
	[Token(Token = "0x60000C2")]
	private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	[Address(RVA = "0x1E42280", Offset = "0x1E41680", Length = "0x96")]
	[Token(Token = "0x60000BC")]
	public X509CertificateCollection get_TrustAnchors() { }

	[Address(RVA = "0x1E41E50", Offset = "0x1E41250", Length = "0x17D")]
	[Token(Token = "0x60000C4")]
	private bool IsParent(X509Certificate child, X509Certificate parent) { }

	[Address(RVA = "0x1E41FD0", Offset = "0x1E413D0", Length = "0x34")]
	[Token(Token = "0x60000C3")]
	private bool IsTrusted(X509Certificate potentialTrusted) { }

	[Address(RVA = "0x1E42010", Offset = "0x1E41410", Length = "0x187")]
	[Token(Token = "0x60000C0")]
	private bool IsValid(X509Certificate cert) { }

	[Address(RVA = "0x1E421A0", Offset = "0x1E415A0", Length = "0x1E")]
	[Token(Token = "0x60000BD")]
	public void LoadCertificates(X509CertificateCollection collection) { }

	[Address(RVA = "0x1E421C0", Offset = "0x1E415C0", Length = "0x4F")]
	[Token(Token = "0x60000BF")]
	public void Reset() { }

}

