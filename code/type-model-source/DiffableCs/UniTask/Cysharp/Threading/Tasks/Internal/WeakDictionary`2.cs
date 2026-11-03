namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x200022F")]
internal class WeakDictionary
{
	[Token(Token = "0x2000230")]
	private class Entry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FB")]
		public WeakReference<TKey> Key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FC")]
		public TValue Value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FD")]
		public int Hash; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FE")]
		public Entry<TKey, TValue> Prev; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FF")]
		public Entry<TKey, TValue> Next; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C86")]
		public Entry() { }

		[Address(RVA = "0x1952350", Offset = "0x1951750", Length = "0x37")]
		[Token(Token = "0x6000C85")]
		private int Count() { }

		[Address(RVA = "0x1952880", Offset = "0x1951C80", Length = "0x11E")]
		[Token(Token = "0x6000C84")]
		public virtual string ToString() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005F6")]
	private Entry<TKey, TValue>[] buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005F7")]
	private int size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005F8")]
	private SpinLock gate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005F9")]
	private readonly float loadFactor; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005FA")]
	private readonly IEqualityComparer<TKey> keyEqualityComparer; //Field offset: 0x0

	[Address(RVA = "0x1419CF0", Offset = "0x14190F0", Length = "0x111")]
	[Token(Token = "0x6000C79")]
	public WeakDictionary`2(int capacity = 4, float loadFactor = 0.75, IEqualityComparer<TKey> keyComparer = null) { }

	[Address(RVA = "0x14171C0", Offset = "0x14165C0", Length = "0x46D")]
	[Token(Token = "0x6000C7E")]
	private bool AddToBuckets(Entry<TKey, TValue>[] targetBuckets, TKey newKey, TValue value, int keyHash) { }

	[Address(RVA = "0x1417630", Offset = "0x1416A30", Length = "0x40")]
	[Token(Token = "0x6000C83")]
	private static int CalculateCapacity(int collectionSize, float loadFactor) { }

	[Address(RVA = "0x1417670", Offset = "0x1416A70", Length = "0x12D")]
	[Token(Token = "0x6000C80")]
	private void Remove(int hashIndex, Entry<TKey, TValue> entry) { }

	[Address(RVA = "0x1417E10", Offset = "0x1417210", Length = "0xA8")]
	[Token(Token = "0x6000C81")]
	public List<KeyValuePair`2<TKey, TValue>> ToList() { }

	[Address(RVA = "0x1417AA0", Offset = "0x1416EA0", Length = "0x2AC")]
	[Token(Token = "0x6000C82")]
	public int ToList(ref List<KeyValuePair`2<TKey, TValue>>& list, bool clear = true) { }

	[Address(RVA = "0x14188B0", Offset = "0x1417CB0", Length = "0x13F")]
	[Token(Token = "0x6000C7A")]
	public bool TryAdd(TKey key, TValue value) { }

	[Address(RVA = "0x1418680", Offset = "0x1417A80", Length = "0x228")]
	[Token(Token = "0x6000C7D")]
	private bool TryAddInternal(TKey key, TValue value) { }

	[Address(RVA = "0x1418BB0", Offset = "0x1417FB0", Length = "0x19B")]
	[Token(Token = "0x6000C7F")]
	private bool TryGetEntry(TKey key, out int hashIndex, out Entry<TKey, TValue> entry) { }

	[Address(RVA = "0x1419130", Offset = "0x1418530", Length = "0x42F")]
	[Token(Token = "0x6000C7B")]
	public bool TryGetValue(TKey key, out TValue value) { }

	[Address(RVA = "0x1419560", Offset = "0x1418960", Length = "0x4FE")]
	[Token(Token = "0x6000C7C")]
	public bool TryRemove(TKey key) { }

}

