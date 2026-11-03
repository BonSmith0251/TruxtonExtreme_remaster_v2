namespace System.Collections.Specialized;

[DefaultMember("Item")]
[Token(Token = "0x20001D7")]
public class ListDictionary : IDictionary, ICollection, IEnumerable
{
	[Token(Token = "0x20001DB")]
	internal class DictionaryNode
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000705")]
		public object key; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000706")]
		public object value; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000707")]
		public DictionaryNode next; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000BD6")]
		public DictionaryNode() { }

	}

	[Token(Token = "0x20001D8")]
	private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006FA")]
		private ListDictionary _list; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006FB")]
		private DictionaryNode _current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40006FC")]
		private int _version; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40006FD")]
		private bool _start; //Field offset: 0x24

		[Token(Token = "0x17000236")]
		public override object Current
		{
			[Address(RVA = "0x268A5E0", Offset = "0x26899E0", Length = "0xB7")]
			[Token(Token = "0x6000BC6")]
			 get { } //Length: 183
		}

		[Token(Token = "0x17000237")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x268A6A0", Offset = "0x2689AA0", Length = "0x7B")]
			[Token(Token = "0x6000BC7")]
			 get { } //Length: 123
		}

		[Token(Token = "0x17000238")]
		public override object Key
		{
			[Address(RVA = "0x268A720", Offset = "0x2689B20", Length = "0x6A")]
			[Token(Token = "0x6000BC8")]
			 get { } //Length: 106
		}

		[Token(Token = "0x17000239")]
		public override object Value
		{
			[Address(RVA = "0x268A790", Offset = "0x2689B90", Length = "0x6A")]
			[Token(Token = "0x6000BC9")]
			 get { } //Length: 106
		}

		[Address(RVA = "0x1FC9CF0", Offset = "0x1FC90F0", Length = "0x58")]
		[Token(Token = "0x6000BC5")]
		public NodeEnumerator(ListDictionary list) { }

		[Address(RVA = "0x268A5E0", Offset = "0x26899E0", Length = "0xB7")]
		[Token(Token = "0x6000BC6")]
		public override object get_Current() { }

		[Address(RVA = "0x268A6A0", Offset = "0x2689AA0", Length = "0x7B")]
		[Token(Token = "0x6000BC7")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x268A720", Offset = "0x2689B20", Length = "0x6A")]
		[Token(Token = "0x6000BC8")]
		public override object get_Key() { }

		[Address(RVA = "0x268A790", Offset = "0x2689B90", Length = "0x6A")]
		[Token(Token = "0x6000BC9")]
		public override object get_Value() { }

		[Address(RVA = "0x268A480", Offset = "0x2689880", Length = "0xC4")]
		[Token(Token = "0x6000BCA")]
		public override bool MoveNext() { }

		[Address(RVA = "0x268A550", Offset = "0x2689950", Length = "0x88")]
		[Token(Token = "0x6000BCB")]
		public override void Reset() { }

	}

	[Token(Token = "0x20001D9")]
	private class NodeKeyValueCollection : ICollection, IEnumerable
	{
		[Token(Token = "0x20001DA")]
		private class NodeKeyValueEnumerator : IEnumerator
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000700")]
			private ListDictionary _list; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000701")]
			private DictionaryNode _current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000702")]
			private int _version; //Field offset: 0x20
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4000703")]
			private bool _isKeys; //Field offset: 0x24
			[FieldOffset(Offset = "0x25")]
			[Token(Token = "0x4000704")]
			private bool _start; //Field offset: 0x25

			[Token(Token = "0x1700023D")]
			public override object Current
			{
				[Address(RVA = "0x268ABE0", Offset = "0x2689FE0", Length = "0x79")]
				[Token(Token = "0x6000BD3")]
				 get { } //Length: 121
			}

			[Address(RVA = "0x1FCA480", Offset = "0x1FC9880", Length = "0x69")]
			[Token(Token = "0x6000BD2")]
			public NodeKeyValueEnumerator(ListDictionary list, bool isKeys) { }

			[Address(RVA = "0x268ABE0", Offset = "0x2689FE0", Length = "0x79")]
			[Token(Token = "0x6000BD3")]
			public override object get_Current() { }

			[Address(RVA = "0x268AA80", Offset = "0x2689E80", Length = "0xC4")]
			[Token(Token = "0x6000BD4")]
			public override bool MoveNext() { }

			[Address(RVA = "0x268AB50", Offset = "0x2689F50", Length = "0x88")]
			[Token(Token = "0x6000BD5")]
			public override void Reset() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40006FE")]
		private ListDictionary _list; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40006FF")]
		private bool _isKeys; //Field offset: 0x18

		[Token(Token = "0x1700023A")]
		private override int System.Collections.ICollection.Count
		{
			[Address(RVA = "0x1FCA1C0", Offset = "0x1FC95C0", Length = "0x35")]
			[Token(Token = "0x6000BCE")]
			private get { } //Length: 53
		}

		[Token(Token = "0x1700023B")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000BCF")]
			private get { } //Length: 3
		}

		[Token(Token = "0x1700023C")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x268A960", Offset = "0x2689D60", Length = "0x76")]
			[Token(Token = "0x6000BD0")]
			private get { } //Length: 118
		}

		[Address(RVA = "0x1BC27C0", Offset = "0x1BC1BC0", Length = "0x44")]
		[Token(Token = "0x6000BCC")]
		public NodeKeyValueCollection(ListDictionary list, bool isKeys) { }

		[Address(RVA = "0x268A800", Offset = "0x2689C00", Length = "0x157")]
		[Token(Token = "0x6000BCD")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x1FCA1C0", Offset = "0x1FC95C0", Length = "0x35")]
		[Token(Token = "0x6000BCE")]
		private override int System.Collections.ICollection.get_Count() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BCF")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0x268A960", Offset = "0x2689D60", Length = "0x76")]
		[Token(Token = "0x6000BD0")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x268A9E0", Offset = "0x2689DE0", Length = "0x9C")]
		[Token(Token = "0x6000BD1")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006F5")]
	private DictionaryNode head; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006F6")]
	private int version; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40006F7")]
	private int count; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006F8")]
	private readonly IComparer comparer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006F9")]
	private object _syncRoot; //Field offset: 0x28

	[Token(Token = "0x1700022F")]
	public override int Count
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000BB7")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000232")]
	public override bool IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BBA")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000231")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BB9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000233")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000BBB")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700022E")]
	public override object Item
	{
		[Address(RVA = "0x2684D20", Offset = "0x2684120", Length = "0x137")]
		[Token(Token = "0x6000BB5")]
		 get { } //Length: 311
		[Address(RVA = "0x2684FB0", Offset = "0x26843B0", Length = "0x1B5")]
		[Token(Token = "0x6000BB6")]
		 set { } //Length: 437
	}

	[Token(Token = "0x17000230")]
	public override ICollection Keys
	{
		[Address(RVA = "0x2684E60", Offset = "0x2684260", Length = "0x64")]
		[Token(Token = "0x6000BB8")]
		 get { } //Length: 100
	}

	[Token(Token = "0x17000234")]
	public override object SyncRoot
	{
		[Address(RVA = "0x2684ED0", Offset = "0x26842D0", Length = "0x6B")]
		[Token(Token = "0x6000BBC")]
		 get { } //Length: 107
	}

	[Token(Token = "0x17000235")]
	public override ICollection Values
	{
		[Address(RVA = "0x2684F40", Offset = "0x2684340", Length = "0x64")]
		[Token(Token = "0x6000BBD")]
		 get { } //Length: 100
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000BB3")]
	public ListDictionary() { }

	[Address(RVA = "0x265F6A0", Offset = "0x265EAA0", Length = "0x31")]
	[Token(Token = "0x6000BB4")]
	public ListDictionary(IComparer comparer) { }

	[Address(RVA = "0x26845A0", Offset = "0x26839A0", Length = "0x1F6")]
	[Token(Token = "0x6000BBE")]
	public override void Add(object key, object value) { }

	[Address(RVA = "0x1FC9250", Offset = "0x1FC8650", Length = "0x26")]
	[Token(Token = "0x6000BBF")]
	public override void Clear() { }

	[Address(RVA = "0x26847A0", Offset = "0x2683BA0", Length = "0x11B")]
	[Token(Token = "0x6000BC0")]
	public override bool Contains(object key) { }

	[Address(RVA = "0x26848C0", Offset = "0x2683CC0", Length = "0x1E2")]
	[Token(Token = "0x6000BC1")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000BB7")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BBA")]
	public override bool get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BB9")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BBB")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x2684D20", Offset = "0x2684120", Length = "0x137")]
	[Token(Token = "0x6000BB5")]
	public override object get_Item(object key) { }

	[Address(RVA = "0x2684E60", Offset = "0x2684260", Length = "0x64")]
	[Token(Token = "0x6000BB8")]
	public override ICollection get_Keys() { }

	[Address(RVA = "0x2684ED0", Offset = "0x26842D0", Length = "0x6B")]
	[Token(Token = "0x6000BBC")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x2684F40", Offset = "0x2684340", Length = "0x64")]
	[Token(Token = "0x6000BBD")]
	public override ICollection get_Values() { }

	[Address(RVA = "0x2684AB0", Offset = "0x2683EB0", Length = "0x87")]
	[Token(Token = "0x6000BC2")]
	public override IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x2684B40", Offset = "0x2683F40", Length = "0x14F")]
	[Token(Token = "0x6000BC4")]
	public override void Remove(object key) { }

	[Address(RVA = "0x2684FB0", Offset = "0x26843B0", Length = "0x1B5")]
	[Token(Token = "0x6000BB6")]
	public override void set_Item(object key, object value) { }

	[Address(RVA = "0x2684C90", Offset = "0x2684090", Length = "0x87")]
	[Token(Token = "0x6000BC3")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

