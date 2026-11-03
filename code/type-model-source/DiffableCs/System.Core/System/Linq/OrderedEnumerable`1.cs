namespace System.Linq;

[Token(Token = "0x200003B")]
internal abstract class OrderedEnumerable : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
{
	[CompilerGenerated]
	[Token(Token = "0x200003C")]
	private sealed class <GetEnumerator>d__1 : IEnumerator<TElement>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B0")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B1")]
		private TElement <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B2")]
		public OrderedEnumerable<TElement> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B3")]
		private Buffer<TElement> <buffer>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B4")]
		private Int32[] <map>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000B5")]
		private int <i>5__4; //Field offset: 0x0

		[Token(Token = "0x17000033")]
		private override TElement System.Collections.Generic.IEnumerator<TElement>.Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x6000176")]
			private get { } //Length: 11
		}

		[Token(Token = "0x17000034")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x16FF790", Offset = "0x16FEB90", Length = "0x2B")]
			[DebuggerHidden]
			[Token(Token = "0x6000178")]
			private get { } //Length: 43
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000173")]
		public <GetEnumerator>d__1(int <>1__state) { }

		[Address(RVA = "0x16FF400", Offset = "0x16FE800", Length = "0x176")]
		[Token(Token = "0x6000175")]
		private override bool MoveNext() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[DebuggerHidden]
		[Token(Token = "0x6000176")]
		private override TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }

		[Address(RVA = "0x16FF790", Offset = "0x16FEB90", Length = "0x2B")]
		[DebuggerHidden]
		[Token(Token = "0x6000178")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000177")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000174")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AF")]
	internal IEnumerable<TElement> source; //Field offset: 0x0

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000172")]
	protected OrderedEnumerable`1() { }

	[Token(Token = "0x600016F")]
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }

	[Address(RVA = "0xE12380", Offset = "0xE11780", Length = "0x85")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__1))]
	[Token(Token = "0x600016E")]
	public override IEnumerator<TElement> GetEnumerator() { }

	[Address(RVA = "0xE12550", Offset = "0xE11950", Length = "0x91")]
	[Token(Token = "0x6000170")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x6A0280", Offset = "0x69F680", Length = "0xC6")]
	[Token(Token = "0x6000171")]
	private override IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

}

