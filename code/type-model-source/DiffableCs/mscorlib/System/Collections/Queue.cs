namespace System.Collections;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(QueueDebugView))]
[Token(Token = "0x20005B5")]
public class Queue : ICollection, IEnumerable, ICloneable
{
	[Token(Token = "0x20005B7")]
	public class QueueDebugView
	{

	}

	[Token(Token = "0x20005B6")]
	private class QueueEnumerator : IEnumerator, ICloneable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017C5")]
		private Queue _q; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017C6")]
		private int _index; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40017C7")]
		private int _version; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40017C8")]
		private object _currentElement; //Field offset: 0x20

		[Token(Token = "0x1700063F")]
		public override object Current
		{
			[Address(RVA = "0x1FCA890", Offset = "0x1FC9C90", Length = "0xBD")]
			[Token(Token = "0x60029C5")]
			 get { } //Length: 189
		}

		[Address(RVA = "0x1FCA810", Offset = "0x1FC9C10", Length = "0x7D")]
		[Token(Token = "0x60029C2")]
		internal QueueEnumerator(Queue q) { }

		[Address(RVA = "0x1F8FF70", Offset = "0x1F8F370", Length = "0x7")]
		[Token(Token = "0x60029C3")]
		public override object Clone() { }

		[Address(RVA = "0x1FCA890", Offset = "0x1FC9C90", Length = "0xBD")]
		[Token(Token = "0x60029C5")]
		public override object get_Current() { }

		[Address(RVA = "0x1FCA680", Offset = "0x1FC9A80", Length = "0xEC")]
		[Token(Token = "0x60029C4")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1FCA770", Offset = "0x1FC9B70", Length = "0x9D")]
		[Token(Token = "0x60029C6")]
		public override void Reset() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017BE")]
	private Object[] _array; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017BF")]
	private int _head; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40017C0")]
	private int _tail; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017C1")]
	private int _size; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40017C2")]
	private int _growFactor; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40017C3")]
	private int _version; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40017C4")]
	private object _syncRoot; //Field offset: 0x30

	[Token(Token = "0x1700063C")]
	public override int Count
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60029B7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700063D")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60029B9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700063E")]
	public override object SyncRoot
	{
		[Address(RVA = "0x1FCB630", Offset = "0x1FCAA30", Length = "0x6B")]
		[Token(Token = "0x60029BA")]
		 get { } //Length: 107
	}

	[Address(RVA = "0x1FCB610", Offset = "0x1FCAA10", Length = "0x15")]
	[Token(Token = "0x60029B3")]
	public Queue() { }

	[Address(RVA = "0x1FCB600", Offset = "0x1FCAA00", Length = "0x10")]
	[Token(Token = "0x60029B4")]
	public Queue(int capacity) { }

	[Address(RVA = "0x1FCB210", Offset = "0x1FCA610", Length = "0x1A3")]
	[Token(Token = "0x60029B5")]
	public Queue(int capacity, float growFactor) { }

	[Address(RVA = "0x1FCB3C0", Offset = "0x1FCA7C0", Length = "0x232")]
	[Token(Token = "0x60029B6")]
	public Queue(ICollection col) { }

	[Address(RVA = "0x1FCA950", Offset = "0x1FC9D50", Length = "0x107")]
	[Token(Token = "0x60029B8")]
	public override object Clone() { }

	[Address(RVA = "0x1FCAA60", Offset = "0x1FC9E60", Length = "0x24E")]
	[Token(Token = "0x60029BB")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x1FCACB0", Offset = "0x1FCA0B0", Length = "0xE0")]
	[Token(Token = "0x60029BE")]
	public override object Dequeue() { }

	[Address(RVA = "0x1FCADA0", Offset = "0x1FCA1A0", Length = "0x1D5")]
	[Token(Token = "0x60029BC")]
	public override void Enqueue(object obj) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60029B7")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60029B9")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x1FCB630", Offset = "0x1FCAA30", Length = "0x6B")]
	[Token(Token = "0x60029BA")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1FCAF80", Offset = "0x1FCA380", Length = "0x35")]
	[Token(Token = "0x60029C0")]
	internal object GetElement(int i) { }

	[Address(RVA = "0x1FCAFC0", Offset = "0x1FCA3C0", Length = "0xAB")]
	[Token(Token = "0x60029BD")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x1FCB070", Offset = "0x1FCA470", Length = "0x91")]
	[Token(Token = "0x60029BF")]
	public override object Peek() { }

	[Address(RVA = "0x1FCB110", Offset = "0x1FCA510", Length = "0xF7")]
	[Token(Token = "0x60029C1")]
	private void SetCapacity(int capacity) { }

}

