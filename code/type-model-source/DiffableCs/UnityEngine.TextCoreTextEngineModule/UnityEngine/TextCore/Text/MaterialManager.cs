namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000026")]
internal static class MaterialManager
{
	[Token(Token = "0x40000EB")]
	private static Dictionary<Int64, Material> s_FallbackMaterials; //Field offset: 0x0

	[Address(RVA = "0x31828F0", Offset = "0x3181CF0", Length = "0x84")]
	[Token(Token = "0x6000070")]
	private static MaterialManager() { }

	[Address(RVA = "0x3181BD0", Offset = "0x3180FD0", Length = "0x2EB")]
	[Token(Token = "0x600006F")]
	private static void CopyMaterialPresetProperties(Material source, Material destination) { }

	[Address(RVA = "0x3181EC0", Offset = "0x31812C0", Length = "0x4C8")]
	[Token(Token = "0x600006D")]
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	[Address(RVA = "0x3182390", Offset = "0x3181790", Length = "0x551")]
	[Token(Token = "0x600006E")]
	public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

}

