namespace System.Dynamic;

[Token(Token = "0x2000262")]
public abstract class DeleteIndexBinder : DynamicMetaObjectBinder
{

	[Address(RVA = "0x2295670", Offset = "0x2294A70", Length = "0xAA")]
	[Token(Token = "0x6000BA8")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Address(RVA = "0x2291290", Offset = "0x2290690", Length = "0x25")]
	[Token(Token = "0x6000BA9")]
	public DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	[Token(Token = "0x6000BAA")]
	public abstract DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion) { }

}

