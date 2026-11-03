namespace System.Xml;

[Token(Token = "0x200009A")]
public class XmlEntityReference : XmlLinkedNode
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400046C")]
	private string name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400046D")]
	private XmlLinkedNode lastChild; //Field offset: 0x28

	[Token(Token = "0x17000236")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x251C440", Offset = "0x251B840", Length = "0x3C")]
		[Token(Token = "0x600088C")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000237")]
	internal string ChildBaseURI
	{
		[Address(RVA = "0x251C480", Offset = "0x251B880", Length = "0x212")]
		[Token(Token = "0x600088E")]
		internal get { } //Length: 530
	}

	[Token(Token = "0x17000234")]
	internal virtual bool IsContainer
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000884")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000233")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000883")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000235")]
	internal virtual XmlLinkedNode LastNode
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000887")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000888")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000230")]
	public virtual string LocalName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600087E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700022F")]
	public virtual string Name
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600087D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000232")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
		[Token(Token = "0x6000881")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000231")]
	public virtual string Value
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600087F")]
		 get { } //Length: 3
		[Address(RVA = "0x251C6A0", Offset = "0x251BAA0", Length = "0x5F")]
		[Token(Token = "0x6000880")]
		 set { } //Length: 95
	}

	[Address(RVA = "0x251C330", Offset = "0x251B730", Length = "0x10C")]
	[Token(Token = "0x600087C")]
	protected private XmlEntityReference(string name, XmlDocument doc) { }

	[Address(RVA = "0x251BEF0", Offset = "0x251B2F0", Length = "0x46")]
	[Token(Token = "0x6000882")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x251BF40", Offset = "0x251B340", Length = "0xBD")]
	[Token(Token = "0x600088D")]
	private string ConstructBaseURI(string baseURI, string systemId) { }

	[Address(RVA = "0x251C440", Offset = "0x251B840", Length = "0x3C")]
	[Token(Token = "0x600088C")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x251C480", Offset = "0x251B880", Length = "0x212")]
	[Token(Token = "0x600088E")]
	internal string get_ChildBaseURI() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000884")]
	internal virtual bool get_IsContainer() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000883")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000887")]
	internal virtual XmlLinkedNode get_LastNode() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600087E")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600087D")]
	public virtual string get_Name() { }

	[Address(RVA = "0x9E1870", Offset = "0x9E0C70", Length = "0x6")]
	[Token(Token = "0x6000881")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600087F")]
	public virtual string get_Value() { }

	[Address(RVA = "0x251AB50", Offset = "0x2519F50", Length = "0x18")]
	[Token(Token = "0x6000889")]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000888")]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x251C6A0", Offset = "0x251BAA0", Length = "0x5F")]
	[Token(Token = "0x6000880")]
	public virtual void set_Value(string value) { }

	[Address(RVA = "0x251C020", Offset = "0x251B420", Length = "0xB1")]
	[Token(Token = "0x6000885")]
	internal virtual void SetParent(XmlNode node) { }

	[Address(RVA = "0x251C000", Offset = "0x251B400", Length = "0x14")]
	[Token(Token = "0x6000886")]
	internal virtual void SetParentForLoad(XmlNode node) { }

	[Address(RVA = "0x251C0E0", Offset = "0x251B4E0", Length = "0x20F")]
	[Token(Token = "0x600088B")]
	public virtual void WriteContentTo(XmlWriter w) { }

	[Address(RVA = "0x251C2F0", Offset = "0x251B6F0", Length = "0x30")]
	[Token(Token = "0x600088A")]
	public virtual void WriteTo(XmlWriter w) { }

}

