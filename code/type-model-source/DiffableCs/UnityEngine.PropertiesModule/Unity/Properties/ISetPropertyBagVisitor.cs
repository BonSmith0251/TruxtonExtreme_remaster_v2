namespace Unity.Properties;

[Token(Token = "0x2000053")]
public interface ISetPropertyBagVisitor
{

	[Token(Token = "0x6000138")]
	public void Visit(ISetPropertyBag<TSet, TValue> properties, ref TSet container) { }

}

