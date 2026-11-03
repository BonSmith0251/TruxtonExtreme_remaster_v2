namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200021B")]
internal sealed class LoadCachedObjectInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003DD")]
	private readonly uint _index; //Field offset: 0x10

	[Token(Token = "0x17000225")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x229D470", Offset = "0x229C870", Length = "0x2C")]
		[Token(Token = "0x6000A8D")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000224")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000A8C")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000A8B")]
	internal LoadCachedObjectInstruction(uint index) { }

	[Address(RVA = "0x229D470", Offset = "0x229C870", Length = "0x2C")]
	[Token(Token = "0x6000A8D")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000A8C")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x229D220", Offset = "0x229C620", Length = "0xA9")]
	[Token(Token = "0x6000A8E")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x229D2D0", Offset = "0x229C6D0", Length = "0x13C")]
	[Token(Token = "0x6000A8F")]
	public virtual string ToDebugString(int instructionIndex, object cookie, Func<Int32, Int32> labelIndexer, IReadOnlyList<Object> objects) { }

	[Address(RVA = "0x229D410", Offset = "0x229C810", Length = "0x5A")]
	[Token(Token = "0x6000A90")]
	public virtual string ToString() { }

}

