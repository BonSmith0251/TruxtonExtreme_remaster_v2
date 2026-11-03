namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000F6")]
internal sealed class EnterFaultInstruction : IndexedBranchInstruction
{
	[Token(Token = "0x400022C")]
	private static readonly EnterFaultInstruction[] s_cache; //Field offset: 0x0

	[Token(Token = "0x17000176")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2257C60", Offset = "0x2257060", Length = "0x2C")]
		[Token(Token = "0x6000623")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000177")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000624")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2257BF0", Offset = "0x2256FF0", Length = "0x68")]
	[Token(Token = "0x6000627")]
	private static EnterFaultInstruction() { }

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000622")]
	private EnterFaultInstruction(int labelIndex) { }

	[Address(RVA = "0x2257A60", Offset = "0x2256E60", Length = "0x101")]
	[Token(Token = "0x6000625")]
	internal static EnterFaultInstruction Create(int labelIndex) { }

	[Address(RVA = "0x2257C60", Offset = "0x2257060", Length = "0x2C")]
	[Token(Token = "0x6000623")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000624")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2257B70", Offset = "0x2256F70", Length = "0x77")]
	[Token(Token = "0x6000626")]
	public virtual int Run(InterpretedFrame frame) { }

}

