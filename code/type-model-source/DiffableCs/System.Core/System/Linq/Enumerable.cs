namespace System.Linq;

[Extension]
[Token(Token = "0x2000018")]
public static class Enumerable
{
	[CompilerGenerated]
	[Token(Token = "0x2000022")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003A")]
		public Func<TSource, Boolean> predicate1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003B")]
		public Func<TSource, Boolean> predicate2; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000DC")]
		public <>c__DisplayClass6_0`1() { }

		[Address(RVA = "0xA749D0", Offset = "0xA73DD0", Length = "0x77")]
		[Token(Token = "0x60000DD")]
		internal bool <CombinePredicates>b__0(TSource x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000023")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003C")]
		public Func<TMiddle, TResult> selector2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003D")]
		public Func<TSource, TMiddle> selector1; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000DE")]
		public <>c__DisplayClass7_0`3() { }

		[Address(RVA = "0xA75800", Offset = "0xA74C00", Length = "0x4F")]
		[Token(Token = "0x60000DF")]
		internal TResult <CombineSelectors>b__0(TSource x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002B")]
	private sealed class <CastIterator>d__99 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000078")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000079")]
		private TResult <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007A")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007B")]
		private IEnumerable source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007C")]
		public IEnumerable <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007D")]
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		[Token(Token = "0x17000021")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x6000124")]
			private get { } //Length: 11
		}

		[Token(Token = "0x17000022")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x113F490", Offset = "0x113E890", Length = "0x2B")]
			[DebuggerHidden]
			[Token(Token = "0x6000126")]
			private get { } //Length: 43
		}

		[Address(RVA = "0x113FA10", Offset = "0x113EE10", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000120")]
		public <CastIterator>d__99`1(int <>1__state) { }

		[Address(RVA = "0x113F8F0", Offset = "0x113ECF0", Length = "0x5D")]
		[Token(Token = "0x6000123")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x113EC60", Offset = "0x113E060", Length = "0x20A")]
		[Token(Token = "0x6000122")]
		private override bool MoveNext() { }

		[Address(RVA = "0x113EF20", Offset = "0x113E320", Length = "0xA8")]
		[DebuggerHidden]
		[Token(Token = "0x6000127")]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[DebuggerHidden]
		[Token(Token = "0x6000124")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[Address(RVA = "0x113F2C0", Offset = "0x113E6C0", Length = "0xB4")]
		[DebuggerHidden]
		[Token(Token = "0x6000128")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x113F490", Offset = "0x113E890", Length = "0x2B")]
		[DebuggerHidden]
		[Token(Token = "0x6000126")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000125")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x113F570", Offset = "0x113E970", Length = "0x62")]
		[DebuggerHidden]
		[Token(Token = "0x6000121")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000027")]
	private sealed class <DistinctIterator>d__68 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000057")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000058")]
		private TSource <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000059")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005A")]
		private IEqualityComparer<TSource> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005B")]
		public IEqualityComparer<TSource> <>3__comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005C")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005D")]
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005E")]
		private Set<TSource> <set>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400005F")]
		private IEnumerator<TSource> <>7__wrap2; //Field offset: 0x0

		[Token(Token = "0x17000019")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[DebuggerHidden]
			[Token(Token = "0x6000100")]
			private get { } //Length: 4
		}

		[Token(Token = "0x1700001A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x16F1FF0", Offset = "0x16F13F0", Length = "0x29")]
			[DebuggerHidden]
			[Token(Token = "0x6000102")]
			private get { } //Length: 41
		}

		[Address(RVA = "0x113FA40", Offset = "0x113EE40", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60000FC")]
		public <DistinctIterator>d__68`1(int <>1__state) { }

		[Address(RVA = "0x16F2250", Offset = "0x16F1650", Length = "0x50")]
		[Token(Token = "0x60000FF")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x16F0CA0", Offset = "0x16F00A0", Length = "0x319")]
		[Token(Token = "0x60000FE")]
		private override bool MoveNext() { }

		[Address(RVA = "0x16F1C10", Offset = "0x16F1010", Length = "0xB9")]
		[DebuggerHidden]
		[Token(Token = "0x6000103")]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[DebuggerHidden]
		[Token(Token = "0x6000100")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[Address(RVA = "0x16F1D80", Offset = "0x16F1180", Length = "0xC5")]
		[DebuggerHidden]
		[Token(Token = "0x6000104")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x16F1FF0", Offset = "0x16F13F0", Length = "0x29")]
		[DebuggerHidden]
		[Token(Token = "0x6000102")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000101")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x16F20C0", Offset = "0x16F14C0", Length = "0x9B")]
		[DebuggerHidden]
		[Token(Token = "0x60000FD")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002A")]
	private sealed class <OfTypeIterator>d__97 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000072")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000073")]
		private TResult <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000074")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000075")]
		private IEnumerable source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000076")]
		public IEnumerable <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000077")]
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		[Token(Token = "0x1700001F")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600011B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000020")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600011D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000117")]
		public <OfTypeIterator>d__97`1(int <>1__state) { }

		[Address(RVA = "0x1977B80", Offset = "0x1976F80", Length = "0x5D")]
		[Token(Token = "0x600011A")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x19777A0", Offset = "0x1976BA0", Length = "0x296")]
		[Token(Token = "0x6000119")]
		private override bool MoveNext() { }

		[Address(RVA = "0x113EE70", Offset = "0x113E270", Length = "0xA8")]
		[DebuggerHidden]
		[Token(Token = "0x600011E")]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600011B")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[Address(RVA = "0x113F200", Offset = "0x113E600", Length = "0xB4")]
		[DebuggerHidden]
		[Token(Token = "0x600011F")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600011D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x600011C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1977A40", Offset = "0x1976E40", Length = "0x62")]
		[DebuggerHidden]
		[Token(Token = "0x6000118")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002C")]
	private sealed class <RangeIterator>d__115 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400007E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400007F")]
		private int <>2__current; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000080")]
		private int <>l__initialThreadId; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000081")]
		private int start; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000082")]
		public int <>3__start; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000083")]
		private int count; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000084")]
		public int <>3__count; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000085")]
		private int <i>5__2; //Field offset: 0x2C

		[Token(Token = "0x17000023")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
			[DebuggerHidden]
			[Token(Token = "0x600012C")]
			private get { } //Length: 4
		}

		[Token(Token = "0x17000024")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x224EF90", Offset = "0x224E390", Length = "0x436")]
			[DebuggerHidden]
			[Token(Token = "0x600012E")]
			private get { } //Length: 1078
		}

		[Address(RVA = "0x113FA40", Offset = "0x113EE40", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000129")]
		public <RangeIterator>d__115(int <>1__state) { }

		[Address(RVA = "0x224EE70", Offset = "0x224E270", Length = "0x39")]
		[Token(Token = "0x600012B")]
		private override bool MoveNext() { }

		[Address(RVA = "0x224EEB0", Offset = "0x224E2B0", Length = "0x97")]
		[DebuggerHidden]
		[Token(Token = "0x600012F")]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[DebuggerHidden]
		[Token(Token = "0x600012C")]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[Address(RVA = "0x224EEB0", Offset = "0x224E2B0", Length = "0x97")]
		[DebuggerHidden]
		[Token(Token = "0x6000130")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x224EF90", Offset = "0x224E390", Length = "0x436")]
		[DebuggerHidden]
		[Token(Token = "0x600012E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x224EF50", Offset = "0x224E350", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600012D")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600012A")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002D")]
	private sealed class <RepeatIterator>d__117 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000086")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000087")]
		private TResult <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000088")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000089")]
		private TResult element; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008A")]
		public TResult <>3__element; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008B")]
		private int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008C")]
		public int <>3__count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008D")]
		private int <i>5__2; //Field offset: 0x0

		[Token(Token = "0x17000025")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000134")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000026")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1978C60", Offset = "0x1978060", Length = "0x2A")]
			[DebuggerHidden]
			[Token(Token = "0x6000136")]
			private get { } //Length: 42
		}

		[Address(RVA = "0x113FA40", Offset = "0x113EE40", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000131")]
		public <RepeatIterator>d__117`1(int <>1__state) { }

		[Address(RVA = "0x19783E0", Offset = "0x19777E0", Length = "0x37")]
		[Token(Token = "0x6000133")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1978750", Offset = "0x1977B50", Length = "0xA4")]
		[DebuggerHidden]
		[Token(Token = "0x6000137")]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000134")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[Address(RVA = "0x1978AE0", Offset = "0x1977EE0", Length = "0xB0")]
		[DebuggerHidden]
		[Token(Token = "0x6000138")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x1978C60", Offset = "0x1978060", Length = "0x2A")]
		[DebuggerHidden]
		[Token(Token = "0x6000136")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000135")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000132")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000029")]
	private sealed class <ReverseIterator>d__79 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006B")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006C")]
		private TSource <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006D")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006E")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006F")]
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000070")]
		private Buffer<TSource> <buffer>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000071")]
		private int <i>5__3; //Field offset: 0x0

		[Token(Token = "0x1700001D")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000112")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000114")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x600010F")]
		public <ReverseIterator>d__79`1(int <>1__state) { }

		[Address(RVA = "0x1979040", Offset = "0x1978440", Length = "0xB4")]
		[Token(Token = "0x6000111")]
		private override bool MoveNext() { }

		[Address(RVA = "0x113EE70", Offset = "0x113E270", Length = "0xA8")]
		[DebuggerHidden]
		[Token(Token = "0x6000115")]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000112")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[Address(RVA = "0x1979630", Offset = "0x1978A30", Length = "0xB4")]
		[DebuggerHidden]
		[Token(Token = "0x6000116")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000114")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000113")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000110")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000021")]
	private sealed class <SelectIterator>d__5 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000031")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000032")]
		private TResult <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000033")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000034")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000035")]
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000036")]
		private Func<TSource, Int32, TResult> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000037")]
		public Func<TSource, Int32, TResult> <>3__selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		private int <index>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000039")]
		private IEnumerator<TSource> <>7__wrap2; //Field offset: 0x0

		[Token(Token = "0x17000011")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[Address(RVA = "0x16F1CD0", Offset = "0x16F10D0", Length = "0xAC")]
			[DebuggerHidden]
			[Token(Token = "0x60000D7")]
			private get { } //Length: 172
		}

		[Token(Token = "0x17000012")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x16F1F40", Offset = "0x16F1340", Length = "0xAD")]
			[DebuggerHidden]
			[Token(Token = "0x60000D9")]
			private get { } //Length: 173
		}

		[Address(RVA = "0x113F950", Offset = "0x113ED50", Length = "0xBE")]
		[DebuggerHidden]
		[Token(Token = "0x60000D3")]
		public <SelectIterator>d__5`2(int <>1__state) { }

		[Address(RVA = "0x1982EF0", Offset = "0x19822F0", Length = "0xEC")]
		[Token(Token = "0x60000D6")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x19825D0", Offset = "0x19819D0", Length = "0x711")]
		[Token(Token = "0x60000D5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1982CF0", Offset = "0x19820F0", Length = "0x1F9")]
		[DebuggerHidden]
		[Token(Token = "0x60000DA")]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[Address(RVA = "0x16F1CD0", Offset = "0x16F10D0", Length = "0xAC")]
		[DebuggerHidden]
		[Token(Token = "0x60000D7")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[Address(RVA = "0x16F1E50", Offset = "0x16F1250", Length = "0x18")]
		[DebuggerHidden]
		[Token(Token = "0x60000DB")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x16F1F40", Offset = "0x16F1340", Length = "0xAD")]
		[DebuggerHidden]
		[Token(Token = "0x60000D9")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60000D8")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x113F5E0", Offset = "0x113E9E0", Length = "0x95")]
		[DebuggerHidden]
		[Token(Token = "0x60000D4")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000024")]
	private sealed class <SelectManyIterator>d__17 : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003E")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003F")]
		private TResult <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000040")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000041")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000042")]
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000043")]
		private Func<TSource, IEnumerable`1<TResult>> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000044")]
		public Func<TSource, IEnumerable`1<TResult>> <>3__selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000045")]
		private IEnumerator<TSource> <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000046")]
		private IEnumerator<TResult> <>7__wrap2; //Field offset: 0x0

		[Token(Token = "0x17000013")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000E5")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000014")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000E7")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60000E0")]
		public <SelectManyIterator>d__17`2(int <>1__state) { }

		[Address(RVA = "0x1984AB0", Offset = "0x1983EB0", Length = "0x50")]
		[Token(Token = "0x60000E3")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1984B50", Offset = "0x1983F50", Length = "0x50")]
		[Token(Token = "0x60000E4")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x1983BD0", Offset = "0x1982FD0", Length = "0x464")]
		[Token(Token = "0x60000E2")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1984040", Offset = "0x1983440", Length = "0xB9")]
		[DebuggerHidden]
		[Token(Token = "0x60000E8")]
		private override IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000E5")]
		private override TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }

		[Address(RVA = "0x19843D0", Offset = "0x19837D0", Length = "0xC8")]
		[DebuggerHidden]
		[Token(Token = "0x60000E9")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000E7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60000E6")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1984550", Offset = "0x1983950", Length = "0x163")]
		[DebuggerHidden]
		[Token(Token = "0x60000E1")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000026")]
	private sealed class <SkipIterator>d__31 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004F")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000050")]
		private TSource <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000051")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000052")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000053")]
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000054")]
		private int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000055")]
		public int <>3__count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000056")]
		private IEnumerator<TSource> <e>5__2; //Field offset: 0x0

		[Token(Token = "0x17000017")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000F7")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000018")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19DDF40", Offset = "0x19DD340", Length = "0x2A")]
			[DebuggerHidden]
			[Token(Token = "0x60000F9")]
			private get { } //Length: 42
		}

		[Address(RVA = "0x113FA40", Offset = "0x113EE40", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60000F3")]
		public <SkipIterator>d__31`1(int <>1__state) { }

		[Address(RVA = "0x19DE100", Offset = "0x19DD500", Length = "0x50")]
		[Token(Token = "0x60000F6")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x19DD910", Offset = "0x19DCD10", Length = "0x2BB")]
		[Token(Token = "0x60000F5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x19DDBD0", Offset = "0x19DCFD0", Length = "0xAE")]
		[DebuggerHidden]
		[Token(Token = "0x60000FA")]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000F7")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[Address(RVA = "0x19DDE80", Offset = "0x19DD280", Length = "0xBA")]
		[DebuggerHidden]
		[Token(Token = "0x60000FB")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x19DDF40", Offset = "0x19DD340", Length = "0x2A")]
		[DebuggerHidden]
		[Token(Token = "0x60000F9")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60000F8")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x19DDF70", Offset = "0x19DD370", Length = "0x9B")]
		[DebuggerHidden]
		[Token(Token = "0x60000F4")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000025")]
	private sealed class <TakeIterator>d__25 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000047")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000048")]
		private TSource <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000049")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004A")]
		private int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004B")]
		public int <>3__count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004C")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004D")]
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004E")]
		private IEnumerator<TSource> <>7__wrap1; //Field offset: 0x0

		[Token(Token = "0x17000015")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x60000EE")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000016")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19DDF40", Offset = "0x19DD340", Length = "0x2A")]
			[DebuggerHidden]
			[Token(Token = "0x60000F0")]
			private get { } //Length: 42
		}

		[Address(RVA = "0x113FA40", Offset = "0x113EE40", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60000EA")]
		public <TakeIterator>d__25`1(int <>1__state) { }

		[Address(RVA = "0x19F4DD0", Offset = "0x19F41D0", Length = "0x50")]
		[Token(Token = "0x60000ED")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x19F4130", Offset = "0x19F3530", Length = "0x21E")]
		[Token(Token = "0x60000EC")]
		private override bool MoveNext() { }

		[Address(RVA = "0x19F48D0", Offset = "0x19F3CD0", Length = "0xAE")]
		[DebuggerHidden]
		[Token(Token = "0x60000F1")]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x60000EE")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[Address(RVA = "0x19F4B80", Offset = "0x19F3F80", Length = "0xBA")]
		[DebuggerHidden]
		[Token(Token = "0x60000F2")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x19DDF40", Offset = "0x19DD340", Length = "0x2A")]
		[DebuggerHidden]
		[Token(Token = "0x60000F0")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60000EF")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x19F4C40", Offset = "0x19F4040", Length = "0x9B")]
		[DebuggerHidden]
		[Token(Token = "0x60000EB")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000028")]
	private sealed class <UnionIterator>d__71 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000060")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000061")]
		private TSource <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000062")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000063")]
		private IEqualityComparer<TSource> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000064")]
		public IEqualityComparer<TSource> <>3__comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000065")]
		private IEnumerable<TSource> first; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000066")]
		public IEnumerable<TSource> <>3__first; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000067")]
		private IEnumerable<TSource> second; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000068")]
		public IEnumerable<TSource> <>3__second; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000069")]
		private Set<TSource> <set>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006A")]
		private IEnumerator<TSource> <>7__wrap2; //Field offset: 0x0

		[Token(Token = "0x1700001B")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[Address(RVA = "0x1963870", Offset = "0x1962C70", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600010A")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700001C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1B71F00", Offset = "0x1B71300", Length = "0x2B")]
			[DebuggerHidden]
			[Token(Token = "0x600010C")]
			private get { } //Length: 43
		}

		[Address(RVA = "0x113FA40", Offset = "0x113EE40", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000105")]
		public <UnionIterator>d__71`1(int <>1__state) { }

		[Address(RVA = "0x1B722F0", Offset = "0x1B716F0", Length = "0x50")]
		[Token(Token = "0x6000108")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1B725C0", Offset = "0x1B719C0", Length = "0x50")]
		[Token(Token = "0x6000109")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x1B714A0", Offset = "0x1B708A0", Length = "0x481")]
		[Token(Token = "0x6000107")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1B71C70", Offset = "0x1B71070", Length = "0xCA")]
		[DebuggerHidden]
		[Token(Token = "0x600010D")]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[Address(RVA = "0x1963870", Offset = "0x1962C70", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600010A")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[Address(RVA = "0x1B71E20", Offset = "0x1B71220", Length = "0xD6")]
		[DebuggerHidden]
		[Token(Token = "0x600010E")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x1B71F00", Offset = "0x1B71300", Length = "0x2B")]
		[DebuggerHidden]
		[Token(Token = "0x600010C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x600010B")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1B721A0", Offset = "0x1B715A0", Length = "0x134")]
		[DebuggerHidden]
		[Token(Token = "0x6000106")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000020")]
	private sealed class <WhereIterator>d__2 : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000028")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000029")]
		private TSource <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002A")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002B")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002C")]
		public IEnumerable<TSource> <>3__source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002D")]
		private Func<TSource, Int32, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002E")]
		public Func<TSource, Int32, Boolean> <>3__predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002F")]
		private int <index>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000030")]
		private IEnumerator<TSource> <>7__wrap2; //Field offset: 0x0

		[Token(Token = "0x1700000F")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.Current
		{
			[Address(RVA = "0xABF840", Offset = "0xABEC40", Length = "0x1B")]
			[DebuggerHidden]
			[Token(Token = "0x60000CE")]
			private get { } //Length: 27
		}

		[Token(Token = "0x17000010")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1B7B1B0", Offset = "0x1B7A5B0", Length = "0x3D")]
			[DebuggerHidden]
			[Token(Token = "0x60000D0")]
			private get { } //Length: 61
		}

		[Address(RVA = "0x1B7B3D0", Offset = "0x1B7A7D0", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60000CA")]
		public <WhereIterator>d__2`1(int <>1__state) { }

		[Address(RVA = "0x1B7B380", Offset = "0x1B7A780", Length = "0x50")]
		[Token(Token = "0x60000CD")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x1B7AA70", Offset = "0x1B79E70", Length = "0x3A3")]
		[Token(Token = "0x60000CC")]
		private override bool MoveNext() { }

		[Address(RVA = "0x1B7AE20", Offset = "0x1B7A220", Length = "0xB9")]
		[DebuggerHidden]
		[Token(Token = "0x60000D1")]
		private override IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }

		[Address(RVA = "0xABF840", Offset = "0xABEC40", Length = "0x1B")]
		[DebuggerHidden]
		[Token(Token = "0x60000CE")]
		private override TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }

		[Address(RVA = "0x1B7B0E0", Offset = "0x1B7A4E0", Length = "0xC5")]
		[DebuggerHidden]
		[Token(Token = "0x60000D2")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x1B7B1B0", Offset = "0x1B7A5B0", Length = "0x3D")]
		[DebuggerHidden]
		[Token(Token = "0x60000D0")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x60000CF")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x1B7B1F0", Offset = "0x1B7A5F0", Length = "0x9B")]
		[DebuggerHidden]
		[Token(Token = "0x60000CB")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000019")]
	private abstract class Iterator : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000010")]
		private int threadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000011")]
		internal int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000012")]
		internal TSource current; //Field offset: 0x0

		[Token(Token = "0x1700000D")]
		public override TSource Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60000A0")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700000E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xABEB60", Offset = "0xABDF60", Length = "0x2B")]
			[Token(Token = "0x60000A7")]
			private get { } //Length: 43
		}

		[Address(RVA = "0xABEBF0", Offset = "0xABDFF0", Length = "0x34")]
		[Token(Token = "0x600009F")]
		public Iterator`1() { }

		[Token(Token = "0x60000A1")]
		public abstract Iterator<TSource> Clone() { }

		[Address(RVA = "0xABE940", Offset = "0xABDD40", Length = "0xE")]
		[Token(Token = "0x60000A2")]
		public override void Dispose() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60000A0")]
		public override TSource get_Current() { }

		[Address(RVA = "0xABE9A0", Offset = "0xABDDA0", Length = "0x77")]
		[Token(Token = "0x60000A3")]
		public override IEnumerator<TSource> GetEnumerator() { }

		[Token(Token = "0x60000A4")]
		public abstract bool MoveNext() { }

		[Token(Token = "0x60000A5")]
		public abstract IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[Address(RVA = "0xABEA20", Offset = "0xABDE20", Length = "0x7A")]
		[Token(Token = "0x60000A8")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0xABEB60", Offset = "0xABDF60", Length = "0x2B")]
		[Token(Token = "0x60000A7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
		[Token(Token = "0x60000A9")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Token(Token = "0x60000A6")]
		public abstract IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	[Token(Token = "0x200001B")]
	private class WhereArrayIterator : Iterator<TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000016")]
		private TSource[] source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000017")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000018")]
		private int index; //Field offset: 0x0

		[Address(RVA = "0x153A080", Offset = "0x1539480", Length = "0x5A")]
		[Token(Token = "0x60000B0")]
		public WhereArrayIterator`1(TSource[] source, Func<TSource, Boolean> predicate) { }

		[Address(RVA = "0x1538E90", Offset = "0x1538290", Length = "0xA7")]
		[Token(Token = "0x60000B1")]
		public virtual Iterator<TSource> Clone() { }

		[Address(RVA = "0x15390B0", Offset = "0x15384B0", Length = "0xC0")]
		[Token(Token = "0x60000B2")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x6E8EF0", Offset = "0x6E82F0", Length = "0x9A")]
		[Token(Token = "0x60000B3")]
		public virtual IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[Address(RVA = "0x1539B00", Offset = "0x1538F00", Length = "0xBE")]
		[Token(Token = "0x60000B4")]
		public virtual IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	[Token(Token = "0x200001A")]
	private class WhereEnumerableIterator : Iterator<TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000013")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000014")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000015")]
		private IEnumerator<TSource> enumerator; //Field offset: 0x0

		[Address(RVA = "0x153A080", Offset = "0x1539480", Length = "0x5A")]
		[Token(Token = "0x60000AA")]
		public WhereEnumerableIterator`1(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

		[Address(RVA = "0x1538E90", Offset = "0x1538290", Length = "0xA7")]
		[Token(Token = "0x60000AB")]
		public virtual Iterator<TSource> Clone() { }

		[Address(RVA = "0x153A590", Offset = "0x1539990", Length = "0x79")]
		[Token(Token = "0x60000AC")]
		public virtual void Dispose() { }

		[Address(RVA = "0x153AD40", Offset = "0x153A140", Length = "0x1D7")]
		[Token(Token = "0x60000AD")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x6E8EF0", Offset = "0x6E82F0", Length = "0x9A")]
		[Token(Token = "0x60000AE")]
		public virtual IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[Address(RVA = "0x153C730", Offset = "0x153BB30", Length = "0xBE")]
		[Token(Token = "0x60000AF")]
		public virtual IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	[Token(Token = "0x200001C")]
	private class WhereListIterator : Iterator<TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000019")]
		private List<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001A")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001B")]
		private Enumerator<TSource> enumerator; //Field offset: 0x0

		[Address(RVA = "0x153A080", Offset = "0x1539480", Length = "0x5A")]
		[Token(Token = "0x60000B5")]
		public WhereListIterator`1(List<TSource> source, Func<TSource, Boolean> predicate) { }

		[Address(RVA = "0x1538E90", Offset = "0x1538290", Length = "0xA7")]
		[Token(Token = "0x60000B6")]
		public virtual Iterator<TSource> Clone() { }

		[Address(RVA = "0x153CBF0", Offset = "0x153BFF0", Length = "0x11D")]
		[Token(Token = "0x60000B7")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x6E8EF0", Offset = "0x6E82F0", Length = "0x9A")]
		[Token(Token = "0x60000B8")]
		public virtual IEnumerable<TResult> Select(Func<TSource, TResult> selector) { }

		[Address(RVA = "0x153D580", Offset = "0x153C980", Length = "0xBE")]
		[Token(Token = "0x60000B9")]
		public virtual IEnumerable<TSource> Where(Func<TSource, Boolean> predicate) { }

	}

	[Token(Token = "0x200001E")]
	private class WhereSelectArrayIterator : Iterator<TResult>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000020")]
		private TSource[] source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000021")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000022")]
		private Func<TSource, TResult> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000023")]
		private int index; //Field offset: 0x0

		[Address(RVA = "0x153EC00", Offset = "0x153E000", Length = "0x7C")]
		[Token(Token = "0x60000C0")]
		public WhereSelectArrayIterator`2(TSource[] source, Func<TSource, Boolean> predicate, Func<TSource, TResult> selector) { }

		[Address(RVA = "0x153DAF0", Offset = "0x153CEF0", Length = "0xC7")]
		[Token(Token = "0x60000C1")]
		public virtual Iterator<TResult> Clone() { }

		[Address(RVA = "0x153E7E0", Offset = "0x153DBE0", Length = "0xC4")]
		[Token(Token = "0x60000C2")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x6E90B0", Offset = "0x6E84B0", Length = "0xB1")]
		[Token(Token = "0x60000C3")]
		public virtual IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		[Address(RVA = "0x153EAA0", Offset = "0x153DEA0", Length = "0xA5")]
		[Token(Token = "0x60000C4")]
		public virtual IEnumerable<TResult> Where(Func<TResult, Boolean> predicate) { }

	}

	[Token(Token = "0x200001D")]
	private class WhereSelectEnumerableIterator : Iterator<TResult>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001C")]
		private IEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001D")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001E")]
		private Func<TSource, TResult> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001F")]
		private IEnumerator<TSource> enumerator; //Field offset: 0x0

		[Address(RVA = "0x153EC00", Offset = "0x153E000", Length = "0x7C")]
		[Token(Token = "0x60000BA")]
		public WhereSelectEnumerableIterator`2(IEnumerable<TSource> source, Func<TSource, Boolean> predicate, Func<TSource, TResult> selector) { }

		[Address(RVA = "0x153DAF0", Offset = "0x153CEF0", Length = "0xC7")]
		[Token(Token = "0x60000BB")]
		public virtual Iterator<TResult> Clone() { }

		[Address(RVA = "0x1542A30", Offset = "0x1541E30", Length = "0x79")]
		[Token(Token = "0x60000BC")]
		public virtual void Dispose() { }

		[Address(RVA = "0x1546CB0", Offset = "0x15460B0", Length = "0x1D2")]
		[Token(Token = "0x60000BD")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x6E90B0", Offset = "0x6E84B0", Length = "0xB1")]
		[Token(Token = "0x60000BE")]
		public virtual IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		[Address(RVA = "0x154A780", Offset = "0x1549B80", Length = "0x83")]
		[Token(Token = "0x60000BF")]
		public virtual IEnumerable<TResult> Where(Func<TResult, Boolean> predicate) { }

	}

	[Token(Token = "0x200001F")]
	private class WhereSelectListIterator : Iterator<TResult>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000024")]
		private List<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000025")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000026")]
		private Func<TSource, TResult> selector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000027")]
		private Enumerator<TSource> enumerator; //Field offset: 0x0

		[Address(RVA = "0x153EC00", Offset = "0x153E000", Length = "0x7C")]
		[Token(Token = "0x60000C5")]
		public WhereSelectListIterator`2(List<TSource> source, Func<TSource, Boolean> predicate, Func<TSource, TResult> selector) { }

		[Address(RVA = "0x153DAF0", Offset = "0x153CEF0", Length = "0xC7")]
		[Token(Token = "0x60000C6")]
		public virtual Iterator<TResult> Clone() { }

		[Address(RVA = "0x154AE10", Offset = "0x154A210", Length = "0x118")]
		[Token(Token = "0x60000C7")]
		public virtual bool MoveNext() { }

		[Address(RVA = "0x6E90B0", Offset = "0x6E84B0", Length = "0xB1")]
		[Token(Token = "0x60000C8")]
		public virtual IEnumerable<TResult2> Select(Func<TResult, TResult2> selector) { }

		[Address(RVA = "0x154C600", Offset = "0x154BA00", Length = "0x83")]
		[Token(Token = "0x60000C9")]
		public virtual IEnumerable<TResult> Where(Func<TResult, Boolean> predicate) { }

	}


	[Address(RVA = "0x7D4400", Offset = "0x7D3800", Length = "0x238")]
	[Extension]
	[Token(Token = "0x6000092")]
	public static bool All(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x7D5180", Offset = "0x7D4580", Length = "0x148")]
	[Extension]
	[Token(Token = "0x6000090")]
	public static bool Any(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7D4CD0", Offset = "0x7D40D0", Length = "0x1D1")]
	[Extension]
	[Token(Token = "0x6000091")]
	public static bool Any(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Extension]
	[Token(Token = "0x6000076")]
	public static IEnumerable<TSource> AsEnumerable(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7D5960", Offset = "0x7D4D60", Length = "0xEF")]
	[Extension]
	[Token(Token = "0x600007D")]
	public static IEnumerable<TResult> Cast(IEnumerable source) { }

	[Address(RVA = "0x7D56F0", Offset = "0x7D4AF0", Length = "0x89")]
	[IteratorStateMachine(typeof(<CastIterator>d__99`1))]
	[Token(Token = "0x600007E")]
	private static IEnumerable<TResult> CastIterator(IEnumerable source) { }

	[Address(RVA = "0x7D5DA0", Offset = "0x7D51A0", Length = "0xDC")]
	[Token(Token = "0x6000060")]
	private static Func<TSource, Boolean> CombinePredicates(Func<TSource, Boolean> predicate1, Func<TSource, Boolean> predicate2) { }

	[Address(RVA = "0x7D6CB0", Offset = "0x7D60B0", Length = "0xDC")]
	[Token(Token = "0x6000061")]
	private static Func<TSource, TResult> CombineSelectors(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }

	[Address(RVA = "0x7D8FE0", Offset = "0x7D83E0", Length = "0x344")]
	[Extension]
	[Token(Token = "0x6000096")]
	public static bool Contains(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0x7D9330", Offset = "0x7D8730", Length = "0x10A")]
	[Extension]
	[Token(Token = "0x6000095")]
	public static bool Contains(IEnumerable<TSource> source, TSource value) { }

	[Address(RVA = "0x7D9760", Offset = "0x7D8B60", Length = "0x256")]
	[Extension]
	[Token(Token = "0x6000094")]
	public static int Count(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x7D99C0", Offset = "0x7D8DC0", Length = "0x1F0")]
	[Extension]
	[Token(Token = "0x6000093")]
	public static int Count(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7DA4E0", Offset = "0x7D98E0", Length = "0x6F")]
	[Extension]
	[Token(Token = "0x600006E")]
	public static IEnumerable<TSource> Distinct(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0x7DA400", Offset = "0x7D9800", Length = "0xDE")]
	[Extension]
	[Token(Token = "0x600006D")]
	public static IEnumerable<TSource> Distinct(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7DA1B0", Offset = "0x7D95B0", Length = "0xA6")]
	[IteratorStateMachine(typeof(<DistinctIterator>d__68`1))]
	[Token(Token = "0x600006F")]
	private static IEnumerable<TSource> DistinctIterator(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0x7DA920", Offset = "0x7D9D20", Length = "0x299")]
	[Extension]
	[Token(Token = "0x600008A")]
	public static TSource ElementAt(IEnumerable<TSource> source, int index) { }

	[Address(RVA = "0x5D49B0", Offset = "0x5D3DB0", Length = "0x75")]
	[Token(Token = "0x600008F")]
	public static IEnumerable<TResult> Empty() { }

	[Address(RVA = "0x7DCFB0", Offset = "0x7DC3B0", Length = "0x1BD")]
	[Extension]
	[Token(Token = "0x6000080")]
	public static TSource First(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x7DC660", Offset = "0x7DBA60", Length = "0x38E")]
	[Extension]
	[Token(Token = "0x600007F")]
	public static TSource First(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7DC250", Offset = "0x7DB650", Length = "0x22D")]
	[Extension]
	[Token(Token = "0x6000081")]
	public static TSource FirstOrDefault(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7DB400", Offset = "0x7DA800", Length = "0x23E")]
	[Extension]
	[Token(Token = "0x6000082")]
	public static TSource FirstOrDefault(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x7DD430", Offset = "0x7DC830", Length = "0xAB")]
	[Extension]
	[Token(Token = "0x600006C")]
	public static IEnumerable<IGrouping`2<TKey, TSource>> GroupBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[Address(RVA = "0x7DE6F0", Offset = "0x7DDAF0", Length = "0x30F")]
	[Extension]
	[Token(Token = "0x6000083")]
	public static TSource Last(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7DDD60", Offset = "0x7DD160", Length = "0x321")]
	[Extension]
	[Token(Token = "0x6000084")]
	public static TSource LastOrDefault(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7DE090", Offset = "0x7DD490", Length = "0x247")]
	[Extension]
	[Token(Token = "0x6000085")]
	public static TSource LastOrDefault(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x7DEB20", Offset = "0x7DDF20", Length = "0x53")]
	[Extension]
	[Token(Token = "0x600009E")]
	public static float Max(IEnumerable<TSource> source, Func<TSource, Single> selector) { }

	[Address(RVA = "0x22337E0", Offset = "0x2232BE0", Length = "0x240")]
	[Extension]
	[Token(Token = "0x600009B")]
	public static int Max(IEnumerable<Int32> source) { }

	[Address(RVA = "0x2233540", Offset = "0x2232940", Length = "0x294")]
	[Extension]
	[Token(Token = "0x600009C")]
	public static float Max(IEnumerable<Single> source) { }

	[Address(RVA = "0x7DEAC0", Offset = "0x7DDEC0", Length = "0x53")]
	[Extension]
	[Token(Token = "0x600009D")]
	public static int Max(IEnumerable<TSource> source, Func<TSource, Int32> selector) { }

	[Address(RVA = "0x2233A30", Offset = "0x2232E30", Length = "0x240")]
	[Extension]
	[Token(Token = "0x600009A")]
	public static int Min(IEnumerable<Int32> source) { }

	[Address(RVA = "0x7DEBF0", Offset = "0x7DDFF0", Length = "0xC6")]
	[Extension]
	[Token(Token = "0x600007B")]
	public static IEnumerable<TResult> OfType(IEnumerable source) { }

	[Address(RVA = "0x7D58D0", Offset = "0x7D4CD0", Length = "0x89")]
	[IteratorStateMachine(typeof(<OfTypeIterator>d__97`1))]
	[Token(Token = "0x600007C")]
	private static IEnumerable<TResult> OfTypeIterator(IEnumerable source) { }

	[Address(RVA = "0x7DF030", Offset = "0x7DE430", Length = "0x8B")]
	[Extension]
	[Token(Token = "0x6000068")]
	public static IOrderedEnumerable<TSource> OrderBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[Address(RVA = "0x7DF0C0", Offset = "0x7DE4C0", Length = "0x9A")]
	[Extension]
	[Token(Token = "0x6000069")]
	public static IOrderedEnumerable<TSource> OrderBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer) { }

	[Address(RVA = "0x7DED50", Offset = "0x7DE150", Length = "0x8B")]
	[Extension]
	[Token(Token = "0x600006A")]
	public static IOrderedEnumerable<TSource> OrderByDescending(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[Address(RVA = "0x2233D00", Offset = "0x2233100", Length = "0xB8")]
	[Token(Token = "0x600008B")]
	public static IEnumerable<Int32> Range(int start, int count) { }

	[Address(RVA = "0x2233C80", Offset = "0x2233080", Length = "0x72")]
	[IteratorStateMachine(typeof(<RangeIterator>d__115))]
	[Token(Token = "0x600008C")]
	private static IEnumerable<Int32> RangeIterator(int start, int count) { }

	[Address(RVA = "0x7DF3E0", Offset = "0x7DE7E0", Length = "0xC9")]
	[Token(Token = "0x600008D")]
	public static IEnumerable<TResult> Repeat(TResult element, int count) { }

	[Address(RVA = "0x7DF160", Offset = "0x7DE560", Length = "0x8C")]
	[IteratorStateMachine(typeof(<RepeatIterator>d__117`1))]
	[Token(Token = "0x600008E")]
	private static IEnumerable<TResult> RepeatIterator(TResult element, int count) { }

	[Address(RVA = "0x7DF700", Offset = "0x7DEB00", Length = "0xC7")]
	[Extension]
	[Token(Token = "0x6000072")]
	public static IEnumerable<TSource> Reverse(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7D58D0", Offset = "0x7D4CD0", Length = "0x89")]
	[IteratorStateMachine(typeof(<ReverseIterator>d__79`1))]
	[Token(Token = "0x6000073")]
	private static IEnumerable<TSource> ReverseIterator(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7DF9A0", Offset = "0x7DEDA0", Length = "0x9A")]
	[Extension]
	[Token(Token = "0x600005E")]
	public static IEnumerable<TResult> Select(IEnumerable<TSource> source, Func<TSource, Int32, TResult> selector) { }

	[Address(RVA = "0x7DFB60", Offset = "0x7DEF60", Length = "0x37D")]
	[Extension]
	[Token(Token = "0x600005D")]
	public static IEnumerable<TResult> Select(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }

	[Address(RVA = "0x7DF7D0", Offset = "0x7DEBD0", Length = "0x11D")]
	[IteratorStateMachine(typeof(<SelectIterator>d__5`2))]
	[Token(Token = "0x600005F")]
	private static IEnumerable<TResult> SelectIterator(IEnumerable<TSource> source, Func<TSource, Int32, TResult> selector) { }

	[Address(RVA = "0x7DFA40", Offset = "0x7DEE40", Length = "0x113")]
	[Extension]
	[Token(Token = "0x6000062")]
	public static IEnumerable<TResult> SelectMany(IEnumerable<TSource> source, Func<TSource, IEnumerable`1<TResult>> selector) { }

	[Address(RVA = "0x7DF8F0", Offset = "0x7DECF0", Length = "0xA6")]
	[IteratorStateMachine(typeof(<SelectManyIterator>d__17`2))]
	[Token(Token = "0x6000063")]
	private static IEnumerable<TResult> SelectManyIterator(IEnumerable<TSource> source, Func<TSource, IEnumerable`1<TResult>> selector) { }

	[Address(RVA = "0x7E05F0", Offset = "0x7DF9F0", Length = "0x4C")]
	[Extension]
	[Token(Token = "0x6000074")]
	public static bool SequenceEqual(IEnumerable<TSource> first, IEnumerable<TSource> second) { }

	[Address(RVA = "0x7E0640", Offset = "0x7DFA40", Length = "0x478")]
	[Extension]
	[Token(Token = "0x6000075")]
	public static bool SequenceEqual(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0x7E4660", Offset = "0x7E3A60", Length = "0x261")]
	[Extension]
	[Token(Token = "0x6000086")]
	public static TSource Single(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7E40E0", Offset = "0x7E34E0", Length = "0x2F0")]
	[Extension]
	[Token(Token = "0x6000087")]
	public static TSource Single(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x7E3770", Offset = "0x7E2B70", Length = "0x252")]
	[Extension]
	[Token(Token = "0x6000088")]
	public static TSource SingleOrDefault(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7E34F0", Offset = "0x7E28F0", Length = "0x276")]
	[Extension]
	[Token(Token = "0x6000089")]
	public static TSource SingleOrDefault(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x7E4A90", Offset = "0x7E3E90", Length = "0xDA")]
	[Extension]
	[Token(Token = "0x6000066")]
	public static IEnumerable<TSource> Skip(IEnumerable<TSource> source, int count) { }

	[Address(RVA = "0x7E48D0", Offset = "0x7E3CD0", Length = "0x98")]
	[IteratorStateMachine(typeof(<SkipIterator>d__31`1))]
	[Token(Token = "0x6000067")]
	private static IEnumerable<TSource> SkipIterator(IEnumerable<TSource> source, int count) { }

	[Address(RVA = "0x2233F70", Offset = "0x2233370", Length = "0x1F5")]
	[Extension]
	[Token(Token = "0x6000098")]
	public static float Sum(IEnumerable<Single> source) { }

	[Address(RVA = "0x2233DC0", Offset = "0x22331C0", Length = "0x1A7")]
	[Extension]
	[Token(Token = "0x6000097")]
	public static int Sum(IEnumerable<Int32> source) { }

	[Address(RVA = "0x7E4C50", Offset = "0x7E4050", Length = "0x53")]
	[Extension]
	[Token(Token = "0x6000099")]
	public static int Sum(IEnumerable<TSource> source, Func<TSource, Int32> selector) { }

	[Address(RVA = "0x7E4E70", Offset = "0x7E4270", Length = "0xDA")]
	[Extension]
	[Token(Token = "0x6000064")]
	public static IEnumerable<TSource> Take(IEnumerable<TSource> source, int count) { }

	[Address(RVA = "0x7E4CB0", Offset = "0x7E40B0", Length = "0x98")]
	[IteratorStateMachine(typeof(<TakeIterator>d__25`1))]
	[Token(Token = "0x6000065")]
	private static IEnumerable<TSource> TakeIterator(IEnumerable<TSource> source, int count) { }

	[Address(RVA = "0x7E4F50", Offset = "0x7E4350", Length = "0xF5")]
	[Extension]
	[Token(Token = "0x600006B")]
	public static IOrderedEnumerable<TSource> ThenBy(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[Address(RVA = "0x7E5570", Offset = "0x7E4970", Length = "0x8F")]
	[Extension]
	[Token(Token = "0x6000077")]
	public static TSource[] ToArray(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7E5B80", Offset = "0x7E4F80", Length = "0x317")]
	[Extension]
	[Token(Token = "0x600007A")]
	public static Dictionary<TKey, TElement> ToDictionary(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x7E5EA0", Offset = "0x7E52A0", Length = "0x62")]
	[Extension]
	[Token(Token = "0x6000079")]
	public static Dictionary<TKey, TElement> ToDictionary(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }

	[Address(RVA = "0x7E6790", Offset = "0x7E5B90", Length = "0x94")]
	[Extension]
	[Token(Token = "0x6000078")]
	public static List<TSource> ToList(IEnumerable<TSource> source) { }

	[Address(RVA = "0x7E7030", Offset = "0x7E6430", Length = "0x126")]
	[Extension]
	[Token(Token = "0x6000070")]
	public static IEnumerable<TSource> Union(IEnumerable<TSource> first, IEnumerable<TSource> second) { }

	[Address(RVA = "0x7E6D30", Offset = "0x7E6130", Length = "0xC5")]
	[IteratorStateMachine(typeof(<UnionIterator>d__71`1))]
	[Token(Token = "0x6000071")]
	private static IEnumerable<TSource> UnionIterator(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0x7E88D0", Offset = "0x7E7CD0", Length = "0x113")]
	[Extension]
	[Token(Token = "0x600005B")]
	public static IEnumerable<TSource> Where(IEnumerable<TSource> source, Func<TSource, Int32, Boolean> predicate) { }

	[Address(RVA = "0x7E7EB0", Offset = "0x7E72B0", Length = "0x356")]
	[Extension]
	[Token(Token = "0x600005A")]
	public static IEnumerable<TSource> Where(IEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0x7E7330", Offset = "0x7E6730", Length = "0xA6")]
	[IteratorStateMachine(typeof(<WhereIterator>d__2`1))]
	[Token(Token = "0x600005C")]
	private static IEnumerable<TSource> WhereIterator(IEnumerable<TSource> source, Func<TSource, Int32, Boolean> predicate) { }

}

