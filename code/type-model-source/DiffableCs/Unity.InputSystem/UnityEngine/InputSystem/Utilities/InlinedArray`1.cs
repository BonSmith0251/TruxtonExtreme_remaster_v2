namespace UnityEngine.InputSystem.Utilities;

[DefaultMember("Item")]
[Token(Token = "0x2000244")]
internal struct InlinedArray : IEnumerable<TValue>, IEnumerable
{
	[Token(Token = "0x2000245")]
	private struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C7E")]
		public InlinedArray<TValue> array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C7F")]
		public int index; //Field offset: 0x0

		[Token(Token = "0x170005F7")]
		public override TValue Current
		{
			[Address(RVA = "0x195BE60", Offset = "0x195B260", Length = "0x44")]
			[Token(Token = "0x6001542")]
			 get { } //Length: 68
		}

		[Token(Token = "0x170005F8")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x195AE10", Offset = "0x195A210", Length = "0xA1")]
			[Token(Token = "0x6001543")]
			private get { } //Length: 161
		}

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6001544")]
		public override void Dispose() { }

		[Address(RVA = "0x195BE60", Offset = "0x195B260", Length = "0x44")]
		[Token(Token = "0x6001542")]
		public override TValue get_Current() { }

		[Address(RVA = "0x19588B0", Offset = "0x1957CB0", Length = "0x18")]
		[Token(Token = "0x6001540")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
		[Token(Token = "0x6001541")]
		public override void Reset() { }

		[Address(RVA = "0x195AE10", Offset = "0x195A210", Length = "0xA1")]
		[Token(Token = "0x6001543")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C7B")]
	public int length; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C7C")]
	public TValue firstValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C7D")]
	public TValue[] additionalValues; //Field offset: 0x0

	[Token(Token = "0x170005F5")]
	public int Capacity
	{
		[Address(RVA = "0x1C9CBD0", Offset = "0x1C9BFD0", Length = "0x15")]
		[Token(Token = "0x6001526")]
		 get { } //Length: 21
	}

	[Token(Token = "0x170005F6")]
	public TValue Item
	{
		[Address(RVA = "0x1C9CD60", Offset = "0x1C9C160", Length = "0x8F")]
		[Token(Token = "0x600152A")]
		 get { } //Length: 143
		[Address(RVA = "0x1C9D680", Offset = "0x1C9CA80", Length = "0x8F")]
		[Token(Token = "0x600152B")]
		 set { } //Length: 143
	}

	[Address(RVA = "0x1C9A270", Offset = "0x1C99670", Length = "0x1D")]
	[Token(Token = "0x6001527")]
	public InlinedArray`1(TValue value) { }

	[Address(RVA = "0x1C9A5A0", Offset = "0x1C999A0", Length = "0x2E")]
	[Token(Token = "0x6001528")]
	public InlinedArray`1(TValue firstValue, TValue[] additionalValues) { }

	[Address(RVA = "0x1C9C7F0", Offset = "0x1C9BBF0", Length = "0x2CF")]
	[Token(Token = "0x6001529")]
	public InlinedArray`1(IEnumerable<TValue> values) { }

	[Address(RVA = "0x1C88000", Offset = "0x1C87400", Length = "0x318")]
	[Token(Token = "0x6001536")]
	public void Append(IEnumerable<TValue> values) { }

	[Address(RVA = "0x1C88320", Offset = "0x1C87720", Length = "0x111")]
	[Token(Token = "0x6001533")]
	public int Append(TValue value) { }

	[Address(RVA = "0x1C87400", Offset = "0x1C86800", Length = "0x7B")]
	[Token(Token = "0x6001534")]
	public int AppendWithCapacity(TValue value, int capacityIncrement = 10) { }

	[Address(RVA = "0x1C8B460", Offset = "0x1C8A860", Length = "0x112")]
	[Token(Token = "0x6001535")]
	public void AssignWithCapacity(InlinedArray<TValue> values) { }

	[Address(RVA = "0x1C8C900", Offset = "0x1C8BD00", Length = "0x17")]
	[Token(Token = "0x600152C")]
	public void Clear() { }

	[Address(RVA = "0x1C8C180", Offset = "0x1C8B580", Length = "0x53")]
	[Token(Token = "0x600152D")]
	public void ClearWithCapacity() { }

	[Address(RVA = "0x1C8CD70", Offset = "0x1C8C170", Length = "0x7B")]
	[Token(Token = "0x600152E")]
	public InlinedArray<TValue> Clone() { }

	[Address(RVA = "0x1C8DF80", Offset = "0x1C8D380", Length = "0x156")]
	[Token(Token = "0x600153C")]
	public bool Contains(TValue value, IEqualityComparer<TValue> comparer) { }

	[Address(RVA = "0x1C9CBD0", Offset = "0x1C9BFD0", Length = "0x15")]
	[Token(Token = "0x6001526")]
	public int get_Capacity() { }

	[Address(RVA = "0x1C9CD60", Offset = "0x1C9C160", Length = "0x8F")]
	[Token(Token = "0x600152A")]
	public TValue get_Item(int index) { }

	[Address(RVA = "0x1C8E2D0", Offset = "0x1C8D6D0", Length = "0x7F")]
	[Token(Token = "0x600153E")]
	public override IEnumerator<TValue> GetEnumerator() { }

	[Address(RVA = "0x1C8F940", Offset = "0x1C8ED40", Length = "0xFE")]
	[Token(Token = "0x6001532")]
	public int IndexOf(TValue value) { }

	[Address(RVA = "0x1C90980", Offset = "0x1C8FD80", Length = "0x2C4")]
	[Token(Token = "0x600153D")]
	public void Merge(InlinedArray<TValue> other) { }

	[Address(RVA = "0x1C96950", Offset = "0x1C95D50", Length = "0x193")]
	[Token(Token = "0x6001537")]
	public void Remove(TValue value) { }

	[Address(RVA = "0x1C94DB0", Offset = "0x1C941B0", Length = "0x232")]
	[Token(Token = "0x6001539")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x1C92330", Offset = "0x1C91730", Length = "0x140")]
	[Token(Token = "0x600153A")]
	public void RemoveAtByMovingTailWithCapacity(int index) { }

	[Address(RVA = "0x1C93DD0", Offset = "0x1C931D0", Length = "0x179")]
	[Token(Token = "0x6001538")]
	public void RemoveAtWithCapacity(int index) { }

	[Address(RVA = "0x1C965F0", Offset = "0x1C959F0", Length = "0x9E")]
	[Token(Token = "0x600153B")]
	public bool RemoveByMovingTailWithCapacity(TValue value) { }

	[Address(RVA = "0x1C9D680", Offset = "0x1C9CA80", Length = "0x8F")]
	[Token(Token = "0x600152B")]
	public void set_Item(int index, TValue value) { }

	[Address(RVA = "0x1C98A20", Offset = "0x1C97E20", Length = "0x14E")]
	[Token(Token = "0x600152F")]
	public void SetLength(int size) { }

	[Address(RVA = "0x1C99440", Offset = "0x1C98840", Length = "0x39")]
	[Token(Token = "0x600153F")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1C99750", Offset = "0x1C98B50", Length = "0x47")]
	[Token(Token = "0x6001530")]
	public TValue[] ToArray() { }

	[Address(RVA = "0x69AFA0", Offset = "0x69A3A0", Length = "0x123")]
	[Token(Token = "0x6001531")]
	public TOther[] ToArray(Func<TValue, TOther> mapFunction) { }

}

