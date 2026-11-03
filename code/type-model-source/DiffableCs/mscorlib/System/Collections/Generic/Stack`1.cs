namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(StackDebugView`1))]
[Token(Token = "0x200060C")]
[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
public class Stack : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[Token(Token = "0x200060D")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018A0")]
		private readonly Stack<T> _stack; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018A1")]
		private readonly int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018A2")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40018A3")]
		private T _currentElement; //Field offset: 0x0

		[Token(Token = "0x17000733")]
		public override T Current
		{
			[Address(RVA = "0x195BE10", Offset = "0x195B210", Length = "0x44")]
			[Token(Token = "0x6002D44")]
			 get { } //Length: 68
		}

		[Token(Token = "0x17000734")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x195AF50", Offset = "0x195A350", Length = "0x99")]
			[Token(Token = "0x6002D46")]
			private get { } //Length: 153
		}

		[Address(RVA = "0x195BC10", Offset = "0x195B010", Length = "0x41")]
		[Token(Token = "0x6002D41")]
		internal Enumerator(Stack<T> stack) { }

		[Address(RVA = "0x1957850", Offset = "0x1956C50", Length = "0x8")]
		[Token(Token = "0x6002D42")]
		public override void Dispose() { }

		[Address(RVA = "0x195BE10", Offset = "0x195B210", Length = "0x44")]
		[Token(Token = "0x6002D44")]
		public override T get_Current() { }

		[Address(RVA = "0x1958D60", Offset = "0x1958160", Length = "0x126")]
		[Token(Token = "0x6002D43")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195AF50", Offset = "0x195A350", Length = "0x99")]
		[Token(Token = "0x6002D46")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x195A760", Offset = "0x1959B60", Length = "0x79")]
		[Token(Token = "0x6002D47")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x195B180", Offset = "0x195A580", Length = "0x63")]
		[Token(Token = "0x6002D45")]
		private void ThrowEnumerationNotStartedOrEnded() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400189C")]
	private T[] _array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400189D")]
	private int _size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400189E")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400189F")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x17000730")]
	public override int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6002D31")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000731")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002D32")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000732")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xFC8420", Offset = "0xFC7820", Length = "0x68")]
		[Token(Token = "0x6002D33")]
		private get { } //Length: 104
	}

	[Address(RVA = "0xE82230", Offset = "0xE81630", Length = "0x44")]
	[Token(Token = "0x6002D2F")]
	public Stack`1() { }

	[Address(RVA = "0xE82280", Offset = "0xE81680", Length = "0xE4")]
	[Token(Token = "0x6002D30")]
	public Stack`1(int capacity) { }

	[Address(RVA = "0xFC7910", Offset = "0xFC6D10", Length = "0xD")]
	[Token(Token = "0x6002D34")]
	public void Clear() { }

	[Address(RVA = "0xFC7990", Offset = "0xFC6D90", Length = "0x48")]
	[Token(Token = "0x6002D35")]
	public bool Contains(T item) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6002D31")]
	public override int get_Count() { }

	[Address(RVA = "0xFC79E0", Offset = "0xFC6DE0", Length = "0x30")]
	[Token(Token = "0x6002D37")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xFC7A50", Offset = "0xFC6E50", Length = "0x6D")]
	[Token(Token = "0x6002D3A")]
	public T Peek() { }

	[Address(RVA = "0xFC7B60", Offset = "0xFC6F60", Length = "0x79")]
	[Token(Token = "0x6002D3B")]
	public T Pop() { }

	[Address(RVA = "0xFC7F70", Offset = "0xFC7370", Length = "0x5D")]
	[Token(Token = "0x6002D3D")]
	public void Push(T item) { }

	[Address(RVA = "0xFC7E00", Offset = "0xFC7200", Length = "0x80")]
	[Token(Token = "0x6002D3E")]
	private void PushWithResize(T item) { }

	[Address(RVA = "0xFC8090", Offset = "0xFC7490", Length = "0x65")]
	[Token(Token = "0x6002D38")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xFC8100", Offset = "0xFC7500", Length = "0x2A2")]
	[Token(Token = "0x6002D36")]
	private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002D32")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0xFC8420", Offset = "0xFC7820", Length = "0x68")]
	[Token(Token = "0x6002D33")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xFC8090", Offset = "0xFC7490", Length = "0x65")]
	[Token(Token = "0x6002D39")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xFC8490", Offset = "0xFC7890", Length = "0x49")]
	[Token(Token = "0x6002D40")]
	private void ThrowForEmptyStack() { }

	[Address(RVA = "0xFC8620", Offset = "0xFC7A20", Length = "0xC8")]
	[Token(Token = "0x6002D3F")]
	public T[] ToArray() { }

	[Address(RVA = "0xFC8800", Offset = "0xFC7C00", Length = "0x5A")]
	[Token(Token = "0x6002D3C")]
	public bool TryPop(out T result) { }

}

