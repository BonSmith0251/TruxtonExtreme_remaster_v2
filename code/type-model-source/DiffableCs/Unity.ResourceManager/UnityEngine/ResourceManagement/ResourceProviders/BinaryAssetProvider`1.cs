namespace UnityEngine.ResourceManagement.ResourceProviders;

[DisplayName("Binary Asset Provider")]
[Token(Token = "0x2000050")]
internal class BinaryAssetProvider : BinaryDataProvider
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60001D6")]
	public BinaryAssetProvider`1() { }

	[Address(RVA = "0x16B7640", Offset = "0x16B6A40", Length = "0x13E")]
	[Token(Token = "0x60001D5")]
	public virtual object Convert(Type type, Byte[] data) { }

}

