namespace UnityEngine.TextCore.LowLevel;

[NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
[Token(Token = "0x200000D")]
public sealed class FontEngine
{
	[Token(Token = "0x400006F")]
	private static Glyph[] s_Glyphs; //Field offset: 0x0
	[Token(Token = "0x4000070")]
	private static UInt32[] s_GlyphIndexes_MarshallingArray_A; //Field offset: 0x8
	[Token(Token = "0x4000071")]
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; //Field offset: 0x10
	[Token(Token = "0x4000072")]
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; //Field offset: 0x18
	[Token(Token = "0x4000073")]
	private static GlyphRect[] s_FreeGlyphRects; //Field offset: 0x20
	[Token(Token = "0x4000074")]
	private static GlyphRect[] s_UsedGlyphRects; //Field offset: 0x28
	[Token(Token = "0x4000075")]
	private static LigatureSubstitutionRecord[] s_LigatureSubstitutionRecords_MarshallingArray; //Field offset: 0x30
	[Token(Token = "0x4000076")]
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; //Field offset: 0x38
	[Token(Token = "0x4000077")]
	private static MarkToBaseAdjustmentRecord[] s_MarkToBaseAdjustmentRecords_MarshallingArray; //Field offset: 0x40
	[Token(Token = "0x4000078")]
	private static MarkToMarkAdjustmentRecord[] s_MarkToMarkAdjustmentRecords_MarshallingArray; //Field offset: 0x48
	[Token(Token = "0x4000079")]
	private static Dictionary<UInt32, Glyph> s_GlyphLookupDictionary; //Field offset: 0x50

	[Address(RVA = "0x3170EB0", Offset = "0x31702B0", Length = "0x1D9")]
	[Token(Token = "0x6000071")]
	private static FontEngine() { }

	[Address(RVA = "0x811910", Offset = "0x810D10", Length = "0x15E")]
	[Token(Token = "0x600006E")]
	private static void GenericListToMarshallingArray(ref List<T>& srcList, ref T[] dstArray) { }

	[Address(RVA = "0x316C370", Offset = "0x316B770", Length = "0x2A")]
	[NativeMethod(Name = "TextCore::FontEngine::GetAllLigatureSubstitutionRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x6000056")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static LigatureSubstitutionRecord[] GetAllLigatureSubstitutionRecords() { }

	[Address(RVA = "0x316C3E0", Offset = "0x316B7E0", Length = "0xD4")]
	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToBaseAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x6000063")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static MarkToBaseAdjustmentRecord[] GetAllMarkToBaseAdjustmentRecords() { }

	[Address(RVA = "0x316C3A0", Offset = "0x316B7A0", Length = "0x33")]
	[Token(Token = "0x600007E")]
	private static void GetAllMarkToBaseAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x316C500", Offset = "0x316B900", Length = "0xD4")]
	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToMarkAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x6000068")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static MarkToMarkAdjustmentRecord[] GetAllMarkToMarkAdjustmentRecords() { }

	[Address(RVA = "0x316C4C0", Offset = "0x316B8C0", Length = "0x33")]
	[Token(Token = "0x6000081")]
	private static void GetAllMarkToMarkAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x316C620", Offset = "0x316BA20", Length = "0xD4")]
	[NativeMethod(Name = "TextCore::FontEngine::GetAllPairAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x600005E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static GlyphPairAdjustmentRecord[] GetAllPairAdjustmentRecords() { }

	[Address(RVA = "0x316C5E0", Offset = "0x316B9E0", Length = "0x33")]
	[Token(Token = "0x600007B")]
	private static void GetAllPairAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x316C740", Offset = "0x316BB40", Length = "0xDC")]
	[Token(Token = "0x6000047")]
	public static FaceInfo GetFaceInfo() { }

	[Address(RVA = "0x316C700", Offset = "0x316BB00", Length = "0x33")]
	[NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x6000048")]
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	[Address(RVA = "0x316C850", Offset = "0x316BC50", Length = "0x68")]
	[Token(Token = "0x6000049")]
	public static String[] GetFontFaces() { }

	[Address(RVA = "0x316C820", Offset = "0x316BC20", Length = "0x2A")]
	[NativeMethod(Name = "TextCore::FontEngine::GetFontFaces", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x600004A")]
	private static String[] GetFontFaces_Internal() { }

	[Address(RVA = "0x316C8C0", Offset = "0x316BCC0", Length = "0x31")]
	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x600004C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static uint GetGlyphIndex(uint unicode) { }

	[Address(RVA = "0x316C900", Offset = "0x316BD00", Length = "0x20C")]
	[Token(Token = "0x600005C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(UInt32[] glyphIndexes) { }

	[Address(RVA = "0x316CC50", Offset = "0x316C050", Length = "0x8A")]
	[Token(Token = "0x6000058")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(List<UInt32> glyphIndexes) { }

	[Address(RVA = "0x316CCE0", Offset = "0x316C0E0", Length = "0x1EE")]
	[Token(Token = "0x6000059")]
	private static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(UInt32[] glyphIndexes) { }

	[Address(RVA = "0x316CB50", Offset = "0x316BF50", Length = "0xF2")]
	[Token(Token = "0x6000057")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint glyphIndex) { }

	[Address(RVA = "0x316CB10", Offset = "0x316BF10", Length = "0x33")]
	[NativeMethod(Name = "TextCore::FontEngine::GetLigatureSubstitutionRecordsFromMarshallingArray", IsFreeFunction = True)]
	[Token(Token = "0x600005B")]
	private static int GetLigatureSubstitutionRecordsFromMarshallingArray(out LigatureSubstitutionRecord[] ligatureSubstitutionRecords) { }

	[Address(RVA = "0x316CFD0", Offset = "0x316C3D0", Length = "0x292")]
	[Token(Token = "0x6000065")]
	private static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(UInt32[] glyphIndexes) { }

	[Address(RVA = "0x316D270", Offset = "0x316C670", Length = "0x8A")]
	[Token(Token = "0x6000064")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(List<UInt32> glyphIndexes) { }

	[Address(RVA = "0x316CF10", Offset = "0x316C310", Length = "0xB4")]
	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToBaseAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	[Token(Token = "0x6000067")]
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray(Span<MarkToBaseAdjustmentRecord> adjustmentRecords) { }

	[Address(RVA = "0x316CED0", Offset = "0x316C2D0", Length = "0x33")]
	[Token(Token = "0x6000080")]
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper adjustmentRecords) { }

	[Address(RVA = "0x316D400", Offset = "0x316C800", Length = "0x8A")]
	[Token(Token = "0x6000069")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(List<UInt32> glyphIndexes) { }

	[Address(RVA = "0x316D490", Offset = "0x316C890", Length = "0x2A4")]
	[Token(Token = "0x600006A")]
	private static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(UInt32[] glyphIndexes) { }

	[Address(RVA = "0x316D340", Offset = "0x316C740", Length = "0xB4")]
	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToMarkAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	[Token(Token = "0x600006C")]
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray(Span<MarkToMarkAdjustmentRecord> adjustmentRecords) { }

	[Address(RVA = "0x316D300", Offset = "0x316C700", Length = "0x33")]
	[Token(Token = "0x6000083")]
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper adjustmentRecords) { }

	[Address(RVA = "0x316D8D0", Offset = "0x316CCD0", Length = "0x20C")]
	[Token(Token = "0x6000060")]
	private static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(UInt32[] glyphIndexes) { }

	[Address(RVA = "0x316D840", Offset = "0x316CC40", Length = "0x8A")]
	[Token(Token = "0x600005F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(List<UInt32> glyphIndexes) { }

	[Address(RVA = "0x316D780", Offset = "0x316CB80", Length = "0xB4")]
	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	[Token(Token = "0x6000062")]
	private static int GetPairAdjustmentRecordsFromMarshallingArray(Span<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords) { }

	[Address(RVA = "0x316D740", Offset = "0x316CB40", Length = "0x33")]
	[Token(Token = "0x600007D")]
	private static int GetPairAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper glyphPairAdjustmentRecords) { }

	[Address(RVA = "0x316DAE0", Offset = "0x316CEE0", Length = "0x3E")]
	[NativeMethod(Name = "TextCore::FontEngine::GetVariantGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x600004B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode) { }

	[Address(RVA = "0x316DB20", Offset = "0x316CF20", Length = "0x95")]
	[Token(Token = "0x600006D")]
	private static void GlyphIndexToMarshallingArray(uint glyphIndex, ref UInt32[] dstArray) { }

	[Address(RVA = "0x316DBC0", Offset = "0x316CFC0", Length = "0x2A")]
	[Token(Token = "0x6000044")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static bool IsColorFontFace() { }

	[Address(RVA = "0x316E730", Offset = "0x316DB30", Length = "0x49")]
	[Token(Token = "0x600003A")]
	public static FontEngineError LoadFontFace(string filePath) { }

	[Address(RVA = "0x316E420", Offset = "0x316D820", Length = "0xD7")]
	[Token(Token = "0x6000040")]
	public static FontEngineError LoadFontFace(string familyName, string styleName, float pointSize) { }

	[Address(RVA = "0x316E500", Offset = "0x316D900", Length = "0xD6")]
	[Token(Token = "0x600003C")]
	public static FontEngineError LoadFontFace(string filePath, float pointSize, int faceIndex) { }

	[Address(RVA = "0x316E5E0", Offset = "0x316D9E0", Length = "0x149")]
	[Token(Token = "0x600003E")]
	public static FontEngineError LoadFontFace(Font font, float pointSize, int faceIndex) { }

	[Address(RVA = "0x316DC30", Offset = "0x316D030", Length = "0x1AD")]
	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	[Token(Token = "0x600003B")]
	private static int LoadFontFace_Internal(string filePath) { }

	[Address(RVA = "0x316DBF0", Offset = "0x316CFF0", Length = "0x33")]
	[Token(Token = "0x6000072")]
	private static int LoadFontFace_Internal_Injected(ref ManagedSpanWrapper filePath) { }

	[Address(RVA = "0x316E040", Offset = "0x316D440", Length = "0xA9")]
	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	[Token(Token = "0x600003F")]
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	[Address(RVA = "0x316DFF0", Offset = "0x316D3F0", Length = "0x50")]
	[Token(Token = "0x6000074")]
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected(IntPtr font, int pointSize, int faceIndex) { }

	[Address(RVA = "0x316DE30", Offset = "0x316D230", Length = "0x1BE")]
	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	[Token(Token = "0x600003D")]
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	[Address(RVA = "0x316DDE0", Offset = "0x316D1E0", Length = "0x50")]
	[Token(Token = "0x6000073")]
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal_Injected(ref ManagedSpanWrapper filePath, int pointSize, int faceIndex) { }

	[Address(RVA = "0x316E150", Offset = "0x316D550", Length = "0x2C4")]
	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	[Token(Token = "0x6000041")]
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	[Address(RVA = "0x316E0F0", Offset = "0x316D4F0", Length = "0x52")]
	[Token(Token = "0x6000075")]
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, int pointSize) { }

	[Address(RVA = "0x316E7D0", Offset = "0x316DBD0", Length = "0xEC")]
	[NativeMethod(Name = "TextCore::FontEngine::PopulateLigatureSubstitutionRecordMarshallingArray", IsFreeFunction = True)]
	[Token(Token = "0x600005A")]
	private static int PopulateLigatureSubstitutionRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[Address(RVA = "0x316E780", Offset = "0x316DB80", Length = "0x42")]
	[Token(Token = "0x6000079")]
	private static int PopulateLigatureSubstitutionRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	[Address(RVA = "0x316E910", Offset = "0x316DD10", Length = "0xEC")]
	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToBaseAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	[Token(Token = "0x6000066")]
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[Address(RVA = "0x316E8C0", Offset = "0x316DCC0", Length = "0x42")]
	[Token(Token = "0x600007F")]
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	[Address(RVA = "0x316EA50", Offset = "0x316DE50", Length = "0xEC")]
	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToMarkAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	[Token(Token = "0x600006B")]
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[Address(RVA = "0x316EA00", Offset = "0x316DE00", Length = "0x42")]
	[Token(Token = "0x6000082")]
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	[Address(RVA = "0x316ECD0", Offset = "0x316E0D0", Length = "0xEC")]
	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	[Token(Token = "0x6000061")]
	private static int PopulatePairAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[Address(RVA = "0x316EBE0", Offset = "0x316DFE0", Length = "0xEC")]
	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = True)]
	[Token(Token = "0x600005D")]
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(UInt32[] glyphIndexes, out int recordCount) { }

	[Address(RVA = "0x316EB90", Offset = "0x316DF90", Length = "0x42")]
	[Token(Token = "0x600007A")]
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	[Address(RVA = "0x316EB40", Offset = "0x316DF40", Length = "0x42")]
	[Token(Token = "0x600007C")]
	private static int PopulatePairAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	[Address(RVA = "0x316EE00", Offset = "0x316E200", Length = "0x8C")]
	[NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = True)]
	[Token(Token = "0x6000070")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static void ResetAtlasTexture(Texture2D texture) { }

	[Address(RVA = "0x316EDC0", Offset = "0x316E1C0", Length = "0x33")]
	[Token(Token = "0x6000084")]
	private static void ResetAtlasTexture_Injected(IntPtr texture) { }

	[Address(RVA = "0x811A70", Offset = "0x810E70", Length = "0xBC")]
	[Token(Token = "0x600006F")]
	private static void SetMarshallingArraySize(ref T[] marshallingArray, int recordCount) { }

	[Address(RVA = "0x316EE90", Offset = "0x316E290", Length = "0x33")]
	[NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x6000051")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static void SetTextureUploadMode(bool shouldUploadImmediately) { }

	[Address(RVA = "0x316FC20", Offset = "0x316F020", Length = "0xAB0")]
	[Token(Token = "0x6000054")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static bool TryAddGlyphsToTexture(List<UInt32> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[Address(RVA = "0x316F850", Offset = "0x316EC50", Length = "0x3CC")]
	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x6000055")]
	private static bool TryAddGlyphsToTexture_Internal(UInt32[] glyphIndex, int padding, GlyphPackingMode packingMode, out GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, out GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	[Address(RVA = "0x316F7E0", Offset = "0x316EBE0", Length = "0x66")]
	[Token(Token = "0x6000078")]
	private static bool TryAddGlyphsToTexture_Internal_Injected(ref ManagedSpanWrapper glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, out BlittableArrayWrapper glyphs, ref int glyphCount) { }

	[Address(RVA = "0x316F1A0", Offset = "0x316E5A0", Length = "0x63B")]
	[Token(Token = "0x6000052")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[Address(RVA = "0x316EF40", Offset = "0x316E340", Length = "0x255")]
	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x6000053")]
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, out GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, out GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	[Address(RVA = "0x316EED0", Offset = "0x316E2D0", Length = "0x61")]
	[Token(Token = "0x6000077")]
	private static bool TryAddGlyphToTexture_Internal_Injected(uint glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, out GlyphMarshallingStruct glyph) { }

	[Address(RVA = "0x3170730", Offset = "0x316FB30", Length = "0x178")]
	[Token(Token = "0x600004F")]
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[Address(RVA = "0x31706E0", Offset = "0x316FAE0", Length = "0x4E")]
	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x6000050")]
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	[Address(RVA = "0x3170900", Offset = "0x316FD00", Length = "0x178")]
	[Token(Token = "0x600004D")]
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[Address(RVA = "0x31708B0", Offset = "0x316FCB0", Length = "0x4E")]
	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x600004E")]
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	[Address(RVA = "0x3170DB0", Offset = "0x31701B0", Length = "0x69")]
	[Token(Token = "0x6000045")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	[Address(RVA = "0x3170AE0", Offset = "0x316FEE0", Length = "0x2C5")]
	[NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = True, IsFreeFunction = True)]
	[Token(Token = "0x6000046")]
	private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef) { }

	[Address(RVA = "0x3170A80", Offset = "0x316FE80", Length = "0x52")]
	[Token(Token = "0x6000076")]
	private static bool TryGetSystemFontReference_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, out FontReference fontRef) { }

	[Address(RVA = "0x3170E50", Offset = "0x3170250", Length = "0x5B")]
	[Token(Token = "0x6000042")]
	public static FontEngineError UnloadFontFace() { }

	[Address(RVA = "0x3170E20", Offset = "0x3170220", Length = "0x2A")]
	[NativeMethod(Name = "TextCore::FontEngine::UnloadFontFace", IsFreeFunction = True)]
	[Token(Token = "0x6000043")]
	private static int UnloadFontFace_Internal() { }

}

