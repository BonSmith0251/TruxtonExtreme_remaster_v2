namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[Obsolete("CinemachinePathBase has been deprecated. Use SplineContainer instead")]
[SaveDuringPlay]
[Token(Token = "0x2000132")]
public class CinemachineSmoothPath : CinemachinePathBase
{
	[Token(Token = "0x2000133")]
	internal struct Waypoint
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004FC")]
		[Tooltip("Position in path-local space")]
		public Vector3 position; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40004FD")]
		[Tooltip("Defines the roll of the path at this waypoint.  The other orientation axes are inferred from the tangent and world up.")]
		public float roll; //Field offset: 0xC

		[Token(Token = "0x17000131")]
		internal Vector4 AsVector4
		{
			[Address(RVA = "0x2880350", Offset = "0x287F750", Length = "0x5CC")]
			[Token(Token = "0x60005F5")]
			internal get { } //Length: 1484
		}

		[Address(RVA = "0x2880320", Offset = "0x287F720", Length = "0x26")]
		[Token(Token = "0x60005F6")]
		internal static Waypoint FromVector4(Vector4 v) { }

		[Address(RVA = "0x2880350", Offset = "0x287F750", Length = "0x5CC")]
		[Token(Token = "0x60005F5")]
		internal Vector4 get_AsVector4() { }

	}

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004F7")]
	[Tooltip("If checked, then the path ends are joined to form a continuous loop.")]
	public bool m_Looped; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004F8")]
	[Tooltip("The waypoints that define the path.  They will be interpolated using a bezier curve.")]
	public Waypoint[] m_Waypoints; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004F9")]
	internal Waypoint[] m_ControlPoints1; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004FA")]
	internal Waypoint[] m_ControlPoints2; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40004FB")]
	private bool m_IsLoopedCache; //Field offset: 0x70

	[Token(Token = "0x17000130")]
	public virtual int DistanceCacheSampleStepsPerSegment
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60005EA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700012F")]
	public virtual bool Looped
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[Token(Token = "0x60005E9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700012E")]
	public virtual float MaxPos
	{
		[Address(RVA = "0x2876D40", Offset = "0x2876140", Length = "0x38")]
		[Token(Token = "0x60005E8")]
		 get { } //Length: 56
	}

	[Token(Token = "0x1700012D")]
	public virtual float MinPos
	{
		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x60005E7")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2877BC0", Offset = "0x2876FC0", Length = "0x52")]
	[Token(Token = "0x60005F4")]
	public CinemachineSmoothPath() { }

	[Address(RVA = "0x2876E10", Offset = "0x2876210", Length = "0x3D1")]
	[Token(Token = "0x60005F2")]
	public virtual Quaternion EvaluateLocalOrientation(float pos) { }

	[Address(RVA = "0x28771F0", Offset = "0x28765F0", Length = "0x21C")]
	[Token(Token = "0x60005F0")]
	public virtual Vector3 EvaluateLocalPosition(float pos) { }

	[Address(RVA = "0x2877410", Offset = "0x2876810", Length = "0x234")]
	[Token(Token = "0x60005F1")]
	public virtual Vector3 EvaluateLocalTangent(float pos) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60005EA")]
	public virtual int get_DistanceCacheSampleStepsPerSegment() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[Token(Token = "0x60005E9")]
	public virtual bool get_Looped() { }

	[Address(RVA = "0x2876D40", Offset = "0x2876140", Length = "0x38")]
	[Token(Token = "0x60005E8")]
	public virtual float get_MaxPos() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x60005E7")]
	public virtual float get_MinPos() { }

	[Address(RVA = "0x2877650", Offset = "0x2876A50", Length = "0x11A")]
	[Token(Token = "0x60005EF")]
	private float GetBoundingIndices(float pos, out int indexA, out int indexB) { }

	[Address(RVA = "0x2877770", Offset = "0x2876B70", Length = "0x59")]
	[Token(Token = "0x60005ED")]
	public virtual void InvalidateDistanceCache() { }

	[Address(RVA = "0x2265EC0", Offset = "0x22652C0", Length = "0x14")]
	[Token(Token = "0x60005EB")]
	private void OnValidate() { }

	[Address(RVA = "0x28777D0", Offset = "0x2876BD0", Length = "0x120")]
	[Token(Token = "0x60005EC")]
	private void Reset() { }

	[Address(RVA = "0x284B3A0", Offset = "0x284A7A0", Length = "0x4E")]
	[Token(Token = "0x60005F3")]
	private static Quaternion RollAroundForward(float angle) { }

	[Address(RVA = "0x2877900", Offset = "0x2876D00", Length = "0x2B4")]
	[Token(Token = "0x60005EE")]
	internal void UpdateControlPoints() { }

}

