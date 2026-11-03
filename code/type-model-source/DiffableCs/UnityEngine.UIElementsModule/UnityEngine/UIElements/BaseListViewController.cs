namespace UnityEngine.UIElements;

[Token(Token = "0x2000055")]
public abstract class BaseListViewController : CollectionViewController
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000198")]
	private Action itemsSourceSizeChanged; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000199")]
	private Action<IEnumerable`1<Int32>> itemsAdded; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400019A")]
	private Action<IEnumerable`1<Int32>> itemsRemoved; //Field offset: 0x40

	[Token(Token = "0x14000007")]
	public event Action<IEnumerable`1<Int32>> itemsAdded
	{
		[Address(RVA = "0x3215A30", Offset = "0x3214E30", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000281")]
		 add { } //Length: 172
		[Address(RVA = "0x3215CB0", Offset = "0x32150B0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000282")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x14000008")]
	public event Action<IEnumerable`1<Int32>> itemsRemoved
	{
		[Address(RVA = "0x3215AE0", Offset = "0x3214EE0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000283")]
		 add { } //Length: 172
		[Address(RVA = "0x3215D60", Offset = "0x3215160", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000284")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x14000006")]
	public event Action itemsSourceSizeChanged
	{
		[Address(RVA = "0x3215B90", Offset = "0x3214F90", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600027F")]
		 add { } //Length: 158
		[Address(RVA = "0x3215E10", Offset = "0x3215210", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000280")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000057")]
	protected BaseListView baseListView
	{
		[Address(RVA = "0x3215C30", Offset = "0x3215030", Length = "0x72")]
		[Token(Token = "0x6000285")]
		 get { } //Length: 114
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000298")]
	protected BaseListViewController() { }

	[Address(RVA = "0x3215980", Offset = "0x3214D80", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000299")]
	internal static bool <AddItems>g__IsGenericList|19_0(Type t) { }

	[Address(RVA = "0x3215A30", Offset = "0x3214E30", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000281")]
	public void add_itemsAdded(Action<IEnumerable`1<Int32>> value) { }

	[Address(RVA = "0x3215AE0", Offset = "0x3214EE0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000283")]
	public void add_itemsRemoved(Action<IEnumerable`1<Int32>> value) { }

	[Address(RVA = "0x3215B90", Offset = "0x3214F90", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600027F")]
	public void add_itemsSourceSizeChanged(Action value) { }

	[Address(RVA = "0x32139B0", Offset = "0x3212DB0", Length = "0x67B")]
	[Token(Token = "0x600028B")]
	public override void AddItems(int itemCount) { }

	[Address(RVA = "0x3214030", Offset = "0x3213430", Length = "0x104")]
	[Token(Token = "0x6000294")]
	private static Array AddToArray(Array source, int itemCount) { }

	[Address(RVA = "0x3214140", Offset = "0x3213540", Length = "0x113")]
	[Token(Token = "0x6000290")]
	public override void ClearItems() { }

	[Address(RVA = "0x3214260", Offset = "0x3213660", Length = "0x150")]
	[Token(Token = "0x6000297")]
	private void EnsureItemSourceCanBeResized() { }

	[Address(RVA = "0x3215C30", Offset = "0x3215030", Length = "0x72")]
	[Token(Token = "0x6000285")]
	protected BaseListView get_baseListView() { }

	[Address(RVA = "0x32143C0", Offset = "0x32137C0", Length = "0x294")]
	[Token(Token = "0x6000289")]
	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	[Address(RVA = "0x3214660", Offset = "0x3213A60", Length = "0x1AD")]
	[Token(Token = "0x6000286")]
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	[Address(RVA = "0x3214810", Offset = "0x3213C10", Length = "0x237")]
	[Token(Token = "0x600028C")]
	public override void Move(int index, int newIndex) { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x600028A")]
	public override bool NeedsDragHandle(int index) { }

	[Address(RVA = "0x3214A50", Offset = "0x3213E50", Length = "0x4C3")]
	[Token(Token = "0x6000287")]
	internal void PostInitRegistration(ReusableListViewItem listItem) { }

	[Address(RVA = "0x3214F20", Offset = "0x3214320", Length = "0x19")]
	[Token(Token = "0x6000292")]
	protected void RaiseItemsAdded(IEnumerable<Int32> indices) { }

	[Address(RVA = "0x3214F40", Offset = "0x3214340", Length = "0x19")]
	[Token(Token = "0x6000293")]
	protected void RaiseItemsRemoved(IEnumerable<Int32> indices) { }

	[Address(RVA = "0x26DCA30", Offset = "0x26DBE30", Length = "0x19")]
	[Token(Token = "0x6000291")]
	protected void RaiseOnSizeChanged() { }

	[Address(RVA = "0x3215CB0", Offset = "0x32150B0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000282")]
	public void remove_itemsAdded(Action<IEnumerable`1<Int32>> value) { }

	[Address(RVA = "0x3215D60", Offset = "0x3215160", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000284")]
	public void remove_itemsRemoved(Action<IEnumerable`1<Int32>> value) { }

	[Address(RVA = "0x3215E10", Offset = "0x3215210", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000280")]
	public void remove_itemsSourceSizeChanged(Action value) { }

	[Address(RVA = "0x3214F60", Offset = "0x3214360", Length = "0x19A")]
	[Token(Token = "0x6000295")]
	private static Array RemoveFromArray(Array source, List<Int32> indicesToRemove) { }

	[Address(RVA = "0x3215100", Offset = "0x3214500", Length = "0x16C")]
	[Token(Token = "0x600028D")]
	public override void RemoveItem(int index) { }

	[Address(RVA = "0x3215270", Offset = "0x3214670", Length = "0x1A6")]
	[Token(Token = "0x600028F")]
	internal override void RemoveItems(int itemCount) { }

	[Address(RVA = "0x3215420", Offset = "0x3214820", Length = "0x266")]
	[Token(Token = "0x600028E")]
	public override void RemoveItems(List<Int32> indices) { }

	[Address(RVA = "0x3215690", Offset = "0x3214A90", Length = "0x1A9")]
	[Token(Token = "0x6000288")]
	internal virtual void SetBindingContext(ReusableCollectionItem reusableItem, int index) { }

	[Address(RVA = "0x3215840", Offset = "0x3214C40", Length = "0x137")]
	[Token(Token = "0x6000296")]
	private void Swap(int lhs, int rhs) { }

}

