namespace System.Net;

[Token(Token = "0x2000222")]
public class HttpVersion
{
	[Token(Token = "0x4000812")]
	public static readonly Version Unknown; //Field offset: 0x0
	[Token(Token = "0x4000813")]
	public static readonly Version Version10; //Field offset: 0x8
	[Token(Token = "0x4000814")]
	public static readonly Version Version11; //Field offset: 0x10
	[Token(Token = "0x4000815")]
	public static readonly Version Version20; //Field offset: 0x18

	[Address(RVA = "0x26A74C0", Offset = "0x26A68C0", Length = "0x163")]
	[Token(Token = "0x6000E56")]
	private static HttpVersion() { }

}

