namespace TXEKernel;

[Token(Token = "0x20000FA")]
public sealed class TXEXorAssetBundleProvider : TXEAssetBundleProviderBase
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000734")]
	public TXEXorAssetBundleProvider() { }

	[Address(RVA = "0x2718C50", Offset = "0x2718050", Length = "0xBD")]
	[Token(Token = "0x6000732")]
	protected virtual Byte[] TransformBytes(Byte[] src, string internalId, string localPath) { }

	[Address(RVA = "0x2718D10", Offset = "0x2718110", Length = "0x66")]
	[Token(Token = "0x6000733")]
	private static void XorInPlace(Byte[] data, Byte[] key) { }

}

