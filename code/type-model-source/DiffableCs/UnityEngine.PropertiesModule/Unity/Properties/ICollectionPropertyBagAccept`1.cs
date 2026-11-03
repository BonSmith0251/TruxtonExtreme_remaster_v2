namespace Unity.Properties;

[Token(Token = "0x2000049")]
public interface ICollectionPropertyBagAccept
{

	[Token(Token = "0x600012E")]
	public void Accept(ICollectionPropertyBagVisitor visitor, ref TContainer container) { }

}

