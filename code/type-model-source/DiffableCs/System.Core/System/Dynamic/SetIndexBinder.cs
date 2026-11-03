namespace System.Dynamic;

[Token(Token = "0x2000278")]
public abstract class SetIndexBinder : DynamicMetaObjectBinder
{

	[Address(RVA = "0x22B3EF0", Offset = "0x22B32F0", Length = "0x1F6")]
	[Token(Token = "0x6000C52")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Address(RVA = "0x22B40F0", Offset = "0x22B34F0", Length = "0x2B")]
	[Token(Token = "0x6000C53")]
	public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	[Token(Token = "0x6000C54")]
	public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

}

