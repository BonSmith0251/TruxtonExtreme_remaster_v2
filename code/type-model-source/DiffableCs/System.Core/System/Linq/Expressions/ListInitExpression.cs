namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ListInitExpressionProxy))]
[Token(Token = "0x2000099")]
public sealed class ListInitExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400018B")]
	private readonly NewExpression <NewExpression>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400018C")]
	private readonly ReadOnlyCollection<ElementInit> <Initializers>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000B4")]
	public ReadOnlyCollection<ElementInit> Initializers
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000442")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000B3")]
	public NewExpression NewExpression
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000441")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000442")]
	public ReadOnlyCollection<ElementInit> get_Initializers() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000441")]
	public NewExpression get_NewExpression() { }

}

