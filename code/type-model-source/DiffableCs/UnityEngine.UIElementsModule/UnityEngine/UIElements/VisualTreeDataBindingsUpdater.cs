namespace UnityEngine.UIElements;

[Token(Token = "0x200004D")]
internal class VisualTreeDataBindingsUpdater : BaseVisualTreeUpdater
{
	[CompilerGenerated]
	[Token(Token = "0x200004F")]
	private sealed class <>c
	{
		[Token(Token = "0x400017C")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400017D")]
		public static Predicate<VisualElement> <>9__29_0; //Field offset: 0x8

		[Address(RVA = "0x3229E40", Offset = "0x3229240", Length = "0x67")]
		[Token(Token = "0x6000243")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000244")]
		public <>c() { }

		[Address(RVA = "0x3229D30", Offset = "0x3229130", Length = "0x26")]
		[Token(Token = "0x6000245")]
		internal bool <ProcessDataSourceChangedRequests>b__29_0(VisualElement e) { }

	}

	[IsReadOnly]
	[Token(Token = "0x200004E")]
	private struct VersionInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400017A")]
		public readonly object source; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400017B")]
		public readonly long version; //Field offset: 0x8

		[Address(RVA = "0xAEE5A0", Offset = "0xAED9A0", Length = "0x27")]
		[Token(Token = "0x6000242")]
		public VersionInfo(object source, long version) { }

	}

	[Token(Token = "0x400016A")]
	private static readonly ProfilerMarker s_UpdateProfilerMarker; //Field offset: 0x0
	[Token(Token = "0x400016B")]
	private static readonly ProfilerMarker s_ProcessBindingRequestsProfilerMarker; //Field offset: 0x8
	[Token(Token = "0x400016C")]
	private static readonly ProfilerMarker s_ProcessDataSourcesProfilerMarker; //Field offset: 0x10
	[Token(Token = "0x400016D")]
	private static readonly ProfilerMarker s_ShouldUpdateBindingProfilerMarker; //Field offset: 0x18
	[Token(Token = "0x400016E")]
	private static readonly ProfilerMarker s_UpdateBindingProfilerMarker; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400016F")]
	private readonly BindingUpdater m_Updater; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000170")]
	private readonly List<VisualElement> m_BindingRegistrationRequests; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000171")]
	private readonly HashSet<VisualElement> m_DataSourceChangedRequests; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000172")]
	private readonly HashSet<VisualElement> m_RemovedElements; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000173")]
	private readonly List<VisualElement> m_BoundsElement; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000174")]
	private readonly List<VersionInfo> m_VersionChanges; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000175")]
	private readonly HashSet<Object> m_TrackedObjects; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000176")]
	private readonly HashSet<Binding> m_RanUpdate; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000177")]
	private readonly HashSet<Object> m_KnownSources; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000178")]
	private readonly HashSet<Binding> m_DirtyBindings; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000179")]
	private BaseVisualElementPanel m_AttachedPanel; //Field offset: 0x78

	[Token(Token = "0x1700004C")]
	private DataBindingManager bindingManager
	{
		[Address(RVA = "0x322E5F0", Offset = "0x322D9F0", Length = "0x30")]
		[Token(Token = "0x6000231")]
		private get { } //Length: 48
	}

	[Token(Token = "0x1700004D")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x322E630", Offset = "0x322DA30", Length = "0x4B7")]
		[Token(Token = "0x6000232")]
		 get { } //Length: 1207
	}

	[Address(RVA = "0x322E1D0", Offset = "0x322D5D0", Length = "0x14B")]
	[Token(Token = "0x6000241")]
	private static VisualTreeDataBindingsUpdater() { }

	[Address(RVA = "0x322E320", Offset = "0x322D720", Length = "0x2CA")]
	[Token(Token = "0x6000233")]
	public VisualTreeDataBindingsUpdater() { }

	[Address(RVA = "0x322B760", Offset = "0x322AB60", Length = "0x1CE")]
	[Token(Token = "0x6000236")]
	private void CacheAndLogBindingResult(bool appliedOnUiCache, in BindingData bindingData, in BindingResult result) { }

	[Address(RVA = "0x322B930", Offset = "0x322AD30", Length = "0x73")]
	[Token(Token = "0x600023D")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x322E5F0", Offset = "0x322D9F0", Length = "0x30")]
	[Token(Token = "0x6000231")]
	private DataBindingManager get_bindingManager() { }

	[Address(RVA = "0x322E630", Offset = "0x322DA30", Length = "0x4B7")]
	[Token(Token = "0x6000232")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x322B9B0", Offset = "0x322ADB0", Length = "0x16F")]
	[Token(Token = "0x6000239")]
	private ValueTuple<Boolean, Int64> GetDataSourceVersion(object source) { }

	[Address(RVA = "0x322BB20", Offset = "0x322AF20", Length = "0x18A")]
	[Token(Token = "0x600023A")]
	private bool IsPrefix(in PropertyPath prefix, in PropertyPath path) { }

	[Address(RVA = "0x322BCB0", Offset = "0x322B0B0", Length = "0x137")]
	[Token(Token = "0x6000237")]
	private void LogResult(in BindingResult result) { }

	[Address(RVA = "0x322BDF0", Offset = "0x322B1F0", Length = "0x380")]
	[Token(Token = "0x6000234")]
	protected void OnHierarchyChange(VisualElement ve, HierarchyChangeType type, IReadOnlyList<VisualElement> additionalContext = null) { }

	[Address(RVA = "0x322C180", Offset = "0x322B580", Length = "0xEB")]
	[Token(Token = "0x600023C")]
	private void OnPanelChanged(BaseVisualElementPanel p) { }

	[Address(RVA = "0x322C270", Offset = "0x322B670", Length = "0xE3")]
	[Token(Token = "0x6000235")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x322C360", Offset = "0x322B760", Length = "0x187")]
	[Token(Token = "0x600023E")]
	private void ProcessAllBindingRequests() { }

	[Address(RVA = "0x322C4F0", Offset = "0x322B8F0", Length = "0x49")]
	[Token(Token = "0x600023F")]
	private void ProcessBindingRequests(VisualElement element) { }

	[Address(RVA = "0x322C540", Offset = "0x322B940", Length = "0x29D")]
	[Token(Token = "0x600023B")]
	private void ProcessDataSourceChangedRequests() { }

	[Address(RVA = "0x322C7E0", Offset = "0x322BBE0", Length = "0x8AD")]
	[Token(Token = "0x6000240")]
	private void ProcessPropertyChangedEvents(HashSet<Binding> ranUpdate) { }

	[Address(RVA = "0x322D090", Offset = "0x322C490", Length = "0x1139")]
	[Token(Token = "0x6000238")]
	public virtual void Update() { }

}

