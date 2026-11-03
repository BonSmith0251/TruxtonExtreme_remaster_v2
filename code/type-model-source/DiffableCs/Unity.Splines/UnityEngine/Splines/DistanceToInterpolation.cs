namespace UnityEngine.Splines;

[Token(Token = "0x2000012")]
public struct DistanceToInterpolation
{
	[Token(Token = "0x4000038")]
	internal static readonly DistanceToInterpolation Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000036")]
	public float Distance; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000037")]
	public float T; //Field offset: 0x4

	[Address(RVA = "0x2E58F90", Offset = "0x2E58390", Length = "0x40")]
	[Token(Token = "0x6000069")]
	private static DistanceToInterpolation() { }

}

