namespace UnityEngine.Rendering;

[Token(Token = "0x2000026")]
public class RasterCommandBuffer : BaseCommandBuffer, IRasterCommandBuffer, IBaseCommandBuffer
{

	[Address(RVA = "0x2BBDA40", Offset = "0x2BBCE40", Length = "0xE")]
	[Token(Token = "0x60002A7")]
	internal RasterCommandBuffer(CommandBuffer wrapped, RenderGraphPass executingPass, bool isAsync) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002CE")]
	public override void BeginSample(ProfilerMarker marker) { }

	[Address(RVA = "0x2BBB670", Offset = "0x2BBAA70", Length = "0x1E")]
	[Token(Token = "0x60002CC")]
	public override void BeginSample(CustomSampler sampler) { }

	[Address(RVA = "0x2BBB650", Offset = "0x2BBAA50", Length = "0x1E")]
	[Token(Token = "0x60002CA")]
	public override void BeginSample(string name) { }

	[Address(RVA = "0x2BC3F40", Offset = "0x2BC3340", Length = "0x33")]
	[Token(Token = "0x60002AC")]
	public override void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[Address(RVA = "0x2BC3F80", Offset = "0x2BC3380", Length = "0x3F")]
	[Token(Token = "0x60002AD")]
	public override void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[Address(RVA = "0x2BC3EF0", Offset = "0x2BC32F0", Length = "0x4D")]
	[Token(Token = "0x60002AE")]
	public override void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth, uint stencil) { }

	[Address(RVA = "0x2BC3FC0", Offset = "0x2BC33C0", Length = "0x3B")]
	[Token(Token = "0x60002AF")]
	public override void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil) { }

	[Address(RVA = "0x2BC4000", Offset = "0x2BC3400", Length = "0x24")]
	[Token(Token = "0x60002B0")]
	public override void ClearRenderTarget(RTClearFlags clearFlags, Color[] backgroundColors, float depth, uint stencil) { }

	[Address(RVA = "0x2BC4030", Offset = "0x2BC3430", Length = "0x1E")]
	[Token(Token = "0x60002D4")]
	public override void ConfigureFoveatedRendering(IntPtr platformData) { }

	[Address(RVA = "0x2BBB800", Offset = "0x2BBAC00", Length = "0x1E")]
	[Token(Token = "0x60002BE")]
	public void DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB820", Offset = "0x2BBAC20", Length = "0x1E")]
	[Token(Token = "0x60002BD")]
	public void DisableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB7E0", Offset = "0x2BBABE0", Length = "0x1E")]
	[Token(Token = "0x60002BC")]
	public void DisableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB840", Offset = "0x2BBAC40", Length = "0x1D")]
	[Token(Token = "0x60002AB")]
	public override void DisableScissorRect() { }

	[Address(RVA = "0x2BBB860", Offset = "0x2BBAC60", Length = "0x1E")]
	[Token(Token = "0x60002BB")]
	public override void DisableShaderKeyword(string keyword) { }

	[Address(RVA = "0x2BC4360", Offset = "0x2BC3760", Length = "0x7A")]
	[Token(Token = "0x60002D9")]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4230", Offset = "0x2BC3630", Length = "0x6D")]
	[Token(Token = "0x60002DA")]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	[Address(RVA = "0x2BC42A0", Offset = "0x2BC36A0", Length = "0x5C")]
	[Token(Token = "0x60002DB")]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	[Address(RVA = "0x2BC4300", Offset = "0x2BC3700", Length = "0x51")]
	[Token(Token = "0x60002DC")]
	public override void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	[Address(RVA = "0x2BC4200", Offset = "0x2BC3600", Length = "0x27")]
	[Token(Token = "0x60002F4")]
	public override void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC41A0", Offset = "0x2BC35A0", Length = "0x27")]
	[Token(Token = "0x60002F5")]
	public override void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count) { }

	[Address(RVA = "0x2BC41D0", Offset = "0x2BC35D0", Length = "0x27")]
	[Token(Token = "0x60002F6")]
	public override void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices) { }

	[Address(RVA = "0x2BC4110", Offset = "0x2BC3510", Length = "0x27")]
	[Token(Token = "0x60002FD")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC4050", Offset = "0x2BC3450", Length = "0x27")]
	[Token(Token = "0x60002F8")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4080", Offset = "0x2BC3480", Length = "0x27")]
	[Token(Token = "0x60002F9")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC40E0", Offset = "0x2BC34E0", Length = "0x27")]
	[Token(Token = "0x60002FA")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC40B0", Offset = "0x2BC34B0", Length = "0x27")]
	[Token(Token = "0x60002FB")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4140", Offset = "0x2BC3540", Length = "0x27")]
	[Token(Token = "0x60002FC")]
	public override void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC4170", Offset = "0x2BC3570", Length = "0x27")]
	[Token(Token = "0x60002F7")]
	public override void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC43E0", Offset = "0x2BC37E0", Length = "0x27")]
	[Token(Token = "0x60002DD")]
	public override void DrawMultipleMeshes(Matrix4x4[] matrices, Mesh[] meshes, Int32[] subsetIndices, int count, Material material, int shaderPass, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4410", Offset = "0x2BC3810", Length = "0x2C")]
	[Token(Token = "0x60002FE")]
	public override void DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	[Address(RVA = "0x2BC4B30", Offset = "0x2BC3F30", Length = "0x81")]
	[Token(Token = "0x60002E6")]
	public override void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount) { }

	[Address(RVA = "0x2BC4BC0", Offset = "0x2BC3FC0", Length = "0x69")]
	[Token(Token = "0x60002E4")]
	public override void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount) { }

	[Address(RVA = "0x2BC4D30", Offset = "0x2BC4130", Length = "0x74")]
	[Token(Token = "0x60002E3")]
	public override void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount) { }

	[Address(RVA = "0x2BC4C30", Offset = "0x2BC4030", Length = "0x7F")]
	[Token(Token = "0x60002E2")]
	public override void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4AA0", Offset = "0x2BC3EA0", Length = "0x8E")]
	[Token(Token = "0x60002E5")]
	public override void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4CB0", Offset = "0x2BC40B0", Length = "0x78")]
	[Token(Token = "0x60002E7")]
	public override void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount) { }

	[Address(RVA = "0x2BC46D0", Offset = "0x2BC3AD0", Length = "0x90")]
	[Token(Token = "0x60002EB")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4990", Offset = "0x2BC3D90", Length = "0x76")]
	[Token(Token = "0x60002E9")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC4440", Offset = "0x2BC3840", Length = "0x81")]
	[Token(Token = "0x60002E8")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4650", Offset = "0x2BC3A50", Length = "0x7A")]
	[Token(Token = "0x60002ED")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC4A10", Offset = "0x2BC3E10", Length = "0x81")]
	[Token(Token = "0x60002EE")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC4880", Offset = "0x2BC3C80", Length = "0x76")]
	[Token(Token = "0x60002EF")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC4810", Offset = "0x2BC3C10", Length = "0x6B")]
	[Token(Token = "0x60002F0")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC4770", Offset = "0x2BC3B70", Length = "0x90")]
	[Token(Token = "0x60002F1")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Address(RVA = "0x2BC45E0", Offset = "0x2BC39E0", Length = "0x6B")]
	[Token(Token = "0x60002EA")]
	public override void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC44D0", Offset = "0x2BC38D0", Length = "0x7A")]
	[Token(Token = "0x60002F3")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[Address(RVA = "0x2BC4550", Offset = "0x2BC3950", Length = "0x83")]
	[Token(Token = "0x60002F2")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC4900", Offset = "0x2BC3D00", Length = "0x83")]
	[Token(Token = "0x60002EC")]
	public override void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Address(RVA = "0x2BC4DF0", Offset = "0x2BC41F0", Length = "0x1E")]
	[Token(Token = "0x60002E0")]
	public override void DrawRenderer(Renderer renderer, Material material) { }

	[Address(RVA = "0x2BC4E10", Offset = "0x2BC4210", Length = "0x24")]
	[Token(Token = "0x60002DF")]
	public override void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	[Address(RVA = "0x2BC4E40", Offset = "0x2BC4240", Length = "0x24")]
	[Token(Token = "0x60002DE")]
	public override void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[Address(RVA = "0x2BC4DB0", Offset = "0x2BC41B0", Length = "0x37")]
	[Token(Token = "0x60002E1")]
	public override void DrawRendererList(RendererList rendererList) { }

	[Address(RVA = "0x2BBB970", Offset = "0x2BBAD70", Length = "0x1E")]
	[Token(Token = "0x60002B8")]
	public void EnableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB990", Offset = "0x2BBAD90", Length = "0x1E")]
	[Token(Token = "0x60002BA")]
	public void EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB9B0", Offset = "0x2BBADB0", Length = "0x1E")]
	[Token(Token = "0x60002B9")]
	public void EnableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB9D0", Offset = "0x2BBADD0", Length = "0x2C")]
	[Token(Token = "0x60002AA")]
	public override void EnableScissorRect(Rect scissor) { }

	[Address(RVA = "0x2BBBA00", Offset = "0x2BBAE00", Length = "0x1E")]
	[Token(Token = "0x60002B7")]
	public override void EnableShaderKeyword(string keyword) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002CF")]
	public override void EndSample(ProfilerMarker marker) { }

	[Address(RVA = "0x2BBBA40", Offset = "0x2BBAE40", Length = "0x1E")]
	[Token(Token = "0x60002CD")]
	public override void EndSample(CustomSampler sampler) { }

	[Address(RVA = "0x2BBBA20", Offset = "0x2BBAE20", Length = "0x1E")]
	[Token(Token = "0x60002CB")]
	public override void EndSample(string name) { }

	[Address(RVA = "0x2BBBA60", Offset = "0x2BBAE60", Length = "0x40")]
	[Token(Token = "0x60002D0")]
	public override void IncrementUpdateCount(RenderTargetIdentifier dest) { }

	[Address(RVA = "0x2BBBAB0", Offset = "0x2BBAEB0", Length = "0x1D")]
	[Token(Token = "0x60002D6")]
	public override void InvokeOnRenderObjectCallbacks() { }

	[Address(RVA = "0x2BBBAD0", Offset = "0x2BBAED0", Length = "0x93")]
	[Token(Token = "0x600031E")]
	public override void IssuePluginCustomBlit(IntPtr callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest, uint commandParam, uint commandFlags) { }

	[Address(RVA = "0x2BBBB70", Offset = "0x2BBAF70", Length = "0x24")]
	[Token(Token = "0x600031F")]
	public override void IssuePluginCustomTextureUpdateV2(IntPtr callback, Texture targetTexture, uint userData) { }

	[Address(RVA = "0x2BBBBD0", Offset = "0x2BBAFD0", Length = "0x1E")]
	[Token(Token = "0x600031C")]
	public override void IssuePluginEvent(IntPtr callback, int eventID) { }

	[Address(RVA = "0x2BBBBA0", Offset = "0x2BBAFA0", Length = "0x24")]
	[Token(Token = "0x600031D")]
	public override void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	[Address(RVA = "0x2BBBBF0", Offset = "0x2BBAFF0", Length = "0x1E")]
	[Token(Token = "0x60002C8")]
	public override void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID) { }

	[Address(RVA = "0x2BC4E70", Offset = "0x2BC4270", Length = "0x1E")]
	[Token(Token = "0x60002D2")]
	public override void SetFoveatedRenderingMode(FoveatedRenderingMode foveatedRenderingMode) { }

	[Address(RVA = "0x2BBC820", Offset = "0x2BBBC20", Length = "0x1E")]
	[Token(Token = "0x6000313")]
	public override void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[Address(RVA = "0x2BBC840", Offset = "0x2BBBC40", Length = "0x1E")]
	[Token(Token = "0x6000312")]
	public override void SetGlobalBuffer(string name, ComputeBuffer value) { }

	[Address(RVA = "0x2BBC880", Offset = "0x2BBBC80", Length = "0x1E")]
	[Token(Token = "0x6000314")]
	public override void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	[Address(RVA = "0x2BBC860", Offset = "0x2BBBC60", Length = "0x1E")]
	[Token(Token = "0x6000315")]
	public override void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	[Address(RVA = "0x2BBC8D0", Offset = "0x2BBBCD0", Length = "0x2D")]
	[Token(Token = "0x6000303")]
	public override void SetGlobalColor(string name, Color value) { }

	[Address(RVA = "0x2BBC8A0", Offset = "0x2BBBCA0", Length = "0x2D")]
	[Token(Token = "0x60002B5")]
	public override void SetGlobalColor(int nameID, Color value) { }

	[Address(RVA = "0x2BBC960", Offset = "0x2BBBD60", Length = "0x24")]
	[Token(Token = "0x6000319")]
	public override void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size) { }

	[Address(RVA = "0x2BBC900", Offset = "0x2BBBD00", Length = "0x24")]
	[Token(Token = "0x6000318")]
	public override void SetGlobalConstantBuffer(GraphicsBuffer buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x2BBC990", Offset = "0x2BBBD90", Length = "0x24")]
	[Token(Token = "0x6000316")]
	public override void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x2BBC930", Offset = "0x2BBBD30", Length = "0x24")]
	[Token(Token = "0x6000317")]
	public override void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size) { }

	[Address(RVA = "0x2BBC9C0", Offset = "0x2BBBDC0", Length = "0x1E")]
	[Token(Token = "0x60002C3")]
	public override void SetGlobalDepthBias(float bias, float slopeBias) { }

	[Address(RVA = "0x2BBCA60", Offset = "0x2BBBE60", Length = "0x1E")]
	[Token(Token = "0x60002B1")]
	public override void SetGlobalFloat(int nameID, float value) { }

	[Address(RVA = "0x2BBCA80", Offset = "0x2BBBE80", Length = "0x1E")]
	[Token(Token = "0x60002FF")]
	public override void SetGlobalFloat(string name, float value) { }

	[Address(RVA = "0x2BBC9E0", Offset = "0x2BBBDE0", Length = "0x1E")]
	[Token(Token = "0x6000307")]
	public override void SetGlobalFloatArray(string propertyName, Single[] values) { }

	[Address(RVA = "0x2BBCA00", Offset = "0x2BBBE00", Length = "0x1E")]
	[Token(Token = "0x6000306")]
	public override void SetGlobalFloatArray(int nameID, List<Single> values) { }

	[Address(RVA = "0x2BBCA40", Offset = "0x2BBBE40", Length = "0x1E")]
	[Token(Token = "0x6000305")]
	public override void SetGlobalFloatArray(string propertyName, List<Single> values) { }

	[Address(RVA = "0x2BBCA20", Offset = "0x2BBBE20", Length = "0x1E")]
	[Token(Token = "0x60002C4")]
	public override void SetGlobalFloatArray(int nameID, Single[] values) { }

	[Address(RVA = "0x2BBCAC0", Offset = "0x2BBBEC0", Length = "0x1E")]
	[Token(Token = "0x6000300")]
	public override void SetGlobalInt(string name, int value) { }

	[Address(RVA = "0x2BBCAA0", Offset = "0x2BBBEA0", Length = "0x1E")]
	[Token(Token = "0x60002B2")]
	public override void SetGlobalInt(int nameID, int value) { }

	[Address(RVA = "0x2BBCB00", Offset = "0x2BBBF00", Length = "0x1E")]
	[Token(Token = "0x60002B3")]
	public override void SetGlobalInteger(int nameID, int value) { }

	[Address(RVA = "0x2BBCAE0", Offset = "0x2BBBEE0", Length = "0x1E")]
	[Token(Token = "0x6000301")]
	public override void SetGlobalInteger(string name, int value) { }

	[Address(RVA = "0x2BBCBF0", Offset = "0x2BBBFF0", Length = "0x4B")]
	[Token(Token = "0x6000304")]
	public override void SetGlobalMatrix(string name, Matrix4x4 value) { }

	[Address(RVA = "0x2BBCBA0", Offset = "0x2BBBFA0", Length = "0x4B")]
	[Token(Token = "0x60002B6")]
	public override void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[Address(RVA = "0x2BBCB80", Offset = "0x2BBBF80", Length = "0x1E")]
	[Token(Token = "0x600030C")]
	public override void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	[Address(RVA = "0x2BBCB60", Offset = "0x2BBBF60", Length = "0x1E")]
	[Token(Token = "0x60002C6")]
	public override void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBCB40", Offset = "0x2BBBF40", Length = "0x1E")]
	[Token(Token = "0x600030D")]
	public override void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBCB20", Offset = "0x2BBBF20", Length = "0x1E")]
	[Token(Token = "0x600030B")]
	public override void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values) { }

	[Address(RVA = "0x2BC4F50", Offset = "0x2BC4350", Length = "0xCD")]
	[Token(Token = "0x6000310")]
	public override void SetGlobalTexture(string name, TextureHandle value, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BC4E90", Offset = "0x2BC4290", Length = "0xB8")]
	[Token(Token = "0x600030E")]
	public override void SetGlobalTexture(string name, TextureHandle value) { }

	[Address(RVA = "0x2BC50E0", Offset = "0x2BC44E0", Length = "0xCB")]
	[Token(Token = "0x6000311")]
	public override void SetGlobalTexture(int nameID, TextureHandle value, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BC5020", Offset = "0x2BC4420", Length = "0xB6")]
	[Token(Token = "0x600030F")]
	public override void SetGlobalTexture(int nameID, TextureHandle value) { }

	[Address(RVA = "0x2BBCFE0", Offset = "0x2BBC3E0", Length = "0x2D")]
	[Token(Token = "0x60002B4")]
	public override void SetGlobalVector(int nameID, Vector4 value) { }

	[Address(RVA = "0x2BBD010", Offset = "0x2BBC410", Length = "0x2D")]
	[Token(Token = "0x6000302")]
	public override void SetGlobalVector(string name, Vector4 value) { }

	[Address(RVA = "0x2BBCFC0", Offset = "0x2BBC3C0", Length = "0x1E")]
	[Token(Token = "0x6000309")]
	public override void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[Address(RVA = "0x2BBCF60", Offset = "0x2BBC360", Length = "0x1E")]
	[Token(Token = "0x6000308")]
	public override void SetGlobalVectorArray(string propertyName, List<Vector4> values) { }

	[Address(RVA = "0x2BBCF80", Offset = "0x2BBC380", Length = "0x1E")]
	[Token(Token = "0x600030A")]
	public override void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	[Address(RVA = "0x2BBCFA0", Offset = "0x2BBC3A0", Length = "0x1E")]
	[Token(Token = "0x60002C5")]
	public override void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[Address(RVA = "0x2BC51B0", Offset = "0x2BC45B0", Length = "0x1E")]
	[Token(Token = "0x60002D1")]
	public override void SetInstanceMultiplier(uint multiplier) { }

	[Address(RVA = "0x2BBD040", Offset = "0x2BBC440", Length = "0x1E")]
	[Token(Token = "0x60002A8")]
	public override void SetInvertCulling(bool invertCulling) { }

	[Address(RVA = "0x2BBD060", Offset = "0x2BBC460", Length = "0x1E")]
	[Token(Token = "0x60002BF")]
	public void SetKeyword(in GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD0B0", Offset = "0x2BBC4B0", Length = "0x24")]
	[Token(Token = "0x60002C0")]
	public void SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD080", Offset = "0x2BBC480", Length = "0x24")]
	[Token(Token = "0x60002C1")]
	public void SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD0E0", Offset = "0x2BBC4E0", Length = "0x1E")]
	[Token(Token = "0x60002C7")]
	public override void SetLateLatchProjectionMatrices(Matrix4x4[] projectionMat) { }

	[Address(RVA = "0x2BC51D0", Offset = "0x2BC45D0", Length = "0x1E")]
	[Token(Token = "0x60002D8")]
	public override void SetShadingRateCombiner(ShadingRateCombinerStage stage, ShadingRateCombiner combiner) { }

	[Address(RVA = "0x2BC51F0", Offset = "0x2BC45F0", Length = "0x1E")]
	[Token(Token = "0x60002D7")]
	public override void SetShadingRateFragmentSize(ShadingRateFragmentSize shadingRateFragmentSize) { }

	[Address(RVA = "0x2BBD8E0", Offset = "0x2BBCCE0", Length = "0x40")]
	[Token(Token = "0x600031A")]
	public override void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[Address(RVA = "0x2BBD930", Offset = "0x2BBCD30", Length = "0x1E")]
	[Token(Token = "0x600031B")]
	public override void SetSinglePassStereo(SinglePassStereoMode mode) { }

	[Address(RVA = "0x2BBDA00", Offset = "0x2BBCE00", Length = "0x1E")]
	[Token(Token = "0x60002D5")]
	public override void SetupCameraProperties(Camera camera) { }

	[Address(RVA = "0x2BBD9D0", Offset = "0x2BBCDD0", Length = "0x2C")]
	[Token(Token = "0x60002A9")]
	public override void SetViewport(Rect pixelRect) { }

	[Address(RVA = "0x2BBD950", Offset = "0x2BBCD50", Length = "0x74")]
	[Token(Token = "0x60002C2")]
	public override void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[Address(RVA = "0x2BC5210", Offset = "0x2BC4610", Length = "0x1E")]
	[Token(Token = "0x60002D3")]
	public override void SetWireframe(bool enable) { }

	[Address(RVA = "0x2BBB820", Offset = "0x2BBAC20", Length = "0x1E")]
	[Token(Token = "0x6000324")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB7E0", Offset = "0x2BBABE0", Length = "0x1E")]
	[Token(Token = "0x6000323")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB800", Offset = "0x2BBAC00", Length = "0x1E")]
	[Token(Token = "0x6000325")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB970", Offset = "0x2BBAD70", Length = "0x1E")]
	[Token(Token = "0x6000320")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB9B0", Offset = "0x2BBADB0", Length = "0x1E")]
	[Token(Token = "0x6000321")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB990", Offset = "0x2BBAD90", Length = "0x1E")]
	[Token(Token = "0x6000322")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBD060", Offset = "0x2BBC460", Length = "0x1E")]
	[Token(Token = "0x6000326")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(in GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD080", Offset = "0x2BBC480", Length = "0x24")]
	[Token(Token = "0x6000328")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD0B0", Offset = "0x2BBC4B0", Length = "0x24")]
	[Token(Token = "0x6000327")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBDA20", Offset = "0x2BBCE20", Length = "0x1E")]
	[Token(Token = "0x60002C9")]
	public override void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType) { }

}

