namespace UnityEngine.UIElements;

[Token(Token = "0x2000193")]
internal interface IListDragAndDropArgs
{

	[Token(Token = "0x17000219")]
	public int childIndex
	{
		[Token(Token = "0x6000BE3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700021A")]
	public DragAndDropData dragAndDropData
	{
		[Token(Token = "0x6000BE4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700021B")]
	public DragAndDropPosition dragAndDropPosition
	{
		[Token(Token = "0x6000BE5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000217")]
	public int insertAtIndex
	{
		[Token(Token = "0x6000BE1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000218")]
	public int parentId
	{
		[Token(Token = "0x6000BE2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000BE3")]
	public int get_childIndex() { }

	[Token(Token = "0x6000BE4")]
	public DragAndDropData get_dragAndDropData() { }

	[Token(Token = "0x6000BE5")]
	public DragAndDropPosition get_dragAndDropPosition() { }

	[Token(Token = "0x6000BE1")]
	public int get_insertAtIndex() { }

	[Token(Token = "0x6000BE2")]
	public int get_parentId() { }

}

