namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[Obsolete("CinemachinePath has been deprecated. Use SplineContainer instead")]
[SaveDuringPlay]
[Token(Token = "0x2000129")]
public class CinemachinePath : CinemachinePathBase
{
	[Token(Token = "0x200012A")]
	internal struct Waypoint
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004D8")]
		[Tooltip("Position in path-local space")]
		public Vector3 position; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40004D9")]
		[Tooltip("Offset from the position, which defines the tangent of the curve at the waypoint.  The length of the tangent encodes the strength of the bezier handle.  The same handle is used symmetrically on both sides of the waypoint, to ensure smoothness.")]
		public Vector3 tangent; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40004DA")]
		[Tooltip("Defines the roll of the path at this waypoint.  The other orientation axes are inferred from the tangent and world up.")]
		public float roll; //Field offset: 0x18

	}

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40004D6")]
	[Tooltip("If checked, then the path ends are joined to form a continuous loop.")]
	public bool m_Looped; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40004D7")]
	[Tooltip("The waypoints that define the path.  They will be interpolated using a bezier curve.")]
	public Waypoint[] m_Waypoints; //Field offset: 0x58

	[Token(Token = "0x17000122")]
	public virtual int DistanceCacheSampleStepsPerSegment
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60005AC")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000121")]
	public virtual bool Looped
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[Token(Token = "0x60005A9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000120")]
	public virtual float MaxPos
	{
		[Address(RVA = "0x2876D40", Offset = "0x2876140", Length = "0x38")]
		[Token(Token = "0x60005A8")]
		 get { } //Length: 56
	}

	[Token(Token = "0x1700011F")]
	public virtual float MinPos
	{
		[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
		[Token(Token = "0x60005A7")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2876CE0", Offset = "0x28760E0", Length = "0x52")]
	[Token(Token = "0x60005B3")]
	public CinemachinePath() { }

	[Address(RVA = "0x28760A0", Offset = "0x28754A0", Length = "0x3B8")]
	[Token(Token = "0x60005B0")]
	public virtual Quaternion EvaluateLocalOrientation(float pos) { }

	[Address(RVA = "0x2876460", Offset = "0x2875860", Length = "0x24C")]
	[Token(Token = "0x60005AE")]
	public virtual Vector3 EvaluateLocalPosition(float pos) { }

	[Address(RVA = "0x28766B0", Offset = "0x2875AB0", Length = "0x24D")]
	[Token(Token = "0x60005AF")]
	public virtual Vector3 EvaluateLocalTangent(float pos) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60005AC")]
	public virtual int get_DistanceCacheSampleStepsPerSegment() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[Token(Token = "0x60005A9")]
	public virtual bool get_Looped() { }

	[Address(RVA = "0x2876D40", Offset = "0x2876140", Length = "0x38")]
	[Token(Token = "0x60005A8")]
	public virtual float get_MaxPos() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x60005A7")]
	public virtual float get_MinPos() { }

	[Address(RVA = "0x2876900", Offset = "0x2875D00", Length = "0x167")]
	[Token(Token = "0x60005AD")]
	private float GetBoundingIndices(float pos, out int indexA, out int indexB) { }

	[Address(RVA = "0x2876A70", Offset = "0x2875E70", Length = "0x120")]
	[Token(Token = "0x60005B1")]
	internal float GetRoll(int indexA, int indexB, float standardizedPos) { }

	[Address(RVA = "0x2265EC0", Offset = "0x22652C0", Length = "0x14")]
	[Token(Token = "0x60005AB")]
	private void OnValidate() { }

	[Address(RVA = "0x2876BA0", Offset = "0x2875FA0", Length = "0x132")]
	[Token(Token = "0x60005AA")]
	private void Reset() { }

	[Address(RVA = "0x284B3A0", Offset = "0x284A7A0", Length = "0x4E")]
	[Token(Token = "0x60005B2")]
	private static Quaternion RollAroundForward(float angle) { }

}

