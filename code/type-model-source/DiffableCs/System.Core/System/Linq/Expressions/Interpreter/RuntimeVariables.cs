namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000219")]
internal sealed class RuntimeVariables : IRuntimeVariables
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003DB")]
	private readonly IStrongBox[] _boxes; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000A84")]
	private RuntimeVariables(IStrongBox[] boxes) { }

	[Address(RVA = "0x22A8BD0", Offset = "0x22A7FD0", Length = "0x60")]
	[Token(Token = "0x6000A85")]
	internal static IRuntimeVariables Create(IStrongBox[] boxes) { }

}

