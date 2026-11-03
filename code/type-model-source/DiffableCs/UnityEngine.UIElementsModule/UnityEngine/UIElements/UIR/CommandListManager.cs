namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200057B")]
internal class CommandListManager : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001249")]
	private readonly IntPtr m_VertexDecl; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400124A")]
	private readonly IntPtr m_DefaultStencilState; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400124B")]
	private uint m_CurrentIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400124C")]
	private Stack<CommandList> m_CommandListPool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400124D")]
	private CommandList m_DefaultCommandList; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400124E")]
	private List<CommandList>[] m_CommandListsArray; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400124F")]
	private List<CommandList> m_CurrentFrameCommandLists; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001250")]
	private List<UIRenderer> m_UIRenderersWithDrawCallData; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001251")]
	private TextureSlotCount m_TextureSlotCount; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001252")]
	private bool <disposed>k__BackingField; //Field offset: 0x54

	[Token(Token = "0x17000A31")]
	public CommandList defaultCommandList
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60027D9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000A32")]
	protected private bool disposed
	{
		[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60027DE")]
		 get { } //Length: 5
		[Address(RVA = "0x1CEB110", Offset = "0x1CEA510", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60027DF")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x32D7A50", Offset = "0x32D6E50", Length = "0x1FD")]
	[Token(Token = "0x60027D8")]
	public CommandListManager(IntPtr vertexDecl, IntPtr defaultStencilState) { }

	[Address(RVA = "0x32D70B0", Offset = "0x32D64B0", Length = "0x146")]
	[Token(Token = "0x60027DB")]
	public void AdvanceFrame() { }

	[Address(RVA = "0x32D7200", Offset = "0x32D6600", Length = "0x30")]
	[Token(Token = "0x60027DC")]
	public void BeginSerialize(TextureSlotCount textureSlotCount) { }

	[Address(RVA = "0x32D73C0", Offset = "0x32D67C0", Length = "0x16A")]
	[Token(Token = "0x60027E0")]
	public override void Dispose() { }

	[Address(RVA = "0x32D7240", Offset = "0x32D6640", Length = "0x176")]
	[Token(Token = "0x60027E2")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x32D7530", Offset = "0x32D6930", Length = "0x1EC")]
	[Token(Token = "0x60027DD")]
	public void EndSerialize() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60027D9")]
	public CommandList get_defaultCommandList() { }

	[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60027DE")]
	protected bool get_disposed() { }

	[Address(RVA = "0x32D7720", Offset = "0x32D6B20", Length = "0x172")]
	[Token(Token = "0x60027DA")]
	public CommandList GetOrCreateCommandList(VisualElement owner, Material material, CommandFlags commandFlags) { }

	[Address(RVA = "0x32D78A0", Offset = "0x32D6CA0", Length = "0x1A4")]
	[Token(Token = "0x60027E1")]
	public void ResetUIRendererDrawCallData() { }

	[Address(RVA = "0x1CEB110", Offset = "0x1CEA510", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60027DF")]
	private void set_disposed(bool value) { }

}

