namespace UnityEngine.Rendering;

[Token(Token = "0x200006C")]
internal struct GPUInstanceDataBufferUploader : IDisposable
{
	[Token(Token = "0x200006E")]
	internal struct GPUResources : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E8")]
		public ComputeBuffer instanceData; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001E9")]
		public ComputeBuffer instanceIndices; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001EA")]
		public ComputeBuffer inputComponentOffsets; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001EB")]
		public ComputeBuffer validComponentIndices; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001EC")]
		public ComputeShader cs; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001ED")]
		public int kernelId; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40001EE")]
		private int m_InstanceDataByteSize; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001EF")]
		private int m_InstanceCount; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40001F0")]
		private int m_ComponentCounts; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001F1")]
		private int m_ValidComponentIndicesCount; //Field offset: 0x38

		[Address(RVA = "0x2CE2340", Offset = "0x2CE1740", Length = "0x1D5")]
		[Token(Token = "0x60001E0")]
		public void CreateResources(int newInstanceCount, int sizePerInstance, int newComponentCounts, int validComponentIndicesCount) { }

		[Address(RVA = "0x2CE2520", Offset = "0x2CE1920", Length = "0x6D")]
		[Token(Token = "0x60001E1")]
		public override void Dispose() { }

		[Address(RVA = "0x2CE2640", Offset = "0x2CE1A40", Length = "0xAD")]
		[Token(Token = "0x60001DF")]
		public void LoadShaders(GPUResidentDrawerResources resources) { }

	}

	[Token(Token = "0x200006D")]
	private static class UploadKernelIDs
	{
		[Token(Token = "0x40001DD")]
		public static readonly int _InputValidComponentCounts; //Field offset: 0x0
		[Token(Token = "0x40001DE")]
		public static readonly int _InputInstanceCounts; //Field offset: 0x4
		[Token(Token = "0x40001DF")]
		public static readonly int _InputInstanceByteSize; //Field offset: 0x8
		[Token(Token = "0x40001E0")]
		public static readonly int _InputComponentOffsets; //Field offset: 0xC
		[Token(Token = "0x40001E1")]
		public static readonly int _InputInstanceData; //Field offset: 0x10
		[Token(Token = "0x40001E2")]
		public static readonly int _InputInstanceIndices; //Field offset: 0x14
		[Token(Token = "0x40001E3")]
		public static readonly int _InputValidComponentIndices; //Field offset: 0x18
		[Token(Token = "0x40001E4")]
		public static readonly int _InputComponentAddresses; //Field offset: 0x1C
		[Token(Token = "0x40001E5")]
		public static readonly int _InputComponentByteCounts; //Field offset: 0x20
		[Token(Token = "0x40001E6")]
		public static readonly int _InputComponentInstanceIndexRanges; //Field offset: 0x24
		[Token(Token = "0x40001E7")]
		public static readonly int _OutputBuffer; //Field offset: 0x28

		[Address(RVA = "0x2CF0DB0", Offset = "0x2CF01B0", Length = "0x201")]
		[Token(Token = "0x60001DE")]
		private static UploadKernelIDs() { }

	}

	[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
	[Token(Token = "0x200006F")]
	public struct WriteInstanceDataParameterJob : IJobParallelFor
	{
		[Token(Token = "0x40001F2")]
		public const int k_BatchSize = 512; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x40001F3")]
		public bool gatherData; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[ReadOnly]
		[Token(Token = "0x40001F4")]
		public int parameterIndex; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x40001F5")]
		public int uintPerParameter; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[ReadOnly]
		[Token(Token = "0x40001F6")]
		public int uintPerInstance; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x40001F7")]
		public NativeArray<Int32> componentDataIndex; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		[Token(Token = "0x40001F8")]
		public NativeArray<Int32> gatherIndices; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[ReadOnly]
		[Token(Token = "0x40001F9")]
		public NativeArray<UInt32> instanceData; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[NativeDisableContainerSafetyRestriction]
		[NoAlias]
		[Token(Token = "0x40001FA")]
		[WriteOnly]
		public NativeArray<UInt32> tmpDataBuffer; //Field offset: 0x40

		[Address(RVA = "0x2CF0FC0", Offset = "0x2CF03C0", Length = "0x1022")]
		[Token(Token = "0x60001E2")]
		public override void Execute(int index) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D4")]
	private int m_UintPerInstance; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40001D5")]
	private int m_Capacity; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001D6")]
	private int m_InstanceCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D7")]
	private NativeArray<Boolean> m_ComponentIsInstanced; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D8")]
	private NativeArray<Int32> m_ComponentDataIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001D9")]
	private NativeArray<Int32> m_DescriptionsUintSize; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001DA")]
	private NativeArray<UInt32> m_TmpDataBuffer; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001DB")]
	private NativeList<Int32> m_WritenComponentIndices; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001DC")]
	private NativeArray<Int32> m_DummyArray; //Field offset: 0x58

	[Address(RVA = "0x2CE1750", Offset = "0x2CE0B50", Length = "0x2C7")]
	[Token(Token = "0x60001D3")]
	public GPUInstanceDataBufferUploader(in NativeArray<GPUInstanceComponentDesc>& descriptions, int capacity, InstanceType instanceType) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x60001D8")]
	public void AllocateUploadHandles(int handlesLength) { }

	[Address(RVA = "0x2CE0E90", Offset = "0x2CE0290", Length = "0x10E")]
	[Token(Token = "0x60001DD")]
	public override void Dispose() { }

	[Address(RVA = "0x2CE0FA0", Offset = "0x2CE03A0", Length = "0xB")]
	[Token(Token = "0x60001D6")]
	public int GetParamUIntOffset(int parameterIndex) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60001D5")]
	public int GetUIntPerInstance() { }

	[Address(RVA = "0x2CE0FB0", Offset = "0x2CE03B0", Length = "0x45")]
	[Token(Token = "0x60001D4")]
	public IntPtr GetUploadBufferPtr() { }

	[Address(RVA = "0x812050", Offset = "0x811450", Length = "0x95")]
	[Token(Token = "0x60001D7")]
	public int PrepareParamWrite(int parameterIndex) { }

	[Address(RVA = "0x2CE1000", Offset = "0x2CE0400", Length = "0x585")]
	[Token(Token = "0x60001DB")]
	public void SubmitToGpu(GPUInstanceDataBuffer instanceDataBuffer, NativeArray<GPUInstanceIndex> gpuInstanceIndices, ref GPUResources gpuResources, bool submitOnlyWrittenParams) { }

	[Address(RVA = "0x2CE1590", Offset = "0x2CE0990", Length = "0x1BC")]
	[Token(Token = "0x60001DC")]
	public void SubmitToGpu(GPUInstanceDataBuffer instanceDataBuffer, NativeArray<InstanceHandle> instances, ref GPUResources gpuResources, bool submitOnlyWrittenParams) { }

	[Address(RVA = "0x8122E0", Offset = "0x8116E0", Length = "0xA0")]
	[Token(Token = "0x60001D9")]
	public JobHandle WriteInstanceDataJob(int parameterIndex, NativeArray<T> instanceData) { }

	[Address(RVA = "0x812380", Offset = "0x811780", Length = "0x1B3")]
	[Token(Token = "0x60001DA")]
	public JobHandle WriteInstanceDataJob(int parameterIndex, NativeArray<T> instanceData, NativeArray<Int32> gatherIndices) { }

}

