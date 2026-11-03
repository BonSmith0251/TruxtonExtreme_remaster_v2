namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
[Token(Token = "0x20000E6")]
internal struct RuntimeLabel
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000210")]
	public readonly int Index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000211")]
	public readonly int StackDepth; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000212")]
	public readonly int ContinuationStackDepth; //Field offset: 0x8

	[Address(RVA = "0x2268ED0", Offset = "0x22682D0", Length = "0xB")]
	[Token(Token = "0x60005C0")]
	public RuntimeLabel(int index, int continuationStackDepth, int stackDepth) { }

	[Address(RVA = "0x2268DF0", Offset = "0x22681F0", Length = "0xD8")]
	[Token(Token = "0x60005C1")]
	public virtual string ToString() { }

}

