namespace UnityEngine.UIElements;

[Token(Token = "0x2000096")]
internal class UIToolkitInteroperabilityBridge
{
	[CompilerGenerated]
	[Token(Token = "0x2000098")]
	private sealed class <>c__DisplayClass37_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002CA")]
		public UIToolkitInteroperabilityBridge <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002CB")]
		public BaseRuntimePanel panel; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000623")]
		public <>c__DisplayClass37_0() { }

		[Address(RVA = "0x34752E0", Offset = "0x34746E0", Length = "0x25")]
		[Token(Token = "0x6000624")]
		internal void <CreatePanelGameObject>b__0() { }

	}

	[Flags]
	[Token(Token = "0x2000097")]
	internal enum EventHandlerTypes : int
	{
		ScreenOverlay = 1,
		WorldSpace = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002B4")]
	private EventSystem m_EventSystem; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002B5")]
	private bool m_OverrideUIToolkitEvents; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002B6")]
	private EventHandlerTypes m_HandlerTypes; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002B7")]
	private LayerMask m_WorldPickingLayers; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002B8")]
	private float m_WorldPickingMaxDistance; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002B9")]
	private bool m_CreateDefaultPanelComponents; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x40002BA")]
	private bool m_Started; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x40002BB")]
	private bool m_Enabled; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x40002BC")]
	private bool m_IsTrackingPanels; //Field offset: 0x2B
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002BD")]
	private GameObject m_WorldSpaceGo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002BE")]
	private readonly HashSet<BaseRuntimePanel> trackedPanels; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002BF")]
	private readonly Dictionary<BaseRuntimePanel, Action> destroyedActions; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002C0")]
	private Settings m_InputSettings; //Field offset: 0x48
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002C1")]
	private bool m_OldOverrideUIToolkitEvents; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40002C2")]
	private EventHandlerTypes m_OldHandlerTypes; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002C3")]
	private bool m_OldCreateDefaultPanelComponents; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40002C4")]
	private bool m_OldDefaultEventCameraIsMainCamera; //Field offset: 0x71
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002C5")]
	private long m_OldEventCamerasHash; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002C6")]
	private List<BaseRuntimePanel> m_PanelsToRemove; //Field offset: 0x80

	[Token(Token = "0x17000198")]
	public internal bool createDefaultPanelComponents
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x600060D")]
		 get { } //Length: 5
		[Address(RVA = "0x3476EA0", Offset = "0x34762A0", Length = "0x48")]
		[Token(Token = "0x600060E")]
		internal set { } //Length: 72
	}

	[Token(Token = "0x17000193")]
	internal EventSystem eventSystem
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000603")]
		internal get { } //Length: 5
		[Address(RVA = "0x3476EF0", Offset = "0x34762F0", Length = "0x7C")]
		[Token(Token = "0x6000604")]
		internal set { } //Length: 124
	}

	[Token(Token = "0x17000195")]
	public internal EventHandlerTypes handlerTypes
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000607")]
		 get { } //Length: 4
		[Address(RVA = "0x3476F70", Offset = "0x3476370", Length = "0x49")]
		[Token(Token = "0x6000608")]
		internal set { } //Length: 73
	}

	[Token(Token = "0x17000194")]
	public internal bool overrideUIToolkitEvents
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000605")]
		 get { } //Length: 5
		[Address(RVA = "0x3476FC0", Offset = "0x34763C0", Length = "0xA")]
		[Token(Token = "0x6000606")]
		internal set { } //Length: 10
	}

	[Token(Token = "0x17000199")]
	private bool shouldTrackPanels
	{
		[Address(RVA = "0x3476E70", Offset = "0x3476270", Length = "0x1A")]
		[Token(Token = "0x600060F")]
		private get { } //Length: 26
	}

	[Token(Token = "0x17000196")]
	public internal int worldPickingLayers
	{
		[Address(RVA = "0x3476E90", Offset = "0x3476290", Length = "0xA")]
		[Token(Token = "0x6000609")]
		 get { } //Length: 10
		[Address(RVA = "0x3476FD0", Offset = "0x34763D0", Length = "0x1D")]
		[Token(Token = "0x600060A")]
		internal set { } //Length: 29
	}

	[Token(Token = "0x17000197")]
	public internal float worldPickingMaxDistance
	{
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[Token(Token = "0x600060B")]
		 get { } //Length: 6
		[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
		[Token(Token = "0x600060C")]
		internal set { } //Length: 6
	}

	[Address(RVA = "0x3476CB0", Offset = "0x34760B0", Length = "0x1B9")]
	[Token(Token = "0x6000622")]
	public UIToolkitInteroperabilityBridge() { }

	[Address(RVA = "0x3475620", Offset = "0x3474A20", Length = "0x1BC")]
	[Token(Token = "0x600061C")]
	private void Apply(PanelInputConfiguration input) { }

	[Address(RVA = "0x3475370", Offset = "0x3474770", Length = "0x18C")]
	[Token(Token = "0x600061E")]
	private void ApplyCameraProperties() { }

	[Address(RVA = "0x3475500", Offset = "0x3474900", Length = "0x46")]
	[Token(Token = "0x600061F")]
	private void ApplyOtherProperties() { }

	[Address(RVA = "0x3475550", Offset = "0x3474950", Length = "0xC6")]
	[Token(Token = "0x600061D")]
	private void ApplyOverrideUIToolkitEvents() { }

	[Address(RVA = "0x34757E0", Offset = "0x3474BE0", Length = "0x306")]
	[Token(Token = "0x6000614")]
	private void CreatePanelGameObject(BaseRuntimePanel panel) { }

	[Address(RVA = "0x3475AF0", Offset = "0x3474EF0", Length = "0x1C5")]
	[Token(Token = "0x6000616")]
	private void CreateWorldSpacePanelGameObject() { }

	[Address(RVA = "0x3475CC0", Offset = "0x34750C0", Length = "0xFA")]
	[Token(Token = "0x6000615")]
	private void DestroyPanelGameObject(BaseRuntimePanel panel) { }

	[Address(RVA = "0x3475DC0", Offset = "0x34751C0", Length = "0x69")]
	[Token(Token = "0x6000617")]
	private void DestroyWorldSpacePanelGameObject() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x600060D")]
	public bool get_createDefaultPanelComponents() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000603")]
	internal EventSystem get_eventSystem() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000607")]
	public EventHandlerTypes get_handlerTypes() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000605")]
	public bool get_overrideUIToolkitEvents() { }

	[Address(RVA = "0x3476E70", Offset = "0x3476270", Length = "0x1A")]
	[Token(Token = "0x600060F")]
	private bool get_shouldTrackPanels() { }

	[Address(RVA = "0x3476E90", Offset = "0x3476290", Length = "0xA")]
	[Token(Token = "0x6000609")]
	public int get_worldPickingLayers() { }

	[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
	[Token(Token = "0x600060B")]
	public float get_worldPickingMaxDistance() { }

	[Address(RVA = "0x3475E30", Offset = "0x3475230", Length = "0x175")]
	[Token(Token = "0x600061A")]
	public void OnDisable() { }

	[Address(RVA = "0x3475FB0", Offset = "0x34753B0", Length = "0x435")]
	[Token(Token = "0x6000619")]
	public void OnEnable() { }

	[Address(RVA = "0x3476EA0", Offset = "0x34762A0", Length = "0x48")]
	[Token(Token = "0x600060E")]
	internal void set_createDefaultPanelComponents(bool value) { }

	[Address(RVA = "0x3476EF0", Offset = "0x34762F0", Length = "0x7C")]
	[Token(Token = "0x6000604")]
	internal void set_eventSystem(EventSystem value) { }

	[Address(RVA = "0x3476F70", Offset = "0x3476370", Length = "0x49")]
	[Token(Token = "0x6000608")]
	internal void set_handlerTypes(EventHandlerTypes value) { }

	[Address(RVA = "0x3476FC0", Offset = "0x34763C0", Length = "0xA")]
	[Token(Token = "0x6000606")]
	internal void set_overrideUIToolkitEvents(bool value) { }

	[Address(RVA = "0x3476FD0", Offset = "0x34763D0", Length = "0x1D")]
	[Token(Token = "0x600060A")]
	internal void set_worldPickingLayers(int value) { }

	[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
	[Token(Token = "0x600060C")]
	internal void set_worldPickingMaxDistance(float value) { }

	[Address(RVA = "0x3476670", Offset = "0x3475A70", Length = "0xB")]
	[Token(Token = "0x6000618")]
	public void Start() { }

	[Address(RVA = "0x34763F0", Offset = "0x34757F0", Length = "0x53")]
	[Token(Token = "0x6000611")]
	private void StartTrackingPanel(BaseRuntimePanel panel) { }

	[Address(RVA = "0x3476450", Offset = "0x3475850", Length = "0x210")]
	[Token(Token = "0x6000610")]
	private void StartTrackingUIToolkitPanels() { }

	[Address(RVA = "0x3476680", Offset = "0x3475A80", Length = "0x205")]
	[Token(Token = "0x6000612")]
	private void StopTrackingUIToolkitPanels() { }

	[Address(RVA = "0x3476CA0", Offset = "0x34760A0", Length = "0x7")]
	[Token(Token = "0x600061B")]
	public void Update() { }

	[Address(RVA = "0x3476890", Offset = "0x3475C90", Length = "0x3C")]
	[Token(Token = "0x6000613")]
	private void UpdatePanelGameObject(BaseRuntimePanel panel) { }

	[Address(RVA = "0x34768D0", Offset = "0x3475CD0", Length = "0x39C")]
	[Token(Token = "0x6000621")]
	private void UpdatePanelGameObjects() { }

	[Address(RVA = "0x3476C70", Offset = "0x3476070", Length = "0x26")]
	[Token(Token = "0x6000620")]
	private void UpdatePanelTracking() { }

}

