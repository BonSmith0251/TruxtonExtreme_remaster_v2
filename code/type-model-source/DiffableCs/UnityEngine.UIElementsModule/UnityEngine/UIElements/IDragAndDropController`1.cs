namespace UnityEngine.UIElements;

[Token(Token = "0x2000196")]
internal interface IDragAndDropController
{

	[Token(Token = "0x6000BF2")]
	public bool CanStartDrag(IEnumerable<Int32> itemIds) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BF6")]
	public void DragCleanup() { }

	[Address(RVA = "0x1C73510", Offset = "0x1C72910", Length = "0x30")]
	[Token(Token = "0x6000BF8")]
	public IEnumerable<Int32> GetSortedSelectedIds() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000BF7")]
	public void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	[Token(Token = "0x6000BF4")]
	public DragVisualMode HandleDragAndDrop(TArgs args) { }

	[Token(Token = "0x6000BF5")]
	public void OnDrop(TArgs args) { }

	[Token(Token = "0x6000BF3")]
	public StartDragArgs SetupDragAndDrop(IEnumerable<Int32> itemIds, bool skipText = false) { }

}

