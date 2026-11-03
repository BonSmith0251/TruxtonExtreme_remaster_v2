namespace System.Dynamic;

[Token(Token = "0x200027A")]
public abstract class UnaryOperationBinder : DynamicMetaObjectBinder
{

	[Address(RVA = "0x22B9660", Offset = "0x22B8A60", Length = "0xEF")]
	[Token(Token = "0x6000C5F")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Token(Token = "0x6000C5E")]
	public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	[Address(RVA = "0x1E57D60", Offset = "0x1E57160", Length = "0x17")]
	[Token(Token = "0x6000C5D")]
	public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target) { }

}

