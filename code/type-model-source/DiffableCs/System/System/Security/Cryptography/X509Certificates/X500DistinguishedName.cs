namespace System.Security.Cryptography.X509Certificates;

[MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
[Token(Token = "0x200012A")]
public sealed class X500DistinguishedName : AsnEncodedData
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400057F")]
	private string name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000580")]
	private Byte[] canonEncoding; //Field offset: 0x28

	[Token(Token = "0x1700011B")]
	public string Name
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60006E9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x264A320", Offset = "0x2649720", Length = "0x10E")]
	[Token(Token = "0x60006E6")]
	public X500DistinguishedName(Byte[] encodedDistinguishedName) { }

	[Address(RVA = "0x264A070", Offset = "0x2649470", Length = "0xE")]
	[Token(Token = "0x60006E7")]
	public X500DistinguishedName(string distinguishedName) { }

	[Address(RVA = "0x264A080", Offset = "0x2649480", Length = "0x29D")]
	[Token(Token = "0x60006E8")]
	public X500DistinguishedName(string distinguishedName, X500DistinguishedNameFlags flag) { }

	[Address(RVA = "0x2649910", Offset = "0x2648D10", Length = "0x210")]
	[Token(Token = "0x60006EF")]
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

	[Address(RVA = "0x2649B30", Offset = "0x2648F30", Length = "0x1CB")]
	[Token(Token = "0x60006EE")]
	private static string Canonize(string s) { }

	[Address(RVA = "0x2649DE0", Offset = "0x26491E0", Length = "0x1AA")]
	[Token(Token = "0x60006EA")]
	public string Decode(X500DistinguishedNameFlags flag) { }

	[Address(RVA = "0x2649D00", Offset = "0x2649100", Length = "0xDE")]
	[Token(Token = "0x60006ED")]
	private void DecodeRawData() { }

	[Address(RVA = "0x2649F90", Offset = "0x2649390", Length = "0x63")]
	[Token(Token = "0x60006EB")]
	public virtual string Format(bool multiLine) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60006E9")]
	public string get_Name() { }

	[Address(RVA = "0x264A000", Offset = "0x2649400", Length = "0x65")]
	[Token(Token = "0x60006EC")]
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

}

