namespace Unity.Cinemachine;

[Token(Token = "0x20000E3")]
public abstract class SignalSourceAsset : ScriptableObject, ISignalSource6D
{

	[Token(Token = "0x170000E7")]
	public abstract float SignalDuration
	{
		[Token(Token = "0x600042C")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x600042E")]
	protected SignalSourceAsset() { }

	[Token(Token = "0x600042C")]
	public abstract float get_SignalDuration() { }

	[Token(Token = "0x600042D")]
	public abstract void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

}

