namespace System.Xml;

[Token(Token = "0x2000099")]
public class XmlEntity : XmlNode
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000464")]
	private string publicId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000465")]
	private string systemId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000466")]
	private string notationName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000467")]
	private string name; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000468")]
	private string unparsedReplacementStr; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000469")]
	private string baseURI; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400046A")]
	private XmlLinkedNode lastChild; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400046B")]
	private bool childrenFoliating; //Field offset: 0x50

	[Token(Token = "0x1700022E")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600087A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000228")]
	public virtual string InnerText
	{
		[Address(RVA = "0x251B9C0", Offset = "0x251ADC0", Length = "0x7")]
		[Token(Token = "0x600086F")]
		 get { } //Length: 7
		[Address(RVA = "0x251C970", Offset = "0x251BD70", Length = "0x5F")]
		[Token(Token = "0x6000870")]
		 set { } //Length: 95
	}

	[Token(Token = "0x1700022D")]
	public virtual string InnerXml
	{
		[Address(RVA = "0x251C9D0", Offset = "0x251BDD0", Length = "0x5F")]
		[Token(Token = "0x6000877")]
		 set { } //Length: 95
	}

	[Token(Token = "0x17000229")]
	internal virtual bool IsContainer
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000871")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000225")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600086C")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700022A")]
	internal virtual XmlLinkedNode LastNode
	{
		[Address(RVA = "0x251C870", Offset = "0x251BC70", Length = "0xFB")]
		[Token(Token = "0x6000872")]
		internal get { } //Length: 251
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x6000873")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000227")]
	public virtual string LocalName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600086E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000226")]
	public virtual string Name
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600086D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700022B")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
		[Token(Token = "0x6000875")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700022C")]
	public string SystemId
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000876")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x251C780", Offset = "0x251BB80", Length = "0xE7")]
	[Token(Token = "0x600086A")]
	internal XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	[Address(RVA = "0x251C700", Offset = "0x251BB00", Length = "0x5F")]
	[Token(Token = "0x600086B")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600087A")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x251B9C0", Offset = "0x251ADC0", Length = "0x7")]
	[Token(Token = "0x600086F")]
	public virtual string get_InnerText() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000871")]
	internal virtual bool get_IsContainer() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600086C")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x251C870", Offset = "0x251BC70", Length = "0xFB")]
	[Token(Token = "0x6000872")]
	internal virtual XmlLinkedNode get_LastNode() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600086E")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600086D")]
	public virtual string get_Name() { }

	[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
	[Token(Token = "0x6000875")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000876")]
	public string get_SystemId() { }

	[Address(RVA = "0x251C760", Offset = "0x251BB60", Length = "0x19")]
	[Token(Token = "0x6000874")]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x251C970", Offset = "0x251BD70", Length = "0x5F")]
	[Token(Token = "0x6000870")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x251C9D0", Offset = "0x251BDD0", Length = "0x5F")]
	[Token(Token = "0x6000877")]
	public virtual void set_InnerXml(string value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6000873")]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x600087B")]
	internal void SetBaseURI(string inBaseURI) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000879")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000878")]
	public virtual void WriteTo(XmlWriter w) { }

}

