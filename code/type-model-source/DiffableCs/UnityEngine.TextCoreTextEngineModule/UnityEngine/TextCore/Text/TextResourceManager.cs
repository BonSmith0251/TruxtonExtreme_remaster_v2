namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200006D")]
internal class TextResourceManager
{
	[Token(Token = "0x200006E")]
	private struct FontAssetRef
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047A")]
		public int nameHashCode; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400047B")]
		public int familyNameHashCode; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400047C")]
		public int styleNameHashCode; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400047D")]
		public long familyNameAndStyleHashCode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400047E")]
		public readonly FontAsset fontAsset; //Field offset: 0x18

		[Address(RVA = "0x2F03E70", Offset = "0x2F03270", Length = "0x35")]
		[Token(Token = "0x600033E")]
		public FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset) { }

	}

	[Token(Token = "0x4000475")]
	private static readonly Dictionary<Int32, FontAssetRef> s_FontAssetReferences; //Field offset: 0x0
	[Token(Token = "0x4000476")]
	private static readonly Dictionary<Int32, FontAsset> s_FontAssetNameReferenceLookup; //Field offset: 0x8
	[Token(Token = "0x4000477")]
	private static readonly Dictionary<Int64, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; //Field offset: 0x10
	[Token(Token = "0x4000478")]
	private static readonly List<Int32> s_FontAssetRemovalList; //Field offset: 0x18
	[Token(Token = "0x4000479")]
	private static readonly int k_RegularStyleHashCode; //Field offset: 0x20

	[Address(RVA = "0x31C7EB0", Offset = "0x31C72B0", Length = "0x26C")]
	[Token(Token = "0x600033D")]
	private static TextResourceManager() { }

	[Address(RVA = "0x31C7840", Offset = "0x31C6C40", Length = "0x667")]
	[Token(Token = "0x600033C")]
	internal static void AddFontAsset(FontAsset fontAsset) { }

}

