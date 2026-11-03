namespace System.Dynamic;

[Token(Token = "0x2000257")]
public abstract class BinaryOperationBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000431")]
	private readonly ExpressionType <Operation>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700025A")]
	public ExpressionType Operation
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B83")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x22911B0", Offset = "0x22905B0", Length = "0xD7")]
	[Token(Token = "0x6000B86")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Address(RVA = "0x2291290", Offset = "0x2290690", Length = "0x25")]
	[Token(Token = "0x6000B84")]
	public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg) { }

	[Token(Token = "0x6000B85")]
	public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B83")]
	public ExpressionType get_Operation() { }

}

