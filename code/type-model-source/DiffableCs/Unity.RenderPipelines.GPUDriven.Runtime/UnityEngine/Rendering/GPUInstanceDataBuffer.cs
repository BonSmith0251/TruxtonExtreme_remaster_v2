namespace UnityEngine.Rendering;

[Token(Token = "0x2000068")]
internal class GPUInstanceDataBuffer : IDisposable
{
	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x200006A")]
	private struct ConvertCPUInstancesToGPUInstancesJob : IJobParallelFor
	{
		[Token(Token = "0x40001CF")]
		public const int k_BatchSize = 512; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40001D0")]
		public NativeArray<Int32> instancesNumPrefixSum; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x40001D1")]
		public NativeArray<InstanceHandle> instances; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001D2")]
		[WriteOnly]
		public NativeArray<GPUInstanceIndex> gpuInstanceIndices; //Field offset: 0x20

		[Address(RVA = "0x2CDEA40", Offset = "0x2CDDE40", Length = "0x31")]
		[Token(Token = "0x60001CD")]
		public override void Execute(int index) { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000069")]
	public struct ReadOnly
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001CE")]
		private readonly NativeArray<Int32> instancesNumPrefixSum; //Field offset: 0x0

		[Address(RVA = "0x2CEE900", Offset = "0x2CEDD00", Length = "0x1A")]
		[Token(Token = "0x60001CA")]
		public ReadOnly(GPUInstanceDataBuffer buffer) { }

		[Address(RVA = "0x2CED610", Offset = "0x2CECA10", Length = "0xCD")]
		[Token(Token = "0x60001CC")]
		public void CPUInstanceArrayToGPUInstanceArray(NativeArray<InstanceHandle> instances, NativeArray<GPUInstanceIndex> gpuInstanceIndices) { }

		[Address(RVA = "0x2CED6E0", Offset = "0x2CECAE0", Length = "0x8")]
		[Token(Token = "0x60001CB")]
		public GPUInstanceIndex CPUInstanceToGPUInstance(InstanceHandle instance) { }

	}

	[Token(Token = "0x40001BD")]
	private static int s_NextLayoutVersion; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BE")]
	public InstanceNumInfo instanceNumInfo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001BF")]
	public NativeArray<Int32> instancesNumPrefixSum; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C0")]
	public NativeArray<Int32> instancesSpan; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001C1")]
	public int byteSize; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40001C2")]
	public int perInstanceComponentCount; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001C3")]
	public int version; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40001C4")]
	public int layoutVersion; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001C5")]
	public GraphicsBuffer gpuBuffer; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001C6")]
	public GraphicsBuffer validComponentsIndicesGpuBuffer; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001C7")]
	public GraphicsBuffer componentAddressesGpuBuffer; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001C8")]
	public GraphicsBuffer componentInstanceIndexRangesGpuBuffer; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001C9")]
	public GraphicsBuffer componentByteCountsGpuBuffer; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001CA")]
	public NativeArray<GPUInstanceComponentDesc> descriptions; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001CB")]
	public NativeArray<MetadataValue> defaultMetadata; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40001CC")]
	public NativeArray<Int32> gpuBufferComponentAddress; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40001CD")]
	public NativeParallelHashMap<Int32, Int32> nameToMetadataMap; //Field offset: 0xA0

	[Token(Token = "0x1700002F")]
	public bool valid
	{
		[Address(RVA = "0x2CE2160", Offset = "0x2CE1560", Length = "0x33")]
		[Token(Token = "0x60001BF")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60001C9")]
	public GPUInstanceDataBuffer() { }

	[Address(RVA = "0x2CE1A20", Offset = "0x2CE0E20", Length = "0x23")]
	[Token(Token = "0x60001C8")]
	public ReadOnly AsReadOnly() { }

	[Address(RVA = "0x2CE1A50", Offset = "0x2CE0E50", Length = "0xCE")]
	[Token(Token = "0x60001C6")]
	public void CPUInstanceArrayToGPUInstanceArray(NativeArray<InstanceHandle> instances, NativeArray<GPUInstanceIndex> gpuInstanceIndices) { }

	[Address(RVA = "0x2CE1B20", Offset = "0x2CE0F20", Length = "0x1AF")]
	[Token(Token = "0x60001C0")]
	private static GPUInstanceIndex CPUInstanceToGPUInstance(in NativeArray<Int32>& instancesNumPrefixSum, InstanceHandle instance) { }

	[Address(RVA = "0x2CE1CD0", Offset = "0x2CE10D0", Length = "0xC")]
	[Token(Token = "0x60001C4")]
	public GPUInstanceIndex CPUInstanceToGPUInstance(InstanceHandle instance) { }

	[Address(RVA = "0x2CE1CE0", Offset = "0x2CE10E0", Length = "0x187")]
	[Token(Token = "0x60001C7")]
	public override void Dispose() { }

	[Address(RVA = "0x2CE2160", Offset = "0x2CE1560", Length = "0x33")]
	[Token(Token = "0x60001BF")]
	public bool get_valid() { }

	[Address(RVA = "0x2CE1F80", Offset = "0x2CE1380", Length = "0x95")]
	[Token(Token = "0x60001C2")]
	public int GetGpuAddress(string strName, bool assertOnFail = true) { }

	[Address(RVA = "0x2CE2020", Offset = "0x2CE1420", Length = "0x88")]
	[Token(Token = "0x60001C3")]
	public int GetGpuAddress(int propertyID, bool assertOnFail = true) { }

	[Address(RVA = "0x2CE20B0", Offset = "0x2CE14B0", Length = "0x68")]
	[Token(Token = "0x60001C1")]
	public int GetPropertyIndex(int propertyID, bool assertOnFail = true) { }

	[Address(RVA = "0x2CE1E70", Offset = "0x2CE1270", Length = "0x10E")]
	[Token(Token = "0x60001C5")]
	public InstanceHandle GPUInstanceToCPUInstance(GPUInstanceIndex gpuInstanceIndex) { }

	[Address(RVA = "0x2CE2120", Offset = "0x2CE1520", Length = "0x40")]
	[Token(Token = "0x60001BE")]
	public static int NextVersion() { }

}

