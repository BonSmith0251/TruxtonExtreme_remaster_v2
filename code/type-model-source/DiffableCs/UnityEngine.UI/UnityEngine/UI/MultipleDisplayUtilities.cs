namespace UnityEngine.UI;

[Token(Token = "0x200005B")]
internal static class MultipleDisplayUtilities
{

	[Address(RVA = "0x344B190", Offset = "0x344A590", Length = "0xE2")]
	[Token(Token = "0x600036C")]
	public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position) { }

	[Address(RVA = "0x344B280", Offset = "0x344A680", Length = "0x12B")]
	[Token(Token = "0x600036D")]
	internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData) { }

	[Address(RVA = "0x344B3B0", Offset = "0x344A7B0", Length = "0x491")]
	[Token(Token = "0x600036E")]
	public static Vector3 RelativeMouseAtScaled(Vector2 position, int displayIndex) { }

}

