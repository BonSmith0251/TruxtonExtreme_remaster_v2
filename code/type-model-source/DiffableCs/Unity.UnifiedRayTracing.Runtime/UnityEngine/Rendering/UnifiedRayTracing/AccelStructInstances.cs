namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000028")]
internal sealed class AccelStructInstances : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x200002B")]
	private sealed class <>c
	{
		[Token(Token = "0x400010A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400010B")]
		public static Func<RTInstance, RTInstance> <>9__22_0; //Field offset: 0x8

		[Address(RVA = "0x2F61B80", Offset = "0x2F60F80", Length = "0x67")]
		[Token(Token = "0x6000085")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000086")]
		public <>c() { }

		[Address(RVA = "0x2F61A50", Offset = "0x2F60E50", Length = "0xB3")]
		[Token(Token = "0x6000087")]
		internal RTInstance <NextFrame>b__22_0(RTInstance instance) { }

	}

	[Token(Token = "0x200002A")]
	internal class InstanceEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000105")]
		public GeometryPoolHandle geometryPoolHandle; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000106")]
		public Allocation indexInInstanceBuffer; //Field offset: 0x14
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000107")]
		public uint instanceMask; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000108")]
		public uint vertexOffset; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000109")]
		public uint indexOffset; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000084")]
		public InstanceEntry() { }

	}

	[Token(Token = "0x2000029")]
	internal struct RTInstance
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000FE")]
		public float4x4 localToWorld; //Field offset: 0x0
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000FF")]
		public float4x4 previousLocalToWorld; //Field offset: 0x40
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000100")]
		public float4x4 localToWorldNormals; //Field offset: 0x80
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000101")]
		public uint renderingLayerMask; //Field offset: 0xC0
		[FieldOffset(Offset = "0xC4")]
		[Token(Token = "0x4000102")]
		public uint instanceMask; //Field offset: 0xC4
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4000103")]
		public uint userMaterialID; //Field offset: 0xC8
		[FieldOffset(Offset = "0xCC")]
		[Token(Token = "0x4000104")]
		public uint geometryIndex; //Field offset: 0xCC

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000F9")]
	private readonly GeometryPool m_GeometryPool; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000FA")]
	private readonly PersistentGpuArray<RTInstance> m_InstanceBuffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000FB")]
	private readonly Dictionary<Int32, InstanceEntry> m_Instances; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000FC")]
	private uint m_FrameTimestamp; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000FD")]
	private uint m_TransformTouchedLastTimestamp; //Field offset: 0x2C

	[Token(Token = "0x17000005")]
	public GeometryPool geometryPool
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000072")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000006")]
	public GraphicsBuffer indexBuffer
	{
		[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
		[Token(Token = "0x6000077")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000003")]
	public PersistentGpuArray<RTInstance> instanceBuffer
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000070")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000008")]
	public bool instanceListValid
	{
		[Address(RVA = "0x20B1050", Offset = "0x20B0450", Length = "0x9")]
		[Token(Token = "0x6000080")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000004")]
	public IReadOnlyCollection<InstanceEntry> instances
	{
		[Address(RVA = "0x2F4F790", Offset = "0x2F4EB90", Length = "0x44")]
		[Token(Token = "0x6000071")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000007")]
	public GraphicsBuffer vertexBuffer
	{
		[Address(RVA = "0x1EF1FB0", Offset = "0x1EF13B0", Length = "0x1B")]
		[Token(Token = "0x6000078")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x2F4F6B0", Offset = "0x2F4EAB0", Length = "0xDF")]
	[Token(Token = "0x600006E")]
	internal AccelStructInstances(GeometryPool geometryPool) { }

	[Address(RVA = "0x2F4DAB0", Offset = "0x2F4CEB0", Length = "0xBD")]
	[Token(Token = "0x6000073")]
	public int AddInstance(MeshInstanceDesc meshInstance, uint materialID, uint renderingLayerMask) { }

	[Address(RVA = "0x2F4DB70", Offset = "0x2F4CF70", Length = "0x44D")]
	[Token(Token = "0x6000075")]
	private void AddInstance(Allocation slotAllocation, in MeshInstanceDesc meshInstance, uint materialID, uint renderingLayerMask) { }

	[Address(RVA = "0x2F4DFC0", Offset = "0x2F4D3C0", Length = "0x15E")]
	[Token(Token = "0x6000074")]
	public int AddInstances(Span<MeshInstanceDesc> meshInstances, Span<UInt32> materialIDs, Span<UInt32> renderingLayerMask) { }

	[Address(RVA = "0x2F4E120", Offset = "0x2F4D520", Length = "0x2BE")]
	[Token(Token = "0x6000081")]
	public void Bind(CommandBuffer cmd, IRayTracingShader shader) { }

	[Address(RVA = "0x2F4E3E0", Offset = "0x2F4D7E0", Length = "0x229")]
	[Token(Token = "0x600007A")]
	public void ClearInstances() { }

	[Address(RVA = "0x2F4E610", Offset = "0x2F4DA10", Length = "0x214")]
	[Token(Token = "0x600006F")]
	public override void Dispose() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000072")]
	public GeometryPool get_geometryPool() { }

	[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
	[Token(Token = "0x6000077")]
	public GraphicsBuffer get_indexBuffer() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000070")]
	public PersistentGpuArray<RTInstance> get_instanceBuffer() { }

	[Address(RVA = "0x20B1050", Offset = "0x20B0450", Length = "0x9")]
	[Token(Token = "0x6000080")]
	public bool get_instanceListValid() { }

	[Address(RVA = "0x2F4F790", Offset = "0x2F4EB90", Length = "0x44")]
	[Token(Token = "0x6000071")]
	public IReadOnlyCollection<InstanceEntry> get_instances() { }

	[Address(RVA = "0x1EF1FB0", Offset = "0x1EF13B0", Length = "0x1B")]
	[Token(Token = "0x6000078")]
	public GraphicsBuffer get_vertexBuffer() { }

	[Address(RVA = "0x2F4E830", Offset = "0x2F4DC30", Length = "0x66")]
	[Token(Token = "0x6000076")]
	public MeshChunk GetEntryGeomAllocation(GeometryPoolHandle handle, int submeshIndex) { }

	[Address(RVA = "0x2F4E8A0", Offset = "0x2F4DCA0", Length = "0x44")]
	[Token(Token = "0x6000082")]
	public int GetInstanceCount() { }

	[Address(RVA = "0x2F4E8F0", Offset = "0x2F4DCF0", Length = "0x139")]
	[Token(Token = "0x600007F")]
	public void NextFrame() { }

	[Address(RVA = "0x2F4EA30", Offset = "0x2F4DE30", Length = "0x16A")]
	[Token(Token = "0x6000083")]
	private static float4x4 NormalMatrix(float4x4 m) { }

	[Address(RVA = "0x2F4EBA0", Offset = "0x2F4DFA0", Length = "0xF7")]
	[Token(Token = "0x6000079")]
	public void RemoveInstance(int instanceHandle) { }

	[Address(RVA = "0x2F4ECA0", Offset = "0x2F4E0A0", Length = "0x251")]
	[Token(Token = "0x600007E")]
	public void UpdateInstanceMask(int instanceHandle, uint mask) { }

	[Address(RVA = "0x2F4EF00", Offset = "0x2F4E300", Length = "0x23D")]
	[Token(Token = "0x600007C")]
	public void UpdateInstanceMaterialID(int instanceHandle, uint materialID) { }

	[Address(RVA = "0x2F4F140", Offset = "0x2F4E540", Length = "0x325")]
	[Token(Token = "0x600007B")]
	public void UpdateInstanceTransform(int instanceHandle, Matrix4x4 localToWorldMatrix) { }

	[Address(RVA = "0x2F4F470", Offset = "0x2F4E870", Length = "0x23D")]
	[Token(Token = "0x600007D")]
	public void UpdateRenderingLayerMask(int instanceHandle, uint renderingLayerMask) { }

}

