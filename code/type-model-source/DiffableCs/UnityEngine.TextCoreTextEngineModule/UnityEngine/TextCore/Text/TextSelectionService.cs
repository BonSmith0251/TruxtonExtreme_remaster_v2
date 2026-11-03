namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextSelectionService.h")]
[Token(Token = "0x200005D")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements.PlayModeTests"})]
internal class TextSelectionService
{

	[Address(RVA = "0x31C1350", Offset = "0x31C0750", Length = "0x40")]
	[NativeMethod(Name = "TextSelectionService::GetCharacterHeightFromIndex")]
	[Token(Token = "0x600029E")]
	internal static float GetCharacterHeightFromIndex(IntPtr textGenerationInfo, int index) { }

	[Address(RVA = "0x31C13E0", Offset = "0x31C07E0", Length = "0x3D")]
	[NativeMethod(Name = "TextSelectionService::GetCursorLogicalIndexFromPosition")]
	[Token(Token = "0x6000299")]
	internal static int GetCursorLogicalIndexFromPosition(IntPtr textGenerationInfo, Vector2 position) { }

	[Address(RVA = "0x31C1390", Offset = "0x31C0790", Length = "0x42")]
	[Token(Token = "0x60002AB")]
	private static int GetCursorLogicalIndexFromPosition_Injected(IntPtr textGenerationInfo, in Vector2 position) { }

	[Address(RVA = "0x31C1470", Offset = "0x31C0870", Length = "0x51")]
	[NativeMethod(Name = "TextSelectionService::GetCursorPositionFromLogicalIndex")]
	[Token(Token = "0x600029A")]
	internal static Vector2 GetCursorPositionFromLogicalIndex(IntPtr textGenerationInfo, int logicalIndex) { }

	[Address(RVA = "0x31C1420", Offset = "0x31C0820", Length = "0x50")]
	[Token(Token = "0x60002AC")]
	private static void GetCursorPositionFromLogicalIndex_Injected(IntPtr textGenerationInfo, int logicalIndex, out Vector2 ret) { }

	[Address(RVA = "0x31C14D0", Offset = "0x31C08D0", Length = "0x40")]
	[NativeMethod(Name = "TextSelectionService::GetEndOfPreviousWord")]
	[Token(Token = "0x60002A0")]
	internal static int GetEndOfPreviousWord(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x31C1510", Offset = "0x31C0910", Length = "0x40")]
	[NativeMethod(Name = "TextSelectionService::GetFirstCharacterIndexOnLine")]
	[Token(Token = "0x60002A1")]
	internal static int GetFirstCharacterIndexOnLine(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x31C15B0", Offset = "0x31C09B0", Length = "0xD6")]
	[NativeMethod(Name = "TextSelectionService::GetHighlightRectangles")]
	[Token(Token = "0x600029D")]
	internal static Rect[] GetHighlightRectangles(IntPtr textGenerationInfo, int cursorIndex, int selectIndex) { }

	[Address(RVA = "0x31C1550", Offset = "0x31C0950", Length = "0x60")]
	[Token(Token = "0x60002AD")]
	private static void GetHighlightRectangles_Injected(IntPtr textGenerationInfo, int cursorIndex, int selectIndex, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x31C1690", Offset = "0x31C0A90", Length = "0x40")]
	[NativeMethod(Name = "TextSelectionService::GetLastCharacterIndexOnLine")]
	[Token(Token = "0x60002A2")]
	internal static int GetLastCharacterIndexOnLine(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x31C16D0", Offset = "0x31C0AD0", Length = "0x40")]
	[NativeMethod(Name = "TextSelectionService::GetLineHeight")]
	[Token(Token = "0x60002A3")]
	internal static float GetLineHeight(IntPtr textGenerationInfo, int lineIndex) { }

	[Address(RVA = "0x31C1710", Offset = "0x31C0B10", Length = "0x40")]
	[NativeMethod(Name = "TextSelectionService::GetLineNumberFromLogicalIndex")]
	[Token(Token = "0x60002A4")]
	internal static int GetLineNumber(IntPtr textGenerationInfo, int logicalIndex) { }

	[Address(RVA = "0x31C1750", Offset = "0x31C0B50", Length = "0x40")]
	[NativeMethod(Name = "TextSelectionService::GetStartOfNextWord")]
	[Token(Token = "0x600029F")]
	internal static int GetStartOfNextWord(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x31C1790", Offset = "0x31C0B90", Length = "0x40")]
	[NativeMethod(Name = "TextSelectionService::LineDownCharacterPosition")]
	[Token(Token = "0x600029C")]
	internal static int LineDownCharacterPosition(IntPtr textGenerationInfo, int originalPos) { }

	[Address(RVA = "0x31C17D0", Offset = "0x31C0BD0", Length = "0x40")]
	[NativeMethod(Name = "TextSelectionService::LineUpCharacterPosition")]
	[Token(Token = "0x600029B")]
	internal static int LineUpCharacterPosition(IntPtr textGenerationInfo, int originalPos) { }

	[Address(RVA = "0x31C1810", Offset = "0x31C0C10", Length = "0x40")]
	[NativeMethod(Name = "TextSelectionService::NextCodePointIndex")]
	[Token(Token = "0x6000298")]
	internal static int NextCodePointIndex(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x31C1850", Offset = "0x31C0C50", Length = "0x40")]
	[NativeMethod(Name = "TextSelectionService::PreviousCodePointIndex")]
	[Token(Token = "0x6000297")]
	internal static int PreviousCodePointIndex(IntPtr textGenerationInfo, int currentIndex) { }

	[Address(RVA = "0x31C1890", Offset = "0x31C0C90", Length = "0x52")]
	[NativeMethod(Name = "TextSelectionService::SelectCurrentParagraph")]
	[Token(Token = "0x60002A9")]
	internal static void SelectCurrentParagraph(IntPtr textGenerationInfo, ref int cursorIndex, ref int selectIndex) { }

	[Address(RVA = "0x31C18F0", Offset = "0x31C0CF0", Length = "0x60")]
	[NativeMethod(Name = "TextSelectionService::SelectCurrentWord")]
	[Token(Token = "0x6000296")]
	internal static void SelectCurrentWord(IntPtr textGenerationInfo, int currentIndex, ref int startIndex, ref int endIndex) { }

	[Address(RVA = "0x31C1950", Offset = "0x31C0D50", Length = "0x42")]
	[NativeMethod(Name = "TextSelectionService::SelectToEndOfParagraph")]
	[Token(Token = "0x60002A7")]
	internal static void SelectToEndOfParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[Address(RVA = "0x31C19A0", Offset = "0x31C0DA0", Length = "0x42")]
	[NativeMethod(Name = "TextSelectionService::SelectToNextParagraph")]
	[Token(Token = "0x60002A8")]
	internal static void SelectToNextParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[Address(RVA = "0x31C19F0", Offset = "0x31C0DF0", Length = "0x42")]
	[NativeMethod(Name = "TextSelectionService::SelectToPreviousParagraph")]
	[Token(Token = "0x60002A5")]
	internal static void SelectToPreviousParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[Address(RVA = "0x31C1A40", Offset = "0x31C0E40", Length = "0x42")]
	[NativeMethod(Name = "TextSelectionService::SelectToStartOfParagraph")]
	[Token(Token = "0x60002A6")]
	internal static void SelectToStartOfParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[Address(RVA = "0x31C1AF0", Offset = "0x31C0EF0", Length = "0xCA")]
	[NativeMethod(Name = "TextSelectionService::Substring")]
	[Token(Token = "0x6000295")]
	internal static string Substring(IntPtr textGenerationInfo, int startIndex, int endIndex) { }

	[Address(RVA = "0x31C1A90", Offset = "0x31C0E90", Length = "0x60")]
	[Token(Token = "0x60002AA")]
	private static void Substring_Injected(IntPtr textGenerationInfo, int startIndex, int endIndex, out ManagedSpanWrapper ret) { }

}

