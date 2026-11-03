namespace Mono.Unity;

[Token(Token = "0x2000009")]
internal static class Debug
{

	[Address(RVA = "0x22BCAA0", Offset = "0x22BBEA0", Length = "0xAF")]
	[Token(Token = "0x6000025")]
	public static void CheckAndThrow(unitytls_errorstate errorState, string context, AlertDescription defaultAlert = 80) { }

	[Address(RVA = "0x22BC910", Offset = "0x22BBD10", Length = "0x182")]
	[Token(Token = "0x6000026")]
	public static void CheckAndThrow(unitytls_errorstate errorState, unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = 80) { }

}

