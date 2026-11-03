namespace System.Xml;

[Token(Token = "0x2000096")]
public class XmlDocumentFragment : XmlNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000458")]
	private XmlLinkedNode lastChild; //Field offset: 0x18

	[Token(Token = "0x17000206")]
	public virtual string InnerXml
	{
		[Address(RVA = "0x2514E30", Offset = "0x2514230", Length = "0x97")]
		[Token(Token = "0x6000824")]
		 set { } //Length: 151
	}

	[Token(Token = "0x17000207")]
	internal virtual bool IsContainer
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000826")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000208")]
	internal virtual XmlLinkedNode LastNode
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000827")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000828")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000202")]
	public virtual string LocalName
	{
		[Address(RVA = "0x2514D90", Offset = "0x2514190", Length = "0x2D")]
		[Token(Token = "0x6000820")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000201")]
	public virtual string Name
	{
		[Address(RVA = "0x2514D90", Offset = "0x2514190", Length = "0x2D")]
		[Token(Token = "0x600081F")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000203")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x20282A0", Offset = "0x20276A0", Length = "0x6")]
		[Token(Token = "0x6000821")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000205")]
	public virtual XmlDocument OwnerDocument
	{
		[Address(RVA = "0x2514DC0", Offset = "0x25141C0", Length = "0x6B")]
		[Token(Token = "0x6000823")]
		 get { } //Length: 107
	}

	[Token(Token = "0x17000204")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000822")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2514D00", Offset = "0x2514100", Length = "0x8B")]
	[Token(Token = "0x600081E")]
	protected private XmlDocumentFragment(XmlDocument ownerDocument) { }

	[Address(RVA = "0x2514870", Offset = "0x2513C70", Length = "0x7E")]
	[Token(Token = "0x600082A")]
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x25148F0", Offset = "0x2513CF0", Length = "0x71")]
	[Token(Token = "0x600082B")]
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x2514970", Offset = "0x2513D70", Length = "0x9C")]
	[Token(Token = "0x6000825")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000826")]
	internal virtual bool get_IsContainer() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000827")]
	internal virtual XmlLinkedNode get_LastNode() { }

	[Address(RVA = "0x2514D90", Offset = "0x2514190", Length = "0x2D")]
	[Token(Token = "0x6000820")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2514D90", Offset = "0x2514190", Length = "0x2D")]
	[Token(Token = "0x600081F")]
	public virtual string get_Name() { }

	[Address(RVA = "0x20282A0", Offset = "0x20276A0", Length = "0x6")]
	[Token(Token = "0x6000821")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2514DC0", Offset = "0x25141C0", Length = "0x6B")]
	[Token(Token = "0x6000823")]
	public virtual XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000822")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x2514A10", Offset = "0x2513E10", Length = "0x70")]
	[Token(Token = "0x6000829")]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x2514E30", Offset = "0x2514230", Length = "0x97")]
	[Token(Token = "0x6000824")]
	public virtual void set_InnerXml(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000828")]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x2514AD0", Offset = "0x2513ED0", Length = "0x20F")]
	[Token(Token = "0x600082D")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x2514CE0", Offset = "0x25140E0", Length = "0x14")]
	[Token(Token = "0x600082C")]
	public virtual void WriteTo(XmlWriter w) { }

}

