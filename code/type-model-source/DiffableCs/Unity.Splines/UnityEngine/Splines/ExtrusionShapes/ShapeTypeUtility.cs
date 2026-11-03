namespace UnityEngine.Splines.ExtrusionShapes;

[Token(Token = "0x200006D")]
internal static class ShapeTypeUtility
{

	[Address(RVA = "0x2E75060", Offset = "0x2E74460", Length = "0x100")]
	[Token(Token = "0x6000377")]
	public static IExtrudeShape CreateShape(ShapeType type) { }

	[Address(RVA = "0x2E75170", Offset = "0x2E74570", Length = "0x147")]
	[Token(Token = "0x6000376")]
	public static ShapeType GetShapeType(object obj) { }

}

