namespace System.Xml;

[Token(Token = "0x2000097")]
public class XmlDocumentType : XmlLinkedNode
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000459")]
	private string name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400045A")]
	private string publicId; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400045B")]
	private string systemId; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400045C")]
	private string internalSubset; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400045D")]
	private bool namespaces; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400045E")]
	private XmlNamedNodeMap entities; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400045F")]
	private XmlNamedNodeMap notations; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000460")]
	private SchemaInfo schemaInfo; //Field offset: 0x58

	[Token(Token = "0x17000213")]
	internal SchemaInfo DtdSchemaInfo
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600083C")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x600083D")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700020D")]
	public XmlNamedNodeMap Entities
	{
		[Address(RVA = "0x25150E0", Offset = "0x25144E0", Length = "0x6D")]
		[Token(Token = "0x6000834")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000211")]
	public string InternalSubset
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000838")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700020C")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000833")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700020A")]
	public virtual string LocalName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000830")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000209")]
	public virtual string Name
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600082F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700020B")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
		[Token(Token = "0x6000831")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700020E")]
	public XmlNamedNodeMap Notations
	{
		[Address(RVA = "0x2515150", Offset = "0x2514550", Length = "0x6D")]
		[Token(Token = "0x6000835")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000212")]
	internal bool ParseWithNamespaces
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x6000839")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700020F")]
	public string PublicId
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000836")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000210")]
	public string SystemId
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000837")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2514F80", Offset = "0x2514380", Length = "0x159")]
	[Token(Token = "0x600082E")]
	protected private XmlDocumentType(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	[Address(RVA = "0x2514ED0", Offset = "0x25142D0", Length = "0x5D")]
	[Token(Token = "0x6000832")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600083C")]
	internal SchemaInfo get_DtdSchemaInfo() { }

	[Address(RVA = "0x25150E0", Offset = "0x25144E0", Length = "0x6D")]
	[Token(Token = "0x6000834")]
	public XmlNamedNodeMap get_Entities() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000838")]
	public string get_InternalSubset() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000833")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000830")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600082F")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
	[Token(Token = "0x6000831")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2515150", Offset = "0x2514550", Length = "0x6D")]
	[Token(Token = "0x6000835")]
	public XmlNamedNodeMap get_Notations() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x6000839")]
	internal bool get_ParseWithNamespaces() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000836")]
	public string get_PublicId() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000837")]
	public string get_SystemId() { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x600083D")]
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600083B")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x2514F30", Offset = "0x2514330", Length = "0x47")]
	[Token(Token = "0x600083A")]
	public virtual void WriteTo(XmlWriter w) { }

}

