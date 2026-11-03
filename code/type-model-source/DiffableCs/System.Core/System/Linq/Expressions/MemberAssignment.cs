namespace System.Linq.Expressions;

[Token(Token = "0x200009B")]
public sealed class MemberAssignment : MemberBinding
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000190")]
	private readonly Expression _expression; //Field offset: 0x20

	[Token(Token = "0x170000BA")]
	public Expression Expression
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600044B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600044B")]
	public Expression get_Expression() { }

}

