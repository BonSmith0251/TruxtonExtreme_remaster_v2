namespace System.Dynamic;

[Token(Token = "0x2000261")]
public abstract class CreateInstanceBinder : DynamicMetaObjectBinder
{

	[Address(RVA = "0x22940F0", Offset = "0x22934F0", Length = "0xAA")]
	[Token(Token = "0x6000BA7")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Token(Token = "0x6000BA6")]
	public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	[Address(RVA = "0x2291290", Offset = "0x2290690", Length = "0x25")]
	[Token(Token = "0x6000BA5")]
	public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args) { }

}

