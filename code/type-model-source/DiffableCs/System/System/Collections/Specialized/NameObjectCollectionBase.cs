namespace System.Collections.Specialized;

[Token(Token = "0x20001E6")]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback
{
	[DefaultMember("Item")]
	[Token(Token = "0x20001E9")]
	internal class KeysCollection : ICollection, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000739")]
		private NameObjectCollectionBase _coll; //Field offset: 0x10

		[Token(Token = "0x17000265")]
		public override int Count
		{
			[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
			[Token(Token = "0x6000C64")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000264")]
		public string Item
		{
			[Address(RVA = "0x2610AD0", Offset = "0x260FED0", Length = "0x14")]
			[Token(Token = "0x6000C62")]
			 get { } //Length: 20
		}

		[Token(Token = "0x17000267")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000C67")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000266")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x2684520", Offset = "0x2683920", Length = "0x49")]
			[Token(Token = "0x6000C66")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000C60")]
		internal KeysCollection(NameObjectCollectionBase coll) { }

		[Address(RVA = "0x2684570", Offset = "0x2683970", Length = "0x2C")]
		[Token(Token = "0x6000C68")]
		internal KeysCollection() { }

		[Address(RVA = "0x2684160", Offset = "0x2683560", Length = "0x1E")]
		[Token(Token = "0x6000C61")]
		public override string Get(int index) { }

		[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
		[Token(Token = "0x6000C64")]
		public override int get_Count() { }

		[Address(RVA = "0x2610AD0", Offset = "0x260FED0", Length = "0x14")]
		[Token(Token = "0x6000C62")]
		public string get_Item(int index) { }

		[Address(RVA = "0x26840E0", Offset = "0x26834E0", Length = "0x7F")]
		[Token(Token = "0x6000C63")]
		public override IEnumerator GetEnumerator() { }

		[Address(RVA = "0x2684180", Offset = "0x2683580", Length = "0x392")]
		[Token(Token = "0x6000C65")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C67")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0x2684520", Offset = "0x2683920", Length = "0x49")]
		[Token(Token = "0x6000C66")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

	}

	[Token(Token = "0x20001E7")]
	public class NameObjectEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000734")]
		internal string Key; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000735")]
		internal object Value; //Field offset: 0x18

		[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
		[Token(Token = "0x6000C5B")]
		internal NameObjectEntry(string name, object value) { }

	}

	[Token(Token = "0x20001E8")]
	public class NameObjectKeysEnumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000736")]
		private int _pos; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000737")]
		private NameObjectCollectionBase _coll; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000738")]
		private int _version; //Field offset: 0x20

		[Token(Token = "0x17000263")]
		public override object Current
		{
			[Address(RVA = "0x2687A70", Offset = "0x2686E70", Length = "0xB3")]
			[Token(Token = "0x6000C5F")]
			 get { } //Length: 179
		}

		[Address(RVA = "0x2687A20", Offset = "0x2686E20", Length = "0x4D")]
		[Token(Token = "0x6000C5C")]
		internal NameObjectKeysEnumerator(NameObjectCollectionBase coll) { }

		[Address(RVA = "0x2687A70", Offset = "0x2686E70", Length = "0xB3")]
		[Token(Token = "0x6000C5F")]
		public override object get_Current() { }

		[Address(RVA = "0x26878B0", Offset = "0x2686CB0", Length = "0xD5")]
		[Token(Token = "0x6000C5D")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2687990", Offset = "0x2686D90", Length = "0x90")]
		[Token(Token = "0x6000C5E")]
		public override void Reset() { }

	}

	[Token(Token = "0x4000722")]
	private const string ReadOnlyName = "ReadOnly"; //Field offset: 0x0
	[Token(Token = "0x4000729")]
	private const string VersionName = "Version"; //Field offset: 0x0
	[Token(Token = "0x4000728")]
	private const string KeyComparerName = "KeyComparer"; //Field offset: 0x0
	[Token(Token = "0x4000727")]
	private const string ValuesName = "Values"; //Field offset: 0x0
	[Token(Token = "0x4000733")]
	private static StringComparer defaultComparer; //Field offset: 0x0
	[Token(Token = "0x4000725")]
	private const string HashCodeProviderName = "HashProvider"; //Field offset: 0x0
	[Token(Token = "0x4000724")]
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	[Token(Token = "0x4000723")]
	private const string CountName = "Count"; //Field offset: 0x0
	[Token(Token = "0x4000726")]
	private const string KeysName = "Keys"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400072A")]
	private bool _readOnly; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400072B")]
	private ArrayList _entriesArray; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400072C")]
	private IEqualityComparer _keyComparer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400072D")]
	private Hashtable _entriesTable; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400072E")]
	private NameObjectEntry _nullKeyEntry; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400072F")]
	private KeysCollection _keys; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000730")]
	private SerializationInfo _serializationInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000731")]
	private int _version; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000732")]
	private object _syncRoot; //Field offset: 0x50

	[Token(Token = "0x1700025F")]
	public override int Count
	{
		[Address(RVA = "0x1EAA5B0", Offset = "0x1EA99B0", Length = "0x2A")]
		[Token(Token = "0x6000C55")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700025E")]
	protected bool IsReadOnly
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000C4D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000262")]
	public override KeysCollection Keys
	{
		[Address(RVA = "0x2687830", Offset = "0x2686C30", Length = "0x79")]
		[Token(Token = "0x6000C59")]
		 get { } //Length: 121
	}

	[Token(Token = "0x17000261")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C58")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000260")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x2687530", Offset = "0x2686930", Length = "0x6B")]
		[Token(Token = "0x6000C57")]
		private get { } //Length: 107
	}

	[Address(RVA = "0x26875A0", Offset = "0x26869A0", Length = "0xAC")]
	[Token(Token = "0x6000C5A")]
	private static NameObjectCollectionBase() { }

	[Address(RVA = "0x1C48F80", Offset = "0x1C48380", Length = "0x31")]
	[Token(Token = "0x6000C47")]
	protected NameObjectCollectionBase(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000C46")]
	internal NameObjectCollectionBase(DBNull dummy) { }

	[Address(RVA = "0x2687690", Offset = "0x2686A90", Length = "0x5E")]
	[Token(Token = "0x6000C43")]
	protected NameObjectCollectionBase() { }

	[Address(RVA = "0x26876F0", Offset = "0x2686AF0", Length = "0x138")]
	[Token(Token = "0x6000C44")]
	protected NameObjectCollectionBase(IEqualityComparer equalityComparer) { }

	[Address(RVA = "0x2687650", Offset = "0x2686A50", Length = "0x34")]
	[Token(Token = "0x6000C45")]
	protected NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer) { }

	[Address(RVA = "0x2685910", Offset = "0x2684D10", Length = "0x1A4")]
	[Token(Token = "0x6000C4E")]
	protected void BaseAdd(string name, object value) { }

	[Address(RVA = "0x2685B80", Offset = "0x2684F80", Length = "0x9A")]
	[Token(Token = "0x6000C52")]
	protected object BaseGet(int index) { }

	[Address(RVA = "0x2685B60", Offset = "0x2684F60", Length = "0x1F")]
	[Token(Token = "0x6000C50")]
	protected object BaseGet(string name) { }

	[Address(RVA = "0x2685AC0", Offset = "0x2684EC0", Length = "0x9A")]
	[Token(Token = "0x6000C53")]
	protected string BaseGetKey(int index) { }

	[Address(RVA = "0x2685C20", Offset = "0x2685020", Length = "0x268")]
	[Token(Token = "0x6000C4F")]
	protected void BaseRemove(string name) { }

	[Address(RVA = "0x2685E90", Offset = "0x2685290", Length = "0xC3")]
	[Token(Token = "0x6000C51")]
	protected void BaseSet(string name, object value) { }

	[Address(RVA = "0x2685F60", Offset = "0x2685360", Length = "0xBE")]
	[Token(Token = "0x6000C4C")]
	private NameObjectEntry FindEntry(string key) { }

	[Address(RVA = "0x1EAA5B0", Offset = "0x1EA99B0", Length = "0x2A")]
	[Token(Token = "0x6000C55")]
	public override int get_Count() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000C4D")]
	protected bool get_IsReadOnly() { }

	[Address(RVA = "0x2687830", Offset = "0x2686C30", Length = "0x79")]
	[Token(Token = "0x6000C59")]
	public override KeysCollection get_Keys() { }

	[Address(RVA = "0x2686020", Offset = "0x2685420", Length = "0x7B")]
	[Token(Token = "0x6000C54")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x26860A0", Offset = "0x26854A0", Length = "0x775")]
	[Token(Token = "0x6000C48")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2686820", Offset = "0x2685C20", Length = "0x7F1")]
	[Token(Token = "0x6000C49")]
	public override void OnDeserialization(object sender) { }

	[Address(RVA = "0x26870F0", Offset = "0x26864F0", Length = "0xD5")]
	[Token(Token = "0x6000C4B")]
	private void Reset(int capacity) { }

	[Address(RVA = "0x2687020", Offset = "0x2686420", Length = "0xC4")]
	[Token(Token = "0x6000C4A")]
	private void Reset() { }

	[Address(RVA = "0x26871D0", Offset = "0x26865D0", Length = "0x352")]
	[Token(Token = "0x6000C56")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C58")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x2687530", Offset = "0x2686930", Length = "0x6B")]
	[Token(Token = "0x6000C57")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

}

