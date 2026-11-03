namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200004D")]
internal sealed class HardwareRayTracingAccelStruct : IRayTracingAccelStruct, IDisposable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C5")]
	private readonly RayTracingAccelerationStructure <accelStruct>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C6")]
	private readonly RayTracingAccelerationStructureBuildFlags m_BuildFlags; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C7")]
	private readonly Dictionary<Int32, Mesh> m_Meshes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C8")]
	private readonly ReferenceCounter m_Counter; //Field offset: 0x28

	[Token(Token = "0x17000022")]
	public RayTracingAccelerationStructure accelStruct
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600013D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2F62E90", Offset = "0x2F62290", Length = "0x16A")]
	[Token(Token = "0x600013E")]
	internal HardwareRayTracingAccelStruct(AccelerationStructureOptions options, ReferenceCounter counter) { }

	[Address(RVA = "0x2F629F0", Offset = "0x2F61DF0", Length = "0x263")]
	[Token(Token = "0x6000140")]
	public override int AddInstance(MeshInstanceDesc meshInstance) { }

	[Address(RVA = "0x2F62C60", Offset = "0x2F62060", Length = "0x9A")]
	[Token(Token = "0x6000146")]
	public override void Build(CommandBuffer cmd, GraphicsBuffer scratchBuffer) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x6000148")]
	private void CheckInstanceHandleIsValid(int instanceHandle) { }

	[Address(RVA = "0x2F62D00", Offset = "0x2F62100", Length = "0x54")]
	[Token(Token = "0x6000142")]
	public override void ClearInstances() { }

	[Address(RVA = "0x2F62D60", Offset = "0x2F62160", Length = "0x2F")]
	[Token(Token = "0x600013F")]
	public override void Dispose() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600013D")]
	public RayTracingAccelerationStructure get_accelStruct() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000147")]
	public override ulong GetBuildScratchBufferRequiredSizeInBytes() { }

	[Address(RVA = "0x2F62D90", Offset = "0x2F62190", Length = "0x64")]
	[Token(Token = "0x6000141")]
	public override void RemoveInstance(int instanceHandle) { }

	[Address(RVA = "0x2F62E00", Offset = "0x2F62200", Length = "0x1E")]
	[Token(Token = "0x6000144")]
	public override void UpdateInstanceID(int instanceHandle, uint instanceID) { }

	[Address(RVA = "0x2F62E20", Offset = "0x2F62220", Length = "0x1E")]
	[Token(Token = "0x6000145")]
	public override void UpdateInstanceMask(int instanceHandle, uint mask) { }

	[Address(RVA = "0x2F62E40", Offset = "0x2F62240", Length = "0x4B")]
	[Token(Token = "0x6000143")]
	public override void UpdateInstanceTransform(int instanceHandle, Matrix4x4 localToWorldMatrix) { }

}

