namespace UnityEngine.Rendering;

[Token(Token = "0x2000060")]
internal class CPUDrawInstanceData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A3")]
	private NativeParallelHashMap<RangeKey, Int32> m_RangeHash; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A4")]
	private NativeList<DrawRange> m_DrawRanges; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001A5")]
	private NativeParallelHashMap<DrawKey, Int32> m_BatchHash; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001A6")]
	private NativeList<DrawBatch> m_DrawBatches; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001A7")]
	private NativeList<DrawInstance> m_DrawInstances; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001A8")]
	private NativeList<Int32> m_DrawInstanceIndices; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001A9")]
	private NativeList<Int32> m_DrawBatchIndices; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001AA")]
	private bool m_NeedsRebuild; //Field offset: 0x58

	[Token(Token = "0x17000025")]
	public NativeParallelHashMap<DrawKey, Int32> batchHash
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[Token(Token = "0x600017F")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000026")]
	public NativeList<DrawBatch> drawBatches
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000180")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000029")]
	public NativeArray<Int32> drawBatchIndices
	{
		[Address(RVA = "0x2CDA8B0", Offset = "0x2CD9CB0", Length = "0x57")]
		[Token(Token = "0x6000183")]
		 get { } //Length: 87
	}

	[Token(Token = "0x1700002A")]
	public NativeArray<Int32> drawInstanceIndices
	{
		[Address(RVA = "0x2CDA910", Offset = "0x2CD9D10", Length = "0x57")]
		[Token(Token = "0x6000184")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000024")]
	public NativeList<DrawInstance> drawInstances
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600017E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000028")]
	public NativeList<DrawRange> drawRanges
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000182")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000027")]
	public NativeParallelHashMap<RangeKey, Int32> rangeHash
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x6000181")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700002B")]
	public bool valid
	{
		[Address(RVA = "0x2CDA970", Offset = "0x2CD9D70", Length = "0x33")]
		[Token(Token = "0x6000185")]
		 get { } //Length: 51
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600018D")]
	public CPUDrawInstanceData() { }

	[Address(RVA = "0x2CD9BD0", Offset = "0x2CD8FD0", Length = "0x83")]
	[Token(Token = "0x6000189")]
	public void DestroyDrawInstanceIndices(NativeArray<Int32> drawInstanceIndicesToDestroy) { }

	[Address(RVA = "0x2CD9C60", Offset = "0x2CD9060", Length = "0x2FE")]
	[Token(Token = "0x600018A")]
	public void DestroyDrawInstances(NativeArray<InstanceHandle> destroyedInstances) { }

	[Address(RVA = "0x2CD9F60", Offset = "0x2CD9360", Length = "0x2FE")]
	[Token(Token = "0x600018B")]
	public void DestroyMaterialDrawInstances(NativeArray<UInt32> destroyedBatchMaterials) { }

	[Address(RVA = "0x2CDA260", Offset = "0x2CD9660", Length = "0x173")]
	[Token(Token = "0x6000187")]
	public void Dispose() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[Token(Token = "0x600017F")]
	public NativeParallelHashMap<DrawKey, Int32> get_batchHash() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000180")]
	public NativeList<DrawBatch> get_drawBatches() { }

	[Address(RVA = "0x2CDA8B0", Offset = "0x2CD9CB0", Length = "0x57")]
	[Token(Token = "0x6000183")]
	public NativeArray<Int32> get_drawBatchIndices() { }

	[Address(RVA = "0x2CDA910", Offset = "0x2CD9D10", Length = "0x57")]
	[Token(Token = "0x6000184")]
	public NativeArray<Int32> get_drawInstanceIndices() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600017E")]
	public NativeList<DrawInstance> get_drawInstances() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000182")]
	public NativeList<DrawRange> get_drawRanges() { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[Token(Token = "0x6000181")]
	public NativeParallelHashMap<RangeKey, Int32> get_rangeHash() { }

	[Address(RVA = "0x2CDA970", Offset = "0x2CD9D70", Length = "0x33")]
	[Token(Token = "0x6000185")]
	public bool get_valid() { }

	[Address(RVA = "0x2CDA3E0", Offset = "0x2CD97E0", Length = "0x1D1")]
	[Token(Token = "0x6000186")]
	public void Initialize() { }

	[Address(RVA = "0x2CDA5C0", Offset = "0x2CD99C0", Length = "0x5")]
	[Token(Token = "0x600018C")]
	public void NeedsRebuild() { }

	[Address(RVA = "0x2CDA5D0", Offset = "0x2CD99D0", Length = "0x2D6")]
	[Token(Token = "0x6000188")]
	public void RebuildDrawListsIfNeeded() { }

}

