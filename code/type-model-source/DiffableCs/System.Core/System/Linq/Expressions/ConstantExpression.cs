namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ConstantExpressionProxy))]
[Token(Token = "0x2000078")]
public class ConstantExpression : Expression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000101")]
	private readonly object <Value>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000075")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0x20270D0", Offset = "0x20264D0", Length = "0x6")]
		[Token(Token = "0x60002F6")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000074")]
	public virtual Type Type
	{
		[Address(RVA = "0x2255C40", Offset = "0x2255040", Length = "0x4F")]
		[Token(Token = "0x60002F5")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000076")]
	public object Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002F7")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2255BD0", Offset = "0x2254FD0", Length = "0x65")]
	[Token(Token = "0x60002F4")]
	internal ConstantExpression(object value) { }

	[Address(RVA = "0x2255BA0", Offset = "0x2254FA0", Length = "0x2F")]
	[Token(Token = "0x60002F8")]
	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[Address(RVA = "0x20270D0", Offset = "0x20264D0", Length = "0x6")]
	[Token(Token = "0x60002F6")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x2255C40", Offset = "0x2255040", Length = "0x4F")]
	[Token(Token = "0x60002F5")]
	public virtual Type get_Type() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002F7")]
	public object get_Value() { }

}

