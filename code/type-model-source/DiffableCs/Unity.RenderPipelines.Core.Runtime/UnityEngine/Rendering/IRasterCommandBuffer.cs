namespace UnityEngine.Rendering;

[Token(Token = "0x2000024")]
public interface IRasterCommandBuffer : IBaseCommandBuffer
{

	[Token(Token = "0x6000238")]
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[Token(Token = "0x6000239")]
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	[Token(Token = "0x600023A")]
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth, uint stencil) { }

	[Token(Token = "0x600023B")]
	public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil) { }

	[Token(Token = "0x600023C")]
	public void ClearRenderTarget(RTClearFlags clearFlags, Color[] backgroundColors, float depth, uint stencil) { }

	[Token(Token = "0x6000240")]
	public void ConfigureFoveatedRendering(IntPtr platformData) { }

	[Token(Token = "0x6000246")]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	[Token(Token = "0x6000245")]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	[Token(Token = "0x6000243")]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[Token(Token = "0x6000244")]
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	[Token(Token = "0x600025F")]
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count) { }

	[Token(Token = "0x6000260")]
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices) { }

	[Token(Token = "0x600025E")]
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[Token(Token = "0x6000262")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Token(Token = "0x6000264")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs) { }

	[Token(Token = "0x6000265")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Token(Token = "0x6000266")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Token(Token = "0x6000263")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Token(Token = "0x6000267")]
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, GraphicsBuffer bufferWithArgs) { }

	[Token(Token = "0x6000261")]
	public void DrawMeshInstancedProcedural(Mesh mesh, int submeshIndex, Material material, int shaderPass, int count, MaterialPropertyBlock properties) { }

	[Token(Token = "0x6000247")]
	public void DrawMultipleMeshes(Matrix4x4[] matrices, Mesh[] meshes, Int32[] subsetIndices, int count, Material material, int shaderPass, MaterialPropertyBlock properties) { }

	[Token(Token = "0x6000268")]
	public void DrawOcclusionMesh(RectInt normalizedCamViewport) { }

	[Token(Token = "0x600024E")]
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount) { }

	[Token(Token = "0x600024D")]
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount) { }

	[Token(Token = "0x6000251")]
	public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount) { }

	[Token(Token = "0x6000250")]
	public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount) { }

	[Token(Token = "0x600024C")]
	public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[Token(Token = "0x600024F")]
	public void DrawProcedural(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int indexCount, int instanceCount, MaterialPropertyBlock properties) { }

	[Token(Token = "0x6000252")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Token(Token = "0x600025C")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Token(Token = "0x600025A")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[Token(Token = "0x6000259")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset) { }

	[Token(Token = "0x600025D")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs) { }

	[Token(Token = "0x6000257")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[Token(Token = "0x6000256")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Token(Token = "0x6000255")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Token(Token = "0x6000254")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs) { }

	[Token(Token = "0x6000253")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[Token(Token = "0x6000258")]
	public void DrawProceduralIndirect(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Token(Token = "0x600025B")]
	public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[Token(Token = "0x600024A")]
	public void DrawRenderer(Renderer renderer, Material material) { }

	[Token(Token = "0x6000249")]
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	[Token(Token = "0x6000248")]
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[Token(Token = "0x600024B")]
	public void DrawRendererList(RendererList rendererList) { }

	[Token(Token = "0x600023E")]
	public void SetFoveatedRenderingMode(FoveatedRenderingMode foveatedRenderingMode) { }

	[Token(Token = "0x600023D")]
	public void SetInstanceMultiplier(uint multiplier) { }

	[Token(Token = "0x6000242")]
	public void SetShadingRateCombiner(ShadingRateCombinerStage stage, ShadingRateCombiner combiner) { }

	[Token(Token = "0x6000241")]
	public void SetShadingRateFragmentSize(ShadingRateFragmentSize shadingRateFragmentSize) { }

	[Token(Token = "0x600023F")]
	public void SetWireframe(bool enable) { }

}

