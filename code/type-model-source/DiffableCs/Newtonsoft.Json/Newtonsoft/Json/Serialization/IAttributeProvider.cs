namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
[Token(Token = "0x200010C")]
public interface IAttributeProvider
{

	[Token(Token = "0x60007BF")]
	public IList<Attribute> GetAttributes(bool inherit) { }

	[Token(Token = "0x60007C0")]
	public IList<Attribute> GetAttributes(Type attributeType, bool inherit) { }

}

