namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine Camera Manager Events")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineCameraManagerEvents.html")]
[SaveDuringPlay]
[Token(Token = "0x2000142")]
public class CinemachineCameraManagerEvents : CinemachineMixerEventsBase
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000555")]
	[Tooltip("This is the CinemachineCameraManager emitting the events.  If null and the current GameObject has a CinemachineCameraManager component, that component will be used.")]
	public CinemachineCameraManagerBase CameraManager; //Field offset: 0x48

	[Address(RVA = "0x286A710", Offset = "0x2869B10", Length = "0x7")]
	[Token(Token = "0x6000651")]
	public CinemachineCameraManagerEvents() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600064E")]
	protected virtual ICinemachineMixer GetMixer() { }

	[Address(RVA = "0x286A670", Offset = "0x2869A70", Length = "0x7")]
	[Token(Token = "0x6000650")]
	private void OnDisable() { }

	[Address(RVA = "0x286A680", Offset = "0x2869A80", Length = "0x8B")]
	[Token(Token = "0x600064F")]
	private void OnEnable() { }

}

