namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200018A")]
internal sealed class ExceptionFilter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400032F")]
	public readonly int LabelIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000330")]
	public readonly int StartIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000331")]
	public readonly int EndIndex; //Field offset: 0x18

	[Address(RVA = "0x11EB3F0", Offset = "0x11EA7F0", Length = "0x44")]
	[Token(Token = "0x600083F")]
	internal ExceptionFilter(int labelIndex, int start, int end) { }

}

