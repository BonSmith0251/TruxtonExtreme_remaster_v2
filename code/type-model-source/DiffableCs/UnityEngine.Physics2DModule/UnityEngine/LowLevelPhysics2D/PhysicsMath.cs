namespace UnityEngine.LowLevelPhysics2D;

[IsReadOnly]
[Token(Token = "0x2000063")]
public struct PhysicsMath
{

	[Address(RVA = "0x312C660", Offset = "0x312BA60", Length = "0x1E1")]
	[Token(Token = "0x60001DF")]
	public static Quaternion AngularVelocityToQuaternion(float angularVelocity, float deltaTime, TransformPlane transformPlane) { }

	[Address(RVA = "0x312A5F0", Offset = "0x31299F0", Length = "0x4A")]
	[Token(Token = "0x60001DB")]
	public static float Atan2(float y, float x) { }

	[Address(RVA = "0x3121430", Offset = "0x3120830", Length = "0xC1")]
	[Token(Token = "0x60001DC")]
	public static Vector3 Swizzle(Vector3 position, TransformPlane transformPlane = 0) { }

	[Address(RVA = "0x312C850", Offset = "0x312BC50", Length = "0xC1")]
	[Token(Token = "0x60001DD")]
	public static Vector3 ToPosition3D(Vector2 position, Vector3 reference, TransformPlane transformPlane = 0) { }

	[Address(RVA = "0x3121500", Offset = "0x3120900", Length = "0x33D")]
	[Token(Token = "0x60001DE")]
	public static float ToRotation2D(Quaternion quaternion, TransformPlane transformPlane = 0) { }

	[Address(RVA = "0x312C920", Offset = "0x312BD20", Length = "0x21D")]
	[Token(Token = "0x60001E0")]
	public static Quaternion ToRotationFast3D(float angle, TransformPlane transformPlane = 0) { }

	[Address(RVA = "0x3121840", Offset = "0x3120C40", Length = "0x2B6")]
	[Token(Token = "0x60001E1")]
	public static Quaternion ToRotationSlow3D(float angle, Quaternion reference, TransformPlane transformPlane = 0) { }

}

