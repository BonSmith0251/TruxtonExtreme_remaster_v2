namespace System.Data;

[Token(Token = "0x200002D")]
internal sealed class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000FB")]
	private readonly DataTable _table; //Field offset: 0x28

	[Address(RVA = "0x230FB30", Offset = "0x230EF30", Length = "0x90")]
	[Token(Token = "0x6000372")]
	public ChildForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable) { }

	[Address(RVA = "0x230FA70", Offset = "0x230EE70", Length = "0xB7")]
	[Token(Token = "0x6000373")]
	protected virtual bool IsValidCandidate(Constraint constraint) { }

}

