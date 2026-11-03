namespace UnityEngine.TextCore.Text;

[Extension]
[Token(Token = "0x2000059")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal static class TextGeneratorUtilities
{
	[Token(Token = "0x400037A")]
	public static readonly Vector2 largePositiveVector2; //Field offset: 0x0
	[Token(Token = "0x400037B")]
	public static readonly Vector2 largeNegativeVector2; //Field offset: 0x8
	[Token(Token = "0x400037C")]
	private static readonly HashSet<UInt32> k_EmojiLookup; //Field offset: 0x10
	[Token(Token = "0x400037D")]
	private static readonly HashSet<UInt32> k_EmojiPresentationFormLookup; //Field offset: 0x18

	[Address(RVA = "0x31BB8F0", Offset = "0x31BACF0", Length = "0x189")]
	[Token(Token = "0x600027E")]
	private static TextGeneratorUtilities() { }

	[Address(RVA = "0x31B7910", Offset = "0x31B6D10", Length = "0x38F")]
	[Token(Token = "0x6000266")]
	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) { }

	[Address(RVA = "0x31B7CA0", Offset = "0x31B70A0", Length = "0x22")]
	[Token(Token = "0x600024E")]
	public static bool Approximately(float a, float b) { }

	[Address(RVA = "0x31B7E50", Offset = "0x31B7250", Length = "0x7B")]
	[Token(Token = "0x6000251")]
	public static float ConvertToFloat(Char[] chars, int startIndex, int length) { }

	[Address(RVA = "0x31B7CD0", Offset = "0x31B70D0", Length = "0x17A")]
	[Token(Token = "0x6000252")]
	public static float ConvertToFloat(Char[] chars, int startIndex, int length, out int lastIndex) { }

	[Address(RVA = "0x31B7ED0", Offset = "0x31B72D0", Length = "0xE")]
	[Token(Token = "0x600026C")]
	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	[Address(RVA = "0x31B7EE0", Offset = "0x31B72E0", Length = "0x9E8")]
	[Token(Token = "0x6000264")]
	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo, bool needToRound) { }

	[Address(RVA = "0x31B88D0", Offset = "0x31B7CD0", Length = "0x93B")]
	[Token(Token = "0x6000265")]
	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[Address(RVA = "0x31B9290", Offset = "0x31B8690", Length = "0xAF")]
	[Token(Token = "0x6000277")]
	private static byte GammaToLinear(byte value) { }

	[Address(RVA = "0x31B9210", Offset = "0x31B8610", Length = "0x7D")]
	[Token(Token = "0x6000276")]
	internal static Color32 GammaToLinear(Color32 c) { }

	[Address(RVA = "0x31B9340", Offset = "0x31B8740", Length = "0xE2")]
	[Token(Token = "0x6000272")]
	public static int GetAttributeParameters(Char[] chars, int startIndex, int length, ref Single[] parameters) { }

	[Address(RVA = "0x31B9430", Offset = "0x31B8830", Length = "0x2C")]
	[Token(Token = "0x600026A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static HorizontalAlignment GetHorizontalAlignment(TextAnchor anchor) { }

	[Address(RVA = "0x31B9480", Offset = "0x31B8880", Length = "0xE6")]
	[Token(Token = "0x600026E")]
	public static int GetMarkupTagHashCode(UInt32[] styleDefinition, int readIndex) { }

	[Address(RVA = "0x31B9570", Offset = "0x31B8970", Length = "0xF3")]
	[Token(Token = "0x600026D")]
	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	[Address(RVA = "0x31B9850", Offset = "0x31B8C50", Length = "0xBA")]
	[Token(Token = "0x600025D")]
	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) { }

	[Address(RVA = "0x31B9760", Offset = "0x31B8B60", Length = "0xE6")]
	[Token(Token = "0x600025E")]
	public static int GetStyleHashCode(ref UInt32[] text, int index, out int closeIndex) { }

	[Address(RVA = "0x31B9670", Offset = "0x31B8A70", Length = "0xE6")]
	[Token(Token = "0x600025F")]
	public static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	[Address(RVA = "0x31B9A10", Offset = "0x31B8E10", Length = "0xDD")]
	[Token(Token = "0x6000260")]
	public static uint GetUTF16(UInt32[] text, int i) { }

	[Address(RVA = "0x31B9910", Offset = "0x31B8D10", Length = "0xF5")]
	[Token(Token = "0x6000261")]
	public static uint GetUTF16(TextBackingContainer text, int i) { }

	[Address(RVA = "0x31B9C50", Offset = "0x31B9050", Length = "0x1A7")]
	[Token(Token = "0x6000263")]
	public static uint GetUTF32(TextBackingContainer text, int i) { }

	[Address(RVA = "0x31B9AF0", Offset = "0x31B8EF0", Length = "0x159")]
	[Token(Token = "0x6000262")]
	public static uint GetUTF32(UInt32[] text, int i) { }

	[Address(RVA = "0x31B9E00", Offset = "0x31B9200", Length = "0x2C")]
	[Token(Token = "0x600026B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static VerticalAlignment GetVerticalAlignment(TextAnchor anchor) { }

	[Address(RVA = "0x31B9E50", Offset = "0x31B9250", Length = "0x419")]
	[Token(Token = "0x600024F")]
	public static Color32 HexCharsToColor(Char[] hexChars, int startIndex, int tagCount) { }

	[Address(RVA = "0x2F1DDD0", Offset = "0x2F1D1D0", Length = "0xA8")]
	[Token(Token = "0x6000250")]
	public static uint HexToInt(char hex) { }

	[Address(RVA = "0x31BA270", Offset = "0x31B9670", Length = "0xFB")]
	[Token(Token = "0x600025B")]
	internal static void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x31BA370", Offset = "0x31B9770", Length = "0xED")]
	[Token(Token = "0x6000256")]
	internal static void InsertClosingTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x31BA460", Offset = "0x31B9860", Length = "0xE7")]
	[Token(Token = "0x600025A")]
	internal static void InsertOpeningStyleTag(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x31BA550", Offset = "0x31B9950", Length = "0xED")]
	[Token(Token = "0x6000255")]
	internal static void InsertOpeningTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x31BA640", Offset = "0x31B9A40", Length = "0x50E")]
	[Token(Token = "0x600025C")]
	private static void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, UInt32[] styleDefinition, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x31BAB50", Offset = "0x31B9F50", Length = "0x10F")]
	[Token(Token = "0x6000274")]
	public static bool IsBaseGlyph(uint c) { }

	[Address(RVA = "0x31BAC60", Offset = "0x31BA060", Length = "0x25")]
	[Token(Token = "0x6000273")]
	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode) { }

	[Address(RVA = "0x31BAC90", Offset = "0x31BA090", Length = "0xBC")]
	[Token(Token = "0x600027D")]
	internal static bool IsCJK(uint c) { }

	[Address(RVA = "0x31BADD0", Offset = "0x31BA1D0", Length = "0x77")]
	[Token(Token = "0x600027A")]
	internal static bool IsEmoji(uint c) { }

	[Address(RVA = "0x31BAD50", Offset = "0x31BA150", Length = "0x77")]
	[Token(Token = "0x600027B")]
	internal static bool IsEmojiPresentationForm(uint c) { }

	[Address(RVA = "0x31BAE50", Offset = "0x31BA250", Length = "0x51")]
	[Token(Token = "0x600027C")]
	internal static bool IsHangul(uint c) { }

	[Address(RVA = "0x31BAEB0", Offset = "0x31BA2B0", Length = "0x6D")]
	[Token(Token = "0x6000278")]
	public static bool IsValidUTF16(TextBackingContainer text, int index) { }

	[Address(RVA = "0x31BAF20", Offset = "0x31BA320", Length = "0x6D")]
	[Token(Token = "0x6000279")]
	public static bool IsValidUTF32(TextBackingContainer text, int index) { }

	[Address(RVA = "0x31BAF90", Offset = "0x31BA390", Length = "0x54")]
	[Token(Token = "0x6000269")]
	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) { }

	[Address(RVA = "0x31BB010", Offset = "0x31BA410", Length = "0x24")]
	[Token(Token = "0x6000268")]
	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) { }

	[Address(RVA = "0x31BB040", Offset = "0x31BA440", Length = "0x59")]
	[Extension]
	[Token(Token = "0x6000275")]
	public static Color MinAlpha(Color c1, Color c2) { }

	[Address(RVA = "0x31BB0A0", Offset = "0x31BA4A0", Length = "0x120")]
	[Token(Token = "0x6000259")]
	public static void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x31BB3C0", Offset = "0x31BA7C0", Length = "0x1EF")]
	[Token(Token = "0x6000258")]
	private static bool ReplaceOpeningStyleTag(ref UInt32[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x31BB1D0", Offset = "0x31BA5D0", Length = "0x1EF")]
	[Token(Token = "0x6000257")]
	public static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<Int32>[]& textStyleStacks, ref TextGenerationSettings generationSettings) { }

	[Address(RVA = "0x943300", Offset = "0x942700", Length = "0x69")]
	[Token(Token = "0x6000254")]
	public static void ResizeInternalArray(ref T[] array, int size) { }

	[Address(RVA = "0x943290", Offset = "0x942690", Length = "0x6C")]
	[Token(Token = "0x6000253")]
	public static void ResizeInternalArray(ref T[] array) { }

	[Address(RVA = "0x31BB5B0", Offset = "0x31BA9B0", Length = "0x21C")]
	[Token(Token = "0x6000267")]
	public static void ResizeLineExtents(int size, TextInfo textInfo) { }

	[Address(RVA = "0x31BB830", Offset = "0x31BAC30", Length = "0x57")]
	[Token(Token = "0x6000270")]
	public static uint ToUpperASCIIFast(uint c) { }

	[Address(RVA = "0x31BB7D0", Offset = "0x31BABD0", Length = "0x55")]
	[Token(Token = "0x600026F")]
	public static char ToUpperASCIIFast(char c) { }

	[Address(RVA = "0x31BB890", Offset = "0x31BAC90", Length = "0x55")]
	[Token(Token = "0x6000271")]
	public static char ToUpperFast(char c) { }

}

