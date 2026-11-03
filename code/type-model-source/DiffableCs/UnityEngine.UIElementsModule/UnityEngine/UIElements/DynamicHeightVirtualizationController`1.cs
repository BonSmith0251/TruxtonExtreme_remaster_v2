namespace UnityEngine.UIElements;

[Token(Token = "0x2000065")]
internal class DynamicHeightVirtualizationController : VerticalVirtualizationController<T>
{
	[CompilerGenerated]
	[Token(Token = "0x2000069")]
	private struct <>c__DisplayClass67_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F5")]
		public int draggedIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F6")]
		public DynamicHeightVirtualizationController<T> <>4__this; //Field offset: 0x0

	}

	[IsReadOnly]
	[Token(Token = "0x2000066")]
	private struct ContentHeightCacheInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001EA")]
		public readonly float sum; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001EB")]
		public readonly int count; //Field offset: 0x0

		[Address(RVA = "0x12F1440", Offset = "0x12F0840", Length = "0x9")]
		[Token(Token = "0x6000398")]
		public ContentHeightCacheInfo(float sum, int count) { }

	}

	[Token(Token = "0x2000068")]
	private enum ScrollDirection : int
	{
		Idle = 0,
		Up = 1,
		Down = 2,
	}

	[Token(Token = "0x2000067")]
	private enum VirtualizationChange : int
	{
		None = 0,
		Resize = 1,
		Scroll = 2,
		ForcedScroll = 3,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D4")]
	private int m_HighestCachedIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E7")]
	private Predicate<Int32> m_IndexOutOfBoundsPredicate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E6")]
	private IVisualElementScheduledItem m_RefreshScrollOffsetScheduledItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E5")]
	private IVisualElementScheduledItem m_ScrollResetScheduledItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E4")]
	private IVisualElementScheduledItem m_ScheduledItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E3")]
	private Action<ReusableCollectionItem> m_GeometryChangedCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E2")]
	private Action m_ScrollResetCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E1")]
	private Action m_FillCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E0")]
	private float m_MinimumItemHeight; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001DF")]
	private float m_AccumulatedHeight; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001DE")]
	private Vector2 m_DelayedScrollOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001DD")]
	private ScrollDirection<T> m_ScrollDirection; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001DC")]
	private VirtualizationChange<T> m_LastChange; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001DB")]
	private bool m_StickToBottom; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001DA")]
	private int m_ForcedLastVisibleItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D9")]
	private int m_ForcedFirstVisibleItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D8")]
	private Nullable<Int32> m_ScrolledToItemIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D7")]
	private readonly HashSet<Int32> m_WaitingCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D6")]
	private readonly Dictionary<Int32, ContentHeightCacheInfo<T>> m_ContentHeightCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001D5")]
	private readonly Dictionary<Int32, Single> m_ItemHeightCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E8")]
	private bool m_FillExecuted; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E9")]
	private long m_TimeSinceFillScheduledMs; //Field offset: 0x0

	[Token(Token = "0x1700007B")]
	protected virtual bool alwaysRebindOnRefresh
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000372")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000078")]
	private int anchoredIndex
	{
		[Address(RVA = "0x194AB50", Offset = "0x1949F50", Length = "0x2F")]
		[Token(Token = "0x600036D")]
		private get { } //Length: 47
		[Address(RVA = "0x194AD50", Offset = "0x194A150", Length = "0x4F")]
		[Token(Token = "0x600036E")]
		private set { } //Length: 79
	}

	[Token(Token = "0x17000079")]
	private float anchorOffset
	{
		[Address(RVA = "0x194AB10", Offset = "0x1949F10", Length = "0x31")]
		[Token(Token = "0x600036F")]
		private get { } //Length: 49
		[Address(RVA = "0x194ACF0", Offset = "0x194A0F0", Length = "0x53")]
		[Token(Token = "0x6000370")]
		private set { } //Length: 83
	}

	[Token(Token = "0x17000077")]
	private float contentHeight
	{
		[Address(RVA = "0x194AB80", Offset = "0x1949F80", Length = "0x31")]
		[Token(Token = "0x600036B")]
		private get { } //Length: 49
		[Address(RVA = "0x194ADA0", Offset = "0x194A1A0", Length = "0x189")]
		[Token(Token = "0x600036C")]
		private set { } //Length: 393
	}

	[Token(Token = "0x17000076")]
	private float contentPadding
	{
		[Address(RVA = "0x194ABC0", Offset = "0x1949FC0", Length = "0x31")]
		[Token(Token = "0x6000369")]
		private get { } //Length: 49
		[Address(RVA = "0x194AF30", Offset = "0x194A330", Length = "0x189")]
		[Token(Token = "0x600036A")]
		private set { } //Length: 393
	}

	[Token(Token = "0x17000075")]
	private float defaultExpectedHeight
	{
		[Address(RVA = "0x194AC00", Offset = "0x194A000", Length = "0x4C")]
		[Token(Token = "0x6000368")]
		private get { } //Length: 76
	}

	[Token(Token = "0x1700007A")]
	private float viewportMaxOffset
	{
		[Address(RVA = "0x194AC50", Offset = "0x194A050", Length = "0x96")]
		[Token(Token = "0x6000371")]
		private get { } //Length: 150
	}

	[Address(RVA = "0x194A760", Offset = "0x1949B60", Length = "0x3A5")]
	[Token(Token = "0x6000373")]
	public DynamicHeightVirtualizationController`1(BaseVerticalCollectionView collectionView) { }

	[Address(RVA = "0x19498A0", Offset = "0x1948CA0", Length = "0x19D")]
	[CompilerGenerated]
	[Token(Token = "0x6000397")]
	private float <GetContentHeightForIndex>g__GetContentHeightFromCachedHeight|67_0(int index, in ContentHeightCacheInfo<T> heightInfo, ref <>c__DisplayClass67_0<T> unnamed_param_2) { }

	[Address(RVA = "0x1944D10", Offset = "0x1944110", Length = "0xA07")]
	[Token(Token = "0x600037F")]
	private void ApplyScrollViewUpdate(bool dimensionsOnly = false) { }

	[Address(RVA = "0x1945720", Offset = "0x1944B20", Length = "0x3D7")]
	[Token(Token = "0x600038C")]
	private void CleanItemHeightCache() { }

	[Address(RVA = "0x1945B00", Offset = "0x1944F00", Length = "0x7F2")]
	[Token(Token = "0x600037B")]
	private void CycleItems(int firstIndex) { }

	[Address(RVA = "0x1946300", Offset = "0x1945700", Length = "0x2D9")]
	[Token(Token = "0x6000392")]
	internal virtual void EndDrag(int dropIndex) { }

	[Address(RVA = "0x19465E0", Offset = "0x19459E0", Length = "0x7A7")]
	[Token(Token = "0x600037D")]
	private void Fill() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000372")]
	protected virtual bool get_alwaysRebindOnRefresh() { }

	[Address(RVA = "0x194AB50", Offset = "0x1949F50", Length = "0x2F")]
	[Token(Token = "0x600036D")]
	private int get_anchoredIndex() { }

	[Address(RVA = "0x194AB10", Offset = "0x1949F10", Length = "0x31")]
	[Token(Token = "0x600036F")]
	private float get_anchorOffset() { }

	[Address(RVA = "0x194AB80", Offset = "0x1949F80", Length = "0x31")]
	[Token(Token = "0x600036B")]
	private float get_contentHeight() { }

	[Address(RVA = "0x194ABC0", Offset = "0x1949FC0", Length = "0x31")]
	[Token(Token = "0x6000369")]
	private float get_contentPadding() { }

	[Address(RVA = "0x194AC00", Offset = "0x194A000", Length = "0x4C")]
	[Token(Token = "0x6000368")]
	private float get_defaultExpectedHeight() { }

	[Address(RVA = "0x194AC50", Offset = "0x194A050", Length = "0x96")]
	[Token(Token = "0x6000371")]
	private float get_viewportMaxOffset() { }

	[Address(RVA = "0x1946D90", Offset = "0x1946190", Length = "0x7D")]
	[Token(Token = "0x6000389")]
	private ContentHeightCacheInfo<T> GetCachedContentHeight(int index) { }

	[Address(RVA = "0x1946E10", Offset = "0x1946210", Length = "0x1AA")]
	[Token(Token = "0x6000388")]
	private float GetContentHeightForIndex(int lastIndex) { }

	[Address(RVA = "0x1946FC0", Offset = "0x19463C0", Length = "0xDB")]
	[Token(Token = "0x6000387")]
	public virtual float GetExpectedContentHeight() { }

	[Address(RVA = "0x19470A0", Offset = "0x19464A0", Length = "0xF6")]
	[Token(Token = "0x6000385")]
	public virtual float GetExpectedItemHeight(int index) { }

	[Address(RVA = "0x19471A0", Offset = "0x19465A0", Length = "0x79")]
	[Token(Token = "0x6000386")]
	private int GetFirstVisibleItem(float offset) { }

	[Address(RVA = "0x1947220", Offset = "0x1946620", Length = "0x75")]
	[Token(Token = "0x6000384")]
	public virtual int GetIndexFromPosition(Vector2 position) { }

	[Address(RVA = "0x19472A0", Offset = "0x19466A0", Length = "0x56")]
	[Token(Token = "0x600038F")]
	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }

	[Address(RVA = "0x1947300", Offset = "0x1946700", Length = "0x178")]
	[Token(Token = "0x6000393")]
	private void HideItem(int activeItemsIndex) { }

	[Address(RVA = "0x1947480", Offset = "0x1946880", Length = "0x7B")]
	[Token(Token = "0x6000395")]
	private bool IsIndexOutOfBounds(int i) { }

	[Address(RVA = "0x1947500", Offset = "0x1946900", Length = "0x118")]
	[Token(Token = "0x6000394")]
	private void MarkWaitingForLayout(T item) { }

	[Address(RVA = "0x1947620", Offset = "0x1946A20", Length = "0x1B4")]
	[Token(Token = "0x600037C")]
	private bool NeedsFill() { }

	[Address(RVA = "0x19477E0", Offset = "0x1946BE0", Length = "0xE1")]
	[Token(Token = "0x6000379")]
	private void OnDetachFromPanelEvent(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x19478D0", Offset = "0x1946CD0", Length = "0x9D")]
	[Token(Token = "0x6000374")]
	private void OnGeometryChangedEvent(GeometryChangedEvent _) { }

	[Address(RVA = "0x1947970", Offset = "0x1946D70", Length = "0x160")]
	[Token(Token = "0x600038D")]
	private void OnRecycledItemGeometryChanged(ReusableCollectionItem item) { }

	[Address(RVA = "0x1947FE0", Offset = "0x19473E0", Length = "0x23C")]
	[Token(Token = "0x6000378")]
	public virtual void OnScroll(Vector2 scrollOffset) { }

	[Address(RVA = "0x1947AE0", Offset = "0x1946EE0", Length = "0x4F8")]
	[Token(Token = "0x600037A")]
	protected virtual void OnScrollUpdate() { }

	[Address(RVA = "0x1948410", Offset = "0x1947810", Length = "0x244")]
	[Token(Token = "0x6000375")]
	public virtual void Refresh(bool rebuild) { }

	[Address(RVA = "0x1948220", Offset = "0x1947620", Length = "0x1E5")]
	[Token(Token = "0x6000396")]
	private void RefreshScrollOffset() { }

	[Address(RVA = "0x1948660", Offset = "0x1947A60", Length = "0x3E2")]
	[Token(Token = "0x600038A")]
	private void RegisterItemHeight(int index, float height) { }

	[Address(RVA = "0x1948A50", Offset = "0x1947E50", Length = "0xE6")]
	[Token(Token = "0x6000390")]
	internal virtual void ReleaseItem(int activeItemsIndex) { }

	[Address(RVA = "0x1948B40", Offset = "0x1947F40", Length = "0x62")]
	[Token(Token = "0x6000383")]
	private void ResetScroll() { }

	[Address(RVA = "0x1948BB0", Offset = "0x1947FB0", Length = "0x6D1")]
	[Token(Token = "0x6000377")]
	public virtual void Resize(Vector2 size) { }

	[Address(RVA = "0x1949290", Offset = "0x1948690", Length = "0xC6")]
	[Token(Token = "0x6000381")]
	private void ScheduleFill() { }

	[Address(RVA = "0x1949360", Offset = "0x1948760", Length = "0xC6")]
	[Token(Token = "0x6000382")]
	private void ScheduleScrollDirectionReset() { }

	[Address(RVA = "0x1949430", Offset = "0x1948830", Length = "0x3CC")]
	[Token(Token = "0x6000376")]
	public virtual void ScrollToItem(int index) { }

	[Address(RVA = "0x194AD50", Offset = "0x194A150", Length = "0x4F")]
	[Token(Token = "0x600036E")]
	private void set_anchoredIndex(int value) { }

	[Address(RVA = "0x194ACF0", Offset = "0x194A0F0", Length = "0x53")]
	[Token(Token = "0x6000370")]
	private void set_anchorOffset(float value) { }

	[Address(RVA = "0x194ADA0", Offset = "0x194A1A0", Length = "0x189")]
	[Token(Token = "0x600036C")]
	private void set_contentHeight(float value) { }

	[Address(RVA = "0x194AF30", Offset = "0x194A330", Length = "0x189")]
	[Token(Token = "0x600036A")]
	private void set_contentPadding(float value) { }

	[Address(RVA = "0x1949800", Offset = "0x1948C00", Length = "0x9D")]
	[Token(Token = "0x6000391")]
	internal virtual void StartDragItem(ReusableCollectionItem item) { }

	[Address(RVA = "0x1949A40", Offset = "0x1948E40", Length = "0x2C7")]
	[Token(Token = "0x600038B")]
	private void UnregisterItemHeight(int index) { }

	[Address(RVA = "0x1949D10", Offset = "0x1949110", Length = "0x12F")]
	[Token(Token = "0x6000380")]
	private void UpdateAnchor() { }

	[Address(RVA = "0x1949E40", Offset = "0x1949240", Length = "0x7B2")]
	[Token(Token = "0x600038E")]
	private bool UpdateRegisteredHeight(ReusableCollectionItem item) { }

	[Address(RVA = "0x194A600", Offset = "0x1949A00", Length = "0x159")]
	[Token(Token = "0x600037E")]
	private void UpdateScrollViewContainer(float previousHeight, float newHeight) { }

}

