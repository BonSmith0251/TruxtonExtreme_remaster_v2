namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200023F")]
internal sealed class CastToEnumInstruction : CastInstruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000409")]
	private readonly Type _t; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000AFD")]
	public CastToEnumInstruction(Type t) { }

	[Address(RVA = "0x2292D00", Offset = "0x2292100", Length = "0x7D")]
	[Token(Token = "0x6000AFE")]
	public virtual int Run(InterpretedFrame frame) { }

}

