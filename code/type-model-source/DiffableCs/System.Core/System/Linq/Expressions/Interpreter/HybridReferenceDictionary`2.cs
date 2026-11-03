namespace System.Linq.Expressions.Interpreter;

[DefaultMember("Item")]
[Token(Token = "0x2000247")]
internal class HybridReferenceDictionary
{
	[CompilerGenerated]
	[Token(Token = "0x2000248")]
	private sealed class <GetEnumeratorWorker>d__7 : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000414")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000415")]
		private KeyValuePair<TKey, TValue> <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000416")]
		public HybridReferenceDictionary<TKey, TValue> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000417")]
		private int <i>5__2; //Field offset: 0x0

		[Token(Token = "0x17000247")]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
		{
			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x6000B1D")]
			private get { } //Length: 11
		}

		[Token(Token = "0x17000248")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1808200", Offset = "0x1807600", Length = "0x2B")]
			[DebuggerHidden]
			[Token(Token = "0x6000B1F")]
			private get { } //Length: 43
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000B1A")]
		public <GetEnumeratorWorker>d__7(int <>1__state) { }

		[Address(RVA = "0x1807DC0", Offset = "0x18071C0", Length = "0xB0")]
		[Token(Token = "0x6000B1C")]
		private override bool MoveNext() { }

		[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
		[DebuggerHidden]
		[Token(Token = "0x6000B1D")]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }

		[Address(RVA = "0x1808200", Offset = "0x1807600", Length = "0x2B")]
		[DebuggerHidden]
		[Token(Token = "0x6000B1F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6000B1E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000B1B")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000412")]
	private KeyValuePair<TKey, TValue>[] _keysAndValues; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000413")]
	private Dictionary<TKey, TValue> _dict; //Field offset: 0x0

	[Token(Token = "0x17000246")]
	public TValue Item
	{
		[Address(RVA = "0x1C728A0", Offset = "0x1C71CA0", Length = "0x12F")]
		[Token(Token = "0x6000B17")]
		 get { } //Length: 303
		[Address(RVA = "0x1C729D0", Offset = "0x1C71DD0", Length = "0x30A")]
		[Token(Token = "0x6000B18")]
		 set { } //Length: 778
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000B19")]
	public HybridReferenceDictionary`2() { }

	[Address(RVA = "0x1C71EC0", Offset = "0x1C712C0", Length = "0x72")]
	[Token(Token = "0x6000B14")]
	public bool ContainsKey(TKey key) { }

	[Address(RVA = "0x1C728A0", Offset = "0x1C71CA0", Length = "0x12F")]
	[Token(Token = "0x6000B17")]
	public TValue get_Item(TKey key) { }

	[Address(RVA = "0x1C72180", Offset = "0x1C71580", Length = "0x122")]
	[Token(Token = "0x6000B15")]
	public IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	[Address(RVA = "0x1C72010", Offset = "0x1C71410", Length = "0x8C")]
	[IteratorStateMachine(typeof(<GetEnumeratorWorker>d__7))]
	[Token(Token = "0x6000B16")]
	private IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumeratorWorker() { }

	[Address(RVA = "0x1C72410", Offset = "0x1C71810", Length = "0x7C")]
	[Token(Token = "0x6000B13")]
	public void Remove(TKey key) { }

	[Address(RVA = "0x1C729D0", Offset = "0x1C71DD0", Length = "0x30A")]
	[Token(Token = "0x6000B18")]
	public void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0x1C72490", Offset = "0x1C71890", Length = "0x8C")]
	[Token(Token = "0x6000B12")]
	public bool TryGetValue(TKey key, out TValue value) { }

}

