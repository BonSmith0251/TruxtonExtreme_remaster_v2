namespace UnityEngine.UI;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Not supported anymore.", True)]
[Token(Token = "0x200002C")]
public interface IMask
{

	[Token(Token = "0x17000067")]
	public RectTransform rectTransform
	{
		[Token(Token = "0x6000190")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600018F")]
	public bool Enabled() { }

	[Token(Token = "0x6000190")]
	public RectTransform get_rectTransform() { }

}

