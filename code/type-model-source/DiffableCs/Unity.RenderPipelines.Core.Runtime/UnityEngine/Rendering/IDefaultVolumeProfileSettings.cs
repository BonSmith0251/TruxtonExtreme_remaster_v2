namespace UnityEngine.Rendering;

[Token(Token = "0x2000168")]
public interface IDefaultVolumeProfileSettings : IRenderPipelineGraphicsSettings
{

	[Token(Token = "0x17000157")]
	private bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000B64")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000158")]
	public VolumeProfile volumeProfile
	{
		[Token(Token = "0x6000B65")]
		 get { } //Length: 0
		[Token(Token = "0x6000B66")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000B65")]
	public VolumeProfile get_volumeProfile() { }

	[Token(Token = "0x6000B66")]
	public void set_volumeProfile(VolumeProfile value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000B64")]
	private bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

