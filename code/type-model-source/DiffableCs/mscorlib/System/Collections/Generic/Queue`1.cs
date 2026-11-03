namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(QueueDebugView`1))]
[Token(Token = "0x2000609")]
[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
public class Queue : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[Token(Token = "0x200060A")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001898")]
		private readonly Queue<T> _q; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001899")]
		private readonly int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400189A")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400189B")]
		private T _currentElement; //Field offset: 0x0

		[Token(Token = "0x1700072E")]
		public override T Current
		{
			[Address(RVA = "0x195BCD0", Offset = "0x195B0D0", Length = "0x44")]
			[Token(Token = "0x6002D2B")]
			 get { } //Length: 68
		}

		[Token(Token = "0x1700072F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x195A9B0", Offset = "0x1959DB0", Length = "0x99")]
			[Token(Token = "0x6002D2D")]
			private get { } //Length: 153
		}

		[Address(RVA = "0x195B5E0", Offset = "0x195A9E0", Length = "0x41")]
		[Token(Token = "0x6002D28")]
		internal Enumerator(Queue<T> q) { }

		[Address(RVA = "0x1957940", Offset = "0x1956D40", Length = "0xF")]
		[Token(Token = "0x6002D29")]
		public override void Dispose() { }

		[Address(RVA = "0x195BCD0", Offset = "0x195B0D0", Length = "0x44")]
		[Token(Token = "0x6002D2B")]
		public override T get_Current() { }

		[Address(RVA = "0x19590D0", Offset = "0x19584D0", Length = "0xEB")]
		[Token(Token = "0x6002D2A")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195A9B0", Offset = "0x1959DB0", Length = "0x99")]
		[Token(Token = "0x6002D2D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x195A4A0", Offset = "0x19598A0", Length = "0x79")]
		[Token(Token = "0x6002D2E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x195B1F0", Offset = "0x195A5F0", Length = "0x63")]
		[Token(Token = "0x6002D2C")]
		private void ThrowEnumerationNotStartedOrEnded() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001892")]
	private T[] _array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001893")]
	private int _head; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001894")]
	private int _tail; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001895")]
	private int _size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001896")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001897")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x1700072B")]
	public override int Count
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6002D17")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700072C")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002D18")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700072D")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xE81940", Offset = "0xE80D40", Length = "0x68")]
		[Token(Token = "0x6002D19")]
		private get { } //Length: 104
	}

	[Address(RVA = "0xE82230", Offset = "0xE81630", Length = "0x44")]
	[Token(Token = "0x6002D15")]
	public Queue`1() { }

	[Address(RVA = "0xE82280", Offset = "0xE81680", Length = "0xE4")]
	[Token(Token = "0x6002D16")]
	public Queue`1(int capacity) { }

	[Address(RVA = "0xE7E2B0", Offset = "0xE7D6B0", Length = "0x6F")]
	[Token(Token = "0x6002D1A")]
	public void Clear() { }

	[Address(RVA = "0xE7EDD0", Offset = "0xE7E1D0", Length = "0x122")]
	[Token(Token = "0x6002D23")]
	public bool Contains(T item) { }

	[Address(RVA = "0xE7F360", Offset = "0xE7E760", Length = "0xD5")]
	[Token(Token = "0x6002D20")]
	public T Dequeue() { }

	[Address(RVA = "0xE80970", Offset = "0xE7FD70", Length = "0x1A4")]
	[Token(Token = "0x6002D1C")]
	public void Enqueue(T item) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6002D17")]
	public override int get_Count() { }

	[Address(RVA = "0xE80B20", Offset = "0xE7FF20", Length = "0x30")]
	[Token(Token = "0x6002D1D")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xD0FA90", Offset = "0xD0EE90", Length = "0x26")]
	[Token(Token = "0x6002D26")]
	private void MoveNext(ref int index) { }

	[Address(RVA = "0xE80D40", Offset = "0xE80140", Length = "0x64")]
	[Token(Token = "0x6002D21")]
	public T Peek() { }

	[Address(RVA = "0xE80FB0", Offset = "0xE803B0", Length = "0xF7")]
	[Token(Token = "0x6002D25")]
	private void SetCapacity(int capacity) { }

	[Address(RVA = "0xE81120", Offset = "0xE80520", Length = "0x65")]
	[Token(Token = "0x6002D1E")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xE81390", Offset = "0xE80790", Length = "0x302")]
	[Token(Token = "0x6002D1B")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002D18")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0xE81940", Offset = "0xE80D40", Length = "0x68")]
	[Token(Token = "0x6002D19")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xE81120", Offset = "0xE80520", Length = "0x65")]
	[Token(Token = "0x6002D1F")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xE81BE0", Offset = "0xE80FE0", Length = "0x49")]
	[Token(Token = "0x6002D27")]
	private void ThrowForEmptyQueue() { }

	[Address(RVA = "0xE81C30", Offset = "0xE81030", Length = "0xE3")]
	[Token(Token = "0x6002D24")]
	public T[] ToArray() { }

	[Address(RVA = "0xE81F10", Offset = "0xE81310", Length = "0x56")]
	[Token(Token = "0x6002D22")]
	public bool TryPeek(out T result) { }

}

