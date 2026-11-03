namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200057A")]
internal class CommandList : IDisposable
{
	[Token(Token = "0x400123C")]
	private static readonly MemoryLabel k_MemoryLabel; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400123D")]
	public VisualElement m_Owner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400123E")]
	public UIRenderer m_Renderer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400123F")]
	private readonly IntPtr m_VertexDecl; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001240")]
	private readonly IntPtr m_StencilState; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001241")]
	public MaterialPropertyBlock constantProps; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001242")]
	public GCHandle handle; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001243")]
	public Material m_Material; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001244")]
	public CommandFlags flags; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001245")]
	private List<SerializedCommand> m_Commands; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001246")]
	private Vector4[] m_GpuTextureData; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001247")]
	private NativeList<DrawBufferRange> m_DrawRanges; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001248")]
	private bool <disposed>k__BackingField; //Field offset: 0x68

	[Token(Token = "0x17000A30")]
	protected private bool disposed
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60027D3")]
		 get { } //Length: 5
		[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60027D4")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x32D89A0", Offset = "0x32D7DA0", Length = "0x82")]
	[Token(Token = "0x60027D7")]
	private static CommandList() { }

	[Address(RVA = "0x32D8A30", Offset = "0x32D7E30", Length = "0x1D3")]
	[Token(Token = "0x60027CB")]
	public CommandList(IntPtr vertexDecl, IntPtr stencilState) { }

	[Address(RVA = "0x32D7C50", Offset = "0x32D7050", Length = "0xD0")]
	[Token(Token = "0x60027D1")]
	public void ApplyBatchProps() { }

	[Address(RVA = "0x32D7D30", Offset = "0x32D7130", Length = "0xEC")]
	[Token(Token = "0x60027D0")]
	public void ApplyUserProps(MaterialPropertyBlock userProps) { }

	[Address(RVA = "0x32D7EB0", Offset = "0x32D72B0", Length = "0x74")]
	[Token(Token = "0x60027D5")]
	public override void Dispose() { }

	[Address(RVA = "0x32D7E20", Offset = "0x32D7220", Length = "0x85")]
	[Token(Token = "0x60027D6")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x32D7F30", Offset = "0x32D7330", Length = "0x188")]
	[Token(Token = "0x60027D2")]
	public void DrawRanges(GPUBuffer<UInt16> ib, GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges) { }

	[Address(RVA = "0x32D80C0", Offset = "0x32D74C0", Length = "0x563")]
	[Token(Token = "0x60027CE")]
	public void Execute() { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60027D3")]
	protected bool get_disposed() { }

	[Address(RVA = "0x32D8630", Offset = "0x32D7A30", Length = "0x170")]
	[Token(Token = "0x60027CD")]
	public void Init(VisualElement owner, Material material, CommandFlags commandFlags) { }

	[Address(RVA = "0x32D87B0", Offset = "0x32D7BB0", Length = "0xBE")]
	[Token(Token = "0x60027CC")]
	public void Reset() { }

	[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60027D4")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x32D8870", Offset = "0x32D7C70", Length = "0x12C")]
	[Token(Token = "0x60027CF")]
	public void SetTexture(int name, Texture texture, int gpuDataOffset, Vector4 gpuData0, Vector4 gpuData1) { }

}

