namespace TXEKernel;

[Token(Token = "0x20000C1")]
public sealed class TXEAesAssetBundleProvider : TXEAssetBundleProviderBase
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000610")]
	public TXEAesAssetBundleProvider() { }

	[Address(RVA = "0x270F8C0", Offset = "0x270ECC0", Length = "0x427")]
	[Token(Token = "0x600060F")]
	private static Byte[] AesDecryptWithDerivedIv(Byte[] input, Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x270FCF0", Offset = "0x270F0F0", Length = "0xA9")]
	[Token(Token = "0x600060E")]
	protected virtual Byte[] TransformBytes(Byte[] src, string internalId, string localPath) { }

}

