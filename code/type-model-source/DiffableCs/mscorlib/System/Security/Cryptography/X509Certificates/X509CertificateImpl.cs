namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000337")]
internal abstract class X509CertificateImpl : IDisposable
{

	[Token(Token = "0x170002A8")]
	public abstract bool HasPrivateKey
	{
		[Token(Token = "0x6001A13")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029E")]
	public abstract string Issuer
	{
		[Token(Token = "0x6001A08")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029D")]
	public abstract bool IsValid
	{
		[Token(Token = "0x6001A05")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A4")]
	public abstract string KeyAlgorithm
	{
		[Token(Token = "0x6001A0F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A5")]
	public abstract Byte[] KeyAlgorithmParameters
	{
		[Token(Token = "0x6001A10")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A1")]
	public abstract DateTime NotAfter
	{
		[Token(Token = "0x6001A0B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A2")]
	public abstract DateTime NotBefore
	{
		[Token(Token = "0x6001A0C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A6")]
	public abstract Byte[] PublicKeyValue
	{
		[Token(Token = "0x6001A11")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A0")]
	public abstract Byte[] RawData
	{
		[Token(Token = "0x6001A0A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A7")]
	public abstract Byte[] SerialNumber
	{
		[Token(Token = "0x6001A12")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700029F")]
	public abstract string Subject
	{
		[Token(Token = "0x6001A09")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A3")]
	public abstract Byte[] Thumbprint
	{
		[Token(Token = "0x6001A0D")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001A1B")]
	protected X509CertificateImpl() { }

	[Token(Token = "0x6001A07")]
	public abstract X509CertificateImpl Clone() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001A19")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1EF43F0", Offset = "0x1EF37F0", Length = "0x61")]
	[Token(Token = "0x6001A18")]
	public override void Dispose() { }

	[Address(RVA = "0x1EF4460", Offset = "0x1EF3860", Length = "0x19C")]
	[Token(Token = "0x6001A17")]
	public virtual bool Equals(object obj) { }

	[Token(Token = "0x6001A16")]
	public abstract Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	[Address(RVA = "0x1EF4600", Offset = "0x1EF3A00", Length = "0x65")]
	[Token(Token = "0x6001A1A")]
	protected virtual void Finalize() { }

	[Token(Token = "0x6001A13")]
	public abstract bool get_HasPrivateKey() { }

	[Token(Token = "0x6001A08")]
	public abstract string get_Issuer() { }

	[Token(Token = "0x6001A05")]
	public abstract bool get_IsValid() { }

	[Token(Token = "0x6001A0F")]
	public abstract string get_KeyAlgorithm() { }

	[Token(Token = "0x6001A10")]
	public abstract Byte[] get_KeyAlgorithmParameters() { }

	[Token(Token = "0x6001A0B")]
	public abstract DateTime get_NotAfter() { }

	[Token(Token = "0x6001A0C")]
	public abstract DateTime get_NotBefore() { }

	[Token(Token = "0x6001A11")]
	public abstract Byte[] get_PublicKeyValue() { }

	[Token(Token = "0x6001A0A")]
	public abstract Byte[] get_RawData() { }

	[Token(Token = "0x6001A12")]
	public abstract Byte[] get_SerialNumber() { }

	[Token(Token = "0x6001A09")]
	public abstract string get_Subject() { }

	[Token(Token = "0x6001A0D")]
	public abstract Byte[] get_Thumbprint() { }

	[Token(Token = "0x6001A15")]
	public abstract DSA GetDSAPrivateKey() { }

	[Address(RVA = "0x1EF4670", Offset = "0x1EF3A70", Length = "0x84")]
	[Token(Token = "0x6001A0E")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x6001A14")]
	public abstract RSA GetRSAPrivateKey() { }

	[Address(RVA = "0x1EF4700", Offset = "0x1EF3B00", Length = "0x4B")]
	[Token(Token = "0x6001A06")]
	protected void ThrowIfContextInvalid() { }

}

