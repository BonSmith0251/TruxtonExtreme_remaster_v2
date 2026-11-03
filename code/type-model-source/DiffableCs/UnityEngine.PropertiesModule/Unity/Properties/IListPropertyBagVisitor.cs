namespace Unity.Properties;

[Token(Token = "0x2000052")]
public interface IListPropertyBagVisitor
{

	[Token(Token = "0x6000137")]
	public void Visit(IListPropertyBag<TList, TElement> properties, ref TList container) { }

}

