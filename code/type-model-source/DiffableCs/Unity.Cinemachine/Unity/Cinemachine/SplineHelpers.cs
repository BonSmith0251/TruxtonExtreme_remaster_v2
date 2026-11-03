namespace Unity.Cinemachine;

[Token(Token = "0x20000E9")]
internal static class SplineHelpers
{

	[Address(RVA = "0x284B3F0", Offset = "0x284A7F0", Length = "0x9C")]
	[Token(Token = "0x6000447")]
	public static float Bezier1(float t, float p0, float p1, float p2, float p3) { }

	[Address(RVA = "0x284B490", Offset = "0x284A890", Length = "0x18E")]
	[Token(Token = "0x6000444")]
	public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) { }

	[Address(RVA = "0x284B620", Offset = "0x284AA20", Length = "0xDC")]
	[Token(Token = "0x6000448")]
	public static float BezierTangent1(float t, float p0, float p1, float p2, float p3) { }

	[Address(RVA = "0x284B700", Offset = "0x284AB00", Length = "0x2EA")]
	[Token(Token = "0x6000445")]
	public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) { }

	[Address(RVA = "0x284B9F0", Offset = "0x284ADF0", Length = "0x1EE")]
	[Token(Token = "0x6000446")]
	public static void BezierTangentWeights3(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, out Vector3 w0, out Vector3 w1, out Vector3 w2) { }

	[Address(RVA = "0x284CCD0", Offset = "0x284C0D0", Length = "0x9E3")]
	[Token(Token = "0x6000449")]
	public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2) { }

	[Address(RVA = "0x284C310", Offset = "0x284B710", Length = "0x9B4")]
	[Token(Token = "0x600044B")]
	public static void ComputeSmoothControlPoints(ref float3[] knot, ref float3[] ctrl1, ref float3[] ctrl2) { }

	[Address(RVA = "0x284BFC0", Offset = "0x284B3C0", Length = "0x342")]
	[Token(Token = "0x600044A")]
	public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2) { }

	[Address(RVA = "0x284BBE0", Offset = "0x284AFE0", Length = "0x3D7")]
	[Token(Token = "0x600044C")]
	public static void ComputeSmoothControlPointsLooped(ref float3[] knot, ref float3[] ctrl1, ref float3[] ctrl2) { }

}

