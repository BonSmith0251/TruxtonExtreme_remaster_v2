namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000052")]
internal interface IRayTracingBackend
{

	[Token(Token = "0x6000166")]
	public IRayTracingAccelStruct CreateAccelerationStructure(AccelerationStructureOptions options, ReferenceCounter counter) { }

	[Token(Token = "0x6000165")]
	public IRayTracingShader CreateRayTracingShader(object shader, string kernelName, GraphicsBuffer dispatchBuffer) { }

	[Token(Token = "0x6000167")]
	public ulong GetRequiredTraceScratchBufferSizeInBytes(uint width, uint height, uint depth) { }

}

