namespace System;

[DefaultMember("Item")]
[IsReadOnly]
[Token(Token = "0x20000B5")]
public struct ArraySegment : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Token(Token = "0x20000B6")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000284")]
		private readonly T[] _array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000285")]
		private readonly int _start; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000286")]
		private readonly int _end; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000287")]
		private int _current; //Field offset: 0x0

		[Token(Token = "0x17000058")]
		public override T Current
		{
			[Address(RVA = "0x1964150", Offset = "0x1963550", Length = "0x4E")]
			[Token(Token = "0x6000410")]
			 get { } //Length: 78
		}

		[Token(Token = "0x17000059")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19627F0", Offset = "0x1961BF0", Length = "0x9A")]
			[Token(Token = "0x6000411")]
			private get { } //Length: 154
		}

		[Address(RVA = "0x1962D50", Offset = "0x1962150", Length = "0xF8")]
		[Token(Token = "0x600040E")]
		internal Enumerator(ArraySegment<T> arraySegment) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000413")]
		public override void Dispose() { }

		[Address(RVA = "0x1964150", Offset = "0x1963550", Length = "0x4E")]
		[Token(Token = "0x6000410")]
		public override T get_Current() { }

		[Address(RVA = "0x195E060", Offset = "0x195D460", Length = "0x1A")]
		[Token(Token = "0x600040F")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19627F0", Offset = "0x1961BF0", Length = "0x9A")]
		[Token(Token = "0x6000411")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x19609B0", Offset = "0x195FDB0", Length = "0x9")]
		[Token(Token = "0x6000412")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x4000280")]
	private static readonly ArraySegment<T> <Empty>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000281")]
	private readonly T[] _array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000282")]
	private readonly int _offset; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000283")]
	private readonly int _count; //Field offset: 0x0

	[Token(Token = "0x17000052")]
	public T[] Array
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60003F7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000054")]
	public override int Count
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x60003F9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000051")]
	public static ArraySegment<T> Empty
	{
		[Address(RVA = "0xB49B80", Offset = "0xB48F80", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60003F4")]
		 get { } //Length: 158
	}

	[Token(Token = "0x17000053")]
	public int Offset
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60003F8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000057")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000405")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000055")]
	private override T System.Collections.Generic.IList<T>.Item
	{
		[Address(RVA = "0xB493D0", Offset = "0xB487D0", Length = "0xC2")]
		[Token(Token = "0x60003FF")]
		private get { } //Length: 194
		[Address(RVA = "0xB49570", Offset = "0xB48970", Length = "0xD0")]
		[Token(Token = "0x6000400")]
		private set { } //Length: 208
	}

	[Token(Token = "0x17000056")]
	private override T System.Collections.Generic.IReadOnlyList<T>.Item
	{
		[Address(RVA = "0xB493D0", Offset = "0xB487D0", Length = "0xC2")]
		[Token(Token = "0x6000404")]
		private get { } //Length: 194
	}

	[Address(RVA = "0xB49960", Offset = "0xB48D60", Length = "0x14E")]
	[Token(Token = "0x600040D")]
	private static ArraySegment`1() { }

	[Address(RVA = "0xB49B20", Offset = "0xB48F20", Length = "0x59")]
	[Token(Token = "0x60003F5")]
	public ArraySegment`1(T[] array) { }

	[Address(RVA = "0xB49AB0", Offset = "0xB48EB0", Length = "0x6F")]
	[Token(Token = "0x60003F6")]
	public ArraySegment`1(T[] array, int offset, int count) { }

	[Address(RVA = "0xB48000", Offset = "0xB47400", Length = "0xBC")]
	[Token(Token = "0x60003FC")]
	public override void CopyTo(T[] destination, int destinationIndex) { }

	[Address(RVA = "0xB481B0", Offset = "0xB475B0", Length = "0x1D")]
	[Token(Token = "0x60003FE")]
	public bool Equals(ArraySegment<T> obj) { }

	[Address(RVA = "0xB481D0", Offset = "0xB475D0", Length = "0x144")]
	[Token(Token = "0x60003FD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60003F7")]
	public T[] get_Array() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x60003F9")]
	public override int get_Count() { }

	[Address(RVA = "0xB49B80", Offset = "0xB48F80", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60003F4")]
	public static ArraySegment<T> get_Empty() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60003F8")]
	public int get_Offset() { }

	[Address(RVA = "0xB485C0", Offset = "0xB479C0", Length = "0xDD")]
	[Token(Token = "0x60003FA")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xB486A0", Offset = "0xB47AA0", Length = "0x9C")]
	[Token(Token = "0x60003FB")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xB48880", Offset = "0xB47C80", Length = "0x7")]
	[Token(Token = "0x6000406")]
	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	[Address(RVA = "0xB48880", Offset = "0xB47C80", Length = "0x7")]
	[Token(Token = "0x6000407")]
	private override void System.Collections.Generic.ICollection<T>.Clear() { }

	[Address(RVA = "0xB48890", Offset = "0xB47C90", Length = "0xEA")]
	[Token(Token = "0x6000408")]
	private override bool System.Collections.Generic.ICollection<T>.Contains(T item) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000405")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xB48C70", Offset = "0xB48070", Length = "0x12")]
	[Token(Token = "0x6000409")]
	private override bool System.Collections.Generic.ICollection<T>.Remove(T item) { }

	[Address(RVA = "0xB48C90", Offset = "0xB48090", Length = "0xC7")]
	[Token(Token = "0x600040A")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xB493D0", Offset = "0xB487D0", Length = "0xC2")]
	[Token(Token = "0x60003FF")]
	private override T System.Collections.Generic.IList<T>.get_Item(int index) { }

	[Address(RVA = "0xB48E60", Offset = "0xB48260", Length = "0xF0")]
	[Token(Token = "0x6000401")]
	private override int System.Collections.Generic.IList<T>.IndexOf(T item) { }

	[Address(RVA = "0xB48880", Offset = "0xB47C80", Length = "0x7")]
	[Token(Token = "0x6000402")]
	private override void System.Collections.Generic.IList<T>.Insert(int index, T item) { }

	[Address(RVA = "0xB48880", Offset = "0xB47C80", Length = "0x7")]
	[Token(Token = "0x6000403")]
	private override void System.Collections.Generic.IList<T>.RemoveAt(int index) { }

	[Address(RVA = "0xB49570", Offset = "0xB48970", Length = "0xD0")]
	[Token(Token = "0x6000400")]
	private override void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }

	[Address(RVA = "0xB493D0", Offset = "0xB487D0", Length = "0xC2")]
	[Token(Token = "0x6000404")]
	private override T System.Collections.Generic.IReadOnlyList<T>.get_Item(int index) { }

	[Address(RVA = "0xB48C90", Offset = "0xB48090", Length = "0xC7")]
	[Token(Token = "0x600040B")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xB49940", Offset = "0xB48D40", Length = "0x13")]
	[Token(Token = "0x600040C")]
	private void ThrowInvalidOperationIfDefault() { }

}

