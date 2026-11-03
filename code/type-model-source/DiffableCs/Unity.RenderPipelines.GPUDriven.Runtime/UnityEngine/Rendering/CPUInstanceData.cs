namespace UnityEngine.Rendering;

[Token(Token = "0x2000078")]
internal struct CPUInstanceData : IDisposable
{
	[IsReadOnly]
	[Token(Token = "0x2000079")]
	public struct ReadOnly
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000224")]
		public readonly ReadOnly<Int32> instanceIndices; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000225")]
		public readonly ReadOnly<InstanceHandle> instances; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000226")]
		public readonly ReadOnly<SharedInstanceHandle> sharedInstances; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000227")]
		public readonly ParallelBitArray localToWorldIsFlippedBits; //Field offset: 0x30
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000228")]
		public readonly ReadOnly<AABB> worldAABBs; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000229")]
		public readonly ReadOnly<Int32> tetrahedronCacheIndices; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400022A")]
		public readonly ParallelBitArray movedInCurrentFrameBits; //Field offset: 0x70
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400022B")]
		public readonly ParallelBitArray movedInPreviousFrameBits; //Field offset: 0x90
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400022C")]
		public readonly ParallelBitArray visibleInPreviousFrameBits; //Field offset: 0xB0
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x400022D")]
		public readonly ReadOnly editorData; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x400022E")]
		public readonly ReadOnly<GPUDrivenRendererMeshLodData> meshLodData; //Field offset: 0xD8

		[Token(Token = "0x1700003D")]
		public int handlesLength
		{
			[Address(RVA = "0x2CEF1E0", Offset = "0x2CEE5E0", Length = "0x2E")]
			[Token(Token = "0x600023B")]
			 get { } //Length: 46
		}

		[Token(Token = "0x1700003E")]
		public int instancesLength
		{
			[Address(RVA = "0x2CEF240", Offset = "0x2CEE640", Length = "0x2E")]
			[Token(Token = "0x600023C")]
			 get { } //Length: 46
		}

		[Address(RVA = "0x2CEE920", Offset = "0x2CEDD20", Length = "0x8B3")]
		[Token(Token = "0x600023D")]
		public ReadOnly(in CPUInstanceData instanceData) { }

		[Address(RVA = "0x2CEF1E0", Offset = "0x2CEE5E0", Length = "0x2E")]
		[Token(Token = "0x600023B")]
		public int get_handlesLength() { }

		[Address(RVA = "0x2CEF240", Offset = "0x2CEE640", Length = "0x2E")]
		[Token(Token = "0x600023C")]
		public int get_instancesLength() { }

		[Address(RVA = "0x2CED6F0", Offset = "0x2CECAF0", Length = "0x66")]
		[Token(Token = "0x600023F")]
		public InstanceHandle IndexToInstance(int index) { }

		[Address(RVA = "0x2CED7D0", Offset = "0x2CECBD0", Length = "0x99")]
		[Token(Token = "0x600023E")]
		public int InstanceToIndex(InstanceHandle instance) { }

		[Address(RVA = "0x2CED900", Offset = "0x2CECD00", Length = "0xF4")]
		[Token(Token = "0x6000241")]
		public bool IsValidIndex(int index) { }

		[Address(RVA = "0x2CEDB00", Offset = "0x2CECF00", Length = "0x1C7")]
		[Token(Token = "0x6000240")]
		public bool IsValidInstance(InstanceHandle instance) { }

	}

	[Token(Token = "0x4000217")]
	private const int k_InvalidIndex = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000218")]
	private NativeArray<Int32> m_StructData; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000219")]
	private NativeList<Int32> m_InstanceIndices; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400021A")]
	public NativeArray<InstanceHandle> instances; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400021B")]
	public NativeArray<SharedInstanceHandle> sharedInstances; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400021C")]
	public ParallelBitArray localToWorldIsFlippedBits; //Field offset: 0x38
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400021D")]
	public NativeArray<AABB> worldAABBs; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400021E")]
	public NativeArray<Int32> tetrahedronCacheIndices; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400021F")]
	public ParallelBitArray movedInCurrentFrameBits; //Field offset: 0x78
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000220")]
	public ParallelBitArray movedInPreviousFrameBits; //Field offset: 0x98
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000221")]
	public ParallelBitArray visibleInPreviousFrameBits; //Field offset: 0xB8
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000222")]
	public EditorInstanceDataArrays editorData; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000223")]
	public NativeArray<GPUDrivenRendererMeshLodData> meshLodData; //Field offset: 0xE0

	[Token(Token = "0x1700003C")]
	public int handlesLength
	{
		[Address(RVA = "0x2CDBF20", Offset = "0x2CDB320", Length = "0x4B")]
		[Token(Token = "0x6000218")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700003B")]
	public int instancesCapacity
	{
		[Address(RVA = "0x2CDBF70", Offset = "0x2CDB370", Length = "0x7")]
		[Token(Token = "0x6000216")]
		 get { } //Length: 7
		[Address(RVA = "0x2CDBF90", Offset = "0x2CDB390", Length = "0x7")]
		[Token(Token = "0x6000217")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700003A")]
	public int instancesLength
	{
		[Address(RVA = "0x2CDBF80", Offset = "0x2CDB380", Length = "0x6")]
		[Token(Token = "0x6000214")]
		 get { } //Length: 6
		[Address(RVA = "0x28D1670", Offset = "0x28D0A70", Length = "0x6")]
		[Token(Token = "0x6000215")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2CDAB90", Offset = "0x2CD9F90", Length = "0x59")]
	[Token(Token = "0x6000225")]
	public void Add(InstanceHandle instance) { }

	[Address(RVA = "0x2CDA9B0", Offset = "0x2CD9DB0", Length = "0x2E")]
	[Token(Token = "0x6000224")]
	public void AddNoGrow(InstanceHandle instance) { }

	[Address(RVA = "0x2CDA9E0", Offset = "0x2CD9DE0", Length = "0x1B0")]
	[Token(Token = "0x600021C")]
	private void AddUnsafe(InstanceHandle instance) { }

	[Address(RVA = "0x2CDABF0", Offset = "0x2CD9FF0", Length = "0x39")]
	[Token(Token = "0x600023A")]
	public ReadOnly AsReadOnly() { }

	[Address(RVA = "0x2CDAC30", Offset = "0x2CDA030", Length = "0x10A")]
	[Token(Token = "0x600021A")]
	public override void Dispose() { }

	[Address(RVA = "0x2CDAD40", Offset = "0x2CDA140", Length = "0x27")]
	[Token(Token = "0x6000223")]
	public void EnsureFreeInstances(int instancesCount) { }

	[Address(RVA = "0x2CDBF20", Offset = "0x2CDB320", Length = "0x4B")]
	[Token(Token = "0x6000218")]
	public int get_handlesLength() { }

	[Address(RVA = "0x2CDBF70", Offset = "0x2CDB370", Length = "0x7")]
	[Token(Token = "0x6000216")]
	public int get_instancesCapacity() { }

	[Address(RVA = "0x2CDBF80", Offset = "0x2CDB380", Length = "0x6")]
	[Token(Token = "0x6000214")]
	public int get_instancesLength() { }

	[Address(RVA = "0x2CDAD80", Offset = "0x2CDA180", Length = "0x24")]
	[Token(Token = "0x600022A")]
	public bool Get_LocalToWorldIsFlipped(InstanceHandle instance) { }

	[Address(RVA = "0x2CDADB0", Offset = "0x2CDA1B0", Length = "0x25")]
	[Token(Token = "0x6000231")]
	public GPUDrivenRendererMeshLodData Get_MeshLodData(InstanceHandle instance) { }

	[Address(RVA = "0x2CDADE0", Offset = "0x2CDA1E0", Length = "0x24")]
	[Token(Token = "0x600022E")]
	public bool Get_MovedInCurrentFrame(InstanceHandle instance) { }

	[Address(RVA = "0x2CDAE10", Offset = "0x2CDA210", Length = "0x27")]
	[Token(Token = "0x600022F")]
	public bool Get_MovedInPreviousFrame(InstanceHandle instance) { }

	[Address(RVA = "0x2CDAE40", Offset = "0x2CDA240", Length = "0x21")]
	[Token(Token = "0x6000229")]
	public SharedInstanceHandle Get_SharedInstance(InstanceHandle instance) { }

	[Address(RVA = "0x2CDAE70", Offset = "0x2CDA270", Length = "0x21")]
	[Token(Token = "0x600022C")]
	public int Get_TetrahedronCacheIndex(InstanceHandle instance) { }

	[Address(RVA = "0x2CDAEA0", Offset = "0x2CDA2A0", Length = "0x27")]
	[Token(Token = "0x6000230")]
	public bool Get_VisibleInPreviousFrame(InstanceHandle instance) { }

	[Address(RVA = "0x2CDAED0", Offset = "0x2CDA2D0", Length = "0x4D")]
	[Token(Token = "0x600022B")]
	public AABB Get_WorldAABB(InstanceHandle instance) { }

	[Address(RVA = "0x2CDAF20", Offset = "0x2CDA320", Length = "0x81")]
	[Token(Token = "0x600022D")]
	public AABB Get_WorldBounds(InstanceHandle instance) { }

	[Address(RVA = "0x2CDAD70", Offset = "0x2CDA170", Length = "0x9")]
	[Token(Token = "0x6000222")]
	public int GetFreeInstancesCount() { }

	[Address(RVA = "0x2CDAFB0", Offset = "0x2CDA3B0", Length = "0x20A")]
	[Token(Token = "0x600021B")]
	private void Grow(int newCapacity) { }

	[Address(RVA = "0x2CDB1C0", Offset = "0x2CDA5C0", Length = "0xB")]
	[Token(Token = "0x600021E")]
	public InstanceHandle IndexToInstance(int index) { }

	[Address(RVA = "0x2CDB1D0", Offset = "0x2CDA5D0", Length = "0x3EE")]
	[Token(Token = "0x6000219")]
	public void Initialize(int initCapacity) { }

	[Address(RVA = "0x2CDB5C0", Offset = "0x2CDA9C0", Length = "0x7B")]
	[Token(Token = "0x600021D")]
	public int InstanceToIndex(InstanceHandle instance) { }

	[Address(RVA = "0x2CDB640", Offset = "0x2CDAA40", Length = "0x136")]
	[Token(Token = "0x6000220")]
	public bool IsFreeInstanceHandle(InstanceHandle instance) { }

	[Address(RVA = "0x2CDB780", Offset = "0x2CDAB80", Length = "0xA8")]
	[Token(Token = "0x6000221")]
	public bool IsValidIndex(int index) { }

	[Address(RVA = "0x2CDB830", Offset = "0x2CDAC30", Length = "0x18B")]
	[Token(Token = "0x600021F")]
	public bool IsValidInstance(InstanceHandle instance) { }

	[Address(RVA = "0x2CDB9C0", Offset = "0x2CDADC0", Length = "0x1DF")]
	[Token(Token = "0x6000226")]
	public void Remove(InstanceHandle instance) { }

	[Address(RVA = "0x2CDBE40", Offset = "0x2CDB240", Length = "0xD6")]
	[Token(Token = "0x6000227")]
	public void Set(InstanceHandle instance, SharedInstanceHandle sharedInstance, bool localToWorldIsFlipped, in AABB worldAABB, int tetrahedronCacheIndex, bool movedInCurrentFrame, bool movedInPreviousFrame, bool visibleInPreviousFrame, in GPUDrivenRendererMeshLodData meshLod) { }

	[Address(RVA = "0x2CDBF90", Offset = "0x2CDB390", Length = "0x7")]
	[Token(Token = "0x6000217")]
	public void set_instancesCapacity(int value) { }

	[Address(RVA = "0x28D1670", Offset = "0x28D0A70", Length = "0x6")]
	[Token(Token = "0x6000215")]
	public void set_instancesLength(int value) { }

	[Address(RVA = "0x2CDBC60", Offset = "0x2CDB060", Length = "0x35")]
	[Token(Token = "0x6000233")]
	public void Set_LocalToWorldIsFlipped(InstanceHandle instance, bool isFlipped) { }

	[Address(RVA = "0x2CDBCA0", Offset = "0x2CDB0A0", Length = "0x31")]
	[Token(Token = "0x6000239")]
	public void Set_MeshLodData(InstanceHandle instance, GPUDrivenRendererMeshLodData meshLod) { }

	[Address(RVA = "0x2CDBCE0", Offset = "0x2CDB0E0", Length = "0x35")]
	[Token(Token = "0x6000236")]
	public void Set_MovedInCurrentFrame(InstanceHandle instance, bool movedInCurrentFrame) { }

	[Address(RVA = "0x2CDBD20", Offset = "0x2CDB120", Length = "0x38")]
	[Token(Token = "0x6000237")]
	public void Set_MovedInPreviousFrame(InstanceHandle instance, bool movedInPreviousFrame) { }

	[Address(RVA = "0x2CDBD60", Offset = "0x2CDB160", Length = "0x2D")]
	[Token(Token = "0x6000232")]
	public void Set_SharedInstance(InstanceHandle instance, SharedInstanceHandle sharedInstance) { }

	[Address(RVA = "0x2CDBD90", Offset = "0x2CDB190", Length = "0x2D")]
	[Token(Token = "0x6000235")]
	public void Set_TetrahedronCacheIndex(InstanceHandle instance, int tetrahedronCacheIndex) { }

	[Address(RVA = "0x2CDBDC0", Offset = "0x2CDB1C0", Length = "0x38")]
	[Token(Token = "0x6000238")]
	public void Set_VisibleInPreviousFrame(InstanceHandle instance, bool visibleInPreviousFrame) { }

	[Address(RVA = "0x2CDBE00", Offset = "0x2CDB200", Length = "0x3F")]
	[Token(Token = "0x6000234")]
	public void Set_WorldAABB(InstanceHandle instance, in AABB worldBounds) { }

	[Address(RVA = "0x2CDBBA0", Offset = "0x2CDAFA0", Length = "0xC0")]
	[Token(Token = "0x6000228")]
	public void SetDefault(InstanceHandle instance) { }

}

