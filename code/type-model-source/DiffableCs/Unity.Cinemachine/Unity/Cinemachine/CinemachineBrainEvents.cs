namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine Brain Events")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineBrainEvents.html")]
[SaveDuringPlay]
[Token(Token = "0x2000140")]
public class CinemachineBrainEvents : CinemachineMixerEventsBase
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400054E")]
	[Tooltip("This is the CinemachineBrain emitting the events.  If null and the current GameObject has a CinemachineBrain component, that component will be used.")]
	public CinemachineBrain Brain; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400054F")]
	[Tooltip("This event will fire after the brain updates its Camera.")]
	public BrainEvent BrainUpdatedEvent; //Field offset: 0x50

	[Address(RVA = "0x2869E80", Offset = "0x2869280", Length = "0x66")]
	[Token(Token = "0x6000646")]
	public CinemachineBrainEvents() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000642")]
	protected virtual ICinemachineMixer GetMixer() { }

	[Address(RVA = "0x2869BA0", Offset = "0x2868FA0", Length = "0x95")]
	[Token(Token = "0x6000645")]
	private void OnCameraUpdated(CinemachineBrain brain) { }

	[Address(RVA = "0x2869C40", Offset = "0x2869040", Length = "0xD5")]
	[Token(Token = "0x6000644")]
	private void OnDisable() { }

	[Address(RVA = "0x2869D20", Offset = "0x2869120", Length = "0x15A")]
	[Token(Token = "0x6000643")]
	private void OnEnable() { }

}

