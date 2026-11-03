namespace UnityEngine.ResourceManagement.Exceptions;

[Token(Token = "0x2000014")]
public class ResourceManagerException : Exception
{

	[Address(RVA = "0x2E493D0", Offset = "0x2E487D0", Length = "0x49")]
	[Token(Token = "0x60000A8")]
	public ResourceManagerException() { }

	[Address(RVA = "0x2E494A0", Offset = "0x2E488A0", Length = "0x59")]
	[Token(Token = "0x60000A9")]
	public ResourceManagerException(string message) { }

	[Address(RVA = "0x2E49500", Offset = "0x2E48900", Length = "0x69")]
	[Token(Token = "0x60000AA")]
	public ResourceManagerException(string message, Exception innerException) { }

	[Address(RVA = "0x2E49420", Offset = "0x2E48820", Length = "0x74")]
	[Token(Token = "0x60000AB")]
	protected ResourceManagerException(SerializationInfo message, StreamingContext context) { }

	[Address(RVA = "0x2E49340", Offset = "0x2E48740", Length = "0x8C")]
	[Token(Token = "0x60000AC")]
	public virtual string ToString() { }

}

