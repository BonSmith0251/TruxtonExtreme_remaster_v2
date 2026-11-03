namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(NewExpressionProxy))]
[Token(Token = "0x20000B5")]
public class NewExpression : Expression
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001B9")]
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001BA")]
	private readonly ConstructorInfo <Constructor>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000DB")]
	public ConstructorInfo Constructor
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60004A7")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60004A7")]
	public ConstructorInfo get_Constructor() { }

	[Address(RVA = "0x2268340", Offset = "0x2267740", Length = "0x54")]
	[Token(Token = "0x60004A8")]
	public override Expression GetArgument(int index) { }

}

