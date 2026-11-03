namespace UnityEngine;

[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/RectTransformUtil.h")]
[NativeHeader("Runtime/Transform/RectTransform.h")]
[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000005")]
public sealed class RectTransformUtility
{
	[Token(Token = "0x4000002")]
	private static readonly Vector3[] s_Corners; //Field offset: 0x0

	[Address(RVA = "0x3433820", Offset = "0x3432C20", Length = "0x68")]
	[Token(Token = "0x6000078")]
	private static RectTransformUtility() { }

	[Address(RVA = "0x3432120", Offset = "0x3431520", Length = "0x258")]
	[Token(Token = "0x6000076")]
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	[Address(RVA = "0x3432380", Offset = "0x3431780", Length = "0x425")]
	[Token(Token = "0x6000075")]
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	[Address(RVA = "0x34327B0", Offset = "0x3431BB0", Length = "0x1A")]
	[Token(Token = "0x6000077")]
	private static Vector2 GetTransposed(Vector2 input) { }

	[Address(RVA = "0x3432840", Offset = "0x3431C40", Length = "0xED")]
	[Token(Token = "0x600006C")]
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	[Address(RVA = "0x34327D0", Offset = "0x3431BD0", Length = "0x62")]
	[Token(Token = "0x6000079")]
	private static void PixelAdjustPoint_Injected(in Vector2 point, IntPtr elementTransform, IntPtr canvas, out Vector2 ret) { }

	[Address(RVA = "0x3432990", Offset = "0x3431D90", Length = "0xED")]
	[Token(Token = "0x600006D")]
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	[Address(RVA = "0x3432930", Offset = "0x3431D30", Length = "0x52")]
	[Token(Token = "0x600007A")]
	private static void PixelAdjustRect_Injected(IntPtr rectTransform, IntPtr canvas, out Rect ret) { }

	[Address(RVA = "0x3432AF0", Offset = "0x3431EF0", Length = "0xED")]
	[Token(Token = "0x600006E")]
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	[Address(RVA = "0x3432A80", Offset = "0x3431E80", Length = "0x62")]
	[Token(Token = "0x600007B")]
	private static bool PointInRectangle_Injected(in Vector2 screenPoint, IntPtr rect, IntPtr cam, in Vector4 offset) { }

	[Address(RVA = "0x3432D10", Offset = "0x3432110", Length = "0x191")]
	[Token(Token = "0x600006F")]
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	[Address(RVA = "0x3432BE0", Offset = "0x3431FE0", Length = "0x12E")]
	[Token(Token = "0x6000070")]
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	[Address(RVA = "0x3432EB0", Offset = "0x34322B0", Length = "0x115")]
	[Token(Token = "0x6000072")]
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	[Address(RVA = "0x3432FD0", Offset = "0x34323D0", Length = "0x17D")]
	[Token(Token = "0x6000073")]
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	[Address(RVA = "0x3433150", Offset = "0x3432550", Length = "0x607")]
	[Token(Token = "0x6000071")]
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	[Address(RVA = "0x3433760", Offset = "0x3432B60", Length = "0xBC")]
	[Token(Token = "0x6000074")]
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

}

