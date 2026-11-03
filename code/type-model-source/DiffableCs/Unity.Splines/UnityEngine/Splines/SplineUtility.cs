namespace UnityEngine.Splines;

[Extension]
[Token(Token = "0x200005D")]
public static class SplineUtility
{
	[Token(Token = "0x200005E")]
	private struct Segment
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000170")]
		public float start; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000171")]
		public float length; //Field offset: 0x4

		[Address(RVA = "0x12F1450", Offset = "0x12F0850", Length = "0xA")]
		[Token(Token = "0x6000368")]
		public Segment(float start, float length) { }

	}

	[Token(Token = "0x4000168")]
	private const int k_SubdivisionCountMin = 6; //Field offset: 0x0
	[Token(Token = "0x4000169")]
	private const int k_SubdivisionCountMax = 1024; //Field offset: 0x0
	[Token(Token = "0x400016A")]
	public const float DefaultTension = 0.33333334; //Field offset: 0x0
	[Token(Token = "0x400016B")]
	public const float CatmullRomTension = 0.5; //Field offset: 0x0
	[Token(Token = "0x400016C")]
	public const int PickResolutionMin = 2; //Field offset: 0x0
	[Token(Token = "0x400016D")]
	public const int PickResolutionDefault = 4; //Field offset: 0x0
	[Token(Token = "0x400016E")]
	public const int PickResolutionMax = 64; //Field offset: 0x0
	[Token(Token = "0x400016F")]
	public const int DrawResolutionDefault = 10; //Field offset: 0x0

	[Address(RVA = "0x905110", Offset = "0x904510", Length = "0x16E")]
	[Extension]
	[Token(Token = "0x6000353")]
	public static Spline AddSpline(T container) { }

	[Address(RVA = "0x905280", Offset = "0x904680", Length = "0x12B")]
	[Extension]
	[Token(Token = "0x6000354")]
	public static void AddSpline(T container, Spline spline) { }

	[Address(RVA = "0x2E77050", Offset = "0x2E76450", Length = "0x1EB")]
	[Extension]
	[Token(Token = "0x600035C")]
	public static bool AreKnotLinked(ISplineContainer container, SplineKnotIndex knotA, SplineKnotIndex knotB) { }

	[Address(RVA = "0x2E77240", Offset = "0x2E76640", Length = "0x12")]
	[Token(Token = "0x6000360")]
	internal static bool AreTangentsModifiable(TangentMode mode) { }

	[Address(RVA = "0x2E77260", Offset = "0x2E76660", Length = "0x190")]
	[Token(Token = "0x6000350")]
	private static float3 Bernstein(float t, float3[] bezier, int degree) { }

	[Address(RVA = "0x2E77400", Offset = "0x2E76800", Length = "0xF5")]
	[Token(Token = "0x600034F")]
	private static float3 CalculateCenterTangent(float3 prevPoint, float3 centerPoint, float3 nextPoint) { }

	[Address(RVA = "0x905520", Offset = "0x904920", Length = "0xC3")]
	[Extension]
	[Token(Token = "0x600032B")]
	public static float CalculateLength(T spline, float4x4 transform) { }

	[Address(RVA = "0x2E77500", Offset = "0x2E76900", Length = "0x3E8")]
	[Token(Token = "0x600034E")]
	private static float3 CalculatePreferredNormalForDirection(float3 splineDirection) { }

	[Address(RVA = "0x9055F0", Offset = "0x9049F0", Length = "0x2AB")]
	[Extension]
	[Token(Token = "0x6000321")]
	public static float3 CalculateUpVector(T spline, float t) { }

	[Address(RVA = "0x906450", Offset = "0x905850", Length = "0x4AF")]
	[Extension]
	[Token(Token = "0x6000322")]
	internal static float3 CalculateUpVector(T spline, int curveIndex, float curveT) { }

	[Address(RVA = "0x2E778F0", Offset = "0x2E76CF0", Length = "0x269")]
	[Token(Token = "0x6000352")]
	private static ValueTuple<Single, Int32> ComputeMaxError(IReadOnlyList<float3> allPoints, int rangeStart, int rangeEnd, float3[] positions, float errorThreshold, bool splineClosed) { }

	[Address(RVA = "0x906D50", Offset = "0x906150", Length = "0x1DF")]
	[Extension]
	[Token(Token = "0x6000337")]
	public static float ConvertIndexUnit(T spline, float value, PathIndexUnit fromPathUnit, PathIndexUnit targetPathUnit) { }

	[Address(RVA = "0x906BA0", Offset = "0x905FA0", Length = "0x1AC")]
	[Extension]
	[Token(Token = "0x6000336")]
	public static float ConvertIndexUnit(T spline, float t, PathIndexUnit targetPathUnit) { }

	[Address(RVA = "0x907110", Offset = "0x906510", Length = "0xBE")]
	[Token(Token = "0x6000338")]
	private static float ConvertNormalizedIndexUnit(T spline, float t, PathIndexUnit targetPathUnit) { }

	[Address(RVA = "0x9071D0", Offset = "0x9065D0", Length = "0x5C8")]
	[Extension]
	[Token(Token = "0x600035D")]
	public static void CopyKnotLinks(T container, int srcSplineIndex, int destSplineIndex) { }

	[Address(RVA = "0x907D30", Offset = "0x907130", Length = "0x256")]
	[Extension]
	[Token(Token = "0x600032A")]
	public static float CurveToSplineT(T spline, float curve) { }

	[Address(RVA = "0x2E77B60", Offset = "0x2E76F60", Length = "0x132")]
	[Extension]
	[Token(Token = "0x6000365")]
	internal static SplineKnotIndex DuplicateKnot(ISplineContainer container, SplineKnotIndex originalKnot, int targetIndex) { }

	[Address(RVA = "0x2E77CA0", Offset = "0x2E770A0", Length = "0x43E")]
	[Extension]
	[Token(Token = "0x6000366")]
	public static void DuplicateSpline(ISplineContainer container, SplineKnotIndex fromKnot, SplineKnotIndex toKnot, out int newSplineIndex) { }

	[Address(RVA = "0x90B150", Offset = "0x90A550", Length = "0x287")]
	[Extension]
	[Token(Token = "0x600031B")]
	public static bool Evaluate(T spline, float t, out float3 position, out float3 tangent, out float3 upVector) { }

	[Address(RVA = "0x908290", Offset = "0x907690", Length = "0x184")]
	[Extension]
	[Token(Token = "0x6000325")]
	public static float3 EvaluateAcceleration(T spline, float t) { }

	[Address(RVA = "0x908B80", Offset = "0x907F80", Length = "0x2BD")]
	[Extension]
	[Token(Token = "0x6000326")]
	public static float EvaluateCurvature(T spline, float t) { }

	[Address(RVA = "0x9085D0", Offset = "0x9079D0", Length = "0x5A2")]
	[Extension]
	[Token(Token = "0x6000327")]
	public static float3 EvaluateCurvatureCenter(T spline, float t) { }

	[Address(RVA = "0x2E780E0", Offset = "0x2E774E0", Length = "0x360")]
	[Token(Token = "0x600031C")]
	public static bool EvaluateNurbs(float t, List<float3> controlPoints, List<Double> knotVector, int order, out float3 position) { }

	[Address(RVA = "0x909140", Offset = "0x908540", Length = "0x181")]
	[Extension]
	[Token(Token = "0x600031E")]
	public static float3 EvaluatePosition(T spline, float t) { }

	[Address(RVA = "0x909770", Offset = "0x908B70", Length = "0x181")]
	[Extension]
	[Token(Token = "0x600031F")]
	public static float3 EvaluateTangent(T spline, float t) { }

	[Address(RVA = "0x909D60", Offset = "0x909160", Length = "0x117")]
	[Extension]
	[Token(Token = "0x6000320")]
	public static float3 EvaluateUpVector(T spline, float t) { }

	[Address(RVA = "0x90A760", Offset = "0x909B60", Length = "0xBF")]
	[Extension]
	[Token(Token = "0x6000324")]
	internal static void EvaluateUpVectorsForCurve(T spline, int curveIndex, float3[] upVectors) { }

	[Address(RVA = "0x90A820", Offset = "0x909C20", Length = "0x49F")]
	[Extension]
	[Token(Token = "0x6000323")]
	internal static void EvaluateUpVectorsForCurve(T spline, int curveIndex, NativeArray<float3> upVectors) { }

	[Address(RVA = "0x2E79C30", Offset = "0x2E79030", Length = "0xC2F")]
	[Token(Token = "0x600034C")]
	public static bool FitSplineToPoints(List<float3> points, float errorThreshold, bool closed, out Spline spline) { }

	[Address(RVA = "0x2E78450", Offset = "0x2E77850", Length = "0x17DF")]
	[Token(Token = "0x600034D")]
	private static bool FitSplineToPointsStepInternal(IReadOnlyList<float3> allPoints, int rangeStart, int rangeEnd, float3 leftTangent, float3 rightTangent, float errorThreshold, bool closed, bool splineClosed, out Spline spline) { }

	[Address(RVA = "0x2E7A860", Offset = "0x2E79C60", Length = "0xDB1")]
	[Token(Token = "0x6000351")]
	private static Spline GenerateSplineFromTValues(IReadOnlyList<float3> allPoints, int rangeStart, int rangeEnd, bool closed, Single[] tValues, float3 leftTangent, float3 rightTangent) { }

	[Address(RVA = "0x2E7B620", Offset = "0x2E7AA20", Length = "0x2AE")]
	[Token(Token = "0x6000349")]
	public static BezierKnot GetAutoSmoothKnot(float3 position, float3 previous, float3 next, float3 normal, float tension = 0.33333334) { }

	[Address(RVA = "0x2E7B990", Offset = "0x2E7AD90", Length = "0xC0")]
	[Token(Token = "0x6000347")]
	public static BezierKnot GetAutoSmoothKnot(float3 position, float3 previous, float3 next) { }

	[Address(RVA = "0x2E7B8D0", Offset = "0x2E7ACD0", Length = "0xBC")]
	[Token(Token = "0x6000348")]
	public static BezierKnot GetAutoSmoothKnot(float3 position, float3 previous, float3 next, float3 normal) { }

	[Address(RVA = "0x2E7BB90", Offset = "0x2E7AF90", Length = "0x2C3")]
	[Token(Token = "0x6000345")]
	public static float3 GetAutoSmoothTangent(float3 previous, float3 current, float3 next, float tension = 0.33333334) { }

	[Address(RVA = "0x2E7BA50", Offset = "0x2E7AE50", Length = "0x135")]
	[Token(Token = "0x6000344")]
	public static float3 GetAutoSmoothTangent(float3 previous, float3 next, float tension = 0.33333334) { }

	[Address(RVA = "0x90B670", Offset = "0x90AA70", Length = "0x10A6")]
	[Extension]
	[Token(Token = "0x600032E")]
	public static Bounds GetBounds(T spline, float4x4 transform) { }

	[Address(RVA = "0x90C720", Offset = "0x90BB20", Length = "0x13D")]
	[Extension]
	[Token(Token = "0x600032D")]
	public static Bounds GetBounds(T spline) { }

	[Address(RVA = "0x2E7BE60", Offset = "0x2E7B260", Length = "0x132")]
	[Token(Token = "0x6000343")]
	public static float3 GetCatmullRomTangent(float3 previous, float3 next) { }

	[Address(RVA = "0x90C860", Offset = "0x90BC60", Length = "0x165")]
	[Extension]
	[Token(Token = "0x600032C")]
	public static int GetCurveCount(T spline) { }

	[Address(RVA = "0x2E7C1A0", Offset = "0x2E7B5A0", Length = "0x55")]
	[Token(Token = "0x6000341")]
	internal static float3 GetExplicitLinearTangent(float3 point, float3 to) { }

	[Address(RVA = "0x2E7BFA0", Offset = "0x2E7B3A0", Length = "0x1F3")]
	[Token(Token = "0x6000342")]
	internal static float3 GetExplicitLinearTangent(BezierKnot from, BezierKnot to) { }

	[Address(RVA = "0x2E7C200", Offset = "0x2E7B600", Length = "0x746")]
	[Token(Token = "0x600034A")]
	internal static quaternion GetKnotRotation(float3 tangent, float3 normal) { }

	[Address(RVA = "0x90D400", Offset = "0x90C800", Length = "0x415")]
	[Token(Token = "0x6000331")]
	private static Segment GetNearestPoint(T spline, float3 ro, float3 rd, Segment range, out float distance, out float3 nearest, out float time, int segments) { }

	[Address(RVA = "0x90D820", Offset = "0x90CC20", Length = "0x42C")]
	[Token(Token = "0x6000332")]
	private static Segment GetNearestPoint(T spline, float3 point, Segment range, out float distance, out float3 nearest, out float time, int segments) { }

	[Address(RVA = "0x90C9D0", Offset = "0x90BDD0", Length = "0x33F")]
	[Token(Token = "0x6000333")]
	public static float GetNearestPoint(T spline, Ray ray, out float3 nearest, out float t, int resolution = 4, int iterations = 2) { }

	[Address(RVA = "0x90DC50", Offset = "0x90D050", Length = "0x247")]
	[Token(Token = "0x6000334")]
	public static float GetNearestPoint(T spline, float3 point, out float3 nearest, out float t, int resolution = 4, int iterations = 2) { }

	[Address(RVA = "0x90E220", Offset = "0x90D620", Length = "0xC8")]
	[Token(Token = "0x600033A")]
	public static float GetNormalizedInterpolation(T spline, float t, PathIndexUnit originalPathUnit) { }

	[Address(RVA = "0x2E7C950", Offset = "0x2E7BD50", Length = "0x2D8")]
	[Token(Token = "0x600031D")]
	private static Single[] GetNurbsBasisFunctions(int degree, float t, List<Double> knotVector, int span) { }

	[Address(RVA = "0x90E840", Offset = "0x90DC40", Length = "0x3F2")]
	[Extension]
	[Token(Token = "0x6000335")]
	public static float3 GetPointAtLinearDistance(T spline, float fromT, float relativeDistance, out float resultPointT) { }

	[Address(RVA = "0x2E7CC30", Offset = "0x2E7C030", Length = "0x63")]
	[Obsolete("Use GetSubdivisionCount instead.", False)]
	[Token(Token = "0x600032F")]
	public static int GetSegmentCount(float length, int resolution) { }

	[Address(RVA = "0x2E7CC30", Offset = "0x2E7C030", Length = "0x63")]
	[Token(Token = "0x6000330")]
	public static int GetSubdivisionCount(float length, int resolution) { }

	[Address(RVA = "0x2E7CCA0", Offset = "0x2E7C0A0", Length = "0x50")]
	[Token(Token = "0x6000346")]
	private static float3 GetUniformAutoSmoothTangent(float3 previous, float3 next, float tension) { }

	[Address(RVA = "0x90EF00", Offset = "0x90E300", Length = "0x12C")]
	[Token(Token = "0x6000358")]
	internal static bool IsIndexValid(T container, SplineKnotIndex index) { }

	[Address(RVA = "0x2E7CCF0", Offset = "0x2E7C0F0", Length = "0xDDE")]
	[Extension]
	[Token(Token = "0x6000364")]
	public static SplineKnotIndex JoinSplinesOnKnots(ISplineContainer container, SplineKnotIndex mainKnot, SplineKnotIndex otherKnot) { }

	[Address(RVA = "0x90F6F0", Offset = "0x90EAF0", Length = "0x47B")]
	[Extension]
	[Token(Token = "0x600035A")]
	public static void LinkKnots(T container, SplineKnotIndex knotA, SplineKnotIndex knotB) { }

	[Address(RVA = "0x910020", Offset = "0x90F420", Length = "0xFB")]
	[Extension]
	[Token(Token = "0x600033E")]
	public static BezierKnot Next(T spline, int index) { }

	[Address(RVA = "0x90FDD0", Offset = "0x90F1D0", Length = "0x72")]
	[Extension]
	[Token(Token = "0x600033C")]
	public static int NextIndex(T spline, int index) { }

	[Address(RVA = "0x2E7DAD0", Offset = "0x2E7CED0", Length = "0x1B")]
	[Token(Token = "0x6000340")]
	internal static int NextIndex(int index, int count, bool wrap) { }

	[Address(RVA = "0x910320", Offset = "0x90F720", Length = "0xFB")]
	[Extension]
	[Token(Token = "0x600033D")]
	public static BezierKnot Previous(T spline, int index) { }

	[Address(RVA = "0x2E7DAF0", Offset = "0x2E7CEF0", Length = "0x1C")]
	[Token(Token = "0x600033F")]
	internal static int PreviousIndex(int index, int count, bool wrap) { }

	[Address(RVA = "0x910290", Offset = "0x90F690", Length = "0x89")]
	[Extension]
	[Token(Token = "0x600033B")]
	public static int PreviousIndex(T spline, int index) { }

	[Address(RVA = "0x910420", Offset = "0x90F820", Length = "0x114")]
	[Token(Token = "0x600035F")]
	public static void ReducePoints(T line, List<float3> results, float epsilon = 0.15) { }

	[Address(RVA = "0x910540", Offset = "0x90F940", Length = "0x15E")]
	[Token(Token = "0x600035E")]
	public static List<float3> ReducePoints(T line, float epsilon = 0.15) { }

	[Address(RVA = "0x910B50", Offset = "0x90FF50", Length = "0x2A3")]
	[Extension]
	[Token(Token = "0x6000356")]
	public static bool RemoveSpline(T container, Spline spline) { }

	[Address(RVA = "0x9109F0", Offset = "0x90FDF0", Length = "0x15F")]
	[Extension]
	[Token(Token = "0x6000355")]
	public static bool RemoveSplineAt(T container, int splineIndex) { }

	[Address(RVA = "0x910E00", Offset = "0x910200", Length = "0x44B")]
	[Extension]
	[Token(Token = "0x6000357")]
	public static bool ReorderSpline(T container, int previousSplineIndex, int newSplineIndex) { }

	[Address(RVA = "0x2E7DB10", Offset = "0x2E7CF10", Length = "0x4D")]
	[Extension]
	[Token(Token = "0x6000361")]
	public static void ReverseFlow(ISplineContainer container, int splineIndex) { }

	[Address(RVA = "0x2E7E3D0", Offset = "0x2E7D7D0", Length = "0xDD3")]
	[Token(Token = "0x6000362")]
	public static void ReverseFlow(SplineInfo splineInfo) { }

	[Address(RVA = "0x2E7DB60", Offset = "0x2E7CF60", Length = "0x868")]
	[Token(Token = "0x6000363")]
	public static void ReverseFlow(Spline spline) { }

	[Address(RVA = "0x911810", Offset = "0x910C10", Length = "0x537")]
	[Extension]
	[Token(Token = "0x6000359")]
	public static void SetLinkedKnotPosition(T container, SplineKnotIndex index) { }

	[Address(RVA = "0x2E7F1B0", Offset = "0x2E7E5B0", Length = "0x220")]
	[Token(Token = "0x600034B")]
	public static void SetPivot(SplineContainer container, Vector3 position) { }

	[Address(RVA = "0x9124B0", Offset = "0x9118B0", Length = "0x179")]
	[Extension]
	[Token(Token = "0x6000329")]
	private static int SplineToCurveT(T spline, float splineT, out float curveT, bool useLUT) { }

	[Address(RVA = "0x9122F0", Offset = "0x9116F0", Length = "0x1BC")]
	[Extension]
	[Token(Token = "0x6000328")]
	public static int SplineToCurveT(T spline, float splineT, out float curveT) { }

	[Address(RVA = "0x2E7F3E0", Offset = "0x2E7E7E0", Length = "0x47D")]
	[Extension]
	[Token(Token = "0x6000367")]
	public static SplineKnotIndex SplitSplineOnKnot(ISplineContainer container, SplineKnotIndex knotInfo) { }

	[Address(RVA = "0x912B00", Offset = "0x911F00", Length = "0x269")]
	[Extension]
	[Token(Token = "0x600035B")]
	public static void UnlinkKnots(T container, IReadOnlyList<SplineKnotIndex> knots) { }

	[Address(RVA = "0x2E7F860", Offset = "0x2E7EC60", Length = "0x101")]
	[Token(Token = "0x6000339")]
	private static float WrapInterpolation(float t, bool closed) { }

}

