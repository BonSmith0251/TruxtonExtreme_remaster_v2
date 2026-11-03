namespace UnityEngine.UIElements;

[Token(Token = "0x200000D")]
internal sealed class VisualTreeAuthoringUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x400001E")]
	private static readonly ProfilerMarker s_UpdateProfilerMarker; //Field offset: 0x0
	[Token(Token = "0x400001F")]
	private static readonly ProfilerMarker s_UpdateChangeProfilerMarker; //Field offset: 0x8
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000020")]
	private readonly List<IVisualElementChangeProcessor> m_RegisteredProcessors; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000021")]
	private readonly List<IVisualElementChangeProcessor> m_ProcessorRegistrationList; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000022")]
	private readonly List<IVisualElementChangeProcessor> m_ProcessorUnregistrationList; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000023")]
	private BaseVisualElementPanel m_AttachedPanel; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000024")]
	private readonly AuthoringChanges m_Changes1; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000025")]
	private readonly AuthoringChanges m_Changes2; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000026")]
	private AuthoringChanges m_Accumulator; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000027")]
	private AuthoringChanges m_Notifier; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000028")]
	private bool m_AccumulatingChanges; //Field offset: 0x68

	[Token(Token = "0x1700000D")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x32123A0", Offset = "0x32117A0", Length = "0x4E")]
		[Token(Token = "0x6000037")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700000E")]
	private bool shouldUpdate
	{
		[Address(RVA = "0x32123F0", Offset = "0x32117F0", Length = "0x52")]
		[Token(Token = "0x6000038")]
		private get { } //Length: 82
	}

	[Address(RVA = "0x3212160", Offset = "0x3211560", Length = "0x98")]
	[Token(Token = "0x6000040")]
	private static VisualTreeAuthoringUpdater() { }

	[Address(RVA = "0x3212200", Offset = "0x3211600", Length = "0x19D")]
	[Token(Token = "0x6000039")]
	public VisualTreeAuthoringUpdater() { }

	[Address(RVA = "0x3211110", Offset = "0x3210510", Length = "0x3F3")]
	[Token(Token = "0x600003D")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x32123A0", Offset = "0x32117A0", Length = "0x4E")]
	[Token(Token = "0x6000037")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x32123F0", Offset = "0x32117F0", Length = "0x52")]
	[Token(Token = "0x6000038")]
	private bool get_shouldUpdate() { }

	[Address(RVA = "0x3211510", Offset = "0x3210910", Length = "0x311")]
	[Token(Token = "0x600003E")]
	private void OnHierarchyChange(VisualElement ve, HierarchyChangeType type, IReadOnlyList<VisualElement> additionalContext = null) { }

	[Address(RVA = "0x3211830", Offset = "0x3210C30", Length = "0xEB")]
	[Token(Token = "0x600003C")]
	private void OnPanelChanged(BaseVisualElementPanel p) { }

	[Address(RVA = "0x3211920", Offset = "0x3210D20", Length = "0x19B")]
	[Token(Token = "0x600003A")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x3211AC0", Offset = "0x3210EC0", Length = "0x64")]
	[Token(Token = "0x600003F")]
	private void SwapBuffers() { }

	[Address(RVA = "0x3211B30", Offset = "0x3210F30", Length = "0x62E")]
	[Token(Token = "0x600003B")]
	public virtual void Update() { }

}

