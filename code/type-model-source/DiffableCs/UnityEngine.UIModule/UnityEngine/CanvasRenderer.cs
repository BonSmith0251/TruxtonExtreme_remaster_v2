namespace UnityEngine;

[NativeClass("UI::CanvasRenderer")]
[NativeHeader("Modules/UI/CanvasRenderer.h")]
[Token(Token = "0x2000004")]
public sealed class CanvasRenderer : Component
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000001")]
	private bool <isMask>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000008")]
	public int absoluteDepth
	{
		[Address(RVA = "0x342E860", Offset = "0x342DC60", Length = "0x76")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000F")]
	public Vector2 clippingSoftness
	{
		[Address(RVA = "0x342E930", Offset = "0x342DD30", Length = "0x87")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 135
		[Address(RVA = "0x342F010", Offset = "0x342E410", Length = "0x80")]
		[Token(Token = "0x6000028")]
		 set { } //Length: 128
	}

	[NativeProperty("ShouldCull", False, TargetType::Function (0))]
	[Token(Token = "0x1700000D")]
	public bool cull
	{
		[Address(RVA = "0x342EAC0", Offset = "0x342DEC0", Length = "0x76")]
		[Token(Token = "0x6000020")]
		 get { } //Length: 118
		[Address(RVA = "0x342F1D0", Offset = "0x342E5D0", Length = "0x86")]
		[Token(Token = "0x6000021")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000A")]
	public bool cullTransparentMesh
	{
		[Address(RVA = "0x342EA00", Offset = "0x342DE00", Length = "0x76")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 118
		[Address(RVA = "0x342F0F0", Offset = "0x342E4F0", Length = "0x86")]
		[Token(Token = "0x600001D")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000009")]
	public bool hasMoved
	{
		[Address(RVA = "0x342EB80", Offset = "0x342DF80", Length = "0x76")]
		[Token(Token = "0x600001B")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000005")]
	public bool hasPopInstruction
	{
		[Address(RVA = "0x342EC40", Offset = "0x342E040", Length = "0x76")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 118
		[Address(RVA = "0x342F2B0", Offset = "0x342E6B0", Length = "0x86")]
		[Token(Token = "0x6000015")]
		 set { } //Length: 134
	}

	[NativeProperty("RectClipping", False, TargetType::Function (0))]
	[Token(Token = "0x1700000B")]
	public bool hasRectClipping
	{
		[Address(RVA = "0x342ED00", Offset = "0x342E100", Length = "0x76")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 118
	}

	[Obsolete("isMask is no longer supported.See EnableClipping for vertex clipping configuration", False)]
	[Token(Token = "0x1700000E")]
	public bool isMask
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000022")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000023")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000006")]
	public int materialCount
	{
		[Address(RVA = "0x342EDC0", Offset = "0x342E1C0", Length = "0x76")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 118
		[Address(RVA = "0x342F380", Offset = "0x342E780", Length = "0x83")]
		[Token(Token = "0x6000017")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000007")]
	public int popMaterialCount
	{
		[Address(RVA = "0x342EE80", Offset = "0x342E280", Length = "0x76")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 118
		[Address(RVA = "0x342F450", Offset = "0x342E850", Length = "0x83")]
		[Token(Token = "0x6000019")]
		 set { } //Length: 131
	}

	[NativeProperty("Depth", False, TargetType::Function (0))]
	[Token(Token = "0x1700000C")]
	public int relativeDepth
	{
		[Address(RVA = "0x342EF40", Offset = "0x342E340", Length = "0x76")]
		[Token(Token = "0x600001F")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000048")]
	public CanvasRenderer() { }

	[Address(RVA = "0x342C270", Offset = "0x342B670", Length = "0x102")]
	[Token(Token = "0x6000041")]
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents) { }

	[Address(RVA = "0x342C380", Offset = "0x342B780", Length = "0x62")]
	[Token(Token = "0x6000042")]
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[Address(RVA = "0x342C430", Offset = "0x342B830", Length = "0x76")]
	[Token(Token = "0x6000037")]
	public void Clear() { }

	[Address(RVA = "0x342C3F0", Offset = "0x342B7F0", Length = "0x33")]
	[Token(Token = "0x600006A")]
	private static void Clear_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342C520", Offset = "0x342B920", Length = "0x10F")]
	[Token(Token = "0x600003F")]
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	[Address(RVA = "0x342C4B0", Offset = "0x342B8B0", Length = "0x62")]
	[Token(Token = "0x6000040")]
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	[Address(RVA = "0x342C4B0", Offset = "0x342B8B0", Length = "0x62")]
	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000047")]
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	[Address(RVA = "0x342C670", Offset = "0x342BA70", Length = "0x76")]
	[Token(Token = "0x6000029")]
	public void DisableRectClipping() { }

	[Address(RVA = "0x342C630", Offset = "0x342BA30", Length = "0x33")]
	[Token(Token = "0x600005C")]
	private static void DisableRectClipping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342C740", Offset = "0x342BB40", Length = "0x85")]
	[Token(Token = "0x6000026")]
	public void EnableRectClipping(Rect rect) { }

	[Address(RVA = "0x342C6F0", Offset = "0x342BAF0", Length = "0x42")]
	[Token(Token = "0x6000059")]
	private static void EnableRectClipping_Injected(IntPtr _unity_self, in Rect rect) { }

	[Address(RVA = "0x342E860", Offset = "0x342DC60", Length = "0x76")]
	[Token(Token = "0x600001A")]
	public int get_absoluteDepth() { }

	[Address(RVA = "0x342E820", Offset = "0x342DC20", Length = "0x33")]
	[Token(Token = "0x600004F")]
	private static int get_absoluteDepth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342E930", Offset = "0x342DD30", Length = "0x87")]
	[Token(Token = "0x6000027")]
	public Vector2 get_clippingSoftness() { }

	[Address(RVA = "0x342E8E0", Offset = "0x342DCE0", Length = "0x42")]
	[Token(Token = "0x600005A")]
	private static void get_clippingSoftness_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x342EAC0", Offset = "0x342DEC0", Length = "0x76")]
	[Token(Token = "0x6000020")]
	public bool get_cull() { }

	[Address(RVA = "0x342EA80", Offset = "0x342DE80", Length = "0x33")]
	[Token(Token = "0x6000055")]
	private static bool get_cull_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342EA00", Offset = "0x342DE00", Length = "0x76")]
	[Token(Token = "0x600001C")]
	public bool get_cullTransparentMesh() { }

	[Address(RVA = "0x342E9C0", Offset = "0x342DDC0", Length = "0x33")]
	[Token(Token = "0x6000051")]
	private static bool get_cullTransparentMesh_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342EB80", Offset = "0x342DF80", Length = "0x76")]
	[Token(Token = "0x600001B")]
	public bool get_hasMoved() { }

	[Address(RVA = "0x342EB40", Offset = "0x342DF40", Length = "0x33")]
	[Token(Token = "0x6000050")]
	private static bool get_hasMoved_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342EC40", Offset = "0x342E040", Length = "0x76")]
	[Token(Token = "0x6000014")]
	public bool get_hasPopInstruction() { }

	[Address(RVA = "0x342EC00", Offset = "0x342E000", Length = "0x33")]
	[Token(Token = "0x6000049")]
	private static bool get_hasPopInstruction_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342ED00", Offset = "0x342E100", Length = "0x76")]
	[Token(Token = "0x600001E")]
	public bool get_hasRectClipping() { }

	[Address(RVA = "0x342ECC0", Offset = "0x342E0C0", Length = "0x33")]
	[Token(Token = "0x6000053")]
	private static bool get_hasRectClipping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000022")]
	public bool get_isMask() { }

	[Address(RVA = "0x342EDC0", Offset = "0x342E1C0", Length = "0x76")]
	[Token(Token = "0x6000016")]
	public int get_materialCount() { }

	[Address(RVA = "0x342ED80", Offset = "0x342E180", Length = "0x33")]
	[Token(Token = "0x600004B")]
	private static int get_materialCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342EE80", Offset = "0x342E280", Length = "0x76")]
	[Token(Token = "0x6000018")]
	public int get_popMaterialCount() { }

	[Address(RVA = "0x342EE40", Offset = "0x342E240", Length = "0x33")]
	[Token(Token = "0x600004D")]
	private static int get_popMaterialCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342EF40", Offset = "0x342E340", Length = "0x76")]
	[Token(Token = "0x600001F")]
	public int get_relativeDepth() { }

	[Address(RVA = "0x342EF00", Offset = "0x342E300", Length = "0x33")]
	[Token(Token = "0x6000054")]
	private static int get_relativeDepth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342C7D0", Offset = "0x342BBD0", Length = "0x89")]
	[Token(Token = "0x6000038")]
	public float GetAlpha() { }

	[Address(RVA = "0x342C8B0", Offset = "0x342BCB0", Length = "0x8E")]
	[Token(Token = "0x6000025")]
	public Color GetColor() { }

	[Address(RVA = "0x342C860", Offset = "0x342BC60", Length = "0x42")]
	[Token(Token = "0x6000058")]
	private static void GetColor_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x342C980", Offset = "0x342BD80", Length = "0x76")]
	[Token(Token = "0x600003A")]
	public float GetInheritedAlpha() { }

	[Address(RVA = "0x342C940", Offset = "0x342BD40", Length = "0x33")]
	[Token(Token = "0x600006B")]
	private static float GetInheritedAlpha_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342CAE0", Offset = "0x342BEE0", Length = "0x9D")]
	[Token(Token = "0x600002B")]
	public Material GetMaterial(int index) { }

	[Address(RVA = "0x342CA40", Offset = "0x342BE40", Length = "0x92")]
	[Token(Token = "0x600003C")]
	public Material GetMaterial() { }

	[Address(RVA = "0x342CA00", Offset = "0x342BE00", Length = "0x40")]
	[Token(Token = "0x600005E")]
	private static IntPtr GetMaterial_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x342CBC0", Offset = "0x342BFC0", Length = "0x90")]
	[Token(Token = "0x6000036")]
	public Mesh GetMesh() { }

	[Address(RVA = "0x342CB80", Offset = "0x342BF80", Length = "0x33")]
	[Token(Token = "0x6000069")]
	private static IntPtr GetMesh_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342CCA0", Offset = "0x342C0A0", Length = "0x9D")]
	[Token(Token = "0x600002D")]
	public Material GetPopMaterial(int index) { }

	[Address(RVA = "0x342CC60", Offset = "0x342C060", Length = "0x40")]
	[Token(Token = "0x6000060")]
	private static IntPtr GetPopMaterial_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x342CFB0", Offset = "0x342C3B0", Length = "0x9D")]
	[Token(Token = "0x6000032")]
	public Texture2D GetSecondaryTexture(int index) { }

	[Address(RVA = "0x342CF70", Offset = "0x342C370", Length = "0x40")]
	[Token(Token = "0x6000065")]
	private static IntPtr GetSecondaryTexture_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x342CD80", Offset = "0x342C180", Length = "0x76")]
	[Token(Token = "0x600002F")]
	public int GetSecondaryTextureCount() { }

	[Address(RVA = "0x342CD40", Offset = "0x342C140", Length = "0x33")]
	[Token(Token = "0x6000062")]
	private static int GetSecondaryTextureCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342CE50", Offset = "0x342C250", Length = "0x113")]
	[Token(Token = "0x6000031")]
	public string GetSecondaryTextureName(int index) { }

	[Address(RVA = "0x342CE00", Offset = "0x342C200", Length = "0x50")]
	[Token(Token = "0x6000064")]
	private static void GetSecondaryTextureName_Injected(IntPtr _unity_self, int index, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x342F010", Offset = "0x342E410", Length = "0x80")]
	[Token(Token = "0x6000028")]
	public void set_clippingSoftness(Vector2 value) { }

	[Address(RVA = "0x342EFC0", Offset = "0x342E3C0", Length = "0x42")]
	[Token(Token = "0x600005B")]
	private static void set_clippingSoftness_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x342F1D0", Offset = "0x342E5D0", Length = "0x86")]
	[Token(Token = "0x6000021")]
	public void set_cull(bool value) { }

	[Address(RVA = "0x342F180", Offset = "0x342E580", Length = "0x42")]
	[Token(Token = "0x6000056")]
	private static void set_cull_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x342F0F0", Offset = "0x342E4F0", Length = "0x86")]
	[Token(Token = "0x600001D")]
	public void set_cullTransparentMesh(bool value) { }

	[Address(RVA = "0x342F0A0", Offset = "0x342E4A0", Length = "0x42")]
	[Token(Token = "0x6000052")]
	private static void set_cullTransparentMesh_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x342F2B0", Offset = "0x342E6B0", Length = "0x86")]
	[Token(Token = "0x6000015")]
	public void set_hasPopInstruction(bool value) { }

	[Address(RVA = "0x342F260", Offset = "0x342E660", Length = "0x42")]
	[Token(Token = "0x600004A")]
	private static void set_hasPopInstruction_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000023")]
	public void set_isMask(bool value) { }

	[Address(RVA = "0x342F380", Offset = "0x342E780", Length = "0x83")]
	[Token(Token = "0x6000017")]
	public void set_materialCount(int value) { }

	[Address(RVA = "0x342F340", Offset = "0x342E740", Length = "0x40")]
	[Token(Token = "0x600004C")]
	private static void set_materialCount_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x342F450", Offset = "0x342E850", Length = "0x83")]
	[Token(Token = "0x6000019")]
	public void set_popMaterialCount(int value) { }

	[Address(RVA = "0x342F410", Offset = "0x342E810", Length = "0x40")]
	[Token(Token = "0x600004E")]
	private static void set_popMaterialCount_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x342D160", Offset = "0x342C560", Length = "0x114")]
	[Token(Token = "0x6000039")]
	public void SetAlpha(float alpha) { }

	[Address(RVA = "0x342D0A0", Offset = "0x342C4A0", Length = "0xBA")]
	[Token(Token = "0x6000034")]
	public void SetAlphaTexture(Texture texture) { }

	[Address(RVA = "0x342D050", Offset = "0x342C450", Length = "0x42")]
	[Token(Token = "0x6000067")]
	private static void SetAlphaTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	[Address(RVA = "0x342D2D0", Offset = "0x342C6D0", Length = "0x85")]
	[Token(Token = "0x6000024")]
	public void SetColor(Color color) { }

	[Address(RVA = "0x342D280", Offset = "0x342C680", Length = "0x42")]
	[Token(Token = "0x6000057")]
	private static void SetColor_Injected(IntPtr _unity_self, in Color color) { }

	[Address(RVA = "0x342D3C0", Offset = "0x342C7C0", Length = "0x243")]
	[Token(Token = "0x600003B")]
	public void SetMaterial(Material material, Texture texture) { }

	[Address(RVA = "0x342D610", Offset = "0x342CA10", Length = "0xD0")]
	[Token(Token = "0x600002A")]
	public void SetMaterial(Material material, int index) { }

	[Address(RVA = "0x342D360", Offset = "0x342C760", Length = "0x52")]
	[Token(Token = "0x600005D")]
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	[Address(RVA = "0x342D740", Offset = "0x342CB40", Length = "0xBA")]
	[Token(Token = "0x6000035")]
	public void SetMesh(Mesh mesh) { }

	[Address(RVA = "0x342D6F0", Offset = "0x342CAF0", Length = "0x42")]
	[Token(Token = "0x6000068")]
	private static void SetMesh_Injected(IntPtr _unity_self, IntPtr mesh) { }

	[Address(RVA = "0x342D860", Offset = "0x342CC60", Length = "0xD0")]
	[Token(Token = "0x600002C")]
	public void SetPopMaterial(Material material, int index) { }

	[Address(RVA = "0x342D800", Offset = "0x342CC00", Length = "0x52")]
	[Token(Token = "0x600005F")]
	private static void SetPopMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	[Address(RVA = "0x342DA70", Offset = "0x342CE70", Length = "0x208")]
	[Token(Token = "0x6000033")]
	public void SetSecondaryTexture(int index, string name, Texture2D texture) { }

	[Address(RVA = "0x342DA10", Offset = "0x342CE10", Length = "0x60")]
	[Token(Token = "0x6000066")]
	private static void SetSecondaryTexture_Injected(IntPtr _unity_self, int index, ref ManagedSpanWrapper name, IntPtr texture) { }

	[Address(RVA = "0x342D980", Offset = "0x342CD80", Length = "0x83")]
	[Token(Token = "0x6000030")]
	public void SetSecondaryTextureCount(int size) { }

	[Address(RVA = "0x342D940", Offset = "0x342CD40", Length = "0x40")]
	[Token(Token = "0x6000063")]
	private static void SetSecondaryTextureCount_Injected(IntPtr _unity_self, int size) { }

	[Address(RVA = "0x342DCD0", Offset = "0x342D0D0", Length = "0xBA")]
	[Token(Token = "0x600002E")]
	public void SetTexture(Texture texture) { }

	[Address(RVA = "0x342DC80", Offset = "0x342D080", Length = "0x42")]
	[Token(Token = "0x6000061")]
	private static void SetTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	[Address(RVA = "0x342E560", Offset = "0x342D960", Length = "0x6D")]
	[Obsolete("UI System now uses meshes.Generate a mesh and use 'SetMesh' instead", False)]
	[Token(Token = "0x6000043")]
	public void SetVertices(List<UIVertex> vertices) { }

	[Address(RVA = "0x342DD90", Offset = "0x342D190", Length = "0x7C4")]
	[Obsolete("UI System now uses meshes.Generate a mesh and use 'SetMesh' instead", False)]
	[Token(Token = "0x6000044")]
	public void SetVertices(UIVertex[] vertices, int size) { }

	[Address(RVA = "0x342E5D0", Offset = "0x342D9D0", Length = "0x42")]
	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000045")]
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[Address(RVA = "0x342E620", Offset = "0x342DA20", Length = "0xCF")]
	[Token(Token = "0x600003E")]
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	[Address(RVA = "0x342E6F0", Offset = "0x342DAF0", Length = "0x12E")]
	[Token(Token = "0x600003D")]
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	[Address(RVA = "0x342C380", Offset = "0x342B780", Length = "0x62")]
	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000046")]
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

}

