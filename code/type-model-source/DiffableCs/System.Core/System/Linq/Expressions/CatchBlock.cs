namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(CatchBlockProxy))]
[Token(Token = "0x2000071")]
public sealed class CatchBlock
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000F4")]
	private readonly ParameterExpression <Variable>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000F5")]
	private readonly Type <Test>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F6")]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000F7")]
	private readonly Expression <Filter>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x1700006C")]
	public Expression Body
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002DF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006D")]
	public Expression Filter
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002E0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006B")]
	public Type Test
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002DE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006A")]
	public ParameterExpression Variable
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002DD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x22553D0", Offset = "0x22547D0", Length = "0x7D")]
	[Token(Token = "0x60002DC")]
	internal CatchBlock(Type test, ParameterExpression variable, Expression body, Expression filter) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002DF")]
	public Expression get_Body() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002E0")]
	public Expression get_Filter() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002DE")]
	public Type get_Test() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002DD")]
	public ParameterExpression get_Variable() { }

	[Address(RVA = "0x2255250", Offset = "0x2254650", Length = "0xD5")]
	[Token(Token = "0x60002E1")]
	public virtual string ToString() { }

	[Address(RVA = "0x2255330", Offset = "0x2254730", Length = "0x9B")]
	[Token(Token = "0x60002E2")]
	public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body) { }

}

