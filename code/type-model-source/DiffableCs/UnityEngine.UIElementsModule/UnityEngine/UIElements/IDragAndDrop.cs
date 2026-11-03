namespace UnityEngine.UIElements;

[Token(Token = "0x2000191")]
internal interface IDragAndDrop
{

	[Token(Token = "0x17000214")]
	public DragAndDropData data
	{
		[Token(Token = "0x6000BDC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000BD9")]
	public void AcceptDrag() { }

	[Token(Token = "0x6000BDA")]
	public void DragCleanup() { }

	[Token(Token = "0x6000BDC")]
	public DragAndDropData get_data() { }

	[Token(Token = "0x6000BDB")]
	public void SetVisualMode(DragVisualMode visualMode) { }

	[Token(Token = "0x6000BD7")]
	public void StartDrag(StartDragArgs args, Vector3 pointerPosition) { }

	[Token(Token = "0x6000BD8")]
	public void UpdateDrag(Vector3 pointerPosition) { }

}

