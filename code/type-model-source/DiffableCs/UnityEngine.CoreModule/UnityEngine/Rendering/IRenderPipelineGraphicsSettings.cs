namespace UnityEngine.Rendering;

[Token(Token = "0x200037A")]
public interface IRenderPipelineGraphicsSettings
{

	[Token(Token = "0x170003D8")]
	public bool isAvailableInPlayerBuild
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001A51")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170003D7")]
	public int version
	{
		[Token(Token = "0x6001A50")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001A51")]
	public bool get_isAvailableInPlayerBuild() { }

	[Token(Token = "0x6001A50")]
	public int get_version() { }

}

