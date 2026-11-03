namespace System.Collections;

[DefaultMember("Item")]
[Token(Token = "0x20005AC")]
internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable
{
	[Token(Token = "0x20005B0")]
	private class DictionaryNode
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017B6")]
		public object key; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017B7")]
		public object value; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40017B8")]
		public DictionaryNode next; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002988")]
		public DictionaryNode() { }

	}

	[Token(Token = "0x20005AD")]
	private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017AB")]
		private ListDictionaryInternal list; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017AC")]
		private DictionaryNode current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40017AD")]
		private int version; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40017AE")]
		private bool start; //Field offset: 0x24

		[Token(Token = "0x17000628")]
		public override object Current
		{
			[Address(RVA = "0x1FC9D50", Offset = "0x1FC9150", Length = "0xCC")]
			[Token(Token = "0x6002978")]
			 get { } //Length: 204
		}

		[Token(Token = "0x17000629")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x1FC9E20", Offset = "0x1FC9220", Length = "0x96")]
			[Token(Token = "0x6002979")]
			 get { } //Length: 150
		}

		[Token(Token = "0x1700062A")]
		public override object Key
		{
			[Address(RVA = "0x1FC9EC0", Offset = "0x1FC92C0", Length = "0x6A")]
			[Token(Token = "0x600297A")]
			 get { } //Length: 106
		}

		[Token(Token = "0x1700062B")]
		public override object Value
		{
			[Address(RVA = "0x1FC9F30", Offset = "0x1FC9330", Length = "0x6A")]
			[Token(Token = "0x600297B")]
			 get { } //Length: 106
		}

		[Address(RVA = "0x1FC9CF0", Offset = "0x1FC90F0", Length = "0x58")]
		[Token(Token = "0x6002977")]
		public NodeEnumerator(ListDictionaryInternal list) { }

		[Address(RVA = "0x1FC9D50", Offset = "0x1FC9150", Length = "0xCC")]
		[Token(Token = "0x6002978")]
		public override object get_Current() { }

		[Address(RVA = "0x1FC9E20", Offset = "0x1FC9220", Length = "0x96")]
		[Token(Token = "0x6002979")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x1FC9EC0", Offset = "0x1FC92C0", Length = "0x6A")]
		[Token(Token = "0x600297A")]
		public override object get_Key() { }

		[Address(RVA = "0x1FC9F30", Offset = "0x1FC9330", Length = "0x6A")]
		[Token(Token = "0x600297B")]
		public override object get_Value() { }

		[Address(RVA = "0x1FC9B90", Offset = "0x1FC8F90", Length = "0xC4")]
		[Token(Token = "0x600297C")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1FC9C60", Offset = "0x1FC9060", Length = "0x88")]
		[Token(Token = "0x600297D")]
		public override void Reset() { }

	}

	[Token(Token = "0x20005AE")]
	private class NodeKeyValueCollection : ICollection, IEnumerable
	{
		[Token(Token = "0x20005AF")]
		private class NodeKeyValueEnumerator : IEnumerator
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40017B1")]
			private ListDictionaryInternal list; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40017B2")]
			private DictionaryNode current; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40017B3")]
			private int version; //Field offset: 0x20
			[FieldOffset(Offset = "0x24")]
			[Token(Token = "0x40017B4")]
			private bool isKeys; //Field offset: 0x24
			[FieldOffset(Offset = "0x25")]
			[Token(Token = "0x40017B5")]
			private bool start; //Field offset: 0x25

			[Token(Token = "0x1700062F")]
			public override object Current
			{
				[Address(RVA = "0x1FCA4F0", Offset = "0x1FC98F0", Length = "0x79")]
				[Token(Token = "0x6002985")]
				 get { } //Length: 121
			}

			[Address(RVA = "0x1FCA480", Offset = "0x1FC9880", Length = "0x69")]
			[Token(Token = "0x6002984")]
			public NodeKeyValueEnumerator(ListDictionaryInternal list, bool isKeys) { }

			[Address(RVA = "0x1FCA4F0", Offset = "0x1FC98F0", Length = "0x79")]
			[Token(Token = "0x6002985")]
			public override object get_Current() { }

			[Address(RVA = "0x1FCA320", Offset = "0x1FC9720", Length = "0xC4")]
			[Token(Token = "0x6002986")]
			public override bool MoveNext() { }

			[Address(RVA = "0x1FCA3F0", Offset = "0x1FC97F0", Length = "0x88")]
			[Token(Token = "0x6002987")]
			public override void Reset() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017AF")]
		private ListDictionaryInternal list; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017B0")]
		private bool isKeys; //Field offset: 0x18

		[Token(Token = "0x1700062C")]
		private override int System.Collections.ICollection.Count
		{
			[Address(RVA = "0x1FCA1C0", Offset = "0x1FC95C0", Length = "0x35")]
			[Token(Token = "0x6002980")]
			private get { } //Length: 53
		}

		[Token(Token = "0x1700062D")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6002981")]
			private get { } //Length: 3
		}

		[Token(Token = "0x1700062E")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x1FCA200", Offset = "0x1FC9600", Length = "0x73")]
			[Token(Token = "0x6002982")]
			private get { } //Length: 115
		}

		[Address(RVA = "0x1BC27C0", Offset = "0x1BC1BC0", Length = "0x44")]
		[Token(Token = "0x600297E")]
		public NodeKeyValueCollection(ListDictionaryInternal list, bool isKeys) { }

		[Address(RVA = "0x1FC9FA0", Offset = "0x1FC93A0", Length = "0x211")]
		[Token(Token = "0x600297F")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x1FCA1C0", Offset = "0x1FC95C0", Length = "0x35")]
		[Token(Token = "0x6002980")]
		private override int System.Collections.ICollection.get_Count() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002981")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0x1FCA200", Offset = "0x1FC9600", Length = "0x73")]
		[Token(Token = "0x6002982")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x1FCA280", Offset = "0x1FC9680", Length = "0x9C")]
		[Token(Token = "0x6002983")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017A7")]
	private DictionaryNode head; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017A8")]
	private int version; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40017A9")]
	private int count; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017AA")]
	private object _syncRoot; //Field offset: 0x20

	[Token(Token = "0x17000621")]
	public override int Count
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6002969")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000624")]
	public override bool IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600296C")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000623")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600296B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000625")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600296D")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000620")]
	public override object Item
	{
		[Address(RVA = "0x1FC97E0", Offset = "0x1FC8BE0", Length = "0xCC")]
		[Token(Token = "0x6002967")]
		 get { } //Length: 204
		[Address(RVA = "0x1FC9A00", Offset = "0x1FC8E00", Length = "0x18F")]
		[Token(Token = "0x6002968")]
		 set { } //Length: 399
	}

	[Token(Token = "0x17000622")]
	public override ICollection Keys
	{
		[Address(RVA = "0x1FC98B0", Offset = "0x1FC8CB0", Length = "0x64")]
		[Token(Token = "0x600296A")]
		 get { } //Length: 100
	}

	[Token(Token = "0x17000626")]
	public override object SyncRoot
	{
		[Address(RVA = "0x1FC9920", Offset = "0x1FC8D20", Length = "0x68")]
		[Token(Token = "0x600296E")]
		 get { } //Length: 104
	}

	[Token(Token = "0x17000627")]
	public override ICollection Values
	{
		[Address(RVA = "0x1FC9990", Offset = "0x1FC8D90", Length = "0x64")]
		[Token(Token = "0x600296F")]
		 get { } //Length: 100
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002966")]
	public ListDictionaryInternal() { }

	[Address(RVA = "0x1FC9070", Offset = "0x1FC8470", Length = "0x1DF")]
	[Token(Token = "0x6002970")]
	public override void Add(object key, object value) { }

	[Address(RVA = "0x1FC9250", Offset = "0x1FC8650", Length = "0x26")]
	[Token(Token = "0x6002971")]
	public override void Clear() { }

	[Address(RVA = "0x1FC9280", Offset = "0x1FC8680", Length = "0xCA")]
	[Token(Token = "0x6002972")]
	public override bool Contains(object key) { }

	[Address(RVA = "0x1FC9350", Offset = "0x1FC8750", Length = "0x24A")]
	[Token(Token = "0x6002973")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6002969")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600296C")]
	public override bool get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600296B")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600296D")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x1FC97E0", Offset = "0x1FC8BE0", Length = "0xCC")]
	[Token(Token = "0x6002967")]
	public override object get_Item(object key) { }

	[Address(RVA = "0x1FC98B0", Offset = "0x1FC8CB0", Length = "0x64")]
	[Token(Token = "0x600296A")]
	public override ICollection get_Keys() { }

	[Address(RVA = "0x1FC9920", Offset = "0x1FC8D20", Length = "0x68")]
	[Token(Token = "0x600296E")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1FC9990", Offset = "0x1FC8D90", Length = "0x64")]
	[Token(Token = "0x600296F")]
	public override ICollection get_Values() { }

	[Address(RVA = "0x1FC95A0", Offset = "0x1FC89A0", Length = "0x87")]
	[Token(Token = "0x6002974")]
	public override IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x1FC9630", Offset = "0x1FC8A30", Length = "0x110")]
	[Token(Token = "0x6002976")]
	public override void Remove(object key) { }

	[Address(RVA = "0x1FC9A00", Offset = "0x1FC8E00", Length = "0x18F")]
	[Token(Token = "0x6002968")]
	public override void set_Item(object key, object value) { }

	[Address(RVA = "0x1FC9750", Offset = "0x1FC8B50", Length = "0x87")]
	[Token(Token = "0x6002975")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

