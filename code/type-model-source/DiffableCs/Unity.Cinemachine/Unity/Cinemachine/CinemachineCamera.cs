namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Cinemachine Camera")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineCamera.html")]
[SaveDuringPlay]
[Token(Token = "0x200000D")]
public sealed class CinemachineCamera : CinemachineVirtualCameraBase
{
	[FieldOffset(Offset = "0xA0")]
	[NoSaveDuringPlay]
	[Token(Token = "0x4000027")]
	[Tooltip("Specifies the Tracking and LookAt targets for this camera.")]
	public CameraTarget Target; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000028")]
	[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera's lens settings, and will be used to drive the Unity camera when the vcam is active.")]
	public LensSettings Lens; //Field offset: 0xB8
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000029")]
	[Tooltip("Hint for transitioning to and from this CinemachineCamera.  Hints can be combined, although not all combinations make sense.  In the case of conflicting hints, Cinemachine will make an arbitrary choice.")]
	public BlendHints BlendHint; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400002A")]
	private CameraState m_State; //Field offset: 0x118
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x400002B")]
	private CinemachineComponentBase[] m_Pipeline; //Field offset: 0x228

	[Token(Token = "0x17000011")]
	public virtual Transform Follow
	{
		[Address(RVA = "0x2803A30", Offset = "0x2802E30", Length = "0xF")]
		[Token(Token = "0x6000042")]
		 get { } //Length: 15
		[Address(RVA = "0x2803B00", Offset = "0x2802F00", Length = "0xF")]
		[Token(Token = "0x6000043")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000010")]
	public virtual Transform LookAt
	{
		[Address(RVA = "0x2803A40", Offset = "0x2802E40", Length = "0x27")]
		[Token(Token = "0x6000040")]
		 get { } //Length: 39
		[Address(RVA = "0x2803B10", Offset = "0x2802F10", Length = "0x1A")]
		[Token(Token = "0x6000041")]
		 set { } //Length: 26
	}

	[Token(Token = "0x17000012")]
	internal bool PipelineCacheInvalidated
	{
		[Address(RVA = "0x2803A70", Offset = "0x2802E70", Length = "0xC")]
		[Token(Token = "0x600004B")]
		internal get { } //Length: 12
	}

	[Token(Token = "0x1700000F")]
	public virtual CameraState State
	{
		[Address(RVA = "0x2803A80", Offset = "0x2802E80", Length = "0x76")]
		[Token(Token = "0x600003F")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x2803890", Offset = "0x2802C90", Length = "0x197")]
	[Token(Token = "0x600004F")]
	public CinemachineCamera() { }

	[Address(RVA = "0x2802390", Offset = "0x2801790", Length = "0x1B3")]
	[Token(Token = "0x6000045")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x2803A30", Offset = "0x2802E30", Length = "0xF")]
	[Token(Token = "0x6000042")]
	public virtual Transform get_Follow() { }

	[Address(RVA = "0x2803A40", Offset = "0x2802E40", Length = "0x27")]
	[Token(Token = "0x6000040")]
	public virtual Transform get_LookAt() { }

	[Address(RVA = "0x2803A70", Offset = "0x2802E70", Length = "0xC")]
	[Token(Token = "0x600004B")]
	internal bool get_PipelineCacheInvalidated() { }

	[Address(RVA = "0x2803A80", Offset = "0x2802E80", Length = "0x76")]
	[Token(Token = "0x600003F")]
	public virtual CameraState get_State() { }

	[Address(RVA = "0x2802550", Offset = "0x2801950", Length = "0x56")]
	[Token(Token = "0x600004E")]
	public virtual CinemachineComponentBase GetCinemachineComponent(Stage stage) { }

	[Address(RVA = "0x28025B0", Offset = "0x28019B0", Length = "0x132")]
	[Token(Token = "0x6000046")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x28026F0", Offset = "0x2801AF0", Length = "0x37B")]
	[Token(Token = "0x6000048")]
	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2802A70", Offset = "0x2801E70", Length = "0x19")]
	[Token(Token = "0x600004A")]
	internal void InvalidatePipelineCache() { }

	[Address(RVA = "0x2802A90", Offset = "0x2801E90", Length = "0x33A")]
	[Token(Token = "0x6000049")]
	private CameraState InvokeComponentPipeline(ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2802DD0", Offset = "0x28021D0", Length = "0x263")]
	[Token(Token = "0x6000044")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x2803040", Offset = "0x2802440", Length = "0x4E1")]
	[Token(Token = "0x6000047")]
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2803530", Offset = "0x2802930", Length = "0xE")]
	[Token(Token = "0x600003E")]
	private void OnValidate() { }

	[Address(RVA = "0x2803540", Offset = "0x2802940", Length = "0xB6")]
	[Token(Token = "0x600004C")]
	internal Type PeekPipelineCacheType(Stage stage) { }

	[Address(RVA = "0x2803600", Offset = "0x2802A00", Length = "0x82")]
	[Token(Token = "0x600003D")]
	private void Reset() { }

	[Address(RVA = "0x2803B00", Offset = "0x2802F00", Length = "0xF")]
	[Token(Token = "0x6000043")]
	public virtual void set_Follow(Transform value) { }

	[Address(RVA = "0x2803B10", Offset = "0x2802F10", Length = "0x1A")]
	[Token(Token = "0x6000041")]
	public virtual void set_LookAt(Transform value) { }

	[Address(RVA = "0x2803690", Offset = "0x2802A90", Length = "0x1FB")]
	[Token(Token = "0x600004D")]
	private void UpdatePipelineCache() { }

}

