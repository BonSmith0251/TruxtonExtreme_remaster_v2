namespace TMPro;

[Token(Token = "0x2000074")]
public static class TMP_MaterialManager
{
	[CompilerGenerated]
	[Token(Token = "0x2000077")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000338")]
		public Material stencilMaterial; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000424")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x2F19090", Offset = "0x2F18490", Length = "0x6B")]
		[Token(Token = "0x6000425")]
		internal bool <AddMaskingMaterial>b__0(MaskingMaterial item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000078")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000339")]
		public Material stencilMaterial; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000426")]
		public <>c__DisplayClass12_0() { }

		[Address(RVA = "0x2F19100", Offset = "0x2F18500", Length = "0x6B")]
		[Token(Token = "0x6000427")]
		internal bool <RemoveStencilMaterial>b__0(MaskingMaterial item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000079")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400033A")]
		public Material baseMaterial; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000428")]
		public <>c__DisplayClass13_0() { }

		[Address(RVA = "0x2F19170", Offset = "0x2F18570", Length = "0x6B")]
		[Token(Token = "0x6000429")]
		internal bool <ReleaseBaseMaterial>b__0(MaskingMaterial item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200007A")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400033B")]
		public Material stencilMaterial; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600042A")]
		public <>c__DisplayClass9_0() { }

		[Address(RVA = "0x2F191E0", Offset = "0x2F185E0", Length = "0x6B")]
		[Token(Token = "0x600042B")]
		internal bool <GetBaseMaterial>b__0(MaskingMaterial item) { }

	}

	[Token(Token = "0x2000075")]
	private class FallbackMaterial
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400032F")]
		public long fallbackID; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000330")]
		public Material sourceMaterial; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000331")]
		internal int sourceMaterialCRC; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000332")]
		public Material fallbackMaterial; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000333")]
		public int count; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000422")]
		public FallbackMaterial() { }

	}

	[Token(Token = "0x2000076")]
	private class MaskingMaterial
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000334")]
		public Material baseMaterial; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000335")]
		public Material stencilMaterial; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000336")]
		public int count; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000337")]
		public int stencilID; //Field offset: 0x24

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000423")]
		public MaskingMaterial() { }

	}

	[Token(Token = "0x400032A")]
	private static List<MaskingMaterial> m_materialList; //Field offset: 0x0
	[Token(Token = "0x400032B")]
	private static Dictionary<Int64, FallbackMaterial> m_fallbackMaterials; //Field offset: 0x8
	[Token(Token = "0x400032C")]
	private static Dictionary<Int32, Int64> m_fallbackMaterialLookup; //Field offset: 0x10
	[Token(Token = "0x400032D")]
	private static List<FallbackMaterial> m_fallbackCleanupList; //Field offset: 0x18
	[Token(Token = "0x400032E")]
	private static bool isFallbackListDirty; //Field offset: 0x20

	[Address(RVA = "0x2F0A700", Offset = "0x2F09B00", Length = "0x1F3")]
	[Token(Token = "0x600040E")]
	private static TMP_MaterialManager() { }

	[Address(RVA = "0x2F078A0", Offset = "0x2F06CA0", Length = "0x137")]
	[Token(Token = "0x600041D")]
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	[Address(RVA = "0x2F079E0", Offset = "0x2F06DE0", Length = "0x272")]
	[Token(Token = "0x6000414")]
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	[Address(RVA = "0x2F07C60", Offset = "0x2F07060", Length = "0x250")]
	[Token(Token = "0x600041F")]
	public static void CleanupFallbackMaterials() { }

	[Address(RVA = "0x2F07EC0", Offset = "0x2F072C0", Length = "0x1E0")]
	[Token(Token = "0x6000417")]
	public static void ClearMaterials() { }

	[Address(RVA = "0x2F080B0", Offset = "0x2F074B0", Length = "0x2EB")]
	[Token(Token = "0x6000421")]
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }

	[Address(RVA = "0x2F083A0", Offset = "0x2F077A0", Length = "0x17B")]
	[Token(Token = "0x600041A")]
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	[Address(RVA = "0x2F08520", Offset = "0x2F07920", Length = "0x177")]
	[Token(Token = "0x6000412")]
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	[Address(RVA = "0x2F08BA0", Offset = "0x2F07FA0", Length = "0x343")]
	[Token(Token = "0x600041B")]
	internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	[Address(RVA = "0x2F086A0", Offset = "0x2F07AA0", Length = "0x4F0")]
	[Token(Token = "0x600041C")]
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	[Address(RVA = "0x2F08EF0", Offset = "0x2F082F0", Length = "0x20B")]
	[Token(Token = "0x6000419")]
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	[Address(RVA = "0x2F09100", Offset = "0x2F08500", Length = "0x3FD")]
	[Token(Token = "0x6000418")]
	public static int GetStencilID(GameObject obj) { }

	[Address(RVA = "0x2F09500", Offset = "0x2F08900", Length = "0x3E2")]
	[Token(Token = "0x6000410")]
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	[Address(RVA = "0x2F098F0", Offset = "0x2F08CF0", Length = "0x75")]
	[Token(Token = "0x600040F")]
	private static void OnPreRender() { }

	[Address(RVA = "0x2F09970", Offset = "0x2F08D70", Length = "0x543")]
	[Token(Token = "0x6000416")]
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	[Address(RVA = "0x2F09EC0", Offset = "0x2F092C0", Length = "0x1D1")]
	[Token(Token = "0x6000420")]
	public static void ReleaseFallbackMaterial(Material fallbackMaterial) { }

	[Address(RVA = "0x2F0A0A0", Offset = "0x2F094A0", Length = "0x251")]
	[Token(Token = "0x6000411")]
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	[Address(RVA = "0x2F0A300", Offset = "0x2F09700", Length = "0x1A3")]
	[Token(Token = "0x600041E")]
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	[Address(RVA = "0x2F0A4B0", Offset = "0x2F098B0", Length = "0x155")]
	[Token(Token = "0x6000415")]
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	[Address(RVA = "0x2F0A610", Offset = "0x2F09A10", Length = "0xEA")]
	[Token(Token = "0x6000413")]
	public static Material SetStencil(Material material, int stencilID) { }

}

