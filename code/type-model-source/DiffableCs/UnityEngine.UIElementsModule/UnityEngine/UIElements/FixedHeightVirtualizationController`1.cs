namespace UnityEngine.UIElements;

[Token(Token = "0x200006A")]
internal class FixedHeightVirtualizationController : VerticalVirtualizationController<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001F7")]
	private Nullable<Int32> m_ScrolledToItemIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001F8")]
	private bool m_ForcedScroll; //Field offset: 0x0

	[Token(Token = "0x1700007C")]
	private float resolvedItemHeight
	{
		[Address(RVA = "0x1BC5CA0", Offset = "0x1BC50A0", Length = "0x26")]
		[Token(Token = "0x6000399")]
		private get { } //Length: 38
	}

	[Address(RVA = "0x1BC6ED0", Offset = "0x1BC62D0", Length = "0xBE")]
	[Token(Token = "0x600039B")]
	public FixedHeightVirtualizationController`1(BaseVerticalCollectionView collectionView) { }

	[Address(RVA = "0x1BC5A50", Offset = "0x1BC4E50", Length = "0x1EB")]
	[Token(Token = "0x60003A5")]
	internal virtual void EndDrag(int dropIndex) { }

	[Address(RVA = "0x1BC5CA0", Offset = "0x1BC50A0", Length = "0x26")]
	[Token(Token = "0x6000399")]
	private float get_resolvedItemHeight() { }

	[Address(RVA = "0x1BC5C40", Offset = "0x1BC5040", Length = "0x5C")]
	[Token(Token = "0x600039F")]
	public virtual float GetExpectedContentHeight() { }

	[Address(RVA = "0x1BC5CA0", Offset = "0x1BC50A0", Length = "0x26")]
	[Token(Token = "0x600039E")]
	public virtual float GetExpectedItemHeight(int index) { }

	[Address(RVA = "0x1BC5CD0", Offset = "0x1BC50D0", Length = "0x3F")]
	[Token(Token = "0x600039D")]
	public virtual int GetIndexFromPosition(Vector2 position) { }

	[Address(RVA = "0x1BC5D10", Offset = "0x1BC5110", Length = "0x180")]
	[Token(Token = "0x60003A4")]
	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }

	[Address(RVA = "0x1BC5EA0", Offset = "0x1BC52A0", Length = "0x9D")]
	[Token(Token = "0x600039C")]
	private void OnGeometryChangedEvent(GeometryChangedEvent evt) { }

	[Address(RVA = "0x1BC66F0", Offset = "0x1BC5AF0", Length = "0x40")]
	[Token(Token = "0x60003A2")]
	public virtual void OnScroll(Vector2 scrollOffset) { }

	[Address(RVA = "0x1BC5F40", Offset = "0x1BC5340", Length = "0x7AF")]
	[Token(Token = "0x60003A3")]
	protected virtual void OnScrollUpdate() { }

	[Address(RVA = "0x1BC6730", Offset = "0x1BC5B30", Length = "0x43A")]
	[Token(Token = "0x60003A1")]
	public virtual void Resize(Vector2 size) { }

	[Address(RVA = "0x1BC6B70", Offset = "0x1BC5F70", Length = "0x358")]
	[Token(Token = "0x60003A0")]
	public virtual void ScrollToItem(int index) { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x600039A")]
	protected virtual bool VisibleItemPredicate(T i) { }

}

