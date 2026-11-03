namespace System.Data;

[Token(Token = "0x20000A5")]
internal sealed class DataTextReader : XmlReader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400034B")]
	private XmlReader _xmlreader; //Field offset: 0x10

	[Token(Token = "0x1700013E")]
	public virtual int AttributeCount
	{
		[Address(RVA = "0x1FEF050", Offset = "0x1FEE450", Length = "0x2A")]
		[Token(Token = "0x6000879")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000138")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
		[Token(Token = "0x6000873")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000143")]
	public virtual bool CanReadValueChunk
	{
		[Address(RVA = "0x1FC8A40", Offset = "0x1FC7E40", Length = "0x2A")]
		[Token(Token = "0x600088C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000142")]
	public virtual bool CanResolveEntity
	{
		[Address(RVA = "0x23700A0", Offset = "0x236F4A0", Length = "0x2A")]
		[Token(Token = "0x600088A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000137")]
	public virtual int Depth
	{
		[Address(RVA = "0x23700D0", Offset = "0x236F4D0", Length = "0x2A")]
		[Token(Token = "0x6000872")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013F")]
	public virtual bool EOF
	{
		[Address(RVA = "0x2370100", Offset = "0x236F500", Length = "0x2A")]
		[Token(Token = "0x6000884")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013A")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
		[Token(Token = "0x6000875")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000139")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
		[Token(Token = "0x6000874")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000133")]
	public virtual string LocalName
	{
		[Address(RVA = "0x1DFC7E0", Offset = "0x1DFBBE0", Length = "0x2A")]
		[Token(Token = "0x600086E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000132")]
	public virtual string Name
	{
		[Address(RVA = "0x21A98A0", Offset = "0x21A8CA0", Length = "0x2A")]
		[Token(Token = "0x600086D")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000134")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
		[Token(Token = "0x600086F")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000141")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x21BB7E0", Offset = "0x21BABE0", Length = "0x2A")]
		[Token(Token = "0x6000888")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000131")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x2370160", Offset = "0x236F560", Length = "0x2A")]
		[Token(Token = "0x600086C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000135")]
	public virtual string Prefix
	{
		[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
		[Token(Token = "0x6000870")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013B")]
	public virtual char QuoteChar
	{
		[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
		[Token(Token = "0x6000876")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000140")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0x2370190", Offset = "0x236F590", Length = "0x2A")]
		[Token(Token = "0x6000886")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000130")]
	public virtual XmlReaderSettings Settings
	{
		[Address(RVA = "0x2171280", Offset = "0x2170680", Length = "0x2A")]
		[Token(Token = "0x600086B")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000136")]
	public virtual string Value
	{
		[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
		[Token(Token = "0x6000871")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013D")]
	public virtual string XmlLang
	{
		[Address(RVA = "0x23701C0", Offset = "0x236F5C0", Length = "0x2A")]
		[Token(Token = "0x6000878")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013C")]
	public virtual XmlSpace XmlSpace
	{
		[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
		[Token(Token = "0x6000877")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2370000", Offset = "0x236F400", Length = "0x65")]
	[Token(Token = "0x600086A")]
	private DataTextReader(XmlReader input) { }

	[Address(RVA = "0x21BB810", Offset = "0x21BAC10", Length = "0x2A")]
	[Token(Token = "0x6000885")]
	public virtual void Close() { }

	[Address(RVA = "0x236FE10", Offset = "0x236F210", Length = "0x91")]
	[Token(Token = "0x6000869")]
	internal static XmlReader CreateReader(XmlReader xr) { }

	[Address(RVA = "0x1FEF050", Offset = "0x1FEE450", Length = "0x2A")]
	[Token(Token = "0x6000879")]
	public virtual int get_AttributeCount() { }

	[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
	[Token(Token = "0x6000873")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x1FC8A40", Offset = "0x1FC7E40", Length = "0x2A")]
	[Token(Token = "0x600088C")]
	public virtual bool get_CanReadValueChunk() { }

	[Address(RVA = "0x23700A0", Offset = "0x236F4A0", Length = "0x2A")]
	[Token(Token = "0x600088A")]
	public virtual bool get_CanResolveEntity() { }

	[Address(RVA = "0x23700D0", Offset = "0x236F4D0", Length = "0x2A")]
	[Token(Token = "0x6000872")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x2370100", Offset = "0x236F500", Length = "0x2A")]
	[Token(Token = "0x6000884")]
	public virtual bool get_EOF() { }

	[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
	[Token(Token = "0x6000875")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
	[Token(Token = "0x6000874")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x1DFC7E0", Offset = "0x1DFBBE0", Length = "0x2A")]
	[Token(Token = "0x600086E")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x21A98A0", Offset = "0x21A8CA0", Length = "0x2A")]
	[Token(Token = "0x600086D")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
	[Token(Token = "0x600086F")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x21BB7E0", Offset = "0x21BABE0", Length = "0x2A")]
	[Token(Token = "0x6000888")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x2370160", Offset = "0x236F560", Length = "0x2A")]
	[Token(Token = "0x600086C")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
	[Token(Token = "0x6000870")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
	[Token(Token = "0x6000876")]
	public virtual char get_QuoteChar() { }

	[Address(RVA = "0x2370190", Offset = "0x236F590", Length = "0x2A")]
	[Token(Token = "0x6000886")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x2171280", Offset = "0x2170680", Length = "0x2A")]
	[Token(Token = "0x600086B")]
	public virtual XmlReaderSettings get_Settings() { }

	[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
	[Token(Token = "0x6000871")]
	public virtual string get_Value() { }

	[Address(RVA = "0x23701C0", Offset = "0x236F5C0", Length = "0x2A")]
	[Token(Token = "0x6000878")]
	public virtual string get_XmlLang() { }

	[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
	[Token(Token = "0x6000877")]
	public virtual XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x236FEB0", Offset = "0x236F2B0", Length = "0x2A")]
	[Token(Token = "0x600087B")]
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	[Address(RVA = "0x236FEE0", Offset = "0x236F2E0", Length = "0x2A")]
	[Token(Token = "0x600087C")]
	public virtual string GetAttribute(int i) { }

	[Address(RVA = "0x226EDE0", Offset = "0x226E1E0", Length = "0x2A")]
	[Token(Token = "0x600087A")]
	public virtual string GetAttribute(string name) { }

	[Address(RVA = "0x1FEF630", Offset = "0x1FEEA30", Length = "0x2A")]
	[Token(Token = "0x6000889")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x236FF10", Offset = "0x236F310", Length = "0x2A")]
	[Token(Token = "0x600087E")]
	public virtual void MoveToAttribute(int i) { }

	[Address(RVA = "0xA75530", Offset = "0xA74930", Length = "0x2A")]
	[Token(Token = "0x600087D")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x1FC8EC0", Offset = "0x1FC82C0", Length = "0x2A")]
	[Token(Token = "0x6000881")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x236FF40", Offset = "0x236F340", Length = "0x2A")]
	[Token(Token = "0x600087F")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x1E8F300", Offset = "0x1E8E700", Length = "0x2A")]
	[Token(Token = "0x6000880")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x236FFA0", Offset = "0x236F3A0", Length = "0x2A")]
	[Token(Token = "0x6000883")]
	public virtual bool Read() { }

	[Address(RVA = "0x21BB7B0", Offset = "0x21BABB0", Length = "0x2A")]
	[Token(Token = "0x6000882")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x236FF70", Offset = "0x236F370", Length = "0x2A")]
	[Token(Token = "0x600088D")]
	public virtual string ReadString() { }

	[Address(RVA = "0x236FFD0", Offset = "0x236F3D0", Length = "0x2A")]
	[Token(Token = "0x600088B")]
	public virtual void ResolveEntity() { }

	[Address(RVA = "0x1FC8A10", Offset = "0x1FC7E10", Length = "0x2A")]
	[Token(Token = "0x6000887")]
	public virtual void Skip() { }

}

