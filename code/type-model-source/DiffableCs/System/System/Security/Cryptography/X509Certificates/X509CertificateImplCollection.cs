namespace System.Security.Cryptography.X509Certificates;

[DefaultMember("Item")]
[Token(Token = "0x2000134")]
internal class X509CertificateImplCollection : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000598")]
	private List<X509CertificateImpl> list; //Field offset: 0x10

	[Token(Token = "0x1700014F")]
	public int Count
	{
		[Address(RVA = "0x2651800", Offset = "0x2650C00", Length = "0x3C")]
		[Token(Token = "0x6000769")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000150")]
	public X509CertificateImpl Item
	{
		[Address(RVA = "0x2651840", Offset = "0x2650C40", Length = "0x51")]
		[Token(Token = "0x600076A")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x2651560", Offset = "0x2650960", Length = "0x77")]
	[Token(Token = "0x6000767")]
	public X509CertificateImplCollection() { }

	[Address(RVA = "0x26515E0", Offset = "0x26509E0", Length = "0x21B")]
	[Token(Token = "0x6000768")]
	private X509CertificateImplCollection(X509CertificateImplCollection other) { }

	[Address(RVA = "0x2651240", Offset = "0x2650640", Length = "0xE3")]
	[Token(Token = "0x600076B")]
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	[Address(RVA = "0x2651330", Offset = "0x2650730", Length = "0x54")]
	[Token(Token = "0x600076C")]
	public X509CertificateImplCollection Clone() { }

	[Address(RVA = "0x26514F0", Offset = "0x26508F0", Length = "0x61")]
	[Token(Token = "0x600076D")]
	public override void Dispose() { }

	[Address(RVA = "0x2651390", Offset = "0x2650790", Length = "0x154")]
	[Token(Token = "0x600076E")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x600076F")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2651800", Offset = "0x2650C00", Length = "0x3C")]
	[Token(Token = "0x6000769")]
	public int get_Count() { }

	[Address(RVA = "0x2651840", Offset = "0x2650C40", Length = "0x51")]
	[Token(Token = "0x600076A")]
	public X509CertificateImpl get_Item(int index) { }

}

