namespace UnityEngine.Rendering;

[Token(Token = "0x2000023")]
public interface IComputeCommandBuffer : IBaseCommandBuffer
{

	[Token(Token = "0x6000211")]
	public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, BuildSettings buildSettings) { }

	[Token(Token = "0x6000210")]
	public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, Vector3 relativeOrigin) { }

	[Token(Token = "0x600020F")]
	public void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure) { }

	[Token(Token = "0x6000237")]
	public void CopyCounterValue(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[Token(Token = "0x6000235")]
	public void CopyCounterValue(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[Token(Token = "0x6000234")]
	public void CopyCounterValue(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[Token(Token = "0x6000236")]
	public void CopyCounterValue(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[Token(Token = "0x600020C")]
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[Token(Token = "0x600020D")]
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset) { }

	[Token(Token = "0x600020E")]
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset) { }

	[Token(Token = "0x6000233")]
	public void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, GraphicsBuffer argsBuffer, uint argsOffset, Camera camera) { }

	[Token(Token = "0x6000232")]
	public void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, Camera camera) { }

	[Token(Token = "0x60001F0")]
	public void SetBufferCounterValue(GraphicsBuffer buffer, uint counterValue) { }

	[Token(Token = "0x60001E9")]
	public void SetBufferCounterValue(ComputeBuffer buffer, uint counterValue) { }

	[Token(Token = "0x60001EF")]
	public void SetBufferData(GraphicsBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Token(Token = "0x60001EE")]
	public void SetBufferData(GraphicsBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Token(Token = "0x60001ED")]
	public void SetBufferData(GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Token(Token = "0x60001EB")]
	public void SetBufferData(GraphicsBuffer buffer, List<T> data) { }

	[Token(Token = "0x60001EA")]
	public void SetBufferData(GraphicsBuffer buffer, Array data) { }

	[Token(Token = "0x60001E8")]
	public void SetBufferData(ComputeBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Token(Token = "0x60001E7")]
	public void SetBufferData(ComputeBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Token(Token = "0x60001E6")]
	public void SetBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Token(Token = "0x60001E5")]
	public void SetBufferData(ComputeBuffer buffer, NativeArray<T> data) { }

	[Token(Token = "0x60001E4")]
	public void SetBufferData(ComputeBuffer buffer, List<T> data) { }

	[Token(Token = "0x60001EC")]
	public void SetBufferData(GraphicsBuffer buffer, NativeArray<T> data) { }

	[Token(Token = "0x60001E3")]
	public void SetBufferData(ComputeBuffer buffer, Array data) { }

	[Token(Token = "0x6000202")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	[Token(Token = "0x6000203")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBufferHandle bufferHandle) { }

	[Token(Token = "0x6000204")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBufferHandle bufferHandle) { }

	[Token(Token = "0x6000205")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer) { }

	[Token(Token = "0x6000201")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[Token(Token = "0x6000206")]
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBuffer buffer) { }

	[Token(Token = "0x6000207")]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Token(Token = "0x6000208")]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, ComputeBuffer buffer, int offset, int size) { }

	[Token(Token = "0x600020A")]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, string name, GraphicsBuffer buffer, int offset, int size) { }

	[Token(Token = "0x6000209")]
	public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Token(Token = "0x60001DC")]
	public void SetComputeFloatParam(ComputeShader computeShader, int nameID, float val) { }

	[Token(Token = "0x60001F1")]
	public void SetComputeFloatParam(ComputeShader computeShader, string name, float val) { }

	[Token(Token = "0x60001F8")]
	public void SetComputeFloatParams(ComputeShader computeShader, int nameID, Single[] values) { }

	[Token(Token = "0x60001F7")]
	public void SetComputeFloatParams(ComputeShader computeShader, string name, Single[] values) { }

	[Token(Token = "0x60001DD")]
	public void SetComputeIntParam(ComputeShader computeShader, int nameID, int val) { }

	[Token(Token = "0x60001F2")]
	public void SetComputeIntParam(ComputeShader computeShader, string name, int val) { }

	[Token(Token = "0x60001FA")]
	public void SetComputeIntParams(ComputeShader computeShader, int nameID, Int32[] values) { }

	[Token(Token = "0x60001F9")]
	public void SetComputeIntParams(ComputeShader computeShader, string name, Int32[] values) { }

	[Token(Token = "0x60001E1")]
	public void SetComputeMatrixArrayParam(ComputeShader computeShader, int nameID, Matrix4x4[] values) { }

	[Token(Token = "0x60001F6")]
	public void SetComputeMatrixArrayParam(ComputeShader computeShader, string name, Matrix4x4[] values) { }

	[Token(Token = "0x60001E0")]
	public void SetComputeMatrixParam(ComputeShader computeShader, int nameID, Matrix4x4 val) { }

	[Token(Token = "0x60001F5")]
	public void SetComputeMatrixParam(ComputeShader computeShader, string name, Matrix4x4 val) { }

	[Token(Token = "0x600020B")]
	public void SetComputeParamsFromMaterial(ComputeShader computeShader, int kernelIndex, Material material) { }

	[Token(Token = "0x60001FF")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt, int mipLevel, RenderTextureSubElement element) { }

	[Token(Token = "0x6000200")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt, int mipLevel, RenderTextureSubElement element) { }

	[Token(Token = "0x60001FE")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt, int mipLevel) { }

	[Token(Token = "0x60001FB")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt) { }

	[Token(Token = "0x60001FD")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt, int mipLevel) { }

	[Token(Token = "0x60001FC")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt) { }

	[Token(Token = "0x60001F4")]
	public void SetComputeVectorArrayParam(ComputeShader computeShader, string name, Vector4[] values) { }

	[Token(Token = "0x60001DF")]
	public void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Vector4[] values) { }

	[Token(Token = "0x60001DE")]
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[Token(Token = "0x60001F3")]
	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	[Token(Token = "0x6000212")]
	public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Token(Token = "0x6000213")]
	public void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Token(Token = "0x6000214")]
	public void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Token(Token = "0x6000215")]
	public void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Token(Token = "0x600021B")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBufferHandle bufferHandle) { }

	[Token(Token = "0x6000216")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer) { }

	[Token(Token = "0x6000217")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer) { }

	[Token(Token = "0x6000218")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer) { }

	[Token(Token = "0x6000219")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer) { }

	[Token(Token = "0x600021A")]
	public void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBufferHandle bufferHandle) { }

	[Token(Token = "0x600021C")]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Token(Token = "0x600021D")]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer, int offset, int size) { }

	[Token(Token = "0x600021E")]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Token(Token = "0x600021F")]
	public void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer, int offset, int size) { }

	[Token(Token = "0x6000223")]
	public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, int nameID, float val) { }

	[Token(Token = "0x6000222")]
	public void SetRayTracingFloatParam(RayTracingShader rayTracingShader, string name, float val) { }

	[Token(Token = "0x6000224")]
	public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, string name, Single[] values) { }

	[Token(Token = "0x6000225")]
	public void SetRayTracingFloatParams(RayTracingShader rayTracingShader, int nameID, Single[] values) { }

	[Token(Token = "0x6000226")]
	public void SetRayTracingIntParam(RayTracingShader rayTracingShader, string name, int val) { }

	[Token(Token = "0x6000227")]
	public void SetRayTracingIntParam(RayTracingShader rayTracingShader, int nameID, int val) { }

	[Token(Token = "0x6000229")]
	public void SetRayTracingIntParams(RayTracingShader rayTracingShader, int nameID, Int32[] values) { }

	[Token(Token = "0x6000228")]
	public void SetRayTracingIntParams(RayTracingShader rayTracingShader, string name, Int32[] values) { }

	[Token(Token = "0x6000230")]
	public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, string name, Matrix4x4[] values) { }

	[Token(Token = "0x6000231")]
	public void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4[] values) { }

	[Token(Token = "0x600022F")]
	public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4 val) { }

	[Token(Token = "0x600022E")]
	public void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, string name, Matrix4x4 val) { }

	[Token(Token = "0x60001E2")]
	public void SetRayTracingShaderPass(RayTracingShader rayTracingShader, string passName) { }

	[Token(Token = "0x6000221")]
	public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, TextureHandle rt) { }

	[Token(Token = "0x6000220")]
	public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, string name, TextureHandle rt) { }

	[Token(Token = "0x600022C")]
	public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, string name, Vector4[] values) { }

	[Token(Token = "0x600022D")]
	public void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, int nameID, Vector4[] values) { }

	[Token(Token = "0x600022A")]
	public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, string name, Vector4 val) { }

	[Token(Token = "0x600022B")]
	public void SetRayTracingVectorParam(RayTracingShader rayTracingShader, int nameID, Vector4 val) { }

}

