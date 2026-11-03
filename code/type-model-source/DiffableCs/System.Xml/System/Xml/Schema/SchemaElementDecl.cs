namespace System.Xml.Schema;

[Token(Token = "0x20001DA")]
internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo
{
	[Token(Token = "0x40008FD")]
	internal static readonly SchemaElementDecl Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008EF")]
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008F0")]
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008F1")]
	private bool isIdDeclared; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40008F2")]
	private bool hasNonCDataAttribute; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x40008F3")]
	private bool isAbstract; //Field offset: 0x72
	[FieldOffset(Offset = "0x73")]
	[Token(Token = "0x40008F4")]
	private bool isNillable; //Field offset: 0x73
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40008F5")]
	private bool hasRequiredAttribute; //Field offset: 0x74
	[FieldOffset(Offset = "0x75")]
	[Token(Token = "0x40008F6")]
	private bool isNotationDeclared; //Field offset: 0x75
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008F7")]
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008F8")]
	private ContentValidator contentValidator; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008F9")]
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40008FA")]
	private XmlSchemaDerivationMethod block; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008FB")]
	private CompiledIdentityConstraint[] constraints; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40008FC")]
	private XmlSchemaElement schemaElement; //Field offset: 0xA0

	[Token(Token = "0x17000504")]
	internal XmlSchemaAnyAttribute AnyAttribute
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x60012C0")]
		internal get { } //Length: 8
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[Token(Token = "0x60012C1")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000508")]
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60012C9")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170004FF")]
	internal XmlSchemaDerivationMethod Block
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[Token(Token = "0x60012B8")]
		internal get { } //Length: 7
		[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
		[Token(Token = "0x60012B9")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000505")]
	internal CompiledIdentityConstraint[] Constraints
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x60012C2")]
		internal get { } //Length: 8
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[Token(Token = "0x60012C3")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000503")]
	internal ContentValidator ContentValidator
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x60012BE")]
		internal get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[Token(Token = "0x60012BF")]
		internal set { } //Length: 16
	}

	[Token(Token = "0x17000507")]
	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60012C8")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000501")]
	internal bool HasDefaultAttribute
	{
		[Address(RVA = "0x1D33240", Offset = "0x1D32640", Length = "0x9")]
		[Token(Token = "0x60012BC")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x170004FC")]
	internal bool HasNonCDataAttribute
	{
		[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
		[Token(Token = "0x60012B1")]
		internal get { } //Length: 5
		[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
		[Token(Token = "0x60012B2")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000502")]
	internal bool HasRequiredAttribute
	{
		[Address(RVA = "0x1D48530", Offset = "0x1D47930", Length = "0x5")]
		[Token(Token = "0x60012BD")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170004FD")]
	internal bool IsAbstract
	{
		[Address(RVA = "0x1CCF6C0", Offset = "0x1CCEAC0", Length = "0x5")]
		[Token(Token = "0x60012B4")]
		internal get { } //Length: 5
		[Address(RVA = "0x2470280", Offset = "0x246F680", Length = "0x4")]
		[Token(Token = "0x60012B5")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170004FB")]
	internal bool IsIdDeclared
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x60012AF")]
		internal get { } //Length: 5
		[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
		[Token(Token = "0x60012B0")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170004FE")]
	internal bool IsNillable
	{
		[Address(RVA = "0x1CCF6B0", Offset = "0x1CCEAB0", Length = "0x5")]
		[Token(Token = "0x60012B6")]
		internal get { } //Length: 5
		[Address(RVA = "0x2470290", Offset = "0x246F690", Length = "0x4")]
		[Token(Token = "0x60012B7")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000500")]
	internal bool IsNotationDeclared
	{
		[Address(RVA = "0x2470270", Offset = "0x246F670", Length = "0x5")]
		[Token(Token = "0x60012BA")]
		internal get { } //Length: 5
		[Address(RVA = "0x24702A0", Offset = "0x246F6A0", Length = "0x4")]
		[Token(Token = "0x60012BB")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000509")]
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x60012CA")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000506")]
	internal XmlSchemaElement SchemaElement
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x60012C4")]
		internal get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[Token(Token = "0x60012C5")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170004FA")]
	private override bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes
	{
		[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
		[Token(Token = "0x60012AC")]
		private get { } //Length: 5
	}

	[Address(RVA = "0x246FE10", Offset = "0x246F210", Length = "0x67")]
	[Token(Token = "0x60012CC")]
	private static SchemaElementDecl() { }

	[Address(RVA = "0x2470000", Offset = "0x246F400", Length = "0x15B")]
	[Token(Token = "0x60012AA")]
	internal SchemaElementDecl(XmlQualifiedName name, string prefix) { }

	[Address(RVA = "0x2470160", Offset = "0x246F560", Length = "0x110")]
	[Token(Token = "0x60012A8")]
	internal SchemaElementDecl() { }

	[Address(RVA = "0x246FE80", Offset = "0x246F280", Length = "0x176")]
	[Token(Token = "0x60012A9")]
	internal SchemaElementDecl(XmlSchemaDatatype dtype) { }

	[Address(RVA = "0x246F7D0", Offset = "0x246EBD0", Length = "0x152")]
	[Token(Token = "0x60012C6")]
	internal void AddAttDef(SchemaAttDef attdef) { }

	[Address(RVA = "0x246F930", Offset = "0x246ED30", Length = "0x27D")]
	[Token(Token = "0x60012CB")]
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	[Address(RVA = "0x246FBB0", Offset = "0x246EFB0", Length = "0x57")]
	[Token(Token = "0x60012B3")]
	internal SchemaElementDecl Clone() { }

	[Address(RVA = "0x246FC10", Offset = "0x246F010", Length = "0xC8")]
	[Token(Token = "0x60012AB")]
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x60012C0")]
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60012C9")]
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x60012B8")]
	internal XmlSchemaDerivationMethod get_Block() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x60012C2")]
	internal CompiledIdentityConstraint[] get_Constraints() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x60012BE")]
	internal ContentValidator get_ContentValidator() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60012C8")]
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	[Address(RVA = "0x1D33240", Offset = "0x1D32640", Length = "0x9")]
	[Token(Token = "0x60012BC")]
	internal bool get_HasDefaultAttribute() { }

	[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
	[Token(Token = "0x60012B1")]
	internal bool get_HasNonCDataAttribute() { }

	[Address(RVA = "0x1D48530", Offset = "0x1D47930", Length = "0x5")]
	[Token(Token = "0x60012BD")]
	internal bool get_HasRequiredAttribute() { }

	[Address(RVA = "0x1CCF6C0", Offset = "0x1CCEAC0", Length = "0x5")]
	[Token(Token = "0x60012B4")]
	internal bool get_IsAbstract() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x60012AF")]
	internal bool get_IsIdDeclared() { }

	[Address(RVA = "0x1CCF6B0", Offset = "0x1CCEAB0", Length = "0x5")]
	[Token(Token = "0x60012B6")]
	internal bool get_IsNillable() { }

	[Address(RVA = "0x2470270", Offset = "0x246F670", Length = "0x5")]
	[Token(Token = "0x60012BA")]
	internal bool get_IsNotationDeclared() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x60012CA")]
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x60012C4")]
	internal XmlSchemaElement get_SchemaElement() { }

	[Address(RVA = "0x246FCE0", Offset = "0x246F0E0", Length = "0x78")]
	[Token(Token = "0x60012C7")]
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[Token(Token = "0x60012C1")]
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
	[Token(Token = "0x60012B9")]
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[Token(Token = "0x60012C3")]
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x60012BF")]
	internal void set_ContentValidator(ContentValidator value) { }

	[Address(RVA = "0x20D3FE0", Offset = "0x20D33E0", Length = "0x4")]
	[Token(Token = "0x60012B2")]
	internal void set_HasNonCDataAttribute(bool value) { }

	[Address(RVA = "0x2470280", Offset = "0x246F680", Length = "0x4")]
	[Token(Token = "0x60012B5")]
	internal void set_IsAbstract(bool value) { }

	[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
	[Token(Token = "0x60012B0")]
	internal void set_IsIdDeclared(bool value) { }

	[Address(RVA = "0x2470290", Offset = "0x246F690", Length = "0x4")]
	[Token(Token = "0x60012B7")]
	internal void set_IsNillable(bool value) { }

	[Address(RVA = "0x24702A0", Offset = "0x246F6A0", Length = "0x4")]
	[Token(Token = "0x60012BB")]
	internal void set_IsNotationDeclared(bool value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x60012C5")]
	internal void set_SchemaElement(XmlSchemaElement value) { }

	[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
	[Token(Token = "0x60012AC")]
	private override bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	[Address(RVA = "0x246FD60", Offset = "0x246F160", Length = "0xAE")]
	[Token(Token = "0x60012AD")]
	private override IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60012AE")]
	private override IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

}

