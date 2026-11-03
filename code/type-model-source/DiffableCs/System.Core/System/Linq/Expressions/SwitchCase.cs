namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(SwitchCaseProxy))]
[Token(Token = "0x20000BE")]
public sealed class SwitchCase
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C1")]
	private readonly ReadOnlyCollection<Expression> <TestValues>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C2")]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700011E")]
	public Expression Body
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000538")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700011D")]
	public ReadOnlyCollection<Expression> TestValues
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000537")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000538")]
	public Expression get_Body() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000537")]
	public ReadOnlyCollection<Expression> get_TestValues() { }

}

