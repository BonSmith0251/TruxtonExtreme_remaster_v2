namespace UnityEngine.UIElements;

[Token(Token = "0x20001A1")]
internal class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007C2")]
	protected readonly BaseListView m_ListView; //Field offset: 0x28

	[Address(RVA = "0x33D4880", Offset = "0x33D3C80", Length = "0x32")]
	[Token(Token = "0x6000C35")]
	public ListViewReorderableDragAndDropController(BaseListView view) { }

	[Address(RVA = "0x33D44F0", Offset = "0x33D38F0", Length = "0xC7")]
	[Token(Token = "0x6000C36")]
	public virtual DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	[Address(RVA = "0x33D45C0", Offset = "0x33D39C0", Length = "0x2B6")]
	[Token(Token = "0x6000C37")]
	public virtual void OnDrop(IListDragAndDropArgs args) { }

}

