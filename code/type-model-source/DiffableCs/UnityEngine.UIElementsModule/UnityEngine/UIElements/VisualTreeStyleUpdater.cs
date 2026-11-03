namespace UnityEngine.UIElements;

[Token(Token = "0x2000562")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class VisualTreeStyleUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x40011DD")]
	private static readonly string s_Description; //Field offset: 0x0
	[Token(Token = "0x40011DE")]
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011D7")]
	private HashSet<VisualElement> m_ApplyStyleUpdateList; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011D8")]
	private HashSet<VisualElement> m_TransitionPropertyUpdateList; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40011D9")]
	private bool m_IsApplyingStyles; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40011DA")]
	private uint m_Version; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40011DB")]
	private uint m_LastVersion; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40011DC")]
	private VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40011DF")]
	private bool <disposed>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x17000A20")]
	protected private bool disposed
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600273C")]
		 get { } //Length: 5
		[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600273D")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000A1F")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x32ECF50", Offset = "0x32EC350", Length = "0x4F")]
		[Token(Token = "0x6002739")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x32ECDC0", Offset = "0x32EC1C0", Length = "0x9B")]
	[Token(Token = "0x6002741")]
	private static VisualTreeStyleUpdater() { }

	[Address(RVA = "0x32ECE60", Offset = "0x32EC260", Length = "0xE4")]
	[Token(Token = "0x6002740")]
	public VisualTreeStyleUpdater() { }

	[Address(RVA = "0x32EC790", Offset = "0x32EBB90", Length = "0x121")]
	[Token(Token = "0x600273F")]
	private void ApplyStyles() { }

	[Address(RVA = "0x32EC8C0", Offset = "0x32EBCC0", Length = "0x32")]
	[Token(Token = "0x600273E")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600273C")]
	protected bool get_disposed() { }

	[Address(RVA = "0x32ECF50", Offset = "0x32EC350", Length = "0x4F")]
	[Token(Token = "0x6002739")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x32EC900", Offset = "0x32EBD00", Length = "0xB1")]
	[Token(Token = "0x600273A")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600273D")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x32EC9C0", Offset = "0x32EBDC0", Length = "0x3F8")]
	[Token(Token = "0x600273B")]
	public virtual void Update() { }

}

