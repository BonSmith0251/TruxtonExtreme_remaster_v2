namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x20000EA")]
internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400021A")]
	private readonly ByRefUpdater[] _byrefArgs; //Field offset: 0x20

	[Token(Token = "0x17000158")]
	public virtual int ProducedStack
	{
		[Address(RVA = "0x2254810", Offset = "0x2253C10", Length = "0x7F")]
		[Token(Token = "0x60005DE")]
		 get { } //Length: 127
	}

	[Address(RVA = "0x22547B0", Offset = "0x2253BB0", Length = "0x5E")]
	[Token(Token = "0x60005DD")]
	internal ByRefMethodInfoCallInstruction(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	[Address(RVA = "0x2254810", Offset = "0x2253C10", Length = "0x7F")]
	[Token(Token = "0x60005DE")]
	public virtual int get_ProducedStack() { }

	[Address(RVA = "0x2254290", Offset = "0x2253690", Length = "0x513")]
	[Token(Token = "0x60005DF")]
	public virtual int Run(InterpretedFrame frame) { }

}

