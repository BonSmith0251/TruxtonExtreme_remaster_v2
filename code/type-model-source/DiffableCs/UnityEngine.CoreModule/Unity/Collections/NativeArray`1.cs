namespace Unity.Collections;

[DebuggerDisplay("Length = {m_Length}")]
[DebuggerTypeProxy(typeof(NativeArrayDebugView`1))]
[DefaultMember("Item")]
[NativeContainer]
[NativeContainerSupportsDeallocateOnJobCompletion]
[NativeContainerSupportsDeferredConvertListToArray]
[NativeContainerSupportsMinMaxWriteRestriction]
[Token(Token = "0x2000058")]
public struct NativeArray : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray`1<T>>
{
	[ExcludeFromDocs]
	[Token(Token = "0x2000059")]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000100")]
		private NativeArray<T> m_Array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000101")]
		private int m_Index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000102")]
		private T value; //Field offset: 0x0

		[Token(Token = "0x1700001E")]
		public override T Current
		{
			[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
			[Token(Token = "0x6000112")]
			 get { } //Length: 6
		}

		[Token(Token = "0x1700001F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1961BC0", Offset = "0x1960FC0", Length = "0x5E")]
			[Token(Token = "0x6000113")]
			private get { } //Length: 94
		}

		[Address(RVA = "0x1962A30", Offset = "0x1961E30", Length = "0x13")]
		[Token(Token = "0x600010E")]
		public Enumerator(ref NativeArray<T>& array) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600010F")]
		public override void Dispose() { }

		[Address(RVA = "0x1963AC0", Offset = "0x1962EC0", Length = "0x6")]
		[Token(Token = "0x6000112")]
		public override T get_Current() { }

		[Address(RVA = "0x195D490", Offset = "0x195C890", Length = "0x62")]
		[Token(Token = "0x6000110")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195F910", Offset = "0x195ED10", Length = "0x8")]
		[Token(Token = "0x6000111")]
		public override void Reset() { }

		[Address(RVA = "0x1961BC0", Offset = "0x1960FC0", Length = "0x5E")]
		[Token(Token = "0x6000113")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(NativeArrayReadOnlyDebugView`1))]
	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[Token(Token = "0x200005A")]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[ExcludeFromDocs]
		[Token(Token = "0x200005B")]
		internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000105")]
			private ReadOnly<T> m_Array; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000106")]
			private int m_Index; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000107")]
			private T value; //Field offset: 0x0

			[Token(Token = "0x17000022")]
			public override T Current
			{
				[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
				[Token(Token = "0x6000121")]
				 get { } //Length: 4
			}

			[Token(Token = "0x17000023")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x1961BC0", Offset = "0x1960FC0", Length = "0x5E")]
				[Token(Token = "0x6000122")]
				private get { } //Length: 94
			}

			[Address(RVA = "0x1962A30", Offset = "0x1961E30", Length = "0x13")]
			[Token(Token = "0x600011D")]
			public Enumerator(in ReadOnly<T> array) { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x600011E")]
			public override void Dispose() { }

			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[Token(Token = "0x6000121")]
			public override T get_Current() { }

			[Address(RVA = "0x195D490", Offset = "0x195C890", Length = "0x62")]
			[Token(Token = "0x600011F")]
			public override bool MoveNext() { }

			[Address(RVA = "0x195F910", Offset = "0x195ED10", Length = "0x8")]
			[Token(Token = "0x6000120")]
			public override void Reset() { }

			[Address(RVA = "0x1961BC0", Offset = "0x1960FC0", Length = "0x5E")]
			[Token(Token = "0x6000122")]
			private override object System.Collections.IEnumerator.get_Current() { }

		}

		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4000103")]
		internal Void* m_Buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000104")]
		internal int m_Length; //Field offset: 0x0

		[Token(Token = "0x17000021")]
		public T Item
		{
			[Address(RVA = "0xD18AA0", Offset = "0xD17EA0", Length = "0x30")]
			[Token(Token = "0x6000116")]
			 get { } //Length: 48
		}

		[Token(Token = "0x17000020")]
		public int Length
		{
			[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
			[Token(Token = "0x6000115")]
			 get { } //Length: 6
		}

		[Address(RVA = "0xAEE300", Offset = "0xAED700", Length = "0x8")]
		[Token(Token = "0x6000114")]
		internal ReadOnly(Void* buffer, int length) { }

		[Address(RVA = "0xD12960", Offset = "0xD11D60", Length = "0x67")]
		[IsReadOnly]
		[Token(Token = "0x600011B")]
		public ReadOnlySpan<T> AsReadOnlySpan() { }

		[Address(RVA = "0xD18AA0", Offset = "0xD17EA0", Length = "0x30")]
		[Token(Token = "0x6000116")]
		public T get_Item(int index) { }

		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x6000115")]
		public int get_Length() { }

		[Address(RVA = "0xE9B5A0", Offset = "0xE9A9A0", Length = "0x74")]
		[Token(Token = "0x6000118")]
		public Enumerator<T> GetEnumerator() { }

		[Address(RVA = "0xE9E340", Offset = "0xE9D740", Length = "0x8A")]
		[Token(Token = "0x600011C")]
		public static ReadOnlySpan<T> op_Implicit(in ReadOnly<T> source) { }

		[Address(RVA = "0xE9C710", Offset = "0xE9BB10", Length = "0xB7")]
		[Token(Token = "0x6000119")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0xE9C710", Offset = "0xE9BB10", Length = "0xB7")]
		[Token(Token = "0x600011A")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xE9DD60", Offset = "0xE9D160", Length = "0x31")]
		[Token(Token = "0x6000117")]
		public T UnsafeElementAt(int index) { }

	}

	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40000FD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ContentLoadModule", "UnityEngine.TilemapModule"})]
	internal Void* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000FE")]
	internal int m_Length; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000FF")]
	internal Allocator m_AllocatorLabel; //Field offset: 0x0

	[Token(Token = "0x1700001D")]
	public bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[Token(Token = "0x60000ED")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700001C")]
	public T Item
	{
		[Address(RVA = "0xD18AA0", Offset = "0xD17EA0", Length = "0x30")]
		[Token(Token = "0x60000EB")]
		 get { } //Length: 48
		[Address(RVA = "0xD18DF0", Offset = "0xD181F0", Length = "0x3D")]
		[Token(Token = "0x60000EC")]
		[WriteAccessRequired]
		 set { } //Length: 61
	}

	[Token(Token = "0x1700001B")]
	public int Length
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x60000EA")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xD18610", Offset = "0xD17A10", Length = "0xB6")]
	[Token(Token = "0x60000E5")]
	public NativeArray`1(int length, Allocator allocator, NativeArrayOptions options = 1) { }

	[Address(RVA = "0xD18100", Offset = "0xD17500", Length = "0xB6")]
	[Token(Token = "0x60000E6")]
	public NativeArray`1(int length, MemoryLabel label, NativeArrayOptions options = 1) { }

	[Address(RVA = "0xD18280", Offset = "0xD17680", Length = "0xC1")]
	[Token(Token = "0x60000E7")]
	public NativeArray`1(T[] array, Allocator allocator) { }

	[Address(RVA = "0xD188C0", Offset = "0xD17CC0", Length = "0x128")]
	[Token(Token = "0x60000E8")]
	public NativeArray`1(NativeArray<T> array, Allocator allocator) { }

	[Address(RVA = "0xD12520", Offset = "0xD11920", Length = "0xB0")]
	[Token(Token = "0x60000E9")]
	private static void Allocate(int length, Allocator allocator, MemoryLabel label, out NativeArray<T>& array) { }

	[Address(RVA = "0xD129D0", Offset = "0xD11DD0", Length = "0x71")]
	[Token(Token = "0x6000109")]
	public ReadOnly<T> AsReadOnly() { }

	[Address(RVA = "0xD12960", Offset = "0xD11D60", Length = "0x67")]
	[IsReadOnly]
	[Token(Token = "0x600010B")]
	public ReadOnlySpan<T> AsReadOnlySpan() { }

	[Address(RVA = "0xD12960", Offset = "0xD11D60", Length = "0x67")]
	[IsReadOnly]
	[Token(Token = "0x600010A")]
	[WriteAccessRequired]
	public Span<T> AsSpan() { }

	[Address(RVA = "0xD14510", Offset = "0xD13910", Length = "0x76")]
	[Token(Token = "0x6000101")]
	public static void Copy(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }

	[Address(RVA = "0xD140A0", Offset = "0xD134A0", Length = "0xCF")]
	[Token(Token = "0x6000100")]
	public static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	[Address(RVA = "0xD13E40", Offset = "0xD13240", Length = "0x61")]
	[Token(Token = "0x60000FF")]
	public static void Copy(NativeArray<T> src, T[] dst, int length) { }

	[Address(RVA = "0xD148F0", Offset = "0xD13CF0", Length = "0xA2")]
	[Token(Token = "0x60000FE")]
	public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length) { }

	[Address(RVA = "0xD14220", Offset = "0xD13620", Length = "0x61")]
	[Token(Token = "0x60000FD")]
	public static void Copy(NativeArray<T> src, T[] dst) { }

	[Address(RVA = "0xD14290", Offset = "0xD13690", Length = "0xF7")]
	[Token(Token = "0x60000FC")]
	public static void Copy(T[] src, NativeArray<T> dst) { }

	[Address(RVA = "0xD14CA0", Offset = "0xD140A0", Length = "0xA2")]
	[Token(Token = "0x60000FB")]
	public static void Copy(NativeArray<T> src, NativeArray<T> dst) { }

	[Address(RVA = "0xD12C20", Offset = "0xD12020", Length = "0x44")]
	[Token(Token = "0x60000F0")]
	[WriteAccessRequired]
	public void CopyFrom(T[] array) { }

	[Address(RVA = "0xD12B60", Offset = "0xD11F60", Length = "0xBF")]
	[Token(Token = "0x60000F1")]
	[WriteAccessRequired]
	public void CopyFrom(NativeArray<T> array) { }

	[Address(RVA = "0xD131C0", Offset = "0xD125C0", Length = "0xDE")]
	[Token(Token = "0x6000104")]
	private static void CopySafe(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }

	[Address(RVA = "0xD13370", Offset = "0xD12770", Length = "0xDB")]
	[Token(Token = "0x6000103")]
	private static void CopySafe(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	[Address(RVA = "0xD13450", Offset = "0xD12850", Length = "0xAA")]
	[Token(Token = "0x6000102")]
	private static void CopySafe(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }

	[Address(RVA = "0xD13B70", Offset = "0xD12F70", Length = "0x87")]
	[Token(Token = "0x60000F2")]
	public void CopyTo(T[] array) { }

	[Address(RVA = "0xD154D0", Offset = "0xD148D0", Length = "0xD4")]
	[Token(Token = "0x60000EE")]
	[WriteAccessRequired]
	public override void Dispose() { }

	[Address(RVA = "0xD15A30", Offset = "0xD14E30", Length = "0x117")]
	[Token(Token = "0x60000EF")]
	public JobHandle Dispose(JobHandle inputDeps) { }

	[Address(RVA = "0xD15EB0", Offset = "0xD152B0", Length = "0x1C")]
	[Token(Token = "0x60000F7")]
	public override bool Equals(NativeArray<T> other) { }

	[Address(RVA = "0xD15ED0", Offset = "0xD152D0", Length = "0xF5")]
	[Token(Token = "0x60000F8")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[Token(Token = "0x60000ED")]
	public bool get_IsCreated() { }

	[Address(RVA = "0xD18AA0", Offset = "0xD17EA0", Length = "0x30")]
	[Token(Token = "0x60000EB")]
	public T get_Item(int index) { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x60000EA")]
	public int get_Length() { }

	[Address(RVA = "0xD161C0", Offset = "0xD155C0", Length = "0x77")]
	[Token(Token = "0x60000F4")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xD163E0", Offset = "0xD157E0", Length = "0xC")]
	[Token(Token = "0x60000F9")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xD16560", Offset = "0xD15960", Length = "0xA8")]
	[Token(Token = "0x6000108")]
	public NativeArray<T> GetSubArray(int start, int length) { }

	[Address(RVA = "0x69E290", Offset = "0x69D690", Length = "0x75")]
	[Token(Token = "0x6000105")]
	private NativeArray<U> InternalReinterpret(int length) { }

	[Address(RVA = "0xD18C80", Offset = "0xD18080", Length = "0x4E")]
	[Token(Token = "0x60000FA")]
	public static bool op_Equality(NativeArray<T> left, NativeArray<T> right) { }

	[Address(RVA = "0xD18CD0", Offset = "0xD180D0", Length = "0x8D")]
	[Token(Token = "0x600010C")]
	public static Span<T> op_Implicit(in NativeArray<T>& source) { }

	[Address(RVA = "0xD18D60", Offset = "0xD18160", Length = "0x8D")]
	[Token(Token = "0x600010D")]
	public static ReadOnlySpan<T> op_Implicit(in NativeArray<T>& source) { }

	[Address(RVA = "0x69E780", Offset = "0x69DB80", Length = "0x8B")]
	[Token(Token = "0x6000106")]
	public NativeArray<U> Reinterpret() { }

	[Address(RVA = "0x69E4F0", Offset = "0x69D8F0", Length = "0x9E")]
	[Token(Token = "0x6000107")]
	public NativeArray<U> Reinterpret(int expectedTypeSize) { }

	[Address(RVA = "0xD18DF0", Offset = "0xD181F0", Length = "0x3D")]
	[Token(Token = "0x60000EC")]
	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	[Address(RVA = "0xD16990", Offset = "0xD15D90", Length = "0x9D")]
	[Token(Token = "0x60000F5")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xD16CE0", Offset = "0xD160E0", Length = "0xC0")]
	[Token(Token = "0x60000F6")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xD17130", Offset = "0xD16530", Length = "0xED")]
	[Token(Token = "0x60000F3")]
	public T[] ToArray() { }

}

