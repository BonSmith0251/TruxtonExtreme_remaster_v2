namespace UnityEngine.ResourceManagement.ResourceProviders;

[DisplayName("Sprites from Atlases Provider")]
[Token(Token = "0x200004F")]
public class AtlasSpriteProvider : ResourceProviderBase
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001D4")]
	public AtlasSpriteProvider() { }

	[Address(RVA = "0x2E3BB00", Offset = "0x2E3AF00", Length = "0x41B")]
	[Token(Token = "0x60001D2")]
	public virtual void Provide(ProvideHandle providerInterface) { }

	[Address(RVA = "0x2E3BF20", Offset = "0x2E3B320", Length = "0x7A")]
	[Token(Token = "0x60001D3")]
	public virtual void Release(IResourceLocation location, object obj) { }

}

