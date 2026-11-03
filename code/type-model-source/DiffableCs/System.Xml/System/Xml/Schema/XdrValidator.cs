namespace System.Xml.Schema;

[Token(Token = "0x20001F3")]
internal sealed class XdrValidator : BaseValidator
{
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000AB6")]
	private HWStack validationStack; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000AB7")]
	private Hashtable attPresence; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000AB8")]
	private XmlQualifiedName name; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000AB9")]
	private XmlNamespaceManager nsManager; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000ABA")]
	private bool isProcessContents; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000ABB")]
	private Hashtable IDs; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000ABC")]
	private IdRefNode idRefListHead; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000ABD")]
	private Parser inlineSchemaParser; //Field offset: 0xB8

	[Token(Token = "0x17000539")]
	private bool HasSchema
	{
		[Address(RVA = "0x2486590", Offset = "0x2485990", Length = "0x1E")]
		[Token(Token = "0x60013E9")]
		private get { } //Length: 30
	}

	[Token(Token = "0x17000538")]
	private bool IsInlineSchemaStarted
	{
		[Address(RVA = "0x24865B0", Offset = "0x24859B0", Length = "0xC")]
		[Token(Token = "0x60013E0")]
		private get { } //Length: 12
	}

	[Token(Token = "0x1700053A")]
	public virtual bool PreserveWhitespace
	{
		[Address(RVA = "0x24865C0", Offset = "0x24859C0", Length = "0x3B")]
		[Token(Token = "0x60013EA")]
		 get { } //Length: 59
	}

	[Address(RVA = "0x2486500", Offset = "0x2485900", Length = "0x8B")]
	[Token(Token = "0x60013DA")]
	internal XdrValidator(BaseValidator validator) { }

	[Address(RVA = "0x2486440", Offset = "0x2485840", Length = "0xB1")]
	[Token(Token = "0x60013DB")]
	internal XdrValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	[Address(RVA = "0x2482C80", Offset = "0x2482080", Length = "0xB1")]
	[Token(Token = "0x60013EF")]
	internal void AddID(string name, object node) { }

	[Address(RVA = "0x2482D40", Offset = "0x2482140", Length = "0x478")]
	[Token(Token = "0x60013EE")]
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	[Address(RVA = "0x24831C0", Offset = "0x24825C0", Length = "0x14D")]
	[Token(Token = "0x60013F3")]
	private void CheckForwardRefs() { }

	[Address(RVA = "0x2483310", Offset = "0x2482710", Length = "0x53B")]
	[Token(Token = "0x60013ED")]
	private void CheckValue(string value, SchemaAttDef attdef) { }

	[Address(RVA = "0x2483850", Offset = "0x2482C50", Length = "0x26F")]
	[Token(Token = "0x60013EC")]
	public virtual void CompleteValidation() { }

	[Address(RVA = "0x2483AC0", Offset = "0x2482EC0", Length = "0x28")]
	[Token(Token = "0x60013F0")]
	public virtual object FindId(string name) { }

	[Address(RVA = "0x2486590", Offset = "0x2485990", Length = "0x1E")]
	[Token(Token = "0x60013E9")]
	private bool get_HasSchema() { }

	[Address(RVA = "0x24865B0", Offset = "0x24859B0", Length = "0xC")]
	[Token(Token = "0x60013E0")]
	private bool get_IsInlineSchemaStarted() { }

	[Address(RVA = "0x24865C0", Offset = "0x24859C0", Length = "0x3B")]
	[Token(Token = "0x60013EA")]
	public virtual bool get_PreserveWhitespace() { }

	[Address(RVA = "0x2483AF0", Offset = "0x2482EF0", Length = "0x212")]
	[Token(Token = "0x60013DC")]
	private void Init() { }

	[Address(RVA = "0x2484380", Offset = "0x2483780", Length = "0x217")]
	[Token(Token = "0x60013E8")]
	private void LoadSchema(string uri) { }

	[Address(RVA = "0x2483D10", Offset = "0x2483110", Length = "0x665")]
	[Token(Token = "0x60013E7")]
	private void LoadSchemaFromLocation(string uri) { }

	[Address(RVA = "0x24845A0", Offset = "0x24839A0", Length = "0xCB")]
	[Token(Token = "0x60013F2")]
	private void Pop() { }

	[Address(RVA = "0x2484670", Offset = "0x2483A70", Length = "0xE2")]
	[Token(Token = "0x60013E2")]
	private void ProcessElement() { }

	[Address(RVA = "0x2484760", Offset = "0x2483B60", Length = "0x23D")]
	[Token(Token = "0x60013E1")]
	private void ProcessInlineSchema() { }

	[Address(RVA = "0x24849A0", Offset = "0x2483DA0", Length = "0x2AB")]
	[Token(Token = "0x60013EB")]
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	[Address(RVA = "0x2484C50", Offset = "0x2484050", Length = "0x1A9")]
	[Token(Token = "0x60013F1")]
	private void Push(XmlQualifiedName elementName) { }

	[Address(RVA = "0x2484E00", Offset = "0x2484200", Length = "0x93")]
	[Token(Token = "0x60013F4")]
	private XmlQualifiedName QualifiedName(string name, string ns) { }

	[Address(RVA = "0x2484EA0", Offset = "0x24842A0", Length = "0x409")]
	[Token(Token = "0x60013E4")]
	private SchemaElementDecl ThoroughGetElementDecl() { }

	[Address(RVA = "0x2486360", Offset = "0x2485760", Length = "0xD2")]
	[Token(Token = "0x60013DD")]
	public virtual void Validate() { }

	[Address(RVA = "0x24852B0", Offset = "0x24846B0", Length = "0x1B7")]
	[Token(Token = "0x60013DF")]
	private void ValidateChildElement() { }

	[Address(RVA = "0x2485470", Offset = "0x2484870", Length = "0x42C")]
	[Token(Token = "0x60013DE")]
	private void ValidateElement() { }

	[Address(RVA = "0x24858A0", Offset = "0x2484CA0", Length = "0x2D6")]
	[Token(Token = "0x60013E3")]
	private void ValidateEndElement() { }

	[Address(RVA = "0x2485B80", Offset = "0x2484F80", Length = "0x33F")]
	[Token(Token = "0x60013E6")]
	private void ValidateEndStartElement() { }

	[Address(RVA = "0x2485ED0", Offset = "0x24852D0", Length = "0x48C")]
	[Token(Token = "0x60013E5")]
	private void ValidateStartElement() { }

}

