namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000136")]
internal abstract class FieldInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000271")]
	protected readonly FieldInfo _field; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60006D1")]
	public FieldInstruction(FieldInfo field) { }

	[Address(RVA = "0x226F6D0", Offset = "0x226EAD0", Length = "0x9F")]
	[Token(Token = "0x60006D2")]
	public virtual string ToString() { }

}

