namespace System.Xml;

[Token(Token = "0x2000098")]
public class XmlElement : XmlLinkedNode
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000461")]
	private XmlName name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000462")]
	private XmlAttributeCollection attributes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000463")]
	private XmlLinkedNode lastChild; //Field offset: 0x30

	[Token(Token = "0x1700021F")]
	public virtual XmlAttributeCollection Attributes
	{
		[Address(RVA = "0x251B850", Offset = "0x251AC50", Length = "0x124")]
		[Token(Token = "0x6000852")]
		 get { } //Length: 292
	}

	[Token(Token = "0x17000220")]
	public override bool HasAttributes
	{
		[Address(RVA = "0x251B980", Offset = "0x251AD80", Length = "0x33")]
		[Token(Token = "0x6000853")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000223")]
	public virtual string InnerText
	{
		[Address(RVA = "0x251B9C0", Offset = "0x251ADC0", Length = "0x7")]
		[Token(Token = "0x6000866")]
		 get { } //Length: 7
		[Address(RVA = "0x251BAD0", Offset = "0x251AED0", Length = "0xE8")]
		[Token(Token = "0x6000867")]
		 set { } //Length: 232
	}

	[Token(Token = "0x17000222")]
	public virtual string InnerXml
	{
		[Address(RVA = "0x251BBC0", Offset = "0x251AFC0", Length = "0x1E3")]
		[Token(Token = "0x6000865")]
		 set { } //Length: 483
	}

	[Token(Token = "0x1700021C")]
	internal virtual bool IsContainer
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600084B")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700021D")]
	public bool IsEmpty
	{
		[Address(RVA = "0x251B9D0", Offset = "0x251ADD0", Length = "0x8")]
		[Token(Token = "0x600084D")]
		 get { } //Length: 8
		[Address(RVA = "0x251BDB0", Offset = "0x251B1B0", Length = "0x55")]
		[Token(Token = "0x600084E")]
		 set { } //Length: 85
	}

	[Token(Token = "0x1700021E")]
	internal virtual XmlLinkedNode LastNode
	{
		[Address(RVA = "0x251B9E0", Offset = "0x251ADE0", Length = "0xE")]
		[Token(Token = "0x600084F")]
		internal get { } //Length: 14
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000850")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000216")]
	public virtual string LocalName
	{
		[Address(RVA = "0x251B9F0", Offset = "0x251ADF0", Length = "0x1B")]
		[Token(Token = "0x6000844")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000215")]
	public virtual string Name
	{
		[Address(RVA = "0x251BA10", Offset = "0x251AE10", Length = "0x1D")]
		[Token(Token = "0x6000843")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000217")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x251BA30", Offset = "0x251AE30", Length = "0x1B")]
		[Token(Token = "0x6000845")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000224")]
	public virtual XmlNode NextSibling
	{
		[Address(RVA = "0x251BA50", Offset = "0x251AE50", Length = "0x3E")]
		[Token(Token = "0x6000868")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000219")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000848")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700021B")]
	public virtual XmlDocument OwnerDocument
	{
		[Address(RVA = "0x251BA90", Offset = "0x251AE90", Length = "0x1B")]
		[Token(Token = "0x600084A")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700021A")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000849")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000218")]
	public virtual string Prefix
	{
		[Address(RVA = "0x251BAB0", Offset = "0x251AEB0", Length = "0x1B")]
		[Token(Token = "0x6000846")]
		 get { } //Length: 27
		[Address(RVA = "0x251BE10", Offset = "0x251B210", Length = "0xD1")]
		[Token(Token = "0x6000847")]
		 set { } //Length: 209
	}

	[Token(Token = "0x17000221")]
	public virtual IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000864")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000214")]
	internal XmlName XmlName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000840")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000841")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x251B6F0", Offset = "0x251AAF0", Length = "0x15E")]
	[Token(Token = "0x600083E")]
	internal XmlElement(XmlName name, bool empty, XmlDocument doc) { }

	[Address(RVA = "0x251B680", Offset = "0x251AA80", Length = "0x60")]
	[Token(Token = "0x600083F")]
	protected private XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	[Address(RVA = "0x251A0A0", Offset = "0x25194A0", Length = "0x1D1")]
	[Token(Token = "0x600084C")]
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[Address(RVA = "0x251A280", Offset = "0x2519680", Length = "0x4EC")]
	[Token(Token = "0x6000842")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x251B850", Offset = "0x251AC50", Length = "0x124")]
	[Token(Token = "0x6000852")]
	public virtual XmlAttributeCollection get_Attributes() { }

	[Address(RVA = "0x251B980", Offset = "0x251AD80", Length = "0x33")]
	[Token(Token = "0x6000853")]
	public override bool get_HasAttributes() { }

	[Address(RVA = "0x251B9C0", Offset = "0x251ADC0", Length = "0x7")]
	[Token(Token = "0x6000866")]
	public virtual string get_InnerText() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600084B")]
	internal virtual bool get_IsContainer() { }

	[Address(RVA = "0x251B9D0", Offset = "0x251ADD0", Length = "0x8")]
	[Token(Token = "0x600084D")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x251B9E0", Offset = "0x251ADE0", Length = "0xE")]
	[Token(Token = "0x600084F")]
	internal virtual XmlLinkedNode get_LastNode() { }

	[Address(RVA = "0x251B9F0", Offset = "0x251ADF0", Length = "0x1B")]
	[Token(Token = "0x6000844")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x251BA10", Offset = "0x251AE10", Length = "0x1D")]
	[Token(Token = "0x6000843")]
	public virtual string get_Name() { }

	[Address(RVA = "0x251BA30", Offset = "0x251AE30", Length = "0x1B")]
	[Token(Token = "0x6000845")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x251BA50", Offset = "0x251AE50", Length = "0x3E")]
	[Token(Token = "0x6000868")]
	public virtual XmlNode get_NextSibling() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000848")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x251BA90", Offset = "0x251AE90", Length = "0x1B")]
	[Token(Token = "0x600084A")]
	public virtual XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000849")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x251BAB0", Offset = "0x251AEB0", Length = "0x1B")]
	[Token(Token = "0x6000846")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000864")]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000840")]
	internal XmlName get_XmlName() { }

	[Address(RVA = "0x251AAD0", Offset = "0x2519ED0", Length = "0x4D")]
	[Token(Token = "0x6000858")]
	public override string GetAttribute(string localName, string namespaceURI) { }

	[Address(RVA = "0x251AA80", Offset = "0x2519E80", Length = "0x4D")]
	[Token(Token = "0x6000854")]
	public override string GetAttribute(string name) { }

	[Address(RVA = "0x251A8E0", Offset = "0x2519CE0", Length = "0x19D")]
	[Token(Token = "0x600085A")]
	public override XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	[Address(RVA = "0x251A770", Offset = "0x2519B70", Length = "0x16B")]
	[Token(Token = "0x6000856")]
	public override XmlAttribute GetAttributeNode(string name) { }

	[Address(RVA = "0x251AB20", Offset = "0x2519F20", Length = "0x22")]
	[Token(Token = "0x600085C")]
	public override bool HasAttribute(string name) { }

	[Address(RVA = "0x251AB50", Offset = "0x2519F50", Length = "0x18")]
	[Token(Token = "0x6000851")]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x251ACD0", Offset = "0x251A0D0", Length = "0x2C")]
	[Token(Token = "0x6000862")]
	public virtual void RemoveAll() { }

	[Address(RVA = "0x251ABB0", Offset = "0x2519FB0", Length = "0x109")]
	[Token(Token = "0x6000861")]
	public override void RemoveAllAttributes() { }

	[Address(RVA = "0x251ACC0", Offset = "0x251A0C0", Length = "0x7")]
	[Token(Token = "0x6000863")]
	internal void RemoveAllChildren() { }

	[Address(RVA = "0x251BAD0", Offset = "0x251AED0", Length = "0xE8")]
	[Token(Token = "0x6000867")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x251BBC0", Offset = "0x251AFC0", Length = "0x1E3")]
	[Token(Token = "0x6000865")]
	public virtual void set_InnerXml(string value) { }

	[Address(RVA = "0x251BDB0", Offset = "0x251B1B0", Length = "0x55")]
	[Token(Token = "0x600084E")]
	public void set_IsEmpty(bool value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000850")]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x251BE10", Offset = "0x251B210", Length = "0xD1")]
	[Token(Token = "0x6000847")]
	public virtual void set_Prefix(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000841")]
	internal void set_XmlName(XmlName value) { }

	[Address(RVA = "0x251B0E0", Offset = "0x251A4E0", Length = "0x112")]
	[Token(Token = "0x6000859")]
	public override string SetAttribute(string localName, string namespaceURI, string value) { }

	[Address(RVA = "0x251AF00", Offset = "0x251A300", Length = "0x1DE")]
	[Token(Token = "0x6000855")]
	public override void SetAttribute(string name, string value) { }

	[Address(RVA = "0x251ADD0", Offset = "0x251A1D0", Length = "0x12E")]
	[Token(Token = "0x6000857")]
	public override XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	[Address(RVA = "0x251AD00", Offset = "0x251A100", Length = "0xCF")]
	[Token(Token = "0x600085B")]
	public override XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000869")]
	internal virtual void SetParent(XmlNode node) { }

	[Address(RVA = "0x2512FC0", Offset = "0x25123C0", Length = "0x72")]
	[Token(Token = "0x6000860")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x251B200", Offset = "0x251A600", Length = "0x224")]
	[Token(Token = "0x600085E")]
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	[Address(RVA = "0x251B430", Offset = "0x251A830", Length = "0x138")]
	[Token(Token = "0x600085F")]
	private void WriteStartElement(XmlWriter w) { }

	[Address(RVA = "0x251B570", Offset = "0x251A970", Length = "0x107")]
	[Token(Token = "0x600085D")]
	public virtual void WriteTo(XmlWriter w) { }

}

