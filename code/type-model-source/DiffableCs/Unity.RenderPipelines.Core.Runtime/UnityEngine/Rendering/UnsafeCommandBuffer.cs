namespace UnityEngine.Rendering;

[Token(Token = "0x2000027")]
public class UnsafeCommandBuffer : BaseCommandBuffer, IUnsafeCommandBuffer, IBaseCommandBuffer, IRasterCommandBuffer, IComputeCommandBuffer
{

	[Address(RVA = "0x2BBDA40", Offset = "0x2BBCE40", Length = "0xE")]
	[Token(Token = "0x6000329")]
	internal UnsafeCommandBuffer(CommandBuffer wrapped, RenderGraphPass executingPass, bool isAsync) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600036F")]
	public override void BeginSample(ProfilerMarker marker) { }

	[Address(RVA = "0x2BBB670", Offset = "0x2BBAA70", Length = "0x1E")]
	[Token(Token = "0x600036D")]
	public override void BeginSample(CustomSampler sampler) { }

	[Address(RVA = "0x2BBB650", Offset = "0x2BBAA50", Length = "0x1E")]
	[Token(Token = "0x600036B")]
	public override void BeginSample(string name) { }

	[Address(RVA = "0x2BBB6C0", Offset = "0x2BBAAC0", Length = "0x1E")]
	[Token(Token = "0x60003BB")]
	public override void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure) { }

	[Address(RVA = "0x2BBB6E0", Offset = "0x2BBAAE0", Length = "0x37")]
	[Token(Token = "0x60003BC")]
	public override void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, Vector3 relativeOrigin) { }

	[Address(RVA = "0x2BBB690", Offset = "0x2BBAA90", Length = "0x2D")]
	[Token(Token = "0x60003BD")]
	public override void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, BuildSettings buildSettings) { }

	[Address(RVA = "0x2BC5C50", Offset = "0x2BC5050", Length = "0x1D")]
	[Token(Token = "0x6000348")]
	public override void Clear() { }

	[Address(RVA = "0x2BC5C30", Offset = "0x2BC5030", Length = "0x1D")]
	[Token(Token = "0x6000349")]
	public override void ClearRandomWriteTargets() { }

	[Address(RVA = "0x2BC3FC0", Offset = "0x2BC33C0", Length = "0x3B")]
	[Token(Token = "0x6000350")]
	public override void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil) { }

	[Address(RVA = "0x2BC4000", Offset = "0x2BC3400", Length = "0x24")]
	[Token(Token = "0x6000351")]
	public override void ClearRenderTarget(RTClearFlags clearFlags, Color[] backgroundColors, float depth, uint stencil) { }

	[Address(RVA = "0x2BC3EF0", Offset = "0x2BC32F0", Length = "0x4D")]
	[Token(Token = "0x600034F")]
	public override void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth, uint stencil) { }

	[Address(RVA = "0x2BC3F80", Offset = "0x2BC3380", Length = "0x3F")]
	[Token(Token = "0x600034E")]
	public override void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[Address(RVA = "0x2BC3F40", Offset = "0x2BC3340", Length = "0x33")]
	[Token(Token = "0x600034D")]
	public override void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[Address(RVA = "0x2BC4030", Offset = "0x2BC3430", Length = "0x1E")]
	[Token(Token = "0x6000375")]
	public override void ConfigureFoveatedRendering(IntPtr platformData) { }

	[Address(RVA = "0x2BBB750", Offset = "0x2BBAB50", Length = "0x24")]
	[Token(Token = "0x600040F")]
	public override void CopyCounterValue(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x2BBB780", Offset = "0x2BBAB80", Length = "0x24")]
	[Token(Token = "0x6000410")]
	public override void CopyCounterValue(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x2BBB7B0", Offset = "0x2BBABB0", Length = "0x24")]
	[Token(Token = "0x6000411")]
	public override void CopyCounterValue(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x2BBB720", Offset = "0x2BBAB20", Length = "0x24")]
	[Token(Token = "0x6000412")]
	public override void CopyCounterValue(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x2BC5C70", Offset = "0x2BC5070", Length = "0x65")]
	[Token(Token = "0x6000413")]
	public override void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	[Address(RVA = "0x2BC5E40", Offset = "0x2BC5240", Length = "0x90")]
	[Token(Token = "0x6000415")]
	public override void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	[Address(RVA = "0x2BC5DC0", Offset = "0x2BC51C0", Length = "0x77")]
	[Token(Token = "0x6000414")]
	public override void CopyTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement) { }

	[Address(RVA = "0x2BC5CE0", Offset = "0x2BC50E0", Length = "0xD6")]
	[Token(Token = "0x6000416")]
	public override void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[Address(RVA = "0x2BBB800", Offset = "0x2BBAC00", Length = "0x1E")]
	[Token(Token = "0x600035F")]
	public void DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB820", Offset = "0x2BBAC20", Length = "0x1E")]
	[Token(Token = "0x600035E")]
	public void DisableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB7E0", Offset = "0x2BBABE0", Length = "0x1E")]
	[Token(Token = "0x600035D")]
	public void DisableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB840", Offset = "0x2BBAC40", Length = "0x1D")]
	[Token(Token = "0x600034C")]
	public override void DisableScissorRect() { }

	[Address(RVA = "0x2BBB860", Offset = "0x2BBAC60", Length = "0x1E")]
	[Token(Token = "0x600035C")]
	public override void DisableShaderKeyword(string keyword) { }

	[Address(RVA = "0x2BBB8E0", Offset = "0x2BBACE0", Length = "0x27")]
	[Token(Token = "0x60003B8")]
	public override void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[Address(RVA = "0x2BBB880", Offset = "0x2BBAC80", Length = "0x24")]
	[Token(Token = "0x60003B9")]
	public override void DispatchCompute(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset) { }

	[Address(RVA = "0x2BBB8B0", Offset = "0x2BBACB0", Length = "0x24")]
	[Token(Token = "0x60003BA")]
	public override void DispatchCompute(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset) { }

	[Address(RVA = "0x2BBB910", Offset = "0x2BBAD10", Length = "0x27")]
	[Token(Token = "0x60003E0")]
	public override void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, Camera camera) { }

	[Address(RVA = "0x2BBB940", Offset = "0x2BBAD40", Length = "0x27")]
	[Token(Token = "0x60003E1")]
	public override void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, GraphicsBuffer argsBuffer, uint argsOffset, Camera camera) { }

	[Address(RVA = "0x2BC4300", Offset = "0x2BC3700", Length = "0x51")]
	[Token(Token = "0x60003E7")]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	[Address(RVA = "0x2BC42A0", Offset = "0x2BC36A0", Length = "0x5C")]
	[Token(Token = "0x60003E6")]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	[Address(RVA = "0x2BC4230", Offset = "0x2BC3630", Length = "0x6D")]
	[Token(Token = "0x60003E5")]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	[Address(RVA = "0x2BC4360", Offset = "0x2BC3760", Length = "0x7A")]
	[Token(Token = "0x60003E4")]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC41A0", Offset = "0x2BC35A0", Length = "0x27")]
	[Token(Token = "0x6000400")]
	public override void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count) { }

	[Address(RVA = "0x2BC4200", Offset = "0x2BC3600", Length = "0x27")]
	[Token(Token = "0x60003FF")]
	public override void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC41D0", Offset = "0x2BC35D0", Length = "0x27")]
	[Token(Token = "0x6000401")]
	public override void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices) { }

	[Address(RVA = "0x2BC4140", Offset = "0x2BC3540", Length = "0x27")]
	[Token(Token = "0x6000407")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC4080", Offset = "0x2BC3480", Length = "0x27")]
	[Token(Token = "0x6000404")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC4050", Offset = "0x2BC3450", Length = "0x27")]
	[Token(Token = "0x6000403")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC40B0", Offset = "0x2BC34B0", Length = "0x27")]
	[Token(Token = "0x6000406")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC40E0", Offset = "0x2BC34E0", Length = "0x27")]
	[Token(Token = "0x6000405")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC4110", Offset = "0x2BC3510", Length = "0x27")]
	[Token(Token = "0x6000408")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC4170", Offset = "0x2BC3570", Length = "0x27")]
	[Token(Token = "0x6000402")]
	public override void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC43E0", Offset = "0x2BC37E0", Length = "0x27")]
	[Token(Token = "0x60003E8")]
	public override void DrawMultipleMeshes(Matrix4x4[] matrices, Mesh[] meshes, Int32[] subsetIndices, int count, Material material, int shaderPass, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4410", Offset = "0x2BC3810", Length = "0x2C")]
	[Token(Token = "0x6000409")]
	public override void DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	[Address(RVA = "0x2BC4AA0", Offset = "0x2BC3EA0", Length = "0x8E")]
	[Token(Token = "0x60003F0")]
	public override void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4CB0", Offset = "0x2BC40B0", Length = "0x78")]
	[Token(Token = "0x60003F2")]
	public override void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount) { }

	[Address(RVA = "0x2BC4C30", Offset = "0x2BC4030", Length = "0x7F")]
	[Token(Token = "0x60003ED")]
	public override void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4B30", Offset = "0x2BC3F30", Length = "0x81")]
	[Token(Token = "0x60003F1")]
	public override void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount) { }

	[Address(RVA = "0x2BC4D30", Offset = "0x2BC4130", Length = "0x74")]
	[Token(Token = "0x60003EE")]
	public override void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount) { }

	[Address(RVA = "0x2BC4BC0", Offset = "0x2BC3FC0", Length = "0x69")]
	[Token(Token = "0x60003EF")]
	public override void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount) { }

	[Address(RVA = "0x2BC46D0", Offset = "0x2BC3AD0", Length = "0x90")]
	[Token(Token = "0x60003F6")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4770", Offset = "0x2BC3B70", Length = "0x90")]
	[Token(Token = "0x60003FC")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4A10", Offset = "0x2BC3E10", Length = "0x81")]
	[Token(Token = "0x60003F9")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4650", Offset = "0x2BC3A50", Length = "0x7A")]
	[Token(Token = "0x60003F8")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC4900", Offset = "0x2BC3D00", Length = "0x83")]
	[Token(Token = "0x60003F7")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC4550", Offset = "0x2BC3950", Length = "0x83")]
	[Token(Token = "0x60003FD")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC4810", Offset = "0x2BC3C10", Length = "0x6B")]
	[Token(Token = "0x60003FB")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC44D0", Offset = "0x2BC38D0", Length = "0x7A")]
	[Token(Token = "0x60003FE")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC4880", Offset = "0x2BC3C80", Length = "0x76")]
	[Token(Token = "0x60003FA")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC4990", Offset = "0x2BC3D90", Length = "0x76")]
	[Token(Token = "0x60003F4")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC4440", Offset = "0x2BC3840", Length = "0x81")]
	[Token(Token = "0x60003F3")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC45E0", Offset = "0x2BC39E0", Length = "0x6B")]
	[Token(Token = "0x60003F5")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC4DF0", Offset = "0x2BC41F0", Length = "0x1E")]
	[Token(Token = "0x60003EB")]
	public override void DrawRenderer(Renderer renderer, Material material) { }

	[Address(RVA = "0x2BC4E40", Offset = "0x2BC4240", Length = "0x24")]
	[Token(Token = "0x60003E9")]
	public override void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[Address(RVA = "0x2BC4E10", Offset = "0x2BC4210", Length = "0x24")]
	[Token(Token = "0x60003EA")]
	public override void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	[Address(RVA = "0x2BC4DB0", Offset = "0x2BC41B0", Length = "0x37")]
	[Token(Token = "0x60003EC")]
	public override void DrawRendererList(RendererList rendererList) { }

	[Address(RVA = "0x2BBB990", Offset = "0x2BBAD90", Length = "0x1E")]
	[Token(Token = "0x600035B")]
	public void EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB970", Offset = "0x2BBAD70", Length = "0x1E")]
	[Token(Token = "0x6000359")]
	public void EnableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB9B0", Offset = "0x2BBADB0", Length = "0x1E")]
	[Token(Token = "0x600035A")]
	public void EnableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB9D0", Offset = "0x2BBADD0", Length = "0x2C")]
	[Token(Token = "0x600034B")]
	public override void EnableScissorRect(Rect scissor) { }

	[Address(RVA = "0x2BBBA00", Offset = "0x2BBAE00", Length = "0x1E")]
	[Token(Token = "0x6000358")]
	public override void EnableShaderKeyword(string keyword) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000370")]
	public override void EndSample(ProfilerMarker marker) { }

	[Address(RVA = "0x2BBBA40", Offset = "0x2BBAE40", Length = "0x1E")]
	[Token(Token = "0x600036E")]
	public override void EndSample(CustomSampler sampler) { }

	[Address(RVA = "0x2BBBA20", Offset = "0x2BBAE20", Length = "0x1E")]
	[Token(Token = "0x600036C")]
	public override void EndSample(string name) { }

	[Address(RVA = "0x2BC5F30", Offset = "0x2BC5330", Length = "0x1E")]
	[Token(Token = "0x60003E3")]
	public override void GenerateMips(RenderTexture rt) { }

	[Address(RVA = "0x2BC5EE0", Offset = "0x2BC52E0", Length = "0x40")]
	[Token(Token = "0x60003E2")]
	public override void GenerateMips(RenderTargetIdentifier rt) { }

	[Address(RVA = "0x2BBBA60", Offset = "0x2BBAE60", Length = "0x40")]
	[Token(Token = "0x6000371")]
	public override void IncrementUpdateCount(RenderTargetIdentifier dest) { }

	[Address(RVA = "0x2BBBAB0", Offset = "0x2BBAEB0", Length = "0x1D")]
	[Token(Token = "0x6000394")]
	public override void InvokeOnRenderObjectCallbacks() { }

	[Address(RVA = "0x2BBBAD0", Offset = "0x2BBAED0", Length = "0x93")]
	[Token(Token = "0x600043A")]
	public override void IssuePluginCustomBlit(IntPtr callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest, uint commandParam, uint commandFlags) { }

	[Address(RVA = "0x2BBBB70", Offset = "0x2BBAF70", Length = "0x24")]
	[Token(Token = "0x600043B")]
	public override void IssuePluginCustomTextureUpdateV2(IntPtr callback, Texture targetTexture, uint userData) { }

	[Address(RVA = "0x2BBBBD0", Offset = "0x2BBAFD0", Length = "0x1E")]
	[Token(Token = "0x6000438")]
	public override void IssuePluginEvent(IntPtr callback, int eventID) { }

	[Address(RVA = "0x2BBBBA0", Offset = "0x2BBAFA0", Length = "0x24")]
	[Token(Token = "0x6000439")]
	public override void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	[Address(RVA = "0x2BBBBF0", Offset = "0x2BBAFF0", Length = "0x1E")]
	[Token(Token = "0x6000369")]
	public override void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID) { }

	[Address(RVA = "0x2BC5FB0", Offset = "0x2BC53B0", Length = "0x24")]
	[Token(Token = "0x600032D")]
	public override void RequestAsyncReadback(GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x2BC6010", Offset = "0x2BC5410", Length = "0x1E")]
	[Token(Token = "0x600032B")]
	public override void RequestAsyncReadback(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x2BC6060", Offset = "0x2BC5460", Length = "0x24")]
	[Token(Token = "0x600032C")]
	public override void RequestAsyncReadback(ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x2BC6090", Offset = "0x2BC5490", Length = "0x1E")]
	[Token(Token = "0x600032E")]
	public override void RequestAsyncReadback(Texture src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x2BC5FE0", Offset = "0x2BC53E0", Length = "0x24")]
	[Token(Token = "0x600032F")]
	public override void RequestAsyncReadback(Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x2BC60B0", Offset = "0x2BC54B0", Length = "0x24")]
	[Token(Token = "0x6000330")]
	public override void RequestAsyncReadback(Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x2BC5F50", Offset = "0x2BC5350", Length = "0x24")]
	[Token(Token = "0x6000331")]
	public override void RequestAsyncReadback(Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x2BC5F80", Offset = "0x2BC5380", Length = "0x27")]
	[Token(Token = "0x6000332")]
	public override void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x2BC6030", Offset = "0x2BC5430", Length = "0x27")]
	[Token(Token = "0x6000333")]
	public override void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x2BC60E0", Offset = "0x2BC54E0", Length = "0x27")]
	[Token(Token = "0x6000334")]
	public override void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x2BC6110", Offset = "0x2BC5510", Length = "0x1E")]
	[Token(Token = "0x600032A")]
	public override void RequestAsyncReadback(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A7920", Offset = "0x7A6D20", Length = "0x84")]
	[Token(Token = "0x600033B")]
	public override void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x9D7E70", Offset = "0x9D7270", Length = "0x7E")]
	[Token(Token = "0x6000339")]
	public override void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x9D7E70", Offset = "0x9D7270", Length = "0x7E")]
	[Token(Token = "0x6000335")]
	public override void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x9D7E70", Offset = "0x9D7270", Length = "0x7E")]
	[Token(Token = "0x6000337")]
	public override void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A7920", Offset = "0x7A6D20", Length = "0x84")]
	[Token(Token = "0x6000336")]
	public override void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A7920", Offset = "0x7A6D20", Length = "0x84")]
	[Token(Token = "0x600033C")]
	public override void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x7A7920", Offset = "0x7A6D20", Length = "0x84")]
	[Token(Token = "0x6000338")]
	public override void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x9D7EF0", Offset = "0x9D72F0", Length = "0x87")]
	[Token(Token = "0x600033D")]
	public override void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x9D7F80", Offset = "0x9D7380", Length = "0x7E")]
	[Token(Token = "0x600033A")]
	public override void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x9D7DE0", Offset = "0x9D71E0", Length = "0x87")]
	[Token(Token = "0x600033F")]
	public override void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x9D7DE0", Offset = "0x9D71E0", Length = "0x87")]
	[Token(Token = "0x600033E")]
	public override void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x2BBBC10", Offset = "0x2BBB010", Length = "0x1E")]
	[Token(Token = "0x6000392")]
	public override void SetBufferCounterValue(GraphicsBuffer buffer, uint counterValue) { }

	[Address(RVA = "0x2BBBC30", Offset = "0x2BBB030", Length = "0x1E")]
	[Token(Token = "0x600038B")]
	public override void SetBufferCounterValue(ComputeBuffer buffer, uint counterValue) { }

	[Address(RVA = "0x2BBBCD0", Offset = "0x2BBB0D0", Length = "0x1E")]
	[Token(Token = "0x6000385")]
	public override void SetBufferData(ComputeBuffer buffer, Array data) { }

	[Address(RVA = "0x7A7A20", Offset = "0x7A6E20", Length = "0x65")]
	[Token(Token = "0x6000386")]
	public override void SetBufferData(ComputeBuffer buffer, List<T> data) { }

	[Address(RVA = "0x2BBBC80", Offset = "0x2BBB080", Length = "0x27")]
	[Token(Token = "0x6000388")]
	public override void SetBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A7920", Offset = "0x7A6D20", Length = "0x84")]
	[Token(Token = "0x6000389")]
	public override void SetBufferData(ComputeBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A7A90", Offset = "0x7A6E90", Length = "0xA3")]
	[Token(Token = "0x600038A")]
	public override void SetBufferData(ComputeBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A79B0", Offset = "0x7A6DB0", Length = "0x6F")]
	[Token(Token = "0x6000387")]
	public override void SetBufferData(ComputeBuffer buffer, NativeArray<T> data) { }

	[Address(RVA = "0x7A7A20", Offset = "0x7A6E20", Length = "0x65")]
	[Token(Token = "0x600038D")]
	public override void SetBufferData(GraphicsBuffer buffer, List<T> data) { }

	[Address(RVA = "0x7A79B0", Offset = "0x7A6DB0", Length = "0x6F")]
	[Token(Token = "0x600038E")]
	public override void SetBufferData(GraphicsBuffer buffer, NativeArray<T> data) { }

	[Address(RVA = "0x2BBBC50", Offset = "0x2BBB050", Length = "0x27")]
	[Token(Token = "0x600038F")]
	public override void SetBufferData(GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A7920", Offset = "0x7A6D20", Length = "0x84")]
	[Token(Token = "0x6000390")]
	public override void SetBufferData(GraphicsBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A7A90", Offset = "0x7A6E90", Length = "0xA3")]
	[Token(Token = "0x6000391")]
	public override void SetBufferData(GraphicsBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x2BBBCB0", Offset = "0x2BBB0B0", Length = "0x1E")]
	[Token(Token = "0x600038C")]
	public override void SetBufferData(GraphicsBuffer buffer, Array data) { }

	[Address(RVA = "0x2BBBD20", Offset = "0x2BBB120", Length = "0x24")]
	[Token(Token = "0x60003AE")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	[Address(RVA = "0x2BBBD50", Offset = "0x2BBB150", Length = "0x24")]
	[Token(Token = "0x60003B2")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBuffer buffer) { }

	[Address(RVA = "0x2BBBCF0", Offset = "0x2BBB0F0", Length = "0x24")]
	[Token(Token = "0x60003B1")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x2BBBDE0", Offset = "0x2BBB1E0", Length = "0x24")]
	[Token(Token = "0x60003B0")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x2BBBD80", Offset = "0x2BBB180", Length = "0x24")]
	[Token(Token = "0x60003AF")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x2BBBDB0", Offset = "0x2BBB1B0", Length = "0x24")]
	[Token(Token = "0x60003AD")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x2BBBE40", Offset = "0x2BBB240", Length = "0x27")]
	[Token(Token = "0x60003B5")]
	public override void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBBEA0", Offset = "0x2BBB2A0", Length = "0x27")]
	[Token(Token = "0x60003B4")]
	public override void SetComputeConstantBufferParam(ComputeShader computeShader, string name, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBBE10", Offset = "0x2BBB210", Length = "0x27")]
	[Token(Token = "0x60003B3")]
	public override void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBBE70", Offset = "0x2BBB270", Length = "0x27")]
	[Token(Token = "0x60003B6")]
	public override void SetComputeConstantBufferParam(ComputeShader computeShader, string name, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBBF00", Offset = "0x2BBB300", Length = "0x24")]
	[Token(Token = "0x6000341")]
	public override void SetComputeFloatParam(ComputeShader computeShader, int nameID, float val) { }

	[Address(RVA = "0x2BBBED0", Offset = "0x2BBB2D0", Length = "0x24")]
	[Token(Token = "0x6000397")]
	public override void SetComputeFloatParam(ComputeShader computeShader, string name, float val) { }

	[Address(RVA = "0x2BBBF60", Offset = "0x2BBB360", Length = "0x24")]
	[Token(Token = "0x600039D")]
	public override void SetComputeFloatParams(ComputeShader computeShader, string name, Single[] values) { }

	[Address(RVA = "0x2BBBF30", Offset = "0x2BBB330", Length = "0x24")]
	[Token(Token = "0x600039E")]
	public override void SetComputeFloatParams(ComputeShader computeShader, int nameID, Single[] values) { }

	[Address(RVA = "0x2BBBF90", Offset = "0x2BBB390", Length = "0x24")]
	[Token(Token = "0x6000342")]
	public override void SetComputeIntParam(ComputeShader computeShader, int nameID, int val) { }

	[Address(RVA = "0x2BBBFC0", Offset = "0x2BBB3C0", Length = "0x24")]
	[Token(Token = "0x6000398")]
	public override void SetComputeIntParam(ComputeShader computeShader, string name, int val) { }

	[Address(RVA = "0x2BBBFF0", Offset = "0x2BBB3F0", Length = "0x24")]
	[Token(Token = "0x600039F")]
	public override void SetComputeIntParams(ComputeShader computeShader, string name, Int32[] values) { }

	[Address(RVA = "0x2BBC020", Offset = "0x2BBB420", Length = "0x24")]
	[Token(Token = "0x60003A0")]
	public override void SetComputeIntParams(ComputeShader computeShader, int nameID, Int32[] values) { }

	[Address(RVA = "0x2BBC050", Offset = "0x2BBB450", Length = "0x24")]
	[Token(Token = "0x6000346")]
	public override void SetComputeMatrixArrayParam(ComputeShader computeShader, int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBC080", Offset = "0x2BBB480", Length = "0x24")]
	[Token(Token = "0x600039C")]
	public override void SetComputeMatrixArrayParam(ComputeShader computeShader, string name, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBC110", Offset = "0x2BBB510", Length = "0x51")]
	[Token(Token = "0x6000345")]
	public override void SetComputeMatrixParam(ComputeShader computeShader, int nameID, Matrix4x4 val) { }

	[Address(RVA = "0x2BBC0B0", Offset = "0x2BBB4B0", Length = "0x51")]
	[Token(Token = "0x600039B")]
	public override void SetComputeMatrixParam(ComputeShader computeShader, string name, Matrix4x4 val) { }

	[Address(RVA = "0x2BBC170", Offset = "0x2BBB570", Length = "0x24")]
	[Token(Token = "0x60003B7")]
	public override void SetComputeParamsFromMaterial(ComputeShader computeShader, int kernelIndex, Material material) { }

	[Address(RVA = "0x2BC6130", Offset = "0x2BC5530", Length = "0xF6")]
	[Token(Token = "0x60003AC")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BC6530", Offset = "0x2BC5930", Length = "0x69")]
	[Token(Token = "0x60003AB")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BC6600", Offset = "0x2BC5A00", Length = "0x5E")]
	[Token(Token = "0x60003A5")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel) { }

	[Address(RVA = "0x2BC6230", Offset = "0x2BC5630", Length = "0xEB")]
	[Token(Token = "0x60003A6")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt, int mipLevel) { }

	[Address(RVA = "0x2BC6850", Offset = "0x2BC5C50", Length = "0xDD")]
	[Token(Token = "0x60003A4")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt) { }

	[Address(RVA = "0x2BC6390", Offset = "0x2BC5790", Length = "0x53")]
	[Token(Token = "0x60003A3")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x2BC63F0", Offset = "0x2BC57F0", Length = "0xDD")]
	[Token(Token = "0x60003A2")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt) { }

	[Address(RVA = "0x2BC65A0", Offset = "0x2BC59A0", Length = "0x5E")]
	[Token(Token = "0x60003A7")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel) { }

	[Address(RVA = "0x2BC6660", Offset = "0x2BC5A60", Length = "0xEB")]
	[Token(Token = "0x60003A8")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt, int mipLevel) { }

	[Address(RVA = "0x2BC64D0", Offset = "0x2BC58D0", Length = "0x53")]
	[Token(Token = "0x60003A1")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x2BC6750", Offset = "0x2BC5B50", Length = "0xF6")]
	[Token(Token = "0x60003AA")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BC6320", Offset = "0x2BC5720", Length = "0x69")]
	[Token(Token = "0x60003A9")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BBC770", Offset = "0x2BBBB70", Length = "0x24")]
	[Token(Token = "0x600039A")]
	public override void SetComputeVectorArrayParam(ComputeShader computeShader, string name, Vector4[] values) { }

	[Address(RVA = "0x2BBC740", Offset = "0x2BBBB40", Length = "0x24")]
	[Token(Token = "0x6000344")]
	public override void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Vector4[] values) { }

	[Address(RVA = "0x2BBC7A0", Offset = "0x2BBBBA0", Length = "0x33")]
	[Token(Token = "0x6000399")]
	public override void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	[Address(RVA = "0x2BBC7E0", Offset = "0x2BBBBE0", Length = "0x33")]
	[Token(Token = "0x6000343")]
	public override void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[Address(RVA = "0x2BC4E70", Offset = "0x2BC4270", Length = "0x1E")]
	[Token(Token = "0x6000373")]
	public override void SetFoveatedRenderingMode(FoveatedRenderingMode foveatedRenderingMode) { }

	[Address(RVA = "0x2BBC820", Offset = "0x2BBBC20", Length = "0x1E")]
	[Token(Token = "0x600042F")]
	public override void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[Address(RVA = "0x2BBC840", Offset = "0x2BBBC40", Length = "0x1E")]
	[Token(Token = "0x600042E")]
	public override void SetGlobalBuffer(string name, ComputeBuffer value) { }

	[Address(RVA = "0x2BBC860", Offset = "0x2BBBC60", Length = "0x1E")]
	[Token(Token = "0x6000431")]
	public override void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	[Address(RVA = "0x2BBC880", Offset = "0x2BBBC80", Length = "0x1E")]
	[Token(Token = "0x6000430")]
	public override void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	[Address(RVA = "0x2BBC8D0", Offset = "0x2BBBCD0", Length = "0x2D")]
	[Token(Token = "0x600041B")]
	public override void SetGlobalColor(string name, Color value) { }

	[Address(RVA = "0x2BBC8A0", Offset = "0x2BBBCA0", Length = "0x2D")]
	[Token(Token = "0x6000356")]
	public override void SetGlobalColor(int nameID, Color value) { }

	[Address(RVA = "0x2BBC930", Offset = "0x2BBBD30", Length = "0x24")]
	[Token(Token = "0x6000433")]
	public override void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size) { }

	[Address(RVA = "0x2BBC960", Offset = "0x2BBBD60", Length = "0x24")]
	[Token(Token = "0x6000435")]
	public override void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size) { }

	[Address(RVA = "0x2BBC900", Offset = "0x2BBBD00", Length = "0x24")]
	[Token(Token = "0x6000434")]
	public override void SetGlobalConstantBuffer(GraphicsBuffer buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x2BBC990", Offset = "0x2BBBD90", Length = "0x24")]
	[Token(Token = "0x6000432")]
	public override void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x2BBC9C0", Offset = "0x2BBBDC0", Length = "0x1E")]
	[Token(Token = "0x6000364")]
	public override void SetGlobalDepthBias(float bias, float slopeBias) { }

	[Address(RVA = "0x2BBCA80", Offset = "0x2BBBE80", Length = "0x1E")]
	[Token(Token = "0x6000417")]
	public override void SetGlobalFloat(string name, float value) { }

	[Address(RVA = "0x2BBCA60", Offset = "0x2BBBE60", Length = "0x1E")]
	[Token(Token = "0x6000352")]
	public override void SetGlobalFloat(int nameID, float value) { }

	[Address(RVA = "0x2BBCA40", Offset = "0x2BBBE40", Length = "0x1E")]
	[Token(Token = "0x600041D")]
	public override void SetGlobalFloatArray(string propertyName, List<Single> values) { }

	[Address(RVA = "0x2BBCA00", Offset = "0x2BBBE00", Length = "0x1E")]
	[Token(Token = "0x600041E")]
	public override void SetGlobalFloatArray(int nameID, List<Single> values) { }

	[Address(RVA = "0x2BBC9E0", Offset = "0x2BBBDE0", Length = "0x1E")]
	[Token(Token = "0x600041F")]
	public override void SetGlobalFloatArray(string propertyName, Single[] values) { }

	[Address(RVA = "0x2BBCA20", Offset = "0x2BBBE20", Length = "0x1E")]
	[Token(Token = "0x6000365")]
	public override void SetGlobalFloatArray(int nameID, Single[] values) { }

	[Address(RVA = "0x2BBCAA0", Offset = "0x2BBBEA0", Length = "0x1E")]
	[Token(Token = "0x6000353")]
	public override void SetGlobalInt(int nameID, int value) { }

	[Address(RVA = "0x2BBCAC0", Offset = "0x2BBBEC0", Length = "0x1E")]
	[Token(Token = "0x6000418")]
	public override void SetGlobalInt(string name, int value) { }

	[Address(RVA = "0x2BBCB00", Offset = "0x2BBBF00", Length = "0x1E")]
	[Token(Token = "0x6000354")]
	public override void SetGlobalInteger(int nameID, int value) { }

	[Address(RVA = "0x2BBCAE0", Offset = "0x2BBBEE0", Length = "0x1E")]
	[Token(Token = "0x6000419")]
	public override void SetGlobalInteger(string name, int value) { }

	[Address(RVA = "0x2BBCBA0", Offset = "0x2BBBFA0", Length = "0x4B")]
	[Token(Token = "0x6000357")]
	public override void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[Address(RVA = "0x2BBCBF0", Offset = "0x2BBBFF0", Length = "0x4B")]
	[Token(Token = "0x600041C")]
	public override void SetGlobalMatrix(string name, Matrix4x4 value) { }

	[Address(RVA = "0x2BBCB80", Offset = "0x2BBBF80", Length = "0x1E")]
	[Token(Token = "0x6000424")]
	public override void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	[Address(RVA = "0x2BBCB40", Offset = "0x2BBBF40", Length = "0x1E")]
	[Token(Token = "0x6000425")]
	public override void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBCB60", Offset = "0x2BBBF60", Length = "0x1E")]
	[Token(Token = "0x6000367")]
	public override void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBCB20", Offset = "0x2BBBF20", Length = "0x1E")]
	[Token(Token = "0x6000423")]
	public override void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values) { }

	[Address(RVA = "0x2BC6BA0", Offset = "0x2BC5FA0", Length = "0x49")]
	[Token(Token = "0x600042B")]
	public override void SetGlobalTexture(string name, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BC6BF0", Offset = "0x2BC5FF0", Length = "0xCD")]
	[Token(Token = "0x600042A")]
	public override void SetGlobalTexture(string name, TextureHandle value, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BC6CC0", Offset = "0x2BC60C0", Length = "0xCB")]
	[Token(Token = "0x600042C")]
	public override void SetGlobalTexture(int nameID, TextureHandle value, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BC6930", Offset = "0x2BC5D30", Length = "0x49")]
	[Token(Token = "0x600042D")]
	public override void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BC6B00", Offset = "0x2BC5F00", Length = "0x43")]
	[Token(Token = "0x6000427")]
	public override void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	[Address(RVA = "0x2BC6B50", Offset = "0x2BC5F50", Length = "0x43")]
	[Token(Token = "0x6000429")]
	public override void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	[Address(RVA = "0x2BC6980", Offset = "0x2BC5D80", Length = "0xB8")]
	[Token(Token = "0x6000426")]
	public override void SetGlobalTexture(string name, TextureHandle value) { }

	[Address(RVA = "0x2BC6A40", Offset = "0x2BC5E40", Length = "0xB6")]
	[Token(Token = "0x6000428")]
	public override void SetGlobalTexture(int nameID, TextureHandle value) { }

	[Address(RVA = "0x2BBD010", Offset = "0x2BBC410", Length = "0x2D")]
	[Token(Token = "0x600041A")]
	public override void SetGlobalVector(string name, Vector4 value) { }

	[Address(RVA = "0x2BBCFE0", Offset = "0x2BBC3E0", Length = "0x2D")]
	[Token(Token = "0x6000355")]
	public override void SetGlobalVector(int nameID, Vector4 value) { }

	[Address(RVA = "0x2BBCFA0", Offset = "0x2BBC3A0", Length = "0x1E")]
	[Token(Token = "0x6000366")]
	public override void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[Address(RVA = "0x2BBCF60", Offset = "0x2BBC360", Length = "0x1E")]
	[Token(Token = "0x6000420")]
	public override void SetGlobalVectorArray(string propertyName, List<Vector4> values) { }

	[Address(RVA = "0x2BBCFC0", Offset = "0x2BBC3C0", Length = "0x1E")]
	[Token(Token = "0x6000421")]
	public override void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[Address(RVA = "0x2BBCF80", Offset = "0x2BBC380", Length = "0x1E")]
	[Token(Token = "0x6000422")]
	public override void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	[Address(RVA = "0x2BC51B0", Offset = "0x2BC45B0", Length = "0x1E")]
	[Token(Token = "0x6000372")]
	public override void SetInstanceMultiplier(uint multiplier) { }

	[Address(RVA = "0x2BBD040", Offset = "0x2BBC440", Length = "0x1E")]
	[Token(Token = "0x6000340")]
	public override void SetInvertCulling(bool invertCulling) { }

	[Address(RVA = "0x2BBD060", Offset = "0x2BBC460", Length = "0x1E")]
	[Token(Token = "0x6000360")]
	public void SetKeyword(in GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD0B0", Offset = "0x2BBC4B0", Length = "0x24")]
	[Token(Token = "0x6000361")]
	public void SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD080", Offset = "0x2BBC480", Length = "0x24")]
	[Token(Token = "0x6000362")]
	public void SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD0E0", Offset = "0x2BBC4E0", Length = "0x1E")]
	[Token(Token = "0x6000368")]
	public override void SetLateLatchProjectionMatrices(Matrix4x4[] projectionMat) { }

	[Address(RVA = "0x2BC6E40", Offset = "0x2BC6240", Length = "0x1E")]
	[Token(Token = "0x600040C")]
	public override void SetRandomWriteTarget(int index, ComputeBuffer buffer) { }

	[Address(RVA = "0x2BC6DF0", Offset = "0x2BC61F0", Length = "0x43")]
	[Token(Token = "0x600040A")]
	public override void SetRandomWriteTarget(int index, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x2BC6DC0", Offset = "0x2BC61C0", Length = "0x24")]
	[Token(Token = "0x600040D")]
	public override void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue) { }

	[Address(RVA = "0x2BC6E60", Offset = "0x2BC6260", Length = "0x1E")]
	[Token(Token = "0x600040E")]
	public override void SetRandomWriteTarget(int index, GraphicsBuffer buffer) { }

	[Address(RVA = "0x2BC6D90", Offset = "0x2BC6190", Length = "0x24")]
	[Token(Token = "0x600040B")]
	public override void SetRandomWriteTarget(int index, ComputeBuffer buffer, bool preserveCounterValue) { }

	[Address(RVA = "0x2BBD100", Offset = "0x2BBC500", Length = "0x24")]
	[Token(Token = "0x60003C1")]
	public override void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x2BBD160", Offset = "0x2BBC560", Length = "0x24")]
	[Token(Token = "0x60003C0")]
	public override void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x2BBD130", Offset = "0x2BBC530", Length = "0x24")]
	[Token(Token = "0x60003BF")]
	public override void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x2BBD190", Offset = "0x2BBC590", Length = "0x24")]
	[Token(Token = "0x60003BE")]
	public override void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x2BBD280", Offset = "0x2BBC680", Length = "0x24")]
	[Token(Token = "0x60003C2")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer) { }

	[Address(RVA = "0x2BBD2B0", Offset = "0x2BBC6B0", Length = "0x24")]
	[Token(Token = "0x60003C3")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x2BBD1F0", Offset = "0x2BBC5F0", Length = "0x24")]
	[Token(Token = "0x60003C4")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer) { }

	[Address(RVA = "0x2BBD250", Offset = "0x2BBC650", Length = "0x24")]
	[Token(Token = "0x60003C5")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x2BBD1C0", Offset = "0x2BBC5C0", Length = "0x24")]
	[Token(Token = "0x60003C6")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x2BBD220", Offset = "0x2BBC620", Length = "0x24")]
	[Token(Token = "0x60003C7")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x2BBD310", Offset = "0x2BBC710", Length = "0x27")]
	[Token(Token = "0x60003C9")]
	public override void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBD370", Offset = "0x2BBC770", Length = "0x27")]
	[Token(Token = "0x60003C8")]
	public override void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBD340", Offset = "0x2BBC740", Length = "0x27")]
	[Token(Token = "0x60003CA")]
	public override void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBD2E0", Offset = "0x2BBC6E0", Length = "0x27")]
	[Token(Token = "0x60003CB")]
	public override void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBD3A0", Offset = "0x2BBC7A0", Length = "0x24")]
	[Token(Token = "0x60003D0")]
	public override void SetRayTracingFloatParam(RayTracingShader rayTracingShader, string name, float val) { }

	[Address(RVA = "0x2BBD3D0", Offset = "0x2BBC7D0", Length = "0x24")]
	[Token(Token = "0x60003D1")]
	public override void SetRayTracingFloatParam(RayTracingShader rayTracingShader, int nameID, float val) { }

	[Address(RVA = "0x2BBD430", Offset = "0x2BBC830", Length = "0x24")]
	[Token(Token = "0x60003D3")]
	public override void SetRayTracingFloatParams(RayTracingShader rayTracingShader, int nameID, Single[] values) { }

	[Address(RVA = "0x2BBD400", Offset = "0x2BBC800", Length = "0x24")]
	[Token(Token = "0x60003D2")]
	public override void SetRayTracingFloatParams(RayTracingShader rayTracingShader, string name, Single[] values) { }

	[Address(RVA = "0x2BBD490", Offset = "0x2BBC890", Length = "0x24")]
	[Token(Token = "0x60003D5")]
	public override void SetRayTracingIntParam(RayTracingShader rayTracingShader, int nameID, int val) { }

	[Address(RVA = "0x2BBD460", Offset = "0x2BBC860", Length = "0x24")]
	[Token(Token = "0x60003D4")]
	public override void SetRayTracingIntParam(RayTracingShader rayTracingShader, string name, int val) { }

	[Address(RVA = "0x2BBD4C0", Offset = "0x2BBC8C0", Length = "0x24")]
	[Token(Token = "0x60003D7")]
	public override void SetRayTracingIntParams(RayTracingShader rayTracingShader, int nameID, Int32[] values) { }

	[Address(RVA = "0x2BBD4F0", Offset = "0x2BBC8F0", Length = "0x24")]
	[Token(Token = "0x60003D6")]
	public override void SetRayTracingIntParams(RayTracingShader rayTracingShader, string name, Int32[] values) { }

	[Address(RVA = "0x2BBD550", Offset = "0x2BBC950", Length = "0x24")]
	[Token(Token = "0x60003DF")]
	public override void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBD520", Offset = "0x2BBC920", Length = "0x24")]
	[Token(Token = "0x60003DE")]
	public override void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, string name, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBD580", Offset = "0x2BBC980", Length = "0x51")]
	[Token(Token = "0x60003DD")]
	public override void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4 val) { }

	[Address(RVA = "0x2BBD5E0", Offset = "0x2BBC9E0", Length = "0x51")]
	[Token(Token = "0x60003DC")]
	public override void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, string name, Matrix4x4 val) { }

	[Address(RVA = "0x2BBD640", Offset = "0x2BBCA40", Length = "0x1E")]
	[Token(Token = "0x6000347")]
	public override void SetRayTracingShaderPass(RayTracingShader rayTracingShader, string passName) { }

	[Address(RVA = "0x2BC6F50", Offset = "0x2BC6350", Length = "0xCD")]
	[Token(Token = "0x60003CD")]
	public override void SetRayTracingTextureParam(RayTracingShader rayTracingShader, string name, TextureHandle rt) { }

	[Address(RVA = "0x2BC7020", Offset = "0x2BC6420", Length = "0x49")]
	[Token(Token = "0x60003CC")]
	public override void SetRayTracingTextureParam(RayTracingShader rayTracingShader, string name, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x2BC7070", Offset = "0x2BC6470", Length = "0x49")]
	[Token(Token = "0x60003CE")]
	public override void SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, RenderTargetIdentifier rt) { }

	[Address(RVA = "0x2BC6E80", Offset = "0x2BC6280", Length = "0xCD")]
	[Token(Token = "0x60003CF")]
	public override void SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, TextureHandle rt) { }

	[Address(RVA = "0x2BBD800", Offset = "0x2BBCC00", Length = "0x24")]
	[Token(Token = "0x60003DA")]
	public override void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, string name, Vector4[] values) { }

	[Address(RVA = "0x2BBD830", Offset = "0x2BBCC30", Length = "0x24")]
	[Token(Token = "0x60003DB")]
	public override void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, int nameID, Vector4[] values) { }

	[Address(RVA = "0x2BBD8A0", Offset = "0x2BBCCA0", Length = "0x33")]
	[Token(Token = "0x60003D8")]
	public override void SetRayTracingVectorParam(RayTracingShader rayTracingShader, string name, Vector4 val) { }

	[Address(RVA = "0x2BBD860", Offset = "0x2BBCC60", Length = "0x33")]
	[Token(Token = "0x60003D9")]
	public override void SetRayTracingVectorParam(RayTracingShader rayTracingShader, int nameID, Vector4 val) { }

	[Address(RVA = "0x2BC7630", Offset = "0x2BC6A30", Length = "0x40")]
	[Token(Token = "0x6000376")]
	public override void SetRenderTarget(RenderTargetIdentifier rt) { }

	[Address(RVA = "0x2BC7270", Offset = "0x2BC6670", Length = "0x67")]
	[Token(Token = "0x6000383")]
	public override void SetRenderTarget(RenderTargetBinding binding, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x2BC74D0", Offset = "0x2BC68D0", Length = "0x50")]
	[Token(Token = "0x6000384")]
	public override void SetRenderTarget(RenderTargetBinding binding) { }

	[Address(RVA = "0x2BC7170", Offset = "0x2BC6570", Length = "0x5F")]
	[Token(Token = "0x6000382")]
	public override void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x2BC7350", Offset = "0x2BC6750", Length = "0x43")]
	[Token(Token = "0x6000381")]
	public override void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	[Address(RVA = "0x2BC71D0", Offset = "0x2BC65D0", Length = "0x90")]
	[Token(Token = "0x6000380")]
	public override void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Address(RVA = "0x2BC75A0", Offset = "0x2BC69A0", Length = "0x82")]
	[Token(Token = "0x600037F")]
	public override void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x2BC73A0", Offset = "0x2BC67A0", Length = "0x77")]
	[Token(Token = "0x600037E")]
	public override void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace) { }

	[Address(RVA = "0x2BC7530", Offset = "0x2BC6930", Length = "0x65")]
	[Token(Token = "0x600037C")]
	public override void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	[Address(RVA = "0x2BC72E0", Offset = "0x2BC66E0", Length = "0x6A")]
	[Token(Token = "0x600037D")]
	public override void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel) { }

	[Address(RVA = "0x2BC7480", Offset = "0x2BC6880", Length = "0x46")]
	[Token(Token = "0x600037A")]
	public override void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace) { }

	[Address(RVA = "0x2BC7120", Offset = "0x2BC6520", Length = "0x40")]
	[Token(Token = "0x6000379")]
	public override void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel) { }

	[Address(RVA = "0x2BC7420", Offset = "0x2BC6820", Length = "0x5C")]
	[Token(Token = "0x6000378")]
	public override void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Address(RVA = "0x2BC7680", Offset = "0x2BC6A80", Length = "0x46")]
	[Token(Token = "0x6000377")]
	public override void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[Address(RVA = "0x2BC70C0", Offset = "0x2BC64C0", Length = "0x51")]
	[Token(Token = "0x600037B")]
	public override void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Address(RVA = "0x2BC51D0", Offset = "0x2BC45D0", Length = "0x1E")]
	[Token(Token = "0x6000396")]
	public override void SetShadingRateCombiner(ShadingRateCombinerStage stage, ShadingRateCombiner combiner) { }

	[Address(RVA = "0x2BC51F0", Offset = "0x2BC45F0", Length = "0x1E")]
	[Token(Token = "0x6000395")]
	public override void SetShadingRateFragmentSize(ShadingRateFragmentSize shadingRateFragmentSize) { }

	[Address(RVA = "0x2BBD8E0", Offset = "0x2BBCCE0", Length = "0x40")]
	[Token(Token = "0x6000436")]
	public override void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[Address(RVA = "0x2BBD930", Offset = "0x2BBCD30", Length = "0x1E")]
	[Token(Token = "0x6000437")]
	public override void SetSinglePassStereo(SinglePassStereoMode mode) { }

	[Address(RVA = "0x2BBDA00", Offset = "0x2BBCE00", Length = "0x1E")]
	[Token(Token = "0x6000393")]
	public override void SetupCameraProperties(Camera camera) { }

	[Address(RVA = "0x2BBD9D0", Offset = "0x2BBCDD0", Length = "0x2C")]
	[Token(Token = "0x600034A")]
	public override void SetViewport(Rect pixelRect) { }

	[Address(RVA = "0x2BBD950", Offset = "0x2BBCD50", Length = "0x74")]
	[Token(Token = "0x6000363")]
	public override void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[Address(RVA = "0x2BC5210", Offset = "0x2BC4610", Length = "0x1E")]
	[Token(Token = "0x6000374")]
	public override void SetWireframe(bool enable) { }

	[Address(RVA = "0x2BBB7E0", Offset = "0x2BBABE0", Length = "0x1E")]
	[Token(Token = "0x600043F")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB820", Offset = "0x2BBAC20", Length = "0x1E")]
	[Token(Token = "0x6000440")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB800", Offset = "0x2BBAC00", Length = "0x1E")]
	[Token(Token = "0x6000441")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB970", Offset = "0x2BBAD70", Length = "0x1E")]
	[Token(Token = "0x600043C")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB9B0", Offset = "0x2BBADB0", Length = "0x1E")]
	[Token(Token = "0x600043D")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB990", Offset = "0x2BBAD90", Length = "0x1E")]
	[Token(Token = "0x600043E")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBD0B0", Offset = "0x2BBC4B0", Length = "0x24")]
	[Token(Token = "0x6000443")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD060", Offset = "0x2BBC460", Length = "0x1E")]
	[Token(Token = "0x6000442")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(in GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD080", Offset = "0x2BBC480", Length = "0x24")]
	[Token(Token = "0x6000444")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBDA20", Offset = "0x2BBCE20", Length = "0x1E")]
	[Token(Token = "0x600036A")]
	public override void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType) { }

}

