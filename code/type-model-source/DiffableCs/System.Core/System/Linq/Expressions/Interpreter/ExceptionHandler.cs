namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200018B")]
internal sealed class ExceptionHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000332")]
	private readonly Type _exceptionType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000333")]
	public readonly int LabelIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000334")]
	public readonly int HandlerStartIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000335")]
	public readonly int HandlerEndIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000336")]
	public readonly ExceptionFilter Filter; //Field offset: 0x28

	[Address(RVA = "0x226EF00", Offset = "0x226E300", Length = "0x67")]
	[Token(Token = "0x6000840")]
	internal ExceptionHandler(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter) { }

	[Address(RVA = "0x226EDE0", Offset = "0x226E1E0", Length = "0x2A")]
	[Token(Token = "0x6000841")]
	public bool Matches(Type exceptionType) { }

	[Address(RVA = "0x226EE10", Offset = "0x226E210", Length = "0xEB")]
	[Token(Token = "0x6000842")]
	public virtual string ToString() { }

}

