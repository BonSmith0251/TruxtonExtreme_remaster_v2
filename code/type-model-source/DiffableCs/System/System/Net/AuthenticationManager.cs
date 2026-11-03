namespace System.Net;

[Token(Token = "0x200028F")]
public class AuthenticationManager
{
	[Token(Token = "0x4000A6E")]
	private static ArrayList modules; //Field offset: 0x0
	[Token(Token = "0x4000A6F")]
	private static object locker; //Field offset: 0x8
	[Token(Token = "0x4000A70")]
	private static ICredentialPolicy credential_policy; //Field offset: 0x10

	[Address(RVA = "0x26B3440", Offset = "0x26B2840", Length = "0xA7")]
	[Token(Token = "0x600112F")]
	private static AuthenticationManager() { }

	[Address(RVA = "0x26B28E0", Offset = "0x26B1CE0", Length = "0x156")]
	[Token(Token = "0x600112C")]
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	[Address(RVA = "0x26B2A40", Offset = "0x26B1E40", Length = "0x371")]
	[Token(Token = "0x600112D")]
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	[Address(RVA = "0x26B2DC0", Offset = "0x26B21C0", Length = "0x292")]
	[Token(Token = "0x600112B")]
	private static void EnsureModules() { }

	[Address(RVA = "0x26B3060", Offset = "0x26B2460", Length = "0x3D5")]
	[Token(Token = "0x600112E")]
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

}

