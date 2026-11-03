namespace TMPro;

[Token(Token = "0x20000B7")]
public static class TMP_TextUtilities
{
	[Token(Token = "0x20000B8")]
	private struct LineSegment
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000686")]
		public Vector3 Point1; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000687")]
		public Vector3 Point2; //Field offset: 0xC

		[Address(RVA = "0x665C80", Offset = "0x665080", Length = "0x20")]
		[Token(Token = "0x60006FD")]
		public LineSegment(Vector3 p1, Vector3 p2) { }

	}

	[Token(Token = "0x4000683")]
	private static Vector3[] m_rectWorldCorners; //Field offset: 0x0
	[Token(Token = "0x4000684")]
	private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; //Field offset: 0x0
	[Token(Token = "0x4000685")]
	private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; //Field offset: 0x0

	[Address(RVA = "0x2F1EC90", Offset = "0x2F1E090", Length = "0x68")]
	[Token(Token = "0x60006FC")]
	private static TMP_TextUtilities() { }

	[Address(RVA = "0x2F19A10", Offset = "0x2F18E10", Length = "0x270")]
	[Token(Token = "0x60006F2")]
	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	[Address(RVA = "0x2F19C80", Offset = "0x2F19080", Length = "0x325")]
	[Token(Token = "0x60006E8")]
	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	[Address(RVA = "0x2F19FB0", Offset = "0x2F193B0", Length = "0x1F3")]
	[Token(Token = "0x60006EC")]
	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	[Address(RVA = "0x2F1A1B0", Offset = "0x2F195B0", Length = "0x6DF")]
	[Token(Token = "0x60006ED")]
	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	[Address(RVA = "0x2F1A890", Offset = "0x2F19C90", Length = "0x881")]
	[Token(Token = "0x60006EA")]
	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	[Address(RVA = "0x2F1B670", Offset = "0x2F1AA70", Length = "0x4C5")]
	[Token(Token = "0x60006E9")]
	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	[Address(RVA = "0x2F1B120", Offset = "0x2F1A520", Length = "0x541")]
	[Token(Token = "0x60006E6")]
	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	[Address(RVA = "0x2F1BB40", Offset = "0x2F1AF40", Length = "0x2D0")]
	[Token(Token = "0x60006E5")]
	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	[Address(RVA = "0x2F1BE20", Offset = "0x2F1B220", Length = "0xBE0")]
	[Token(Token = "0x60006EE")]
	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	[Address(RVA = "0x2F1CA10", Offset = "0x2F1BE10", Length = "0xC76")]
	[Token(Token = "0x60006EB")]
	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	[Address(RVA = "0x2F1D690", Offset = "0x2F1CA90", Length = "0x1D2")]
	[Token(Token = "0x60006E3")]
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	[Address(RVA = "0x2F1D870", Offset = "0x2F1CC70", Length = "0x2A1")]
	[Token(Token = "0x60006E4")]
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	[Address(RVA = "0x2F1DC00", Offset = "0x2F1D000", Length = "0xEF")]
	[Token(Token = "0x60006F6")]
	public static int GetHashCode(string s) { }

	[Address(RVA = "0x2F1DB20", Offset = "0x2F1CF20", Length = "0xD4")]
	[Token(Token = "0x60006F9")]
	public static uint GetHashCodeCaseInSensitive(string s) { }

	[Address(RVA = "0x2F17500", Offset = "0x2F16900", Length = "0x57")]
	[Token(Token = "0x60006F7")]
	public static int GetSimpleHashCode(string s) { }

	[Address(RVA = "0x2F1DCF0", Offset = "0x2F1D0F0", Length = "0xD7")]
	[Token(Token = "0x60006F8")]
	public static uint GetSimpleHashCodeLowercase(string s) { }

	[Address(RVA = "0x2F1DDD0", Offset = "0x2F1D1D0", Length = "0xA8")]
	[Token(Token = "0x60006FA")]
	public static int HexToInt(char hex) { }

	[Address(RVA = "0x2F1DEF0", Offset = "0x2F1D2F0", Length = "0x1DF")]
	[Token(Token = "0x60006F1")]
	private static bool IntersectLinePlane(LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	[Address(RVA = "0x2F1E0D0", Offset = "0x2F1D4D0", Length = "0x1C8")]
	[Token(Token = "0x60006E7")]
	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	[Address(RVA = "0x2F1E2A0", Offset = "0x2F1D6A0", Length = "0x299")]
	[Token(Token = "0x60006EF")]
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	[Address(RVA = "0x2F1E540", Offset = "0x2F1D940", Length = "0x423")]
	[Token(Token = "0x60006F0")]
	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	[Address(RVA = "0x2F1E970", Offset = "0x2F1DD70", Length = "0xA0")]
	[Token(Token = "0x60006FB")]
	public static int StringHexToInt(string s) { }

	[Address(RVA = "0x2F1EB70", Offset = "0x2F1DF70", Length = "0x57")]
	[Token(Token = "0x60006F3")]
	public static char ToLowerFast(char c) { }

	[Address(RVA = "0x2F1EBD0", Offset = "0x2F1DFD0", Length = "0x5D")]
	[Token(Token = "0x60006F5")]
	internal static uint ToUpperASCIIFast(uint c) { }

	[Address(RVA = "0x2F1EC30", Offset = "0x2F1E030", Length = "0x57")]
	[Token(Token = "0x60006F4")]
	public static char ToUpperFast(char c) { }

}

