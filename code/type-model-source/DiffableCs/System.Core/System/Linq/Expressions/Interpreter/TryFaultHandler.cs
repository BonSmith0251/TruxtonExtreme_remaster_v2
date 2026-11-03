namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200018D")]
internal sealed class TryFaultHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400033D")]
	internal readonly int TryStartIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400033E")]
	internal readonly int TryEndIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400033F")]
	internal readonly int FinallyStartIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000340")]
	internal readonly int FinallyEndIndex; //Field offset: 0x1C

	[Address(RVA = "0x2290640", Offset = "0x228FA40", Length = "0x4B")]
	[Token(Token = "0x600084A")]
	internal TryFaultHandler(int tryStart, int tryEnd, int finallyStart, int finallyEnd) { }

}

