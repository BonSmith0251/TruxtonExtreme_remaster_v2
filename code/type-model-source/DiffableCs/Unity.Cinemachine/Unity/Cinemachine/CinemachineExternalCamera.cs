namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Cinemachine External Camera")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineExternalCamera.html")]
[RequireComponent(typeof(Camera))]
[Token(Token = "0x2000024")]
public class CinemachineExternalCamera : CinemachineVirtualCameraBase
{
	[FieldOffset(Offset = "0xA0")]
	[FormerlySerializedAs("m_PositionBlending")]
	[FormerlySerializedAs("m_BlendHint")]
	[Token(Token = "0x400009F")]
	[Tooltip("Hint for transitioning to and from this CinemachineCamera.  Hints can be combined, although not all combinations make sense.  In the case of conflicting hints, Cinemachine will make an arbitrary choice.")]
	public BlendHints BlendHint; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[FormerlySerializedAs("m_LookAt")]
	[NoSaveDuringPlay]
	[Token(Token = "0x40000A0")]
	[Tooltip("The object that the camera is looking at.  Setting this may improve the quality of the blends to and from this camera")]
	public Transform LookAtTarget; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40000A1")]
	private Camera m_Camera; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40000A2")]
	private CameraState m_State; //Field offset: 0xB8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40000A3")]
	private Transform <Follow>k__BackingField; //Field offset: 0x1C8

	[HideInInspector]
	[Token(Token = "0x17000019")]
	public virtual Transform Follow
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000AF")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000B0")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000018")]
	public virtual Transform LookAt
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x60000AD")]
		 get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[Token(Token = "0x60000AE")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000017")]
	public virtual CameraState State
	{
		[Address(RVA = "0x280F1D0", Offset = "0x280E5D0", Length = "0x76")]
		[Token(Token = "0x60000AC")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x280F080", Offset = "0x280E480", Length = "0x147")]
	[Token(Token = "0x60000B2")]
	public CinemachineExternalCamera() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000AF")]
	public virtual Transform get_Follow() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x60000AD")]
	public virtual Transform get_LookAt() { }

	[Address(RVA = "0x280F1D0", Offset = "0x280E5D0", Length = "0x76")]
	[Token(Token = "0x60000AC")]
	public virtual CameraState get_State() { }

	[Address(RVA = "0x280E9B0", Offset = "0x280DDB0", Length = "0x6CA")]
	[Token(Token = "0x60000B1")]
	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000B0")]
	public virtual void set_Follow(Transform value) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[Token(Token = "0x60000AE")]
	public virtual void set_LookAt(Transform value) { }

}

