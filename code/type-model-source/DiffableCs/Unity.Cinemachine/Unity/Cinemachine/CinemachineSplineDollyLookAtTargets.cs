namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Rotation Control/Cinemachine Spline Dolly LookAt Targets")]
[CameraPipeline(Stage::Aim (1))]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineSplineDollyLookAtTargets.html")]
[SaveDuringPlay]
[Token(Token = "0x2000071")]
public class CinemachineSplineDollyLookAtTargets : CinemachineComponentBase
{
	[Token(Token = "0x2000072")]
	internal struct Item
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E3")]
		[Tooltip("The target object to look at.  It may be None, in which case the Offset will specify a point in world space.")]
		public Transform LookAt; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40001E4")]
		[Tooltip("The offset (in local coords) from the LookAt target's origin.  If LookAt target is None, this will specify a world-space point.")]
		public Vector3 Offset; //Field offset: 0x8
		[FieldOffset(Offset = "0x14")]
		[Range(0, 1)]
		[Token(Token = "0x40001E5")]
		[Tooltip("Controls how to ease in and out of this data point.  A value of 0 will linearly interpolate between LookAt points, while a value of 1 will slow down and briefly pause the rotation to look at the target.")]
		public float Easing; //Field offset: 0x14

		[Token(Token = "0x1700006C")]
		public Vector3 WorldLookAt
		{
			[Address(RVA = "0x2832690", Offset = "0x2831A90", Length = "0xBA")]
			[IsReadOnly]
			[Token(Token = "0x6000232")]
			 get { } //Length: 186
			[Address(RVA = "0x2832750", Offset = "0x2831B50", Length = "0xB2")]
			[Token(Token = "0x6000233")]
			 set { } //Length: 178
		}

		[Address(RVA = "0x2832690", Offset = "0x2831A90", Length = "0xBA")]
		[IsReadOnly]
		[Token(Token = "0x6000232")]
		public Vector3 get_WorldLookAt() { }

		[Address(RVA = "0x2832750", Offset = "0x2831B50", Length = "0xB2")]
		[Token(Token = "0x6000233")]
		public void set_WorldLookAt(Vector3 value) { }

	}

	[Token(Token = "0x2000073")]
	public struct LerpItem : IInterpolator<Item>
	{

		[Address(RVA = "0x2832810", Offset = "0x2831C10", Length = "0x207")]
		[Token(Token = "0x6000234")]
		public override Item Interpolate(Item a, Item b, float t) { }

	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001E2")]
	[Tooltip("LookAt targets for the camera at specific positions on the Spline")]
	public SplineData<Item> Targets; //Field offset: 0x28

	[Token(Token = "0x1700006A")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2827B30", Offset = "0x2826F30", Length = "0x138")]
		[Token(Token = "0x600022D")]
		 get { } //Length: 312
	}

	[Token(Token = "0x1700006B")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600022E")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2827A70", Offset = "0x2826E70", Length = "0xB9")]
	[Token(Token = "0x6000231")]
	public CinemachineSplineDollyLookAtTargets() { }

	[Address(RVA = "0x2827B30", Offset = "0x2826F30", Length = "0x138")]
	[Token(Token = "0x600022D")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600022E")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x28273B0", Offset = "0x28267B0", Length = "0x11E")]
	[Token(Token = "0x6000230")]
	internal bool GetGetSplineAndDolly(out SplineContainer spline, out CinemachineSplineDolly dolly) { }

	[Address(RVA = "0x28274D0", Offset = "0x28268D0", Length = "0x4E1")]
	[Token(Token = "0x600022F")]
	public virtual void MutateCameraState(ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x28279C0", Offset = "0x2826DC0", Length = "0xAF")]
	[Token(Token = "0x600022C")]
	private void Reset() { }

}

