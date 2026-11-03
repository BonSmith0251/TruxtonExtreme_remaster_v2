namespace Unity.Properties;

[Token(Token = "0x2000033")]
public interface IPropertyBag : IPropertyBag
{

	[Token(Token = "0x60000C1")]
	public void Accept(IPropertyBagVisitor visitor, ref TContainer container) { }

	[Token(Token = "0x60000C0")]
	public PropertyCollection<TContainer> GetProperties(ref TContainer container) { }

	[Token(Token = "0x60000BF")]
	public PropertyCollection<TContainer> GetProperties() { }

}

