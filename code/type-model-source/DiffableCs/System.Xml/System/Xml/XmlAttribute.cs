namespace System.Xml;

[Token(Token = "0x200008D")]
public class XmlAttribute : XmlNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000422")]
	private XmlName name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000423")]
	private XmlLinkedNode lastChild; //Field offset: 0x20

	[Token(Token = "0x170001C6")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x2513290", Offset = "0x2512690", Length = "0x74")]
		[Token(Token = "0x6000772")]
		 get { } //Length: 116
	}

	[Token(Token = "0x170001C0")]
	public virtual string InnerText
	{
		[Address(RVA = "0x25134E0", Offset = "0x25128E0", Length = "0x6D")]
		[Token(Token = "0x6000760")]
		 set { } //Length: 109
	}

	[Token(Token = "0x170001C5")]
	public virtual string InnerXml
	{
		[Address(RVA = "0x2513550", Offset = "0x2512950", Length = "0x97")]
		[Token(Token = "0x600076F")]
		 set { } //Length: 151
	}

	[Token(Token = "0x170001C1")]
	internal virtual bool IsContainer
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000763")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170001C2")]
	internal virtual XmlLinkedNode LastNode
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000765")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000766")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001B9")]
	public virtual string LocalName
	{
		[Address(RVA = "0x21B18A0", Offset = "0x21B0CA0", Length = "0x1B")]
		[Token(Token = "0x6000757")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170001B5")]
	internal int LocalNameHash
	{
		[Address(RVA = "0x2513310", Offset = "0x2512710", Length = "0x1A")]
		[Token(Token = "0x6000750")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x170001B8")]
	public virtual string Name
	{
		[Address(RVA = "0x2513330", Offset = "0x2512730", Length = "0x1D")]
		[Token(Token = "0x6000756")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170001BA")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x21B18C0", Offset = "0x21B0CC0", Length = "0x1B")]
		[Token(Token = "0x6000758")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170001BC")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600075B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001BD")]
	public virtual XmlDocument OwnerDocument
	{
		[Address(RVA = "0x21B1A40", Offset = "0x21B0E40", Length = "0x1B")]
		[Token(Token = "0x600075C")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170001C4")]
	public override XmlElement OwnerElement
	{
		[Address(RVA = "0x2513350", Offset = "0x2512750", Length = "0x72")]
		[Token(Token = "0x600076E")]
		 get { } //Length: 114
	}

	[Token(Token = "0x170001B7")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000755")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001BB")]
	public virtual string Prefix
	{
		[Address(RVA = "0x21B18E0", Offset = "0x21B0CE0", Length = "0x1B")]
		[Token(Token = "0x6000759")]
		 get { } //Length: 27
		[Address(RVA = "0x25135F0", Offset = "0x25129F0", Length = "0xCB")]
		[Token(Token = "0x600075A")]
		 set { } //Length: 203
	}

	[Token(Token = "0x170001BF")]
	public virtual IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600075F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C3")]
	public override bool Specified
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000768")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001BE")]
	public virtual string Value
	{
		[Address(RVA = "0x25133D0", Offset = "0x25127D0", Length = "0x14")]
		[Token(Token = "0x600075D")]
		 get { } //Length: 20
		[Address(RVA = "0x25136C0", Offset = "0x2512AC0", Length = "0x14")]
		[Token(Token = "0x600075E")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170001C8")]
	internal virtual string XmlLang
	{
		[Address(RVA = "0x25133F0", Offset = "0x25127F0", Length = "0x74")]
		[Token(Token = "0x6000775")]
		internal get { } //Length: 116
	}

	[Token(Token = "0x170001B6")]
	internal XmlName XmlName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000752")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000753")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001C7")]
	internal virtual XmlSpace XmlSpace
	{
		[Address(RVA = "0x2513470", Offset = "0x2512870", Length = "0x63")]
		[Token(Token = "0x6000774")]
		internal get { } //Length: 99
	}

	[Address(RVA = "0x2513170", Offset = "0x2512570", Length = "0x11F")]
	[Token(Token = "0x600074F")]
	internal XmlAttribute(XmlName name, XmlDocument doc) { }

	[Address(RVA = "0x2513120", Offset = "0x2512520", Length = "0x44")]
	[Token(Token = "0x6000751")]
	protected private XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	[Address(RVA = "0x2512930", Offset = "0x2511D30", Length = "0x80")]
	[Token(Token = "0x600076D")]
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	[Address(RVA = "0x2512760", Offset = "0x2511B60", Length = "0x1C7")]
	[Token(Token = "0x6000764")]
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[Address(RVA = "0x25129B0", Offset = "0x2511DB0", Length = "0xEC")]
	[Token(Token = "0x6000754")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x2513290", Offset = "0x2512690", Length = "0x74")]
	[Token(Token = "0x6000772")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000763")]
	internal virtual bool get_IsContainer() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000765")]
	internal virtual XmlLinkedNode get_LastNode() { }

	[Address(RVA = "0x21B18A0", Offset = "0x21B0CA0", Length = "0x1B")]
	[Token(Token = "0x6000757")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2513310", Offset = "0x2512710", Length = "0x1A")]
	[Token(Token = "0x6000750")]
	internal int get_LocalNameHash() { }

	[Address(RVA = "0x2513330", Offset = "0x2512730", Length = "0x1D")]
	[Token(Token = "0x6000756")]
	public virtual string get_Name() { }

	[Address(RVA = "0x21B18C0", Offset = "0x21B0CC0", Length = "0x1B")]
	[Token(Token = "0x6000758")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x600075B")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x21B1A40", Offset = "0x21B0E40", Length = "0x1B")]
	[Token(Token = "0x600075C")]
	public virtual XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0x2513350", Offset = "0x2512750", Length = "0x72")]
	[Token(Token = "0x600076E")]
	public override XmlElement get_OwnerElement() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000755")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x21B18E0", Offset = "0x21B0CE0", Length = "0x1B")]
	[Token(Token = "0x6000759")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600075F")]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000768")]
	public override bool get_Specified() { }

	[Address(RVA = "0x25133D0", Offset = "0x25127D0", Length = "0x14")]
	[Token(Token = "0x600075D")]
	public virtual string get_Value() { }

	[Address(RVA = "0x25133F0", Offset = "0x25127F0", Length = "0x74")]
	[Token(Token = "0x6000775")]
	internal virtual string get_XmlLang() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000752")]
	internal XmlName get_XmlName() { }

	[Address(RVA = "0x2513470", Offset = "0x2512870", Length = "0x63")]
	[Token(Token = "0x6000774")]
	internal virtual XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x2512AA0", Offset = "0x2511EA0", Length = "0x98")]
	[Token(Token = "0x600076A")]
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x2512B40", Offset = "0x2511F40", Length = "0x98")]
	[Token(Token = "0x6000769")]
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x2512BE0", Offset = "0x2511FE0", Length = "0xF")]
	[Token(Token = "0x6000767")]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x2512BF0", Offset = "0x2511FF0", Length = "0x198")]
	[Token(Token = "0x6000761")]
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	[Address(RVA = "0x2512D90", Offset = "0x2512190", Length = "0x80")]
	[Token(Token = "0x600076C")]
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	[Address(RVA = "0x2512E10", Offset = "0x2512210", Length = "0x80")]
	[Token(Token = "0x600076B")]
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	[Address(RVA = "0x2512E90", Offset = "0x2512290", Length = "0x12D")]
	[Token(Token = "0x6000762")]
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	[Address(RVA = "0x25134E0", Offset = "0x25128E0", Length = "0x6D")]
	[Token(Token = "0x6000760")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x2513550", Offset = "0x2512950", Length = "0x97")]
	[Token(Token = "0x600076F")]
	public virtual void set_InnerXml(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000766")]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x25135F0", Offset = "0x25129F0", Length = "0xCB")]
	[Token(Token = "0x600075A")]
	public virtual void set_Prefix(string value) { }

	[Address(RVA = "0x25136C0", Offset = "0x2512AC0", Length = "0x14")]
	[Token(Token = "0x600075E")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000753")]
	internal void set_XmlName(XmlName value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000773")]
	internal virtual void SetParent(XmlNode node) { }

	[Address(RVA = "0x2512FC0", Offset = "0x25123C0", Length = "0x72")]
	[Token(Token = "0x6000771")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x2513040", Offset = "0x2512440", Length = "0xD4")]
	[Token(Token = "0x6000770")]
	public virtual void WriteTo(XmlWriter w) { }

}

