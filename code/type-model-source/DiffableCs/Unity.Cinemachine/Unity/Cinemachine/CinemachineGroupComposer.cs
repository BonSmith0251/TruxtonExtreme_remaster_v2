namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[CameraPipeline(Stage::Aim (1))]
[Obsolete("CinemachineGroupTransposer has been deprecated. Use CinemachineRotationComposer and CinemachineGroupFraming instead")]
[SaveDuringPlay]
[Token(Token = "0x2000118")]
public class CinemachineGroupComposer : CinemachineComposer
{
	[Token(Token = "0x200011A")]
	internal enum AdjustmentMode : int
	{
		ZoomOnly = 0,
		DollyOnly = 1,
		DollyThenZoom = 2,
	}

	[Token(Token = "0x2000119")]
	internal enum FramingMode : int
	{
		Horizontal = 0,
		Vertical = 1,
		HorizontalAndVertical = 2,
	}

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000485")]
	[Tooltip("The bounding box of the targets should occupy this amount of the screen space.  1 means fill the whole screen.  0.5 means fill half the screen, etc.")]
	public float m_GroupFramingSize; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4000486")]
	[Tooltip("What screen dimensions to consider when framing.  Can be Horizontal, Vertical, or both")]
	public FramingMode m_FramingMode; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Range(0, 20)]
	[Token(Token = "0x4000487")]
	[Tooltip("How aggressively the camera tries to frame the group. Small numbers are more responsive, rapidly adjusting the camera to keep the group in the frame.  Larger numbers give a heavier more slowly responding camera.")]
	public float m_FrameDamping; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4000488")]
	[Tooltip("How to adjust the camera to get the desired framing.  You can zoom, dolly in/out, or do both.")]
	public AdjustmentMode m_AdjustmentMode; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000489")]
	[Tooltip("The maximum distance toward the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyIn; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x400048A")]
	[Tooltip("The maximum distance away the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyOut; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400048B")]
	[Tooltip("Set this to limit how close to the target the camera can get.")]
	public float m_MinimumDistance; //Field offset: 0x140
	[FieldOffset(Offset = "0x144")]
	[Token(Token = "0x400048C")]
	[Tooltip("Set this to limit how far from the target the camera can get.")]
	public float m_MaximumDistance; //Field offset: 0x144
	[FieldOffset(Offset = "0x148")]
	[Range(1, 179)]
	[Token(Token = "0x400048D")]
	[Tooltip("If adjusting FOV, will not set the FOV lower than this.")]
	public float m_MinimumFOV; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[Range(1, 179)]
	[Token(Token = "0x400048E")]
	[Tooltip("If adjusting FOV, will not set the FOV higher than this.")]
	public float m_MaximumFOV; //Field offset: 0x14C
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400048F")]
	[Tooltip("If adjusting Orthographic Size, will not set it lower than this.")]
	public float m_MinimumOrthoSize; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4000490")]
	[Tooltip("If adjusting Orthographic Size, will not set it higher than this.")]
	public float m_MaximumOrthoSize; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000491")]
	private float m_prevFramingDistance; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x4000492")]
	private float m_prevFOV; //Field offset: 0x15C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000493")]
	private Bounds <LastBounds>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000494")]
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; //Field offset: 0x178

	[Token(Token = "0x1700011C")]
	public private Bounds LastBounds
	{
		[Address(RVA = "0x286CDB0", Offset = "0x286C1B0", Length = "0x1B")]
		[CompilerGenerated]
		[Token(Token = "0x600056C")]
		 get { } //Length: 27
		[Address(RVA = "0x286CE00", Offset = "0x286C200", Length = "0x18")]
		[CompilerGenerated]
		[Token(Token = "0x600056D")]
		private set { } //Length: 24
	}

	[Token(Token = "0x1700011D")]
	public private Matrix4x4 LastBoundsMatrix
	{
		[Address(RVA = "0x286CD80", Offset = "0x286C180", Length = "0x2F")]
		[CompilerGenerated]
		[Token(Token = "0x600056E")]
		 get { } //Length: 47
		[Address(RVA = "0x286CDD0", Offset = "0x286C1D0", Length = "0x2C")]
		[CompilerGenerated]
		[Token(Token = "0x600056F")]
		private set { } //Length: 44
	}

	[Address(RVA = "0x286CD00", Offset = "0x286C100", Length = "0x75")]
	[Token(Token = "0x6000575")]
	public CinemachineGroupComposer() { }

	[Address(RVA = "0x286CDB0", Offset = "0x286C1B0", Length = "0x1B")]
	[CompilerGenerated]
	[Token(Token = "0x600056C")]
	public Bounds get_LastBounds() { }

	[Address(RVA = "0x286CD80", Offset = "0x286C180", Length = "0x2F")]
	[CompilerGenerated]
	[Token(Token = "0x600056E")]
	public Matrix4x4 get_LastBoundsMatrix() { }

	[Address(RVA = "0x286B5E0", Offset = "0x286A9E0", Length = "0x1E")]
	[Token(Token = "0x6000570")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x286B600", Offset = "0x286AA00", Length = "0x3E6")]
	[Token(Token = "0x6000573")]
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd) { }

	[Address(RVA = "0x286B9F0", Offset = "0x286ADF0", Length = "0x1D9")]
	[Token(Token = "0x6000572")]
	private float GetTargetHeight(Vector2 boundsSize) { }

	[Address(RVA = "0x286BBD0", Offset = "0x286AFD0", Length = "0xF59")]
	[Token(Token = "0x6000571")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x286CB30", Offset = "0x286BF30", Length = "0xCE")]
	[Token(Token = "0x600056A")]
	private void OnValidate() { }

	[Address(RVA = "0x286CC00", Offset = "0x286C000", Length = "0x70")]
	[Token(Token = "0x600056B")]
	private void Reset() { }

	[Address(RVA = "0x286CE00", Offset = "0x286C200", Length = "0x18")]
	[CompilerGenerated]
	[Token(Token = "0x600056D")]
	private void set_LastBounds(Bounds value) { }

	[Address(RVA = "0x286CDD0", Offset = "0x286C1D0", Length = "0x2C")]
	[CompilerGenerated]
	[Token(Token = "0x600056F")]
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	[Address(RVA = "0x286CC70", Offset = "0x286C070", Length = "0x8B")]
	[Token(Token = "0x6000574")]
	internal void UpgradeToCm3(CinemachineGroupFraming c) { }

}

