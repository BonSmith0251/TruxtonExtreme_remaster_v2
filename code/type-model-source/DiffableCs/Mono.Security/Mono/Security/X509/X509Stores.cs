namespace Mono.Security.X509;

[Token(Token = "0x200001A")]
public class X509Stores
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007E")]
	private string _storePath; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007F")]
	private bool _newFormat; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000080")]
	private X509Store _trusted; //Field offset: 0x20

	[Token(Token = "0x1700004B")]
	public X509Store TrustedRoot
	{
		[Address(RVA = "0x1E45CA0", Offset = "0x1E450A0", Length = "0xE3")]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 227
	}

	[Address(RVA = "0x1BC27C0", Offset = "0x1BC1BC0", Length = "0x44")]
	[Token(Token = "0x60000E5")]
	internal X509Stores(string path, bool newFormat) { }

	[Address(RVA = "0x1E45CA0", Offset = "0x1E450A0", Length = "0xE3")]
	[Token(Token = "0x60000E6")]
	public X509Store get_TrustedRoot() { }

	[Address(RVA = "0x1E45B70", Offset = "0x1E44F70", Length = "0x123")]
	[Token(Token = "0x60000E7")]
	public X509Store Open(string storeName, bool create) { }

}

