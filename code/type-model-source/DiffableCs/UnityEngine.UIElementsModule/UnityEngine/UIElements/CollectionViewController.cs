namespace UnityEngine.UIElements;

[Token(Token = "0x200005C")]
public abstract class CollectionViewController : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C8")]
	private BaseVerticalCollectionView m_View; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C9")]
	private IList m_ItemsSource; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001CA")]
	private Action itemsSourceChanged; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001CB")]
	private Action<Int32, Int32> itemIndexChanged; //Field offset: 0x28

	[Token(Token = "0x1400000B")]
	public event Action<Int32, Int32> itemIndexChanged
	{
		[Address(RVA = "0x3221D20", Offset = "0x3221120", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000300")]
		 add { } //Length: 172
		[Address(RVA = "0x3221E70", Offset = "0x3221270", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000301")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x1400000A")]
	public event Action itemsSourceChanged
	{
		[Address(RVA = "0x3221DD0", Offset = "0x32211D0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60002FE")]
		 add { } //Length: 158
		[Address(RVA = "0x3221F20", Offset = "0x3221320", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x60002FF")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000068")]
	public override IList itemsSource
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000302")]
		 get { } //Length: 5
		[Address(RVA = "0x3221FC0", Offset = "0x32213C0", Length = "0xA2")]
		[Token(Token = "0x6000303")]
		 set { } //Length: 162
	}

	[Token(Token = "0x17000069")]
	protected BaseVerticalCollectionView view
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000305")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600031A")]
	protected CollectionViewController() { }

	[Address(RVA = "0x3221D20", Offset = "0x3221120", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000300")]
	public void add_itemIndexChanged(Action<Int32, Int32> value) { }

	[Address(RVA = "0x3221DD0", Offset = "0x32211D0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60002FE")]
	public void add_itemsSourceChanged(Action value) { }

	[Token(Token = "0x6000315")]
	protected abstract void BindItem(VisualElement element, int index) { }

	[Token(Token = "0x6000317")]
	protected abstract void DestroyItem(VisualElement element) { }

	[Address(RVA = "0x32218E0", Offset = "0x3220CE0", Length = "0x47")]
	[Token(Token = "0x6000308")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000302")]
	public override IList get_itemsSource() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000305")]
	protected BaseVerticalCollectionView get_view() { }

	[Address(RVA = "0x13C0E80", Offset = "0x13C0280", Length = "0x5")]
	[Token(Token = "0x600030C")]
	public override int GetIdForIndex(int index) { }

	[Address(RVA = "0x13C0E80", Offset = "0x13C0280", Length = "0x5")]
	[Token(Token = "0x600030B")]
	public override int GetIndexForId(int id) { }

	[Address(RVA = "0x3221930", Offset = "0x3220D30", Length = "0x91")]
	[Token(Token = "0x600030D")]
	public override object GetItemForIndex(int index) { }

	[Address(RVA = "0x32219D0", Offset = "0x3220DD0", Length = "0x4D")]
	[Token(Token = "0x6000309")]
	public override int GetItemsCount() { }

	[Address(RVA = "0x2077B00", Offset = "0x2076F00", Length = "0x14")]
	[Token(Token = "0x600030A")]
	internal override int GetItemsMinCount() { }

	[Address(RVA = "0x3221A20", Offset = "0x3220E20", Length = "0x101")]
	[Token(Token = "0x6000310")]
	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	[Address(RVA = "0x3221B30", Offset = "0x3220F30", Length = "0x2A")]
	[Token(Token = "0x6000312")]
	internal override void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	[Address(RVA = "0x3221B60", Offset = "0x3220F60", Length = "0x45")]
	[Token(Token = "0x600030E")]
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	[Address(RVA = "0x3221BB0", Offset = "0x3220FB0", Length = "0x37")]
	[Token(Token = "0x6000311")]
	internal override void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index) { }

	[Token(Token = "0x6000314")]
	protected abstract VisualElement MakeItem() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000307")]
	protected override void PrepareView() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000313")]
	internal override void PreRefresh() { }

	[Address(RVA = "0x321E4D0", Offset = "0x321D8D0", Length = "0x19")]
	[Token(Token = "0x6000319")]
	protected void RaiseItemIndexChanged(int srcIndex, int dstIndex) { }

	[Address(RVA = "0x2717C60", Offset = "0x2717060", Length = "0x19")]
	[Token(Token = "0x6000318")]
	protected void RaiseItemsSourceChanged() { }

	[Address(RVA = "0x3221E70", Offset = "0x3221270", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000301")]
	public void remove_itemIndexChanged(Action<Int32, Int32> value) { }

	[Address(RVA = "0x3221F20", Offset = "0x3221320", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x60002FF")]
	public void remove_itemsSourceChanged(Action value) { }

	[Address(RVA = "0x3221FC0", Offset = "0x32213C0", Length = "0xA2")]
	[Token(Token = "0x6000303")]
	public override void set_itemsSource(IList value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600030F")]
	internal override void SetBindingContext(ReusableCollectionItem reusableItem, int index) { }

	[Address(RVA = "0x3221BF0", Offset = "0x3220FF0", Length = "0x79")]
	[Token(Token = "0x6000304")]
	 void SetHierarchyViewModelWithoutNotify(HierarchyViewModel source) { }

	[Address(RVA = "0x3221C70", Offset = "0x3221070", Length = "0xA3")]
	[Token(Token = "0x6000306")]
	public void SetView(BaseVerticalCollectionView collectionView) { }

	[Token(Token = "0x6000316")]
	protected abstract void UnbindItem(VisualElement element, int index) { }

}

