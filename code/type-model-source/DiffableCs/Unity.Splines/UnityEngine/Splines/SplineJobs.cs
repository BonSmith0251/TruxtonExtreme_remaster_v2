namespace UnityEngine.Splines;

[Token(Token = "0x2000046")]
public static class SplineJobs
{

	[Address(RVA = "0x8FB220", Offset = "0x8FA620", Length = "0x16D")]
	[Token(Token = "0x600028B")]
	public static void EvaluatePosition(T spline, NativeArray<float3> positions) { }

	[Address(RVA = "0x2E75920", Offset = "0x2E74D20", Length = "0x112")]
	[Token(Token = "0x600028C")]
	public static void EvaluatePosition(NativeSpline spline, NativeArray<float3> positions) { }

	[Address(RVA = "0x8FB070", Offset = "0x8FA470", Length = "0x1A4")]
	[Token(Token = "0x600028D")]
	public static void EvaluatePositionTangentNormal(T spline, NativeArray<float3> positions, NativeArray<float3> tangents, NativeArray<float3> normals) { }

	[Address(RVA = "0x2E757E0", Offset = "0x2E74BE0", Length = "0x13B")]
	[Token(Token = "0x600028E")]
	public static void EvaluatePositionTangentNormal(NativeSpline spline, NativeArray<float3> positions, NativeArray<float3> tangents, NativeArray<float3> normals) { }

}

