namespace UnityEngine.UI;

[Token(Token = "0x2000009")]
public interface ICanvasElement
{

	[Token(Token = "0x17000009")]
	public Transform transform
	{
		[Token(Token = "0x600001D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600001D")]
	public Transform get_transform() { }

	[Token(Token = "0x600001F")]
	public void GraphicUpdateComplete() { }

	[Token(Token = "0x6000020")]
	public bool IsDestroyed() { }

	[Token(Token = "0x600001E")]
	public void LayoutComplete() { }

	[Token(Token = "0x600001C")]
	public void Rebuild(CanvasUpdate executing) { }

}

