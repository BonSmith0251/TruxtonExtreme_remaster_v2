namespace UnityEngine.EventSystems;

[RequireComponent(typeof(EventSystem))]
[Token(Token = "0x20000BD")]
public abstract class BaseInputModule : UIBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000338")]
	protected List<RaycastResult> m_RaycastResultCache; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000339")]
	private bool m_SendPointerHoverToParent; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400033A")]
	private AxisEventData m_AxisEventData; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400033B")]
	private EventSystem m_EventSystem; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400033C")]
	private BaseEventData m_BaseEventData; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400033D")]
	protected BaseInput m_InputOverride; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400033E")]
	private BaseInput m_DefaultInput; //Field offset: 0x50

	[Token(Token = "0x170001F0")]
	protected EventSystem eventSystem
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000716")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001EE")]
	public BaseInput input
	{
		[Address(RVA = "0x34626D0", Offset = "0x3461AD0", Length = "0x21C")]
		[Token(Token = "0x6000713")]
		 get { } //Length: 540
	}

	[Token(Token = "0x170001EF")]
	public BaseInput inputOverride
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000714")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x6000715")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001ED")]
	protected private bool sendPointerHoverToParent
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000711")]
		private get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x6000712")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x3462650", Offset = "0x3461A50", Length = "0x7B")]
	[Token(Token = "0x600072A")]
	protected BaseInputModule() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000724")]
	public override void ActivateModule() { }

	[Address(RVA = "0x3461380", Offset = "0x3460780", Length = "0x52")]
	[Token(Token = "0x6000728")]
	public override Vector2 ConvertPointerEventScrollDeltaToTicks(Vector2 scrollDelta) { }

	[Address(RVA = "0x34613E0", Offset = "0x34607E0", Length = "0x95")]
	[Token(Token = "0x6000727")]
	public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000723")]
	public override void DeactivateModule() { }

	[Address(RVA = "0x3461480", Offset = "0x3460880", Length = "0x7F")]
	[Token(Token = "0x600071C")]
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	[Address(RVA = "0x3461500", Offset = "0x3460900", Length = "0x63")]
	[Token(Token = "0x600071B")]
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	[Address(RVA = "0x3461570", Offset = "0x3460970", Length = "0x187")]
	[Token(Token = "0x600071D")]
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	[Address(RVA = "0x3461700", Offset = "0x3460B00", Length = "0x154")]
	[Token(Token = "0x600071A")]
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000716")]
	protected EventSystem get_eventSystem() { }

	[Address(RVA = "0x34626D0", Offset = "0x3461AD0", Length = "0x21C")]
	[Token(Token = "0x6000713")]
	public BaseInput get_input() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000714")]
	public BaseInput get_inputOverride() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000711")]
	protected private bool get_sendPointerHoverToParent() { }

	[Address(RVA = "0x3461860", Offset = "0x3460C60", Length = "0x147")]
	[Token(Token = "0x600071F")]
	protected override AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	[Address(RVA = "0x34619B0", Offset = "0x3460DB0", Length = "0xA8")]
	[Token(Token = "0x6000720")]
	protected override BaseEventData GetBaseEventData() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000729")]
	public override NavigationDeviceType GetNavigationEventDeviceType(BaseEventData eventData) { }

	[Address(RVA = "0x3461A60", Offset = "0x3460E60", Length = "0xB2A")]
	[Token(Token = "0x600071E")]
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000726")]
	public override bool IsModuleSupported() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000721")]
	public override bool IsPointerOverGameObject(int pointerId) { }

	[Address(RVA = "0x3462590", Offset = "0x3461990", Length = "0x1D")]
	[Token(Token = "0x6000718")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x34625B0", Offset = "0x34619B0", Length = "0x5E")]
	[Token(Token = "0x6000717")]
	protected virtual void OnEnable() { }

	[Token(Token = "0x6000719")]
	public abstract void Process() { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6000715")]
	public void set_inputOverride(BaseInput value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x6000712")]
	protected private void set_sendPointerHoverToParent(bool value) { }

	[Address(RVA = "0x3462610", Offset = "0x3461A10", Length = "0x3D")]
	[Token(Token = "0x6000722")]
	public override bool ShouldActivateModule() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000725")]
	public override void UpdateModule() { }

}

