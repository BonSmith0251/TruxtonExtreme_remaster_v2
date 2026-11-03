namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/Panel Raycaster (UI Toolkit)")]
[Token(Token = "0x2000095")]
public class PanelRaycaster : BaseRaycaster, IRuntimePanelComponent
{
	[Token(Token = "0x40002B3")]
	private static ScreenOverlayPanelPicker panelPicker; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002B2")]
	private BaseRuntimePanel m_Panel; //Field offset: 0x28

	[Token(Token = "0x17000192")]
	public virtual Camera eventCamera
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000600")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700018E")]
	public override IPanel panel
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60005F7")]
		 get { } //Length: 5
		[Address(RVA = "0x346A6B0", Offset = "0x3469AB0", Length = "0x16F")]
		[Token(Token = "0x60005F8")]
		 set { } //Length: 367
	}

	[Token(Token = "0x17000191")]
	public virtual int renderOrderPriority
	{
		[Address(RVA = "0x346A5A0", Offset = "0x34699A0", Length = "0x77")]
		[Token(Token = "0x60005FE")]
		 get { } //Length: 119
	}

	[Token(Token = "0x1700018F")]
	private GameObject selectableGameObject
	{
		[Address(RVA = "0x346A620", Offset = "0x3469A20", Length = "0x12")]
		[Token(Token = "0x60005FC")]
		private get { } //Length: 18
	}

	[Token(Token = "0x17000190")]
	public virtual int sortOrderPriority
	{
		[Address(RVA = "0x346A640", Offset = "0x3469A40", Length = "0x66")]
		[Token(Token = "0x60005FD")]
		 get { } //Length: 102
	}

	[Address(RVA = "0x346A520", Offset = "0x3469920", Length = "0x73")]
	[Token(Token = "0x6000602")]
	private static PanelRaycaster() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000601")]
	public PanelRaycaster() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000600")]
	public virtual Camera get_eventCamera() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60005F7")]
	public override IPanel get_panel() { }

	[Address(RVA = "0x346A5A0", Offset = "0x34699A0", Length = "0x77")]
	[Token(Token = "0x60005FE")]
	public virtual int get_renderOrderPriority() { }

	[Address(RVA = "0x346A620", Offset = "0x3469A20", Length = "0x12")]
	[Token(Token = "0x60005FC")]
	private GameObject get_selectableGameObject() { }

	[Address(RVA = "0x346A640", Offset = "0x3469A40", Length = "0x66")]
	[Token(Token = "0x60005FD")]
	public virtual int get_sortOrderPriority() { }

	[Address(RVA = "0x3469E80", Offset = "0x3469280", Length = "0x127")]
	[Token(Token = "0x60005FB")]
	private void OnPanelDestroyed() { }

	[Address(RVA = "0x3469FB0", Offset = "0x34693B0", Length = "0x44A")]
	[Token(Token = "0x60005FF")]
	public virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	[Address(RVA = "0x346A400", Offset = "0x3469800", Length = "0x88")]
	[Token(Token = "0x60005F9")]
	private void RegisterCallbacks() { }

	[Address(RVA = "0x346A6B0", Offset = "0x3469AB0", Length = "0x16F")]
	[Token(Token = "0x60005F8")]
	public override void set_panel(IPanel value) { }

	[Address(RVA = "0x346A490", Offset = "0x3469890", Length = "0x88")]
	[Token(Token = "0x60005FA")]
	private void UnregisterCallbacks() { }

}

