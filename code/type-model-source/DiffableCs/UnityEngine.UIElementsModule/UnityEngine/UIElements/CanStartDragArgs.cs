namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000198")]
public struct CanStartDragArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400079E")]
	public readonly VisualElement draggedElement; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400079F")]
	public readonly int id; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007A0")]
	public readonly IEnumerable<Int32> selectedIds; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007A1")]
	internal readonly EventModifiers modifiers; //Field offset: 0x18

	[Address(RVA = "0x33AC690", Offset = "0x33ABA90", Length = "0x4A")]
	[Token(Token = "0x6000BF9")]
	internal CanStartDragArgs(VisualElement draggedElement, int id, IEnumerable<Int32> selectedIds, EventModifiers modifiers) { }

}

