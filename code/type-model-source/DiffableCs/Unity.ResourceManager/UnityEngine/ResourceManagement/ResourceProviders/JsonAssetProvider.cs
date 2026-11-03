namespace UnityEngine.ResourceManagement.ResourceProviders;

[DisplayName("JSON Asset Provider")]
[Token(Token = "0x2000062")]
public class JsonAssetProvider : TextDataProvider
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600022B")]
	public JsonAssetProvider() { }

	[Address(RVA = "0x2E44BD0", Offset = "0x2E43FD0", Length = "0xB")]
	[Token(Token = "0x600022A")]
	public virtual object Convert(Type type, string text) { }

}

