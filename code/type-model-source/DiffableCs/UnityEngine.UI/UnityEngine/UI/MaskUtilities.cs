namespace UnityEngine.UI;

[Token(Token = "0x2000058")]
public class MaskUtilities
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000368")]
	public MaskUtilities() { }

	[Address(RVA = "0x3446DA0", Offset = "0x34461A0", Length = "0x17B")]
	[Token(Token = "0x6000363")]
	public static Transform FindRootSortOverrideCanvas(Transform start) { }

	[Address(RVA = "0x3446F20", Offset = "0x3446320", Length = "0x322")]
	[Token(Token = "0x6000366")]
	public static RectMask2D GetRectMaskForClippable(IClippable clippable) { }

	[Address(RVA = "0x3447250", Offset = "0x3446650", Length = "0x342")]
	[Token(Token = "0x6000367")]
	public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks) { }

	[Address(RVA = "0x34475A0", Offset = "0x34469A0", Length = "0x294")]
	[Token(Token = "0x6000364")]
	public static int GetStencilDepth(Transform transform, Transform stopAfter) { }

	[Address(RVA = "0x3447840", Offset = "0x3446C40", Length = "0x169")]
	[Token(Token = "0x6000365")]
	public static bool IsDescendantOrSelf(Transform father, Transform child) { }

	[Address(RVA = "0x34479B0", Offset = "0x3446DB0", Length = "0x207")]
	[Token(Token = "0x6000361")]
	public static void Notify2DMaskStateChanged(Component mask) { }

	[Address(RVA = "0x3447BC0", Offset = "0x3446FC0", Length = "0x204")]
	[Token(Token = "0x6000362")]
	public static void NotifyStencilStateChanged(Component mask) { }

}

