namespace UnityEngine.AddressableAssets;

[Token(Token = "0x2000034")]
public class AssetReferenceSprite : AssetReferenceT<Sprite>
{

	[Address(RVA = "0x27A4CA0", Offset = "0x27A40A0", Length = "0x48")]
	[Token(Token = "0x6000166")]
	public AssetReferenceSprite(string guid) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000167")]
	public virtual bool ValidateAsset(string path) { }

}

