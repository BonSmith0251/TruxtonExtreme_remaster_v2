namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000141")]
internal static class X509Helper2
{

	[Address(RVA = "0x2658FB0", Offset = "0x26583B0", Length = "0x55")]
	[Token(Token = "0x60007F1")]
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	[Address(RVA = "0x2659010", Offset = "0x2658410", Length = "0x6E")]
	[Token(Token = "0x60007F4")]
	internal static Exception GetInvalidChainContextException() { }

	[Address(RVA = "0x2659080", Offset = "0x2658480", Length = "0x11F")]
	[MonoTODO("Investigate replacement; see comments in source.")]
	[Token(Token = "0x60007F0")]
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	[Address(RVA = "0x1EF6BE0", Offset = "0x1EF5FE0", Length = "0x1C")]
	[Token(Token = "0x60007F2")]
	public static bool IsValid(X509ChainImpl impl) { }

	[Address(RVA = "0x26591A0", Offset = "0x26585A0", Length = "0x50")]
	[Token(Token = "0x60007F3")]
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

}

