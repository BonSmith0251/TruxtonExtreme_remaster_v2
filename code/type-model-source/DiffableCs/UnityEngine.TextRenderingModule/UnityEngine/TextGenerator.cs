namespace UnityEngine;

[NativeHeader("Modules/TextRendering/TextGenerator.h")]
[Token(Token = "0x2000005")]
[UsedByNativeCode]
public sealed class TextGenerator : IDisposable
{
	[Token(Token = "0x2000006")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000028")]
		public static IntPtr ConvertToNative(TextGenerator textGenerator) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001D")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001E")]
	private string m_LastString; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001F")]
	private TextGenerationSettings m_LastSettings; //Field offset: 0x20
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000020")]
	private bool m_HasGenerated; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000021")]
	private TextGenerationError m_LastValid; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000022")]
	private readonly List<UIVertex> m_Verts; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000023")]
	private readonly List<UICharInfo> m_Characters; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000024")]
	private readonly List<UILineInfo> m_Lines; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000025")]
	private bool m_CachedVerts; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA1")]
	[Token(Token = "0x4000026")]
	private bool m_CachedCharacters; //Field offset: 0xA1
	[FieldOffset(Offset = "0xA2")]
	[Token(Token = "0x4000027")]
	private bool m_CachedLines; //Field offset: 0xA2

	[Token(Token = "0x17000006")]
	public int characterCount
	{
		[Address(RVA = "0x31CD800", Offset = "0x31CCC00", Length = "0x51")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000001")]
	public int characterCountVisible
	{
		[Address(RVA = "0x31CD760", Offset = "0x31CCB60", Length = "0x53")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 83
	}

	[Token(Token = "0x17000003")]
	public IList<UICharInfo> characters
	{
		[Address(RVA = "0x31CD860", Offset = "0x31CCC60", Length = "0x85")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 133
	}

	[Token(Token = "0x17000007")]
	public int lineCount
	{
		[Address(RVA = "0x31CD930", Offset = "0x31CCD30", Length = "0x51")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000004")]
	public IList<UILineInfo> lines
	{
		[Address(RVA = "0x31CD990", Offset = "0x31CCD90", Length = "0x85")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 133
	}

	[Token(Token = "0x17000005")]
	public Rect rectExtents
	{
		[Address(RVA = "0x31CDA70", Offset = "0x31CCE70", Length = "0x69")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 105
	}

	[Token(Token = "0x17000002")]
	public IList<UIVertex> verts
	{
		[Address(RVA = "0x31CDAE0", Offset = "0x31CCEE0", Length = "0x85")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 133
	}

	[Address(RVA = "0x31CD610", Offset = "0x31CCA10", Length = "0x149")]
	[Token(Token = "0x6000004")]
	public TextGenerator() { }

	[Address(RVA = "0x31CD4B0", Offset = "0x31CC8B0", Length = "0x155")]
	[Token(Token = "0x6000005")]
	public TextGenerator(int initialCapacity) { }

	[Address(RVA = "0x31CBB60", Offset = "0x31CAF60", Length = "0xDE")]
	[Token(Token = "0x6000006")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x31CD800", Offset = "0x31CCC00", Length = "0x51")]
	[Token(Token = "0x6000018")]
	public int get_characterCount() { }

	[Address(RVA = "0x31CD7C0", Offset = "0x31CCBC0", Length = "0x33")]
	[Token(Token = "0x6000022")]
	private static int get_characterCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CD760", Offset = "0x31CCB60", Length = "0x53")]
	[Token(Token = "0x6000008")]
	public int get_characterCountVisible() { }

	[Address(RVA = "0x31CD860", Offset = "0x31CCC60", Length = "0x85")]
	[Token(Token = "0x6000015")]
	public IList<UICharInfo> get_characters() { }

	[Address(RVA = "0x31CD930", Offset = "0x31CCD30", Length = "0x51")]
	[Token(Token = "0x6000019")]
	public int get_lineCount() { }

	[Address(RVA = "0x31CD8F0", Offset = "0x31CCCF0", Length = "0x33")]
	[Token(Token = "0x6000023")]
	private static int get_lineCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31CD990", Offset = "0x31CCD90", Length = "0x85")]
	[Token(Token = "0x6000016")]
	public IList<UILineInfo> get_lines() { }

	[Address(RVA = "0x31CDA70", Offset = "0x31CCE70", Length = "0x69")]
	[Token(Token = "0x6000017")]
	public Rect get_rectExtents() { }

	[Address(RVA = "0x31CDA20", Offset = "0x31CCE20", Length = "0x42")]
	[Token(Token = "0x6000021")]
	private static void get_rectExtents_Injected(IntPtr _unity_self, out Rect ret) { }

	[Address(RVA = "0x31CDAE0", Offset = "0x31CCEE0", Length = "0x85")]
	[Token(Token = "0x6000014")]
	public IList<UIVertex> get_verts() { }

	[Address(RVA = "0x31CBC90", Offset = "0x31CB090", Length = "0x5A")]
	[Token(Token = "0x600000B")]
	public void GetCharacters(List<UICharInfo> characters) { }

	[Address(RVA = "0x31CBC90", Offset = "0x31CB090", Length = "0x5A")]
	[NativeThrows]
	[Token(Token = "0x600001F")]
	private void GetCharactersInternal(object characters) { }

	[Address(RVA = "0x31CBC40", Offset = "0x31CB040", Length = "0x42")]
	[Token(Token = "0x6000026")]
	private static void GetCharactersInternal_Injected(IntPtr _unity_self, object characters) { }

	[Address(RVA = "0x31CBD40", Offset = "0x31CB140", Length = "0x5A")]
	[Token(Token = "0x600000C")]
	public void GetLines(List<UILineInfo> lines) { }

	[Address(RVA = "0x31CBD40", Offset = "0x31CB140", Length = "0x5A")]
	[NativeThrows]
	[Token(Token = "0x6000020")]
	private void GetLinesInternal(object lines) { }

	[Address(RVA = "0x31CBCF0", Offset = "0x31CB0F0", Length = "0x42")]
	[Token(Token = "0x6000027")]
	private static void GetLinesInternal_Injected(IntPtr _unity_self, object lines) { }

	[Address(RVA = "0x31CBDA0", Offset = "0x31CB1A0", Length = "0x10B")]
	[Token(Token = "0x600000F")]
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	[Address(RVA = "0x31CBEB0", Offset = "0x31CB2B0", Length = "0x112")]
	[Token(Token = "0x600000E")]
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	[Address(RVA = "0x31CC020", Offset = "0x31CB420", Length = "0x5A")]
	[Token(Token = "0x600000D")]
	public void GetVertices(List<UIVertex> vertices) { }

	[Address(RVA = "0x31CC020", Offset = "0x31CB420", Length = "0x5A")]
	[NativeThrows]
	[Token(Token = "0x600001E")]
	private void GetVerticesInternal(object vertices) { }

	[Address(RVA = "0x31CBFD0", Offset = "0x31CB3D0", Length = "0x42")]
	[Token(Token = "0x6000025")]
	private static void GetVerticesInternal_Injected(IntPtr _unity_self, object vertices) { }

	[Address(RVA = "0x31CC080", Offset = "0x31CB480", Length = "0x2A")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600001A")]
	private static IntPtr Internal_Create() { }

	[Address(RVA = "0x31CC0B0", Offset = "0x31CB4B0", Length = "0x33")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600001B")]
	private static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x31CC0F0", Offset = "0x31CB4F0", Length = "0x8")]
	[Token(Token = "0x600000A")]
	public void Invalidate() { }

	[Address(RVA = "0x31CD0B0", Offset = "0x31CC4B0", Length = "0x58")]
	[Token(Token = "0x6000011")]
	public bool Populate(string str, TextGenerationSettings settings) { }

	[Address(RVA = "0x31CCD50", Offset = "0x31CC150", Length = "0x35C")]
	[Token(Token = "0x600001C")]
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	[Address(RVA = "0x31CCB60", Offset = "0x31CBF60", Length = "0x1ED")]
	[Token(Token = "0x600001D")]
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[Address(RVA = "0x31CCAA0", Offset = "0x31CBEA0", Length = "0xB7")]
	[Token(Token = "0x6000024")]
	private static bool Populate_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper str, IntPtr font, in Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	[Address(RVA = "0x31CC100", Offset = "0x31CB500", Length = "0x367")]
	[Token(Token = "0x6000013")]
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	[Address(RVA = "0x31CC470", Offset = "0x31CB870", Length = "0x40A")]
	[Token(Token = "0x6000012")]
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	[Address(RVA = "0x31CC880", Offset = "0x31CBC80", Length = "0x21E")]
	[Token(Token = "0x6000010")]
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	[Address(RVA = "0x31CD110", Offset = "0x31CC510", Length = "0x50")]
	[Token(Token = "0x6000007")]
	private override void System.IDisposable.Dispose() { }

	[Address(RVA = "0x31CD160", Offset = "0x31CC560", Length = "0x34F")]
	[Token(Token = "0x6000009")]
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

}

