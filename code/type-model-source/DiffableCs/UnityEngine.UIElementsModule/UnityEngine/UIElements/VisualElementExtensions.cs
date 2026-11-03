namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x2000540")]
public static class VisualElementExtensions
{

	[Address(RVA = "0x32C7C10", Offset = "0x32C7010", Length = "0x50")]
	[Extension]
	[Token(Token = "0x600269D")]
	public static void AddManipulator(VisualElement ele, IManipulator manipulator) { }

	[Address(RVA = "0x32C7EA0", Offset = "0x32C72A0", Length = "0x89")]
	[Extension]
	[Token(Token = "0x60026A9")]
	internal static Ray ChangeCoordinatesTo(VisualElement src, VisualElement dest, Ray ray) { }

	[Address(RVA = "0x32C8020", Offset = "0x32C7420", Length = "0x4A8")]
	[Extension]
	[Token(Token = "0x60026A8")]
	public static Rect ChangeCoordinatesTo(VisualElement src, VisualElement dest, Rect rect) { }

	[Address(RVA = "0x32C7F30", Offset = "0x32C7330", Length = "0xEA")]
	[Extension]
	[Token(Token = "0x60026A5")]
	public static Vector2 ChangeCoordinatesTo(VisualElement src, VisualElement dest, Vector2 point) { }

	[Address(RVA = "0x32C7C60", Offset = "0x32C7060", Length = "0xF9")]
	[Extension]
	[Token(Token = "0x60026A6")]
	internal static Vector2 ChangeCoordinatesTo_2D(VisualElement src, VisualElement dest, Vector2 point) { }

	[Address(RVA = "0x32C7D60", Offset = "0x32C7160", Length = "0x13A")]
	[Extension]
	[Token(Token = "0x60026A7")]
	internal static Vector2 ChangeCoordinatesTo_3D(VisualElement src, VisualElement dest, Vector2 point) { }

	[Address(RVA = "0x32C84D0", Offset = "0x32C78D0", Length = "0x1AF")]
	[Extension]
	[Token(Token = "0x60026AB")]
	internal static bool IntersectLocalRay(VisualElement ve, Ray localRay, out Vector3 localPoint) { }

	[Address(RVA = "0x32C8680", Offset = "0x32C7A80", Length = "0x41D")]
	[Extension]
	[Token(Token = "0x60026AA")]
	internal static bool IntersectWorldRay(VisualElement ve, Ray worldRay, out float distance, out Vector3 localPoint) { }

	[Address(RVA = "0x32C8AA0", Offset = "0x32C7EA0", Length = "0xDE")]
	[Extension]
	[Token(Token = "0x60026A1")]
	public static Vector2 LocalToWorld(VisualElement ele, Vector2 p) { }

	[Address(RVA = "0x32C8B80", Offset = "0x32C7F80", Length = "0x1DA")]
	[Extension]
	[Token(Token = "0x60026A3")]
	internal static Ray LocalToWorld(VisualElement ele, Ray r) { }

	[Address(RVA = "0x32C8D60", Offset = "0x32C8160", Length = "0x49")]
	[Extension]
	[Token(Token = "0x600269E")]
	public static void RemoveManipulator(VisualElement ele, IManipulator manipulator) { }

	[Address(RVA = "0x32C8DB0", Offset = "0x32C81B0", Length = "0x3F6")]
	[Extension]
	[Token(Token = "0x600269C")]
	public static void StretchToParentSize(VisualElement elem) { }

	[Address(RVA = "0x32C91B0", Offset = "0x32C85B0", Length = "0x1A9")]
	[Extension]
	[Token(Token = "0x60026AC")]
	internal static Ray TransformRay(Matrix4x4 m, Ray ray) { }

	[Address(RVA = "0x32C9740", Offset = "0x32C8B40", Length = "0xDE")]
	[Extension]
	[Token(Token = "0x600269F")]
	public static Vector2 WorldToLocal(VisualElement ele, Vector2 p) { }

	[Address(RVA = "0x32C9480", Offset = "0x32C8880", Length = "0xDF")]
	[Extension]
	[Token(Token = "0x60026A2")]
	public static Rect WorldToLocal(VisualElement ele, Rect r) { }

	[Address(RVA = "0x32C9560", Offset = "0x32C8960", Length = "0x1DA")]
	[Extension]
	[Token(Token = "0x60026A4")]
	internal static Ray WorldToLocal(VisualElement ele, Ray r) { }

	[Address(RVA = "0x32C9360", Offset = "0x32C8760", Length = "0x11B")]
	[Extension]
	[Token(Token = "0x60026A0")]
	internal static Vector3 WorldToLocal3D(VisualElement ele, Vector3 p) { }

}

