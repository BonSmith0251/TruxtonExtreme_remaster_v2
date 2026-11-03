namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000196")]
internal sealed class ParameterByRefUpdater : ByRefUpdater
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000359")]
	private readonly LocalVariable _parameter; //Field offset: 0x18

	[Address(RVA = "0x22A6F90", Offset = "0x22A6390", Length = "0x41")]
	[Token(Token = "0x60008C0")]
	public ParameterByRefUpdater(LocalVariable parameter, int argumentIndex) { }

	[Address(RVA = "0x22A6DE0", Offset = "0x22A61E0", Length = "0x1A2")]
	[Token(Token = "0x60008C1")]
	public virtual void Update(InterpretedFrame frame, object value) { }

}

