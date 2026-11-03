namespace System.Data;

[Token(Token = "0x20000A2")]
internal sealed class NewDiffgramGen
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000338")]
	internal XmlDocument _doc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000339")]
	internal DataSet _ds; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400033A")]
	internal DataTable _dt; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400033B")]
	internal XmlWriter _xmlw; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400033C")]
	private bool _fBefore; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400033D")]
	private bool _fErrors; //Field offset: 0x31
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400033E")]
	internal Hashtable _rowsOrder; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400033F")]
	private ArrayList _tables; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000340")]
	private bool _writeHierarchy; //Field offset: 0x48

	[Address(RVA = "0x2372B70", Offset = "0x2371F70", Length = "0x159")]
	[Token(Token = "0x6000836")]
	internal NewDiffgramGen(DataSet ds) { }

	[Address(RVA = "0x2372A40", Offset = "0x2371E40", Length = "0x123")]
	[Token(Token = "0x6000837")]
	internal NewDiffgramGen(DataTable dt, bool writeHierarchy) { }

	[Address(RVA = "0x23706C0", Offset = "0x236FAC0", Length = "0x2CC")]
	[Token(Token = "0x6000838")]
	private void CreateTableHierarchy(DataTable dt) { }

	[Address(RVA = "0x2370990", Offset = "0x236FD90", Length = "0x26A")]
	[Token(Token = "0x6000839")]
	private void DoAssignments(ArrayList tables) { }

	[Address(RVA = "0x2370C00", Offset = "0x2370000", Length = "0x115")]
	[Token(Token = "0x600083A")]
	private bool EmptyData() { }

	[Address(RVA = "0x2370D20", Offset = "0x2370120", Length = "0x94C")]
	[Token(Token = "0x6000840")]
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	[Address(RVA = "0x2371670", Offset = "0x2370A70", Length = "0x668")]
	[Token(Token = "0x600083F")]
	private void GenerateRow(DataRow row) { }

	[Address(RVA = "0x23722B0", Offset = "0x23716B0", Length = "0x84")]
	[Token(Token = "0x600083D")]
	private void GenerateTable(DataTable table) { }

	[Address(RVA = "0x2371CE0", Offset = "0x23710E0", Length = "0x5C7")]
	[Token(Token = "0x600083E")]
	private void GenerateTableErrors(DataTable table) { }

	[Address(RVA = "0x2372340", Offset = "0x2371740", Length = "0x5E")]
	[Token(Token = "0x6000841")]
	internal static string QualifiedName(string prefix, string name) { }

	[Address(RVA = "0x2372A30", Offset = "0x2371E30", Length = "0xB")]
	[Token(Token = "0x600083B")]
	internal void Save(XmlWriter xmlw) { }

	[Address(RVA = "0x23723A0", Offset = "0x23717A0", Length = "0x685")]
	[Token(Token = "0x600083C")]
	internal void Save(XmlWriter xmlw, DataTable table) { }

}

