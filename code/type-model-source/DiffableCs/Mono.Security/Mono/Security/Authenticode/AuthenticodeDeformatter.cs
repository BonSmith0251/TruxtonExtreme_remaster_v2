namespace Mono.Security.Authenticode;

[Token(Token = "0x2000054")]
public class AuthenticodeDeformatter : AuthenticodeBase
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400023A")]
	private string filename; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400023B")]
	private Byte[] rawdata; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400023C")]
	private Byte[] hash; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400023D")]
	private X509CertificateCollection coll; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400023E")]
	private ASN1 signedHash; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400023F")]
	private DateTime timestamp; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000240")]
	private X509Certificate signingCertificate; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000241")]
	private int reason; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000242")]
	private bool trustedRoot; //Field offset: 0x7C
	[FieldOffset(Offset = "0x7D")]
	[Token(Token = "0x4000243")]
	private bool trustedTimestampRoot; //Field offset: 0x7D
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000244")]
	private Byte[] entry; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000245")]
	private X509Chain signerChain; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000246")]
	private X509Chain timestampChain; //Field offset: 0x90

	[Token(Token = "0x17000084")]
	public Byte[] RawData
	{
		[Address(RVA = "0x1E49A60", Offset = "0x1E48E60", Length = "0x150")]
		[Token(Token = "0x60001D9")]
		 set { } //Length: 336
	}

	[Token(Token = "0x17000085")]
	public X509Certificate SigningCertificate
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x60001DA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1E49880", Offset = "0x1E48C80", Length = "0xDF")]
	[Token(Token = "0x60001D7")]
	public AuthenticodeDeformatter() { }

	[Address(RVA = "0x1E49960", Offset = "0x1E48D60", Length = "0xFA")]
	[Token(Token = "0x60001D8")]
	public AuthenticodeDeformatter(Byte[] rawData) { }

	[Address(RVA = "0x1E46AB0", Offset = "0x1E45EB0", Length = "0x1970")]
	[Token(Token = "0x60001DB")]
	private bool CheckSignature() { }

	[Address(RVA = "0x1E48430", Offset = "0x1E47830", Length = "0x111")]
	[Token(Token = "0x60001DC")]
	private bool CompareIssuerSerial(string issuer, Byte[] serial, X509Certificate x509) { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x60001DA")]
	public X509Certificate get_SigningCertificate() { }

	[Address(RVA = "0x1E48550", Offset = "0x1E47950", Length = "0xF9")]
	[Token(Token = "0x60001DF")]
	private void Reset() { }

	[Address(RVA = "0x1E49A60", Offset = "0x1E48E60", Length = "0x150")]
	[Token(Token = "0x60001D9")]
	public void set_RawData(Byte[] value) { }

	[Address(RVA = "0x1E48650", Offset = "0x1E47A50", Length = "0x893")]
	[Token(Token = "0x60001DE")]
	private bool VerifyCounterSignature(SignerInfo cs, Byte[] signature) { }

	[Address(RVA = "0x1E48EF0", Offset = "0x1E482F0", Length = "0x989")]
	[Token(Token = "0x60001DD")]
	private bool VerifySignature(SignedData sd, Byte[] calculatedMessageDigest, HashAlgorithm ha) { }

}

