namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200011D")]
internal struct AdditionalLightsShadowAtlasLayout
{
	[CompilerGenerated]
	[Token(Token = "0x2000120")]
	private sealed class <>c
	{
		[Token(Token = "0x400064D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400064E")]
		public static Func<ShadowResolutionRequest, ShadowResolutionRequest, Int32> <>9__24_0; //Field offset: 0x8

		[Address(RVA = "0x2DC8D70", Offset = "0x2DC8170", Length = "0x67")]
		[Token(Token = "0x6000704")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000705")]
		public <>c() { }

		[Address(RVA = "0x2DC7DF0", Offset = "0x2DC71F0", Length = "0x1AD")]
		[Token(Token = "0x6000706")]
		internal int <CreateCompareShadowResolutionRequesPredicate>b__24_0(ShadowResolutionRequest curr, ShadowResolutionRequest other) { }

	}

	[Token(Token = "0x200011E")]
	public struct ShadowResolutionRequest
	{
		[Flags]
		[Token(Token = "0x200011F")]
		private enum SettingsOptions : ushort
		{
			None = 0,
			SoftShadow = 1,
			PointLightShadow = 2,
			All = 65535,
		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000641")]
		public ushort visibleLightIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x4000642")]
		public ushort perLightShadowSliceIndex; //Field offset: 0x2
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000643")]
		public ushort requestedResolution; //Field offset: 0x4
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x4000644")]
		public ushort offsetX; //Field offset: 0x6
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000645")]
		public ushort offsetY; //Field offset: 0x8
		[FieldOffset(Offset = "0xA")]
		[Token(Token = "0x4000646")]
		public ushort allocatedResolution; //Field offset: 0xA
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000647")]
		private SettingsOptions m_ShadowProperties; //Field offset: 0xC

		[Token(Token = "0x170001D9")]
		public bool pointLightShadow
		{
			[Address(RVA = "0x2DC64C0", Offset = "0x2DC58C0", Length = "0x9")]
			[Token(Token = "0x6000702")]
			 get { } //Length: 9
			[Address(RVA = "0x2DC64E0", Offset = "0x2DC58E0", Length = "0x24")]
			[Token(Token = "0x6000703")]
			 set { } //Length: 36
		}

		[Token(Token = "0x170001D8")]
		public bool softShadow
		{
			[Address(RVA = "0x2DC64D0", Offset = "0x2DC58D0", Length = "0x7")]
			[Token(Token = "0x6000700")]
			 get { } //Length: 7
			[Address(RVA = "0x2DC6510", Offset = "0x2DC5910", Length = "0x24")]
			[Token(Token = "0x6000701")]
			 set { } //Length: 36
		}

		[Address(RVA = "0x2DC64C0", Offset = "0x2DC58C0", Length = "0x9")]
		[Token(Token = "0x6000702")]
		public bool get_pointLightShadow() { }

		[Address(RVA = "0x2DC64D0", Offset = "0x2DC58D0", Length = "0x7")]
		[Token(Token = "0x6000700")]
		public bool get_softShadow() { }

		[Address(RVA = "0x2DC64E0", Offset = "0x2DC58E0", Length = "0x24")]
		[Token(Token = "0x6000703")]
		public void set_pointLightShadow(bool value) { }

		[Address(RVA = "0x2DC6510", Offset = "0x2DC5910", Length = "0x24")]
		[Token(Token = "0x6000701")]
		public void set_softShadow(bool value) { }

	}

	[Token(Token = "0x4000635")]
	private static List<RectInt> s_UnusedAtlasSquareAreas; //Field offset: 0x0
	[Token(Token = "0x4000636")]
	private static List<ShadowResolutionRequest> s_ShadowResolutionRequests; //Field offset: 0x8
	[Token(Token = "0x4000637")]
	private static Single[] s_VisibleLightIndexToCameraSquareDistance; //Field offset: 0x10
	[Token(Token = "0x4000638")]
	private static Func<ShadowResolutionRequest, ShadowResolutionRequest, Int32> s_CompareShadowResolutionRequest; //Field offset: 0x18
	[Token(Token = "0x4000639")]
	private static ShadowResolutionRequest[] s_SortedShadowResolutionRequests; //Field offset: 0x20
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400063A")]
	private NativeArray<ShadowResolutionRequest> m_SortedShadowResolutionRequests; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400063B")]
	private NativeArray<Int32> m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400063C")]
	private int m_TotalShadowSlicesCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400063D")]
	private int m_TotalShadowResolutionRequestCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400063E")]
	private bool m_TooManyShadowMaps; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400063F")]
	private int m_ShadowSlicesScaleFactor; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000640")]
	private int m_AtlasSize; //Field offset: 0x30

	[Address(RVA = "0x2DA6D40", Offset = "0x2DA6140", Length = "0x1204")]
	[Token(Token = "0x60006F4")]
	public AdditionalLightsShadowAtlasLayout(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2DA6A40", Offset = "0x2DA5E40", Length = "0xFB")]
	[Token(Token = "0x60006FD")]
	public static void ClearStaticCaches() { }

	[Address(RVA = "0x2DA6B40", Offset = "0x2DA5F40", Length = "0xF2")]
	[Token(Token = "0x60006FF")]
	private static Func<ShadowResolutionRequest, ShadowResolutionRequest, Int32> CreateCompareShadowResolutionRequesPredicate() { }

	[Address(RVA = "0x2DA6C40", Offset = "0x2DA6040", Length = "0x77")]
	[Token(Token = "0x60006FE")]
	private static int EstimateScaleFactorNeededToFitAllShadowsInAtlas(in NativeArray<ShadowResolutionRequest>& shadowResolutionRequests, int endIndex, int atlasSize) { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60006F9")]
	public int GetAtlasSize() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x60006F8")]
	public int GetShadowSlicesScaleFactor() { }

	[Address(RVA = "0x2DA6CC0", Offset = "0x2DA60C0", Length = "0x37")]
	[Token(Token = "0x60006FC")]
	public ShadowResolutionRequest GetSliceShadowResolutionRequest(int originalVisibleLightIndex, int sliceIndex) { }

	[Address(RVA = "0x2DA6D00", Offset = "0x2DA6100", Length = "0x2A")]
	[Token(Token = "0x60006FB")]
	public ShadowResolutionRequest GetSortedShadowResolutionRequest(int sortedShadowResolutionRequestIndex) { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x60006F6")]
	public int GetTotalShadowResolutionRequestCount() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60006F5")]
	public int GetTotalShadowSlicesCount() { }

	[Address(RVA = "0x2DA6D30", Offset = "0x2DA6130", Length = "0xF")]
	[Token(Token = "0x60006FA")]
	public bool HasSpaceForLight(int originalVisibleLightIndex) { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x60006F7")]
	public bool HasTooManyShadowMaps() { }

}

