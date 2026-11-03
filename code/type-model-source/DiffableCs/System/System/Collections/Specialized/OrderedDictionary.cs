namespace System.Collections.Specialized;

[DefaultMember("Item")]
[Token(Token = "0x20001DD")]
public class OrderedDictionary : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback
{
	[Token(Token = "0x20001DE")]
	private class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000711")]
		private int _objectReturnType; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000712")]
		private IEnumerator _arrayEnumerator; //Field offset: 0x18

		[Token(Token = "0x1700024A")]
		public override object Current
		{
			[Address(RVA = "0x268B9C0", Offset = "0x268ADC0", Length = "0x20B")]
			[Token(Token = "0x6000C03")]
			 get { } //Length: 523
		}

		[Token(Token = "0x1700024B")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x268BBD0", Offset = "0x268AFD0", Length = "0x10D")]
			[Token(Token = "0x6000C04")]
			 get { } //Length: 269
		}

		[Token(Token = "0x1700024C")]
		public override object Key
		{
			[Address(RVA = "0x268BCE0", Offset = "0x268B0E0", Length = "0x83")]
			[Token(Token = "0x6000C05")]
			 get { } //Length: 131
		}

		[Token(Token = "0x1700024D")]
		public override object Value
		{
			[Address(RVA = "0x268BD70", Offset = "0x268B170", Length = "0x84")]
			[Token(Token = "0x6000C06")]
			 get { } //Length: 132
		}

		[Address(RVA = "0x268B950", Offset = "0x268AD50", Length = "0x62")]
		[Token(Token = "0x6000C02")]
		internal OrderedDictionaryEnumerator(ArrayList array, int objectReturnType) { }

		[Address(RVA = "0x268B9C0", Offset = "0x268ADC0", Length = "0x20B")]
		[Token(Token = "0x6000C03")]
		public override object get_Current() { }

		[Address(RVA = "0x268BBD0", Offset = "0x268AFD0", Length = "0x10D")]
		[Token(Token = "0x6000C04")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x268BCE0", Offset = "0x268B0E0", Length = "0x83")]
		[Token(Token = "0x6000C05")]
		public override object get_Key() { }

		[Address(RVA = "0x268BD70", Offset = "0x268B170", Length = "0x84")]
		[Token(Token = "0x6000C06")]
		public override object get_Value() { }

		[Address(RVA = "0x268B8B0", Offset = "0x268ACB0", Length = "0x46")]
		[Token(Token = "0x6000C07")]
		public override bool MoveNext() { }

		[Address(RVA = "0x268B900", Offset = "0x268AD00", Length = "0x49")]
		[Token(Token = "0x6000C08")]
		public override void Reset() { }

	}

	[Token(Token = "0x20001DF")]
	private class OrderedDictionaryKeyValueCollection : ICollection, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000713")]
		private ArrayList _objects; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000714")]
		private bool _isKeys; //Field offset: 0x18

		[Token(Token = "0x1700024E")]
		private override int System.Collections.ICollection.Count
		{
			[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
			[Token(Token = "0x6000C0B")]
			private get { } //Length: 42
		}

		[Token(Token = "0x1700024F")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000C0C")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000250")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x1FC0440", Offset = "0x1FBF840", Length = "0x2A")]
			[Token(Token = "0x6000C0D")]
			private get { } //Length: 42
		}

		[Address(RVA = "0x1BC27C0", Offset = "0x1BC1BC0", Length = "0x44")]
		[Token(Token = "0x6000C09")]
		public OrderedDictionaryKeyValueCollection(ArrayList array, bool isKeys) { }

		[Address(RVA = "0x268BE00", Offset = "0x268B200", Length = "0x32B")]
		[Token(Token = "0x6000C0A")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
		[Token(Token = "0x6000C0B")]
		private override int System.Collections.ICollection.get_Count() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C0C")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0x1FC0440", Offset = "0x1FBF840", Length = "0x2A")]
		[Token(Token = "0x6000C0D")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x268C130", Offset = "0x268B530", Length = "0x9D")]
		[Token(Token = "0x6000C0E")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400070A")]
	private ArrayList _objectsArray; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400070B")]
	private Hashtable _objectsTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400070C")]
	private int _initialCapacity; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400070D")]
	private IEqualityComparer _comparer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400070E")]
	private bool _readOnly; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400070F")]
	private object _syncRoot; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000710")]
	private SerializationInfo _siInfo; //Field offset: 0x40

	[Token(Token = "0x17000240")]
	public override int Count
	{
		[Address(RVA = "0x268CEE0", Offset = "0x268C2E0", Length = "0x30")]
		[Token(Token = "0x6000BEC")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000242")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000BEE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000248")]
	public override object Item
	{
		[Address(RVA = "0x268CF20", Offset = "0x268C320", Length = "0x39")]
		[Token(Token = "0x6000BF4")]
		 get { } //Length: 57
		[Address(RVA = "0x268D170", Offset = "0x268C570", Length = "0x2A5")]
		[Token(Token = "0x6000BF5")]
		 set { } //Length: 677
	}

	[Token(Token = "0x17000244")]
	public override ICollection Keys
	{
		[Address(RVA = "0x268CF60", Offset = "0x268C360", Length = "0x71")]
		[Token(Token = "0x6000BF0")]
		 get { } //Length: 113
	}

	[Token(Token = "0x17000245")]
	private ArrayList objectsArray
	{
		[Address(RVA = "0x268D060", Offset = "0x268C460", Length = "0x79")]
		[Token(Token = "0x6000BF1")]
		private get { } //Length: 121
	}

	[Token(Token = "0x17000246")]
	private Hashtable objectsTable
	{
		[Address(RVA = "0x268D0E0", Offset = "0x268C4E0", Length = "0x8A")]
		[Token(Token = "0x6000BF2")]
		private get { } //Length: 138
	}

	[Token(Token = "0x17000243")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BEF")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000247")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x268CD00", Offset = "0x268C100", Length = "0x6B")]
		[Token(Token = "0x6000BF3")]
		private get { } //Length: 107
	}

	[Token(Token = "0x17000241")]
	private override bool System.Collections.IDictionary.IsFixedSize
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000BED")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000249")]
	public override ICollection Values
	{
		[Address(RVA = "0x268CFE0", Offset = "0x268C3E0", Length = "0x71")]
		[Token(Token = "0x6000BF6")]
		 get { } //Length: 113
	}

	[Address(RVA = "0x268CE70", Offset = "0x268C270", Length = "0x29")]
	[Token(Token = "0x6000BE8")]
	public OrderedDictionary() { }

	[Address(RVA = "0x268CE30", Offset = "0x268C230", Length = "0x36")]
	[Token(Token = "0x6000BE9")]
	public OrderedDictionary(int capacity) { }

	[Address(RVA = "0x268CEA0", Offset = "0x268C2A0", Length = "0x40")]
	[Token(Token = "0x6000BEA")]
	public OrderedDictionary(int capacity, IEqualityComparer comparer) { }

	[Address(RVA = "0x1C48F80", Offset = "0x1C48380", Length = "0x31")]
	[Token(Token = "0x6000BEB")]
	protected OrderedDictionary(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x268C1D0", Offset = "0x268B5D0", Length = "0x12F")]
	[Token(Token = "0x6000BF7")]
	public override void Add(object key, object value) { }

	[Address(RVA = "0x268C300", Offset = "0x268B700", Length = "0xAF")]
	[Token(Token = "0x6000BF8")]
	public override void Clear() { }

	[Address(RVA = "0x268C3B0", Offset = "0x268B7B0", Length = "0x39")]
	[Token(Token = "0x6000BF9")]
	public override bool Contains(object key) { }

	[Address(RVA = "0x268C3F0", Offset = "0x268B7F0", Length = "0x48")]
	[Token(Token = "0x6000BFA")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x268CEE0", Offset = "0x268C2E0", Length = "0x30")]
	[Token(Token = "0x6000BEC")]
	public override int get_Count() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000BEE")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x268CF20", Offset = "0x268C320", Length = "0x39")]
	[Token(Token = "0x6000BF4")]
	public override object get_Item(object key) { }

	[Address(RVA = "0x268CF60", Offset = "0x268C360", Length = "0x71")]
	[Token(Token = "0x6000BF0")]
	public override ICollection get_Keys() { }

	[Address(RVA = "0x268D060", Offset = "0x268C460", Length = "0x79")]
	[Token(Token = "0x6000BF1")]
	private ArrayList get_objectsArray() { }

	[Address(RVA = "0x268D0E0", Offset = "0x268C4E0", Length = "0x8A")]
	[Token(Token = "0x6000BF2")]
	private Hashtable get_objectsTable() { }

	[Address(RVA = "0x268CFE0", Offset = "0x268C3E0", Length = "0x71")]
	[Token(Token = "0x6000BF6")]
	public override ICollection get_Values() { }

	[Address(RVA = "0x268C440", Offset = "0x268B840", Length = "0x95")]
	[Token(Token = "0x6000BFD")]
	public override IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x268C4E0", Offset = "0x268B8E0", Length = "0x1C6")]
	[Token(Token = "0x6000BFF")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x268C6B0", Offset = "0x268BAB0", Length = "0x167")]
	[Token(Token = "0x6000BFB")]
	private int IndexOfKey(object key) { }

	[Address(RVA = "0x268C820", Offset = "0x268BC20", Length = "0x399")]
	[Token(Token = "0x6000C01")]
	protected override void OnDeserialization(object sender) { }

	[Address(RVA = "0x268CBC0", Offset = "0x268BFC0", Length = "0x132")]
	[Token(Token = "0x6000BFC")]
	public override void Remove(object key) { }

	[Address(RVA = "0x268D170", Offset = "0x268C570", Length = "0x2A5")]
	[Token(Token = "0x6000BF5")]
	public override void set_Item(object key, object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BEF")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x268CD00", Offset = "0x268C100", Length = "0x6B")]
	[Token(Token = "0x6000BF3")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000BED")]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[Address(RVA = "0x268CD70", Offset = "0x268C170", Length = "0x95")]
	[Token(Token = "0x6000BFE")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x268CE10", Offset = "0x268C210", Length = "0x14")]
	[Token(Token = "0x6000C00")]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

}

