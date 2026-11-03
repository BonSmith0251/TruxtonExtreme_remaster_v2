namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000031")]
internal sealed class GeometryPool : IDisposable
{
	[Token(Token = "0x2000034")]
	internal struct GeometrySlot
	{
		[Token(Token = "0x4000156")]
		public static readonly GeometrySlot Invalid; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000151")]
		public uint refCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000152")]
		public uint hash; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000153")]
		public Allocation meshChunkTableAlloc; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000154")]
		public NativeArray<MeshChunk> meshChunks; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000155")]
		public bool hasGPUData; //Field offset: 0x28

		[Token(Token = "0x17000012")]
		public bool valid
		{
			[Address(RVA = "0x2F5B100", Offset = "0x2F5A500", Length = "0x47")]
			[Token(Token = "0x60000B9")]
			 get { } //Length: 71
		}

		[Address(RVA = "0x2F5B050", Offset = "0x2F5A450", Length = "0xA5")]
		[Token(Token = "0x60000BA")]
		private static GeometrySlot() { }

		[Address(RVA = "0x2F5B100", Offset = "0x2F5A500", Length = "0x47")]
		[Token(Token = "0x60000B9")]
		public bool get_valid() { }

	}

	[Token(Token = "0x2000035")]
	private struct GeoPoolEntrySlot
	{
		[Token(Token = "0x400015A")]
		public static readonly GeoPoolEntrySlot Invalid; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000157")]
		public uint refCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000158")]
		public uint hash; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000159")]
		public int geoSlotHandle; //Field offset: 0x8

		[Token(Token = "0x17000013")]
		public bool valid
		{
			[Address(RVA = "0x2F56CE0", Offset = "0x2F560E0", Length = "0x8")]
			[Token(Token = "0x60000BB")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x2F56C90", Offset = "0x2F56090", Length = "0x4B")]
		[Token(Token = "0x60000BC")]
		private static GeoPoolEntrySlot() { }

		[Address(RVA = "0x2F56CE0", Offset = "0x2F560E0", Length = "0x8")]
		[Token(Token = "0x60000BB")]
		public bool get_valid() { }

	}

	[Token(Token = "0x2000032")]
	private static class GeoPoolShaderIDs
	{
		[Token(Token = "0x4000135")]
		public static readonly int _InputIBBaseOffset; //Field offset: 0x0
		[Token(Token = "0x4000136")]
		public static readonly int _DispatchIndexOffset; //Field offset: 0x4
		[Token(Token = "0x4000137")]
		public static readonly int _InputIBCount; //Field offset: 0x8
		[Token(Token = "0x4000138")]
		public static readonly int _OutputIBOffset; //Field offset: 0xC
		[Token(Token = "0x4000139")]
		public static readonly int _InputFirstVertex; //Field offset: 0x10
		[Token(Token = "0x400013A")]
		public static readonly int _InputIndexBuffer; //Field offset: 0x14
		[Token(Token = "0x400013B")]
		public static readonly int _OutputIndexBuffer; //Field offset: 0x18
		[Token(Token = "0x400013C")]
		public static readonly int _InputVBCount; //Field offset: 0x1C
		[Token(Token = "0x400013D")]
		public static readonly int _InputBaseVertexOffset; //Field offset: 0x20
		[Token(Token = "0x400013E")]
		public static readonly int _DispatchVertexOffset; //Field offset: 0x24
		[Token(Token = "0x400013F")]
		public static readonly int _OutputVBSize; //Field offset: 0x28
		[Token(Token = "0x4000140")]
		public static readonly int _OutputVBOffset; //Field offset: 0x2C
		[Token(Token = "0x4000141")]
		public static readonly int _InputPosBufferStride; //Field offset: 0x30
		[Token(Token = "0x4000142")]
		public static readonly int _InputPosBufferOffset; //Field offset: 0x34
		[Token(Token = "0x4000143")]
		public static readonly int _InputUv0BufferStride; //Field offset: 0x38
		[Token(Token = "0x4000144")]
		public static readonly int _InputUv0BufferOffset; //Field offset: 0x3C
		[Token(Token = "0x4000145")]
		public static readonly int _InputUv1BufferStride; //Field offset: 0x40
		[Token(Token = "0x4000146")]
		public static readonly int _InputUv1BufferOffset; //Field offset: 0x44
		[Token(Token = "0x4000147")]
		public static readonly int _InputNormalBufferStride; //Field offset: 0x48
		[Token(Token = "0x4000148")]
		public static readonly int _InputNormalBufferOffset; //Field offset: 0x4C
		[Token(Token = "0x4000149")]
		public static readonly int _PosBuffer; //Field offset: 0x50
		[Token(Token = "0x400014A")]
		public static readonly int _Uv0Buffer; //Field offset: 0x54
		[Token(Token = "0x400014B")]
		public static readonly int _Uv1Buffer; //Field offset: 0x58
		[Token(Token = "0x400014C")]
		public static readonly int _NormalBuffer; //Field offset: 0x5C
		[Token(Token = "0x400014D")]
		public static readonly int _OutputVB; //Field offset: 0x60
		[Token(Token = "0x400014E")]
		public static readonly int _AttributesMask; //Field offset: 0x64

		[Address(RVA = "0x2F56CF0", Offset = "0x2F560F0", Length = "0x486")]
		[Token(Token = "0x60000B6")]
		private static GeoPoolShaderIDs() { }

	}

	[Token(Token = "0x2000033")]
	internal struct MeshChunk
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014F")]
		public Allocation vertexAlloc; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000150")]
		public Allocation indexAlloc; //Field offset: 0xC

		[Token(Token = "0x17000011")]
		public static MeshChunk Invalid
		{
			[Address(RVA = "0x2F5CFF0", Offset = "0x2F5C3F0", Length = "0x80")]
			[Token(Token = "0x60000B8")]
			 get { } //Length: 128
		}

		[Address(RVA = "0x2F5CFD0", Offset = "0x2F5C3D0", Length = "0x1B")]
		[Token(Token = "0x60000B7")]
		public GeoPoolMeshChunk EncodeGPUEntry() { }

		[Address(RVA = "0x2F5CFF0", Offset = "0x2F5C3F0", Length = "0x80")]
		[Token(Token = "0x60000B8")]
		public static MeshChunk get_Invalid() { }

	}

	[Token(Token = "0x2000036")]
	private struct VertexBufferAttribInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400015B")]
		public GraphicsBuffer buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400015C")]
		public int stride; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400015D")]
		public int offset; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400015E")]
		public int byteCount; //Field offset: 0x10

		[Token(Token = "0x17000014")]
		public bool valid
		{
			[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
			[Token(Token = "0x60000BD")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x2096430", Offset = "0x2095830", Length = "0x8")]
		[Token(Token = "0x60000BD")]
		public bool get_valid() { }

	}

	[Token(Token = "0x4000117")]
	private const int kMaxThreadGroupsPerDispatch = 65535; //Field offset: 0x0
	[Token(Token = "0x4000118")]
	private const int kThreadGroupSize = 256; //Field offset: 0x0
	[Token(Token = "0x4000119")]
	private const int InvalidHandle = -1; //Field offset: 0x0
	[Token(Token = "0x400011A")]
	private const Target VertexBufferTarget = 16; //Field offset: 0x0
	[Token(Token = "0x400011B")]
	private const Target IndexBufferTarget = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400011C")]
	private GraphicsBuffer m_GlobalIndexBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400011D")]
	private GraphicsBuffer m_GlobalVertexBuffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011E")]
	private GraphicsBuffer m_GlobalMeshChunkTableEntryBuffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400011F")]
	private readonly GraphicsBuffer m_DummyBuffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000120")]
	private int m_MaxVertCounts; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000121")]
	private int m_MaxIndexCounts; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000122")]
	private int m_MaxMeshChunkTableEntriesCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000123")]
	private BlockAllocator m_VertexAllocator; //Field offset: 0x40
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000124")]
	private BlockAllocator m_IndexAllocator; //Field offset: 0x60
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000125")]
	private BlockAllocator m_MeshChunkTableAllocator; //Field offset: 0x80
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000126")]
	private NativeParallelHashMap<UInt32, Int32> m_MeshHashToGeoSlot; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000127")]
	private List<GeometrySlot> m_GeoSlots; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000128")]
	private NativeList<Int32> m_FreeGeoSlots; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000129")]
	private NativeParallelHashMap<UInt32, GeometryPoolHandle> m_GeoPoolEntryHashToSlot; //Field offset: 0xC0
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400012A")]
	private NativeList<GeoPoolEntrySlot> m_GeoPoolEntrySlots; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400012B")]
	private NativeList<GeometryPoolHandle> m_FreeGeoPoolEntrySlots; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400012C")]
	private readonly List<GraphicsBuffer> m_InputBufferReferences; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400012D")]
	private readonly ComputeShader m_CopyShader; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400012E")]
	private ComputeShader m_GeometryPoolKernelsCS; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400012F")]
	private int m_KernelMainUpdateIndexBuffer16; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4000130")]
	private int m_KernelMainUpdateIndexBuffer32; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000131")]
	private int m_KernelMainUpdateVertexBuffer; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000132")]
	private readonly CommandBuffer m_CmdBuffer; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000133")]
	private bool m_MustClearCmdBuffer; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000134")]
	private int m_PendingCmds; //Field offset: 0x114

	[Token(Token = "0x1700000A")]
	public GraphicsBuffer globalIndexBuffer
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000092")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000D")]
	public GraphicsBuffer globalMeshChunkTableEntryBuffer
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000095")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000B")]
	public GraphicsBuffer globalVertexBuffer
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000093")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000C")]
	public int globalVertexBufferStrideBytes
	{
		[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
		[Token(Token = "0x6000094")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700000E")]
	public int indicesCount
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000096")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000010")]
	public int meshChunkTablesEntryCount
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000098")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000F")]
	public int verticesCount
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000097")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2F5AAD0", Offset = "0x2F59ED0", Length = "0x57F")]
	[Token(Token = "0x6000099")]
	public GeometryPool(in GeometryPoolDesc desc, ComputeShader geometryPoolShader, ComputeShader copyShader) { }

	[Address(RVA = "0x2F571E0", Offset = "0x2F565E0", Length = "0x2F3")]
	[Token(Token = "0x60000B4")]
	private void AddIndexUpdateCommand(CommandBuffer cmdBuffer, IndexFormat inputFormat, in GraphicsBuffer inputBuffer, in Allocation location, int firstVertex, int inputOffset, int indexCount, int outputOffset, GraphicsBuffer outputIdxBuffer) { }

	[Address(RVA = "0x2F574E0", Offset = "0x2F568E0", Length = "0x639")]
	[Token(Token = "0x60000B5")]
	private void AddVertexUpdateCommand(CommandBuffer cmdBuffer, int baseVertexOffset, in VertexBufferAttribInfo pos, in VertexBufferAttribInfo uv0, in VertexBufferAttribInfo uv1, in VertexBufferAttribInfo n, in Allocation location, GraphicsBuffer outputVertexBuffer) { }

	[Address(RVA = "0x2F57B20", Offset = "0x2F56F20", Length = "0x44")]
	[Token(Token = "0x60000B3")]
	private CommandBuffer AllocateCommandBuffer() { }

	[Address(RVA = "0x2F57B70", Offset = "0x2F56F70", Length = "0xA87")]
	[Token(Token = "0x60000A2")]
	private bool AllocateGeo(Mesh mesh, out int allocationHandle) { }

	[Address(RVA = "0x254C0A0", Offset = "0x254B4A0", Length = "0xD")]
	[Token(Token = "0x600009E")]
	private int CalcIndexCount(int bufferByteSize) { }

	[Address(RVA = "0x2F58600", Offset = "0x2F57A00", Length = "0x61")]
	[Token(Token = "0x600009F")]
	private int CalcMeshChunkTablesCount(int bufferByteSize) { }

	[Address(RVA = "0x2F58680", Offset = "0x2F57A80", Length = "0x19C")]
	[Token(Token = "0x60000AA")]
	private uint CalculateClusterHash(Mesh mesh, GeometryPoolSubmeshData[] submeshData) { }

	[Address(RVA = "0x2F58670", Offset = "0x2F57A70", Length = "0xD")]
	[Token(Token = "0x600009D")]
	private int CalcVertexCount(int bufferByteSize) { }

	[Address(RVA = "0x2F58C70", Offset = "0x2F58070", Length = "0x19F")]
	[Token(Token = "0x60000A0")]
	private void DeallocateGeometrySlot(ref GeometrySlot slot) { }

	[Address(RVA = "0x2F58B20", Offset = "0x2F57F20", Length = "0x141")]
	[Token(Token = "0x60000A1")]
	private void DeallocateGeometrySlot(int geoSlotHandle) { }

	[Address(RVA = "0x2F58820", Offset = "0x2F57C20", Length = "0x145")]
	[Token(Token = "0x60000A3")]
	private void DeallocateGeoPoolEntrySlot(GeometryPoolHandle handle) { }

	[Address(RVA = "0x2F58970", Offset = "0x2F57D70", Length = "0x1A6")]
	[Token(Token = "0x60000A4")]
	private void DeallocateGeoPoolEntrySlot(ref GeoPoolEntrySlot geoPoolEntrySlot) { }

	[Address(RVA = "0x2F58F90", Offset = "0x2F58390", Length = "0x34A")]
	[Token(Token = "0x600009B")]
	public override void Dispose() { }

	[Address(RVA = "0x2F58E10", Offset = "0x2F58210", Length = "0x176")]
	[Token(Token = "0x600009A")]
	private void DisposeInputBuffers() { }

	[Address(RVA = "0x2C12730", Offset = "0x2C11B30", Length = "0xD")]
	[Token(Token = "0x6000091")]
	private static int DivUp(int x, int y) { }

	[Address(RVA = "0x2F59330", Offset = "0x2F58730", Length = "0x47")]
	[Token(Token = "0x60000AC")]
	private static int FindSubmeshEntryInDesc(int submeshIndex, in GeometryPoolSubmeshData[] submeshData) { }

	[Address(RVA = "0x2F592E0", Offset = "0x2F586E0", Length = "0x4C")]
	[Token(Token = "0x60000A9")]
	private uint FNVHash(uint prevHash, uint dword) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000092")]
	public GraphicsBuffer get_globalIndexBuffer() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000095")]
	public GraphicsBuffer get_globalMeshChunkTableEntryBuffer() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000093")]
	public GraphicsBuffer get_globalVertexBuffer() { }

	[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
	[Token(Token = "0x6000094")]
	public int get_globalVertexBufferStrideBytes() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000096")]
	public int get_indicesCount() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000098")]
	public int get_meshChunkTablesEntryCount() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000097")]
	public int get_verticesCount() { }

	[Address(RVA = "0x2F59380", Offset = "0x2F58780", Length = "0xCA")]
	[Token(Token = "0x60000A6")]
	public GeometrySlot GetEntryGeomAllocation(GeometryPoolHandle handle) { }

	[Address(RVA = "0x2F59450", Offset = "0x2F58850", Length = "0x1F8")]
	[Token(Token = "0x60000A5")]
	public GeometryPoolEntryInfo GetEntryInfo(GeometryPoolHandle handle) { }

	[Address(RVA = "0x2F59650", Offset = "0x2F58A50", Length = "0x30")]
	[Token(Token = "0x6000090")]
	private int GetFormatByteCount(VertexAttributeFormat format) { }

	[Address(RVA = "0x2F596B0", Offset = "0x2F58AB0", Length = "0xDC")]
	[Token(Token = "0x60000AB")]
	public GeometryPoolHandle GetHandle(Mesh mesh) { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x600008E")]
	public static int GetIndexByteSize() { }

	[Address(RVA = "0x2F59790", Offset = "0x2F58B90", Length = "0x104")]
	[Token(Token = "0x60000A7")]
	public int GetInstanceGeometryIndex(Mesh mesh) { }

	[Address(RVA = "0x2F598A0", Offset = "0x2F58CA0", Length = "0x51")]
	[Token(Token = "0x600008F")]
	public static int GetMeshChunkTableEntryByteSize() { }

	[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
	[Token(Token = "0x600008D")]
	public static int GetVertexByteSize() { }

	[Address(RVA = "0x2F59900", Offset = "0x2F58D00", Length = "0x101")]
	[Token(Token = "0x60000B1")]
	private GraphicsBuffer LoadIndexBuffer(Mesh mesh) { }

	[Address(RVA = "0x2F59A10", Offset = "0x2F58E10", Length = "0xCD")]
	[Token(Token = "0x600009C")]
	private void LoadKernels(ComputeShader geometryPoolShader) { }

	[Address(RVA = "0x2F59AE0", Offset = "0x2F58EE0", Length = "0x194")]
	[Token(Token = "0x60000B2")]
	private void LoadVertexAttribInfo(Mesh mesh, VertexAttribute attribute, out VertexBufferAttribInfo output) { }

	[Address(RVA = "0x2F5A340", Offset = "0x2F59740", Length = "0x5B")]
	[Token(Token = "0x60000AD")]
	public bool Register(Mesh mesh, out GeometryPoolHandle outHandle) { }

	[Address(RVA = "0x2F59CB0", Offset = "0x2F590B0", Length = "0x68C")]
	[Token(Token = "0x60000AE")]
	public bool Register(in GeometryPoolEntryDesc entryDesc, out GeometryPoolHandle outHandle) { }

	[Address(RVA = "0x2F5A3A0", Offset = "0x2F597A0", Length = "0x7E")]
	[Token(Token = "0x60000B0")]
	public void SendGpuCommands() { }

	[Address(RVA = "0x2F5A420", Offset = "0x2F59820", Length = "0x17C")]
	[Token(Token = "0x60000AF")]
	public void Unregister(GeometryPoolHandle handle) { }

	[Address(RVA = "0x2F5A5A0", Offset = "0x2F599A0", Length = "0x521")]
	[Token(Token = "0x60000A8")]
	private void UpdateGeoGpuState(Mesh mesh, GeometryPoolHandle handle) { }

}

