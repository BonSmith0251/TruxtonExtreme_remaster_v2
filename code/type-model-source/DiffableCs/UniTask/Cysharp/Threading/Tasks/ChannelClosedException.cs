namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000022")]
public class ChannelClosedException : InvalidOperationException
{

	[Address(RVA = "0x2731940", Offset = "0x2730D40", Length = "0x3C")]
	[Token(Token = "0x60000BB")]
	public ChannelClosedException() { }

	[Address(RVA = "0x26ABD10", Offset = "0x26AB110", Length = "0x8")]
	[Token(Token = "0x60000BC")]
	public ChannelClosedException(string message) { }

	[Address(RVA = "0x2731980", Offset = "0x2730D80", Length = "0x4B")]
	[Token(Token = "0x60000BD")]
	public ChannelClosedException(Exception innerException) { }

	[Address(RVA = "0x27319D0", Offset = "0x2730DD0", Length = "0x8")]
	[Token(Token = "0x60000BE")]
	public ChannelClosedException(string message, Exception innerException) { }

}

