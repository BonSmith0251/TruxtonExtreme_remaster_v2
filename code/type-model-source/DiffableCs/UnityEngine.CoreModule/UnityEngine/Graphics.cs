namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[Token(Token = "0x20000DC")]
public class Graphics
{
	[Token(Token = "0x400026B")]
	internal static readonly int kMaxDrawMeshInstanceCount; //Field offset: 0x0
	[Token(Token = "0x400026C")]
	internal static Dictionary<Int32, RenderInstancedDataLayout> s_RenderInstancedDataLayouts; //Field offset: 0x8

	[StaticAccessor("GetGfxDevice()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x1700011E")]
	public static GraphicsTier activeTier
	{
		[Address(RVA = "0x2FF7B50", Offset = "0x2FF6F50", Length = "0x2A")]
		[Token(Token = "0x6000645")]
		 get { } //Length: 42
		[Address(RVA = "0x2FF7C40", Offset = "0x2FF7040", Length = "0x31")]
		[Token(Token = "0x6000646")]
		 set { } //Length: 49
	}

	[Token(Token = "0x17000120")]
	public static OpenGLESVersion minOpenGLESVersion
	{
		[Address(RVA = "0x2FF7B80", Offset = "0x2FF6F80", Length = "0x5B")]
		[Token(Token = "0x600064A")]
		 get { } //Length: 91
	}

	[Token(Token = "0x1700011F")]
	public static bool preserveFramebufferAlpha
	{
		[Address(RVA = "0x2FF7BE0", Offset = "0x2FF6FE0", Length = "0x5B")]
		[Token(Token = "0x6000648")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x2FF7A90", Offset = "0x2FF6E90", Length = "0xBA")]
	[Token(Token = "0x6000661")]
	private static Graphics() { }

	[Address(RVA = "0x2FF5750", Offset = "0x2FF4B50", Length = "0x138")]
	[Token(Token = "0x600065B")]
	public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset) { }

	[Address(RVA = "0x2FF5660", Offset = "0x2FF4A60", Length = "0xE7")]
	[FreeFunction("GraphicsScripting::Blit")]
	[Token(Token = "0x6000652")]
	private static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset) { }

	[Address(RVA = "0x2FF55F0", Offset = "0x2FF49F0", Length = "0x62")]
	[Token(Token = "0x6000667")]
	private static void Blit4_Injected(IntPtr source, IntPtr dest, in Vector2 scale, in Vector2 offset) { }

	[Address(RVA = "0x2FF5890", Offset = "0x2FF4C90", Length = "0x2A")]
	[StaticAccessor("GetGfxDevice()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x600064D")]
	public static void ClearRandomWriteTargets() { }

	[Address(RVA = "0x2FF5CA0", Offset = "0x2FF50A0", Length = "0x12D")]
	[Token(Token = "0x6000658")]
	public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[Address(RVA = "0x2FF5B80", Offset = "0x2FF4F80", Length = "0x11A")]
	[Token(Token = "0x6000657")]
	public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	[Address(RVA = "0x2FF5930", Offset = "0x2FF4D30", Length = "0xFC")]
	[FreeFunction("CopyTextureRegion")]
	[Token(Token = "0x600064F")]
	private static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[Address(RVA = "0x2FF58C0", Offset = "0x2FF4CC0", Length = "0x66")]
	[Token(Token = "0x6000664")]
	private static void CopyTexture_Region_Injected(IntPtr src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, IntPtr dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[Address(RVA = "0x2FF5A90", Offset = "0x2FF4E90", Length = "0xE9")]
	[FreeFunction("CopyTexture")]
	[Token(Token = "0x600064E")]
	private static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	[Address(RVA = "0x2FF5A30", Offset = "0x2FF4E30", Length = "0x60")]
	[Token(Token = "0x6000663")]
	private static void CopyTexture_Slice_Injected(IntPtr src, int srcElement, int srcMip, IntPtr dst, int dstElement, int dstMip) { }

	[Address(RVA = "0x2FF69A0", Offset = "0x2FF5DA0", Length = "0x2F6")]
	[Token(Token = "0x6000659")]
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[Address(RVA = "0x2FF6740", Offset = "0x2FF5B40", Length = "0x253")]
	[ExcludeFromDocs]
	[Token(Token = "0x600065D")]
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2FF6440", Offset = "0x2FF5840", Length = "0x2F3")]
	[ExcludeFromDocs]
	[Token(Token = "0x600065C")]
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera) { }

	[Address(RVA = "0x2FF5EB0", Offset = "0x2FF52B0", Length = "0x588")]
	[Token(Token = "0x600065A")]
	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[Address(RVA = "0x2FF5DD0", Offset = "0x2FF51D0", Length = "0xD1")]
	[ExcludeFromDocs]
	[Token(Token = "0x600065E")]
	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera) { }

	[Address(RVA = "0x2FF6CE0", Offset = "0x2FF60E0", Length = "0xB0")]
	[NativeMethod(Name = "GraphicsScripting::ExecuteCommandBuffer", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x6000653")]
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	[Address(RVA = "0x2FF6CA0", Offset = "0x2FF60A0", Length = "0x33")]
	[Token(Token = "0x6000668")]
	private static void ExecuteCommandBuffer_Injected(IntPtr buffer) { }

	[Address(RVA = "0x2FF7B50", Offset = "0x2FF6F50", Length = "0x2A")]
	[Token(Token = "0x6000645")]
	public static GraphicsTier get_activeTier() { }

	[Address(RVA = "0x2FF7B80", Offset = "0x2FF6F80", Length = "0x5B")]
	[Token(Token = "0x600064A")]
	public static OpenGLESVersion get_minOpenGLESVersion() { }

	[Address(RVA = "0x2FF7BE0", Offset = "0x2FF6FE0", Length = "0x5B")]
	[Token(Token = "0x6000648")]
	public static bool get_preserveFramebufferAlpha() { }

	[Address(RVA = "0x2FF6DA0", Offset = "0x2FF61A0", Length = "0x2A")]
	[NativeMethod(Name = "GetMinOpenGLESVersion")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x6000649")]
	internal static OpenGLESVersion GetMinOpenGLESVersion() { }

	[Address(RVA = "0x2FF6DD0", Offset = "0x2FF61D0", Length = "0x2A")]
	[NativeMethod(Name = "GetPreserveFramebufferAlpha")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x6000647")]
	internal static bool GetPreserveFramebufferAlpha() { }

	[Address(RVA = "0x2FF71A0", Offset = "0x2FF65A0", Length = "0x1EB")]
	[FreeFunction("GraphicsScripting::DrawMesh")]
	[Token(Token = "0x6000650")]
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[Address(RVA = "0x2FF7120", Offset = "0x2FF6520", Length = "0x75")]
	[Token(Token = "0x6000665")]
	private static void Internal_DrawMesh_Injected(IntPtr mesh, int submeshIndex, in Matrix4x4 matrix, IntPtr material, int layer, IntPtr camera, IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, IntPtr probeAnchor, LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume) { }

	[Address(RVA = "0x2FF6E80", Offset = "0x2FF6280", Length = "0x29C")]
	[FreeFunction("GraphicsScripting::DrawMeshInstanced")]
	[Token(Token = "0x6000651")]
	private static void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[Address(RVA = "0x2FF6E00", Offset = "0x2FF6200", Length = "0x75")]
	[Token(Token = "0x6000666")]
	private static void Internal_DrawMeshInstanced_Injected(IntPtr mesh, int submeshIndex, IntPtr material, ref ManagedSpanWrapper matrices, int count, IntPtr properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, IntPtr camera, LightProbeUsage lightProbeUsage, IntPtr lightProbeProxyVolume) { }

	[Address(RVA = "0x2FF7390", Offset = "0x2FF6790", Length = "0x2A")]
	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = True)]
	[Token(Token = "0x6000644")]
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[Address(RVA = "0x2FF73C0", Offset = "0x2FF67C0", Length = "0x2A")]
	[FreeFunction("GraphicsScripting::SetNullRT")]
	[Token(Token = "0x600064B")]
	private static void Internal_SetNullRT() { }

	[Address(RVA = "0x2FF7460", Offset = "0x2FF6860", Length = "0x9B")]
	[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600064C")]
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[Address(RVA = "0x2FF73F0", Offset = "0x2FF67F0", Length = "0x62")]
	[Token(Token = "0x6000662")]
	private static void Internal_SetRTSimple_Injected(in RenderBuffer color, in RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[Address(RVA = "0x2FF7C40", Offset = "0x2FF7040", Length = "0x31")]
	[Token(Token = "0x6000646")]
	public static void set_activeTier(GraphicsTier value) { }

	[Address(RVA = "0x2FF7820", Offset = "0x2FF6C20", Length = "0x67")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000660")]
	public static void SetRenderTarget(RenderTexture rt, int mipLevel) { }

	[Address(RVA = "0x2FF77C0", Offset = "0x2FF6BC0", Length = "0x5C")]
	[ExcludeFromDocs]
	[Token(Token = "0x600065F")]
	public static void SetRenderTarget(RenderTexture rt) { }

	[Address(RVA = "0x2FF7890", Offset = "0x2FF6C90", Length = "0x1F2")]
	[Token(Token = "0x6000656")]
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	[Address(RVA = "0x2FF7500", Offset = "0x2FF6900", Length = "0x1C1")]
	[Token(Token = "0x6000655")]
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	[Address(RVA = "0x2FF76D0", Offset = "0x2FF6AD0", Length = "0xE3")]
	[Token(Token = "0x6000654")]
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

}

