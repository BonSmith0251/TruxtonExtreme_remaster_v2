namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000198")]
internal sealed class FieldByRefUpdater : ByRefUpdater
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400035C")]
	private readonly Nullable<LocalDefinition> _object; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400035D")]
	private readonly FieldInfo _field; //Field offset: 0x30

	[Address(RVA = "0x2299E10", Offset = "0x2299210", Length = "0x6A")]
	[Token(Token = "0x60008C5")]
	public FieldByRefUpdater(Nullable<LocalDefinition> obj, FieldInfo field, int argumentIndex) { }

	[Address(RVA = "0x2299CD0", Offset = "0x22990D0", Length = "0x96")]
	[Token(Token = "0x60008C7")]
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	[Address(RVA = "0x2299D70", Offset = "0x2299170", Length = "0x9B")]
	[Token(Token = "0x60008C6")]
	public virtual void Update(InterpretedFrame frame, object value) { }

}

