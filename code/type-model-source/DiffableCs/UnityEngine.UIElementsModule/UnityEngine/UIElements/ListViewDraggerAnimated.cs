namespace UnityEngine.UIElements;

[Token(Token = "0x20001A0")]
internal class ListViewDraggerAnimated : ListViewDragger
{
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40007BA")]
	private int m_DragStartIndex; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40007BB")]
	private int m_CurrentIndex; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40007BC")]
	private float m_SelectionHeight; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x40007BD")]
	private float m_LocalOffsetOnStart; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40007BE")]
	private Vector3 m_CurrentPointerPosition; //Field offset: 0x90
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40007BF")]
	private ReusableCollectionItem m_Item; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40007C0")]
	private ReusableCollectionItem m_OffsetItem; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40007C1")]
	private bool <isDragging>k__BackingField; //Field offset: 0xB0

	[Token(Token = "0x1700022F")]
	public ReusableCollectionItem draggedItem
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x6000C2C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700022E")]
	public private bool isDragging
	{
		[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000C2A")]
		 get { } //Length: 8
		[Address(RVA = "0x6617A0", Offset = "0x660BA0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000C2B")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000230")]
	protected virtual bool supportsDragEvents
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000C2D")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x33D41A0", Offset = "0x33D35A0", Length = "0x8")]
	[Token(Token = "0x6000C2E")]
	public ListViewDraggerAnimated(BaseVerticalCollectionView listView) { }

	[Address(RVA = "0x33D2680", Offset = "0x33D1A80", Length = "0x3C6")]
	[Token(Token = "0x6000C31")]
	private void Animate(ReusableCollectionItem element, float paddingTop) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000C33")]
	protected virtual void ClearDragAndDropUI(bool dragCancelled) { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x6000C2C")]
	public ReusableCollectionItem get_draggedItem() { }

	[Address(RVA = "0x661730", Offset = "0x660B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000C2A")]
	public bool get_isDragging() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C2D")]
	protected virtual bool get_supportsDragEvents() { }

	[Address(RVA = "0x33D2A50", Offset = "0x33D1E50", Length = "0x48B")]
	[Token(Token = "0x6000C32")]
	protected private virtual void OnDrop(Vector3 pointerPosition, EventModifiers modifiers) { }

	[Address(RVA = "0x6617A0", Offset = "0x660BA0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000C2B")]
	private void set_isDragging(bool value) { }

	[Address(RVA = "0x33D2EE0", Offset = "0x33D22E0", Length = "0xA2E")]
	[Token(Token = "0x6000C2F")]
	protected private virtual StartDragArgs StartDrag(Vector3 pointerPosition, EventModifiers modifiers) { }

	[Address(RVA = "0x33D3910", Offset = "0x33D2D10", Length = "0x40")]
	[Token(Token = "0x6000C34")]
	protected virtual bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	[Address(RVA = "0x33D3950", Offset = "0x33D2D50", Length = "0x844")]
	[Token(Token = "0x6000C30")]
	protected private virtual void UpdateDrag(Vector3 pointerPosition, EventModifiers modifiers) { }

}

