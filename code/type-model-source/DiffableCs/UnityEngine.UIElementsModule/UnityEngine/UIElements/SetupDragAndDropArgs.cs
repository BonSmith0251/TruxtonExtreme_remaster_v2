namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000199")]
public struct SetupDragAndDropArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007A2")]
	public readonly VisualElement draggedElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007A3")]
	public readonly IEnumerable<Int32> selectedIds; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007A4")]
	public readonly StartDragArgs startDragArgs; //Field offset: 0x10

	[Address(RVA = "0x33B39D0", Offset = "0x33B2DD0", Length = "0x63")]
	[Token(Token = "0x6000BFA")]
	internal SetupDragAndDropArgs(VisualElement draggedElement, IEnumerable<Int32> selectedIds, StartDragArgs startDragArgs) { }

}

