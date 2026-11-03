namespace System.Data;

[Token(Token = "0x2000091")]
internal sealed class XDRSchema : XMLSchema
{
	[Token(Token = "0x2000092")]
	private sealed class NameType : IComparable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002D7")]
		public string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002D8")]
		public Type type; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x600077D")]
		public NameType(string n, Type t) { }

		[Address(RVA = "0x234A270", Offset = "0x2349670", Length = "0x45")]
		[Token(Token = "0x600077E")]
		public override int CompareTo(object obj) { }

	}

	[Token(Token = "0x40002D4")]
	private static readonly Char[] s_colonArray; //Field offset: 0x0
	[Token(Token = "0x40002D5")]
	private static NameType[] s_mapNameTypeXdr; //Field offset: 0x8
	[Token(Token = "0x40002D6")]
	private static NameType s_enumerationNameType; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002D0")]
	internal string _schemaName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002D1")]
	internal string _schemaUri; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002D2")]
	internal XmlElement _schemaRoot; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002D3")]
	internal DataSet _ds; //Field offset: 0x28

	[Address(RVA = "0x2353810", Offset = "0x2352C10", Length = "0x134F")]
	[Token(Token = "0x600077C")]
	private static XDRSchema() { }

	[Address(RVA = "0x2354B60", Offset = "0x2353F60", Length = "0x80")]
	[Token(Token = "0x600076D")]
	internal XDRSchema(DataSet ds, bool fInline) { }

	[Address(RVA = "0x2350C90", Offset = "0x2350090", Length = "0xD6")]
	[Token(Token = "0x6000773")]
	private static NameType FindNameType(string name) { }

	[Address(RVA = "0x2350D70", Offset = "0x2350170", Length = "0x4B6")]
	[Token(Token = "0x600076F")]
	internal XmlElement FindTypeNode(XmlElement node) { }

	[Address(RVA = "0x2351230", Offset = "0x2350630", Length = "0x227")]
	[Token(Token = "0x6000775")]
	internal string GetInstanceName(XmlElement node) { }

	[Address(RVA = "0x23516D0", Offset = "0x2350AD0", Length = "0x22")]
	[Token(Token = "0x6000777")]
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	[Address(RVA = "0x2351460", Offset = "0x2350860", Length = "0x264")]
	[Token(Token = "0x6000778")]
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	[Address(RVA = "0x2351700", Offset = "0x2350B00", Length = "0xBEC")]
	[Token(Token = "0x6000776")]
	internal void HandleColumn(XmlElement node, DataTable table) { }

	[Address(RVA = "0x23522F0", Offset = "0x23516F0", Length = "0x1B2")]
	[Token(Token = "0x6000772")]
	internal DataTable HandleTable(XmlElement node) { }

	[Address(RVA = "0x23524B0", Offset = "0x23518B0", Length = "0x217")]
	[Token(Token = "0x6000779")]
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	[Address(RVA = "0x23526D0", Offset = "0x2351AD0", Length = "0x259")]
	[Token(Token = "0x600077B")]
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	[Address(RVA = "0x2352930", Offset = "0x2351D30", Length = "0x5A6")]
	[Token(Token = "0x600077A")]
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	[Address(RVA = "0x2352EE0", Offset = "0x23522E0", Length = "0x1B7")]
	[Token(Token = "0x6000770")]
	internal bool IsTextOnlyContent(XmlElement node) { }

	[Address(RVA = "0x23530A0", Offset = "0x23524A0", Length = "0x397")]
	[Token(Token = "0x6000771")]
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	[Address(RVA = "0x2353440", Offset = "0x2352840", Length = "0x270")]
	[Token(Token = "0x600076E")]
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	[Address(RVA = "0x23536C0", Offset = "0x2352AC0", Length = "0x14A")]
	[Token(Token = "0x6000774")]
	private Type ParseDataType(string dt, string dtValues) { }

}

