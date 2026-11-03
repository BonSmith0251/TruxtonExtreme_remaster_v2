namespace UnityEngine.UIElements;

[Token(Token = "0x2000159")]
internal class TabDragger : PointerManipulator
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006D3")]
	private float m_StartPos; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40006D4")]
	private float m_LastPos; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006D5")]
	private bool m_Moving; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x40006D6")]
	private bool m_Cancelled; //Field offset: 0x31
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006D7")]
	private VisualElement m_Header; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006D8")]
	private TabView m_TabView; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006D9")]
	private VisualElement m_PreviewElement; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40006DA")]
	private TabDragLocationPreview m_LocationPreviewElement; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006DB")]
	private VisualElement m_TabToMove; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006DC")]
	private float m_TabToMovePos; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40006DD")]
	private VisualElement m_DestinationTab; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40006DE")]
	private bool m_MoveBeforeDestination; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40006DF")]
	private int m_DraggingPointerId; //Field offset: 0x74
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40006E0")]
	private TabLayout <tabLayout>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40006E1")]
	private bool <active>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x40006E2")]
	private bool <isVertical>k__BackingField; //Field offset: 0x81

	[Token(Token = "0x170001CA")]
	internal bool active
	{
		[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A71")]
		internal get { } //Length: 8
		[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A72")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170001CB")]
	internal bool isVertical
	{
		[Address(RVA = "0x21447B0", Offset = "0x2143BB0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000A73")]
		internal get { } //Length: 8
		[Address(RVA = "0x21449B0", Offset = "0x2143DB0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000A74")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170001CC")]
	internal bool moving
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000A75")]
		internal get { } //Length: 5
		[Address(RVA = "0x33B6420", Offset = "0x33B5820", Length = "0x8C")]
		[Token(Token = "0x6000A76")]
		private set { } //Length: 140
	}

	[Token(Token = "0x170001C9")]
	private TabLayout tabLayout
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A6F")]
		private get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A70")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x33B62F0", Offset = "0x33B56F0", Length = "0x127")]
	[Token(Token = "0x6000A77")]
	public TabDragger() { }

	[Address(RVA = "0x33B3FE0", Offset = "0x33B33E0", Length = "0x5EE")]
	[Token(Token = "0x6000A84")]
	private void BeginDragMove(float pos) { }

	[Address(RVA = "0x33B45D0", Offset = "0x33B39D0", Length = "0xC")]
	[Token(Token = "0x6000A85")]
	private void DragMove(float pos) { }

	[Address(RVA = "0x33B45E0", Offset = "0x33B39E0", Length = "0x22E")]
	[Token(Token = "0x6000A88")]
	private void EndDragMove(bool cancelled) { }

	[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A71")]
	internal bool get_active() { }

	[Address(RVA = "0x21447B0", Offset = "0x2143BB0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000A73")]
	internal bool get_isVertical() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000A75")]
	internal bool get_moving() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A6F")]
	private TabLayout get_tabLayout() { }

	[Address(RVA = "0x33B4810", Offset = "0x33B3C10", Length = "0xCB")]
	[Token(Token = "0x6000A80")]
	private void OnKeyDown(KeyDownEvent e) { }

	[Address(RVA = "0x33B48E0", Offset = "0x33B3CE0", Length = "0x71")]
	[Token(Token = "0x6000A7D")]
	private void OnPointerCancel(PointerCancelEvent evt) { }

	[Address(RVA = "0x33B4960", Offset = "0x33B3D60", Length = "0x5C")]
	[Token(Token = "0x6000A7E")]
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	[Address(RVA = "0x33B49C0", Offset = "0x33B3DC0", Length = "0xAE")]
	[Token(Token = "0x6000A7A")]
	private void OnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0x33B4A70", Offset = "0x33B3E70", Length = "0x18B")]
	[Token(Token = "0x6000A7B")]
	private void OnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0x33B4C00", Offset = "0x33B4000", Length = "0x10F")]
	[Token(Token = "0x6000A7C")]
	private void OnPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x33B4D10", Offset = "0x33B4110", Length = "0xB4")]
	[Token(Token = "0x6000A7F")]
	private void ProcessCancelEvent(EventBase evt, int pointerId) { }

	[Address(RVA = "0x33B4DD0", Offset = "0x33B41D0", Length = "0x27F")]
	[Token(Token = "0x6000A81")]
	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x33B5050", Offset = "0x33B4450", Length = "0x148")]
	[Token(Token = "0x6000A82")]
	private void ProcessMoveEvent(EventBase e, Vector2 localPosition) { }

	[Address(RVA = "0x33B51A0", Offset = "0x33B45A0", Length = "0xBC")]
	[Token(Token = "0x6000A83")]
	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	[Address(RVA = "0x33B5260", Offset = "0x33B4660", Length = "0x2EA")]
	[Token(Token = "0x6000A78")]
	protected virtual void RegisterCallbacksOnTarget() { }

	[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A72")]
	internal void set_active(bool value) { }

	[Address(RVA = "0x21449B0", Offset = "0x2143DB0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000A74")]
	internal void set_isVertical(bool value) { }

	[Address(RVA = "0x33B6420", Offset = "0x33B5820", Length = "0x8C")]
	[Token(Token = "0x6000A76")]
	private void set_moving(bool value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A70")]
	private void set_tabLayout(TabLayout value) { }

	[Address(RVA = "0x33B5550", Offset = "0x33B4950", Length = "0x2E4")]
	[Token(Token = "0x6000A79")]
	protected virtual void UnregisterCallbacksFromTarget() { }

	[Address(RVA = "0x33B5840", Offset = "0x33B4C40", Length = "0x269")]
	[Token(Token = "0x6000A87")]
	private void UpdateMoveLocation() { }

	[Address(RVA = "0x33B5AB0", Offset = "0x33B4EB0", Length = "0x836")]
	[Token(Token = "0x6000A86")]
	private void UpdatePreviewPosition() { }

}

