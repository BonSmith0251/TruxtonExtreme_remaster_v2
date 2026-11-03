namespace System.Xml.Schema;

[Token(Token = "0x20001E8")]
internal sealed class XdrBuilder : SchemaBuilder
{
	[Token(Token = "0x20001EC")]
	private sealed class AttributeContent
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A9F")]
		internal SchemaAttDef _AttDef; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AA0")]
		internal XmlQualifiedName _Name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AA1")]
		internal string _Prefix; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AA2")]
		internal bool _Required; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000AA3")]
		internal uint _MinVal; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AA4")]
		internal uint _MaxVal; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000AA5")]
		internal uint _MaxLength; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AA6")]
		internal uint _MinLength; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000AA7")]
		internal bool _EnumerationRequired; //Field offset: 0x3C
		[FieldOffset(Offset = "0x3D")]
		[Token(Token = "0x4000AA8")]
		internal bool _HasDataType; //Field offset: 0x3D
		[FieldOffset(Offset = "0x3E")]
		[Token(Token = "0x4000AA9")]
		internal bool _Global; //Field offset: 0x3E
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000AAA")]
		internal object _Default; //Field offset: 0x40

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60013CE")]
		public AttributeContent() { }

	}

	[Token(Token = "0x20001E9")]
	private sealed class DeclBaseInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A80")]
		internal XmlQualifiedName _Name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A81")]
		internal string _Prefix; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A82")]
		internal XmlQualifiedName _TypeName; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A83")]
		internal string _TypePrefix; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A84")]
		internal object _Default; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000A85")]
		internal object _Revises; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A86")]
		internal uint _MaxOccurs; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000A87")]
		internal uint _MinOccurs; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A88")]
		internal bool _Checking; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000A89")]
		internal SchemaElementDecl _ElementDecl; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000A8A")]
		internal SchemaAttDef _Attdef; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A8B")]
		internal DeclBaseInfo _Next; //Field offset: 0x60

		[Address(RVA = "0x24786C0", Offset = "0x2477AC0", Length = "0x1F")]
		[Token(Token = "0x60013C8")]
		internal DeclBaseInfo() { }

		[Address(RVA = "0x24785B0", Offset = "0x24779B0", Length = "0x106")]
		[Token(Token = "0x60013C9")]
		internal void Reset() { }

	}

	[Token(Token = "0x20001EB")]
	private sealed class ElementContent
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A91")]
		internal SchemaElementDecl _ElementDecl; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A92")]
		internal int _ContentAttr; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000A93")]
		internal int _OrderAttr; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A94")]
		internal bool _MasterGroupRequired; //Field offset: 0x20
		[FieldOffset(Offset = "0x21")]
		[Token(Token = "0x4000A95")]
		internal bool _ExistTerminal; //Field offset: 0x21
		[FieldOffset(Offset = "0x22")]
		[Token(Token = "0x4000A96")]
		internal bool _AllowDataType; //Field offset: 0x22
		[FieldOffset(Offset = "0x23")]
		[Token(Token = "0x4000A97")]
		internal bool _HasDataType; //Field offset: 0x23
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000A98")]
		internal bool _HasType; //Field offset: 0x24
		[FieldOffset(Offset = "0x25")]
		[Token(Token = "0x4000A99")]
		internal bool _EnumerationRequired; //Field offset: 0x25
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A9A")]
		internal uint _MinVal; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000A9B")]
		internal uint _MaxVal; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A9C")]
		internal uint _MaxLength; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000A9D")]
		internal uint _MinLength; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000A9E")]
		internal Hashtable _AttDefList; //Field offset: 0x38

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60013CD")]
		public ElementContent() { }

	}

	[Token(Token = "0x20001EA")]
	private sealed class GroupContent
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A8C")]
		internal uint _MinVal; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000A8D")]
		internal uint _MaxVal; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A8E")]
		internal bool _HasMaxAttr; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x4000A8F")]
		internal bool _HasMinAttr; //Field offset: 0x19
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000A90")]
		internal int _Order; //Field offset: 0x1C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60013CC")]
		public GroupContent() { }

		[Address(RVA = "0x2478710", Offset = "0x2477B10", Length = "0x71")]
		[Token(Token = "0x60013CB")]
		internal static GroupContent Copy(GroupContent other) { }

		[Address(RVA = "0x24786E0", Offset = "0x2477AE0", Length = "0x2A")]
		[Token(Token = "0x60013CA")]
		internal static void Copy(GroupContent from, GroupContent to) { }

	}

	[Token(Token = "0x20001F1")]
	private sealed class XdrAttributeEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AAB")]
		internal Token _Attribute; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000AAC")]
		internal int _SchemaFlags; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AAD")]
		internal XmlSchemaDatatype _Datatype; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AAE")]
		internal XdrBuildFunction _BuildFunc; //Field offset: 0x20

		[Address(RVA = "0x2478AE0", Offset = "0x2477EE0", Length = "0x9E")]
		[Token(Token = "0x60013D7")]
		internal XdrAttributeEntry(Token a, XmlTokenizedType ttype, XdrBuildFunction build) { }

		[Address(RVA = "0x2478A40", Offset = "0x2477E40", Length = "0x9C")]
		[Token(Token = "0x60013D8")]
		internal XdrAttributeEntry(Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuildFunction build) { }

	}

	[Token(Token = "0x20001EF")]
	private sealed class XdrBeginChildFunction : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x60013D3")]
		public XdrBeginChildFunction(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x60013D4")]
		public override void Invoke(XdrBuilder builder) { }

	}

	[Token(Token = "0x20001ED")]
	private sealed class XdrBuildFunction : MulticastDelegate
	{

		[Address(RVA = "0x22D3880", Offset = "0x22D2C80", Length = "0xB5")]
		[Token(Token = "0x60013CF")]
		public XdrBuildFunction(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x60013D0")]
		public override void Invoke(XdrBuilder builder, object obj, string prefix) { }

	}

	[Token(Token = "0x20001F0")]
	private sealed class XdrEndChildFunction : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x60013D5")]
		public XdrEndChildFunction(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x60013D6")]
		public override void Invoke(XdrBuilder builder) { }

	}

	[Token(Token = "0x20001F2")]
	private sealed class XdrEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AAF")]
		internal Token _Name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AB0")]
		internal Int32[] _NextStates; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AB1")]
		internal XdrAttributeEntry[] _Attributes; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AB2")]
		internal XdrInitFunction _InitFunc; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AB3")]
		internal XdrBeginChildFunction _BeginChildFunc; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AB4")]
		internal XdrEndChildFunction _EndChildFunc; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000AB5")]
		internal bool _AllowText; //Field offset: 0x40

		[Address(RVA = "0x2482BE0", Offset = "0x2481FE0", Length = "0x9C")]
		[Token(Token = "0x60013D9")]
		internal XdrEntry(Token n, Int32[] states, XdrAttributeEntry[] attributes, XdrInitFunction init, XdrBeginChildFunction begin, XdrEndChildFunction end, bool fText) { }

	}

	[Token(Token = "0x20001EE")]
	private sealed class XdrInitFunction : MulticastDelegate
	{

		[Address(RVA = "0x639C90", Offset = "0x639090", Length = "0xB5")]
		[Token(Token = "0x60013D1")]
		public XdrInitFunction(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x60013D2")]
		public override void Invoke(XdrBuilder builder, object obj) { }

	}

	[Token(Token = "0x4000A5B")]
	private static readonly Int32[] S_XDR_Root_Element; //Field offset: 0x0
	[Token(Token = "0x4000A5C")]
	private static readonly Int32[] S_XDR_Root_SubElements; //Field offset: 0x8
	[Token(Token = "0x4000A5D")]
	private static readonly Int32[] S_XDR_ElementType_SubElements; //Field offset: 0x10
	[Token(Token = "0x4000A5E")]
	private static readonly Int32[] S_XDR_AttributeType_SubElements; //Field offset: 0x18
	[Token(Token = "0x4000A5F")]
	private static readonly Int32[] S_XDR_Group_SubElements; //Field offset: 0x20
	[Token(Token = "0x4000A60")]
	private static readonly XdrAttributeEntry[] S_XDR_Root_Attributes; //Field offset: 0x28
	[Token(Token = "0x4000A61")]
	private static readonly XdrAttributeEntry[] S_XDR_ElementType_Attributes; //Field offset: 0x30
	[Token(Token = "0x4000A62")]
	private static readonly XdrAttributeEntry[] S_XDR_AttributeType_Attributes; //Field offset: 0x38
	[Token(Token = "0x4000A63")]
	private static readonly XdrAttributeEntry[] S_XDR_Element_Attributes; //Field offset: 0x40
	[Token(Token = "0x4000A64")]
	private static readonly XdrAttributeEntry[] S_XDR_Attribute_Attributes; //Field offset: 0x48
	[Token(Token = "0x4000A65")]
	private static readonly XdrAttributeEntry[] S_XDR_Group_Attributes; //Field offset: 0x50
	[Token(Token = "0x4000A66")]
	private static readonly XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; //Field offset: 0x58
	[Token(Token = "0x4000A67")]
	private static readonly XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; //Field offset: 0x60
	[Token(Token = "0x4000A68")]
	private static readonly XdrEntry[] S_SchemaEntries; //Field offset: 0x68
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A69")]
	private SchemaInfo _SchemaInfo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A6A")]
	private string _TargetNamespace; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A6B")]
	private XmlReader _reader; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A6C")]
	private PositionInfo positionInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A6D")]
	private ParticleContentValidator _contentValidator; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A6E")]
	private XdrEntry _CurState; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A6F")]
	private XdrEntry _NextState; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A70")]
	private HWStack _StateHistory; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A71")]
	private HWStack _GroupStack; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A72")]
	private string _XdrName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A73")]
	private string _XdrPrefix; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A74")]
	private ElementContent _ElementDef; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A75")]
	private GroupContent _GroupDef; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A76")]
	private AttributeContent _AttributeDef; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A77")]
	private DeclBaseInfo _UndefinedAttributeTypes; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A78")]
	private DeclBaseInfo _BaseDecl; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A79")]
	private XmlNameTable _NameTable; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A7A")]
	private SchemaNames _SchemaNames; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A7B")]
	private XmlNamespaceManager _CurNsMgr; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000A7C")]
	private string _Text; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000A7D")]
	private ValidationEventHandler validationEventHandler; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000A7E")]
	private Hashtable _UndeclaredElements; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000A7F")]
	private XmlResolver xmlResolver; //Field offset: 0xC0

	[Token(Token = "0x17000537")]
	internal XmlResolver XmlResolver
	{
		[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
		[Token(Token = "0x6001375")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x247F2B0", Offset = "0x247E6B0", Length = "0x365C")]
	[Token(Token = "0x60013C7")]
	private static XdrBuilder() { }

	[Address(RVA = "0x2482910", Offset = "0x2481D10", Length = "0x2C3")]
	[Token(Token = "0x6001372")]
	internal XdrBuilder(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	[Address(RVA = "0x2478B80", Offset = "0x2477F80", Length = "0xBD")]
	[Token(Token = "0x60013B3")]
	private void AddOrder() { }

	[Address(RVA = "0x2478C40", Offset = "0x2478040", Length = "0x1A2")]
	[Token(Token = "0x60013C0")]
	private XmlSchemaDatatype CheckDatatype(string str) { }

	[Address(RVA = "0x2478DF0", Offset = "0x24781F0", Length = "0x12E")]
	[Token(Token = "0x60013C1")]
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	[Address(RVA = "0x2478F20", Offset = "0x2478320", Length = "0x7D")]
	[Token(Token = "0x60013BA")]
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	[Address(RVA = "0x2478FA0", Offset = "0x24783A0", Length = "0xCF")]
	[Token(Token = "0x600137C")]
	internal virtual void EndChildren() { }

	[Address(RVA = "0x2479070", Offset = "0x2478470", Length = "0x20A")]
	[Token(Token = "0x60013BE")]
	private int GetContent(XmlQualifiedName qname) { }

	[Address(RVA = "0x2479280", Offset = "0x2478680", Length = "0x113")]
	[Token(Token = "0x60013BF")]
	private bool GetModel(XmlQualifiedName qname) { }

	[Address(RVA = "0x24793A0", Offset = "0x24787A0", Length = "0x1E7")]
	[Token(Token = "0x60013AF")]
	private bool GetNextState(XmlQualifiedName qname) { }

	[Address(RVA = "0x2479590", Offset = "0x2478990", Length = "0x1B4")]
	[Token(Token = "0x60013B2")]
	private int GetOrder(XmlQualifiedName qname) { }

	[Address(RVA = "0x2479750", Offset = "0x2478B50", Length = "0x29")]
	[Token(Token = "0x60013B7")]
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6001378")]
	internal virtual bool IsContentParsed() { }

	[Address(RVA = "0x2479780", Offset = "0x2478B80", Length = "0xA")]
	[Token(Token = "0x60013C2")]
	private bool IsGlobal(int flags) { }

	[Address(RVA = "0x2479790", Offset = "0x2478B90", Length = "0x1BE")]
	[Token(Token = "0x60013B1")]
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	[Address(RVA = "0x2479950", Offset = "0x2478D50", Length = "0xFD")]
	[Token(Token = "0x60013B0")]
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	[Address(RVA = "0x2479A50", Offset = "0x2478E50", Length = "0x9E")]
	[Token(Token = "0x6001377")]
	internal static bool IsXdrSchema(string uri) { }

	[Address(RVA = "0x2479AF0", Offset = "0x2478EF0", Length = "0x123")]
	[Token(Token = "0x60013B4")]
	private static bool IsYes(object obj, XdrBuilder builder) { }

	[Address(RVA = "0x2479C20", Offset = "0x2479020", Length = "0x4D6")]
	[Token(Token = "0x6001376")]
	private bool LoadSchema(string uri) { }

	[Address(RVA = "0x247A100", Offset = "0x2479500", Length = "0x131")]
	[Token(Token = "0x60013B8")]
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	[Address(RVA = "0x247A240", Offset = "0x2479640", Length = "0x131")]
	[Token(Token = "0x60013B9")]
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	[Address(RVA = "0x247A380", Offset = "0x2479780", Length = "0x3E")]
	[Token(Token = "0x60013BB")]
	private static bool ParseInteger(string str, ref uint n) { }

	[Address(RVA = "0x247A3C0", Offset = "0x24797C0", Length = "0x11E")]
	[Token(Token = "0x60013B6")]
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	[Address(RVA = "0x247A4E0", Offset = "0x24798E0", Length = "0xF4")]
	[Token(Token = "0x60013B5")]
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	[Address(RVA = "0x247A690", Offset = "0x2479A90", Length = "0xA6")]
	[Token(Token = "0x600137E")]
	private void Pop() { }

	[Address(RVA = "0x247A5E0", Offset = "0x24799E0", Length = "0xA6")]
	[Token(Token = "0x6001380")]
	private void PopGroupInfo() { }

	[Address(RVA = "0x247A740", Offset = "0x2479B40", Length = "0x405")]
	[Token(Token = "0x6001374")]
	internal virtual void ProcessAttribute(string prefix, string name, string ns, string value) { }

	[Address(RVA = "0x247AB50", Offset = "0x2479F50", Length = "0x7F")]
	[Token(Token = "0x600137A")]
	internal virtual void ProcessCData(string value) { }

	[Address(RVA = "0x247ABD0", Offset = "0x2479FD0", Length = "0x250")]
	[Token(Token = "0x6001373")]
	internal virtual bool ProcessElement(string prefix, string name, string ns) { }

	[Address(RVA = "0x247AE30", Offset = "0x247A230", Length = "0x5F")]
	[Token(Token = "0x6001379")]
	internal virtual void ProcessMarkup(XmlNode[] markup) { }

	[Address(RVA = "0x247AF50", Offset = "0x247A350", Length = "0x52")]
	[Token(Token = "0x600137D")]
	private void Push() { }

	[Address(RVA = "0x247AE90", Offset = "0x247A290", Length = "0xB6")]
	[Token(Token = "0x600137F")]
	private void PushGroupInfo() { }

	[Address(RVA = "0x247B0F0", Offset = "0x247A4F0", Length = "0x11B")]
	[Token(Token = "0x60013C6")]
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	[Address(RVA = "0x247AFB0", Offset = "0x247A3B0", Length = "0x131")]
	[Token(Token = "0x60013C3")]
	private void SendValidationEvent(string code, String[] args, XmlSeverityType severity) { }

	[Address(RVA = "0x247B320", Offset = "0x247A720", Length = "0x19")]
	[Token(Token = "0x60013C4")]
	private void SendValidationEvent(string code) { }

	[Address(RVA = "0x247B210", Offset = "0x247A610", Length = "0x10C")]
	[Token(Token = "0x60013C5")]
	private void SendValidationEvent(string code, string msg) { }

	[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
	[Token(Token = "0x6001375")]
	internal void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x247B340", Offset = "0x247A740", Length = "0x4F")]
	[Token(Token = "0x60013BD")]
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	[Address(RVA = "0x247B390", Offset = "0x247A790", Length = "0x38")]
	[Token(Token = "0x600137B")]
	internal virtual void StartChildren() { }

	[Address(RVA = "0x247B450", Offset = "0x247A850", Length = "0x454")]
	[Token(Token = "0x60013A4")]
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	[Address(RVA = "0x247B3D0", Offset = "0x247A7D0", Length = "0x7A")]
	[Token(Token = "0x6001399")]
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	[Address(RVA = "0x247B8B0", Offset = "0x247ACB0", Length = "0x364")]
	[Token(Token = "0x600138F")]
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	[Address(RVA = "0x247BC20", Offset = "0x247B020", Length = "0xE1")]
	[Token(Token = "0x6001384")]
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	[Address(RVA = "0x247C6D0", Offset = "0x247BAD0", Length = "0x2B")]
	[Token(Token = "0x60013A3")]
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247C700", Offset = "0x247BB00", Length = "0x7B")]
	[Token(Token = "0x60013A2")]
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247C780", Offset = "0x247BB80", Length = "0x104")]
	[Token(Token = "0x60013A1")]
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247BD10", Offset = "0x247B110", Length = "0x28")]
	[Token(Token = "0x6001394")]
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247BD40", Offset = "0x247B140", Length = "0x16B")]
	[Token(Token = "0x6001397")]
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247BEB0", Offset = "0x247B2B0", Length = "0x16B")]
	[Token(Token = "0x6001398")]
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247C020", Offset = "0x247B420", Length = "0x241")]
	[Token(Token = "0x6001395")]
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247C270", Offset = "0x247B670", Length = "0xFD")]
	[Token(Token = "0x6001396")]
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247C370", Offset = "0x247B770", Length = "0x2D2")]
	[Token(Token = "0x6001392")]
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247C650", Offset = "0x247BA50", Length = "0x7A")]
	[Token(Token = "0x6001393")]
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247D2D0", Offset = "0x247C6D0", Length = "0x7A")]
	[Token(Token = "0x600139E")]
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247D350", Offset = "0x247C750", Length = "0x7A")]
	[Token(Token = "0x600139D")]
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247D3D0", Offset = "0x247C7D0", Length = "0x1C1")]
	[Token(Token = "0x600139C")]
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247C890", Offset = "0x247BC90", Length = "0x9E")]
	[Token(Token = "0x6001388")]
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247C930", Offset = "0x247BD30", Length = "0x16B")]
	[Token(Token = "0x600138D")]
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247CAA0", Offset = "0x247BEA0", Length = "0x16B")]
	[Token(Token = "0x600138E")]
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247CC10", Offset = "0x247C010", Length = "0x168")]
	[Token(Token = "0x600138B")]
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247CD80", Offset = "0x247C180", Length = "0xFD")]
	[Token(Token = "0x600138C")]
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247CE80", Offset = "0x247C280", Length = "0x17E")]
	[Token(Token = "0x6001389")]
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247D000", Offset = "0x247C400", Length = "0x202")]
	[Token(Token = "0x6001387")]
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247D210", Offset = "0x247C610", Length = "0xB4")]
	[Token(Token = "0x600138A")]
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247D5A0", Offset = "0x247C9A0", Length = "0x87")]
	[Token(Token = "0x60013A9")]
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247D630", Offset = "0x247CA30", Length = "0x87")]
	[Token(Token = "0x60013A8")]
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247D6C0", Offset = "0x247CAC0", Length = "0xEF")]
	[Token(Token = "0x60013A7")]
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001383")]
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247D7B0", Offset = "0x247CBB0", Length = "0x92")]
	[Token(Token = "0x6001382")]
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	[Address(RVA = "0x247D850", Offset = "0x247CC50", Length = "0x102")]
	[Token(Token = "0x60013BC")]
	private void XDR_CheckAttributeDefault(DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	[Address(RVA = "0x247DD90", Offset = "0x247D190", Length = "0x25")]
	[Token(Token = "0x60013A5")]
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	[Address(RVA = "0x247D960", Offset = "0x247CD60", Length = "0xED")]
	[Token(Token = "0x60013AE")]
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	[Address(RVA = "0x247DA50", Offset = "0x247CE50", Length = "0x33E")]
	[Token(Token = "0x600139A")]
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	[Address(RVA = "0x247E3B0", Offset = "0x247D7B0", Length = "0x10B")]
	[Token(Token = "0x600139F")]
	private static void XDR_EndElement(XdrBuilder builder) { }

	[Address(RVA = "0x247DDC0", Offset = "0x247D1C0", Length = "0x107")]
	[Token(Token = "0x60013AC")]
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	[Address(RVA = "0x247DED0", Offset = "0x247D2D0", Length = "0x4D0")]
	[Token(Token = "0x6001390")]
	private static void XDR_EndElementType(XdrBuilder builder) { }

	[Address(RVA = "0x247E4C0", Offset = "0x247D8C0", Length = "0x203")]
	[Token(Token = "0x60013AA")]
	private static void XDR_EndGroup(XdrBuilder builder) { }

	[Address(RVA = "0x247E6D0", Offset = "0x247DAD0", Length = "0x47D")]
	[Token(Token = "0x6001385")]
	private static void XDR_EndRoot(XdrBuilder builder) { }

	[Address(RVA = "0x247ECE0", Offset = "0x247E0E0", Length = "0x95")]
	[Token(Token = "0x60013A0")]
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	[Address(RVA = "0x247EB50", Offset = "0x247DF50", Length = "0x6C")]
	[Token(Token = "0x60013AD")]
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	[Address(RVA = "0x247EBC0", Offset = "0x247DFC0", Length = "0x113")]
	[Token(Token = "0x6001391")]
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	[Address(RVA = "0x247EFD0", Offset = "0x247E3D0", Length = "0xAD")]
	[Token(Token = "0x600139B")]
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	[Address(RVA = "0x247ED80", Offset = "0x247E180", Length = "0xAA")]
	[Token(Token = "0x60013AB")]
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	[Address(RVA = "0x247EE30", Offset = "0x247E230", Length = "0x194")]
	[Token(Token = "0x6001386")]
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	[Address(RVA = "0x247F080", Offset = "0x247E480", Length = "0x1A3")]
	[Token(Token = "0x60013A6")]
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	[Address(RVA = "0x247F230", Offset = "0x247E630", Length = "0x7C")]
	[Token(Token = "0x6001381")]
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

}

