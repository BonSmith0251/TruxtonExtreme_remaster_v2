namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000144")]
public sealed class X509SubjectKeyIdentifierExtension : X509Extension
{
	[Token(Token = "0x40005CB")]
	internal const string oid = "2.5.29.14"; //Field offset: 0x0
	[Token(Token = "0x40005CC")]
	internal const string friendlyName = "Subject Key Identifier"; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005CD")]
	private Byte[] _subjectKeyIdentifier; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005CE")]
	private string _ski; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005CF")]
	private AsnDecodeStatus _status; //Field offset: 0x38

	[Token(Token = "0x1700017C")]
	public string SubjectKeyIdentifier
	{
		[Address(RVA = "0x265B720", Offset = "0x265AB20", Length = "0xE1")]
		[Token(Token = "0x600080B")]
		 get { } //Length: 225
	}

	[Address(RVA = "0x265B690", Offset = "0x265AA90", Length = "0x8D")]
	[Token(Token = "0x6000805")]
	public X509SubjectKeyIdentifierExtension() { }

	[Address(RVA = "0x265B0F0", Offset = "0x265A4F0", Length = "0xDA")]
	[Token(Token = "0x6000806")]
	public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	[Address(RVA = "0x265B1D0", Offset = "0x265A5D0", Length = "0x1E8")]
	[Token(Token = "0x6000807")]
	public X509SubjectKeyIdentifierExtension(Byte[] subjectKeyIdentifier, bool critical) { }

	[Address(RVA = "0x265B3C0", Offset = "0x265A7C0", Length = "0x2C5")]
	[Token(Token = "0x6000808")]
	public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical) { }

	[Address(RVA = "0x265B0D0", Offset = "0x265A4D0", Length = "0x1E")]
	[Token(Token = "0x6000809")]
	public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical) { }

	[Address(RVA = "0x265ACB0", Offset = "0x265A0B0", Length = "0x41F")]
	[Token(Token = "0x600080A")]
	public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	[Address(RVA = "0x265A480", Offset = "0x2659880", Length = "0x1DE")]
	[Token(Token = "0x600080C")]
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	[Address(RVA = "0x265A660", Offset = "0x2659A60", Length = "0x13A")]
	[Token(Token = "0x6000810")]
	internal AsnDecodeStatus Decode(Byte[] extension) { }

	[Address(RVA = "0x265A7A0", Offset = "0x2659BA0", Length = "0x77")]
	[Token(Token = "0x6000811")]
	internal Byte[] Encode() { }

	[Address(RVA = "0x265A8D0", Offset = "0x2659CD0", Length = "0x185")]
	[Token(Token = "0x600080F")]
	internal static Byte[] FromHex(string hex) { }

	[Address(RVA = "0x265A820", Offset = "0x2659C20", Length = "0x2A")]
	[Token(Token = "0x600080D")]
	internal static byte FromHexChar(char c) { }

	[Address(RVA = "0x265A850", Offset = "0x2659C50", Length = "0x7A")]
	[Token(Token = "0x600080E")]
	internal static byte FromHexChars(char c1, char c2) { }

	[Address(RVA = "0x265B720", Offset = "0x265AB20", Length = "0xE1")]
	[Token(Token = "0x600080B")]
	public string get_SubjectKeyIdentifier() { }

	[Address(RVA = "0x265AA60", Offset = "0x2659E60", Length = "0x246")]
	[Token(Token = "0x6000812")]
	internal virtual string ToString(bool multiLine) { }

}

