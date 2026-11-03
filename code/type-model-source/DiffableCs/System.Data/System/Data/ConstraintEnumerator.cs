namespace System.Data;

[Token(Token = "0x200002B")]
internal class ConstraintEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000F8")]
	private IEnumerator _tables; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000F9")]
	private IEnumerator _constraints; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000FA")]
	private Constraint _currentObject; //Field offset: 0x20

	[Token(Token = "0x1700007F")]
	protected Constraint CurrentObject
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600036E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2314A40", Offset = "0x2313E40", Length = "0x73")]
	[Token(Token = "0x600036A")]
	public ConstraintEnumerator(DataSet dataSet) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600036E")]
	protected Constraint get_CurrentObject() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600036C")]
	public Constraint GetConstraint() { }

	[Address(RVA = "0x2314810", Offset = "0x2313C10", Length = "0x22B")]
	[Token(Token = "0x600036B")]
	public bool GetNext() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600036D")]
	protected override bool IsValidCandidate(Constraint constraint) { }

}

