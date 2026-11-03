namespace System.Xml;

[Token(Token = "0x20000BB")]
internal class DtdParser : IDtdParser
{
	[Token(Token = "0x20000BE")]
	private enum LiteralType : int
	{
		AttributeValue = 0,
		EntityReplText = 1,
		SystemOrPublicID = 2,
	}

	[Token(Token = "0x20000C0")]
	private class ParseElementOnlyContent_LocalFrame
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400053C")]
		public int startParenEntityId; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400053D")]
		public Token parsingSchema; //Field offset: 0x14

		[Address(RVA = "0x2542BA0", Offset = "0x2541FA0", Length = "0x2B")]
		[Token(Token = "0x6000A65")]
		public ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam) { }

	}

	[Token(Token = "0x20000BD")]
	private enum ScanningFunction : int
	{
		SubsetContent = 0,
		Name = 1,
		QName = 2,
		Nmtoken = 3,
		Doctype1 = 4,
		Doctype2 = 5,
		Element1 = 6,
		Element2 = 7,
		Element3 = 8,
		Element4 = 9,
		Element5 = 10,
		Element6 = 11,
		Element7 = 12,
		Attlist1 = 13,
		Attlist2 = 14,
		Attlist3 = 15,
		Attlist4 = 16,
		Attlist5 = 17,
		Attlist6 = 18,
		Attlist7 = 19,
		Entity1 = 20,
		Entity2 = 21,
		Entity3 = 22,
		Notation1 = 23,
		CondSection1 = 24,
		CondSection2 = 25,
		CondSection3 = 26,
		Literal = 27,
		SystemId = 28,
		PublicId1 = 29,
		PublicId2 = 30,
		ClosingTag = 31,
		ParamEntitySpace = 32,
		None = 33,
	}

	[Token(Token = "0x20000BC")]
	private enum Token : int
	{
		CDATA = 0,
		ID = 1,
		IDREF = 2,
		IDREFS = 3,
		ENTITY = 4,
		ENTITIES = 5,
		NMTOKEN = 6,
		NMTOKENS = 7,
		NOTATION = 8,
		None = 9,
		PERef = 10,
		AttlistDecl = 11,
		ElementDecl = 12,
		EntityDecl = 13,
		NotationDecl = 14,
		Comment = 15,
		PI = 16,
		CondSectionStart = 17,
		CondSectionEnd = 18,
		Eof = 19,
		REQUIRED = 20,
		IMPLIED = 21,
		FIXED = 22,
		QName = 23,
		Name = 24,
		Nmtoken = 25,
		Quote = 26,
		LeftParen = 27,
		RightParen = 28,
		GreaterThan = 29,
		Or = 30,
		LeftBracket = 31,
		RightBracket = 32,
		PUBLIC = 33,
		SYSTEM = 34,
		Literal = 35,
		DOCTYPE = 36,
		NData = 37,
		Percent = 38,
		Star = 39,
		QMark = 40,
		Plus = 41,
		PCDATA = 42,
		Comma = 43,
		ANY = 44,
		EMPTY = 45,
		IGNORE = 46,
		INCLUDE = 47,
	}

	[Token(Token = "0x20000BF")]
	private class UndeclaredNotation
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000538")]
		internal string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000539")]
		internal int lineNo; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400053A")]
		internal int linePos; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400053B")]
		internal UndeclaredNotation next; //Field offset: 0x20

		[Address(RVA = "0x254C400", Offset = "0x254B800", Length = "0x64")]
		[Token(Token = "0x6000A64")]
		internal UndeclaredNotation(string name, int lineNo, int linePos) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004BF")]
	private IDtdParserAdapter readerAdapter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004C0")]
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004C1")]
	private XmlNameTable nameTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004C2")]
	private SchemaInfo schemaInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004C3")]
	private XmlCharType xmlCharType; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004C4")]
	private string systemId; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004C5")]
	private string publicId; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004C6")]
	private bool normalize; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x40004C7")]
	private bool validate; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[Token(Token = "0x40004C8")]
	private bool supportNamespaces; //Field offset: 0x4A
	[FieldOffset(Offset = "0x4B")]
	[Token(Token = "0x40004C9")]
	private bool v1Compat; //Field offset: 0x4B
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004CA")]
	private Char[] chars; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004CB")]
	private int charsUsed; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40004CC")]
	private int curPos; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004CD")]
	private ScanningFunction scanningFunction; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40004CE")]
	private ScanningFunction nextScaningFunction; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004CF")]
	private ScanningFunction savedScanningFunction; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40004D0")]
	private bool whitespaceSeen; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40004D1")]
	private int tokenStartPos; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40004D2")]
	private int colonPos; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40004D3")]
	private StringBuilder internalSubsetValueSb; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40004D4")]
	private int externalEntitiesDepth; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40004D5")]
	private int currentEntityId; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40004D6")]
	private bool freeFloatingDtd; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[Token(Token = "0x40004D7")]
	private bool hasFreeFloatingInternalSubset; //Field offset: 0x89
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40004D8")]
	private StringBuilder stringBuilder; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40004D9")]
	private int condSectionDepth; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40004DA")]
	private LineInfo literalLineInfo; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40004DB")]
	private char literalQuoteChar; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40004DC")]
	private string documentBaseUri; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40004DD")]
	private string externalDtdBaseUri; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40004DE")]
	private Dictionary<String, UndeclaredNotation> undeclaredNotations; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40004DF")]
	private Int32[] condSectionEntityIds; //Field offset: 0xC0

	[Token(Token = "0x170002C5")]
	private string BaseUriStr
	{
		[Address(RVA = "0x2535960", Offset = "0x2534D60", Length = "0xB1")]
		[Token(Token = "0x6000A58")]
		private get { } //Length: 177
	}

	[Token(Token = "0x170002BE")]
	private bool IgnoreEntityReferences
	{
		[Address(RVA = "0x2535A20", Offset = "0x2534E20", Length = "0x8")]
		[Token(Token = "0x6000A03")]
		private get { } //Length: 8
	}

	[Token(Token = "0x170002C3")]
	private int LineNo
	{
		[Address(RVA = "0x2535A30", Offset = "0x2534E30", Length = "0x49")]
		[Token(Token = "0x6000A56")]
		private get { } //Length: 73
	}

	[Token(Token = "0x170002C4")]
	private int LinePos
	{
		[Address(RVA = "0x2535A80", Offset = "0x2534E80", Length = "0x5A")]
		[Token(Token = "0x6000A57")]
		private get { } //Length: 90
	}

	[Token(Token = "0x170002C2")]
	private bool Normalize
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[Token(Token = "0x6000A07")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170002BD")]
	private bool ParsingInternalSubset
	{
		[Address(RVA = "0x2535AE0", Offset = "0x2534EE0", Length = "0xB")]
		[Token(Token = "0x6000A02")]
		private get { } //Length: 11
	}

	[Token(Token = "0x170002C0")]
	private bool ParsingTopLevelMarkup
	{
		[Address(RVA = "0x2535AF0", Offset = "0x2534EF0", Length = "0x1A")]
		[Token(Token = "0x6000A05")]
		private get { } //Length: 26
	}

	[Token(Token = "0x170002BF")]
	private bool SaveInternalSubsetValue
	{
		[Address(RVA = "0x2535B10", Offset = "0x2534F10", Length = "0x5E")]
		[Token(Token = "0x6000A04")]
		private get { } //Length: 94
	}

	[Token(Token = "0x170002C1")]
	private bool SupportNamespaces
	{
		[Address(RVA = "0x24F8BD0", Offset = "0x24F7FD0", Length = "0x5")]
		[Token(Token = "0x6000A06")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x2535880", Offset = "0x2534C80", Length = "0xD1")]
	[Token(Token = "0x60009FC")]
	private DtdParser() { }

	[Address(RVA = "0x2529DB0", Offset = "0x25291B0", Length = "0x20C")]
	[Token(Token = "0x6000A17")]
	private void AddUndeclaredNotation(string notationName) { }

	[Address(RVA = "0x2529FC0", Offset = "0x25293C0", Length = "0xFD")]
	[Token(Token = "0x60009FD")]
	internal static IDtdParser Create() { }

	[Address(RVA = "0x252A0C0", Offset = "0x25294C0", Length = "0xB9")]
	[Token(Token = "0x6000A43")]
	private bool EatPublicKeyword() { }

	[Address(RVA = "0x252A180", Offset = "0x2529580", Length = "0xB9")]
	[Token(Token = "0x6000A44")]
	private bool EatSystemKeyword() { }

	[Address(RVA = "0x2535960", Offset = "0x2534D60", Length = "0xB1")]
	[Token(Token = "0x6000A58")]
	private string get_BaseUriStr() { }

	[Address(RVA = "0x2535A20", Offset = "0x2534E20", Length = "0x8")]
	[Token(Token = "0x6000A03")]
	private bool get_IgnoreEntityReferences() { }

	[Address(RVA = "0x2535A30", Offset = "0x2534E30", Length = "0x49")]
	[Token(Token = "0x6000A56")]
	private int get_LineNo() { }

	[Address(RVA = "0x2535A80", Offset = "0x2534E80", Length = "0x5A")]
	[Token(Token = "0x6000A57")]
	private int get_LinePos() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[Token(Token = "0x6000A07")]
	private bool get_Normalize() { }

	[Address(RVA = "0x2535AE0", Offset = "0x2534EE0", Length = "0xB")]
	[Token(Token = "0x6000A02")]
	private bool get_ParsingInternalSubset() { }

	[Address(RVA = "0x2535AF0", Offset = "0x2534EF0", Length = "0x1A")]
	[Token(Token = "0x6000A05")]
	private bool get_ParsingTopLevelMarkup() { }

	[Address(RVA = "0x2535B10", Offset = "0x2534F10", Length = "0x5E")]
	[Token(Token = "0x6000A04")]
	private bool get_SaveInternalSubsetValue() { }

	[Address(RVA = "0x24F8BD0", Offset = "0x24F7FD0", Length = "0x5")]
	[Token(Token = "0x6000A06")]
	private bool get_SupportNamespaces() { }

	[Address(RVA = "0x252A240", Offset = "0x2529640", Length = "0x1AA")]
	[Token(Token = "0x6000A45")]
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	[Address(RVA = "0x252A3F0", Offset = "0x25297F0", Length = "0x29")]
	[Token(Token = "0x6000A46")]
	private string GetNameString() { }

	[Address(RVA = "0x252A3F0", Offset = "0x25297F0", Length = "0x29")]
	[Token(Token = "0x6000A47")]
	private string GetNmtokenString() { }

	[Address(RVA = "0x252A420", Offset = "0x2529820", Length = "0x12A8")]
	[Token(Token = "0x6000A1C")]
	private Token GetToken(bool needWhiteSpace) { }

	[Address(RVA = "0x252B7E0", Offset = "0x252ABE0", Length = "0x73")]
	[Token(Token = "0x6000A48")]
	private string GetValue() { }

	[Address(RVA = "0x252B750", Offset = "0x252AB50", Length = "0x85")]
	[Token(Token = "0x6000A49")]
	private string GetValueWithStrippedSpaces() { }

	[Address(RVA = "0x252B860", Offset = "0x252AC60", Length = "0x15A")]
	[Token(Token = "0x6000A50")]
	private bool HandleEntityEnd(bool inLiteral) { }

	[Address(RVA = "0x252BCB0", Offset = "0x252B0B0", Length = "0x61")]
	[Token(Token = "0x6000A4E")]
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	[Address(RVA = "0x252B9C0", Offset = "0x252ADC0", Length = "0x2E5")]
	[Token(Token = "0x6000A4F")]
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	[Address(RVA = "0x252C130", Offset = "0x252B530", Length = "0x2B7")]
	[Token(Token = "0x60009FE")]
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	[Address(RVA = "0x252BD20", Offset = "0x252B120", Length = "0x401")]
	[Token(Token = "0x60009FF")]
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	[Address(RVA = "0x252C3F0", Offset = "0x252B7F0", Length = "0xE")]
	[Token(Token = "0x6000A55")]
	private bool IsAttributeValueType(Token token) { }

	[Address(RVA = "0x252C400", Offset = "0x252B800", Length = "0x10E")]
	[Token(Token = "0x6000A4B")]
	private void LoadParsingBuffer() { }

	[Address(RVA = "0x252C510", Offset = "0x252B910", Length = "0x57")]
	[Token(Token = "0x6000A59")]
	private void OnUnexpectedError() { }

	[Address(RVA = "0x252FD30", Offset = "0x252F130", Length = "0x28A")]
	[Token(Token = "0x6000A08")]
	private void Parse(bool saveInternalSubset) { }

	[Address(RVA = "0x252C570", Offset = "0x252B970", Length = "0x614")]
	[Token(Token = "0x6000A0E")]
	private void ParseAttlistDecl() { }

	[Address(RVA = "0x252CB90", Offset = "0x252BF90", Length = "0x26D")]
	[Token(Token = "0x6000A10")]
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	[Address(RVA = "0x252CE00", Offset = "0x252C200", Length = "0x705")]
	[Token(Token = "0x6000A0F")]
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	[Address(RVA = "0x252D510", Offset = "0x252C910", Length = "0x190")]
	[Token(Token = "0x6000A18")]
	private void ParseComment() { }

	[Address(RVA = "0x252D6B0", Offset = "0x252CAB0", Length = "0x2B0")]
	[Token(Token = "0x6000A1A")]
	private void ParseCondSection() { }

	[Address(RVA = "0x252D970", Offset = "0x252CD70", Length = "0x45A")]
	[Token(Token = "0x6000A11")]
	private void ParseElementDecl() { }

	[Address(RVA = "0x252DDD0", Offset = "0x252D1D0", Length = "0x2D1")]
	[Token(Token = "0x6000A14")]
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	[Address(RVA = "0x252E0B0", Offset = "0x252D4B0", Length = "0x3EF")]
	[Token(Token = "0x6000A12")]
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	[Address(RVA = "0x252E4A0", Offset = "0x252D8A0", Length = "0x3E7")]
	[Token(Token = "0x6000A15")]
	private void ParseEntityDecl() { }

	[Address(RVA = "0x252E890", Offset = "0x252DC90", Length = "0x496")]
	[Token(Token = "0x6000A1B")]
	private void ParseExternalId(Token idTokenType, Token declType, out string publicId, out string systemId) { }

	[Address(RVA = "0x252ED30", Offset = "0x252E130", Length = "0x192")]
	[Token(Token = "0x6000A0C")]
	private void ParseExternalSubset() { }

	[Address(RVA = "0x252EED0", Offset = "0x252E2D0", Length = "0x57")]
	[Token(Token = "0x6000A0A")]
	private void ParseFreeFloatingDtd() { }

	[Address(RVA = "0x252EF30", Offset = "0x252E330", Length = "0x69")]
	[Token(Token = "0x6000A13")]
	private void ParseHowMany(ParticleContentValidator pcv) { }

	[Address(RVA = "0x252EFA0", Offset = "0x252E3A0", Length = "0x1F3")]
	[Token(Token = "0x6000A09")]
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	[Address(RVA = "0x252F1A0", Offset = "0x252E5A0", Length = "0x7")]
	[Token(Token = "0x6000A0B")]
	private void ParseInternalSubset() { }

	[Address(RVA = "0x252F1B0", Offset = "0x252E5B0", Length = "0x2E3")]
	[Token(Token = "0x6000A16")]
	private void ParseNotationDecl() { }

	[Address(RVA = "0x252F4A0", Offset = "0x252E8A0", Length = "0xF6")]
	[Token(Token = "0x6000A19")]
	private void ParsePI() { }

	[Address(RVA = "0x252F5A0", Offset = "0x252E9A0", Length = "0x67C")]
	[Token(Token = "0x6000A0D")]
	private void ParseSubset() { }

	[Address(RVA = "0x252FC40", Offset = "0x252F040", Length = "0xEA")]
	[Token(Token = "0x6000A62")]
	private string ParseUnexpectedToken(int startPos) { }

	[Address(RVA = "0x2530000", Offset = "0x252F400", Length = "0x70")]
	[Token(Token = "0x6000A4A")]
	private int ReadData() { }

	[Address(RVA = "0x252FFC0", Offset = "0x252F3C0", Length = "0x3C")]
	[Token(Token = "0x6000A41")]
	private bool ReadDataInName() { }

	[Address(RVA = "0x2530170", Offset = "0x252F570", Length = "0xB")]
	[Token(Token = "0x6000A4C")]
	private void SaveParsingBuffer() { }

	[Address(RVA = "0x2530080", Offset = "0x252F480", Length = "0xE2")]
	[Token(Token = "0x6000A4D")]
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	[Address(RVA = "0x2530180", Offset = "0x252F580", Length = "0xC5")]
	[Token(Token = "0x6000A2B")]
	private Token ScanAttlist1() { }

	[Address(RVA = "0x2530250", Offset = "0x252F650", Length = "0x7A2")]
	[Token(Token = "0x6000A2C")]
	private Token ScanAttlist2() { }

	[Address(RVA = "0x2530A00", Offset = "0x252FE00", Length = "0x92")]
	[Token(Token = "0x6000A2D")]
	private Token ScanAttlist3() { }

	[Address(RVA = "0x2530AA0", Offset = "0x252FEA0", Length = "0xCA")]
	[Token(Token = "0x6000A2E")]
	private Token ScanAttlist4() { }

	[Address(RVA = "0x2530B70", Offset = "0x252FF70", Length = "0xCA")]
	[Token(Token = "0x6000A2F")]
	private Token ScanAttlist5() { }

	[Address(RVA = "0x2530C40", Offset = "0x2530040", Length = "0x480")]
	[Token(Token = "0x6000A30")]
	private Token ScanAttlist6() { }

	[Address(RVA = "0x25310D0", Offset = "0x25304D0", Length = "0xAB")]
	[Token(Token = "0x6000A31")]
	private Token ScanAttlist7() { }

	[Address(RVA = "0x2531180", Offset = "0x2530580", Length = "0x7D")]
	[Token(Token = "0x6000A23")]
	private Token ScanClosingTag() { }

	[Address(RVA = "0x2531200", Offset = "0x2530600", Length = "0x35B")]
	[Token(Token = "0x6000A3B")]
	private Token ScanCondSection1() { }

	[Address(RVA = "0x2531560", Offset = "0x2530960", Length = "0x7C")]
	[Token(Token = "0x6000A3C")]
	private Token ScanCondSection2() { }

	[Address(RVA = "0x25315E0", Offset = "0x25309E0", Length = "0x5FF")]
	[Token(Token = "0x6000A3D")]
	private Token ScanCondSection3() { }

	[Address(RVA = "0x2531BE0", Offset = "0x2530FE0", Length = "0x178")]
	[Token(Token = "0x6000A21")]
	private Token ScanDoctype1() { }

	[Address(RVA = "0x2531D60", Offset = "0x2531160", Length = "0xB4")]
	[Token(Token = "0x6000A22")]
	private Token ScanDoctype2() { }

	[Address(RVA = "0x2531E20", Offset = "0x2531220", Length = "0x275")]
	[Token(Token = "0x6000A24")]
	private Token ScanElement1() { }

	[Address(RVA = "0x25320A0", Offset = "0x25314A0", Length = "0x218")]
	[Token(Token = "0x6000A25")]
	private Token ScanElement2() { }

	[Address(RVA = "0x25322C0", Offset = "0x25316C0", Length = "0x7B")]
	[Token(Token = "0x6000A26")]
	private Token ScanElement3() { }

	[Address(RVA = "0x2532340", Offset = "0x2531740", Length = "0xD2")]
	[Token(Token = "0x6000A27")]
	private Token ScanElement4() { }

	[Address(RVA = "0x2532420", Offset = "0x2531820", Length = "0xF8")]
	[Token(Token = "0x6000A28")]
	private Token ScanElement5() { }

	[Address(RVA = "0x2532520", Offset = "0x2531920", Length = "0xCA")]
	[Token(Token = "0x6000A29")]
	private Token ScanElement6() { }

	[Address(RVA = "0x25325F0", Offset = "0x25319F0", Length = "0x4D")]
	[Token(Token = "0x6000A2A")]
	private Token ScanElement7() { }

	[Address(RVA = "0x2532640", Offset = "0x2531A40", Length = "0x69")]
	[Token(Token = "0x6000A36")]
	private Token ScanEntity1() { }

	[Address(RVA = "0x25326B0", Offset = "0x2531AB0", Length = "0x17C")]
	[Token(Token = "0x6000A37")]
	private Token ScanEntity2() { }

	[Address(RVA = "0x2532830", Offset = "0x2531C30", Length = "0xF7")]
	[Token(Token = "0x6000A38")]
	private Token ScanEntity3() { }

	[Address(RVA = "0x2532930", Offset = "0x2531D30", Length = "0x100")]
	[Token(Token = "0x6000A33")]
	private XmlQualifiedName ScanEntityName() { }

	[Address(RVA = "0x2532A40", Offset = "0x2531E40", Length = "0xDE4")]
	[Token(Token = "0x6000A32")]
	private Token ScanLiteral(LiteralType literalType) { }

	[Address(RVA = "0x2533870", Offset = "0x2532C70", Length = "0xA")]
	[Token(Token = "0x6000A3E")]
	private void ScanName() { }

	[Address(RVA = "0x2533840", Offset = "0x2532C40", Length = "0x24")]
	[Token(Token = "0x6000A1E")]
	private Token ScanNameExpected() { }

	[Address(RVA = "0x25338B0", Offset = "0x2532CB0", Length = "0x1C9")]
	[Token(Token = "0x6000A42")]
	private void ScanNmtoken() { }

	[Address(RVA = "0x2533880", Offset = "0x2532C80", Length = "0x21")]
	[Token(Token = "0x6000A20")]
	private Token ScanNmtokenExpected() { }

	[Address(RVA = "0x2533A80", Offset = "0x2532E80", Length = "0x13E")]
	[Token(Token = "0x6000A34")]
	private Token ScanNotation1() { }

	[Address(RVA = "0x2533BC0", Offset = "0x2532FC0", Length = "0xA6")]
	[Token(Token = "0x6000A39")]
	private Token ScanPublicId1() { }

	[Address(RVA = "0x2533C70", Offset = "0x2533070", Length = "0x6C")]
	[Token(Token = "0x6000A3A")]
	private Token ScanPublicId2() { }

	[Address(RVA = "0x2533D10", Offset = "0x2533110", Length = "0x276")]
	[Token(Token = "0x6000A40")]
	private void ScanQName(bool isQName) { }

	[Address(RVA = "0x2533F90", Offset = "0x2533390", Length = "0xC")]
	[Token(Token = "0x6000A3F")]
	private void ScanQName() { }

	[Address(RVA = "0x2533CE0", Offset = "0x25330E0", Length = "0x26")]
	[Token(Token = "0x6000A1F")]
	private Token ScanQNameExpected() { }

	[Address(RVA = "0x2533FA0", Offset = "0x25333A0", Length = "0x85F")]
	[Token(Token = "0x6000A1D")]
	private Token ScanSubsetContent() { }

	[Address(RVA = "0x2534800", Offset = "0x2533C00", Length = "0xA5")]
	[Token(Token = "0x6000A35")]
	private Token ScanSystemId() { }

	[Address(RVA = "0x2534A10", Offset = "0x2533E10", Length = "0x132")]
	[Token(Token = "0x6000A53")]
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	[Address(RVA = "0x25348B0", Offset = "0x2533CB0", Length = "0x152")]
	[Token(Token = "0x6000A52")]
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	[Address(RVA = "0x2534B50", Offset = "0x2533F50", Length = "0xFB")]
	[Token(Token = "0x6000A54")]
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	[Address(RVA = "0x2534C50", Offset = "0x2534050", Length = "0x1DA")]
	[Token(Token = "0x6000A63")]
	internal static string StripSpaces(string value) { }

	[Address(RVA = "0x2534E30", Offset = "0x2534230", Length = "0x4F")]
	[Token(Token = "0x6000A01")]
	private override IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	[Address(RVA = "0x2534E80", Offset = "0x2534280", Length = "0x36")]
	[Token(Token = "0x6000A00")]
	private override IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	[Address(RVA = "0x2535150", Offset = "0x2534550", Length = "0x28")]
	[Token(Token = "0x6000A5A")]
	private void Throw(int curPos, string res) { }

	[Address(RVA = "0x2535180", Offset = "0x2534580", Length = "0x1BC")]
	[Token(Token = "0x6000A5B")]
	private void Throw(int curPos, string res, string arg) { }

	[Address(RVA = "0x2535480", Offset = "0x2534880", Length = "0x1BC")]
	[Token(Token = "0x6000A5C")]
	private void Throw(int curPos, string res, String[] args) { }

	[Address(RVA = "0x2535340", Offset = "0x2534740", Length = "0x13B")]
	[Token(Token = "0x6000A5D")]
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	[Address(RVA = "0x2534F40", Offset = "0x2534340", Length = "0x79")]
	[Token(Token = "0x6000A5E")]
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	[Address(RVA = "0x2534EC0", Offset = "0x25342C0", Length = "0x7D")]
	[Token(Token = "0x6000A5F")]
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	[Address(RVA = "0x2534FC0", Offset = "0x25343C0", Length = "0x1A")]
	[Token(Token = "0x6000A60")]
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	[Address(RVA = "0x2534FE0", Offset = "0x25343E0", Length = "0x16B")]
	[Token(Token = "0x6000A61")]
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	[Address(RVA = "0x2535640", Offset = "0x2534A40", Length = "0x234")]
	[Token(Token = "0x6000A51")]
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

}

