namespace UnityEngine.Splines;

[Token(Token = "0x2000048")]
public static class SplineMath
{

	[Address(RVA = "0x2E75CF0", Offset = "0x2E750F0", Length = "0x1CC")]
	[Token(Token = "0x600029D")]
	public static float DistancePointLine(float3 p, float3 a, float3 b) { }

	[Address(RVA = "0x2E75EC0", Offset = "0x2E752C0", Length = "0x75")]
	[Token(Token = "0x600029E")]
	internal static float GetUnitCircleTangentLength() { }

	[Address(RVA = "0x2E75F40", Offset = "0x2E75340", Length = "0x1BD")]
	[Token(Token = "0x600029C")]
	public static float3 PointLineNearestPoint(float3 p, float3 a, float3 b, out float lineParam) { }

	[Address(RVA = "0x2E76100", Offset = "0x2E75500", Length = "0xE7")]
	[Token(Token = "0x6000299")]
	public static float3 RayLineDistance(float3 ro, float3 rd, float3 a, float3 b) { }

	[Address(RVA = "0x2E76550", Offset = "0x2E75950", Length = "0xC0")]
	[Token(Token = "0x600029A")]
	public static ValueTuple<float3, float3> RayLineNearestPoint(float3 ro, float3 rd, float3 a, float3 b) { }

	[Address(RVA = "0x2E761F0", Offset = "0x2E755F0", Length = "0x35F")]
	[Token(Token = "0x600029B")]
	public static ValueTuple<float3, float3> RayLineNearestPoint(float3 ro, float3 rd, float3 a, float3 b, out float rayParam, out float lineParam) { }

	[Address(RVA = "0x2E76610", Offset = "0x2E75A10", Length = "0x152")]
	[Token(Token = "0x6000298")]
	public static float RayLineParameter(float3 ro, float3 rd, float3 lineOrigin, float3 lineDir) { }

}

