namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001A6")]
internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction
{

	[Token(Token = "0x170001DC")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000942")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001DD")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22A9390", Offset = "0x22A8790", Length = "0x2C")]
		[Token(Token = "0x6000943")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000941")]
	internal StoreLocalInstruction(int index) { }

	[Address(RVA = "0x22A9280", Offset = "0x22A8680", Length = "0x65")]
	[Token(Token = "0x6000945")]
	public override Instruction BoxIfIndexMatches(int index) { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000942")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22A9390", Offset = "0x22A8790", Length = "0x2C")]
	[Token(Token = "0x6000943")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x22A92F0", Offset = "0x22A86F0", Length = "0x94")]
	[Token(Token = "0x6000944")]
	public virtual int Run(InterpretedFrame frame) { }

}

