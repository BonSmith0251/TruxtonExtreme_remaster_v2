namespace UnityEngine.UIElements;

[Token(Token = "0x2000064")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEngine.HierarchyModule"})]
internal abstract class CollectionVirtualizationController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D3")]
	protected readonly ScrollView m_ScrollView; //Field offset: 0x10

	[Token(Token = "0x17000074")]
	public abstract IEnumerable<ReusableCollectionItem> activeItems
	{
		[Token(Token = "0x6000364")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000072")]
	public abstract int firstVisibleIndex
	{
		[Token(Token = "0x6000356")]
		 get { } //Length: 0
		[Token(Token = "0x6000357")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000073")]
	public abstract int visibleItemCount
	{
		[Token(Token = "0x6000358")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000359")]
	protected CollectionVirtualizationController(ScrollView scrollView) { }

	[Token(Token = "0x6000366")]
	internal abstract void EndDrag(int dropIndex) { }

	[Token(Token = "0x6000364")]
	public abstract IEnumerable<ReusableCollectionItem> get_activeItems() { }

	[Token(Token = "0x6000356")]
	public abstract int get_firstVisibleIndex() { }

	[Token(Token = "0x6000358")]
	public abstract int get_visibleItemCount() { }

	[Token(Token = "0x6000360")]
	public abstract float GetExpectedContentHeight() { }

	[Token(Token = "0x600035F")]
	public abstract float GetExpectedItemHeight(int index) { }

	[Token(Token = "0x600035E")]
	public abstract int GetIndexFromPosition(Vector2 position) { }

	[Token(Token = "0x6000361")]
	public abstract void OnFocusIn(VisualElement leafTarget) { }

	[Token(Token = "0x6000362")]
	public abstract void OnFocusOut(VisualElement willFocus) { }

	[Token(Token = "0x600035D")]
	public abstract void OnScroll(Vector2 offset) { }

	[Token(Token = "0x600035A")]
	public abstract void Refresh(bool rebuild) { }

	[Token(Token = "0x600035C")]
	public abstract void Resize(Vector2 size) { }

	[Token(Token = "0x600035B")]
	public abstract void ScrollToItem(int id) { }

	[Token(Token = "0x6000357")]
	protected abstract void set_firstVisibleIndex(int value) { }

	[Token(Token = "0x6000365")]
	internal abstract void StartDragItem(ReusableCollectionItem item) { }

	[Token(Token = "0x6000367")]
	public abstract void UnbindAll() { }

	[Token(Token = "0x6000363")]
	public abstract void UpdateBackground() { }

}

