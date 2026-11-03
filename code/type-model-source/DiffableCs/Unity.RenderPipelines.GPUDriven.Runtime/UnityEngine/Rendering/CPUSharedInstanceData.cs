namespace UnityEngine.Rendering;

[Token(Token = "0x200007C")]
internal struct CPUSharedInstanceData : IDisposable
{
	[IsReadOnly]
	[Token(Token = "0x200007D")]
	public struct ReadOnly
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000242")]
		public readonly ReadOnly<Int32> instanceIndices; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000243")]
		public readonly ReadOnly<SharedInstanceHandle> instances; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000244")]
		public readonly ReadOnly<EntityId> rendererGroupIDs; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000245")]
		public readonly ReadOnly<SmallEntityIdArray> materialIDArrays; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000246")]
		public readonly ReadOnly<EntityId> meshIDs; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000247")]
		public readonly ReadOnly<AABB> localAABBs; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000248")]
		public readonly ReadOnly<CPUSharedInstanceFlags> flags; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000249")]
		public readonly ReadOnly<UInt32> lodGroupAndMasks; //Field offset: 0x70
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400024A")]
		public readonly ReadOnly<GPUDrivenMeshLodInfo> meshLodInfos; //Field offset: 0x80
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400024B")]
		public readonly ReadOnly<Int32> gameObjectLayers; //Field offset: 0x90
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400024C")]
		public readonly ReadOnly<Int32> refCounts; //Field offset: 0xA0

		[Token(Token = "0x17000046")]
		public int handlesLength
		{
			[Address(RVA = "0x2CEF210", Offset = "0x2CEE610", Length = "0x2E")]
			[Token(Token = "0x600027C")]
			 get { } //Length: 46
		}

		[Token(Token = "0x17000047")]
		public int instancesLength
		{
			[Address(RVA = "0x2CEF270", Offset = "0x2CEE670", Length = "0x2E")]
			[Token(Token = "0x600027D")]
			 get { } //Length: 46
		}

		[Address(RVA = "0x2CEDF40", Offset = "0x2CED340", Length = "0x9BE")]
		[Token(Token = "0x600027E")]
		public ReadOnly(in CPUSharedInstanceData instanceData) { }

		[Address(RVA = "0x2CEF210", Offset = "0x2CEE610", Length = "0x2E")]
		[Token(Token = "0x600027C")]
		public int get_handlesLength() { }

		[Address(RVA = "0x2CEF270", Offset = "0x2CEE670", Length = "0x2E")]
		[Token(Token = "0x600027D")]
		public int get_instancesLength() { }

		[Address(RVA = "0x2CED760", Offset = "0x2CECB60", Length = "0x66")]
		[Token(Token = "0x6000280")]
		public SharedInstanceHandle IndexToSharedInstance(int index) { }

		[Address(RVA = "0x2CED870", Offset = "0x2CECC70", Length = "0x8D")]
		[Token(Token = "0x6000283")]
		public int InstanceToIndex(in ReadOnly instanceData, InstanceHandle instance) { }

		[Address(RVA = "0x2CEDA00", Offset = "0x2CECE00", Length = "0xF4")]
		[Token(Token = "0x6000282")]
		public bool IsValidIndex(int index) { }

		[Address(RVA = "0x2CEDCD0", Offset = "0x2CED0D0", Length = "0x1C7")]
		[Token(Token = "0x6000281")]
		public bool IsValidSharedInstance(SharedInstanceHandle instance) { }

		[Address(RVA = "0x2CEDEA0", Offset = "0x2CED2A0", Length = "0x99")]
		[Token(Token = "0x600027F")]
		public int SharedInstanceToIndex(SharedInstanceHandle instance) { }

	}

	[Token(Token = "0x4000234")]
	private const int k_InvalidIndex = -1; //Field offset: 0x0
	[Token(Token = "0x4000235")]
	private const uint k_InvalidLODGroupAndMask = 4294967295; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000236")]
	private NativeArray<Int32> m_StructData; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000237")]
	private NativeList<Int32> m_InstanceIndices; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000238")]
	public NativeArray<SharedInstanceHandle> instances; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000239")]
	public NativeArray<EntityId> rendererGroupIDs; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400023A")]
	public NativeArray<SmallEntityIdArray> materialIDArrays; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400023B")]
	public NativeArray<EntityId> meshIDs; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400023C")]
	public NativeArray<AABB> localAABBs; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400023D")]
	public NativeArray<CPUSharedInstanceFlags> flags; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400023E")]
	public NativeArray<UInt32> lodGroupAndMasks; //Field offset: 0x78
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400023F")]
	public NativeArray<GPUDrivenMeshLodInfo> meshLodInfos; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000240")]
	public NativeArray<Int32> gameObjectLayers; //Field offset: 0x98
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000241")]
	public NativeArray<Int32> refCounts; //Field offset: 0xA8

	[Token(Token = "0x17000045")]
	public int handlesLength
	{
		[Address(RVA = "0x2CDE980", Offset = "0x2CDDD80", Length = "0x4B")]
		[Token(Token = "0x6000259")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000044")]
	public int instancesCapacity
	{
		[Address(RVA = "0x2CDBF70", Offset = "0x2CDB370", Length = "0x7")]
		[Token(Token = "0x6000257")]
		 get { } //Length: 7
		[Address(RVA = "0x2CDBF90", Offset = "0x2CDB390", Length = "0x7")]
		[Token(Token = "0x6000258")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000043")]
	public int instancesLength
	{
		[Address(RVA = "0x2CDBF80", Offset = "0x2CDB380", Length = "0x6")]
		[Token(Token = "0x6000255")]
		 get { } //Length: 6
		[Address(RVA = "0x28D1670", Offset = "0x28D0A70", Length = "0x6")]
		[Token(Token = "0x6000256")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2CDCFB0", Offset = "0x2CDC3B0", Length = "0x59")]
	[Token(Token = "0x6000267")]
	public void Add(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDCDD0", Offset = "0x2CDC1D0", Length = "0x2E")]
	[Token(Token = "0x6000266")]
	public void AddNoGrow(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDCE00", Offset = "0x2CDC200", Length = "0x1B0")]
	[Token(Token = "0x600025D")]
	private void AddUnsafe(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDD010", Offset = "0x2CDC410", Length = "0x39")]
	[Token(Token = "0x600027B")]
	public ReadOnly AsReadOnly() { }

	[Address(RVA = "0x2CDD050", Offset = "0x2CDC450", Length = "0x3B9")]
	[Token(Token = "0x600025B")]
	public override void Dispose() { }

	[Address(RVA = "0x2CDD410", Offset = "0x2CDC810", Length = "0x27")]
	[Token(Token = "0x6000265")]
	public void EnsureFreeInstances(int instancesCount) { }

	[Address(RVA = "0x2CDD440", Offset = "0x2CDC840", Length = "0x22")]
	[Token(Token = "0x600026C")]
	public CPUSharedInstanceFlags Get_Flags(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDD470", Offset = "0x2CDC870", Length = "0x24")]
	[Token(Token = "0x600026E")]
	public int Get_GameObjectLayer(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDE980", Offset = "0x2CDDD80", Length = "0x4B")]
	[Token(Token = "0x6000259")]
	public int get_handlesLength() { }

	[Address(RVA = "0x2CDBF70", Offset = "0x2CDB370", Length = "0x7")]
	[Token(Token = "0x6000257")]
	public int get_instancesCapacity() { }

	[Address(RVA = "0x2CDBF80", Offset = "0x2CDB380", Length = "0x6")]
	[Token(Token = "0x6000255")]
	public int get_instancesLength() { }

	[Address(RVA = "0x2CDD4D0", Offset = "0x2CDC8D0", Length = "0x81")]
	[Token(Token = "0x600026B")]
	public AABB Get_LocalAABB(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDD4A0", Offset = "0x2CDC8A0", Length = "0x21")]
	[Token(Token = "0x600026D")]
	public uint Get_LODGroupAndMask(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDD560", Offset = "0x2CDC960", Length = "0x7F")]
	[Token(Token = "0x6000270")]
	public SmallEntityIdArray Get_MaterialIDs(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDD5E0", Offset = "0x2CDC9E0", Length = "0x21")]
	[Token(Token = "0x600026A")]
	public int Get_MeshID(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDD610", Offset = "0x2CDCA10", Length = "0x24")]
	[Token(Token = "0x600026F")]
	public int Get_RefCount(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDD640", Offset = "0x2CDCA40", Length = "0x21")]
	[Token(Token = "0x6000269")]
	public int Get_RendererGroupID(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDAD70", Offset = "0x2CDA170", Length = "0x9")]
	[Token(Token = "0x6000264")]
	public int GetFreeInstancesCount() { }

	[Address(RVA = "0x2CDD670", Offset = "0x2CDCA70", Length = "0x261")]
	[Token(Token = "0x600025C")]
	private void Grow(int newCapacity) { }

	[Address(RVA = "0x2CDB1C0", Offset = "0x2CDA5C0", Length = "0xB")]
	[Token(Token = "0x600025F")]
	public SharedInstanceHandle IndexToSharedInstance(int index) { }

	[Address(RVA = "0x2CDD8E0", Offset = "0x2CDCCE0", Length = "0x3D3")]
	[Token(Token = "0x600025A")]
	public void Initialize(int initCapacity) { }

	[Address(RVA = "0x2CDDCC0", Offset = "0x2CDD0C0", Length = "0x139")]
	[Token(Token = "0x6000260")]
	public int InstanceToIndex(in CPUInstanceData instanceData, InstanceHandle instance) { }

	[Address(RVA = "0x2CDDE00", Offset = "0x2CDD200", Length = "0x136")]
	[Token(Token = "0x6000262")]
	public bool IsFreeInstanceHandle(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDDF40", Offset = "0x2CDD340", Length = "0xA8")]
	[Token(Token = "0x6000263")]
	public bool IsValidIndex(int index) { }

	[Address(RVA = "0x2CDDFF0", Offset = "0x2CDD3F0", Length = "0x18B")]
	[Token(Token = "0x6000261")]
	public bool IsValidInstance(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDE180", Offset = "0x2CDD580", Length = "0x29E")]
	[Token(Token = "0x6000268")]
	public void Remove(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDE750", Offset = "0x2CDDB50", Length = "0x1AD")]
	[Token(Token = "0x6000279")]
	public void Set(SharedInstanceHandle instance, EntityId rendererGroupID, in SmallEntityIdArray materialIDs, int meshID, in AABB localAABB, TransformUpdateFlags transformUpdateFlags, InstanceFlags instanceFlags, uint lodGroupAndMask, GPUDrivenMeshLodInfo meshLodInfo, int gameObjectLayer, int refCount) { }

	[Address(RVA = "0x2CDE4F0", Offset = "0x2CDD8F0", Length = "0x2F")]
	[Token(Token = "0x6000274")]
	public void Set_Flags(SharedInstanceHandle instance, CPUSharedInstanceFlags instanceFlags) { }

	[Address(RVA = "0x2CDE520", Offset = "0x2CDD920", Length = "0x30")]
	[Token(Token = "0x6000276")]
	public void Set_GameObjectLayer(SharedInstanceHandle instance, int gameObjectLayer) { }

	[Address(RVA = "0x2CDBF90", Offset = "0x2CDB390", Length = "0x7")]
	[Token(Token = "0x6000258")]
	public void set_instancesCapacity(int value) { }

	[Address(RVA = "0x28D1670", Offset = "0x28D0A70", Length = "0x6")]
	[Token(Token = "0x6000256")]
	public void set_instancesLength(int value) { }

	[Address(RVA = "0x2CDE580", Offset = "0x2CDD980", Length = "0x3F")]
	[Token(Token = "0x6000273")]
	public void Set_LocalAABB(SharedInstanceHandle instance, in AABB localAABB) { }

	[Address(RVA = "0x2CDE550", Offset = "0x2CDD950", Length = "0x2D")]
	[Token(Token = "0x6000275")]
	public void Set_LODGroupAndMask(SharedInstanceHandle instance, uint lodGroupAndMask) { }

	[Address(RVA = "0x2CDE5C0", Offset = "0x2CDD9C0", Length = "0xDE")]
	[Token(Token = "0x6000278")]
	public void Set_MaterialIDs(SharedInstanceHandle instance, in SmallEntityIdArray materialIDs) { }

	[Address(RVA = "0x2CDE6A0", Offset = "0x2CDDAA0", Length = "0x40")]
	[Token(Token = "0x6000272")]
	public void Set_MeshID(SharedInstanceHandle instance, int meshID) { }

	[Address(RVA = "0x2CDE6E0", Offset = "0x2CDDAE0", Length = "0x30")]
	[Token(Token = "0x6000277")]
	public void Set_RefCount(SharedInstanceHandle instance, int refCount) { }

	[Address(RVA = "0x2CDE710", Offset = "0x2CDDB10", Length = "0x40")]
	[Token(Token = "0x6000271")]
	public void Set_RendererGroupID(SharedInstanceHandle instance, int rendererGroupID) { }

	[Address(RVA = "0x2CDE420", Offset = "0x2CDD820", Length = "0xC3")]
	[Token(Token = "0x600027A")]
	public void SetDefault(SharedInstanceHandle instance) { }

	[Address(RVA = "0x2CDE900", Offset = "0x2CDDD00", Length = "0x7B")]
	[Token(Token = "0x600025E")]
	public int SharedInstanceToIndex(SharedInstanceHandle instance) { }

}

