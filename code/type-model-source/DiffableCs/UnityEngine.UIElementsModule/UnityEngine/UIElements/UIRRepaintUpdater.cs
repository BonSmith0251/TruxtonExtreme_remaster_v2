namespace UnityEngine.UIElements;

[Token(Token = "0x20002E0")]
internal class UIRRepaintUpdater : BaseVisualTreeUpdater, IPanelRenderer
{
	[Token(Token = "0x4000BB8")]
	private static readonly string s_Description; //Field offset: 0x0
	[Token(Token = "0x4000BB9")]
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BB6")]
	private BaseVisualElementPanel attachedPanel; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BB7")]
	internal RenderTreeManager renderTreeManager; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BBA")]
	private bool m_ForceGammaRendering; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000BBB")]
	private uint m_VertexBudget; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BBC")]
	private TextureSlotCount m_TextureSlotCount; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000BBD")]
	private bool <drawStats>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x45")]
	[Token(Token = "0x4000BBE")]
	private bool <breakBatches>k__BackingField; //Field offset: 0x45
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x46")]
	[Token(Token = "0x4000BBF")]
	private bool <disposed>k__BackingField; //Field offset: 0x46

	[Token(Token = "0x170003EC")]
	public bool breakBatches
	{
		[Address(RVA = "0x22100E0", Offset = "0x220F4E0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60013FE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003ED")]
	protected private bool disposed
	{
		[Address(RVA = "0x340F660", Offset = "0x340EA60", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001410")]
		 get { } //Length: 5
		[Address(RVA = "0x220FE10", Offset = "0x220F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001411")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170003EB")]
	public bool drawStats
	{
		[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60013FD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003E8")]
	public override bool forceGammaRendering
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x60013F7")]
		 get { } //Length: 5
		[Address(RVA = "0x340F6C0", Offset = "0x340EAC0", Length = "0x10")]
		[Token(Token = "0x60013F8")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170003E7")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x340F670", Offset = "0x340EA70", Length = "0x4F")]
		[Token(Token = "0x60013F6")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170003EA")]
	public override TextureSlotCount textureSlotCount
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x60013FB")]
		 get { } //Length: 4
		[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
		[Token(Token = "0x60013FC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003E9")]
	public override uint vertexBudget
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x60013F9")]
		 get { } //Length: 4
		[Address(RVA = "0x340F6D0", Offset = "0x340EAD0", Length = "0x10")]
		[Token(Token = "0x60013FA")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x340F4C0", Offset = "0x340E8C0", Length = "0x103")]
	[Token(Token = "0x6001403")]
	private static UIRRepaintUpdater() { }

	[Address(RVA = "0x340F5D0", Offset = "0x340E9D0", Length = "0x82")]
	[Token(Token = "0x60013F5")]
	public UIRRepaintUpdater() { }

	[Address(RVA = "0x340E370", Offset = "0x340D770", Length = "0x441")]
	[Token(Token = "0x6001406")]
	private void AttachToPanel() { }

	[Address(RVA = "0x340E7C0", Offset = "0x340DBC0", Length = "0x61")]
	[Token(Token = "0x6001402")]
	protected override RenderTreeManager CreateRenderChain() { }

	[Address(RVA = "0x340E830", Offset = "0x340DC30", Length = "0x68")]
	[Token(Token = "0x600140A")]
	private void DestroyRenderChain() { }

	[Address(RVA = "0x340E8A0", Offset = "0x340DCA0", Length = "0x419")]
	[Token(Token = "0x6001407")]
	private void DetachFromPanel() { }

	[Address(RVA = "0x340ECC0", Offset = "0x340E0C0", Length = "0x24")]
	[Token(Token = "0x6001412")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x22100E0", Offset = "0x220F4E0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60013FE")]
	public bool get_breakBatches() { }

	[Address(RVA = "0x340F660", Offset = "0x340EA60", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001410")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1CF2CF0", Offset = "0x1CF20F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60013FD")]
	public bool get_drawStats() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x60013F7")]
	public override bool get_forceGammaRendering() { }

	[Address(RVA = "0x340F670", Offset = "0x340EA70", Length = "0x4F")]
	[Token(Token = "0x60013F6")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x60013FB")]
	public override TextureSlotCount get_textureSlotCount() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x60013F9")]
	public override uint get_vertexBudget() { }

	[Address(RVA = "0x340ECF0", Offset = "0x340E0F0", Length = "0xB7")]
	[Token(Token = "0x6001408")]
	private void InitRenderChain() { }

	[Address(RVA = "0x340EDB0", Offset = "0x340E1B0", Length = "0x1C1")]
	[Token(Token = "0x6001404")]
	private static void OnGraphicsResourcesRecreate(bool recreate) { }

	[Address(RVA = "0x340E830", Offset = "0x340DC30", Length = "0x68")]
	[Token(Token = "0x600140C")]
	private void OnPanelAtlasChanged() { }

	[Address(RVA = "0x340EF80", Offset = "0x340E380", Length = "0x1F")]
	[Token(Token = "0x6001405")]
	private void OnPanelChanged(BaseVisualElementPanel obj) { }

	[Address(RVA = "0x340E830", Offset = "0x340DC30", Length = "0x68")]
	[Token(Token = "0x600140D")]
	private void OnPanelDrawsInCamerasChanged() { }

	[Address(RVA = "0x340EFA0", Offset = "0x340E3A0", Length = "0x60")]
	[Token(Token = "0x600140E")]
	private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

	[Address(RVA = "0x340E830", Offset = "0x340DC30", Length = "0x68")]
	[Token(Token = "0x600140B")]
	private void OnPanelIsFlatChanged() { }

	[Address(RVA = "0x340F010", Offset = "0x340E410", Length = "0x224")]
	[Token(Token = "0x60013FF")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x340F240", Offset = "0x340E640", Length = "0x83")]
	[Token(Token = "0x6001401")]
	public override void Render() { }

	[Address(RVA = "0x340E830", Offset = "0x340DC30", Length = "0x68")]
	[Token(Token = "0x6001409")]
	public override void Reset() { }

	[Address(RVA = "0x340F2D0", Offset = "0x340E6D0", Length = "0xB3")]
	[Token(Token = "0x600140F")]
	private void ResetAllElementsDataRecursive(VisualElement ve) { }

	[Address(RVA = "0x220FE10", Offset = "0x220F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001411")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x340F6C0", Offset = "0x340EAC0", Length = "0x10")]
	[Token(Token = "0x60013F8")]
	public override void set_forceGammaRendering(bool value) { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[Token(Token = "0x60013FC")]
	public override void set_textureSlotCount(TextureSlotCount value) { }

	[Address(RVA = "0x340F6D0", Offset = "0x340EAD0", Length = "0x10")]
	[Token(Token = "0x60013FA")]
	public override void set_vertexBudget(uint value) { }

	[Address(RVA = "0x340F390", Offset = "0x340E790", Length = "0x12A")]
	[Token(Token = "0x6001400")]
	public virtual void Update() { }

}

