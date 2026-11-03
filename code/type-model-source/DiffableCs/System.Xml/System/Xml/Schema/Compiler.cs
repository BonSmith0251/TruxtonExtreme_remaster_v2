namespace System.Xml.Schema;

[Token(Token = "0x20001E2")]
internal sealed class Compiler : BaseProcessor
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A31")]
	private string restrictionErrorMsg; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A32")]
	private XmlSchemaObjectTable attributes; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A33")]
	private XmlSchemaObjectTable attributeGroups; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A34")]
	private XmlSchemaObjectTable elements; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A35")]
	private XmlSchemaObjectTable schemaTypes; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A36")]
	private XmlSchemaObjectTable groups; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A37")]
	private XmlSchemaObjectTable notations; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A38")]
	private XmlSchemaObjectTable examplars; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A39")]
	private XmlSchemaObjectTable identityConstraints; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A3A")]
	private Stack complexTypeStack; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A3B")]
	private Hashtable schemasToCompile; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A3C")]
	private Hashtable importedSchemas; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A3D")]
	private XmlSchema schemaForSchema; //Field offset: 0xA0

	[Address(RVA = "0x246F190", Offset = "0x246E590", Length = "0x289")]
	[Token(Token = "0x6001320")]
	public Compiler(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	[Address(RVA = "0x245A010", Offset = "0x2459410", Length = "0x691")]
	[Token(Token = "0x6001362")]
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	[Address(RVA = "0x245A6B0", Offset = "0x2459AB0", Length = "0x7C8")]
	[Token(Token = "0x6001354")]
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out decimal minOccurs, out decimal maxOccurs) { }

	[Address(RVA = "0x245AE80", Offset = "0x245A280", Length = "0x2F0")]
	[Token(Token = "0x6001342")]
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	[Address(RVA = "0x245B180", Offset = "0x245A580", Length = "0x6B8")]
	[Token(Token = "0x6001343")]
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	[Address(RVA = "0x245B840", Offset = "0x245AC40", Length = "0x27D")]
	[Token(Token = "0x6001340")]
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	[Address(RVA = "0x245BAC0", Offset = "0x245AEC0", Length = "0x672")]
	[Token(Token = "0x6001341")]
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	[Address(RVA = "0x245C140", Offset = "0x245B540", Length = "0x2FE")]
	[Token(Token = "0x600133F")]
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	[Address(RVA = "0x245C440", Offset = "0x245B840", Length = "0x4BA")]
	[Token(Token = "0x6001345")]
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	[Address(RVA = "0x245C900", Offset = "0x245BD00", Length = "0x621")]
	[Token(Token = "0x6001344")]
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	[Address(RVA = "0x245CF30", Offset = "0x245C330", Length = "0x7BA")]
	[Token(Token = "0x6001359")]
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	[Address(RVA = "0x245DC10", Offset = "0x245D010", Length = "0xDE")]
	[Token(Token = "0x600133D")]
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	[Address(RVA = "0x245D6F0", Offset = "0x245CAF0", Length = "0x51F")]
	[Token(Token = "0x600133C")]
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	[Address(RVA = "0x245DCF0", Offset = "0x245D0F0", Length = "0x129")]
	[Token(Token = "0x6001336")]
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	[Address(RVA = "0x245DEA0", Offset = "0x245D2A0", Length = "0xF9")]
	[Token(Token = "0x6001327")]
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	[Address(RVA = "0x245DE20", Offset = "0x245D220", Length = "0x7E")]
	[Token(Token = "0x6001328")]
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	[Address(RVA = "0x245DFA0", Offset = "0x245D3A0", Length = "0xC8")]
	[Token(Token = "0x600132C")]
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	[Address(RVA = "0x245E070", Offset = "0x245D470", Length = "0x561")]
	[Token(Token = "0x6001329")]
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	[Address(RVA = "0x245E5E0", Offset = "0x245D9E0", Length = "0x277")]
	[Token(Token = "0x600132B")]
	private void CleanupElement(XmlSchemaElement element) { }

	[Address(RVA = "0x245E860", Offset = "0x245DC60", Length = "0x5F")]
	[Token(Token = "0x600132D")]
	private void CleanupGroup(XmlSchemaGroup group) { }

	[Address(RVA = "0x245E8C0", Offset = "0x245DCC0", Length = "0x1B6")]
	[Token(Token = "0x600132E")]
	private void CleanupParticle(XmlSchemaParticle particle) { }

	[Address(RVA = "0x245EA80", Offset = "0x245DE80", Length = "0xC2")]
	[Token(Token = "0x600132A")]
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	[Address(RVA = "0x24669C0", Offset = "0x2465DC0", Length = "0x1BA6")]
	[Token(Token = "0x6001326")]
	internal bool Compile() { }

	[Address(RVA = "0x245EB50", Offset = "0x245DF50", Length = "0xA1")]
	[Token(Token = "0x600135C")]
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	[Address(RVA = "0x245EC00", Offset = "0x245E000", Length = "0xA1")]
	[Token(Token = "0x600135B")]
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	[Address(RVA = "0x245F4C0", Offset = "0x245E8C0", Length = "0x98D")]
	[Token(Token = "0x600135D")]
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	[Address(RVA = "0x245ECB0", Offset = "0x245E0B0", Length = "0x80B")]
	[Token(Token = "0x6001357")]
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	[Address(RVA = "0x245FE50", Offset = "0x245F250", Length = "0x3F8")]
	[Token(Token = "0x6001335")]
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	[Address(RVA = "0x24609D0", Offset = "0x245FDD0", Length = "0xD1D")]
	[Token(Token = "0x6001361")]
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	[Address(RVA = "0x2460250", Offset = "0x245F650", Length = "0x41A")]
	[Token(Token = "0x600133A")]
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	[Address(RVA = "0x2460670", Offset = "0x245FA70", Length = "0x350")]
	[Token(Token = "0x600133B")]
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	[Address(RVA = "0x2461820", Offset = "0x2460C20", Length = "0xB88")]
	[Token(Token = "0x6001337")]
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	[Address(RVA = "0x24616F0", Offset = "0x2460AF0", Length = "0x12C")]
	[Token(Token = "0x6001365")]
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	[Address(RVA = "0x24623B0", Offset = "0x24617B0", Length = "0x18E")]
	[Token(Token = "0x600133E")]
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	[Address(RVA = "0x2462540", Offset = "0x2461940", Length = "0x1091")]
	[Token(Token = "0x6001360")]
	private void CompileElement(XmlSchemaElement xe) { }

	[Address(RVA = "0x24635E0", Offset = "0x24629E0", Length = "0xDD")]
	[Token(Token = "0x6001333")]
	private void CompileGroup(XmlSchemaGroup group) { }

	[Address(RVA = "0x24636C0", Offset = "0x2462AC0", Length = "0x697")]
	[Token(Token = "0x600135F")]
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	[Address(RVA = "0x2463D60", Offset = "0x2463160", Length = "0x10CE")]
	[Token(Token = "0x6001358")]
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	[Address(RVA = "0x2464E30", Offset = "0x2464230", Length = "0x1E2")]
	[Token(Token = "0x6001364")]
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	[Address(RVA = "0x2465020", Offset = "0x2464420", Length = "0x2ED")]
	[Token(Token = "0x6001363")]
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	[Address(RVA = "0x2465310", Offset = "0x2464710", Length = "0x29C")]
	[Token(Token = "0x6001338")]
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	[Address(RVA = "0x24655B0", Offset = "0x24649B0", Length = "0x435")]
	[Token(Token = "0x6001339")]
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	[Address(RVA = "0x24659F0", Offset = "0x2464DF0", Length = "0x9F4")]
	[Token(Token = "0x6001334")]
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	[Address(RVA = "0x24663F0", Offset = "0x24657F0", Length = "0x5C5")]
	[Token(Token = "0x6001330")]
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	[Address(RVA = "0x2468570", Offset = "0x2467970", Length = "0x85")]
	[Token(Token = "0x6001369")]
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	[Address(RVA = "0x2468600", Offset = "0x2467A00", Length = "0xBD")]
	[Token(Token = "0x6001321")]
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	[Address(RVA = "0x24686C0", Offset = "0x2467AC0", Length = "0x1B5")]
	[Token(Token = "0x6001368")]
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	[Address(RVA = "0x2468880", Offset = "0x2467C80", Length = "0xA3")]
	[Token(Token = "0x6001367")]
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	[Address(RVA = "0x2468930", Offset = "0x2467D30", Length = "0xF7")]
	[Token(Token = "0x6001352")]
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	[Address(RVA = "0x244E220", Offset = "0x244D620", Length = "0x7A")]
	[Token(Token = "0x6001356")]
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	[Address(RVA = "0x2468A30", Offset = "0x2467E30", Length = "0xDD")]
	[Token(Token = "0x6001366")]
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	[Address(RVA = "0x2468B10", Offset = "0x2467F10", Length = "0xF9")]
	[Token(Token = "0x6001325")]
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x2468C10", Offset = "0x2468010", Length = "0x100")]
	[Token(Token = "0x6001349")]
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	[Address(RVA = "0x2468D20", Offset = "0x2468120", Length = "0x1B1")]
	[Token(Token = "0x600134C")]
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	[Address(RVA = "0x2468EE0", Offset = "0x24682E0", Length = "0x1ED")]
	[Token(Token = "0x6001348")]
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	[Address(RVA = "0x24690D0", Offset = "0x24684D0", Length = "0x278")]
	[Token(Token = "0x6001347")]
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	[Address(RVA = "0x2469350", Offset = "0x2468750", Length = "0xA6E")]
	[Token(Token = "0x600134B")]
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	[Address(RVA = "0x2469DC0", Offset = "0x24691C0", Length = "0x172")]
	[Token(Token = "0x600136A")]
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }

	[Address(RVA = "0x2469F40", Offset = "0x2469340", Length = "0x4E8")]
	[Token(Token = "0x600134A")]
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	[Address(RVA = "0x246A430", Offset = "0x2469830", Length = "0x34E")]
	[Token(Token = "0x600134D")]
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	[Address(RVA = "0x246A780", Offset = "0x2469B80", Length = "0xB0")]
	[Token(Token = "0x6001353")]
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	[Address(RVA = "0x246A830", Offset = "0x2469C30", Length = "0xDA")]
	[Token(Token = "0x600135A")]
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	[Address(RVA = "0x246A910", Offset = "0x2469D10", Length = "0x338")]
	[Token(Token = "0x600134E")]
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	[Address(RVA = "0x246AC50", Offset = "0x246A050", Length = "0x44C")]
	[Token(Token = "0x600134F")]
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	[Address(RVA = "0x246B0A0", Offset = "0x246A4A0", Length = "0xCB")]
	[Token(Token = "0x6001351")]
	private bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs) { }

	[Address(RVA = "0x246B170", Offset = "0x246A570", Length = "0x101")]
	[Token(Token = "0x6001350")]
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	[Address(RVA = "0x246B280", Offset = "0x246A680", Length = "0x123C")]
	[Token(Token = "0x6001346")]
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	[Address(RVA = "0x246C4C0", Offset = "0x246B8C0", Length = "0xDF5")]
	[Token(Token = "0x6001324")]
	private void Output(SchemaInfo schemaInfo) { }

	[Address(RVA = "0x246D2C0", Offset = "0x246C6C0", Length = "0x121A")]
	[Token(Token = "0x6001322")]
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	[Address(RVA = "0x246E4E0", Offset = "0x246D8E0", Length = "0x6C1")]
	[Token(Token = "0x600132F")]
	private void ProcessSubstitutionGroups() { }

	[Address(RVA = "0x246EBB0", Offset = "0x246DFB0", Length = "0x2D")]
	[Token(Token = "0x6001355")]
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	[Address(RVA = "0x246EBE0", Offset = "0x246DFE0", Length = "0x83")]
	[Token(Token = "0x6001332")]
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	[Address(RVA = "0x246EC70", Offset = "0x246E070", Length = "0x191")]
	[Token(Token = "0x6001331")]
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	[Address(RVA = "0x246EE10", Offset = "0x246E210", Length = "0x1F2")]
	[Token(Token = "0x600135E")]
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	[Address(RVA = "0x246F010", Offset = "0x246E410", Length = "0x176")]
	[Token(Token = "0x6001323")]
	private void UpdateSForSSimpleTypes() { }

}

