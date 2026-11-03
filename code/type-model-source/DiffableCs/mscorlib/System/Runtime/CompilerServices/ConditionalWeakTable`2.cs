namespace System.Runtime.CompilerServices;

[Token(Token = "0x20004B1")]
public sealed class ConditionalWeakTable : IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable
{
	[Token(Token = "0x20004B2")]
	internal sealed class CreateValueCallback : MulticastDelegate
	{

		[Address(RVA = "0xDC2410", Offset = "0xDC1810", Length = "0x124")]
		[Token(Token = "0x6002177")]
		public CreateValueCallback(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6002178")]
		public override TValue Invoke(TKey key) { }

	}

	[Token(Token = "0x20004B3")]
	private sealed class Enumerator : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001298")]
		private ConditionalWeakTable<TKey, TValue> _table; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001299")]
		private int _currentIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400129A")]
		private KeyValuePair<TKey, TValue> _current; //Field offset: 0x0

		[Token(Token = "0x17000413")]
		public override KeyValuePair<TKey, TValue> Current
		{
			[Address(RVA = "0x19C7B00", Offset = "0x19C6F00", Length = "0x32")]
			[Token(Token = "0x600217D")]
			 get { } //Length: 50
		}

		[Token(Token = "0x17000414")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19C46A0", Offset = "0x19C3AA0", Length = "0x4A")]
			[Token(Token = "0x600217E")]
			private get { } //Length: 74
		}

		[Address(RVA = "0x19C7700", Offset = "0x19C6B00", Length = "0x40")]
		[Token(Token = "0x6002179")]
		public Enumerator(ConditionalWeakTable<TKey, TValue> table) { }

		[Address(RVA = "0x19BFC20", Offset = "0x19BF020", Length = "0x66")]
		[Token(Token = "0x600217B")]
		public override void Dispose() { }

		[Address(RVA = "0x19BFD60", Offset = "0x19BF160", Length = "0xB9")]
		[Token(Token = "0x600217A")]
		protected virtual void Finalize() { }

		[Address(RVA = "0x19C7B00", Offset = "0x19C6F00", Length = "0x32")]
		[Token(Token = "0x600217D")]
		public override KeyValuePair<TKey, TValue> get_Current() { }

		[Address(RVA = "0x19C04F0", Offset = "0x19BF8F0", Length = "0x27E")]
		[Token(Token = "0x600217C")]
		public override bool MoveNext() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600217F")]
		public override void Reset() { }

		[Address(RVA = "0x19C46A0", Offset = "0x19C3AA0", Length = "0x4A")]
		[Token(Token = "0x600217E")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001295")]
	private Ephemeron[] data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001296")]
	private object _lock; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001297")]
	private int size; //Field offset: 0x0

	[Address(RVA = "0x17BE7D0", Offset = "0x17BDBD0", Length = "0xC2")]
	[Token(Token = "0x600216C")]
	public ConditionalWeakTable`2() { }

	[Address(RVA = "0x17BD540", Offset = "0x17BC940", Length = "0x34B")]
	[Token(Token = "0x6002171")]
	public void Add(TKey key, TValue value) { }

	[Address(RVA = "0x17BD890", Offset = "0x17BCC90", Length = "0x47")]
	[Token(Token = "0x600216D")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x17BD8E0", Offset = "0x17BCCE0", Length = "0x175")]
	[Token(Token = "0x6002174")]
	public TValue GetValue(TKey key, CreateValueCallback<TKey, TValue> createValueCallback) { }

	[Address(RVA = "0x17BDA60", Offset = "0x17BCE60", Length = "0x61")]
	[Token(Token = "0x600216F")]
	private void RecomputeSize() { }

	[Address(RVA = "0x17BDDA0", Offset = "0x17BD1A0", Length = "0x39E")]
	[Token(Token = "0x6002170")]
	private void Rehash() { }

	[Address(RVA = "0x17BDAD0", Offset = "0x17BCED0", Length = "0x2C1")]
	[Token(Token = "0x600216E")]
	private void RehashWithoutResize() { }

	[Address(RVA = "0x17BE140", Offset = "0x17BD540", Length = "0x2AC")]
	[Token(Token = "0x6002172")]
	public bool Remove(TKey key) { }

	[Address(RVA = "0x17BE3F0", Offset = "0x17BD7F0", Length = "0x132")]
	[Token(Token = "0x6002175")]
	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0x10DA570", Offset = "0x10D9970", Length = "0x45")]
	[Token(Token = "0x6002176")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x17BE530", Offset = "0x17BD930", Length = "0x294")]
	[Token(Token = "0x6002173")]
	public bool TryGetValue(TKey key, out TValue value) { }

}

