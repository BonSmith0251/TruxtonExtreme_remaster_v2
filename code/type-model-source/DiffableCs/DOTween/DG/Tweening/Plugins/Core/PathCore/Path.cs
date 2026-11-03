namespace DG.Tweening.Plugins.Core.PathCore;

[Token(Token = "0x200009C")]
public class Path
{
	[Token(Token = "0x40001A4")]
	private static CatmullRomDecoder _catmullRomDecoder; //Field offset: 0x0
	[Token(Token = "0x40001A5")]
	private static LinearDecoder _linearDecoder; //Field offset: 0x8
	[Token(Token = "0x40001A6")]
	private static CubicBezierDecoder _cubicBezierDecoder; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001A7")]
	public Single[] wpLengths; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40001A8")]
	public Vector3[] wps; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40001A9")]
	internal PathType type; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40001AA")]
	internal int subdivisionsXSegment; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40001AB")]
	internal int subdivisions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001AC")]
	internal ControlPoint[] controlPoints; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40001AD")]
	internal float length; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40001AE")]
	internal bool isFinalized; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40001AF")]
	internal Single[] timesTable; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40001B0")]
	internal Single[] lengthsTable; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001B1")]
	internal int linearWPIndex; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40001B2")]
	internal bool addedExtraStartWp; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x40001B3")]
	internal bool addedExtraEndWp; //Field offset: 0x55
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001B4")]
	internal PathOptions plugOptions; //Field offset: 0x58
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40001B5")]
	private Path _incrementalClone; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40001B6")]
	private int _incrementalIndex; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40001B7")]
	private ABSPathDecoder _decoder; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40001B8")]
	private bool _changed; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40001B9")]
	internal Vector3[] nonLinearDrawWps; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40001BA")]
	internal Vector3 targetPosition; //Field offset: 0xF0
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x40001BB")]
	internal Nullable<Vector3> lookAtPosition; //Field offset: 0xFC
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x40001BC")]
	internal Color gizmoColor; //Field offset: 0x10C

	[Token(Token = "0x1700000E")]
	internal int minInputWaypoints
	{
		[Address(RVA = "0x66EEC0", Offset = "0x66E2C0", Length = "0x2D")]
		[Token(Token = "0x6000391")]
		internal get { } //Length: 45
	}

	[Address(RVA = "0x66EAF0", Offset = "0x66DEF0", Length = "0x3A5")]
	[Token(Token = "0x6000392")]
	public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, Nullable<Color> gizmoColor = null) { }

	[Address(RVA = "0x66EEA0", Offset = "0x66E2A0", Length = "0x1D")]
	[Token(Token = "0x6000393")]
	internal Path() { }

	[Address(RVA = "0x66D020", Offset = "0x66C420", Length = "0x1A3")]
	[Token(Token = "0x600039D")]
	internal void AssignDecoder(PathType pathType) { }

	[Address(RVA = "0x66D1D0", Offset = "0x66C5D0", Length = "0xE4")]
	[Token(Token = "0x600039C")]
	internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false) { }

	[Address(RVA = "0x66D2C0", Offset = "0x66C6C0", Length = "0x735")]
	[Token(Token = "0x600039B")]
	internal Path CloneIncremental(int loopIncrement) { }

	[Address(RVA = "0x66DA00", Offset = "0x66CE00", Length = "0x148")]
	[Token(Token = "0x6000396")]
	internal float ConvertToConstantPathPerc(float perc) { }

	[Address(RVA = "0x66DB50", Offset = "0x66CF50", Length = "0xDA")]
	[Token(Token = "0x60003A0")]
	private static Vector3 ConvertToDrawPoint(Vector3 wp, PathOptions plugOptions) { }

	[Address(RVA = "0x66DC30", Offset = "0x66D030", Length = "0x15E")]
	[Token(Token = "0x600039A")]
	internal void Destroy() { }

	[Address(RVA = "0x66E5D0", Offset = "0x66D9D0", Length = "0x7")]
	[Token(Token = "0x600039E")]
	internal void Draw() { }

	[Address(RVA = "0x66DD90", Offset = "0x66D190", Length = "0x836")]
	[Token(Token = "0x600039F")]
	private static void Draw(Path p) { }

	[Address(RVA = "0x66E5E0", Offset = "0x66D9E0", Length = "0x134")]
	[Token(Token = "0x6000394")]
	internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal) { }

	[Address(RVA = "0x66EEC0", Offset = "0x66E2C0", Length = "0x2D")]
	[Token(Token = "0x6000391")]
	internal int get_minInputWaypoints() { }

	[Address(RVA = "0x66E720", Offset = "0x66DB20", Length = "0x12E")]
	[Token(Token = "0x6000398")]
	internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment) { }

	[Address(RVA = "0x66E850", Offset = "0x66DC50", Length = "0x86")]
	[Token(Token = "0x6000395")]
	internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false) { }

	[Address(RVA = "0x66E8E0", Offset = "0x66DCE0", Length = "0xB7")]
	[Token(Token = "0x6000397")]
	internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward) { }

	[Address(RVA = "0x66E9A0", Offset = "0x66DDA0", Length = "0x14B")]
	[Token(Token = "0x6000399")]
	internal static void RefreshNonLinearDrawWps(Path p) { }

}

