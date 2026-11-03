namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000046")]
public enum AssetLoadMode : int
{
	RequestedAssetAndDependencies = 0,
	AllPackedAssetsAndDependencies = 1,
}

