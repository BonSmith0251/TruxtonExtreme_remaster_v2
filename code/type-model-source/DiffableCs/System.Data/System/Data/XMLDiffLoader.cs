namespace System.Data;

[Token(Token = "0x2000093")]
internal sealed class XMLDiffLoader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002D9")]
	private ArrayList _tables; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002DA")]
	private DataSet _dataSet; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002DB")]
	private DataTable _dataTable; //Field offset: 0x20

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000789")]
	public XMLDiffLoader() { }

	[Address(RVA = "0x2354BE0", Offset = "0x2353FE0", Length = "0x2CC")]
	[Token(Token = "0x6000780")]
	private void CreateTablesHierarchy(DataTable dt) { }

	[Address(RVA = "0x2354EB0", Offset = "0x23542B0", Length = "0x208")]
	[Token(Token = "0x6000786")]
	private DataTable GetTable(string tableName, string ns) { }

	[Address(RVA = "0x23550C0", Offset = "0x23544C0", Length = "0x199")]
	[Token(Token = "0x600077F")]
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	[Address(RVA = "0x2355260", Offset = "0x2354660", Length = "0x20F")]
	[Token(Token = "0x6000781")]
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	[Address(RVA = "0x2355470", Offset = "0x2354870", Length = "0x3AA")]
	[Token(Token = "0x6000782")]
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	[Address(RVA = "0x2355820", Offset = "0x2354C20", Length = "0x354")]
	[Token(Token = "0x6000783")]
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	[Address(RVA = "0x23560D0", Offset = "0x23554D0", Length = "0x41C")]
	[Token(Token = "0x6000784")]
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	[Address(RVA = "0x2355B80", Offset = "0x2354F80", Length = "0x545")]
	[Token(Token = "0x6000785")]
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	[Address(RVA = "0x23564F0", Offset = "0x23558F0", Length = "0xF4A")]
	[Token(Token = "0x6000787")]
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	[Address(RVA = "0x2357440", Offset = "0x2356840", Length = "0x69")]
	[Token(Token = "0x6000788")]
	internal void SkipWhitespaces(XmlReader reader) { }

}

