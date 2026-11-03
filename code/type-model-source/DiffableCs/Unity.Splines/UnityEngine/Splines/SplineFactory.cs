namespace UnityEngine.Splines;

[Token(Token = "0x200003A")]
public static class SplineFactory
{

	[Address(RVA = "0x2E641F0", Offset = "0x2E635F0", Length = "0xE")]
	[Token(Token = "0x600021C")]
	public static Spline CreateCatmullRom(IList<float3> positions, bool closed = false) { }

	[Address(RVA = "0x2E63C90", Offset = "0x2E63090", Length = "0x559")]
	[Token(Token = "0x600021D")]
	internal static Spline CreateCatmullRom(IList<float3> positions, IList<quaternion> rotations, bool closed = false) { }

	[Address(RVA = "0x2E64200", Offset = "0x2E63600", Length = "0x43C")]
	[Token(Token = "0x6000222")]
	public static Spline CreateCircle(float radius) { }

	[Address(RVA = "0x2E64640", Offset = "0x2E63A40", Length = "0xB67")]
	[Token(Token = "0x600021F")]
	public static Spline CreateHelix(float radius, float height, int revolutions) { }

	[Address(RVA = "0x2E651B0", Offset = "0x2E645B0", Length = "0xE")]
	[Token(Token = "0x600021A")]
	public static Spline CreateLinear(IList<float3> positions, bool closed = false) { }

	[Address(RVA = "0x2E651C0", Offset = "0x2E645C0", Length = "0x284")]
	[Token(Token = "0x600021B")]
	public static Spline CreateLinear(IList<float3> positions, IList<quaternion> rotations, bool closed = false) { }

	[Address(RVA = "0x2E65450", Offset = "0x2E64850", Length = "0x437")]
	[Token(Token = "0x6000223")]
	public static Spline CreatePolygon(float edgeSize, int sides) { }

	[Address(RVA = "0x2E65890", Offset = "0x2E64C90", Length = "0xAF9")]
	[Token(Token = "0x6000220")]
	public static Spline CreateRoundedCornerSquare(float size, float cornerRadius) { }

	[Address(RVA = "0x2E66390", Offset = "0x2E65790", Length = "0x5BF")]
	[Token(Token = "0x600021E")]
	public static Spline CreateRoundedSquare(float radius, float rounding) { }

	[Address(RVA = "0x2E66950", Offset = "0x2E65D50", Length = "0x1C9")]
	[Token(Token = "0x6000221")]
	public static Spline CreateSquare(float size) { }

	[Address(RVA = "0x2E66B20", Offset = "0x2E65F20", Length = "0x5FF")]
	[Token(Token = "0x6000224")]
	public static Spline CreateStarPolygon(float edgeSize, int corners, float concavity) { }

}

