namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000240")]
internal sealed class CastReferenceToEnumInstruction : CastInstruction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400040A")]
	private readonly Type _t; //Field offset: 0x10

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000AFF")]
	public CastReferenceToEnumInstruction(Type t) { }

	[Address(RVA = "0x2292870", Offset = "0x2291C70", Length = "0x8C")]
	[Token(Token = "0x6000B00")]
	public virtual int Run(InterpretedFrame frame) { }

}

