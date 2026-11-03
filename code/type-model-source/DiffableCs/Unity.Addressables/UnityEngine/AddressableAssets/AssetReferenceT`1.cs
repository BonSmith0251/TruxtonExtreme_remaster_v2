namespace UnityEngine.AddressableAssets;

[Token(Token = "0x200002F")]
public class AssetReferenceT : AssetReference
{

	[Address(RVA = "0x1008520", Offset = "0x1007920", Length = "0x8")]
	[Token(Token = "0x600015E")]
	public AssetReferenceT`1(string guid) { }

	[Address(RVA = "0x1008430", Offset = "0x1007830", Length = "0x6F")]
	[Token(Token = "0x600015F")]
	public override AsyncOperationHandle<TObject> LoadAssetAsync() { }

	[Address(RVA = "0x10084A0", Offset = "0x10078A0", Length = "0x7E")]
	[Token(Token = "0x6000160")]
	public virtual bool ValidateAsset(object obj) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000161")]
	public virtual bool ValidateAsset(string mainAssetPath) { }

}

