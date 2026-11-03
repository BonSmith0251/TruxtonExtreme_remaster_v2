namespace UnityEngine.InputSystem.XR;

[AddComponentMenu("XR/Tracked Pose Driver (Input System)")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/TrackedInputDevices.html#tracked-pose-driver")]
[Token(Token = "0x20000E7")]
public class TrackedPoseDriver : MonoBehaviour, ISerializationCallbackReceiver
{
	[Flags]
	[Token(Token = "0x20000E9")]
	private enum TrackingStates : int
	{
		None = 0,
		Position = 1,
		Rotation = 2,
	}

	[Token(Token = "0x20000E8")]
	internal enum TrackingType : int
	{
		RotationAndPosition = 0,
		RotationOnly = 1,
		PositionOnly = 2,
	}

	[Token(Token = "0x20000EA")]
	internal enum UpdateType : int
	{
		UpdateAndBeforeRender = 0,
		Update = 1,
		BeforeRender = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000574")]
	[Tooltip("Which Transform properties to update.")]
	private TrackingType m_TrackingType; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000575")]
	[Tooltip("Updates the Transform properties after these phases of Input System event processing.")]
	private UpdateType m_UpdateType; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000576")]
	[Tooltip("Ignore Tracking State and always treat the input pose as valid.")]
	private bool m_IgnoreTrackingState; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000577")]
	[Tooltip("The input action to read the position value of a tracked device. Must be a Vector 3 control type.")]
	private InputActionProperty m_PositionInput; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000578")]
	[Tooltip("The input action to read the rotation value of a tracked device. Must be a Quaternion control type.")]
	private InputActionProperty m_RotationInput; //Field offset: 0x48
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000579")]
	[Tooltip("The input action to read the tracking state value of a tracked device. Identifies if position and rotation have valid data. Must be an Integer control type.")]
	private InputActionProperty m_TrackingStateInput; //Field offset: 0x60
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400057A")]
	private Vector3 m_CurrentPosition; //Field offset: 0x78
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400057B")]
	private Quaternion m_CurrentRotation; //Field offset: 0x84
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400057C")]
	private TrackingStates m_CurrentTrackingState; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400057D")]
	private bool m_RotationBound; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x400057E")]
	private bool m_PositionBound; //Field offset: 0x99
	[FieldOffset(Offset = "0x9A")]
	[Token(Token = "0x400057F")]
	private bool m_TrackingStateBound; //Field offset: 0x9A
	[FieldOffset(Offset = "0x9B")]
	[Token(Token = "0x4000580")]
	private bool m_IsFirstUpdate; //Field offset: 0x9B
	[FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	[Token(Token = "0x4000581")]
	private InputAction m_PositionAction; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	[Obsolete]
	[SerializeField]
	[Token(Token = "0x4000582")]
	private InputAction m_RotationAction; //Field offset: 0xA8

	[Token(Token = "0x1700032E")]
	public bool ignoreTrackingState
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000C36")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x6000C37")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000332")]
	public InputAction positionAction
	{
		[Address(RVA = "0x29CCF90", Offset = "0x29CC390", Length = "0xB")]
		[Token(Token = "0x6000C5B")]
		 get { } //Length: 11
		[Address(RVA = "0x29CD010", Offset = "0x29CC410", Length = "0xDE")]
		[Token(Token = "0x6000C5C")]
		 set { } //Length: 222
	}

	[Token(Token = "0x1700032F")]
	public InputActionProperty positionInput
	{
		[Address(RVA = "0x29CCFA0", Offset = "0x29CC3A0", Length = "0x15")]
		[Token(Token = "0x6000C38")]
		 get { } //Length: 21
		[Address(RVA = "0x29CD0F0", Offset = "0x29CC4F0", Length = "0xB5")]
		[Token(Token = "0x6000C39")]
		 set { } //Length: 181
	}

	[Token(Token = "0x17000333")]
	public InputAction rotationAction
	{
		[Address(RVA = "0x29CCFC0", Offset = "0x29CC3C0", Length = "0xB")]
		[Token(Token = "0x6000C5D")]
		 get { } //Length: 11
		[Address(RVA = "0x29CD1B0", Offset = "0x29CC5B0", Length = "0xDE")]
		[Token(Token = "0x6000C5E")]
		 set { } //Length: 222
	}

	[Token(Token = "0x17000330")]
	public InputActionProperty rotationInput
	{
		[Address(RVA = "0x29CCFD0", Offset = "0x29CC3D0", Length = "0x15")]
		[Token(Token = "0x6000C3A")]
		 get { } //Length: 21
		[Address(RVA = "0x29CD290", Offset = "0x29CC690", Length = "0xB5")]
		[Token(Token = "0x6000C3B")]
		 set { } //Length: 181
	}

	[Token(Token = "0x17000331")]
	public InputActionProperty trackingStateInput
	{
		[Address(RVA = "0x29CCFF0", Offset = "0x29CC3F0", Length = "0x15")]
		[Token(Token = "0x6000C3C")]
		 get { } //Length: 21
		[Address(RVA = "0x29CD350", Offset = "0x29CC750", Length = "0xB5")]
		[Token(Token = "0x6000C3D")]
		 set { } //Length: 181
	}

	[Token(Token = "0x1700032C")]
	public TrackingType trackingType
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000C32")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000C33")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700032D")]
	public UpdateType updateType
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000C34")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x6000C35")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x29CCEF0", Offset = "0x29CC2F0", Length = "0x99")]
	[Token(Token = "0x6000C61")]
	public TrackedPoseDriver() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000C4E")]
	protected override void Awake() { }

	[Address(RVA = "0x29CB960", Offset = "0x29CAD60", Length = "0x29")]
	[Token(Token = "0x6000C3E")]
	private void BindActions() { }

	[Address(RVA = "0x29CB990", Offset = "0x29CAD90", Length = "0x17A")]
	[Token(Token = "0x6000C40")]
	private void BindPosition() { }

	[Address(RVA = "0x29CBB10", Offset = "0x29CAF10", Length = "0x17A")]
	[Token(Token = "0x6000C41")]
	private void BindRotation() { }

	[Address(RVA = "0x29CBC90", Offset = "0x29CB090", Length = "0x17A")]
	[Token(Token = "0x6000C42")]
	private void BindTrackingState() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000C36")]
	public bool get_ignoreTrackingState() { }

	[Address(RVA = "0x29CCF90", Offset = "0x29CC390", Length = "0xB")]
	[Token(Token = "0x6000C5B")]
	public InputAction get_positionAction() { }

	[Address(RVA = "0x29CCFA0", Offset = "0x29CC3A0", Length = "0x15")]
	[Token(Token = "0x6000C38")]
	public InputActionProperty get_positionInput() { }

	[Address(RVA = "0x29CCFC0", Offset = "0x29CC3C0", Length = "0xB")]
	[Token(Token = "0x6000C5D")]
	public InputAction get_rotationAction() { }

	[Address(RVA = "0x29CCFD0", Offset = "0x29CC3D0", Length = "0x15")]
	[Token(Token = "0x6000C3A")]
	public InputActionProperty get_rotationInput() { }

	[Address(RVA = "0x29CCFF0", Offset = "0x29CC3F0", Length = "0x15")]
	[Token(Token = "0x6000C3C")]
	public InputActionProperty get_trackingStateInput() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000C32")]
	public TrackingType get_trackingType() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000C34")]
	public UpdateType get_updateType() { }

	[Address(RVA = "0x29CBE10", Offset = "0x29CB210", Length = "0xC1")]
	[Token(Token = "0x6000C5A")]
	private static bool HasResolvedControl(InputAction action) { }

	[Address(RVA = "0x29CBEE0", Offset = "0x29CB2E0", Length = "0x21")]
	[Token(Token = "0x6000C57")]
	protected override void OnBeforeRender() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000C51")]
	protected override void OnDestroy() { }

	[Address(RVA = "0x29CBF10", Offset = "0x29CB310", Length = "0x11")]
	[Token(Token = "0x6000C53")]
	private void OnDeviceChanged(InputDevice inputDevice, InputDeviceChange inputDeviceChange) { }

	[Address(RVA = "0x29CBF30", Offset = "0x29CB330", Length = "0xF2")]
	[Token(Token = "0x6000C50")]
	protected void OnDisable() { }

	[Address(RVA = "0x29CC030", Offset = "0x29CB430", Length = "0xFA")]
	[Token(Token = "0x6000C4F")]
	protected void OnEnable() { }

	[Address(RVA = "0x29CC130", Offset = "0x29CB530", Length = "0x4B")]
	[Token(Token = "0x6000C48")]
	private void OnPositionCanceled(CallbackContext context) { }

	[Address(RVA = "0x29CC180", Offset = "0x29CB580", Length = "0x60")]
	[Token(Token = "0x6000C47")]
	private void OnPositionPerformed(CallbackContext context) { }

	[Address(RVA = "0x29CC1E0", Offset = "0x29CB5E0", Length = "0x43")]
	[Token(Token = "0x6000C4A")]
	private void OnRotationCanceled(CallbackContext context) { }

	[Address(RVA = "0x29CC230", Offset = "0x29CB630", Length = "0x57")]
	[Token(Token = "0x6000C49")]
	private void OnRotationPerformed(CallbackContext context) { }

	[Address(RVA = "0x29CC290", Offset = "0x29CB690", Length = "0xB")]
	[Token(Token = "0x6000C4C")]
	private void OnTrackingStateCanceled(CallbackContext context) { }

	[Address(RVA = "0x29CC2A0", Offset = "0x29CB6A0", Length = "0x4C")]
	[Token(Token = "0x6000C4B")]
	private void OnTrackingStatePerformed(CallbackContext context) { }

	[Address(RVA = "0x29CC2F0", Offset = "0x29CB6F0", Length = "0x21")]
	[Token(Token = "0x6000C56")]
	protected override void OnUpdate() { }

	[Address(RVA = "0x29CC320", Offset = "0x29CB720", Length = "0x47")]
	[Token(Token = "0x6000C58")]
	protected override void PerformUpdate() { }

	[Address(RVA = "0x29CC410", Offset = "0x29CB810", Length = "0xAB")]
	[Token(Token = "0x6000C55")]
	private void ReadTrackingState() { }

	[Address(RVA = "0x29CC370", Offset = "0x29CB770", Length = "0xA0")]
	[Token(Token = "0x6000C54")]
	private void ReadTrackingStateWithoutTrackingAction() { }

	[Address(RVA = "0x29CC4C0", Offset = "0x29CB8C0", Length = "0x2A")]
	[Token(Token = "0x6000C43")]
	private static void RenameAndEnable(InputAction action, string name) { }

	[Address(RVA = "0x29CC4F0", Offset = "0x29CB8F0", Length = "0x20D")]
	[Token(Token = "0x6000C4D")]
	protected void Reset() { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x6000C37")]
	public void set_ignoreTrackingState(bool value) { }

	[Address(RVA = "0x29CD010", Offset = "0x29CC410", Length = "0xDE")]
	[Token(Token = "0x6000C5C")]
	public void set_positionAction(InputAction value) { }

	[Address(RVA = "0x29CD0F0", Offset = "0x29CC4F0", Length = "0xB5")]
	[Token(Token = "0x6000C39")]
	public void set_positionInput(InputActionProperty value) { }

	[Address(RVA = "0x29CD1B0", Offset = "0x29CC5B0", Length = "0xDE")]
	[Token(Token = "0x6000C5E")]
	public void set_rotationAction(InputAction value) { }

	[Address(RVA = "0x29CD290", Offset = "0x29CC690", Length = "0xB5")]
	[Token(Token = "0x6000C3B")]
	public void set_rotationInput(InputActionProperty value) { }

	[Address(RVA = "0x29CD350", Offset = "0x29CC750", Length = "0xB5")]
	[Token(Token = "0x6000C3D")]
	public void set_trackingStateInput(InputActionProperty value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000C33")]
	public void set_trackingType(TrackingType value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x6000C35")]
	public void set_updateType(UpdateType value) { }

	[Address(RVA = "0x29CC700", Offset = "0x29CBB00", Length = "0x11E")]
	[Token(Token = "0x6000C59")]
	protected override void SetLocalTransform(Vector3 newPosition, Quaternion newRotation) { }

	[Address(RVA = "0x29CC820", Offset = "0x29CBC20", Length = "0x29")]
	[Token(Token = "0x6000C3F")]
	private void UnbindActions() { }

	[Address(RVA = "0x29CC850", Offset = "0x29CBC50", Length = "0x130")]
	[Token(Token = "0x6000C44")]
	private void UnbindPosition() { }

	[Address(RVA = "0x29CC980", Offset = "0x29CBD80", Length = "0x130")]
	[Token(Token = "0x6000C45")]
	private void UnbindRotation() { }

	[Address(RVA = "0x29CCAB0", Offset = "0x29CBEB0", Length = "0x130")]
	[Token(Token = "0x6000C46")]
	private void UnbindTrackingState() { }

	[Address(RVA = "0x29CCBE0", Offset = "0x29CBFE0", Length = "0xC3")]
	[Token(Token = "0x6000C60")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000C5F")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	[Address(RVA = "0x29CCCB0", Offset = "0x29CC0B0", Length = "0x23A")]
	[Token(Token = "0x6000C52")]
	protected void UpdateCallback() { }

}

