namespace System.Data;

[Token(Token = "0x2000096")]
internal sealed class XSDSchema : XMLSchema
{
	[Token(Token = "0x2000097")]
	private sealed class NameType : IComparable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002F2")]
		public readonly string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002F3")]
		public readonly Type type; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x60007C8")]
		public NameType(string n, Type t) { }

		[Address(RVA = "0x234A270", Offset = "0x2349670", Length = "0x45")]
		[Token(Token = "0x60007C9")]
		public override int CompareTo(object obj) { }

	}

	[Token(Token = "0x40002F1")]
	private static readonly NameType[] s_mapNameTypeXsd; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002DE")]
	private XmlSchemaSet _schemaSet; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002DF")]
	private XmlSchemaElement _dsElement; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E0")]
	private DataSet _ds; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002E1")]
	private string _schemaName; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002E2")]
	private ArrayList _columnExpressions; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002E3")]
	private Hashtable _constraintNodes; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002E4")]
	private ArrayList _refTables; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002E5")]
	private ArrayList _complexTypes; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002E6")]
	private XmlSchemaObjectCollection _annotations; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002E7")]
	private XmlSchemaObjectCollection _elements; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002E8")]
	private Hashtable _attributes; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002E9")]
	private Hashtable _elementsTable; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002EA")]
	private Hashtable _attributeGroups; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002EB")]
	private Hashtable _schemaTypes; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002EC")]
	private Hashtable _expressions; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40002ED")]
	private Dictionary<DataTable, List`1<DataTable>> _tableDictionary; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002EE")]
	private Hashtable _udSimpleTypes; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40002EF")]
	private Hashtable _existingSimpleTypeMap; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40002F0")]
	private bool _fromInference; //Field offset: 0xA0

	[Token(Token = "0x17000128")]
	internal bool FromInference
	{
		[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
		[Token(Token = "0x6000791")]
		internal get { } //Length: 8
		[Address(RVA = "0x5B8EB0", Offset = "0x5B82B0", Length = "0x7")]
		[Token(Token = "0x6000792")]
		internal set { } //Length: 7
	}

	[Address(RVA = "0x23669C0", Offset = "0x2365DC0", Length = "0x16AC")]
	[Token(Token = "0x60007C7")]
	private static XSDSchema() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60007C6")]
	public XSDSchema() { }

	[Address(RVA = "0x2357CC0", Offset = "0x23570C0", Length = "0x1A1")]
	[Token(Token = "0x60007BF")]
	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	[Address(RVA = "0x2357E70", Offset = "0x2357270", Length = "0x264")]
	[Token(Token = "0x60007AB")]
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	[Address(RVA = "0x2358A00", Offset = "0x2357E00", Length = "0x8B")]
	[Token(Token = "0x6000793")]
	private void CollectElementsAnnotations(XmlSchema schema) { }

	[Address(RVA = "0x23580E0", Offset = "0x23574E0", Length = "0x916")]
	[Token(Token = "0x6000794")]
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	[Address(RVA = "0x2358A90", Offset = "0x2357E90", Length = "0x1C3")]
	[Token(Token = "0x600079F")]
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	[Address(RVA = "0x2358C60", Offset = "0x2358060", Length = "0x52F")]
	[Token(Token = "0x60007A0")]
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	[Address(RVA = "0x2359190", Offset = "0x2358590", Length = "0x1BA")]
	[Token(Token = "0x60007AA")]
	internal DataColumn FindField(DataTable table, string field) { }

	[Address(RVA = "0x2359350", Offset = "0x2358750", Length = "0xD4")]
	[Token(Token = "0x60007B6")]
	private static NameType FindNameType(string name) { }

	[Address(RVA = "0x2359430", Offset = "0x2358830", Length = "0x3E6")]
	[Token(Token = "0x60007B9")]
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	[Address(RVA = "0x208F6E0", Offset = "0x208EAE0", Length = "0x8")]
	[Token(Token = "0x6000791")]
	internal bool get_FromInference() { }

	[Address(RVA = "0x2359820", Offset = "0x2358C20", Length = "0x152")]
	[Token(Token = "0x60007AC")]
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	[Address(RVA = "0x2359980", Offset = "0x2358D80", Length = "0x149")]
	[Token(Token = "0x60007B3")]
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	[Address(RVA = "0x2359AD0", Offset = "0x2358ED0", Length = "0x125")]
	[Token(Token = "0x6000799")]
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	[Address(RVA = "0x2359C00", Offset = "0x2359000", Length = "0x270")]
	[Token(Token = "0x60007C1")]
	private string GetNamespaceFromPrefix(string prefix) { }

	[Address(RVA = "0x235A150", Offset = "0x2359550", Length = "0x198")]
	[Token(Token = "0x60007A9")]
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	[Address(RVA = "0x2359E80", Offset = "0x2359280", Length = "0x2C5")]
	[Token(Token = "0x60007A4")]
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	[Address(RVA = "0x235A2F0", Offset = "0x23596F0", Length = "0x278")]
	[Token(Token = "0x60007C0")]
	private string GetPrefix(string ns) { }

	[Address(RVA = "0x235A570", Offset = "0x2359970", Length = "0x77")]
	[Token(Token = "0x60007AD")]
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	[Address(RVA = "0x235A5F0", Offset = "0x23599F0", Length = "0x113")]
	[Token(Token = "0x60007C3")]
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	[Address(RVA = "0x235A710", Offset = "0x2359B10", Length = "0x188")]
	[Token(Token = "0x60007C2")]
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	[Address(RVA = "0x235A8A0", Offset = "0x2359CA0", Length = "0xB1C")]
	[Token(Token = "0x60007BC")]
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	[Address(RVA = "0x235B3C0", Offset = "0x235A7C0", Length = "0x369")]
	[Token(Token = "0x60007A7")]
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	[Address(RVA = "0x235B730", Offset = "0x235AB30", Length = "0x2A5")]
	[Token(Token = "0x60007A6")]
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	[Address(RVA = "0x235B9E0", Offset = "0x235ADE0", Length = "0x20C")]
	[Token(Token = "0x6000798")]
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	[Address(RVA = "0x235BBF0", Offset = "0x235AFF0", Length = "0x879")]
	[Token(Token = "0x60007A8")]
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	[Address(RVA = "0x235C470", Offset = "0x235B870", Length = "0x4E4")]
	[Token(Token = "0x60007B1")]
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	[Address(RVA = "0x235C960", Offset = "0x235BD60", Length = "0x11EA")]
	[Token(Token = "0x60007BE")]
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	[Address(RVA = "0x235DB50", Offset = "0x235CF50", Length = "0xF24")]
	[Token(Token = "0x60007BD")]
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	[Address(RVA = "0x235EA80", Offset = "0x235DE80", Length = "0x97A")]
	[Token(Token = "0x60007B0")]
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	[Address(RVA = "0x235F400", Offset = "0x235E800", Length = "0x863")]
	[Token(Token = "0x60007A5")]
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	[Address(RVA = "0x235FC70", Offset = "0x235F070", Length = "0xF3")]
	[Token(Token = "0x600079B")]
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	[Address(RVA = "0x235FD70", Offset = "0x235F170", Length = "0x9F3")]
	[Token(Token = "0x600079C")]
	internal void HandleRelation(XmlElement node, bool fNested) { }

	[Address(RVA = "0x2360770", Offset = "0x235FB70", Length = "0x281")]
	[Token(Token = "0x60007A3")]
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	[Address(RVA = "0x2360A00", Offset = "0x235FE00", Length = "0x74F")]
	[Token(Token = "0x60007BB")]
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	[Address(RVA = "0x2361150", Offset = "0x2360550", Length = "0x9A4")]
	[Token(Token = "0x60007BA")]
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	[Address(RVA = "0x2361B00", Offset = "0x2360F00", Length = "0x1B2")]
	[Token(Token = "0x60007C5")]
	internal DataTable HandleTable(XmlSchemaElement node) { }

	[Address(RVA = "0x2361CC0", Offset = "0x23610C0", Length = "0x1DB")]
	[Token(Token = "0x600079D")]
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	[Address(RVA = "0x2361EA0", Offset = "0x23612A0", Length = "0x741")]
	[Token(Token = "0x60007B2")]
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	[Address(RVA = "0x23625F0", Offset = "0x23619F0", Length = "0x1225")]
	[Token(Token = "0x60007B4")]
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	[Address(RVA = "0x2363820", Offset = "0x2362C20", Length = "0x5ED")]
	[Token(Token = "0x600079E")]
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	[Address(RVA = "0x2363E10", Offset = "0x2363210", Length = "0x2E1")]
	[Token(Token = "0x60007C4")]
	internal bool IsTable(XmlSchemaElement node) { }

	[Address(RVA = "0x2364100", Offset = "0x2363500", Length = "0x61")]
	[Token(Token = "0x60007B8")]
	internal static bool IsXsdType(string name) { }

	[Address(RVA = "0x2364170", Offset = "0x2363570", Length = "0x17C1")]
	[Token(Token = "0x60007A2")]
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	[Address(RVA = "0x2365940", Offset = "0x2364D40", Length = "0x2A")]
	[Token(Token = "0x60007A1")]
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	[Address(RVA = "0x2365970", Offset = "0x2364D70", Length = "0x2A3")]
	[Token(Token = "0x60007B7")]
	private Type ParseDataType(string dt) { }

	[Address(RVA = "0x2365C20", Offset = "0x2365020", Length = "0x64")]
	[Token(Token = "0x6000795")]
	internal static string QualifiedName(string name) { }

	[Address(RVA = "0x5B8EB0", Offset = "0x5B82B0", Length = "0x7")]
	[Token(Token = "0x6000792")]
	internal void set_FromInference(bool value) { }

	[Address(RVA = "0x2365F00", Offset = "0x2365300", Length = "0x394")]
	[Token(Token = "0x6000797")]
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	[Address(RVA = "0x2365C90", Offset = "0x2365090", Length = "0x260")]
	[Token(Token = "0x600079A")]
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	[Address(RVA = "0x23662A0", Offset = "0x23656A0", Length = "0x4FF")]
	[Token(Token = "0x6000796")]
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	[Address(RVA = "0x23667A0", Offset = "0x2365BA0", Length = "0x6C")]
	[Token(Token = "0x60007AE")]
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	[Address(RVA = "0x2366810", Offset = "0x2365C10", Length = "0xCB")]
	[Token(Token = "0x60007AF")]
	internal static Rule TranslateRule(string strRule) { }

	[Address(RVA = "0x23668E0", Offset = "0x2365CE0", Length = "0xDD")]
	[Token(Token = "0x60007B5")]
	public static Type XsdtoClr(string xsdTypeName) { }

}

