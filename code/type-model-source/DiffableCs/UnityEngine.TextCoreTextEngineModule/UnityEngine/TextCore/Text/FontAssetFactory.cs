namespace UnityEngine.TextCore.Text;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000034")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.CoreModule", "UnityEngine.UIElementsModule"})]
internal class FontAssetFactory
{
	[Token(Token = "0x4000178")]
	private static readonly HashSet<FontAsset> visitedFontAssets; //Field offset: 0x0

	[Address(RVA = "0x31AE9D0", Offset = "0x31ADDD0", Length = "0x84")]
	[Token(Token = "0x6000147")]
	private static FontAssetFactory() { }

	[Address(RVA = "0x31AE5A0", Offset = "0x31AD9A0", Length = "0x234")]
	[Token(Token = "0x6000144")]
	internal static FontAsset ConvertFontToFontAsset(Font font) { }

	[Address(RVA = "0x31AE7E0", Offset = "0x31ADBE0", Length = "0xB1")]
	[Token(Token = "0x6000146")]
	public static void SetHideFlags(FontAsset fontAsset) { }

	[Address(RVA = "0x31AE8A0", Offset = "0x31ADCA0", Length = "0x124")]
	[Token(Token = "0x6000145")]
	internal static void SetupFontAssetSettings(FontAsset fontAsset) { }

}

