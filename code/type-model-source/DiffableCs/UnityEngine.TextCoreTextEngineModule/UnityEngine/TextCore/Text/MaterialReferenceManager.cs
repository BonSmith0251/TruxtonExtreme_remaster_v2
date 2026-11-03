namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000028")]
internal class MaterialReferenceManager
{
	[Token(Token = "0x40000F4")]
	private static MaterialReferenceManager s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000F5")]
	private Dictionary<Int32, Material> m_FontMaterialReferenceLookup; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000F6")]
	private Dictionary<Int32, FontAsset> m_FontAssetReferenceLookup; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F7")]
	private Dictionary<Int32, SpriteAsset> m_SpriteAssetReferenceLookup; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000F8")]
	private Dictionary<Int32, TextColorGradient> m_ColorGradientReferenceLookup; //Field offset: 0x28

	[Token(Token = "0x17000011")]
	public static MaterialReferenceManager instance
	{
		[Address(RVA = "0x3183460", Offset = "0x3182860", Length = "0x1C3")]
		[Token(Token = "0x6000074")]
		 get { } //Length: 451
	}

	[Address(RVA = "0x3183310", Offset = "0x3182710", Length = "0x149")]
	[Token(Token = "0x6000085")]
	public MaterialReferenceManager() { }

	[Address(RVA = "0x3182A10", Offset = "0x3181E10", Length = "0x95")]
	[Token(Token = "0x600007B")]
	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset) { }

	[Address(RVA = "0x3182980", Offset = "0x3181D80", Length = "0x89")]
	[Token(Token = "0x600007C")]
	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset) { }

	[Address(RVA = "0x3182B90", Offset = "0x3181F90", Length = "0xEE")]
	[Token(Token = "0x6000075")]
	public static void AddFontAsset(FontAsset fontAsset) { }

	[Address(RVA = "0x3182AB0", Offset = "0x3181EB0", Length = "0xDE")]
	[Token(Token = "0x6000076")]
	private void AddFontAssetInternal(FontAsset fontAsset) { }

	[Address(RVA = "0x3182CF0", Offset = "0x31820F0", Length = "0x6D")]
	[Token(Token = "0x6000079")]
	public static void AddFontMaterial(int hashCode, Material material) { }

	[Address(RVA = "0x3182C80", Offset = "0x3182080", Length = "0x61")]
	[Token(Token = "0x600007A")]
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	[Address(RVA = "0x3182E30", Offset = "0x3182230", Length = "0xD6")]
	[Token(Token = "0x6000077")]
	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	[Address(RVA = "0x3182D60", Offset = "0x3182160", Length = "0xC6")]
	[Token(Token = "0x6000078")]
	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	[Address(RVA = "0x3183460", Offset = "0x3182860", Length = "0x1C3")]
	[Token(Token = "0x6000074")]
	public static MaterialReferenceManager get_instance() { }

	[Address(RVA = "0x3182F90", Offset = "0x3182390", Length = "0x7E")]
	[Token(Token = "0x6000081")]
	public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset) { }

	[Address(RVA = "0x3182F10", Offset = "0x3182310", Length = "0x72")]
	[Token(Token = "0x6000082")]
	private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset) { }

	[Address(RVA = "0x3183090", Offset = "0x3182490", Length = "0x7E")]
	[Token(Token = "0x600007D")]
	public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset) { }

	[Address(RVA = "0x3183010", Offset = "0x3182410", Length = "0x72")]
	[Token(Token = "0x600007E")]
	private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset) { }

	[Address(RVA = "0x3183190", Offset = "0x3182590", Length = "0x7E")]
	[Token(Token = "0x6000083")]
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	[Address(RVA = "0x3183110", Offset = "0x3182510", Length = "0x72")]
	[Token(Token = "0x6000084")]
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	[Address(RVA = "0x3183290", Offset = "0x3182690", Length = "0x7E")]
	[Token(Token = "0x600007F")]
	public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset) { }

	[Address(RVA = "0x3183210", Offset = "0x3182610", Length = "0x72")]
	[Token(Token = "0x6000080")]
	private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset) { }

}

