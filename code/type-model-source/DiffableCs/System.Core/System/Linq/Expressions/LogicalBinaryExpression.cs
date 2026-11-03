namespace System.Linq.Expressions;

[Token(Token = "0x2000043")]
internal sealed class LogicalBinaryExpression : BinaryExpression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D0")]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700004C")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001A9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700004B")]
	public virtual Type Type
	{
		[Address(RVA = "0x224EA20", Offset = "0x224DE20", Length = "0x32")]
		[Token(Token = "0x60001A8")]
		 get { } //Length: 50
	}

	[Address(RVA = "0x224E9E0", Offset = "0x224DDE0", Length = "0x31")]
	[Token(Token = "0x60001A7")]
	internal LogicalBinaryExpression(ExpressionType nodeType, Expression left, Expression right) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001A9")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x224EA20", Offset = "0x224DE20", Length = "0x32")]
	[Token(Token = "0x60001A8")]
	public virtual Type get_Type() { }

}

