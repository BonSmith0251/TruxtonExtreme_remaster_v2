namespace UnityEngine.Rendering.Universal;

[Extension]
[Token(Token = "0x2000097")]
public static class URP2D_GraphicsExtensions
{

	[Address(RVA = "0x2D56E20", Offset = "0x2D56220", Length = "0x19")]
	[Extension]
	[Token(Token = "0x6000377")]
	public static SpriteMaskInteraction GetSpriteMaskInteraction(MeshRenderer meshRenderer) { }

	[Address(RVA = "0x2D56E20", Offset = "0x2D56220", Length = "0x19")]
	[Extension]
	[Token(Token = "0x6000378")]
	public static SpriteMaskInteraction GetSpriteMaskInteraction(SkinnedMeshRenderer skinnedMeshRenderer) { }

	[Address(RVA = "0x2D56E40", Offset = "0x2D56240", Length = "0x1A")]
	[Extension]
	[Token(Token = "0x6000379")]
	public static void SetSpriteMaskInteraction(MeshRenderer meshRenderer, SpriteMaskInteraction maskInteraction) { }

	[Address(RVA = "0x2D56E40", Offset = "0x2D56240", Length = "0x1A")]
	[Extension]
	[Token(Token = "0x600037A")]
	public static void SetSpriteMaskInteraction(SkinnedMeshRenderer skinnedMeshRenderer, SpriteMaskInteraction maskInteraction) { }

}

