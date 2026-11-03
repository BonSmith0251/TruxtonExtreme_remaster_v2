namespace Mono.Btls;

[Token(Token = "0x2000076")]
internal class MonoBtlsException : Exception
{

	[Address(RVA = "0x22C3E30", Offset = "0x22C3230", Length = "0x49")]
	[Token(Token = "0x60001C5")]
	public MonoBtlsException() { }

	[Address(RVA = "0x22C3F00", Offset = "0x22C3300", Length = "0x8D")]
	[Token(Token = "0x60001C6")]
	public MonoBtlsException(MonoBtlsSslError error) { }

	[Address(RVA = "0x22C3DD0", Offset = "0x22C31D0", Length = "0x59")]
	[Token(Token = "0x60001C7")]
	public MonoBtlsException(string message) { }

	[Address(RVA = "0x22C3E80", Offset = "0x22C3280", Length = "0x77")]
	[Token(Token = "0x60001C8")]
	public MonoBtlsException(string format, Object[] args) { }

}

