namespace Unity.Cinemachine;

[Extension]
[Token(Token = "0x20000E8")]
internal static class SplineContainerExtensions
{

	[Address(RVA = "0x284B3A0", Offset = "0x284A7A0", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x6000443")]
	internal static Quaternion <LocalEvaluateSplineWithRoll>g__RollAroundForward|1_0(float angle) { }

	[Address(RVA = "0x284A390", Offset = "0x2849790", Length = "0x2EF")]
	[Extension]
	[Token(Token = "0x6000440")]
	public static Vector3 EvaluateSplinePosition(ISpline spline, Transform transform, float tNormalized) { }

	[Address(RVA = "0x284A680", Offset = "0x2849A80", Length = "0x38C")]
	[Extension]
	[Token(Token = "0x600043F")]
	public static bool EvaluateSplineWithRoll(ISpline spline, Transform transform, float tNormalized, CinemachineSplineRoll roll, out Vector3 position, out Quaternion rotation) { }

	[Address(RVA = "0x284AA10", Offset = "0x2849E10", Length = "0x124")]
	[Extension]
	[Token(Token = "0x6000441")]
	public static float GetMaxPosition(ISpline spline, PathIndexUnit unit) { }

	[Address(RVA = "0x284AB40", Offset = "0x2849F40", Length = "0x8B")]
	[Extension]
	[Token(Token = "0x600043D")]
	public static bool IsValid(ISplineContainer spline) { }

	[Address(RVA = "0x284ABD0", Offset = "0x2849FD0", Length = "0x5FF")]
	[Extension]
	[Token(Token = "0x600043E")]
	public static bool LocalEvaluateSplineWithRoll(ISpline spline, float tNormalized, CinemachineSplineRoll roll, out Vector3 position, out Quaternion rotation) { }

	[Address(RVA = "0x284B1D0", Offset = "0x284A5D0", Length = "0x1C9")]
	[Extension]
	[Token(Token = "0x6000442")]
	public static float StandardizePosition(ISpline spline, float t, PathIndexUnit unit, out float maxPos) { }

}

