namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200012B")]
public sealed class X509BasicConstraintsExtension : X509Extension
{
	[Token(Token = "0x4000581")]
	internal const string oid = "2.5.29.19"; //Field offset: 0x0
	[Token(Token = "0x4000582")]
	internal const string friendlyName = "Basic Constraints"; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000583")]
	private bool _certificateAuthority; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000584")]
	private bool _hasPathLengthConstraint; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000585")]
	private int _pathLengthConstraint; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000586")]
	private AsnDecodeStatus _status; //Field offset: 0x30

	[Token(Token = "0x1700011C")]
	public bool CertificateAuthority
	{
		[Address(RVA = "0x264AF30", Offset = "0x264A330", Length = "0x6B")]
		[Token(Token = "0x60006F3")]
		 get { } //Length: 107
	}

	[Token(Token = "0x1700011D")]
	public bool HasPathLengthConstraint
	{
		[Address(RVA = "0x264AFA0", Offset = "0x264A3A0", Length = "0x6B")]
		[Token(Token = "0x60006F4")]
		 get { } //Length: 107
	}

	[Token(Token = "0x1700011E")]
	public int PathLengthConstraint
	{
		[Address(RVA = "0x264B010", Offset = "0x264A410", Length = "0x6A")]
		[Token(Token = "0x60006F5")]
		 get { } //Length: 106
	}

	[Address(RVA = "0x264ADC0", Offset = "0x264A1C0", Length = "0x8D")]
	[Token(Token = "0x60006F0")]
	public X509BasicConstraintsExtension() { }

	[Address(RVA = "0x264AE50", Offset = "0x264A250", Length = "0xDA")]
	[Token(Token = "0x60006F1")]
	public X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical) { }

	[Address(RVA = "0x264AB50", Offset = "0x2649F50", Length = "0x26A")]
	[Token(Token = "0x60006F2")]
	public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	[Address(RVA = "0x264A430", Offset = "0x2649830", Length = "0x1DE")]
	[Token(Token = "0x60006F6")]
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	[Address(RVA = "0x264A610", Offset = "0x2649A10", Length = "0x15F")]
	[Token(Token = "0x60006F7")]
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	[Address(RVA = "0x264A780", Offset = "0x2649B80", Length = "0x174")]
	[Token(Token = "0x60006F8")]
	internal Byte[] Encode() { }

	[Address(RVA = "0x264AF30", Offset = "0x264A330", Length = "0x6B")]
	[Token(Token = "0x60006F3")]
	public bool get_CertificateAuthority() { }

	[Address(RVA = "0x264AFA0", Offset = "0x264A3A0", Length = "0x6B")]
	[Token(Token = "0x60006F4")]
	public bool get_HasPathLengthConstraint() { }

	[Address(RVA = "0x264B010", Offset = "0x264A410", Length = "0x6A")]
	[Token(Token = "0x60006F5")]
	public int get_PathLengthConstraint() { }

	[Address(RVA = "0x264A900", Offset = "0x2649D00", Length = "0x24D")]
	[Token(Token = "0x60006F9")]
	internal virtual string ToString(bool multiLine) { }

}

