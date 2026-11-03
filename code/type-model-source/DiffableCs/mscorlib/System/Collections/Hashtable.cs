namespace System.Collections;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(HashtableDebugView))]
[DefaultMember("Item")]
[Token(Token = "0x20005C9")]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable
{
	[Token(Token = "0x20005CA")]
	private struct bucket
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001807")]
		public object key; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001808")]
		public object val; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001809")]
		public int hash_coll; //Field offset: 0x10

	}

	[Token(Token = "0x20005CF")]
	public class HashtableDebugView
	{

	}

	[Token(Token = "0x20005CE")]
	private class HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400180D")]
		private Hashtable _hashtable; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400180E")]
		private int _bucket; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400180F")]
		private int _version; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001810")]
		private bool _current; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4001811")]
		private int _getObjectRetType; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001812")]
		private object _currentKey; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001813")]
		private object _currentValue; //Field offset: 0x30

		[Token(Token = "0x1700069C")]
		public override object Current
		{
			[Address(RVA = "0x1FC2890", Offset = "0x1FC1C90", Length = "0xF9")]
			[Token(Token = "0x6002B0A")]
			 get { } //Length: 249
		}

		[Token(Token = "0x1700069B")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x1FC2990", Offset = "0x1FC1D90", Length = "0x94")]
			[Token(Token = "0x6002B09")]
			 get { } //Length: 148
		}

		[Token(Token = "0x1700069A")]
		public override object Key
		{
			[Address(RVA = "0x1FC2A30", Offset = "0x1FC1E30", Length = "0x65")]
			[Token(Token = "0x6002B07")]
			 get { } //Length: 101
		}

		[Token(Token = "0x1700069D")]
		public override object Value
		{
			[Address(RVA = "0x1FC2AA0", Offset = "0x1FC1EA0", Length = "0x65")]
			[Token(Token = "0x6002B0B")]
			 get { } //Length: 101
		}

		[Address(RVA = "0x1FC2820", Offset = "0x1FC1C20", Length = "0x6A")]
		[Token(Token = "0x6002B05")]
		internal HashtableEnumerator(Hashtable hashtable, int getObjRetType) { }

		[Address(RVA = "0x1F8FF70", Offset = "0x1F8F370", Length = "0x7")]
		[Token(Token = "0x6002B06")]
		public override object Clone() { }

		[Address(RVA = "0x1FC2890", Offset = "0x1FC1C90", Length = "0xF9")]
		[Token(Token = "0x6002B0A")]
		public override object get_Current() { }

		[Address(RVA = "0x1FC2990", Offset = "0x1FC1D90", Length = "0x94")]
		[Token(Token = "0x6002B09")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x1FC2A30", Offset = "0x1FC1E30", Length = "0x65")]
		[Token(Token = "0x6002B07")]
		public override object get_Key() { }

		[Address(RVA = "0x1FC2AA0", Offset = "0x1FC1EA0", Length = "0x65")]
		[Token(Token = "0x6002B0B")]
		public override object get_Value() { }

		[Address(RVA = "0x1FC2610", Offset = "0x1FC1A10", Length = "0x13E")]
		[Token(Token = "0x6002B08")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1FC2750", Offset = "0x1FC1B50", Length = "0xC3")]
		[Token(Token = "0x6002B0C")]
		public override void Reset() { }

	}

	[Token(Token = "0x20005CB")]
	private class KeyCollection : ICollection, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400180A")]
		private Hashtable _hashtable; //Field offset: 0x10

		[Token(Token = "0x1700068E")]
		public override int Count
		{
			[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
			[Token(Token = "0x6002AE8")]
			 get { } //Length: 26
		}

		[Token(Token = "0x1700068C")]
		public override bool IsSynchronized
		{
			[Address(RVA = "0x1FC8A10", Offset = "0x1FC7E10", Length = "0x2A")]
			[Token(Token = "0x6002AE6")]
			 get { } //Length: 42
		}

		[Token(Token = "0x1700068D")]
		public override object SyncRoot
		{
			[Address(RVA = "0x1FC8A40", Offset = "0x1FC7E40", Length = "0x2A")]
			[Token(Token = "0x6002AE7")]
			 get { } //Length: 42
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6002AE3")]
		internal KeyCollection(Hashtable hashtable) { }

		[Address(RVA = "0x1FC8740", Offset = "0x1FC7B40", Length = "0x22C")]
		[Token(Token = "0x6002AE4")]
		public override void CopyTo(Array array, int arrayIndex) { }

		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6002AE8")]
		public override int get_Count() { }

		[Address(RVA = "0x1FC8A10", Offset = "0x1FC7E10", Length = "0x2A")]
		[Token(Token = "0x6002AE6")]
		public override bool get_IsSynchronized() { }

		[Address(RVA = "0x1FC8A40", Offset = "0x1FC7E40", Length = "0x2A")]
		[Token(Token = "0x6002AE7")]
		public override object get_SyncRoot() { }

		[Address(RVA = "0x1FC8970", Offset = "0x1FC7D70", Length = "0x93")]
		[Token(Token = "0x6002AE5")]
		public override IEnumerator GetEnumerator() { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x20005CD")]
	private class SyncHashtable : Hashtable, IEnumerable
	{
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400180C")]
		protected Hashtable _table; //Field offset: 0x50

		[Token(Token = "0x17000692")]
		public virtual int Count
		{
			[Address(RVA = "0x1FD1350", Offset = "0x1FD0750", Length = "0x2A")]
			[Token(Token = "0x6002AF2")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000694")]
		public virtual bool IsFixedSize
		{
			[Address(RVA = "0x1FD1380", Offset = "0x1FD0780", Length = "0x2A")]
			[Token(Token = "0x6002AF4")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000693")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x1FD13B0", Offset = "0x1FD07B0", Length = "0x2A")]
			[Token(Token = "0x6002AF3")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000695")]
		public virtual bool IsSynchronized
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002AF5")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000696")]
		public virtual object Item
		{
			[Address(RVA = "0x1FD13E0", Offset = "0x1FD07E0", Length = "0x2A")]
			[Token(Token = "0x6002AF6")]
			 get { } //Length: 42
			[Address(RVA = "0x1FD1620", Offset = "0x1FD0A20", Length = "0xF5")]
			[Token(Token = "0x6002AF7")]
			 set { } //Length: 245
		}

		[Token(Token = "0x17000698")]
		public virtual ICollection Keys
		{
			[Address(RVA = "0x1FD1410", Offset = "0x1FD0810", Length = "0xEE")]
			[Token(Token = "0x6002B01")]
			 get { } //Length: 238
		}

		[Token(Token = "0x17000697")]
		public virtual object SyncRoot
		{
			[Address(RVA = "0x1FD1500", Offset = "0x1FD0900", Length = "0x2A")]
			[Token(Token = "0x6002AF8")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000699")]
		public virtual ICollection Values
		{
			[Address(RVA = "0x1FD1530", Offset = "0x1FD0930", Length = "0xEE")]
			[Token(Token = "0x6002B02")]
			 get { } //Length: 238
		}

		[Address(RVA = "0x1FD1310", Offset = "0x1FD0710", Length = "0x31")]
		[Token(Token = "0x6002AEF")]
		internal SyncHashtable(Hashtable table) { }

		[Address(RVA = "0x1FD12B0", Offset = "0x1FD06B0", Length = "0x54")]
		[Token(Token = "0x6002AF0")]
		internal SyncHashtable(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x1FD0BA0", Offset = "0x1FCFFA0", Length = "0xF5")]
		[Token(Token = "0x6002AF9")]
		public virtual void Add(object key, object value) { }

		[Address(RVA = "0x1FD0CA0", Offset = "0x1FD00A0", Length = "0xD6")]
		[Token(Token = "0x6002AFA")]
		public virtual void Clear() { }

		[Address(RVA = "0x1FD0D80", Offset = "0x1FD0180", Length = "0x1E2")]
		[Token(Token = "0x6002AFE")]
		public virtual object Clone() { }

		[Address(RVA = "0x1FD1020", Offset = "0x1FD0420", Length = "0x2A")]
		[Token(Token = "0x6002AFB")]
		public virtual bool Contains(object key) { }

		[Address(RVA = "0x1FD0F70", Offset = "0x1FD0370", Length = "0xA1")]
		[Token(Token = "0x6002AFC")]
		public virtual bool ContainsKey(object key) { }

		[Address(RVA = "0x1FD1050", Offset = "0x1FD0450", Length = "0xF5")]
		[Token(Token = "0x6002AFD")]
		public virtual void CopyTo(Array array, int arrayIndex) { }

		[Address(RVA = "0x1FD1350", Offset = "0x1FD0750", Length = "0x2A")]
		[Token(Token = "0x6002AF2")]
		public virtual int get_Count() { }

		[Address(RVA = "0x1FD1380", Offset = "0x1FD0780", Length = "0x2A")]
		[Token(Token = "0x6002AF4")]
		public virtual bool get_IsFixedSize() { }

		[Address(RVA = "0x1FD13B0", Offset = "0x1FD07B0", Length = "0x2A")]
		[Token(Token = "0x6002AF3")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002AF5")]
		public virtual bool get_IsSynchronized() { }

		[Address(RVA = "0x1FD13E0", Offset = "0x1FD07E0", Length = "0x2A")]
		[Token(Token = "0x6002AF6")]
		public virtual object get_Item(object key) { }

		[Address(RVA = "0x1FD1410", Offset = "0x1FD0810", Length = "0xEE")]
		[Token(Token = "0x6002B01")]
		public virtual ICollection get_Keys() { }

		[Address(RVA = "0x1FD1500", Offset = "0x1FD0900", Length = "0x2A")]
		[Token(Token = "0x6002AF8")]
		public virtual object get_SyncRoot() { }

		[Address(RVA = "0x1FD1530", Offset = "0x1FD0930", Length = "0xEE")]
		[Token(Token = "0x6002B02")]
		public virtual ICollection get_Values() { }

		[Address(RVA = "0x1FD1150", Offset = "0x1FD0550", Length = "0x2A")]
		[Token(Token = "0x6002B00")]
		public virtual IDictionaryEnumerator GetEnumerator() { }

		[Address(RVA = "0x1FD1180", Offset = "0x1FD0580", Length = "0x3E")]
		[Token(Token = "0x6002AF1")]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002B04")]
		public virtual void OnDeserialization(object sender) { }

		[Address(RVA = "0x1FD11C0", Offset = "0x1FD05C0", Length = "0xE5")]
		[Token(Token = "0x6002B03")]
		public virtual void Remove(object key) { }

		[Address(RVA = "0x1FD1620", Offset = "0x1FD0A20", Length = "0xF5")]
		[Token(Token = "0x6002AF7")]
		public virtual void set_Item(object key, object value) { }

		[Address(RVA = "0x1FD1150", Offset = "0x1FD0550", Length = "0x2A")]
		[Token(Token = "0x6002AFF")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x20005CC")]
	private class ValueCollection : ICollection, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400180B")]
		private Hashtable _hashtable; //Field offset: 0x10

		[Token(Token = "0x17000691")]
		public override int Count
		{
			[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
			[Token(Token = "0x6002AEE")]
			 get { } //Length: 26
		}

		[Token(Token = "0x1700068F")]
		public override bool IsSynchronized
		{
			[Address(RVA = "0x1FC8A10", Offset = "0x1FC7E10", Length = "0x2A")]
			[Token(Token = "0x6002AEC")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000690")]
		public override object SyncRoot
		{
			[Address(RVA = "0x1FC8A40", Offset = "0x1FC7E40", Length = "0x2A")]
			[Token(Token = "0x6002AED")]
			 get { } //Length: 42
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6002AE9")]
		internal ValueCollection(Hashtable hashtable) { }

		[Address(RVA = "0x1FD26A0", Offset = "0x1FD1AA0", Length = "0x230")]
		[Token(Token = "0x6002AEA")]
		public override void CopyTo(Array array, int arrayIndex) { }

		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6002AEE")]
		public override int get_Count() { }

		[Address(RVA = "0x1FC8A10", Offset = "0x1FC7E10", Length = "0x2A")]
		[Token(Token = "0x6002AEC")]
		public override bool get_IsSynchronized() { }

		[Address(RVA = "0x1FC8A40", Offset = "0x1FC7E40", Length = "0x2A")]
		[Token(Token = "0x6002AED")]
		public override object get_SyncRoot() { }

		[Address(RVA = "0x1FD28E0", Offset = "0x1FD1CE0", Length = "0x93")]
		[Token(Token = "0x6002AEB")]
		public override IEnumerator GetEnumerator() { }

	}

	[Token(Token = "0x4001806")]
	private static ConditionalWeakTable<Object, SerializationInfo> s_serializationInfoTable; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017FB")]
	private bucket[] _buckets; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017FC")]
	private int _count; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40017FD")]
	private int _occupancy; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017FE")]
	private int _loadsize; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40017FF")]
	private float _loadFactor; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001800")]
	private int _version; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001801")]
	private bool _isWriterInProgress; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001802")]
	private ICollection _keys; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001803")]
	private ICollection _values; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001804")]
	private IEqualityComparer _keycomparer; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001805")]
	private object _syncRoot; //Field offset: 0x48

	[Token(Token = "0x1700068B")]
	public override int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6002ADF")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000686")]
	public override bool IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002AD6")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000685")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002AD5")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000687")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002AD7")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000684")]
	public override object Item
	{
		[Address(RVA = "0x1FC56D0", Offset = "0x1FC4AD0", Length = "0x242")]
		[Token(Token = "0x6002ACC")]
		 get { } //Length: 578
		[Address(RVA = "0x1FC5DD0", Offset = "0x1FC51D0", Length = "0x1A")]
		[Token(Token = "0x6002ACD")]
		 set { } //Length: 26
	}

	[Token(Token = "0x17000688")]
	public override ICollection Keys
	{
		[Address(RVA = "0x1FC5920", Offset = "0x1FC4D20", Length = "0x79")]
		[Token(Token = "0x6002AD9")]
		 get { } //Length: 121
	}

	[Token(Token = "0x17000683")]
	private static ConditionalWeakTable<Object, SerializationInfo> SerializationInfoTable
	{
		[Address(RVA = "0x1FC59A0", Offset = "0x1FC4DA0", Length = "0x4A")]
		[Token(Token = "0x6002AB7")]
		private get { } //Length: 74
	}

	[Token(Token = "0x1700068A")]
	public override object SyncRoot
	{
		[Address(RVA = "0x1FC59F0", Offset = "0x1FC4DF0", Length = "0x68")]
		[Token(Token = "0x6002ADE")]
		 get { } //Length: 104
	}

	[Token(Token = "0x17000689")]
	public override ICollection Values
	{
		[Address(RVA = "0x1FC5A60", Offset = "0x1FC4E60", Length = "0x79")]
		[Token(Token = "0x6002ADA")]
		 get { } //Length: 121
	}

	[Address(RVA = "0x1FC5240", Offset = "0x1FC4640", Length = "0xA1")]
	[Token(Token = "0x6002AC1")]
	protected Hashtable(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002AB8")]
	internal Hashtable(bool trash) { }

	[Address(RVA = "0x1FC52F0", Offset = "0x1FC46F0", Length = "0x12")]
	[Token(Token = "0x6002AB9")]
	public Hashtable() { }

	[Address(RVA = "0x1FC5230", Offset = "0x1FC4630", Length = "0x10")]
	[Token(Token = "0x6002ABA")]
	public Hashtable(int capacity) { }

	[Address(RVA = "0x1FC5390", Offset = "0x1FC4790", Length = "0x27A")]
	[Token(Token = "0x6002ABB")]
	public Hashtable(int capacity, float loadFactor) { }

	[Address(RVA = "0x1FC5310", Offset = "0x1FC4710", Length = "0x32")]
	[Token(Token = "0x6002ABC")]
	public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[Address(RVA = "0x1FC50A0", Offset = "0x1FC44A0", Length = "0xB6")]
	[Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
	[Token(Token = "0x6002ABD")]
	public Hashtable(IHashCodeProvider hcp, IComparer comparer) { }

	[Address(RVA = "0x1FC5060", Offset = "0x1FC4460", Length = "0x3C")]
	[Token(Token = "0x6002ABE")]
	public Hashtable(IEqualityComparer equalityComparer) { }

	[Address(RVA = "0x1FC5350", Offset = "0x1FC4750", Length = "0x3A")]
	[Token(Token = "0x6002ABF")]
	public Hashtable(int capacity, IEqualityComparer equalityComparer) { }

	[Address(RVA = "0x1FC5160", Offset = "0x1FC4560", Length = "0xC2")]
	[Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
	[Token(Token = "0x6002AC0")]
	public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	[Address(RVA = "0x1FC2B10", Offset = "0x1FC1F10", Length = "0x1A")]
	[Token(Token = "0x6002AC3")]
	public override void Add(object key, object value) { }

	[Address(RVA = "0x1FC2B30", Offset = "0x1FC1F30", Length = "0x12A")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6002AC4")]
	public override void Clear() { }

	[Address(RVA = "0x1FC2C60", Offset = "0x1FC2060", Length = "0x113")]
	[Token(Token = "0x6002AC5")]
	public override object Clone() { }

	[Address(RVA = "0x1FC2F10", Offset = "0x1FC2310", Length = "0x14")]
	[Token(Token = "0x6002AC6")]
	public override bool Contains(object key) { }

	[Address(RVA = "0x1FC2D80", Offset = "0x1FC2180", Length = "0x18E")]
	[Token(Token = "0x6002AC7")]
	public override bool ContainsKey(object key) { }

	[Address(RVA = "0x1FC2F30", Offset = "0x1FC2330", Length = "0x11D")]
	[Token(Token = "0x6002AC9")]
	private void CopyEntries(Array array, int arrayIndex) { }

	[Address(RVA = "0x1FC3050", Offset = "0x1FC2450", Length = "0x96")]
	[Token(Token = "0x6002AC8")]
	private void CopyKeys(Array array, int arrayIndex) { }

	[Address(RVA = "0x1FC30F0", Offset = "0x1FC24F0", Length = "0x2BF")]
	[Token(Token = "0x6002ACA")]
	public override void CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x1FC33B0", Offset = "0x1FC27B0", Length = "0x9A")]
	[Token(Token = "0x6002ACB")]
	private void CopyValues(Array array, int arrayIndex) { }

	[Address(RVA = "0x1FC5610", Offset = "0x1FC4A10", Length = "0xBE")]
	[Token(Token = "0x6002ACE")]
	private void expand() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6002ADF")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002AD6")]
	public override bool get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002AD5")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002AD7")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x1FC56D0", Offset = "0x1FC4AD0", Length = "0x242")]
	[Token(Token = "0x6002ACC")]
	public override object get_Item(object key) { }

	[Address(RVA = "0x1FC5920", Offset = "0x1FC4D20", Length = "0x79")]
	[Token(Token = "0x6002AD9")]
	public override ICollection get_Keys() { }

	[Address(RVA = "0x1FC59A0", Offset = "0x1FC4DA0", Length = "0x4A")]
	[Token(Token = "0x6002AB7")]
	private static ConditionalWeakTable<Object, SerializationInfo> get_SerializationInfoTable() { }

	[Address(RVA = "0x1FC59F0", Offset = "0x1FC4DF0", Length = "0x68")]
	[Token(Token = "0x6002ADE")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1FC5A60", Offset = "0x1FC4E60", Length = "0x79")]
	[Token(Token = "0x6002ADA")]
	public override ICollection get_Values() { }

	[Address(RVA = "0x1FC3450", Offset = "0x1FC2850", Length = "0x8F")]
	[Token(Token = "0x6002AD3")]
	public override IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x1FC34E0", Offset = "0x1FC28E0", Length = "0x85")]
	[Token(Token = "0x6002AD4")]
	protected override int GetHash(object key) { }

	[Address(RVA = "0x1FC3570", Offset = "0x1FC2970", Length = "0x584")]
	[Token(Token = "0x6002AE1")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1FC3B00", Offset = "0x1FC2F00", Length = "0x50")]
	[Token(Token = "0x6002AC2")]
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	[Address(RVA = "0x1FC3B50", Offset = "0x1FC2F50", Length = "0x5F5")]
	[Token(Token = "0x6002ADB")]
	private void Insert(object key, object nvalue, bool add) { }

	[Address(RVA = "0x1FC4150", Offset = "0x1FC3550", Length = "0x137")]
	[Token(Token = "0x6002AD8")]
	protected override bool KeyEquals(object item, object key) { }

	[Address(RVA = "0x1FC4290", Offset = "0x1FC3690", Length = "0x98C")]
	[Token(Token = "0x6002AE2")]
	public override void OnDeserialization(object sender) { }

	[Address(RVA = "0x1FC5AE0", Offset = "0x1FC4EE0", Length = "0x148")]
	[Token(Token = "0x6002ADC")]
	private void putEntry(bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[Address(RVA = "0x1FC5DA0", Offset = "0x1FC51A0", Length = "0x21")]
	[Token(Token = "0x6002ACF")]
	private void rehash() { }

	[Address(RVA = "0x1FC5C30", Offset = "0x1FC5030", Length = "0x16E")]
	[Token(Token = "0x6002AD1")]
	private void rehash(int newsize) { }

	[Address(RVA = "0x1FC4C20", Offset = "0x1FC4020", Length = "0x2CA")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6002ADD")]
	public override void Remove(object key) { }

	[Address(RVA = "0x1FC5DD0", Offset = "0x1FC51D0", Length = "0x1A")]
	[Token(Token = "0x6002ACD")]
	public override void set_Item(object key, object value) { }

	[Address(RVA = "0x1FC4EF0", Offset = "0x1FC42F0", Length = "0xAE")]
	[Token(Token = "0x6002AE0")]
	public static Hashtable Synchronized(Hashtable table) { }

	[Address(RVA = "0x1FC4FA0", Offset = "0x1FC43A0", Length = "0x8F")]
	[Token(Token = "0x6002AD2")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x1FC5030", Offset = "0x1FC4430", Length = "0x2B")]
	[Token(Token = "0x6002AD0")]
	private void UpdateVersion() { }

}

