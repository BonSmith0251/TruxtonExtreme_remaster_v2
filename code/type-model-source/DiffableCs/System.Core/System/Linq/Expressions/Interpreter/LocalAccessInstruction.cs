namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A0")]
internal abstract class LocalAccessInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000370")]
	internal readonly int _index; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000928")]
	protected LocalAccessInstruction(int index) { }

	[Address(RVA = "0x229DA90", Offset = "0x229CE90", Length = "0x1C0")]
	[Token(Token = "0x6000929")]
	public virtual string ToDebugString(int instructionIndex, object cookie, Func<Int32, Int32> labelIndexer, IReadOnlyList<Object> objects) { }

}

