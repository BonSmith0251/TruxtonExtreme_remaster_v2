namespace Unity.Collections;

[DebuggerDisplay("Length = {m_ListData == null ? default : m_ListData->Length}, Capacity = {m_ListData == null ? default : m_ListData->Capacity}")]
[DebuggerTypeProxy(typeof(NativeListDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[NativeContainer]
[Token(Token = "0x200009A")]
public struct NativeList : INativeDisposable, IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	[Token(Token = "0x200009B")]
	internal struct ParallelWriter
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40003C1")]
		public UnsafeList<T>* ListData; //Field offset: 0x0

		[Token(Token = "0x170000D5")]
		public Void* Ptr
		{
			[Address(RVA = "0xE1C7F0", Offset = "0xE1BBF0", Length = "0xAB")]
			[IsReadOnly]
			[Token(Token = "0x60007BD")]
			 get { } //Length: 171
		}

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x60007BE")]
		internal ParallelWriter(UnsafeList<T>* listData) { }

		[Address(RVA = "0xE192B0", Offset = "0xE186B0", Length = "0xBB")]
		[Token(Token = "0x60007BF")]
		public void AddNoResize(T value) { }

		[Address(RVA = "0xE1B230", Offset = "0xE1A630", Length = "0x66")]
		[Token(Token = "0x60007C0")]
		public void AddRangeNoResize(Void* ptr, int count) { }

		[Address(RVA = "0xE1A000", Offset = "0xE19400", Length = "0x9A")]
		[Token(Token = "0x60007C1")]
		public void AddRangeNoResize(UnsafeList<T> list) { }

		[Address(RVA = "0xE1AEC0", Offset = "0xE1A2C0", Length = "0xB3")]
		[Token(Token = "0x60007C2")]
		public void AddRangeNoResize(NativeList<T> list) { }

		[Address(RVA = "0xE1C7F0", Offset = "0xE1BBF0", Length = "0xAB")]
		[IsReadOnly]
		[Token(Token = "0x60007BD")]
		public Void* get_Ptr() { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003C0")]
	internal UnsafeList<T>* m_ListData; //Field offset: 0x0

	[Token(Token = "0x170000D2")]
	public override int Capacity
	{
		[Address(RVA = "0xD75450", Offset = "0xD74850", Length = "0x24")]
		[IsReadOnly]
		[Token(Token = "0x6000790")]
		 get { } //Length: 36
		[Address(RVA = "0xD75A10", Offset = "0xD74E10", Length = "0x43")]
		[Token(Token = "0x6000791")]
		 set { } //Length: 67
	}

	[Token(Token = "0x170000D4")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x60007A1")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000D3")]
	public override bool IsEmpty
	{
		[Address(RVA = "0xD75480", Offset = "0xD74880", Length = "0x3C")]
		[IsReadOnly]
		[Token(Token = "0x60007A0")]
		 get { } //Length: 60
	}

	[Token(Token = "0x170000D0")]
	public override T Item
	{
		[Address(RVA = "0xD755B0", Offset = "0xD749B0", Length = "0x8C")]
		[Token(Token = "0x600078B")]
		 get { } //Length: 140
		[Address(RVA = "0xD75D30", Offset = "0xD75130", Length = "0x89")]
		[Token(Token = "0x600078C")]
		 set { } //Length: 137
	}

	[Token(Token = "0x170000D1")]
	public override int Length
	{
		[Address(RVA = "0xD757D0", Offset = "0xD74BD0", Length = "0x24")]
		[IsReadOnly]
		[Token(Token = "0x600078E")]
		 get { } //Length: 36
		[Address(RVA = "0xD75E60", Offset = "0xD75260", Length = "0x49")]
		[Token(Token = "0x600078F")]
		 set { } //Length: 73
	}

	[Address(RVA = "0xD74E30", Offset = "0xD74230", Length = "0x74")]
	[Token(Token = "0x6000787")]
	public NativeList`1(AllocatorHandle allocator) { }

	[Address(RVA = "0xD751B0", Offset = "0xD745B0", Length = "0x53")]
	[Token(Token = "0x6000788")]
	public NativeList`1(int initialCapacity, AllocatorHandle allocator) { }

	[Address(RVA = "0xD6F960", Offset = "0xD6ED60", Length = "0x13D")]
	[Token(Token = "0x6000796")]
	public void Add(in T value) { }

	[Address(RVA = "0xD6E3A0", Offset = "0xD6D7A0", Length = "0xB7")]
	[Token(Token = "0x6000793")]
	public void AddNoResize(T value) { }

	[Address(RVA = "0xD6F470", Offset = "0xD6E870", Length = "0x58")]
	[Token(Token = "0x6000798")]
	public void AddRange(Void* ptr, int count) { }

	[Address(RVA = "0xD6F340", Offset = "0xD6E740", Length = "0xC1")]
	[Token(Token = "0x6000797")]
	public void AddRange(NativeArray<T> array) { }

	[Address(RVA = "0xD6E610", Offset = "0xD6DA10", Length = "0x58")]
	[Token(Token = "0x6000794")]
	public void AddRangeNoResize(Void* ptr, int count) { }

	[Address(RVA = "0xD6EAE0", Offset = "0xD6DEE0", Length = "0x68")]
	[Token(Token = "0x6000795")]
	public void AddRangeNoResize(NativeList<T> list) { }

	[Address(RVA = "0xD6F5F0", Offset = "0xD6E9F0", Length = "0x58")]
	[Token(Token = "0x6000799")]
	public void AddReplicate(in T value, int count) { }

	[Address(RVA = "0xD6FED0", Offset = "0xD6F2D0", Length = "0xA4")]
	[Token(Token = "0x60007A7")]
	public NativeArray<T> AsArray() { }

	[Address(RVA = "0xD6FF80", Offset = "0xD6F380", Length = "0x62")]
	[Token(Token = "0x60007A8")]
	public NativeArray<T> AsDeferredJobArray() { }

	[Address(RVA = "0xD6FFF0", Offset = "0xD6F3F0", Length = "0x91")]
	[Token(Token = "0x60007B5")]
	public ReadOnly<T> AsParallelReader() { }

	[Address(RVA = "0xD70090", Offset = "0xD6F490", Length = "0x24")]
	[Token(Token = "0x60007B6")]
	public ParallelWriter<T> AsParallelWriter() { }

	[Address(RVA = "0xD6FFF0", Offset = "0xD6F3F0", Length = "0x91")]
	[Token(Token = "0x60007B4")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0xD700C0", Offset = "0xD6F4C0", Length = "0x8A")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60007BB")]
	private static void CheckArgPositive(int value) { }

	[Address(RVA = "0xD70150", Offset = "0xD6F550", Length = "0x190")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60007BC")]
	private void CheckHandleMatches(AllocatorHandle handle) { }

	[Address(RVA = "0xD702F0", Offset = "0xD6F6F0", Length = "0x116")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60007BA")]
	private static void CheckIndexInRange(int value, int length) { }

	[Address(RVA = "0xD70410", Offset = "0xD6F810", Length = "0x6F")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60007B7")]
	private static void CheckInitialCapacity(int initialCapacity) { }

	[Address(RVA = "0xD70480", Offset = "0xD6F880", Length = "0xA2")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60007B9")]
	private static void CheckSufficientCapacity(int capacity, int length) { }

	[Address(RVA = "0xD70530", Offset = "0xD6F930", Length = "0xA2")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x60007B8")]
	private static void CheckTotalSize(int initialCapacity, long totalSize) { }

	[Address(RVA = "0xD705E0", Offset = "0xD6F9E0", Length = "0x39")]
	[Token(Token = "0x60007A5")]
	public override void Clear() { }

	[Address(RVA = "0xD70E30", Offset = "0xD70230", Length = "0x6E")]
	[Token(Token = "0x60007AC")]
	public void CopyFrom(in NativeList<T>& other) { }

	[Address(RVA = "0xD70CF0", Offset = "0xD700F0", Length = "0x48")]
	[Token(Token = "0x60007AB")]
	public void CopyFrom(in UnsafeList<T>& other) { }

	[Address(RVA = "0xD709A0", Offset = "0xD6FDA0", Length = "0x48")]
	[Token(Token = "0x60007AA")]
	public void CopyFrom(in NativeArray<T>& other) { }

	[Address(RVA = "0xD71260", Offset = "0xD70660", Length = "0x9C")]
	[Token(Token = "0x60007A4")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xD70FA0", Offset = "0xD703A0", Length = "0x72")]
	[Token(Token = "0x60007A2")]
	public override void Dispose() { }

	[Address(RVA = "0x69EB90", Offset = "0x69DF90", Length = "0xAD")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	[Token(Token = "0x60007A3")]
	internal void Dispose(ref U allocator) { }

	[Address(RVA = "0xD71CC0", Offset = "0xD710C0", Length = "0x34")]
	[Token(Token = "0x600078D")]
	public override T ElementAt(int index) { }

	[Address(RVA = "0xD75450", Offset = "0xD74850", Length = "0x24")]
	[IsReadOnly]
	[Token(Token = "0x6000790")]
	public override int get_Capacity() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x60007A1")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xD75480", Offset = "0xD74880", Length = "0x3C")]
	[IsReadOnly]
	[Token(Token = "0x60007A0")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0xD755B0", Offset = "0xD749B0", Length = "0x8C")]
	[Token(Token = "0x600078B")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xD757D0", Offset = "0xD74BD0", Length = "0x24")]
	[IsReadOnly]
	[Token(Token = "0x600078E")]
	public override int get_Length() { }

	[Address(RVA = "0xD72060", Offset = "0xD71460", Length = "0x138")]
	[Token(Token = "0x60007AD")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000792")]
	public UnsafeList<T>* GetUnsafeList() { }

	[Address(RVA = "0x69ED00", Offset = "0x69E100", Length = "0x140")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	[Token(Token = "0x6000789")]
	internal void Initialize(int initialCapacity, ref U allocator) { }

	[Address(RVA = "0xD72C50", Offset = "0xD72050", Length = "0x7D")]
	[Token(Token = "0x600079B")]
	public void InsertRange(int index, int count) { }

	[Address(RVA = "0xD72830", Offset = "0xD71C30", Length = "0x56")]
	[Token(Token = "0x600079A")]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[Address(RVA = "0x69FEE0", Offset = "0x69F2E0", Length = "0x5B")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	[Token(Token = "0x600078A")]
	internal static NativeList<T> New(int initialCapacity, ref U allocator) { }

	[Address(RVA = "0xD75800", Offset = "0xD74C00", Length = "0xC1")]
	[Obsolete("Implicit cast from `NativeList<T>` to `NativeArray<T>` has been deprecated; Use '.AsArray()' method to do explicit cast instead.", False)]
	[Token(Token = "0x60007A6")]
	public static NativeArray<T> op_Implicit(NativeList<T> nativeList) { }

	[Address(RVA = "0xD730C0", Offset = "0xD724C0", Length = "0x46")]
	[Token(Token = "0x600079E")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0xD72F80", Offset = "0xD72380", Length = "0x46")]
	[Token(Token = "0x600079C")]
	public void RemoveAtSwapBack(int index) { }

	[Address(RVA = "0xD73670", Offset = "0xD72A70", Length = "0x56")]
	[Token(Token = "0x600079F")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0xD734F0", Offset = "0xD728F0", Length = "0x56")]
	[Token(Token = "0x600079D")]
	public void RemoveRangeSwapBack(int index, int count) { }

	[Address(RVA = "0xD73D50", Offset = "0xD73150", Length = "0x53")]
	[Token(Token = "0x60007B0")]
	public void Resize(int length, NativeArrayOptions options) { }

	[Address(RVA = "0xD73930", Offset = "0xD72D30", Length = "0x6C")]
	[Token(Token = "0x60007B1")]
	public void ResizeUninitialized(int length) { }

	[Address(RVA = "0xD75A10", Offset = "0xD74E10", Length = "0x43")]
	[Token(Token = "0x6000791")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0xD75D30", Offset = "0xD75130", Length = "0x89")]
	[Token(Token = "0x600078C")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0xD75E60", Offset = "0xD75260", Length = "0x49")]
	[Token(Token = "0x600078F")]
	public override void set_Length(int value) { }

	[Address(RVA = "0xD74060", Offset = "0xD73460", Length = "0x46")]
	[Token(Token = "0x60007B2")]
	public void SetCapacity(int capacity) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x60007AF")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x60007AE")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xD74650", Offset = "0xD73A50", Length = "0x136")]
	[Token(Token = "0x60007A9")]
	public NativeArray<T> ToArray(AllocatorHandle allocator) { }

	[Address(RVA = "0xD74C10", Offset = "0xD74010", Length = "0x39")]
	[Token(Token = "0x60007B3")]
	public void TrimExcess() { }

}

