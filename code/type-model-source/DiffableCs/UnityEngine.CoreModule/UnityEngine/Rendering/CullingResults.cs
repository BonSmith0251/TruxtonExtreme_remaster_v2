namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableCulling.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeHeader("Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
[Token(Token = "0x20003D3")]
public struct CullingResults : IEquatable<CullingResults>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C6E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.VFXModule"})]
	internal IntPtr ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C6F")]
	private CullingAllocationInfo* m_AllocationInfo; //Field offset: 0x8

	[Token(Token = "0x1700041D")]
	public int lightAndReflectionProbeIndexCount
	{
		[Address(RVA = "0x30BD5E0", Offset = "0x30BC9E0", Length = "0x6A")]
		[Token(Token = "0x6001D87")]
		 get { } //Length: 106
	}

	[Token(Token = "0x1700041B")]
	public NativeArray<VisibleLight> visibleLights
	{
		[Address(RVA = "0x30BD650", Offset = "0x30BCA50", Length = "0x70")]
		[Token(Token = "0x6001D84")]
		 get { } //Length: 112
	}

	[Token(Token = "0x1700041C")]
	public NativeArray<VisibleReflectionProbe> visibleReflectionProbes
	{
		[Address(RVA = "0x30BD6D0", Offset = "0x30BCAD0", Length = "0x71")]
		[Token(Token = "0x6001D85")]
		 get { } //Length: 113
	}

	[Address(RVA = "0x30BCCA0", Offset = "0x30BC0A0", Length = "0xC7")]
	[Token(Token = "0x6001D8E")]
	public bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[Address(RVA = "0x30BCD70", Offset = "0x30BC170", Length = "0xB2")]
	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputeDirectionalShadowMatricesAndCullingPrimitives")]
	[Token(Token = "0x6001D83")]
	private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[Address(RVA = "0x30BCC30", Offset = "0x30BC030", Length = "0x63")]
	[Token(Token = "0x6001D94")]
	private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, in Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[Address(RVA = "0x30BCE30", Offset = "0x30BC230", Length = "0x60")]
	[Token(Token = "0x6001D8D")]
	public bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[Address(RVA = "0x30BCE90", Offset = "0x30BC290", Length = "0x60")]
	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputePointShadowMatricesAndCullingPrimitives")]
	[Token(Token = "0x6001D82")]
	private static bool ComputePointShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[Address(RVA = "0x30BCEF0", Offset = "0x30BC2F0", Length = "0x60")]
	[FreeFunction("ScriptableRenderPipeline_Bindings::ComputeSpotShadowMatricesAndCullingPrimitives")]
	[Token(Token = "0x6001D81")]
	private static bool ComputeSpotShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[Address(RVA = "0x30BCF50", Offset = "0x30BC350", Length = "0x60")]
	[Token(Token = "0x6001D8C")]
	public bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[Address(RVA = "0x30BCFB0", Offset = "0x30BC3B0", Length = "0xDA")]
	[Token(Token = "0x6001D90")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30BD090", Offset = "0x30BC490", Length = "0x61")]
	[Token(Token = "0x6001D8F")]
	public override bool Equals(CullingResults other) { }

	[Address(RVA = "0x30BD1A0", Offset = "0x30BC5A0", Length = "0x4C")]
	[FreeFunction("FillLightAndReflectionProbeIndices")]
	[Token(Token = "0x6001D7C")]
	private static void FillLightAndReflectionProbeIndices(IntPtr cullingResultsPtr, ComputeBuffer computeBuffer) { }

	[Address(RVA = "0x30BD150", Offset = "0x30BC550", Length = "0x4C")]
	[Token(Token = "0x6001D88")]
	public void FillLightAndReflectionProbeIndices(ComputeBuffer computeBuffer) { }

	[Address(RVA = "0x30BD100", Offset = "0x30BC500", Length = "0x42")]
	[Token(Token = "0x6001D93")]
	private static void FillLightAndReflectionProbeIndices_Injected(IntPtr cullingResultsPtr, IntPtr computeBuffer) { }

	[Address(RVA = "0x30BD1F0", Offset = "0x30BC5F0", Length = "0x52")]
	[FreeFunction("FillLightIndexMapScriptable")]
	[Token(Token = "0x6001D7E")]
	private static void FillLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize) { }

	[Address(RVA = "0x30BD5E0", Offset = "0x30BC9E0", Length = "0x6A")]
	[Token(Token = "0x6001D87")]
	public int get_lightAndReflectionProbeIndexCount() { }

	[Address(RVA = "0x30BD650", Offset = "0x30BCA50", Length = "0x70")]
	[Token(Token = "0x6001D84")]
	public NativeArray<VisibleLight> get_visibleLights() { }

	[Address(RVA = "0x30BD6D0", Offset = "0x30BCAD0", Length = "0x71")]
	[Token(Token = "0x6001D85")]
	public NativeArray<VisibleReflectionProbe> get_visibleReflectionProbes() { }

	[Address(RVA = "0x30BD250", Offset = "0x30BC650", Length = "0x1F")]
	[Token(Token = "0x6001D91")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30BD270", Offset = "0x30BC670", Length = "0x33")]
	[FreeFunction("ScriptableRenderPipeline_Bindings::GetLightIndexCount")]
	[Token(Token = "0x6001D7A")]
	private static int GetLightIndexCount(IntPtr cullingResultsPtr) { }

	[Address(RVA = "0x30BD2F0", Offset = "0x30BC6F0", Length = "0x110")]
	[Token(Token = "0x6001D89")]
	public NativeArray<Int32> GetLightIndexMap(Allocator allocator) { }

	[Address(RVA = "0x30BD2B0", Offset = "0x30BC6B0", Length = "0x33")]
	[FreeFunction("GetLightIndexMapSize")]
	[Token(Token = "0x6001D7D")]
	private static int GetLightIndexMapSize(IntPtr cullingResultsPtr) { }

	[Address(RVA = "0x7B9900", Offset = "0x7B8D00", Length = "0x76")]
	[Token(Token = "0x6001D86")]
	private NativeArray<T> GetNativeArray(Void* dataPointer, int length) { }

	[Address(RVA = "0x30BD400", Offset = "0x30BC800", Length = "0x33")]
	[FreeFunction("ScriptableRenderPipeline_Bindings::GetReflectionProbeIndexCount")]
	[Token(Token = "0x6001D7B")]
	private static int GetReflectionProbeIndexCount(IntPtr cullingResultsPtr) { }

	[Address(RVA = "0x30BD440", Offset = "0x30BC840", Length = "0x50")]
	[Token(Token = "0x6001D8B")]
	public bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds) { }

	[Address(RVA = "0x30BD490", Offset = "0x30BC890", Length = "0x50")]
	[FreeFunction("ScriptableRenderPipeline_Bindings::GetShadowCasterBounds")]
	[Token(Token = "0x6001D80")]
	private static bool GetShadowCasterBounds(IntPtr cullingResultsPtr, int lightIndex, out Bounds bounds) { }

	[Address(RVA = "0x30BD750", Offset = "0x30BCB50", Length = "0x62")]
	[Token(Token = "0x6001D92")]
	public static bool op_Equality(CullingResults left, CullingResults right) { }

	[Address(RVA = "0x30BD4E0", Offset = "0x30BC8E0", Length = "0x95")]
	[Token(Token = "0x6001D8A")]
	public void SetLightIndexMap(NativeArray<Int32> lightIndexMap) { }

	[Address(RVA = "0x30BD580", Offset = "0x30BC980", Length = "0x52")]
	[FreeFunction("SetLightIndexMapScriptable")]
	[Token(Token = "0x6001D7F")]
	private static void SetLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize) { }

}

