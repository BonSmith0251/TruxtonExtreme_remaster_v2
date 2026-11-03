namespace UnityEngine;

[Token(Token = "0x2000029")]
internal class RuntimeTextSettings : TextSettings
{
	[Token(Token = "0x40000FF")]
	private static RuntimeTextSettings s_DefaultTextSettings; //Field offset: 0x0
	[Token(Token = "0x4000100")]
	private static List<FontAsset> s_FallbackOSFontAssetIMGUIInternal; //Field offset: 0x8

	[Token(Token = "0x1700007B")]
	internal static RuntimeTextSettings defaultTextSettings
	{
		[Address(RVA = "0x30F7060", Offset = "0x30F6460", Length = "0xBB")]
		[Token(Token = "0x60001F7")]
		internal get { } //Length: 187
	}

	[Address(RVA = "0x30F7050", Offset = "0x30F6450", Length = "0x7")]
	[Token(Token = "0x60001FA")]
	public RuntimeTextSettings() { }

	[Address(RVA = "0x30F7060", Offset = "0x30F6460", Length = "0xBB")]
	[Token(Token = "0x60001F7")]
	internal static RuntimeTextSettings get_defaultTextSettings() { }

	[Address(RVA = "0x30F6FB0", Offset = "0x30F63B0", Length = "0x37")]
	[Token(Token = "0x60001F8")]
	internal virtual List<FontAsset> GetStaticFallbackOSFontAsset() { }

	[Address(RVA = "0x30F6FF0", Offset = "0x30F63F0", Length = "0x56")]
	[Token(Token = "0x60001F9")]
	internal virtual void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

}

