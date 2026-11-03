namespace System.Reflection;

[Token(Token = "0x20004E5")]
public interface ICustomAttributeProvider
{

	[Token(Token = "0x6002250")]
	public Object[] GetCustomAttributes(bool inherit) { }

	[Token(Token = "0x6002251")]
	public Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Token(Token = "0x6002252")]
	public bool IsDefined(Type attributeType, bool inherit) { }

}

