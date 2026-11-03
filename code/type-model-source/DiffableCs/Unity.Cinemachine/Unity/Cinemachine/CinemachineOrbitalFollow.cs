namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Position Control/Cinemachine Orbital Follow")]
[CameraPipeline(Stage::Body (0))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineOrbitalFollow.html")]
[RequiredTarget(RequiredTargets::Tracking (1))]
[SaveDuringPlay]
[Token(Token = "0x200005D")]
public class CinemachineOrbitalFollow : CinemachineComponentBase, IInputAxisOwner, IInputAxisResetSource, IModifierValueSource, IModifiablePositionDamping, IModifiableDistance
{
	[CompilerGenerated]
	[Token(Token = "0x2000060")]
	private struct <>c__DisplayClass50_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000185")]
		public Quaternion orient; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000186")]
		public Vector3 up; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000187")]
		public Vector3 dir; //Field offset: 0x1C
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000188")]
		public CinemachineOrbitalFollow <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000189")]
		public float distance; //Field offset: 0x30

	}

	[CompilerGenerated]
	[Token(Token = "0x2000061")]
	private struct <>c__DisplayClass50_1
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400018A")]
		public Vector3 cameraOffset; //Field offset: 0x0

	}

	[CompilerGenerated]
	[Token(Token = "0x2000062")]
	private struct <>c__DisplayClass50_2
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400018B")]
		public float bestAngle; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400018C")]
		public float best; //Field offset: 0x4

	}

	[Token(Token = "0x200005E")]
	internal enum OrbitStyles : int
	{
		Sphere = 0,
		ThreeRing = 1,
	}

	[Token(Token = "0x200005F")]
	internal enum ReferenceFrames : int
	{
		AxisCenter = 0,
		ParentObject = 1,
		TrackingTarget = 2,
		LookAtTarget = 3,
	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400016F")]
	[Tooltip("Offset from the target object's center in target-local space. Use this to fine-tune the orbit when the desired focus of the orbit is not the tracked object's center.")]
	public Vector3 TargetOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000170")]
	public TrackerSettings TrackerSettings; //Field offset: 0x34
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000171")]
	[Tooltip("Defines the manner in which the orbit surface is constructed.")]
	public OrbitStyles OrbitStyle; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000172")]
	[Tooltip("The camera will be placed at this distance from the Follow target.")]
	public float Radius; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[HideFoldout]
	[Token(Token = "0x4000173")]
	[Tooltip("Defines a complex surface rig from 3 horizontal rings.")]
	public Settings Orbits; //Field offset: 0x60
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000174")]
	[Tooltip("Defines the reference frame for horizontal recentering.  The axis center will be dynamically updated to be behind the selected object.")]
	public ReferenceFrames RecenteringTarget; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000175")]
	[Tooltip("Axis representing the current horizontal rotation.  Value is in degrees and represents a rotation about the up vector.")]
	public InputAxis HorizontalAxis; //Field offset: 0x80
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000176")]
	[Tooltip("Axis representing the current vertical rotation.  Value is in degrees and represents a rotation about the right vector.")]
	public InputAxis VerticalAxis; //Field offset: 0xB4
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000177")]
	[Tooltip("Axis controlling the scale of the current distance.  Value is a scalar multiplier and is applied to the specified camera distance.")]
	public InputAxis RadialAxis; //Field offset: 0xE8
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000178")]
	private Vector3 m_PreviousOffset; //Field offset: 0x11C
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000179")]
	private Tracker m_TargetTracker; //Field offset: 0x128
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400017A")]
	private OrbitSplineCache m_OrbitCache; //Field offset: 0x168
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x400017B")]
	private Action m_ResetHandler; //Field offset: 0x1A0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x400017C")]
	private Vector3 <TrackedPoint>k__BackingField; //Field offset: 0x1A8

	[Token(Token = "0x17000044")]
	private static InputAxis DefaultHorizontal
	{
		[Address(RVA = "0x28218E0", Offset = "0x2820CE0", Length = "0x5B")]
		[Token(Token = "0x60001AA")]
		private get { } //Length: 91
	}

	[Token(Token = "0x17000046")]
	private static InputAxis DefaultRadial
	{
		[Address(RVA = "0x2821940", Offset = "0x2820D40", Length = "0x64")]
		[Token(Token = "0x60001AC")]
		private get { } //Length: 100
	}

	[Token(Token = "0x17000045")]
	private static InputAxis DefaultVertical
	{
		[Address(RVA = "0x28219B0", Offset = "0x2820DB0", Length = "0x64")]
		[Token(Token = "0x60001AB")]
		private get { } //Length: 100
	}

	[Token(Token = "0x17000047")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2821A20", Offset = "0x2820E20", Length = "0x6D")]
		[Token(Token = "0x60001AD")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000048")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60001AE")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000043")]
	internal Vector3 TrackedPoint
	{
		[Address(RVA = "0x2821A90", Offset = "0x2820E90", Length = "0x19")]
		[CompilerGenerated]
		[Token(Token = "0x60001A6")]
		internal get { } //Length: 25
		[Address(RVA = "0x2821AB0", Offset = "0x2820EB0", Length = "0x16")]
		[CompilerGenerated]
		[Token(Token = "0x60001A7")]
		private set { } //Length: 22
	}

	[Token(Token = "0x1700004C")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.Distance
	{
		[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
		[Token(Token = "0x60001B7")]
		private get { } //Length: 6
		[Address(RVA = "0x2820D60", Offset = "0x2820160", Length = "0x6")]
		[Token(Token = "0x60001B8")]
		private set { } //Length: 6
	}

	[Token(Token = "0x1700004B")]
	private override Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.PositionDamping
	{
		[Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", Length = "0x13")]
		[Token(Token = "0x60001B5")]
		private get { } //Length: 19
		[Address(RVA = "0x1D14930", Offset = "0x1D13D30", Length = "0x10")]
		[Token(Token = "0x60001B6")]
		private set { } //Length: 16
	}

	[Token(Token = "0x1700004A")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.NormalizedModifierValue
	{
		[Address(RVA = "0x2820D70", Offset = "0x2820170", Length = "0x38")]
		[Token(Token = "0x60001B4")]
		private get { } //Length: 56
	}

	[Token(Token = "0x17000049")]
	private override bool Unity.Cinemachine.IInputAxisResetSource.HasResetHandler
	{
		[Address(RVA = "0x2821320", Offset = "0x2820720", Length = "0xC")]
		[Token(Token = "0x60001B3")]
		private get { } //Length: 12
	}

	[Address(RVA = "0x28216C0", Offset = "0x2820AC0", Length = "0x21D")]
	[Token(Token = "0x60001C3")]
	public CinemachineOrbitalFollow() { }

	[Address(RVA = "0x2820200", Offset = "0x281F600", Length = "0xEB")]
	[CompilerGenerated]
	[Token(Token = "0x60001CA")]
	private float <InferAxesFromPosition_ThreeRing>g__AngleFunction|50_4(float input, ref <>c__DisplayClass50_0 unnamed_param_1, ref <>c__DisplayClass50_1 unnamed_param_2) { }

	[Address(RVA = "0x28202F0", Offset = "0x281F6F0", Length = "0x3B")]
	[CompilerGenerated]
	[Token(Token = "0x60001CD")]
	private void <InferAxesFromPosition_ThreeRing>g__ChooseBestAngle|50_7(float x, ref <>c__DisplayClass50_0 unnamed_param_1, ref <>c__DisplayClass50_1 unnamed_param_2, ref <>c__DisplayClass50_2 unnamed_param_3) { }

	[Address(RVA = "0x2820330", Offset = "0x281F730", Length = "0x15F")]
	[CompilerGenerated]
	[Token(Token = "0x60001C7")]
	private float <InferAxesFromPosition_ThreeRing>g__GetHorizontalAxis|50_0(ref <>c__DisplayClass50_0 unnamed_param_0) { }

	[Address(RVA = "0x2820490", Offset = "0x281F890", Length = "0x397")]
	[CompilerGenerated]
	[Token(Token = "0x60001C8")]
	private float <InferAxesFromPosition_ThreeRing>g__GetVerticalAxisClosestValue|50_1(out Vector3 splinePoint, ref <>c__DisplayClass50_0 unnamed_param_1) { }

	[Address(RVA = "0x2820830", Offset = "0x281FC30", Length = "0x1BB")]
	[CompilerGenerated]
	[Token(Token = "0x60001CC")]
	private float <InferAxesFromPosition_ThreeRing>g__InitialGuess|50_6(ref <>c__DisplayClass50_0 unnamed_param_0, ref <>c__DisplayClass50_1 unnamed_param_1) { }

	[Address(RVA = "0x28209F0", Offset = "0x281FDF0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60001CE")]
	internal static float <InferAxesFromPosition_ThreeRing>g__MapTo01|50_3(float valueToMap, float fMin, float fMax) { }

	[Address(RVA = "0x2820A00", Offset = "0x281FE00", Length = "0x8B")]
	[CompilerGenerated]
	[Token(Token = "0x60001CB")]
	private float <InferAxesFromPosition_ThreeRing>g__SlopeOfAngleFunction|50_5(float input, ref <>c__DisplayClass50_0 unnamed_param_1, ref <>c__DisplayClass50_1 unnamed_param_2) { }

	[Address(RVA = "0x2820A90", Offset = "0x281FE90", Length = "0x2AC")]
	[CompilerGenerated]
	[Token(Token = "0x60001C9")]
	private float <InferAxesFromPosition_ThreeRing>g__SteepestDescent|50_2(Vector3 cameraOffset, ref <>c__DisplayClass50_0 unnamed_param_1) { }

	[Address(RVA = "0x1389050", Offset = "0x1388450", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60001C4")]
	private InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__32_0() { }

	[Address(RVA = "0x2820D40", Offset = "0x2820140", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60001C5")]
	private InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__32_1() { }

	[Address(RVA = "0x15EDFE0", Offset = "0x15ED3E0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60001C6")]
	private InputAxis <Unity.Cinemachine.IInputAxisOwner.GetInputAxes>b__32_2() { }

	[Address(RVA = "0x281DFA0", Offset = "0x281D3A0", Length = "0x906")]
	[Token(Token = "0x60001BC")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x28218E0", Offset = "0x2820CE0", Length = "0x5B")]
	[Token(Token = "0x60001AA")]
	private static InputAxis get_DefaultHorizontal() { }

	[Address(RVA = "0x2821940", Offset = "0x2820D40", Length = "0x64")]
	[Token(Token = "0x60001AC")]
	private static InputAxis get_DefaultRadial() { }

	[Address(RVA = "0x28219B0", Offset = "0x2820DB0", Length = "0x64")]
	[Token(Token = "0x60001AB")]
	private static InputAxis get_DefaultVertical() { }

	[Address(RVA = "0x2821A20", Offset = "0x2820E20", Length = "0x6D")]
	[Token(Token = "0x60001AD")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60001AE")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x2821A90", Offset = "0x2820E90", Length = "0x19")]
	[CompilerGenerated]
	[Token(Token = "0x60001A6")]
	internal Vector3 get_TrackedPoint() { }

	[Address(RVA = "0x281E8B0", Offset = "0x281DCB0", Length = "0x6C")]
	[Token(Token = "0x60001B9")]
	internal Vector3 GetCameraOffsetForNormalizedAxisValue(float t) { }

	[Address(RVA = "0x281E920", Offset = "0x281DD20", Length = "0x2E3")]
	[Token(Token = "0x60001BA")]
	private Vector4 GetCameraPoint() { }

	[Address(RVA = "0x281EC10", Offset = "0x281E010", Length = "0x2E")]
	[Token(Token = "0x60001AF")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x281EC40", Offset = "0x281E040", Length = "0x138")]
	[Token(Token = "0x60001C2")]
	internal Quaternion GetReferenceOrientation() { }

	[Address(RVA = "0x281ED80", Offset = "0x281E180", Length = "0x221")]
	[Token(Token = "0x60001BD")]
	private void InferAxesFromPosition_Sphere(Vector3 dir, float distance, ref CameraState state) { }

	[Address(RVA = "0x281EFB0", Offset = "0x281E3B0", Length = "0x278")]
	[Token(Token = "0x60001BE")]
	private void InferAxesFromPosition_ThreeRing(Vector3 dir, float distance, ref CameraState state) { }

	[Address(RVA = "0x281F230", Offset = "0x281E630", Length = "0x8F7")]
	[Token(Token = "0x60001C0")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x281FB30", Offset = "0x281EF30", Length = "0xCB")]
	[Token(Token = "0x60001BF")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x281FC00", Offset = "0x281F000", Length = "0x33A")]
	[Token(Token = "0x60001BB")]
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x281FF40", Offset = "0x281F340", Length = "0x70")]
	[Token(Token = "0x60001A8")]
	private void OnValidate() { }

	[Address(RVA = "0x281FFB0", Offset = "0x281F3B0", Length = "0x249")]
	[Token(Token = "0x60001A9")]
	private void Reset() { }

	[Address(RVA = "0x2821AB0", Offset = "0x2820EB0", Length = "0x16")]
	[CompilerGenerated]
	[Token(Token = "0x60001A7")]
	private void set_TrackedPoint(Vector3 value) { }

	[Address(RVA = "0x2820D50", Offset = "0x2820150", Length = "0x6")]
	[Token(Token = "0x60001B7")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance() { }

	[Address(RVA = "0x2820D60", Offset = "0x2820160", Length = "0x6")]
	[Token(Token = "0x60001B8")]
	private override void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value) { }

	[Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", Length = "0x13")]
	[Token(Token = "0x60001B5")]
	private override Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping() { }

	[Address(RVA = "0x1D14930", Offset = "0x1D13D30", Length = "0x10")]
	[Token(Token = "0x60001B6")]
	private override void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(Vector3 value) { }

	[Address(RVA = "0x2820D70", Offset = "0x2820170", Length = "0x38")]
	[Token(Token = "0x60001B4")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue() { }

	[Address(RVA = "0x2820DB0", Offset = "0x28201B0", Length = "0x40A")]
	[Token(Token = "0x60001B0")]
	private override void Unity.Cinemachine.IInputAxisOwner.GetInputAxes(List<AxisDescriptor> axes) { }

	[Address(RVA = "0x2821320", Offset = "0x2820720", Length = "0xC")]
	[Token(Token = "0x60001B3")]
	private override bool Unity.Cinemachine.IInputAxisResetSource.get_HasResetHandler() { }

	[Address(RVA = "0x28211C0", Offset = "0x28205C0", Length = "0xAB")]
	[Token(Token = "0x60001B1")]
	private override void Unity.Cinemachine.IInputAxisResetSource.RegisterResetHandler(Action handler) { }

	[Address(RVA = "0x2821270", Offset = "0x2820670", Length = "0xAB")]
	[Token(Token = "0x60001B2")]
	private override void Unity.Cinemachine.IInputAxisResetSource.UnregisterResetHandler(Action handler) { }

	[Address(RVA = "0x2821330", Offset = "0x2820730", Length = "0x38C")]
	[Token(Token = "0x60001C1")]
	private void UpdateHorizontalCenter(Quaternion referenceOrientation) { }

}

