namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000E6")]
internal class LightCookieManager : IDisposable
{
	[Token(Token = "0x20000EB")]
	private struct LightCookieMapping
	{
		[CompilerGenerated]
		[Token(Token = "0x20000EC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000570")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x2DC8E50", Offset = "0x2DC8250", Length = "0x67")]
			[Token(Token = "0x6000660")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000661")]
			public <>c() { }

			[Address(RVA = "0x2DC8B10", Offset = "0x2DC7F10", Length = "0xF3")]
			[Token(Token = "0x6000662")]
			internal int <.cctor>b__6_0(LightCookieMapping a, LightCookieMapping b) { }

			[Address(RVA = "0x2DC8C10", Offset = "0x2DC8010", Length = "0xC")]
			[Token(Token = "0x6000663")]
			internal int <.cctor>b__6_1(LightCookieMapping a, LightCookieMapping b) { }

		}

		[Token(Token = "0x400056E")]
		public static Func<LightCookieMapping, LightCookieMapping, Int32> s_CompareByCookieSize; //Field offset: 0x0
		[Token(Token = "0x400056F")]
		public static Func<LightCookieMapping, LightCookieMapping, Int32> s_CompareByBufferIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056B")]
		public ushort visibleLightIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x400056C")]
		public ushort lightBufferIndex; //Field offset: 0x2
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400056D")]
		public Light light; //Field offset: 0x8

		[Address(RVA = "0x2DB18E0", Offset = "0x2DB0CE0", Length = "0x135")]
		[Token(Token = "0x600065F")]
		private static LightCookieMapping() { }

	}

	[Token(Token = "0x20000EF")]
	private class LightCookieShaderData : IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000576")]
		private int m_Size; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000577")]
		private bool m_UseStructuredBuffer; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000578")]
		private Matrix4x4[] m_WorldToLightCpuData; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000579")]
		private Vector4[] m_AtlasUVRectCpuData; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400057A")]
		private Single[] m_LightTypeCpuData; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400057B")]
		private ShaderBitArray m_CookieEnableBitsCpuData; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400057C")]
		private ComputeBuffer m_WorldToLightBuffer; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400057D")]
		private ComputeBuffer m_AtlasUVRectBuffer; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400057E")]
		private ComputeBuffer m_LightTypeBuffer; //Field offset: 0x48
		[CompilerGenerated]
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400057F")]
		private bool <isUploaded>k__BackingField; //Field offset: 0x50

		[Token(Token = "0x170001BC")]
		public Vector4[] atlasUVRects
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x600066F")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170001BB")]
		public ShaderBitArray cookieEnableBits
		{
			[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
			[Token(Token = "0x600066E")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170001BE")]
		public bool isUploaded
		{
			[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000671")]
			 get { } //Length: 5
			[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000672")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170001BD")]
		public Single[] lightTypes
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[Token(Token = "0x6000670")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170001BA")]
		public Matrix4x4[] worldToLights
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x600066D")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2DB1F10", Offset = "0x2DB1310", Length = "0x3E")]
		[Token(Token = "0x6000673")]
		public LightCookieShaderData(int size, bool useStructuredBuffer) { }

		[Address(RVA = "0x2DB1A20", Offset = "0x2DB0E20", Length = "0x8E")]
		[Token(Token = "0x6000677")]
		public void Clear(CommandBuffer cmd) { }

		[Address(RVA = "0x2DB1AB0", Offset = "0x2DB0EB0", Length = "0x4A")]
		[Token(Token = "0x6000674")]
		public override void Dispose() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600066F")]
		public Vector4[] get_atlasUVRects() { }

		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600066E")]
		public ShaderBitArray get_cookieEnableBits() { }

		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000671")]
		public bool get_isUploaded() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000670")]
		public Single[] get_lightTypes() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600066D")]
		public Matrix4x4[] get_worldToLights() { }

		[Address(RVA = "0x2DB1B00", Offset = "0x2DB0F00", Length = "0x224")]
		[Token(Token = "0x6000675")]
		public void Resize(int size) { }

		[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000672")]
		public void set_isUploaded(bool value) { }

		[Address(RVA = "0x2DB1D30", Offset = "0x2DB1130", Length = "0x1D4")]
		[Token(Token = "0x6000676")]
		public void Upload(CommandBuffer cmd) { }

	}

	[Token(Token = "0x20000E8")]
	private enum LightCookieShaderFormat : int
	{
		None = -1,
		RGB = 0,
		Alpha = 1,
		Red = 2,
	}

	[Token(Token = "0x20000E9")]
	internal struct Settings
	{
		[Token(Token = "0x20000EA")]
		internal struct AtlasSettings
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000569")]
			public Vector2Int resolution; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400056A")]
			public GraphicsFormat format; //Field offset: 0x8

			[Token(Token = "0x170001B5")]
			public bool isPow2
			{
				[Address(RVA = "0x2DA7F50", Offset = "0x2DA7350", Length = "0x18")]
				[Token(Token = "0x600065D")]
				 get { } //Length: 24
			}

			[Token(Token = "0x170001B6")]
			public bool isSquare
			{
				[Address(RVA = "0x2DA7F70", Offset = "0x2DA7370", Length = "0x9")]
				[Token(Token = "0x600065E")]
				 get { } //Length: 9
			}

			[Address(RVA = "0x2DA7F50", Offset = "0x2DA7350", Length = "0x18")]
			[Token(Token = "0x600065D")]
			public bool get_isPow2() { }

			[Address(RVA = "0x2DA7F70", Offset = "0x2DA7370", Length = "0x9")]
			[Token(Token = "0x600065E")]
			public bool get_isSquare() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000565")]
		public AtlasSettings atlas; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000566")]
		public int maxAdditionalLights; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000567")]
		public float cubeOctahedralSizeScale; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000568")]
		public bool useStructuredBuffer; //Field offset: 0x14

		[Address(RVA = "0x2DC6110", Offset = "0x2DC5510", Length = "0xA7")]
		[Token(Token = "0x600065C")]
		public static Settings Create() { }

	}

	[Token(Token = "0x20000E7")]
	private static class ShaderProperty
	{
		[Token(Token = "0x4000554")]
		public static readonly int mainLightTexture; //Field offset: 0x0
		[Token(Token = "0x4000555")]
		public static readonly int mainLightWorldToLight; //Field offset: 0x4
		[Token(Token = "0x4000556")]
		public static readonly int mainLightCookieTextureFormat; //Field offset: 0x8
		[Token(Token = "0x4000557")]
		public static readonly int additionalLightsCookieAtlasTexture; //Field offset: 0xC
		[Token(Token = "0x4000558")]
		public static readonly int additionalLightsCookieAtlasTextureFormat; //Field offset: 0x10
		[Token(Token = "0x4000559")]
		public static readonly int additionalLightsCookieEnableBits; //Field offset: 0x14
		[Token(Token = "0x400055A")]
		public static readonly int additionalLightsCookieAtlasUVRectBuffer; //Field offset: 0x18
		[Token(Token = "0x400055B")]
		public static readonly int additionalLightsCookieAtlasUVRects; //Field offset: 0x1C
		[Token(Token = "0x400055C")]
		public static readonly int additionalLightsWorldToLightBuffer; //Field offset: 0x20
		[Token(Token = "0x400055D")]
		public static readonly int additionalLightsLightTypeBuffer; //Field offset: 0x24
		[Token(Token = "0x400055E")]
		public static readonly int additionalLightsWorldToLights; //Field offset: 0x28
		[Token(Token = "0x400055F")]
		public static readonly int additionalLightsLightTypes; //Field offset: 0x2C

		[Address(RVA = "0x2DC6290", Offset = "0x2DC5690", Length = "0x22C")]
		[Token(Token = "0x600065B")]
		private static ShaderProperty() { }

	}

	[Token(Token = "0x20000EE")]
	private class WorkMemory
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000574")]
		public LightCookieMapping[] lightMappings; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000575")]
		public Vector4[] uvRects; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600066C")]
		public WorkMemory() { }

		[Address(RVA = "0x2DC9330", Offset = "0x2DC8730", Length = "0x123")]
		[Token(Token = "0x600066B")]
		public void Resize(int size) { }

	}

	[DefaultMember("Item")]
	[IsReadOnly]
	[Token(Token = "0x20000ED")]
	private struct WorkSlice
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000571")]
		private readonly T[] m_Data; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000572")]
		private readonly int m_Start; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000573")]
		private readonly int m_Length; //Field offset: 0x0

		[Token(Token = "0x170001B9")]
		public int capacity
		{
			[Address(RVA = "0xA8E460", Offset = "0xA8D860", Length = "0x19")]
			[Token(Token = "0x6000669")]
			 get { } //Length: 25
		}

		[Token(Token = "0x170001B7")]
		public T Item
		{
			[Address(RVA = "0x154EA70", Offset = "0x154DE70", Length = "0x3D")]
			[Token(Token = "0x6000666")]
			 get { } //Length: 61
			[Address(RVA = "0x154EBE0", Offset = "0x154DFE0", Length = "0x3A")]
			[Token(Token = "0x6000667")]
			 set { } //Length: 58
		}

		[Token(Token = "0x170001B8")]
		public int length
		{
			[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
			[Token(Token = "0x6000668")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x154E830", Offset = "0x154DC30", Length = "0x5E")]
		[Token(Token = "0x6000664")]
		public WorkSlice`1(T[] src, int srcLen = -1) { }

		[Address(RVA = "0x154E930", Offset = "0x154DD30", Length = "0x9A")]
		[Token(Token = "0x6000665")]
		public WorkSlice`1(T[] src, int srcStart, int srcLen = -1) { }

		[Address(RVA = "0xA8E460", Offset = "0xA8D860", Length = "0x19")]
		[Token(Token = "0x6000669")]
		public int get_capacity() { }

		[Address(RVA = "0x154EA70", Offset = "0x154DE70", Length = "0x3D")]
		[Token(Token = "0x6000666")]
		public T get_Item(int index) { }

		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x6000668")]
		public int get_length() { }

		[Address(RVA = "0x154EBE0", Offset = "0x154DFE0", Length = "0x3A")]
		[Token(Token = "0x6000667")]
		public void set_Item(int index, T value) { }

		[Address(RVA = "0x154E580", Offset = "0x154D980", Length = "0xB2")]
		[Token(Token = "0x600066A")]
		public void Sort(Func<T, T, Int32> compare) { }

	}

	[Token(Token = "0x4000549")]
	private static readonly Matrix4x4 s_DirLightProj; //Field offset: 0x0
	[Token(Token = "0x400054F")]
	private const int k_MaxCookieSizeDivisor = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400054A")]
	private Texture2DAtlas m_AdditionalLightsCookieAtlas; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400054B")]
	private LightCookieShaderData m_AdditionalLightsCookieShaderData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400054C")]
	private readonly Settings m_Settings; //Field offset: 0x20
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400054D")]
	private WorkMemory m_WorkMem; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400054E")]
	private Int32[] m_VisibleLightIndexToShaderDataIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000550")]
	private int m_CookieSizeDivisor; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000551")]
	private uint m_PrevCookieRequestPixelCount; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000552")]
	private int m_PrevWarnFrame; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000553")]
	private bool <IsKeywordLightCookieEnabled>k__BackingField; //Field offset: 0x54

	[Token(Token = "0x170001B4")]
	internal RTHandle AdditionalLightsCookieAtlasTexture
	{
		[Address(RVA = "0x2DB18D0", Offset = "0x2DB0CD0", Length = "0xF")]
		[Token(Token = "0x6000644")]
		internal get { } //Length: 15
	}

	[Token(Token = "0x170001B3")]
	internal bool IsKeywordLightCookieEnabled
	{
		[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000642")]
		internal get { } //Length: 5
		[Address(RVA = "0x1CEB110", Offset = "0x1CEA510", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000643")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2DB17B0", Offset = "0x2DB0BB0", Length = "0x8F")]
	[Token(Token = "0x600065A")]
	private static LightCookieManager() { }

	[Address(RVA = "0x2DB1840", Offset = "0x2DB0C40", Length = "0x89")]
	[Token(Token = "0x6000645")]
	public LightCookieManager(ref Settings settings) { }

	[Address(RVA = "0x2DAE400", Offset = "0x2DAD800", Length = "0x1AC")]
	[Token(Token = "0x6000657")]
	private void AdjustUVRect(ref Vector4 uvScaleOffset, Texture cookie, ref Vector2 cookieSize) { }

	[Address(RVA = "0x2DAE5B0", Offset = "0x2DAD9B0", Length = "0x33")]
	[Token(Token = "0x6000653")]
	private int ApproximateCookieSizeDivisor(float requestAtlasRatio) { }

	[Address(RVA = "0x2DAE5F0", Offset = "0x2DAD9F0", Length = "0xEF")]
	[Token(Token = "0x6000652")]
	private uint ComputeCookieRequestPixelCount(ref WorkSlice<LightCookieMapping>& validLightMappings) { }

	[Address(RVA = "0x2DAE6E0", Offset = "0x2DADAE0", Length = "0x127")]
	[Token(Token = "0x6000656")]
	private int ComputeOctahedralCookieSize(Texture cookie) { }

	[Address(RVA = "0x2DAE810", Offset = "0x2DADC10", Length = "0x63")]
	[Token(Token = "0x6000648")]
	public override void Dispose() { }

	[Address(RVA = "0x2DAE880", Offset = "0x2DADC80", Length = "0x1A0")]
	[Token(Token = "0x6000654")]
	private Vector4 Fetch2D(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1) { }

	[Address(RVA = "0x2DAEA30", Offset = "0x2DADE30", Length = "0x27F")]
	[Token(Token = "0x6000655")]
	private Vector4 FetchCube(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1) { }

	[Address(RVA = "0x2DAECB0", Offset = "0x2DAE0B0", Length = "0x339")]
	[Token(Token = "0x6000651")]
	private int FetchUVRects(CommandBuffer cmd, ref WorkSlice<LightCookieMapping>& validLightMappings, Vector4[] textureAtlasUVRects, int cookieSizeDivisor) { }

	[Address(RVA = "0x2DAEFF0", Offset = "0x2DAE3F0", Length = "0x4C9")]
	[Token(Token = "0x600064F")]
	private int FilterAndValidateAdditionalLights(UniversalLightData lightData, LightCookieMapping[] validLightMappings) { }

	[Address(RVA = "0x2DB18D0", Offset = "0x2DB0CD0", Length = "0xF")]
	[Token(Token = "0x6000644")]
	internal RTHandle get_AdditionalLightsCookieAtlasTexture() { }

	[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000642")]
	internal bool get_IsKeywordLightCookieEnabled() { }

	[Address(RVA = "0x2DAF4C0", Offset = "0x2DAE8C0", Length = "0x41")]
	[Token(Token = "0x6000649")]
	public int GetLightCookieShaderDataIndex(int visibleLightIndex) { }

	[Address(RVA = "0x2DAF510", Offset = "0x2DAE910", Length = "0x78")]
	[Token(Token = "0x600064C")]
	private LightCookieShaderFormat GetLightCookieShaderFormat(GraphicsFormat cookieFormat) { }

	[Address(RVA = "0x2DAF590", Offset = "0x2DAE990", Length = "0x285")]
	[Token(Token = "0x600064D")]
	private void GetLightUVScaleOffset(ref UniversalAdditionalLightData additionalLightData, ref Matrix4x4 uvTransform) { }

	[Address(RVA = "0x2DAF820", Offset = "0x2DAEC20", Length = "0x14D")]
	[Token(Token = "0x6000646")]
	private void InitAdditionalLights(int size) { }

	[Address(RVA = "0x2BE61D0", Offset = "0x2BE55D0", Length = "0x13")]
	[Token(Token = "0x6000647")]
	public bool isInitialized() { }

	[Address(RVA = "0x1CEB110", Offset = "0x1CEA510", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000643")]
	private void set_IsKeywordLightCookieEnabled(bool value) { }

	[Address(RVA = "0x2DB04D0", Offset = "0x2DAF8D0", Length = "0x2D7")]
	[Token(Token = "0x600064A")]
	public void Setup(CommandBuffer cmd, UniversalLightData lightData) { }

	[Address(RVA = "0x2DAF970", Offset = "0x2DAED70", Length = "0x3E5")]
	[Token(Token = "0x600064E")]
	private bool SetupAdditionalLights(CommandBuffer cmd, UniversalLightData lightData) { }

	[Address(RVA = "0x2DAFD60", Offset = "0x2DAF160", Length = "0x761")]
	[Token(Token = "0x600064B")]
	private bool SetupMainLight(CommandBuffer cmd, ref VisibleLight visibleMainLight) { }

	[Address(RVA = "0x2DB07B0", Offset = "0x2DAFBB0", Length = "0x12D")]
	[Token(Token = "0x6000658")]
	private void ShrinkUVRect(ref Vector4 uvScaleOffset, float amountPixels, ref Vector2 cookieSize) { }

	[Address(RVA = "0x2DB08E0", Offset = "0x2DAFCE0", Length = "0x26A")]
	[Token(Token = "0x6000650")]
	private int UpdateAdditionalLightsAtlas(CommandBuffer cmd, ref WorkSlice<LightCookieMapping>& validLightMappings, Vector4[] textureAtlasUVRects) { }

	[Address(RVA = "0x2DB0B50", Offset = "0x2DAFF50", Length = "0xC5C")]
	[Token(Token = "0x6000659")]
	private void UploadAdditionalLights(CommandBuffer cmd, UniversalLightData lightData, ref WorkSlice<LightCookieMapping>& validLightMappings, ref WorkSlice<Vector4>& validUvRects) { }

}

