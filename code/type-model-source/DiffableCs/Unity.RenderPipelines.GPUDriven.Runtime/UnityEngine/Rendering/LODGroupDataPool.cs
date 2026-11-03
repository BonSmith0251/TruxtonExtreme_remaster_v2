namespace UnityEngine.Rendering;

[Token(Token = "0x20000BF")]
internal class LODGroupDataPool : IDisposable
{
	[Token(Token = "0x20000C0")]
	private static class LodGroupShaderIDs
	{
		[Token(Token = "0x4000399")]
		public static readonly int _SupportDitheringCrossFade; //Field offset: 0x0
		[Token(Token = "0x400039A")]
		public static readonly int _LodGroupCullingDataGPUByteSize; //Field offset: 0x4
		[Token(Token = "0x400039B")]
		public static readonly int _LodGroupCullingDataStartOffset; //Field offset: 0x8
		[Token(Token = "0x400039C")]
		public static readonly int _LodCullingDataQueueCount; //Field offset: 0xC
		[Token(Token = "0x400039D")]
		public static readonly int _InputLodCullingDataIndices; //Field offset: 0x10
		[Token(Token = "0x400039E")]
		public static readonly int _InputLodCullingDataBuffer; //Field offset: 0x14
		[Token(Token = "0x400039F")]
		public static readonly int _LodGroupCullingData; //Field offset: 0x18

		[Address(RVA = "0x2CF79B0", Offset = "0x2CF6DB0", Length = "0x151")]
		[Token(Token = "0x6000339")]
		private static LodGroupShaderIDs() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000393")]
	private NativeList<LODGroupData> m_LODGroupData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000394")]
	private NativeParallelHashMap<Int32, GPUInstanceIndex> m_LODGroupDataHash; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000395")]
	private NativeList<LODGroupCullingData> m_LODGroupCullingData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000396")]
	private NativeList<GPUInstanceIndex> m_FreeLODGroupDataHandles; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000397")]
	private int m_CrossfadedRendererCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000398")]
	private bool m_SupportDitheringCrossFade; //Field offset: 0x3C

	[Token(Token = "0x1700005F")]
	public int activeLodGroupCount
	{
		[Address(RVA = "0x2CF7670", Offset = "0x2CF6A70", Length = "0x4B")]
		[Token(Token = "0x6000333")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700005E")]
	public int crossfadedRendererCount
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000332")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700005D")]
	public NativeList<LODGroupCullingData> lodGroupCullingData
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000331")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005C")]
	public NativeParallelHashMap<Int32, GPUInstanceIndex> lodGroupDataHash
	{
		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[Token(Token = "0x6000330")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2CF7530", Offset = "0x2CF6930", Length = "0x133")]
	[Token(Token = "0x6000334")]
	public LODGroupDataPool(GPUResidentDrawerResources resources, int initialInstanceCount, bool supportDitheringCrossFade) { }

	[Address(RVA = "0x2CF6F90", Offset = "0x2CF6390", Length = "0x8E")]
	[Token(Token = "0x6000335")]
	public override void Dispose() { }

	[Address(RVA = "0x2CF7020", Offset = "0x2CF6420", Length = "0x38")]
	[Token(Token = "0x6000338")]
	public void FreeLODGroupData(NativeArray<EntityId> destroyedLODGroupsID) { }

	[Address(RVA = "0x2CF7670", Offset = "0x2CF6A70", Length = "0x4B")]
	[Token(Token = "0x6000333")]
	public int get_activeLodGroupCount() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000332")]
	public int get_crossfadedRendererCount() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000331")]
	public NativeList<LODGroupCullingData> get_lodGroupCullingData() { }

	[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
	[Token(Token = "0x6000330")]
	public NativeParallelHashMap<Int32, GPUInstanceIndex> get_lodGroupDataHash() { }

	[Address(RVA = "0x2CF7060", Offset = "0x2CF6460", Length = "0x393")]
	[Token(Token = "0x6000337")]
	public void UpdateLODGroupData(in GPUDrivenLODGroupData inputData) { }

	[Address(RVA = "0x2CF7400", Offset = "0x2CF6800", Length = "0x12C")]
	[Token(Token = "0x6000336")]
	public void UpdateLODGroupTransformData(in GPUDrivenLODGroupData inputData) { }

}

