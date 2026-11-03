namespace System.Collections;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ArrayListDebugView))]
[DefaultMember("Item")]
[Token(Token = "0x20005C4")]
public class ArrayList : IList, ICollection, IEnumerable, ICloneable
{
	[Token(Token = "0x20005C8")]
	public class ArrayListDebugView
	{

	}

	[Token(Token = "0x20005C7")]
	private sealed class ArrayListEnumeratorSimple : IEnumerator, ICloneable
	{
		[Token(Token = "0x40017FA")]
		private static object s_dummyObject; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017F5")]
		private ArrayList _list; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017F6")]
		private int _index; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40017F7")]
		private int _version; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40017F8")]
		private object _currentElement; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40017F9")]
		private bool _isArrayList; //Field offset: 0x28

		[Token(Token = "0x17000682")]
		public override object Current
		{
			[Address(RVA = "0x1FBBB40", Offset = "0x1FBAF40", Length = "0xF3")]
			[Token(Token = "0x6002AB4")]
			 get { } //Length: 243
		}

		[Address(RVA = "0x1FBB9C0", Offset = "0x1FBADC0", Length = "0x73")]
		[Token(Token = "0x6002AB6")]
		private static ArrayListEnumeratorSimple() { }

		[Address(RVA = "0x1FBBA40", Offset = "0x1FBAE40", Length = "0xFB")]
		[Token(Token = "0x6002AB1")]
		internal ArrayListEnumeratorSimple(ArrayList list) { }

		[Address(RVA = "0x1F8FF70", Offset = "0x1F8F370", Length = "0x7")]
		[Token(Token = "0x6002AB2")]
		public override object Clone() { }

		[Address(RVA = "0x1FBBB40", Offset = "0x1FBAF40", Length = "0xF3")]
		[Token(Token = "0x6002AB4")]
		public override object get_Current() { }

		[Address(RVA = "0x1FBB6E0", Offset = "0x1FBAAE0", Length = "0x204")]
		[Token(Token = "0x6002AB3")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1FBB8F0", Offset = "0x1FBACF0", Length = "0xC7")]
		[Token(Token = "0x6002AB5")]
		public override void Reset() { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x20005C5")]
	private class IListWrapper : ArrayList
	{
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40017F3")]
		private IList _list; //Field offset: 0x28

		[Token(Token = "0x17000674")]
		public virtual int Capacity
		{
			[Address(RVA = "0x1FC71C0", Offset = "0x1FC65C0", Length = "0x89")]
			[Token(Token = "0x6002A7E")]
			 set { } //Length: 137
		}

		[Token(Token = "0x17000675")]
		public virtual int Count
		{
			[Address(RVA = "0x1FC6FD0", Offset = "0x1FC63D0", Length = "0x49")]
			[Token(Token = "0x6002A7F")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000677")]
		public virtual bool IsFixedSize
		{
			[Address(RVA = "0x1FC7020", Offset = "0x1FC6420", Length = "0x49")]
			[Token(Token = "0x6002A81")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000676")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x1FC7070", Offset = "0x1FC6470", Length = "0x49")]
			[Token(Token = "0x6002A80")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000678")]
		public virtual bool IsSynchronized
		{
			[Address(RVA = "0x1FC70C0", Offset = "0x1FC64C0", Length = "0x49")]
			[Token(Token = "0x6002A82")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000679")]
		public virtual object Item
		{
			[Address(RVA = "0x1FC7110", Offset = "0x1FC6510", Length = "0x54")]
			[Token(Token = "0x6002A83")]
			 get { } //Length: 84
			[Address(RVA = "0x1FC7250", Offset = "0x1FC6650", Length = "0x6D")]
			[Token(Token = "0x6002A84")]
			 set { } //Length: 109
		}

		[Token(Token = "0x1700067A")]
		public virtual object SyncRoot
		{
			[Address(RVA = "0x1FC7170", Offset = "0x1FC6570", Length = "0x49")]
			[Token(Token = "0x6002A85")]
			 get { } //Length: 73
		}

		[Address(RVA = "0x1FC6F50", Offset = "0x1FC6350", Length = "0x74")]
		[Token(Token = "0x6002A7D")]
		internal IListWrapper(IList list) { }

		[Address(RVA = "0x1FC5E40", Offset = "0x1FC5240", Length = "0x5C")]
		[Token(Token = "0x6002A86")]
		public virtual int Add(object obj) { }

		[Address(RVA = "0x1FC5DF0", Offset = "0x1FC51F0", Length = "0x49")]
		[Token(Token = "0x6002A87")]
		public virtual void AddRange(ICollection c) { }

		[Address(RVA = "0x1FC5EA0", Offset = "0x1FC52A0", Length = "0xB4")]
		[Token(Token = "0x6002A88")]
		public virtual void Clear() { }

		[Address(RVA = "0x1FC5F60", Offset = "0x1FC5360", Length = "0x58")]
		[Token(Token = "0x6002A89")]
		public virtual object Clone() { }

		[Address(RVA = "0x1FC5FC0", Offset = "0x1FC53C0", Length = "0xC3")]
		[Token(Token = "0x6002A8A")]
		public virtual bool Contains(object obj) { }

		[Address(RVA = "0x1FC6100", Offset = "0x1FC5500", Length = "0x31F")]
		[Token(Token = "0x6002A8C")]
		public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

		[Address(RVA = "0x1FC6090", Offset = "0x1FC5490", Length = "0x67")]
		[Token(Token = "0x6002A8B")]
		public virtual void CopyTo(Array array, int index) { }

		[Address(RVA = "0x1FC6FD0", Offset = "0x1FC63D0", Length = "0x49")]
		[Token(Token = "0x6002A7F")]
		public virtual int get_Count() { }

		[Address(RVA = "0x1FC7020", Offset = "0x1FC6420", Length = "0x49")]
		[Token(Token = "0x6002A81")]
		public virtual bool get_IsFixedSize() { }

		[Address(RVA = "0x1FC7070", Offset = "0x1FC6470", Length = "0x49")]
		[Token(Token = "0x6002A80")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1FC70C0", Offset = "0x1FC64C0", Length = "0x49")]
		[Token(Token = "0x6002A82")]
		public virtual bool get_IsSynchronized() { }

		[Address(RVA = "0x1FC7110", Offset = "0x1FC6510", Length = "0x54")]
		[Token(Token = "0x6002A83")]
		public virtual object get_Item(int index) { }

		[Address(RVA = "0x1FC7170", Offset = "0x1FC6570", Length = "0x49")]
		[Token(Token = "0x6002A85")]
		public virtual object get_SyncRoot() { }

		[Address(RVA = "0x1FC6420", Offset = "0x1FC5820", Length = "0x46")]
		[Token(Token = "0x6002A8D")]
		public virtual IEnumerator GetEnumerator() { }

		[Address(RVA = "0x1FC6470", Offset = "0x1FC5870", Length = "0x58")]
		[Token(Token = "0x6002A8E")]
		public virtual int IndexOf(object value) { }

		[Address(RVA = "0x1FC6810", Offset = "0x1FC5C10", Length = "0x6D")]
		[Token(Token = "0x6002A8F")]
		public virtual void Insert(int index, object obj) { }

		[Address(RVA = "0x1FC64D0", Offset = "0x1FC58D0", Length = "0x338")]
		[Token(Token = "0x6002A90")]
		public virtual void InsertRange(int index, ICollection c) { }

		[Address(RVA = "0x1FBCAE0", Offset = "0x1FBBEE0", Length = "0x44")]
		[Token(Token = "0x6002A91")]
		public virtual void Remove(object value) { }

		[Address(RVA = "0x1FC6880", Offset = "0x1FC5C80", Length = "0x5B")]
		[Token(Token = "0x6002A92")]
		public virtual void RemoveAt(int index) { }

		[Address(RVA = "0x1FC68E0", Offset = "0x1FC5CE0", Length = "0x1E9")]
		[Token(Token = "0x6002A93")]
		public virtual void RemoveRange(int index, int count) { }

		[Address(RVA = "0x1FC71C0", Offset = "0x1FC65C0", Length = "0x89")]
		[Token(Token = "0x6002A7E")]
		public virtual void set_Capacity(int value) { }

		[Address(RVA = "0x1FC7250", Offset = "0x1FC6650", Length = "0x6D")]
		[Token(Token = "0x6002A84")]
		public virtual void set_Item(int index, object value) { }

		[Address(RVA = "0x1FC6AD0", Offset = "0x1FC5ED0", Length = "0x2A6")]
		[Token(Token = "0x6002A94")]
		public virtual void Sort(int index, int count, IComparer comparer) { }

		[Address(RVA = "0x1FC6D80", Offset = "0x1FC6180", Length = "0xC5")]
		[Token(Token = "0x6002A95")]
		public virtual Object[] ToArray() { }

		[Address(RVA = "0x1FC6E50", Offset = "0x1FC6250", Length = "0xFA")]
		[Token(Token = "0x6002A96")]
		public virtual Array ToArray(Type type) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x20005C6")]
	private class ReadOnlyArrayList : ArrayList
	{
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40017F4")]
		private ArrayList _list; //Field offset: 0x28

		[Token(Token = "0x17000681")]
		public virtual int Capacity
		{
			[Address(RVA = "0x1FCBD50", Offset = "0x1FCB150", Length = "0x4E")]
			[Token(Token = "0x6002AA1")]
			 set { } //Length: 78
		}

		[Token(Token = "0x1700067B")]
		public virtual int Count
		{
			[Address(RVA = "0x1FCBC90", Offset = "0x1FCB090", Length = "0x2A")]
			[Token(Token = "0x6002A98")]
			 get { } //Length: 42
		}

		[Token(Token = "0x1700067D")]
		public virtual bool IsFixedSize
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002A9A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700067C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002A99")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700067E")]
		public virtual bool IsSynchronized
		{
			[Address(RVA = "0x1FCBCC0", Offset = "0x1FCB0C0", Length = "0x2A")]
			[Token(Token = "0x6002A9B")]
			 get { } //Length: 42
		}

		[Token(Token = "0x1700067F")]
		public virtual object Item
		{
			[Address(RVA = "0x1FCBCF0", Offset = "0x1FCB0F0", Length = "0x2A")]
			[Token(Token = "0x6002A9C")]
			 get { } //Length: 42
			[Address(RVA = "0x1FCBDA0", Offset = "0x1FCB1A0", Length = "0x4E")]
			[Token(Token = "0x6002A9D")]
			 set { } //Length: 78
		}

		[Token(Token = "0x17000680")]
		public virtual object SyncRoot
		{
			[Address(RVA = "0x1FCBD20", Offset = "0x1FCB120", Length = "0x2A")]
			[Token(Token = "0x6002A9E")]
			 get { } //Length: 42
		}

		[Address(RVA = "0x1FCBC20", Offset = "0x1FCB020", Length = "0x6C")]
		[Token(Token = "0x6002A97")]
		internal ReadOnlyArrayList(ArrayList l) { }

		[Address(RVA = "0x1FCB6F0", Offset = "0x1FCAAF0", Length = "0x4E")]
		[Token(Token = "0x6002A9F")]
		public virtual int Add(object obj) { }

		[Address(RVA = "0x1FCB6A0", Offset = "0x1FCAAA0", Length = "0x4E")]
		[Token(Token = "0x6002AA0")]
		public virtual void AddRange(ICollection c) { }

		[Address(RVA = "0x1FCB740", Offset = "0x1FCAB40", Length = "0x4E")]
		[Token(Token = "0x6002AA2")]
		public virtual void Clear() { }

		[Address(RVA = "0x1FCB790", Offset = "0x1FCAB90", Length = "0x15D")]
		[Token(Token = "0x6002AA3")]
		public virtual object Clone() { }

		[Address(RVA = "0x1FCB8F0", Offset = "0x1FCACF0", Length = "0x2A")]
		[Token(Token = "0x6002AA4")]
		public virtual bool Contains(object obj) { }

		[Address(RVA = "0x1FCB920", Offset = "0x1FCAD20", Length = "0x2F")]
		[Token(Token = "0x6002AA6")]
		public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

		[Address(RVA = "0x1FCB950", Offset = "0x1FCAD50", Length = "0x2A")]
		[Token(Token = "0x6002AA5")]
		public virtual void CopyTo(Array array, int index) { }

		[Address(RVA = "0x1FCBC90", Offset = "0x1FCB090", Length = "0x2A")]
		[Token(Token = "0x6002A98")]
		public virtual int get_Count() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002A9A")]
		public virtual bool get_IsFixedSize() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002A99")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1FCBCC0", Offset = "0x1FCB0C0", Length = "0x2A")]
		[Token(Token = "0x6002A9B")]
		public virtual bool get_IsSynchronized() { }

		[Address(RVA = "0x1FCBCF0", Offset = "0x1FCB0F0", Length = "0x2A")]
		[Token(Token = "0x6002A9C")]
		public virtual object get_Item(int index) { }

		[Address(RVA = "0x1FCBD20", Offset = "0x1FCB120", Length = "0x2A")]
		[Token(Token = "0x6002A9E")]
		public virtual object get_SyncRoot() { }

		[Address(RVA = "0x1FCB980", Offset = "0x1FCAD80", Length = "0x2A")]
		[Token(Token = "0x6002AA7")]
		public virtual IEnumerator GetEnumerator() { }

		[Address(RVA = "0x1FCB9B0", Offset = "0x1FCADB0", Length = "0x2A")]
		[Token(Token = "0x6002AA8")]
		public virtual int IndexOf(object value) { }

		[Address(RVA = "0x1FCBA30", Offset = "0x1FCAE30", Length = "0x4E")]
		[Token(Token = "0x6002AA9")]
		public virtual void Insert(int index, object obj) { }

		[Address(RVA = "0x1FCB9E0", Offset = "0x1FCADE0", Length = "0x4E")]
		[Token(Token = "0x6002AAA")]
		public virtual void InsertRange(int index, ICollection c) { }

		[Address(RVA = "0x1FCBB20", Offset = "0x1FCAF20", Length = "0x4E")]
		[Token(Token = "0x6002AAB")]
		public virtual void Remove(object value) { }

		[Address(RVA = "0x1FCBA80", Offset = "0x1FCAE80", Length = "0x4E")]
		[Token(Token = "0x6002AAC")]
		public virtual void RemoveAt(int index) { }

		[Address(RVA = "0x1FCBAD0", Offset = "0x1FCAED0", Length = "0x4E")]
		[Token(Token = "0x6002AAD")]
		public virtual void RemoveRange(int index, int count) { }

		[Address(RVA = "0x1FCBD50", Offset = "0x1FCB150", Length = "0x4E")]
		[Token(Token = "0x6002AA1")]
		public virtual void set_Capacity(int value) { }

		[Address(RVA = "0x1FCBDA0", Offset = "0x1FCB1A0", Length = "0x4E")]
		[Token(Token = "0x6002A9D")]
		public virtual void set_Item(int index, object value) { }

		[Address(RVA = "0x1FCBB70", Offset = "0x1FCAF70", Length = "0x4E")]
		[Token(Token = "0x6002AAE")]
		public virtual void Sort(int index, int count, IComparer comparer) { }

		[Address(RVA = "0x1FCBBF0", Offset = "0x1FCAFF0", Length = "0x2A")]
		[Token(Token = "0x6002AAF")]
		public virtual Object[] ToArray() { }

		[Address(RVA = "0x1FCBBC0", Offset = "0x1FCAFC0", Length = "0x2A")]
		[Token(Token = "0x6002AB0")]
		public virtual Array ToArray(Type type) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017EF")]
	private Object[] _items; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017F0")]
	private int _size; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40017F1")]
	private int _version; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017F2")]
	private object _syncRoot; //Field offset: 0x20

	[Token(Token = "0x1700066D")]
	public override int Capacity
	{
		[Address(RVA = "0x1FBD1F0", Offset = "0x1FBC5F0", Length = "0x121")]
		[Token(Token = "0x6002A5F")]
		 set { } //Length: 289
	}

	[Token(Token = "0x1700066E")]
	public override int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6002A60")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700066F")]
	public override bool IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002A61")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000670")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002A62")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000671")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002A63")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000673")]
	public override object Item
	{
		[Address(RVA = "0x1FBD0D0", Offset = "0x1FBC4D0", Length = "0xA5")]
		[Token(Token = "0x6002A65")]
		 get { } //Length: 165
		[Address(RVA = "0x1FBD320", Offset = "0x1FBC720", Length = "0xFC")]
		[Token(Token = "0x6002A66")]
		 set { } //Length: 252
	}

	[Token(Token = "0x17000672")]
	public override object SyncRoot
	{
		[Address(RVA = "0x1FBD180", Offset = "0x1FBC580", Length = "0x68")]
		[Token(Token = "0x6002A64")]
		 get { } //Length: 104
	}

	[Address(RVA = "0x1FBCE30", Offset = "0x1FBC230", Length = "0x50")]
	[Token(Token = "0x6002A5C")]
	public ArrayList() { }

	[Address(RVA = "0x1FBCE80", Offset = "0x1FBC280", Length = "0xFE")]
	[Token(Token = "0x6002A5D")]
	public ArrayList(int capacity) { }

	[Address(RVA = "0x1FBCF80", Offset = "0x1FBC380", Length = "0x140")]
	[Token(Token = "0x6002A5E")]
	public ArrayList(ICollection c) { }

	[Address(RVA = "0x1FBBC40", Offset = "0x1FBB040", Length = "0xA2")]
	[Token(Token = "0x6002A67")]
	public static ArrayList Adapter(IList list) { }

	[Address(RVA = "0x1FBBD10", Offset = "0x1FBB110", Length = "0xF1")]
	[Token(Token = "0x6002A68")]
	public override int Add(object value) { }

	[Address(RVA = "0x1FBBCF0", Offset = "0x1FBB0F0", Length = "0x1A")]
	[Token(Token = "0x6002A69")]
	public override void AddRange(ICollection c) { }

	[Address(RVA = "0xCF5010", Offset = "0xCF4410", Length = "0x31")]
	[Token(Token = "0x6002A6A")]
	public override void Clear() { }

	[Address(RVA = "0x1FBBE10", Offset = "0x1FBB210", Length = "0x16E")]
	[Token(Token = "0x6002A6B")]
	public override object Clone() { }

	[Address(RVA = "0x1FBBF80", Offset = "0x1FBB380", Length = "0xDA")]
	[Token(Token = "0x6002A6C")]
	public override bool Contains(object item) { }

	[Address(RVA = "0x1FBC060", Offset = "0x1FBB460", Length = "0x125")]
	[Token(Token = "0x6002A6F")]
	public override void CopyTo(int index, Array array, int arrayIndex, int count) { }

	[Address(RVA = "0x1FBC190", Offset = "0x1FBB590", Length = "0xB7")]
	[Token(Token = "0x6002A6E")]
	public override void CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x1FBC250", Offset = "0x1FBB650", Length = "0x17")]
	[Token(Token = "0x6002A6D")]
	public override void CopyTo(Array array) { }

	[Address(RVA = "0x1FBC270", Offset = "0x1FBB670", Length = "0x5B")]
	[Token(Token = "0x6002A70")]
	private void EnsureCapacity(int min) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6002A60")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002A61")]
	public override bool get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002A62")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002A63")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x1FBD0D0", Offset = "0x1FBC4D0", Length = "0xA5")]
	[Token(Token = "0x6002A65")]
	public override object get_Item(int index) { }

	[Address(RVA = "0x1FBD180", Offset = "0x1FBC580", Length = "0x68")]
	[Token(Token = "0x6002A64")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1FBC2D0", Offset = "0x1FBB6D0", Length = "0x127")]
	[Token(Token = "0x6002A71")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x1FBC400", Offset = "0x1FBB800", Length = "0x22")]
	[Token(Token = "0x6002A72")]
	public override int IndexOf(object value) { }

	[Address(RVA = "0x1FBC610", Offset = "0x1FBBA10", Length = "0x152")]
	[Token(Token = "0x6002A73")]
	public override void Insert(int index, object value) { }

	[Address(RVA = "0x1FBC430", Offset = "0x1FBB830", Length = "0x1D9")]
	[Token(Token = "0x6002A74")]
	public override void InsertRange(int index, ICollection c) { }

	[Address(RVA = "0x1FBC770", Offset = "0x1FBBB70", Length = "0xA2")]
	[Token(Token = "0x6002A75")]
	public static ArrayList ReadOnly(ArrayList list) { }

	[Address(RVA = "0x1FBCAE0", Offset = "0x1FBBEE0", Length = "0x44")]
	[Token(Token = "0x6002A76")]
	public override void Remove(object obj) { }

	[Address(RVA = "0x1FBC820", Offset = "0x1FBBC20", Length = "0xDE")]
	[Token(Token = "0x6002A77")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x1FBC900", Offset = "0x1FBBD00", Length = "0x1DA")]
	[Token(Token = "0x6002A78")]
	public override void RemoveRange(int index, int count) { }

	[Address(RVA = "0x1FBD1F0", Offset = "0x1FBC5F0", Length = "0x121")]
	[Token(Token = "0x6002A5F")]
	public override void set_Capacity(int value) { }

	[Address(RVA = "0x1FBD320", Offset = "0x1FBC720", Length = "0xFC")]
	[Token(Token = "0x6002A66")]
	public override void set_Item(int index, object value) { }

	[Address(RVA = "0x1FBCB30", Offset = "0x1FBBF30", Length = "0x52")]
	[Token(Token = "0x6002A79")]
	public override void Sort(IComparer comparer) { }

	[Address(RVA = "0x1FBCB90", Offset = "0x1FBBF90", Length = "0x142")]
	[Token(Token = "0x6002A7A")]
	public override void Sort(int index, int count, IComparer comparer) { }

	[Address(RVA = "0x1FBCCE0", Offset = "0x1FBC0E0", Length = "0x8E")]
	[Token(Token = "0x6002A7B")]
	public override Object[] ToArray() { }

	[Address(RVA = "0x1FBCD70", Offset = "0x1FBC170", Length = "0xBE")]
	[Token(Token = "0x6002A7C")]
	public override Array ToArray(Type type) { }

}

