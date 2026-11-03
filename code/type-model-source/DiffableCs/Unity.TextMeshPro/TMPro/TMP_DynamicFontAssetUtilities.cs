namespace TMPro;

[Token(Token = "0x2000047")]
internal class TMP_DynamicFontAssetUtilities
{
	[Token(Token = "0x2000048")]
	internal struct FontReference
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D1")]
		public string familyName; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001D2")]
		public string styleName; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001D3")]
		public int faceIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001D4")]
		public string filePath; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D5")]
		public ulong hashCode; //Field offset: 0x20

		[Address(RVA = "0x2EAEAF0", Offset = "0x2EADEF0", Length = "0x2FE")]
		[Token(Token = "0x6000219")]
		public FontReference(string fontFilePath, string faceNameAndStyle, int index) { }

	}

	[Token(Token = "0x40001CD")]
	private static TMP_DynamicFontAssetUtilities s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CE")]
	private Dictionary<UInt64, FontReference> s_SystemFontLookup; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001CF")]
	private String[] s_SystemFontPaths; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D0")]
	private uint s_RegularStyleNameHashCode; //Field offset: 0x20

	[Address(RVA = "0x2EB73F0", Offset = "0x2EB67F0", Length = "0x6E")]
	[Token(Token = "0x6000218")]
	private static TMP_DynamicFontAssetUtilities() { }

	[Address(RVA = "0x2EB7460", Offset = "0x2EB6860", Length = "0xE")]
	[Token(Token = "0x6000217")]
	public TMP_DynamicFontAssetUtilities() { }

	[Address(RVA = "0x2EB6930", Offset = "0x2EB5D30", Length = "0x66D")]
	[Token(Token = "0x6000213")]
	private void InitializeSystemFontReferenceCache() { }

	[Address(RVA = "0x2EB7360", Offset = "0x2EB6760", Length = "0x81")]
	[Token(Token = "0x6000214")]
	public static bool TryGetSystemFontReference(string familyName, out FontReference fontRef) { }

	[Address(RVA = "0x2EB72D0", Offset = "0x2EB66D0", Length = "0x8E")]
	[Token(Token = "0x6000215")]
	public static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	[Address(RVA = "0x2EB6FA0", Offset = "0x2EB63A0", Length = "0x32A")]
	[Token(Token = "0x6000216")]
	private bool TryGetSystemFontReferenceInternal(string familyName, string styleName, out FontReference fontRef) { }

}

