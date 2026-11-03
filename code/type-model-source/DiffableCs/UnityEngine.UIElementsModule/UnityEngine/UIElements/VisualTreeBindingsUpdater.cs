namespace UnityEngine.UIElements;

[Token(Token = "0x200004B")]
internal class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
{
	[Token(Token = "0x4000158")]
	private static readonly PropertyName s_BindingRequestObjectVEPropertyName; //Field offset: 0x0
	[Token(Token = "0x4000159")]
	private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName; //Field offset: 0x4
	[Token(Token = "0x400015A")]
	private static readonly string s_Description; //Field offset: 0x8
	[Token(Token = "0x400015B")]
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x10
	[Token(Token = "0x400015C")]
	private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker; //Field offset: 0x18
	[Token(Token = "0x400015D")]
	private static ProfilerMarker s_MarkerUpdate; //Field offset: 0x20
	[Token(Token = "0x400015E")]
	private static ProfilerMarker s_MarkerPoll; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400015F")]
	private static bool <disableBindingsThrottling>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000160")]
	private readonly HashSet<VisualElement> m_ElementsWithBindings; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000161")]
	private readonly HashSet<VisualElement> m_ElementsToAdd; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000162")]
	private readonly HashSet<VisualElement> m_ElementsToRemove; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000163")]
	private long m_LastUpdateTime; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000164")]
	private HashSet<VisualElement> m_ElementsToBind; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000165")]
	private Dictionary<Object, Object> <temporaryObjectCache>k__BackingField; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000166")]
	private List<IBinding> updatedBindings; //Field offset: 0x70

	[Token(Token = "0x1700004A")]
	public static bool disableBindingsThrottling
	{
		[Address(RVA = "0x322B6C0", Offset = "0x322AAC0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x600021F")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000049")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x322B710", Offset = "0x322AB10", Length = "0x4F")]
		[Token(Token = "0x600021E")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700004B")]
	public Dictionary<Object, Object> temporaryObjectCache
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000223")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x322B360", Offset = "0x322A760", Length = "0x1BA")]
	[Token(Token = "0x6000230")]
	private static VisualTreeBindingsUpdater() { }

	[Address(RVA = "0x322B520", Offset = "0x322A920", Length = "0x195")]
	[Token(Token = "0x600022F")]
	public VisualTreeBindingsUpdater() { }

	[Address(RVA = "0x3229F20", Offset = "0x3229320", Length = "0x23")]
	[Token(Token = "0x6000229")]
	private long CurrentTime() { }

	[Address(RVA = "0x3229F50", Offset = "0x3229350", Length = "0x20")]
	[Token(Token = "0x600022E")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x322B6C0", Offset = "0x322AAC0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x600021F")]
	public static bool get_disableBindingsThrottling() { }

	[Address(RVA = "0x322B710", Offset = "0x322AB10", Length = "0x4F")]
	[Token(Token = "0x600021E")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000223")]
	public Dictionary<Object, Object> get_temporaryObjectCache() { }

	[Address(RVA = "0x3229F70", Offset = "0x3229370", Length = "0x83")]
	[Token(Token = "0x6000224")]
	public static IBinding GetAdditionalBinding(VisualElement ve) { }

	[Address(RVA = "0x322A000", Offset = "0x3229400", Length = "0x10F")]
	[Token(Token = "0x6000220")]
	private IBinding GetBindingObjectFromElement(VisualElement ve) { }

	[Address(RVA = "0x322A110", Offset = "0x3229510", Length = "0x29")]
	[Token(Token = "0x6000228")]
	protected virtual void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	[Address(RVA = "0x322A140", Offset = "0x3229540", Length = "0xE9")]
	[Token(Token = "0x6000227")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x322A230", Offset = "0x3229630", Length = "0x274")]
	[Token(Token = "0x600022B")]
	public void PerformTrackingOperations() { }

	[Address(RVA = "0x322A4B0", Offset = "0x32298B0", Length = "0xCF")]
	[Token(Token = "0x600022A")]
	public bool ShouldProcessBindings(long startTime) { }

	[Address(RVA = "0x322A6B0", Offset = "0x3229AB0", Length = "0x77")]
	[Token(Token = "0x6000221")]
	private void StartTracking(VisualElement ve) { }

	[Address(RVA = "0x322A580", Offset = "0x3229980", Length = "0x129")]
	[Token(Token = "0x6000225")]
	private void StartTrackingRecursive(VisualElement ve) { }

	[Address(RVA = "0x322A850", Offset = "0x3229C50", Length = "0x77")]
	[Token(Token = "0x6000222")]
	private void StopTracking(VisualElement ve) { }

	[Address(RVA = "0x322A730", Offset = "0x3229B30", Length = "0x119")]
	[Token(Token = "0x6000226")]
	private void StopTrackingRecursive(VisualElement ve) { }

	[Address(RVA = "0x322ADB0", Offset = "0x322A1B0", Length = "0x5A5")]
	[Token(Token = "0x600022C")]
	public virtual void Update() { }

	[Address(RVA = "0x322A8D0", Offset = "0x3229CD0", Length = "0x4D4")]
	[Token(Token = "0x600022D")]
	private void UpdateBindings() { }

}

