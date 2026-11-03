namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200022F")]
internal sealed class TypeIsInstruction : Instruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003EF")]
	private readonly Type _type; //Field offset: 0x10

	[Token(Token = "0x17000233")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000AC7")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000235")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22AC270", Offset = "0x22AB670", Length = "0x2C")]
		[Token(Token = "0x6000AC9")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000234")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000AC8")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000AC6")]
	internal TypeIsInstruction(Type type) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000AC7")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22AC270", Offset = "0x22AB670", Length = "0x2C")]
	[Token(Token = "0x6000AC9")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000AC8")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x22AC1A0", Offset = "0x22AB5A0", Length = "0x62")]
	[Token(Token = "0x6000ACA")]
	public virtual int Run(InterpretedFrame frame) { }

	[Address(RVA = "0x22AC210", Offset = "0x22AB610", Length = "0x5D")]
	[Token(Token = "0x6000ACB")]
	public virtual string ToString() { }

}

