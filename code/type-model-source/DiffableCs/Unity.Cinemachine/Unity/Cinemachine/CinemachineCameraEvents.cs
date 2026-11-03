namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine Camera Events")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineCameraEvents.html")]
[SaveDuringPlay]
[Token(Token = "0x2000141")]
public class CinemachineCameraEvents : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000550")]
	[Tooltip("This is the object whose events are being monitored.  If null and the current GameObject has a CinemachineVirtualCameraBase component, that component will be used.")]
	public CinemachineVirtualCameraBase EventTarget; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Space]
	[Token(Token = "0x4000551")]
	[Tooltip("This event will fire whenever a virtual camera becomes active in the context of a mixer.  If a blend is involved, then the event will fire on the first frame of the blend.")]
	public CameraEvent CameraActivatedEvent; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000552")]
	[Tooltip("This event will fire whenever a virtual stops being live.  If a blend is involved, then the event will fire after the last frame of the blend.")]
	public CameraEvent CameraDeactivatedEvent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000553")]
	[Tooltip("This event will fire whenever a blend is created that involves this camera.  The handler can modify any settings in the blend, except the cameras themselves.")]
	public BlendEvent BlendCreatedEvent; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000554")]
	[Tooltip("This event will fire whenever a virtual camera finishes blending in.  It will not fire if the blend length is zero.")]
	public CameraEvent BlendFinishedEvent; //Field offset: 0x40

	[Address(RVA = "0x286A580", Offset = "0x2869980", Length = "0xED")]
	[Token(Token = "0x600064D")]
	public CinemachineCameraEvents() { }

	[Address(RVA = "0x2869EF0", Offset = "0x28692F0", Length = "0x71")]
	[Token(Token = "0x600064A")]
	private void OnBlendCreated(BlendEventParams evt) { }

	[Address(RVA = "0x2869F70", Offset = "0x2869370", Length = "0x6A")]
	[Token(Token = "0x600064B")]
	private void OnBlendFinished(ICinemachineMixer mixer, ICinemachineCamera cam) { }

	[Address(RVA = "0x2869FE0", Offset = "0x28693E0", Length = "0x6D")]
	[Token(Token = "0x6000649")]
	private void OnCameraActivated(ActivationEventParams evt) { }

	[Address(RVA = "0x286A050", Offset = "0x2869450", Length = "0x6A")]
	[Token(Token = "0x600064C")]
	private void OnCameraDeactivated(ICinemachineMixer mixer, ICinemachineCamera cam) { }

	[Address(RVA = "0x286A0C0", Offset = "0x28694C0", Length = "0x212")]
	[Token(Token = "0x6000648")]
	private void OnDisable() { }

	[Address(RVA = "0x286A2E0", Offset = "0x28696E0", Length = "0x296")]
	[Token(Token = "0x6000647")]
	private void OnEnable() { }

}

