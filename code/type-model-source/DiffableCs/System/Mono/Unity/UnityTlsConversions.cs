namespace Mono.Unity;

[Token(Token = "0x2000042")]
internal static class UnityTlsConversions
{

	[Address(RVA = "0x22D1430", Offset = "0x22D0830", Length = "0x23")]
	[Token(Token = "0x6000090")]
	public static TlsProtocols ConvertProtocolVersion(unitytls_protocol protocol) { }

	[Address(RVA = "0x22D1460", Offset = "0x22D0860", Length = "0x3C")]
	[Token(Token = "0x600008F")]
	public static unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	[Address(RVA = "0x22D14A0", Offset = "0x22D08A0", Length = "0x39")]
	[Token(Token = "0x600008E")]
	public static unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	[Address(RVA = "0x22D14E0", Offset = "0x22D08E0", Length = "0x5C")]
	[Token(Token = "0x6000091")]
	public static AlertDescription VerifyResultToAlertDescription(unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	[Address(RVA = "0x22D1540", Offset = "0x22D0940", Length = "0x3F")]
	[Token(Token = "0x6000093")]
	public static X509ChainStatusFlags VerifyResultToChainStatus(unitytls_x509verify_result verifyResult) { }

	[Address(RVA = "0x22D1580", Offset = "0x22D0980", Length = "0x25")]
	[Token(Token = "0x6000092")]
	public static SslPolicyErrors VerifyResultToPolicyErrror(unitytls_x509verify_result verifyResult) { }

}

