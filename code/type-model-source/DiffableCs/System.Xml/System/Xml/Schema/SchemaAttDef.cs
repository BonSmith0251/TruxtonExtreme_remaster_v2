namespace System.Xml.Schema;

[Token(Token = "0x20001D2")]
internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo
{
	[Token(Token = "0x20001D3")]
	public enum Reserve : int
	{
		None = 0,
		XmlSpace = 1,
		XmlLang = 2,
	}

	[Token(Token = "0x40008C6")]
	public static readonly SchemaAttDef Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008BE")]
	private string defExpanded; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008BF")]
	private int lineNum; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40008C0")]
	private int linePos; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008C1")]
	private int valueLineNum; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40008C2")]
	private int valueLinePos; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008C3")]
	private Reserve reserved; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40008C4")]
	private bool defaultValueChecked; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008C5")]
	private XmlSchemaAttribute schemaAttribute; //Field offset: 0x80

	[Token(Token = "0x170004EC")]
	internal bool DefaultValueChecked
	{
		[Address(RVA = "0x243EE10", Offset = "0x243E210", Length = "0x5")]
		[Token(Token = "0x600121C")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170004E9")]
	internal string DefaultValueExpanded
	{
		[Address(RVA = "0x243EE20", Offset = "0x243E220", Length = "0x1E")]
		[Token(Token = "0x6001216")]
		internal get { } //Length: 30
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x6001217")]
		internal set { } //Length: 995
	}

	[Token(Token = "0x170004E6")]
	internal int LineNumber
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[Token(Token = "0x6001210")]
		internal get { } //Length: 4
		[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
		[Token(Token = "0x6001211")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170004E5")]
	internal int LinePosition
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[Token(Token = "0x600120E")]
		internal get { } //Length: 4
		[Address(RVA = "0xD97670", Offset = "0xD96A70", Length = "0x4")]
		[Token(Token = "0x600120F")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170004EB")]
	internal Reserve Reserved
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x600121A")]
		internal get { } //Length: 4
		[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
		[Token(Token = "0x600121B")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170004ED")]
	internal XmlSchemaAttribute SchemaAttribute
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x600121D")]
		internal get { } //Length: 8
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[Token(Token = "0x600121E")]
		internal set { } //Length: 16
	}

	[Token(Token = "0x170004DF")]
	private override bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6001208")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170004DE")]
	private override bool System.Xml.IDtdAttributeInfo.IsNonCDataType
	{
		[Address(RVA = "0x243ED00", Offset = "0x243E100", Length = "0x2F")]
		[Token(Token = "0x6001207")]
		private get { } //Length: 47
	}

	[Token(Token = "0x170004E0")]
	private override bool System.Xml.IDtdAttributeInfo.IsXmlAttribute
	{
		[Address(RVA = "0x243ED30", Offset = "0x243E130", Length = "0x8")]
		[Token(Token = "0x6001209")]
		private get { } //Length: 8
	}

	[Token(Token = "0x170004DC")]
	private override int System.Xml.IDtdAttributeInfo.LineNumber
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[Token(Token = "0x6001205")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170004DD")]
	private override int System.Xml.IDtdAttributeInfo.LinePosition
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[Token(Token = "0x6001206")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170004DB")]
	private override string System.Xml.IDtdAttributeInfo.LocalName
	{
		[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
		[Token(Token = "0x6001204")]
		private get { } //Length: 27
	}

	[Token(Token = "0x170004DA")]
	private override string System.Xml.IDtdAttributeInfo.Prefix
	{
		[Address(RVA = "0x243ED40", Offset = "0x243E140", Length = "0x7")]
		[Token(Token = "0x6001203")]
		private get { } //Length: 7
	}

	[Token(Token = "0x170004E1")]
	private override string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded
	{
		[Address(RVA = "0x243ED50", Offset = "0x243E150", Length = "0x1E")]
		[Token(Token = "0x600120A")]
		private get { } //Length: 30
	}

	[Token(Token = "0x170004E2")]
	private override object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600120B")]
		private get { } //Length: 5
	}

	[Token(Token = "0x170004E3")]
	private override int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x600120C")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170004E4")]
	private override int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition
	{
		[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
		[Token(Token = "0x600120D")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170004EA")]
	internal XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x243EE40", Offset = "0x243E240", Length = "0x2A")]
		[Token(Token = "0x6001218")]
		internal get { } //Length: 42
		[Address(RVA = "0x243EE70", Offset = "0x243E270", Length = "0x29")]
		[Token(Token = "0x6001219")]
		internal set { } //Length: 41
	}

	[Token(Token = "0x170004E8")]
	internal int ValueLineNumber
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x6001214")]
		internal get { } //Length: 4
		[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
		[Token(Token = "0x6001215")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170004E7")]
	internal int ValueLinePosition
	{
		[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
		[Token(Token = "0x6001212")]
		internal get { } //Length: 4
		[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
		[Token(Token = "0x6001213")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x243ED70", Offset = "0x243E170", Length = "0x67")]
	[Token(Token = "0x6001221")]
	private static SchemaAttDef() { }

	[Address(RVA = "0x243EE00", Offset = "0x243E200", Length = "0x7")]
	[Token(Token = "0x6001202")]
	private SchemaAttDef() { }

	[Address(RVA = "0x243EDF0", Offset = "0x243E1F0", Length = "0x8")]
	[Token(Token = "0x6001200")]
	public SchemaAttDef(XmlQualifiedName name, string prefix) { }

	[Address(RVA = "0x243EDE0", Offset = "0x243E1E0", Length = "0xB")]
	[Token(Token = "0x6001201")]
	public SchemaAttDef(XmlQualifiedName name) { }

	[Address(RVA = "0x243E9F0", Offset = "0x243DDF0", Length = "0x2AA")]
	[Token(Token = "0x600121F")]
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	[Address(RVA = "0x243ECA0", Offset = "0x243E0A0", Length = "0x57")]
	[Token(Token = "0x6001220")]
	internal SchemaAttDef Clone() { }

	[Address(RVA = "0x243EE10", Offset = "0x243E210", Length = "0x5")]
	[Token(Token = "0x600121C")]
	internal bool get_DefaultValueChecked() { }

	[Address(RVA = "0x243EE20", Offset = "0x243E220", Length = "0x1E")]
	[Token(Token = "0x6001216")]
	internal string get_DefaultValueExpanded() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[Token(Token = "0x6001210")]
	internal int get_LineNumber() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[Token(Token = "0x600120E")]
	internal int get_LinePosition() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x600121A")]
	internal Reserve get_Reserved() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x600121D")]
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	[Address(RVA = "0x243EE40", Offset = "0x243E240", Length = "0x2A")]
	[Token(Token = "0x6001218")]
	internal XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x6001214")]
	internal int get_ValueLineNumber() { }

	[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
	[Token(Token = "0x6001212")]
	internal int get_ValueLinePosition() { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x6001217")]
	internal void set_DefaultValueExpanded(string value) { }

	[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
	[Token(Token = "0x6001211")]
	internal void set_LineNumber(int value) { }

	[Address(RVA = "0xD97670", Offset = "0xD96A70", Length = "0x4")]
	[Token(Token = "0x600120F")]
	internal void set_LinePosition(int value) { }

	[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
	[Token(Token = "0x600121B")]
	internal void set_Reserved(Reserve value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x600121E")]
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	[Address(RVA = "0x243EE70", Offset = "0x243E270", Length = "0x29")]
	[Token(Token = "0x6001219")]
	internal void set_TokenizedType(XmlTokenizedType value) { }

	[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
	[Token(Token = "0x6001215")]
	internal void set_ValueLineNumber(int value) { }

	[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
	[Token(Token = "0x6001213")]
	internal void set_ValueLinePosition(int value) { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6001208")]
	private override bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	[Address(RVA = "0x243ED00", Offset = "0x243E100", Length = "0x2F")]
	[Token(Token = "0x6001207")]
	private override bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	[Address(RVA = "0x243ED30", Offset = "0x243E130", Length = "0x8")]
	[Token(Token = "0x6001209")]
	private override bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[Token(Token = "0x6001205")]
	private override int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[Token(Token = "0x6001206")]
	private override int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
	[Token(Token = "0x6001204")]
	private override string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	[Address(RVA = "0x243ED40", Offset = "0x243E140", Length = "0x7")]
	[Token(Token = "0x6001203")]
	private override string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	[Address(RVA = "0x243ED50", Offset = "0x243E150", Length = "0x1E")]
	[Token(Token = "0x600120A")]
	private override string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600120B")]
	private override object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x600120C")]
	private override int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
	[Token(Token = "0x600120D")]
	private override int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

}

