namespace System.Runtime.Remoting.Messaging;

[DefaultMember("Item")]
[Token(Token = "0x20003C0")]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable
{
	[Token(Token = "0x20003C1")]
	private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000EE2")]
		private MessageDictionary _methodDictionary; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000EE3")]
		private IDictionaryEnumerator _hashtableEnum; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000EE4")]
		private int _posMethod; //Field offset: 0x20

		[Token(Token = "0x17000370")]
		public override object Current
		{
			[Address(RVA = "0x1F01C10", Offset = "0x1F01010", Length = "0x54")]
			[Token(Token = "0x6001D13")]
			 get { } //Length: 84
		}

		[Token(Token = "0x17000371")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x1F01C70", Offset = "0x1F01070", Length = "0x1B3")]
			[Token(Token = "0x6001D16")]
			 get { } //Length: 435
		}

		[Token(Token = "0x17000372")]
		public override object Key
		{
			[Address(RVA = "0x1F01E30", Offset = "0x1F01230", Length = "0x1C")]
			[Token(Token = "0x6001D17")]
			 get { } //Length: 28
		}

		[Token(Token = "0x17000373")]
		public override object Value
		{
			[Address(RVA = "0x1F01E50", Offset = "0x1F01250", Length = "0x1D")]
			[Token(Token = "0x6001D18")]
			 get { } //Length: 29
		}

		[Address(RVA = "0x1F01B70", Offset = "0x1F00F70", Length = "0x96")]
		[Token(Token = "0x6001D12")]
		public DictionaryEnumerator(MessageDictionary methodDictionary) { }

		[Address(RVA = "0x1F01C10", Offset = "0x1F01010", Length = "0x54")]
		[Token(Token = "0x6001D13")]
		public override object get_Current() { }

		[Address(RVA = "0x1F01C70", Offset = "0x1F01070", Length = "0x1B3")]
		[Token(Token = "0x6001D16")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x1F01E30", Offset = "0x1F01230", Length = "0x1C")]
		[Token(Token = "0x6001D17")]
		public override object get_Key() { }

		[Address(RVA = "0x1F01E50", Offset = "0x1F01250", Length = "0x1D")]
		[Token(Token = "0x6001D18")]
		public override object get_Value() { }

		[Address(RVA = "0x1F01A00", Offset = "0x1F00E00", Length = "0x104")]
		[Token(Token = "0x6001D14")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1F01B10", Offset = "0x1F00F10", Length = "0x50")]
		[Token(Token = "0x6001D15")]
		public override void Reset() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EDE")]
	private IDictionary _internalProperties; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EDF")]
	protected IMethodMessage _message; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EE0")]
	private String[] _methodKeys; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000EE1")]
	private bool _ownProperties; //Field offset: 0x28

	[Token(Token = "0x1700036D")]
	public override int Count
	{
		[Address(RVA = "0x1F07A20", Offset = "0x1F06E20", Length = "0x6A")]
		[Token(Token = "0x6001D0C")]
		 get { } //Length: 106
	}

	[Token(Token = "0x17000366")]
	internal IDictionary InternalDictionary
	{
		[Address(RVA = "0x1F07A90", Offset = "0x1F06E90", Length = "0xA2")]
		[Token(Token = "0x6001CFB")]
		internal get { } //Length: 162
	}

	[Token(Token = "0x17000368")]
	public override bool IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001D00")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000369")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001D01")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700036E")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001D0D")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700036A")]
	public override object Item
	{
		[Address(RVA = "0x1F07B40", Offset = "0x1F06F40", Length = "0x11B")]
		[Token(Token = "0x6001D02")]
		 get { } //Length: 283
		[Address(RVA = "0x1F06BB0", Offset = "0x1F05FB0", Length = "0x151")]
		[Token(Token = "0x6001D03")]
		 set { } //Length: 337
	}

	[Token(Token = "0x1700036B")]
	public override ICollection Keys
	{
		[Address(RVA = "0x1F07C60", Offset = "0x1F07060", Length = "0x3C6")]
		[Token(Token = "0x6001D06")]
		 get { } //Length: 966
	}

	[Token(Token = "0x17000367")]
	public String[] MethodKeys
	{
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6001CFC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700036F")]
	public override object SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6001D0E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700036C")]
	public override ICollection Values
	{
		[Address(RVA = "0x1F08030", Offset = "0x1F07430", Length = "0x409")]
		[Token(Token = "0x6001D07")]
		 get { } //Length: 1033
	}

	[Address(RVA = "0x1F079E0", Offset = "0x1F06DE0", Length = "0x31")]
	[Token(Token = "0x6001CF9")]
	public MessageDictionary(IMethodMessage message) { }

	[Address(RVA = "0x1F06BB0", Offset = "0x1F05FB0", Length = "0x151")]
	[Token(Token = "0x6001D08")]
	public override void Add(object key, object value) { }

	[Address(RVA = "0x1F06D10", Offset = "0x1F06110", Length = "0x4B")]
	[Token(Token = "0x6001CFD")]
	protected override IDictionary AllocInternalProperties() { }

	[Address(RVA = "0x1F06D60", Offset = "0x1F06160", Length = "0x4C")]
	[Token(Token = "0x6001D09")]
	public override void Clear() { }

	[Address(RVA = "0x1F06DB0", Offset = "0x1F061B0", Length = "0xFF")]
	[Token(Token = "0x6001D0A")]
	public override bool Contains(object key) { }

	[Address(RVA = "0x1F06EB0", Offset = "0x1F062B0", Length = "0x70")]
	[Token(Token = "0x6001D0F")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x1F07A20", Offset = "0x1F06E20", Length = "0x6A")]
	[Token(Token = "0x6001D0C")]
	public override int get_Count() { }

	[Address(RVA = "0x1F07A90", Offset = "0x1F06E90", Length = "0xA2")]
	[Token(Token = "0x6001CFB")]
	internal IDictionary get_InternalDictionary() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001D00")]
	public override bool get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001D01")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001D0D")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x1F07B40", Offset = "0x1F06F40", Length = "0x11B")]
	[Token(Token = "0x6001D02")]
	public override object get_Item(object key) { }

	[Address(RVA = "0x1F07C60", Offset = "0x1F07060", Length = "0x3C6")]
	[Token(Token = "0x6001D06")]
	public override ICollection get_Keys() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6001D0E")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x1F08030", Offset = "0x1F07430", Length = "0x409")]
	[Token(Token = "0x6001D07")]
	public override ICollection get_Values() { }

	[Address(RVA = "0x1F06F30", Offset = "0x1F06330", Length = "0x54")]
	[Token(Token = "0x6001D11")]
	public override IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x1F06F90", Offset = "0x1F06390", Length = "0x47")]
	[Token(Token = "0x6001CFE")]
	public IDictionary GetInternalProperties() { }

	[Address(RVA = "0x1F06FE0", Offset = "0x1F063E0", Length = "0x3B9")]
	[Token(Token = "0x6001D04")]
	protected override object GetMethodProperty(string key) { }

	[Address(RVA = "0x1F073A0", Offset = "0x1F067A0", Length = "0xDF")]
	[Token(Token = "0x6001CFA")]
	internal bool HasUserData() { }

	[Address(RVA = "0x1F07480", Offset = "0x1F06880", Length = "0x7C")]
	[Token(Token = "0x6001CFF")]
	private bool IsOverridenKey(string key) { }

	[Address(RVA = "0x1F07500", Offset = "0x1F06900", Length = "0x144")]
	[Token(Token = "0x6001D0B")]
	public override void Remove(object key) { }

	[Address(RVA = "0x1F06BB0", Offset = "0x1F05FB0", Length = "0x151")]
	[Token(Token = "0x6001D03")]
	public override void set_Item(object key, object value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6001CFC")]
	public void set_MethodKeys(String[] value) { }

	[Address(RVA = "0x1F07650", Offset = "0x1F06A50", Length = "0x329")]
	[Token(Token = "0x6001D05")]
	protected override void SetMethodProperty(string key, object value) { }

	[Address(RVA = "0x1F07980", Offset = "0x1F06D80", Length = "0x54")]
	[Token(Token = "0x6001D10")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

