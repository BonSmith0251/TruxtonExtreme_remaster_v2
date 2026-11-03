namespace DG.Tweening.Core;

[Token(Token = "0x20000B6")]
public static class DOTweenUtils
{
	[Token(Token = "0x4000243")]
	private static Assembly[] _loadedAssemblies; //Field offset: 0x0
	[Token(Token = "0x4000244")]
	private static readonly String[] _defAssembliesToQuery; //Field offset: 0x8

	[Address(RVA = "0x67F520", Offset = "0x67E920", Length = "0xF5")]
	[Token(Token = "0x600044A")]
	private static DOTweenUtils() { }

	[Address(RVA = "0x67EE30", Offset = "0x67E230", Length = "0x203")]
	[Token(Token = "0x6000445")]
	internal static float Angle2D(Vector3 from, Vector3 to) { }

	[Address(RVA = "0x67F040", Offset = "0x67E440", Length = "0x2C1")]
	[Token(Token = "0x6000449")]
	internal static Type GetLooseScriptType(string typeName) { }

	[Address(RVA = "0x67F310", Offset = "0x67E710", Length = "0x77")]
	[Token(Token = "0x6000447")]
	public static Vector2 GetPointOnCircle(Vector2 center, float radius, float degrees) { }

	[Address(RVA = "0x67F390", Offset = "0x67E790", Length = "0xBF")]
	[Token(Token = "0x6000446")]
	internal static Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation) { }

	[Address(RVA = "0x67F450", Offset = "0x67E850", Length = "0x63")]
	[Token(Token = "0x6000448")]
	internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b) { }

	[Address(RVA = "0x67F4C0", Offset = "0x67E8C0", Length = "0x5C")]
	[Token(Token = "0x6000444")]
	internal static Vector3 Vector3FromAngle(float degrees, float magnitude) { }

}

