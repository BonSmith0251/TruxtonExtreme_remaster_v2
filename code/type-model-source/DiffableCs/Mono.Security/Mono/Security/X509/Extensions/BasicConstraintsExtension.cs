namespace Mono.Security.X509.Extensions;

[Token(Token = "0x200002E")]
public class BasicConstraintsExtension : X509Extension
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000086")]
	private bool cA; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000087")]
	private int pathLenConstraint; //Field offset: 0x2C

	[Token(Token = "0x1700004E")]
	public bool CertificateAuthority
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000106")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1E2DC40", Offset = "0x1E2D040", Length = "0x8")]
	[Token(Token = "0x6000103")]
	public BasicConstraintsExtension(X509Extension extension) { }

	[Address(RVA = "0x1E2DCD0", Offset = "0x1E2D0D0", Length = "0x13C")]
	[Token(Token = "0x6000104")]
	protected virtual void Decode() { }

	[Address(RVA = "0x1E2DE10", Offset = "0x1E2D210", Length = "0x1DB")]
	[Token(Token = "0x6000105")]
	protected virtual void Encode() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000106")]
	public bool get_CertificateAuthority() { }

	[Address(RVA = "0x1E2DFF0", Offset = "0x1E2D3F0", Length = "0x16E")]
	[Token(Token = "0x6000107")]
	public virtual string ToString() { }

}

