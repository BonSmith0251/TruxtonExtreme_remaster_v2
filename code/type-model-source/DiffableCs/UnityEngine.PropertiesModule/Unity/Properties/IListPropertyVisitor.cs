namespace Unity.Properties;

[Token(Token = "0x2000056")]
public interface IListPropertyVisitor
{

	[Token(Token = "0x600013B")]
	public void Visit(Property<TContainer, TList> property, ref TContainer container, ref TList list) { }

}

