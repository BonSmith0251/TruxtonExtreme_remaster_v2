namespace UnityEngine.Rendering;

[Token(Token = "0x2000167")]
public interface IDefaultVolumeProfileAsset : IRenderPipelineGraphicsSettings
{

	[Token(Token = "0x17000156")]
	public VolumeProfile defaultVolumeProfile
	{
		[Token(Token = "0x6000B62")]
		 get { } //Length: 0
		[Token(Token = "0x6000B63")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000B62")]
	public VolumeProfile get_defaultVolumeProfile() { }

	[Token(Token = "0x6000B63")]
	public void set_defaultVolumeProfile(VolumeProfile value) { }

}

