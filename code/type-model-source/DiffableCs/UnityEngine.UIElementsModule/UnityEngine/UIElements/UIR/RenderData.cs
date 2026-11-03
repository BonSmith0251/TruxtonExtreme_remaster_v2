namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005C1")]
internal class RenderData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001461")]
	public VisualElement owner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001462")]
	public RenderTree renderTree; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001463")]
	public RenderData parent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001464")]
	public RenderData prevSibling; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001465")]
	public RenderData nextSibling; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001466")]
	public RenderData firstChild; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001467")]
	public RenderData lastChild; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001468")]
	public RenderData groupTransformAncestor; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001469")]
	public RenderData boneTransformAncestor; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400146A")]
	public RenderData prevDirty; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400146B")]
	public RenderData nextDirty; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400146C")]
	public RenderDataFlags flags; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400146D")]
	public int depthInRenderTree; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400146E")]
	public RenderDataDirtyTypes dirtiedValues; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400146F")]
	public uint dirtyID; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001470")]
	public RenderChainCommand firstHeadCommand; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001471")]
	public RenderChainCommand lastHeadCommand; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001472")]
	public RenderChainCommand firstTailCommand; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001473")]
	public RenderChainCommand lastTailCommand; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001474")]
	public bool localFlipsWinding; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x4001475")]
	public bool worldFlipsWinding; //Field offset: 0x99
	[FieldOffset(Offset = "0x9A")]
	[Token(Token = "0x4001476")]
	public bool worldTransformScaleZero; //Field offset: 0x9A
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4001477")]
	public ClipMethod clipMethod; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001478")]
	public int childrenStencilRef; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4001479")]
	public int childrenMaskDepth; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400147A")]
	public MeshHandle headMesh; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400147B")]
	public MeshHandle tailMesh; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400147C")]
	public Matrix4x4 verticesSpace; //Field offset: 0xB8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400147D")]
	public BMPAlloc transformID; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400147E")]
	public BMPAlloc clipRectID; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400147F")]
	public BMPAlloc opacityID; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001480")]
	public BMPAlloc textCoreSettingsID; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4001481")]
	public BMPAlloc colorID; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4001482")]
	public BMPAlloc backgroundColorID; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001483")]
	public BMPAlloc borderLeftColorID; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001484")]
	public BMPAlloc borderTopColorID; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4001485")]
	public BMPAlloc borderRightColorID; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4001486")]
	public BMPAlloc borderBottomColorID; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4001487")]
	public BMPAlloc tintColorID; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4001488")]
	public float compositeOpacity; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4001489")]
	public float backgroundAlpha; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400148A")]
	public BasicNode<GraphicEntry> graphicEntries; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400148B")]
	public bool pendingRepaint; //Field offset: 0x160
	[FieldOffset(Offset = "0x161")]
	[Token(Token = "0x400148C")]
	public bool pendingHierarchicalRepaint; //Field offset: 0x161
	[FieldOffset(Offset = "0x164")]
	[Token(Token = "0x400148D")]
	private Rect m_ClippingRect; //Field offset: 0x164
	[FieldOffset(Offset = "0x174")]
	[Token(Token = "0x400148E")]
	private Rect m_ClippingRectMinusGroup; //Field offset: 0x174
	[FieldOffset(Offset = "0x184")]
	[Token(Token = "0x400148F")]
	private bool m_ClippingRectIsInfinite; //Field offset: 0x184

	[Token(Token = "0x17000A5F")]
	public Rect clippingRect
	{
		[Address(RVA = "0x3305280", Offset = "0x3304680", Length = "0x42")]
		[Token(Token = "0x6002944")]
		 get { } //Length: 66
		[Address(RVA = "0x3305360", Offset = "0x3304760", Length = "0xB")]
		[Token(Token = "0x6002945")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000A61")]
	internal bool clippingRectIsInfinite
	{
		[Address(RVA = "0x33051F0", Offset = "0x33045F0", Length = "0x34")]
		[Token(Token = "0x6002948")]
		internal get { } //Length: 52
		[Address(RVA = "0x3305340", Offset = "0x3304740", Length = "0x7")]
		[Token(Token = "0x6002949")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000A60")]
	public Rect clippingRectMinusGroup
	{
		[Address(RVA = "0x3305230", Offset = "0x3304630", Length = "0x42")]
		[Token(Token = "0x6002946")]
		 get { } //Length: 66
		[Address(RVA = "0x3305350", Offset = "0x3304750", Length = "0xB")]
		[Token(Token = "0x6002947")]
		 set { } //Length: 11
	}

	[Token(Token = "0x17000A5A")]
	public bool hasExtraData
	{
		[Address(RVA = "0x33052D0", Offset = "0x33046D0", Length = "0x9")]
		[Token(Token = "0x600293F")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000A5B")]
	public bool hasExtraMeshes
	{
		[Address(RVA = "0x33052E0", Offset = "0x33046E0", Length = "0x9")]
		[Token(Token = "0x6002940")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000A5E")]
	public bool isClippingRectDirty
	{
		[Address(RVA = "0x33052F0", Offset = "0x33046F0", Length = "0x9")]
		[Token(Token = "0x6002943")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000A58")]
	public bool isGroupTransform
	{
		[Address(RVA = "0x3305300", Offset = "0x3304700", Length = "0x7")]
		[Token(Token = "0x600293D")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000A59")]
	public bool isIgnoringDynamicColorHint
	{
		[Address(RVA = "0x3305310", Offset = "0x3304710", Length = "0x8")]
		[Token(Token = "0x600293E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000A5D")]
	public bool isNestedRenderTreeRoot
	{
		[Address(RVA = "0x3305320", Offset = "0x3304720", Length = "0x9")]
		[Token(Token = "0x6002942")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000A5C")]
	public bool isSubTreeQuad
	{
		[Address(RVA = "0x3305330", Offset = "0x3304730", Length = "0x9")]
		[Token(Token = "0x6002941")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600294D")]
	public RenderData() { }

	[Address(RVA = "0x3303FD0", Offset = "0x33033D0", Length = "0x59")]
	[Token(Token = "0x6002939")]
	public static bool AllocatesID(BMPAlloc alloc) { }

	[Address(RVA = "0x3305280", Offset = "0x3304680", Length = "0x42")]
	[Token(Token = "0x6002944")]
	public Rect get_clippingRect() { }

	[Address(RVA = "0x33051F0", Offset = "0x33045F0", Length = "0x34")]
	[Token(Token = "0x6002948")]
	internal bool get_clippingRectIsInfinite() { }

	[Address(RVA = "0x3305230", Offset = "0x3304630", Length = "0x42")]
	[Token(Token = "0x6002946")]
	public Rect get_clippingRectMinusGroup() { }

	[Address(RVA = "0x33052D0", Offset = "0x33046D0", Length = "0x9")]
	[Token(Token = "0x600293F")]
	public bool get_hasExtraData() { }

	[Address(RVA = "0x33052E0", Offset = "0x33046E0", Length = "0x9")]
	[Token(Token = "0x6002940")]
	public bool get_hasExtraMeshes() { }

	[Address(RVA = "0x33052F0", Offset = "0x33046F0", Length = "0x9")]
	[Token(Token = "0x6002943")]
	public bool get_isClippingRectDirty() { }

	[Address(RVA = "0x3305300", Offset = "0x3304700", Length = "0x7")]
	[Token(Token = "0x600293D")]
	public bool get_isGroupTransform() { }

	[Address(RVA = "0x3305310", Offset = "0x3304710", Length = "0x8")]
	[Token(Token = "0x600293E")]
	public bool get_isIgnoringDynamicColorHint() { }

	[Address(RVA = "0x3305320", Offset = "0x3304720", Length = "0x9")]
	[Token(Token = "0x6002942")]
	public bool get_isNestedRenderTreeRoot() { }

	[Address(RVA = "0x3305330", Offset = "0x3304730", Length = "0x9")]
	[Token(Token = "0x6002941")]
	public bool get_isSubTreeQuad() { }

	[Address(RVA = "0x3304030", Offset = "0x3303430", Length = "0x25A")]
	[Token(Token = "0x600294C")]
	private static void GetLocalClippingRect(VisualElement owner, out Rect localRect) { }

	[Address(RVA = "0x3304290", Offset = "0x3303690", Length = "0x59")]
	[Token(Token = "0x600293A")]
	public static bool InheritsID(BMPAlloc alloc) { }

	[Address(RVA = "0x33042F0", Offset = "0x33036F0", Length = "0x403")]
	[Token(Token = "0x600293B")]
	public void Init() { }

	[Address(RVA = "0x3304700", Offset = "0x3303B00", Length = "0xD4")]
	[Token(Token = "0x600294B")]
	private static Rect IntersectClipRects(Rect rect, Rect parentRect) { }

	[Address(RVA = "0x33047E0", Offset = "0x3303BE0", Length = "0x14B")]
	[Token(Token = "0x600293C")]
	public void Reset() { }

	[Address(RVA = "0x3305360", Offset = "0x3304760", Length = "0xB")]
	[Token(Token = "0x6002945")]
	public void set_clippingRect(Rect value) { }

	[Address(RVA = "0x3305340", Offset = "0x3304740", Length = "0x7")]
	[Token(Token = "0x6002949")]
	internal void set_clippingRectIsInfinite(bool value) { }

	[Address(RVA = "0x3305350", Offset = "0x3304750", Length = "0xB")]
	[Token(Token = "0x6002947")]
	public void set_clippingRectMinusGroup(Rect value) { }

	[Address(RVA = "0x3304930", Offset = "0x3303D30", Length = "0x8BD")]
	[Token(Token = "0x600294A")]
	internal void UpdateClippingRect() { }

}

