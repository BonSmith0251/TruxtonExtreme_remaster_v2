namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200004E")]
internal class HardwareRayTracingBackend : IRayTracingBackend
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C9")]
	private readonly RayTracingResources m_Resources; //Field offset: 0x10

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000149")]
	public HardwareRayTracingBackend(RayTracingResources resources) { }

	[Address(RVA = "0x2F63000", Offset = "0x2F62400", Length = "0x195")]
	[Token(Token = "0x600014B")]
	public override IRayTracingAccelStruct CreateAccelerationStructure(AccelerationStructureOptions options, ReferenceCounter counter) { }

	[Address(RVA = "0x2F631A0", Offset = "0x2F625A0", Length = "0xB5")]
	[Token(Token = "0x600014A")]
	public override IRayTracingShader CreateRayTracingShader(object shader, string kernelName, GraphicsBuffer dispatchBuffer) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600014C")]
	public override ulong GetRequiredTraceScratchBufferSizeInBytes(uint width, uint height, uint depth) { }

}

