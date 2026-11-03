namespace System.Xml;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
[Token(Token = "0x20000A4")]
public abstract class XmlNode : ICloneable, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000487")]
	internal XmlNode parentNode; //Field offset: 0x10

	[Token(Token = "0x1700025A")]
	public override XmlAttributeCollection Attributes
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008EE")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000268")]
	public override string BaseURI
	{
		[Address(RVA = "0x2540950", Offset = "0x253FD50", Length = "0x101")]
		[Token(Token = "0x6000910")]
		 get { } //Length: 257
	}

	[Token(Token = "0x17000257")]
	public override XmlNodeList ChildNodes
	{
		[Address(RVA = "0x2540A60", Offset = "0x253FE60", Length = "0x54")]
		[Token(Token = "0x60008EB")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000269")]
	internal XmlDocument Document
	{
		[Address(RVA = "0x2540AC0", Offset = "0x253FEC0", Length = "0x98")]
		[Token(Token = "0x6000914")]
		internal get { } //Length: 152
	}

	[Token(Token = "0x1700025C")]
	public override XmlNode FirstChild
	{
		[Address(RVA = "0x2540B60", Offset = "0x253FF60", Length = "0x2A")]
		[Token(Token = "0x60008F0")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000260")]
	public override bool HasChildNodes
	{
		[Address(RVA = "0x2540B90", Offset = "0x253FF90", Length = "0x22")]
		[Token(Token = "0x60008FF")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000265")]
	public override string InnerText
	{
		[Address(RVA = "0x2540BC0", Offset = "0x253FFC0", Length = "0x11C")]
		[Token(Token = "0x600090C")]
		 get { } //Length: 284
		[Address(RVA = "0x2541240", Offset = "0x2540640", Length = "0x109")]
		[Token(Token = "0x600090D")]
		 set { } //Length: 265
	}

	[Token(Token = "0x17000266")]
	public override string InnerXml
	{
		[Address(RVA = "0x2541350", Offset = "0x2540750", Length = "0x5F")]
		[Token(Token = "0x600090E")]
		 set { } //Length: 95
	}

	[Token(Token = "0x1700025E")]
	internal override bool IsContainer
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60008F2")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000264")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x2540CE0", Offset = "0x25400E0", Length = "0xDB")]
		[Token(Token = "0x6000906")]
		 get { } //Length: 219
	}

	[Token(Token = "0x1700026C")]
	internal override bool IsText
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000920")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700025D")]
	public override XmlNode LastChild
	{
		[Address(RVA = "0x1E9E660", Offset = "0x1E9DA60", Length = "0x14")]
		[Token(Token = "0x60008F1")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700025F")]
	internal override XmlLinkedNode LastNode
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008F3")]
		internal get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60008F4")]
		internal set { } //Length: 3
	}

	[Token(Token = "0x17000263")]
	public abstract string LocalName
	{
		[Token(Token = "0x6000905")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000253")]
	public abstract string Name
	{
		[Token(Token = "0x60008E6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000261")]
	public override string NamespaceURI
	{
		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x6000902")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000259")]
	public override XmlNode NextSibling
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008ED")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000255")]
	public abstract XmlNodeType NodeType
	{
		[Token(Token = "0x60008E9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700025B")]
	public override XmlDocument OwnerDocument
	{
		[Address(RVA = "0x2540DC0", Offset = "0x25401C0", Length = "0xBE")]
		[Token(Token = "0x60008EF")]
		 get { } //Length: 190
	}

	[Token(Token = "0x17000256")]
	public override XmlNode ParentNode
	{
		[Address(RVA = "0x2540E80", Offset = "0x2540280", Length = "0xF8")]
		[Token(Token = "0x60008EA")]
		 get { } //Length: 248
	}

	[Token(Token = "0x17000262")]
	public override string Prefix
	{
		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x6000903")]
		 get { } //Length: 18
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000904")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000258")]
	public override XmlNode PreviousSibling
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008EC")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000267")]
	public override IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x2540F80", Offset = "0x2540380", Length = "0x4F")]
		[Token(Token = "0x600090F")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000254")]
	public override string Value
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60008E7")]
		 get { } //Length: 3
		[Address(RVA = "0x25413B0", Offset = "0x25407B0", Length = "0xD4")]
		[Token(Token = "0x60008E8")]
		 set { } //Length: 212
	}

	[Token(Token = "0x1700026B")]
	internal override string XmlLang
	{
		[Address(RVA = "0x2540FD0", Offset = "0x25403D0", Length = "0xE0")]
		[Token(Token = "0x600091F")]
		internal get { } //Length: 224
	}

	[Token(Token = "0x1700026A")]
	internal override XmlSpace XmlSpace
	{
		[Address(RVA = "0x25410C0", Offset = "0x25404C0", Length = "0x17A")]
		[Token(Token = "0x600091E")]
		internal get { } //Length: 378
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008E4")]
	internal XmlNode() { }

	[Address(RVA = "0x25408C0", Offset = "0x253FCC0", Length = "0x8B")]
	[Token(Token = "0x60008E5")]
	internal XmlNode(XmlDocument doc) { }

	[Address(RVA = "0x253DEB0", Offset = "0x253D2B0", Length = "0x4A")]
	[Token(Token = "0x600091D")]
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	[Address(RVA = "0x253DF00", Offset = "0x253D300", Length = "0x72")]
	[Token(Token = "0x60008F5")]
	internal bool AncestorNode(XmlNode node) { }

	[Address(RVA = "0x253E2B0", Offset = "0x253D6B0", Length = "0x655")]
	[Token(Token = "0x60008FA")]
	public override XmlNode AppendChild(XmlNode newChild) { }

	[Address(RVA = "0x253DF80", Offset = "0x253D380", Length = "0x1F0")]
	[Token(Token = "0x60008FB")]
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[Address(RVA = "0x253E180", Offset = "0x253D580", Length = "0x122")]
	[Token(Token = "0x600090B")]
	private void AppendChildText(StringBuilder builder) { }

	[Address(RVA = "0x253E910", Offset = "0x253DD10", Length = "0x4A")]
	[Token(Token = "0x600091C")]
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60008FE")]
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60008FD")]
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Token(Token = "0x6000900")]
	public abstract XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x253E960", Offset = "0x253DD60", Length = "0xB4")]
	[Token(Token = "0x6000901")]
	internal override void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	[Address(RVA = "0x253EA20", Offset = "0x253DE20", Length = "0x83")]
	[Token(Token = "0x600091A")]
	internal override XmlNode FindChild(XmlNodeType type) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008EE")]
	public override XmlAttributeCollection get_Attributes() { }

	[Address(RVA = "0x2540950", Offset = "0x253FD50", Length = "0x101")]
	[Token(Token = "0x6000910")]
	public override string get_BaseURI() { }

	[Address(RVA = "0x2540A60", Offset = "0x253FE60", Length = "0x54")]
	[Token(Token = "0x60008EB")]
	public override XmlNodeList get_ChildNodes() { }

	[Address(RVA = "0x2540AC0", Offset = "0x253FEC0", Length = "0x98")]
	[Token(Token = "0x6000914")]
	internal XmlDocument get_Document() { }

	[Address(RVA = "0x2540B60", Offset = "0x253FF60", Length = "0x2A")]
	[Token(Token = "0x60008F0")]
	public override XmlNode get_FirstChild() { }

	[Address(RVA = "0x2540B90", Offset = "0x253FF90", Length = "0x22")]
	[Token(Token = "0x60008FF")]
	public override bool get_HasChildNodes() { }

	[Address(RVA = "0x2540BC0", Offset = "0x253FFC0", Length = "0x11C")]
	[Token(Token = "0x600090C")]
	public override string get_InnerText() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60008F2")]
	internal override bool get_IsContainer() { }

	[Address(RVA = "0x2540CE0", Offset = "0x25400E0", Length = "0xDB")]
	[Token(Token = "0x6000906")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000920")]
	internal override bool get_IsText() { }

	[Address(RVA = "0x1E9E660", Offset = "0x1E9DA60", Length = "0x14")]
	[Token(Token = "0x60008F1")]
	public override XmlNode get_LastChild() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008F3")]
	internal override XmlLinkedNode get_LastNode() { }

	[Token(Token = "0x6000905")]
	public abstract string get_LocalName() { }

	[Token(Token = "0x60008E6")]
	public abstract string get_Name() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000902")]
	public override string get_NamespaceURI() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008ED")]
	public override XmlNode get_NextSibling() { }

	[Token(Token = "0x60008E9")]
	public abstract XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2540DC0", Offset = "0x25401C0", Length = "0xBE")]
	[Token(Token = "0x60008EF")]
	public override XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0x2540E80", Offset = "0x2540280", Length = "0xF8")]
	[Token(Token = "0x60008EA")]
	public override XmlNode get_ParentNode() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000903")]
	public override string get_Prefix() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008EC")]
	public override XmlNode get_PreviousSibling() { }

	[Address(RVA = "0x2540F80", Offset = "0x2540380", Length = "0x4F")]
	[Token(Token = "0x600090F")]
	public override IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60008E7")]
	public override string get_Value() { }

	[Address(RVA = "0x2540FD0", Offset = "0x25403D0", Length = "0xE0")]
	[Token(Token = "0x600091F")]
	internal override string get_XmlLang() { }

	[Address(RVA = "0x25410C0", Offset = "0x25404C0", Length = "0x17A")]
	[Token(Token = "0x600091E")]
	internal override XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x253EAB0", Offset = "0x253DEB0", Length = "0x54")]
	[Token(Token = "0x600090A")]
	public IEnumerator GetEnumerator() { }

	[Address(RVA = "0x253EB10", Offset = "0x253DF10", Length = "0x132")]
	[Token(Token = "0x600091B")]
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	[Address(RVA = "0x253F090", Offset = "0x253E490", Length = "0x27")]
	[Token(Token = "0x6000915")]
	public override string GetPrefixOfNamespace(string namespaceURI) { }

	[Address(RVA = "0x253EC50", Offset = "0x253E050", Length = "0x439")]
	[Token(Token = "0x6000916")]
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	[Address(RVA = "0x253F0C0", Offset = "0x253E4C0", Length = "0xCD")]
	[Token(Token = "0x6000907")]
	internal static bool HasReadOnlyParent(XmlNode n) { }

	[Address(RVA = "0x253F190", Offset = "0x253E590", Length = "0x7B1")]
	[Token(Token = "0x60008F7")]
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x253F950", Offset = "0x253ED50", Length = "0x7D7")]
	[Token(Token = "0x60008F6")]
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60008FC")]
	internal override bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x2540130", Offset = "0x253F530", Length = "0x25")]
	[Token(Token = "0x6000921")]
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	[Address(RVA = "0x2540160", Offset = "0x253F560", Length = "0x4A")]
	[Token(Token = "0x60008F9")]
	public override XmlNode PrependChild(XmlNode newChild) { }

	[Address(RVA = "0x25401B0", Offset = "0x253F5B0", Length = "0x7C")]
	[Token(Token = "0x6000913")]
	public override void RemoveAll() { }

	[Address(RVA = "0x2540230", Offset = "0x253F630", Length = "0x4A7")]
	[Token(Token = "0x60008F8")]
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	[Address(RVA = "0x2541240", Offset = "0x2540640", Length = "0x109")]
	[Token(Token = "0x600090D")]
	public override void set_InnerText(string value) { }

	[Address(RVA = "0x2541350", Offset = "0x2540750", Length = "0x5F")]
	[Token(Token = "0x600090E")]
	public override void set_InnerXml(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60008F4")]
	internal override void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000904")]
	public override void set_Prefix(string value) { }

	[Address(RVA = "0x25413B0", Offset = "0x25407B0", Length = "0xD4")]
	[Token(Token = "0x60008E8")]
	public override void set_Value(string value) { }

	[Address(RVA = "0x25406E0", Offset = "0x253FAE0", Length = "0x3C")]
	[Token(Token = "0x6000917")]
	internal override void SetParent(XmlNode node) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000918")]
	internal override void SetParentForLoad(XmlNode node) { }

	[Address(RVA = "0x2540720", Offset = "0x253FB20", Length = "0xC1")]
	[Token(Token = "0x6000919")]
	internal static void SplitName(string name, out string prefix, out string localName) { }

	[Address(RVA = "0x25407F0", Offset = "0x253FBF0", Length = "0x54")]
	[Token(Token = "0x6000909")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x2540850", Offset = "0x253FC50", Length = "0x16")]
	[Token(Token = "0x6000908")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x2540870", Offset = "0x253FC70", Length = "0x40")]
	[Token(Token = "0x6000922")]
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	[Token(Token = "0x6000912")]
	public abstract void WriteContentTo(XmlWriter w) { }

	[Token(Token = "0x6000911")]
	public abstract void WriteTo(XmlWriter w) { }

}

