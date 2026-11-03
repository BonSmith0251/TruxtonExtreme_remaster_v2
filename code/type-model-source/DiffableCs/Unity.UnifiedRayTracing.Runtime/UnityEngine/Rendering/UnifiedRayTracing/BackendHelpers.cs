namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200003E")]
public static class BackendHelpers
{

	[Address(RVA = "0x2F50390", Offset = "0x2F4F790", Length = "0xEC")]
	[Token(Token = "0x60000CC")]
	public static string GetFileNameOfShader(RayTracingBackend backend, string fileName) { }

	[Address(RVA = "0x2F50480", Offset = "0x2F4F880", Length = "0xEC")]
	[Token(Token = "0x60000CD")]
	public static Type GetTypeOfShader(RayTracingBackend backend) { }

}

