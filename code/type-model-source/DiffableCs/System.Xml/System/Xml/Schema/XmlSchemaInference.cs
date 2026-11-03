namespace System.Xml.Schema;

[Token(Token = "0x20001C8")]
public sealed class XmlSchemaInference
{
	[Token(Token = "0x20001C9")]
	internal enum InferenceOption : int
	{
		Restricted = 0,
		Relaxed = 1,
	}

	[Token(Token = "0x4000868")]
	internal static XmlQualifiedName ST_boolean; //Field offset: 0x0
	[Token(Token = "0x4000869")]
	internal static XmlQualifiedName ST_byte; //Field offset: 0x8
	[Token(Token = "0x400086A")]
	internal static XmlQualifiedName ST_unsignedByte; //Field offset: 0x10
	[Token(Token = "0x400086B")]
	internal static XmlQualifiedName ST_short; //Field offset: 0x18
	[Token(Token = "0x400086C")]
	internal static XmlQualifiedName ST_unsignedShort; //Field offset: 0x20
	[Token(Token = "0x400086D")]
	internal static XmlQualifiedName ST_int; //Field offset: 0x28
	[Token(Token = "0x400086E")]
	internal static XmlQualifiedName ST_unsignedInt; //Field offset: 0x30
	[Token(Token = "0x400086F")]
	internal static XmlQualifiedName ST_long; //Field offset: 0x38
	[Token(Token = "0x4000870")]
	internal static XmlQualifiedName ST_unsignedLong; //Field offset: 0x40
	[Token(Token = "0x4000871")]
	internal static XmlQualifiedName ST_integer; //Field offset: 0x48
	[Token(Token = "0x4000872")]
	internal static XmlQualifiedName ST_decimal; //Field offset: 0x50
	[Token(Token = "0x4000873")]
	internal static XmlQualifiedName ST_float; //Field offset: 0x58
	[Token(Token = "0x4000874")]
	internal static XmlQualifiedName ST_double; //Field offset: 0x60
	[Token(Token = "0x4000875")]
	internal static XmlQualifiedName ST_duration; //Field offset: 0x68
	[Token(Token = "0x4000876")]
	internal static XmlQualifiedName ST_dateTime; //Field offset: 0x70
	[Token(Token = "0x4000877")]
	internal static XmlQualifiedName ST_time; //Field offset: 0x78
	[Token(Token = "0x4000878")]
	internal static XmlQualifiedName ST_date; //Field offset: 0x80
	[Token(Token = "0x4000879")]
	internal static XmlQualifiedName ST_gYearMonth; //Field offset: 0x88
	[Token(Token = "0x400087A")]
	internal static XmlQualifiedName ST_string; //Field offset: 0x90
	[Token(Token = "0x400087B")]
	internal static XmlQualifiedName ST_anySimpleType; //Field offset: 0x98
	[Token(Token = "0x400087C")]
	internal static XmlQualifiedName[] SimpleTypes; //Field offset: 0xA0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400087D")]
	private XmlSchema rootSchema; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400087E")]
	private XmlSchemaSet schemaSet; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400087F")]
	private XmlReader xtr; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000880")]
	private NameTable nametable; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000881")]
	private string TargetNamespace; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000882")]
	private XmlNamespaceManager NamespaceManager; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000883")]
	private ArrayList schemaList; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000884")]
	private InferenceOption occurrence; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000885")]
	private InferenceOption typeInference; //Field offset: 0x4C

	[Token(Token = "0x170004CD")]
	public InferenceOption Occurrence
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x600118F")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[Token(Token = "0x600118E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170004CE")]
	public InferenceOption TypeInference
	{
		[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
		[Token(Token = "0x6001190")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x243D860", Offset = "0x243CC60", Length = "0xF0F")]
	[Token(Token = "0x60011AB")]
	private static XmlSchemaInference() { }

	[Address(RVA = "0x243E770", Offset = "0x243DB70", Length = "0x27F")]
	[Token(Token = "0x6001191")]
	public XmlSchemaInference() { }

	[Address(RVA = "0x2434630", Offset = "0x2433A30", Length = "0x947")]
	[Token(Token = "0x6001194")]
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	[Address(RVA = "0x2434F80", Offset = "0x2434380", Length = "0x727")]
	[Token(Token = "0x6001196")]
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	[Address(RVA = "0x24356B0", Offset = "0x2434AB0", Length = "0x174")]
	[Token(Token = "0x6001198")]
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	[Address(RVA = "0x2435830", Offset = "0x2434C30", Length = "0x2A1")]
	[Token(Token = "0x60011A8")]
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	[Address(RVA = "0x2435AE0", Offset = "0x2434EE0", Length = "0x99")]
	[Token(Token = "0x6001195")]
	private XmlSchema CreateXmlSchema(string targetNS) { }

	[Address(RVA = "0x2435B80", Offset = "0x2434F80", Length = "0xC3")]
	[Token(Token = "0x60011A7")]
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	[Address(RVA = "0x2435E90", Offset = "0x2435290", Length = "0x1F8")]
	[Token(Token = "0x600119E")]
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	[Address(RVA = "0x2435C50", Offset = "0x2435050", Length = "0x235")]
	[Token(Token = "0x60011A1")]
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	[Address(RVA = "0x24361F0", Offset = "0x24355F0", Length = "0x125")]
	[Token(Token = "0x60011A0")]
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	[Address(RVA = "0x2436090", Offset = "0x2435490", Length = "0x150")]
	[Token(Token = "0x60011A2")]
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	[Address(RVA = "0x2436320", Offset = "0x2435720", Length = "0x20E")]
	[Token(Token = "0x600119F")]
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	[Address(RVA = "0x2436530", Offset = "0x2435930", Length = "0x14E3")]
	[Token(Token = "0x600119A")]
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x600118F")]
	public InferenceOption get_Occurrence() { }

	[Address(RVA = "0x2437A20", Offset = "0x2436E20", Length = "0x173")]
	[Token(Token = "0x6001199")]
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	[Address(RVA = "0x2437BA0", Offset = "0x2436FA0", Length = "0xA65")]
	[Token(Token = "0x60011A9")]
	private static int GetSchemaType(XmlQualifiedName qname) { }

	[Address(RVA = "0x2438610", Offset = "0x2437A10", Length = "0x1C59")]
	[Token(Token = "0x6001197")]
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	[Address(RVA = "0x243AAC0", Offset = "0x2439EC0", Length = "0x7C")]
	[Token(Token = "0x6001192")]
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	[Address(RVA = "0x243A270", Offset = "0x2439670", Length = "0x84E")]
	[Token(Token = "0x6001193")]
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	[Address(RVA = "0x243AB40", Offset = "0x2439F40", Length = "0x1080")]
	[Token(Token = "0x60011A6")]
	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	[Address(RVA = "0x243BC00", Offset = "0x243B000", Length = "0xCA")]
	[Token(Token = "0x60011A3")]
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	[Address(RVA = "0x243BCD0", Offset = "0x243B0D0", Length = "0x9B")]
	[Token(Token = "0x600119C")]
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	[Address(RVA = "0x243BD70", Offset = "0x243B170", Length = "0x2D0")]
	[Token(Token = "0x600119D")]
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	[Address(RVA = "0x243C050", Offset = "0x243B450", Length = "0x813")]
	[Token(Token = "0x600119B")]
	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	[Address(RVA = "0x243C870", Offset = "0x243BC70", Length = "0xCDD")]
	[Token(Token = "0x60011A5")]
	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[Token(Token = "0x600118E")]
	public void set_Occurrence(InferenceOption value) { }

	[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
	[Token(Token = "0x6001190")]
	public void set_TypeInference(InferenceOption value) { }

	[Address(RVA = "0x243D550", Offset = "0x243C950", Length = "0x1DF")]
	[Token(Token = "0x60011AA")]
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	[Address(RVA = "0x243D730", Offset = "0x243CB30", Length = "0x125")]
	[Token(Token = "0x60011A4")]
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

}

