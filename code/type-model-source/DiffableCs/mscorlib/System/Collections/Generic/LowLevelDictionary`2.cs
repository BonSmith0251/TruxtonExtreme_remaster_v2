namespace System.Collections.Generic;

[DefaultMember("Item")]
[Token(Token = "0x2000605")]
internal class LowLevelDictionary
{
	[Token(Token = "0x2000607")]
	private sealed class DefaultComparer : IEqualityComparer<T>
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002D12")]
		public DefaultComparer`1() { }

		[Address(RVA = "0x17D3160", Offset = "0x17D2560", Length = "0x129")]
		[Token(Token = "0x6002D10")]
		public override bool Equals(T x, T y) { }

		[Address(RVA = "0x17D3520", Offset = "0x17D2920", Length = "0x3C")]
		[Token(Token = "0x6002D11")]
		public override int GetHashCode(T obj) { }

	}

	[Token(Token = "0x2000606")]
	private sealed class Entry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400188F")]
		public TKey _key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001890")]
		public TValue _value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001891")]
		public Entry<TKey, TValue> _next; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002D0F")]
		public Entry() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400188B")]
	private Entry<TKey, TValue>[] _buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400188C")]
	private int _numEntries; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400188D")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400188E")]
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0

	[Token(Token = "0x1700072A")]
	public TKey Item
	{
		[Address(RVA = "0xCF4770", Offset = "0xCF3B70", Length = "0x224")]
		[Token(Token = "0x6002D08")]
		 set { } //Length: 548
	}

	[Address(RVA = "0xCF4230", Offset = "0xCF3630", Length = "0xE5")]
	[Token(Token = "0x6002D06")]
	public LowLevelDictionary`2() { }

	[Address(RVA = "0xCF4420", Offset = "0xCF3820", Length = "0x9E")]
	[Token(Token = "0x6002D07")]
	public LowLevelDictionary`2(int capacity, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xCF2F70", Offset = "0xCF2370", Length = "0x5E")]
	[Token(Token = "0x6002D09")]
	public void Clear(int capacity = 17) { }

	[Address(RVA = "0xCF2FD0", Offset = "0xCF23D0", Length = "0x14C")]
	[Token(Token = "0x6002D0D")]
	private void ExpandBuckets() { }

	[Address(RVA = "0xCF35E0", Offset = "0xCF29E0", Length = "0xD8")]
	[Token(Token = "0x6002D0B")]
	private Entry<TKey, TValue> Find(TKey key) { }

	[Address(RVA = "0xCF37E0", Offset = "0xCF2BE0", Length = "0xF3")]
	[Token(Token = "0x6002D0E")]
	private int GetBucket(TKey key, int numBuckets = 0) { }

	[Address(RVA = "0xCF3C80", Offset = "0xCF3080", Length = "0x133")]
	[Token(Token = "0x6002D0A")]
	public bool Remove(TKey key) { }

	[Address(RVA = "0xCF4770", Offset = "0xCF3B70", Length = "0x224")]
	[Token(Token = "0x6002D08")]
	public void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xCF3DC0", Offset = "0xCF31C0", Length = "0x14D")]
	[Token(Token = "0x6002D0C")]
	private Entry<TKey, TValue> UncheckedAdd(TKey key, TValue value) { }

}

