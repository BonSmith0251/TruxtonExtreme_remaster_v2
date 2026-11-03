namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000197")]
internal sealed class ArrayByRefUpdater : ByRefUpdater
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400035A")]
	private readonly LocalDefinition _array; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400035B")]
	private readonly LocalDefinition _index; //Field offset: 0x28

	[Address(RVA = "0x2290E30", Offset = "0x2290230", Length = "0x62")]
	[Token(Token = "0x60008C2")]
	public ArrayByRefUpdater(LocalDefinition array, LocalDefinition index, int argumentIndex) { }

	[Address(RVA = "0x2290C80", Offset = "0x2290080", Length = "0x8F")]
	[Token(Token = "0x60008C4")]
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[Address(RVA = "0x2290D10", Offset = "0x2290110", Length = "0x114")]
	[Token(Token = "0x60008C3")]
	public virtual void Update(InterpretedFrame frame, object value) { }

}

