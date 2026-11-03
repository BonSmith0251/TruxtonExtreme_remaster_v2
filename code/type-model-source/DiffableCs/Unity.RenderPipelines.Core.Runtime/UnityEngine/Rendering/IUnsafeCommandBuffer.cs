namespace UnityEngine.Rendering;

[Token(Token = "0x2000025")]
public interface IUnsafeCommandBuffer : IBaseCommandBuffer, IRasterCommandBuffer, IComputeCommandBuffer
{

	[Token(Token = "0x600027F")]
	public void Clear() { }

	[Token(Token = "0x6000280")]
	public void ClearRandomWriteTargets() { }

	[Token(Token = "0x60002A2")]
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[Token(Token = "0x60002A1")]
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	[Token(Token = "0x60002A0")]
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, RenderTargetIdentifier dst, int dstElement) { }

	[Token(Token = "0x600029F")]
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	[Token(Token = "0x6000299")]
	public void GenerateMips(RenderTexture rt) { }

	[Token(Token = "0x6000298")]
	public void GenerateMips(RenderTargetIdentifier rt) { }

	[Token(Token = "0x6000269")]
	public void RequestAsyncReadback(ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x6000273")]
	public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x6000272")]
	public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x6000270")]
	public void RequestAsyncReadback(Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x600026F")]
	public void RequestAsyncReadback(Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x600026E")]
	public void RequestAsyncReadback(Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x600026D")]
	public void RequestAsyncReadback(Texture src, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x600026C")]
	public void RequestAsyncReadback(GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x600026B")]
	public void RequestAsyncReadback(ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x600026A")]
	public void RequestAsyncReadback(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x6000271")]
	public void RequestAsyncReadback(Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x600027E")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x600027B")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, GraphicsFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x600027C")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x6000274")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, ComputeBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x6000275")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, ComputeBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x600027D")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x6000277")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x6000278")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x6000276")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x600027A")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, TextureFormat dstFormat, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x6000279")]
	public void RequestAsyncReadbackIntoNativeArray(ref NativeArray<T>& output, Texture src, int mipIndex, Action<AsyncGPUReadbackRequest> callback) { }

	[Token(Token = "0x6000291")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt) { }

	[Token(Token = "0x6000295")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[Token(Token = "0x6000294")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[Token(Token = "0x6000293")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel) { }

	[Token(Token = "0x6000292")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt, int mipLevel) { }

	[Token(Token = "0x6000290")]
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	[Token(Token = "0x60002A3")]
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	[Token(Token = "0x60002A4")]
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	[Token(Token = "0x60002A6")]
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	[Token(Token = "0x60002A5")]
	public void SetGlobalTexture(string name, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	[Token(Token = "0x600029B")]
	public void SetRandomWriteTarget(int index, ComputeBuffer buffer, bool preserveCounterValue) { }

	[Token(Token = "0x600029A")]
	public void SetRandomWriteTarget(int index, RenderTargetIdentifier rt) { }

	[Token(Token = "0x600029E")]
	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer) { }

	[Token(Token = "0x600029C")]
	public void SetRandomWriteTarget(int index, ComputeBuffer buffer) { }

	[Token(Token = "0x600029D")]
	public void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue) { }

	[Token(Token = "0x6000296")]
	public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, string name, RenderTargetIdentifier rt) { }

	[Token(Token = "0x6000297")]
	public void SetRayTracingTextureParam(RayTracingShader rayTracingShader, int nameID, RenderTargetIdentifier rt) { }

	[Token(Token = "0x6000281")]
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	[Token(Token = "0x6000282")]
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[Token(Token = "0x6000283")]
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Token(Token = "0x6000284")]
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel) { }

	[Token(Token = "0x6000285")]
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace) { }

	[Token(Token = "0x6000286")]
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Token(Token = "0x600028E")]
	public void SetRenderTarget(RenderTargetBinding binding, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Token(Token = "0x6000288")]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel) { }

	[Token(Token = "0x6000289")]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace) { }

	[Token(Token = "0x600028A")]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Token(Token = "0x600028B")]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Token(Token = "0x600028C")]
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	[Token(Token = "0x600028D")]
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	[Token(Token = "0x600028F")]
	public void SetRenderTarget(RenderTargetBinding binding) { }

	[Token(Token = "0x6000287")]
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

}

