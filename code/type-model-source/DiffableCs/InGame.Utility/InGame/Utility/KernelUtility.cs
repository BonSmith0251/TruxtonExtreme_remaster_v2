namespace InGame.Utility;

[Token(Token = "0x2000008")]
public static class KernelUtility
{

	[Address(RVA = "0x1DD70A0", Offset = "0x1DD64A0", Length = "0x5D")]
	[Token(Token = "0x600000C")]
	public static Vector3 GetPlaneEuler(Vector3 direction) { }

	[Address(RVA = "0x1DD7100", Offset = "0x1DD6500", Length = "0x170")]
	[Token(Token = "0x600000D")]
	public static Vector3 GetPlaneEuler(Quaternion tq) { }

	[Address(RVA = "0x1DD7270", Offset = "0x1DD6670", Length = "0x25B")]
	[Token(Token = "0x600000B")]
	public static Quaternion GetPlaneQuaternion(Vector3 direction) { }

	[Address(RVA = "0x1DD74D0", Offset = "0x1DD68D0", Length = "0x225")]
	[Token(Token = "0x600000A")]
	public static Dictionary<String, Int32> MergeDic(Dictionary<String, Int32> ret, Dictionary<String, Int32> temp, bool withAdd) { }

	[Address(RVA = "0x1DD7700", Offset = "0x1DD6B00", Length = "0x6E")]
	[Token(Token = "0x600000E")]
	public static float Normalized(float tval, float tmin, float tmax) { }

}

