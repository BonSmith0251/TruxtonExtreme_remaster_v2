namespace Mono.Security.Interface;

[Token(Token = "0x2000045")]
public sealed class TlsException : Exception
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40001FB")]
	private Alert alert; //Field offset: 0x90

	[Address(RVA = "0x1E57FC0", Offset = "0x1E573C0", Length = "0x7B")]
	[Token(Token = "0x600017B")]
	public TlsException(Alert alert) { }

	[Address(RVA = "0x1E57E00", Offset = "0x1E57200", Length = "0x7C")]
	[Token(Token = "0x600017C")]
	public TlsException(Alert alert, string message) { }

	[Address(RVA = "0x1E57F00", Offset = "0x1E57300", Length = "0xBF")]
	[Token(Token = "0x600017D")]
	public TlsException(AlertDescription description) { }

	[Address(RVA = "0x1E57E80", Offset = "0x1E57280", Length = "0x7C")]
	[Token(Token = "0x600017E")]
	public TlsException(AlertDescription description, string message) { }

}

