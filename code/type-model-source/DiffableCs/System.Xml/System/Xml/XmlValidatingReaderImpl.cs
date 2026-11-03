namespace System.Xml;

[Token(Token = "0x2000070")]
internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
{
	[Token(Token = "0x2000071")]
	private enum ParsingFunction : int
	{
		Read = 0,
		Init = 1,
		ParseDtdFromContext = 2,
		ResolveEntityInternally = 3,
		InReadBinaryContent = 4,
		ReaderClosed = 5,
		Error = 6,
		None = 7,
	}

	[Token(Token = "0x2000072")]
	public class ValidationEventHandling : IValidationEventHandling
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000321")]
		private XmlValidatingReaderImpl reader; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000322")]
		private ValidationEventHandler eventHandler; //Field offset: 0x18

		[Token(Token = "0x17000162")]
		private override object System.Xml.IValidationEventHandling.EventHandler
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000624")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000623")]
		internal ValidationEventHandling(XmlValidatingReaderImpl reader) { }

		[Address(RVA = "0x24FDF00", Offset = "0x24FD300", Length = "0x9F")]
		[Token(Token = "0x6000626")]
		internal void AddHandler(ValidationEventHandler handler) { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000624")]
		private override object System.Xml.IValidationEventHandling.get_EventHandler() { }

		[Address(RVA = "0x24FDFA0", Offset = "0x24FD3A0", Length = "0x11F")]
		[Token(Token = "0x6000625")]
		private override void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	}

	[Token(Token = "0x4000317")]
	private static XmlResolver s_tempResolver; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400030B")]
	private XmlReader coreReader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400030C")]
	private XmlTextReaderImpl coreReaderImpl; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400030D")]
	private IXmlNamespaceResolver coreReaderNSResolver; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400030E")]
	private ValidationType validationType; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400030F")]
	private BaseValidator validator; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000310")]
	private XmlSchemaCollection schemaCollection; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000311")]
	private bool processIdentityConstraints; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000312")]
	private ParsingFunction parsingFunction; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000313")]
	private ValidationEventHandling eventHandling; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000314")]
	private XmlParserContext parserContext; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000315")]
	private ReadContentAsBinaryHelper readBinaryHelper; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000316")]
	private XmlReader outerReader; //Field offset: 0x60

	[Token(Token = "0x17000155")]
	public virtual int AttributeCount
	{
		[Address(RVA = "0x1FEF050", Offset = "0x1FEE450", Length = "0x2A")]
		[Token(Token = "0x60005F7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700014C")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
		[Token(Token = "0x60005EE")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000156")]
	public virtual bool CanResolveEntity
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000604")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700014B")]
	public virtual int Depth
	{
		[Address(RVA = "0x23700D0", Offset = "0x236F4D0", Length = "0x2A")]
		[Token(Token = "0x60005ED")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000161")]
	internal virtual IDtdInfo DtdInfo
	{
		[Address(RVA = "0x2508D60", Offset = "0x2508160", Length = "0x2A")]
		[Token(Token = "0x6000621")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x17000153")]
	public virtual bool EOF
	{
		[Address(RVA = "0x2370100", Offset = "0x236F500", Length = "0x2A")]
		[Token(Token = "0x60005F5")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700014E")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
		[Token(Token = "0x60005F0")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700014D")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
		[Token(Token = "0x60005EF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000157")]
	public override int LineNumber
	{
		[Address(RVA = "0x2508D90", Offset = "0x2508190", Length = "0x98")]
		[Token(Token = "0x6000609")]
		 get { } //Length: 152
	}

	[Token(Token = "0x17000158")]
	public override int LinePosition
	{
		[Address(RVA = "0x2508E30", Offset = "0x2508230", Length = "0x98")]
		[Token(Token = "0x600060A")]
		 get { } //Length: 152
	}

	[Token(Token = "0x17000147")]
	public virtual string LocalName
	{
		[Address(RVA = "0x1DFC7E0", Offset = "0x1DFBBE0", Length = "0x2A")]
		[Token(Token = "0x60005E9")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000146")]
	public virtual string Name
	{
		[Address(RVA = "0x21A98A0", Offset = "0x21A8CA0", Length = "0x2A")]
		[Token(Token = "0x60005E8")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700015D")]
	internal virtual XmlNamespaceManager NamespaceManager
	{
		[Address(RVA = "0x2508ED0", Offset = "0x25082D0", Length = "0x2A")]
		[Token(Token = "0x600061B")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x1700015B")]
	internal bool Namespaces
	{
		[Address(RVA = "0x2508F00", Offset = "0x2508300", Length = "0x1E")]
		[Token(Token = "0x6000612")]
		internal get { } //Length: 30
	}

	[Token(Token = "0x17000148")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
		[Token(Token = "0x60005EA")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000154")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x21BB7E0", Offset = "0x21BABE0", Length = "0x2A")]
		[Token(Token = "0x60005F6")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000145")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x2370160", Offset = "0x236F560", Length = "0x2A")]
		[Token(Token = "0x60005E7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000149")]
	public virtual string Prefix
	{
		[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
		[Token(Token = "0x60005EB")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700014F")]
	public virtual char QuoteChar
	{
		[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
		[Token(Token = "0x60005F1")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000152")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0x2508F20", Offset = "0x2508320", Length = "0x37")]
		[Token(Token = "0x60005F4")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700015A")]
	internal XmlSchemaCollection Schemas
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000611")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700015F")]
	internal object SchemaTypeObject
	{
		[Address(RVA = "0x2509070", Offset = "0x2508470", Length = "0x1E")]
		[Token(Token = "0x600061D")]
		internal set { } //Length: 30
	}

	[Token(Token = "0x17000144")]
	public virtual XmlReaderSettings Settings
	{
		[Address(RVA = "0x2508F60", Offset = "0x2508360", Length = "0xCC")]
		[Token(Token = "0x60005E6")]
		 get { } //Length: 204
	}

	[Token(Token = "0x1700015E")]
	internal bool StandAlone
	{
		[Address(RVA = "0x2509030", Offset = "0x2508430", Length = "0x1E")]
		[Token(Token = "0x600061C")]
		internal get { } //Length: 30
	}

	[Token(Token = "0x17000160")]
	internal object TypedValueObject
	{
		[Address(RVA = "0x2509050", Offset = "0x2508450", Length = "0x1D")]
		[Token(Token = "0x600061E")]
		internal get { } //Length: 29
		[Address(RVA = "0x2509090", Offset = "0x2508490", Length = "0x1E")]
		[Token(Token = "0x600061F")]
		internal set { } //Length: 30
	}

	[Token(Token = "0x17000159")]
	internal ValidationType ValidationType
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000610")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700015C")]
	internal BaseValidator Validator
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000619")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x600061A")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700014A")]
	public virtual string Value
	{
		[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
		[Token(Token = "0x60005EC")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000151")]
	public virtual string XmlLang
	{
		[Address(RVA = "0x23701C0", Offset = "0x236F5C0", Length = "0x2A")]
		[Token(Token = "0x60005F3")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000150")]
	public virtual XmlSpace XmlSpace
	{
		[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
		[Token(Token = "0x60005F2")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x25087F0", Offset = "0x2507BF0", Length = "0x564")]
	[Token(Token = "0x60005E5")]
	internal XmlValidatingReaderImpl(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	[Address(RVA = "0x25078C0", Offset = "0x2506CC0", Length = "0x1E")]
	[Token(Token = "0x6000620")]
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	[Address(RVA = "0x25078E0", Offset = "0x2506CE0", Length = "0x37")]
	[Token(Token = "0x6000601")]
	public virtual void Close() { }

	[Address(RVA = "0x1FEF050", Offset = "0x1FEE450", Length = "0x2A")]
	[Token(Token = "0x60005F7")]
	public virtual int get_AttributeCount() { }

	[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
	[Token(Token = "0x60005EE")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000604")]
	public virtual bool get_CanResolveEntity() { }

	[Address(RVA = "0x23700D0", Offset = "0x236F4D0", Length = "0x2A")]
	[Token(Token = "0x60005ED")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x2508D60", Offset = "0x2508160", Length = "0x2A")]
	[Token(Token = "0x6000621")]
	internal virtual IDtdInfo get_DtdInfo() { }

	[Address(RVA = "0x2370100", Offset = "0x236F500", Length = "0x2A")]
	[Token(Token = "0x60005F5")]
	public virtual bool get_EOF() { }

	[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
	[Token(Token = "0x60005F0")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
	[Token(Token = "0x60005EF")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x2508D90", Offset = "0x2508190", Length = "0x98")]
	[Token(Token = "0x6000609")]
	public override int get_LineNumber() { }

	[Address(RVA = "0x2508E30", Offset = "0x2508230", Length = "0x98")]
	[Token(Token = "0x600060A")]
	public override int get_LinePosition() { }

	[Address(RVA = "0x1DFC7E0", Offset = "0x1DFBBE0", Length = "0x2A")]
	[Token(Token = "0x60005E9")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x21A98A0", Offset = "0x21A8CA0", Length = "0x2A")]
	[Token(Token = "0x60005E8")]
	public virtual string get_Name() { }

	[Address(RVA = "0x2508ED0", Offset = "0x25082D0", Length = "0x2A")]
	[Token(Token = "0x600061B")]
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	[Address(RVA = "0x2508F00", Offset = "0x2508300", Length = "0x1E")]
	[Token(Token = "0x6000612")]
	internal bool get_Namespaces() { }

	[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
	[Token(Token = "0x60005EA")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x21BB7E0", Offset = "0x21BABE0", Length = "0x2A")]
	[Token(Token = "0x60005F6")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x2370160", Offset = "0x236F560", Length = "0x2A")]
	[Token(Token = "0x60005E7")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
	[Token(Token = "0x60005EB")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
	[Token(Token = "0x60005F1")]
	public virtual char get_QuoteChar() { }

	[Address(RVA = "0x2508F20", Offset = "0x2508320", Length = "0x37")]
	[Token(Token = "0x60005F4")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000611")]
	internal XmlSchemaCollection get_Schemas() { }

	[Address(RVA = "0x2508F60", Offset = "0x2508360", Length = "0xCC")]
	[Token(Token = "0x60005E6")]
	public virtual XmlReaderSettings get_Settings() { }

	[Address(RVA = "0x2509030", Offset = "0x2508430", Length = "0x1E")]
	[Token(Token = "0x600061C")]
	internal bool get_StandAlone() { }

	[Address(RVA = "0x2509050", Offset = "0x2508450", Length = "0x1D")]
	[Token(Token = "0x600061E")]
	internal object get_TypedValueObject() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000610")]
	internal ValidationType get_ValidationType() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000619")]
	internal BaseValidator get_Validator() { }

	[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
	[Token(Token = "0x60005EC")]
	public virtual string get_Value() { }

	[Address(RVA = "0x23701C0", Offset = "0x236F5C0", Length = "0x2A")]
	[Token(Token = "0x60005F3")]
	public virtual string get_XmlLang() { }

	[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
	[Token(Token = "0x60005F2")]
	public virtual XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x236FEB0", Offset = "0x236F2B0", Length = "0x2A")]
	[Token(Token = "0x60005F9")]
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	[Address(RVA = "0x226EDE0", Offset = "0x226E1E0", Length = "0x2A")]
	[Token(Token = "0x60005F8")]
	public virtual string GetAttribute(string name) { }

	[Address(RVA = "0x236FEE0", Offset = "0x236F2E0", Length = "0x2A")]
	[Token(Token = "0x60005FA")]
	public virtual string GetAttribute(int i) { }

	[Address(RVA = "0x2507920", Offset = "0x2506D20", Length = "0xAE")]
	[Token(Token = "0x600060E")]
	internal IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x25079D0", Offset = "0x2506DD0", Length = "0xF8")]
	[Token(Token = "0x6000617")]
	private XmlResolver GetResolver() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000608")]
	public override bool HasLineInfo() { }

	[Address(RVA = "0x2507AD0", Offset = "0x2506ED0", Length = "0x2A")]
	[Token(Token = "0x6000602")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x2507B00", Offset = "0x2506F00", Length = "0x58")]
	[Token(Token = "0x600060F")]
	internal string LookupPrefix(string namespaceName) { }

	[Address(RVA = "0x2507B60", Offset = "0x2506F60", Length = "0xBE")]
	[Token(Token = "0x6000606")]
	internal void MoveOffEntityReference() { }

	[Address(RVA = "0x2507C20", Offset = "0x2507020", Length = "0x37")]
	[Token(Token = "0x60005FC")]
	public virtual void MoveToAttribute(int i) { }

	[Address(RVA = "0x2507C60", Offset = "0x2507060", Length = "0x45")]
	[Token(Token = "0x60005FB")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x2507CB0", Offset = "0x25070B0", Length = "0x45")]
	[Token(Token = "0x60005FF")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x2507D00", Offset = "0x2507100", Length = "0x45")]
	[Token(Token = "0x60005FD")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x2507D50", Offset = "0x2507150", Length = "0x45")]
	[Token(Token = "0x60005FE")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x2507DA0", Offset = "0x25071A0", Length = "0x1C3")]
	[Token(Token = "0x6000613")]
	private void ParseDtdFromParserContext() { }

	[Address(RVA = "0x2507F70", Offset = "0x2507370", Length = "0x110")]
	[Token(Token = "0x6000618")]
	private void ProcessCoreReaderEvent() { }

	[Address(RVA = "0x25081D0", Offset = "0x25075D0", Length = "0x24")]
	[Token(Token = "0x6000600")]
	public virtual bool Read() { }

	[Address(RVA = "0x2508090", Offset = "0x2507490", Length = "0x62")]
	[Token(Token = "0x6000603")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x2508100", Offset = "0x2507500", Length = "0xC4")]
	[Token(Token = "0x6000607")]
	public virtual string ReadString() { }

	[Address(RVA = "0x2508430", Offset = "0x2507830", Length = "0x37")]
	[Token(Token = "0x6000605")]
	public virtual void ResolveEntity() { }

	[Address(RVA = "0x2508380", Offset = "0x2507780", Length = "0xA0")]
	[Token(Token = "0x6000615")]
	private void ResolveEntityInternally() { }

	[Address(RVA = "0x2509070", Offset = "0x2508470", Length = "0x1E")]
	[Token(Token = "0x600061D")]
	internal void set_SchemaTypeObject(object value) { }

	[Address(RVA = "0x2509090", Offset = "0x2508490", Length = "0x1E")]
	[Token(Token = "0x600061F")]
	internal void set_TypedValueObject(object value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x600061A")]
	internal void set_Validator(BaseValidator value) { }

	[Address(RVA = "0x2508470", Offset = "0x2507870", Length = "0x1AB")]
	[Token(Token = "0x6000616")]
	private void SetupValidation(ValidationType valType) { }

	[Address(RVA = "0x2507920", Offset = "0x2506D20", Length = "0xAE")]
	[Token(Token = "0x600060B")]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x2422630", Offset = "0x2421A30", Length = "0x14")]
	[Token(Token = "0x600060C")]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[Address(RVA = "0x2507B00", Offset = "0x2506F00", Length = "0x58")]
	[Token(Token = "0x600060D")]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	[Address(RVA = "0x2508620", Offset = "0x2507A20", Length = "0x135")]
	[Token(Token = "0x6000622")]
	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	[Address(RVA = "0x2508760", Offset = "0x2507B60", Length = "0x80")]
	[Token(Token = "0x6000614")]
	private void ValidateDtd() { }

}

