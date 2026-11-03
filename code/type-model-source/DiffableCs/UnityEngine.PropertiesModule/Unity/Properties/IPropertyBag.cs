namespace Unity.Properties;

[Token(Token = "0x2000032")]
public interface IPropertyBag
{

	[Token(Token = "0x60000BD")]
	public void Accept(ITypeVisitor visitor) { }

	[Token(Token = "0x60000BE")]
	public void Accept(IPropertyBagVisitor visitor, ref object container) { }

}

