namespace Unity.Cinemachine;

[Token(Token = "0x2000077")]
public interface ICameraOverrideStack
{

	[Token(Token = "0x17000079")]
	public Vector3 DefaultWorldUp
	{
		[Token(Token = "0x600025B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600025B")]
	public Vector3 get_DefaultWorldUp() { }

	[Token(Token = "0x600025A")]
	public void ReleaseCameraOverride(int overrideId) { }

	[Token(Token = "0x6000259")]
	public int SetCameraOverride(int overrideId, int priority, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime) { }

}

