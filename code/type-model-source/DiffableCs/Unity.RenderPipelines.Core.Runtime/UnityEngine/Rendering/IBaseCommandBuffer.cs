namespace UnityEngine.Rendering;

[Token(Token = "0x2000022")]
public interface IBaseCommandBuffer
{

	[Token(Token = "0x60001B2")]
	public void BeginSample(string name) { }

	[Token(Token = "0x60001B6")]
	public void BeginSample(ProfilerMarker marker) { }

	[Token(Token = "0x60001B4")]
	public void BeginSample(CustomSampler sampler) { }

	[Token(Token = "0x60001A5")]
	public void DisableKeyword(Material material, in LocalKeyword keyword) { }

	[Token(Token = "0x60001A4")]
	public void DisableKeyword(in GlobalKeyword keyword) { }

	[Token(Token = "0x60001A6")]
	public void DisableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Token(Token = "0x6000198")]
	public void DisableScissorRect() { }

	[Token(Token = "0x60001A3")]
	public void DisableShaderKeyword(string keyword) { }

	[Token(Token = "0x60001A2")]
	public void EnableKeyword(ComputeShader computeShader, in LocalKeyword keyword) { }

	[Token(Token = "0x60001A0")]
	public void EnableKeyword(in GlobalKeyword keyword) { }

	[Token(Token = "0x60001A1")]
	public void EnableKeyword(Material material, in LocalKeyword keyword) { }

	[Token(Token = "0x6000197")]
	public void EnableScissorRect(Rect scissor) { }

	[Token(Token = "0x600019F")]
	public void EnableShaderKeyword(string keyword) { }

	[Token(Token = "0x60001B3")]
	public void EndSample(string name) { }

	[Token(Token = "0x60001B7")]
	public void EndSample(ProfilerMarker marker) { }

	[Token(Token = "0x60001B5")]
	public void EndSample(CustomSampler sampler) { }

	[Token(Token = "0x60001B8")]
	public void IncrementUpdateCount(RenderTargetIdentifier dest) { }

	[Token(Token = "0x60001BA")]
	public void InvokeOnRenderObjectCallbacks() { }

	[Token(Token = "0x60001DA")]
	public void IssuePluginCustomBlit(IntPtr callback, uint command, RenderTargetIdentifier source, RenderTargetIdentifier dest, uint commandParam, uint commandFlags) { }

	[Token(Token = "0x60001DB")]
	public void IssuePluginCustomTextureUpdateV2(IntPtr callback, Texture targetTexture, uint userData) { }

	[Token(Token = "0x60001D8")]
	public void IssuePluginEvent(IntPtr callback, int eventID) { }

	[Token(Token = "0x60001D9")]
	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	[Token(Token = "0x60001B0")]
	public void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID) { }

	[Token(Token = "0x60001D0")]
	public void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	[Token(Token = "0x60001CF")]
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[Token(Token = "0x60001CE")]
	public void SetGlobalBuffer(string name, ComputeBuffer value) { }

	[Token(Token = "0x60001D1")]
	public void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	[Token(Token = "0x60001BF")]
	public void SetGlobalColor(string name, Color value) { }

	[Token(Token = "0x600019D")]
	public void SetGlobalColor(int nameID, Color value) { }

	[Token(Token = "0x60001D5")]
	public void SetGlobalConstantBuffer(GraphicsBuffer buffer, string name, int offset, int size) { }

	[Token(Token = "0x60001D3")]
	public void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size) { }

	[Token(Token = "0x60001D4")]
	public void SetGlobalConstantBuffer(GraphicsBuffer buffer, int nameID, int offset, int size) { }

	[Token(Token = "0x60001D2")]
	public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size) { }

	[Token(Token = "0x60001AB")]
	public void SetGlobalDepthBias(float bias, float slopeBias) { }

	[Token(Token = "0x60001BB")]
	public void SetGlobalFloat(string name, float value) { }

	[Token(Token = "0x6000199")]
	public void SetGlobalFloat(int nameID, float value) { }

	[Token(Token = "0x60001C1")]
	public void SetGlobalFloatArray(string propertyName, List<Single> values) { }

	[Token(Token = "0x60001C3")]
	public void SetGlobalFloatArray(string propertyName, Single[] values) { }

	[Token(Token = "0x60001C2")]
	public void SetGlobalFloatArray(int nameID, List<Single> values) { }

	[Token(Token = "0x60001AC")]
	public void SetGlobalFloatArray(int nameID, Single[] values) { }

	[Token(Token = "0x60001BC")]
	public void SetGlobalInt(string name, int value) { }

	[Token(Token = "0x600019A")]
	public void SetGlobalInt(int nameID, int value) { }

	[Token(Token = "0x600019B")]
	public void SetGlobalInteger(int nameID, int value) { }

	[Token(Token = "0x60001BD")]
	public void SetGlobalInteger(string name, int value) { }

	[Token(Token = "0x60001C0")]
	public void SetGlobalMatrix(string name, Matrix4x4 value) { }

	[Token(Token = "0x600019E")]
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[Token(Token = "0x60001C9")]
	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	[Token(Token = "0x60001C7")]
	public void SetGlobalMatrixArray(string propertyName, List<Matrix4x4> values) { }

	[Token(Token = "0x60001C8")]
	public void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	[Token(Token = "0x60001AE")]
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[Token(Token = "0x60001CA")]
	public void SetGlobalTexture(string name, TextureHandle value) { }

	[Token(Token = "0x60001CB")]
	public void SetGlobalTexture(int nameID, TextureHandle value) { }

	[Token(Token = "0x60001CC")]
	public void SetGlobalTexture(string name, TextureHandle value, RenderTextureSubElement element) { }

	[Token(Token = "0x60001CD")]
	public void SetGlobalTexture(int nameID, TextureHandle value, RenderTextureSubElement element) { }

	[Token(Token = "0x60001BE")]
	public void SetGlobalVector(string name, Vector4 value) { }

	[Token(Token = "0x600019C")]
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[Token(Token = "0x60001C4")]
	public void SetGlobalVectorArray(string propertyName, List<Vector4> values) { }

	[Token(Token = "0x60001AD")]
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[Token(Token = "0x60001C5")]
	public void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[Token(Token = "0x60001C6")]
	public void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	[Token(Token = "0x6000195")]
	public void SetInvertCulling(bool invertCulling) { }

	[Token(Token = "0x60001A7")]
	public void SetKeyword(in GlobalKeyword keyword, bool value) { }

	[Token(Token = "0x60001A8")]
	public void SetKeyword(Material material, in LocalKeyword keyword, bool value) { }

	[Token(Token = "0x60001A9")]
	public void SetKeyword(ComputeShader computeShader, in LocalKeyword keyword, bool value) { }

	[Token(Token = "0x60001AF")]
	public void SetLateLatchProjectionMatrices(Matrix4x4[] projectionMat) { }

	[Token(Token = "0x60001D6")]
	public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[Token(Token = "0x60001D7")]
	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	[Token(Token = "0x60001B9")]
	public void SetupCameraProperties(Camera camera) { }

	[Token(Token = "0x6000196")]
	public void SetViewport(Rect pixelRect) { }

	[Token(Token = "0x60001AA")]
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[Token(Token = "0x60001B1")]
	public void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType) { }

}

