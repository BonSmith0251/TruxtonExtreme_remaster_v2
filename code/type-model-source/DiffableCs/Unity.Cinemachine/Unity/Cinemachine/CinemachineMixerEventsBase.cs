namespace Unity.Cinemachine;

[SaveDuringPlay]
[Token(Token = "0x2000147")]
public abstract class CinemachineMixerEventsBase : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Space]
	[Token(Token = "0x400055E")]
	[Tooltip("This event will fire whenever a virtual camera goes live.  If a blend is involved, then the event will fire on the first frame of the blend.")]
	public CameraEvent CameraActivatedEvent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400055F")]
	[Tooltip("This event will fire whenever a virtual stops being live.  If a blend is involved, then the event will fire after the last frame of the blend.")]
	public CameraEvent CameraDeactivatedEvent; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000560")]
	[Tooltip("This event will fire whenever a blend is created in the root frame of this Brain.  The handler can modify any settings in the blend, except the cameras themselves.  Note: timeline tracks will not generate these events.")]
	public BlendEvent BlendCreatedEvent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000561")]
	[Tooltip("This event will fire whenever a virtual camera finishes blending in.  It will not fire if the blend length is zero.")]
	public CameraEvent BlendFinishedEvent; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000562")]
	[Tooltip("This event is fired when there is a camera cut.  A camera cut is a camera activation with a zero-length blend.")]
	public CameraEvent CameraCutEvent; //Field offset: 0x40

	[Address(RVA = "0x2870300", Offset = "0x286F700", Length = "0x116")]
	[Token(Token = "0x600066A")]
	protected CinemachineMixerEventsBase() { }

	[Token(Token = "0x6000663")]
	protected abstract ICinemachineMixer GetMixer() { }

	[Address(RVA = "0x286FC90", Offset = "0x286F090", Length = "0x21F")]
	[Token(Token = "0x6000664")]
	protected void InstallHandlers(ICinemachineMixer mixer) { }

	[Address(RVA = "0x286FEB0", Offset = "0x286F2B0", Length = "0x79")]
	[Token(Token = "0x6000668")]
	private void OnBlendCreated(BlendEventParams evt) { }

	[Address(RVA = "0x286FF30", Offset = "0x286F330", Length = "0x7F")]
	[Token(Token = "0x6000669")]
	private void OnBlendFinished(ICinemachineMixer mixer, ICinemachineCamera cam) { }

	[Address(RVA = "0x286FFB0", Offset = "0x286F3B0", Length = "0xAC")]
	[Token(Token = "0x6000666")]
	private void OnCameraActivated(ActivationEventParams evt) { }

	[Address(RVA = "0x2870060", Offset = "0x286F460", Length = "0x7F")]
	[Token(Token = "0x6000667")]
	private void OnCameraDeactivated(ICinemachineMixer mixer, ICinemachineCamera cam) { }

	[Address(RVA = "0x28700E0", Offset = "0x286F4E0", Length = "0x212")]
	[Token(Token = "0x6000665")]
	protected void UninstallHandlers() { }

}

