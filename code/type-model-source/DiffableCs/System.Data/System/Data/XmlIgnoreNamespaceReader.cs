namespace System.Data;

[Token(Token = "0x2000098")]
internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002F4")]
	private List<String> _namespacesToIgnore; //Field offset: 0x30

	[Address(RVA = "0x236D5E0", Offset = "0x236C9E0", Length = "0x8E")]
	[Token(Token = "0x60007CA")]
	internal XmlIgnoreNamespaceReader(XmlDocument xdoc, String[] namespacesToIgnore) { }

	[Address(RVA = "0x236D3A0", Offset = "0x236C7A0", Length = "0x11A")]
	[Token(Token = "0x60007CB")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x236D4C0", Offset = "0x236C8C0", Length = "0x117")]
	[Token(Token = "0x60007CC")]
	public virtual bool MoveToNextAttribute() { }

}

