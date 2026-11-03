namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000066")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal class TextInfo
{
	[Token(Token = "0x40003AA")]
	private static Vector2 s_InfinityVectorPositive; //Field offset: 0x0
	[Token(Token = "0x40003AB")]
	private static Vector2 s_InfinityVectorNegative; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003AC")]
	public int characterCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40003AD")]
	public int spriteCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003AE")]
	public int spaceCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40003AF")]
	public int wordCount; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003B0")]
	public int linkCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40003B1")]
	public int lineCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003B2")]
	public int materialCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003B3")]
	public TextElementInfo[] textElementInfo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003B4")]
	public WordInfo[] wordInfo; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003B5")]
	public LinkInfo[] linkInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003B6")]
	public LineInfo[] lineInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003B7")]
	public MeshInfo[] meshInfo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003B8")]
	public bool hasMultipleColors; //Field offset: 0x58

	[Address(RVA = "0x31C7620", Offset = "0x31C6A20", Length = "0x5C")]
	[Token(Token = "0x600032A")]
	private static TextInfo() { }

	[Address(RVA = "0x31C7680", Offset = "0x31C6A80", Length = "0x1BC")]
	[Token(Token = "0x6000311")]
	public TextInfo() { }

	[Address(RVA = "0x31C57C0", Offset = "0x31C4BC0", Length = "0x6D")]
	[Token(Token = "0x6000312")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void Clear() { }

	[Address(RVA = "0x31C54B0", Offset = "0x31C48B0", Length = "0x286")]
	[Token(Token = "0x6000314")]
	internal void ClearLineInfo() { }

	[Address(RVA = "0x31C5740", Offset = "0x31C4B40", Length = "0x7F")]
	[Token(Token = "0x6000313")]
	internal void ClearMeshInfo(bool updateMesh) { }

	[Address(RVA = "0x31C5830", Offset = "0x31C4C30", Length = "0x26A")]
	[Token(Token = "0x6000322")]
	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	[Address(RVA = "0x31C5AA0", Offset = "0x31C4EA0", Length = "0x53E")]
	[Token(Token = "0x600031E")]
	public int FindIntersectingLink(Vector3 position, Rect screenRect, bool inverseYAxis = true) { }

	[Address(RVA = "0x31C5FE0", Offset = "0x31C53E0", Length = "0x483")]
	[Token(Token = "0x600031D")]
	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly) { }

	[Address(RVA = "0x31C6470", Offset = "0x31C5870", Length = "0xC6")]
	[Token(Token = "0x600031C")]
	public int FindNearestLine(Vector2 position) { }

	[Address(RVA = "0x31C6540", Offset = "0x31C5940", Length = "0x58")]
	[Token(Token = "0x6000326")]
	public float GetCharacterHeightFromIndex(int index) { }

	[Address(RVA = "0x31C65A0", Offset = "0x31C59A0", Length = "0x57")]
	[Token(Token = "0x600031F")]
	public int GetCorrespondingStringIndex(int index) { }

	[Address(RVA = "0x31C6600", Offset = "0x31C5A00", Length = "0x1DE")]
	[Token(Token = "0x6000319")]
	public int GetCursorIndexFromPosition(Vector2 position, Rect screenRect, bool inverseYAxis = true) { }

	[Address(RVA = "0x31C67E0", Offset = "0x31C5BE0", Length = "0x13E")]
	[Token(Token = "0x6000317")]
	public override Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, Rect screenRect, float lineHeight, bool inverseYAxis = true) { }

	[Address(RVA = "0x31C6920", Offset = "0x31C5D20", Length = "0x1A0")]
	[Token(Token = "0x6000318")]
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, Rect screenRect, float lineHeight, bool useXAdvance = false, bool inverseYAxis = true) { }

	[Address(RVA = "0x31C6B60", Offset = "0x31C5F60", Length = "0x50")]
	[Token(Token = "0x6000324")]
	public float GetLineHeight(int lineNumber) { }

	[Address(RVA = "0x31C6AD0", Offset = "0x31C5ED0", Length = "0x88")]
	[Token(Token = "0x6000325")]
	public float GetLineHeightFromCharacterIndex(int index) { }

	[Address(RVA = "0x31C6BC0", Offset = "0x31C5FC0", Length = "0xC7")]
	[Token(Token = "0x6000320")]
	public LineInfo GetLineInfoFromCharacterIndex(int index) { }

	[Address(RVA = "0x31C6C90", Offset = "0x31C6090", Length = "0x4D")]
	[Token(Token = "0x6000323")]
	public int GetLineNumber(int index) { }

	[Address(RVA = "0x31C6CE0", Offset = "0x31C60E0", Length = "0xAB")]
	[Token(Token = "0x6000328")]
	public int IndexOf(char value, int startIndex) { }

	[Address(RVA = "0x31C6D90", Offset = "0x31C6190", Length = "0xA8")]
	[Token(Token = "0x6000329")]
	public int LastIndexOf(char value, int startIndex) { }

	[Address(RVA = "0x31C6E40", Offset = "0x31C6240", Length = "0x1C8")]
	[Token(Token = "0x600031A")]
	public int LineDownCharacterPosition(int originalPos) { }

	[Address(RVA = "0x31C7010", Offset = "0x31C6410", Length = "0x1C2")]
	[Token(Token = "0x600031B")]
	public int LineUpCharacterPosition(int originalPos) { }

	[Address(RVA = "0x31C71E0", Offset = "0x31C65E0", Length = "0x29D")]
	[Token(Token = "0x6000321")]
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	[Address(RVA = "0x93F9D0", Offset = "0x93EDD0", Length = "0x7C")]
	[Token(Token = "0x6000315")]
	internal static void Resize(ref T[] array, int size) { }

	[Address(RVA = "0x93FA50", Offset = "0x93EE50", Length = "0xA4")]
	[Token(Token = "0x6000316")]
	internal static void Resize(ref T[] array, int size, bool isBlockAllocated) { }

	[Address(RVA = "0x31C7480", Offset = "0x31C6880", Length = "0x19F")]
	[Token(Token = "0x6000327")]
	public string Substring(int startIndex, int length) { }

}

