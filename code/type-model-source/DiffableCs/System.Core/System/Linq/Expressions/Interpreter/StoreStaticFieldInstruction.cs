namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200013A")]
internal sealed class StoreStaticFieldInstruction : FieldInstruction
{

	[Token(Token = "0x170001A2")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60006E2")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001A1")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2290140", Offset = "0x228F540", Length = "0x2C")]
		[Token(Token = "0x60006E1")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60006E0")]
	public StoreStaticFieldInstruction(FieldInfo field) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60006E2")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x2290140", Offset = "0x228F540", Length = "0x2C")]
	[Token(Token = "0x60006E1")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x22900E0", Offset = "0x228F4E0", Length = "0x54")]
	[Token(Token = "0x60006E3")]
	public virtual int Run(InterpretedFrame frame) { }

}

