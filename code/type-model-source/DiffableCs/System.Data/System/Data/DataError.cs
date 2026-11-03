namespace System.Data;

[Token(Token = "0x2000033")]
internal sealed class DataError
{
	[Token(Token = "0x2000034")]
	public struct ColumnError
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000110")]
		internal DataColumn _column; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000111")]
		internal string _error; //Field offset: 0x8

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400010D")]
	private string _rowError; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400010E")]
	private int _count; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400010F")]
	private ColumnError[] _errorList; //Field offset: 0x20

	[Token(Token = "0x1700008E")]
	internal bool HasErrors
	{
		[Address(RVA = "0x2319010", Offset = "0x2318410", Length = "0x2B")]
		[Token(Token = "0x60003B4")]
		internal get { } //Length: 43
	}

	[Token(Token = "0x1700008D")]
	internal string Text
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60003B2")]
		internal get { } //Length: 5
		[Address(RVA = "0x2318F70", Offset = "0x2318370", Length = "0x23")]
		[Token(Token = "0x60003B3")]
		internal set { } //Length: 35
	}

	[Address(RVA = "0x1D39B10", Offset = "0x1D38F10", Length = "0x36")]
	[Token(Token = "0x60003B0")]
	internal DataError() { }

	[Address(RVA = "0x2318FA0", Offset = "0x23183A0", Length = "0x68")]
	[Token(Token = "0x60003B1")]
	internal DataError(string rowError) { }

	[Address(RVA = "0x23188C0", Offset = "0x2317CC0", Length = "0xA8")]
	[Token(Token = "0x60003B7")]
	internal void Clear(DataColumn column) { }

	[Address(RVA = "0x2318970", Offset = "0x2317D70", Length = "0x72")]
	[Token(Token = "0x60003B8")]
	internal void Clear() { }

	[Address(RVA = "0x2319010", Offset = "0x2318410", Length = "0x2B")]
	[Token(Token = "0x60003B4")]
	internal bool get_HasErrors() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60003B2")]
	internal string get_Text() { }

	[Address(RVA = "0x23189F0", Offset = "0x2317DF0", Length = "0x6E")]
	[Token(Token = "0x60003B6")]
	internal string GetColumnError(DataColumn column) { }

	[Address(RVA = "0x2318A60", Offset = "0x2317E60", Length = "0xEF")]
	[Token(Token = "0x60003B9")]
	internal DataColumn[] GetColumnsInError() { }

	[Address(RVA = "0x2318B50", Offset = "0x2317F50", Length = "0x153")]
	[Token(Token = "0x60003BB")]
	internal int IndexOf(DataColumn column) { }

	[Address(RVA = "0x2318F70", Offset = "0x2318370", Length = "0x23")]
	[Token(Token = "0x60003B3")]
	internal void set_Text(string value) { }

	[Address(RVA = "0x2318CB0", Offset = "0x23180B0", Length = "0x2BD")]
	[Token(Token = "0x60003B5")]
	internal void SetColumnError(DataColumn column, string error) { }

	[Address(RVA = "0x2318F70", Offset = "0x2318370", Length = "0x23")]
	[Token(Token = "0x60003BA")]
	private void SetText(string errorText) { }

}

