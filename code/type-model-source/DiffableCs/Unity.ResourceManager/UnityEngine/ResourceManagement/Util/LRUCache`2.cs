namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000028")]
internal struct LRUCache
{
	[Token(Token = "0x200002A")]
	internal struct Entry : IEquatable<Entry<TKey, TValue>>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007C")]
		public LinkedListNode<Key<TKey, TValue>> lruNode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007D")]
		public TValue Value; //Field offset: 0x0

		[Address(RVA = "0x1952390", Offset = "0x1951790", Length = "0x67")]
		[Token(Token = "0x6000110")]
		public override bool Equals(Entry<TKey, TValue> other) { }

		[Address(RVA = "0x1952710", Offset = "0x1951B10", Length = "0x2C")]
		[Token(Token = "0x6000111")]
		public virtual int GetHashCode() { }

	}

	[Token(Token = "0x2000029")]
	internal struct Key : IEquatable<Key<TKey, TValue>>
	{
		[Token(Token = "0x4000079")]
		private static Type typeType; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007A")]
		public TKey key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007B")]
		public Type type; //Field offset: 0x0

		[Address(RVA = "0xAD4DA0", Offset = "0xAD41A0", Length = "0xB8")]
		[Token(Token = "0x600010F")]
		private static Key() { }

		[Address(RVA = "0xAD5160", Offset = "0xAD4560", Length = "0x161")]
		[Token(Token = "0x600010C")]
		public Key(TKey k, Type t) { }

		[Address(RVA = "0xAD4810", Offset = "0xAD3C10", Length = "0x66")]
		[Token(Token = "0x600010E")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0xAD4A20", Offset = "0xAD3E20", Length = "0x7B")]
		[Token(Token = "0x600010D")]
		private override bool System.IEquatable<UnityEngine.ResourceManagement.Util.LRUCache<TKey,TValue>.Key>.Equals(Key<TKey, TValue> other) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000074")]
	public int requestHits; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000075")]
	public int requestCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000076")]
	private int entryLimit; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000077")]
	private Dictionary<Key<TKey, TValue>, Entry<TKey, TValue>> cache; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000078")]
	private LinkedList<Key<TKey, TValue>> lru; //Field offset: 0x0

	[Address(RVA = "0xAF67D0", Offset = "0xAF5BD0", Length = "0x122")]
	[Token(Token = "0x6000109")]
	public LRUCache`2(int limit) { }

	[Address(RVA = "0xAF5A50", Offset = "0xAF4E50", Length = "0x399")]
	[Token(Token = "0x600010A")]
	public bool TryAdd(TKey id, TValue obj) { }

	[Address(RVA = "0xAF6460", Offset = "0xAF5860", Length = "0x1FD")]
	[Token(Token = "0x600010B")]
	public bool TryGet(Type type, TKey id, out TValue val) { }

}

