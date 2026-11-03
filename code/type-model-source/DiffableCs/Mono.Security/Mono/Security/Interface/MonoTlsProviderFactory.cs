namespace Mono.Security.Interface;

[Token(Token = "0x2000043")]
public static class MonoTlsProviderFactory
{

	[Address(RVA = "0x1E51EF0", Offset = "0x1E512F0", Length = "0x68")]
	[Token(Token = "0x600015A")]
	public static MonoTlsProvider GetProvider() { }

}

