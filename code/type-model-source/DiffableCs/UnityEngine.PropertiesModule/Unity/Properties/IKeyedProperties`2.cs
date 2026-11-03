namespace Unity.Properties;

[Token(Token = "0x2000031")]
public interface IKeyedProperties
{

	[Token(Token = "0x60000BC")]
	public bool TryGetProperty(ref TContainer container, TKey key, out IProperty<TContainer>& property) { }

}

