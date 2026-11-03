namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafePtrListDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x200011C")]
public struct UnsafePtrList : INativeDisposable, IDisposable, IEnumerable<IntPtr>, IEnumerable
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x200011E")]
	internal struct ParallelReader
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40004DC")]
		public readonly T** Ptr; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004DD")]
		public readonly int Length; //Field offset: 0x0

		[Address(RVA = "0xAEE300", Offset = "0xAED700", Length = "0x8")]
		[Token(Token = "0x6000C20")]
		internal ParallelReader(T** ptr, int length) { }

		[Address(RVA = "0xE189E0", Offset = "0xE17DE0", Length = "0x83")]
		[Token(Token = "0x6000C22")]
		public bool Contains(Void* ptr) { }

		[Address(RVA = "0xE18A70", Offset = "0xE17E70", Length = "0x32")]
		[Token(Token = "0x6000C21")]
		public int IndexOf(Void* ptr) { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x200011F")]
	internal struct ParallelWriter
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40004DE")]
		public readonly T** Ptr; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40004DF")]
		public UnsafeList<IntPtr>* ListData; //Field offset: 0x0

		[Address(RVA = "0xE1C7E0", Offset = "0xE1BBE0", Length = "0x8")]
		[Token(Token = "0x6000C23")]
		internal ParallelWriter(T** ptr, UnsafeList<IntPtr>* listData) { }

		[Address(RVA = "0xE190A0", Offset = "0xE184A0", Length = "0x83")]
		[Token(Token = "0x6000C24")]
		public void AddNoResize(T* value) { }

		[Address(RVA = "0xE1AC90", Offset = "0xE1A090", Length = "0x59")]
		[Token(Token = "0x6000C25")]
		public void AddRangeNoResize(T** ptr, int count) { }

		[Address(RVA = "0xE1B850", Offset = "0xE1AC50", Length = "0xB9")]
		[Token(Token = "0x6000C26")]
		public void AddRangeNoResize(UnsafePtrList<T> list) { }

	}

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x200011D")]
	internal struct ReadOnly
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40004DA")]
		public readonly T** Ptr; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004DB")]
		public readonly int Length; //Field offset: 0x0

		[Token(Token = "0x1700016B")]
		public bool IsCreated
		{
			[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
			[IsReadOnly]
			[Token(Token = "0x6000C1B")]
			 get { } //Length: 8
		}

		[Token(Token = "0x1700016C")]
		public bool IsEmpty
		{
			[Address(RVA = "0xEA4630", Offset = "0xEA3A30", Length = "0x8A")]
			[IsReadOnly]
			[Token(Token = "0x6000C1C")]
			 get { } //Length: 138
		}

		[Address(RVA = "0xAEE300", Offset = "0xAED700", Length = "0x8")]
		[Token(Token = "0x6000C1D")]
		internal ReadOnly(T** ptr, int length) { }

		[Address(RVA = "0xE9EAF0", Offset = "0xE9DEF0", Length = "0x83")]
		[Token(Token = "0x6000C1F")]
		public bool Contains(Void* ptr) { }

		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000C1B")]
		public bool get_IsCreated() { }

		[Address(RVA = "0xEA4630", Offset = "0xEA3A30", Length = "0x8A")]
		[IsReadOnly]
		[Token(Token = "0x6000C1C")]
		public bool get_IsEmpty() { }

		[Address(RVA = "0xE18A70", Offset = "0xE17E70", Length = "0x32")]
		[Token(Token = "0x6000C1E")]
		public int IndexOf(Void* ptr) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004D5")]
	public readonly T** Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004D6")]
	public readonly int m_length; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004D7")]
	public readonly int m_capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004D8")]
	public readonly AllocatorHandle Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004D9")]
	private readonly int padding; //Field offset: 0x0

	[Token(Token = "0x17000167")]
	public int Capacity
	{
		[Address(RVA = "0x11DCE70", Offset = "0x11DC270", Length = "0xC0")]
		[IsReadOnly]
		[Token(Token = "0x6000BF6")]
		 get { } //Length: 192
		[Address(RVA = "0x11DD0C0", Offset = "0x11DC4C0", Length = "0xA5")]
		[Token(Token = "0x6000BF7")]
		 set { } //Length: 165
	}

	[Token(Token = "0x1700016A")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000C01")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000169")]
	public bool IsEmpty
	{
		[Address(RVA = "0x11DCF30", Offset = "0x11DC330", Length = "0xD0")]
		[IsReadOnly]
		[Token(Token = "0x6000C00")]
		 get { } //Length: 208
	}

	[Token(Token = "0x17000168")]
	public T* Item
	{
		[Address(RVA = "0x11BD910", Offset = "0x11BCD10", Length = "0xB")]
		[Token(Token = "0x6000BF8")]
		 get { } //Length: 11
		[Address(RVA = "0x11BDED0", Offset = "0x11BD2D0", Length = "0xB")]
		[Token(Token = "0x6000BF9")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000166")]
	public int Length
	{
		[Address(RVA = "0x11DD000", Offset = "0x11DC400", Length = "0xBB")]
		[IsReadOnly]
		[Token(Token = "0x6000BF4")]
		 get { } //Length: 187
		[Address(RVA = "0x11DD170", Offset = "0x11DC570", Length = "0xA5")]
		[Token(Token = "0x6000BF5")]
		 set { } //Length: 165
	}

	[Address(RVA = "0x11DCDE0", Offset = "0x11DC1E0", Length = "0x81")]
	[Token(Token = "0x6000BFB")]
	public UnsafePtrList`1(T** ptr, int length) { }

	[Address(RVA = "0x11DCCA0", Offset = "0x11DC0A0", Length = "0x134")]
	[Token(Token = "0x6000BFC")]
	public UnsafePtrList`1(int initialCapacity, AllocatorHandle allocator, NativeArrayOptions options = 0) { }

	[Address(RVA = "0x11DBB60", Offset = "0x11DAF60", Length = "0xA7")]
	[Token(Token = "0x6000C0D")]
	public void Add(in IntPtr value) { }

	[Address(RVA = "0x11DBC10", Offset = "0x11DB010", Length = "0xFA")]
	[Token(Token = "0x6000C0E")]
	public void Add(Void* value) { }

	[Address(RVA = "0x11DB700", Offset = "0x11DAB00", Length = "0xCD")]
	[Token(Token = "0x6000C0A")]
	public void AddNoResize(Void* value) { }

	[Address(RVA = "0x11DB990", Offset = "0x11DAD90", Length = "0x108")]
	[Token(Token = "0x6000C10")]
	public void AddRange(UnsafePtrList<T> list) { }

	[Address(RVA = "0x11DBAA0", Offset = "0x11DAEA0", Length = "0xB9")]
	[Token(Token = "0x6000C0F")]
	public void AddRange(Void* ptr, int length) { }

	[Address(RVA = "0x11DB7D0", Offset = "0x11DABD0", Length = "0xB9")]
	[Token(Token = "0x6000C0B")]
	public void AddRangeNoResize(Void** ptr, int count) { }

	[Address(RVA = "0x11DB890", Offset = "0x11DAC90", Length = "0x100")]
	[Token(Token = "0x6000C0C")]
	public void AddRangeNoResize(UnsafePtrList<T> list) { }

	[Address(RVA = "0x11DBD10", Offset = "0x11DB110", Length = "0xC6")]
	[Token(Token = "0x6000C19")]
	public ParallelReader<T> AsParallelReader() { }

	[Address(RVA = "0x11DBDE0", Offset = "0x11DB1E0", Length = "0x62")]
	[Token(Token = "0x6000C1A")]
	public ParallelWriter<T> AsParallelWriter() { }

	[Address(RVA = "0x11DBE50", Offset = "0x11DB250", Length = "0xC6")]
	[Token(Token = "0x6000C18")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0x11DBF20", Offset = "0x11DB320", Length = "0x97")]
	[Token(Token = "0x6000C04")]
	public void Clear() { }

	[Address(RVA = "0x11DBFC0", Offset = "0x11DB3C0", Length = "0x89")]
	[Token(Token = "0x6000C09")]
	public bool Contains(Void* ptr) { }

	[Address(RVA = "0x11DC050", Offset = "0x11DB450", Length = "0x158")]
	[Token(Token = "0x6000BFD")]
	public static UnsafePtrList<T>* Create(T** ptr, int length) { }

	[Address(RVA = "0x11DC1B0", Offset = "0x11DB5B0", Length = "0x11D")]
	[Token(Token = "0x6000BFE")]
	public static UnsafePtrList<T>* Create(int initialCapacity, AllocatorHandle allocator, NativeArrayOptions options = 0) { }

	[Address(RVA = "0x11DC2D0", Offset = "0x11DB6D0", Length = "0x1E1")]
	[Token(Token = "0x6000BFF")]
	public static void Destroy(UnsafePtrList<T>* listData) { }

	[Address(RVA = "0x11DC5A0", Offset = "0x11DB9A0", Length = "0x97")]
	[Token(Token = "0x6000C02")]
	public override void Dispose() { }

	[Address(RVA = "0x11DC4C0", Offset = "0x11DB8C0", Length = "0xD2")]
	[Token(Token = "0x6000C03")]
	public override JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0x11B9B90", Offset = "0x11B8F90", Length = "0xB")]
	[Token(Token = "0x6000BFA")]
	public T* ElementAt(int index) { }

	[Address(RVA = "0x11DCE70", Offset = "0x11DC270", Length = "0xC0")]
	[IsReadOnly]
	[Token(Token = "0x6000BF6")]
	public int get_Capacity() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000C01")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x11DCF30", Offset = "0x11DC330", Length = "0xD0")]
	[IsReadOnly]
	[Token(Token = "0x6000C00")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x11BD910", Offset = "0x11BCD10", Length = "0xB")]
	[Token(Token = "0x6000BF8")]
	public T* get_Item(int index) { }

	[Address(RVA = "0x11DD000", Offset = "0x11DC400", Length = "0xBB")]
	[IsReadOnly]
	[Token(Token = "0x6000BF4")]
	public int get_Length() { }

	[Address(RVA = "0x11DC640", Offset = "0x11DBA40", Length = "0xB0")]
	[Token(Token = "0x6000C08")]
	public int IndexOf(Void* ptr) { }

	[Address(RVA = "0x11DC6F0", Offset = "0x11DBAF0", Length = "0xB7")]
	[Token(Token = "0x6000C11")]
	public void InsertRangeWithBeginEnd(int begin, int end) { }

	[Address(RVA = "0x11DC860", Offset = "0x11DBC60", Length = "0xA5")]
	[Token(Token = "0x6000C14")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x11DC7B0", Offset = "0x11DBBB0", Length = "0xA5")]
	[Token(Token = "0x6000C12")]
	public void RemoveAtSwapBack(int index) { }

	[Address(RVA = "0x11DC9D0", Offset = "0x11DBDD0", Length = "0xB7")]
	[Token(Token = "0x6000C15")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0x11DC910", Offset = "0x11DBD10", Length = "0xB7")]
	[Token(Token = "0x6000C13")]
	public void RemoveRangeSwapBack(int index, int count) { }

	[Address(RVA = "0x11DCA90", Offset = "0x11DBE90", Length = "0xB7")]
	[Token(Token = "0x6000C05")]
	public void Resize(int length, NativeArrayOptions options = 0) { }

	[Address(RVA = "0x11DD0C0", Offset = "0x11DC4C0", Length = "0xA5")]
	[Token(Token = "0x6000BF7")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0x11BDED0", Offset = "0x11BD2D0", Length = "0xB")]
	[Token(Token = "0x6000BF9")]
	public void set_Item(int index, T* value) { }

	[Address(RVA = "0x11DD170", Offset = "0x11DC570", Length = "0xA5")]
	[Token(Token = "0x6000BF5")]
	public void set_Length(int value) { }

	[Address(RVA = "0x11DCB50", Offset = "0x11DBF50", Length = "0xA5")]
	[Token(Token = "0x6000C06")]
	public void SetCapacity(int capacity) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000C17")]
	private override IEnumerator<IntPtr> System.Collections.Generic.IEnumerable<System.IntPtr>.GetEnumerator() { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000C16")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x11DCC00", Offset = "0x11DC000", Length = "0x97")]
	[Token(Token = "0x6000C07")]
	public void TrimExcess() { }

}

