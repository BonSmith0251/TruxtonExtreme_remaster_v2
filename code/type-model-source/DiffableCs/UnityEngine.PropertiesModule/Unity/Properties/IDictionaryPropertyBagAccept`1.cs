namespace Unity.Properties;

[Token(Token = "0x200004C")]
public interface IDictionaryPropertyBagAccept
{

	[Token(Token = "0x6000131")]
	public void Accept(IDictionaryPropertyBagVisitor visitor, ref TContainer container) { }

}

