namespace System.Dynamic;

[Token(Token = "0x2000273")]
public abstract class GetIndexBinder : DynamicMetaObjectBinder
{

	[Address(RVA = "0x22AFA40", Offset = "0x22AEE40", Length = "0xE0")]
	[Token(Token = "0x6000C3D")]
	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	[Address(RVA = "0x2291290", Offset = "0x2290690", Length = "0x25")]
	[Token(Token = "0x6000C3E")]
	public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	[Token(Token = "0x6000C3F")]
	public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion) { }

}

