namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeListTDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x2000115")]
public struct UnsafeList : INativeDisposable, IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable
{
	[Token(Token = "0x2000119")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D1")]
		internal T* m_Ptr; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D2")]
		internal int m_Length; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D3")]
		internal int m_Index; //Field offset: 0x0

		[Token(Token = "0x17000163")]
		public override T Current
		{
			[Address(RVA = "0x1963770", Offset = "0x1962B70", Length = "0x5F")]
			[Token(Token = "0x6000BE9")]
			 get { } //Length: 95
		}

		[Token(Token = "0x17000164")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1961600", Offset = "0x1960A00", Length = "0xCA")]
			[Token(Token = "0x6000BEA")]
			private get { } //Length: 202
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000BE6")]
		public override void Dispose() { }

		[Address(RVA = "0x1963770", Offset = "0x1962B70", Length = "0x5F")]
		[Token(Token = "0x6000BE9")]
		public override T get_Current() { }

		[Address(RVA = "0x195CA10", Offset = "0x195BE10", Length = "0xF")]
		[Token(Token = "0x6000BE7")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1957850", Offset = "0x1956C50", Length = "0x8")]
		[Token(Token = "0x6000BE8")]
		public override void Reset() { }

		[Address(RVA = "0x1961600", Offset = "0x1960A00", Length = "0xCA")]
		[Token(Token = "0x6000BEA")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x2000117")]
	internal struct ParallelReader
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40004CE")]
		public readonly T* Ptr; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004CF")]
		public readonly int Length; //Field offset: 0x0

		[Address(RVA = "0xAEE300", Offset = "0xAED700", Length = "0x8")]
		[Token(Token = "0x6000BE0")]
		internal ParallelReader(T* ptr, int length) { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x2000118")]
	internal struct ParallelWriter
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40004D0")]
		public UnsafeList<T>* ListData; //Field offset: 0x0

		[Token(Token = "0x17000162")]
		public Void* Ptr
		{
			[Address(RVA = "0xE1C7F0", Offset = "0xE1BBF0", Length = "0xAB")]
			[IsReadOnly]
			[Token(Token = "0x6000BE1")]
			 get { } //Length: 171
		}

		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[Token(Token = "0x6000BE2")]
		internal ParallelWriter(UnsafeList<T>* listData) { }

		[Address(RVA = "0xE192B0", Offset = "0xE186B0", Length = "0xBB")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000BE3")]
		public void AddNoResize(T value) { }

		[Address(RVA = "0xE1B230", Offset = "0xE1A630", Length = "0x66")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000BE4")]
		public void AddRangeNoResize(Void* ptr, int count) { }

		[Address(RVA = "0xE1A000", Offset = "0xE19400", Length = "0x9A")]
		[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
		[Token(Token = "0x6000BE5")]
		public void AddRangeNoResize(UnsafeList<T> list) { }

		[Address(RVA = "0xE1C7F0", Offset = "0xE1BBF0", Length = "0xAB")]
		[IsReadOnly]
		[Token(Token = "0x6000BE1")]
		public Void* get_Ptr() { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x2000116")]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40004CC")]
		public readonly T* Ptr; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004CD")]
		public readonly int Length; //Field offset: 0x0

		[Token(Token = "0x17000160")]
		public bool IsCreated
		{
			[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
			[IsReadOnly]
			[Token(Token = "0x6000BDA")]
			 get { } //Length: 8
		}

		[Token(Token = "0x17000161")]
		public bool IsEmpty
		{
			[Address(RVA = "0xE9E190", Offset = "0xE9D590", Length = "0x36")]
			[IsReadOnly]
			[Token(Token = "0x6000BDB")]
			 get { } //Length: 54
		}

		[Address(RVA = "0xAEE300", Offset = "0xAED700", Length = "0x8")]
		[Token(Token = "0x6000BDC")]
		internal ReadOnly(T* ptr, int length) { }

		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000BDA")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xE9E190", Offset = "0xE9D590", Length = "0x36")]
		[IsReadOnly]
		[Token(Token = "0x6000BDB")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xE9B620", Offset = "0xE9AA20", Length = "0x17")]
		[Token(Token = "0x6000BDD")]
		public Enumerator<T> GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000BDF")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x6000BDE")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004C7")]
	public T* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004C8")]
	public int m_length; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004C9")]
	public int m_capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004CA")]
	public AllocatorHandle Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004CB")]
	private readonly int padding; //Field offset: 0x0

	[Token(Token = "0x1700015C")]
	public override int Capacity
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000BA8")]
		 get { } //Length: 4
		[Address(RVA = "0x11B1FE0", Offset = "0x11B13E0", Length = "0x6B")]
		[Token(Token = "0x6000BA9")]
		 set { } //Length: 107
	}

	[Token(Token = "0x1700015F")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000BB4")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700015E")]
	public override bool IsEmpty
	{
		[Address(RVA = "0xE9E190", Offset = "0xE9D590", Length = "0x36")]
		[IsReadOnly]
		[Token(Token = "0x6000BB3")]
		 get { } //Length: 54
	}

	[Token(Token = "0x1700015D")]
	public override T Item
	{
		[Address(RVA = "0x11B1D80", Offset = "0x11B1180", Length = "0x5E")]
		[Token(Token = "0x6000BAA")]
		 get { } //Length: 94
		[Address(RVA = "0x11B22D0", Offset = "0x11B16D0", Length = "0x5B")]
		[Token(Token = "0x6000BAB")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700015B")]
	public override int Length
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[IsReadOnly]
		[Token(Token = "0x6000BA6")]
		 get { } //Length: 4
		[Address(RVA = "0x11B27B0", Offset = "0x11B1BB0", Length = "0x7D")]
		[Token(Token = "0x6000BA7")]
		 set { } //Length: 125
	}

	[Address(RVA = "0x11B1520", Offset = "0x11B0920", Length = "0x81")]
	[Token(Token = "0x6000BAD")]
	public UnsafeList`1(T* ptr, int length) { }

	[Address(RVA = "0x11B18E0", Offset = "0x11B0CE0", Length = "0xD4")]
	[Token(Token = "0x6000BAE")]
	public UnsafeList`1(int initialCapacity, AllocatorHandle allocator, NativeArrayOptions options = 0) { }

	[Address(RVA = "0x11A9D00", Offset = "0x11A9100", Length = "0x116")]
	[Token(Token = "0x6000BC2")]
	public void Add(in T value) { }

	[Address(RVA = "0x11A7F90", Offset = "0x11A7390", Length = "0x97")]
	[Token(Token = "0x6000BBF")]
	public void AddNoResize(T value) { }

	[Address(RVA = "0x11A93D0", Offset = "0x11A87D0", Length = "0x6B")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000BC4")]
	public void AddRange(UnsafeList<T> list) { }

	[Address(RVA = "0x11A8AA0", Offset = "0x11A7EA0", Length = "0xBB")]
	[Token(Token = "0x6000BC3")]
	public void AddRange(Void* ptr, int count) { }

	[Address(RVA = "0x11A8270", Offset = "0x11A7670", Length = "0x7A")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000BC1")]
	public void AddRangeNoResize(UnsafeList<T> list) { }

	[Address(RVA = "0x11A8600", Offset = "0x11A7A00", Length = "0x37")]
	[Token(Token = "0x6000BC0")]
	public void AddRangeNoResize(Void* ptr, int count) { }

	[Address(RVA = "0x11A9600", Offset = "0x11A8A00", Length = "0xDB")]
	[Token(Token = "0x6000BC5")]
	public void AddReplicate(in T value, int count) { }

	[Address(RVA = "0x11AA490", Offset = "0x11A9890", Length = "0x84")]
	[Token(Token = "0x6000BCD")]
	public ParallelReader<T> AsParallelReader() { }

	[Address(RVA = "0x11AA520", Offset = "0x11A9920", Length = "0x24")]
	[Token(Token = "0x6000BCE")]
	public ParallelWriter<T> AsParallelWriter() { }

	[Address(RVA = "0x11AA550", Offset = "0x11A9950", Length = "0x84")]
	[Token(Token = "0x6000BCC")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0x11AA700", Offset = "0x11A9B00", Length = "0x131")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000BD7")]
	private void CheckBeginEnd(int begin, int end) { }

	[Address(RVA = "0x11AA5E0", Offset = "0x11A99E0", Length = "0x114")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000BD6")]
	private void CheckBeginEndNoLength(int begin, int end) { }

	[Address(RVA = "0x11AA840", Offset = "0x11A9C40", Length = "0x211")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000BD5")]
	private void CheckIndexCount(int index, int count) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000BD8")]
	private void CheckNoResizeHasEnoughCapacity(int length) { }

	[Address(RVA = "0x11AAA60", Offset = "0x11A9E60", Length = "0x131")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000BD9")]
	private void CheckNoResizeHasEnoughCapacity(int length, int index) { }

	[Address(RVA = "0x11AABA0", Offset = "0x11A9FA0", Length = "0x54")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000BD4")]
	internal static void CheckNull(Void* listData) { }

	[Address(RVA = "0x11AAC00", Offset = "0x11AA000", Length = "0x8")]
	[Token(Token = "0x6000BB8")]
	public override void Clear() { }

	[Address(RVA = "0x11AB8D0", Offset = "0x11AACD0", Length = "0xB2")]
	[Token(Token = "0x6000BD0")]
	public void CopyFrom(in UnsafeList<T>& other) { }

	[Address(RVA = "0x11AAD40", Offset = "0x11AA140", Length = "0xD5")]
	[Token(Token = "0x6000BCF")]
	public void CopyFrom(in NativeArray<T>& other) { }

	[Address(RVA = "0x11AC1F0", Offset = "0x11AB5F0", Length = "0xFD")]
	[Token(Token = "0x6000BB1")]
	public static UnsafeList<T>* Create(int initialCapacity, AllocatorHandle allocator, NativeArrayOptions options = 0) { }

	[Address(RVA = "0x6A8050", Offset = "0x6A7450", Length = "0x12E")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	[Token(Token = "0x6000BAF")]
	internal static UnsafeList<T>* Create(int initialCapacity, ref U allocator, NativeArrayOptions options) { }

	[Address(RVA = "0x11ACDB0", Offset = "0x11AC1B0", Length = "0xBE")]
	[Token(Token = "0x6000BB2")]
	public static void Destroy(UnsafeList<T>* listData) { }

	[Address(RVA = "0x6E5FD0", Offset = "0x6E53D0", Length = "0xED")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	[Token(Token = "0x6000BB0")]
	internal static void Destroy(UnsafeList<T>* listData, ref U allocator) { }

	[Address(RVA = "0x11ADF20", Offset = "0x11AD320", Length = "0x10F")]
	[Token(Token = "0x6000BB7")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x6E60C0", Offset = "0x6E54C0", Length = "0x9A")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)})]
	[Token(Token = "0x6000BB5")]
	internal void Dispose(ref U allocator) { }

	[Address(RVA = "0x11AE340", Offset = "0x11AD740", Length = "0xE7")]
	[Token(Token = "0x6000BB6")]
	public override void Dispose() { }

	[Address(RVA = "0x11AE880", Offset = "0x11ADC80", Length = "0xB")]
	[Token(Token = "0x6000BAC")]
	public override T ElementAt(int index) { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000BA8")]
	public override int get_Capacity() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000BB4")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xE9E190", Offset = "0xE9D590", Length = "0x36")]
	[IsReadOnly]
	[Token(Token = "0x6000BB3")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x11B1D80", Offset = "0x11B1180", Length = "0x5E")]
	[Token(Token = "0x6000BAA")]
	public override T get_Item(int index) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[IsReadOnly]
	[Token(Token = "0x6000BA6")]
	public override int get_Length() { }

	[Address(RVA = "0x11AE8B0", Offset = "0x11ADCB0", Length = "0x4B")]
	[Token(Token = "0x6000BD1")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0x11AF120", Offset = "0x11AE520", Length = "0x57")]
	[Token(Token = "0x6000BC7")]
	public void InsertRange(int index, int count) { }

	[Address(RVA = "0x11AEE40", Offset = "0x11AE240", Length = "0xD3")]
	[Token(Token = "0x6000BC6")]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[Address(RVA = "0x11AF770", Offset = "0x11AEB70", Length = "0x94")]
	[Token(Token = "0x6000BCA")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x11AF4E0", Offset = "0x11AE8E0", Length = "0x90")]
	[Token(Token = "0x6000BC8")]
	public void RemoveAtSwapBack(int index) { }

	[Address(RVA = "0x11AFC40", Offset = "0x11AF040", Length = "0x59")]
	[Token(Token = "0x6000BCB")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0x11AF9E0", Offset = "0x11AEDE0", Length = "0x60")]
	[Token(Token = "0x6000BC9")]
	public void RemoveRangeSwapBack(int index, int count) { }

	[Address(RVA = "0x11B02B0", Offset = "0x11AF6B0", Length = "0xD2")]
	[Token(Token = "0x6000BB9")]
	public void Resize(int length, NativeArrayOptions options = 0) { }

	[Address(RVA = "0x6A8B50", Offset = "0x6A7F50", Length = "0x169")]
	[Token(Token = "0x6000BBA")]
	private void ResizeExact(ref U allocator, int newCapacity) { }

	[Address(RVA = "0x11B00A0", Offset = "0x11AF4A0", Length = "0x4B")]
	[Token(Token = "0x6000BBB")]
	private void ResizeExact(int capacity) { }

	[Address(RVA = "0x11B1FE0", Offset = "0x11B13E0", Length = "0x6B")]
	[Token(Token = "0x6000BA9")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x11B22D0", Offset = "0x11B16D0", Length = "0x5B")]
	[Token(Token = "0x6000BAB")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0x11B27B0", Offset = "0x11B1BB0", Length = "0x7D")]
	[Token(Token = "0x6000BA7")]
	public override void set_Length(int value) { }

	[Address(RVA = "0x11B09C0", Offset = "0x11AFDC0", Length = "0x4B")]
	[Token(Token = "0x6000BBD")]
	public void SetCapacity(int capacity) { }

	[Address(RVA = "0x6A95E0", Offset = "0x6A89E0", Length = "0x9F")]
	[Token(Token = "0x6000BBC")]
	private void SetCapacity(ref U allocator, int capacity) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000BD3")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000BD2")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x11B0DD0", Offset = "0x11B01D0", Length = "0x96")]
	[Token(Token = "0x6000BBE")]
	public void TrimExcess() { }

}

