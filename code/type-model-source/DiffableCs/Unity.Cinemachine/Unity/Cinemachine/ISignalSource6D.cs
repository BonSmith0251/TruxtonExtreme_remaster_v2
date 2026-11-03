namespace Unity.Cinemachine;

[Token(Token = "0x20000E2")]
public interface ISignalSource6D
{

	[Token(Token = "0x170000E6")]
	public float SignalDuration
	{
		[Token(Token = "0x600042A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600042A")]
	public float get_SignalDuration() { }

	[Token(Token = "0x600042B")]
	public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

}

