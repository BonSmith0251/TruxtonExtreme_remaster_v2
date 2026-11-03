namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000047")]
internal class ComputeRayTracingAccelStruct : IRayTracingAccelStruct, IDisposable
{
	[Token(Token = "0x200004A")]
	private sealed class MeshBlas
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001B9")]
		public MeshBuildInfo buildInfo; //Field offset: 0x10
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001BA")]
		public Allocation bvhAlloc; //Field offset: 0x40
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40001BB")]
		public Allocation bvhLeavesAlloc; //Field offset: 0x4C
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40001BC")]
		public Allocation blasVertices; //Field offset: 0x58
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x40001BD")]
		public bool bvhBuilt; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001BE")]
		private uint refCount; //Field offset: 0x68

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000127")]
		public MeshBlas() { }

		[Address(RVA = "0x2F63610", Offset = "0x2F62A10", Length = "0x4")]
		[Token(Token = "0x6000125")]
		public void DecRef() { }

		[Address(RVA = "0x2F63620", Offset = "0x2F62A20", Length = "0x4")]
		[Token(Token = "0x6000124")]
		public void IncRef() { }

		[Address(RVA = "0x2F63630", Offset = "0x2F62A30", Length = "0x8")]
		[Token(Token = "0x6000126")]
		public bool IsUnreferenced() { }

	}

	[Token(Token = "0x2000049")]
	private sealed class RadeonRaysInstance
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001B1")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"mesh", "subMeshIndex"})]
		public ValueTuple<Int32, Int32> geomKey; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001B2")]
		public MeshBlas blas; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001B3")]
		public uint instanceMask; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40001B4")]
		public bool triangleCullingEnabled; //Field offset: 0x24
		[FieldOffset(Offset = "0x25")]
		[Token(Token = "0x40001B5")]
		public bool invertTriangleCulling; //Field offset: 0x25
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001B6")]
		public uint userInstanceID; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40001B7")]
		public bool opaqueGeometry; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001B8")]
		public Transform localToWorldTransform; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000123")]
		public RadeonRaysInstance() { }

	}

	[Token(Token = "0x2000048")]
	private struct Triangle
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AE")]
		public float3 v0; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40001AF")]
		public float3 v1; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001B0")]
		public float3 v2; //Field offset: 0x18

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A0")]
	private readonly uint m_HandleObfuscation; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A1")]
	private readonly RadeonRaysAPI m_RadeonRaysAPI; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A2")]
	private readonly BuildFlags m_BuildFlags; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001A3")]
	private readonly ReferenceCounter m_Counter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001A4")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"mesh", "subMeshIndex"})]
	private readonly Dictionary<ValueTuple`2<Int32, Int32>, MeshBlas> m_Blases; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001A5")]
	internal BlockAllocator m_BlasAllocator; //Field offset: 0x38
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001A6")]
	private GraphicsBuffer m_BlasBuffer; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001A7")]
	internal BlockAllocator m_BlasLeavesAllocator; //Field offset: 0x60
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001A8")]
	private GraphicsBuffer m_BlasLeavesBuffer; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40001A9")]
	private readonly BLASPositionsPool m_BlasPositions; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40001AA")]
	private Nullable<TopLevelAccelStruct> m_TopLevelAccelStruct; //Field offset: 0x90
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001AB")]
	private readonly ComputeShader m_CopyShader; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001AC")]
	private readonly Dictionary<Int32, RadeonRaysInstance> m_RadeonInstances; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40001AD")]
	private readonly Queue<UInt32> m_FreeHandles; //Field offset: 0xC8

	[Token(Token = "0x17000020")]
	internal GraphicsBuffer bottomLevelBvhBuffer
	{
		[Address(RVA = "0x2F564A0", Offset = "0x2F558A0", Length = "0x4F")]
		[Token(Token = "0x6000102")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000021")]
	internal GraphicsBuffer instanceInfoBuffer
	{
		[Address(RVA = "0x2F564F0", Offset = "0x2F558F0", Length = "0x4F")]
		[Token(Token = "0x6000103")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700001F")]
	internal GraphicsBuffer topLevelBvhBuffer
	{
		[Address(RVA = "0x2F56540", Offset = "0x2F55940", Length = "0x4F")]
		[Token(Token = "0x6000101")]
		internal get { } //Length: 79
	}

	[Address(RVA = "0x2F55F70", Offset = "0x2F55370", Length = "0x525")]
	[Token(Token = "0x6000100")]
	internal ComputeRayTracingAccelStruct(AccelerationStructureOptions options, RayTracingResources resources, ReferenceCounter counter, int blasBufferInitialSizeBytes = 67108864) { }

	[Address(RVA = "0x2F527C0", Offset = "0x2F51BC0", Length = "0x57D")]
	[Token(Token = "0x6000105")]
	public override int AddInstance(MeshInstanceDesc meshInstance) { }

	[Address(RVA = "0x2F533A0", Offset = "0x2F527A0", Length = "0x68F")]
	[Token(Token = "0x600010F")]
	private void AllocateBlas(Mesh mesh, int submeshIndex, MeshBlas blas) { }

	[Address(RVA = "0x2F52D40", Offset = "0x2F52140", Length = "0x323")]
	[Token(Token = "0x600011E")]
	private Allocation AllocateBlasInternalNodes(int allocationNodeCount) { }

	[Address(RVA = "0x2F53070", Offset = "0x2F52470", Length = "0x326")]
	[Token(Token = "0x600011F")]
	private Allocation AllocateBlasLeafNodes(int allocationNodeCount) { }

	[Address(RVA = "0x2F53CE0", Offset = "0x2F530E0", Length = "0x29C")]
	[Token(Token = "0x6000119")]
	public void Bind(CommandBuffer cmd, string name, ComputeShader shader, int kernelIndex) { }

	[Address(RVA = "0x2F53A30", Offset = "0x2F52E30", Length = "0x2A9")]
	[Token(Token = "0x6000118")]
	public void Bind(CommandBuffer cmd, string name, IRayTracingShader shader) { }

	[Address(RVA = "0x2F546B0", Offset = "0x2F53AB0", Length = "0x79")]
	[Token(Token = "0x600010B")]
	public override void Build(CommandBuffer cmd, GraphicsBuffer scratchBuffer) { }

	[Address(RVA = "0x2F53F80", Offset = "0x2F53380", Length = "0x299")]
	[Token(Token = "0x6000115")]
	private void BuildMissingBottomLevelAccelStructs(CommandBuffer cmd, GraphicsBuffer scratchBuffer) { }

	[Address(RVA = "0x2F54220", Offset = "0x2F53620", Length = "0x480")]
	[Token(Token = "0x6000116")]
	private void BuildTopLevelAccelStruct(CommandBuffer cmd, GraphicsBuffer scratchBuffer) { }

	[Address(RVA = "0x2F54730", Offset = "0x2F53B30", Length = "0xDE")]
	[Conditional("UNITY_ASSERTIONS")]
	[Token(Token = "0x6000122")]
	private void CheckInstanceHandleIsValid(int instanceHandle) { }

	[Address(RVA = "0x2F54810", Offset = "0x2F53C10", Length = "0x36A")]
	[Token(Token = "0x6000107")]
	public override void ClearInstances() { }

	[Address(RVA = "0x2F54B80", Offset = "0x2F53F80", Length = "0xC")]
	[Token(Token = "0x6000117")]
	private BuildFlags ConvertFlagsToGpuBuild(BuildFlags flags) { }

	[Address(RVA = "0x2F54B90", Offset = "0x2F53F90", Length = "0x25F")]
	[Token(Token = "0x600011B")]
	private static Matrix4x4 ConvertTranform(Transform input) { }

	[Address(RVA = "0x2F54DF0", Offset = "0x2F541F0", Length = "0x126")]
	[Token(Token = "0x600011A")]
	private static Transform ConvertTranform(Matrix4x4 input) { }

	[Address(RVA = "0x2F54F20", Offset = "0x2F54320", Length = "0x40")]
	[Token(Token = "0x6000114")]
	private void CreateBvh(CommandBuffer cmd, GraphicsBuffer scratchBuffer) { }

	[Address(RVA = "0x2F54F60", Offset = "0x2F54360", Length = "0x111")]
	[Token(Token = "0x6000112")]
	private void DeleteMeshBlas(ValueTuple<Int32, Int32> geomKey, MeshBlas blas) { }

	[Address(RVA = "0x2F55080", Offset = "0x2F54480", Length = "0x278")]
	[Token(Token = "0x6000104")]
	public override void Dispose() { }

	[Address(RVA = "0x2F55300", Offset = "0x2F54700", Length = "0x8F")]
	[Token(Token = "0x600010D")]
	private void FreeTopLevelAccelStruct() { }

	[Address(RVA = "0x2F564A0", Offset = "0x2F558A0", Length = "0x4F")]
	[Token(Token = "0x6000102")]
	internal GraphicsBuffer get_bottomLevelBvhBuffer() { }

	[Address(RVA = "0x2F564F0", Offset = "0x2F558F0", Length = "0x4F")]
	[Token(Token = "0x6000103")]
	internal GraphicsBuffer get_instanceInfoBuffer() { }

	[Address(RVA = "0x2F56540", Offset = "0x2F55940", Length = "0x4F")]
	[Token(Token = "0x6000101")]
	internal GraphicsBuffer get_topLevelBvhBuffer() { }

	[Address(RVA = "0x2F55390", Offset = "0x2F54790", Length = "0x14")]
	[Token(Token = "0x600010C")]
	public override ulong GetBuildScratchBufferRequiredSizeInBytes() { }

	[Address(RVA = "0x2F553B0", Offset = "0x2F547B0", Length = "0x2CC")]
	[Token(Token = "0x6000113")]
	private ulong GetBvhBuildScratchBufferSizeInDwords() { }

	[Address(RVA = "0x2F55680", Offset = "0x2F54A80", Length = "0xBA")]
	[Token(Token = "0x600011C")]
	private static int3 GetFaceIndices(List<Int32> indices, int triangleIdx) { }

	[Address(RVA = "0x2F55740", Offset = "0x2F54B40", Length = "0x175")]
	[Token(Token = "0x600010E")]
	private MeshBlas GetOrAllocateMeshBlas(Mesh mesh, int subMeshIndex) { }

	[Address(RVA = "0x2F558C0", Offset = "0x2F54CC0", Length = "0x149")]
	[Token(Token = "0x600011D")]
	private static Triangle GetTriangle(List<Vector3> vertices, int3 idx) { }

	[Address(RVA = "0x2F55A10", Offset = "0x2F54E10", Length = "0x1F")]
	[Token(Token = "0x6000110")]
	private GraphicsBuffer LoadIndexBuffer(Mesh mesh) { }

	[Address(RVA = "0x2F55A30", Offset = "0x2F54E30", Length = "0x8A")]
	[Token(Token = "0x6000111")]
	private GraphicsBuffer LoadPositionBuffer(Mesh mesh, out int stride, out int offset) { }

	[Address(RVA = "0x2F55AC0", Offset = "0x2F54EC0", Length = "0x92")]
	[Token(Token = "0x6000120")]
	private int NewHandle() { }

	[Address(RVA = "0x2F55B60", Offset = "0x2F54F60", Length = "0x57")]
	[Token(Token = "0x6000121")]
	private void ReleaseHandle(int handle) { }

	[Address(RVA = "0x2F55BC0", Offset = "0x2F54FC0", Length = "0x1DD")]
	[Token(Token = "0x6000106")]
	public override void RemoveInstance(int instanceHandle) { }

	[Address(RVA = "0x2F55DA0", Offset = "0x2F551A0", Length = "0x73")]
	[Token(Token = "0x6000109")]
	public override void UpdateInstanceID(int instanceHandle, uint instanceID) { }

	[Address(RVA = "0x2F55E20", Offset = "0x2F55220", Length = "0x73")]
	[Token(Token = "0x600010A")]
	public override void UpdateInstanceMask(int instanceHandle, uint mask) { }

	[Address(RVA = "0x2F55EA0", Offset = "0x2F552A0", Length = "0xCE")]
	[Token(Token = "0x6000108")]
	public override void UpdateInstanceTransform(int instanceHandle, Matrix4x4 localToWorldMatrix) { }

}

