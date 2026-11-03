namespace TMPro;

[Token(Token = "0x2000012")]
public class MaterialReferenceManager
{
	[Token(Token = "0x4000023")]
	private static MaterialReferenceManager s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000024")]
	private Dictionary<Int32, Material> m_FontMaterialReferenceLookup; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000025")]
	private Dictionary<Int32, TMP_FontAsset> m_FontAssetReferenceLookup; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000026")]
	private Dictionary<Int32, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000027")]
	private Dictionary<Int32, TMP_ColorGradient> m_ColorGradientReferenceLookup; //Field offset: 0x28

	[Token(Token = "0x17000011")]
	public static MaterialReferenceManager instance
	{
		[Address(RVA = "0x2E994A0", Offset = "0x2E988A0", Length = "0x1C3")]
		[Token(Token = "0x6000037")]
		 get { } //Length: 451
	}

	[Address(RVA = "0x2E99350", Offset = "0x2E98750", Length = "0x149")]
	[Token(Token = "0x600004C")]
	public MaterialReferenceManager() { }

	[Address(RVA = "0x2E98760", Offset = "0x2E97B60", Length = "0x95")]
	[Token(Token = "0x6000040")]
	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	[Address(RVA = "0x2E986D0", Offset = "0x2E97AD0", Length = "0x89")]
	[Token(Token = "0x6000041")]
	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	[Address(RVA = "0x2E988F0", Offset = "0x2E97CF0", Length = "0xF1")]
	[Token(Token = "0x6000038")]
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2E98800", Offset = "0x2E97C00", Length = "0xE1")]
	[Token(Token = "0x6000039")]
	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2E98A60", Offset = "0x2E97E60", Length = "0x6D")]
	[Token(Token = "0x600003E")]
	public static void AddFontMaterial(int hashCode, Material material) { }

	[Address(RVA = "0x2E989F0", Offset = "0x2E97DF0", Length = "0x61")]
	[Token(Token = "0x600003F")]
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	[Address(RVA = "0x2E98C90", Offset = "0x2E98090", Length = "0xF1")]
	[Token(Token = "0x600003A")]
	public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset) { }

	[Address(RVA = "0x2E98D90", Offset = "0x2E98190", Length = "0xD9")]
	[Token(Token = "0x600003C")]
	public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset) { }

	[Address(RVA = "0x2E98AD0", Offset = "0x2E97ED0", Length = "0xE1")]
	[Token(Token = "0x600003B")]
	private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset) { }

	[Address(RVA = "0x2E98BC0", Offset = "0x2E97FC0", Length = "0xC9")]
	[Token(Token = "0x600003D")]
	private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset) { }

	[Address(RVA = "0x2E98EE0", Offset = "0x2E982E0", Length = "0x64")]
	[Token(Token = "0x6000043")]
	public bool Contains(TMP_SpriteAsset sprite) { }

	[Address(RVA = "0x2E98E70", Offset = "0x2E98270", Length = "0x64")]
	[Token(Token = "0x6000042")]
	public bool Contains(TMP_FontAsset font) { }

	[Address(RVA = "0x2E994A0", Offset = "0x2E988A0", Length = "0x1C3")]
	[Token(Token = "0x6000037")]
	public static MaterialReferenceManager get_instance() { }

	[Address(RVA = "0x2E98FD0", Offset = "0x2E983D0", Length = "0x7E")]
	[Token(Token = "0x6000048")]
	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	[Address(RVA = "0x2E98F50", Offset = "0x2E98350", Length = "0x72")]
	[Token(Token = "0x6000049")]
	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	[Address(RVA = "0x2E990D0", Offset = "0x2E984D0", Length = "0x7E")]
	[Token(Token = "0x6000044")]
	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2E99050", Offset = "0x2E98450", Length = "0x72")]
	[Token(Token = "0x6000045")]
	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2E991D0", Offset = "0x2E985D0", Length = "0x7E")]
	[Token(Token = "0x600004A")]
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	[Address(RVA = "0x2E99150", Offset = "0x2E98550", Length = "0x72")]
	[Token(Token = "0x600004B")]
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	[Address(RVA = "0x2E992D0", Offset = "0x2E986D0", Length = "0x7E")]
	[Token(Token = "0x6000046")]
	public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	[Address(RVA = "0x2E99250", Offset = "0x2E98650", Length = "0x72")]
	[Token(Token = "0x6000047")]
	private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset) { }

}

