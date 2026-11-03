namespace Unity.Properties;

[Token(Token = "0x200002F")]
public interface IIndexedProperties
{

	[Token(Token = "0x60000BA")]
	public bool TryGetProperty(ref TContainer container, int index, out IProperty<TContainer>& property) { }

}

