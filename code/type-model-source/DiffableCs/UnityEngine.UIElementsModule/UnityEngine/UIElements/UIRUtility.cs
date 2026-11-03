namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x20002E5")]
internal static class UIRUtility
{
	[ThreadStatic]
	[Token(Token = "0x4000BCD")]
	private static Nullable<Int32> s_ThreadIndex; //Field offset: 0x80000000
	[Token(Token = "0x4000BCB")]
	private static readonly ProfilerMarker k_ComputeTransformMatrixMarker; //Field offset: 0x0
	[Token(Token = "0x4000BCC")]
	public static readonly string k_DefaultShaderName; //Field offset: 0x8

	[Address(RVA = "0x3410760", Offset = "0x340FB60", Length = "0xBC")]
	[Token(Token = "0x6001439")]
	private static UIRUtility() { }

	[Address(RVA = "0x340F880", Offset = "0x340EC80", Length = "0xB6")]
	[Token(Token = "0x6001430")]
	public static Rect CastToRect(RectInt rect) { }

	[Address(RVA = "0x340F6E0", Offset = "0x340EAE0", Length = "0x19E")]
	[Token(Token = "0x6001431")]
	public static RectInt CastToRectInt(Rect rect) { }

	[Address(RVA = "0x340F940", Offset = "0x340ED40", Length = "0x283")]
	[Token(Token = "0x600142A")]
	private static void ComputeMatrixRelativeToAncestor(RenderData renderData, RenderData ancestor, out Matrix4x4 transform) { }

	[Address(RVA = "0x340FBD0", Offset = "0x340EFD0", Length = "0xD4")]
	[Token(Token = "0x600142B")]
	public static void ComputeMatrixRelativeToRenderTree(RenderData renderData, out Matrix4x4 transform) { }

	[Address(RVA = "0x340FCB0", Offset = "0x340F0B0", Length = "0x1D0")]
	[Token(Token = "0x600142D")]
	internal static void ComputeTransformMatrix(RenderData renderData, RenderData ancestor, out Matrix4x4 result) { }

	[Address(RVA = "0x340FE90", Offset = "0x340F290", Length = "0xBE")]
	[Token(Token = "0x6001434")]
	public static void Destroy(object obj) { }

	[Address(RVA = "0x340FF50", Offset = "0x340F350", Length = "0x164")]
	[Token(Token = "0x6001428")]
	public static Rect Encapsulate(Rect a, Rect b) { }

	[Address(RVA = "0x34100E0", Offset = "0x340F4E0", Length = "0x17")]
	[Token(Token = "0x6001436")]
	public static int GetNextPow2(int n) { }

	[Address(RVA = "0x34100C0", Offset = "0x340F4C0", Length = "0x19")]
	[Token(Token = "0x6001437")]
	public static int GetNextPow2Exp(int n) { }

	[Address(RVA = "0x3410100", Offset = "0x340F500", Length = "0x1E")]
	[Token(Token = "0x6001435")]
	public static int GetPrevPow2(int n) { }

	[Address(RVA = "0x3410120", Offset = "0x340F520", Length = "0xEB")]
	[Token(Token = "0x6001438")]
	public static int GetThreadIndex() { }

	[Address(RVA = "0x3410210", Offset = "0x340F610", Length = "0x1AD")]
	[Token(Token = "0x600142C")]
	public static void GetVerticesTransformInfo(RenderData renderData, out Matrix4x4 transform) { }

	[Address(RVA = "0x34103C0", Offset = "0x340F7C0", Length = "0xB0")]
	[Token(Token = "0x6001429")]
	public static Rect InflateByMargins(Rect r, PostProcessingMargins margins) { }

	[Address(RVA = "0x3410470", Offset = "0x340F870", Length = "0xD6")]
	[Token(Token = "0x6001432")]
	public static bool IsRoundRect(VisualElement ve) { }

	[Address(RVA = "0x3410550", Offset = "0x340F950", Length = "0x9E")]
	[Token(Token = "0x6001433")]
	public static bool IsVectorImageBackground(VisualElement ve) { }

	[Address(RVA = "0x3410670", Offset = "0x340FA70", Length = "0x6B")]
	[Token(Token = "0x600142F")]
	public static bool RectHasArea(RectInt rect) { }

	[Address(RVA = "0x34105F0", Offset = "0x340F9F0", Length = "0x7A")]
	[Token(Token = "0x600142E")]
	public static bool RectHasArea(Rect rect) { }

	[Address(RVA = "0x34106E0", Offset = "0x340FAE0", Length = "0x78")]
	[Token(Token = "0x6001427")]
	public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef) { }

}

