namespace UnityEngine.UIElements;

[Obsolete("IUxmlObjectFactory<out T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x200050F")]
internal interface IUxmlObjectFactory : IBaseUxmlObjectFactory, IBaseUxmlFactory
{

	[Token(Token = "0x6002590")]
	public T CreateObject(IUxmlAttributes bag, CreationContext cc) { }

}

