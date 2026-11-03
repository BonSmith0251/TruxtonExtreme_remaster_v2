namespace System.Dynamic;

[Token(Token = "0x2000276")]
public abstract class InvokeBinder : DynamicMetaObjectBinder
{

	[Address(RVA = "0x22AFCE0", Offset = "0x22AF0E0", Length = "0xE0")]
	[Token(Token = "0x6000C4B")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Token(Token = "0x6000C4A")]
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	[Address(RVA = "0x2291290", Offset = "0x2290690", Length = "0x25")]
	[Token(Token = "0x6000C49")]
	public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args) { }

}

