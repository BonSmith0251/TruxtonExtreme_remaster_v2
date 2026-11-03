namespace System.Xml.Schema;

[Token(Token = "0x20001F7")]
[XmlRoot("schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
public class XmlSchema : XmlSchemaObject
{
	[Token(Token = "0x4000AE0")]
	private static int globalIdCounter; //Field offset: 0x0
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000ACA")]
	private XmlSchemaForm attributeFormDefault; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000ACB")]
	private XmlSchemaForm elementFormDefault; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000ACC")]
	private XmlSchemaDerivationMethod blockDefault; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000ACD")]
	private XmlSchemaDerivationMethod finalDefault; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000ACE")]
	private string targetNs; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000ACF")]
	private string version; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000AD0")]
	private XmlSchemaObjectCollection includes; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000AD1")]
	private XmlSchemaObjectCollection items; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000AD2")]
	private string id; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000AD3")]
	private XmlAttribute[] moreAttributes; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000AD4")]
	private bool isCompiled; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4000AD5")]
	private bool isCompiledBySet; //Field offset: 0x79
	[FieldOffset(Offset = "0x7A")]
	[Token(Token = "0x4000AD6")]
	private bool isPreprocessed; //Field offset: 0x7A
	[FieldOffset(Offset = "0x7B")]
	[Token(Token = "0x4000AD7")]
	private bool isRedefined; //Field offset: 0x7B
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000AD8")]
	private int errorCount; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000AD9")]
	private XmlSchemaObjectTable attributes; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000ADA")]
	private XmlSchemaObjectTable attributeGroups; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000ADB")]
	private XmlSchemaObjectTable elements; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000ADC")]
	private XmlSchemaObjectTable types; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000ADD")]
	private XmlSchemaObjectTable groups; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000ADE")]
	private XmlSchemaObjectTable notations; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000ADF")]
	private XmlSchemaObjectTable identityConstraints; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000AE1")]
	private ArrayList importedSchemas; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000AE2")]
	private ArrayList importedNamespaces; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000AE3")]
	private int schemaId; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000AE4")]
	private Uri baseUri; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000AE5")]
	private bool isChameleon; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000AE6")]
	private Hashtable ids; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000AE7")]
	private XmlDocument document; //Field offset: 0xE8

	[DefaultValue(XmlSchemaForm::None (0))]
	[Token(Token = "0x17000544")]
	[XmlAttribute("attributeFormDefault")]
	public XmlSchemaForm AttributeFormDefault
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6001413")]
		 get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x6001414")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000550")]
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups
	{
		[Address(RVA = "0x2490A80", Offset = "0x248FE80", Length = "0x75")]
		[Token(Token = "0x6001428")]
		 get { } //Length: 117
	}

	[Token(Token = "0x1700054F")]
	[XmlIgnore]
	public XmlSchemaObjectTable Attributes
	{
		[Address(RVA = "0x2490B00", Offset = "0x248FF00", Length = "0x75")]
		[Token(Token = "0x6001427")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000557")]
	[XmlIgnore]
	internal Uri BaseUri
	{
		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[Token(Token = "0x6001430")]
		internal get { } //Length: 8
		[Address(RVA = "0x20E7790", Offset = "0x20E6B90", Length = "0x13")]
		[Token(Token = "0x6001431")]
		internal set { } //Length: 19
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[Token(Token = "0x17000545")]
	[XmlAttribute("blockDefault")]
	public XmlSchemaDerivationMethod BlockDefault
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x6001415")]
		 get { } //Length: 4
		[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
		[Token(Token = "0x6001416")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700055B")]
	[XmlIgnore]
	internal XmlDocument Document
	{
		[Address(RVA = "0x2490B80", Offset = "0x248FF80", Length = "0x75")]
		[Token(Token = "0x6001436")]
		internal get { } //Length: 117
	}

	[DefaultValue(XmlSchemaForm::None (0))]
	[Token(Token = "0x17000547")]
	[XmlAttribute("elementFormDefault")]
	public XmlSchemaForm ElementFormDefault
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x6001419")]
		 get { } //Length: 4
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[Token(Token = "0x600141A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000552")]
	[XmlIgnore]
	public XmlSchemaObjectTable Elements
	{
		[Address(RVA = "0x2490C00", Offset = "0x2490000", Length = "0x75")]
		[Token(Token = "0x600142A")]
		 get { } //Length: 117
	}

	[Token(Token = "0x1700055C")]
	[XmlIgnore]
	internal int ErrorCount
	{
		[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
		[Token(Token = "0x6001437")]
		internal get { } //Length: 4
		[Address(RVA = "0x1D16670", Offset = "0x1D15A70", Length = "0x4")]
		[Token(Token = "0x6001438")]
		internal set { } //Length: 4
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[Token(Token = "0x17000546")]
	[XmlAttribute("finalDefault")]
	public XmlSchemaDerivationMethod FinalDefault
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x6001417")]
		 get { } //Length: 4
		[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
		[Token(Token = "0x6001418")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000554")]
	[XmlIgnore]
	public XmlSchemaObjectTable Groups
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x600142D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000553")]
	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x600142B")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x600142C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700055D")]
	[XmlIgnore]
	internal virtual string IdAttribute
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x600143B")]
		internal get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x600143C")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000556")]
	[XmlIgnore]
	internal XmlSchemaObjectTable IdentityConstraints
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[Token(Token = "0x600142F")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700055A")]
	[XmlIgnore]
	internal Hashtable Ids
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[Token(Token = "0x6001435")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700055F")]
	internal ArrayList ImportedNamespaces
	{
		[Address(RVA = "0x2490C80", Offset = "0x2490080", Length = "0x75")]
		[Token(Token = "0x6001441")]
		internal get { } //Length: 117
	}

	[Token(Token = "0x1700055E")]
	internal ArrayList ImportedSchemas
	{
		[Address(RVA = "0x2490D00", Offset = "0x2490100", Length = "0x75")]
		[Token(Token = "0x6001440")]
		internal get { } //Length: 117
	}

	[Token(Token = "0x1700054A")]
	[XmlElement("import", typeof(XmlSchemaImport))]
	[XmlElement("include", typeof(XmlSchemaInclude))]
	[XmlElement("redefine", typeof(XmlSchemaRedefine))]
	public XmlSchemaObjectCollection Includes
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600141F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000559")]
	[XmlIgnore]
	internal bool IsChameleon
	{
		[Address(RVA = "0x2490D80", Offset = "0x2490180", Length = "0x8")]
		[Token(Token = "0x6001433")]
		internal get { } //Length: 8
		[Address(RVA = "0x2490E90", Offset = "0x2490290", Length = "0x7")]
		[Token(Token = "0x6001434")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700054C")]
	[XmlIgnore]
	internal bool IsCompiledBySet
	{
		[Address(RVA = "0x248DA80", Offset = "0x248CE80", Length = "0x5")]
		[Token(Token = "0x6001421")]
		internal get { } //Length: 5
		[Address(RVA = "0x2490EA0", Offset = "0x24902A0", Length = "0x4")]
		[Token(Token = "0x6001422")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700054D")]
	[XmlIgnore]
	internal bool IsPreprocessed
	{
		[Address(RVA = "0x231DDD0", Offset = "0x231D1D0", Length = "0x5")]
		[Token(Token = "0x6001423")]
		internal get { } //Length: 5
		[Address(RVA = "0x231E010", Offset = "0x231D410", Length = "0x4")]
		[Token(Token = "0x6001424")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700054E")]
	[XmlIgnore]
	internal bool IsRedefined
	{
		[Address(RVA = "0x248DAC0", Offset = "0x248CEC0", Length = "0x5")]
		[Token(Token = "0x6001425")]
		internal get { } //Length: 5
		[Address(RVA = "0x2490EB0", Offset = "0x24902B0", Length = "0x1FF")]
		[Token(Token = "0x6001426")]
		internal set { } //Length: 511
	}

	[Token(Token = "0x1700054B")]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("notation", typeof(XmlSchemaNotation))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection Items
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6001420")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000555")]
	[XmlIgnore]
	public XmlSchemaObjectTable Notations
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x600142E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000558")]
	[XmlIgnore]
	internal int SchemaId
	{
		[Address(RVA = "0x2490D90", Offset = "0x2490190", Length = "0x6A")]
		[Token(Token = "0x6001432")]
		internal get { } //Length: 106
	}

	[Token(Token = "0x17000551")]
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes
	{
		[Address(RVA = "0x2490E00", Offset = "0x2490200", Length = "0x75")]
		[Token(Token = "0x6001429")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000548")]
	[XmlAttribute("targetNamespace", DataType = "anyURI")]
	public string TargetNamespace
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600141B")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x600141C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000549")]
	[XmlAttribute("version", DataType = "token")]
	public string Version
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x600141D")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x600141E")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2490830", Offset = "0x248FC30", Length = "0x39")]
	[Token(Token = "0x6001443")]
	private static XmlSchema() { }

	[Address(RVA = "0x2490870", Offset = "0x248FC70", Length = "0x208")]
	[Token(Token = "0x600140F")]
	public XmlSchema() { }

	[Address(RVA = "0x248FC40", Offset = "0x248F040", Length = "0x67")]
	[Token(Token = "0x600143F")]
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	[Address(RVA = "0x248FCB0", Offset = "0x248F0B0", Length = "0x145")]
	[Token(Token = "0x6001439")]
	internal XmlSchema Clone() { }

	[Address(RVA = "0x248FEC0", Offset = "0x248F2C0", Length = "0x1E4")]
	[Token(Token = "0x6001411")]
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	[Address(RVA = "0x248FE00", Offset = "0x248F200", Length = "0xB3")]
	[Token(Token = "0x6001412")]
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	[Address(RVA = "0x24900B0", Offset = "0x248F4B0", Length = "0x440")]
	[Token(Token = "0x600143A")]
	internal XmlSchema DeepClone() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6001413")]
	public XmlSchemaForm get_AttributeFormDefault() { }

	[Address(RVA = "0x2490A80", Offset = "0x248FE80", Length = "0x75")]
	[Token(Token = "0x6001428")]
	public XmlSchemaObjectTable get_AttributeGroups() { }

	[Address(RVA = "0x2490B00", Offset = "0x248FF00", Length = "0x75")]
	[Token(Token = "0x6001427")]
	public XmlSchemaObjectTable get_Attributes() { }

	[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
	[Token(Token = "0x6001430")]
	internal Uri get_BaseUri() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x6001415")]
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	[Address(RVA = "0x2490B80", Offset = "0x248FF80", Length = "0x75")]
	[Token(Token = "0x6001436")]
	internal XmlDocument get_Document() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x6001419")]
	public XmlSchemaForm get_ElementFormDefault() { }

	[Address(RVA = "0x2490C00", Offset = "0x2490000", Length = "0x75")]
	[Token(Token = "0x600142A")]
	public XmlSchemaObjectTable get_Elements() { }

	[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
	[Token(Token = "0x6001437")]
	internal int get_ErrorCount() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x6001417")]
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x600142D")]
	public XmlSchemaObjectTable get_Groups() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x600142B")]
	public string get_Id() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x600143B")]
	internal virtual string get_IdAttribute() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[Token(Token = "0x600142F")]
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[Token(Token = "0x6001435")]
	internal Hashtable get_Ids() { }

	[Address(RVA = "0x2490C80", Offset = "0x2490080", Length = "0x75")]
	[Token(Token = "0x6001441")]
	internal ArrayList get_ImportedNamespaces() { }

	[Address(RVA = "0x2490D00", Offset = "0x2490100", Length = "0x75")]
	[Token(Token = "0x6001440")]
	internal ArrayList get_ImportedSchemas() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600141F")]
	public XmlSchemaObjectCollection get_Includes() { }

	[Address(RVA = "0x2490D80", Offset = "0x2490180", Length = "0x8")]
	[Token(Token = "0x6001433")]
	internal bool get_IsChameleon() { }

	[Address(RVA = "0x248DA80", Offset = "0x248CE80", Length = "0x5")]
	[Token(Token = "0x6001421")]
	internal bool get_IsCompiledBySet() { }

	[Address(RVA = "0x231DDD0", Offset = "0x231D1D0", Length = "0x5")]
	[Token(Token = "0x6001423")]
	internal bool get_IsPreprocessed() { }

	[Address(RVA = "0x248DAC0", Offset = "0x248CEC0", Length = "0x5")]
	[Token(Token = "0x6001425")]
	internal bool get_IsRedefined() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6001420")]
	public XmlSchemaObjectCollection get_Items() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x600142E")]
	public XmlSchemaObjectTable get_Notations() { }

	[Address(RVA = "0x2490D90", Offset = "0x2490190", Length = "0x6A")]
	[Token(Token = "0x6001432")]
	internal int get_SchemaId() { }

	[Address(RVA = "0x2490E00", Offset = "0x2490200", Length = "0x75")]
	[Token(Token = "0x6001429")]
	public XmlSchemaObjectTable get_SchemaTypes() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600141B")]
	public string get_TargetNamespace() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x600141D")]
	public string get_Version() { }

	[Address(RVA = "0x2490500", Offset = "0x248F900", Length = "0x1C5")]
	[Token(Token = "0x6001442")]
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	[Address(RVA = "0x24906D0", Offset = "0x248FAD0", Length = "0x153")]
	[Token(Token = "0x6001410")]
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x6001414")]
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	[Address(RVA = "0x20E7790", Offset = "0x20E6B90", Length = "0x13")]
	[Token(Token = "0x6001431")]
	internal void set_BaseUri(Uri value) { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[Token(Token = "0x6001416")]
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[Token(Token = "0x600141A")]
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	[Address(RVA = "0x1D16670", Offset = "0x1D15A70", Length = "0x4")]
	[Token(Token = "0x6001438")]
	internal void set_ErrorCount(int value) { }

	[Address(RVA = "0x2490E80", Offset = "0x2490280", Length = "0x4")]
	[Token(Token = "0x6001418")]
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x600142C")]
	public void set_Id(string value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x600143C")]
	internal virtual void set_IdAttribute(string value) { }

	[Address(RVA = "0x2490E90", Offset = "0x2490290", Length = "0x7")]
	[Token(Token = "0x6001434")]
	internal void set_IsChameleon(bool value) { }

	[Address(RVA = "0x2490EA0", Offset = "0x24902A0", Length = "0x4")]
	[Token(Token = "0x6001422")]
	internal void set_IsCompiledBySet(bool value) { }

	[Address(RVA = "0x231E010", Offset = "0x231D410", Length = "0x4")]
	[Token(Token = "0x6001424")]
	internal void set_IsPreprocessed(bool value) { }

	[Address(RVA = "0x2490EB0", Offset = "0x24902B0", Length = "0x1FF")]
	[Token(Token = "0x6001426")]
	internal void set_IsRedefined(bool value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x600141C")]
	public void set_TargetNamespace(string value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x600141E")]
	public void set_Version(string value) { }

	[Address(RVA = "0x1D14EE0", Offset = "0x1D142E0", Length = "0x4")]
	[Token(Token = "0x600143D")]
	internal void SetIsCompiled(bool isCompiled) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x600143E")]
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

