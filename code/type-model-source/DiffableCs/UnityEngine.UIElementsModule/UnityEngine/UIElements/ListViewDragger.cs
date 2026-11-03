namespace UnityEngine.UIElements;

[Token(Token = "0x200019D")]
internal class ListViewDragger : DragEventsProcessor
{
	[Token(Token = "0x200019E")]
	public struct DragPosition : IEquatable<DragPosition>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007B5")]
		public int insertAtIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40007B6")]
		public int parentId; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007B7")]
		public int childIndex; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007B8")]
		public ReusableCollectionItem recycledItem; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007B9")]
		public DragAndDropPosition dropPosition; //Field offset: 0x18

		[Address(RVA = "0x33C75C0", Offset = "0x33C69C0", Length = "0x5F")]
		[Token(Token = "0x6000C25")]
		public override bool Equals(DragPosition other) { }

		[Address(RVA = "0x33C74E0", Offset = "0x33C68E0", Length = "0xD4")]
		[Token(Token = "0x6000C26")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x33C7620", Offset = "0x33C6A20", Length = "0x77")]
		[Token(Token = "0x6000C27")]
		public virtual int GetHashCode() { }

	}

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007AD")]
	private DragPosition m_LastDragPosition; //Field offset: 0x30
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007AE")]
	private VisualElement m_DragHoverBar; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40007AF")]
	private VisualElement m_DragHoverItemMarker; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40007B0")]
	private VisualElement m_DragHoverSiblingMarker; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40007B1")]
	private float m_LeftIndentation; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40007B2")]
	private float m_SiblingBottom; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40007B3")]
	private bool m_Enabled; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40007B4")]
	private ICollectionDragAndDropController <dragAndDropController>k__BackingField; //Field offset: 0x78

	[Token(Token = "0x1700022C")]
	public ICollectionDragAndDropController dragAndDropController
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C0C")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000C0D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700022D")]
	internal bool enabled
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x6000C0E")]
		internal get { } //Length: 5
		[Address(RVA = "0x33B34C0", Offset = "0x33B28C0", Length = "0x2FF")]
		[Token(Token = "0x6000C0F")]
		internal set { } //Length: 767
	}

	[Token(Token = "0x1700022B")]
	protected ScrollView targetScrollView
	{
		[Address(RVA = "0x33B3410", Offset = "0x33B2810", Length = "0x21")]
		[Token(Token = "0x6000C0B")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700022A")]
	protected BaseVerticalCollectionView targetView
	{
		[Address(RVA = "0x33B3440", Offset = "0x33B2840", Length = "0x72")]
		[Token(Token = "0x6000C0A")]
		 get { } //Length: 114
	}

	[Address(RVA = "0x33B32D0", Offset = "0x33B26D0", Length = "0x13B")]
	[Token(Token = "0x6000C10")]
	public ListViewDragger(BaseVerticalCollectionView listView) { }

	[Address(RVA = "0x33B2CB0", Offset = "0x33B20B0", Length = "0x147")]
	[CompilerGenerated]
	[Token(Token = "0x6000C24")]
	private void <ApplyDragAndDropUI>g__GeometryChangedCallback|31_0(GeometryChangedEvent e) { }

	[Address(RVA = "0x33AF1E0", Offset = "0x33AE5E0", Length = "0x7CD")]
	[Token(Token = "0x6000C18")]
	private void ApplyDragAndDropUI(DragPosition dragPosition) { }

	[Address(RVA = "0x33AF9B0", Offset = "0x33AEDB0", Length = "0x385")]
	[Token(Token = "0x6000C11")]
	protected virtual bool CanStartDrag(Vector3 pointerPosition, EventModifiers modifiers) { }

	[Address(RVA = "0x33AFD40", Offset = "0x33AF140", Length = "0x3CD")]
	[Token(Token = "0x6000C21")]
	protected virtual void ClearDragAndDropUI(bool dragCancelled) { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C0C")]
	public ICollectionDragAndDropController get_dragAndDropController() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x6000C0E")]
	internal bool get_enabled() { }

	[Address(RVA = "0x33B3410", Offset = "0x33B2810", Length = "0x21")]
	[Token(Token = "0x6000C0B")]
	protected ScrollView get_targetScrollView() { }

	[Address(RVA = "0x33B3440", Offset = "0x33B2840", Length = "0x72")]
	[Token(Token = "0x6000C0A")]
	protected BaseVerticalCollectionView get_targetView() { }

	[Address(RVA = "0x33B0110", Offset = "0x33AF510", Length = "0x11F")]
	[Token(Token = "0x6000C1E")]
	private float GetHoverBarTopPosition(ReusableCollectionItem item) { }

	[Address(RVA = "0x33B0230", Offset = "0x33AF630", Length = "0x1CD")]
	[Token(Token = "0x6000C1C")]
	private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId) { }

	[Address(RVA = "0x33B0400", Offset = "0x33AF800", Length = "0x2A8")]
	[Token(Token = "0x6000C22")]
	protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition) { }

	[Address(RVA = "0x33B06B0", Offset = "0x33AFAB0", Length = "0x1C2")]
	[Token(Token = "0x6000C14")]
	private DragVisualMode GetVisualMode(Vector3 pointerPosition, EventModifiers modifiers, ref DragPosition dragPosition) { }

	[Address(RVA = "0x33B0880", Offset = "0x33AFC80", Length = "0x10E")]
	[Token(Token = "0x6000C17")]
	private void HandleAutoExpansion(Vector2 pointerPosition) { }

	[Address(RVA = "0x33B0990", Offset = "0x33AFD90", Length = "0x2DC")]
	[Token(Token = "0x6000C16")]
	internal void HandleDragAndScroll(Vector2 pointerPosition) { }

	[Address(RVA = "0x33B0C70", Offset = "0x33B0070", Length = "0x833")]
	[Token(Token = "0x6000C1B")]
	private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref DragPosition dragPosition, Vector2 pointerPosition) { }

	[Address(RVA = "0x33B14B0", Offset = "0x33B08B0", Length = "0x116")]
	[Token(Token = "0x6000C1A")]
	private void HandleTreePosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	[Address(RVA = "0x33B15D0", Offset = "0x33B09D0", Length = "0xAF")]
	[Token(Token = "0x6000C23")]
	private bool IsDraggingDisabled() { }

	[Address(RVA = "0x33B1680", Offset = "0x33B0A80", Length = "0x17D")]
	[Token(Token = "0x6000C1D")]
	protected DragAndDropArgs MakeDragAndDropArgs(DragPosition dragPosition, EventModifiers modifiers) { }

	[Address(RVA = "0x33B1800", Offset = "0x33B0C00", Length = "0x312")]
	[Token(Token = "0x6000C15")]
	protected private virtual void OnDrop(Vector3 pointerPosition, EventModifiers modifiers) { }

	[Address(RVA = "0x33B1C70", Offset = "0x33B1070", Length = "0x73D")]
	[Token(Token = "0x6000C20")]
	private void PlaceHoverBarAt(float top, float indentationPadding = -1, float siblingBottom = -1) { }

	[Address(RVA = "0x33B1B20", Offset = "0x33B0F20", Length = "0x144")]
	[Token(Token = "0x6000C1F")]
	private void PlaceHoverBarAtElement(ReusableCollectionItem item) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000C0D")]
	public void set_dragAndDropController(ICollectionDragAndDropController value) { }

	[Address(RVA = "0x33B34C0", Offset = "0x33B28C0", Length = "0x2FF")]
	[Token(Token = "0x6000C0F")]
	internal void set_enabled(bool value) { }

	[Address(RVA = "0x33B23B0", Offset = "0x33B17B0", Length = "0x471")]
	[Token(Token = "0x6000C12")]
	protected private virtual StartDragArgs StartDrag(Vector3 pointerPosition, EventModifiers modifiers) { }

	[Address(RVA = "0x33B2830", Offset = "0x33B1C30", Length = "0x47B")]
	[Token(Token = "0x6000C19")]
	protected override bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	[Address(RVA = "0x33B2E00", Offset = "0x33B2200", Length = "0x4C7")]
	[Token(Token = "0x6000C13")]
	protected private virtual void UpdateDrag(Vector3 pointerPosition, EventModifiers modifiers) { }

}

