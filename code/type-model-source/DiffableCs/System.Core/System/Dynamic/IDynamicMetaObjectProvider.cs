namespace System.Dynamic;

[Token(Token = "0x2000275")]
public interface IDynamicMetaObjectProvider
{

	[Token(Token = "0x6000C48")]
	public DynamicMetaObject GetMetaObject(Expression parameter) { }

}

