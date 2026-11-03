namespace UnityEngine.UIElements;

[Token(Token = "0x20001A2")]
internal class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	[Token(Token = "0x20001A3")]
	internal class DropData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007C7")]
		public Int32[] expandedIdsBeforeDrag; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007C8")]
		public Int32[] draggedIds; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007C9")]
		public int lastItemId; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40007CA")]
		public float expandItemBeginTimerMs; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007CB")]
		public Vector2 expandItemBeginPosition; //Field offset: 0x28

		[Address(RVA = "0x1CC8810", Offset = "0x1CC7C10", Length = "0xE")]
		[Token(Token = "0x6000C43")]
		public DropData() { }

	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007C3")]
	protected DropData m_DropData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007C4")]
	protected readonly BaseTreeView m_TreeView; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007C5")]
	private IVisualElementScheduledItem m_ExpandDropItemScheduledItem; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007C6")]
	private Action m_ExpandDropItemCallback; //Field offset: 0x40

	[Address(RVA = "0x33DDAB0", Offset = "0x33DCEB0", Length = "0xDA")]
	[Token(Token = "0x6000C38")]
	public TreeViewReorderableDragAndDropController(BaseTreeView view) { }

	[Address(RVA = "0x33DC1B0", Offset = "0x33DB5B0", Length = "0x37")]
	[Token(Token = "0x6000C3C")]
	public virtual bool CanDrop() { }

	[Address(RVA = "0x33DC1F0", Offset = "0x33DB5F0", Length = "0x68F")]
	[Token(Token = "0x6000C39")]
	protected virtual int CompareId(int id1, int id2) { }

	[Address(RVA = "0x33DC880", Offset = "0x33DBC80", Length = "0x1D1")]
	[Token(Token = "0x6000C41")]
	private void DelayExpandDropItem() { }

	[Address(RVA = "0x33DCA60", Offset = "0x33DBE60", Length = "0x10B")]
	[Token(Token = "0x6000C3E")]
	public virtual void DragCleanup() { }

	[Address(RVA = "0x33DCB70", Offset = "0x33DBF70", Length = "0x25C")]
	[Token(Token = "0x6000C42")]
	private void ExpandDropItem() { }

	[Address(RVA = "0x33DCDD0", Offset = "0x33DC1D0", Length = "0x20A")]
	[Token(Token = "0x6000C40")]
	public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	[Address(RVA = "0x33DCFE0", Offset = "0x33DC3E0", Length = "0xA4")]
	[Token(Token = "0x6000C3B")]
	public virtual DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	[Address(RVA = "0x33DD090", Offset = "0x33DC490", Length = "0x632")]
	[Token(Token = "0x6000C3D")]
	public virtual void OnDrop(IListDragAndDropArgs args) { }

	[Address(RVA = "0x33DD6D0", Offset = "0x33DCAD0", Length = "0x279")]
	[Token(Token = "0x6000C3F")]
	private void RestoreExpanded(List<Int32> ids) { }

	[Address(RVA = "0x33DD950", Offset = "0x33DCD50", Length = "0x157")]
	[Token(Token = "0x6000C3A")]
	public virtual StartDragArgs SetupDragAndDrop(IEnumerable<Int32> itemIds, bool skipText = false) { }

}

