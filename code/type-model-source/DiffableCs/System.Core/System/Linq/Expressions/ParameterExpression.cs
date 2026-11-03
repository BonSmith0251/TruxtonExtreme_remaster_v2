namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ParameterExpressionProxy))]
[Token(Token = "0x20000B6")]
public class ParameterExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BB")]
	private readonly string <Name>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000DF")]
	public bool IsByRef
	{
		[Address(RVA = "0x1DDF660", Offset = "0x1DDEA60", Length = "0x14")]
		[Token(Token = "0x60004AE")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170000DE")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60004AD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000DD")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x2268DB0", Offset = "0x22681B0", Length = "0x6")]
		[Token(Token = "0x60004AC")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000DC")]
	public virtual Type Type
	{
		[Address(RVA = "0x217A900", Offset = "0x2179D00", Length = "0x32")]
		[Token(Token = "0x60004AB")]
		 get { } //Length: 50
	}

	[Address(RVA = "0x2268D40", Offset = "0x2268140", Length = "0x65")]
	[Token(Token = "0x60004A9")]
	internal ParameterExpression(string name) { }

	[Address(RVA = "0x22685B0", Offset = "0x22679B0", Length = "0x2F")]
	[Token(Token = "0x60004B0")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x1DDF660", Offset = "0x1DDEA60", Length = "0x14")]
	[Token(Token = "0x60004AE")]
	public bool get_IsByRef() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60004AD")]
	public string get_Name() { }

	[Address(RVA = "0x2268DB0", Offset = "0x22681B0", Length = "0x6")]
	[Token(Token = "0x60004AC")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x217A900", Offset = "0x2179D00", Length = "0x32")]
	[Token(Token = "0x60004AB")]
	public virtual Type get_Type() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60004AF")]
	internal override bool GetIsByRef() { }

	[Address(RVA = "0x22685E0", Offset = "0x22679E0", Length = "0x714")]
	[Token(Token = "0x60004AA")]
	internal static ParameterExpression Make(Type type, string name, bool isByRef) { }

}

