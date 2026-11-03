namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005C9")]
internal class RenderTreeCompositor : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x20005CC")]
	private sealed class <>c
	{
		[Token(Token = "0x40014D6")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40014D7")]
		public static Func<DrawOperation> <>9__7_0; //Field offset: 0x8

		[Address(RVA = "0x3315A50", Offset = "0x3314E50", Length = "0x67")]
		[Token(Token = "0x60029A2")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60029A3")]
		public <>c() { }

		[Address(RVA = "0x3315990", Offset = "0x3314D90", Length = "0x44")]
		[Token(Token = "0x60029A4")]
		internal DrawOperation <.ctor>b__7_0() { }

	}

	[Token(Token = "0x20005CB")]
	private class DrawOperation
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40014C6")]
		private DrawOperationType m_Type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40014C7")]
		private VisualElement m_VisualElement; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40014C8")]
		private RenderTree m_RenderTree; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40014C9")]
		private PostProcessingPass m_FilterPass; //Field offset: 0x28
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40014CA")]
		private int m_FilterPassIndex; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40014CB")]
		private FilterFunction m_Filter; //Field offset: 0x88
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x40014CC")]
		public RectInt bounds; //Field offset: 0xF8
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x40014CD")]
		public RectInt drawSourceBounds; //Field offset: 0x108
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x40014CE")]
		public Vector4 drawSourceTexOffsets; //Field offset: 0x118
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x40014CF")]
		public AtlasBlock dstAtlasBlock; //Field offset: 0x128
		[FieldOffset(Offset = "0x158")]
		[Token(Token = "0x40014D0")]
		public TextureId dstTextureId; //Field offset: 0x158
		[FieldOffset(Offset = "0x160")]
		[Token(Token = "0x40014D1")]
		public DrawOperation parent; //Field offset: 0x160
		[FieldOffset(Offset = "0x168")]
		[Token(Token = "0x40014D2")]
		public DrawOperation firstChild; //Field offset: 0x168
		[FieldOffset(Offset = "0x170")]
		[Token(Token = "0x40014D3")]
		public DrawOperation lastChild; //Field offset: 0x170
		[FieldOffset(Offset = "0x178")]
		[Token(Token = "0x40014D4")]
		public DrawOperation prevSibling; //Field offset: 0x178
		[FieldOffset(Offset = "0x180")]
		[Token(Token = "0x40014D5")]
		public DrawOperation nextSibling; //Field offset: 0x180

		[Token(Token = "0x17000A6D")]
		public FilterFunction filter
		{
			[Address(RVA = "0x3303910", Offset = "0x3302D10", Length = "0x50")]
			[Token(Token = "0x600299B")]
			 get { } //Length: 80
		}

		[Token(Token = "0x17000A6B")]
		public PostProcessingPass FilterPass
		{
			[Address(RVA = "0x33038D0", Offset = "0x3302CD0", Length = "0x35")]
			[Token(Token = "0x6002999")]
			 get { } //Length: 53
		}

		[Token(Token = "0x17000A6C")]
		public int FilterPassIndex
		{
			[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
			[Token(Token = "0x600299A")]
			 get { } //Length: 7
		}

		[Token(Token = "0x17000A6A")]
		public RenderTree renderTree
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6002998")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000A68")]
		public DrawOperationType type
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x6002996")]
			 get { } //Length: 85
		}

		[Token(Token = "0x17000A69")]
		public VisualElement visualElement
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6002997")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60029A1")]
		public DrawOperation() { }

		[Address(RVA = "0x33034E0", Offset = "0x33028E0", Length = "0xE4")]
		[Token(Token = "0x60029A0")]
		public void AddChild(DrawOperation op) { }

		[Address(RVA = "0x3303910", Offset = "0x3302D10", Length = "0x50")]
		[Token(Token = "0x600299B")]
		public FilterFunction get_filter() { }

		[Address(RVA = "0x33038D0", Offset = "0x3302CD0", Length = "0x35")]
		[Token(Token = "0x6002999")]
		public PostProcessingPass get_FilterPass() { }

		[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
		[Token(Token = "0x600299A")]
		public int get_FilterPassIndex() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6002998")]
		public RenderTree get_renderTree() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6002996")]
		public DrawOperationType get_type() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6002997")]
		public VisualElement get_visualElement() { }

		[Address(RVA = "0x3303660", Offset = "0x3302A60", Length = "0x11A")]
		[Token(Token = "0x600299C")]
		public void Init(VisualElement ve, in PostProcessingPass filterPass, int filterPassIndex, FilterFunction filter) { }

		[Address(RVA = "0x3303780", Offset = "0x3302B80", Length = "0x5F")]
		[Token(Token = "0x600299D")]
		public void Init(RenderTree renderTree) { }

		[Address(RVA = "0x33035D0", Offset = "0x33029D0", Length = "0x82")]
		[Token(Token = "0x600299E")]
		private void InitPointers() { }

		[Address(RVA = "0x33037E0", Offset = "0x3302BE0", Length = "0xE9")]
		[Token(Token = "0x600299F")]
		public void Reset() { }

	}

	[Token(Token = "0x20005CA")]
	private enum DrawOperationType : int
	{
		Undefined = 0,
		RenderTree = 1,
		Effect = 2,
	}

	[Token(Token = "0x40014C0")]
	private static Vector4[] s_UVRects; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40014BB")]
	private readonly RenderTreeManager m_RenderTreeManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40014BC")]
	private DrawOperation m_RootOperation; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014BD")]
	private List<RenderTexture> m_AllocatedTextures; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014BE")]
	private MaterialPropertyBlock m_Block; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014BF")]
	private ObjectPool<DrawOperation> m_DrawOperationPool; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014C1")]
	private bool <disposed>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x17000A67")]
	protected private bool disposed
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002991")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002992")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x330DB90", Offset = "0x330CF90", Length = "0x68")]
	[Token(Token = "0x6002995")]
	private static RenderTreeCompositor() { }

	[Address(RVA = "0x330DC00", Offset = "0x330D000", Length = "0x1E0")]
	[Token(Token = "0x6002984")]
	public RenderTreeCompositor(RenderTreeManager owner) { }

	[Address(RVA = "0x330AC90", Offset = "0x330A090", Length = "0x50F")]
	[Token(Token = "0x6002987")]
	private void AddChildrenOperations_DepthFirst(DrawOperation parentOperation, RenderTree renderTree) { }

	[Address(RVA = "0x330B1A0", Offset = "0x330A5A0", Length = "0x2E6")]
	[Token(Token = "0x600298E")]
	private void ApplyEffectParameters(PostProcessingPass effect, FilterFunction filter, VisualElement source, bool readsGamma) { }

	[Address(RVA = "0x330B490", Offset = "0x330A890", Length = "0x1B1")]
	[Token(Token = "0x600298B")]
	private void AssignTextureIds_DepthFirst(DrawOperation op) { }

	[Address(RVA = "0x330B650", Offset = "0x330AA50", Length = "0xE3")]
	[Token(Token = "0x6002986")]
	private void BuildDrawOperationTree(RenderTree rootRenderTree) { }

	[Address(RVA = "0x330B8C0", Offset = "0x330ACC0", Length = "0x208")]
	[Token(Token = "0x6002990")]
	private void CleanupOperation_PostOrder(DrawOperation op) { }

	[Address(RVA = "0x330B740", Offset = "0x330AB40", Length = "0x174")]
	[Token(Token = "0x600298F")]
	private void CleanupOperationTree() { }

	[Address(RVA = "0x330BB30", Offset = "0x330AF30", Length = "0x24")]
	[Token(Token = "0x6002994")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x330BAD0", Offset = "0x330AED0", Length = "0x5D")]
	[Token(Token = "0x6002993")]
	public override void Dispose() { }

	[Address(RVA = "0x330BB60", Offset = "0x330AF60", Length = "0x1080")]
	[Token(Token = "0x600298D")]
	private void ExecuteDrawOperation_PostOrder(DrawOperation op) { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002991")]
	protected bool get_disposed() { }

	[Address(RVA = "0x330CBF0", Offset = "0x330BFF0", Length = "0xAF")]
	[Token(Token = "0x6002988")]
	private static PostProcessingMargins GetReadMargins(PostProcessingPass effect, FilterFunction func) { }

	[Address(RVA = "0x330CCA0", Offset = "0x330C0A0", Length = "0xAF")]
	[Token(Token = "0x6002989")]
	private static PostProcessingMargins GetWriteMargins(PostProcessingPass effect, FilterFunction func) { }

	[Address(RVA = "0x330CD50", Offset = "0x330C150", Length = "0xC")]
	[Token(Token = "0x600298C")]
	public void RenderNestedPasses() { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002992")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x330DA70", Offset = "0x330CE70", Length = "0x113")]
	[Token(Token = "0x6002985")]
	public void Update(RenderTree rootRenderTree) { }

	[Address(RVA = "0x330CD60", Offset = "0x330C160", Length = "0xD06")]
	[Token(Token = "0x600298A")]
	private void UpdateDrawBounds_PostOrder(DrawOperation op) { }

}

