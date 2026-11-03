namespace System.Data;

[Token(Token = "0x200002F")]
public class DataColumnChangeEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000FD")]
	private DataColumn _column; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000FE")]
	private readonly DataRow <Row>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000FF")]
	private object <ProposedValue>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000080")]
	public object ProposedValue
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000378")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000379")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2314FB0", Offset = "0x23143B0", Length = "0x65")]
	[Token(Token = "0x6000376")]
	internal DataColumnChangeEventArgs(DataRow row) { }

	[Address(RVA = "0x2315020", Offset = "0x2314420", Length = "0x9F")]
	[Token(Token = "0x6000377")]
	public DataColumnChangeEventArgs(DataRow row, DataColumn column, object value) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000378")]
	public object get_ProposedValue() { }

	[Address(RVA = "0x2314F70", Offset = "0x2314370", Length = "0x37")]
	[Token(Token = "0x600037A")]
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000379")]
	public void set_ProposedValue(object value) { }

}

