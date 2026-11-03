namespace UnityEngine.UI;

[Token(Token = "0x2000048")]
public interface ILayoutElement
{

	[Token(Token = "0x170000BC")]
	public float flexibleHeight
	{
		[Token(Token = "0x60002BD")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B9")]
	public float flexibleWidth
	{
		[Token(Token = "0x60002BA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000BD")]
	public int layoutPriority
	{
		[Token(Token = "0x60002BE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000BA")]
	public float minHeight
	{
		[Token(Token = "0x60002BB")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B7")]
	public float minWidth
	{
		[Token(Token = "0x60002B8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000BB")]
	public float preferredHeight
	{
		[Token(Token = "0x60002BC")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B8")]
	public float preferredWidth
	{
		[Token(Token = "0x60002B9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60002B6")]
	public void CalculateLayoutInputHorizontal() { }

	[Token(Token = "0x60002B7")]
	public void CalculateLayoutInputVertical() { }

	[Token(Token = "0x60002BD")]
	public float get_flexibleHeight() { }

	[Token(Token = "0x60002BA")]
	public float get_flexibleWidth() { }

	[Token(Token = "0x60002BE")]
	public int get_layoutPriority() { }

	[Token(Token = "0x60002BB")]
	public float get_minHeight() { }

	[Token(Token = "0x60002B8")]
	public float get_minWidth() { }

	[Token(Token = "0x60002BC")]
	public float get_preferredHeight() { }

	[Token(Token = "0x60002B9")]
	public float get_preferredWidth() { }

}

