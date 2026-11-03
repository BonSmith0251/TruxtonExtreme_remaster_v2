namespace System.Xml.XPath;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[Token(Token = "0x20000EC")]
public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver
{
	[Token(Token = "0x40005C0")]
	internal static readonly XPathNavigatorKeyComparer comparer; //Field offset: 0x0
	[Token(Token = "0x40005C1")]
	internal static readonly Char[] NodeTypeLetter; //Field offset: 0x8
	[Token(Token = "0x40005C2")]
	internal static readonly Char[] UniqueIdTbl; //Field offset: 0x10
	[Token(Token = "0x40005C3")]
	internal static readonly Int32[] ContentKindMasks; //Field offset: 0x18

	[Token(Token = "0x170002F9")]
	public abstract string LocalName
	{
		[Token(Token = "0x6000BCA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002FA")]
	public abstract string NamespaceURI
	{
		[Token(Token = "0x6000BCB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002F7")]
	public abstract XmlNameTable NameTable
	{
		[Token(Token = "0x6000BC4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002F8")]
	public abstract XPathNodeType NodeType
	{
		[Token(Token = "0x6000BC9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002FB")]
	public abstract string Prefix
	{
		[Token(Token = "0x6000BCC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002FD")]
	public override IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x254EA30", Offset = "0x254DE30", Length = "0x39")]
		[Token(Token = "0x6000BD3")]
		 get { } //Length: 57
	}

	[Token(Token = "0x170002F0")]
	public virtual object TypedValue
	{
		[Address(RVA = "0x254EA70", Offset = "0x254DE70", Length = "0x1ED")]
		[Token(Token = "0x6000BBB")]
		 get { } //Length: 493
	}

	[Token(Token = "0x170002FC")]
	public override object UnderlyingObject
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000BCD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170002F2")]
	public virtual bool ValueAsBoolean
	{
		[Address(RVA = "0x254EC60", Offset = "0x254E060", Length = "0x1E5")]
		[Token(Token = "0x6000BBD")]
		 get { } //Length: 485
	}

	[Token(Token = "0x170002F3")]
	public virtual DateTime ValueAsDateTime
	{
		[Address(RVA = "0x254EE50", Offset = "0x254E250", Length = "0x1E5")]
		[Token(Token = "0x6000BBE")]
		 get { } //Length: 485
	}

	[Token(Token = "0x170002F4")]
	public virtual double ValueAsDouble
	{
		[Address(RVA = "0x254F040", Offset = "0x254E440", Length = "0x1E5")]
		[Token(Token = "0x6000BBF")]
		 get { } //Length: 485
	}

	[Token(Token = "0x170002F5")]
	public virtual int ValueAsInt
	{
		[Address(RVA = "0x254F230", Offset = "0x254E630", Length = "0x1E5")]
		[Token(Token = "0x6000BC0")]
		 get { } //Length: 485
	}

	[Token(Token = "0x170002F6")]
	public virtual long ValueAsLong
	{
		[Address(RVA = "0x254F420", Offset = "0x254E820", Length = "0x1E5")]
		[Token(Token = "0x6000BC1")]
		 get { } //Length: 485
	}

	[Token(Token = "0x170002F1")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x254F610", Offset = "0x254EA10", Length = "0xDB")]
		[Token(Token = "0x6000BBC")]
		 get { } //Length: 219
	}

	[Token(Token = "0x170002EF")]
	public virtual XmlSchemaType XmlType
	{
		[Address(RVA = "0x254F6F0", Offset = "0x254EAF0", Length = "0x93")]
		[Token(Token = "0x6000BBA")]
		 get { } //Length: 147
	}

	[Address(RVA = "0x254E880", Offset = "0x254DC80", Length = "0x1A5")]
	[Token(Token = "0x6000BD6")]
	private static XPathNavigator() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000BD5")]
	protected XPathNavigator() { }

	[Token(Token = "0x6000BC8")]
	public abstract XPathNavigator Clone() { }

	[Token(Token = "0x6000BCA")]
	public abstract string get_LocalName() { }

	[Token(Token = "0x6000BCB")]
	public abstract string get_NamespaceURI() { }

	[Token(Token = "0x6000BC4")]
	public abstract XmlNameTable get_NameTable() { }

	[Token(Token = "0x6000BC9")]
	public abstract XPathNodeType get_NodeType() { }

	[Token(Token = "0x6000BCC")]
	public abstract string get_Prefix() { }

	[Address(RVA = "0x254EA30", Offset = "0x254DE30", Length = "0x39")]
	[Token(Token = "0x6000BD3")]
	public override IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x254EA70", Offset = "0x254DE70", Length = "0x1ED")]
	[Token(Token = "0x6000BBB")]
	public virtual object get_TypedValue() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000BCD")]
	public override object get_UnderlyingObject() { }

	[Address(RVA = "0x254EC60", Offset = "0x254E060", Length = "0x1E5")]
	[Token(Token = "0x6000BBD")]
	public virtual bool get_ValueAsBoolean() { }

	[Address(RVA = "0x254EE50", Offset = "0x254E250", Length = "0x1E5")]
	[Token(Token = "0x6000BBE")]
	public virtual DateTime get_ValueAsDateTime() { }

	[Address(RVA = "0x254F040", Offset = "0x254E440", Length = "0x1E5")]
	[Token(Token = "0x6000BBF")]
	public virtual double get_ValueAsDouble() { }

	[Address(RVA = "0x254F230", Offset = "0x254E630", Length = "0x1E5")]
	[Token(Token = "0x6000BC0")]
	public virtual int get_ValueAsInt() { }

	[Address(RVA = "0x254F420", Offset = "0x254E820", Length = "0x1E5")]
	[Token(Token = "0x6000BC1")]
	public virtual long get_ValueAsLong() { }

	[Address(RVA = "0x254F610", Offset = "0x254EA10", Length = "0xDB")]
	[Token(Token = "0x6000BBC")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x254F6F0", Offset = "0x254EAF0", Length = "0x93")]
	[Token(Token = "0x6000BBA")]
	public virtual XmlSchemaType get_XmlType() { }

	[Address(RVA = "0x254DF80", Offset = "0x254D380", Length = "0x208")]
	[Token(Token = "0x6000BC7")]
	public override IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Token(Token = "0x6000BD2")]
	public abstract bool IsSamePosition(XPathNavigator other) { }

	[Address(RVA = "0x254E190", Offset = "0x254D590", Length = "0xA")]
	[Token(Token = "0x6000BD4")]
	internal static bool IsText(XPathNodeType type) { }

	[Address(RVA = "0x254E1A0", Offset = "0x254D5A0", Length = "0x1B5")]
	[Token(Token = "0x6000BC5")]
	public override string LookupNamespace(string prefix) { }

	[Address(RVA = "0x254E360", Offset = "0x254D760", Length = "0x237")]
	[Token(Token = "0x6000BC6")]
	public override string LookupPrefix(string namespaceURI) { }

	[Token(Token = "0x6000BCF")]
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	[Address(RVA = "0x254E5A0", Offset = "0x254D9A0", Length = "0xA4")]
	[Token(Token = "0x6000BCE")]
	public override bool MoveToNamespace(string name) { }

	[Token(Token = "0x6000BD0")]
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope) { }

	[Token(Token = "0x6000BD1")]
	public abstract bool MoveToParent() { }

	[Address(RVA = "0x24DA040", Offset = "0x24D9440", Length = "0x14")]
	[Token(Token = "0x6000BC3")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x1D214A0", Offset = "0x1D208A0", Length = "0x14")]
	[Token(Token = "0x6000BB9")]
	public virtual string ToString() { }

	[Address(RVA = "0x254E650", Offset = "0x254DA50", Length = "0x225")]
	[Token(Token = "0x6000BC2")]
	public virtual object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

}

