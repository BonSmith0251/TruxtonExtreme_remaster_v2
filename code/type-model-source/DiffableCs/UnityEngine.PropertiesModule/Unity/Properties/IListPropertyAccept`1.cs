namespace Unity.Properties;

[Token(Token = "0x200004E")]
public interface IListPropertyAccept
{

	[Token(Token = "0x6000133")]
	public void Accept(IListPropertyVisitor visitor, Property<TContainer, TList> property, ref TContainer container, ref TList list) { }

}

