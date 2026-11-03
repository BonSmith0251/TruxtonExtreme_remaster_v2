namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005AF")]
internal class MeshGenerator : IMeshGenerator, IDisposable
{
	[Token(Token = "0x20005B1")]
	internal struct BackgroundRepeatInstance
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013E9")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40013EA")]
		public Rect backgroundRepeatRect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40013EB")]
		public Rect uv; //Field offset: 0x20

	}

	[Token(Token = "0x20005B2")]
	internal struct BorderParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013EC")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40013ED")]
		public Color playmodeTintColor; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40013EE")]
		public Color leftColor; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40013EF")]
		public Color topColor; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40013F0")]
		public Color rightColor; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40013F1")]
		public Color bottomColor; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40013F2")]
		public float leftWidth; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x40013F3")]
		public float topWidth; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40013F4")]
		public float rightWidth; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40013F5")]
		public float bottomWidth; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40013F6")]
		public Vector2 topLeftRadius; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40013F7")]
		public Vector2 topRightRadius; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40013F8")]
		public Vector2 bottomRightRadius; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40013F9")]
		public Vector2 bottomLeftRadius; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40013FA")]
		internal ColorPage leftColorPage; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40013FB")]
		internal ColorPage topColorPage; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40013FC")]
		internal ColorPage rightColorPage; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40013FD")]
		internal ColorPage bottomColorPage; //Field offset: 0xA8

		[Address(RVA = "0x32F18A0", Offset = "0x32F0CA0", Length = "0x11A")]
		[Token(Token = "0x6002903")]
		internal void ToNativeParams(out NativeBorderParams nativeBorderParams) { }

	}

	[Token(Token = "0x20005B3")]
	internal struct RectangleParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013FE")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40013FF")]
		public Rect uv; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001400")]
		public Color color; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001401")]
		public Rect subRect; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001402")]
		public Rect backgroundRepeatRect; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001403")]
		public NativePagedList<BackgroundRepeatInstance> backgroundRepeatInstanceList; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4001404")]
		public int backgroundRepeatInstanceListStartIndex; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4001405")]
		public int backgroundRepeatInstanceListEndIndex; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4001406")]
		public BackgroundPosition backgroundPositionX; //Field offset: 0x60
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4001407")]
		public BackgroundPosition backgroundPositionY; //Field offset: 0x6C
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4001408")]
		public BackgroundRepeat backgroundRepeat; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4001409")]
		public BackgroundSize backgroundSize; //Field offset: 0x80
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400140A")]
		public Texture texture; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400140B")]
		public Sprite sprite; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400140C")]
		public VectorImage vectorImage; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400140D")]
		public ScaleMode scaleMode; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB4")]
		[Token(Token = "0x400140E")]
		public Color playmodeTintColor; //Field offset: 0xB4
		[FieldOffset(Offset = "0xC4")]
		[Token(Token = "0x400140F")]
		public Vector2 topLeftRadius; //Field offset: 0xC4
		[FieldOffset(Offset = "0xCC")]
		[Token(Token = "0x4001410")]
		public Vector2 topRightRadius; //Field offset: 0xCC
		[FieldOffset(Offset = "0xD4")]
		[Token(Token = "0x4001411")]
		public Vector2 bottomRightRadius; //Field offset: 0xD4
		[FieldOffset(Offset = "0xDC")]
		[Token(Token = "0x4001412")]
		public Vector2 bottomLeftRadius; //Field offset: 0xDC
		[FieldOffset(Offset = "0xE4")]
		[Token(Token = "0x4001413")]
		public Vector2 contentSize; //Field offset: 0xE4
		[FieldOffset(Offset = "0xEC")]
		[Token(Token = "0x4001414")]
		public Vector2 textureSize; //Field offset: 0xEC
		[FieldOffset(Offset = "0xF4")]
		[Token(Token = "0x4001415")]
		public int leftSlice; //Field offset: 0xF4
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4001416")]
		public int topSlice; //Field offset: 0xF8
		[FieldOffset(Offset = "0xFC")]
		[Token(Token = "0x4001417")]
		public int rightSlice; //Field offset: 0xFC
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x4001418")]
		public int bottomSlice; //Field offset: 0x100
		[FieldOffset(Offset = "0x104")]
		[Token(Token = "0x4001419")]
		public float sliceScale; //Field offset: 0x104
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x400141A")]
		internal Rect spriteGeomRect; //Field offset: 0x108
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x400141B")]
		public Vector4 rectInset; //Field offset: 0x118
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x400141C")]
		internal ColorPage colorPage; //Field offset: 0x128
		[FieldOffset(Offset = "0x130")]
		[Token(Token = "0x400141D")]
		internal MeshFlags meshFlags; //Field offset: 0x130

		[Address(RVA = "0x32FF020", Offset = "0x32FE420", Length = "0x615")]
		[Token(Token = "0x6002905")]
		private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) { }

		[Address(RVA = "0x32FF640", Offset = "0x32FEA40", Length = "0x27D")]
		[Token(Token = "0x6002904")]
		private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) { }

		[Address(RVA = "0x32FF8C0", Offset = "0x32FECC0", Length = "0x137")]
		[Token(Token = "0x6002909")]
		private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation) { }

		[Address(RVA = "0x32FFA00", Offset = "0x32FEE00", Length = "0x10C")]
		[Token(Token = "0x6002907")]
		private static Rect ComputeGeomRect(Sprite sprite) { }

		[Address(RVA = "0x32FFB10", Offset = "0x32FEF10", Length = "0x10C")]
		[Token(Token = "0x6002908")]
		private static Rect ComputeUVRect(Sprite sprite) { }

		[Address(RVA = "0x32FFC20", Offset = "0x32FF020", Length = "0x73")]
		[Token(Token = "0x600290D")]
		internal bool HasRadius(float epsilon) { }

		[Address(RVA = "0x32FFCA0", Offset = "0x32FF0A0", Length = "0x45")]
		[Token(Token = "0x600290E")]
		internal bool HasSlices(float epsilon) { }

		[Address(RVA = "0x32FFCF0", Offset = "0x32FF0F0", Length = "0xFA7")]
		[Token(Token = "0x600290B")]
		public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, Color playModeTintColor, bool hasRadius, ref Vector4 slices, bool useForRepeat = false) { }

		[Address(RVA = "0x3300CA0", Offset = "0x33000A0", Length = "0x246")]
		[Token(Token = "0x600290A")]
		public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, Color playModeTintColor) { }

		[Address(RVA = "0x3300EF0", Offset = "0x33002F0", Length = "0x1BE")]
		[Token(Token = "0x600290C")]
		public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, Color playModeTintColor) { }

		[Address(RVA = "0x33010B0", Offset = "0x33004B0", Length = "0x295")]
		[Token(Token = "0x6002906")]
		internal static Rect RectIntersection(Rect a, Rect b) { }

		[Address(RVA = "0x3301350", Offset = "0x3300750", Length = "0x176")]
		[Token(Token = "0x600290F")]
		internal void ToNativeParams(out NativeRectParams nativeRectParams) { }

	}

	[Token(Token = "0x20005B0")]
	private struct RepeatRectUV
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40013E7")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40013E8")]
		public Rect uv; //Field offset: 0x10

	}

	[Token(Token = "0x20005B5")]
	private struct TessellationJob : IJobParallelFor
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x4001422")]
		public TempMeshAllocator allocator; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x4001423")]
		public NativeSlice<TessellationJobParameters> jobParameters; //Field offset: 0x8

		[Address(RVA = "0x3313B90", Offset = "0x3312F90", Length = "0x39C")]
		[Token(Token = "0x6002912")]
		private void DrawBorder(UnsafeMeshGenerationNode node, ref BorderParams borderParams) { }

		[Address(RVA = "0x3313F30", Offset = "0x3313330", Length = "0xB30")]
		[Token(Token = "0x6002913")]
		private void DrawRectangle(UnsafeMeshGenerationNode node, ref NativeRectParams rectParams, Texture tex) { }

		[Address(RVA = "0x3314A70", Offset = "0x3313E70", Length = "0x57C")]
		[Token(Token = "0x6002914")]
		private void DrawSprite(UnsafeMeshGenerationNode node, ref NativeRectParams rectParams, Sprite sprite) { }

		[Address(RVA = "0x3314FF0", Offset = "0x33143F0", Length = "0x703")]
		[Token(Token = "0x6002915")]
		private void DrawVectorImage(UnsafeMeshGenerationNode node, ref NativeRectParams rectParams, VectorImage vi) { }

		[Address(RVA = "0x3315700", Offset = "0x3314B00", Length = "0x231")]
		[Token(Token = "0x6002910")]
		public override void Execute(int i) { }

		[Address(RVA = "0x9F9E20", Offset = "0x9F9220", Length = "0x89")]
		[Token(Token = "0x6002911")]
		private T ExtractHandle(IntPtr handlePtr) { }

	}

	[Token(Token = "0x20005B4")]
	private struct TessellationJobParameters
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400141E")]
		public bool isBorderJob; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400141F")]
		public NativeRectParams rectParams; //Field offset: 0x8
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x4001420")]
		public BorderParams borderParams; //Field offset: 0x120
		[FieldOffset(Offset = "0x1D0")]
		[Token(Token = "0x4001421")]
		public UnsafeMeshGenerationNode node; //Field offset: 0x1D0

	}

	[Token(Token = "0x40013D1")]
	private static readonly MemoryLabel k_MemoryLabel; //Field offset: 0x0
	[Token(Token = "0x40013D2")]
	private static readonly ProfilerMarker k_MarkerDrawRectangle; //Field offset: 0x10
	[Token(Token = "0x40013D3")]
	private static readonly ProfilerMarker k_MarkerDrawBorder; //Field offset: 0x18
	[Token(Token = "0x40013D4")]
	private static readonly ProfilerMarker k_MarkerDrawVectorImage; //Field offset: 0x20
	[Token(Token = "0x40013D5")]
	private static readonly ProfilerMarker k_MarkerDrawRectangleRepeat; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013D6")]
	private MeshGenerationContext m_MeshGenerationContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013D7")]
	private List<RepeatRectUV>[] m_RepeatRectUVList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013D8")]
	private NativePagedList<BackgroundRepeatInstance> m_BackgroundRepeatInstanceList; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013D9")]
	private GCHandlePool m_GCHandlePool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013DA")]
	private NativeArray<TessellationJobParameters> m_JobParameters; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40013DB")]
	private VisualElement <currentElement>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40013DC")]
	private TextJobSystem <textJobSystem>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40013DD")]
	private TextInfo m_TextInfo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40013DE")]
	private TextGenerationSettings m_Settings; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40013DF")]
	private List<NativeSlice`1<Vertex>> m_VerticesArray; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40013E0")]
	private List<NativeSlice`1<UInt16>> m_IndicesArray; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40013E1")]
	private List<Texture2D> m_Atlases; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40013E2")]
	private List<Single> m_SdfScales; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40013E3")]
	private List<GlyphRenderMode> m_RenderModes; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40013E4")]
	private MeshGenerationCallback m_OnMeshGenerationDelegate; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40013E5")]
	private List<TessellationJobParameters> m_TesselationJobParameters; //Field offset: 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40013E6")]
	private bool <disposed>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x17000A51")]
	public override VisualElement currentElement
	{
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60028EC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000A53")]
	internal bool disposed
	{
		[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60028FE")]
		internal get { } //Length: 8
		[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60028FF")]
		private set { } //Length: 7
	}

	[Token(Token = "0x17000A52")]
	public override TextJobSystem textJobSystem
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60028ED")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60028EE")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x32FE5D0", Offset = "0x32FD9D0", Length = "0x16B")]
	[Token(Token = "0x6002902")]
	private static MeshGenerator() { }

	[Address(RVA = "0x32FE740", Offset = "0x32FDB40", Length = "0x4B5")]
	[Token(Token = "0x60028EB")]
	public MeshGenerator(MeshGenerationContext mgc) { }

	[Address(RVA = "0x32F8EE0", Offset = "0x32F82E0", Length = "0x3C1")]
	[Token(Token = "0x60028F1")]
	public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref RectangleParams rectParams) { }

	[Address(RVA = "0x32F92B0", Offset = "0x32F86B0", Length = "0x3EE")]
	[Token(Token = "0x60028FB")]
	private static void AdjustSpriteWinding(Vector2[] vertices, UInt16[] indices, NativeSlice<UInt16> newIndices) { }

	[Address(RVA = "0x32F96A0", Offset = "0x32F8AA0", Length = "0x5D")]
	[Token(Token = "0x60028EF")]
	private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length) { }

	[Address(RVA = "0x329D5F0", Offset = "0x329C9F0", Length = "0x1A1")]
	[Token(Token = "0x60028F4")]
	internal static Vertex ConvertTextVertexToUIRVertex(ref TextCoreVertex vertex, Vector2 posOffset, float inverseScale, bool isDynamicColor = false, bool isColorGlyph = false) { }

	[Address(RVA = "0x32F9700", Offset = "0x32F8B00", Length = "0xBD")]
	[Token(Token = "0x6002900")]
	public override void Dispose() { }

	[Address(RVA = "0x32F97C0", Offset = "0x32F8BC0", Length = "0x94")]
	[Token(Token = "0x6002901")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x32F9860", Offset = "0x32F8C60", Length = "0x269B")]
	[Token(Token = "0x60028F9")]
	private void DoDrawRectangleRepeat(ref RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	[Address(RVA = "0x32FBF00", Offset = "0x32FB300", Length = "0x265")]
	[Token(Token = "0x60028F7")]
	public override void DrawBorder(BorderParams borderParams) { }

	[Address(RVA = "0x32FC1A0", Offset = "0x32FB5A0", Length = "0xBD7")]
	[Token(Token = "0x60028F6")]
	public override void DrawRectangle(RectangleParams rectParams) { }

	[Address(RVA = "0x32FC170", Offset = "0x32FB570", Length = "0x25")]
	[Token(Token = "0x60028F8")]
	public override void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	[Address(RVA = "0x32FCD80", Offset = "0x32FC180", Length = "0x2D9")]
	[Token(Token = "0x60028F3")]
	public override void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Texture2D> atlases, List<GlyphRenderMode> renderModes, List<Single> sdfScales) { }

	[Address(RVA = "0x32FD060", Offset = "0x32FC460", Length = "0x306")]
	[Token(Token = "0x60028F2")]
	public override void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Material> materials, List<GlyphRenderMode> renderModes) { }

	[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60028FE")]
	internal bool get_disposed() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60028ED")]
	public override TextJobSystem get_textJobSystem() { }

	[Address(RVA = "0x32FD370", Offset = "0x32FC770", Length = "0x2AA")]
	[Token(Token = "0x60028F0")]
	public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight) { }

	[Address(RVA = "0x32FD620", Offset = "0x32FCA20", Length = "0x147")]
	[Token(Token = "0x60028F5")]
	private void MakeText(Texture texture, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, bool isSdf, float sdfScale, float sharpness, bool multiChannel) { }

	[Address(RVA = "0x32FD770", Offset = "0x32FCB70", Length = "0x56")]
	[Token(Token = "0x60028FD")]
	private void OnMeshGeneration(MeshGenerationContext ctx, object data) { }

	[Address(RVA = "0x32FD7D0", Offset = "0x32FCBD0", Length = "0x390")]
	[Token(Token = "0x60028FC")]
	public override void ScheduleJobs(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60028EC")]
	public override void set_currentElement(VisualElement value) { }

	[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x60028FF")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60028EE")]
	public override void set_textJobSystem(TextJobSystem value) { }

	[Address(RVA = "0x32FDB70", Offset = "0x32FCF70", Length = "0xA5A")]
	[Token(Token = "0x60028FA")]
	private void StampRectangleWithSubRect(RectangleParams rectParams, Rect targetRect, Rect totalRect, Rect targetUV, ref NativePagedList<BackgroundRepeatInstance>& backgroundRepeatInstanceList) { }

}

