namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x200019A")]
public struct HandleDragAndDropArgs
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007A5")]
	private readonly DragAndDropArgs m_DragAndDropArgs; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007A6")]
	private readonly Vector2 <position>k__BackingField; //Field offset: 0x28

	[Address(RVA = "0x33AF120", Offset = "0x33AE520", Length = "0x26")]
	[Token(Token = "0x6000BFB")]
	internal HandleDragAndDropArgs(Vector2 position, DragAndDropArgs dragAndDropArgs) { }

}

