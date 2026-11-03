namespace Unity.Cinemachine;

[Extension]
[Token(Token = "0x20000F5")]
public static class UnityQuaternionExtensions
{

	[Address(RVA = "0x2865B40", Offset = "0x2864F40", Length = "0x314")]
	[Extension]
	[Token(Token = "0x600048E")]
	public static Quaternion ApplyCameraRotation(Quaternion orient, Vector2 rot, Vector3 worldUp) { }

	[Address(RVA = "0x2865E60", Offset = "0x2865260", Length = "0x4E7")]
	[Extension]
	[Token(Token = "0x600048D")]
	public static Vector2 GetCameraRotationToTarget(Quaternion orient, Vector3 lookAtDir, Vector3 worldUp) { }

	[Address(RVA = "0x2866350", Offset = "0x2865750", Length = "0x76B")]
	[Token(Token = "0x600048C")]
	public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up) { }

}

