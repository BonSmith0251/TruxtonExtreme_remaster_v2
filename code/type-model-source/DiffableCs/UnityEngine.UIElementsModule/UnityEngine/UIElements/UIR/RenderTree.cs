namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005C5")]
internal class RenderTree
{
	[Flags]
	[Token(Token = "0x20005C6")]
	public enum AllowedClasses : int
	{
		Clipping = 1,
		Opacity = 2,
		Color = 4,
		TransformSize = 8,
		Visuals = 16,
		All = 31,
	}

	[Token(Token = "0x40014A9")]
	private static readonly ProfilerMarker k_MarkerClipProcessing; //Field offset: 0x0
	[Token(Token = "0x40014AA")]
	private static readonly ProfilerMarker k_MarkerOpacityProcessing; //Field offset: 0x8
	[Token(Token = "0x40014AB")]
	private static readonly ProfilerMarker k_MarkerColorsProcessing; //Field offset: 0x10
	[Token(Token = "0x40014AC")]
	private static readonly ProfilerMarker k_MarkerTransformProcessing; //Field offset: 0x18
	[Token(Token = "0x40014AD")]
	private static readonly ProfilerMarker k_MarkerVisualsProcessing; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400149E")]
	private RenderTreeManager m_RenderTreeManager; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400149F")]
	private DepthOrderedDirtyTracking m_DirtyTracker; //Field offset: 0x18
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40014A0")]
	private RenderChainCommand m_FirstCommand; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40014A1")]
	private RenderData m_RootRenderData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40014A2")]
	public TextureId quadTextureId; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40014A3")]
	public RectInt quadRect; //Field offset: 0x5C
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40014A4")]
	public Rect quadUVRect; //Field offset: 0x6C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40014A5")]
	public GCHandlePool m_GCHandlePool; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40014A6")]
	internal RenderTree parent; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40014A7")]
	internal RenderTree firstChild; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40014A8")]
	internal RenderTree nextSibling; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40014AE")]
	private AllowedClasses m_AllowedDirtyClasses; //Field offset: 0xA0

	[Token(Token = "0x17000A64")]
	internal DepthOrderedDirtyTracking dirtyTracker
	{
		[Address(RVA = "0x3313B30", Offset = "0x3312F30", Length = "0x7")]
		[Token(Token = "0x6002971")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000A65")]
	internal RenderChainCommand firstCommand
	{
		[Address(RVA = "0x2F944D0", Offset = "0x2F938D0", Length = "0x7")]
		[Token(Token = "0x6002972")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000A66")]
	internal bool isRootRenderTree
	{
		[Address(RVA = "0x3313B40", Offset = "0x3312F40", Length = "0x4E")]
		[Token(Token = "0x6002973")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000A62")]
	internal RenderTreeManager renderTreeManager
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600296F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000A63")]
	internal RenderData rootRenderData
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6002970")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x3313950", Offset = "0x3312D50", Length = "0x14B")]
	[Token(Token = "0x6002980")]
	private static RenderTree() { }

	[Address(RVA = "0x3313AA0", Offset = "0x3312EA0", Length = "0x82")]
	[Token(Token = "0x600297F")]
	public RenderTree() { }

	[Address(RVA = "0x3312B30", Offset = "0x3311F30", Length = "0x9E")]
	[Token(Token = "0x600297E")]
	internal void ChildWillBeRemoved(RenderData renderData) { }

	[Address(RVA = "0x3312BD0", Offset = "0x3311FD0", Length = "0x77")]
	[Token(Token = "0x6002977")]
	private void DepthFirstResetTextures(RenderData renderData) { }

	[Address(RVA = "0x3312C50", Offset = "0x3312050", Length = "0x77")]
	[Token(Token = "0x6002976")]
	public void Dispose() { }

	[Address(RVA = "0x3313B30", Offset = "0x3312F30", Length = "0x7")]
	[Token(Token = "0x6002971")]
	internal DepthOrderedDirtyTracking get_dirtyTracker() { }

	[Address(RVA = "0x2F944D0", Offset = "0x2F938D0", Length = "0x7")]
	[Token(Token = "0x6002972")]
	internal RenderChainCommand get_firstCommand() { }

	[Address(RVA = "0x3313B40", Offset = "0x3312F40", Length = "0x4E")]
	[Token(Token = "0x6002973")]
	internal bool get_isRootRenderTree() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600296F")]
	internal RenderTreeManager get_renderTreeManager() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6002970")]
	internal RenderData get_rootRenderData() { }

	[Address(RVA = "0x3312CD0", Offset = "0x33120D0", Length = "0x1B5")]
	[Token(Token = "0x6002974")]
	public void Init(RenderTreeManager renderTreeManager, RenderData rootRenderData) { }

	[Address(RVA = "0x3312E90", Offset = "0x3312290", Length = "0x2B")]
	[Token(Token = "0x600297C")]
	internal void OnRenderCommandAdded(RenderChainCommand command) { }

	[Address(RVA = "0x3312EC0", Offset = "0x33122C0", Length = "0x34")]
	[Token(Token = "0x600297D")]
	internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) { }

	[Address(RVA = "0x3312F00", Offset = "0x3312300", Length = "0x8B")]
	[Token(Token = "0x6002979")]
	public void OnRenderDataOpacityIdChanged(RenderData renderData) { }

	[Address(RVA = "0x3312F90", Offset = "0x3312390", Length = "0xAB")]
	[Token(Token = "0x6002978")]
	public void OnRenderDataTransformOrSizeChanged(RenderData renderData, bool transformChanged, bool clipRectSizeChanged) { }

	[Address(RVA = "0x3313040", Offset = "0x3312440", Length = "0x9E")]
	[Token(Token = "0x600297A")]
	public void OnRenderDataVisualsChanged(RenderData renderData, bool hierarchical) { }

	[Address(RVA = "0x33130E0", Offset = "0x33124E0", Length = "0x7E6")]
	[Token(Token = "0x600297B")]
	public void ProcessChanges(ref ChainBuilderStats stats) { }

	[Address(RVA = "0x33138D0", Offset = "0x3312CD0", Length = "0x76")]
	[Token(Token = "0x6002975")]
	public void Reset() { }

}

