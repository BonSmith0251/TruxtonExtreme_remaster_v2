namespace System.Xml.Schema;

[Token(Token = "0x2000178")]
internal abstract class DatatypeImplementation : XmlSchemaDatatype
{
	[Token(Token = "0x2000179")]
	private class SchemaDatatypeMap : IComparable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400080B")]
		private string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400080C")]
		private DatatypeImplementation type; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400080D")]
		private int parentIndex; //Field offset: 0x20

		[Token(Token = "0x1700040F")]
		public string Name
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000FAD")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000410")]
		public int ParentIndex
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[Token(Token = "0x6000FAE")]
			 get { } //Length: 4
		}

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x6000FAA")]
		internal SchemaDatatypeMap(string name, DatatypeImplementation type) { }

		[Address(RVA = "0x22AE270", Offset = "0x22AD670", Length = "0x5F")]
		[Token(Token = "0x6000FAB")]
		internal SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex) { }

		[Address(RVA = "0x234A270", Offset = "0x2349670", Length = "0x45")]
		[Token(Token = "0x6000FAF")]
		public override int CompareTo(object obj) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000FAD")]
		public string get_Name() { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000FAE")]
		public int get_ParentIndex() { }

		[Address(RVA = "0xF48BF0", Offset = "0xF47FF0", Length = "0x17")]
		[Token(Token = "0x6000FAC")]
		public static DatatypeImplementation op_Explicit(SchemaDatatypeMap sdm) { }

	}

	[Token(Token = "0x40007B5")]
	private static Hashtable builtinTypes; //Field offset: 0x0
	[Token(Token = "0x40007B6")]
	private static XmlSchemaSimpleType[] enumToTypeCode; //Field offset: 0x8
	[Token(Token = "0x40007B7")]
	private static XmlSchemaSimpleType anySimpleType; //Field offset: 0x10
	[Token(Token = "0x40007B8")]
	private static XmlSchemaSimpleType anyAtomicType; //Field offset: 0x18
	[Token(Token = "0x40007B9")]
	private static XmlSchemaSimpleType untypedAtomicType; //Field offset: 0x20
	[Token(Token = "0x40007BA")]
	private static XmlSchemaSimpleType yearMonthDurationType; //Field offset: 0x28
	[Token(Token = "0x40007BB")]
	private static XmlSchemaSimpleType dayTimeDurationType; //Field offset: 0x30
	[Token(Token = "0x40007BC")]
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; //Field offset: 0x38
	[Token(Token = "0x40007BD")]
	private static XmlSchemaSimpleType tokenTypeV1Compat; //Field offset: 0x40
	[Token(Token = "0x40007BE")]
	internal static XmlQualifiedName QnAnySimpleType; //Field offset: 0x48
	[Token(Token = "0x40007BF")]
	internal static XmlQualifiedName QnAnyType; //Field offset: 0x50
	[Token(Token = "0x40007C0")]
	internal static FacetsChecker stringFacetsChecker; //Field offset: 0x58
	[Token(Token = "0x40007C1")]
	internal static FacetsChecker miscFacetsChecker; //Field offset: 0x60
	[Token(Token = "0x40007C2")]
	internal static FacetsChecker numeric2FacetsChecker; //Field offset: 0x68
	[Token(Token = "0x40007C3")]
	internal static FacetsChecker binaryFacetsChecker; //Field offset: 0x70
	[Token(Token = "0x40007C4")]
	internal static FacetsChecker dateTimeFacetsChecker; //Field offset: 0x78
	[Token(Token = "0x40007C5")]
	internal static FacetsChecker durationFacetsChecker; //Field offset: 0x80
	[Token(Token = "0x40007C6")]
	internal static FacetsChecker listFacetsChecker; //Field offset: 0x88
	[Token(Token = "0x40007C7")]
	internal static FacetsChecker qnameFacetsChecker; //Field offset: 0x90
	[Token(Token = "0x40007C8")]
	internal static FacetsChecker unionFacetsChecker; //Field offset: 0x98
	[Token(Token = "0x40007C9")]
	private static readonly DatatypeImplementation c_anySimpleType; //Field offset: 0xA0
	[Token(Token = "0x40007CA")]
	private static readonly DatatypeImplementation c_anyURI; //Field offset: 0xA8
	[Token(Token = "0x40007CB")]
	private static readonly DatatypeImplementation c_base64Binary; //Field offset: 0xB0
	[Token(Token = "0x40007CC")]
	private static readonly DatatypeImplementation c_boolean; //Field offset: 0xB8
	[Token(Token = "0x40007CD")]
	private static readonly DatatypeImplementation c_byte; //Field offset: 0xC0
	[Token(Token = "0x40007CE")]
	private static readonly DatatypeImplementation c_char; //Field offset: 0xC8
	[Token(Token = "0x40007CF")]
	private static readonly DatatypeImplementation c_date; //Field offset: 0xD0
	[Token(Token = "0x40007D0")]
	private static readonly DatatypeImplementation c_dateTime; //Field offset: 0xD8
	[Token(Token = "0x40007D1")]
	private static readonly DatatypeImplementation c_dateTimeNoTz; //Field offset: 0xE0
	[Token(Token = "0x40007D2")]
	private static readonly DatatypeImplementation c_dateTimeTz; //Field offset: 0xE8
	[Token(Token = "0x40007D3")]
	private static readonly DatatypeImplementation c_day; //Field offset: 0xF0
	[Token(Token = "0x40007D4")]
	private static readonly DatatypeImplementation c_decimal; //Field offset: 0xF8
	[Token(Token = "0x40007D5")]
	private static readonly DatatypeImplementation c_double; //Field offset: 0x100
	[Token(Token = "0x40007D6")]
	private static readonly DatatypeImplementation c_doubleXdr; //Field offset: 0x108
	[Token(Token = "0x40007D7")]
	private static readonly DatatypeImplementation c_duration; //Field offset: 0x110
	[Token(Token = "0x40007D8")]
	private static readonly DatatypeImplementation c_ENTITY; //Field offset: 0x118
	[Token(Token = "0x40007D9")]
	private static readonly DatatypeImplementation c_ENTITIES; //Field offset: 0x120
	[Token(Token = "0x40007DA")]
	private static readonly DatatypeImplementation c_ENUMERATION; //Field offset: 0x128
	[Token(Token = "0x40007DB")]
	private static readonly DatatypeImplementation c_fixed; //Field offset: 0x130
	[Token(Token = "0x40007DC")]
	private static readonly DatatypeImplementation c_float; //Field offset: 0x138
	[Token(Token = "0x40007DD")]
	private static readonly DatatypeImplementation c_floatXdr; //Field offset: 0x140
	[Token(Token = "0x40007DE")]
	private static readonly DatatypeImplementation c_hexBinary; //Field offset: 0x148
	[Token(Token = "0x40007DF")]
	private static readonly DatatypeImplementation c_ID; //Field offset: 0x150
	[Token(Token = "0x40007E0")]
	private static readonly DatatypeImplementation c_IDREF; //Field offset: 0x158
	[Token(Token = "0x40007E1")]
	private static readonly DatatypeImplementation c_IDREFS; //Field offset: 0x160
	[Token(Token = "0x40007E2")]
	private static readonly DatatypeImplementation c_int; //Field offset: 0x168
	[Token(Token = "0x40007E3")]
	private static readonly DatatypeImplementation c_integer; //Field offset: 0x170
	[Token(Token = "0x40007E4")]
	private static readonly DatatypeImplementation c_language; //Field offset: 0x178
	[Token(Token = "0x40007E5")]
	private static readonly DatatypeImplementation c_long; //Field offset: 0x180
	[Token(Token = "0x40007E6")]
	private static readonly DatatypeImplementation c_month; //Field offset: 0x188
	[Token(Token = "0x40007E7")]
	private static readonly DatatypeImplementation c_monthDay; //Field offset: 0x190
	[Token(Token = "0x40007E8")]
	private static readonly DatatypeImplementation c_Name; //Field offset: 0x198
	[Token(Token = "0x40007E9")]
	private static readonly DatatypeImplementation c_NCName; //Field offset: 0x1A0
	[Token(Token = "0x40007EA")]
	private static readonly DatatypeImplementation c_negativeInteger; //Field offset: 0x1A8
	[Token(Token = "0x40007EB")]
	private static readonly DatatypeImplementation c_NMTOKEN; //Field offset: 0x1B0
	[Token(Token = "0x40007EC")]
	private static readonly DatatypeImplementation c_NMTOKENS; //Field offset: 0x1B8
	[Token(Token = "0x40007ED")]
	private static readonly DatatypeImplementation c_nonNegativeInteger; //Field offset: 0x1C0
	[Token(Token = "0x40007EE")]
	private static readonly DatatypeImplementation c_nonPositiveInteger; //Field offset: 0x1C8
	[Token(Token = "0x40007EF")]
	private static readonly DatatypeImplementation c_normalizedString; //Field offset: 0x1D0
	[Token(Token = "0x40007F0")]
	private static readonly DatatypeImplementation c_NOTATION; //Field offset: 0x1D8
	[Token(Token = "0x40007F1")]
	private static readonly DatatypeImplementation c_positiveInteger; //Field offset: 0x1E0
	[Token(Token = "0x40007F2")]
	private static readonly DatatypeImplementation c_QName; //Field offset: 0x1E8
	[Token(Token = "0x40007F3")]
	private static readonly DatatypeImplementation c_QNameXdr; //Field offset: 0x1F0
	[Token(Token = "0x40007F4")]
	private static readonly DatatypeImplementation c_short; //Field offset: 0x1F8
	[Token(Token = "0x40007F5")]
	private static readonly DatatypeImplementation c_string; //Field offset: 0x200
	[Token(Token = "0x40007F6")]
	private static readonly DatatypeImplementation c_time; //Field offset: 0x208
	[Token(Token = "0x40007F7")]
	private static readonly DatatypeImplementation c_timeNoTz; //Field offset: 0x210
	[Token(Token = "0x40007F8")]
	private static readonly DatatypeImplementation c_timeTz; //Field offset: 0x218
	[Token(Token = "0x40007F9")]
	private static readonly DatatypeImplementation c_token; //Field offset: 0x220
	[Token(Token = "0x40007FA")]
	private static readonly DatatypeImplementation c_unsignedByte; //Field offset: 0x228
	[Token(Token = "0x40007FB")]
	private static readonly DatatypeImplementation c_unsignedInt; //Field offset: 0x230
	[Token(Token = "0x40007FC")]
	private static readonly DatatypeImplementation c_unsignedLong; //Field offset: 0x238
	[Token(Token = "0x40007FD")]
	private static readonly DatatypeImplementation c_unsignedShort; //Field offset: 0x240
	[Token(Token = "0x40007FE")]
	private static readonly DatatypeImplementation c_uuid; //Field offset: 0x248
	[Token(Token = "0x40007FF")]
	private static readonly DatatypeImplementation c_year; //Field offset: 0x250
	[Token(Token = "0x4000800")]
	private static readonly DatatypeImplementation c_yearMonth; //Field offset: 0x258
	[Token(Token = "0x4000801")]
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; //Field offset: 0x260
	[Token(Token = "0x4000802")]
	internal static readonly DatatypeImplementation c_tokenV1Compat; //Field offset: 0x268
	[Token(Token = "0x4000803")]
	private static readonly DatatypeImplementation c_anyAtomicType; //Field offset: 0x270
	[Token(Token = "0x4000804")]
	private static readonly DatatypeImplementation c_dayTimeDuration; //Field offset: 0x278
	[Token(Token = "0x4000805")]
	private static readonly DatatypeImplementation c_untypedAtomicType; //Field offset: 0x280
	[Token(Token = "0x4000806")]
	private static readonly DatatypeImplementation c_yearMonthDuration; //Field offset: 0x288
	[Token(Token = "0x4000807")]
	private static readonly DatatypeImplementation[] c_tokenizedTypes; //Field offset: 0x290
	[Token(Token = "0x4000808")]
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; //Field offset: 0x298
	[Token(Token = "0x4000809")]
	private static readonly SchemaDatatypeMap[] c_XdrTypes; //Field offset: 0x2A0
	[Token(Token = "0x400080A")]
	private static readonly SchemaDatatypeMap[] c_XsdTypes; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007B0")]
	private XmlSchemaDatatypeVariety variety; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007B1")]
	private RestrictionFacets restriction; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007B2")]
	private DatatypeImplementation baseType; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007B3")]
	private XmlValueConverter valueConverter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007B4")]
	private XmlSchemaType parentSchemaType; //Field offset: 0x30

	[Token(Token = "0x17000400")]
	internal static XmlSchemaSimpleType AnySimpleType
	{
		[Address(RVA = "0x259DDB0", Offset = "0x259D1B0", Length = "0x4F")]
		[Token(Token = "0x6000F7F")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700040B")]
	protected DatatypeImplementation Base
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000FA0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700040E")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000FA3")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000402")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x259DE00", Offset = "0x259D200", Length = "0x4F")]
		[Token(Token = "0x6000F97")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000409")]
	internal virtual bool HasLexicalFacets
	{
		[Address(RVA = "0x259DE50", Offset = "0x259D250", Length = "0x1F")]
		[Token(Token = "0x6000F9E")]
		internal get { } //Length: 31
	}

	[Token(Token = "0x1700040A")]
	internal virtual bool HasValueFacets
	{
		[Address(RVA = "0x259DE70", Offset = "0x259D270", Length = "0x1F")]
		[Token(Token = "0x6000F9F")]
		internal get { } //Length: 31
	}

	[Token(Token = "0x1700040C")]
	internal abstract Type ListValueType
	{
		[Token(Token = "0x6000FA1")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000408")]
	internal virtual RestrictionFacets Restriction
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000F9D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000404")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x9DCC70", Offset = "0x9DC070", Length = "0x6")]
		[Token(Token = "0x6000F99")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000407")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000F9C")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000401")]
	internal static XmlSchemaSimpleType UntypedAtomicType
	{
		[Address(RVA = "0x259DE90", Offset = "0x259D290", Length = "0x4F")]
		[Token(Token = "0x6000F80")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700040D")]
	internal abstract RestrictionFlags ValidRestrictionFlags
	{
		[Token(Token = "0x6000FA2")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000403")]
	internal virtual XmlValueConverter ValueConverter
	{
		[Address(RVA = "0x259DEE0", Offset = "0x259D2E0", Length = "0x4B")]
		[Token(Token = "0x6000F98")]
		internal get { } //Length: 75
	}

	[Token(Token = "0x17000405")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x24FB740", Offset = "0x24FAB40", Length = "0x32")]
		[Token(Token = "0x6000F9A")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000406")]
	public virtual XmlSchemaDatatypeVariety Variety
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000F9B")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x2597B40", Offset = "0x2596F40", Length = "0x626F")]
	[Token(Token = "0x6000F7E")]
	private static DatatypeImplementation() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000FA9")]
	protected DatatypeImplementation() { }

	[Address(RVA = "0x25950D0", Offset = "0x25944D0", Length = "0x87")]
	[Token(Token = "0x6000FA8")]
	protected int Compare(Byte[] value1, Byte[] value2) { }

	[Address(RVA = "0x2595160", Offset = "0x2594560", Length = "0xC07")]
	[Token(Token = "0x6000F87")]
	internal static void CreateBuiltinTypes() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000F96")]
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x2595D80", Offset = "0x2595180", Length = "0x2F7")]
	[Token(Token = "0x6000F90")]
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	[Address(RVA = "0x2595D70", Offset = "0x2595170", Length = "0xD")]
	[Token(Token = "0x6000F8F")]
	internal virtual XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	[Address(RVA = "0x2596080", Offset = "0x2595480", Length = "0x13F")]
	[Token(Token = "0x6000F8E")]
	internal virtual XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	[Address(RVA = "0x25961C0", Offset = "0x25955C0", Length = "0x12C")]
	[Token(Token = "0x6000F91")]
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	[Address(RVA = "0x25962F0", Offset = "0x25956F0", Length = "0x280")]
	[Token(Token = "0x6000F86")]
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	[Address(RVA = "0x2596580", Offset = "0x2595980", Length = "0xC2")]
	[Token(Token = "0x6000F84")]
	private static DatatypeImplementation FromTypeName(string name) { }

	[Address(RVA = "0x2596650", Offset = "0x2595A50", Length = "0xC2")]
	[Token(Token = "0x6000F83")]
	internal static DatatypeImplementation FromXdrName(string name) { }

	[Address(RVA = "0x25967A0", Offset = "0x2595BA0", Length = "0x72")]
	[Token(Token = "0x6000F81")]
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	[Address(RVA = "0x2596720", Offset = "0x2595B20", Length = "0x72")]
	[Token(Token = "0x6000F82")]
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	[Address(RVA = "0x259DDB0", Offset = "0x259D1B0", Length = "0x4F")]
	[Token(Token = "0x6000F7F")]
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000FA0")]
	protected DatatypeImplementation get_Base() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000FA3")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x259DE00", Offset = "0x259D200", Length = "0x4F")]
	[Token(Token = "0x6000F97")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x259DE50", Offset = "0x259D250", Length = "0x1F")]
	[Token(Token = "0x6000F9E")]
	internal virtual bool get_HasLexicalFacets() { }

	[Address(RVA = "0x259DE70", Offset = "0x259D270", Length = "0x1F")]
	[Token(Token = "0x6000F9F")]
	internal virtual bool get_HasValueFacets() { }

	[Token(Token = "0x6000FA1")]
	internal abstract Type get_ListValueType() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000F9D")]
	internal virtual RestrictionFacets get_Restriction() { }

	[Address(RVA = "0x9DCC70", Offset = "0x9DC070", Length = "0x6")]
	[Token(Token = "0x6000F99")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000F9C")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x259DE90", Offset = "0x259D290", Length = "0x4F")]
	[Token(Token = "0x6000F80")]
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	[Token(Token = "0x6000FA2")]
	internal abstract RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x259DEE0", Offset = "0x259D2E0", Length = "0x4B")]
	[Token(Token = "0x6000F98")]
	internal virtual XmlValueConverter get_ValueConverter() { }

	[Address(RVA = "0x24FB740", Offset = "0x24FAB40", Length = "0x32")]
	[Token(Token = "0x6000F9A")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000F9B")]
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	[Address(RVA = "0x2596820", Offset = "0x2595C20", Length = "0x4F")]
	[Token(Token = "0x6000F8C")]
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	[Address(RVA = "0x2596870", Offset = "0x2595C70", Length = "0x1F4")]
	[Token(Token = "0x6000F8A")]
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	[Address(RVA = "0x2596A70", Offset = "0x2595E70", Length = "0x153")]
	[Token(Token = "0x6000F8D")]
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	[Address(RVA = "0x2596BD0", Offset = "0x2595FD0", Length = "0x6F")]
	[Token(Token = "0x6000F88")]
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	[Address(RVA = "0x2596C40", Offset = "0x2596040", Length = "0xBF")]
	[Token(Token = "0x6000F89")]
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	[Address(RVA = "0x2596D00", Offset = "0x2596100", Length = "0x1F4")]
	[Token(Token = "0x6000F8B")]
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	[Address(RVA = "0x2596F00", Offset = "0x2596300", Length = "0x7D")]
	[Token(Token = "0x6000FA7")]
	internal string GetTypeName() { }

	[Address(RVA = "0x2596F80", Offset = "0x2596380", Length = "0xF9")]
	[Token(Token = "0x6000F95")]
	internal virtual bool IsComparable(XmlSchemaDatatype dtype) { }

	[Address(RVA = "0x2597080", Offset = "0x2596480", Length = "0x2BB")]
	[Token(Token = "0x6000F93")]
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x2597340", Offset = "0x2596740", Length = "0x21")]
	[Token(Token = "0x6000F94")]
	internal virtual bool IsEqual(object o1, object o2) { }

	[Address(RVA = "0x2597510", Offset = "0x2596910", Length = "0x208")]
	[Token(Token = "0x6000FA4")]
	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	[Address(RVA = "0x2597370", Offset = "0x2596770", Length = "0x192")]
	[Token(Token = "0x6000FA5")]
	internal virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	[Address(RVA = "0x2597720", Offset = "0x2596B20", Length = "0xDB")]
	[Token(Token = "0x6000F85")]
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	[Address(RVA = "0x2597800", Offset = "0x2596C00", Length = "0x33D")]
	[Token(Token = "0x6000FA6")]
	internal virtual Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000F92")]
	internal virtual void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

}

