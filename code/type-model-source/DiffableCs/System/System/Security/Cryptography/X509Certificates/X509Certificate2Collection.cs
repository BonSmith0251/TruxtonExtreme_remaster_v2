namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
[Token(Token = "0x200012D")]
public class X509Certificate2Collection : X509CertificateCollection
{
	[Token(Token = "0x400058F")]
	private static String[] newline_split; //Field offset: 0x0

	[Token(Token = "0x1700012D")]
	public X509Certificate2 Item
	{
		[Address(RVA = "0x264C680", Offset = "0x264BA80", Length = "0x15E")]
		[Token(Token = "0x6000717")]
		 get { } //Length: 350
	}

	[Address(RVA = "0x264C540", Offset = "0x264B940", Length = "0x9B")]
	[Token(Token = "0x600071E")]
	private static X509Certificate2Collection() { }

	[Address(RVA = "0x1E3EFC0", Offset = "0x1E3E3C0", Length = "0x7")]
	[Token(Token = "0x6000715")]
	public X509Certificate2Collection() { }

	[Address(RVA = "0x264C5E0", Offset = "0x264B9E0", Length = "0x94")]
	[Token(Token = "0x6000716")]
	public X509Certificate2Collection(X509Certificate2Collection certificates) { }

	[Address(RVA = "0x264B110", Offset = "0x264A510", Length = "0x81")]
	[Token(Token = "0x6000718")]
	public int Add(X509Certificate2 certificate) { }

	[Address(RVA = "0x264B080", Offset = "0x264A480", Length = "0x81")]
	[MonoTODO("Method isn't transactional (like documented)")]
	[Token(Token = "0x6000719")]
	public void AddRange(X509Certificate2Collection certificates) { }

	[Address(RVA = "0x264B1A0", Offset = "0x264A5A0", Length = "0x21C")]
	[Token(Token = "0x600071A")]
	public bool Contains(X509Certificate2 certificate) { }

	[Address(RVA = "0x264B3C0", Offset = "0x264A7C0", Length = "0xF84")]
	[MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
	[Token(Token = "0x600071C")]
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	[Address(RVA = "0x264C680", Offset = "0x264BA80", Length = "0x15E")]
	[Token(Token = "0x6000717")]
	public X509Certificate2 get_Item(int index) { }

	[Address(RVA = "0x264C3C0", Offset = "0x264B7C0", Length = "0x97")]
	[Token(Token = "0x600071D")]
	public X509Certificate2Enumerator GetEnumerator() { }

	[Address(RVA = "0x264C460", Offset = "0x264B860", Length = "0xD1")]
	[Token(Token = "0x600071B")]
	private string GetKeyIdentifier(X509Certificate2 x) { }

}

