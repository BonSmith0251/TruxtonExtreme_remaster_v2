namespace UnityEngine.Rendering;

[MovedFrom("UnityEngine.Experimental.Rendering")]
[Token(Token = "0x2000383")]
public struct RayTracingMeshInstanceConfig
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A87")]
	public Mesh mesh; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A88")]
	public uint subMeshIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000A89")]
	public RayTracingSubMeshFlags subMeshFlags; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A8A")]
	private RayTracingMode <rayTracingMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A8B")]
	private bool <dynamicGeometry>k__BackingField; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A8C")]
	public Material material; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A8D")]
	public MaterialPropertyBlock materialProperties; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A8E")]
	public bool enableTriangleCulling; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000A8F")]
	public bool frontTriangleCounterClockwise; //Field offset: 0x29
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000A90")]
	public int layer; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A91")]
	public uint renderingLayerMask; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000A92")]
	public uint mask; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A93")]
	public MotionVectorGenerationMode motionVectorMode; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000A94")]
	public LightProbeUsage lightProbeUsage; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A95")]
	public LightProbeProxyVolume lightProbeProxyVolume; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A96")]
	private RayTracingAccelerationStructureBuildFlags <accelerationStructureBuildFlags>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000A97")]
	private bool <accelerationStructureBuildFlagsOverride>k__BackingField; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A98")]
	public int meshLod; //Field offset: 0x50

	[Token(Token = "0x170003DE")]
	public RayTracingAccelerationStructureBuildFlags accelerationStructureBuildFlags
	{
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A60")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003DF")]
	public bool accelerationStructureBuildFlagsOverride
	{
		[Address(RVA = "0x29E48A0", Offset = "0x29E3CA0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A61")]
		 set { } //Length: 4
	}

	[Obsolete("dynamicGeometry has been deprecated and will be removed in the future. Use rayTracingMode instead.", False)]
	[Token(Token = "0x170003DD")]
	public bool dynamicGeometry
	{
		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A5F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003DC")]
	public RayTracingMode rayTracingMode
	{
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A5E")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x30B6F20", Offset = "0x30B6320", Length = "0x105")]
	[Token(Token = "0x6001A5C")]
	public RayTracingMeshInstanceConfig() { }

	[Address(RVA = "0x30B6DF0", Offset = "0x30B61F0", Length = "0x124")]
	[Token(Token = "0x6001A5D")]
	public RayTracingMeshInstanceConfig(Mesh mesh, uint subMeshIndex, Material material) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A60")]
	public void set_accelerationStructureBuildFlags(RayTracingAccelerationStructureBuildFlags value) { }

	[Address(RVA = "0x29E48A0", Offset = "0x29E3CA0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A61")]
	public void set_accelerationStructureBuildFlagsOverride(bool value) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A5F")]
	public void set_dynamicGeometry(bool value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A5E")]
	public void set_rayTracingMode(RayTracingMode value) { }

}

