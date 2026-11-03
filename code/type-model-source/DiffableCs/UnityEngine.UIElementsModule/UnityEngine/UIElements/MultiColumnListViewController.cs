namespace UnityEngine.UIElements;

[Token(Token = "0x2000060")]
public class MultiColumnListViewController : BaseListViewController
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001CE")]
	private MultiColumnController m_ColumnController; //Field offset: 0x48

	[Token(Token = "0x1700006F")]
	public MultiColumnController columnController
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000331")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x32252F0", Offset = "0x32246F0", Length = "0x178")]
	[Token(Token = "0x6000332")]
	public MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[Address(RVA = "0x3224940", Offset = "0x3223D40", Length = "0x91")]
	[Token(Token = "0x600033B")]
	protected virtual void BindItem(VisualElement element, int index) { }

	[Address(RVA = "0x32249E0", Offset = "0x3223DE0", Length = "0x1E")]
	[Token(Token = "0x600033D")]
	protected virtual void DestroyItem(VisualElement element) { }

	[Address(RVA = "0x3224A00", Offset = "0x3223E00", Length = "0x163")]
	[Token(Token = "0x600033F")]
	public virtual void Dispose() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000331")]
	public MultiColumnController get_columnController() { }

	[Address(RVA = "0x3224B70", Offset = "0x3223F70", Length = "0x1E")]
	[Token(Token = "0x6000339")]
	public virtual int GetIdForIndex(int index) { }

	[Address(RVA = "0x3224B90", Offset = "0x3223F90", Length = "0x1E")]
	[Token(Token = "0x6000338")]
	public virtual int GetIndexForId(int id) { }

	[Address(RVA = "0x3224BB0", Offset = "0x3223FB0", Length = "0xA6")]
	[Token(Token = "0x6000337")]
	public virtual object GetItemForIndex(int index) { }

	[Address(RVA = "0x3224C60", Offset = "0x3224060", Length = "0x168")]
	[Token(Token = "0x6000336")]
	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	[Address(RVA = "0x3224DD0", Offset = "0x32241D0", Length = "0x26D")]
	[Token(Token = "0x6000335")]
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	[Address(RVA = "0x3225040", Offset = "0x3224440", Length = "0x1D")]
	[Token(Token = "0x600033A")]
	protected virtual VisualElement MakeItem() { }

	[Address(RVA = "0x3225080", Offset = "0x3224480", Length = "0x124")]
	[Token(Token = "0x600033E")]
	protected virtual void PrepareView() { }

	[Address(RVA = "0x3225060", Offset = "0x3224460", Length = "0x1D")]
	[Token(Token = "0x6000333")]
	internal virtual void PreRefresh() { }

	[Address(RVA = "0x32251B0", Offset = "0x32245B0", Length = "0x48")]
	[Token(Token = "0x6000334")]
	private void SortIfNeeded() { }

	[Address(RVA = "0x3225200", Offset = "0x3224600", Length = "0x1E")]
	[Token(Token = "0x600033C")]
	protected virtual void UnbindItem(VisualElement element, int index) { }

	[Address(RVA = "0x3225220", Offset = "0x3224620", Length = "0xCD")]
	[Token(Token = "0x6000340")]
	private void UpdateReorderClassList() { }

}

