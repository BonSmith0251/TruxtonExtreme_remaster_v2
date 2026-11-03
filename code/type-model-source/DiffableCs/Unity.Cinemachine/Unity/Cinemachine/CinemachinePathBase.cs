namespace Unity.Cinemachine;

[Obsolete("CinemachinePathBase has been deprecated. Use SplineContainer instead")]
[Token(Token = "0x200012B")]
public abstract class CinemachinePathBase : MonoBehaviour
{
	[Token(Token = "0x200012C")]
	internal class Appearance
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004E3")]
		[Tooltip("The color of the path itself when it is active in the editor")]
		public Color pathColor; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004E4")]
		[Tooltip("The color of the path itself when it is inactive in the editor")]
		public Color inactivePathColor; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Range(0, 10)]
		[Token(Token = "0x40004E5")]
		[Tooltip("The width of the railroad-tracks that are drawn to represent the path")]
		public float width; //Field offset: 0x30

		[Address(RVA = "0x2869B10", Offset = "0x2868F10", Length = "0x3E")]
		[Token(Token = "0x60005CF")]
		public Appearance() { }

	}

	[Token(Token = "0x200012D")]
	internal enum PositionUnits : int
	{
		PathUnits = 0,
		Distance = 1,
		Normalized = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[Range(1, 100)]
	[Token(Token = "0x40004DB")]
	[Tooltip("Path samples per waypoint.  This is used for calculating path distances.")]
	public int m_Resolution; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004DC")]
	[Tooltip("The settings that control how the path will appear in the editor scene view.")]
	public Appearance m_Appearance; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004DD")]
	private Single[] m_DistanceToPos; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004DE")]
	private Single[] m_PosToDistance; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004DF")]
	private int m_CachedSampleSteps; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40004E0")]
	private float m_PathLength; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004E1")]
	private float m_cachedPosStepSize; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40004E2")]
	private float m_cachedDistanceStepSize; //Field offset: 0x4C

	[Token(Token = "0x17000126")]
	public abstract int DistanceCacheSampleStepsPerSegment
	{
		[Token(Token = "0x60005C5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000125")]
	public abstract bool Looped
	{
		[Token(Token = "0x60005B6")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000124")]
	public abstract float MaxPos
	{
		[Token(Token = "0x60005B5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000123")]
	public abstract float MinPos
	{
		[Token(Token = "0x60005B4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000127")]
	public float PathLength
	{
		[Address(RVA = "0x2875FC0", Offset = "0x28753C0", Length = "0xD7")]
		[Token(Token = "0x60005C8")]
		 get { } //Length: 215
	}

	[Address(RVA = "0x2875F20", Offset = "0x2875320", Length = "0x93")]
	[Token(Token = "0x60005CE")]
	protected CinemachinePathBase() { }

	[Address(RVA = "0x2874BA0", Offset = "0x2873FA0", Length = "0x98")]
	[Token(Token = "0x60005C7")]
	public bool DistanceCacheIsValid() { }

	[Token(Token = "0x60005BD")]
	public abstract Quaternion EvaluateLocalOrientation(float pos) { }

	[Token(Token = "0x60005BB")]
	public abstract Vector3 EvaluateLocalPosition(float pos) { }

	[Token(Token = "0x60005BC")]
	public abstract Vector3 EvaluateLocalTangent(float pos) { }

	[Address(RVA = "0x2874CA0", Offset = "0x28740A0", Length = "0x1DA")]
	[Token(Token = "0x60005BA")]
	public override Quaternion EvaluateOrientation(float pos) { }

	[Address(RVA = "0x2874C40", Offset = "0x2874040", Length = "0x53")]
	[Token(Token = "0x60005C4")]
	public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units) { }

	[Address(RVA = "0x2874EE0", Offset = "0x28742E0", Length = "0x9F")]
	[Token(Token = "0x60005B8")]
	public override Vector3 EvaluatePosition(float pos) { }

	[Address(RVA = "0x2874E80", Offset = "0x2874280", Length = "0x5B")]
	[Token(Token = "0x60005C2")]
	public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units) { }

	[Address(RVA = "0x2874FE0", Offset = "0x28743E0", Length = "0x9F")]
	[Token(Token = "0x60005B9")]
	public override Vector3 EvaluateTangent(float pos) { }

	[Address(RVA = "0x2874F80", Offset = "0x2874380", Length = "0x5B")]
	[Token(Token = "0x60005C3")]
	public Vector3 EvaluateTangentAtUnit(float pos, PositionUnits units) { }

	[Address(RVA = "0x2875080", Offset = "0x2874480", Length = "0x41E")]
	[Token(Token = "0x60005BE")]
	public override float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment) { }

	[Address(RVA = "0x28754A0", Offset = "0x28748A0", Length = "0x155")]
	[Token(Token = "0x60005CB")]
	public float FromPathNativeUnits(float pos, PositionUnits units) { }

	[Token(Token = "0x60005C5")]
	public abstract int get_DistanceCacheSampleStepsPerSegment() { }

	[Token(Token = "0x60005B6")]
	public abstract bool get_Looped() { }

	[Token(Token = "0x60005B5")]
	public abstract float get_MaxPos() { }

	[Token(Token = "0x60005B4")]
	public abstract float get_MinPos() { }

	[Address(RVA = "0x2875FC0", Offset = "0x28753C0", Length = "0xD7")]
	[Token(Token = "0x60005C8")]
	public float get_PathLength() { }

	[Address(RVA = "0x2875600", Offset = "0x2874A00", Length = "0x3C")]
	[Token(Token = "0x60005C6")]
	public override void InvalidateDistanceCache() { }

	[Address(RVA = "0x2875640", Offset = "0x2874A40", Length = "0x2E")]
	[Token(Token = "0x60005C0")]
	public float MaxUnit(PositionUnits units) { }

	[Address(RVA = "0x2875670", Offset = "0x2874A70", Length = "0x22")]
	[Token(Token = "0x60005BF")]
	public float MinUnit(PositionUnits units) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60005CC")]
	protected override void OnEnable() { }

	[Address(RVA = "0x28756A0", Offset = "0x2874AA0", Length = "0x468")]
	[Token(Token = "0x60005CD")]
	private void ResamplePath(int stepsPerSegment) { }

	[Address(RVA = "0x2875B10", Offset = "0x2874F10", Length = "0xBC")]
	[Token(Token = "0x60005C9")]
	public float StandardizePathDistance(float distance) { }

	[Address(RVA = "0x2875BD0", Offset = "0x2874FD0", Length = "0xE7")]
	[Token(Token = "0x60005B7")]
	public override float StandardizePos(float pos) { }

	[Address(RVA = "0x2875CC0", Offset = "0x28750C0", Length = "0xA1")]
	[Token(Token = "0x60005C1")]
	public override float StandardizeUnit(float pos, PositionUnits units) { }

	[Address(RVA = "0x2875D70", Offset = "0x2875170", Length = "0x1A0")]
	[Token(Token = "0x60005CA")]
	public float ToNativePathUnits(float pos, PositionUnits units) { }

}

