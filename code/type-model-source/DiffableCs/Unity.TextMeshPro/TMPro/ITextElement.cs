namespace TMPro;

[Token(Token = "0x2000094")]
public interface ITextElement
{

	[Token(Token = "0x1700012A")]
	public Material sharedMaterial
	{
		[Token(Token = "0x600052E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600052E")]
	public Material get_sharedMaterial() { }

	[Token(Token = "0x6000530")]
	public int GetInstanceID() { }

	[Token(Token = "0x600052F")]
	public void Rebuild(CanvasUpdate update) { }

}

