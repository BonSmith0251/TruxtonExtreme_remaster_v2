namespace Unity.Properties;

[Token(Token = "0x200004D")]
public interface IPropertyAccept
{

	[Token(Token = "0x6000132")]
	public void Accept(IPropertyVisitor visitor, ref TContainer container) { }

}

