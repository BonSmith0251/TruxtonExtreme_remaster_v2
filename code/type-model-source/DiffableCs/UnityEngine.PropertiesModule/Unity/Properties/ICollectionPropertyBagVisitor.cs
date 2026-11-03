namespace Unity.Properties;

[Token(Token = "0x2000051")]
public interface ICollectionPropertyBagVisitor
{

	[Token(Token = "0x6000136")]
	public void Visit(ICollectionPropertyBag<TCollection, TElement> properties, ref TCollection container) { }

}

