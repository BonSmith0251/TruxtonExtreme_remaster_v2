namespace UnityEngine.Rendering;

[Token(Token = "0x2000021")]
public class ComputeCommandBuffer : BaseCommandBuffer, IComputeCommandBuffer, IBaseCommandBuffer
{

	[Address(RVA = "0x2BBDA40", Offset = "0x2BBCE40", Length = "0xE")]
	[Token(Token = "0x60000E8")]
	internal ComputeCommandBuffer(CommandBuffer wrapped, RenderGraphPass executingPass, bool isAsync) { }

	[Address(RVA = "0x2BBB670", Offset = "0x2BBAA70", Length = "0x1E")]
	[Token(Token = "0x600010F")]
	public override void BeginSample(CustomSampler sampler) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000111")]
	public override void BeginSample(ProfilerMarker marker) { }

	[Address(RVA = "0x2BBB650", Offset = "0x2BBAA50", Length = "0x1E")]
	[Token(Token = "0x600010D")]
	public override void BeginSample(string name) { }

	[Address(RVA = "0x2BBB690", Offset = "0x2BBAA90", Length = "0x2D")]
	[Token(Token = "0x6000144")]
	public override void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, BuildSettings buildSettings) { }

	[Address(RVA = "0x2BBB6E0", Offset = "0x2BBAAE0", Length = "0x37")]
	[Token(Token = "0x6000143")]
	public override void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure, Vector3 relativeOrigin) { }

	[Address(RVA = "0x2BBB6C0", Offset = "0x2BBAAC0", Length = "0x1E")]
	[Token(Token = "0x6000142")]
	public override void BuildRayTracingAccelerationStructure(RayTracingAccelerationStructure accelerationStructure) { }

	[Address(RVA = "0x2BBB750", Offset = "0x2BBAB50", Length = "0x24")]
	[Token(Token = "0x6000167")]
	public override void CopyCounterValue(ComputeBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x2BBB780", Offset = "0x2BBAB80", Length = "0x24")]
	[Token(Token = "0x6000168")]
	public override void CopyCounterValue(GraphicsBuffer src, ComputeBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x2BBB7B0", Offset = "0x2BBABB0", Length = "0x24")]
	[Token(Token = "0x6000169")]
	public override void CopyCounterValue(ComputeBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x2BBB720", Offset = "0x2BBAB20", Length = "0x24")]
	[Token(Token = "0x600016A")]
	public override void CopyCounterValue(GraphicsBuffer src, GraphicsBuffer dst, uint dstOffsetBytes) { }

	[Address(RVA = "0x2BBB7E0", Offset = "0x2BBABE0", Length = "0x1E")]
	[Token(Token = "0x60000FF")]
	public void DisableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB800", Offset = "0x2BBAC00", Length = "0x1E")]
	[Token(Token = "0x6000101")]
	public void DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB820", Offset = "0x2BBAC20", Length = "0x1E")]
	[Token(Token = "0x6000100")]
	public void DisableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB840", Offset = "0x2BBAC40", Length = "0x1D")]
	[Token(Token = "0x60000F3")]
	public override void DisableScissorRect() { }

	[Address(RVA = "0x2BBB860", Offset = "0x2BBAC60", Length = "0x1E")]
	[Token(Token = "0x60000FE")]
	public override void DisableShaderKeyword(string keyword) { }

	[Address(RVA = "0x2BBB8B0", Offset = "0x2BBACB0", Length = "0x24")]
	[Token(Token = "0x6000141")]
	public override void DispatchCompute(ComputeShader computeShader, int kernelIndex, GraphicsBuffer indirectBuffer, uint argsOffset) { }

	[Address(RVA = "0x2BBB880", Offset = "0x2BBAC80", Length = "0x24")]
	[Token(Token = "0x6000140")]
	public override void DispatchCompute(ComputeShader computeShader, int kernelIndex, ComputeBuffer indirectBuffer, uint argsOffset) { }

	[Address(RVA = "0x2BBB8E0", Offset = "0x2BBACE0", Length = "0x27")]
	[Token(Token = "0x600013F")]
	public override void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[Address(RVA = "0x2BBB940", Offset = "0x2BBAD40", Length = "0x27")]
	[Token(Token = "0x6000166")]
	public override void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, GraphicsBuffer argsBuffer, uint argsOffset, Camera camera) { }

	[Address(RVA = "0x2BBB910", Offset = "0x2BBAD10", Length = "0x27")]
	[Token(Token = "0x6000165")]
	public override void DispatchRays(RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, Camera camera) { }

	[Address(RVA = "0x2BBB970", Offset = "0x2BBAD70", Length = "0x1E")]
	[Token(Token = "0x60000FB")]
	public void EnableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB9B0", Offset = "0x2BBADB0", Length = "0x1E")]
	[Token(Token = "0x60000FC")]
	public void EnableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB990", Offset = "0x2BBAD90", Length = "0x1E")]
	[Token(Token = "0x60000FD")]
	public void EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB9D0", Offset = "0x2BBADD0", Length = "0x2C")]
	[Token(Token = "0x60000F2")]
	public override void EnableScissorRect(Rect scissor) { }

	[Address(RVA = "0x2BBBA00", Offset = "0x2BBAE00", Length = "0x1E")]
	[Token(Token = "0x60000FA")]
	public override void EnableShaderKeyword(string keyword) { }

	[Address(RVA = "0x2BBBA20", Offset = "0x2BBAE20", Length = "0x1E")]
	[Token(Token = "0x600010E")]
	public override void EndSample(string name) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000112")]
	public override void EndSample(ProfilerMarker marker) { }

	[Address(RVA = "0x2BBBA40", Offset = "0x2BBAE40", Length = "0x1E")]
	[Token(Token = "0x6000110")]
	public override void EndSample(CustomSampler sampler) { }

	[Address(RVA = "0x2BBBA60", Offset = "0x2BBAE60", Length = "0x40")]
	[Token(Token = "0x6000113")]
	public override void IncrementUpdateCount(RenderTargetIdentifier dest) { }

	[Address(RVA = "0x2BBBAB0", Offset = "0x2BBAEB0", Length = "0x1D")]
	[Token(Token = "0x6000123")]
	public override void InvokeOnRenderObjectCallbacks() { }

	[Address(RVA = "0x2BBBAD0", Offset = "0x2BBAED0", Length = "0x93")]
	[Token(Token = "0x600018A")]
	public override void IssuePluginCustomBlit(IntPtr callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest, uint commandParam, uint commandFlags) { }

	[Address(RVA = "0x2BBBB70", Offset = "0x2BBAF70", Length = "0x24")]
	[Token(Token = "0x600018B")]
	public override void IssuePluginCustomTextureUpdateV2(IntPtr callback, Texture targetTexture, uint userData) { }

	[Address(RVA = "0x2BBBBD0", Offset = "0x2BBAFD0", Length = "0x1E")]
	[Token(Token = "0x6000188")]
	public override void IssuePluginEvent(IntPtr callback, int eventID) { }

	[Address(RVA = "0x2BBBBA0", Offset = "0x2BBAFA0", Length = "0x24")]
	[Token(Token = "0x6000189")]
	public override void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	[Address(RVA = "0x2BBBBF0", Offset = "0x2BBAFF0", Length = "0x1E")]
	[Token(Token = "0x600010B")]
	public override void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID) { }

	[Address(RVA = "0x2BBBC30", Offset = "0x2BBB030", Length = "0x1E")]
	[Token(Token = "0x600011A")]
	public override void SetBufferCounterValue(ComputeBuffer buffer, uint counterValue) { }

	[Address(RVA = "0x2BBBC10", Offset = "0x2BBB010", Length = "0x1E")]
	[Token(Token = "0x6000121")]
	public override void SetBufferCounterValue(GraphicsBuffer buffer, uint counterValue) { }

	[Address(RVA = "0x7A79B0", Offset = "0x7A6DB0", Length = "0x6F")]
	[Token(Token = "0x600011D")]
	public override void SetBufferData(GraphicsBuffer buffer, NativeArray<T> data) { }

	[Address(RVA = "0x7A7A90", Offset = "0x7A6E90", Length = "0xA3")]
	[Token(Token = "0x6000119")]
	public override void SetBufferData(ComputeBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A7920", Offset = "0x7A6D20", Length = "0x84")]
	[Token(Token = "0x6000118")]
	public override void SetBufferData(ComputeBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x2BBBC80", Offset = "0x2BBB080", Length = "0x27")]
	[Token(Token = "0x6000117")]
	public override void SetBufferData(ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A7B40", Offset = "0x7A6F40", Length = "0xBC")]
	[Token(Token = "0x6000116")]
	public override void SetBufferData(ComputeBuffer buffer, NativeArray<T> data) { }

	[Address(RVA = "0x7A7A20", Offset = "0x7A6E20", Length = "0x65")]
	[Token(Token = "0x6000115")]
	public override void SetBufferData(ComputeBuffer buffer, List<T> data) { }

	[Address(RVA = "0x2BBBCD0", Offset = "0x2BBB0D0", Length = "0x1E")]
	[Token(Token = "0x6000114")]
	public override void SetBufferData(ComputeBuffer buffer, Array data) { }

	[Address(RVA = "0x2BBBC50", Offset = "0x2BBB050", Length = "0x27")]
	[Token(Token = "0x600011E")]
	public override void SetBufferData(GraphicsBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A7920", Offset = "0x7A6D20", Length = "0x84")]
	[Token(Token = "0x600011F")]
	public override void SetBufferData(GraphicsBuffer buffer, List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x7A7A90", Offset = "0x7A6E90", Length = "0xA3")]
	[Token(Token = "0x6000120")]
	public override void SetBufferData(GraphicsBuffer buffer, NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) { }

	[Address(RVA = "0x2BBBCB0", Offset = "0x2BBB0B0", Length = "0x1E")]
	[Token(Token = "0x600011B")]
	public override void SetBufferData(GraphicsBuffer buffer, Array data) { }

	[Address(RVA = "0x7A7A20", Offset = "0x7A6E20", Length = "0x65")]
	[Token(Token = "0x600011C")]
	public override void SetBufferData(GraphicsBuffer buffer, List<T> data) { }

	[Address(RVA = "0x2BBBCF0", Offset = "0x2BBB0F0", Length = "0x24")]
	[Token(Token = "0x6000138")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x2BBBDE0", Offset = "0x2BBB1E0", Length = "0x24")]
	[Token(Token = "0x6000137")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x2BBBD80", Offset = "0x2BBB180", Length = "0x24")]
	[Token(Token = "0x6000136")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x2BBBD50", Offset = "0x2BBB150", Length = "0x24")]
	[Token(Token = "0x6000139")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, GraphicsBuffer buffer) { }

	[Address(RVA = "0x2BBBDB0", Offset = "0x2BBB1B0", Length = "0x24")]
	[Token(Token = "0x6000134")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x2BBBD20", Offset = "0x2BBB120", Length = "0x24")]
	[Token(Token = "0x6000135")]
	public override void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	[Address(RVA = "0x2BBBE10", Offset = "0x2BBB210", Length = "0x27")]
	[Token(Token = "0x600013A")]
	public override void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBBE40", Offset = "0x2BBB240", Length = "0x27")]
	[Token(Token = "0x600013C")]
	public override void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBBEA0", Offset = "0x2BBB2A0", Length = "0x27")]
	[Token(Token = "0x600013B")]
	public override void SetComputeConstantBufferParam(ComputeShader computeShader, string name, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBBE70", Offset = "0x2BBB270", Length = "0x27")]
	[Token(Token = "0x600013D")]
	public override void SetComputeConstantBufferParam(ComputeShader computeShader, string name, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBBF00", Offset = "0x2BBB300", Length = "0x24")]
	[Token(Token = "0x60000EA")]
	public override void SetComputeFloatParam(ComputeShader computeShader, int nameID, float val) { }

	[Address(RVA = "0x2BBBED0", Offset = "0x2BBB2D0", Length = "0x24")]
	[Token(Token = "0x6000124")]
	public override void SetComputeFloatParam(ComputeShader computeShader, string name, float val) { }

	[Address(RVA = "0x2BBBF60", Offset = "0x2BBB360", Length = "0x24")]
	[Token(Token = "0x600012A")]
	public override void SetComputeFloatParams(ComputeShader computeShader, string name, Single[] values) { }

	[Address(RVA = "0x2BBBF30", Offset = "0x2BBB330", Length = "0x24")]
	[Token(Token = "0x600012B")]
	public override void SetComputeFloatParams(ComputeShader computeShader, int nameID, Single[] values) { }

	[Address(RVA = "0x2BBBFC0", Offset = "0x2BBB3C0", Length = "0x24")]
	[Token(Token = "0x6000125")]
	public override void SetComputeIntParam(ComputeShader computeShader, string name, int val) { }

	[Address(RVA = "0x2BBBF90", Offset = "0x2BBB390", Length = "0x24")]
	[Token(Token = "0x60000EB")]
	public override void SetComputeIntParam(ComputeShader computeShader, int nameID, int val) { }

	[Address(RVA = "0x2BBBFF0", Offset = "0x2BBB3F0", Length = "0x24")]
	[Token(Token = "0x600012C")]
	public override void SetComputeIntParams(ComputeShader computeShader, string name, Int32[] values) { }

	[Address(RVA = "0x2BBC020", Offset = "0x2BBB420", Length = "0x24")]
	[Token(Token = "0x600012D")]
	public override void SetComputeIntParams(ComputeShader computeShader, int nameID, Int32[] values) { }

	[Address(RVA = "0x2BBC050", Offset = "0x2BBB450", Length = "0x24")]
	[Token(Token = "0x60000EF")]
	public override void SetComputeMatrixArrayParam(ComputeShader computeShader, int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBC080", Offset = "0x2BBB480", Length = "0x24")]
	[Token(Token = "0x6000129")]
	public override void SetComputeMatrixArrayParam(ComputeShader computeShader, string name, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBC110", Offset = "0x2BBB510", Length = "0x51")]
	[Token(Token = "0x60000EE")]
	public override void SetComputeMatrixParam(ComputeShader computeShader, int nameID, Matrix4x4 val) { }

	[Address(RVA = "0x2BBC0B0", Offset = "0x2BBB4B0", Length = "0x51")]
	[Token(Token = "0x6000128")]
	public override void SetComputeMatrixParam(ComputeShader computeShader, string name, Matrix4x4 val) { }

	[Address(RVA = "0x2BBC170", Offset = "0x2BBB570", Length = "0x24")]
	[Token(Token = "0x600013E")]
	public override void SetComputeParamsFromMaterial(ComputeShader computeShader, int kernelIndex, Material material) { }

	[Address(RVA = "0x2BBC650", Offset = "0x2BBBA50", Length = "0xEB")]
	[Token(Token = "0x6000131")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt, int mipLevel) { }

	[Address(RVA = "0x2BBC550", Offset = "0x2BBB950", Length = "0xF6")]
	[Token(Token = "0x6000132")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BBC290", Offset = "0x2BBB690", Length = "0xF6")]
	[Token(Token = "0x6000133")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt, int mipLevel, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BBC390", Offset = "0x2BBB790", Length = "0xDD")]
	[Token(Token = "0x600012F")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, TextureHandle rt) { }

	[Address(RVA = "0x2BBC470", Offset = "0x2BBB870", Length = "0xDD")]
	[Token(Token = "0x600012E")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt) { }

	[Address(RVA = "0x2BBC1A0", Offset = "0x2BBB5A0", Length = "0xEB")]
	[Token(Token = "0x6000130")]
	public override void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, TextureHandle rt, int mipLevel) { }

	[Address(RVA = "0x2BBC770", Offset = "0x2BBBB70", Length = "0x24")]
	[Token(Token = "0x6000127")]
	public override void SetComputeVectorArrayParam(ComputeShader computeShader, string name, Vector4[] values) { }

	[Address(RVA = "0x2BBC740", Offset = "0x2BBBB40", Length = "0x24")]
	[Token(Token = "0x60000ED")]
	public override void SetComputeVectorArrayParam(ComputeShader computeShader, int nameID, Vector4[] values) { }

	[Address(RVA = "0x2BBC7E0", Offset = "0x2BBBBE0", Length = "0x33")]
	[Token(Token = "0x60000EC")]
	public override void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[Address(RVA = "0x2BBC7A0", Offset = "0x2BBBBA0", Length = "0x33")]
	[Token(Token = "0x6000126")]
	public override void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	[Address(RVA = "0x2BBC820", Offset = "0x2BBBC20", Length = "0x1E")]
	[Token(Token = "0x600017F")]
	public override void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[Address(RVA = "0x2BBC840", Offset = "0x2BBBC40", Length = "0x1E")]
	[Token(Token = "0x600017E")]
	public override void SetGlobalBuffer(string name, ComputeBuffer value) { }

	[Address(RVA = "0x2BBC880", Offset = "0x2BBBC80", Length = "0x1E")]
	[Token(Token = "0x6000180")]
	public override void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	[Address(RVA = "0x2BBC860", Offset = "0x2BBBC60", Length = "0x1E")]
	[Token(Token = "0x6000181")]
	public override void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	[Address(RVA = "0x2BBC8A0", Offset = "0x2BBBCA0", Length = "0x2D")]
	[Token(Token = "0x60000F8")]
	public override void SetGlobalColor(int nameID, Color value) { }

	[Address(RVA = "0x2BBC8D0", Offset = "0x2BBBCD0", Length = "0x2D")]
	[Token(Token = "0x600016F")]
	public override void SetGlobalColor(string name, Color value) { }

	[Address(RVA = "0x2BBC930", Offset = "0x2BBBD30", Length = "0x24")]
	[Token(Token = "0x6000183")]
	public override void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size) { }

	[Address(RVA = "0x2BBC900", Offset = "0x2BBBD00", Length = "0x24")]
	[Token(Token = "0x6000184")]
	public override void SetGlobalConstantBuffer(GraphicsBuffer buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x2BBC990", Offset = "0x2BBBD90", Length = "0x24")]
	[Token(Token = "0x6000182")]
	public override void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[Address(RVA = "0x2BBC960", Offset = "0x2BBBD60", Length = "0x24")]
	[Token(Token = "0x6000185")]
	public override void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size) { }

	[Address(RVA = "0x2BBC9C0", Offset = "0x2BBBDC0", Length = "0x1E")]
	[Token(Token = "0x6000106")]
	public override void SetGlobalDepthBias(float bias, float slopeBias) { }

	[Address(RVA = "0x2BBCA80", Offset = "0x2BBBE80", Length = "0x1E")]
	[Token(Token = "0x600016B")]
	public override void SetGlobalFloat(string name, float value) { }

	[Address(RVA = "0x2BBCA60", Offset = "0x2BBBE60", Length = "0x1E")]
	[Token(Token = "0x60000F4")]
	public override void SetGlobalFloat(int nameID, float value) { }

	[Address(RVA = "0x2BBC9E0", Offset = "0x2BBBDE0", Length = "0x1E")]
	[Token(Token = "0x6000173")]
	public override void SetGlobalFloatArray(string propertyName, Single[] values) { }

	[Address(RVA = "0x2BBCA40", Offset = "0x2BBBE40", Length = "0x1E")]
	[Token(Token = "0x6000171")]
	public override void SetGlobalFloatArray(string propertyName, List<Single> values) { }

	[Address(RVA = "0x2BBCA20", Offset = "0x2BBBE20", Length = "0x1E")]
	[Token(Token = "0x6000107")]
	public override void SetGlobalFloatArray(int nameID, Single[] values) { }

	[Address(RVA = "0x2BBCA00", Offset = "0x2BBBE00", Length = "0x1E")]
	[Token(Token = "0x6000172")]
	public override void SetGlobalFloatArray(int nameID, List<Single> values) { }

	[Address(RVA = "0x2BBCAA0", Offset = "0x2BBBEA0", Length = "0x1E")]
	[Token(Token = "0x60000F5")]
	public override void SetGlobalInt(int nameID, int value) { }

	[Address(RVA = "0x2BBCAC0", Offset = "0x2BBBEC0", Length = "0x1E")]
	[Token(Token = "0x600016C")]
	public override void SetGlobalInt(string name, int value) { }

	[Address(RVA = "0x2BBCB00", Offset = "0x2BBBF00", Length = "0x1E")]
	[Token(Token = "0x60000F6")]
	public override void SetGlobalInteger(int nameID, int value) { }

	[Address(RVA = "0x2BBCAE0", Offset = "0x2BBBEE0", Length = "0x1E")]
	[Token(Token = "0x600016D")]
	public override void SetGlobalInteger(string name, int value) { }

	[Address(RVA = "0x2BBCBF0", Offset = "0x2BBBFF0", Length = "0x4B")]
	[Token(Token = "0x6000170")]
	public override void SetGlobalMatrix(string name, Matrix4x4 value) { }

	[Address(RVA = "0x2BBCBA0", Offset = "0x2BBBFA0", Length = "0x4B")]
	[Token(Token = "0x60000F9")]
	public override void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[Address(RVA = "0x2BBCB20", Offset = "0x2BBBF20", Length = "0x1E")]
	[Token(Token = "0x6000177")]
	public override void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values) { }

	[Address(RVA = "0x2BBCB80", Offset = "0x2BBBF80", Length = "0x1E")]
	[Token(Token = "0x6000178")]
	public override void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	[Address(RVA = "0x2BBCB60", Offset = "0x2BBBF60", Length = "0x1E")]
	[Token(Token = "0x6000109")]
	public override void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBCB40", Offset = "0x2BBBF40", Length = "0x1E")]
	[Token(Token = "0x6000179")]
	public override void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBCD10", Offset = "0x2BBC110", Length = "0xB8")]
	[Token(Token = "0x600017A")]
	public override void SetGlobalTexture(string name, TextureHandle value) { }

	[Address(RVA = "0x2BBCDD0", Offset = "0x2BBC1D0", Length = "0xCB")]
	[Token(Token = "0x600017D")]
	public override void SetGlobalTexture(int nameID, TextureHandle value, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BBCC40", Offset = "0x2BBC040", Length = "0xCD")]
	[Token(Token = "0x600017C")]
	public override void SetGlobalTexture(string name, TextureHandle value, RenderTextureSubElement element) { }

	[Address(RVA = "0x2BBCEA0", Offset = "0x2BBC2A0", Length = "0xB6")]
	[Token(Token = "0x600017B")]
	public override void SetGlobalTexture(int nameID, TextureHandle value) { }

	[Address(RVA = "0x2BBCFE0", Offset = "0x2BBC3E0", Length = "0x2D")]
	[Token(Token = "0x60000F7")]
	public override void SetGlobalVector(int nameID, Vector4 value) { }

	[Address(RVA = "0x2BBD010", Offset = "0x2BBC410", Length = "0x2D")]
	[Token(Token = "0x600016E")]
	public override void SetGlobalVector(string name, Vector4 value) { }

	[Address(RVA = "0x2BBCFA0", Offset = "0x2BBC3A0", Length = "0x1E")]
	[Token(Token = "0x6000108")]
	public override void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[Address(RVA = "0x2BBCF60", Offset = "0x2BBC360", Length = "0x1E")]
	[Token(Token = "0x6000174")]
	public override void SetGlobalVectorArray(string propertyName, List<Vector4> values) { }

	[Address(RVA = "0x2BBCF80", Offset = "0x2BBC380", Length = "0x1E")]
	[Token(Token = "0x6000176")]
	public override void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	[Address(RVA = "0x2BBCFC0", Offset = "0x2BBC3C0", Length = "0x1E")]
	[Token(Token = "0x6000175")]
	public override void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[Address(RVA = "0x2BBD040", Offset = "0x2BBC440", Length = "0x1E")]
	[Token(Token = "0x60000E9")]
	public override void SetInvertCulling(bool invertCulling) { }

	[Address(RVA = "0x2BBD060", Offset = "0x2BBC460", Length = "0x1E")]
	[Token(Token = "0x6000102")]
	public void SetKeyword(in GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD0B0", Offset = "0x2BBC4B0", Length = "0x24")]
	[Token(Token = "0x6000103")]
	public void SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD080", Offset = "0x2BBC480", Length = "0x24")]
	[Token(Token = "0x6000104")]
	public void SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD0E0", Offset = "0x2BBC4E0", Length = "0x1E")]
	[Token(Token = "0x600010A")]
	public override void SetLateLatchProjectionMatrices(Matrix4x4[] projectionMat) { }

	[Address(RVA = "0x2BBD130", Offset = "0x2BBC530", Length = "0x24")]
	[Token(Token = "0x6000146")]
	public override void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x2BBD190", Offset = "0x2BBC590", Length = "0x24")]
	[Token(Token = "0x6000145")]
	public override void SetRayTracingAccelerationStructure(RayTracingShader rayTracingShader, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x2BBD100", Offset = "0x2BBC500", Length = "0x24")]
	[Token(Token = "0x6000148")]
	public override void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, int nameID, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x2BBD160", Offset = "0x2BBC560", Length = "0x24")]
	[Token(Token = "0x6000147")]
	public override void SetRayTracingAccelerationStructure(ComputeShader computeShader, int kernelIndex, string name, RayTracingAccelerationStructure rayTracingAccelerationStructure) { }

	[Address(RVA = "0x2BBD280", Offset = "0x2BBC680", Length = "0x24")]
	[Token(Token = "0x6000149")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer) { }

	[Address(RVA = "0x2BBD2B0", Offset = "0x2BBC6B0", Length = "0x24")]
	[Token(Token = "0x600014A")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer) { }

	[Address(RVA = "0x2BBD1F0", Offset = "0x2BBC5F0", Length = "0x24")]
	[Token(Token = "0x600014B")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer) { }

	[Address(RVA = "0x2BBD1C0", Offset = "0x2BBC5C0", Length = "0x24")]
	[Token(Token = "0x600014D")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x2BBD220", Offset = "0x2BBC620", Length = "0x24")]
	[Token(Token = "0x600014E")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBufferHandle bufferHandle) { }

	[Address(RVA = "0x2BBD250", Offset = "0x2BBC650", Length = "0x24")]
	[Token(Token = "0x600014C")]
	public override void SetRayTracingBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer) { }

	[Address(RVA = "0x2BBD310", Offset = "0x2BBC710", Length = "0x27")]
	[Token(Token = "0x6000150")]
	public override void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBD340", Offset = "0x2BBC740", Length = "0x27")]
	[Token(Token = "0x6000151")]
	public override void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBD2E0", Offset = "0x2BBC6E0", Length = "0x27")]
	[Token(Token = "0x6000152")]
	public override void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, string name, GraphicsBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBD370", Offset = "0x2BBC770", Length = "0x27")]
	[Token(Token = "0x600014F")]
	public override void SetRayTracingConstantBufferParam(RayTracingShader rayTracingShader, int nameID, ComputeBuffer buffer, int offset, int size) { }

	[Address(RVA = "0x2BBD3D0", Offset = "0x2BBC7D0", Length = "0x24")]
	[Token(Token = "0x6000156")]
	public override void SetRayTracingFloatParam(RayTracingShader rayTracingShader, int nameID, float val) { }

	[Address(RVA = "0x2BBD3A0", Offset = "0x2BBC7A0", Length = "0x24")]
	[Token(Token = "0x6000155")]
	public override void SetRayTracingFloatParam(RayTracingShader rayTracingShader, string name, float val) { }

	[Address(RVA = "0x2BBD400", Offset = "0x2BBC800", Length = "0x24")]
	[Token(Token = "0x6000157")]
	public override void SetRayTracingFloatParams(RayTracingShader rayTracingShader, string name, Single[] values) { }

	[Address(RVA = "0x2BBD430", Offset = "0x2BBC830", Length = "0x24")]
	[Token(Token = "0x6000158")]
	public override void SetRayTracingFloatParams(RayTracingShader rayTracingShader, int nameID, Single[] values) { }

	[Address(RVA = "0x2BBD490", Offset = "0x2BBC890", Length = "0x24")]
	[Token(Token = "0x600015A")]
	public override void SetRayTracingIntParam(RayTracingShader rayTracingShader, int nameID, int val) { }

	[Address(RVA = "0x2BBD460", Offset = "0x2BBC860", Length = "0x24")]
	[Token(Token = "0x6000159")]
	public override void SetRayTracingIntParam(RayTracingShader rayTracingShader, string name, int val) { }

	[Address(RVA = "0x2BBD4C0", Offset = "0x2BBC8C0", Length = "0x24")]
	[Token(Token = "0x600015C")]
	public override void SetRayTracingIntParams(RayTracingShader rayTracingShader, int nameID, Int32[] values) { }

	[Address(RVA = "0x2BBD4F0", Offset = "0x2BBC8F0", Length = "0x24")]
	[Token(Token = "0x600015B")]
	public override void SetRayTracingIntParams(RayTracingShader rayTracingShader, string name, Int32[] values) { }

	[Address(RVA = "0x2BBD550", Offset = "0x2BBC950", Length = "0x24")]
	[Token(Token = "0x6000164")]
	public override void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBD520", Offset = "0x2BBC920", Length = "0x24")]
	[Token(Token = "0x6000163")]
	public override void SetRayTracingMatrixArrayParam(RayTracingShader rayTracingShader, string name, Matrix4x4[] values) { }

	[Address(RVA = "0x2BBD580", Offset = "0x2BBC980", Length = "0x51")]
	[Token(Token = "0x6000162")]
	public override void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, int nameID, Matrix4x4 val) { }

	[Address(RVA = "0x2BBD5E0", Offset = "0x2BBC9E0", Length = "0x51")]
	[Token(Token = "0x6000161")]
	public override void SetRayTracingMatrixParam(RayTracingShader rayTracingShader, string name, Matrix4x4 val) { }

	[Address(RVA = "0x2BBD640", Offset = "0x2BBCA40", Length = "0x1E")]
	[Token(Token = "0x60000F0")]
	public override void SetRayTracingShaderPass(RayTracingShader rayTracingShader, string passName) { }

	[Address(RVA = "0x2BBD730", Offset = "0x2BBCB30", Length = "0xCD")]
	[Token(Token = "0x6000154")]
	public override void SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, TextureHandle rt) { }

	[Address(RVA = "0x2BBD660", Offset = "0x2BBCA60", Length = "0xCD")]
	[Token(Token = "0x6000153")]
	public override void SetRayTracingTextureParam(RayTracingShader rayTracingShader, string name, TextureHandle rt) { }

	[Address(RVA = "0x2BBD830", Offset = "0x2BBCC30", Length = "0x24")]
	[Token(Token = "0x6000160")]
	public override void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, int nameID, Vector4[] values) { }

	[Address(RVA = "0x2BBD800", Offset = "0x2BBCC00", Length = "0x24")]
	[Token(Token = "0x600015F")]
	public override void SetRayTracingVectorArrayParam(RayTracingShader rayTracingShader, string name, Vector4[] values) { }

	[Address(RVA = "0x2BBD860", Offset = "0x2BBCC60", Length = "0x33")]
	[Token(Token = "0x600015E")]
	public override void SetRayTracingVectorParam(RayTracingShader rayTracingShader, int nameID, Vector4 val) { }

	[Address(RVA = "0x2BBD8A0", Offset = "0x2BBCCA0", Length = "0x33")]
	[Token(Token = "0x600015D")]
	public override void SetRayTracingVectorParam(RayTracingShader rayTracingShader, string name, Vector4 val) { }

	[Address(RVA = "0x2BBD8E0", Offset = "0x2BBCCE0", Length = "0x40")]
	[Token(Token = "0x6000186")]
	public override void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[Address(RVA = "0x2BBD930", Offset = "0x2BBCD30", Length = "0x1E")]
	[Token(Token = "0x6000187")]
	public override void SetSinglePassStereo(SinglePassStereoMode mode) { }

	[Address(RVA = "0x2BBDA00", Offset = "0x2BBCE00", Length = "0x1E")]
	[Token(Token = "0x6000122")]
	public override void SetupCameraProperties(Camera camera) { }

	[Address(RVA = "0x2BBD9D0", Offset = "0x2BBCDD0", Length = "0x2C")]
	[Token(Token = "0x60000F1")]
	public override void SetViewport(Rect pixelRect) { }

	[Address(RVA = "0x2BBD950", Offset = "0x2BBCD50", Length = "0x74")]
	[Token(Token = "0x6000105")]
	public override void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[Address(RVA = "0x2BBB7E0", Offset = "0x2BBABE0", Length = "0x1E")]
	[Token(Token = "0x600018F")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB820", Offset = "0x2BBAC20", Length = "0x1E")]
	[Token(Token = "0x6000190")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB800", Offset = "0x2BBAC00", Length = "0x1E")]
	[Token(Token = "0x6000191")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB970", Offset = "0x2BBAD70", Length = "0x1E")]
	[Token(Token = "0x600018C")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(in GlobalKeyword keyword) { }

	[Address(RVA = "0x2BBB9B0", Offset = "0x2BBADB0", Length = "0x1E")]
	[Token(Token = "0x600018D")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(Material material, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBB990", Offset = "0x2BBAD90", Length = "0x1E")]
	[Token(Token = "0x600018E")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Address(RVA = "0x2BBD060", Offset = "0x2BBC460", Length = "0x1E")]
	[Token(Token = "0x6000192")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(in GlobalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD0B0", Offset = "0x2BBC4B0", Length = "0x24")]
	[Token(Token = "0x6000193")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBD080", Offset = "0x2BBC480", Length = "0x24")]
	[Token(Token = "0x6000194")]
	private override void UnityEngine.Rendering.IBaseCommandBuffer.SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2BBDA20", Offset = "0x2BBCE20", Length = "0x1E")]
	[Token(Token = "0x600010C")]
	public override void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType) { }

}

