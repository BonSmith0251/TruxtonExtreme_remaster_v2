namespace UnityEngine.UIElements;

[Token(Token = "0x2000560")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class VisualTreeLayoutUpdater : BaseVisualTreeUpdater
{
	[Token(Token = "0x40011CC")]
	private static readonly string s_Description; //Field offset: 0x0
	[Token(Token = "0x40011CD")]
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	[Token(Token = "0x40011CE")]
	private static readonly ProfilerMarker k_ComputeLayoutMarker; //Field offset: 0x10
	[Token(Token = "0x40011CF")]
	private static readonly ProfilerMarker k_UpdateSubTreeMarker; //Field offset: 0x18
	[Token(Token = "0x40011D0")]
	private static readonly ProfilerMarker k_DispatchChangeEventsMarker; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011D1")]
	private List<ValueTuple`3<Rect, Rect, VisualElement>> changeEventsList; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011D2")]
	private List<VisualElement> missedHierarchyChangeEventsList; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40011D3")]
	private TextJobSystem m_TextJobSystem; //Field offset: 0x38

	[Token(Token = "0x17000A1E")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x32EA5E0", Offset = "0x32E99E0", Length = "0x4F")]
		[Token(Token = "0x6002728")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x32EA390", Offset = "0x32E9790", Length = "0x14E")]
	[Token(Token = "0x6002730")]
	private static VisualTreeLayoutUpdater() { }

	[Address(RVA = "0x32EA4E0", Offset = "0x32E98E0", Length = "0xF2")]
	[Token(Token = "0x600272F")]
	public VisualTreeLayoutUpdater() { }

	[Address(RVA = "0x32E8B40", Offset = "0x32E7F40", Length = "0x2CF")]
	[Token(Token = "0x600272D")]
	private void DispatchChangeEvents(List<ValueTuple`3<Rect, Rect, VisualElement>> changeEvents, int currentLayoutPass) { }

	[Address(RVA = "0x32E8E10", Offset = "0x32E8210", Length = "0x310")]
	[Token(Token = "0x600272E")]
	private void DispatchMissedHierarchyChangeEvents(List<VisualElement> missedHierarchyChangeEvents, int currentLayoutPass) { }

	[Address(RVA = "0x32EA5E0", Offset = "0x32E99E0", Length = "0x4F")]
	[Token(Token = "0x6002728")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x32E9130", Offset = "0x32E8530", Length = "0x147")]
	[Token(Token = "0x6002729")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x32E9F10", Offset = "0x32E9310", Length = "0x473")]
	[Token(Token = "0x600272A")]
	public virtual void Update() { }

	[Address(RVA = "0x32E9280", Offset = "0x32E8680", Length = "0x367")]
	[Token(Token = "0x600272B")]
	private static bool UpdateHierarchyDisplayed(VisualElement ve, List<ValueTuple`3<Rect, Rect, VisualElement>> changeEvents, bool inheritedDisplayed = true) { }

	[Address(RVA = "0x32E95F0", Offset = "0x32E89F0", Length = "0x918")]
	[Token(Token = "0x600272C")]
	private void UpdateSubTree(VisualElement ve, List<ValueTuple`3<Rect, Rect, VisualElement>> changeEvents) { }

}

