namespace System.Linq;

[DefaultMember("Item")]
[Token(Token = "0x2000034")]
public class Lookup : IEnumerable<IGrouping`2<TKey, TElement>>, IEnumerable, ILookup<TKey, TElement>
{
	[CompilerGenerated]
	[Token(Token = "0x2000037")]
	private sealed class <GetEnumerator>d__12 : IEnumerator<IGrouping`2<TKey, TElement>>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009F")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A0")]
		private IGrouping<TKey, TElement> <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A1")]
		public Lookup<TKey, TElement> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A2")]
		private Grouping<TKey, TElement> <g>5__2; //Field offset: 0x0

		[Token(Token = "0x17000031")]
		private override IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000163")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000032")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000165")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000160")]
		public <GetEnumerator>d__12(int <>1__state) { }

		[Address(RVA = "0x1804480", Offset = "0x1803880", Length = "0x9A")]
		[Token(Token = "0x6000162")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000163")]
		private override IGrouping<TKey, TElement> System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey,TElement>>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000165")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000164")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000161")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000035")]
	public class Grouping : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable, IList<TElement>, ICollection<TElement>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000036")]
		private sealed class <GetEnumerator>d__7 : IEnumerator<TElement>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400009B")]
			private int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400009C")]
			private TElement <>2__current; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400009D")]
			public Grouping<TKey, TElement> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400009E")]
			private int <i>5__2; //Field offset: 0x0

			[Token(Token = "0x1700002F")]
			private override TElement System.Collections.Generic.IEnumerator<TElement>.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x600015D")]
				private get { } //Length: 5
			}

			[Token(Token = "0x17000030")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[DebuggerHidden]
				[Token(Token = "0x600015F")]
				private get { } //Length: 5
			}

			[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
			[DebuggerHidden]
			[Token(Token = "0x600015A")]
			public <GetEnumerator>d__7(int <>1__state) { }

			[Address(RVA = "0x1807220", Offset = "0x1806620", Length = "0x7B")]
			[Token(Token = "0x600015C")]
			private override bool MoveNext() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600015D")]
			private override TElement System.Collections.Generic.IEnumerator<TElement>.get_Current() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600015F")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
			[DebuggerHidden]
			[Token(Token = "0x600015E")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x600015B")]
			private override void System.IDisposable.Dispose() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000095")]
		internal TKey key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000096")]
		internal int hashCode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000097")]
		internal TElement[] elements; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000098")]
		internal int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000099")]
		internal Grouping<TKey, TElement> hashNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400009A")]
		internal Grouping<TKey, TElement> next; //Field offset: 0x0

		[Token(Token = "0x1700002B")]
		public override TKey Key
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x600014C")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700002C")]
		private override int System.Collections.Generic.ICollection<TElement>.Count
		{
			[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
			[Token(Token = "0x600014D")]
			private get { } //Length: 4
		}

		[Token(Token = "0x1700002D")]
		private override bool System.Collections.Generic.ICollection<TElement>.IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x600014E")]
			private get { } //Length: 3
		}

		[Token(Token = "0x1700002E")]
		private override TElement System.Collections.Generic.IList<TElement>.Item
		{
			[Address(RVA = "0x1C41DF0", Offset = "0x1C411F0", Length = "0x5B")]
			[Token(Token = "0x6000157")]
			private get { } //Length: 91
			[Address(RVA = "0x1C41DD0", Offset = "0x1C411D0", Length = "0x1B")]
			[Token(Token = "0x6000158")]
			private set { } //Length: 27
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000159")]
		public Grouping() { }

		[Address(RVA = "0x1C41750", Offset = "0x1C40B50", Length = "0xB8")]
		[Token(Token = "0x6000149")]
		internal void Add(TElement element) { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600014C")]
		public override TKey get_Key() { }

		[Address(RVA = "0x1C418D0", Offset = "0x1C40CD0", Length = "0x86")]
		[IteratorStateMachine(typeof(<GetEnumerator>d__7))]
		[Token(Token = "0x600014A")]
		public override IEnumerator<TElement> GetEnumerator() { }

		[Address(RVA = "0x1C41960", Offset = "0x1C40D60", Length = "0x1B")]
		[Token(Token = "0x600014F")]
		private override void System.Collections.Generic.ICollection<TElement>.Add(TElement item) { }

		[Address(RVA = "0x1C41980", Offset = "0x1C40D80", Length = "0x1B")]
		[Token(Token = "0x6000150")]
		private override void System.Collections.Generic.ICollection<TElement>.Clear() { }

		[Address(RVA = "0x1C419A0", Offset = "0x1C40DA0", Length = "0x32")]
		[Token(Token = "0x6000151")]
		private override bool System.Collections.Generic.ICollection<TElement>.Contains(TElement item) { }

		[Address(RVA = "0x1C41B40", Offset = "0x1C40F40", Length = "0x2A")]
		[Token(Token = "0x6000152")]
		private override void System.Collections.Generic.ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) { }

		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x600014D")]
		private override int System.Collections.Generic.ICollection<TElement>.get_Count() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600014E")]
		private override bool System.Collections.Generic.ICollection<TElement>.get_IsReadOnly() { }

		[Address(RVA = "0x1C41960", Offset = "0x1C40D60", Length = "0x1B")]
		[Token(Token = "0x6000153")]
		private override bool System.Collections.Generic.ICollection<TElement>.Remove(TElement item) { }

		[Address(RVA = "0x1C41DF0", Offset = "0x1C411F0", Length = "0x5B")]
		[Token(Token = "0x6000157")]
		private override TElement System.Collections.Generic.IList<TElement>.get_Item(int index) { }

		[Address(RVA = "0x1C41DA0", Offset = "0x1C411A0", Length = "0x2D")]
		[Token(Token = "0x6000154")]
		private override int System.Collections.Generic.IList<TElement>.IndexOf(TElement item) { }

		[Address(RVA = "0x1C41DD0", Offset = "0x1C411D0", Length = "0x1B")]
		[Token(Token = "0x6000155")]
		private override void System.Collections.Generic.IList<TElement>.Insert(int index, TElement item) { }

		[Address(RVA = "0x1C41960", Offset = "0x1C40D60", Length = "0x1B")]
		[Token(Token = "0x6000156")]
		private override void System.Collections.Generic.IList<TElement>.RemoveAt(int index) { }

		[Address(RVA = "0x1C41DD0", Offset = "0x1C411D0", Length = "0x1B")]
		[Token(Token = "0x6000158")]
		private override void System.Collections.Generic.IList<TElement>.set_Item(int index, TElement value) { }

		[Address(RVA = "0x1C41F90", Offset = "0x1C41390", Length = "0x92")]
		[Token(Token = "0x600014B")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000091")]
	private IEqualityComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000092")]
	private Grouping<TKey, TElement>[] groupings; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000093")]
	private Grouping<TKey, TElement> lastGrouping; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000094")]
	private int count; //Field offset: 0x0

	[Token(Token = "0x1700002A")]
	public override IEnumerable<TElement> Item
	{
		[Address(RVA = "0xCF2D80", Offset = "0xCF2180", Length = "0x86")]
		[Token(Token = "0x6000143")]
		 get { } //Length: 134
	}

	[Address(RVA = "0xCF2A70", Offset = "0xCF1E70", Length = "0x18F")]
	[Token(Token = "0x6000142")]
	private Lookup`2(IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x69DF70", Offset = "0x69D370", Length = "0x314")]
	[Token(Token = "0x6000141")]
	internal static Lookup<TKey, TElement> Create(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xCF2D80", Offset = "0xCF2180", Length = "0x86")]
	[Token(Token = "0x6000143")]
	public override IEnumerable<TElement> get_Item(TKey key) { }

	[Address(RVA = "0xCF1610", Offset = "0xCF0A10", Length = "0x8C")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__12))]
	[Token(Token = "0x6000144")]
	public override IEnumerator<IGrouping`2<TKey, TElement>> GetEnumerator() { }

	[Address(RVA = "0xCF1D70", Offset = "0xCF1170", Length = "0x476")]
	[Token(Token = "0x6000147")]
	internal Grouping<TKey, TElement> GetGrouping(TKey key, bool create) { }

	[Address(RVA = "0xCF2340", Offset = "0xCF1740", Length = "0xC9")]
	[Token(Token = "0x6000146")]
	internal int InternalGetHashCode(TKey key) { }

	[Address(RVA = "0xCF2600", Offset = "0xCF1A00", Length = "0x14E")]
	[Token(Token = "0x6000148")]
	private void Resize() { }

	[Address(RVA = "0xCF2770", Offset = "0xCF1B70", Length = "0x9B")]
	[Token(Token = "0x6000145")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

