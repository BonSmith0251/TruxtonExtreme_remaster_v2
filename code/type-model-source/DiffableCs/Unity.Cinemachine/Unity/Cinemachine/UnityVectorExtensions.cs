namespace Unity.Cinemachine;

[Extension]
[Token(Token = "0x20000F4")]
public static class UnityVectorExtensions
{
	[Token(Token = "0x4000391")]
	public const float Epsilon = 0.0001; //Field offset: 0x0

	[Address(RVA = "0x2866C50", Offset = "0x2866050", Length = "0x31")]
	[Extension]
	[Token(Token = "0x6000482")]
	public static Vector3 Abs(Vector3 v) { }

	[Address(RVA = "0x2866C20", Offset = "0x2866020", Length = "0x28")]
	[Extension]
	[Token(Token = "0x6000481")]
	public static Vector2 Abs(Vector2 v) { }

	[Address(RVA = "0x2866C90", Offset = "0x2866090", Length = "0x31")]
	[Extension]
	[Token(Token = "0x6000485")]
	public static bool AlmostZero(Vector3 v) { }

	[Address(RVA = "0x2866CD0", Offset = "0x28660D0", Length = "0x1CA")]
	[Token(Token = "0x6000487")]
	public static float Angle(Vector3 v1, Vector3 v2) { }

	[Address(RVA = "0x2866F40", Offset = "0x2866340", Length = "0xEF")]
	[Extension]
	[Token(Token = "0x600047B")]
	public static float ClosestPointOnSegment(Vector3 p, Vector3 s0, Vector3 s1) { }

	[Address(RVA = "0x2866EA0", Offset = "0x28662A0", Length = "0x9F")]
	[Extension]
	[Token(Token = "0x600047C")]
	public static float ClosestPointOnSegment(Vector2 p, Vector2 s0, Vector2 s1) { }

	[Address(RVA = "0x2867030", Offset = "0x2866430", Length = "0x146")]
	[Extension]
	[Token(Token = "0x6000486")]
	internal static void ConservativeSetPositionAndRotation(Transform t, Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x2867180", Offset = "0x2866580", Length = "0x2D")]
	[Extension]
	[Token(Token = "0x6000480")]
	private static float Cross(Vector2 v1, Vector2 v2) { }

	[Address(RVA = "0x28671B0", Offset = "0x28665B0", Length = "0x3DE")]
	[Token(Token = "0x600047F")]
	public static int FindIntersection(in Vector2 p1, in Vector2 p2, in Vector2 q1, in Vector2 q2, out Vector2 intersection) { }

	[Address(RVA = "0x2867590", Offset = "0x2866990", Length = "0x26")]
	[Extension]
	[Token(Token = "0x6000479")]
	public static bool IsNaN(Vector2 v) { }

	[Address(RVA = "0x28675C0", Offset = "0x28669C0", Length = "0x2E")]
	[Extension]
	[Token(Token = "0x600047A")]
	public static bool IsNaN(Vector3 v) { }

	[Address(RVA = "0x28676B0", Offset = "0x2866AB0", Length = "0x60")]
	[Extension]
	[Token(Token = "0x6000483")]
	public static bool IsUniform(Vector2 v) { }

	[Address(RVA = "0x28675F0", Offset = "0x28669F0", Length = "0xB6")]
	[Extension]
	[Token(Token = "0x6000484")]
	public static bool IsUniform(Vector3 v) { }

	[Address(RVA = "0x2867710", Offset = "0x2866B10", Length = "0x27")]
	[Token(Token = "0x600048B")]
	public static float NormalizeAngle(float angle) { }

	[Address(RVA = "0x2867740", Offset = "0x2866B40", Length = "0x8E")]
	[Extension]
	[Token(Token = "0x600047D")]
	public static Vector3 ProjectOntoPlane(Vector3 vector, Vector3 planeNormal) { }

	[Address(RVA = "0x28677D0", Offset = "0x2866BD0", Length = "0x59F")]
	[Token(Token = "0x6000489")]
	public static Quaternion SafeFromToRotation(Vector3 v1, Vector3 v2, Vector3 up) { }

	[Address(RVA = "0x2867D70", Offset = "0x2867170", Length = "0x139")]
	[Token(Token = "0x6000488")]
	public static float SignedAngle(Vector3 v1, Vector3 v2, Vector3 up) { }

	[Address(RVA = "0x2867EB0", Offset = "0x28672B0", Length = "0x30B")]
	[Token(Token = "0x600048A")]
	public static Vector3 SlerpWithReferenceUp(Vector3 vA, Vector3 vB, float t, Vector3 up) { }

	[Address(RVA = "0x28681C0", Offset = "0x28675C0", Length = "0x8F")]
	[Extension]
	[Token(Token = "0x600047E")]
	public static Vector2 SquareNormalize(Vector2 v) { }

}

