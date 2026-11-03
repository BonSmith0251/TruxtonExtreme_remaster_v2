namespace Unity.Properties;

[Token(Token = "0x200004B")]
public interface ISetPropertyBagAccept
{

	[Token(Token = "0x6000130")]
	public void Accept(ISetPropertyBagVisitor visitor, ref TContainer container) { }

}

