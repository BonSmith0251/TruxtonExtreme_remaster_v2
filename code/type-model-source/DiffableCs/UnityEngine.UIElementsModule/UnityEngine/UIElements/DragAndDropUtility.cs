namespace UnityEngine.UIElements;

[Token(Token = "0x200018C")]
internal static class DragAndDropUtility
{
	[Token(Token = "0x400077D")]
	private static Func<IDragAndDrop> s_MakeDragAndDropClientFunc; //Field offset: 0x0
	[Token(Token = "0x400077E")]
	private static IDragAndDrop s_DragAndDropEditor; //Field offset: 0x8
	[Token(Token = "0x400077F")]
	private static IDragAndDrop s_DragAndDropPlayMode; //Field offset: 0x10

	[Address(RVA = "0x33ADA20", Offset = "0x33ACE20", Length = "0x150")]
	[Token(Token = "0x6000BB5")]
	internal static IDragAndDrop GetDragAndDrop(IPanel panel) { }

}

