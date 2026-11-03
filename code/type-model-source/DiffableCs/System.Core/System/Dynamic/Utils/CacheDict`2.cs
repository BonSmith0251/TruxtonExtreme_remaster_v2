namespace System.Dynamic.Utils;

[DefaultMember("Item")]
[Token(Token = "0x200027B")]
internal sealed class CacheDict
{
	[Token(Token = "0x200027C")]
	private sealed class Entry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000481")]
		internal readonly int _hash; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000482")]
		internal readonly TKey _key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000483")]
		internal readonly TValue _value; //Field offset: 0x0

		[Address(RVA = "0x19529A0", Offset = "0x1951DA0", Length = "0x5D")]
		[Token(Token = "0x6000C65")]
		internal Entry(int hash, TKey key, TValue value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400047F")]
	private readonly int _mask; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000480")]
	private readonly Entry<TKey, TValue>[] _entries; //Field offset: 0x0

	[Token(Token = "0x17000287")]
	internal TKey Item
	{
		[Address(RVA = "0x16BDE30", Offset = "0x16BD230", Length = "0x157")]
		[Token(Token = "0x6000C64")]
		internal set { } //Length: 343
	}

	[Address(RVA = "0x16BDD10", Offset = "0x16BD110", Length = "0x90")]
	[Token(Token = "0x6000C60")]
	internal CacheDict`2(int size) { }

	[Address(RVA = "0x16BD6B0", Offset = "0x16BCAB0", Length = "0x14E")]
	[Token(Token = "0x6000C63")]
	internal void Add(TKey key, TValue value) { }

	[Address(RVA = "0x16BD800", Offset = "0x16BCC00", Length = "0x27")]
	[Token(Token = "0x6000C61")]
	private static int AlignSize(int size) { }

	[Address(RVA = "0x16BDE30", Offset = "0x16BD230", Length = "0x157")]
	[Token(Token = "0x6000C64")]
	internal void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0x16BD830", Offset = "0x16BCC30", Length = "0xC3")]
	[Token(Token = "0x6000C62")]
	internal bool TryGetValue(TKey key, out TValue value) { }

}

