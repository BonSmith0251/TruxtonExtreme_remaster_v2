namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Shaders/RayTracing/RayTracingShader.h")]
[NativeHeader("Runtime/Export/Graphics/RenderingCommandBuffer.bindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeType("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[Token(Token = "0x200038A")]
[UsedByNativeCode]
public class CommandBuffer : IDisposable
{
	[Token(Token = "0x200038B")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6001CAB")]
		public static IntPtr ConvertToNative(CommandBuffer commandBuffer) { }

	}

	[Token(Token = "0x4000AAC")]
	public static bool ThrowOnSetRenderTarget; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AAD")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x170003E5")]
	public string name
	{
		[Address(RVA = "0x30B3670", Offset = "0x30B2A70", Length = "0xCE")]
		[Token(Token = "0x6001AD3")]
		 get { } //Length: 206
		[Address(RVA = "0x30B3830", Offset = "0x30B2C30", Length = "0x1BB")]
		[Token(Token = "0x6001AD4")]
		 set { } //Length: 443
	}

	[Token(Token = "0x170003E6")]
	public int sizeInBytes
	{
		[Address(RVA = "0x30B3780", Offset = "0x30B2B80", Length = "0x51")]
		[NativeMethod("GetBufferSize")]
		[Token(Token = "0x6001AD5")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x30B35E0", Offset = "0x30B29E0", Length = "0x3B")]
	[Token(Token = "0x6001B70")]
	public CommandBuffer() { }

	[Address(RVA = "0x3099D20", Offset = "0x3099120", Length = "0x17A")]
	[Token(Token = "0x6001B5C")]
	public void BeginRenderPass(int width, int height, int volumeDepth, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex, int shadingRateImageAttachmentIndex, NativeArray<SubPassDescriptor> subPasses, ReadOnlySpan<Byte> debugNameUtf8) { }

	[Address(RVA = "0x3099B00", Offset = "0x3098F00", Length = "0x214")]
	[FreeFunction("RenderingCommandBuffer_Bindings::BeginRenderPass", HasExplicitThis = True)]
	[Token(Token = "0x6001B5B")]
	private void BeginRenderPass_Internal(int width, int height, int volumeDepth, int samples, ReadOnlySpan<AttachmentDescriptor> attachments, int depthAttachmentIndex, int shadingRateImageAttachmentIndex, ReadOnlySpan<SubPassDescriptor> subPasses, ReadOnlySpan<Byte> debugNameUtf8) { }

	[Address(RVA = "0x3099AA0", Offset = "0x3098EA0", Length = "0x60")]
	[Token(Token = "0x6001CA2")]
	private static void BeginRenderPass_Internal_Injected(IntPtr _unity_self, int width, int height, int volumeDepth, int samples, ref ManagedSpanWrapper attachments, int depthAttachmentIndex, int shadingRateImageAttachmentIndex, ref ManagedSpanWrapper subPasses, ref ManagedSpanWrapper debugNameUtf8) { }

	[Address(RVA = "0x309A000", Offset = "0x3099400", Length = "0x1BB")]
	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample", HasExplicitThis = True)]
	[Token(Token = "0x6001B20")]
	public void BeginSample(string name) { }

	[Address(RVA = "0x3099EF0", Offset = "0x30992F0", Length = "0xBB")]
	[Token(Token = "0x6001B22")]
	public void BeginSample(CustomSampler sampler) { }

	[Address(RVA = "0x3099EF0", Offset = "0x30992F0", Length = "0xBB")]
	[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample_CustomSampler", HasExplicitThis = True)]
	[Token(Token = "0x6001B24")]
	private void BeginSample_CustomSampler(CustomSampler sampler) { }

	[Address(RVA = "0x3099EA0", Offset = "0x30992A0", Length = "0x42")]
	[Token(Token = "0x6001C89")]
	private static void BeginSample_CustomSampler_Injected(IntPtr _unity_self, IntPtr sampler) { }

	[Address(RVA = "0x3099FB0", Offset = "0x30993B0", Length = "0x42")]
	[Token(Token = "0x6001C87")]
	private static void BeginSample_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x309A370", Offset = "0x3099770", Length = "0x18C")]
	[Token(Token = "0x6001BED")]
	public void Blit(Texture source, RenderTargetIdentifier dest) { }

	[Address(RVA = "0x309A230", Offset = "0x3099630", Length = "0x135")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Texture", HasExplicitThis = True)]
	[Token(Token = "0x6001AEE")]
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[Address(RVA = "0x309A1C0", Offset = "0x30995C0", Length = "0x62")]
	[Token(Token = "0x6001C63")]
	private static void Blit_Texture_Injected(IntPtr _unity_self, IntPtr source, ref RenderTargetIdentifier dest, IntPtr mat, int pass, in Vector2 scale, in Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[Address(RVA = "0x309A500", Offset = "0x3099900", Length = "0x130")]
	[Token(Token = "0x6001B93")]
	public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure) { }

	[Address(RVA = "0x309A710", Offset = "0x3099B10", Length = "0x10B")]
	[Token(Token = "0x6001B94")]
	public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, Vector3 relativeOrigin) { }

	[Address(RVA = "0x309A640", Offset = "0x3099A40", Length = "0xC9")]
	[Token(Token = "0x6001B95")]
	public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, BuildSettings buildSettings) { }

	[Address(RVA = "0x309A820", Offset = "0x3099C20", Length = "0x8A")]
	[Token(Token = "0x6001B30")]
	private static void CheckThrowOnSetRenderTarget() { }

	[Address(RVA = "0x309B260", Offset = "0x309A660", Length = "0x51")]
	[NativeMethod("ClearCommands")]
	[Token(Token = "0x6001AD6")]
	public void Clear() { }

	[Address(RVA = "0x309B220", Offset = "0x309A620", Length = "0x33")]
	[Token(Token = "0x6001C4B")]
	private static void Clear_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x309A8F0", Offset = "0x3099CF0", Length = "0x51")]
	[FreeFunction("RenderingCommandBuffer_Bindings::ClearRandomWriteTargets", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001AE9")]
	public void ClearRandomWriteTargets() { }

	[Address(RVA = "0x309A8B0", Offset = "0x3099CB0", Length = "0x33")]
	[Token(Token = "0x6001C5E")]
	private static void ClearRandomWriteTargets_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x309B140", Offset = "0x309A540", Length = "0xDD")]
	[Token(Token = "0x6001AF2")]
	public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth = 1, uint stencil = 0) { }

	[Address(RVA = "0x309AE60", Offset = "0x309A260", Length = "0xF2")]
	[Token(Token = "0x6001AF1")]
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth = 1, uint stencil = 0) { }

	[Address(RVA = "0x309B050", Offset = "0x309A450", Length = "0xED")]
	[Token(Token = "0x6001AF0")]
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[Address(RVA = "0x309AF60", Offset = "0x309A360", Length = "0xEC")]
	[Token(Token = "0x6001AEF")]
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[Address(RVA = "0x309ABC0", Offset = "0x3099FC0", Length = "0x29A")]
	[Token(Token = "0x6001AF3")]
	public void ClearRenderTarget(RTClearFlags clearFlags, Color[] backgroundColors, float depth = 1, uint stencil = 0) { }

	[Address(RVA = "0x309A9B0", Offset = "0x3099DB0", Length = "0x124")]
	[Token(Token = "0x6001B41")]
	private void ClearRenderTargetMulti_Internal(RTClearFlags clearFlags, Color[] colors, float depth, uint stencil) { }

	[Address(RVA = "0x309A950", Offset = "0x3099D50", Length = "0x60")]
	[Token(Token = "0x6001C96")]
	private static void ClearRenderTargetMulti_Internal_Injected(IntPtr _unity_self, RTClearFlags clearFlags, ref ManagedSpanWrapper colors, float depth, uint stencil) { }

	[Address(RVA = "0x309AB40", Offset = "0x3099F40", Length = "0x7F")]
	[Token(Token = "0x6001B40")]
	private void ClearRenderTargetSingle_Internal(RTClearFlags clearFlags, Color color, float depth, uint stencil) { }

	[Address(RVA = "0x309AAE0", Offset = "0x3099EE0", Length = "0x60")]
	[Token(Token = "0x6001C95")]
	private static void ClearRenderTargetSingle_Internal_Injected(IntPtr _unity_self, RTClearFlags clearFlags, in Color color, float depth, uint stencil) { }

	[Address(RVA = "0x309B310", Offset = "0x309A710", Length = "0x5A")]
	[FreeFunction("RenderingCommandBuffer_Bindings::ConfigureFoveatedRendering", HasExplicitThis = True)]
	[Token(Token = "0x6001B2F")]
	public void ConfigureFoveatedRendering(IntPtr platformData) { }

	[Address(RVA = "0x309B2C0", Offset = "0x309A6C0", Length = "0x42")]
	[Token(Token = "0x6001C94")]
	private static void ConfigureFoveatedRendering_Injected(IntPtr _unity_self, IntPtr platformData) { }

	[Address(RVA = "0x309B3E0", Offset = "0x309A7E0", Length = "0xA0")]
	[Token(Token = "0x6001BE5")]
	public void CopyCounterValue(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B620", Offset = "0x309AA20", Length = "0xA0")]
	[Token(Token = "0x6001BE6")]
	public void CopyCounterValue(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B500", Offset = "0x309A900", Length = "0xA0")]
	[Token(Token = "0x6001BE7")]
	public void CopyCounterValue(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B740", Offset = "0x309AB40", Length = "0xA0")]
	[Token(Token = "0x6001BE8")]
	public void CopyCounterValue(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B3E0", Offset = "0x309A7E0", Length = "0xA0")]
	[NativeMethod("AddCopyCounterValue")]
	[Token(Token = "0x6001ACF")]
	private void CopyCounterValueCC(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B370", Offset = "0x309A770", Length = "0x62")]
	[Token(Token = "0x6001C44")]
	private static void CopyCounterValueCC_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B500", Offset = "0x309A900", Length = "0xA0")]
	[NativeMethod("AddCopyCounterValue")]
	[Token(Token = "0x6001AD1")]
	private void CopyCounterValueCG(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B490", Offset = "0x309A890", Length = "0x62")]
	[Token(Token = "0x6001C46")]
	private static void CopyCounterValueCG_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B620", Offset = "0x309AA20", Length = "0xA0")]
	[NativeMethod("AddCopyCounterValue")]
	[Token(Token = "0x6001AD0")]
	private void CopyCounterValueGC(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B5B0", Offset = "0x309A9B0", Length = "0x62")]
	[Token(Token = "0x6001C45")]
	private static void CopyCounterValueGC_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B740", Offset = "0x309AB40", Length = "0xA0")]
	[NativeMethod("AddCopyCounterValue")]
	[Token(Token = "0x6001AD2")]
	private void CopyCounterValueGG(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B6D0", Offset = "0x309AAD0", Length = "0x62")]
	[Token(Token = "0x6001C47")]
	private static void CopyCounterValueGG_Injected(IntPtr _unity_self, IntPtr src, IntPtr dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x309B9F0", Offset = "0x309ADF0", Length = "0xC9")]
	[Token(Token = "0x6001BE9")]
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	[Address(RVA = "0x309BBB0", Offset = "0x309AFB0", Length = "0xD8")]
	[Token(Token = "0x6001BEA")]
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement) { }

	[Address(RVA = "0x309BAC0", Offset = "0x309AEC0", Length = "0xE0")]
	[Token(Token = "0x6001BEB")]
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	[Address(RVA = "0x309B8F0", Offset = "0x309ACF0", Length = "0xF6")]
	[Token(Token = "0x6001BEC")]
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[Address(RVA = "0x309B860", Offset = "0x309AC60", Length = "0x84")]
	[FreeFunction("RenderingCommandBuffer_Bindings::CopyTexture_Internal", HasExplicitThis = True)]
	[Token(Token = "0x6001AED")]
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[Address(RVA = "0x309B7F0", Offset = "0x309ABF0", Length = "0x66")]
	[Token(Token = "0x6001C62")]
	private static void CopyTexture_Internal_Injected(IntPtr _unity_self, ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[Address(RVA = "0x309BC90", Offset = "0x309B090", Length = "0x98")]
	[Token(Token = "0x6001B72")]
	public GraphicsFence CreateAsyncGraphicsFence() { }

	[Address(RVA = "0x309BD80", Offset = "0x309B180", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::CreateGPUFence_Internal", HasExplicitThis = True)]
	[Token(Token = "0x6001AA5")]
	private IntPtr CreateGPUFence_Internal(GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	[Address(RVA = "0x309BD30", Offset = "0x309B130", Length = "0x50")]
	[Token(Token = "0x6001C1A")]
	private static IntPtr CreateGPUFence_Internal_Injected(IntPtr _unity_self, GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	[Address(RVA = "0x309BDF0", Offset = "0x309B1F0", Length = "0xB3")]
	[Token(Token = "0x6001B73")]
	public GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage) { }

	[Address(RVA = "0x309BF10", Offset = "0x309B310", Length = "0xC4")]
	[FreeFunction("RenderingCommandBuffer_Bindings::DisableComputeKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001B04")]
	private void DisableComputeKeyword(ComputeShader computeShader, LocalKeyword keyword) { }

	[Address(RVA = "0x309BEB0", Offset = "0x309B2B0", Length = "0x52")]
	[Token(Token = "0x6001C71")]
	private static void DisableComputeKeyword_Injected(IntPtr _unity_self, IntPtr computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x309C030", Offset = "0x309B430", Length = "0x5A")]
	[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001B02")]
	private void DisableGlobalKeyword(GlobalKeyword keyword) { }

	[Address(RVA = "0x309BFE0", Offset = "0x309B3E0", Length = "0x42")]
	[Token(Token = "0x6001C6F")]
	private static void DisableGlobalKeyword_Injected(IntPtr _unity_self, in GlobalKeyword keyword) { }

	[Address(RVA = "0x309C160", Offset = "0x309B560", Length = "0xC8")]
	[Token(Token = "0x6001B07")]
	public void DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x309C230", Offset = "0x309B630", Length = "0x5C")]
	[Token(Token = "0x6001B05")]
	public void DisableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x309C090", Offset = "0x309B490", Length = "0xC8")]
	[Token(Token = "0x6001B06")]
	public void DisableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x309C2F0", Offset = "0x309B6F0", Length = "0xC4")]
	[FreeFunction("RenderingCommandBuffer_Bindings::DisableMaterialKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001B03")]
	private void DisableMaterialKeyword(Material material, LocalKeyword keyword) { }

	[Address(RVA = "0x309C290", Offset = "0x309B690", Length = "0x52")]
	[Token(Token = "0x6001C70")]
	private static void DisableMaterialKeyword_Injected(IntPtr _unity_self, IntPtr material, in LocalKeyword keyword) { }

	[Address(RVA = "0x309C400", Offset = "0x309B800", Length = "0x51")]
	[FreeFunction("RenderingCommandBuffer_Bindings::DisableScissorRect", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001AEC")]
	public void DisableScissorRect() { }

	[Address(RVA = "0x309C3C0", Offset = "0x309B7C0", Length = "0x33")]
	[Token(Token = "0x6001C61")]
	private static void DisableScissorRect_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x309C4B0", Offset = "0x309B8B0", Length = "0x1BB")]
	[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001B01")]
	public void DisableShaderKeyword(string keyword) { }

	[Address(RVA = "0x309C460", Offset = "0x309B860", Length = "0x42")]
	[Token(Token = "0x6001C6E")]
	private static void DisableShaderKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x309C930", Offset = "0x309BD30", Length = "0xE9")]
	[Token(Token = "0x6001B90")]
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[Address(RVA = "0x309C7D0", Offset = "0x309BBD0", Length = "0x15D")]
	[Token(Token = "0x6001B91")]
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset) { }

	[Address(RVA = "0x309C670", Offset = "0x309BA70", Length = "0x15D")]
	[Token(Token = "0x6001B92")]
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset) { }

	[Address(RVA = "0x309CA20", Offset = "0x309BE20", Length = "0xE")]
	[Token(Token = "0x6001BB6")]
	public void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, Camera camera = null) { }

	[Address(RVA = "0x309CA30", Offset = "0x309BE30", Length = "0xE")]
	[Token(Token = "0x6001BB7")]
	public void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, GraphicsBuffer argsBuffer, uint argsOffset, Camera camera = null) { }

	[Address(RVA = "0x309CAE0", Offset = "0x309BEE0", Length = "0x5F")]
	[Token(Token = "0x6001B6F")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x309CA40", Offset = "0x309BE40", Length = "0x9C")]
	[Token(Token = "0x6001B6E")]
	public override void Dispose() { }

	[Address(RVA = "0x309DEC0", Offset = "0x309D2C0", Length = "0x356")]
	[Token(Token = "0x6001BBA")]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x309DDF0", Offset = "0x309D1F0", Length = "0x62")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001BBB")]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	[Address(RVA = "0x309DD90", Offset = "0x309D190", Length = "0x5F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001BBC")]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	[Address(RVA = "0x309DE60", Offset = "0x309D260", Length = "0x58")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001BBD")]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	[Address(RVA = "0x309D7F0", Offset = "0x309CBF0", Length = "0x591")]
	[Token(Token = "0x6001BD5")]
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x309D7B0", Offset = "0x309CBB0", Length = "0x3D")]
	[Token(Token = "0x6001BD6")]
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count) { }

	[Address(RVA = "0x309D760", Offset = "0x309CB60", Length = "0x44")]
	[Token(Token = "0x6001BD7")]
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices) { }

	[Address(RVA = "0x309D380", Offset = "0x309C780", Length = "0x36")]
	[Token(Token = "0x6001BDB")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs) { }

	[Address(RVA = "0x309CFC0", Offset = "0x309C3C0", Length = "0x3B0")]
	[Token(Token = "0x6001BD9")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x309CF00", Offset = "0x309C300", Length = "0x3D")]
	[Token(Token = "0x6001BDA")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x309CB40", Offset = "0x309BF40", Length = "0x3B0")]
	[Token(Token = "0x6001BDC")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x309CF80", Offset = "0x309C380", Length = "0x3D")]
	[Token(Token = "0x6001BDD")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x309CF40", Offset = "0x309C340", Length = "0x36")]
	[Token(Token = "0x6001BDE")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs) { }

	[Address(RVA = "0x309D3C0", Offset = "0x309C7C0", Length = "0x395")]
	[Token(Token = "0x6001BD8")]
	public void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties = null) { }

	[Address(RVA = "0x309E220", Offset = "0x309D620", Length = "0xEA")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001BBE")]
	public void DrawMultipleMeshes(Matrix4x4[] matrices, Mesh[] meshes, Int32[] subsetIndices, int count, Material material, int shaderPass, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x309E310", Offset = "0x309D710", Length = "0x5E")]
	[Token(Token = "0x6001BDF")]
	public void DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	[Address(RVA = "0x309F2D0", Offset = "0x309E6D0", Length = "0x232")]
	[Token(Token = "0x6001BC6")]
	public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x309F820", Offset = "0x309EC20", Length = "0x74")]
	[Token(Token = "0x6001BC8")]
	public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount) { }

	[Address(RVA = "0x309F590", Offset = "0x309E990", Length = "0x68")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001BC4")]
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount) { }

	[Address(RVA = "0x309F510", Offset = "0x309E910", Length = "0x77")]
	[Token(Token = "0x6001BC7")]
	public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount) { }

	[Address(RVA = "0x309F600", Offset = "0x309EA00", Length = "0x211")]
	[Token(Token = "0x6001BC3")]
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x309F8A0", Offset = "0x309ECA0", Length = "0x65")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001BC5")]
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount) { }

	[Address(RVA = "0x309EE90", Offset = "0x309E290", Length = "0x72")]
	[Token(Token = "0x6001BCE")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[Address(RVA = "0x309EE10", Offset = "0x309E210", Length = "0x79")]
	[Token(Token = "0x6001BCD")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x309EDA0", Offset = "0x309E1A0", Length = "0x6A")]
	[Token(Token = "0x6001BD0")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x309EA40", Offset = "0x309DE40", Length = "0x63")]
	[Token(Token = "0x6001BCB")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[Address(RVA = "0x309F260", Offset = "0x309E660", Length = "0x6A")]
	[Token(Token = "0x6001BCA")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x309E370", Offset = "0x309D770", Length = "0x79")]
	[Token(Token = "0x6001BD3")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x309EF10", Offset = "0x309E310", Length = "0x2D1")]
	[Token(Token = "0x6001BCF")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x309EAB0", Offset = "0x309DEB0", Length = "0x2E2")]
	[Token(Token = "0x6001BD2")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x309F1F0", Offset = "0x309E5F0", Length = "0x63")]
	[Token(Token = "0x6001BD1")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[Address(RVA = "0x309E750", Offset = "0x309DB50", Length = "0x2E2")]
	[Token(Token = "0x6001BCC")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x309E470", Offset = "0x309D870", Length = "0x2D1")]
	[Token(Token = "0x6001BC9")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x309E3F0", Offset = "0x309D7F0", Length = "0x72")]
	[Token(Token = "0x6001BD4")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[Address(RVA = "0x309F980", Offset = "0x309ED80", Length = "0x2C5")]
	[Token(Token = "0x6001BBF")]
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[Address(RVA = "0x309FC50", Offset = "0x309F050", Length = "0x1F")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001BC0")]
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	[Address(RVA = "0x309FC70", Offset = "0x309F070", Length = "0x22")]
	[ExcludeFromDocs]
	[Token(Token = "0x6001BC1")]
	public void DrawRenderer(Renderer renderer, Material material) { }

	[Address(RVA = "0x309F910", Offset = "0x309ED10", Length = "0x69")]
	[Token(Token = "0x6001BC2")]
	public void DrawRendererList(RendererList rendererList) { }

	[Address(RVA = "0x309FD00", Offset = "0x309F100", Length = "0xC4")]
	[FreeFunction("RenderingCommandBuffer_Bindings::EnableComputeKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001AFD")]
	private void EnableComputeKeyword(ComputeShader computeShader, LocalKeyword keyword) { }

	[Address(RVA = "0x309FCA0", Offset = "0x309F0A0", Length = "0x52")]
	[Token(Token = "0x6001C6D")]
	private static void EnableComputeKeyword_Injected(IntPtr _unity_self, IntPtr computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x309FE20", Offset = "0x309F220", Length = "0x5A")]
	[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001AFB")]
	private void EnableGlobalKeyword(GlobalKeyword keyword) { }

	[Address(RVA = "0x309FDD0", Offset = "0x309F1D0", Length = "0x42")]
	[Token(Token = "0x6001C6B")]
	private static void EnableGlobalKeyword_Injected(IntPtr _unity_self, in GlobalKeyword keyword) { }

	[Address(RVA = "0x309FEE0", Offset = "0x309F2E0", Length = "0xC8")]
	[Token(Token = "0x6001B00")]
	public void EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x309FFB0", Offset = "0x309F3B0", Length = "0xC8")]
	[Token(Token = "0x6001AFF")]
	public void EnableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x309FE80", Offset = "0x309F280", Length = "0x5C")]
	[Token(Token = "0x6001AFE")]
	public void EnableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x30A00E0", Offset = "0x309F4E0", Length = "0xC4")]
	[FreeFunction("RenderingCommandBuffer_Bindings::EnableMaterialKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001AFC")]
	private void EnableMaterialKeyword(Material material, LocalKeyword keyword) { }

	[Address(RVA = "0x30A0080", Offset = "0x309F480", Length = "0x52")]
	[Token(Token = "0x6001C6C")]
	private static void EnableMaterialKeyword_Injected(IntPtr _unity_self, IntPtr material, in LocalKeyword keyword) { }

	[Address(RVA = "0x30A0200", Offset = "0x309F600", Length = "0x5A")]
	[FreeFunction("RenderingCommandBuffer_Bindings::EnableScissorRect", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001AEB")]
	public void EnableScissorRect(Rect scissor) { }

	[Address(RVA = "0x30A01B0", Offset = "0x309F5B0", Length = "0x42")]
	[Token(Token = "0x6001C60")]
	private static void EnableScissorRect_Injected(IntPtr _unity_self, in Rect scissor) { }

	[Address(RVA = "0x30A02B0", Offset = "0x309F6B0", Length = "0x1BB")]
	[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001AFA")]
	public void EnableShaderKeyword(string keyword) { }

	[Address(RVA = "0x30A0260", Offset = "0x309F660", Length = "0x42")]
	[Token(Token = "0x6001C6A")]
	private static void EnableShaderKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[Address(RVA = "0x30A0510", Offset = "0x309F910", Length = "0x9A")]
	[Token(Token = "0x6001B60")]
	public void EndRenderPass() { }

	[Address(RVA = "0x30A04B0", Offset = "0x309F8B0", Length = "0x51")]
	[FreeFunction("RenderingCommandBuffer_Bindings::EndRenderPass", HasExplicitThis = True)]
	[Token(Token = "0x6001B5F")]
	private void EndRenderPass_Internal() { }

	[Address(RVA = "0x30A0470", Offset = "0x309F870", Length = "0x33")]
	[Token(Token = "0x6001CA4")]
	private static void EndRenderPass_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30A0710", Offset = "0x309FB10", Length = "0x1BB")]
	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample", HasExplicitThis = True)]
	[Token(Token = "0x6001B21")]
	public void EndSample(string name) { }

	[Address(RVA = "0x30A0600", Offset = "0x309FA00", Length = "0xBB")]
	[Token(Token = "0x6001B23")]
	public void EndSample(CustomSampler sampler) { }

	[Address(RVA = "0x30A0600", Offset = "0x309FA00", Length = "0xBB")]
	[FreeFunction("RenderingCommandBuffer_Bindings::EndSample_CustomSampler", HasExplicitThis = True)]
	[Token(Token = "0x6001B25")]
	private void EndSample_CustomSampler(CustomSampler sampler) { }

	[Address(RVA = "0x30A05B0", Offset = "0x309F9B0", Length = "0x42")]
	[Token(Token = "0x6001C8A")]
	private static void EndSample_CustomSampler_Injected(IntPtr _unity_self, IntPtr sampler) { }

	[Address(RVA = "0x30A06C0", Offset = "0x309FAC0", Length = "0x42")]
	[Token(Token = "0x6001C88")]
	private static void EndSample_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x30A08D0", Offset = "0x309FCD0", Length = "0xA5")]
	[Token(Token = "0x6001B6D")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x30A0B30", Offset = "0x309FF30", Length = "0xC7")]
	[Token(Token = "0x6001BB8")]
	public void GenerateMips(RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30A0980", Offset = "0x309FD80", Length = "0x1AC")]
	[Token(Token = "0x6001BB9")]
	public void GenerateMips(RenderTexture rt) { }

	[Address(RVA = "0x30B3670", Offset = "0x30B2A70", Length = "0xCE")]
	[Token(Token = "0x6001AD3")]
	public string get_name() { }

	[Address(RVA = "0x30B3620", Offset = "0x30B2A20", Length = "0x42")]
	[Token(Token = "0x6001C48")]
	private static void get_name_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x30B3780", Offset = "0x30B2B80", Length = "0x51")]
	[NativeMethod("GetBufferSize")]
	[Token(Token = "0x6001AD5")]
	public int get_sizeInBytes() { }

	[Address(RVA = "0x30B3740", Offset = "0x30B2B40", Length = "0x33")]
	[Token(Token = "0x6001C4A")]
	private static int get_sizeInBytes_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30A0C50", Offset = "0x30A0050", Length = "0x5A")]
	[FreeFunction("RenderingCommandBuffer_Bindings::IncrementUpdateCount", HasExplicitThis = True)]
	[Token(Token = "0x6001B2B")]
	public void IncrementUpdateCount(RenderTargetIdentifier dest) { }

	[Address(RVA = "0x30A0C00", Offset = "0x30A0000", Length = "0x42")]
	[Token(Token = "0x6001C90")]
	private static void IncrementUpdateCount_Injected(IntPtr _unity_self, in RenderTargetIdentifier dest) { }

	[Address(RVA = "0x30A0CB0", Offset = "0x30A00B0", Length = "0x2A")]
	[FreeFunction("RenderingCommandBuffer_Bindings::InitBuffer")]
	[Token(Token = "0x6001AA4")]
	private static IntPtr InitBuffer() { }

	[Address(RVA = "0x30A14E0", Offset = "0x30A08E0", Length = "0xCB")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_BuildRayTracingAccelerationStructure", HasExplicitThis = True)]
	[Token(Token = "0x6001AC8")]
	private void Internal_BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, BuildSettings buildSettings) { }

	[Address(RVA = "0x30A1480", Offset = "0x30A0880", Length = "0x52")]
	[Token(Token = "0x6001C3D")]
	private static void Internal_BuildRayTracingAccelerationStructure_Injected(IntPtr _unity_self, IntPtr accelerationStructure, in BuildSettings buildSettings) { }

	[Address(RVA = "0x309C930", Offset = "0x309BD30", Length = "0xE9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchCompute", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001AB7")]
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[Address(RVA = "0x30A1890", Offset = "0x30A0C90", Length = "0x62")]
	[Token(Token = "0x6001C2C")]
	private static void Internal_DispatchCompute_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[Address(RVA = "0x30A1790", Offset = "0x30A0B90", Length = "0xF9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchComputeIndirect", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001AB8")]
	private void Internal_DispatchComputeIndirect(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset) { }

	[Address(RVA = "0x30A1720", Offset = "0x30A0B20", Length = "0x62")]
	[Token(Token = "0x6001C2D")]
	private static void Internal_DispatchComputeIndirect_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, IntPtr indirectBuffer, uint argsOffset) { }

	[Address(RVA = "0x30A1620", Offset = "0x30A0A20", Length = "0xF9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchComputeIndirect", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001AB9")]
	private void Internal_DispatchComputeIndirectGraphicsBuffer(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset) { }

	[Address(RVA = "0x30A15B0", Offset = "0x30A09B0", Length = "0x62")]
	[Token(Token = "0x6001C2E")]
	private static void Internal_DispatchComputeIndirectGraphicsBuffer_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, IntPtr indirectBuffer, uint argsOffset) { }

	[Address(RVA = "0x30A1CB0", Offset = "0x30A10B0", Length = "0x28F")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchRays", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001ACC")]
	private void Internal_DispatchRays(RayTracingShader rayTracingShader, string rayGenShaderName, uint width, uint height, uint depth, Camera camera = null) { }

	[Address(RVA = "0x30A1C40", Offset = "0x30A1040", Length = "0x62")]
	[Token(Token = "0x6001C41")]
	private static void Internal_DispatchRays_Injected(IntPtr _unity_self, IntPtr rayTracingShader, ref ManagedSpanWrapper rayGenShaderName, uint width, uint height, uint depth, IntPtr camera) { }

	[Address(RVA = "0x30A1970", Offset = "0x30A0D70", Length = "0x2C4")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchRaysIndirect", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001ACD")]
	private void Internal_DispatchRaysIndirect(RayTracingShader rayTracingShader, string rayGenShaderName, GraphicsBuffer argsBuffer, uint argsOffset = 0, Camera camera = null) { }

	[Address(RVA = "0x30A1900", Offset = "0x30A0D00", Length = "0x62")]
	[Token(Token = "0x6001C42")]
	private static void Internal_DispatchRaysIndirect_Injected(IntPtr _unity_self, IntPtr rayTracingShader, ref ManagedSpanWrapper rayGenShaderName, IntPtr argsBuffer, uint argsOffset, IntPtr camera) { }

	[Address(RVA = "0x30A26D0", Offset = "0x30A1AD0", Length = "0x14F")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMesh", HasExplicitThis = True)]
	[Token(Token = "0x6001AD7")]
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A2660", Offset = "0x30A1A60", Length = "0x62")]
	[Token(Token = "0x6001C4C")]
	private static void Internal_DrawMesh_Injected(IntPtr _unity_self, IntPtr mesh, in Matrix4x4 matrix, IntPtr material, int submeshIndex, int shaderPass, IntPtr properties) { }

	[Address(RVA = "0x30A2490", Offset = "0x30A1890", Length = "0x1C0")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstanced", HasExplicitThis = True)]
	[Token(Token = "0x6001AE1")]
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A2420", Offset = "0x30A1820", Length = "0x62")]
	[Token(Token = "0x6001C56")]
	private static void Internal_DrawMeshInstanced_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, ref ManagedSpanWrapper matrices, int count, IntPtr properties) { }

	[Address(RVA = "0x30A2160", Offset = "0x30A1560", Length = "0x135")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstancedIndirect", HasExplicitThis = True)]
	[Token(Token = "0x6001AE3")]
	private void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A20F0", Offset = "0x30A14F0", Length = "0x62")]
	[Token(Token = "0x6001C58")]
	private static void Internal_DrawMeshInstancedIndirect_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[Address(RVA = "0x30A1FB0", Offset = "0x30A13B0", Length = "0x135")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstancedIndirect", HasExplicitThis = True)]
	[Token(Token = "0x6001AE4")]
	private void Internal_DrawMeshInstancedIndirectGraphicsBuffer(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A1F40", Offset = "0x30A1340", Length = "0x62")]
	[Token(Token = "0x6001C59")]
	private static void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[Address(RVA = "0x30A2310", Offset = "0x30A1710", Length = "0x10F")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstancedProcedural", HasExplicitThis = True)]
	[Token(Token = "0x6001AE2")]
	private void Internal_DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A22A0", Offset = "0x30A16A0", Length = "0x62")]
	[Token(Token = "0x6001C57")]
	private static void Internal_DrawMeshInstancedProcedural_Injected(IntPtr _unity_self, IntPtr mesh, int submeshIndex, IntPtr material, int shaderPass, int count, IntPtr properties) { }

	[Address(RVA = "0x30A2890", Offset = "0x30A1C90", Length = "0x208")]
	[NativeMethod("AddDrawMultipleMeshes")]
	[Token(Token = "0x6001AD8")]
	private void Internal_DrawMultipleMeshes(Matrix4x4[] matrices, Mesh[] meshes, Int32[] subsetIndices, int count, Material material, int shaderPass, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A2820", Offset = "0x30A1C20", Length = "0x62")]
	[Token(Token = "0x6001C4D")]
	private static void Internal_DrawMultipleMeshes_Injected(IntPtr _unity_self, ref ManagedSpanWrapper matrices, Mesh[] meshes, ref ManagedSpanWrapper subsetIndices, int count, IntPtr material, int shaderPass, IntPtr properties) { }

	[Address(RVA = "0x30A2AF0", Offset = "0x30A1EF0", Length = "0x5A")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawOcclusionMesh", HasExplicitThis = True)]
	[Token(Token = "0x6001AE5")]
	private void Internal_DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	[Address(RVA = "0x30A2AA0", Offset = "0x30A1EA0", Length = "0x42")]
	[Token(Token = "0x6001C5A")]
	private static void Internal_DrawOcclusionMesh_Injected(IntPtr _unity_self, in RectInt normalizedCamViewport) { }

	[Address(RVA = "0x30A33E0", Offset = "0x30A27E0", Length = "0x102")]
	[NativeMethod("AddDrawProcedural")]
	[Token(Token = "0x6001ADB")]
	private void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A3370", Offset = "0x30A2770", Length = "0x62")]
	[Token(Token = "0x6001C50")]
	private static void Internal_DrawProcedural_Injected(IntPtr _unity_self, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, IntPtr properties) { }

	[Address(RVA = "0x30A2F20", Offset = "0x30A2320", Length = "0x125")]
	[NativeMethod("AddDrawProceduralIndexed")]
	[Token(Token = "0x6001ADC")]
	private void Internal_DrawProceduralIndexed(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A2EB0", Offset = "0x30A22B0", Length = "0x62")]
	[Token(Token = "0x6001C51")]
	private static void Internal_DrawProceduralIndexed_Injected(IntPtr _unity_self, IntPtr indexBuffer, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, IntPtr properties) { }

	[Address(RVA = "0x30A2D70", Offset = "0x30A2170", Length = "0x13F")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndexedIndirect", HasExplicitThis = True)]
	[Token(Token = "0x6001ADE")]
	private void Internal_DrawProceduralIndexedIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A2D00", Offset = "0x30A2100", Length = "0x62")]
	[Token(Token = "0x6001C53")]
	private static void Internal_DrawProceduralIndexedIndirect_Injected(IntPtr _unity_self, IntPtr indexBuffer, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[Address(RVA = "0x30A2BC0", Offset = "0x30A1FC0", Length = "0x13F")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndexedIndirect", HasExplicitThis = True)]
	[Token(Token = "0x6001AE0")]
	private void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A2B50", Offset = "0x30A1F50", Length = "0x62")]
	[Token(Token = "0x6001C55")]
	private static void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(IntPtr _unity_self, IntPtr indexBuffer, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[Address(RVA = "0x30A3250", Offset = "0x30A2650", Length = "0x110")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndirect", HasExplicitThis = True)]
	[Token(Token = "0x6001ADD")]
	private void Internal_DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A31E0", Offset = "0x30A25E0", Length = "0x62")]
	[Token(Token = "0x6001C52")]
	private static void Internal_DrawProceduralIndirect_Injected(IntPtr _unity_self, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[Address(RVA = "0x30A30C0", Offset = "0x30A24C0", Length = "0x110")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawProceduralIndirect", HasExplicitThis = True)]
	[Token(Token = "0x6001ADF")]
	private void Internal_DrawProceduralIndirectGraphicsBuffer(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x30A3050", Offset = "0x30A2450", Length = "0x62")]
	[Token(Token = "0x6001C54")]
	private static void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(IntPtr _unity_self, in Matrix4x4 matrix, IntPtr material, int shaderPass, MeshTopology topology, IntPtr bufferWithArgs, int argsOffset, IntPtr properties) { }

	[Address(RVA = "0x30A3610", Offset = "0x30A2A10", Length = "0x117")]
	[NativeMethod("AddDrawRenderer")]
	[Token(Token = "0x6001AD9")]
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[Address(RVA = "0x30A35A0", Offset = "0x30A29A0", Length = "0x62")]
	[Token(Token = "0x6001C4E")]
	private static void Internal_DrawRenderer_Injected(IntPtr _unity_self, IntPtr renderer, IntPtr material, int submeshIndex, int shaderPass) { }

	[Address(RVA = "0x30A3540", Offset = "0x30A2940", Length = "0x5A")]
	[NativeMethod("AddDrawRendererList")]
	[Token(Token = "0x6001ADA")]
	private void Internal_DrawRendererList(RendererList rendererList) { }

	[Address(RVA = "0x30A34F0", Offset = "0x30A28F0", Length = "0x42")]
	[Token(Token = "0x6001C4F")]
	private static void Internal_DrawRendererList_Injected(IntPtr _unity_self, in RendererList rendererList) { }

	[Address(RVA = "0x30A3780", Offset = "0x30A2B80", Length = "0x5A")]
	[NativeMethod("AddGenerateMips")]
	[Token(Token = "0x6001ACE")]
	private void Internal_GenerateMips(RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30A3730", Offset = "0x30A2B30", Length = "0x42")]
	[Token(Token = "0x6001C43")]
	private static void Internal_GenerateMips_Injected(IntPtr _unity_self, in RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30A3850", Offset = "0x30A2C50", Length = "0xFF")]
	[NativeMethod("AddRequestAsyncReadback")]
	[Token(Token = "0x6001A99")]
	private void Internal_RequestAsyncReadback_1(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[Address(RVA = "0x30A37E0", Offset = "0x30A2BE0", Length = "0x62")]
	[Token(Token = "0x6001C0F")]
	private static void Internal_RequestAsyncReadback_1_Injected(IntPtr _unity_self, IntPtr src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[Address(RVA = "0x30A39C0", Offset = "0x30A2DC0", Length = "0x105")]
	[NativeMethod("AddRequestAsyncReadback")]
	[Token(Token = "0x6001A9A")]
	private void Internal_RequestAsyncReadback_2(ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[Address(RVA = "0x30A3950", Offset = "0x30A2D50", Length = "0x62")]
	[Token(Token = "0x6001C10")]
	private static void Internal_RequestAsyncReadback_2_Injected(IntPtr _unity_self, IntPtr src, int size, int offset, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[Address(RVA = "0x30A3B40", Offset = "0x30A2F40", Length = "0x10B")]
	[NativeMethod("AddRequestAsyncReadback")]
	[Token(Token = "0x6001A9B")]
	private void Internal_RequestAsyncReadback_3(Texture src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[Address(RVA = "0x30A3AD0", Offset = "0x30A2ED0", Length = "0x62")]
	[Token(Token = "0x6001C11")]
	private static void Internal_RequestAsyncReadback_3_Injected(IntPtr _unity_self, IntPtr src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[Address(RVA = "0x30A3CC0", Offset = "0x30A30C0", Length = "0x10B")]
	[NativeMethod("AddRequestAsyncReadback")]
	[Token(Token = "0x6001A9C")]
	private void Internal_RequestAsyncReadback_4(Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[Address(RVA = "0x30A3C50", Offset = "0x30A3050", Length = "0x62")]
	[Token(Token = "0x6001C12")]
	private static void Internal_RequestAsyncReadback_4_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[Address(RVA = "0x30A3E40", Offset = "0x30A3240", Length = "0x111")]
	[NativeMethod("AddRequestAsyncReadback")]
	[Token(Token = "0x6001A9D")]
	private void Internal_RequestAsyncReadback_5(Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[Address(RVA = "0x30A3DD0", Offset = "0x30A31D0", Length = "0x62")]
	[Token(Token = "0x6001C13")]
	private static void Internal_RequestAsyncReadback_5_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[Address(RVA = "0x30A3FD0", Offset = "0x30A33D0", Length = "0x126")]
	[NativeMethod("AddRequestAsyncReadback")]
	[Token(Token = "0x6001A9E")]
	private void Internal_RequestAsyncReadback_6(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[Address(RVA = "0x30A3F60", Offset = "0x30A3360", Length = "0x68")]
	[Token(Token = "0x6001C14")]
	private static void Internal_RequestAsyncReadback_6_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[Address(RVA = "0x30A4170", Offset = "0x30A3570", Length = "0x126")]
	[NativeMethod("AddRequestAsyncReadback")]
	[Token(Token = "0x6001A9F")]
	private void Internal_RequestAsyncReadback_7(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[Address(RVA = "0x30A4100", Offset = "0x30A3500", Length = "0x68")]
	[Token(Token = "0x6001C15")]
	private static void Internal_RequestAsyncReadback_7_Injected(IntPtr _unity_self, IntPtr src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[Address(RVA = "0x30A4310", Offset = "0x30A3710", Length = "0xFF")]
	[NativeMethod("AddRequestAsyncReadback")]
	[Token(Token = "0x6001AA0")]
	private void Internal_RequestAsyncReadback_8(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[Address(RVA = "0x30A42A0", Offset = "0x30A36A0", Length = "0x62")]
	[Token(Token = "0x6001C16")]
	private static void Internal_RequestAsyncReadback_8_Injected(IntPtr _unity_self, IntPtr src, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[Address(RVA = "0x30A4480", Offset = "0x30A3880", Length = "0x105")]
	[NativeMethod("AddRequestAsyncReadback")]
	[Token(Token = "0x6001AA1")]
	private void Internal_RequestAsyncReadback_9(GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData = null) { }

	[Address(RVA = "0x30A4410", Offset = "0x30A3810", Length = "0x62")]
	[Token(Token = "0x6001C17")]
	private static void Internal_RequestAsyncReadback_9_Injected(IntPtr _unity_self, IntPtr src, int size, int offset, Action<AsyncGPUReadbackRequest> callback, AsyncRequestNativeArrayData* nativeArrayData) { }

	[Address(RVA = "0x30A4600", Offset = "0x30A3A00", Length = "0x103")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AB1")]
	private void Internal_SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x30A4590", Offset = "0x30A3990", Length = "0x62")]
	[Token(Token = "0x6001C26")]
	private static void Internal_SetComputeBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, IntPtr buffer) { }

	[Address(RVA = "0x30A4780", Offset = "0x30A3B80", Length = "0xF9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeConstantBufferParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AB4")]
	private void Internal_SetComputeConstantComputeBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30A4710", Offset = "0x30A3B10", Length = "0x62")]
	[Token(Token = "0x6001C29")]
	private static void Internal_SetComputeConstantComputeBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, IntPtr buffer, int offset, int size) { }

	[Address(RVA = "0x30A48F0", Offset = "0x30A3CF0", Length = "0xF9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeConstantBufferParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AB5")]
	private void Internal_SetComputeConstantGraphicsBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30A4880", Offset = "0x30A3C80", Length = "0x62")]
	[Token(Token = "0x6001C2A")]
	private static void Internal_SetComputeConstantGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, IntPtr buffer, int offset, int size) { }

	[Address(RVA = "0x30A4A60", Offset = "0x30A3E60", Length = "0x16C")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeFloats", HasExplicitThis = True)]
	[Token(Token = "0x6001AAE")]
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, Single[] values) { }

	[Address(RVA = "0x30A49F0", Offset = "0x30A3DF0", Length = "0x62")]
	[Token(Token = "0x6001C23")]
	private static void Internal_SetComputeFloats_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x30A4C40", Offset = "0x30A4040", Length = "0xF7")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AB2")]
	private void Internal_SetComputeGraphicsBufferHandleParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x30A4BD0", Offset = "0x30A3FD0", Length = "0x62")]
	[Token(Token = "0x6001C27")]
	private static void Internal_SetComputeGraphicsBufferHandleParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, in GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x30A4DB0", Offset = "0x30A41B0", Length = "0x103")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AB3")]
	private void Internal_SetComputeGraphicsBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x30A4D40", Offset = "0x30A4140", Length = "0x62")]
	[Token(Token = "0x6001C28")]
	private static void Internal_SetComputeGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, IntPtr buffer) { }

	[Address(RVA = "0x30A4F30", Offset = "0x30A4330", Length = "0x16C")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeInts", HasExplicitThis = True)]
	[Token(Token = "0x6001AAF")]
	private void Internal_SetComputeInts(ComputeShader computeShader, int nameID, Int32[] values) { }

	[Address(RVA = "0x30A4EC0", Offset = "0x30A42C0", Length = "0x62")]
	[Token(Token = "0x6001C24")]
	private static void Internal_SetComputeInts_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x30A5110", Offset = "0x30A4510", Length = "0x117")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeParamsFromMaterial", HasExplicitThis = True)]
	[Token(Token = "0x6001AB6")]
	private void Internal_SetComputeParamsFromMaterial(ComputeShader computeShader, int kernelIndex, Material material) { }

	[Address(RVA = "0x30A50A0", Offset = "0x30A44A0", Length = "0x62")]
	[Token(Token = "0x6001C2B")]
	private static void Internal_SetComputeParamsFromMaterial_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, IntPtr material) { }

	[Address(RVA = "0x30A52A0", Offset = "0x30A46A0", Length = "0x139")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeRayTracingAccelerationStructure", HasExplicitThis = True)]
	[Token(Token = "0x6001ACA")]
	private void Internal_SetComputeRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, int nameID, RayTracingAccelerationStructure accelerationStructure) { }

	[Address(RVA = "0x30A5230", Offset = "0x30A4630", Length = "0x62")]
	[Token(Token = "0x6001C3F")]
	private static void Internal_SetComputeRayTracingAccelerationStructure_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, IntPtr accelerationStructure) { }

	[Address(RVA = "0x30A5450", Offset = "0x30A4850", Length = "0xE9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeTextureParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AB0")]
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x30A53E0", Offset = "0x30A47E0", Length = "0x62")]
	[Token(Token = "0x6001C25")]
	private static void Internal_SetComputeTextureParam_Injected(IntPtr _unity_self, IntPtr computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x30A55B0", Offset = "0x30A49B0", Length = "0x133")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingAccelerationStructure", HasExplicitThis = True)]
	[Token(Token = "0x6001AC9")]
	private void Internal_SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, int nameID, RayTracingAccelerationStructure accelerationStructure) { }

	[Address(RVA = "0x30A5540", Offset = "0x30A4940", Length = "0x62")]
	[Token(Token = "0x6001C3E")]
	private static void Internal_SetRayTracingAccelerationStructure_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr accelerationStructure) { }

	[Address(RVA = "0x30A5760", Offset = "0x30A4B60", Length = "0xF9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingBufferParam", HasExplicitThis = True)]
	[Token(Token = "0x6001ABA")]
	private void Internal_SetRayTracingComputeBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x30A56F0", Offset = "0x30A4AF0", Length = "0x62")]
	[Token(Token = "0x6001C2F")]
	private static void Internal_SetRayTracingComputeBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer) { }

	[Address(RVA = "0x30A58D0", Offset = "0x30A4CD0", Length = "0xF9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingConstantBufferParam", HasExplicitThis = True)]
	[Token(Token = "0x6001ABD")]
	private void Internal_SetRayTracingConstantComputeBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30A5860", Offset = "0x30A4C60", Length = "0x62")]
	[Token(Token = "0x6001C32")]
	private static void Internal_SetRayTracingConstantComputeBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer, int offset, int size) { }

	[Address(RVA = "0x30A5A40", Offset = "0x30A4E40", Length = "0xF9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingConstantBufferParam", HasExplicitThis = True)]
	[Token(Token = "0x6001ABE")]
	private void Internal_SetRayTracingConstantGraphicsBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30A59D0", Offset = "0x30A4DD0", Length = "0x62")]
	[Token(Token = "0x6001C33")]
	private static void Internal_SetRayTracingConstantGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer, int offset, int size) { }

	[Address(RVA = "0x30A5BB0", Offset = "0x30A4FB0", Length = "0xE7")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingFloatParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AC0")]
	private void Internal_SetRayTracingFloatParam(RayTracingShader rayTracingShader, int nameID, float val) { }

	[Address(RVA = "0x30A5B40", Offset = "0x30A4F40", Length = "0x62")]
	[Token(Token = "0x6001C35")]
	private static void Internal_SetRayTracingFloatParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, float val) { }

	[Address(RVA = "0x30A5D10", Offset = "0x30A5110", Length = "0x16C")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingFloats", HasExplicitThis = True)]
	[Token(Token = "0x6001AC6")]
	private void Internal_SetRayTracingFloats(RayTracingShader rayTracingShader, int nameID, Single[] values) { }

	[Address(RVA = "0x30A5CA0", Offset = "0x30A50A0", Length = "0x62")]
	[Token(Token = "0x6001C3B")]
	private static void Internal_SetRayTracingFloats_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x30A5EF0", Offset = "0x30A52F0", Length = "0xE1")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingBufferParam", HasExplicitThis = True)]
	[Token(Token = "0x6001ABC")]
	private void Internal_SetRayTracingGraphicsBufferHandleParam(RayTracingShader rayTracingShader, int nameID, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x30A5E80", Offset = "0x30A5280", Length = "0x62")]
	[Token(Token = "0x6001C31")]
	private static void Internal_SetRayTracingGraphicsBufferHandleParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, in GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x30A6050", Offset = "0x30A5450", Length = "0xF9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingBufferParam", HasExplicitThis = True)]
	[Token(Token = "0x6001ABB")]
	private void Internal_SetRayTracingGraphicsBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x30A5FE0", Offset = "0x30A53E0", Length = "0x62")]
	[Token(Token = "0x6001C30")]
	private static void Internal_SetRayTracingGraphicsBufferParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, IntPtr buffer) { }

	[Address(RVA = "0x30A61C0", Offset = "0x30A55C0", Length = "0xE9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingIntParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AC1")]
	private void Internal_SetRayTracingIntParam(RayTracingShader rayTracingShader, int nameID, int val) { }

	[Address(RVA = "0x30A6150", Offset = "0x30A5550", Length = "0x62")]
	[Token(Token = "0x6001C36")]
	private static void Internal_SetRayTracingIntParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, int val) { }

	[Address(RVA = "0x30A6320", Offset = "0x30A5720", Length = "0x16C")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingInts", HasExplicitThis = True)]
	[Token(Token = "0x6001AC7")]
	private void Internal_SetRayTracingInts(RayTracingShader rayTracingShader, int nameID, Int32[] values) { }

	[Address(RVA = "0x30A62B0", Offset = "0x30A56B0", Length = "0x62")]
	[Token(Token = "0x6001C3C")]
	private static void Internal_SetRayTracingInts_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x30A6500", Offset = "0x30A5900", Length = "0x16C")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingMatrixArrayParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AC5")]
	private void Internal_SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x30A6490", Offset = "0x30A5890", Length = "0x62")]
	[Token(Token = "0x6001C3A")]
	private static void Internal_SetRayTracingMatrixArrayParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x30A66E0", Offset = "0x30A5AE0", Length = "0xE9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingMatrixParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AC4")]
	private void Internal_SetRayTracingMatrixParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4 val) { }

	[Address(RVA = "0x30A6670", Offset = "0x30A5A70", Length = "0x62")]
	[Token(Token = "0x6001C39")]
	private static void Internal_SetRayTracingMatrixParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, in Matrix4x4 val) { }

	[Address(RVA = "0x30A6840", Offset = "0x30A5C40", Length = "0xE9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingTextureParam", HasExplicitThis = True)]
	[Token(Token = "0x6001ABF")]
	private void Internal_SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, ref RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30A67D0", Offset = "0x30A5BD0", Length = "0x62")]
	[Token(Token = "0x6001C34")]
	private static void Internal_SetRayTracingTextureParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30A69A0", Offset = "0x30A5DA0", Length = "0x16C")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingVectorArrayParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AC3")]
	private void Internal_SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, int nameID, Vector4[] values) { }

	[Address(RVA = "0x30A6930", Offset = "0x30A5D30", Length = "0x62")]
	[Token(Token = "0x6001C38")]
	private static void Internal_SetRayTracingVectorArrayParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x30A6B80", Offset = "0x30A5F80", Length = "0xE9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetRayTracingVectorParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AC2")]
	private void Internal_SetRayTracingVectorParam(RayTracingShader rayTracingShader, int nameID, Vector4 val) { }

	[Address(RVA = "0x30A6B10", Offset = "0x30A5F10", Length = "0x62")]
	[Token(Token = "0x6001C37")]
	private static void Internal_SetRayTracingVectorParam_Injected(IntPtr _unity_self, IntPtr rayTracingShader, int nameID, in Vector4 val) { }

	[Address(RVA = "0x30A6CB0", Offset = "0x30A60B0", Length = "0x58")]
	[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetSinglePassStereo", HasExplicitThis = True)]
	[Token(Token = "0x6001AA3")]
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[Address(RVA = "0x30A6C70", Offset = "0x30A6070", Length = "0x40")]
	[Token(Token = "0x6001C19")]
	private static void Internal_SetSinglePassStereo_Injected(IntPtr _unity_self, SinglePassStereoMode mode) { }

	[Address(RVA = "0x30A0D40", Offset = "0x30A0140", Length = "0xCB")]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferCounterValue", HasExplicitThis = True)]
	[Token(Token = "0x6001B50")]
	private void InternalSetComputeBufferCounterValue(ComputeBuffer buffer, uint counterValue) { }

	[Address(RVA = "0x30A0CE0", Offset = "0x30A00E0", Length = "0x52")]
	[Token(Token = "0x6001C9E")]
	private static void InternalSetComputeBufferCounterValue_Injected(IntPtr _unity_self, IntPtr buffer, uint counterValue) { }

	[Address(RVA = "0x30A0E80", Offset = "0x30A0280", Length = "0xDD")]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001B4F")]
	private void InternalSetComputeBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x30A0E10", Offset = "0x30A0210", Length = "0x62")]
	[Token(Token = "0x6001C9D")]
	private static void InternalSetComputeBufferData_Injected(IntPtr _unity_self, IntPtr buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x30A0FD0", Offset = "0x30A03D0", Length = "0xDD")]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferNativeData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001B4E")]
	private void InternalSetComputeBufferNativeData(ComputeBuffer buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x30A0F60", Offset = "0x30A0360", Length = "0x62")]
	[Token(Token = "0x6001C9C")]
	private static void InternalSetComputeBufferNativeData_Injected(IntPtr _unity_self, IntPtr buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x30A1110", Offset = "0x30A0510", Length = "0xCB")]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferCounterValue", HasExplicitThis = True)]
	[Token(Token = "0x6001B5A")]
	private void InternalSetGraphicsBufferCounterValue(GraphicsBuffer buffer, uint counterValue) { }

	[Address(RVA = "0x30A10B0", Offset = "0x30A04B0", Length = "0x52")]
	[Token(Token = "0x6001CA1")]
	private static void InternalSetGraphicsBufferCounterValue_Injected(IntPtr _unity_self, IntPtr buffer, uint counterValue) { }

	[Address(RVA = "0x30A1250", Offset = "0x30A0650", Length = "0xDD")]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001B59")]
	private void InternalSetGraphicsBufferData(GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x30A11E0", Offset = "0x30A05E0", Length = "0x62")]
	[Token(Token = "0x6001CA0")]
	private static void InternalSetGraphicsBufferData_Injected(IntPtr _unity_self, IntPtr buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x30A13A0", Offset = "0x30A07A0", Length = "0xDD")]
	[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferNativeData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001B58")]
	private void InternalSetGraphicsBufferNativeData(GraphicsBuffer buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x30A1330", Offset = "0x30A0730", Length = "0x62")]
	[Token(Token = "0x6001C9F")]
	private static void InternalSetGraphicsBufferNativeData_Injected(IntPtr _unity_self, IntPtr buffer, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize) { }

	[Address(RVA = "0x30A6DB0", Offset = "0x30A61B0", Length = "0x9A")]
	[Token(Token = "0x6001B64")]
	public void InvokeOnRenderObjectCallbacks() { }

	[Address(RVA = "0x30A6D50", Offset = "0x30A6150", Length = "0x51")]
	[FreeFunction("RenderingCommandBuffer_Bindings::InvokeOnRenderObjectCallbacks", HasExplicitThis = True)]
	[Token(Token = "0x6001B63")]
	private void InvokeOnRenderObjectCallbacks_Internal() { }

	[Address(RVA = "0x30A6D10", Offset = "0x30A6110", Length = "0x33")]
	[Token(Token = "0x6001CA6")]
	private static void InvokeOnRenderObjectCallbacks_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30A6F40", Offset = "0x30A6340", Length = "0xE8")]
	[Token(Token = "0x6001C0D")]
	public void IssuePluginCustomBlit(IntPtr callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest, uint commandParam, uint commandFlags) { }

	[Address(RVA = "0x30A6EC0", Offset = "0x30A62C0", Length = "0x79")]
	[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginCustomBlitInternal", HasExplicitThis = True)]
	[Token(Token = "0x6001B27")]
	private void IssuePluginCustomBlitInternal(IntPtr callback, uint command, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, uint commandParam, uint commandFlags) { }

	[Address(RVA = "0x30A6E50", Offset = "0x30A6250", Length = "0x62")]
	[Token(Token = "0x6001C8C")]
	private static void IssuePluginCustomBlitInternal_Injected(IntPtr _unity_self, IntPtr callback, uint command, ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, uint commandParam, uint commandFlags) { }

	[Address(RVA = "0x30A70A0", Offset = "0x30A64A0", Length = "0xCF")]
	[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginCustomTextureUpdateInternal", HasExplicitThis = True)]
	[Token(Token = "0x6001B28")]
	private void IssuePluginCustomTextureUpdateInternal(IntPtr callback, Texture targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2) { }

	[Address(RVA = "0x30A7030", Offset = "0x30A6430", Length = "0x6D")]
	[Token(Token = "0x6001C8D")]
	private static void IssuePluginCustomTextureUpdateInternal_Injected(IntPtr _unity_self, IntPtr callback, IntPtr targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2) { }

	[Address(RVA = "0x30A7170", Offset = "0x30A6570", Length = "0x10A")]
	[Token(Token = "0x6001C0E")]
	public void IssuePluginCustomTextureUpdateV2(IntPtr callback, Texture targetTexture, uint userData) { }

	[Address(RVA = "0x30A7560", Offset = "0x30A6960", Length = "0xBB")]
	[Token(Token = "0x6001C0B")]
	public void IssuePluginEvent(IntPtr callback, int eventID) { }

	[Address(RVA = "0x30A7370", Offset = "0x30A6770", Length = "0x11D")]
	[Token(Token = "0x6001C0C")]
	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	[Address(RVA = "0x30A72F0", Offset = "0x30A66F0", Length = "0x79")]
	[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginEventAndDataInternal", HasExplicitThis = True)]
	[Token(Token = "0x6001B26")]
	private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	[Address(RVA = "0x30A7280", Offset = "0x30A6680", Length = "0x62")]
	[Token(Token = "0x6001C8B")]
	private static void IssuePluginEventAndDataInternal_Injected(IntPtr _unity_self, IntPtr callback, int eventID, IntPtr data) { }

	[Address(RVA = "0x30A74F0", Offset = "0x30A68F0", Length = "0x69")]
	[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginEventInternal", HasExplicitThis = True)]
	[Token(Token = "0x6001B1F")]
	private void IssuePluginEventInternal(IntPtr callback, int eventID) { }

	[Address(RVA = "0x30A7490", Offset = "0x30A6890", Length = "0x52")]
	[Token(Token = "0x6001C86")]
	private static void IssuePluginEventInternal_Injected(IntPtr _unity_self, IntPtr callback, int eventID) { }

	[Address(RVA = "0x30A7670", Offset = "0x30A6A70", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::MarkLateLatchMatrixShaderPropertyID", HasExplicitThis = True)]
	[Token(Token = "0x6001B19")]
	public void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID) { }

	[Address(RVA = "0x30A7620", Offset = "0x30A6A20", Length = "0x50")]
	[Token(Token = "0x6001C80")]
	private static void MarkLateLatchMatrixShaderPropertyID_Injected(IntPtr _unity_self, CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID) { }

	[Address(RVA = "0x30A7780", Offset = "0x30A6B80", Length = "0x9A")]
	[Token(Token = "0x6001B5E")]
	public void NextSubPass() { }

	[Address(RVA = "0x30A7720", Offset = "0x30A6B20", Length = "0x51")]
	[FreeFunction("RenderingCommandBuffer_Bindings::NextSubPass", HasExplicitThis = True)]
	[Token(Token = "0x6001B5D")]
	private void NextSubPass_Internal() { }

	[Address(RVA = "0x30A76E0", Offset = "0x30A6AE0", Length = "0x33")]
	[Token(Token = "0x6001CA3")]
	private static void NextSubPass_Internal_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x309CA40", Offset = "0x309BE40", Length = "0x9C")]
	[Token(Token = "0x6001B71")]
	public void Release() { }

	[Address(RVA = "0x30A7860", Offset = "0x30A6C60", Length = "0x51")]
	[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseBuffer", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6001AA7")]
	private void ReleaseBuffer() { }

	[Address(RVA = "0x30A7820", Offset = "0x30A6C20", Length = "0x33")]
	[Token(Token = "0x6001C1C")]
	private static void ReleaseBuffer_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30A85B0", Offset = "0x30A79B0", Length = "0x14E")]
	[Token(Token = "0x6001A85")]
	public void RequestAsyncReadback(ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x30A8190", Offset = "0x30A7590", Length = "0x14E")]
	[Token(Token = "0x6001A86")]
	public void RequestAsyncReadback(GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x30A7E60", Offset = "0x30A7260", Length = "0x130")]
	[Token(Token = "0x6001A84")]
	public void RequestAsyncReadback(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x30A78C0", Offset = "0x30A6CC0", Length = "0x13C")]
	[Token(Token = "0x6001A87")]
	public void RequestAsyncReadback(Texture src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x30A7A00", Offset = "0x30A6E00", Length = "0x130")]
	[Token(Token = "0x6001A83")]
	public void RequestAsyncReadback(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x30A7B40", Offset = "0x30A6F40", Length = "0x1A8")]
	[Token(Token = "0x6001A89")]
	public void RequestAsyncReadback(Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x30A8700", Offset = "0x30A7B00", Length = "0x15A")]
	[Token(Token = "0x6001A8A")]
	public void RequestAsyncReadback(Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x30A82E0", Offset = "0x30A76E0", Length = "0x164")]
	[Token(Token = "0x6001A8B")]
	public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x30A7FA0", Offset = "0x30A73A0", Length = "0x1E6")]
	[Token(Token = "0x6001A8C")]
	public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x30A7CF0", Offset = "0x30A70F0", Length = "0x167")]
	[Token(Token = "0x6001A8D")]
	public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x30A8450", Offset = "0x30A7850", Length = "0x154")]
	[Token(Token = "0x6001A88")]
	public void RequestAsyncReadback(Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A3B00", Offset = "0x7A2F00", Length = "0x125")]
	[Token(Token = "0x6001A98")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A3FA0", Offset = "0x7A33A0", Length = "0x114")]
	[Token(Token = "0x6001A96")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A3A20", Offset = "0x7A2E20", Length = "0xD4")]
	[Token(Token = "0x6001A95")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A3DA0", Offset = "0x7A31A0", Length = "0x115")]
	[Token(Token = "0x6001A94")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A3960", Offset = "0x7A2D60", Length = "0xBA")]
	[Token(Token = "0x6001A92")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A3EC0", Offset = "0x7A32C0", Length = "0xD4")]
	[Token(Token = "0x6001A91")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A4180", Offset = "0x7A3580", Length = "0xBA")]
	[Token(Token = "0x6001A90")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A4240", Offset = "0x7A3640", Length = "0xD4")]
	[Token(Token = "0x6001A8F")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A40C0", Offset = "0x7A34C0", Length = "0xBA")]
	[Token(Token = "0x6001A8E")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A4320", Offset = "0x7A3720", Length = "0xC7")]
	[Token(Token = "0x6001A93")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A3C30", Offset = "0x7A3030", Length = "0x164")]
	[Token(Token = "0x6001A97")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x30A88A0", Offset = "0x30A7CA0", Length = "0x51")]
	[Token(Token = "0x6001B68")]
	public void ResetShadingRate() { }

	[Address(RVA = "0x30A88A0", Offset = "0x30A7CA0", Length = "0x51")]
	[FreeFunction("RenderingCommandBuffer_Bindings::ResetShadingRate_Impl", HasExplicitThis = True)]
	[Token(Token = "0x6001B6C")]
	private void ResetShadingRate_Impl() { }

	[Address(RVA = "0x30A8860", Offset = "0x30A7C60", Length = "0x33")]
	[Token(Token = "0x6001CAA")]
	private static void ResetShadingRate_Impl_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30B3830", Offset = "0x30B2C30", Length = "0x1BB")]
	[Token(Token = "0x6001AD4")]
	public void set_name(string value) { }

	[Address(RVA = "0x30B37E0", Offset = "0x30B2BE0", Length = "0x42")]
	[Token(Token = "0x6001C49")]
	private static void set_name_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x30A1110", Offset = "0x30A0510", Length = "0xCB")]
	[Token(Token = "0x6001B57")]
	public void SetBufferCounterValue(GraphicsBuffer buffer, uint counterValue) { }

	[Address(RVA = "0x30A0D40", Offset = "0x30A0140", Length = "0xCB")]
	[Token(Token = "0x6001B4D")]
	public void SetBufferCounterValue(ComputeBuffer buffer, uint counterValue) { }

	[Address(RVA = "0x7A4770", Offset = "0x7A3B70", Length = "0x1A8")]
	[Token(Token = "0x6001B4C")]
	public void SetBufferData(ComputeBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A5180", Offset = "0x7A4580", Length = "0x305")]
	[Token(Token = "0x6001B55")]
	public void SetBufferData(GraphicsBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x30A8900", Offset = "0x30A7D00", Length = "0x344")]
	[Token(Token = "0x6001B54")]
	public void SetBufferData(GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A50B0", Offset = "0x7A44B0", Length = "0xC4")]
	[Token(Token = "0x6001B53")]
	public void SetBufferData(GraphicsBuffer buffer, NativeArray<T> data) { }

	[Address(RVA = "0x7A4920", Offset = "0x7A3D20", Length = "0x1FA")]
	[Token(Token = "0x6001B52")]
	public void SetBufferData(GraphicsBuffer buffer, List<T> data) { }

	[Address(RVA = "0x30A8C50", Offset = "0x30A8050", Length = "0x1F7")]
	[Token(Token = "0x6001B51")]
	public void SetBufferData(GraphicsBuffer buffer, Array data) { }

	[Address(RVA = "0x7A4DA0", Offset = "0x7A41A0", Length = "0x305")]
	[Token(Token = "0x6001B4B")]
	public void SetBufferData(ComputeBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x30A8E50", Offset = "0x30A8250", Length = "0x344")]
	[Token(Token = "0x6001B4A")]
	public void SetBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A5790", Offset = "0x7A4B90", Length = "0x93")]
	[Token(Token = "0x6001B49")]
	public void SetBufferData(ComputeBuffer buffer, NativeArray<T> data) { }

	[Address(RVA = "0x7A4570", Offset = "0x7A3970", Length = "0x1FA")]
	[Token(Token = "0x6001B48")]
	public void SetBufferData(ComputeBuffer buffer, List<T> data) { }

	[Address(RVA = "0x7A43F0", Offset = "0x7A37F0", Length = "0x173")]
	[Token(Token = "0x6001B56")]
	public void SetBufferData(GraphicsBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x30A91A0", Offset = "0x30A85A0", Length = "0x1F7")]
	[Token(Token = "0x6001B47")]
	public void SetBufferData(ComputeBuffer buffer, Array data) { }

	[Address(RVA = "0x30A93A0", Offset = "0x30A87A0", Length = "0xFF")]
	[Token(Token = "0x6001B87")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x30A4DB0", Offset = "0x30A41B0", Length = "0x103")]
	[Token(Token = "0x6001B89")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x30A96C0", Offset = "0x30A8AC0", Length = "0x10D")]
	[Token(Token = "0x6001B8A")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBuffer buffer) { }

	[Address(RVA = "0x30A4600", Offset = "0x30A3A00", Length = "0x103")]
	[Token(Token = "0x6001B85")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x30A95B0", Offset = "0x30A89B0", Length = "0x10B")]
	[Token(Token = "0x6001B88")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x30A94A0", Offset = "0x30A88A0", Length = "0x10D")]
	[Token(Token = "0x6001B86")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	[Address(RVA = "0x30A4780", Offset = "0x30A3B80", Length = "0xF9")]
	[Token(Token = "0x6001B8B")]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30A97D0", Offset = "0x30A8BD0", Length = "0x103")]
	[Token(Token = "0x6001B8E")]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30A48F0", Offset = "0x30A3CF0", Length = "0xF9")]
	[Token(Token = "0x6001B8D")]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30A98E0", Offset = "0x30A8CE0", Length = "0x103")]
	[Token(Token = "0x6001B8C")]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30A9B50", Offset = "0x30A8F50", Length = "0xF0")]
	[Token(Token = "0x6001B75")]
	public void SetComputeFloatParam(ComputeShader computeShader, string name, float val) { }

	[Address(RVA = "0x30A9A60", Offset = "0x30A8E60", Length = "0xE7")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeFloatParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AA8")]
	public void SetComputeFloatParam(ComputeShader computeShader, int nameID, float val) { }

	[Address(RVA = "0x30A99F0", Offset = "0x30A8DF0", Length = "0x62")]
	[Token(Token = "0x6001C1D")]
	private static void SetComputeFloatParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, float val) { }

	[Address(RVA = "0x30A9C60", Offset = "0x30A9060", Length = "0x4B")]
	[Token(Token = "0x6001B7B")]
	public void SetComputeFloatParams(ComputeShader computeShader, string name, Single[] values) { }

	[Address(RVA = "0x30A9C50", Offset = "0x30A9050", Length = "0xE")]
	[Token(Token = "0x6001B7C")]
	public void SetComputeFloatParams(ComputeShader computeShader, int nameID, Single[] values) { }

	[Address(RVA = "0x30A9D20", Offset = "0x30A9120", Length = "0xE9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeIntParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AA9")]
	public void SetComputeIntParam(ComputeShader computeShader, int nameID, int val) { }

	[Address(RVA = "0x30A9E10", Offset = "0x30A9210", Length = "0xF3")]
	[Token(Token = "0x6001B76")]
	public void SetComputeIntParam(ComputeShader computeShader, string name, int val) { }

	[Address(RVA = "0x30A9CB0", Offset = "0x30A90B0", Length = "0x62")]
	[Token(Token = "0x6001C1E")]
	private static void SetComputeIntParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, int val) { }

	[Address(RVA = "0x30A9F10", Offset = "0x30A9310", Length = "0x4B")]
	[Token(Token = "0x6001B7D")]
	public void SetComputeIntParams(ComputeShader computeShader, string name, Int32[] values) { }

	[Address(RVA = "0x30A9F60", Offset = "0x30A9360", Length = "0xE")]
	[Token(Token = "0x6001B7E")]
	public void SetComputeIntParams(ComputeShader computeShader, int nameID, Int32[] values) { }

	[Address(RVA = "0x30A9FE0", Offset = "0x30A93E0", Length = "0xC8")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001B0A")]
	private void SetComputeKeyword(ComputeShader computeShader, LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x30A9F70", Offset = "0x30A9370", Length = "0x64")]
	[Token(Token = "0x6001C74")]
	private static void SetComputeKeyword_Injected(IntPtr _unity_self, IntPtr computeShader, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x30AA2A0", Offset = "0x30A96A0", Length = "0x16C")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeMatrixArrayParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AAD")]
	public void SetComputeMatrixArrayParam(ComputeShader computeShader, int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x30AA120", Offset = "0x30A9520", Length = "0x176")]
	[Token(Token = "0x6001B7A")]
	public void SetComputeMatrixArrayParam(ComputeShader computeShader, string name, Matrix4x4[] values) { }

	[Address(RVA = "0x30AA0B0", Offset = "0x30A94B0", Length = "0x62")]
	[Token(Token = "0x6001C22")]
	private static void SetComputeMatrixArrayParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x30AA480", Offset = "0x30A9880", Length = "0x119")]
	[Token(Token = "0x6001B79")]
	public void SetComputeMatrixParam(ComputeShader computeShader, string name, Matrix4x4 val) { }

	[Address(RVA = "0x30AA5A0", Offset = "0x30A99A0", Length = "0xE9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeMatrixParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AAC")]
	public void SetComputeMatrixParam(ComputeShader computeShader, int nameID, Matrix4x4 val) { }

	[Address(RVA = "0x30AA410", Offset = "0x30A9810", Length = "0x62")]
	[Token(Token = "0x6001C21")]
	private static void SetComputeMatrixParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, in Matrix4x4 val) { }

	[Address(RVA = "0x30A5110", Offset = "0x30A4510", Length = "0x117")]
	[Token(Token = "0x6001B8F")]
	public void SetComputeParamsFromMaterial(ComputeShader computeShader, int kernelIndex, Material material) { }

	[Address(RVA = "0x30AA8D0", Offset = "0x30A9CD0", Length = "0x107")]
	[Token(Token = "0x6001B80")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30AA7B0", Offset = "0x30A9BB0", Length = "0x11C")]
	[Token(Token = "0x6001B83")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x30AA9E0", Offset = "0x30A9DE0", Length = "0x111")]
	[Token(Token = "0x6001B7F")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30AAC20", Offset = "0x30AA020", Length = "0x109")]
	[Token(Token = "0x6001B82")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel) { }

	[Address(RVA = "0x30AA690", Offset = "0x30A9A90", Length = "0x113")]
	[Token(Token = "0x6001B81")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel) { }

	[Address(RVA = "0x30AAB00", Offset = "0x30A9F00", Length = "0x112")]
	[Token(Token = "0x6001B84")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x30AADA0", Offset = "0x30AA1A0", Length = "0x16C")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorArrayParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AAB")]
	public void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Vector4[] values) { }

	[Address(RVA = "0x30AAF10", Offset = "0x30AA310", Length = "0x176")]
	[Token(Token = "0x6001B78")]
	public void SetComputeVectorArrayParam(ComputeShader computeShader, string name, Vector4[] values) { }

	[Address(RVA = "0x30AAD30", Offset = "0x30AA130", Length = "0x62")]
	[Token(Token = "0x6001C20")]
	private static void SetComputeVectorArrayParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x30AB1F0", Offset = "0x30AA5F0", Length = "0xFD")]
	[Token(Token = "0x6001B77")]
	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	[Address(RVA = "0x30AB100", Offset = "0x30AA500", Length = "0xE9")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorParam", HasExplicitThis = True)]
	[Token(Token = "0x6001AAA")]
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[Address(RVA = "0x30AB090", Offset = "0x30AA490", Length = "0x62")]
	[Token(Token = "0x6001C1F")]
	private static void SetComputeVectorParam_Injected(IntPtr _unity_self, IntPtr computeShader, int nameID, in Vector4 val) { }

	[Address(RVA = "0x30AB330", Offset = "0x30AA730", Length = "0x58")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetExecutionFlags", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001B10")]
	public void SetExecutionFlags(CommandBufferExecutionFlags flags) { }

	[Address(RVA = "0x30AB2F0", Offset = "0x30AA6F0", Length = "0x40")]
	[Token(Token = "0x6001C77")]
	private static void SetExecutionFlags_Injected(IntPtr _unity_self, CommandBufferExecutionFlags flags) { }

	[Address(RVA = "0x30AB3D0", Offset = "0x30AA7D0", Length = "0x58")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetFoveatedRenderingMode", HasExplicitThis = True)]
	[Token(Token = "0x6001B2D")]
	public void SetFoveatedRenderingMode(FoveatedRenderingMode foveatedRenderingMode) { }

	[Address(RVA = "0x30AB390", Offset = "0x30AA790", Length = "0x40")]
	[Token(Token = "0x6001C92")]
	private static void SetFoveatedRenderingMode_Injected(IntPtr _unity_self, FoveatedRenderingMode foveatedRenderingMode) { }

	[Address(RVA = "0x30AB5A0", Offset = "0x30AA9A0", Length = "0x7E")]
	[Token(Token = "0x6001C04")]
	public void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	[Address(RVA = "0x30AB500", Offset = "0x30AA900", Length = "0x9F")]
	[Token(Token = "0x6001C01")]
	public void SetGlobalBuffer(string name, ComputeBuffer value) { }

	[Address(RVA = "0x30AB480", Offset = "0x30AA880", Length = "0x7E")]
	[Token(Token = "0x6001C02")]
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[Address(RVA = "0x30AB620", Offset = "0x30AAA20", Length = "0x9F")]
	[Token(Token = "0x6001C03")]
	public void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	[Address(RVA = "0x30AB480", Offset = "0x30AA880", Length = "0x7E")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = True)]
	[Token(Token = "0x6001B1C")]
	private void SetGlobalBufferInternal(int nameID, ComputeBuffer value) { }

	[Address(RVA = "0x30AB430", Offset = "0x30AA830", Length = "0x50")]
	[Token(Token = "0x6001C83")]
	private static void SetGlobalBufferInternal_Injected(IntPtr _unity_self, int nameID, IntPtr value) { }

	[Address(RVA = "0x30AB710", Offset = "0x30AAB10", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalColor", HasExplicitThis = True)]
	[Token(Token = "0x6001AF8")]
	public void SetGlobalColor(int nameID, Color value) { }

	[Address(RVA = "0x30AB780", Offset = "0x30AAB80", Length = "0x84")]
	[Token(Token = "0x6001BF2")]
	public void SetGlobalColor(string name, Color value) { }

	[Address(RVA = "0x30AB6C0", Offset = "0x30AAAC0", Length = "0x50")]
	[Token(Token = "0x6001C68")]
	private static void SetGlobalColor_Injected(IntPtr _unity_self, int nameID, in Color value) { }

	[Address(RVA = "0x30AB920", Offset = "0x30AAD20", Length = "0x92")]
	[Token(Token = "0x6001C07")]
	public void SetGlobalConstantBuffer(GraphicsBuffer buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x30ABA60", Offset = "0x30AAE60", Length = "0x9E")]
	[Token(Token = "0x6001C08")]
	public void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size) { }

	[Address(RVA = "0x30AB880", Offset = "0x30AAC80", Length = "0x92")]
	[Token(Token = "0x6001C05")]
	public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x30AB9C0", Offset = "0x30AADC0", Length = "0x9E")]
	[Token(Token = "0x6001C06")]
	public void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size) { }

	[Address(RVA = "0x30AB880", Offset = "0x30AAC80", Length = "0x92")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = True)]
	[Token(Token = "0x6001B29")]
	private void SetGlobalConstantBufferInternal(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x30AB810", Offset = "0x30AAC10", Length = "0x62")]
	[Token(Token = "0x6001C8E")]
	private static void SetGlobalConstantBufferInternal_Injected(IntPtr _unity_self, IntPtr buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x30AB920", Offset = "0x30AAD20", Length = "0x92")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = True)]
	[Token(Token = "0x6001B2A")]
	private void SetGlobalConstantGraphicsBufferInternal(GraphicsBuffer buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x30ABB00", Offset = "0x30AAF00", Length = "0x62")]
	[Token(Token = "0x6001C8F")]
	private static void SetGlobalConstantGraphicsBufferInternal_Injected(IntPtr _unity_self, IntPtr buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x30ABBD0", Offset = "0x30AAFD0", Length = "0x71")]
	[NativeMethod("AddSetGlobalDepthBias")]
	[Token(Token = "0x6001B0F")]
	public void SetGlobalDepthBias(float bias, float slopeBias) { }

	[Address(RVA = "0x30ABB70", Offset = "0x30AAF70", Length = "0x53")]
	[Token(Token = "0x6001C76")]
	private static void SetGlobalDepthBias_Injected(IntPtr _unity_self, float bias, float slopeBias) { }

	[Address(RVA = "0x30AC320", Offset = "0x30AB720", Length = "0x84")]
	[Token(Token = "0x6001BEE")]
	public void SetGlobalFloat(string name, float value) { }

	[Address(RVA = "0x30AC2B0", Offset = "0x30AB6B0", Length = "0x68")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = True)]
	[Token(Token = "0x6001AF4")]
	public void SetGlobalFloat(int nameID, float value) { }

	[Address(RVA = "0x30AC260", Offset = "0x30AB660", Length = "0x50")]
	[Token(Token = "0x6001C64")]
	private static void SetGlobalFloat_Injected(IntPtr _unity_self, int nameID, float value) { }

	[Address(RVA = "0x30ABFD0", Offset = "0x30AB3D0", Length = "0x138")]
	[Token(Token = "0x6001BF5")]
	public void SetGlobalFloatArray(int nameID, List<Single> values) { }

	[Address(RVA = "0x30ABD60", Offset = "0x30AB160", Length = "0x128")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloatArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001B15")]
	public void SetGlobalFloatArray(int nameID, Single[] values) { }

	[Address(RVA = "0x30ABE90", Offset = "0x30AB290", Length = "0x135")]
	[Token(Token = "0x6001BF6")]
	public void SetGlobalFloatArray(string propertyName, Single[] values) { }

	[Address(RVA = "0x30AC110", Offset = "0x30AB510", Length = "0x145")]
	[Token(Token = "0x6001BF4")]
	public void SetGlobalFloatArray(string propertyName, List<Single> values) { }

	[Address(RVA = "0x30ABD10", Offset = "0x30AB110", Length = "0x50")]
	[Token(Token = "0x6001C7C")]
	private static void SetGlobalFloatArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x30ABCA0", Offset = "0x30AB0A0", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloatArrayListImpl", HasExplicitThis = True)]
	[Token(Token = "0x6001B12")]
	private void SetGlobalFloatArrayListImpl(int nameID, object values) { }

	[Address(RVA = "0x30ABC50", Offset = "0x30AB050", Length = "0x50")]
	[Token(Token = "0x6001C79")]
	private static void SetGlobalFloatArrayListImpl_Injected(IntPtr _unity_self, int nameID, object values) { }

	[Address(RVA = "0x30AB5A0", Offset = "0x30AA9A0", Length = "0x7E")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = True)]
	[Token(Token = "0x6001B1D")]
	private void SetGlobalGraphicsBufferInternal(int nameID, GraphicsBuffer value) { }

	[Address(RVA = "0x30AC3B0", Offset = "0x30AB7B0", Length = "0x50")]
	[Token(Token = "0x6001C84")]
	private static void SetGlobalGraphicsBufferInternal_Injected(IntPtr _unity_self, int nameID, IntPtr value) { }

	[Address(RVA = "0x30AC4E0", Offset = "0x30AB8E0", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInt", HasExplicitThis = True)]
	[Token(Token = "0x6001AF5")]
	public void SetGlobalInt(int nameID, int value) { }

	[Address(RVA = "0x30AC450", Offset = "0x30AB850", Length = "0x84")]
	[Token(Token = "0x6001BEF")]
	public void SetGlobalInt(string name, int value) { }

	[Address(RVA = "0x30AC400", Offset = "0x30AB800", Length = "0x50")]
	[Token(Token = "0x6001C65")]
	private static void SetGlobalInt_Injected(IntPtr _unity_self, int nameID, int value) { }

	[Address(RVA = "0x30AC5A0", Offset = "0x30AB9A0", Length = "0x84")]
	[Token(Token = "0x6001BF0")]
	public void SetGlobalInteger(string name, int value) { }

	[Address(RVA = "0x30AC630", Offset = "0x30ABA30", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInteger", HasExplicitThis = True)]
	[Token(Token = "0x6001AF6")]
	public void SetGlobalInteger(int nameID, int value) { }

	[Address(RVA = "0x30AC550", Offset = "0x30AB950", Length = "0x50")]
	[Token(Token = "0x6001C66")]
	private static void SetGlobalInteger_Injected(IntPtr _unity_self, int nameID, int value) { }

	[Address(RVA = "0x30AC700", Offset = "0x30ABB00", Length = "0x64")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetShaderKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001B08")]
	private void SetGlobalKeyword(GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x30AC6A0", Offset = "0x30ABAA0", Length = "0x54")]
	[Token(Token = "0x6001C72")]
	private static void SetGlobalKeyword_Injected(IntPtr _unity_self, in GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x30ACE40", Offset = "0x30AC240", Length = "0x9F")]
	[Token(Token = "0x6001BF3")]
	public void SetGlobalMatrix(string name, Matrix4x4 value) { }

	[Address(RVA = "0x30ACDD0", Offset = "0x30AC1D0", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrix", HasExplicitThis = True)]
	[Token(Token = "0x6001AF9")]
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[Address(RVA = "0x30ACD80", Offset = "0x30AC180", Length = "0x50")]
	[Token(Token = "0x6001C69")]
	private static void SetGlobalMatrix_Injected(IntPtr _unity_self, int nameID, in Matrix4x4 value) { }

	[Address(RVA = "0x30AC9C0", Offset = "0x30ABDC0", Length = "0x145")]
	[Token(Token = "0x6001BFA")]
	public void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values) { }

	[Address(RVA = "0x30AC880", Offset = "0x30ABC80", Length = "0x135")]
	[Token(Token = "0x6001BFC")]
	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	[Address(RVA = "0x30ACB10", Offset = "0x30ABF10", Length = "0x138")]
	[Token(Token = "0x6001BFB")]
	public void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	[Address(RVA = "0x30ACC50", Offset = "0x30AC050", Length = "0x128")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrixArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001B17")]
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x30AC830", Offset = "0x30ABC30", Length = "0x50")]
	[Token(Token = "0x6001C7E")]
	private static void SetGlobalMatrixArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x30AC7C0", Offset = "0x30ABBC0", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrixArrayListImpl", HasExplicitThis = True)]
	[Token(Token = "0x6001B14")]
	private void SetGlobalMatrixArrayListImpl(int nameID, object values) { }

	[Address(RVA = "0x30AC770", Offset = "0x30ABB70", Length = "0x50")]
	[Token(Token = "0x6001C7B")]
	private static void SetGlobalMatrixArrayListImpl_Injected(IntPtr _unity_self, int nameID, object values) { }

	[Address(RVA = "0x30ACFC0", Offset = "0x30AC3C0", Length = "0x77")]
	[Token(Token = "0x6001C00")]
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	[Address(RVA = "0x30AD0B0", Offset = "0x30AC4B0", Length = "0xA8")]
	[Token(Token = "0x6001BFF")]
	public void SetGlobalTexture(string name, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	[Address(RVA = "0x30AD040", Offset = "0x30AC440", Length = "0x6D")]
	[Token(Token = "0x6001BFE")]
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	[Address(RVA = "0x30AD160", Offset = "0x30AC560", Length = "0x9E")]
	[Token(Token = "0x6001BFD")]
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	[Address(RVA = "0x30ACF40", Offset = "0x30AC340", Length = "0x77")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalTexture_Impl", HasExplicitThis = True)]
	[Token(Token = "0x6001B1B")]
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[Address(RVA = "0x30ACEE0", Offset = "0x30AC2E0", Length = "0x60")]
	[Token(Token = "0x6001C82")]
	private static void SetGlobalTexture_Impl_Injected(IntPtr _unity_self, int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[Address(RVA = "0x30AD8F0", Offset = "0x30ACCF0", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = True)]
	[Token(Token = "0x6001AF7")]
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[Address(RVA = "0x30AD860", Offset = "0x30ACC60", Length = "0x84")]
	[Token(Token = "0x6001BF1")]
	public void SetGlobalVector(string name, Vector4 value) { }

	[Address(RVA = "0x30AD810", Offset = "0x30ACC10", Length = "0x50")]
	[Token(Token = "0x6001C67")]
	private static void SetGlobalVector_Injected(IntPtr _unity_self, int nameID, in Vector4 value) { }

	[Address(RVA = "0x30AD6D0", Offset = "0x30ACAD0", Length = "0x135")]
	[Token(Token = "0x6001BF9")]
	public void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	[Address(RVA = "0x30AD460", Offset = "0x30AC860", Length = "0x128")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVectorArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001B16")]
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[Address(RVA = "0x30AD590", Offset = "0x30AC990", Length = "0x138")]
	[Token(Token = "0x6001BF8")]
	public void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[Address(RVA = "0x30AD310", Offset = "0x30AC710", Length = "0x145")]
	[Token(Token = "0x6001BF7")]
	public void SetGlobalVectorArray(string propertyName, List<Vector4> values) { }

	[Address(RVA = "0x30AD2C0", Offset = "0x30AC6C0", Length = "0x50")]
	[Token(Token = "0x6001C7D")]
	private static void SetGlobalVectorArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values) { }

	[Address(RVA = "0x30AD250", Offset = "0x30AC650", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVectorArrayListImpl", HasExplicitThis = True)]
	[Token(Token = "0x6001B13")]
	private void SetGlobalVectorArrayListImpl(int nameID, object values) { }

	[Address(RVA = "0x30AD200", Offset = "0x30AC600", Length = "0x50")]
	[Token(Token = "0x6001C7A")]
	private static void SetGlobalVectorArrayListImpl_Injected(IntPtr _unity_self, int nameID, object values) { }

	[Address(RVA = "0x30AD9A0", Offset = "0x30ACDA0", Length = "0x58")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetInstanceMultiplier", HasExplicitThis = True)]
	[Token(Token = "0x6001B2C")]
	public void SetInstanceMultiplier(uint multiplier) { }

	[Address(RVA = "0x30AD960", Offset = "0x30ACD60", Length = "0x40")]
	[Token(Token = "0x6001C91")]
	private static void SetInstanceMultiplier_Injected(IntPtr _unity_self, uint multiplier) { }

	[Address(RVA = "0x30ADA50", Offset = "0x30ACE50", Length = "0x5B")]
	[NativeMethod("AddSetInvertCulling")]
	[Token(Token = "0x6001AA2")]
	public void SetInvertCulling(bool invertCulling) { }

	[Address(RVA = "0x30ADA00", Offset = "0x30ACE00", Length = "0x42")]
	[Token(Token = "0x6001C18")]
	private static void SetInvertCulling_Injected(IntPtr _unity_self, bool invertCulling) { }

	[Address(RVA = "0x30ADAB0", Offset = "0x30ACEB0", Length = "0xE0")]
	[Token(Token = "0x6001B0D")]
	public void SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x30ADC10", Offset = "0x30AD010", Length = "0xE0")]
	[Token(Token = "0x6001B0C")]
	public void SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x30ADBA0", Offset = "0x30ACFA0", Length = "0x67")]
	[Token(Token = "0x6001B0B")]
	public void SetKeyword(in GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x30ADD50", Offset = "0x30AD150", Length = "0x11A")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetLateLatchProjectionMatrices", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001B18")]
	public void SetLateLatchProjectionMatrices(Matrix4x4[] projectionMat) { }

	[Address(RVA = "0x30ADD00", Offset = "0x30AD100", Length = "0x42")]
	[Token(Token = "0x6001C7F")]
	private static void SetLateLatchProjectionMatrices_Injected(IntPtr _unity_self, ref ManagedSpanWrapper projectionMat) { }

	[Address(RVA = "0x30ADEE0", Offset = "0x30AD2E0", Length = "0xC8")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetMaterialKeyword", HasExplicitThis = True)]
	[Token(Token = "0x6001B09")]
	private void SetMaterialKeyword(Material material, LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x30ADE70", Offset = "0x30AD270", Length = "0x64")]
	[Token(Token = "0x6001C73")]
	private static void SetMaterialKeyword_Injected(IntPtr _unity_self, IntPtr material, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x30AE450", Offset = "0x30AD850", Length = "0xB7")]
	[Token(Token = "0x6001BE0")]
	public void SetRandomWriteTarget(int index, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30AE5F0", Offset = "0x30AD9F0", Length = "0xD9")]
	[Token(Token = "0x6001BE1")]
	public void SetRandomWriteTarget(int index, ComputeBuffer buffer, bool preserveCounterValue) { }

	[Address(RVA = "0x30AE370", Offset = "0x30AD770", Length = "0xD8")]
	[Token(Token = "0x6001BE4")]
	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer) { }

	[Address(RVA = "0x30AE510", Offset = "0x30AD910", Length = "0xD9")]
	[Token(Token = "0x6001BE3")]
	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue) { }

	[Address(RVA = "0x30AE290", Offset = "0x30AD690", Length = "0xD8")]
	[Token(Token = "0x6001BE2")]
	public void SetRandomWriteTarget(int index, ComputeBuffer buffer) { }

	[Address(RVA = "0x30AE020", Offset = "0x30AD420", Length = "0x94")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Buffer", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001AE7")]
	private void SetRandomWriteTarget_Buffer(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	[Address(RVA = "0x30ADFB0", Offset = "0x30AD3B0", Length = "0x62")]
	[Token(Token = "0x6001C5C")]
	private static void SetRandomWriteTarget_Buffer_Injected(IntPtr _unity_self, int index, IntPtr uav, bool preserveCounterValue) { }

	[Address(RVA = "0x30AE130", Offset = "0x30AD530", Length = "0x94")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Buffer", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001AE8")]
	private void SetRandomWriteTarget_GraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue) { }

	[Address(RVA = "0x30AE0C0", Offset = "0x30AD4C0", Length = "0x62")]
	[Token(Token = "0x6001C5D")]
	private static void SetRandomWriteTarget_GraphicsBuffer_Injected(IntPtr _unity_self, int index, IntPtr uav, bool preserveCounterValue) { }

	[Address(RVA = "0x30AE220", Offset = "0x30AD620", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Texture", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001AE6")]
	private void SetRandomWriteTarget_Texture(int index, ref RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30AE1D0", Offset = "0x30AD5D0", Length = "0x50")]
	[Token(Token = "0x6001C5B")]
	private static void SetRandomWriteTarget_Texture_Injected(IntPtr _unity_self, int index, ref RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30AE820", Offset = "0x30ADC20", Length = "0x13D")]
	[Token(Token = "0x6001B96")]
	public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x30AE6D0", Offset = "0x30ADAD0", Length = "0x143")]
	[Token(Token = "0x6001B98")]
	public void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x30A52A0", Offset = "0x30A46A0", Length = "0x139")]
	[Token(Token = "0x6001B99")]
	public void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x30A55B0", Offset = "0x30A49B0", Length = "0x133")]
	[Token(Token = "0x6001B97")]
	public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x30AEB60", Offset = "0x30ADF60", Length = "0x103")]
	[Token(Token = "0x6001B9A")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer) { }

	[Address(RVA = "0x30A5760", Offset = "0x30A4B60", Length = "0xF9")]
	[Token(Token = "0x6001B9B")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x30AE960", Offset = "0x30ADD60", Length = "0x103")]
	[Token(Token = "0x6001B9C")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer) { }

	[Address(RVA = "0x30A6050", Offset = "0x30A5450", Length = "0xF9")]
	[Token(Token = "0x6001B9D")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x30AEA70", Offset = "0x30ADE70", Length = "0xE9")]
	[Token(Token = "0x6001B9E")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x30AEC70", Offset = "0x30AE070", Length = "0xE1")]
	[Token(Token = "0x6001B9F")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x30A58D0", Offset = "0x30A4CD0", Length = "0xF9")]
	[Token(Token = "0x6001BA0")]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30AED60", Offset = "0x30AE160", Length = "0x103")]
	[Token(Token = "0x6001BA1")]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30A5A40", Offset = "0x30A4E40", Length = "0xF9")]
	[Token(Token = "0x6001BA2")]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30AEE70", Offset = "0x30AE270", Length = "0x103")]
	[Token(Token = "0x6001BA3")]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x30AEF80", Offset = "0x30AE380", Length = "0xF0")]
	[Token(Token = "0x6001BA6")]
	public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, string name, float val) { }

	[Address(RVA = "0x30A5BB0", Offset = "0x30A4FB0", Length = "0xE7")]
	[Token(Token = "0x6001BA7")]
	public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, int nameID, float val) { }

	[Address(RVA = "0x30AF080", Offset = "0x30AE480", Length = "0x4B")]
	[Token(Token = "0x6001BA8")]
	public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, string name, Single[] values) { }

	[Address(RVA = "0x30AF0D0", Offset = "0x30AE4D0", Length = "0xE")]
	[Token(Token = "0x6001BA9")]
	public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, int nameID, Single[] values) { }

	[Address(RVA = "0x30AF0E0", Offset = "0x30AE4E0", Length = "0xF3")]
	[Token(Token = "0x6001BAA")]
	public void SetRayTracingIntParam(RayTracingShader rayTracingShader, string name, int val) { }

	[Address(RVA = "0x30A61C0", Offset = "0x30A55C0", Length = "0xE9")]
	[Token(Token = "0x6001BAB")]
	public void SetRayTracingIntParam(RayTracingShader rayTracingShader, int nameID, int val) { }

	[Address(RVA = "0x30AF1F0", Offset = "0x30AE5F0", Length = "0x4B")]
	[Token(Token = "0x6001BAC")]
	public void SetRayTracingIntParams(RayTracingShader rayTracingShader, string name, Int32[] values) { }

	[Address(RVA = "0x30AF1E0", Offset = "0x30AE5E0", Length = "0xE")]
	[Token(Token = "0x6001BAD")]
	public void SetRayTracingIntParams(RayTracingShader rayTracingShader, int nameID, Int32[] values) { }

	[Address(RVA = "0x30AF290", Offset = "0x30AE690", Length = "0xE")]
	[Token(Token = "0x6001BB5")]
	public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x30AF240", Offset = "0x30AE640", Length = "0x4B")]
	[Token(Token = "0x6001BB4")]
	public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, string name, Matrix4x4[] values) { }

	[Address(RVA = "0x30AF3B0", Offset = "0x30AE7B0", Length = "0x119")]
	[Token(Token = "0x6001BB2")]
	public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, string name, Matrix4x4 val) { }

	[Address(RVA = "0x30AF2A0", Offset = "0x30AE6A0", Length = "0x106")]
	[Token(Token = "0x6001BB3")]
	public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4 val) { }

	[Address(RVA = "0x30AF530", Offset = "0x30AE930", Length = "0x21B")]
	[NativeMethod("AddSetRayTracingShaderPass")]
	[Token(Token = "0x6001ACB")]
	public void SetRayTracingShaderPass(RayTracingShader rayTracingShader, string passName) { }

	[Address(RVA = "0x30AF4D0", Offset = "0x30AE8D0", Length = "0x52")]
	[Token(Token = "0x6001C40")]
	private static void SetRayTracingShaderPass_Injected(IntPtr _unity_self, IntPtr rayTracingShader, ref ManagedSpanWrapper passName) { }

	[Address(RVA = "0x30AF750", Offset = "0x30AEB50", Length = "0xE9")]
	[Token(Token = "0x6001BA5")]
	public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30AF840", Offset = "0x30AEC40", Length = "0xF3")]
	[Token(Token = "0x6001BA4")]
	public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, string name, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30AF950", Offset = "0x30AED50", Length = "0x4B")]
	[Token(Token = "0x6001BB0")]
	public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, string name, Vector4[] values) { }

	[Address(RVA = "0x30AF940", Offset = "0x30AED40", Length = "0xE")]
	[Token(Token = "0x6001BB1")]
	public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, int nameID, Vector4[] values) { }

	[Address(RVA = "0x30AFA90", Offset = "0x30AEE90", Length = "0xFD")]
	[Token(Token = "0x6001BAE")]
	public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, string name, Vector4 val) { }

	[Address(RVA = "0x30AF9A0", Offset = "0x30AEDA0", Length = "0xE5")]
	[Token(Token = "0x6001BAF")]
	public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, int nameID, Vector4 val) { }

	[Address(RVA = "0x30B07B0", Offset = "0x30AFBB0", Length = "0x255")]
	[Token(Token = "0x6001B3D")]
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x30B2890", Offset = "0x30B1C90", Length = "0x226")]
	[Token(Token = "0x6001B3C")]
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	[Address(RVA = "0x30B0A10", Offset = "0x30AFE10", Length = "0x1AA")]
	[Token(Token = "0x6001B3B")]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Address(RVA = "0x30B2280", Offset = "0x30B1680", Length = "0x2BE")]
	[Token(Token = "0x6001B3A")]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x30B0570", Offset = "0x30AF970", Length = "0x235")]
	[Token(Token = "0x6001B38")]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel) { }

	[Address(RVA = "0x30B2540", Offset = "0x30B1940", Length = "0x144")]
	[Token(Token = "0x6001B37")]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	[Address(RVA = "0x30B1EB0", Offset = "0x30B12B0", Length = "0x26C")]
	[Token(Token = "0x6001B36")]
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x30B2690", Offset = "0x30B1A90", Length = "0x1F8")]
	[Token(Token = "0x6001B35")]
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace) { }

	[Address(RVA = "0x30B15E0", Offset = "0x30B09E0", Length = "0x1DA")]
	[Token(Token = "0x6001B34")]
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel) { }

	[Address(RVA = "0x30B0400", Offset = "0x30AF800", Length = "0x169")]
	[Token(Token = "0x6001B33")]
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Address(RVA = "0x30B2120", Offset = "0x30B1520", Length = "0x150")]
	[Token(Token = "0x6001B32")]
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[Address(RVA = "0x30B0BC0", Offset = "0x30AFFC0", Length = "0x237")]
	[Token(Token = "0x6001B39")]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace) { }

	[Address(RVA = "0x30B14F0", Offset = "0x30B08F0", Length = "0xE7")]
	[Token(Token = "0x6001B31")]
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	[Address(RVA = "0x30B17C0", Offset = "0x30B0BC0", Length = "0x6E6")]
	[Token(Token = "0x6001B3E")]
	public void SetRenderTarget(RenderTargetBinding binding, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x30B0E00", Offset = "0x30B0200", Length = "0x6E5")]
	[Token(Token = "0x6001B3F")]
	public void SetRenderTarget(RenderTargetBinding binding) { }

	[Address(RVA = "0x30AFD30", Offset = "0x30AF130", Length = "0x9F")]
	[Token(Token = "0x6001B43")]
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	[Address(RVA = "0x30AFCC0", Offset = "0x30AF0C0", Length = "0x62")]
	[Token(Token = "0x6001C98")]
	private static void SetRenderTargetColorDepth_Internal_Injected(IntPtr _unity_self, in RenderTargetIdentifier color, in RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	[Address(RVA = "0x30AFC00", Offset = "0x30AF000", Length = "0xBF")]
	[Token(Token = "0x6001B45")]
	private void SetRenderTargetColorDepthSubtarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x30AFB90", Offset = "0x30AEF90", Length = "0x62")]
	[Token(Token = "0x6001C9A")]
	private static void SetRenderTargetColorDepthSubtarget_Injected(IntPtr _unity_self, in RenderTargetIdentifier color, in RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x30B00E0", Offset = "0x30AF4E0", Length = "0x217")]
	[Token(Token = "0x6001B44")]
	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	[Address(RVA = "0x30B0070", Offset = "0x30AF470", Length = "0x62")]
	[Token(Token = "0x6001C99")]
	private static void SetRenderTargetMulti_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, in RenderTargetIdentifier depth, ref ManagedSpanWrapper colorLoadActions, ref ManagedSpanWrapper colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	[Address(RVA = "0x30AFE40", Offset = "0x30AF240", Length = "0x225")]
	[Token(Token = "0x6001B46")]
	private void SetRenderTargetMultiSubtarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x30AFDD0", Offset = "0x30AF1D0", Length = "0x62")]
	[Token(Token = "0x6001C9B")]
	private static void SetRenderTargetMultiSubtarget_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, in RenderTargetIdentifier depth, ref ManagedSpanWrapper colorLoadActions, ref ManagedSpanWrapper colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x30B0370", Offset = "0x30AF770", Length = "0x89")]
	[Token(Token = "0x6001B42")]
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Address(RVA = "0x30B0300", Offset = "0x30AF700", Length = "0x62")]
	[Token(Token = "0x6001C97")]
	private static void SetRenderTargetSingle_Internal_Injected(IntPtr _unity_self, in RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Address(RVA = "0x30B2B10", Offset = "0x30B1F10", Length = "0x67")]
	[Token(Token = "0x6001B66")]
	public void SetShadingRateCombiner(ShadingRateCombinerStage stage, ShadingRateCombiner combiner) { }

	[Address(RVA = "0x30B2B10", Offset = "0x30B1F10", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetShadingRateCombiner_Impl", HasExplicitThis = True)]
	[Token(Token = "0x6001B6A")]
	private void SetShadingRateCombiner_Impl(ShadingRateCombinerStage stage, ShadingRateCombiner combiner) { }

	[Address(RVA = "0x30B2AC0", Offset = "0x30B1EC0", Length = "0x50")]
	[Token(Token = "0x6001CA8")]
	private static void SetShadingRateCombiner_Impl_Injected(IntPtr _unity_self, ShadingRateCombinerStage stage, ShadingRateCombiner combiner) { }

	[Address(RVA = "0x30B2BC0", Offset = "0x30B1FC0", Length = "0x58")]
	[Token(Token = "0x6001B65")]
	public void SetShadingRateFragmentSize(ShadingRateFragmentSize shadingRateFragmentSize) { }

	[Address(RVA = "0x30B2BC0", Offset = "0x30B1FC0", Length = "0x58")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetShadingRateFragmentSize_Impl", HasExplicitThis = True)]
	[Token(Token = "0x6001B69")]
	private void SetShadingRateFragmentSize_Impl(ShadingRateFragmentSize shadingRateFragmentSize) { }

	[Address(RVA = "0x30B2B80", Offset = "0x30B1F80", Length = "0x40")]
	[Token(Token = "0x6001CA7")]
	private static void SetShadingRateFragmentSize_Impl_Injected(IntPtr _unity_self, ShadingRateFragmentSize shadingRateFragmentSize) { }

	[Address(RVA = "0x30B2C70", Offset = "0x30B2070", Length = "0x5A")]
	[Token(Token = "0x6001B67")]
	public void SetShadingRateImage(in RenderTargetIdentifier shadingRateImage) { }

	[Address(RVA = "0x30B2C70", Offset = "0x30B2070", Length = "0x5A")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetShadingRateImage_Impl", HasExplicitThis = True)]
	[Token(Token = "0x6001B6B")]
	private void SetShadingRateImage_Impl(in RenderTargetIdentifier shadingRateImage) { }

	[Address(RVA = "0x30B2C20", Offset = "0x30B2020", Length = "0x42")]
	[Token(Token = "0x6001CA9")]
	private static void SetShadingRateImage_Impl_Injected(IntPtr _unity_self, in RenderTargetIdentifier shadingRateImage) { }

	[Address(RVA = "0x30B2DA0", Offset = "0x30B21A0", Length = "0xB9")]
	[Token(Token = "0x6001C09")]
	public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[Address(RVA = "0x30B2D30", Offset = "0x30B2130", Length = "0x69")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetShadowSamplingMode_Impl", HasExplicitThis = True)]
	[Token(Token = "0x6001B1E")]
	private void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[Address(RVA = "0x30B2CD0", Offset = "0x30B20D0", Length = "0x52")]
	[Token(Token = "0x6001C85")]
	private static void SetShadowSamplingMode_Impl_Injected(IntPtr _unity_self, ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[Address(RVA = "0x30A6CB0", Offset = "0x30A60B0", Length = "0x58")]
	[Token(Token = "0x6001C0A")]
	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	[Address(RVA = "0x30B31B0", Offset = "0x30B25B0", Length = "0x107")]
	[Token(Token = "0x6001B62")]
	public void SetupCameraProperties(Camera camera) { }

	[Address(RVA = "0x30B30E0", Offset = "0x30B24E0", Length = "0xC7")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetupCameraProperties", HasExplicitThis = True)]
	[Token(Token = "0x6001B61")]
	private void SetupCameraProperties_Internal(Camera camera) { }

	[Address(RVA = "0x30B3090", Offset = "0x30B2490", Length = "0x42")]
	[Token(Token = "0x6001CA5")]
	private static void SetupCameraProperties_Internal_Injected(IntPtr _unity_self, IntPtr camera) { }

	[Address(RVA = "0x30B2F80", Offset = "0x30B2380", Length = "0x5A")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewport", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001AEA")]
	public void SetViewport(Rect pixelRect) { }

	[Address(RVA = "0x30B2F30", Offset = "0x30B2330", Length = "0x42")]
	[Token(Token = "0x6001C5F")]
	private static void SetViewport_Injected(IntPtr _unity_self, in Rect pixelRect) { }

	[Address(RVA = "0x30B2EC0", Offset = "0x30B22C0", Length = "0x69")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetViewProjectionMatrices", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001B0E")]
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[Address(RVA = "0x30B2E60", Offset = "0x30B2260", Length = "0x52")]
	[Token(Token = "0x6001C75")]
	private static void SetViewProjectionMatrices_Injected(IntPtr _unity_self, in Matrix4x4 view, in Matrix4x4 proj) { }

	[Address(RVA = "0x30B3030", Offset = "0x30B2430", Length = "0x5B")]
	[FreeFunction("RenderingCommandBuffer_Bindings::SetWireframe", HasExplicitThis = True)]
	[Token(Token = "0x6001B2E")]
	public void SetWireframe(bool enable) { }

	[Address(RVA = "0x30B2FE0", Offset = "0x30B23E0", Length = "0x42")]
	[Token(Token = "0x6001C93")]
	private static void SetWireframe_Injected(IntPtr _unity_self, bool enable) { }

	[Address(RVA = "0x30B3300", Offset = "0x30B2700", Length = "0x58")]
	[FreeFunction("RenderingCommandBuffer_Bindings::UnmarkLateLatchMatrix", HasExplicitThis = True)]
	[Token(Token = "0x6001B1A")]
	public void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType) { }

	[Address(RVA = "0x30B32C0", Offset = "0x30B26C0", Length = "0x40")]
	[Token(Token = "0x6001C81")]
	private static void UnmarkLateLatchMatrix_Injected(IntPtr _unity_self, CameraLateLatchMatrixType matrixPropertyType) { }

	[Address(RVA = "0x30B33B0", Offset = "0x30B27B0", Length = "0x67")]
	[FreeFunction("RenderingCommandBuffer_Bindings::ValidateAgainstExecutionFlags", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6001B11")]
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[Address(RVA = "0x30B3360", Offset = "0x30B2760", Length = "0x50")]
	[Token(Token = "0x6001C78")]
	private static bool ValidateAgainstExecutionFlags_Injected(IntPtr _unity_self, CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[Address(RVA = "0x30B3420", Offset = "0x30B2820", Length = "0xE7")]
	[Token(Token = "0x6001B74")]
	public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStageFlags stage) { }

	[Address(RVA = "0x30B3570", Offset = "0x30B2970", Length = "0x69")]
	[FreeFunction("RenderingCommandBuffer_Bindings::WaitOnGPUFence_Internal", HasExplicitThis = True)]
	[Token(Token = "0x6001AA6")]
	private void WaitOnGPUFence_Internal(IntPtr fencePtr, SynchronisationStageFlags stage) { }

	[Address(RVA = "0x30B3510", Offset = "0x30B2910", Length = "0x52")]
	[Token(Token = "0x6001C1B")]
	private static void WaitOnGPUFence_Internal_Injected(IntPtr _unity_self, IntPtr fencePtr, SynchronisationStageFlags stage) { }

}

