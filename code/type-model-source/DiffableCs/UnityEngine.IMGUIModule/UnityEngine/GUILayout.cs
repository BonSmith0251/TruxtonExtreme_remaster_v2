namespace UnityEngine;

[Token(Token = "0x200000F")]
public class GUILayout
{

	[Address(RVA = "0x30E6CE0", Offset = "0x30E60E0", Length = "0x7E")]
	[Token(Token = "0x60000AE")]
	public static void BeginArea(Rect screenRect, string text, GUIStyle style) { }

	[Address(RVA = "0x30E6A10", Offset = "0x30E5E10", Length = "0x2C6")]
	[Token(Token = "0x60000AF")]
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	[Address(RVA = "0x30E6D60", Offset = "0x30E6160", Length = "0x146")]
	[Token(Token = "0x60000AB")]
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	[Address(RVA = "0x30E6EB0", Offset = "0x30E62B0", Length = "0x167")]
	[Token(Token = "0x60000B0")]
	public static void EndArea() { }

	[Address(RVA = "0x30E7020", Offset = "0x30E6420", Length = "0x8B")]
	[Token(Token = "0x60000B2")]
	public static GUILayoutOption Height(float height) { }

	[Address(RVA = "0x30E7230", Offset = "0x30E6630", Length = "0x1E0")]
	[Token(Token = "0x60000AC")]
	public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUILayoutOption[] options) { }

	[Address(RVA = "0x30E70B0", Offset = "0x30E64B0", Length = "0x17C")]
	[Token(Token = "0x60000AD")]
	public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, GUILayoutOption[] options) { }

	[Address(RVA = "0x30E7420", Offset = "0x30E6820", Length = "0x1BB")]
	[Token(Token = "0x60000AA")]
	public static void Label(string text, GUILayoutOption[] options) { }

	[Address(RVA = "0x30E75E0", Offset = "0x30E69E0", Length = "0x8B")]
	[Token(Token = "0x60000B1")]
	public static GUILayoutOption Width(float width) { }

}

