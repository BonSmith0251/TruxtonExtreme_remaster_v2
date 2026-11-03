namespace UnityEngine.UIElements;

[Token(Token = "0x2000070")]
internal abstract class VerticalVirtualizationController : CollectionVirtualizationController
{
	[CompilerGenerated]
	[Token(Token = "0x2000071")]
	private sealed class <>c
	{
		[Token(Token = "0x4000220")]
		public static readonly <>c<T> <>9; //Field offset: 0x0
		[Token(Token = "0x4000221")]
		public static Func<T> <>9__35_0; //Field offset: 0x0
		[Token(Token = "0x4000222")]
		public static Action<T> <>9__35_1; //Field offset: 0x0
		[Token(Token = "0x4000223")]
		public static Action<T> <>9__35_2; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000403")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000404")]
		public <>c() { }

		[Address(RVA = "0xA347A0", Offset = "0xA33BA0", Length = "0x14")]
		[Token(Token = "0x6000405")]
		internal T <.ctor>b__35_0() { }

		[Address(RVA = "0xA4D5C0", Offset = "0xA4C9C0", Length = "0x2C")]
		[Token(Token = "0x6000406")]
		internal void <.ctor>b__35_1(T i) { }

		[Address(RVA = "0xA4D5F0", Offset = "0xA4C9F0", Length = "0x2C")]
		[Token(Token = "0x6000407")]
		internal void <.ctor>b__35_2(T i) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000212")]
	private readonly ObjectPool<T> m_Pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000213")]
	protected BaseVerticalCollectionView m_CollectionView; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000214")]
	protected List<T> m_ActiveItems; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000215")]
	protected T m_DraggedItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000216")]
	private Nullable<Int32> m_DeferredScrollToItemIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000217")]
	private readonly Action m_PerformDeferredScrollToItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000218")]
	private IVisualElementScheduledItem m_ScheduleDeferredScrollToItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000219")]
	private IVisualElementScheduledItem m_ScrollScheduledItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021A")]
	private Action m_ScrollCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021B")]
	private int m_LastFocusedElementIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021C")]
	private List<Int32> m_LastFocusedElementTreeChildIndexes; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021D")]
	protected readonly Func<T, Boolean> m_VisibleItemPredicateDelegate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021E")]
	protected List<T> m_ScrollInsertionList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400021F")]
	private VisualElement m_EmptyRows; //Field offset: 0x0

	[Token(Token = "0x17000088")]
	public virtual IEnumerable<ReusableCollectionItem> activeItems
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60003E2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700008F")]
	protected override bool alwaysRebindOnRefresh
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60003EB")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700008E")]
	public virtual int firstVisibleIndex
	{
		[Address(RVA = "0x1408160", Offset = "0x1407560", Length = "0x76")]
		[Token(Token = "0x60003E9")]
		 get { } //Length: 118
		[Address(RVA = "0x1408600", Offset = "0x1407A00", Length = "0x26")]
		[Token(Token = "0x60003EA")]
		 set { } //Length: 38
	}

	[Token(Token = "0x1700008A")]
	internal T firstVisibleItem
	{
		[Address(RVA = "0x14081E0", Offset = "0x14075E0", Length = "0x169")]
		[Token(Token = "0x60003E5")]
		internal get { } //Length: 361
	}

	[Token(Token = "0x17000089")]
	internal int itemsCount
	{
		[Address(RVA = "0x1408350", Offset = "0x1407750", Length = "0x86")]
		[Token(Token = "0x60003E3")]
		internal get { } //Length: 134
	}

	[Token(Token = "0x1700008B")]
	internal T lastVisibleItem
	{
		[Address(RVA = "0x14083E0", Offset = "0x14077E0", Length = "0x95")]
		[Token(Token = "0x60003E6")]
		internal get { } //Length: 149
	}

	[Token(Token = "0x1700008D")]
	protected SerializedVirtualizationData serializedData
	{
		[Address(RVA = "0x1408480", Offset = "0x1407880", Length = "0x1E")]
		[Token(Token = "0x60003E8")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700008C")]
	public virtual int visibleItemCount
	{
		[Address(RVA = "0x14084A0", Offset = "0x14078A0", Length = "0x156")]
		[Token(Token = "0x60003E7")]
		 get { } //Length: 342
	}

	[Address(RVA = "0x1407960", Offset = "0x1406D60", Length = "0x7FA")]
	[Token(Token = "0x60003EC")]
	protected VerticalVirtualizationController`1(BaseVerticalCollectionView collectionView) { }

	[Address(RVA = "0x14051B0", Offset = "0x14045B0", Length = "0x364")]
	[Token(Token = "0x60003FC")]
	internal virtual void EndDrag(int dropIndex) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60003E2")]
	public virtual IEnumerable<ReusableCollectionItem> get_activeItems() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60003EB")]
	protected override bool get_alwaysRebindOnRefresh() { }

	[Address(RVA = "0x1408160", Offset = "0x1407560", Length = "0x76")]
	[Token(Token = "0x60003E9")]
	public virtual int get_firstVisibleIndex() { }

	[Address(RVA = "0x14081E0", Offset = "0x14075E0", Length = "0x169")]
	[Token(Token = "0x60003E5")]
	internal T get_firstVisibleItem() { }

	[Address(RVA = "0x1408350", Offset = "0x1407750", Length = "0x86")]
	[Token(Token = "0x60003E3")]
	internal int get_itemsCount() { }

	[Address(RVA = "0x14083E0", Offset = "0x14077E0", Length = "0x95")]
	[Token(Token = "0x60003E6")]
	internal T get_lastVisibleItem() { }

	[Address(RVA = "0x1408480", Offset = "0x1407880", Length = "0x1E")]
	[Token(Token = "0x60003E8")]
	protected SerializedVirtualizationData get_serializedData() { }

	[Address(RVA = "0x14084A0", Offset = "0x14078A0", Length = "0x156")]
	[Token(Token = "0x60003E7")]
	public virtual int get_visibleItemCount() { }

	[Address(RVA = "0x1405520", Offset = "0x1404920", Length = "0x94")]
	[Token(Token = "0x6000401")]
	protected int GetDraggedIndex() { }

	[Address(RVA = "0x14055C0", Offset = "0x14049C0", Length = "0x273")]
	[Token(Token = "0x60003FD")]
	internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }

	[Address(RVA = "0x1405840", Offset = "0x1404C40", Length = "0xFC")]
	[Token(Token = "0x60003F9")]
	private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex) { }

	[Address(RVA = "0x1405940", Offset = "0x1404D40", Length = "0x7A")]
	[Token(Token = "0x60003F0")]
	private bool IsContentContainerPanelDirtied() { }

	[Address(RVA = "0x14059C0", Offset = "0x1404DC0", Length = "0xBF")]
	[Token(Token = "0x60003FF")]
	private void OnDestroyItem(ReusableCollectionItem item) { }

	[Address(RVA = "0x1405A80", Offset = "0x1404E80", Length = "0x7D")]
	[Token(Token = "0x60003F6")]
	private void OnDetachFromPanelEvent(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x1405B00", Offset = "0x1404F00", Length = "0x38D")]
	[Token(Token = "0x60003F7")]
	public virtual void OnFocusIn(VisualElement leafTarget) { }

	[Address(RVA = "0x1405E90", Offset = "0x1405290", Length = "0x7C")]
	[Token(Token = "0x60003F8")]
	public virtual void OnFocusOut(VisualElement willFocus) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000400")]
	protected override void OnScrollUpdate() { }

	[Address(RVA = "0x1405F10", Offset = "0x1405310", Length = "0x96")]
	[Token(Token = "0x60003F4")]
	private void PerformDeferredScrollToItem() { }

	[Address(RVA = "0x1405FB0", Offset = "0x14053B0", Length = "0x40F")]
	[Token(Token = "0x60003ED")]
	public virtual void Refresh(bool rebuild) { }

	[Address(RVA = "0x14063C0", Offset = "0x14057C0", Length = "0xD1")]
	[Token(Token = "0x60003FE")]
	internal override void ReleaseItem(int activeItemsIndex) { }

	[Address(RVA = "0x14064A0", Offset = "0x14058A0", Length = "0x1AE")]
	[Token(Token = "0x60003F3")]
	protected void ScheduleDeferredScrollToItem() { }

	[Address(RVA = "0x1406650", Offset = "0x1405A50", Length = "0xB4")]
	[Token(Token = "0x6000402")]
	protected void ScheduleScroll() { }

	[Address(RVA = "0x1408600", Offset = "0x1407A00", Length = "0x26")]
	[Token(Token = "0x60003EA")]
	protected virtual void set_firstVisibleIndex(int value) { }

	[Address(RVA = "0x1406710", Offset = "0x1405B10", Length = "0x689")]
	[Token(Token = "0x60003EF")]
	protected void Setup(T recycledItem, int newIndex) { }

	[Address(RVA = "0x1406DA0", Offset = "0x14061A0", Length = "0xC1")]
	[Token(Token = "0x60003F2")]
	protected bool ShouldDeferScrollToItem(int index) { }

	[Address(RVA = "0x1406E70", Offset = "0x1406270", Length = "0x22")]
	[Token(Token = "0x60003F1")]
	private bool ShouldStopDeferredScrollTo() { }

	[Address(RVA = "0x1406EA0", Offset = "0x14062A0", Length = "0x124")]
	[Token(Token = "0x60003FB")]
	internal virtual void StartDragItem(ReusableCollectionItem item) { }

	[Address(RVA = "0x1406FD0", Offset = "0x14063D0", Length = "0x71")]
	[Token(Token = "0x60003F5")]
	protected void StopDeferredScrollToItem() { }

	[Address(RVA = "0x1407050", Offset = "0x1406450", Length = "0x184")]
	[Token(Token = "0x60003EE")]
	public virtual void UnbindAll() { }

	[Address(RVA = "0x14071E0", Offset = "0x14065E0", Length = "0x6CA")]
	[Token(Token = "0x60003FA")]
	public virtual void UpdateBackground() { }

	[Address(RVA = "0x14078B0", Offset = "0x1406CB0", Length = "0xAD")]
	[Token(Token = "0x60003E4")]
	protected override bool VisibleItemPredicate(T i) { }

}

