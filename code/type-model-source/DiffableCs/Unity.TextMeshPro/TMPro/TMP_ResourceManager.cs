namespace TMPro;

[Token(Token = "0x200007E")]
public class TMP_ResourceManager
{
	[Token(Token = "0x200007F")]
	private struct FontAssetRef
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000357")]
		public int nameHashCode; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000358")]
		public int familyNameHashCode; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000359")]
		public int styleNameHashCode; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400035A")]
		public long familyNameAndStyleHashCode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400035B")]
		public readonly TMP_FontAsset fontAsset; //Field offset: 0x18

		[Address(RVA = "0x2F03E70", Offset = "0x2F03270", Length = "0x35")]
		[Token(Token = "0x6000449")]
		public FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, TMP_FontAsset fontAsset) { }

	}

	[Token(Token = "0x4000351")]
	private static TMP_Settings s_TextSettings; //Field offset: 0x0
	[Token(Token = "0x4000352")]
	private static readonly Dictionary<Int32, FontAssetRef> s_FontAssetReferences; //Field offset: 0x8
	[Token(Token = "0x4000353")]
	private static readonly Dictionary<Int32, TMP_FontAsset> s_FontAssetNameReferenceLookup; //Field offset: 0x10
	[Token(Token = "0x4000354")]
	private static readonly Dictionary<Int64, TMP_FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; //Field offset: 0x18
	[Token(Token = "0x4000355")]
	private static readonly List<Int32> s_FontAssetRemovalList; //Field offset: 0x20
	[Token(Token = "0x4000356")]
	private static readonly int k_RegularStyleHashCode; //Field offset: 0x28

	[Address(RVA = "0x2F0E740", Offset = "0x2F0DB40", Length = "0x205")]
	[Token(Token = "0x6000448")]
	private static TMP_ResourceManager() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000447")]
	public TMP_ResourceManager() { }

	[Address(RVA = "0x2F0D890", Offset = "0x2F0CC90", Length = "0x66B")]
	[Token(Token = "0x6000441")]
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2F0DF00", Offset = "0x2F0D300", Length = "0x40")]
	[Token(Token = "0x6000445")]
	public static void ClearFontAssetGlyphCache() { }

	[Address(RVA = "0x2F0DF40", Offset = "0x2F0D340", Length = "0x116")]
	[Token(Token = "0x6000440")]
	internal static TMP_Settings GetTextSettings() { }

	[Address(RVA = "0x2F0E060", Offset = "0x2F0D460", Length = "0x40F")]
	[Token(Token = "0x6000446")]
	internal static void RebuildFontAssetCache() { }

	[Address(RVA = "0x2F0E470", Offset = "0x2F0D870", Length = "0x159")]
	[Token(Token = "0x6000442")]
	public static void RemoveFontAsset(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2F0E5D0", Offset = "0x2F0D9D0", Length = "0xCD")]
	[Token(Token = "0x6000444")]
	internal static bool TryGetFontAssetByFamilyName(int familyNameHashCode, int styleNameHashCode, out TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x2F0E6A0", Offset = "0x2F0DAA0", Length = "0x97")]
	[Token(Token = "0x6000443")]
	internal static bool TryGetFontAssetByName(int nameHashcode, out TMP_FontAsset fontAsset) { }

}

