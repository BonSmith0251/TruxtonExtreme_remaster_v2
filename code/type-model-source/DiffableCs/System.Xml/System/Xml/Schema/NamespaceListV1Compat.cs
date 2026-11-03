namespace System.Xml.Schema;

[Token(Token = "0x20001CD")]
internal class NamespaceListV1Compat : NamespaceList
{

	[Address(RVA = "0x2426400", Offset = "0x2425800", Length = "0x8")]
	[Token(Token = "0x60011BF")]
	public NamespaceListV1Compat(string namespaces, string targetNamespace) { }

	[Address(RVA = "0x2426360", Offset = "0x2425760", Length = "0x9A")]
	[Token(Token = "0x60011C0")]
	public virtual bool Allows(string ns) { }

}

