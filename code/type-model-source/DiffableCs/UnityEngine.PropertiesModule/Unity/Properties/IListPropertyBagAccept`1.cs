namespace Unity.Properties;

[Token(Token = "0x200004A")]
public interface IListPropertyBagAccept
{

	[Token(Token = "0x600012F")]
	public void Accept(IListPropertyBagVisitor visitor, ref TContainer container) { }

}

