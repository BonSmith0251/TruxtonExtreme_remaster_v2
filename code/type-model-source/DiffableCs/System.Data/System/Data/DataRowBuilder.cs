namespace System.Data;

[Token(Token = "0x200003C")]
public sealed class DataRowBuilder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000144")]
	internal readonly DataTable _table; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000145")]
	internal int _record; //Field offset: 0x18

	[Address(RVA = "0xF63E90", Offset = "0xF63290", Length = "0x42")]
	[Token(Token = "0x6000470")]
	internal DataRowBuilder(DataTable table, int record) { }

}

