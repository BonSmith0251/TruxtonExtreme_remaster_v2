namespace Mono.Btls;

[Token(Token = "0x20000A2")]
internal static class MonoBtlsX509StoreManager
{
	[Token(Token = "0x40001DE")]
	private static bool initialized; //Field offset: 0x0
	[Token(Token = "0x40001DF")]
	private static string machineTrustedRootPath; //Field offset: 0x8
	[Token(Token = "0x40001E0")]
	private static string machineIntermediateCAPath; //Field offset: 0x10
	[Token(Token = "0x40001E1")]
	private static string machineUntrustedPath; //Field offset: 0x18
	[Token(Token = "0x40001E2")]
	private static string userTrustedRootPath; //Field offset: 0x20
	[Token(Token = "0x40001E3")]
	private static string userIntermediateCAPath; //Field offset: 0x28
	[Token(Token = "0x40001E4")]
	private static string userUntrustedPath; //Field offset: 0x30

	[Address(RVA = "0x2607250", Offset = "0x2606650", Length = "0x1F4")]
	[Token(Token = "0x60002F6")]
	private static void DoInitialize() { }

	[Address(RVA = "0x2607450", Offset = "0x2606850", Length = "0x11C")]
	[Token(Token = "0x60002F7")]
	public static string GetStorePath(MonoBtlsX509StoreType type) { }

	[Address(RVA = "0x2607590", Offset = "0x2606990", Length = "0x2D9")]
	[Token(Token = "0x60002F5")]
	private static void Initialize() { }

}

