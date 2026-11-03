namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20001DD")]
internal class ByRefNewInstruction : NewInstruction
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003A4")]
	private readonly ByRefUpdater[] _byrefArgs; //Field offset: 0x20

	[Token(Token = "0x1700020C")]
	public virtual string InstructionName
	{
		[Address(RVA = "0x2291C00", Offset = "0x2291000", Length = "0x2C")]
		[Token(Token = "0x60009EC")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x22547B0", Offset = "0x2253BB0", Length = "0x5E")]
	[Token(Token = "0x60009EB")]
	internal ByRefNewInstruction(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	[Address(RVA = "0x2291C00", Offset = "0x2291000", Length = "0x2C")]
	[Token(Token = "0x60009EC")]
	public virtual string get_InstructionName() { }

	[Address(RVA = "0x2291A00", Offset = "0x2290E00", Length = "0x1F7")]
	[Token(Token = "0x60009ED")]
	public virtual int Run(InterpretedFrame frame) { }

}

