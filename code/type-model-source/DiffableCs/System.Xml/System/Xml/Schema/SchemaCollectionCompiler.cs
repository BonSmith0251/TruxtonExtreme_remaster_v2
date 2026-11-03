namespace System.Xml.Schema;

[Token(Token = "0x20001D5")]
internal sealed class SchemaCollectionCompiler : BaseProcessor
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008CB")]
	private bool compileContentModel; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008CC")]
	private XmlSchemaObjectTable examplars; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008CD")]
	private Stack complexTypeStack; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008CE")]
	private XmlSchema schema; //Field offset: 0x58

	[Address(RVA = "0x24513F0", Offset = "0x24507F0", Length = "0xC6")]
	[Token(Token = "0x600122A")]
	public SchemaCollectionCompiler(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	[Address(RVA = "0x243EEA0", Offset = "0x243E2A0", Length = "0x690")]
	[Token(Token = "0x6001265")]
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	[Address(RVA = "0x243F540", Offset = "0x243E940", Length = "0x99D")]
	[Token(Token = "0x600125A")]
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out decimal minOccurs, out decimal maxOccurs) { }

	[Address(RVA = "0x243FEE0", Offset = "0x243F2E0", Length = "0x422")]
	[Token(Token = "0x6001255")]
	private void CalculateSequenceRange(XmlSchemaSequence sequence, out decimal minOccurs, out decimal maxOccurs) { }

	[Address(RVA = "0x2440310", Offset = "0x243F710", Length = "0x5AE")]
	[Token(Token = "0x6001249")]
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	[Address(RVA = "0x24408C0", Offset = "0x243FCC0", Length = "0x672")]
	[Token(Token = "0x600124A")]
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	[Address(RVA = "0x2440F40", Offset = "0x2440340", Length = "0x197")]
	[Token(Token = "0x6001247")]
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	[Address(RVA = "0x24410E0", Offset = "0x24404E0", Length = "0x688")]
	[Token(Token = "0x6001248")]
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	[Address(RVA = "0x2441770", Offset = "0x2440B70", Length = "0x4A9")]
	[Token(Token = "0x6001246")]
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	[Address(RVA = "0x2441C20", Offset = "0x2441020", Length = "0x602")]
	[Token(Token = "0x600124B")]
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	[Address(RVA = "0x2442230", Offset = "0x2441630", Length = "0x132")]
	[Token(Token = "0x6001244")]
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	[Address(RVA = "0x2442370", Offset = "0x2441770", Length = "0x233")]
	[Token(Token = "0x600123A")]
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	[Address(RVA = "0x24425B0", Offset = "0x24419B0", Length = "0x129")]
	[Token(Token = "0x600123E")]
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	[Address(RVA = "0x24430F0", Offset = "0x24424F0", Length = "0xCB5")]
	[Token(Token = "0x600122D")]
	private void Cleanup() { }

	[Address(RVA = "0x2443DB0", Offset = "0x24431B0", Length = "0x7B3")]
	[Token(Token = "0x600122E")]
	internal static void Cleanup(XmlSchema schema) { }

	[Address(RVA = "0x2442740", Offset = "0x2441B40", Length = "0x4C")]
	[Token(Token = "0x6001231")]
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	[Address(RVA = "0x24426E0", Offset = "0x2441AE0", Length = "0x55")]
	[Token(Token = "0x6001232")]
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	[Address(RVA = "0x2442790", Offset = "0x2441B90", Length = "0xF1")]
	[Token(Token = "0x6001236")]
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	[Address(RVA = "0x2442890", Offset = "0x2441C90", Length = "0x44F")]
	[Token(Token = "0x6001233")]
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	[Address(RVA = "0x2442CE0", Offset = "0x24420E0", Length = "0x1CF")]
	[Token(Token = "0x6001235")]
	private static void CleanupElement(XmlSchemaElement element) { }

	[Address(RVA = "0x2442EB0", Offset = "0x24422B0", Length = "0x36")]
	[Token(Token = "0x6001237")]
	private static void CleanupGroup(XmlSchemaGroup group) { }

	[Address(RVA = "0x2442EF0", Offset = "0x24422F0", Length = "0x1D4")]
	[Token(Token = "0x6001238")]
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	[Address(RVA = "0x24430D0", Offset = "0x24424D0", Length = "0x1C")]
	[Token(Token = "0x6001234")]
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	[Address(RVA = "0x244C280", Offset = "0x244B680", Length = "0x1B80")]
	[Token(Token = "0x600122F")]
	private void Compile() { }

	[Address(RVA = "0x2444570", Offset = "0x2443970", Length = "0xA1")]
	[Token(Token = "0x6001260")]
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	[Address(RVA = "0x2444620", Offset = "0x2443A20", Length = "0xA1")]
	[Token(Token = "0x600125F")]
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	[Address(RVA = "0x2444DA0", Offset = "0x24441A0", Length = "0xC07")]
	[Token(Token = "0x6001261")]
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	[Address(RVA = "0x24446D0", Offset = "0x2443AD0", Length = "0x6C3")]
	[Token(Token = "0x600125D")]
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	[Address(RVA = "0x24459B0", Offset = "0x2444DB0", Length = "0x3F8")]
	[Token(Token = "0x600123D")]
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	[Address(RVA = "0x2445DB0", Offset = "0x24451B0", Length = "0xCF")]
	[Token(Token = "0x6001267")]
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	[Address(RVA = "0x2446700", Offset = "0x2445B00", Length = "0xD5F")]
	[Token(Token = "0x6001264")]
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	[Address(RVA = "0x2445E80", Offset = "0x2445280", Length = "0x4F1")]
	[Token(Token = "0x6001242")]
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	[Address(RVA = "0x2446380", Offset = "0x2445780", Length = "0x370")]
	[Token(Token = "0x6001243")]
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	[Address(RVA = "0x2447460", Offset = "0x2446860", Length = "0xC32")]
	[Token(Token = "0x600123F")]
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	[Address(RVA = "0x24480A0", Offset = "0x24474A0", Length = "0x1A6")]
	[Token(Token = "0x6001245")]
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	[Address(RVA = "0x2448250", Offset = "0x2447650", Length = "0xF7E")]
	[Token(Token = "0x6001263")]
	private void CompileElement(XmlSchemaElement xe) { }

	[Address(RVA = "0x24491D0", Offset = "0x24485D0", Length = "0xE7")]
	[Token(Token = "0x600123B")]
	private void CompileGroup(XmlSchemaGroup group) { }

	[Address(RVA = "0x24492C0", Offset = "0x24486C0", Length = "0x69D")]
	[Token(Token = "0x6001262")]
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	[Address(RVA = "0x2449960", Offset = "0x2448D60", Length = "0x103E")]
	[Token(Token = "0x600125E")]
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	[Address(RVA = "0x244A9A0", Offset = "0x2449DA0", Length = "0x2ED")]
	[Token(Token = "0x6001266")]
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	[Address(RVA = "0x244AC90", Offset = "0x244A090", Length = "0x29C")]
	[Token(Token = "0x6001240")]
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	[Address(RVA = "0x244AF30", Offset = "0x244A330", Length = "0x435")]
	[Token(Token = "0x6001241")]
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	[Address(RVA = "0x244B370", Offset = "0x244A770", Length = "0x9C0")]
	[Token(Token = "0x600123C")]
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	[Address(RVA = "0x244BD40", Offset = "0x244B140", Length = "0x532")]
	[Token(Token = "0x6001239")]
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	[Address(RVA = "0x244DE10", Offset = "0x244D210", Length = "0x72")]
	[Token(Token = "0x600122B")]
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	[Address(RVA = "0x244DE90", Offset = "0x244D290", Length = "0x1C8")]
	[Token(Token = "0x600126A")]
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	[Address(RVA = "0x244E060", Offset = "0x244D460", Length = "0xB2")]
	[Token(Token = "0x6001269")]
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	[Address(RVA = "0x244E120", Offset = "0x244D520", Length = "0xF7")]
	[Token(Token = "0x6001258")]
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	[Address(RVA = "0x244E220", Offset = "0x244D620", Length = "0x7A")]
	[Token(Token = "0x600125C")]
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	[Address(RVA = "0x244E2A0", Offset = "0x244D6A0", Length = "0x156")]
	[Token(Token = "0x6001268")]
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	[Address(RVA = "0x244E400", Offset = "0x244D800", Length = "0x56")]
	[Token(Token = "0x600124F")]
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	[Address(RVA = "0x244E460", Offset = "0x244D860", Length = "0x6D")]
	[Token(Token = "0x600124E")]
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	[Address(RVA = "0x244E4D0", Offset = "0x244D8D0", Length = "0x138")]
	[Token(Token = "0x600124D")]
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	[Address(RVA = "0x244E610", Offset = "0x244DA10", Length = "0x384")]
	[Token(Token = "0x6001251")]
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	[Address(RVA = "0x244E9A0", Offset = "0x244DDA0", Length = "0x2B7")]
	[Token(Token = "0x6001250")]
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	[Address(RVA = "0x244EC60", Offset = "0x244E060", Length = "0x2CD")]
	[Token(Token = "0x6001252")]
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	[Address(RVA = "0x244EF30", Offset = "0x244E330", Length = "0xB0")]
	[Token(Token = "0x6001259")]
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	[Address(RVA = "0x244EFE0", Offset = "0x244E3E0", Length = "0x338")]
	[Token(Token = "0x6001253")]
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	[Address(RVA = "0x244F320", Offset = "0x244E720", Length = "0x2B2")]
	[Token(Token = "0x6001254")]
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	[Address(RVA = "0x244F5E0", Offset = "0x244E9E0", Length = "0xCB")]
	[Token(Token = "0x6001257")]
	private bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs) { }

	[Address(RVA = "0x244F6B0", Offset = "0x244EAB0", Length = "0x101")]
	[Token(Token = "0x6001256")]
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	[Address(RVA = "0x244F7C0", Offset = "0x244EBC0", Length = "0xBE0")]
	[Token(Token = "0x600124C")]
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	[Address(RVA = "0x24503B0", Offset = "0x244F7B0", Length = "0xCAA")]
	[Token(Token = "0x6001230")]
	private void Output(SchemaInfo schemaInfo) { }

	[Address(RVA = "0x2451060", Offset = "0x2450460", Length = "0x35C")]
	[Token(Token = "0x600122C")]
	private void Prepare() { }

	[Address(RVA = "0x24513C0", Offset = "0x24507C0", Length = "0x2A")]
	[Token(Token = "0x600125B")]
	private void PushComplexType(XmlSchemaComplexType complexType) { }

}

