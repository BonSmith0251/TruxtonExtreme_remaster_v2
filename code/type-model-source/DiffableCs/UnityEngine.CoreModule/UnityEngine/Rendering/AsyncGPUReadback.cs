namespace UnityEngine.Rendering;

[StaticAccessor("AsyncGPUReadbackManager::GetInstance()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000339")]
public static class AsyncGPUReadback
{

	[Address(RVA = "0x3077CD0", Offset = "0x30770D0", Length = "0x108")]
	[Token(Token = "0x60019FA")]
	public static AsyncGPUReadbackRequest Request(GraphicsBuffer src, Action<AsyncGPUReadbackRequest> callback = null) { }

	[Address(RVA = "0x3077DE0", Offset = "0x30771E0", Length = "0x128")]
	[Token(Token = "0x60019FB")]
	public static AsyncGPUReadbackRequest Request(GraphicsBuffer src, int size, int offset, Action<AsyncGPUReadbackRequest> callback = null) { }

	[Address(RVA = "0x3077AE0", Offset = "0x3076EE0", Length = "0xB3")]
	[NativeMethod("Request")]
	[Token(Token = "0x60019FC")]
	private static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1(GraphicsBuffer buffer, AsyncRequestNativeArrayData* data) { }

	[Address(RVA = "0x3077A80", Offset = "0x3076E80", Length = "0x52")]
	[Token(Token = "0x60019FE")]
	private static void Request_Internal_GraphicsBuffer_1_Injected(IntPtr buffer, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret) { }

	[Address(RVA = "0x3077C00", Offset = "0x3077000", Length = "0xCC")]
	[NativeMethod("Request")]
	[Token(Token = "0x60019FD")]
	private static AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_2(GraphicsBuffer src, int size, int offset, AsyncRequestNativeArrayData* data) { }

	[Address(RVA = "0x3077BA0", Offset = "0x3076FA0", Length = "0x60")]
	[Token(Token = "0x60019FF")]
	private static void Request_Internal_GraphicsBuffer_2_Injected(IntPtr src, int size, int offset, AsyncRequestNativeArrayData* data, out AsyncGPUReadbackRequest ret) { }

}

