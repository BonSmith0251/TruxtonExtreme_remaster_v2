namespace KANAI.Kernel.Extensions;

[Extension]
[Token(Token = "0x2000042")]
public static class Extensions
{

	[Address(RVA = "0x1DE9050", Offset = "0x1DE8450", Length = "0xC5")]
	[Extension]
	[Token(Token = "0x600023F")]
	public static Transform FindAlls(Transform iSelf, string tname) { }

	[Address(RVA = "0x1DE92E0", Offset = "0x1DE86E0", Length = "0xDC")]
	[Extension]
	[Token(Token = "0x6000232")]
	public static GameObject FindObject(GameObject iSelf, string iFormat, Object[] args) { }

	[Address(RVA = "0x1DE9200", Offset = "0x1DE8600", Length = "0xD3")]
	[Extension]
	[Token(Token = "0x600023E")]
	public static Transform FindObject(Transform iSelf, string iFormat, Object[] args) { }

	[Address(RVA = "0x1DE9120", Offset = "0x1DE8520", Length = "0xD2")]
	[Extension]
	[Token(Token = "0x6000233")]
	public static GameObject FindObjectInChild(GameObject iSelf, string name) { }

	[Address(RVA = "0x1DE93C0", Offset = "0x1DE87C0", Length = "0x133")]
	[Extension]
	[Token(Token = "0x6000234")]
	public static List<GameObject> FindObjectsInChild(GameObject iSelf, string name) { }

	[Address(RVA = "0x1DE9500", Offset = "0x1DE8900", Length = "0x1F6")]
	[Extension]
	[Token(Token = "0x6000237")]
	public static void FitRectToParent(Transform node) { }

	[Address(RVA = "0x1DE9700", Offset = "0x1DE8B00", Length = "0x1A5")]
	[Extension]
	[Token(Token = "0x6000240")]
	public static string GetParentPath(Transform iSelf, Transform iParent) { }

	[Address(RVA = "0x7F0D00", Offset = "0x7F0100", Length = "0xD3")]
	[Extension]
	[Token(Token = "0x6000235")]
	public static ComponentType GetSafeComponent(GameObject iSelf) { }

	[Address(RVA = "0x1DE9970", Offset = "0x1DE8D70", Length = "0xFC")]
	[Extension]
	[Token(Token = "0x6000239")]
	public static void Identity(Transform node) { }

	[Address(RVA = "0x1DE98B0", Offset = "0x1DE8CB0", Length = "0xB0")]
	[Extension]
	[Token(Token = "0x600023A")]
	public static void IdentityNoScale(Transform node) { }

	[Address(RVA = "0x1DE9C50", Offset = "0x1DE9050", Length = "0x1BE")]
	[Extension]
	[Token(Token = "0x600023C")]
	public static Quaternion InverseRotation(Transform node, Quaternion worldQuaternion) { }

	[Address(RVA = "0x1DE9A70", Offset = "0x1DE8E70", Length = "0x1D0")]
	[Extension]
	[Token(Token = "0x600023D")]
	public static Quaternion InverseRotationR(Transform node, Quaternion worldQuaternion) { }

	[Address(RVA = "0x1DE9E10", Offset = "0x1DE9210", Length = "0x18F")]
	[Extension]
	[Token(Token = "0x600023B")]
	public static Vector3 LocalPositionToParent(Transform node, Transform parent, bool withSelf = true) { }

	[Address(RVA = "0x1DE9FA0", Offset = "0x1DE93A0", Length = "0x1F7")]
	[Extension]
	[Token(Token = "0x6000238")]
	public static void RectIdentity(Transform node) { }

	[Address(RVA = "0x1DEA1A0", Offset = "0x1DE95A0", Length = "0x229")]
	[Extension]
	[Token(Token = "0x6000236")]
	public static void SetLayers(GameObject iSelf, int nlayer) { }

}

