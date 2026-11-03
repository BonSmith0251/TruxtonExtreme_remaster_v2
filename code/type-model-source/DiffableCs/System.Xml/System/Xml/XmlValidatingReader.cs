namespace System.Xml;

[Obsolete("Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. https://go.microsoft.com/fwlink/?linkid=14202")]
[Token(Token = "0x200006F")]
public class XmlValidatingReader : XmlReader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400030A")]
	private XmlValidatingReaderImpl impl; //Field offset: 0x10

	[Token(Token = "0x1700013F")]
	public virtual int AttributeCount
	{
		[Address(RVA = "0x1FEF050", Offset = "0x1FEE450", Length = "0x2A")]
		[Token(Token = "0x60005D5")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013D")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
		[Token(Token = "0x60005D3")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013C")]
	public virtual int Depth
	{
		[Address(RVA = "0x23700D0", Offset = "0x236F4D0", Length = "0x2A")]
		[Token(Token = "0x60005D2")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000140")]
	public virtual bool EOF
	{
		[Address(RVA = "0x2370100", Offset = "0x236F500", Length = "0x2A")]
		[Token(Token = "0x60005DF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013E")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
		[Token(Token = "0x60005D4")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000138")]
	public virtual string LocalName
	{
		[Address(RVA = "0x1DFC7E0", Offset = "0x1DFBBE0", Length = "0x2A")]
		[Token(Token = "0x60005CE")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000143")]
	public bool Namespaces
	{
		[Address(RVA = "0x25090B0", Offset = "0x25084B0", Length = "0x27")]
		[Token(Token = "0x60005E4")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000139")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
		[Token(Token = "0x60005CF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000142")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x21BB7E0", Offset = "0x21BABE0", Length = "0x2A")]
		[Token(Token = "0x60005E1")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000137")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x2370160", Offset = "0x236F560", Length = "0x2A")]
		[Token(Token = "0x60005CD")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013A")]
	public virtual string Prefix
	{
		[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
		[Token(Token = "0x60005D0")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000141")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0x2370190", Offset = "0x236F590", Length = "0x2A")]
		[Token(Token = "0x60005E0")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013B")]
	public virtual string Value
	{
		[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
		[Token(Token = "0x60005D1")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x1FEF050", Offset = "0x1FEE450", Length = "0x2A")]
	[Token(Token = "0x60005D5")]
	public virtual int get_AttributeCount() { }

	[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
	[Token(Token = "0x60005D3")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x23700D0", Offset = "0x236F4D0", Length = "0x2A")]
	[Token(Token = "0x60005D2")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x2370100", Offset = "0x236F500", Length = "0x2A")]
	[Token(Token = "0x60005DF")]
	public virtual bool get_EOF() { }

	[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
	[Token(Token = "0x60005D4")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x1DFC7E0", Offset = "0x1DFBBE0", Length = "0x2A")]
	[Token(Token = "0x60005CE")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x25090B0", Offset = "0x25084B0", Length = "0x27")]
	[Token(Token = "0x60005E4")]
	public bool get_Namespaces() { }

	[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
	[Token(Token = "0x60005CF")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x21BB7E0", Offset = "0x21BABE0", Length = "0x2A")]
	[Token(Token = "0x60005E1")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x2370160", Offset = "0x236F560", Length = "0x2A")]
	[Token(Token = "0x60005CD")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
	[Token(Token = "0x60005D0")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x2370190", Offset = "0x236F590", Length = "0x2A")]
	[Token(Token = "0x60005E0")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
	[Token(Token = "0x60005D1")]
	public virtual string get_Value() { }

	[Address(RVA = "0x236FEB0", Offset = "0x236F2B0", Length = "0x2A")]
	[Token(Token = "0x60005D7")]
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	[Address(RVA = "0x226EDE0", Offset = "0x226E1E0", Length = "0x2A")]
	[Token(Token = "0x60005D6")]
	public virtual string GetAttribute(string name) { }

	[Address(RVA = "0x236FEE0", Offset = "0x236F2E0", Length = "0x2A")]
	[Token(Token = "0x60005D8")]
	public virtual string GetAttribute(int i) { }

	[Address(RVA = "0x24FCEA0", Offset = "0x24FC2A0", Length = "0x38")]
	[Token(Token = "0x60005E2")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0xA75530", Offset = "0xA74930", Length = "0x2A")]
	[Token(Token = "0x60005D9")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x1FC8EC0", Offset = "0x1FC82C0", Length = "0x2A")]
	[Token(Token = "0x60005DC")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x236FF40", Offset = "0x236F340", Length = "0x2A")]
	[Token(Token = "0x60005DA")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x1E8F300", Offset = "0x1E8E700", Length = "0x2A")]
	[Token(Token = "0x60005DB")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x236FFA0", Offset = "0x236F3A0", Length = "0x2A")]
	[Token(Token = "0x60005DE")]
	public virtual bool Read() { }

	[Address(RVA = "0x21BB7B0", Offset = "0x21BABB0", Length = "0x2A")]
	[Token(Token = "0x60005DD")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x236FFD0", Offset = "0x236F3D0", Length = "0x2A")]
	[Token(Token = "0x60005E3")]
	public virtual void ResolveEntity() { }

}

