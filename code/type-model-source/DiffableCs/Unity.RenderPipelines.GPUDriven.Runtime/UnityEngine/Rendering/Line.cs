namespace UnityEngine.Rendering;

[Token(Token = "0x2000015")]
internal struct Line
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003A")]
	public float3 m; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400003B")]
	public float3 t; //Field offset: 0xC

	[Address(RVA = "0x2CD3430", Offset = "0x2CD2830", Length = "0xBE")]
	[Token(Token = "0x6000084")]
	internal static Line LineOfPlaneIntersectingPlane(float4 a, float4 b) { }

	[Address(RVA = "0x2CD34F0", Offset = "0x2CD28F0", Length = "0xFE")]
	[Token(Token = "0x6000085")]
	internal static float4 PlaneContainingLineAndPoint(Line a, float3 b) { }

	[Address(RVA = "0x2CD35F0", Offset = "0x2CD29F0", Length = "0xD8")]
	[Token(Token = "0x6000086")]
	internal static float4 PlaneContainingLineWithNormalPerpendicularToVector(Line a, float3 b) { }

}

