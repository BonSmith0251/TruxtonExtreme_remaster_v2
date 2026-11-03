namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(NewArrayExpressionProxy))]
[Token(Token = "0x20000B2")]
public class NewArrayExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001B7")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001B8")]
	private readonly ReadOnlyCollection<Expression> <Expressions>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000D8")]
	public ReadOnlyCollection<Expression> Expressions
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60004A0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000D7")]
	public virtual Type Type
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600049F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2268130", Offset = "0x2267530", Length = "0x82")]
	[Token(Token = "0x600049D")]
	internal NewArrayExpression(Type type, ReadOnlyCollection<Expression> expressions) { }

	[Address(RVA = "0x2267F10", Offset = "0x2267310", Length = "0x2F")]
	[Token(Token = "0x60004A1")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60004A0")]
	public ReadOnlyCollection<Expression> get_Expressions() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600049F")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x2267F40", Offset = "0x2267340", Length = "0x7E")]
	[Token(Token = "0x600049E")]
	internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions) { }

	[Address(RVA = "0x2267FC0", Offset = "0x22673C0", Length = "0x168")]
	[Token(Token = "0x60004A2")]
	public NewArrayExpression Update(IEnumerable<Expression> expressions) { }

}

