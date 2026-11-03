namespace UnityEngine.Rendering;

[Token(Token = "0x200014F")]
public sealed class LensFlareCommonSRP
{
	[CompilerGenerated]
	[Token(Token = "0x2000151")]
	private sealed class <>c__DisplayClass56_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000672")]
		public LensFlareComponentSRP newData; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B27")]
		public <>c__DisplayClass56_0() { }

		[Address(RVA = "0x2C39040", Offset = "0x2C38440", Length = "0x6B")]
		[Token(Token = "0x6000B28")]
		internal bool <AddData>b__0(LensFlareCompInfo x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000152")]
	private sealed class <>c__DisplayClass57_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000673")]
		public LensFlareComponentSRP data; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B29")]
		public <>c__DisplayClass57_0() { }

		[Address(RVA = "0x2C390B0", Offset = "0x2C384B0", Length = "0x6B")]
		[Token(Token = "0x6000B2A")]
		internal bool <RemoveData>b__0(LensFlareCompInfo x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000153")]
	private struct <>c__DisplayClass80_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000674")]
		public Vector2 screenPos; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000675")]
		public float position; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000676")]
		public float globalCos0; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000677")]
		public float globalSin0; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000678")]
		public LensFlareDataElementSRP element; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000679")]
		public float combinedScale; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400067A")]
		public float usedAspectRatio; //Field offset: 0x24

	}

	[Token(Token = "0x2000150")]
	public class LensFlareCompInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000670")]
		internal int index; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000671")]
		internal LensFlareComponentSRP comp; //Field offset: 0x18

		[Address(RVA = "0xF53D70", Offset = "0xF53170", Length = "0x40")]
		[Token(Token = "0x6000B26")]
		internal LensFlareCompInfo(int idx, LensFlareComponentSRP cmp) { }

	}

	[Token(Token = "0x4000647")]
	private static LensFlareCommonSRP m_Instance; //Field offset: 0x0
	[Token(Token = "0x4000648")]
	private static readonly object m_Padlock; //Field offset: 0x8
	[Token(Token = "0x4000649")]
	private static List<LensFlareCompInfo> m_Data; //Field offset: 0x10
	[Token(Token = "0x400064A")]
	private static List<Int32> m_AvailableIndicies; //Field offset: 0x18
	[Token(Token = "0x400064B")]
	public static int maxLensFlareWithOcclusion; //Field offset: 0x20
	[Token(Token = "0x400064C")]
	public static int maxLensFlareWithOcclusionTemporalSample; //Field offset: 0x24
	[Token(Token = "0x400064D")]
	public static int mergeNeeded; //Field offset: 0x28
	[Token(Token = "0x400064E")]
	public static RTHandle occlusionRT; //Field offset: 0x30
	[Token(Token = "0x400064F")]
	private static int frameIdx; //Field offset: 0x38
	[Token(Token = "0x4000650")]
	internal static readonly int _FlareOcclusionPermutation; //Field offset: 0x3C
	[Token(Token = "0x4000651")]
	internal static readonly int _FlareOcclusionRemapTex; //Field offset: 0x40
	[Token(Token = "0x4000652")]
	internal static readonly int _FlareOcclusionTex; //Field offset: 0x44
	[Token(Token = "0x4000653")]
	internal static readonly int _FlareOcclusionIndex; //Field offset: 0x48
	[Token(Token = "0x4000654")]
	internal static readonly int _FlareCloudOpacity; //Field offset: 0x4C
	[Token(Token = "0x4000655")]
	internal static readonly int _FlareSunOcclusionTex; //Field offset: 0x50
	[Token(Token = "0x4000656")]
	internal static readonly int _FlareTex; //Field offset: 0x54
	[Token(Token = "0x4000657")]
	internal static readonly int _FlareColorValue; //Field offset: 0x58
	[Token(Token = "0x4000658")]
	internal static readonly int _FlareData0; //Field offset: 0x5C
	[Token(Token = "0x4000659")]
	internal static readonly int _FlareData1; //Field offset: 0x60
	[Token(Token = "0x400065A")]
	internal static readonly int _FlareData2; //Field offset: 0x64
	[Token(Token = "0x400065B")]
	internal static readonly int _FlareData3; //Field offset: 0x68
	[Token(Token = "0x400065C")]
	internal static readonly int _FlareData4; //Field offset: 0x6C
	[Token(Token = "0x400065D")]
	internal static readonly int _FlareData5; //Field offset: 0x70
	[Token(Token = "0x400065E")]
	internal static readonly int _FlareData6; //Field offset: 0x74
	[Token(Token = "0x400065F")]
	internal static readonly int _FlareRadialTint; //Field offset: 0x78
	[Token(Token = "0x4000660")]
	internal static readonly int _ViewId; //Field offset: 0x7C
	[Token(Token = "0x4000661")]
	internal static readonly int _LensFlareScreenSpaceBloomMipTexture; //Field offset: 0x80
	[Token(Token = "0x4000662")]
	internal static readonly int _LensFlareScreenSpaceResultTexture; //Field offset: 0x84
	[Token(Token = "0x4000663")]
	internal static readonly int _LensFlareScreenSpaceSpectralLut; //Field offset: 0x88
	[Token(Token = "0x4000664")]
	internal static readonly int _LensFlareScreenSpaceStreakTex; //Field offset: 0x8C
	[Token(Token = "0x4000665")]
	internal static readonly int _LensFlareScreenSpaceMipLevel; //Field offset: 0x90
	[Token(Token = "0x4000666")]
	internal static readonly int _LensFlareScreenSpaceTintColor; //Field offset: 0x94
	[Token(Token = "0x4000667")]
	internal static readonly int _LensFlareScreenSpaceParams1; //Field offset: 0x98
	[Token(Token = "0x4000668")]
	internal static readonly int _LensFlareScreenSpaceParams2; //Field offset: 0x9C
	[Token(Token = "0x4000669")]
	internal static readonly int _LensFlareScreenSpaceParams3; //Field offset: 0xA0
	[Token(Token = "0x400066A")]
	internal static readonly int _LensFlareScreenSpaceParams4; //Field offset: 0xA4
	[Token(Token = "0x400066B")]
	internal static readonly int _LensFlareScreenSpaceParams5; //Field offset: 0xA8
	[Token(Token = "0x400066C")]
	private static readonly bool s_SupportsLensFlare16bitsFormat; //Field offset: 0xAC
	[Token(Token = "0x400066D")]
	private static readonly bool s_SupportsLensFlare32bitsFormat; //Field offset: 0xAD
	[Token(Token = "0x400066E")]
	private static readonly bool s_SupportsLensFlare16bitsFormatWithLoadStore; //Field offset: 0xAE
	[Token(Token = "0x400066F")]
	private static readonly bool s_SupportsLensFlare32bitsFormatWithLoadStore; //Field offset: 0xAF

	[Token(Token = "0x17000144")]
	private List<LensFlareCompInfo> Data
	{
		[Address(RVA = "0x2C2DCB0", Offset = "0x2C2D0B0", Length = "0x4F")]
		[Token(Token = "0x6000AFB")]
		private get { } //Length: 79
	}

	[Token(Token = "0x17000143")]
	public static LensFlareCommonSRP Instance
	{
		[Address(RVA = "0x2C2DD00", Offset = "0x2C2D100", Length = "0x196")]
		[Token(Token = "0x6000AFA")]
		 get { } //Length: 406
	}

	[Token(Token = "0x17000142")]
	private static bool requireOcclusionRTRandomWrite
	{
		[Address(RVA = "0x2C2DEA0", Offset = "0x2C2D2A0", Length = "0x52")]
		[Token(Token = "0x6000AF4")]
		private get { } //Length: 82
	}

	[Address(RVA = "0x2C2D550", Offset = "0x2C2C950", Length = "0x75E")]
	[Token(Token = "0x6000B20")]
	private static LensFlareCommonSRP() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000AF3")]
	private LensFlareCommonSRP() { }

	[Address(RVA = "0x2C2C780", Offset = "0x2C2BB80", Length = "0x231")]
	[CompilerGenerated]
	[Token(Token = "0x6000B24")]
	internal static Vector2 <ProcessLensFlareSRPElementsSingle>g__ComputeLocalSize|80_0(Vector2 rayOff, Vector2 rayOff0, Vector2 curSize, AnimationCurve distortionCurve, ref <>c__DisplayClass80_0 unnamed_param_4) { }

	[Address(RVA = "0x2C2C9C0", Offset = "0x2C2BDC0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000B25")]
	internal static float <ProcessLensFlareSRPElementsSingle>g__RandomRange|80_1(float min, float max) { }

	[Address(RVA = "0x2C2C9D0", Offset = "0x2C2BDD0", Length = "0x430")]
	[CompilerGenerated]
	[Token(Token = "0x6000B23")]
	internal static float <ShapeAttenuationAreaTubeLight>g__DiffLineIntegral|63_2(Vector3 p1, Vector3 p2) { }

	[Address(RVA = "0x2C2CE00", Offset = "0x2C2C200", Length = "0x58")]
	[CompilerGenerated]
	[Token(Token = "0x6000B21")]
	internal static float <ShapeAttenuationAreaTubeLight>g__Fpo|63_0(float d, float l) { }

	[Address(RVA = "0x2C2CE60", Offset = "0x2C2C260", Length = "0x1B")]
	[CompilerGenerated]
	[Token(Token = "0x6000B22")]
	internal static float <ShapeAttenuationAreaTubeLight>g__Fwt|63_1(float d, float l) { }

	[Address(RVA = "0x2C24B20", Offset = "0x2C23F20", Length = "0x312")]
	[Token(Token = "0x6000AFE")]
	public void AddData(LensFlareComponentSRP newData) { }

	[Address(RVA = "0x2C24E40", Offset = "0x2C24240", Length = "0x11A")]
	[Token(Token = "0x6000B1E")]
	private static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d) { }

	[Address(RVA = "0x2C24F60", Offset = "0x2C24360", Length = "0x4B")]
	[Token(Token = "0x6000B1D")]
	private static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView) { }

	[Address(RVA = "0x2C24FB0", Offset = "0x2C243B0", Length = "0x41")]
	[Token(Token = "0x6000AF5")]
	private static bool CheckOcclusionBasedOnDeviceType() { }

	[Address(RVA = "0x2C25000", Offset = "0x2C24400", Length = "0xB63")]
	[Token(Token = "0x6000B15")]
	public static void ComputeOcclusion(Material lensFlareShader, Camera cam, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture) { }

	[Address(RVA = "0x2C25B70", Offset = "0x2C24F70", Length = "0x1B4")]
	[Token(Token = "0x6000B11")]
	public static void ComputeOcclusion(Material lensFlareShader, Camera cam, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture) { }

	[Address(RVA = "0x2C25D30", Offset = "0x2C25130", Length = "0x104")]
	[Token(Token = "0x6000AF9")]
	public static void Dispose() { }

	[Address(RVA = "0x2C25E40", Offset = "0x2C25240", Length = "0xC31")]
	[Token(Token = "0x6000B14")]
	private static bool DoComponent(bool occlusionOnly, LensFlareCompInfo info, Camera cam, Vector3 cameraPositionWS, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Matrix4x4 viewProjMatrix, CommandBuffer cmd, out Vector3 flarePosWS, out Vector3 flarePosViewport, out Vector2 flarePosScreen, out Vector3 camToFlare, out Light light, out bool isDirLight, out float flareIntensity, out float distanceAttenuation) { }

	[Address(RVA = "0x2C26CB0", Offset = "0x2C260B0", Length = "0xA29")]
	[Token(Token = "0x6000B19")]
	public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, Rect viewport, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, Single> GetLensFlareLightAttenuation, bool debugView) { }

	[Address(RVA = "0x2C26A80", Offset = "0x2C25E80", Length = "0x22E")]
	[Token(Token = "0x6000B18")]
	public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, Rect viewport, XRPass xr, int xrIndex, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, UnsafeCommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, Single> GetLensFlareLightAttenuation, bool debugView) { }

	[Address(RVA = "0x2C278C0", Offset = "0x2C26CC0", Length = "0xB08")]
	[Token(Token = "0x6000B1B")]
	public static void DoLensFlareScreenSpaceCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, Color tintColor, Texture originalBloomTexture, Texture bloomMipTexture, Texture spectralLut, Texture streakTextureTmp, Texture streakTextureTmp2, Vector4 parameters1, Vector4 parameters2, Vector4 parameters3, Vector4 parameters4, Vector4 parameters5, CommandBuffer cmd, RTHandle result, bool debugView) { }

	[Address(RVA = "0x2C276E0", Offset = "0x2C26AE0", Length = "0x1DB")]
	[Token(Token = "0x6000B1A")]
	public static void DoLensFlareScreenSpaceCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, Color tintColor, Texture originalBloomTexture, Texture bloomMipTexture, Texture spectralLut, Texture streakTextureTmp, Texture streakTextureTmp2, Vector4 parameters1, Vector4 parameters2, Vector4 parameters3, Vector4 parameters4, Vector4 parameters5, UnsafeCommandBuffer cmd, RTHandle result, bool debugView) { }

	[Address(RVA = "0x2C283D0", Offset = "0x2C277D0", Length = "0x297")]
	[Token(Token = "0x6000B1C")]
	private static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance) { }

	[Address(RVA = "0x2C28670", Offset = "0x2C27A70", Length = "0x30")]
	[Token(Token = "0x6000B12")]
	private static bool ForceSingleElement(LensFlareDataElementSRP element) { }

	[Address(RVA = "0x2C2DCB0", Offset = "0x2C2D0B0", Length = "0x4F")]
	[Token(Token = "0x6000AFB")]
	private List<LensFlareCompInfo> get_Data() { }

	[Address(RVA = "0x2C2DD00", Offset = "0x2C2D100", Length = "0x196")]
	[Token(Token = "0x6000AFA")]
	public static LensFlareCommonSRP get_Instance() { }

	[Address(RVA = "0x2C2DEA0", Offset = "0x2C2D2A0", Length = "0x52")]
	[Token(Token = "0x6000AF4")]
	private static bool get_requireOcclusionRTRandomWrite() { }

	[Address(RVA = "0x2C286B0", Offset = "0x2C27AB0", Length = "0xFC")]
	[Obsolete("This is now deprecated as a public API. Call ComputeOcclusion() or DoLensFlareDataDrivenCommon() instead. #from(6000.3)")]
	[Token(Token = "0x6000B0B")]
	public static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate) { }

	[Address(RVA = "0x2C287B0", Offset = "0x2C27BB0", Length = "0x6F")]
	[Token(Token = "0x6000B0C")]
	private static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0) { }

	[Address(RVA = "0x2C28820", Offset = "0x2C27C20", Length = "0x13A")]
	[Token(Token = "0x6000AFD")]
	private int GetNextAvailableIndex() { }

	[Address(RVA = "0x2C28960", Offset = "0x2C27D60", Length = "0xEF")]
	[Token(Token = "0x6000AF7")]
	private static GraphicsFormat GetOcclusionRTFormat() { }

	[Address(RVA = "0x2C28A50", Offset = "0x2C27E50", Length = "0x3A3")]
	[Token(Token = "0x6000AF8")]
	public static void Initialize() { }

	[Address(RVA = "0x2C28E00", Offset = "0x2C28200", Length = "0x21F")]
	[Token(Token = "0x6000B0A")]
	private static Vector4 InternalGetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate) { }

	[Address(RVA = "0x2C29020", Offset = "0x2C28420", Length = "0x276")]
	[Token(Token = "0x6000B10")]
	public static bool IsCloudLayerOpacityNeeded(Camera cam) { }

	[Address(RVA = "0x2C292A0", Offset = "0x2C286A0", Length = "0x7C")]
	[Token(Token = "0x6000AFC")]
	public bool IsEmpty() { }

	[Address(RVA = "0x2C29320", Offset = "0x2C28720", Length = "0x139")]
	[Token(Token = "0x6000B09")]
	private static bool IsLensFlareSRPHidden(Camera cam, LensFlareComponentSRP comp, LensFlareDataSRP data) { }

	[Address(RVA = "0x2C29460", Offset = "0x2C28860", Length = "0x1CB")]
	[Token(Token = "0x6000AF6")]
	public static bool IsOcclusionRTCompatible() { }

	[Address(RVA = "0x2C29630", Offset = "0x2C28A30", Length = "0x8C")]
	[Token(Token = "0x6000B1F")]
	private static Vector2 Panini_Generic_Inv(Vector2 projPos, float d) { }

	[Address(RVA = "0x2C296C0", Offset = "0x2C28AC0", Length = "0x267")]
	[Token(Token = "0x6000B13")]
	private static bool PreDrawSetup(bool occlusionOnly, bool clearRenderTarget, RenderTargetIdentifier rt, Camera cam, XRPass xr, int xrIndex, CommandBuffer cmd) { }

	[Address(RVA = "0x2C2BAD0", Offset = "0x2C2AED0", Length = "0x25E")]
	[Token(Token = "0x6000B17")]
	private static void ProcessLensFlareSRPElements(ref LensFlareDataElementSRP[] elements, CommandBuffer cmd, Color globalColorModulation, Light light, float compIntensity, float scale, Material lensFlareShader, Vector2 screenPos, bool compAllowOffScreen, float aspect, Vector4 flareData6, bool preview, int depth) { }

	[Address(RVA = "0x2C29930", Offset = "0x2C28D30", Length = "0x2194")]
	[Token(Token = "0x6000B16")]
	public static void ProcessLensFlareSRPElementsSingle(LensFlareDataElementSRP element, CommandBuffer cmd, Color globalColorModulation, Light light, float compIntensity, float scale, Material lensFlareShader, Vector2 screenPos, bool compAllowOffScreen, Vector2 vScreenRatio, Vector3 flareData1, bool preview, int depth) { }

	[Address(RVA = "0x2C2BD30", Offset = "0x2C2B130", Length = "0x24B")]
	[Token(Token = "0x6000AFF")]
	public void RemoveData(LensFlareComponentSRP data) { }

	[Address(RVA = "0x2C2BF80", Offset = "0x2C2B380", Length = "0x43")]
	[Token(Token = "0x6000B06")]
	private static float ShapeAttenuateForwardLight(Vector3 forward, Vector3 wo) { }

	[Address(RVA = "0x2C2BFD0", Offset = "0x2C2B3D0", Length = "0x86")]
	[Token(Token = "0x6000B08")]
	public static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo) { }

	[Address(RVA = "0x2C2C060", Offset = "0x2C2B460", Length = "0x86")]
	[Token(Token = "0x6000B07")]
	public static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo) { }

	[Address(RVA = "0x2C2C0F0", Offset = "0x2C2B4F0", Length = "0x3FB")]
	[Token(Token = "0x6000B05")]
	public static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam) { }

	[Address(RVA = "0x2C2C4F0", Offset = "0x2C2B8F0", Length = "0x54")]
	[Token(Token = "0x6000B01")]
	public static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo) { }

	[Address(RVA = "0x21D6EB0", Offset = "0x21D62B0", Length = "0x9")]
	[Token(Token = "0x6000B00")]
	public static float ShapeAttenuationPointLight() { }

	[Address(RVA = "0x2C2C550", Offset = "0x2C2B950", Length = "0x5E")]
	[Token(Token = "0x6000B03")]
	public static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo) { }

	[Address(RVA = "0x2C2C5B0", Offset = "0x2C2B9B0", Length = "0x113")]
	[Token(Token = "0x6000B02")]
	public static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01) { }

	[Address(RVA = "0x2C2C6D0", Offset = "0x2C2BAD0", Length = "0xA7")]
	[Token(Token = "0x6000B04")]
	public static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo) { }

	[Address(RVA = "0x2C2D3B0", Offset = "0x2C2C7B0", Length = "0x196")]
	[Token(Token = "0x6000B0D")]
	private static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS) { }

	[Address(RVA = "0x2C2CE80", Offset = "0x2C2C280", Length = "0x316")]
	[Token(Token = "0x6000B0F")]
	private static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS) { }

	[Address(RVA = "0x2C2D1A0", Offset = "0x2C2C5A0", Length = "0x203")]
	[Token(Token = "0x6000B0E")]
	private static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS) { }

}

