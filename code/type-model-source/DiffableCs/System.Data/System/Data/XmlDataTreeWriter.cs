namespace System.Data;

[Token(Token = "0x20000A3")]
internal sealed class XmlDataTreeWriter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000341")]
	private XmlWriter _xmlw; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000342")]
	private DataSet _ds; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000343")]
	private DataTable _dt; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000344")]
	private ArrayList _dTables; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000345")]
	private DataTable[] _topLevelTables; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000346")]
	private bool _fFromTable; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000347")]
	private bool _isDiffgram; //Field offset: 0x39
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000348")]
	private Hashtable _rowsOrder; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000349")]
	private bool _writeHierarchy; //Field offset: 0x48

	[Address(RVA = "0x2379710", Offset = "0x2378B10", Length = "0x29A")]
	[Token(Token = "0x6000842")]
	internal XmlDataTreeWriter(DataSet ds) { }

	[Address(RVA = "0x2379510", Offset = "0x2378910", Length = "0x1F8")]
	[Token(Token = "0x6000843")]
	internal XmlDataTreeWriter(DataTable dt, bool writeHierarchy) { }

	[Address(RVA = "0x2376810", Offset = "0x2375C10", Length = "0x2CC")]
	[Token(Token = "0x6000845")]
	private void CreateTablesHierarchy(DataTable dt) { }

	[Address(RVA = "0x2376AE0", Offset = "0x2375EE0", Length = "0x2F9")]
	[Token(Token = "0x6000844")]
	private DataTable[] CreateToplevelTables() { }

	[Address(RVA = "0x2376DE0", Offset = "0x23761E0", Length = "0x290")]
	[Token(Token = "0x6000849")]
	private ArrayList GetNestedChildRelations(DataRow row) { }

	[Address(RVA = "0x2377080", Offset = "0x2376480", Length = "0x83")]
	[Token(Token = "0x600084B")]
	internal static bool PreserveSpace(object value) { }

	[Address(RVA = "0x2377110", Offset = "0x2376510", Length = "0xD7")]
	[Token(Token = "0x6000846")]
	internal static bool RowHasErrors(DataRow row) { }

	[Address(RVA = "0x23777B0", Offset = "0x2376BB0", Length = "0x83D")]
	[Token(Token = "0x6000848")]
	internal void Save(XmlWriter xw, bool writeSchema) { }

	[Address(RVA = "0x23771F0", Offset = "0x23765F0", Length = "0x5BB")]
	[Token(Token = "0x6000847")]
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	[Address(RVA = "0x2377FF0", Offset = "0x23773F0", Length = "0x151E")]
	[Token(Token = "0x600084A")]
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

}

