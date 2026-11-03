namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Rotation Control/Cinemachine Pan Tilt")]
[CameraPipeline(Stage::Aim (1))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachinePanTilt.html")]
[SaveDuringPlay]
[Token(Token = "0x2000067")]
public class CinemachinePanTilt : CinemachineComponentBase, IInputAxisOwner, IInputAxisResetSource, IModifierValueSource
{
	[Token(Token = "0x2000069")]
	internal enum RecenterTargetModes : int
	{
		AxisCenter = 0,
		TrackingTargetForward = 1,
		LookAtTargetForward = 2,
	}

	[Token(Token = "0x2000068")]
	internal enum ReferenceFrames : int
	{
		ParentObject = 0,
		World = 1,
		TrackingTarget = 2,
		LookAtTarget = 3,
	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000197")]
	public ReferenceFrames ReferenceFrame; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000198")]
	public RecenterTargetModes RecenterTarget; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000199")]
	[Tooltip("Axis representing the current horizontal rotation.  Value is in degrees and represents a rotation about the Y axis.")]
	public InputAxis PanAxis; //Field offset: 0x30
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400019A")]
	[Tooltip("Axis representing the current vertical rotation.  Value is in degrees and represents a rotation about the X axis.")]
	public InputAxis TiltAxis; //Field offset: 0x64
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400019B")]
	private Quaternion m_PreviousCameraRotation; //Field offset: 0x98
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400019C")]
	private Action m_ResetHandler; //Field offset: 0xA8

	[Token(Token = "0x1700004E")]
	private static InputAxis DefaultPan
	{
		[Address(RVA = "0x28218E0", Offset = "0x2820CE0", Length = "0x5B")]
		[Token(Token = "0x60001D5")]
		private get { } //Length: 91
	}

	[Token(Token = "0x1700004F")]
	private static InputAxis DefaultTilt
	{
		[Address(RVA = "0x28233E0", Offset = "0x28227E0", Length = "0x5A")]
		[Token(Token = "0x60001D6")]
		private get { } //Length: 90
	}

	[Token(Token = "0x17000052")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x1CC9FE0", Offset = "0x1CC93E0", Length = "0x7")]
		[Token(Token = "0x60001DC")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000053")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x60001DD")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000050")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.NormalizedModifierValue
	{
		[Address(RVA = "0x2822E50", Offset = "0x2822250", Length = "0x35")]
		[Token(Token = "0x60001DA")]
		private get { } //Length: 53
	}

	[Token(Token = "0x17000051")]
	private override bool Unity.Cinemachine.IInputAxisResetSource.HasResetHandler
	{
		[Address(RVA = "0x22F0F50", Offset = "0x22F0350", Length = "0xC")]
		[Token(Token = "0x60001DB")]
		private get { } //Length: 12
	}

	[Address(RVA = "0x28232D0", Offset = "0x28226D0", Length = "0x104")]
	[Token(Token = "0x60001E5")]
	public CinemachinePanTilt() { }

	[Address(RVA = "0x2822E00", Offset = "0x2822200", Length = "0x26")]
	[CompilerGenerated]
	[Token(Token = "0x60001E8")]
	internal static float <GetRecenterTarget>g__NormalizeAngle|31_0(float angle) { }

	[Address(RVA = "0x2822E30", Offset = "0x2822230", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001E6")]
	private InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__14_0() { }

	[Address(RVA = "0x2822E40", Offset = "0x2822240", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60001E7")]
	private InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__14_1() { }

	[Address(RVA = "0x2821AD0", Offset = "0x2820ED0", Length = "0x1F")]
	[Token(Token = "0x60001E0")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x28218E0", Offset = "0x2820CE0", Length = "0x5B")]
	[Token(Token = "0x60001D5")]
	private static InputAxis get_DefaultPan() { }

	[Address(RVA = "0x28233E0", Offset = "0x28227E0", Length = "0x5A")]
	[Token(Token = "0x60001D6")]
	private static InputAxis get_DefaultTilt() { }

	[Address(RVA = "0x1CC9FE0", Offset = "0x1CC93E0", Length = "0x7")]
	[Token(Token = "0x60001DC")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x60001DD")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x2821AF0", Offset = "0x2820EF0", Length = "0x2F4")]
	[Token(Token = "0x60001E4")]
	public Vector2 GetRecenterTarget() { }

	[Address(RVA = "0x2821DF0", Offset = "0x28211F0", Length = "0x16D")]
	[Token(Token = "0x60001E3")]
	private Quaternion GetReferenceFrame(Vector3 up) { }

	[Address(RVA = "0x2821F60", Offset = "0x2821360", Length = "0x5D4")]
	[Token(Token = "0x60001DF")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2822540", Offset = "0x2821940", Length = "0x21B")]
	[Token(Token = "0x60001E1")]
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2822760", Offset = "0x2821B60", Length = "0x6C")]
	[Token(Token = "0x60001D3")]
	private void OnValidate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001DE")]
	public virtual void PrePipelineMutateCameraState(ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x28227D0", Offset = "0x2821BD0", Length = "0xFF")]
	[Token(Token = "0x60001D4")]
	private void Reset() { }

	[Address(RVA = "0x28228D0", Offset = "0x2821CD0", Length = "0x521")]
	[Token(Token = "0x60001E2")]
	private void SetAxesForRotation(Quaternion targetRot) { }

	[Address(RVA = "0x2822E50", Offset = "0x2822250", Length = "0x35")]
	[Token(Token = "0x60001DA")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue() { }

	[Address(RVA = "0x2822E90", Offset = "0x2822290", Length = "0x2D7")]
	[Token(Token = "0x60001D7")]
	private override void Unity.Cinemachine.IInputAxisOwner.GetInputAxes(List<AxisDescriptor> axes) { }

	[Address(RVA = "0x22F0F50", Offset = "0x22F0350", Length = "0xC")]
	[Token(Token = "0x60001DB")]
	private override bool Unity.Cinemachine.IInputAxisResetSource.get_HasResetHandler() { }

	[Address(RVA = "0x2823170", Offset = "0x2822570", Length = "0xAB")]
	[Token(Token = "0x60001D8")]
	private override void Unity.Cinemachine.IInputAxisResetSource.RegisterResetHandler(Action handler) { }

	[Address(RVA = "0x2823220", Offset = "0x2822620", Length = "0xAB")]
	[Token(Token = "0x60001D9")]
	private override void Unity.Cinemachine.IInputAxisResetSource.UnregisterResetHandler(Action handler) { }

}

