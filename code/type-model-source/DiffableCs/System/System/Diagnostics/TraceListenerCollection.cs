namespace System.Diagnostics;

[DefaultMember("Item")]
[Token(Token = "0x2000103")]
public class TraceListenerCollection : IList, ICollection, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400047F")]
	private ArrayList list; //Field offset: 0x10

	[Token(Token = "0x170000FB")]
	public override int Count
	{
		[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
		[Token(Token = "0x6000648")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000100")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000658")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000FF")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6000657")]
		private get { } //Length: 4
	}

	[Token(Token = "0x170000FE")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000651")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000FD")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000650")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000FC")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x263F420", Offset = "0x263E820", Length = "0x2A")]
		[Token(Token = "0x600064E")]
		private get { } //Length: 42
		[Address(RVA = "0x263F450", Offset = "0x263E850", Length = "0x110")]
		[Token(Token = "0x600064F")]
		private set { } //Length: 272
	}

	[Address(RVA = "0x263F570", Offset = "0x263E970", Length = "0x6C")]
	[Token(Token = "0x6000647")]
	internal TraceListenerCollection() { }

	[Address(RVA = "0x263EA60", Offset = "0x263DE60", Length = "0x126")]
	[Token(Token = "0x6000649")]
	public int Add(TraceListener listener) { }

	[Address(RVA = "0x263EB90", Offset = "0x263DF90", Length = "0x5C")]
	[Token(Token = "0x600064A")]
	public override void Clear() { }

	[Address(RVA = "0x1FC0C30", Offset = "0x1FC0030", Length = "0x2A")]
	[Token(Token = "0x6000648")]
	public override int get_Count() { }

	[Address(RVA = "0x1E3EF90", Offset = "0x1E3E390", Length = "0x2A")]
	[Token(Token = "0x600064B")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x263EBF0", Offset = "0x263DFF0", Length = "0x138")]
	[Token(Token = "0x600064C")]
	internal void InitializeListener(TraceListener listener) { }

	[Address(RVA = "0x263ED30", Offset = "0x263E130", Length = "0x103")]
	[Token(Token = "0x600064D")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x263EE40", Offset = "0x263E240", Length = "0x115")]
	[Token(Token = "0x6000659")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000658")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000657")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x263EF60", Offset = "0x263E360", Length = "0x1D7")]
	[Token(Token = "0x6000652")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x1FC0580", Offset = "0x1FBF980", Length = "0x2A")]
	[Token(Token = "0x6000653")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000651")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000650")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0x263F420", Offset = "0x263E820", Length = "0x2A")]
	[Token(Token = "0x600064E")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x1FC05B0", Offset = "0x1FBF9B0", Length = "0x2A")]
	[Token(Token = "0x6000654")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x263F140", Offset = "0x263E540", Length = "0x1CE")]
	[Token(Token = "0x6000655")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x263F310", Offset = "0x263E710", Length = "0x105")]
	[Token(Token = "0x6000656")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x263F450", Offset = "0x263E850", Length = "0x110")]
	[Token(Token = "0x600064F")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

