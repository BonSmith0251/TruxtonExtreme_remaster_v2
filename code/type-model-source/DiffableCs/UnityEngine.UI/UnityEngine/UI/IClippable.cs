namespace UnityEngine.UI;

[Token(Token = "0x200000F")]
public interface IClippable
{

	[Token(Token = "0x17000013")]
	public GameObject gameObject
	{
		[Token(Token = "0x6000053")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000014")]
	public RectTransform rectTransform
	{
		[Token(Token = "0x6000055")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000056")]
	public void Cull(Rect clipRect, bool validRect) { }

	[Token(Token = "0x6000053")]
	public GameObject get_gameObject() { }

	[Token(Token = "0x6000055")]
	public RectTransform get_rectTransform() { }

	[Token(Token = "0x6000054")]
	public void RecalculateClipping() { }

	[Token(Token = "0x6000057")]
	public void SetClipRect(Rect value, bool validRect) { }

	[Token(Token = "0x6000058")]
	public void SetClipSoftness(Vector2 clipSoftness) { }

}

