namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000126")]
public class SkinnedMeshRenderer : Renderer
{

	[Token(Token = "0x170001CD")]
	public Transform[] bones
	{
		[Address(RVA = "0x303A810", Offset = "0x3039C10", Length = "0x76")]
		[Token(Token = "0x6000AF4")]
		 get { } //Length: 118
		[Address(RVA = "0x303AE60", Offset = "0x303A260", Length = "0x85")]
		[Token(Token = "0x6000AF5")]
		 set { } //Length: 133
	}

	[Token(Token = "0x170001CB")]
	public bool forceMatrixRecalculationPerRender
	{
		[Address(RVA = "0x303A8D0", Offset = "0x3039CD0", Length = "0x76")]
		[Token(Token = "0x6000AF0")]
		 get { } //Length: 118
		[Address(RVA = "0x303AF40", Offset = "0x303A340", Length = "0x86")]
		[Token(Token = "0x6000AF1")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170001C9")]
	public SkinQuality quality
	{
		[Address(RVA = "0x303A990", Offset = "0x3039D90", Length = "0x76")]
		[Token(Token = "0x6000AEC")]
		 get { } //Length: 118
		[Address(RVA = "0x303B010", Offset = "0x303A410", Length = "0x83")]
		[Token(Token = "0x6000AED")]
		 set { } //Length: 131
	}

	[Token(Token = "0x170001CC")]
	public Transform rootBone
	{
		[Address(RVA = "0x303AA50", Offset = "0x3039E50", Length = "0x90")]
		[Token(Token = "0x6000AF2")]
		 get { } //Length: 144
		[Address(RVA = "0x303B0F0", Offset = "0x303A4F0", Length = "0xBA")]
		[Token(Token = "0x6000AF3")]
		 set { } //Length: 186
	}

	[NativeProperty("Mesh")]
	[Token(Token = "0x170001CE")]
	public Mesh sharedMesh
	{
		[Address(RVA = "0x303AB30", Offset = "0x3039F30", Length = "0x90")]
		[Token(Token = "0x6000AF6")]
		 get { } //Length: 144
		[Address(RVA = "0x303B200", Offset = "0x303A600", Length = "0xBA")]
		[Token(Token = "0x6000AF7")]
		 set { } //Length: 186
	}

	[NativeProperty("SkinnedMeshMotionVectors")]
	[Token(Token = "0x170001CF")]
	public bool skinnedMotionVectors
	{
		[Address(RVA = "0x303AC10", Offset = "0x303A010", Length = "0x76")]
		[Token(Token = "0x6000AF8")]
		 get { } //Length: 118
		[Address(RVA = "0x303B310", Offset = "0x303A710", Length = "0x86")]
		[Token(Token = "0x6000AF9")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170001CA")]
	public bool updateWhenOffscreen
	{
		[Address(RVA = "0x303ACD0", Offset = "0x303A0D0", Length = "0x76")]
		[Token(Token = "0x6000AEE")]
		 get { } //Length: 118
		[Address(RVA = "0x303B3F0", Offset = "0x303A7F0", Length = "0x86")]
		[Token(Token = "0x6000AEF")]
		 set { } //Length: 134
	}

	[Token(Token = "0x170001D0")]
	public Target vertexBufferTarget
	{
		[Address(RVA = "0x303AD90", Offset = "0x303A190", Length = "0x76")]
		[Token(Token = "0x6000B02")]
		 get { } //Length: 118
		[Address(RVA = "0x303B4C0", Offset = "0x303A8C0", Length = "0x83")]
		[Token(Token = "0x6000B03")]
		 set { } //Length: 131
	}

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x6000B08")]
	public SkinnedMeshRenderer() { }

	[Address(RVA = "0x3039F90", Offset = "0x3039390", Length = "0xE5")]
	[Token(Token = "0x6000AFD")]
	public void BakeMesh(Mesh mesh, bool useScale) { }

	[Address(RVA = "0x3039EB0", Offset = "0x30392B0", Length = "0xD6")]
	[Token(Token = "0x6000AFC")]
	public void BakeMesh(Mesh mesh) { }

	[Address(RVA = "0x3039E50", Offset = "0x3039250", Length = "0x54")]
	[Token(Token = "0x6000B19")]
	private static void BakeMesh_Injected(IntPtr _unity_self, IntPtr mesh, bool useScale) { }

	[Address(RVA = "0x303A810", Offset = "0x3039C10", Length = "0x76")]
	[Token(Token = "0x6000AF4")]
	public Transform[] get_bones() { }

	[Address(RVA = "0x303A7D0", Offset = "0x3039BD0", Length = "0x33")]
	[Token(Token = "0x6000B11")]
	private static Transform[] get_bones_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303A8D0", Offset = "0x3039CD0", Length = "0x76")]
	[Token(Token = "0x6000AF0")]
	public bool get_forceMatrixRecalculationPerRender() { }

	[Address(RVA = "0x303A890", Offset = "0x3039C90", Length = "0x33")]
	[Token(Token = "0x6000B0D")]
	private static bool get_forceMatrixRecalculationPerRender_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303A990", Offset = "0x3039D90", Length = "0x76")]
	[Token(Token = "0x6000AEC")]
	public SkinQuality get_quality() { }

	[Address(RVA = "0x303A950", Offset = "0x3039D50", Length = "0x33")]
	[Token(Token = "0x6000B09")]
	private static SkinQuality get_quality_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303AA50", Offset = "0x3039E50", Length = "0x90")]
	[Token(Token = "0x6000AF2")]
	public Transform get_rootBone() { }

	[Address(RVA = "0x303AA10", Offset = "0x3039E10", Length = "0x33")]
	[Token(Token = "0x6000B0F")]
	private static IntPtr get_rootBone_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303AB30", Offset = "0x3039F30", Length = "0x90")]
	[Token(Token = "0x6000AF6")]
	public Mesh get_sharedMesh() { }

	[Address(RVA = "0x303AAF0", Offset = "0x3039EF0", Length = "0x33")]
	[Token(Token = "0x6000B13")]
	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303AC10", Offset = "0x303A010", Length = "0x76")]
	[Token(Token = "0x6000AF8")]
	public bool get_skinnedMotionVectors() { }

	[Address(RVA = "0x303ABD0", Offset = "0x3039FD0", Length = "0x33")]
	[Token(Token = "0x6000B15")]
	private static bool get_skinnedMotionVectors_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303ACD0", Offset = "0x303A0D0", Length = "0x76")]
	[Token(Token = "0x6000AEE")]
	public bool get_updateWhenOffscreen() { }

	[Address(RVA = "0x303AC90", Offset = "0x303A090", Length = "0x33")]
	[Token(Token = "0x6000B0B")]
	private static bool get_updateWhenOffscreen_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303AD90", Offset = "0x303A190", Length = "0x76")]
	[Token(Token = "0x6000B02")]
	public Target get_vertexBufferTarget() { }

	[Address(RVA = "0x303AD50", Offset = "0x303A150", Length = "0x33")]
	[Token(Token = "0x6000B1C")]
	private static Target get_vertexBufferTarget_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303A0C0", Offset = "0x30394C0", Length = "0x83")]
	[Token(Token = "0x6000AFA")]
	public float GetBlendShapeWeight(int index) { }

	[Address(RVA = "0x303A080", Offset = "0x3039480", Length = "0x40")]
	[Token(Token = "0x6000B17")]
	private static float GetBlendShapeWeight_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x303A230", Offset = "0x3039630", Length = "0x11B")]
	[Token(Token = "0x6000AFF")]
	public GraphicsBuffer GetPreviousVertexBuffer() { }

	[Address(RVA = "0x303A190", Offset = "0x3039590", Length = "0x99")]
	[FreeFunction(Name = "SkinnedMeshRendererScripting::GetPreviousVertexBufferPtr", HasExplicitThis = True)]
	[Token(Token = "0x6000B01")]
	private GraphicsBuffer GetPreviousVertexBufferImpl() { }

	[Address(RVA = "0x303A150", Offset = "0x3039550", Length = "0x33")]
	[Token(Token = "0x6000B1B")]
	private static IntPtr GetPreviousVertexBufferImpl_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303A350", Offset = "0x3039750", Length = "0x76")]
	[Token(Token = "0x6000B07")]
	public uint GetShaderUserValue() { }

	[Address(RVA = "0x303A4B0", Offset = "0x30398B0", Length = "0x11B")]
	[Token(Token = "0x6000AFE")]
	public GraphicsBuffer GetVertexBuffer() { }

	[Address(RVA = "0x303A410", Offset = "0x3039810", Length = "0x99")]
	[FreeFunction(Name = "SkinnedMeshRendererScripting::GetVertexBufferPtr", HasExplicitThis = True)]
	[Token(Token = "0x6000B00")]
	private GraphicsBuffer GetVertexBufferImpl() { }

	[Address(RVA = "0x303A3D0", Offset = "0x30397D0", Length = "0x33")]
	[Token(Token = "0x6000B1A")]
	private static IntPtr GetVertexBufferImpl_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303A350", Offset = "0x3039750", Length = "0x76")]
	[FreeFunction(Name = "SkinnedMeshRendererScripting::GetShaderUserValue", HasExplicitThis = True)]
	[Token(Token = "0x6000B06")]
	internal uint Internal_GetShaderUserValueUInt() { }

	[Address(RVA = "0x303A5D0", Offset = "0x30399D0", Length = "0x33")]
	[Token(Token = "0x6000B1F")]
	private static uint Internal_GetShaderUserValueUInt_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x303A650", Offset = "0x3039A50", Length = "0x83")]
	[FreeFunction(Name = "SkinnedMeshRendererScripting::SetShaderUserValue", HasExplicitThis = True)]
	[Token(Token = "0x6000B04")]
	internal void Internal_SetShaderUserValueUInt(uint v) { }

	[Address(RVA = "0x303A610", Offset = "0x3039A10", Length = "0x40")]
	[Token(Token = "0x6000B1E")]
	private static void Internal_SetShaderUserValueUInt_Injected(IntPtr _unity_self, uint v) { }

	[Address(RVA = "0x303AE60", Offset = "0x303A260", Length = "0x85")]
	[Token(Token = "0x6000AF5")]
	public void set_bones(Transform[] value) { }

	[Address(RVA = "0x303AE10", Offset = "0x303A210", Length = "0x42")]
	[Token(Token = "0x6000B12")]
	private static void set_bones_Injected(IntPtr _unity_self, Transform[] value) { }

	[Address(RVA = "0x303AF40", Offset = "0x303A340", Length = "0x86")]
	[Token(Token = "0x6000AF1")]
	public void set_forceMatrixRecalculationPerRender(bool value) { }

	[Address(RVA = "0x303AEF0", Offset = "0x303A2F0", Length = "0x42")]
	[Token(Token = "0x6000B0E")]
	private static void set_forceMatrixRecalculationPerRender_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x303B010", Offset = "0x303A410", Length = "0x83")]
	[Token(Token = "0x6000AED")]
	public void set_quality(SkinQuality value) { }

	[Address(RVA = "0x303AFD0", Offset = "0x303A3D0", Length = "0x40")]
	[Token(Token = "0x6000B0A")]
	private static void set_quality_Injected(IntPtr _unity_self, SkinQuality value) { }

	[Address(RVA = "0x303B0F0", Offset = "0x303A4F0", Length = "0xBA")]
	[Token(Token = "0x6000AF3")]
	public void set_rootBone(Transform value) { }

	[Address(RVA = "0x303B0A0", Offset = "0x303A4A0", Length = "0x42")]
	[Token(Token = "0x6000B10")]
	private static void set_rootBone_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x303B200", Offset = "0x303A600", Length = "0xBA")]
	[Token(Token = "0x6000AF7")]
	public void set_sharedMesh(Mesh value) { }

	[Address(RVA = "0x303B1B0", Offset = "0x303A5B0", Length = "0x42")]
	[Token(Token = "0x6000B14")]
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x303B310", Offset = "0x303A710", Length = "0x86")]
	[Token(Token = "0x6000AF9")]
	public void set_skinnedMotionVectors(bool value) { }

	[Address(RVA = "0x303B2C0", Offset = "0x303A6C0", Length = "0x42")]
	[Token(Token = "0x6000B16")]
	private static void set_skinnedMotionVectors_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x303B3F0", Offset = "0x303A7F0", Length = "0x86")]
	[Token(Token = "0x6000AEF")]
	public void set_updateWhenOffscreen(bool value) { }

	[Address(RVA = "0x303B3A0", Offset = "0x303A7A0", Length = "0x42")]
	[Token(Token = "0x6000B0C")]
	private static void set_updateWhenOffscreen_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x303B4C0", Offset = "0x303A8C0", Length = "0x83")]
	[Token(Token = "0x6000B03")]
	public void set_vertexBufferTarget(Target value) { }

	[Address(RVA = "0x303B480", Offset = "0x303A880", Length = "0x40")]
	[Token(Token = "0x6000B1D")]
	private static void set_vertexBufferTarget_Injected(IntPtr _unity_self, Target value) { }

	[Address(RVA = "0x303A730", Offset = "0x3039B30", Length = "0x93")]
	[Token(Token = "0x6000AFB")]
	public void SetBlendShapeWeight(int index, float value) { }

	[Address(RVA = "0x303A6E0", Offset = "0x3039AE0", Length = "0x50")]
	[Token(Token = "0x6000B18")]
	private static void SetBlendShapeWeight_Injected(IntPtr _unity_self, int index, float value) { }

	[Address(RVA = "0x303A650", Offset = "0x3039A50", Length = "0x83")]
	[Token(Token = "0x6000B05")]
	public void SetShaderUserValue(uint v) { }

}

