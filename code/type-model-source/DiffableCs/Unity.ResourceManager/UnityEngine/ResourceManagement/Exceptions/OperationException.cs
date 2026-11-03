namespace UnityEngine.ResourceManagement.Exceptions;

[Token(Token = "0x2000016")]
public class OperationException : Exception
{

	[Address(RVA = "0x2E46230", Offset = "0x2E45630", Length = "0x69")]
	[Token(Token = "0x60000B6")]
	public OperationException(string message, Exception innerException = null) { }

	[Address(RVA = "0x2E461A0", Offset = "0x2E455A0", Length = "0x8C")]
	[Token(Token = "0x60000B7")]
	public virtual string ToString() { }

}

