namespace System.Xml.Schema;

[Token(Token = "0x2000271")]
internal sealed class XsdValidator : BaseValidator
{
	[Token(Token = "0x4000DB7")]
	private static readonly XmlSchemaDatatype dtCDATA; //Field offset: 0x0
	[Token(Token = "0x4000DB8")]
	private static readonly XmlSchemaDatatype dtQName; //Field offset: 0x8
	[Token(Token = "0x4000DB9")]
	private static readonly XmlSchemaDatatype dtStringArray; //Field offset: 0x10
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000DAE")]
	private int startIDConstraint; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000DAF")]
	private HWStack validationStack; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000DB0")]
	private Hashtable attPresence; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000DB1")]
	private XmlNamespaceManager nsManager; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000DB2")]
	private bool bManageNamespaces; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000DB3")]
	private Hashtable IDs; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000DB4")]
	private IdRefNode idRefListHead; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000DB5")]
	private Parser inlineSchemaParser; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000DB6")]
	private XmlSchemaContentProcessing processContents; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000DBA")]
	private string NsXmlNs; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000DBB")]
	private string NsXs; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000DBC")]
	private string NsXsi; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000DBD")]
	private string XsiType; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000DBE")]
	private string XsiNil; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000DBF")]
	private string XsiSchemaLocation; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000DC0")]
	private string XsiNoNamespaceSchemaLocation; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000DC1")]
	private string XsdSchema; //Field offset: 0x100

	[Token(Token = "0x17000693")]
	private bool HasIdentityConstraints
	{
		[Address(RVA = "0x24EA1D0", Offset = "0x24E95D0", Length = "0x385")]
		[Token(Token = "0x6001976")]
		private get { } //Length: 901
	}

	[Token(Token = "0x17000691")]
	private bool HasSchema
	{
		[Address(RVA = "0x2486590", Offset = "0x2485990", Length = "0x1E")]
		[Token(Token = "0x600196B")]
		private get { } //Length: 30
	}

	[Token(Token = "0x17000690")]
	private bool IsInlineSchemaStarted
	{
		[Address(RVA = "0x24865B0", Offset = "0x24859B0", Length = "0xC")]
		[Token(Token = "0x600195E")]
		private get { } //Length: 12
	}

	[Token(Token = "0x17000692")]
	public virtual bool PreserveWhitespace
	{
		[Address(RVA = "0x24865C0", Offset = "0x24859C0", Length = "0x3B")]
		[Token(Token = "0x600196C")]
		 get { } //Length: 59
	}

	[Address(RVA = "0x24EA080", Offset = "0x24E9480", Length = "0xE8")]
	[Token(Token = "0x600197C")]
	private static XsdValidator() { }

	[Address(RVA = "0x24EA1A0", Offset = "0x24E95A0", Length = "0x2A")]
	[Token(Token = "0x6001959")]
	internal XsdValidator(BaseValidator validator) { }

	[Address(RVA = "0x24EA170", Offset = "0x24E9570", Length = "0x30")]
	[Token(Token = "0x600195A")]
	internal XsdValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	[Address(RVA = "0x24E42B0", Offset = "0x24E36B0", Length = "0xB1")]
	[Token(Token = "0x600196F")]
	internal void AddID(string name, object node) { }

	[Address(RVA = "0x24E4370", Offset = "0x24E3770", Length = "0x59C")]
	[Token(Token = "0x6001977")]
	private void AddIdentityConstraints() { }

	[Address(RVA = "0x24E4910", Offset = "0x24E3D10", Length = "0x38B")]
	[Token(Token = "0x6001979")]
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	[Address(RVA = "0x24E4CA0", Offset = "0x24E40A0", Length = "0x14D")]
	[Token(Token = "0x6001974")]
	private void CheckForwardRefs() { }

	[Address(RVA = "0x24E4DF0", Offset = "0x24E41F0", Length = "0x421")]
	[Token(Token = "0x600196E")]
	private void CheckValue(string value, SchemaAttDef attdef) { }

	[Address(RVA = "0x24E4CA0", Offset = "0x24E40A0", Length = "0x14D")]
	[Token(Token = "0x600195D")]
	public virtual void CompleteValidation() { }

	[Address(RVA = "0x24E5220", Offset = "0x24E4620", Length = "0x41A")]
	[Token(Token = "0x6001978")]
	private void ElementIdentityConstraints() { }

	[Address(RVA = "0x24E5640", Offset = "0x24E4A40", Length = "0xD33")]
	[Token(Token = "0x600197B")]
	private void EndElementIdentityConstraints() { }

	[Address(RVA = "0x24E6380", Offset = "0x24E5780", Length = "0xDC")]
	[Token(Token = "0x6001965")]
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	[Address(RVA = "0x2483AC0", Offset = "0x2482EC0", Length = "0x28")]
	[Token(Token = "0x6001970")]
	public virtual object FindId(string name) { }

	[Address(RVA = "0x24EA1D0", Offset = "0x24E95D0", Length = "0x385")]
	[Token(Token = "0x6001976")]
	private bool get_HasIdentityConstraints() { }

	[Address(RVA = "0x2486590", Offset = "0x2485990", Length = "0x1E")]
	[Token(Token = "0x600196B")]
	private bool get_HasSchema() { }

	[Address(RVA = "0x24865B0", Offset = "0x24859B0", Length = "0xC")]
	[Token(Token = "0x600195E")]
	private bool get_IsInlineSchemaStarted() { }

	[Address(RVA = "0x24865C0", Offset = "0x24859C0", Length = "0x3B")]
	[Token(Token = "0x600196C")]
	public virtual bool get_PreserveWhitespace() { }

	[Address(RVA = "0x24E6460", Offset = "0x24E5860", Length = "0x43A")]
	[Token(Token = "0x600195B")]
	private void Init() { }

	[Address(RVA = "0x24E68A0", Offset = "0x24E5CA0", Length = "0x50")]
	[Token(Token = "0x6001971")]
	public bool IsXSDRoot(string localName, string ns) { }

	[Address(RVA = "0x24E6E40", Offset = "0x24E6240", Length = "0x1C6")]
	[Token(Token = "0x600196A")]
	private void LoadSchema(string uri, string url) { }

	[Address(RVA = "0x24E68F0", Offset = "0x24E5CF0", Length = "0x542")]
	[Token(Token = "0x6001969")]
	private void LoadSchemaFromLocation(string uri, string url) { }

	[Address(RVA = "0x24E7010", Offset = "0x24E6410", Length = "0xF9")]
	[Token(Token = "0x6001973")]
	private void Pop() { }

	[Address(RVA = "0x24E7110", Offset = "0x24E6510", Length = "0x78C")]
	[Token(Token = "0x6001962")]
	private void ProcessElement(object particle) { }

	[Address(RVA = "0x24E78A0", Offset = "0x24E6CA0", Length = "0x256")]
	[Token(Token = "0x600195F")]
	private void ProcessInlineSchema() { }

	[Address(RVA = "0x24E7B00", Offset = "0x24E6F00", Length = "0x2AB")]
	[Token(Token = "0x600196D")]
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	[Address(RVA = "0x24E7DB0", Offset = "0x24E71B0", Length = "0x7EF")]
	[Token(Token = "0x6001963")]
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	[Address(RVA = "0x24E85A0", Offset = "0x24E79A0", Length = "0x19F")]
	[Token(Token = "0x6001972")]
	private void Push(XmlQualifiedName elementName) { }

	[Address(RVA = "0x24E8740", Offset = "0x24E7B40", Length = "0x42E")]
	[Token(Token = "0x6001966")]
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	[Address(RVA = "0x24E8B70", Offset = "0x24E7F70", Length = "0x68")]
	[Token(Token = "0x600197A")]
	private object UnWrapUnion(object typedValue) { }

	[Address(RVA = "0x24E9FA0", Offset = "0x24E93A0", Length = "0xD2")]
	[Token(Token = "0x600195C")]
	public virtual void Validate() { }

	[Address(RVA = "0x24E8BE0", Offset = "0x24E7FE0", Length = "0x26C")]
	[Token(Token = "0x6001961")]
	private object ValidateChildElement() { }

	[Address(RVA = "0x24E8E50", Offset = "0x24E8250", Length = "0x1DC")]
	[Token(Token = "0x6001960")]
	private void ValidateElement() { }

	[Address(RVA = "0x24E9030", Offset = "0x24E8430", Length = "0x342")]
	[Token(Token = "0x6001964")]
	private void ValidateEndElement() { }

	[Address(RVA = "0x24E9380", Offset = "0x24E8780", Length = "0x498")]
	[Token(Token = "0x6001968")]
	private void ValidateEndStartElement() { }

	[Address(RVA = "0x24E9880", Offset = "0x24E8C80", Length = "0x712")]
	[Token(Token = "0x6001967")]
	private void ValidateStartElement() { }

	[Address(RVA = "0x24E9820", Offset = "0x24E8C20", Length = "0x51")]
	[Token(Token = "0x6001975")]
	private void ValidateStartElementIdentityConstraints() { }

}

