namespace Unity.Cinemachine;

[Token(Token = "0x20000BF")]
public interface ICinemachineMixer : ICinemachineCamera
{

	[Token(Token = "0x60003B4")]
	public bool IsLiveChild(ICinemachineCamera child, bool dominantChildOnly = false) { }

}

