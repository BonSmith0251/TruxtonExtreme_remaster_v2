namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000599")]
internal class EntryProcessor
{
	[Token(Token = "0x200059A")]
	private struct MaskMesh
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001350")]
		public NativeSlice<Vertex> vertices; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001351")]
		public NativeSlice<UInt16> indices; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001352")]
		public int indexOffset; //Field offset: 0x20

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400132A")]
	private EntryPreProcessor m_PreProcessor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400132B")]
	private RenderTreeManager m_RenderTreeManager; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400132C")]
	private RenderData m_CurrentRenderData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400132D")]
	private int m_MaskDepth; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400132E")]
	private int m_MaskDepthPopped; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400132F")]
	private int m_MaskDepthPushed; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001330")]
	private int m_StencilRef; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001331")]
	private int m_StencilRefPopped; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001332")]
	private int m_StencilRefPushed; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001333")]
	private BMPAlloc m_ClipRectId; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001334")]
	private BMPAlloc m_ClipRectIdPopped; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001335")]
	private BMPAlloc m_ClipRectIdPushed; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001336")]
	private bool m_IsDrawingMask; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001337")]
	private Stack<MaskMesh> m_MaskMeshes; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001338")]
	private bool m_VertexDataComputed; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001339")]
	private Matrix4x4 m_Transform; //Field offset: 0x6C
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x400133A")]
	private Color32 m_TransformData; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400133B")]
	private Color32 m_OpacityData; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x400133C")]
	private Color32 m_TextCoreSettingsPage; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400133D")]
	private MeshHandle m_Mesh; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400133E")]
	private NativeSlice<Vertex> m_Verts; //Field offset: 0xC0
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400133F")]
	private NativeSlice<UInt16> m_Indices; //Field offset: 0xD0
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4001340")]
	private ushort m_IndexOffset; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x4001341")]
	private int m_AllocVertexCount; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4001342")]
	private int m_AllocIndex; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4001343")]
	private int m_VertsFilled; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4001344")]
	private int m_IndicesFilled; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4001345")]
	private VertexFlags m_RenderType; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4001346")]
	private bool m_RemapUVs; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4001347")]
	private Rect m_AtlasRect; //Field offset: 0xFC
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4001348")]
	private int m_GradientSettingIndexOffset; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001349")]
	private bool m_IsTail; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400134A")]
	private RenderChainCommand m_FirstCommand; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400134B")]
	private RenderChainCommand m_LastCommand; //Field offset: 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400134C")]
	private RenderChainCommand <firstHeadCommand>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400134D")]
	private RenderChainCommand <lastHeadCommand>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400134E")]
	private RenderChainCommand <firstTailCommand>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400134F")]
	private RenderChainCommand <lastTailCommand>k__BackingField; //Field offset: 0x140

	[Token(Token = "0x17000A43")]
	public private RenderChainCommand firstHeadCommand
	{
		[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002876")]
		 get { } //Length: 8
		[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002877")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A45")]
	public private RenderChainCommand firstTailCommand
	{
		[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600287A")]
		 get { } //Length: 8
		[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600287B")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A44")]
	public private RenderChainCommand lastHeadCommand
	{
		[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002878")]
		 get { } //Length: 8
		[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002879")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000A46")]
	public private RenderChainCommand lastTailCommand
	{
		[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600287C")]
		 get { } //Length: 8
		[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600287D")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x32F55D0", Offset = "0x32F49D0", Length = "0x1DF")]
	[Token(Token = "0x600288A")]
	public EntryProcessor() { }

	[Address(RVA = "0x32EE5A0", Offset = "0x32ED9A0", Length = "0x272B")]
	[Token(Token = "0x6002886")]
	private void AppendCommand(RenderChainCommand next) { }

	[Address(RVA = "0x32F2F10", Offset = "0x32F2310", Length = "0x122")]
	[Token(Token = "0x600287F")]
	public void ClearReferences() { }

	[Address(RVA = "0x32F3040", Offset = "0x32F2440", Length = "0x18D")]
	[Token(Token = "0x6002885")]
	private RenderChainCommand CreateMeshDrawCommand(MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture) { }

	[Address(RVA = "0x32F31D0", Offset = "0x32F25D0", Length = "0x4D8")]
	[Token(Token = "0x6002884")]
	private void DrawReverseMask() { }

	[Address(RVA = "0x1CF2E90", Offset = "0x1CF2290", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002876")]
	public RenderChainCommand get_firstHeadCommand() { }

	[Address(RVA = "0x1CF2960", Offset = "0x1CF1D60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600287A")]
	public RenderChainCommand get_firstTailCommand() { }

	[Address(RVA = "0x1CF2970", Offset = "0x1CF1D70", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6002878")]
	public RenderChainCommand get_lastHeadCommand() { }

	[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600287C")]
	public RenderChainCommand get_lastTailCommand() { }

	[Address(RVA = "0x32F36B0", Offset = "0x32F2AB0", Length = "0x2E1")]
	[Token(Token = "0x600287E")]
	public void Init(Entry root, RenderTreeManager renderTreeManager, RenderData renderData) { }

	[Address(RVA = "0x32F39A0", Offset = "0x32F2DA0", Length = "0x235")]
	[Token(Token = "0x6002887")]
	private void ProcessFirstAlloc(List<AllocSize> allocList, ref MeshHandle mesh) { }

	[Address(RVA = "0x32F3BE0", Offset = "0x32F2FE0", Length = "0xCA")]
	[Token(Token = "0x6002880")]
	public void ProcessHead() { }

	[Address(RVA = "0x32F3CB0", Offset = "0x32F30B0", Length = "0xA9C")]
	[Token(Token = "0x6002883")]
	private void ProcessMeshEntry(Entry entry, TextureId textureId) { }

	[Address(RVA = "0x32F4750", Offset = "0x32F3B50", Length = "0x27C")]
	[Token(Token = "0x6002888")]
	private void ProcessNextAlloc() { }

	[Address(RVA = "0x32F49D0", Offset = "0x32F3DD0", Length = "0x90C")]
	[Token(Token = "0x6002882")]
	private void ProcessRange(int first, int last) { }

	[Address(RVA = "0x32F5340", Offset = "0x32F4740", Length = "0x16F")]
	[Token(Token = "0x6002881")]
	public void ProcessTail() { }

	[Address(RVA = "0x290E640", Offset = "0x290DA40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002877")]
	private void set_firstHeadCommand(RenderChainCommand value) { }

	[Address(RVA = "0x290E660", Offset = "0x290DA60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600287B")]
	private void set_firstTailCommand(RenderChainCommand value) { }

	[Address(RVA = "0x22EC5C0", Offset = "0x22EB9C0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002879")]
	private void set_lastHeadCommand(RenderChainCommand value) { }

	[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600287D")]
	private void set_lastTailCommand(RenderChainCommand value) { }

	[Address(RVA = "0x32F54B0", Offset = "0x32F48B0", Length = "0x111")]
	[Token(Token = "0x6002889")]
	private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex>& verts, out NativeSlice<UInt16>& indices, out ushort indexOffset, ref ChainBuilderStats stats) { }

}

