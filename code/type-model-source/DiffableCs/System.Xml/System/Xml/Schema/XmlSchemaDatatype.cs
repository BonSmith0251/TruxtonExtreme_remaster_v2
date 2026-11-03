namespace System.Xml.Schema;

[Token(Token = "0x200020E")]
public abstract class XmlSchemaDatatype
{

	[Token(Token = "0x170005C4")]
	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Token(Token = "0x600151E")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x170005C3")]
	internal abstract FacetsChecker FacetsChecker
	{
		[Token(Token = "0x600151D")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x170005BF")]
	internal abstract bool HasLexicalFacets
	{
		[Token(Token = "0x6001515")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x170005C0")]
	internal abstract bool HasValueFacets
	{
		[Token(Token = "0x6001516")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x170005C2")]
	internal abstract RestrictionFacets Restriction
	{
		[Token(Token = "0x6001518")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x170005BC")]
	public abstract XmlTokenizedType TokenizedType
	{
		[Token(Token = "0x6001510")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170005BE")]
	public override XmlTypeCode TypeCode
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001513")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170005C5")]
	internal string TypeCodeString
	{
		[Address(RVA = "0x248D310", Offset = "0x248C710", Length = "0x14D")]
		[Token(Token = "0x6001524")]
		internal get { } //Length: 333
	}

	[Token(Token = "0x170005C1")]
	internal abstract XmlValueConverter ValueConverter
	{
		[Token(Token = "0x6001517")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x170005BB")]
	public abstract Type ValueType
	{
		[Token(Token = "0x600150F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170005BD")]
	public override XmlSchemaDatatypeVariety Variety
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6001512")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600152C")]
	protected XmlSchemaDatatype() { }

	[Token(Token = "0x6001519")]
	internal abstract int Compare(object value1, object value2) { }

	[Address(RVA = "0x248C480", Offset = "0x248B880", Length = "0x5E1")]
	[Token(Token = "0x6001526")]
	internal static string ConcatenatedToString(object value) { }

	[Token(Token = "0x6001520")]
	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	[Token(Token = "0x600151F")]
	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	[Address(RVA = "0x248CA70", Offset = "0x248BE70", Length = "0x59")]
	[Token(Token = "0x600152A")]
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	[Address(RVA = "0x248CAD0", Offset = "0x248BED0", Length = "0x49")]
	[Token(Token = "0x6001529")]
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	[Address(RVA = "0x248CB70", Offset = "0x248BF70", Length = "0x47")]
	[Token(Token = "0x6001527")]
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	[Address(RVA = "0x248CB20", Offset = "0x248BF20", Length = "0x47")]
	[Token(Token = "0x6001528")]
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	[Token(Token = "0x600151E")]
	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Token(Token = "0x600151D")]
	internal abstract FacetsChecker get_FacetsChecker() { }

	[Token(Token = "0x6001515")]
	internal abstract bool get_HasLexicalFacets() { }

	[Token(Token = "0x6001516")]
	internal abstract bool get_HasValueFacets() { }

	[Token(Token = "0x6001518")]
	internal abstract RestrictionFacets get_Restriction() { }

	[Token(Token = "0x6001510")]
	public abstract XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001513")]
	public override XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x248D310", Offset = "0x248C710", Length = "0x14D")]
	[Token(Token = "0x6001524")]
	internal string get_TypeCodeString() { }

	[Token(Token = "0x6001517")]
	internal abstract XmlValueConverter get_ValueConverter() { }

	[Token(Token = "0x600150F")]
	public abstract Type get_ValueType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001512")]
	public override XmlSchemaDatatypeVariety get_Variety() { }

	[Token(Token = "0x6001523")]
	internal abstract bool IsComparable(XmlSchemaDatatype dtype) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001514")]
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	[Token(Token = "0x6001522")]
	internal abstract bool IsEqual(object o1, object o2) { }

	[Token(Token = "0x6001511")]
	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	[Token(Token = "0x600151A")]
	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	[Token(Token = "0x600151C")]
	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	[Token(Token = "0x600151B")]
	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	[Address(RVA = "0x248CBC0", Offset = "0x248BFC0", Length = "0x24C")]
	[Token(Token = "0x6001525")]
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	[Token(Token = "0x6001521")]
	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	[Address(RVA = "0x248D150", Offset = "0x248C550", Length = "0x1B1")]
	[Token(Token = "0x600152B")]
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

}

