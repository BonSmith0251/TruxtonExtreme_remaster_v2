namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200019A")]
internal sealed class IndexMethodByRefUpdater : ByRefUpdater
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000360")]
	private readonly MethodInfo _indexer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000361")]
	private readonly Nullable<LocalDefinition> _obj; //Field offset: 0x20
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000362")]
	private readonly LocalDefinition[] _args; //Field offset: 0x38

	[Address(RVA = "0x229A8B0", Offset = "0x2299CB0", Length = "0x7E")]
	[Token(Token = "0x60008CB")]
	public IndexMethodByRefUpdater(Nullable<LocalDefinition> obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex) { }

	[Address(RVA = "0x229A470", Offset = "0x2299870", Length = "0x1D6")]
	[Token(Token = "0x60008CD")]
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[Address(RVA = "0x229A650", Offset = "0x2299A50", Length = "0x25D")]
	[Token(Token = "0x60008CC")]
	public virtual void Update(InterpretedFrame frame, object value) { }

}

