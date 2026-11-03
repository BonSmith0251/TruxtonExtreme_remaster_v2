namespace System.Data;

[Token(Token = "0x200002E")]
internal sealed class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000FC")]
	private readonly DataTable _table; //Field offset: 0x28

	[Address(RVA = "0x230FB30", Offset = "0x230EF30", Length = "0x90")]
	[Token(Token = "0x6000374")]
	public ParentForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable) { }

	[Address(RVA = "0x2329210", Offset = "0x2328610", Length = "0xB7")]
	[Token(Token = "0x6000375")]
	protected virtual bool IsValidCandidate(Constraint constraint) { }

}

