namespace TXEKernel;

[Token(Token = "0x20000EB")]
public sealed class TXEPlainAssetBundleProvider : TXEAssetBundleProviderBase
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60006EA")]
	public TXEPlainAssetBundleProvider() { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[Token(Token = "0x60006E9")]
	protected virtual Byte[] TransformBytes(Byte[] src, string internalId, string localPath) { }

}

