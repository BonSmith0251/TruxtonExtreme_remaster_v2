namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000024")]
internal sealed class AccelStructAdapter : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000026")]
	private sealed class <>c
	{
		[Token(Token = "0x40000F0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000F1")]
		public static Converter<InstanceIDs, Int32> <>9__26_0; //Field offset: 0x8

		[Address(RVA = "0x2F61B10", Offset = "0x2F60F10", Length = "0x67")]
		[Token(Token = "0x600006A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600006B")]
		public <>c() { }

		[Address(RVA = "0xF59E80", Offset = "0xF59280", Length = "0x3")]
		[Token(Token = "0x600006C")]
		internal int <GetInstanceIDs>b__26_0(InstanceIDs item) { }

	}

	[Token(Token = "0x2000025")]
	private struct InstanceIDs
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EE")]
		public int InstanceID; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000EF")]
		public int AccelStructID; //Field offset: 0x4

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000EB")]
	private IRayTracingAccelStruct _accelStruct; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000EC")]
	private AccelStructInstances _instances; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000ED")]
	private readonly Dictionary<Int32, InstanceIDs[]> _objectHandleToInstances; //Field offset: 0x20

	[Token(Token = "0x17000002")]
	public GeometryPool GeometryPool
	{
		[Address(RVA = "0x21B18E0", Offset = "0x21B0CE0", Length = "0x1B")]
		[Token(Token = "0x6000059")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000001")]
	internal AccelStructInstances Instances
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000055")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2F4D920", Offset = "0x2F4CD20", Length = "0x187")]
	[Token(Token = "0x6000056")]
	public AccelStructAdapter(IRayTracingAccelStruct accelStruct, GeometryPool geometryPool) { }

	[Address(RVA = "0x2F4D700", Offset = "0x2F4CB00", Length = "0x212")]
	[Token(Token = "0x6000057")]
	public AccelStructAdapter(IRayTracingAccelStruct accelStruct, RayTracingResources resources) { }

	[Address(RVA = "0x2F4AD50", Offset = "0x2F4A150", Length = "0x462")]
	[Token(Token = "0x600005F")]
	private void AddHeightmap(TerrainDesc terrainDesc, ref List<InstanceIDs>& instanceHandles) { }

	[Address(RVA = "0x2F4B870", Offset = "0x2F4AC70", Length = "0x3D3")]
	[Token(Token = "0x600005C")]
	public void AddInstance(int objectHandle, Component meshRendererOrTerrain, Span<UInt32> perSubMeshMask, Span<UInt32> perSubMeshMaterialIDs, Span<Boolean> perSubMeshIsOpaque, uint renderingLayerMask) { }

	[Address(RVA = "0x2F4B340", Offset = "0x2F4A740", Length = "0x3E4")]
	[Token(Token = "0x600005D")]
	public void AddInstance(int objectHandle, Mesh mesh, Matrix4x4 localToWorldMatrix, Span<UInt32> perSubMeshMask, Span<UInt32> perSubMeshMaterialIDs, Span<Boolean> perSubMeshIsOpaque, uint renderingLayerMask) { }

	[Address(RVA = "0x2F4B1C0", Offset = "0x2F4A5C0", Length = "0x176")]
	[Token(Token = "0x600005E")]
	private void AddInstance(int objectHandle, TerrainDesc terrainDesc) { }

	[Address(RVA = "0x2F4B730", Offset = "0x2F4AB30", Length = "0x132")]
	[Token(Token = "0x6000061")]
	private InstanceIDs AddInstance(MeshInstanceDesc instanceDesc, uint materialID, uint renderingLayerMask) { }

	[Address(RVA = "0x2F4BC50", Offset = "0x2F4B050", Length = "0x6E5")]
	[Token(Token = "0x6000060")]
	private void AddTrees(TerrainDesc terrainDesc, ref List<InstanceIDs>& instanceHandles) { }

	[Address(RVA = "0x2F4C340", Offset = "0x2F4B740", Length = "0xFD")]
	[Token(Token = "0x600005A")]
	public void Bind(CommandBuffer cmd, string propertyName, IRayTracingShader shader) { }

	[Address(RVA = "0x2F4C440", Offset = "0x2F4B840", Length = "0xDE")]
	[Token(Token = "0x6000067")]
	public void Build(CommandBuffer cmd, ref GraphicsBuffer scratchBuffer) { }

	[Address(RVA = "0x2F4C520", Offset = "0x2F4B920", Length = "0x9D")]
	[Token(Token = "0x600005B")]
	public override void Dispose() { }

	[Address(RVA = "0x21B18E0", Offset = "0x21B0CE0", Length = "0x1B")]
	[Token(Token = "0x6000059")]
	public GeometryPool get_GeometryPool() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000055")]
	internal AccelStructInstances get_Instances() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000058")]
	public IRayTracingAccelStruct GetAccelerationStructure() { }

	[Address(RVA = "0x2F4C5C0", Offset = "0x2F4B9C0", Length = "0x183")]
	[Token(Token = "0x6000069")]
	public bool GetInstanceIDs(int rendererID, out Int32[] instanceIDs) { }

	[Address(RVA = "0x2F4C750", Offset = "0x2F4BB50", Length = "0x142")]
	[Token(Token = "0x6000068")]
	public void NextFrame() { }

	[Address(RVA = "0x2F4C8A0", Offset = "0x2F4BCA0", Length = "0x2B1")]
	[Token(Token = "0x6000062")]
	public void RemoveInstance(int objectHandle) { }

	[Address(RVA = "0x2F4CB60", Offset = "0x2F4BF60", Length = "0x1A2")]
	[Token(Token = "0x6000065")]
	public void UpdateInstanceMask(int objectHandle, Span<UInt32> perSubMeshMask) { }

	[Address(RVA = "0x2F4CD10", Offset = "0x2F4C110", Length = "0x1F6")]
	[Token(Token = "0x6000066")]
	public void UpdateInstanceMask(int objectHandle, uint mask) { }

	[Address(RVA = "0x2F4CF10", Offset = "0x2F4C310", Length = "0x346")]
	[Token(Token = "0x6000064")]
	public void UpdateInstanceMaterialIDs(int objectHandle, Span<UInt32> perSubMeshMaterialIDs) { }

	[Address(RVA = "0x2F4D260", Offset = "0x2F4C660", Length = "0x495")]
	[Token(Token = "0x6000063")]
	public void UpdateInstanceTransform(int objectHandle, Matrix4x4 localToWorldMatrix) { }

}

