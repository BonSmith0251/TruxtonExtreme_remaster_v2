namespace UnityEngine.Splines;

[Token(Token = "0x2000009")]
public static class CurveUtility
{
	[Token(Token = "0x200000A")]
	private struct FrenetFrame
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001A")]
		public float3 origin; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400001B")]
		public float3 tangent; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400001C")]
		public float3 normal; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400001D")]
		public float3 binormal; //Field offset: 0x24

	}

	[Token(Token = "0x4000017")]
	private const int k_NormalsPerCurve = 16; //Field offset: 0x0
	[Token(Token = "0x4000018")]
	private const float k_Epsilon = 0.0001; //Field offset: 0x0
	[Token(Token = "0x4000019")]
	private static readonly DistanceToInterpolation[] k_DistanceLUT; //Field offset: 0x0

	[Address(RVA = "0x2E58F20", Offset = "0x2E58320", Length = "0x68")]
	[Token(Token = "0x6000037")]
	private static CurveUtility() { }

	[Address(RVA = "0x2E56010", Offset = "0x2E55410", Length = "0x174")]
	[Token(Token = "0x600002F")]
	public static float ApproximateLength(BezierCurve curve) { }

	[Address(RVA = "0x2E56190", Offset = "0x2E55590", Length = "0x70")]
	[Token(Token = "0x600002E")]
	private static bool Approximately(float a, float b) { }

	[Address(RVA = "0x2E563F0", Offset = "0x2E557F0", Length = "0xE4")]
	[Token(Token = "0x600002C")]
	public static void CalculateCurveLengths(BezierCurve curve, DistanceToInterpolation[] lookupTable) { }

	[Address(RVA = "0x2E56200", Offset = "0x2E55600", Length = "0x1F0")]
	[Token(Token = "0x600002D")]
	public static void CalculateCurveLengths(BezierCurve curve, NativeArray<DistanceToInterpolation> lookupTable) { }

	[Address(RVA = "0x2E564E0", Offset = "0x2E558E0", Length = "0x1B6")]
	[Token(Token = "0x600002B")]
	public static float CalculateLength(BezierCurve curve, int resolution = 30) { }

	[Address(RVA = "0x2E566A0", Offset = "0x2E55AA0", Length = "0x1D3")]
	[Token(Token = "0x6000029")]
	private static float3 DeCasteljau(BezierCurve curve, float t) { }

	[Address(RVA = "0x2E56880", Offset = "0x2E55C80", Length = "0x193")]
	[Token(Token = "0x6000027")]
	public static float3 EvaluateAcceleration(BezierCurve curve, float t) { }

	[Address(RVA = "0x2E56A20", Offset = "0x2E55E20", Length = "0x1FD")]
	[Token(Token = "0x6000028")]
	public static float EvaluateCurvature(BezierCurve curve, float t) { }

	[Address(RVA = "0x2E56C20", Offset = "0x2E56020", Length = "0x1DD")]
	[Token(Token = "0x6000025")]
	public static float3 EvaluatePosition(BezierCurve curve, float t) { }

	[Address(RVA = "0x2E56E00", Offset = "0x2E56200", Length = "0x1E8")]
	[Token(Token = "0x6000026")]
	public static float3 EvaluateTangent(BezierCurve curve, float t) { }

	[Address(RVA = "0x2E56FF0", Offset = "0x2E563F0", Length = "0x1039")]
	[Token(Token = "0x6000031")]
	internal static float3 EvaluateUpVector(BezierCurve curve, float t, float3 startUp, float3 endUp, bool fixEndUpMismatch = true) { }

	[Address(RVA = "0x2E58030", Offset = "0x2E57430", Length = "0x1B4")]
	[Token(Token = "0x6000030")]
	internal static void EvaluateUpVectors(BezierCurve curve, float3 startUp, float3 endUp, NativeArray<float3> upVectors) { }

	[Address(RVA = "0x2E581F0", Offset = "0x2E575F0", Length = "0xB3")]
	[Token(Token = "0x6000033")]
	public static float GetDistanceToInterpolation(BezierCurve curve, float distance) { }

	[Address(RVA = "0x7B9FC0", Offset = "0x7B93C0", Length = "0x151")]
	[Token(Token = "0x6000034")]
	public static float GetDistanceToInterpolation(T lut, float distance) { }

	[Address(RVA = "0x2E582B0", Offset = "0x2E576B0", Length = "0x393")]
	[Token(Token = "0x6000036")]
	public static float GetNearestPoint(BezierCurve curve, Ray ray, out float3 position, out float interpolation, int resolution = 16) { }

	[Address(RVA = "0x2E58650", Offset = "0x2E57A50", Length = "0xD2")]
	[Token(Token = "0x6000035")]
	public static float3 GetNearestPoint(BezierCurve curve, Ray ray, int resolution = 16) { }

	[Address(RVA = "0x2E58730", Offset = "0x2E57B30", Length = "0x45F")]
	[Token(Token = "0x6000032")]
	private static FrenetFrame GetNextRotationMinimizingFrame(BezierCurve curve, FrenetFrame previousRMFrame, float nextRMFrameT) { }

	[Address(RVA = "0x2E58B90", Offset = "0x2E57F90", Length = "0x38D")]
	[Token(Token = "0x600002A")]
	public static void Split(BezierCurve curve, float t, out BezierCurve left, out BezierCurve right) { }

}

