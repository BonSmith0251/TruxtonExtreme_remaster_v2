namespace UnityEngine.UIElements;

[Obsolete("UxmlObjectFactory<TCreatedType, TTraits> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x2000512")]
internal class UxmlObjectFactory : BaseUxmlFactory<TCreatedType, TTraits>, IUxmlObjectFactory<TCreatedType>, IBaseUxmlObjectFactory, IBaseUxmlFactory
{

	[Address(RVA = "0x11E5320", Offset = "0x11E4720", Length = "0x14")]
	[Token(Token = "0x600259A")]
	public UxmlObjectFactory`2() { }

	[Address(RVA = "0x11E5260", Offset = "0x11E4660", Length = "0xB3")]
	[Token(Token = "0x6002599")]
	public override TCreatedType CreateObject(IUxmlAttributes bag, CreationContext cc) { }

}

