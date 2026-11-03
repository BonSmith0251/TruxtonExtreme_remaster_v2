namespace Unity.Properties;

[Token(Token = "0x2000030")]
public interface INamedProperties
{

	[Token(Token = "0x60000BB")]
	public bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer>& property) { }

}

