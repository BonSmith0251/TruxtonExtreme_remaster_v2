namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200004B")]
internal class ComputeRayTracingBackend : IRayTracingBackend
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BF")]
	private readonly RayTracingResources m_Resources; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000128")]
	public ComputeRayTracingBackend(RayTracingResources resources) { }

	[Address(RVA = "0x2F61E20", Offset = "0x2F61220", Length = "0x86")]
	[Token(Token = "0x600012A")]
	public override IRayTracingAccelStruct CreateAccelerationStructure(AccelerationStructureOptions options, ReferenceCounter counter) { }

	[Address(RVA = "0x2F61EB0", Offset = "0x2F612B0", Length = "0x14B")]
	[Token(Token = "0x6000129")]
	public override IRayTracingShader CreateRayTracingShader(object shader, string kernelName, GraphicsBuffer dispatchBuffer) { }

	[Address(RVA = "0x2F62000", Offset = "0x2F61400", Length = "0x1E")]
	[Token(Token = "0x600012B")]
	public override ulong GetRequiredTraceScratchBufferSizeInBytes(uint width, uint height, uint depth) { }

}

