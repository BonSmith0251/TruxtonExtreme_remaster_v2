namespace System.Data;

[Token(Token = "0x200002C")]
internal class ForeignKeyConstraintEnumerator : ConstraintEnumerator
{

	[Address(RVA = "0x2314A40", Offset = "0x2313E40", Length = "0x73")]
	[Token(Token = "0x600036F")]
	public ForeignKeyConstraintEnumerator(DataSet dataSet) { }

	[Address(RVA = "0x23284F0", Offset = "0x23278F0", Length = "0x6B")]
	[Token(Token = "0x6000371")]
	public ForeignKeyConstraint GetForeignKeyConstraint() { }

	[Address(RVA = "0x2328560", Offset = "0x2327960", Length = "0x71")]
	[Token(Token = "0x6000370")]
	protected virtual bool IsValidCandidate(Constraint constraint) { }

}

