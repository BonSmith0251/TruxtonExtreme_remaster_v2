namespace UnityEngine.AddressableAssets;

[Token(Token = "0x2000035")]
public class AssetReferenceAtlasedSprite : AssetReferenceT<Sprite>
{

	[Address(RVA = "0x27A4C00", Offset = "0x27A4000", Length = "0x48")]
	[Token(Token = "0x6000168")]
	public AssetReferenceAtlasedSprite(string guid) { }

	[Address(RVA = "0x27A4B80", Offset = "0x27A3F80", Length = "0x71")]
	[Token(Token = "0x6000169")]
	public virtual bool ValidateAsset(object obj) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600016A")]
	public virtual bool ValidateAsset(string path) { }

}

