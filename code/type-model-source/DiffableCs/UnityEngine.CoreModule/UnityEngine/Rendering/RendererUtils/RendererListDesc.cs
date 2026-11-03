namespace UnityEngine.Rendering.RendererUtils;

[Token(Token = "0x2000409")]
public struct RendererListDesc
{
	[Token(Token = "0x4000DA9")]
	private static readonly ShaderTagId s_EmptyName; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D99")]
	public SortingCriteria sortingCriteria; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000D9A")]
	public PerObjectData rendererConfiguration; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D9B")]
	public RenderQueueRange renderQueueRange; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D9C")]
	public Nullable<RenderStateBlock> stateBlock; //Field offset: 0x10
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D9D")]
	public Shader overrideShader; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000D9E")]
	public Material overrideMaterial; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000D9F")]
	public bool excludeObjectMotionVectors; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000DA0")]
	public int layerMask; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000DA1")]
	public uint renderingLayerMask; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000DA2")]
	private uint <batchLayerMask>k__BackingField; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000DA3")]
	public int overrideMaterialPassIndex; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000DA4")]
	public int overrideShaderPassIndex; //Field offset: 0xA4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000DA5")]
	private CullingResults <cullingResult>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000DA6")]
	private Camera <camera>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000DA7")]
	private ShaderTagId <passName>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000DA8")]
	private ShaderTagId[] <passNames>k__BackingField; //Field offset: 0xC8

	[Token(Token = "0x170004A0")]
	public uint batchLayerMask
	{
		[Address(RVA = "0x25E2B40", Offset = "0x25E1F40", Length = "0x7")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001F24")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170004A2")]
	internal Camera camera
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001F26")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170004A1")]
	internal CullingResults cullingResult
	{
		[Address(RVA = "0x2C7A4E0", Offset = "0x2C798E0", Length = "0xE")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001F25")]
		internal get { } //Length: 14
	}

	[Token(Token = "0x170004A3")]
	internal ShaderTagId passName
	{
		[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001F27")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x170004A4")]
	internal ShaderTagId[] passNames
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001F28")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x30C6B80", Offset = "0x30C5F80", Length = "0x4F")]
	[Token(Token = "0x6001F2B")]
	private static RendererListDesc() { }

	[Address(RVA = "0x30C5FB0", Offset = "0x30C53B0", Length = "0xA93")]
	[Token(Token = "0x6001F2A")]
	public static RendererListParams ConvertToParameters(in RendererListDesc desc) { }

	[Address(RVA = "0x25E2B40", Offset = "0x25E1F40", Length = "0x7")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001F24")]
	public uint get_batchLayerMask() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001F26")]
	internal Camera get_camera() { }

	[Address(RVA = "0x2C7A4E0", Offset = "0x2C798E0", Length = "0xE")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001F25")]
	internal CullingResults get_cullingResult() { }

	[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001F27")]
	internal ShaderTagId get_passName() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001F28")]
	internal ShaderTagId[] get_passNames() { }

	[Address(RVA = "0x30C6A50", Offset = "0x30C5E50", Length = "0x12E")]
	[Token(Token = "0x6001F29")]
	public bool IsValid() { }

}

