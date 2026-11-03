namespace UnityEngine.Rendering;

[Token(Token = "0x2000050")]
public interface IVirtualTexturingEnabledRenderPipeline
{

	[Token(Token = "0x1700003B")]
	public bool virtualTexturingEnabled
	{
		[Token(Token = "0x6000510")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000510")]
	public bool get_virtualTexturingEnabled() { }

}

