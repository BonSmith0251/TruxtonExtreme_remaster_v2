namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000139")]
internal sealed class StoreFieldInstruction : FieldInstruction
{

	[Token(Token = "0x170001A0")]
	public virtual int ConsumedStack
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x60006DE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700019F")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x22900B0", Offset = "0x228F4B0", Length = "0x2C")]
		[Token(Token = "0x60006DD")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60006DC")]
	public StoreFieldInstruction(FieldInfo field) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x60006DE")]
	public virtual int get_ConsumedStack() { }

	[Address(RVA = "0x22900B0", Offset = "0x228F4B0", Length = "0x2C")]
	[Token(Token = "0x60006DD")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2290030", Offset = "0x228F430", Length = "0x79")]
	[Token(Token = "0x60006DF")]
	public virtual int Run(InterpretedFrame frame) { }

}

