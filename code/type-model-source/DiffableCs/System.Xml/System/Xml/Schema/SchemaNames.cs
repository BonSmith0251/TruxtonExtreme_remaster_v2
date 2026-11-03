namespace System.Xml.Schema;

[Token(Token = "0x20001DE")]
internal sealed class SchemaNames
{
	[Token(Token = "0x20001DF")]
	internal enum Token : int
	{
		Empty = 0,
		SchemaName = 1,
		SchemaType = 2,
		SchemaMaxOccurs = 3,
		SchemaMinOccurs = 4,
		SchemaInfinite = 5,
		SchemaModel = 6,
		SchemaOpen = 7,
		SchemaClosed = 8,
		SchemaContent = 9,
		SchemaMixed = 10,
		SchemaEmpty = 11,
		SchemaElementOnly = 12,
		SchemaTextOnly = 13,
		SchemaOrder = 14,
		SchemaSeq = 15,
		SchemaOne = 16,
		SchemaMany = 17,
		SchemaRequired = 18,
		SchemaYes = 19,
		SchemaNo = 20,
		SchemaString = 21,
		SchemaId = 22,
		SchemaIdref = 23,
		SchemaIdrefs = 24,
		SchemaEntity = 25,
		SchemaEntities = 26,
		SchemaNmtoken = 27,
		SchemaNmtokens = 28,
		SchemaEnumeration = 29,
		SchemaDefault = 30,
		XdrRoot = 31,
		XdrElementType = 32,
		XdrElement = 33,
		XdrGroup = 34,
		XdrAttributeType = 35,
		XdrAttribute = 36,
		XdrDatatype = 37,
		XdrDescription = 38,
		XdrExtends = 39,
		SchemaXdrRootAlias = 40,
		SchemaDtType = 41,
		SchemaDtValues = 42,
		SchemaDtMaxLength = 43,
		SchemaDtMinLength = 44,
		SchemaDtMax = 45,
		SchemaDtMin = 46,
		SchemaDtMinExclusive = 47,
		SchemaDtMaxExclusive = 48,
		SchemaTargetNamespace = 49,
		SchemaVersion = 50,
		SchemaFinalDefault = 51,
		SchemaBlockDefault = 52,
		SchemaFixed = 53,
		SchemaAbstract = 54,
		SchemaBlock = 55,
		SchemaSubstitutionGroup = 56,
		SchemaFinal = 57,
		SchemaNillable = 58,
		SchemaRef = 59,
		SchemaBase = 60,
		SchemaDerivedBy = 61,
		SchemaNamespace = 62,
		SchemaProcessContents = 63,
		SchemaRefer = 64,
		SchemaPublic = 65,
		SchemaSystem = 66,
		SchemaSchemaLocation = 67,
		SchemaValue = 68,
		SchemaSource = 69,
		SchemaAttributeFormDefault = 70,
		SchemaElementFormDefault = 71,
		SchemaUse = 72,
		SchemaForm = 73,
		XsdSchema = 74,
		XsdAnnotation = 75,
		XsdInclude = 76,
		XsdImport = 77,
		XsdElement = 78,
		XsdAttribute = 79,
		xsdAttributeGroup = 80,
		XsdAnyAttribute = 81,
		XsdGroup = 82,
		XsdAll = 83,
		XsdChoice = 84,
		XsdSequence = 85,
		XsdAny = 86,
		XsdNotation = 87,
		XsdSimpleType = 88,
		XsdComplexType = 89,
		XsdUnique = 90,
		XsdKey = 91,
		XsdKeyref = 92,
		XsdSelector = 93,
		XsdField = 94,
		XsdMinExclusive = 95,
		XsdMinInclusive = 96,
		XsdMaxExclusive = 97,
		XsdMaxInclusive = 98,
		XsdTotalDigits = 99,
		XsdFractionDigits = 100,
		XsdLength = 101,
		XsdMinLength = 102,
		XsdMaxLength = 103,
		XsdEnumeration = 104,
		XsdPattern = 105,
		XsdDocumentation = 106,
		XsdAppInfo = 107,
		XsdComplexContent = 108,
		XsdComplexContentExtension = 109,
		XsdComplexContentRestriction = 110,
		XsdSimpleContent = 111,
		XsdSimpleContentExtension = 112,
		XsdSimpleContentRestriction = 113,
		XsdSimpleTypeList = 114,
		XsdSimpleTypeRestriction = 115,
		XsdSimpleTypeUnion = 116,
		XsdWhitespace = 117,
		XsdRedefine = 118,
		SchemaItemType = 119,
		SchemaMemberTypes = 120,
		SchemaXPath = 121,
		XmlLang = 122,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000924")]
	private XmlNameTable nameTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000925")]
	public string NsDataType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000926")]
	public string NsDataTypeAlias; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000927")]
	public string NsDataTypeOld; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000928")]
	public string NsXml; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000929")]
	public string NsXmlNs; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400092A")]
	public string NsXdr; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400092B")]
	public string NsXdrAlias; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400092C")]
	public string NsXs; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400092D")]
	public string NsXsi; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400092E")]
	public string XsiType; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400092F")]
	public string XsiNil; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000930")]
	public string XsiSchemaLocation; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000931")]
	public string XsiNoNamespaceSchemaLocation; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000932")]
	public string XsdSchema; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000933")]
	public string XdrSchema; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000934")]
	public XmlQualifiedName QnPCData; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000935")]
	public XmlQualifiedName QnXml; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000936")]
	public XmlQualifiedName QnXmlNs; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000937")]
	public XmlQualifiedName QnDtDt; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000938")]
	public XmlQualifiedName QnXmlLang; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000939")]
	public XmlQualifiedName QnName; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400093A")]
	public XmlQualifiedName QnType; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400093B")]
	public XmlQualifiedName QnMaxOccurs; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400093C")]
	public XmlQualifiedName QnMinOccurs; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400093D")]
	public XmlQualifiedName QnInfinite; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400093E")]
	public XmlQualifiedName QnModel; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400093F")]
	public XmlQualifiedName QnOpen; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000940")]
	public XmlQualifiedName QnClosed; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000941")]
	public XmlQualifiedName QnContent; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000942")]
	public XmlQualifiedName QnMixed; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000943")]
	public XmlQualifiedName QnEmpty; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000944")]
	public XmlQualifiedName QnEltOnly; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000945")]
	public XmlQualifiedName QnTextOnly; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000946")]
	public XmlQualifiedName QnOrder; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000947")]
	public XmlQualifiedName QnSeq; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000948")]
	public XmlQualifiedName QnOne; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000949")]
	public XmlQualifiedName QnMany; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400094A")]
	public XmlQualifiedName QnRequired; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400094B")]
	public XmlQualifiedName QnYes; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400094C")]
	public XmlQualifiedName QnNo; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400094D")]
	public XmlQualifiedName QnString; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400094E")]
	public XmlQualifiedName QnID; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400094F")]
	public XmlQualifiedName QnIDRef; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000950")]
	public XmlQualifiedName QnIDRefs; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000951")]
	public XmlQualifiedName QnEntity; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000952")]
	public XmlQualifiedName QnEntities; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000953")]
	public XmlQualifiedName QnNmToken; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000954")]
	public XmlQualifiedName QnNmTokens; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000955")]
	public XmlQualifiedName QnEnumeration; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000956")]
	public XmlQualifiedName QnDefault; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000957")]
	public XmlQualifiedName QnXdrSchema; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000958")]
	public XmlQualifiedName QnXdrElementType; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000959")]
	public XmlQualifiedName QnXdrElement; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x400095A")]
	public XmlQualifiedName QnXdrGroup; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x400095B")]
	public XmlQualifiedName QnXdrAttributeType; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x400095C")]
	public XmlQualifiedName QnXdrAttribute; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400095D")]
	public XmlQualifiedName QnXdrDataType; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x400095E")]
	public XmlQualifiedName QnXdrDescription; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x400095F")]
	public XmlQualifiedName QnXdrExtends; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000960")]
	public XmlQualifiedName QnXdrAliasSchema; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000961")]
	public XmlQualifiedName QnDtType; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000962")]
	public XmlQualifiedName QnDtValues; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000963")]
	public XmlQualifiedName QnDtMaxLength; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000964")]
	public XmlQualifiedName QnDtMinLength; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000965")]
	public XmlQualifiedName QnDtMax; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000966")]
	public XmlQualifiedName QnDtMin; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000967")]
	public XmlQualifiedName QnDtMinExclusive; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000968")]
	public XmlQualifiedName QnDtMaxExclusive; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000969")]
	public XmlQualifiedName QnTargetNamespace; //Field offset: 0x238
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x400096A")]
	public XmlQualifiedName QnVersion; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x400096B")]
	public XmlQualifiedName QnFinalDefault; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x400096C")]
	public XmlQualifiedName QnBlockDefault; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400096D")]
	public XmlQualifiedName QnFixed; //Field offset: 0x258
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400096E")]
	public XmlQualifiedName QnAbstract; //Field offset: 0x260
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400096F")]
	public XmlQualifiedName QnBlock; //Field offset: 0x268
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000970")]
	public XmlQualifiedName QnSubstitutionGroup; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000971")]
	public XmlQualifiedName QnFinal; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000972")]
	public XmlQualifiedName QnNillable; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000973")]
	public XmlQualifiedName QnRef; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000974")]
	public XmlQualifiedName QnBase; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000975")]
	public XmlQualifiedName QnDerivedBy; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000976")]
	public XmlQualifiedName QnNamespace; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000977")]
	public XmlQualifiedName QnProcessContents; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000978")]
	public XmlQualifiedName QnRefer; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000979")]
	public XmlQualifiedName QnPublic; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x400097A")]
	public XmlQualifiedName QnSystem; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x400097B")]
	public XmlQualifiedName QnSchemaLocation; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[Token(Token = "0x400097C")]
	public XmlQualifiedName QnValue; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x400097D")]
	public XmlQualifiedName QnUse; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x400097E")]
	public XmlQualifiedName QnForm; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x400097F")]
	public XmlQualifiedName QnElementFormDefault; //Field offset: 0x2E8
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x4000980")]
	public XmlQualifiedName QnAttributeFormDefault; //Field offset: 0x2F0
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x4000981")]
	public XmlQualifiedName QnItemType; //Field offset: 0x2F8
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x4000982")]
	public XmlQualifiedName QnMemberTypes; //Field offset: 0x300
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x4000983")]
	public XmlQualifiedName QnXPath; //Field offset: 0x308
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000984")]
	public XmlQualifiedName QnXsdSchema; //Field offset: 0x310
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4000985")]
	public XmlQualifiedName QnXsdAnnotation; //Field offset: 0x318
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4000986")]
	public XmlQualifiedName QnXsdInclude; //Field offset: 0x320
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x4000987")]
	public XmlQualifiedName QnXsdImport; //Field offset: 0x328
	[FieldOffset(Offset = "0x330")]
	[Token(Token = "0x4000988")]
	public XmlQualifiedName QnXsdElement; //Field offset: 0x330
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x4000989")]
	public XmlQualifiedName QnXsdAttribute; //Field offset: 0x338
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x400098A")]
	public XmlQualifiedName QnXsdAttributeGroup; //Field offset: 0x340
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x400098B")]
	public XmlQualifiedName QnXsdAnyAttribute; //Field offset: 0x348
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x400098C")]
	public XmlQualifiedName QnXsdGroup; //Field offset: 0x350
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x400098D")]
	public XmlQualifiedName QnXsdAll; //Field offset: 0x358
	[FieldOffset(Offset = "0x360")]
	[Token(Token = "0x400098E")]
	public XmlQualifiedName QnXsdChoice; //Field offset: 0x360
	[FieldOffset(Offset = "0x368")]
	[Token(Token = "0x400098F")]
	public XmlQualifiedName QnXsdSequence; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x4000990")]
	public XmlQualifiedName QnXsdAny; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x4000991")]
	public XmlQualifiedName QnXsdNotation; //Field offset: 0x378
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x4000992")]
	public XmlQualifiedName QnXsdSimpleType; //Field offset: 0x380
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x4000993")]
	public XmlQualifiedName QnXsdComplexType; //Field offset: 0x388
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x4000994")]
	public XmlQualifiedName QnXsdUnique; //Field offset: 0x390
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x4000995")]
	public XmlQualifiedName QnXsdKey; //Field offset: 0x398
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x4000996")]
	public XmlQualifiedName QnXsdKeyRef; //Field offset: 0x3A0
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x4000997")]
	public XmlQualifiedName QnXsdSelector; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x3B0")]
	[Token(Token = "0x4000998")]
	public XmlQualifiedName QnXsdField; //Field offset: 0x3B0
	[FieldOffset(Offset = "0x3B8")]
	[Token(Token = "0x4000999")]
	public XmlQualifiedName QnXsdMinExclusive; //Field offset: 0x3B8
	[FieldOffset(Offset = "0x3C0")]
	[Token(Token = "0x400099A")]
	public XmlQualifiedName QnXsdMinInclusive; //Field offset: 0x3C0
	[FieldOffset(Offset = "0x3C8")]
	[Token(Token = "0x400099B")]
	public XmlQualifiedName QnXsdMaxInclusive; //Field offset: 0x3C8
	[FieldOffset(Offset = "0x3D0")]
	[Token(Token = "0x400099C")]
	public XmlQualifiedName QnXsdMaxExclusive; //Field offset: 0x3D0
	[FieldOffset(Offset = "0x3D8")]
	[Token(Token = "0x400099D")]
	public XmlQualifiedName QnXsdTotalDigits; //Field offset: 0x3D8
	[FieldOffset(Offset = "0x3E0")]
	[Token(Token = "0x400099E")]
	public XmlQualifiedName QnXsdFractionDigits; //Field offset: 0x3E0
	[FieldOffset(Offset = "0x3E8")]
	[Token(Token = "0x400099F")]
	public XmlQualifiedName QnXsdLength; //Field offset: 0x3E8
	[FieldOffset(Offset = "0x3F0")]
	[Token(Token = "0x40009A0")]
	public XmlQualifiedName QnXsdMinLength; //Field offset: 0x3F0
	[FieldOffset(Offset = "0x3F8")]
	[Token(Token = "0x40009A1")]
	public XmlQualifiedName QnXsdMaxLength; //Field offset: 0x3F8
	[FieldOffset(Offset = "0x400")]
	[Token(Token = "0x40009A2")]
	public XmlQualifiedName QnXsdEnumeration; //Field offset: 0x400
	[FieldOffset(Offset = "0x408")]
	[Token(Token = "0x40009A3")]
	public XmlQualifiedName QnXsdPattern; //Field offset: 0x408
	[FieldOffset(Offset = "0x410")]
	[Token(Token = "0x40009A4")]
	public XmlQualifiedName QnXsdDocumentation; //Field offset: 0x410
	[FieldOffset(Offset = "0x418")]
	[Token(Token = "0x40009A5")]
	public XmlQualifiedName QnXsdAppinfo; //Field offset: 0x418
	[FieldOffset(Offset = "0x420")]
	[Token(Token = "0x40009A6")]
	public XmlQualifiedName QnSource; //Field offset: 0x420
	[FieldOffset(Offset = "0x428")]
	[Token(Token = "0x40009A7")]
	public XmlQualifiedName QnXsdComplexContent; //Field offset: 0x428
	[FieldOffset(Offset = "0x430")]
	[Token(Token = "0x40009A8")]
	public XmlQualifiedName QnXsdSimpleContent; //Field offset: 0x430
	[FieldOffset(Offset = "0x438")]
	[Token(Token = "0x40009A9")]
	public XmlQualifiedName QnXsdRestriction; //Field offset: 0x438
	[FieldOffset(Offset = "0x440")]
	[Token(Token = "0x40009AA")]
	public XmlQualifiedName QnXsdExtension; //Field offset: 0x440
	[FieldOffset(Offset = "0x448")]
	[Token(Token = "0x40009AB")]
	public XmlQualifiedName QnXsdUnion; //Field offset: 0x448
	[FieldOffset(Offset = "0x450")]
	[Token(Token = "0x40009AC")]
	public XmlQualifiedName QnXsdList; //Field offset: 0x450
	[FieldOffset(Offset = "0x458")]
	[Token(Token = "0x40009AD")]
	public XmlQualifiedName QnXsdWhiteSpace; //Field offset: 0x458
	[FieldOffset(Offset = "0x460")]
	[Token(Token = "0x40009AE")]
	public XmlQualifiedName QnXsdRedefine; //Field offset: 0x460
	[FieldOffset(Offset = "0x468")]
	[Token(Token = "0x40009AF")]
	public XmlQualifiedName QnXsdAnyType; //Field offset: 0x468
	[FieldOffset(Offset = "0x470")]
	[Token(Token = "0x40009B0")]
	internal XmlQualifiedName[] TokenToQName; //Field offset: 0x470

	[Address(RVA = "0x2474E80", Offset = "0x2474280", Length = "0x330C")]
	[Token(Token = "0x6001312")]
	public SchemaNames(XmlNameTable nameTable) { }

	[Address(RVA = "0x2471CF0", Offset = "0x24710F0", Length = "0x302B")]
	[Token(Token = "0x6001313")]
	public void CreateTokenToQNameTable() { }

	[Address(RVA = "0x2474D20", Offset = "0x2474120", Length = "0x4D")]
	[Token(Token = "0x6001316")]
	public bool IsXDRRoot(string localName, string ns) { }

	[Address(RVA = "0x2474D70", Offset = "0x2474170", Length = "0x4D")]
	[Token(Token = "0x6001315")]
	public bool IsXSDRoot(string localName, string ns) { }

	[Address(RVA = "0x2474DC0", Offset = "0x24741C0", Length = "0xB9")]
	[Token(Token = "0x6001314")]
	public SchemaType SchemaTypeFromRoot(string localName, string ns) { }

}

