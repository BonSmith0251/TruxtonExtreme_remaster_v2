namespace UnityEngine.Rendering;

[Token(Token = "0x20000B4")]
internal struct IndirectBufferContextStorage : IDisposable
{
	[Token(Token = "0x4000359")]
	private const int kAllocatorCount = 2; //Field offset: 0x0
	[Token(Token = "0x400035A")]
	internal const int kInstanceInfoGpuOffsetMultiplier = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400035B")]
	private IndirectBufferLimits m_BufferLimits; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400035C")]
	private GraphicsBuffer m_InstanceBuffer; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400035D")]
	private GraphicsBuffer m_InstanceInfoBuffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400035E")]
	private NativeArray<IndirectInstanceInfo> m_InstanceInfoStaging; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400035F")]
	private GraphicsBuffer m_DispatchArgsBuffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000360")]
	private GraphicsBuffer m_DrawArgsBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000361")]
	private GraphicsBuffer m_DrawInfoBuffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000362")]
	private NativeArray<IndirectDrawInfo> m_DrawInfoStaging; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000363")]
	private int m_ContextAllocCounter; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000364")]
	private NativeHashMap<Int32, Int32> m_ContextIndexFromViewID; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000365")]
	private NativeList<IndirectBufferContext> m_Contexts; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000366")]
	private NativeArray<IndirectBufferAllocInfo> m_ContextAllocInfo; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000367")]
	private NativeArray<Int32> m_AllocationCounters; //Field offset: 0x78

	[Token(Token = "0x1700005B")]
	public NativeArray<Int32> allocationCounters
	{
		[Address(RVA = "0x16D0810", Offset = "0x16CFC10", Length = "0xB")]
		[Token(Token = "0x600031B")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000054")]
	public GraphicsBuffer dispatchArgsBuffer
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000313")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000055")]
	public GraphicsBuffer drawArgsBuffer
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000314")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000056")]
	public GraphicsBuffer drawInfoBuffer
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000315")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005A")]
	public NativeArray<IndirectDrawInfo> drawInfoGlobalArray
	{
		[Address(RVA = "0x1116930", Offset = "0x1115D30", Length = "0xB")]
		[Token(Token = "0x600031A")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000058")]
	public GraphicsBufferHandle indirectDrawArgsBufferHandle
	{
		[Address(RVA = "0x2CF51D0", Offset = "0x2CF45D0", Length = "0x1D")]
		[Token(Token = "0x6000317")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000052")]
	public GraphicsBuffer instanceBuffer
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6000311")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000053")]
	public GraphicsBuffer instanceInfoBuffer
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000312")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000059")]
	public NativeArray<IndirectInstanceInfo> instanceInfoGlobalArray
	{
		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[Token(Token = "0x6000319")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000057")]
	public GraphicsBufferHandle visibleInstanceBufferHandle
	{
		[Address(RVA = "0x2CF51F0", Offset = "0x2CF45F0", Length = "0x1D")]
		[Token(Token = "0x6000316")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x2CF4230", Offset = "0x2CF3630", Length = "0x186")]
	[Token(Token = "0x600031F")]
	private void AllocateDrawBuffers(int maxDrawCount) { }

	[Address(RVA = "0x2CF43C0", Offset = "0x2CF37C0", Length = "0x144")]
	[Token(Token = "0x600031D")]
	private void AllocateInstanceBuffers(int maxInstanceCount) { }

	[Address(RVA = "0x2CF4510", Offset = "0x2CF3910", Length = "0x29")]
	[Token(Token = "0x6000325")]
	public void ClearContextsAndGrowBuffers() { }

	[Address(RVA = "0x2CF4540", Offset = "0x2CF3940", Length = "0xD4")]
	[Token(Token = "0x600032A")]
	public void CopyFromStaging(CommandBuffer cmd, in IndirectBufferAllocInfo allocInfo) { }

	[Address(RVA = "0x2CF4620", Offset = "0x2CF3A20", Length = "0xF9")]
	[Token(Token = "0x6000321")]
	public override void Dispose() { }

	[Address(RVA = "0x2CF4720", Offset = "0x2CF3B20", Length = "0x77")]
	[Token(Token = "0x6000320")]
	private void FreeDrawBuffers() { }

	[Address(RVA = "0x2CF47A0", Offset = "0x2CF3BA0", Length = "0x66")]
	[Token(Token = "0x600031E")]
	private void FreeInstanceBuffers() { }

	[Address(RVA = "0x16D0810", Offset = "0x16CFC10", Length = "0xB")]
	[Token(Token = "0x600031B")]
	public NativeArray<Int32> get_allocationCounters() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000313")]
	public GraphicsBuffer get_dispatchArgsBuffer() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000314")]
	public GraphicsBuffer get_drawArgsBuffer() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000315")]
	public GraphicsBuffer get_drawInfoBuffer() { }

	[Address(RVA = "0x1116930", Offset = "0x1115D30", Length = "0xB")]
	[Token(Token = "0x600031A")]
	public NativeArray<IndirectDrawInfo> get_drawInfoGlobalArray() { }

	[Address(RVA = "0x2CF51D0", Offset = "0x2CF45D0", Length = "0x1D")]
	[Token(Token = "0x6000317")]
	public GraphicsBufferHandle get_indirectDrawArgsBufferHandle() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6000311")]
	public GraphicsBuffer get_instanceBuffer() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000312")]
	public GraphicsBuffer get_instanceInfoBuffer() { }

	[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
	[Token(Token = "0x6000319")]
	public NativeArray<IndirectInstanceInfo> get_instanceInfoGlobalArray() { }

	[Address(RVA = "0x2CF51F0", Offset = "0x2CF45F0", Length = "0x1D")]
	[Token(Token = "0x6000316")]
	public GraphicsBufferHandle get_visibleInstanceBufferHandle() { }

	[Address(RVA = "0x2CF4890", Offset = "0x2CF3C90", Length = "0x8E")]
	[Token(Token = "0x6000329")]
	public IndirectBufferAllocInfo GetAllocInfo(int contextIndex) { }

	[Address(RVA = "0x2CF4810", Offset = "0x2CF3C10", Length = "0x79")]
	[Token(Token = "0x6000328")]
	public NativeArray<IndirectBufferAllocInfo> GetAllocInfoSubArray(int contextIndex) { }

	[Address(RVA = "0x2CF4920", Offset = "0x2CF3D20", Length = "0xC4")]
	[Token(Token = "0x600032C")]
	public IndirectBufferContext GetBufferContext(int contextIndex) { }

	[Address(RVA = "0x2CF49F0", Offset = "0x2CF3DF0", Length = "0xB")]
	[Token(Token = "0x600032B")]
	public IndirectBufferLimits GetLimits(int contextIndex) { }

	[Address(RVA = "0x2CF4A00", Offset = "0x2CF3E00", Length = "0x19A")]
	[Token(Token = "0x6000324")]
	private void GrowBuffers() { }

	[Address(RVA = "0x2CF4BA0", Offset = "0x2CF3FA0", Length = "0xFE")]
	[Token(Token = "0x6000318")]
	public IndirectBufferContextHandles ImportBuffers(RenderGraph renderGraph) { }

	[Address(RVA = "0x2CF4CA0", Offset = "0x2CF40A0", Length = "0x151")]
	[Token(Token = "0x600031C")]
	public void Init() { }

	[Address(RVA = "0x2CF4E00", Offset = "0x2CF4200", Length = "0x9D")]
	[Token(Token = "0x6000323")]
	private void ResetAllocators() { }

	[Address(RVA = "0x2CF4EA0", Offset = "0x2CF42A0", Length = "0xB8")]
	[Token(Token = "0x600032D")]
	public void SetBufferContext(int contextIndex, IndirectBufferContext ctx) { }

	[Address(RVA = "0x2CF4F60", Offset = "0x2CF4360", Length = "0xCE")]
	[Token(Token = "0x6000322")]
	private void SyncContexts() { }

	[Address(RVA = "0x2CF5030", Offset = "0x2CF4430", Length = "0x130")]
	[Token(Token = "0x6000326")]
	public int TryAllocateContext(int viewID) { }

	[Address(RVA = "0x2CF5160", Offset = "0x2CF4560", Length = "0x62")]
	[Token(Token = "0x6000327")]
	public int TryGetContextIndex(int viewID) { }

}

