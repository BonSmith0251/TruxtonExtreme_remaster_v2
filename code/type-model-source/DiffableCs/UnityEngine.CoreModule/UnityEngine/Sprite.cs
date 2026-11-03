namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
[NativeType("Runtime/Graphics/SpriteFrame.h")]
[Token(Token = "0x200008D")]
public sealed class Sprite : object
{

	[Token(Token = "0x1700003D")]
	public Texture2D associatedAlphaSplitTexture
	{
		[Address(RVA = "0x2FEF000", Offset = "0x2FEE400", Length = "0x90")]
		[NativeMethod("GetAlphaTexture")]
		[Token(Token = "0x60001EE")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000038")]
	public Vector4 border
	{
		[Address(RVA = "0x2FEF0F0", Offset = "0x2FEE4F0", Length = "0x8E")]
		[Token(Token = "0x60001E6")]
		 get { } //Length: 142
	}

	[Token(Token = "0x17000036")]
	public Bounds bounds
	{
		[Address(RVA = "0x2FEF1D0", Offset = "0x2FEE5D0", Length = "0x94")]
		[Token(Token = "0x60001E4")]
		 get { } //Length: 148
	}

	[Token(Token = "0x1700003A")]
	internal uint extrude
	{
		[Address(RVA = "0x2FEF2B0", Offset = "0x2FEE6B0", Length = "0x76")]
		[Token(Token = "0x60001E8")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x1700003F")]
	public bool packed
	{
		[Address(RVA = "0x2FEF330", Offset = "0x2FEE730", Length = "0x7C")]
		[Token(Token = "0x60001F0")]
		 get { } //Length: 124
	}

	[Token(Token = "0x17000040")]
	public SpritePackingMode packingMode
	{
		[Address(RVA = "0x2FED160", Offset = "0x2FEC560", Length = "0x76")]
		[Token(Token = "0x60001F1")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000041")]
	public SpritePackingRotation packingRotation
	{
		[Address(RVA = "0x2FED220", Offset = "0x2FEC620", Length = "0x76")]
		[Token(Token = "0x60001F2")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700003E")]
	public Vector2 pivot
	{
		[Address(RVA = "0x2FEF400", Offset = "0x2FEE800", Length = "0x87")]
		[NativeMethod("GetPivotInPixels")]
		[Token(Token = "0x60001EF")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700003B")]
	public float pixelsPerUnit
	{
		[Address(RVA = "0x2FEF4D0", Offset = "0x2FEE8D0", Length = "0x76")]
		[NativeMethod("GetPixelsToUnits")]
		[Token(Token = "0x60001EC")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000037")]
	public Rect rect
	{
		[Address(RVA = "0x2FEF5A0", Offset = "0x2FEE9A0", Length = "0x8E")]
		[Token(Token = "0x60001E5")]
		 get { } //Length: 142
	}

	[Token(Token = "0x1700003C")]
	public float spriteAtlasTextureScale
	{
		[Address(RVA = "0x2FEF670", Offset = "0x2FEEA70", Length = "0x76")]
		[NativeMethod("GetSpriteAtlasTextureScale")]
		[Token(Token = "0x60001ED")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000039")]
	public Texture2D texture
	{
		[Address(RVA = "0x2FEF7E0", Offset = "0x2FEEBE0", Length = "0x90")]
		[Token(Token = "0x60001E7")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000042")]
	public Rect textureRect
	{
		[Address(RVA = "0x2FEF6F0", Offset = "0x2FEEAF0", Length = "0xA0")]
		[Token(Token = "0x60001F3")]
		 get { } //Length: 160
	}

	[Token(Token = "0x17000043")]
	public Vector2 textureRectOffset
	{
		[Address(RVA = "0x2FEE1C0", Offset = "0x2FED5C0", Length = "0x87")]
		[Token(Token = "0x60001F4")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000045")]
	public UInt16[] triangles
	{
		[Address(RVA = "0x2FEF8C0", Offset = "0x2FEECC0", Length = "0x76")]
		[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
		[Token(Token = "0x60001F6")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000046")]
	public Vector2[] uv
	{
		[Address(RVA = "0x2FEF980", Offset = "0x2FEED80", Length = "0x76")]
		[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
		[Token(Token = "0x60001F7")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000044")]
	public Vector2[] vertices
	{
		[Address(RVA = "0x2FEFA40", Offset = "0x2FEEE40", Length = "0x76")]
		[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
		[Token(Token = "0x60001F5")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x2FEEF70", Offset = "0x2FEE370", Length = "0x49")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001D9")]
	private Sprite() { }

	[Address(RVA = "0x2FEC030", Offset = "0x2FEB430", Length = "0xD3")]
	[Token(Token = "0x60001FB")]
	public bool AddScriptableObject(ScriptableObject obj) { }

	[Address(RVA = "0x2FEBFE0", Offset = "0x2FEB3E0", Length = "0x42")]
	[Token(Token = "0x600022D")]
	private static bool AddScriptableObject_Injected(IntPtr _unity_self, IntPtr obj) { }

	[Address(RVA = "0x2FEC400", Offset = "0x2FEB800", Length = "0xC6")]
	[Token(Token = "0x600020D")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	[Address(RVA = "0x2FEC3A0", Offset = "0x2FEB7A0", Length = "0x5B")]
	[Token(Token = "0x600020C")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	[Address(RVA = "0x2FEC750", Offset = "0x2FEBB50", Length = "0x5C2")]
	[Token(Token = "0x600020B")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	[Address(RVA = "0x2FEC640", Offset = "0x2FEBA40", Length = "0x63")]
	[Token(Token = "0x600020A")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	[Address(RVA = "0x2FEC6B0", Offset = "0x2FEBAB0", Length = "0x9E")]
	[Token(Token = "0x6000209")]
	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits) { }

	[Address(RVA = "0x2FEC580", Offset = "0x2FEB980", Length = "0xBC")]
	[Token(Token = "0x600020F")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	[Address(RVA = "0x2FEC4D0", Offset = "0x2FEB8D0", Length = "0xAE")]
	[Token(Token = "0x6000210")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	[Address(RVA = "0x2FECDD0", Offset = "0x2FEC1D0", Length = "0xC3")]
	[Token(Token = "0x600020E")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	[Address(RVA = "0x2FECD20", Offset = "0x2FEC120", Length = "0xAD")]
	[Token(Token = "0x6000208")]
	[VisibleToOtherModules]
	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	[Address(RVA = "0x2FEC2B0", Offset = "0x2FEB6B0", Length = "0xEE")]
	[FreeFunction("SpritesBindings::CreateSprite", ThrowsException = True)]
	[Token(Token = "0x60001E3")]
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	[Address(RVA = "0x2FEC230", Offset = "0x2FEB630", Length = "0x71")]
	[Token(Token = "0x600021A")]
	private static IntPtr CreateSprite_Injected(IntPtr texture, in Rect rect, in Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, in Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	[Address(RVA = "0x2FEC180", Offset = "0x2FEB580", Length = "0xAF")]
	[FreeFunction("SpritesBindings::CreateSpriteWithoutTextureScripting")]
	[Token(Token = "0x60001E2")]
	internal static Sprite CreateSpriteWithoutTextureScripting(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	[Address(RVA = "0x2FEC110", Offset = "0x2FEB510", Length = "0x62")]
	[Token(Token = "0x6000219")]
	private static IntPtr CreateSpriteWithoutTextureScripting_Injected(in Rect rect, in Vector2 pivot, float pixelsToUnits, IntPtr texture) { }

	[Address(RVA = "0x2FEF000", Offset = "0x2FEE400", Length = "0x90")]
	[NativeMethod("GetAlphaTexture")]
	[Token(Token = "0x60001EE")]
	public Texture2D get_associatedAlphaSplitTexture() { }

	[Address(RVA = "0x2FEEFC0", Offset = "0x2FEE3C0", Length = "0x33")]
	[Token(Token = "0x6000225")]
	private static IntPtr get_associatedAlphaSplitTexture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEF0F0", Offset = "0x2FEE4F0", Length = "0x8E")]
	[Token(Token = "0x60001E6")]
	public Vector4 get_border() { }

	[Address(RVA = "0x2FEF0A0", Offset = "0x2FEE4A0", Length = "0x42")]
	[Token(Token = "0x600021D")]
	private static void get_border_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[Address(RVA = "0x2FEF1D0", Offset = "0x2FEE5D0", Length = "0x94")]
	[Token(Token = "0x60001E4")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x2FEF180", Offset = "0x2FEE580", Length = "0x42")]
	[Token(Token = "0x600021B")]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[Address(RVA = "0x2FEF2B0", Offset = "0x2FEE6B0", Length = "0x76")]
	[Token(Token = "0x60001E8")]
	internal uint get_extrude() { }

	[Address(RVA = "0x2FEF270", Offset = "0x2FEE670", Length = "0x33")]
	[Token(Token = "0x600021F")]
	private static uint get_extrude_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEF330", Offset = "0x2FEE730", Length = "0x7C")]
	[Token(Token = "0x60001F0")]
	public bool get_packed() { }

	[Address(RVA = "0x2FED160", Offset = "0x2FEC560", Length = "0x76")]
	[Token(Token = "0x60001F1")]
	public SpritePackingMode get_packingMode() { }

	[Address(RVA = "0x2FED220", Offset = "0x2FEC620", Length = "0x76")]
	[Token(Token = "0x60001F2")]
	public SpritePackingRotation get_packingRotation() { }

	[Address(RVA = "0x2FEF400", Offset = "0x2FEE800", Length = "0x87")]
	[NativeMethod("GetPivotInPixels")]
	[Token(Token = "0x60001EF")]
	public Vector2 get_pivot() { }

	[Address(RVA = "0x2FEF3B0", Offset = "0x2FEE7B0", Length = "0x42")]
	[Token(Token = "0x6000226")]
	private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x2FEF4D0", Offset = "0x2FEE8D0", Length = "0x76")]
	[NativeMethod("GetPixelsToUnits")]
	[Token(Token = "0x60001EC")]
	public float get_pixelsPerUnit() { }

	[Address(RVA = "0x2FEF490", Offset = "0x2FEE890", Length = "0x33")]
	[Token(Token = "0x6000223")]
	private static float get_pixelsPerUnit_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEF5A0", Offset = "0x2FEE9A0", Length = "0x8E")]
	[Token(Token = "0x60001E5")]
	public Rect get_rect() { }

	[Address(RVA = "0x2FEF550", Offset = "0x2FEE950", Length = "0x42")]
	[Token(Token = "0x600021C")]
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	[Address(RVA = "0x2FEF670", Offset = "0x2FEEA70", Length = "0x76")]
	[NativeMethod("GetSpriteAtlasTextureScale")]
	[Token(Token = "0x60001ED")]
	public float get_spriteAtlasTextureScale() { }

	[Address(RVA = "0x2FEF630", Offset = "0x2FEEA30", Length = "0x33")]
	[Token(Token = "0x6000224")]
	private static float get_spriteAtlasTextureScale_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEF7E0", Offset = "0x2FEEBE0", Length = "0x90")]
	[Token(Token = "0x60001E7")]
	public Texture2D get_texture() { }

	[Address(RVA = "0x2FEF7A0", Offset = "0x2FEEBA0", Length = "0x33")]
	[Token(Token = "0x600021E")]
	private static IntPtr get_texture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEF6F0", Offset = "0x2FEEAF0", Length = "0xA0")]
	[Token(Token = "0x60001F3")]
	public Rect get_textureRect() { }

	[Address(RVA = "0x2FEE1C0", Offset = "0x2FED5C0", Length = "0x87")]
	[Token(Token = "0x60001F4")]
	public Vector2 get_textureRectOffset() { }

	[Address(RVA = "0x2FEF8C0", Offset = "0x2FEECC0", Length = "0x76")]
	[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
	[Token(Token = "0x60001F6")]
	public UInt16[] get_triangles() { }

	[Address(RVA = "0x2FEF880", Offset = "0x2FEEC80", Length = "0x33")]
	[Token(Token = "0x6000228")]
	private static UInt16[] get_triangles_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEF980", Offset = "0x2FEED80", Length = "0x76")]
	[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
	[Token(Token = "0x60001F7")]
	public Vector2[] get_uv() { }

	[Address(RVA = "0x2FEF940", Offset = "0x2FEED40", Length = "0x33")]
	[Token(Token = "0x6000229")]
	private static Vector2[] get_uv_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEFA40", Offset = "0x2FEEE40", Length = "0x76")]
	[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
	[Token(Token = "0x60001F5")]
	public Vector2[] get_vertices() { }

	[Address(RVA = "0x2FEFA00", Offset = "0x2FEEE00", Length = "0x33")]
	[Token(Token = "0x6000227")]
	private static Vector2[] get_vertices_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FECEF0", Offset = "0x2FEC2F0", Length = "0x8E")]
	[Token(Token = "0x60001DF")]
	internal Vector4 GetInnerUVs() { }

	[Address(RVA = "0x2FECEA0", Offset = "0x2FEC2A0", Length = "0x42")]
	[Token(Token = "0x6000216")]
	private static void GetInnerUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[Address(RVA = "0x2FECFD0", Offset = "0x2FEC3D0", Length = "0x8E")]
	[Token(Token = "0x60001E0")]
	internal Vector4 GetOuterUVs() { }

	[Address(RVA = "0x2FECF80", Offset = "0x2FEC380", Length = "0x42")]
	[Token(Token = "0x6000217")]
	private static void GetOuterUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[Address(RVA = "0x2FED0A0", Offset = "0x2FEC4A0", Length = "0x76")]
	[Token(Token = "0x60001DC")]
	internal int GetPacked() { }

	[Address(RVA = "0x2FED060", Offset = "0x2FEC460", Length = "0x33")]
	[Token(Token = "0x6000213")]
	private static int GetPacked_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FED160", Offset = "0x2FEC560", Length = "0x76")]
	[Token(Token = "0x60001DA")]
	internal int GetPackingMode() { }

	[Address(RVA = "0x2FED120", Offset = "0x2FEC520", Length = "0x33")]
	[Token(Token = "0x6000211")]
	private static int GetPackingMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FED220", Offset = "0x2FEC620", Length = "0x76")]
	[Token(Token = "0x60001DB")]
	internal int GetPackingRotation() { }

	[Address(RVA = "0x2FED1E0", Offset = "0x2FEC5E0", Length = "0x33")]
	[Token(Token = "0x6000212")]
	private static int GetPackingRotation_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FED2F0", Offset = "0x2FEC6F0", Length = "0x8E")]
	[Token(Token = "0x60001E1")]
	internal Vector4 GetPadding() { }

	[Address(RVA = "0x2FED2A0", Offset = "0x2FEC6A0", Length = "0x42")]
	[Token(Token = "0x6000218")]
	private static void GetPadding_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[Address(RVA = "0x2FEDAF0", Offset = "0x2FECEF0", Length = "0x217")]
	[Token(Token = "0x6000201")]
	public ReadOnlySpan<Vector2> GetPhysicsShape(int shapeIdx) { }

	[Address(RVA = "0x2FED980", Offset = "0x2FECD80", Length = "0x165")]
	[Token(Token = "0x6000200")]
	public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape) { }

	[Address(RVA = "0x2FED3C0", Offset = "0x2FEC7C0", Length = "0x76")]
	[Token(Token = "0x60001F8")]
	public int GetPhysicsShapeCount() { }

	[Address(RVA = "0x2FED380", Offset = "0x2FEC780", Length = "0x33")]
	[Token(Token = "0x600022A")]
	private static int GetPhysicsShapeCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FED490", Offset = "0x2FEC890", Length = "0x207")]
	[FreeFunction("SpritesBindings::GetPhysicsShape", ThrowsException = True)]
	[Token(Token = "0x6000202")]
	private static void GetPhysicsShapeImpl(Sprite sprite, int shapeIdx, List<Vector2> physicsShape) { }

	[Address(RVA = "0x2FED440", Offset = "0x2FEC840", Length = "0x50")]
	[Token(Token = "0x6000231")]
	private static void GetPhysicsShapeImpl_Injected(IntPtr sprite, int shapeIdx, ref BlittableListWrapper physicsShape) { }

	[Address(RVA = "0x2FED6A0", Offset = "0x2FECAA0", Length = "0x180")]
	[Token(Token = "0x60001FE")]
	public int GetPhysicsShapePointCount(int shapeIdx) { }

	[Address(RVA = "0x2FED880", Offset = "0x2FECC80", Length = "0xF6")]
	[FreeFunction("SpritesBindings::GetPhysicsShape", ThrowsException = True)]
	[Token(Token = "0x6000203")]
	private static ReadOnlySpan<Vector2> GetPhysicsShapeSpanImpl(Sprite sprite, int shapeIdx) { }

	[Address(RVA = "0x2FED830", Offset = "0x2FECC30", Length = "0x50")]
	[Token(Token = "0x6000232")]
	private static void GetPhysicsShapeSpanImpl_Injected(IntPtr sprite, int shapeIdx, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FEDE20", Offset = "0x2FED220", Length = "0xA7")]
	[FreeFunction("SpritesBindings::GetScriptableObjects", ThrowsException = True, HasExplicitThis = True)]
	[Token(Token = "0x60001FA")]
	public uint GetScriptableObjects(ScriptableObject[] scriptableObjects) { }

	[Address(RVA = "0x2FEDDD0", Offset = "0x2FED1D0", Length = "0x42")]
	[Token(Token = "0x600022C")]
	private static uint GetScriptableObjects_Injected(IntPtr _unity_self, ScriptableObject[] scriptableObjects) { }

	[Address(RVA = "0x2FEDD50", Offset = "0x2FED150", Length = "0x76")]
	[Token(Token = "0x60001F9")]
	public uint GetScriptableObjectsCount() { }

	[Address(RVA = "0x2FEDD10", Offset = "0x2FED110", Length = "0x33")]
	[Token(Token = "0x600022B")]
	private static uint GetScriptableObjectsCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEDFD0", Offset = "0x2FED3D0", Length = "0x9D")]
	[Token(Token = "0x60001E9")]
	internal Texture2D GetSecondaryTexture(int index) { }

	[Address(RVA = "0x2FEDF90", Offset = "0x2FED390", Length = "0x40")]
	[Token(Token = "0x6000220")]
	private static IntPtr GetSecondaryTexture_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x2FEDF10", Offset = "0x2FED310", Length = "0x76")]
	[Token(Token = "0x60001EA")]
	public int GetSecondaryTextureCount() { }

	[Address(RVA = "0x2FEDED0", Offset = "0x2FED2D0", Length = "0x33")]
	[Token(Token = "0x6000221")]
	private static int GetSecondaryTextureCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FEE0C0", Offset = "0x2FED4C0", Length = "0xA7")]
	[FreeFunction("SpritesBindings::GetSecondaryTextures", ThrowsException = True, HasExplicitThis = True)]
	[Token(Token = "0x60001EB")]
	public int GetSecondaryTextures(SecondarySpriteTexture[] secondaryTexture) { }

	[Address(RVA = "0x2FEE070", Offset = "0x2FED470", Length = "0x42")]
	[Token(Token = "0x6000222")]
	private static int GetSecondaryTextures_Injected(IntPtr _unity_self, SecondarySpriteTexture[] secondaryTexture) { }

	[Address(RVA = "0x2FEE2A0", Offset = "0x2FED6A0", Length = "0x8E")]
	[Token(Token = "0x60001DD")]
	internal Rect GetTextureRect() { }

	[Address(RVA = "0x2FEE250", Offset = "0x2FED650", Length = "0x42")]
	[Token(Token = "0x6000214")]
	private static void GetTextureRect_Injected(IntPtr _unity_self, out Rect ret) { }

	[Address(RVA = "0x2FEE1C0", Offset = "0x2FED5C0", Length = "0x87")]
	[Token(Token = "0x60001DE")]
	internal Vector2 GetTextureRectOffset() { }

	[Address(RVA = "0x2FEE170", Offset = "0x2FED570", Length = "0x42")]
	[Token(Token = "0x6000215")]
	private static void GetTextureRectOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x2FEE370", Offset = "0x2FED770", Length = "0x83")]
	[NativeMethod("GetPhysicsShapePointCount")]
	[Token(Token = "0x60001FF")]
	private int Internal_GetPhysicsShapePointCount(int shapeIdx) { }

	[Address(RVA = "0x2FEE330", Offset = "0x2FED730", Length = "0x40")]
	[Token(Token = "0x6000230")]
	private static int Internal_GetPhysicsShapePointCount_Injected(IntPtr _unity_self, int shapeIdx) { }

	[Address(RVA = "0x2FEE460", Offset = "0x2FED860", Length = "0x1D0")]
	[FreeFunction("SpritesBindings::OverrideGeometry", HasExplicitThis = True)]
	[Token(Token = "0x6000207")]
	public void OverrideGeometry(Vector2[] vertices, UInt16[] triangles) { }

	[Address(RVA = "0x2FEE400", Offset = "0x2FED800", Length = "0x52")]
	[Token(Token = "0x6000235")]
	private static void OverrideGeometry_Injected(IntPtr _unity_self, ref ManagedSpanWrapper vertices, ref ManagedSpanWrapper triangles) { }

	[Address(RVA = "0x2FEE760", Offset = "0x2FEDB60", Length = "0x127")]
	[FreeFunction("SpritesBindings::OverridePhysicsShape", ThrowsException = True)]
	[Token(Token = "0x6000206")]
	private static void OverridePhysicsShape(Sprite sprite, Vector2[] physicsShape, int idx) { }

	[Address(RVA = "0x2FEE890", Offset = "0x2FEDC90", Length = "0x4B1")]
	[Token(Token = "0x6000204")]
	public void OverridePhysicsShape(IList<Vector2[]> physicsShapes) { }

	[Address(RVA = "0x2FEE700", Offset = "0x2FEDB00", Length = "0x52")]
	[Token(Token = "0x6000234")]
	private static void OverridePhysicsShape_Injected(IntPtr sprite, ref ManagedSpanWrapper physicsShape, int idx) { }

	[Address(RVA = "0x2FEE680", Offset = "0x2FEDA80", Length = "0x78")]
	[FreeFunction("SpritesBindings::OverridePhysicsShapeCount")]
	[Token(Token = "0x6000205")]
	private static void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount) { }

	[Address(RVA = "0x2FEE640", Offset = "0x2FEDA40", Length = "0x40")]
	[Token(Token = "0x6000233")]
	private static void OverridePhysicsShapeCount_Injected(IntPtr sprite, int physicsShapeCount) { }

	[Address(RVA = "0x2FEED90", Offset = "0x2FEE190", Length = "0x83")]
	[Token(Token = "0x60001FC")]
	public bool RemoveScriptableObjectAt(uint i) { }

	[Address(RVA = "0x2FEED50", Offset = "0x2FEE150", Length = "0x40")]
	[Token(Token = "0x600022E")]
	private static bool RemoveScriptableObjectAt_Injected(IntPtr _unity_self, uint i) { }

	[Address(RVA = "0x2FEEE80", Offset = "0x2FEE280", Length = "0xE3")]
	[Token(Token = "0x60001FD")]
	public bool SetScriptableObjectAt(ScriptableObject obj, uint i) { }

	[Address(RVA = "0x2FEEE20", Offset = "0x2FEE220", Length = "0x52")]
	[Token(Token = "0x600022F")]
	private static bool SetScriptableObjectAt_Injected(IntPtr _unity_self, IntPtr obj, uint i) { }

}

