namespace System.Xml;

[DefaultMember("ItemOf")]
[Token(Token = "0x200008E")]
public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable
{

	[Token(Token = "0x170001C9")]
	public XmlAttribute ItemOf
	{
		[Address(RVA = "0x2512540", Offset = "0x2511940", Length = "0xEB")]
		[Token(Token = "0x6000777")]
		 get { } //Length: 235
	}

	[Token(Token = "0x170001CA")]
	public XmlAttribute ItemOf
	{
		[Address(RVA = "0x2512630", Offset = "0x2511A30", Length = "0x121")]
		[Token(Token = "0x6000778")]
		 get { } //Length: 289
	}

	[Token(Token = "0x170001CB")]
	public XmlAttribute ItemOf
	{
		[Address(RVA = "0x25123F0", Offset = "0x25117F0", Length = "0x14F")]
		[Token(Token = "0x6000779")]
		 get { } //Length: 335
	}

	[Token(Token = "0x170001CE")]
	private override int System.Collections.ICollection.Count
	{
		[Address(RVA = "0x25123D0", Offset = "0x25117D0", Length = "0x7")]
		[Token(Token = "0x6000783")]
		private get { } //Length: 7
	}

	[Token(Token = "0x170001CC")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000781")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001CD")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6000782")]
		private get { } //Length: 4
	}

	[Address(RVA = "0x25123E0", Offset = "0x25117E0", Length = "0x8")]
	[Token(Token = "0x6000776")]
	internal XmlAttributeCollection(XmlNode parent) { }

	[Address(RVA = "0x2510FC0", Offset = "0x25103C0", Length = "0x1E8")]
	[Token(Token = "0x6000784")]
	internal virtual XmlNode AddNode(XmlNode node) { }

	[Address(RVA = "0x25111B0", Offset = "0x25105B0", Length = "0x1E3")]
	[Token(Token = "0x600077C")]
	public XmlAttribute Append(XmlAttribute node) { }

	[Address(RVA = "0x25113A0", Offset = "0x25107A0", Length = "0xD3")]
	[Token(Token = "0x6000787")]
	internal void Detach(XmlAttribute attr) { }

	[Address(RVA = "0x2511480", Offset = "0x2510880", Length = "0x195")]
	[Token(Token = "0x600077A")]
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	[Address(RVA = "0x2512540", Offset = "0x2511940", Length = "0xEB")]
	[Token(Token = "0x6000777")]
	public XmlAttribute get_ItemOf(int i) { }

	[Address(RVA = "0x2512630", Offset = "0x2511A30", Length = "0x121")]
	[Token(Token = "0x6000778")]
	public XmlAttribute get_ItemOf(string name) { }

	[Address(RVA = "0x25123F0", Offset = "0x25117F0", Length = "0x14F")]
	[Token(Token = "0x6000779")]
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	[Address(RVA = "0x2511620", Offset = "0x2510A20", Length = "0x9F")]
	[Token(Token = "0x6000785")]
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

	[Address(RVA = "0x25116C0", Offset = "0x2510AC0", Length = "0x18E")]
	[Token(Token = "0x6000788")]
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	[Address(RVA = "0x2511850", Offset = "0x2510C50", Length = "0xB1")]
	[Token(Token = "0x600078D")]
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

	[Address(RVA = "0x2511910", Offset = "0x2510D10", Length = "0x100")]
	[Token(Token = "0x600078B")]
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	[Address(RVA = "0x2512020", Offset = "0x2511420", Length = "0x93")]
	[Token(Token = "0x600077D")]
	public XmlAttribute Remove(XmlAttribute node) { }

	[Address(RVA = "0x2511A20", Offset = "0x2510E20", Length = "0xD3")]
	[Token(Token = "0x600077F")]
	public void RemoveAll() { }

	[Address(RVA = "0x2511B00", Offset = "0x2510F00", Length = "0xAC")]
	[Token(Token = "0x600077E")]
	public XmlAttribute RemoveAt(int i) { }

	[Address(RVA = "0x2511BB0", Offset = "0x2510FB0", Length = "0xFE")]
	[Token(Token = "0x600078A")]
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	[Address(RVA = "0x2511CB0", Offset = "0x25110B0", Length = "0x1D0")]
	[Token(Token = "0x6000786")]
	internal virtual XmlNode RemoveNodeAt(int i) { }

	[Address(RVA = "0x2511E90", Offset = "0x2511290", Length = "0x18E")]
	[Token(Token = "0x6000789")]
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	[Address(RVA = "0x25120C0", Offset = "0x25114C0", Length = "0xD6")]
	[Token(Token = "0x600078C")]
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	[Address(RVA = "0x25121A0", Offset = "0x25115A0", Length = "0x19A")]
	[Token(Token = "0x600077B")]
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	[Address(RVA = "0x2512340", Offset = "0x2511740", Length = "0x8D")]
	[Token(Token = "0x6000780")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x25123D0", Offset = "0x25117D0", Length = "0x7")]
	[Token(Token = "0x6000783")]
	private override int System.Collections.ICollection.get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000781")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000782")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

}

