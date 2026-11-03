namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[Token(Token = "0x2000611")]
internal class LowLevelList
{
	[Token(Token = "0x40018A7")]
	private static readonly T[] s_emptyArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40018A4")]
	protected T[] _items; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40018A5")]
	protected int _size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40018A6")]
	protected int _version; //Field offset: 0x0

	[Token(Token = "0x17000735")]
	public int Capacity
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6002D4A")]
		 get { } //Length: 26
		[Address(RVA = "0xCF6F10", Offset = "0xCF6310", Length = "0x140")]
		[Token(Token = "0x6002D4B")]
		 set { } //Length: 320
	}

	[Token(Token = "0x17000736")]
	public override int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6002D4C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000737")]
	public override T Item
	{
		[Address(RVA = "0xCF6DB0", Offset = "0xCF61B0", Length = "0x6B")]
		[Token(Token = "0x6002D4D")]
		 get { } //Length: 107
		[Address(RVA = "0xCF71D0", Offset = "0xCF65D0", Length = "0x85")]
		[Token(Token = "0x6002D4E")]
		 set { } //Length: 133
	}

	[Address(RVA = "0xB15F80", Offset = "0xB15380", Length = "0xD0")]
	[Token(Token = "0x6002D5B")]
	private static LowLevelList`1() { }

	[Address(RVA = "0xB16050", Offset = "0xB15450", Length = "0x89")]
	[Token(Token = "0x6002D48")]
	public LowLevelList`1() { }

	[Address(RVA = "0xCF6CA0", Offset = "0xCF60A0", Length = "0x107")]
	[Token(Token = "0x6002D49")]
	public LowLevelList`1(int capacity) { }

	[Address(RVA = "0xCF4E10", Offset = "0xCF4210", Length = "0x80")]
	[Token(Token = "0x6002D4F")]
	public override void Add(T item) { }

	[Address(RVA = "0xCF4DD0", Offset = "0xCF41D0", Length = "0x1A")]
	[Token(Token = "0x6002D51")]
	public void AddRange(IEnumerable<T> collection) { }

	[Address(RVA = "0xCF5010", Offset = "0xCF4410", Length = "0x31")]
	[Token(Token = "0x6002D52")]
	public override void Clear() { }

	[Address(RVA = "0xCF5050", Offset = "0xCF4450", Length = "0xA0")]
	[Token(Token = "0x6002D53")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xB106F0", Offset = "0xB0FAF0", Length = "0x2A")]
	[Token(Token = "0x6002D54")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0xCF52C0", Offset = "0xCF46C0", Length = "0x170")]
	[Token(Token = "0x6002D50")]
	private void EnsureCapacity(int min) { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x6002D4A")]
	public int get_Capacity() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6002D4C")]
	public override int get_Count() { }

	[Address(RVA = "0xCF6DB0", Offset = "0xCF61B0", Length = "0x6B")]
	[Token(Token = "0x6002D4D")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xCF54A0", Offset = "0xCF48A0", Length = "0x2D")]
	[Token(Token = "0x6002D55")]
	public override int IndexOf(T item) { }

	[Address(RVA = "0xCF5FD0", Offset = "0xCF53D0", Length = "0x106")]
	[Token(Token = "0x6002D56")]
	public override void Insert(int index, T item) { }

	[Address(RVA = "0xCF5AE0", Offset = "0xCF4EE0", Length = "0x4E7")]
	[Token(Token = "0x6002D57")]
	public void InsertRange(int index, IEnumerable<T> collection) { }

	[Address(RVA = "0xCF6A70", Offset = "0xCF5E70", Length = "0x118")]
	[Token(Token = "0x6002D58")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xCF62C0", Offset = "0xCF56C0", Length = "0x1C8")]
	[Token(Token = "0x6002D59")]
	public int RemoveAll(Predicate<T> match) { }

	[Address(RVA = "0xCF67E0", Offset = "0xCF5BE0", Length = "0xBB")]
	[Token(Token = "0x6002D5A")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0xCF6F10", Offset = "0xCF6310", Length = "0x140")]
	[Token(Token = "0x6002D4B")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xCF71D0", Offset = "0xCF65D0", Length = "0x85")]
	[Token(Token = "0x6002D4E")]
	public override void set_Item(int index, T value) { }

}

