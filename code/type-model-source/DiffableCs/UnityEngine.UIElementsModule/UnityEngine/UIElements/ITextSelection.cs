namespace UnityEngine.UIElements;

[Token(Token = "0x20004BF")]
public interface ITextSelection
{

	[Token(Token = "0x1700099F")]
	public int cursorIndex
	{
		[Token(Token = "0x6002426")]
		 get { } //Length: 0
		[Token(Token = "0x6002427")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170009A5")]
	public Vector2 cursorPosition
	{
		[Token(Token = "0x6002435")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170009A7")]
	internal float cursorWidth
	{
		[Token(Token = "0x6002437")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x170009A0")]
	public bool doubleClickSelectsWord
	{
		[Token(Token = "0x6002428")]
		 get { } //Length: 0
		[Token(Token = "0x6002429")]
		 set { } //Length: 0
	}

	[Token(Token = "0x1700099E")]
	public bool isSelectable
	{
		[Token(Token = "0x6002424")]
		 get { } //Length: 0
		[Token(Token = "0x6002425")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170009A6")]
	internal float lineHeightAtCursorPosition
	{
		[Token(Token = "0x6002436")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x170009A3")]
	public bool selectAllOnFocus
	{
		[Token(Token = "0x6002431")]
		 get { } //Length: 0
		[Token(Token = "0x6002432")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170009A4")]
	public bool selectAllOnMouseUp
	{
		[Token(Token = "0x6002433")]
		 get { } //Length: 0
		[Token(Token = "0x6002434")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170009A1")]
	public int selectIndex
	{
		[Token(Token = "0x600242A")]
		 get { } //Length: 0
		[Token(Token = "0x600242B")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170009A2")]
	public bool tripleClickSelectsLine
	{
		[Token(Token = "0x600242C")]
		 get { } //Length: 0
		[Token(Token = "0x600242D")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6002426")]
	public int get_cursorIndex() { }

	[Token(Token = "0x6002435")]
	public Vector2 get_cursorPosition() { }

	[Token(Token = "0x6002437")]
	internal float get_cursorWidth() { }

	[Token(Token = "0x6002428")]
	public bool get_doubleClickSelectsWord() { }

	[Token(Token = "0x6002424")]
	public bool get_isSelectable() { }

	[Token(Token = "0x6002436")]
	internal float get_lineHeightAtCursorPosition() { }

	[Token(Token = "0x6002431")]
	public bool get_selectAllOnFocus() { }

	[Token(Token = "0x6002433")]
	public bool get_selectAllOnMouseUp() { }

	[Token(Token = "0x600242A")]
	public int get_selectIndex() { }

	[Token(Token = "0x600242C")]
	public bool get_tripleClickSelectsLine() { }

	[Token(Token = "0x600242E")]
	public bool HasSelection() { }

	[Token(Token = "0x600242F")]
	public void SelectAll() { }

	[Token(Token = "0x6002430")]
	public void SelectNone() { }

	[Token(Token = "0x6002427")]
	public void set_cursorIndex(int value) { }

	[Token(Token = "0x6002429")]
	public void set_doubleClickSelectsWord(bool value) { }

	[Token(Token = "0x6002425")]
	public void set_isSelectable(bool value) { }

	[Token(Token = "0x6002432")]
	public void set_selectAllOnFocus(bool value) { }

	[Token(Token = "0x6002434")]
	public void set_selectAllOnMouseUp(bool value) { }

	[Token(Token = "0x600242B")]
	public void set_selectIndex(int value) { }

	[Token(Token = "0x600242D")]
	public void set_tripleClickSelectsLine(bool value) { }

}

