namespace System.Linq.Expressions;

[Token(Token = "0x2000047")]
internal class SimpleBinaryExpression : BinaryExpression
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D3")]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D4")]
	private readonly Type <Type>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x17000051")]
	public virtual ExpressionType NodeType
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60001B4")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000052")]
	public virtual Type Type
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60001B5")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x224EE20", Offset = "0x224E220", Length = "0x42")]
	[Token(Token = "0x60001B3")]
	internal SimpleBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60001B4")]
	public virtual ExpressionType get_NodeType() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001B5")]
	public virtual Type get_Type() { }

}

