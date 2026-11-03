namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
[NativeHeader("Runtime/Graphics/Texture.h")]
[Token(Token = "0x2000337")]
[UsedByNativeCode]
public struct AsyncGPUReadbackRequest
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000872")]
	internal IntPtr m_Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000873")]
	internal int m_Version; //Field offset: 0x8

	[Token(Token = "0x170003BA")]
	public bool done
	{
		[Address(RVA = "0x30779B0", Offset = "0x3076DB0", Length = "0x33")]
		[Token(Token = "0x60019EE")]
		 get { } //Length: 51
	}

	[Token(Token = "0x170003BB")]
	public bool hasError
	{
		[Address(RVA = "0x3077940", Offset = "0x3076D40", Length = "0x33")]
		[Token(Token = "0x60019EF")]
		 get { } //Length: 51
	}

	[Token(Token = "0x170003BC")]
	public int layerCount
	{
		[Address(RVA = "0x30778C0", Offset = "0x3076CC0", Length = "0x33")]
		[Token(Token = "0x60019F0")]
		 get { } //Length: 51
	}

	[Token(Token = "0x170003BD")]
	public int layerDataSize
	{
		[Address(RVA = "0x3077900", Offset = "0x3076D00", Length = "0x33")]
		[Token(Token = "0x60019F1")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x30779B0", Offset = "0x3076DB0", Length = "0x33")]
	[Token(Token = "0x60019EE")]
	public bool get_done() { }

	[Address(RVA = "0x3077940", Offset = "0x3076D40", Length = "0x33")]
	[Token(Token = "0x60019EF")]
	public bool get_hasError() { }

	[Address(RVA = "0x30778C0", Offset = "0x3076CC0", Length = "0x33")]
	[Token(Token = "0x60019F0")]
	public int get_layerCount() { }

	[Address(RVA = "0x3077900", Offset = "0x3076D00", Length = "0x33")]
	[Token(Token = "0x60019F1")]
	public int get_layerDataSize() { }

	[Address(RVA = "0x7356E0", Offset = "0x734AE0", Length = "0x19A")]
	[Token(Token = "0x60019ED")]
	public NativeArray<T> GetData(int layer = 0) { }

	[Address(RVA = "0x3077880", Offset = "0x3076C80", Length = "0x40")]
	[Token(Token = "0x60019F7")]
	private IntPtr GetDataRaw(int layer) { }

	[Address(RVA = "0x30778C0", Offset = "0x3076CC0", Length = "0x33")]
	[Token(Token = "0x60019F4")]
	private int GetLayerCount() { }

	[Address(RVA = "0x3077900", Offset = "0x3076D00", Length = "0x33")]
	[Token(Token = "0x60019F5")]
	private int GetLayerDataSize() { }

	[Address(RVA = "0x3077940", Offset = "0x3076D40", Length = "0x33")]
	[Token(Token = "0x60019F3")]
	private bool HasError() { }

	[Address(RVA = "0x3077980", Offset = "0x3076D80", Length = "0x2E")]
	[RequiredByNativeCode]
	[Token(Token = "0x60019F8")]
	private static void InvokeCallback(Action<AsyncGPUReadbackRequest> callback, AsyncGPUReadbackRequest obj) { }

	[Address(RVA = "0x30779B0", Offset = "0x3076DB0", Length = "0x33")]
	[Token(Token = "0x60019F2")]
	private bool IsDone() { }

	[Address(RVA = "0x30779F0", Offset = "0x3076DF0", Length = "0x42")]
	[Token(Token = "0x60019F6")]
	internal void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback) { }

	[Address(RVA = "0x3077A40", Offset = "0x3076E40", Length = "0x33")]
	[Token(Token = "0x60019EC")]
	public void WaitForCompletion() { }

}

