namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000195")]
internal abstract class ByRefUpdater
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000358")]
	public readonly int ArgumentIndex; //Field offset: 0x10

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x60008BD")]
	public ByRefUpdater(int argumentIndex) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60008BF")]
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[Token(Token = "0x60008BE")]
	public abstract void Update(InterpretedFrame frame, object value) { }

}

