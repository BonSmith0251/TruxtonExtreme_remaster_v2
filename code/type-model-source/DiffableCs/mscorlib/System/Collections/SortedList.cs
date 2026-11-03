namespace System.Collections;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(SortedListDebugView))]
[DefaultMember("Item")]
[Token(Token = "0x20005B9")]
public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable
{
	[DefaultMember("Item")]
	[Token(Token = "0x20005BC")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	private class KeyList : IList, ICollection, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017DD")]
		private SortedList sortedList; //Field offset: 0x10

		[Token(Token = "0x17000657")]
		public override int Count
		{
			[Address(RVA = "0xAE7E00", Offset = "0xAE7200", Length = "0x1A")]
			[Token(Token = "0x6002A11")]
			 get { } //Length: 26
		}

		[Token(Token = "0x17000659")]
		public override bool IsFixedSize
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002A13")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000658")]
		public override bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002A12")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700065A")]
		public override bool IsSynchronized
		{
			[Address(RVA = "0x1E8F300", Offset = "0x1E8E700", Length = "0x2A")]
			[Token(Token = "0x6002A14")]
			 get { } //Length: 42
		}

		[Token(Token = "0x1700065C")]
		public override object Item
		{
			[Address(RVA = "0x1FC05B0", Offset = "0x1FBF9B0", Length = "0x2A")]
			[Token(Token = "0x6002A1B")]
			 get { } //Length: 42
			[Address(RVA = "0x1FC8EF0", Offset = "0x1FC82F0", Length = "0x4E")]
			[Token(Token = "0x6002A1C")]
			 set { } //Length: 78
		}

		[Token(Token = "0x1700065B")]
		public override object SyncRoot
		{
			[Address(RVA = "0x1FC8EC0", Offset = "0x1FC82C0", Length = "0x2A")]
			[Token(Token = "0x6002A15")]
			 get { } //Length: 42
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6002A10")]
		internal KeyList(SortedList sortedList) { }

		[Address(RVA = "0x1FC8A70", Offset = "0x1FC7E70", Length = "0x4E")]
		[Token(Token = "0x6002A16")]
		public override int Add(object key) { }

		[Address(RVA = "0x1FC8AC0", Offset = "0x1FC7EC0", Length = "0x4E")]
		[Token(Token = "0x6002A17")]
		public override void Clear() { }

		[Address(RVA = "0x1FC8B10", Offset = "0x1FC7F10", Length = "0x2A")]
		[Token(Token = "0x6002A18")]
		public override bool Contains(object key) { }

		[Address(RVA = "0x1FC8B40", Offset = "0x1FC7F40", Length = "0xE7")]
		[Token(Token = "0x6002A19")]
		public override void CopyTo(Array array, int arrayIndex) { }

		[Address(RVA = "0xAE7E00", Offset = "0xAE7200", Length = "0x1A")]
		[Token(Token = "0x6002A11")]
		public override int get_Count() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002A13")]
		public override bool get_IsFixedSize() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002A12")]
		public override bool get_IsReadOnly() { }

		[Address(RVA = "0x1E8F300", Offset = "0x1E8E700", Length = "0x2A")]
		[Token(Token = "0x6002A14")]
		public override bool get_IsSynchronized() { }

		[Address(RVA = "0x1FC05B0", Offset = "0x1FBF9B0", Length = "0x2A")]
		[Token(Token = "0x6002A1B")]
		public override object get_Item(int index) { }

		[Address(RVA = "0x1FC8EC0", Offset = "0x1FC82C0", Length = "0x2A")]
		[Token(Token = "0x6002A15")]
		public override object get_SyncRoot() { }

		[Address(RVA = "0x1FC8C30", Offset = "0x1FC8030", Length = "0xA9")]
		[Token(Token = "0x6002A1D")]
		public override IEnumerator GetEnumerator() { }

		[Address(RVA = "0x1FC8CE0", Offset = "0x1FC80E0", Length = "0xEA")]
		[Token(Token = "0x6002A1E")]
		public override int IndexOf(object key) { }

		[Address(RVA = "0x1FC8DD0", Offset = "0x1FC81D0", Length = "0x4E")]
		[Token(Token = "0x6002A1A")]
		public override void Insert(int index, object value) { }

		[Address(RVA = "0x1FC8E70", Offset = "0x1FC8270", Length = "0x4E")]
		[Token(Token = "0x6002A1F")]
		public override void Remove(object key) { }

		[Address(RVA = "0x1FC8E20", Offset = "0x1FC8220", Length = "0x4E")]
		[Token(Token = "0x6002A20")]
		public override void RemoveAt(int index) { }

		[Address(RVA = "0x1FC8EF0", Offset = "0x1FC82F0", Length = "0x4E")]
		[Token(Token = "0x6002A1C")]
		public override void set_Item(int index, object value) { }

	}

	[Token(Token = "0x20005BE")]
	public class SortedListDebugView
	{

	}

	[Token(Token = "0x20005BB")]
	private class SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017D4")]
		private SortedList _sortedList; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017D5")]
		private object _key; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40017D6")]
		private object _value; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40017D7")]
		private int _index; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40017D8")]
		private int _startIndex; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40017D9")]
		private int _endIndex; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40017DA")]
		private int _version; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40017DB")]
		private bool _current; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40017DC")]
		private int _getObjectRetType; //Field offset: 0x3C

		[Token(Token = "0x17000655")]
		public override object Current
		{
			[Address(RVA = "0x1FCCAF0", Offset = "0x1FCBEF0", Length = "0xF9")]
			[Token(Token = "0x6002A0D")]
			 get { } //Length: 249
		}

		[Token(Token = "0x17000654")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x1FCCBF0", Offset = "0x1FCBFF0", Length = "0xF8")]
			[Token(Token = "0x6002A0C")]
			 get { } //Length: 248
		}

		[Token(Token = "0x17000653")]
		public override object Key
		{
			[Address(RVA = "0x1FCCCF0", Offset = "0x1FCC0F0", Length = "0xC5")]
			[Token(Token = "0x6002A0A")]
			 get { } //Length: 197
		}

		[Token(Token = "0x17000656")]
		public override object Value
		{
			[Address(RVA = "0x1FCCDC0", Offset = "0x1FCC1C0", Length = "0xC5")]
			[Token(Token = "0x6002A0E")]
			 get { } //Length: 197
		}

		[Address(RVA = "0x1FCCA70", Offset = "0x1FCBE70", Length = "0x73")]
		[Token(Token = "0x6002A08")]
		internal SortedListEnumerator(SortedList sortedList, int index, int count, int getObjRetType) { }

		[Address(RVA = "0x1F8FF70", Offset = "0x1F8F370", Length = "0x7")]
		[Token(Token = "0x6002A09")]
		public override object Clone() { }

		[Address(RVA = "0x1FCCAF0", Offset = "0x1FCBEF0", Length = "0xF9")]
		[Token(Token = "0x6002A0D")]
		public override object get_Current() { }

		[Address(RVA = "0x1FCCBF0", Offset = "0x1FCBFF0", Length = "0xF8")]
		[Token(Token = "0x6002A0C")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x1FCCCF0", Offset = "0x1FCC0F0", Length = "0xC5")]
		[Token(Token = "0x6002A0A")]
		public override object get_Key() { }

		[Address(RVA = "0x1FCCDC0", Offset = "0x1FCC1C0", Length = "0xC5")]
		[Token(Token = "0x6002A0E")]
		public override object get_Value() { }

		[Address(RVA = "0x1FCC8B0", Offset = "0x1FCBCB0", Length = "0x119")]
		[Token(Token = "0x6002A0B")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1FCC9D0", Offset = "0x1FCBDD0", Length = "0x9D")]
		[Token(Token = "0x6002A0F")]
		public override void Reset() { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x20005BA")]
	private class SyncSortedList : SortedList
	{
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40017D2")]
		private SortedList _list; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40017D3")]
		private object _root; //Field offset: 0x50

		[Token(Token = "0x1700064D")]
		public virtual int Count
		{
			[Address(RVA = "0x1FD2400", Offset = "0x1FD1800", Length = "0xAC")]
			[Token(Token = "0x60029F1")]
			 get { } //Length: 172
		}

		[Token(Token = "0x17000650")]
		public virtual bool IsFixedSize
		{
			[Address(RVA = "0x1FD24B0", Offset = "0x1FD18B0", Length = "0x2A")]
			[Token(Token = "0x60029F4")]
			 get { } //Length: 42
		}

		[Token(Token = "0x1700064F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x1FD24E0", Offset = "0x1FD18E0", Length = "0x2A")]
			[Token(Token = "0x60029F3")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000651")]
		public virtual bool IsSynchronized
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x60029F5")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000652")]
		public virtual object Item
		{
			[Address(RVA = "0x1FD2510", Offset = "0x1FD1910", Length = "0xC0")]
			[Token(Token = "0x60029F6")]
			 get { } //Length: 192
			[Address(RVA = "0x1FD25E0", Offset = "0x1FD19E0", Length = "0xBE")]
			[Token(Token = "0x60029F7")]
			 set { } //Length: 190
		}

		[Token(Token = "0x1700064E")]
		public virtual object SyncRoot
		{
			[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
			[Token(Token = "0x60029F2")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x1FD2390", Offset = "0x1FD1790", Length = "0x61")]
		[Token(Token = "0x60029F0")]
		internal SyncSortedList(SortedList list) { }

		[Address(RVA = "0x1FD1720", Offset = "0x1FD0B20", Length = "0xBE")]
		[Token(Token = "0x60029F8")]
		public virtual void Add(object key, object value) { }

		[Address(RVA = "0x1FD17E0", Offset = "0x1FD0BE0", Length = "0xA0")]
		[Token(Token = "0x60029F9")]
		public virtual void Clear() { }

		[Address(RVA = "0x1FD1890", Offset = "0x1FD0C90", Length = "0xB1")]
		[Token(Token = "0x60029FA")]
		public virtual object Clone() { }

		[Address(RVA = "0x1FD1AF0", Offset = "0x1FD0EF0", Length = "0xC2")]
		[Token(Token = "0x60029FB")]
		public virtual bool Contains(object key) { }

		[Address(RVA = "0x1FD1950", Offset = "0x1FD0D50", Length = "0xC2")]
		[Token(Token = "0x60029FC")]
		public virtual bool ContainsKey(object key) { }

		[Address(RVA = "0x1FD1A20", Offset = "0x1FD0E20", Length = "0xC2")]
		[Token(Token = "0x60029FD")]
		public virtual bool ContainsValue(object key) { }

		[Address(RVA = "0x1FD1BC0", Offset = "0x1FD0FC0", Length = "0xBE")]
		[Token(Token = "0x60029FE")]
		public virtual void CopyTo(Array array, int index) { }

		[Address(RVA = "0x1FD2400", Offset = "0x1FD1800", Length = "0xAC")]
		[Token(Token = "0x60029F1")]
		public virtual int get_Count() { }

		[Address(RVA = "0x1FD24B0", Offset = "0x1FD18B0", Length = "0x2A")]
		[Token(Token = "0x60029F4")]
		public virtual bool get_IsFixedSize() { }

		[Address(RVA = "0x1FD24E0", Offset = "0x1FD18E0", Length = "0x2A")]
		[Token(Token = "0x60029F3")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60029F5")]
		public virtual bool get_IsSynchronized() { }

		[Address(RVA = "0x1FD2510", Offset = "0x1FD1910", Length = "0xC0")]
		[Token(Token = "0x60029F6")]
		public virtual object get_Item(object key) { }

		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60029F2")]
		public virtual object get_SyncRoot() { }

		[Address(RVA = "0x1FD1C80", Offset = "0x1FD1080", Length = "0xBE")]
		[Token(Token = "0x60029FF")]
		public virtual object GetByIndex(int index) { }

		[Address(RVA = "0x1FD1D40", Offset = "0x1FD1140", Length = "0xB1")]
		[Token(Token = "0x6002A00")]
		public virtual IDictionaryEnumerator GetEnumerator() { }

		[Address(RVA = "0x1FD1EC0", Offset = "0x1FD12C0", Length = "0xBE")]
		[Token(Token = "0x6002A01")]
		public virtual object GetKey(int index) { }

		[Address(RVA = "0x1FD1E00", Offset = "0x1FD1200", Length = "0xB1")]
		[Token(Token = "0x6002A02")]
		public virtual IList GetKeyList() { }

		[Address(RVA = "0x1FD1F80", Offset = "0x1FD1380", Length = "0xB1")]
		[Token(Token = "0x6002A03")]
		public virtual IList GetValueList() { }

		[Address(RVA = "0x1FD2040", Offset = "0x1FD1440", Length = "0x123")]
		[Token(Token = "0x6002A04")]
		public virtual int IndexOfKey(object key) { }

		[Address(RVA = "0x1FD2170", Offset = "0x1FD1570", Length = "0xBB")]
		[Token(Token = "0x6002A05")]
		public virtual int IndexOfValue(object value) { }

		[Address(RVA = "0x1FD22E0", Offset = "0x1FD16E0", Length = "0xAF")]
		[Token(Token = "0x6002A07")]
		public virtual void Remove(object key) { }

		[Address(RVA = "0x1FD2230", Offset = "0x1FD1630", Length = "0xAD")]
		[Token(Token = "0x6002A06")]
		public virtual void RemoveAt(int index) { }

		[Address(RVA = "0x1FD25E0", Offset = "0x1FD19E0", Length = "0xBE")]
		[Token(Token = "0x60029F7")]
		public virtual void set_Item(object key, object value) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x20005BD")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	private class ValueList : IList, ICollection, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017DE")]
		private SortedList sortedList; //Field offset: 0x10

		[Token(Token = "0x1700065D")]
		public override int Count
		{
			[Address(RVA = "0xAE7E00", Offset = "0xAE7200", Length = "0x1A")]
			[Token(Token = "0x6002A22")]
			 get { } //Length: 26
		}

		[Token(Token = "0x1700065F")]
		public override bool IsFixedSize
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002A24")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700065E")]
		public override bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002A23")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000660")]
		public override bool IsSynchronized
		{
			[Address(RVA = "0x1E8F300", Offset = "0x1E8E700", Length = "0x2A")]
			[Token(Token = "0x6002A25")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000662")]
		public override object Item
		{
			[Address(RVA = "0x1FD2D70", Offset = "0x1FD2170", Length = "0x2A")]
			[Token(Token = "0x6002A2C")]
			 get { } //Length: 42
			[Address(RVA = "0x1FD2DA0", Offset = "0x1FD21A0", Length = "0x5DC")]
			[Token(Token = "0x6002A2D")]
			 set { } //Length: 1500
		}

		[Token(Token = "0x17000661")]
		public override object SyncRoot
		{
			[Address(RVA = "0x1FC8EC0", Offset = "0x1FC82C0", Length = "0x2A")]
			[Token(Token = "0x6002A26")]
			 get { } //Length: 42
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6002A21")]
		internal ValueList(SortedList sortedList) { }

		[Address(RVA = "0x1FD2980", Offset = "0x1FD1D80", Length = "0x4E")]
		[Token(Token = "0x6002A27")]
		public override int Add(object key) { }

		[Address(RVA = "0x1FD29D0", Offset = "0x1FD1DD0", Length = "0x4E")]
		[Token(Token = "0x6002A28")]
		public override void Clear() { }

		[Address(RVA = "0x1FD2A20", Offset = "0x1FD1E20", Length = "0x2A")]
		[Token(Token = "0x6002A29")]
		public override bool Contains(object value) { }

		[Address(RVA = "0x1FD2A50", Offset = "0x1FD1E50", Length = "0xE7")]
		[Token(Token = "0x6002A2A")]
		public override void CopyTo(Array array, int arrayIndex) { }

		[Address(RVA = "0xAE7E00", Offset = "0xAE7200", Length = "0x1A")]
		[Token(Token = "0x6002A22")]
		public override int get_Count() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002A24")]
		public override bool get_IsFixedSize() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002A23")]
		public override bool get_IsReadOnly() { }

		[Address(RVA = "0x1E8F300", Offset = "0x1E8E700", Length = "0x2A")]
		[Token(Token = "0x6002A25")]
		public override bool get_IsSynchronized() { }

		[Address(RVA = "0x1FD2D70", Offset = "0x1FD2170", Length = "0x2A")]
		[Token(Token = "0x6002A2C")]
		public override object get_Item(int index) { }

		[Address(RVA = "0x1FC8EC0", Offset = "0x1FC82C0", Length = "0x2A")]
		[Token(Token = "0x6002A26")]
		public override object get_SyncRoot() { }

		[Address(RVA = "0x1FD2B40", Offset = "0x1FD1F40", Length = "0xA9")]
		[Token(Token = "0x6002A2E")]
		public override IEnumerator GetEnumerator() { }

		[Address(RVA = "0x1FD2BF0", Offset = "0x1FD1FF0", Length = "0x87")]
		[Token(Token = "0x6002A2F")]
		public override int IndexOf(object value) { }

		[Address(RVA = "0x1FD2C80", Offset = "0x1FD2080", Length = "0x4E")]
		[Token(Token = "0x6002A2B")]
		public override void Insert(int index, object value) { }

		[Address(RVA = "0x1FD2D20", Offset = "0x1FD2120", Length = "0x4E")]
		[Token(Token = "0x6002A30")]
		public override void Remove(object value) { }

		[Address(RVA = "0x1FD2CD0", Offset = "0x1FD20D0", Length = "0x4E")]
		[Token(Token = "0x6002A31")]
		public override void RemoveAt(int index) { }

		[Address(RVA = "0x1FD2DA0", Offset = "0x1FD21A0", Length = "0x5DC")]
		[Token(Token = "0x6002A2D")]
		public override void set_Item(int index, object value) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017CA")]
	private Object[] keys; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017CB")]
	private Object[] values; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017CC")]
	private int _size; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40017CD")]
	private int version; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40017CE")]
	private IComparer comparer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40017CF")]
	private KeyList keyList; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40017D0")]
	private ValueList valueList; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40017D1")]
	private object _syncRoot; //Field offset: 0x40

	[Token(Token = "0x17000644")]
	public override int Capacity
	{
		[Address(RVA = "0x1FCE320", Offset = "0x1FCD720", Length = "0x1AC")]
		[Token(Token = "0x60029D3")]
		 set { } //Length: 428
	}

	[Token(Token = "0x17000645")]
	public override int Count
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60029D4")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000649")]
	public override bool IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60029D8")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000648")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60029D7")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700064A")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60029D9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700064C")]
	public override object Item
	{
		[Address(RVA = "0x1FCE220", Offset = "0x1FCD620", Length = "0x4E")]
		[Token(Token = "0x60029E8")]
		 get { } //Length: 78
		[Address(RVA = "0x1FCE4D0", Offset = "0x1FCD8D0", Length = "0x140")]
		[Token(Token = "0x60029E9")]
		 set { } //Length: 320
	}

	[Token(Token = "0x17000646")]
	public override ICollection Keys
	{
		[Address(RVA = "0x1FCE270", Offset = "0x1FCD670", Length = "0x14")]
		[Token(Token = "0x60029D5")]
		 get { } //Length: 20
	}

	[Token(Token = "0x1700064B")]
	public override object SyncRoot
	{
		[Address(RVA = "0x1FCE290", Offset = "0x1FCD690", Length = "0x68")]
		[Token(Token = "0x60029DA")]
		 get { } //Length: 104
	}

	[Token(Token = "0x17000647")]
	public override ICollection Values
	{
		[Address(RVA = "0x1FCE300", Offset = "0x1FCD700", Length = "0x14")]
		[Token(Token = "0x60029D6")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x1FCDEF0", Offset = "0x1FCD2F0", Length = "0x157")]
	[Token(Token = "0x60029CE")]
	public SortedList() { }

	[Address(RVA = "0x1FCE050", Offset = "0x1FCD450", Length = "0x1C0")]
	[Token(Token = "0x60029D0")]
	public SortedList(int initialCapacity) { }

	[Address(RVA = "0x1FCDEB0", Offset = "0x1FCD2B0", Length = "0x37")]
	[Token(Token = "0x60029D1")]
	public SortedList(IComparer comparer) { }

	[Address(RVA = "0x1FCCE90", Offset = "0x1FCC290", Length = "0x13E")]
	[Token(Token = "0x60029D2")]
	public override void Add(object key, object value) { }

	[Address(RVA = "0x1FCCFD0", Offset = "0x1FCC3D0", Length = "0x3D")]
	[Token(Token = "0x60029DB")]
	public override void Clear() { }

	[Address(RVA = "0x1FCD010", Offset = "0x1FCC410", Length = "0xC5")]
	[Token(Token = "0x60029DC")]
	public override object Clone() { }

	[Address(RVA = "0x1FCD0E0", Offset = "0x1FCC4E0", Length = "0x21")]
	[Token(Token = "0x60029DD")]
	public override bool Contains(object key) { }

	[Address(RVA = "0x1FCD0E0", Offset = "0x1FCC4E0", Length = "0x21")]
	[Token(Token = "0x60029DE")]
	public override bool ContainsKey(object key) { }

	[Address(RVA = "0x1FCD110", Offset = "0x1FCC510", Length = "0x21")]
	[Token(Token = "0x60029DF")]
	public override bool ContainsValue(object value) { }

	[Address(RVA = "0x1FCD140", Offset = "0x1FCC540", Length = "0x2E4")]
	[Token(Token = "0x60029E0")]
	public override void CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x1FCD430", Offset = "0x1FCC830", Length = "0x51")]
	[Token(Token = "0x60029E1")]
	private void EnsureCapacity(int min) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60029D4")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60029D8")]
	public override bool get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60029D7")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60029D9")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x1FCE220", Offset = "0x1FCD620", Length = "0x4E")]
	[Token(Token = "0x60029E8")]
	public override object get_Item(object key) { }

	[Address(RVA = "0x1FCE270", Offset = "0x1FCD670", Length = "0x14")]
	[Token(Token = "0x60029D5")]
	public override ICollection get_Keys() { }

	[Address(RVA = "0x1FCE290", Offset = "0x1FCD690", Length = "0x68")]
	[Token(Token = "0x60029DA")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1FCE300", Offset = "0x1FCD700", Length = "0x14")]
	[Token(Token = "0x60029D6")]
	public override ICollection get_Values() { }

	[Address(RVA = "0x1FCD490", Offset = "0x1FCC890", Length = "0xAF")]
	[Token(Token = "0x60029E2")]
	public override object GetByIndex(int index) { }

	[Address(RVA = "0x1FCD540", Offset = "0x1FCC940", Length = "0x86")]
	[Token(Token = "0x60029E4")]
	public override IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x1FCD650", Offset = "0x1FCCA50", Length = "0xAF")]
	[Token(Token = "0x60029E5")]
	public override object GetKey(int index) { }

	[Address(RVA = "0x1FCD5D0", Offset = "0x1FCC9D0", Length = "0x79")]
	[Token(Token = "0x60029E6")]
	public override IList GetKeyList() { }

	[Address(RVA = "0x1FCD700", Offset = "0x1FCCB00", Length = "0x79")]
	[Token(Token = "0x60029E7")]
	public override IList GetValueList() { }

	[Address(RVA = "0x1FCD780", Offset = "0x1FCCB80", Length = "0xAC")]
	[Token(Token = "0x60029EA")]
	public override int IndexOfKey(object key) { }

	[Address(RVA = "0x1FCD830", Offset = "0x1FCCC30", Length = "0x56")]
	[Token(Token = "0x60029EB")]
	public override int IndexOfValue(object value) { }

	[Address(RVA = "0x1FCD890", Offset = "0x1FCCC90", Length = "0x150")]
	[Token(Token = "0x60029CF")]
	private void Init() { }

	[Address(RVA = "0x1FCD9F0", Offset = "0x1FCCDF0", Length = "0x193")]
	[Token(Token = "0x60029EC")]
	private void Insert(int index, object key, object value) { }

	[Address(RVA = "0x1FCDCF0", Offset = "0x1FCD0F0", Length = "0x44")]
	[Token(Token = "0x60029EE")]
	public override void Remove(object key) { }

	[Address(RVA = "0x1FCDB90", Offset = "0x1FCCF90", Length = "0x157")]
	[Token(Token = "0x60029ED")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x1FCE320", Offset = "0x1FCD720", Length = "0x1AC")]
	[Token(Token = "0x60029D3")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x1FCE4D0", Offset = "0x1FCD8D0", Length = "0x140")]
	[Token(Token = "0x60029E9")]
	public override void set_Item(object key, object value) { }

	[Address(RVA = "0x1FCDD40", Offset = "0x1FCD140", Length = "0xD5")]
	[Token(Token = "0x60029EF")]
	public static SortedList Synchronized(SortedList list) { }

	[Address(RVA = "0x1FCDE20", Offset = "0x1FCD220", Length = "0x86")]
	[Token(Token = "0x60029E3")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

