namespace UnityEngine.Rendering;

[Extension]
[Token(Token = "0x20000C6")]
internal static class LODRenderingUtils
{

	[Address(RVA = "0x2CF76C0", Offset = "0x2CF6AC0", Length = "0x15")]
	[Token(Token = "0x600034C")]
	public static float CalculateFOVHalfAngle(float fieldOfView) { }

	[Address(RVA = "0x2CF76E0", Offset = "0x2CF6AE0", Length = "0x8")]
	[Token(Token = "0x6000354")]
	public static float CalculateLODDistance(float relativeScreenHeight, float size) { }

	[Address(RVA = "0x2CF76F0", Offset = "0x2CF6AF0", Length = "0x2F")]
	[Token(Token = "0x600034E")]
	public static float CalculateMeshLodConstant(LODParameters lodParams, float screenRelativeMetric, float meshLodThreshold) { }

	[Address(RVA = "0x2CF7720", Offset = "0x2CF6B20", Length = "0x65")]
	[Token(Token = "0x600034F")]
	public static float CalculatePerspectiveDistance(Vector3 objPosition, Vector3 camPosition, float sqrScreenRelativeMetric) { }

	[Address(RVA = "0x2CF7790", Offset = "0x2CF6B90", Length = "0x4C")]
	[Token(Token = "0x600034D")]
	public static float CalculateScreenRelativeMetricNoBias(LODParameters lodParams) { }

	[Address(RVA = "0x2CF77E0", Offset = "0x2CF6BE0", Length = "0x50")]
	[Token(Token = "0x6000350")]
	public static float CalculateSqrPerspectiveDistance(Vector3 objPosition, Vector3 camPosition, float sqrScreenRelativeMetric) { }

	[Address(RVA = "0x2CF7830", Offset = "0x2CF6C30", Length = "0x88")]
	[Extension]
	[Token(Token = "0x6000351")]
	public static Vector3 GetWorldReferencePoint(LODGroup lodGroup) { }

	[Address(RVA = "0x2CF78C0", Offset = "0x2CF6CC0", Length = "0x59")]
	[Extension]
	[Token(Token = "0x6000352")]
	public static float GetWorldSpaceScale(LODGroup lodGroup) { }

	[Address(RVA = "0x2CF7920", Offset = "0x2CF6D20", Length = "0x85")]
	[Extension]
	[Token(Token = "0x6000353")]
	public static float GetWorldSpaceSize(LODGroup lodGroup) { }

}

