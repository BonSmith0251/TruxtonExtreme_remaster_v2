namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x20001C2")]
public class UnityException : Exception
{

	[Address(RVA = "0x3073F70", Offset = "0x3073370", Length = "0x65")]
	[Token(Token = "0x600140B")]
	public UnityException() { }

	[Address(RVA = "0x3074060", Offset = "0x3073460", Length = "0x61")]
	[Token(Token = "0x600140C")]
	public UnityException(string message) { }

	[Address(RVA = "0x3073FE0", Offset = "0x30733E0", Length = "0x74")]
	[Token(Token = "0x600140D")]
	protected UnityException(SerializationInfo info, StreamingContext context) { }

}

