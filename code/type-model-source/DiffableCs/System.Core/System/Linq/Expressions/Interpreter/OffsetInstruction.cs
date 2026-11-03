namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000EB")]
internal abstract class OffsetInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400021B")]
	protected int _offset; //Field offset: 0x10

	[Token(Token = "0x17000159")]
	public abstract Instruction[] Cache
	{
		[Token(Token = "0x60005E0")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x22539E0", Offset = "0x2252DE0", Length = "0xE")]
	[Token(Token = "0x60005E4")]
	protected OffsetInstruction() { }

	[Address(RVA = "0x22683A0", Offset = "0x22677A0", Length = "0x9E")]
	[Token(Token = "0x60005E1")]
	public Instruction Fixup(int offset) { }

	[Token(Token = "0x60005E0")]
	public abstract Instruction[] get_Cache() { }

	[Address(RVA = "0x2268440", Offset = "0x2267840", Length = "0xB4")]
	[Token(Token = "0x60005E2")]
	public virtual string ToDebugString(int instructionIndex, object cookie, Func<Int32, Int32> labelIndexer, IReadOnlyList<Object> objects) { }

	[Address(RVA = "0x2268500", Offset = "0x2267900", Length = "0xA8")]
	[Token(Token = "0x60005E3")]
	public virtual string ToString() { }

}

