namespace System.Data;

[Token(Token = "0x200003E")]
public class DataRowChangeEventArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400014F")]
	private readonly DataRow <Row>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000150")]
	private readonly DataRowAction <Action>k__BackingField; //Field offset: 0x18

	[Address(RVA = "0x231EF50", Offset = "0x231E350", Length = "0x76")]
	[Token(Token = "0x6000471")]
	public DataRowChangeEventArgs(DataRow row, DataRowAction action) { }

}

