namespace Unity.Properties;

[Token(Token = "0x2000054")]
public interface IDictionaryPropertyBagVisitor
{

	[Token(Token = "0x6000139")]
	public void Visit(IDictionaryPropertyBag<TDictionary, TKey, TValue> properties, ref TDictionary container) { }

}

