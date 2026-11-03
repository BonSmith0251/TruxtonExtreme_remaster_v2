namespace Mono.Security.X509;

[DefaultMember("Item")]
[Token(Token = "0x2000017")]
public sealed class X509ExtensionCollection : CollectionBase, IEnumerable
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000072")]
	private bool readOnly; //Field offset: 0x18

	[Token(Token = "0x17000041")]
	public X509Extension Item
	{
		[Address(RVA = "0x1E43AC0", Offset = "0x1E42EC0", Length = "0x1FD")]
		[Token(Token = "0x60000D4")]
		 get { } //Length: 509
	}

	[Address(RVA = "0x1E3EFC0", Offset = "0x1E3E3C0", Length = "0x7")]
	[Token(Token = "0x60000D0")]
	public X509ExtensionCollection() { }

	[Address(RVA = "0x1E43970", Offset = "0x1E42D70", Length = "0x144")]
	[Token(Token = "0x60000D1")]
	public X509ExtensionCollection(ASN1 asn1) { }

	[Address(RVA = "0x1E43AC0", Offset = "0x1E42EC0", Length = "0x1FD")]
	[Token(Token = "0x60000D4")]
	public X509Extension get_Item(string oid) { }

	[Address(RVA = "0x1E43800", Offset = "0x1E42C00", Length = "0x167")]
	[Token(Token = "0x60000D2")]
	public int IndexOf(string oid) { }

	[Address(RVA = "0x1E3EF90", Offset = "0x1E3E390", Length = "0x2A")]
	[Token(Token = "0x60000D3")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

