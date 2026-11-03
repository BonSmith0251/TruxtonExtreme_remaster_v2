namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005EE")]
internal class UIRVEShaderInfoAllocator
{
	[Token(Token = "0x40015AC")]
	private static readonly Vector2Int identityTransformTexel; //Field offset: 0x0
	[Token(Token = "0x40015AD")]
	private static readonly Vector2Int infiniteClipRectTexel; //Field offset: 0x8
	[Token(Token = "0x40015AE")]
	private static readonly Vector2Int fullOpacityTexel; //Field offset: 0x10
	[Token(Token = "0x40015AF")]
	private static readonly Vector2Int clearColorTexel; //Field offset: 0x18
	[Token(Token = "0x40015B0")]
	private static readonly Vector2Int defaultTextCoreSettingsTexel; //Field offset: 0x20
	[Token(Token = "0x40015B1")]
	private static readonly Matrix4x4 identityTransformValue; //Field offset: 0x28
	[Token(Token = "0x40015B2")]
	private static readonly Vector4 identityTransformRow0Value; //Field offset: 0x68
	[Token(Token = "0x40015B3")]
	private static readonly Vector4 identityTransformRow1Value; //Field offset: 0x78
	[Token(Token = "0x40015B4")]
	private static readonly Vector4 identityTransformRow2Value; //Field offset: 0x88
	[Token(Token = "0x40015B5")]
	private static readonly Vector4 infiniteClipRectValue; //Field offset: 0x98
	[Token(Token = "0x40015B6")]
	private static readonly Vector4 fullOpacityValue; //Field offset: 0xA8
	[Token(Token = "0x40015B7")]
	private static readonly Vector4 clearColorValue; //Field offset: 0xB8
	[Token(Token = "0x40015B8")]
	private static readonly TextCoreSettings defaultTextCoreSettingsValue; //Field offset: 0xC8
	[Token(Token = "0x40015B9")]
	public static readonly BMPAlloc identityTransform; //Field offset: 0x108
	[Token(Token = "0x40015BA")]
	public static readonly BMPAlloc infiniteClipRect; //Field offset: 0x110
	[Token(Token = "0x40015BB")]
	public static readonly BMPAlloc fullOpacity; //Field offset: 0x118
	[Token(Token = "0x40015BC")]
	public static readonly BMPAlloc clearColor; //Field offset: 0x120
	[Token(Token = "0x40015BD")]
	public static readonly BMPAlloc defaultTextCoreSettings; //Field offset: 0x128
	[Token(Token = "0x40015BE")]
	private static int s_DefaultShaderInfoTextureRefCount; //Field offset: 0x130
	[Token(Token = "0x40015BF")]
	private static Texture2D s_DefaultShaderInfoTexture; //Field offset: 0x138
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40015A4")]
	private BaseShaderInfoStorage m_Storage; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40015A5")]
	private BitmapAllocator32 m_TransformAllocator; //Field offset: 0x18
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40015A6")]
	private BitmapAllocator32 m_ClipRectAllocator; //Field offset: 0x38
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40015A7")]
	private BitmapAllocator32 m_OpacityAllocator; //Field offset: 0x58
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40015A8")]
	private BitmapAllocator32 m_ColorAllocator; //Field offset: 0x78
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40015A9")]
	private BitmapAllocator32 m_TextSettingsAllocator; //Field offset: 0x98
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40015AA")]
	private bool m_StorageReallyCreated; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40015AB")]
	private ColorSpace m_ColorSpace; //Field offset: 0xBC

	[Token(Token = "0x17000A95")]
	public Texture atlas
	{
		[Address(RVA = "0x332D230", Offset = "0x332C630", Length = "0x88")]
		[Token(Token = "0x6002A80")]
		 get { } //Length: 136
	}

	[Token(Token = "0x17000A94")]
	private static int pageHeight
	{
		[Address(RVA = "0x332D2C0", Offset = "0x332C6C0", Length = "0x8")]
		[Token(Token = "0x6002A7B")]
		private get { } //Length: 8
	}

	[Token(Token = "0x17000A93")]
	private static int pageWidth
	{
		[Address(RVA = "0x3131B90", Offset = "0x3130F90", Length = "0x8")]
		[Token(Token = "0x6002A7A")]
		private get { } //Length: 8
	}

	[Address(RVA = "0x332CCE0", Offset = "0x332C0E0", Length = "0x314")]
	[Token(Token = "0x6002A99")]
	private static UIRVEShaderInfoAllocator() { }

	[Address(RVA = "0x332D000", Offset = "0x332C400", Length = "0x22B")]
	[Token(Token = "0x6002A81")]
	public UIRVEShaderInfoAllocator(ColorSpace colorSpace) { }

	[Address(RVA = "0x332A4F0", Offset = "0x33298F0", Length = "0x4E2")]
	[Token(Token = "0x6002A7C")]
	private static void AcquireDefaultShaderInfoTexture() { }

	[Address(RVA = "0x332A9E0", Offset = "0x3329DE0", Length = "0x2E")]
	[Token(Token = "0x6002A86")]
	public BMPAlloc AllocClipRect() { }

	[Address(RVA = "0x332AA10", Offset = "0x3329E10", Length = "0x2E")]
	[Token(Token = "0x6002A88")]
	public BMPAlloc AllocColor() { }

	[Address(RVA = "0x332AA40", Offset = "0x3329E40", Length = "0x2E")]
	[Token(Token = "0x6002A87")]
	public BMPAlloc AllocOpacity() { }

	[Address(RVA = "0x332AA70", Offset = "0x3329E70", Length = "0x31")]
	[Token(Token = "0x6002A89")]
	public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) { }

	[Address(RVA = "0x332AAB0", Offset = "0x3329EB0", Length = "0x89")]
	[Token(Token = "0x6002A7E")]
	private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc) { }

	[Address(RVA = "0x332AB40", Offset = "0x3329F40", Length = "0x2E")]
	[Token(Token = "0x6002A85")]
	public BMPAlloc AllocTransform() { }

	[Address(RVA = "0x332AB70", Offset = "0x3329F70", Length = "0x175")]
	[Token(Token = "0x6002A7F")]
	private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) { }

	[Address(RVA = "0x332ACF0", Offset = "0x332A0F0", Length = "0x111")]
	[Token(Token = "0x6002A95")]
	public Color32 ClipRectAllocToVertexData(BMPAlloc alloc) { }

	[Address(RVA = "0x332AE10", Offset = "0x332A210", Length = "0x114")]
	[Token(Token = "0x6002A97")]
	public Color32 ColorAllocToVertexData(BMPAlloc alloc) { }

	[Address(RVA = "0x332AF30", Offset = "0x332A330", Length = "0x1A1")]
	[Token(Token = "0x6002A83")]
	public void Dispose() { }

	[Address(RVA = "0x332B0E0", Offset = "0x332A4E0", Length = "0x96")]
	[Token(Token = "0x6002A90")]
	public void FreeClipRect(BMPAlloc alloc) { }

	[Address(RVA = "0x332B180", Offset = "0x332A580", Length = "0x96")]
	[Token(Token = "0x6002A92")]
	public void FreeColor(BMPAlloc alloc) { }

	[Address(RVA = "0x332B220", Offset = "0x332A620", Length = "0x96")]
	[Token(Token = "0x6002A91")]
	public void FreeOpacity(BMPAlloc alloc) { }

	[Address(RVA = "0x332B2C0", Offset = "0x332A6C0", Length = "0x99")]
	[Token(Token = "0x6002A93")]
	public void FreeTextCoreSettings(BMPAlloc alloc) { }

	[Address(RVA = "0x332B360", Offset = "0x332A760", Length = "0x96")]
	[Token(Token = "0x6002A8F")]
	public void FreeTransform(BMPAlloc alloc) { }

	[Address(RVA = "0x332D230", Offset = "0x332C630", Length = "0x88")]
	[Token(Token = "0x6002A80")]
	public Texture get_atlas() { }

	[Address(RVA = "0x332D2C0", Offset = "0x332C6C0", Length = "0x8")]
	[Token(Token = "0x6002A7B")]
	private static int get_pageHeight() { }

	[Address(RVA = "0x3131B90", Offset = "0x3130F90", Length = "0x8")]
	[Token(Token = "0x6002A7A")]
	private static int get_pageWidth() { }

	[Address(RVA = "0x332B400", Offset = "0x332A800", Length = "0x1E")]
	[Token(Token = "0x6002A84")]
	public void IssuePendingStorageChanges() { }

	[Address(RVA = "0x332B420", Offset = "0x332A820", Length = "0x111")]
	[Token(Token = "0x6002A96")]
	public Color32 OpacityAllocToVertexData(BMPAlloc alloc) { }

	[Address(RVA = "0x332B540", Offset = "0x332A940", Length = "0x9DF")]
	[Token(Token = "0x6002A82")]
	private void ReallyCreateStorage() { }

	[Address(RVA = "0x332BF20", Offset = "0x332B320", Length = "0x100")]
	[Token(Token = "0x6002A7D")]
	private static void ReleaseDefaultShaderInfoTexture() { }

	[Address(RVA = "0x332C020", Offset = "0x332B420", Length = "0x13A")]
	[Token(Token = "0x6002A8B")]
	public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) { }

	[Address(RVA = "0x332C160", Offset = "0x332B560", Length = "0x1B1")]
	[Token(Token = "0x6002A8D")]
	public void SetColorValue(BMPAlloc alloc, Color color) { }

	[Address(RVA = "0x332C320", Offset = "0x332B720", Length = "0x12E")]
	[Token(Token = "0x6002A8C")]
	public void SetOpacityValue(BMPAlloc alloc, float opacity) { }

	[Address(RVA = "0x332C450", Offset = "0x332B850", Length = "0x420")]
	[Token(Token = "0x6002A8E")]
	public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings) { }

	[Address(RVA = "0x332C880", Offset = "0x332BC80", Length = "0x218")]
	[Token(Token = "0x6002A8A")]
	public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) { }

	[Address(RVA = "0x332CAA0", Offset = "0x332BEA0", Length = "0x114")]
	[Token(Token = "0x6002A98")]
	public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) { }

	[Address(RVA = "0x332CBC0", Offset = "0x332BFC0", Length = "0x111")]
	[Token(Token = "0x6002A94")]
	public Color32 TransformAllocToVertexData(BMPAlloc alloc) { }

}

