namespace System.Net;

[Token(Token = "0x2000241")]
public abstract class EndPoint
{

	[Token(Token = "0x17000326")]
	public override AddressFamily AddressFamily
	{
		[Address(RVA = "0x269A9B0", Offset = "0x2699DB0", Length = "0x27")]
		[Token(Token = "0x6000F5F")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000F62")]
	protected EndPoint() { }

	[Address(RVA = "0x269A950", Offset = "0x2699D50", Length = "0x27")]
	[Token(Token = "0x6000F61")]
	public override EndPoint Create(SocketAddress socketAddress) { }

	[Address(RVA = "0x269A9B0", Offset = "0x2699DB0", Length = "0x27")]
	[Token(Token = "0x6000F5F")]
	public override AddressFamily get_AddressFamily() { }

	[Address(RVA = "0x269A980", Offset = "0x2699D80", Length = "0x27")]
	[Token(Token = "0x6000F60")]
	public override SocketAddress Serialize() { }

}

