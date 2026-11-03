namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001F6")]
internal static class ToLookup
{
	[CompilerGenerated]
	[Token(Token = "0x20001FD")]
	private struct <ToLookupAsync>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400130D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400130E")]
		public AsyncUniTaskMethodBuilder<ILookup`2<TKey, TSource>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400130F")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001310")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001311")]
		public Func<TSource, TKey> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001312")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001313")]
		private ArrayPool<TSource> <pool>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001314")]
		private TSource[] <array>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001315")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001316")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001317")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001318")]
		private ILookup<TKey, TSource> <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001319")]
		private int <i>5__8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400131A")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400131B")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B6A7C0", Offset = "0x1B69BC0", Length = "0xDDC")]
		[Token(Token = "0x60008BA")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B6B5A0", Offset = "0x1B6A9A0", Length = "0x87")]
		[DebuggerHidden]
		[Token(Token = "0x60008BB")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001FE")]
	private struct <ToLookupAsync>d__1 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400131C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400131D")]
		public AsyncUniTaskMethodBuilder<ILookup`2<TKey, TElement>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400131E")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400131F")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001320")]
		public Func<TSource, TKey> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001321")]
		public Func<TSource, TElement> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001322")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001323")]
		private ArrayPool<TSource> <pool>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001324")]
		private TSource[] <array>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001325")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001326")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001327")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001328")]
		private ILookup<TKey, TElement> <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001329")]
		private int <i>5__8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400132A")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400132B")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x1B6B630", Offset = "0x1B6AA30", Length = "0xDFC")]
		[Token(Token = "0x60008BC")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B6C430", Offset = "0x1B6B830", Length = "0x87")]
		[DebuggerHidden]
		[Token(Token = "0x60008BD")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001FF")]
	private struct <ToLookupAwaitAsync>d__2 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400132C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400132D")]
		public AsyncUniTaskMethodBuilder<ILookup`2<TKey, TSource>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400132E")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400132F")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001330")]
		public Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001331")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001332")]
		private ArrayPool<TSource> <pool>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001333")]
		private TSource[] <array>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001334")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001335")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001336")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001337")]
		private ILookup<TKey, TSource> <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001338")]
		private int <i>5__8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001339")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400133A")]
		private Awaiter<Lookup<TKey, TSource>> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400133B")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1B6C4C0", Offset = "0x1B6B8C0", Length = "0xFAC")]
		[Token(Token = "0x60008BE")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B6D470", Offset = "0x1B6C870", Length = "0x87")]
		[DebuggerHidden]
		[Token(Token = "0x60008BF")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000200")]
	private struct <ToLookupAwaitAsync>d__3 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400133C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400134A")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001349")]
		private int <i>5__8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001348")]
		private ILookup<TKey, TElement> <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001347")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001346")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001345")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400134B")]
		private Awaiter<Lookup<TKey, TElement>> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001344")]
		private TSource[] <array>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001342")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001341")]
		public Func<TSource, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001340")]
		public Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400133F")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400133E")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400133D")]
		public AsyncUniTaskMethodBuilder<ILookup`2<TKey, TElement>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001343")]
		private ArrayPool<TSource> <pool>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400134C")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1B6D500", Offset = "0x1B6C900", Length = "0xFCC")]
		[Token(Token = "0x60008C0")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B6E4D0", Offset = "0x1B6D8D0", Length = "0x87")]
		[DebuggerHidden]
		[Token(Token = "0x60008C1")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000201")]
	private struct <ToLookupAwaitWithCancellationAsync>d__4 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400134D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400134E")]
		public AsyncUniTaskMethodBuilder<ILookup`2<TKey, TSource>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400134F")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001350")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001351")]
		public Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001352")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001353")]
		private ArrayPool<TSource> <pool>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001354")]
		private TSource[] <array>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001355")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001356")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001357")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001358")]
		private ILookup<TKey, TSource> <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001359")]
		private int <i>5__8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400135A")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400135B")]
		private Awaiter<Lookup<TKey, TSource>> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400135C")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1B6E560", Offset = "0x1B6D960", Length = "0xFCC")]
		[Token(Token = "0x60008C2")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B6D470", Offset = "0x1B6C870", Length = "0x87")]
		[DebuggerHidden]
		[Token(Token = "0x60008C3")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000202")]
	private struct <ToLookupAwaitWithCancellationAsync>d__5 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400135D")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400136B")]
		private Awaiter<Boolean> <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400136A")]
		private int <i>5__8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001369")]
		private ILookup<TKey, TElement> <>7__wrap6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001368")]
		private int <>7__wrap5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001367")]
		private object <>7__wrap4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001366")]
		private IUniTaskAsyncEnumerator<TSource> <e>5__4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400136C")]
		private Awaiter<Lookup<TKey, TElement>> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001365")]
		private TSource[] <array>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001363")]
		public IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001362")]
		public Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001361")]
		public Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001360")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400135F")]
		public IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400135E")]
		public AsyncUniTaskMethodBuilder<ILookup`2<TKey, TElement>> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001364")]
		private ArrayPool<TSource> <pool>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400136D")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x1B6F530", Offset = "0x1B6E930", Length = "0xFDB")]
		[Token(Token = "0x60008C4")]
		private override void MoveNext() { }

		[Address(RVA = "0x1B6E4D0", Offset = "0x1B6D8D0", Length = "0x87")]
		[DebuggerHidden]
		[Token(Token = "0x60008C5")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x20001FC")]
	private class Grouping : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400130B")]
		private readonly List<TElement> elements; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400130C")]
		private TKey <Key>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700004A")]
		public private override TKey Key
		{
			[Address(RVA = "0xAC9480", Offset = "0xAC8880", Length = "0xAC")]
			[CompilerGenerated]
			[Token(Token = "0x60008B2")]
			 get { } //Length: 172
			[Address(RVA = "0x1BAC7A0", Offset = "0x1BABBA0", Length = "0xB9")]
			[CompilerGenerated]
			[Token(Token = "0x60008B3")]
			private set { } //Length: 185
		}

		[Address(RVA = "0x1C41310", Offset = "0x1C40710", Length = "0x169")]
		[Token(Token = "0x60008B4")]
		public Grouping`2(TKey key) { }

		[Address(RVA = "0x1C40DF0", Offset = "0x1C401F0", Length = "0x10A")]
		[Token(Token = "0x60008B5")]
		public void Add(TElement value) { }

		[Address(RVA = "0xAC9480", Offset = "0xAC8880", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x60008B2")]
		public override TKey get_Key() { }

		[Address(RVA = "0x1C40F00", Offset = "0x1C40300", Length = "0xD0")]
		[Token(Token = "0x60008B8")]
		public IUniTaskAsyncEnumerator<TElement> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

		[Address(RVA = "0x1C40FE0", Offset = "0x1C403E0", Length = "0xC6")]
		[Token(Token = "0x60008B6")]
		public override IEnumerator<TElement> GetEnumerator() { }

		[Address(RVA = "0x1BAC7A0", Offset = "0x1BABBA0", Length = "0xB9")]
		[CompilerGenerated]
		[Token(Token = "0x60008B3")]
		private void set_Key(TKey value) { }

		[Address(RVA = "0x1C40FE0", Offset = "0x1C403E0", Length = "0xC6")]
		[Token(Token = "0x60008B7")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x1C410B0", Offset = "0x1C404B0", Length = "0x25E")]
		[Token(Token = "0x60008B9")]
		public virtual string ToString() { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x20001F7")]
	private class Lookup : ILookup<TKey, TElement>, IEnumerable<IGrouping`2<TKey, TElement>>, IEnumerable
	{
		[CompilerGenerated]
		[Token(Token = "0x20001F8")]
		private struct <CreateAsync>d__6 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012DB")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012DC")]
			public AsyncUniTaskMethodBuilder<Lookup`2<TKey, TElement>> <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012DD")]
			public IEqualityComparer<TKey> comparer; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012DE")]
			public ArraySegment<TElement> source; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012DF")]
			public Func<TElement, UniTask`1<TKey>> keySelector; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012E0")]
			private Dictionary<TKey, Grouping`2<TKey, TElement>> <dict>5__2; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012E1")]
			private TElement[] <arr>5__3; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012E2")]
			private int <c>5__4; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012E3")]
			private int <i>5__5; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012E4")]
			private Awaiter<TKey> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x114B8E0", Offset = "0x114ACE0", Length = "0x1441")]
			[Token(Token = "0x60008AA")]
			private override void MoveNext() { }

			[Address(RVA = "0x114CD30", Offset = "0x114C130", Length = "0xC7")]
			[DebuggerHidden]
			[Token(Token = "0x60008AB")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20001F9")]
		private struct <CreateAsync>d__7 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012E5")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012E6")]
			public AsyncUniTaskMethodBuilder<Lookup`2<TKey, TElement>> <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012E7")]
			public IEqualityComparer<TKey> comparer; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012E8")]
			public ArraySegment<TSource> source; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012E9")]
			public Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012EA")]
			public Func<TSource, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012EB")]
			private Dictionary<TKey, Grouping`2<TKey, TElement>> <dict>5__2; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012EC")]
			private TSource[] <arr>5__3; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012ED")]
			private int <c>5__4; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012EE")]
			private int <i>5__5; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012EF")]
			private TKey <key>5__6; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012F0")]
			private Awaiter<TKey> <>u__1; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012F1")]
			private Awaiter<TElement> <>u__2; //Field offset: 0x0

			[Address(RVA = "0x114CE00", Offset = "0x114C200", Length = "0x1BB1")]
			[Token(Token = "0x60008AC")]
			private override void MoveNext() { }

			[Address(RVA = "0x114E9C0", Offset = "0x114DDC0", Length = "0xC7")]
			[DebuggerHidden]
			[Token(Token = "0x60008AD")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20001FA")]
		private struct <CreateAsync>d__8 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012F2")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012F3")]
			public AsyncUniTaskMethodBuilder<Lookup`2<TKey, TElement>> <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012F4")]
			public IEqualityComparer<TKey> comparer; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012F5")]
			public ArraySegment<TElement> source; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012F6")]
			public Func<TElement, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012F7")]
			public CancellationToken cancellationToken; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012F8")]
			private Dictionary<TKey, Grouping`2<TKey, TElement>> <dict>5__2; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012F9")]
			private TElement[] <arr>5__3; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012FA")]
			private int <c>5__4; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012FB")]
			private int <i>5__5; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012FC")]
			private Awaiter<TKey> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x114EA90", Offset = "0x114DE90", Length = "0x148E")]
			[Token(Token = "0x60008AE")]
			private override void MoveNext() { }

			[Address(RVA = "0x114CD30", Offset = "0x114C130", Length = "0xC7")]
			[DebuggerHidden]
			[Token(Token = "0x60008AF")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20001FB")]
		private struct <CreateAsync>d__9 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012FD")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012FE")]
			public AsyncUniTaskMethodBuilder<Lookup`2<TKey, TElement>> <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40012FF")]
			public IEqualityComparer<TKey> comparer; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001300")]
			public ArraySegment<TSource> source; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001301")]
			public Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001302")]
			public CancellationToken cancellationToken; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001303")]
			public Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001304")]
			private Dictionary<TKey, Grouping`2<TKey, TElement>> <dict>5__2; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001305")]
			private TSource[] <arr>5__3; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001306")]
			private int <c>5__4; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001307")]
			private int <i>5__5; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001308")]
			private TKey <key>5__6; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001309")]
			private Awaiter<TKey> <>u__1; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400130A")]
			private Awaiter<TElement> <>u__2; //Field offset: 0x0

			[Address(RVA = "0x114FF20", Offset = "0x114F320", Length = "0x1C44")]
			[Token(Token = "0x60008B0")]
			private override void MoveNext() { }

			[Address(RVA = "0x114E9C0", Offset = "0x114DDC0", Length = "0xC7")]
			[DebuggerHidden]
			[Token(Token = "0x60008B1")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x40012D9")]
		private static readonly Lookup<TKey, TElement> empty; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012DA")]
		private readonly Dictionary<TKey, Grouping`2<TKey, TElement>> dict; //Field offset: 0x0

		[Token(Token = "0x17000049")]
		public override int Count
		{
			[Address(RVA = "0xCF2C00", Offset = "0xCF2000", Length = "0x31")]
			[Token(Token = "0x60008A5")]
			 get { } //Length: 49
		}

		[Token(Token = "0x17000048")]
		public override IEnumerable<TElement> Item
		{
			[Address(RVA = "0xCF2C40", Offset = "0xCF2040", Length = "0x13C")]
			[Token(Token = "0x60008A4")]
			 get { } //Length: 316
		}

		[Address(RVA = "0xCF2810", Offset = "0xCF1C10", Length = "0x1BC")]
		[Token(Token = "0x60008A9")]
		private static Lookup`2() { }

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600089C")]
		private Lookup`2(Dictionary<TKey, Grouping`2<TKey, TElement>> dict) { }

		[Address(RVA = "0xCF0430", Offset = "0xCEF830", Length = "0xEA")]
		[Token(Token = "0x60008A6")]
		public override bool Contains(TKey key) { }

		[Address(RVA = "0xCF0E40", Offset = "0xCF0240", Length = "0x7C8")]
		[Token(Token = "0x600089E")]
		public static Lookup<TKey, TElement> Create(ArraySegment<TElement> source, Func<TElement, TKey> keySelector, IEqualityComparer<TKey> comparer) { }

		[Address(RVA = "0x69D100", Offset = "0x69C500", Length = "0x7E4")]
		[Token(Token = "0x600089F")]
		public static Lookup<TKey, TElement> Create(ArraySegment<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }

		[Address(RVA = "0xCF0990", Offset = "0xCEFD90", Length = "0x407")]
		[AsyncStateMachine(typeof(<CreateAsync>d__6))]
		[Token(Token = "0x60008A0")]
		public static UniTask<Lookup`2<TKey, TElement>> CreateAsync(ArraySegment<TElement> source, Func<TElement, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer) { }

		[Address(RVA = "0x69CDC0", Offset = "0x69C1C0", Length = "0x33E")]
		[AsyncStateMachine(typeof(<CreateAsync>d__7`1))]
		[Token(Token = "0x60008A1")]
		public static UniTask<Lookup`2<TKey, TElement>> CreateAsync(ArraySegment<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, Func<TSource, UniTask`1<TElement>> elementSelector, IEqualityComparer<TKey> comparer) { }

		[Address(RVA = "0xCF0520", Offset = "0xCEF920", Length = "0x46A")]
		[AsyncStateMachine(typeof(<CreateAsync>d__8))]
		[Token(Token = "0x60008A2")]
		public static UniTask<Lookup`2<TKey, TElement>> CreateAsync(ArraySegment<TElement> source, Func<TElement, CancellationToken, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x69CA30", Offset = "0x69BE30", Length = "0x388")]
		[AsyncStateMachine(typeof(<CreateAsync>d__9`1))]
		[Token(Token = "0x60008A3")]
		public static UniTask<Lookup`2<TKey, TElement>> CreateAsync(ArraySegment<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0xCF0DA0", Offset = "0xCF01A0", Length = "0x99")]
		[Token(Token = "0x600089D")]
		public static Lookup<TKey, TElement> CreateEmpty() { }

		[Address(RVA = "0xCF2C00", Offset = "0xCF2000", Length = "0x31")]
		[Token(Token = "0x60008A5")]
		public override int get_Count() { }

		[Address(RVA = "0xCF2C40", Offset = "0xCF2040", Length = "0x13C")]
		[Token(Token = "0x60008A4")]
		public override IEnumerable<TElement> get_Item(TKey key) { }

		[Address(RVA = "0xCF1730", Offset = "0xCF0B30", Length = "0xAD")]
		[Token(Token = "0x60008A7")]
		public override IEnumerator<IGrouping`2<TKey, TElement>> GetEnumerator() { }

		[Address(RVA = "0xCF1730", Offset = "0xCF0B30", Length = "0xAD")]
		[Token(Token = "0x60008A8")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}


	[Address(RVA = "0x946150", Offset = "0x945550", Length = "0x15D")]
	[AsyncStateMachine(typeof(<ToLookupAsync>d__0`2))]
	[Token(Token = "0x6000896")]
	internal static UniTask<ILookup`2<TKey, TSource>> ToLookupAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x945FF0", Offset = "0x9453F0", Length = "0x154")]
	[AsyncStateMachine(typeof(<ToLookupAsync>d__1`3))]
	[Token(Token = "0x6000897")]
	internal static UniTask<ILookup`2<TKey, TElement>> ToLookupAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x946410", Offset = "0x945810", Length = "0x165")]
	[AsyncStateMachine(typeof(<ToLookupAwaitAsync>d__2`2))]
	[Token(Token = "0x6000898")]
	internal static UniTask<ILookup`2<TKey, TSource>> ToLookupAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x9462B0", Offset = "0x9456B0", Length = "0x160")]
	[AsyncStateMachine(typeof(<ToLookupAwaitAsync>d__3`3))]
	[Token(Token = "0x6000899")]
	internal static UniTask<ILookup`2<TKey, TElement>> ToLookupAwaitAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, Func<TSource, UniTask`1<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x946410", Offset = "0x945810", Length = "0x165")]
	[AsyncStateMachine(typeof(<ToLookupAwaitWithCancellationAsync>d__4`2))]
	[Token(Token = "0x600089A")]
	internal static UniTask<ILookup`2<TKey, TSource>> ToLookupAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

	[Address(RVA = "0x9462B0", Offset = "0x9456B0", Length = "0x160")]
	[AsyncStateMachine(typeof(<ToLookupAwaitWithCancellationAsync>d__5`3))]
	[Token(Token = "0x600089B")]
	internal static UniTask<ILookup`2<TKey, TElement>> ToLookupAwaitWithCancellationAsync(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

}

