namespace System.Xml.Schema;

[Token(Token = "0x20001B8")]
internal sealed class DtdValidator : BaseValidator
{
	[Token(Token = "0x20001B9")]
	private class NamespaceManager : XmlNamespaceManager
	{

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6001127")]
		public NamespaceManager() { }

		[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
		[Token(Token = "0x6001126")]
		public virtual string LookupNamespace(string prefix) { }

	}

	[Token(Token = "0x400084F")]
	private static NamespaceManager namespaceManager; //Field offset: 0x0
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000850")]
	private HWStack validationStack; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000851")]
	private Hashtable attPresence; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000852")]
	private XmlQualifiedName name; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000853")]
	private Hashtable IDs; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000854")]
	private IdRefNode idRefListHead; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000855")]
	private bool processIdentityConstraints; //Field offset: 0xA8

	[Token(Token = "0x170004C4")]
	public virtual bool PreserveWhitespace
	{
		[Address(RVA = "0x24865C0", Offset = "0x24859C0", Length = "0x3B")]
		[Token(Token = "0x6001119")]
		 get { } //Length: 59
	}

	[Address(RVA = "0x25ABA20", Offset = "0x25AAE20", Length = "0x73")]
	[Token(Token = "0x6001125")]
	private static DtdValidator() { }

	[Address(RVA = "0x25ABAA0", Offset = "0x25AAEA0", Length = "0x203")]
	[Token(Token = "0x600110D")]
	internal DtdValidator(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	[Address(RVA = "0x25A8E80", Offset = "0x25A8280", Length = "0xB1")]
	[Token(Token = "0x600111C")]
	internal void AddID(string name, object node) { }

	[Address(RVA = "0x25A8F40", Offset = "0x25A8340", Length = "0x328")]
	[Token(Token = "0x6001124")]
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	[Address(RVA = "0x25A9270", Offset = "0x25A8670", Length = "0x14D")]
	[Token(Token = "0x6001120")]
	private void CheckForwardRefs() { }

	[Address(RVA = "0x25A93C0", Offset = "0x25A87C0", Length = "0x4DB")]
	[Token(Token = "0x600111B")]
	private void CheckValue(string value, SchemaAttDef attdef) { }

	[Address(RVA = "0x25A98A0", Offset = "0x25A8CA0", Length = "0x174")]
	[Token(Token = "0x6001117")]
	public virtual void CompleteValidation() { }

	[Address(RVA = "0x25A9A20", Offset = "0x25A8E20", Length = "0x28")]
	[Token(Token = "0x600111D")]
	public virtual object FindId(string name) { }

	[Address(RVA = "0x25A9A50", Offset = "0x25A8E50", Length = "0x1E5")]
	[Token(Token = "0x600111E")]
	private bool GenEntity(XmlQualifiedName qname) { }

	[Address(RVA = "0x24865C0", Offset = "0x24859C0", Length = "0x3B")]
	[Token(Token = "0x6001119")]
	public virtual bool get_PreserveWhitespace() { }

	[Address(RVA = "0x25A9C40", Offset = "0x25A9040", Length = "0xA5")]
	[Token(Token = "0x600111F")]
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	[Address(RVA = "0x25A9CF0", Offset = "0x25A90F0", Length = "0x16C")]
	[Token(Token = "0x600110E")]
	private void Init() { }

	[Address(RVA = "0x25A9E60", Offset = "0x25A9260", Length = "0x8C")]
	[Token(Token = "0x6001110")]
	private bool MeetsStandAloneConstraint() { }

	[Address(RVA = "0x25A9EF0", Offset = "0x25A92F0", Length = "0xD7")]
	[Token(Token = "0x6001122")]
	private bool Pop() { }

	[Address(RVA = "0x25A9FD0", Offset = "0x25A93D0", Length = "0x150")]
	[Token(Token = "0x6001116")]
	private void ProcessElement() { }

	[Address(RVA = "0x25AA130", Offset = "0x25A9530", Length = "0x2C5")]
	[Token(Token = "0x600111A")]
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	[Address(RVA = "0x25AA400", Offset = "0x25A9800", Length = "0x168")]
	[Token(Token = "0x6001121")]
	private void Push(XmlQualifiedName elementName) { }

	[Address(RVA = "0x25AA570", Offset = "0x25A9970", Length = "0x2B1")]
	[Token(Token = "0x6001123")]
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	[Address(RVA = "0x25AB6A0", Offset = "0x25AAAA0", Length = "0x344")]
	[Token(Token = "0x600110F")]
	public virtual void Validate() { }

	[Address(RVA = "0x25AA830", Offset = "0x25A9C30", Length = "0x1B7")]
	[Token(Token = "0x6001113")]
	private void ValidateChildElement() { }

	[Address(RVA = "0x25AA9F0", Offset = "0x25A9DF0", Length = "0x3F9")]
	[Token(Token = "0x6001112")]
	private void ValidateElement() { }

	[Address(RVA = "0x25AADF0", Offset = "0x25AA1F0", Length = "0x1FF")]
	[Token(Token = "0x6001118")]
	private void ValidateEndElement() { }

	[Address(RVA = "0x25AAFF0", Offset = "0x25AA3F0", Length = "0x19C")]
	[Token(Token = "0x6001115")]
	private void ValidateEndStartElement() { }

	[Address(RVA = "0x25AB190", Offset = "0x25AA590", Length = "0xA7")]
	[Token(Token = "0x6001111")]
	private void ValidatePIComment() { }

	[Address(RVA = "0x25AB240", Offset = "0x25AA640", Length = "0x455")]
	[Token(Token = "0x6001114")]
	private void ValidateStartElement() { }

}

