namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000F0")]
internal abstract class IndexedBranchInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000222")]
	internal readonly int _labelIndex; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x60005FC")]
	public IndexedBranchInstruction(int labelIndex) { }

	[Address(RVA = "0x22644B0", Offset = "0x22638B0", Length = "0x54")]
	[Token(Token = "0x60005FD")]
	public RuntimeLabel GetLabel(InterpretedFrame frame) { }

	[Address(RVA = "0x2264510", Offset = "0x2263910", Length = "0xC2")]
	[Token(Token = "0x60005FE")]
	public virtual string ToDebugString(int instructionIndex, object cookie, Func<Int32, Int32> labelIndexer, IReadOnlyList<Object> objects) { }

	[Address(RVA = "0x22645E0", Offset = "0x22639E0", Length = "0x86")]
	[Token(Token = "0x60005FF")]
	public virtual string ToString() { }

}

