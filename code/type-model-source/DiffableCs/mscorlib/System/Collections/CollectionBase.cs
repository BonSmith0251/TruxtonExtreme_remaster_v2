namespace System.Collections;

[Token(Token = "0x20005B4")]
public abstract class CollectionBase : IList, ICollection, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017BD")]
	private ArrayList _list; //Field offset: 0x10

	[Token(Token = "0x17000636")]
	public override int Count
	{
		[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
		[Token(Token = "0x600299A")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000634")]
	protected ArrayList InnerList
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6002998")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000635")]
	protected IList List
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6002999")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000639")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x1FC0410", Offset = "0x1FBF810", Length = "0x2A")]
		[Token(Token = "0x600299F")]
		private get { } //Length: 42
	}

	[Token(Token = "0x1700063A")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x1FC0440", Offset = "0x1FBF840", Length = "0x2A")]
		[Token(Token = "0x60029A0")]
		private get { } //Length: 42
	}

	[Token(Token = "0x17000638")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x1FC08C0", Offset = "0x1FBFCC0", Length = "0x2A")]
		[Token(Token = "0x600299E")]
		private get { } //Length: 42
	}

	[Token(Token = "0x17000637")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x1F298A0", Offset = "0x1F28CA0", Length = "0x2A")]
		[Token(Token = "0x600299D")]
		private get { } //Length: 42
	}

	[Token(Token = "0x1700063B")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x1FC08F0", Offset = "0x1FBFCF0", Length = "0xC0")]
		[Token(Token = "0x60029A2")]
		private get { } //Length: 192
		[Address(RVA = "0x1FC09C0", Offset = "0x1FBFDC0", Length = "0x1C0")]
		[Token(Token = "0x60029A3")]
		private set { } //Length: 448
	}

	[Address(RVA = "0x1FC0B90", Offset = "0x1FBFF90", Length = "0x9E")]
	[Token(Token = "0x6002997")]
	protected CollectionBase() { }

	[Address(RVA = "0x1FC0180", Offset = "0x1FBF580", Length = "0x59")]
	[Token(Token = "0x600299B")]
	public override void Clear() { }

	[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
	[Token(Token = "0x600299A")]
	public override int get_Count() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6002998")]
	protected ArrayList get_InnerList() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6002999")]
	protected IList get_List() { }

	[Address(RVA = "0x1E3EF90", Offset = "0x1E3E390", Length = "0x2A")]
	[Token(Token = "0x60029A9")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60029AC")]
	protected override void OnClear() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60029B1")]
	protected override void OnClearComplete() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60029AB")]
	protected override void OnInsert(int index, object value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60029B0")]
	protected override void OnInsertComplete(int index, object value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60029AD")]
	protected override void OnRemove(int index, object value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60029B2")]
	protected override void OnRemoveComplete(int index, object value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60029AA")]
	protected override void OnSet(int index, object oldValue, object newValue) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60029AF")]
	protected override void OnSetComplete(int index, object oldValue, object newValue) { }

	[Address(RVA = "0x1FC01E0", Offset = "0x1FBF5E0", Length = "0x60")]
	[Token(Token = "0x60029AE")]
	protected override void OnValidate(object value) { }

	[Address(RVA = "0x1FC0240", Offset = "0x1FBF640", Length = "0x191")]
	[Token(Token = "0x600299C")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x1FC03E0", Offset = "0x1FBF7E0", Length = "0x2A")]
	[Token(Token = "0x60029A1")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x1FC0410", Offset = "0x1FBF810", Length = "0x2A")]
	[Token(Token = "0x600299F")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x1FC0440", Offset = "0x1FBF840", Length = "0x2A")]
	[Token(Token = "0x60029A0")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x1FC0470", Offset = "0x1FBF870", Length = "0x106")]
	[Token(Token = "0x60029A5")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x1FC0580", Offset = "0x1FBF980", Length = "0x2A")]
	[Token(Token = "0x60029A4")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x1FC08C0", Offset = "0x1FBFCC0", Length = "0x2A")]
	[Token(Token = "0x600299E")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x1F298A0", Offset = "0x1F28CA0", Length = "0x2A")]
	[Token(Token = "0x600299D")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0x1FC08F0", Offset = "0x1FBFCF0", Length = "0xC0")]
	[Token(Token = "0x60029A2")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x1FC05B0", Offset = "0x1FBF9B0", Length = "0x2A")]
	[Token(Token = "0x60029A7")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x1FC05E0", Offset = "0x1FBF9E0", Length = "0x17A")]
	[Token(Token = "0x60029A8")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x1FC0760", Offset = "0x1FBFB60", Length = "0x155")]
	[Token(Token = "0x60029A6")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x1FC09C0", Offset = "0x1FBFDC0", Length = "0x1C0")]
	[Token(Token = "0x60029A3")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

