namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MemberInitExpressionProxy))]
[Token(Token = "0x20000A1")]
public sealed class MemberInitExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400019A")]
	private readonly NewExpression <NewExpression>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400019B")]
	private readonly ReadOnlyCollection<MemberBinding> <Bindings>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000C3")]
	public ReadOnlyCollection<MemberBinding> Bindings
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600045E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C2")]
	public NewExpression NewExpression
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600045D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600045E")]
	public ReadOnlyCollection<MemberBinding> get_Bindings() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600045D")]
	public NewExpression get_NewExpression() { }

}

