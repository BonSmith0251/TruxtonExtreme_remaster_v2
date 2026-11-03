namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Event System")]
[DisallowMultipleComponent]
[Token(Token = "0x20000B4")]
public class EventSystem : UIBehaviour
{
	[Token(Token = "0x20000B5")]
	private struct UIToolkitOverrideConfigOld
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400030D")]
		public EventSystem activeEventSystem; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400030E")]
		public bool sendEvents; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x400030F")]
		public bool createPanelGameObjectsOnStart; //Field offset: 0x9

	}

	[Token(Token = "0x4000302")]
	private static List<EventSystem> m_EventSystems; //Field offset: 0x0
	[Token(Token = "0x400030A")]
	private static readonly Comparison<RaycastResult> s_RaycastComparer; //Field offset: 0x8
	[Token(Token = "0x400030C")]
	private static Nullable<UIToolkitOverrideConfigOld> s_UIToolkitOverrideConfigOld; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000300")]
	private List<BaseInputModule> m_SystemInputModules; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000301")]
	private BaseInputModule m_CurrentInputModule; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_Selected")]
	[SerializeField]
	[Token(Token = "0x4000303")]
	private GameObject m_FirstSelected; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000304")]
	private bool m_sendNavigationEvents; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000305")]
	private int m_DragThreshold; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000306")]
	private GameObject m_CurrentSelected; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000307")]
	private bool m_HasFocus; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x4000308")]
	private bool m_SelectionGuard; //Field offset: 0x49
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000309")]
	private BaseEventData m_DummyData; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400030B")]
	private UIToolkitInteroperabilityBridge m_UIToolkitInterop; //Field offset: 0x58

	[Token(Token = "0x170001CC")]
	public bool alreadySelecting
	{
		[Address(RVA = "0x24F8BE0", Offset = "0x24F7FE0", Length = "0x5")]
		[Token(Token = "0x60006A1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001CD")]
	private BaseEventData baseEventDataCache
	{
		[Address(RVA = "0x3464FE0", Offset = "0x34643E0", Length = "0x79")]
		[Token(Token = "0x60006A3")]
		private get { } //Length: 121
	}

	[Token(Token = "0x170001C4")]
	public static EventSystem current
	{
		[Address(RVA = "0x3465060", Offset = "0x3464460", Length = "0xAB")]
		[Token(Token = "0x6000693")]
		 get { } //Length: 171
		[Address(RVA = "0x3465170", Offset = "0x3464570", Length = "0x184")]
		[Token(Token = "0x6000694")]
		 set { } //Length: 388
	}

	[Token(Token = "0x170001C7")]
	public BaseInputModule currentInputModule
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000699")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C9")]
	public GameObject currentSelectedGameObject
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600069C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001C8")]
	public GameObject firstSelectedGameObject
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600069A")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x600069B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001CB")]
	public bool isFocused
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[Token(Token = "0x600069E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001CF")]
	internal bool isOverridingUIToolkitEvents
	{
		[Address(RVA = "0x3465110", Offset = "0x3464510", Length = "0x5C")]
		[Token(Token = "0x60006AA")]
		internal get { } //Length: 92
	}

	[Obsolete("lastSelectedGameObject is no longer supported")]
	[Token(Token = "0x170001CA")]
	public GameObject lastSelectedGameObject
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600069D")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001C6")]
	public int pixelDragThreshold
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x6000697")]
		 get { } //Length: 4
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[Token(Token = "0x6000698")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001C5")]
	public bool sendNavigationEvents
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x6000695")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[Token(Token = "0x6000696")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001CE")]
	internal UIToolkitInteroperabilityBridge uiToolkitInterop
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60006A9")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x3464E10", Offset = "0x3464210", Length = "0x107")]
	[Token(Token = "0x60006B4")]
	private static EventSystem() { }

	[Address(RVA = "0x3464F20", Offset = "0x3464320", Length = "0xBB")]
	[Token(Token = "0x600069F")]
	protected EventSystem() { }

	[Address(RVA = "0x3463180", Offset = "0x3462580", Length = "0x10C")]
	[Token(Token = "0x60006B2")]
	private void ChangeEventModule(BaseInputModule module) { }

	[Address(RVA = "0x24F8BE0", Offset = "0x24F7FE0", Length = "0x5")]
	[Token(Token = "0x60006A1")]
	public bool get_alreadySelecting() { }

	[Address(RVA = "0x3464FE0", Offset = "0x34643E0", Length = "0x79")]
	[Token(Token = "0x60006A3")]
	private BaseEventData get_baseEventDataCache() { }

	[Address(RVA = "0x3465060", Offset = "0x3464460", Length = "0xAB")]
	[Token(Token = "0x6000693")]
	public static EventSystem get_current() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000699")]
	public BaseInputModule get_currentInputModule() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600069C")]
	public GameObject get_currentSelectedGameObject() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600069A")]
	public GameObject get_firstSelectedGameObject() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[Token(Token = "0x600069E")]
	public bool get_isFocused() { }

	[Address(RVA = "0x3465110", Offset = "0x3464510", Length = "0x5C")]
	[Token(Token = "0x60006AA")]
	internal bool get_isOverridingUIToolkitEvents() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600069D")]
	public GameObject get_lastSelectedGameObject() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x6000697")]
	public int get_pixelDragThreshold() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x6000695")]
	public bool get_sendNavigationEvents() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60006A9")]
	internal UIToolkitInteroperabilityBridge get_uiToolkitInterop() { }

	[Address(RVA = "0x3463290", Offset = "0x3462690", Length = "0x9D")]
	[Token(Token = "0x60006A8")]
	public bool IsPointerOverGameObject(int pointerId) { }

	[Address(RVA = "0x3463330", Offset = "0x3462730", Length = "0x8F")]
	[Token(Token = "0x60006A7")]
	public bool IsPointerOverGameObject() { }

	[Address(RVA = "0x34633C0", Offset = "0x34627C0", Length = "0xF")]
	[Token(Token = "0x60006B0")]
	protected override void OnApplicationFocus(bool hasFocus) { }

	[Address(RVA = "0x34633D0", Offset = "0x34627D0", Length = "0x25E")]
	[Token(Token = "0x60006AD")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x3463630", Offset = "0x3462A30", Length = "0x34D")]
	[Token(Token = "0x60006AC")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x3463980", Offset = "0x3462D80", Length = "0x1F8")]
	[Token(Token = "0x60006A6")]
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	[Address(RVA = "0x3463B80", Offset = "0x3462F80", Length = "0x47A")]
	[Token(Token = "0x60006A5")]
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	[Address(RVA = "0x3465170", Offset = "0x3464570", Length = "0x184")]
	[Token(Token = "0x6000694")]
	public static void set_current(EventSystem value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x600069B")]
	public void set_firstSelectedGameObject(GameObject value) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[Token(Token = "0x6000698")]
	public void set_pixelDragThreshold(int value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[Token(Token = "0x6000696")]
	public void set_sendNavigationEvents(bool value) { }

	[Address(RVA = "0x3464000", Offset = "0x3463400", Length = "0x92")]
	[Token(Token = "0x60006A4")]
	public void SetSelectedGameObject(GameObject selected) { }

	[Address(RVA = "0x34640A0", Offset = "0x34634A0", Length = "0x21E")]
	[Token(Token = "0x60006A2")]
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	[Address(RVA = "0x34642C0", Offset = "0x34636C0", Length = "0x4ED")]
	[Obsolete("Use PanelInputConfiguration component instead.")]
	[Token(Token = "0x60006AB")]
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true) { }

	[Address(RVA = "0x34647B0", Offset = "0x3463BB0", Length = "0x21")]
	[Token(Token = "0x60006AE")]
	protected virtual void Start() { }

	[Address(RVA = "0x34647E0", Offset = "0x3463BE0", Length = "0xF8")]
	[Token(Token = "0x60006AF")]
	private void TickModules() { }

	[Address(RVA = "0x34648E0", Offset = "0x3463CE0", Length = "0x154")]
	[Token(Token = "0x60006B3")]
	public virtual string ToString() { }

	[Address(RVA = "0x3464B80", Offset = "0x3463F80", Length = "0x287")]
	[Token(Token = "0x60006B1")]
	protected override void Update() { }

	[Address(RVA = "0x3464A40", Offset = "0x3463E40", Length = "0x13D")]
	[Token(Token = "0x60006A0")]
	public void UpdateModules() { }

}

