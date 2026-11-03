namespace System.Data;

[Token(Token = "0x2000073")]
public class MergeFailedEventArgs : EventArgs
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400024C")]
	private readonly DataTable <Table>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400024D")]
	private readonly string <Conflict>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000FF")]
	public string Conflict
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600065F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2347430", Offset = "0x2346830", Length = "0x82")]
	[Token(Token = "0x600065E")]
	public MergeFailedEventArgs(DataTable table, string conflict) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600065F")]
	public string get_Conflict() { }

}

