namespace UnityEngine.Rendering;

[Token(Token = "0x200013B")]
internal static class ProbeVolumePositioning
{
	[Token(Token = "0x40005F0")]
	internal static Vector3[] m_Axes; //Field offset: 0x0
	[Token(Token = "0x40005F1")]
	internal static Vector3[] m_AABBCorners; //Field offset: 0x8

	[Address(RVA = "0x2C1D010", Offset = "0x2C1C410", Length = "0xA5")]
	[Token(Token = "0x6000AB3")]
	private static ProbeVolumePositioning() { }

	[Address(RVA = "0x2C1BC40", Offset = "0x2C1B040", Length = "0x691")]
	[Token(Token = "0x6000AB0")]
	public static bool OBBAABBIntersect(in Volume a, in Bounds b, in Bounds aAABB) { }

	[Address(RVA = "0x2C1C2E0", Offset = "0x2C1B6E0", Length = "0x165")]
	[Token(Token = "0x6000AAF")]
	public static bool OBBContains(in Volume obb, Vector3 point) { }

	[Address(RVA = "0x2C1C450", Offset = "0x2C1B850", Length = "0x894")]
	[Token(Token = "0x6000AAE")]
	public static bool OBBIntersect(in Volume a, in Volume b) { }

	[Address(RVA = "0x2C1CCF0", Offset = "0x2C1C0F0", Length = "0xDD")]
	[Token(Token = "0x6000AB2")]
	private static Vector2 ProjectAABB(in Vector3[] corners, Vector3 axis) { }

	[Address(RVA = "0x2C1CDD0", Offset = "0x2C1C1D0", Length = "0x231")]
	[Token(Token = "0x6000AB1")]
	private static Vector2 ProjectOBB(in Volume a, Vector3 axis) { }

}

