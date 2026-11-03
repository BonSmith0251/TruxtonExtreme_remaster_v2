namespace UnityEngine.InputSystem;

[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[Token(Token = "0x200007B")]
public struct InputControlList : IList<TControl>, ICollection<TControl>, IEnumerable<TControl>, IEnumerable, IReadOnlyList<TControl>, IReadOnlyCollection<TControl>, IDisposable
{
	[Token(Token = "0x200007C")]
	private struct Enumerator : IEnumerator<TControl>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D1")]
		private readonly UInt64* m_Indices; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D2")]
		private readonly int m_Count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D3")]
		private int m_Current; //Field offset: 0x0

		[Token(Token = "0x170001A0")]
		public override TControl Current
		{
			[Address(RVA = "0x1991870", Offset = "0x1990C70", Length = "0x8C")]
			[Token(Token = "0x60005F5")]
			 get { } //Length: 140
		}

		[Token(Token = "0x170001A1")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19901C0", Offset = "0x198F5C0", Length = "0x36")]
			[Token(Token = "0x60005F6")]
			private get { } //Length: 54
		}

		[Address(RVA = "0x1991100", Offset = "0x1990500", Length = "0x8F")]
		[Token(Token = "0x60005F2")]
		public Enumerator(InputControlList<TControl> list) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60005F7")]
		public override void Dispose() { }

		[Address(RVA = "0x1991870", Offset = "0x1990C70", Length = "0x8C")]
		[Token(Token = "0x60005F5")]
		public override TControl get_Current() { }

		[Address(RVA = "0x198DAA0", Offset = "0x198CEA0", Length = "0x1A")]
		[Token(Token = "0x60005F3")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1957850", Offset = "0x1956C50", Length = "0x8")]
		[Token(Token = "0x60005F4")]
		public override void Reset() { }

		[Address(RVA = "0x19901C0", Offset = "0x198F5C0", Length = "0x36")]
		[Token(Token = "0x60005F6")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x40002D0")]
	private const ulong kInvalidIndex = 18446744073709551615; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002CD")]
	private int m_Count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002CE")]
	private NativeArray<UInt64> m_Indices; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002CF")]
	private readonly Allocator m_Allocator; //Field offset: 0x0

	[Token(Token = "0x1700019D")]
	public int Capacity
	{
		[Address(RVA = "0x1CA3840", Offset = "0x1CA2C40", Length = "0x3D")]
		[Token(Token = "0x60005D3")]
		 get { } //Length: 61
		[Address(RVA = "0x1CA3970", Offset = "0x1CA2D70", Length = "0xF1")]
		[Token(Token = "0x60005D4")]
		 set { } //Length: 241
	}

	[Token(Token = "0x1700019C")]
	public override int Count
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60005D2")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700019E")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60005D5")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700019F")]
	public override TControl Item
	{
		[Address(RVA = "0x1CA3880", Offset = "0x1CA2C80", Length = "0xF0")]
		[Token(Token = "0x60005D6")]
		 get { } //Length: 240
		[Address(RVA = "0x1CA3A70", Offset = "0x1CA2E70", Length = "0xFE")]
		[Token(Token = "0x60005D7")]
		 set { } //Length: 254
	}

	[Address(RVA = "0x1CA35C0", Offset = "0x1CA29C0", Length = "0x5A")]
	[Token(Token = "0x60005D8")]
	public InputControlList`1(Allocator allocator, int initialCapacity = 0) { }

	[Address(RVA = "0x1CA3250", Offset = "0x1CA2650", Length = "0x366")]
	[Token(Token = "0x60005D9")]
	public InputControlList`1(IEnumerable<TControl> values, Allocator allocator = 4) { }

	[Address(RVA = "0x1CA3620", Offset = "0x1CA2A20", Length = "0x215")]
	[Token(Token = "0x60005DA")]
	public InputControlList`1(TControl[] values) { }

	[Address(RVA = "0x1CA2110", Offset = "0x1CA1510", Length = "0x10B")]
	[Token(Token = "0x60005DC")]
	public override void Add(TControl item) { }

	[Address(RVA = "0x1CA1CC0", Offset = "0x1CA10C0", Length = "0x44D")]
	[Token(Token = "0x60005DE")]
	public void AddRange(IEnumerable<TControl> list, int count = -1, int destinationIndex = -1) { }

	[Address(RVA = "0x69B640", Offset = "0x69AA40", Length = "0x304")]
	[Token(Token = "0x60005DD")]
	public void AddSlice(TList list, int count = -1, int destinationIndex = -1, int sourceIndex = 0) { }

	[Address(RVA = "0x1CA2220", Offset = "0x1CA1620", Length = "0x196")]
	[Token(Token = "0x60005EB")]
	internal void AppendTo(ref TControl[] array, ref int count) { }

	[Address(RVA = "0x1CA23C0", Offset = "0x1CA17C0", Length = "0x7")]
	[Token(Token = "0x60005E5")]
	public override void Clear() { }

	[Address(RVA = "0x1CA23D0", Offset = "0x1CA17D0", Length = "0x79")]
	[Token(Token = "0x60005E7")]
	public bool Contains(TControl item, int startIndex, int count = -1) { }

	[Address(RVA = "0x1CA2450", Offset = "0x1CA1850", Length = "0x80")]
	[Token(Token = "0x60005E6")]
	public override bool Contains(TControl item) { }

	[Address(RVA = "0x1CA24D0", Offset = "0x1CA18D0", Length = "0x39")]
	[Token(Token = "0x60005E1")]
	public override void CopyTo(TControl[] array, int arrayIndex) { }

	[Address(RVA = "0x1CA2510", Offset = "0x1CA1910", Length = "0x53")]
	[Token(Token = "0x60005EC")]
	public override void Dispose() { }

	[Address(RVA = "0x1CA2570", Offset = "0x1CA1970", Length = "0x158")]
	[Token(Token = "0x60005F1")]
	private static TControl FromIndex(ulong index) { }

	[Address(RVA = "0x1CA3840", Offset = "0x1CA2C40", Length = "0x3D")]
	[Token(Token = "0x60005D3")]
	public int get_Capacity() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60005D2")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60005D5")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x1CA3880", Offset = "0x1CA2C80", Length = "0xF0")]
	[Token(Token = "0x60005D6")]
	public override TControl get_Item(int index) { }

	[Address(RVA = "0x1CA26D0", Offset = "0x1CA1AD0", Length = "0xAC")]
	[Token(Token = "0x60005ED")]
	public override IEnumerator<TControl> GetEnumerator() { }

	[Address(RVA = "0x1CA2920", Offset = "0x1CA1D20", Length = "0x57")]
	[Token(Token = "0x60005E2")]
	public override int IndexOf(TControl item) { }

	[Address(RVA = "0x1CA2780", Offset = "0x1CA1B80", Length = "0x197")]
	[Token(Token = "0x60005E3")]
	public int IndexOf(TControl item, int startIndex, int count = -1) { }

	[Address(RVA = "0x1CA24D0", Offset = "0x1CA18D0", Length = "0x39")]
	[Token(Token = "0x60005E4")]
	public override void Insert(int index, TControl item) { }

	[Address(RVA = "0x1CA2A80", Offset = "0x1CA1E80", Length = "0xCA")]
	[Token(Token = "0x60005DF")]
	public override bool Remove(TControl item) { }

	[Address(RVA = "0x1CA2980", Offset = "0x1CA1D80", Length = "0xF7")]
	[Token(Token = "0x60005E0")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x1CA2B50", Offset = "0x1CA1F50", Length = "0x190")]
	[Token(Token = "0x60005DB")]
	public void Resize(int size) { }

	[Address(RVA = "0x1CA3970", Offset = "0x1CA2D70", Length = "0xF1")]
	[Token(Token = "0x60005D4")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0x1CA3A70", Offset = "0x1CA2E70", Length = "0xFE")]
	[Token(Token = "0x60005D7")]
	public override void set_Item(int index, TControl value) { }

	[Address(RVA = "0x69BB40", Offset = "0x69AF40", Length = "0x280")]
	[Token(Token = "0x60005E9")]
	public void Sort(int startIndex, int count, TCompare comparer) { }

	[Address(RVA = "0x1CA2CF0", Offset = "0x1CA20F0", Length = "0xFC")]
	[Token(Token = "0x60005E8")]
	public void SwapElements(int index1, int index2) { }

	[Address(RVA = "0x1CA2DF0", Offset = "0x1CA21F0", Length = "0x39")]
	[Token(Token = "0x60005EE")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1CA2E30", Offset = "0x1CA2230", Length = "0x22C")]
	[Token(Token = "0x60005EA")]
	public TControl[] ToArray(bool dispose = false) { }

	[Address(RVA = "0x1CA3060", Offset = "0x1CA2460", Length = "0x91")]
	[Token(Token = "0x60005F0")]
	private static ulong ToIndex(TControl control) { }

	[Address(RVA = "0x1CA3100", Offset = "0x1CA2500", Length = "0x14E")]
	[Token(Token = "0x60005EF")]
	public virtual string ToString() { }

}

