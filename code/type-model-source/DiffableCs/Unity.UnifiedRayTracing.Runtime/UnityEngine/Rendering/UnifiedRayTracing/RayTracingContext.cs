namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000055")]
public sealed class RayTracingContext : IDisposable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D7")]
	private RayTracingResources <Resources>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001D8")]
	private RayTracingBackend <BackendType>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D9")]
	private readonly IRayTracingBackend m_Backend; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001DA")]
	private readonly ReferenceCounter m_AccelStructCounter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001DB")]
	private readonly GraphicsBuffer m_DispatchBuffer; //Field offset: 0x30

	[Token(Token = "0x17000024")]
	public private RayTracingBackend BackendType
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000181")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000182")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000023")]
	public private RayTracingResources Resources
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000179")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600017A")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2F63B30", Offset = "0x2F62F30", Length = "0x201")]
	[Token(Token = "0x6000176")]
	public RayTracingContext(RayTracingBackend backend, RayTracingResources resources) { }

	[Address(RVA = "0x2F63AF0", Offset = "0x2F62EF0", Length = "0x35")]
	[Token(Token = "0x6000177")]
	public RayTracingContext(RayTracingResources resources) { }

	[Address(RVA = "0x2F636D0", Offset = "0x2F62AD0", Length = "0xCC")]
	[Token(Token = "0x600017E")]
	public IRayTracingAccelStruct CreateAccelerationStructure(AccelerationStructureOptions options) { }

	[Address(RVA = "0x2F637A0", Offset = "0x2F62BA0", Length = "0xF1")]
	[Token(Token = "0x600017C")]
	public IRayTracingShader CreateRayTracingShader(object shader) { }

	[Address(RVA = "0x2F638A0", Offset = "0x2F62CA0", Length = "0x84")]
	[Token(Token = "0x6000178")]
	public override void Dispose() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000181")]
	public RayTracingBackend get_BackendType() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000179")]
	public RayTracingResources get_Resources() { }

	[Address(RVA = "0x2F63930", Offset = "0x2F62D30", Length = "0x7A")]
	[Token(Token = "0x600017F")]
	public ulong GetRequiredTraceScratchBufferSizeInBytes(uint width, uint height, uint depth) { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x6000180")]
	public static uint GetScratchBufferStrideInBytes() { }

	[Address(RVA = "0x2F639B0", Offset = "0x2F62DB0", Length = "0x1A")]
	[Token(Token = "0x600017B")]
	public static bool IsBackendSupported(RayTracingBackend backend) { }

	[Address(RVA = "0x2F639D0", Offset = "0x2F62DD0", Length = "0x115")]
	[Token(Token = "0x600017D")]
	public IRayTracingShader LoadRayTracingShaderFromAssetBundle(AssetBundle assetBundle, string name) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000182")]
	private void set_BackendType(RayTracingBackend value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600017A")]
	private void set_Resources(RayTracingResources value) { }

}

