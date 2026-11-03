namespace UnityEngine.Rendering;

[Token(Token = "0x200008D")]
public sealed class DebugManager
{
	[CompilerGenerated]
	[Token(Token = "0x2000090")]
	private sealed class <>c
	{
		[Token(Token = "0x40001F6")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001F7")]
		public static Action<Boolean> <>9__49_0; //Field offset: 0x8
		[Token(Token = "0x40001F8")]
		public static Action <>9__49_1; //Field offset: 0x10
		[Token(Token = "0x40001F9")]
		public static Func<Widget, Int32> <>9__60_0; //Field offset: 0x18

		[Address(RVA = "0x2BEBA10", Offset = "0x2BEAE10", Length = "0x67")]
		[Token(Token = "0x6000669")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600066A")]
		public <>c() { }

		[Address(RVA = "0x2BEA950", Offset = "0x2BE9D50", Length = "0x44")]
		[Token(Token = "0x600066E")]
		internal DebugManager <.cctor>b__96_0() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600066B")]
		internal void <.ctor>b__49_0(bool <p0>) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600066C")]
		internal void <.ctor>b__49_1() { }

		[Address(RVA = "0x2BEA870", Offset = "0x2BE9C70", Length = "0x69")]
		[Token(Token = "0x600066D")]
		internal int <TogglePersistent>b__60_0(Widget w) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000091")]
	private sealed class <>c__DisplayClass68_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001FA")]
		public string displayName; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600066F")]
		public <>c__DisplayClass68_0() { }

		[Address(RVA = "0x21A8EB0", Offset = "0x21A82B0", Length = "0x25")]
		[Token(Token = "0x6000670")]
		internal bool <FindPanelIndex>b__0(Panel p) { }

	}

	[Token(Token = "0x200008E")]
	internal enum UIMode : int
	{
		EditorMode = 0,
		RuntimeMode = 1,
	}

	[Token(Token = "0x200008F")]
	private class UIState
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001F4")]
		public UIMode mode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Token(Token = "0x40001F5")]
		private bool m_Open; //Field offset: 0x14

		[Token(Token = "0x17000066")]
		public bool open
		{
			[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
			[Token(Token = "0x6000666")]
			 get { } //Length: 5
			[Address(RVA = "0x2BEBA80", Offset = "0x2BEAE80", Length = "0x86")]
			[Token(Token = "0x6000667")]
			 set { } //Length: 134
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000668")]
		public UIState() { }

		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[Token(Token = "0x6000666")]
		public bool get_open() { }

		[Address(RVA = "0x2BEBA80", Offset = "0x2BEAE80", Length = "0x86")]
		[Token(Token = "0x6000667")]
		public void set_open(bool value) { }

	}

	[Token(Token = "0x40001D3")]
	private const string kEnableDebugBtn1 = "Enable Debug Button 1"; //Field offset: 0x0
	[Token(Token = "0x40001DD")]
	private const string kEnableDebug = "Enable Debug"; //Field offset: 0x0
	[Token(Token = "0x40001DC")]
	private const string kResetBtn = "Debug Reset"; //Field offset: 0x0
	[Token(Token = "0x40001DB")]
	private const string kMultiplierBtn = "Debug Multiplier"; //Field offset: 0x0
	[Token(Token = "0x40001DA")]
	private const string kDPadHorizontal = "Debug Horizontal"; //Field offset: 0x0
	[Token(Token = "0x40001D9")]
	private const string kDPadVertical = "Debug Vertical"; //Field offset: 0x0
	[Token(Token = "0x40001E1")]
	private static readonly Lazy<DebugManager> s_Instance; //Field offset: 0x0
	[Token(Token = "0x40001D7")]
	private const string kValidateBtn = "Debug Validate"; //Field offset: 0x0
	[Token(Token = "0x40001D6")]
	private const string kDebugNextBtn = "Debug Next"; //Field offset: 0x0
	[Token(Token = "0x40001D5")]
	private const string kDebugPreviousBtn = "Debug Previous"; //Field offset: 0x0
	[Token(Token = "0x40001D4")]
	private const string kEnableDebugBtn2 = "Enable Debug Button 2"; //Field offset: 0x0
	[Token(Token = "0x40001D8")]
	private const string kPersistentBtn = "Debug Persistent"; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x40001ED")]
	private static Action<UIMode, Boolean> windowStateChanged; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001DE")]
	private DebugActionDesc[] m_DebugActions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001DF")]
	private DebugActionState[] m_DebugActionStates; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001E0")]
	private InputActionMap debugActionMap; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001E2")]
	private ReadOnlyCollection<Panel> m_ReadOnlyPanels; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001E3")]
	private readonly List<Panel> m_Panels; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001E4")]
	private Action<Boolean> onDisplayRuntimeUIChanged; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001E5")]
	private Action onSetDirty; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001E6")]
	private Action resetData; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001E7")]
	public bool refreshEditorRequested; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40001E8")]
	private Nullable<Int32> m_RequestedPanelIndex; //Field offset: 0x54
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001E9")]
	private GameObject m_Root; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001EA")]
	private DebugUIHandlerCanvas m_RootUICanvas; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001EB")]
	private GameObject m_PersistentRoot; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001EC")]
	private DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001EE")]
	private UIState editorUIState; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40001EF")]
	private bool m_EnableRuntimeUI; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40001F0")]
	private UIState runtimeUIState; //Field offset: 0x90

	[Token(Token = "0x14000005")]
	public event Action<Boolean> onDisplayRuntimeUIChanged
	{
		[Address(RVA = "0x2BDE190", Offset = "0x2BDD590", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000639")]
		 add { } //Length: 172
		[Address(RVA = "0x2BDE6E0", Offset = "0x2BDDAE0", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x600063A")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x14000006")]
	public event Action onSetDirty
	{
		[Address(RVA = "0x2BDE240", Offset = "0x2BDD640", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600063B")]
		 add { } //Length: 158
		[Address(RVA = "0x2BDE790", Offset = "0x2BDDB90", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600063C")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000007")]
	private event Action resetData
	{
		[Address(RVA = "0x2BDE2E0", Offset = "0x2BDD6E0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600063D")]
		private add { } //Length: 158
		[Address(RVA = "0x2BDE830", Offset = "0x2BDDC30", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600063E")]
		private remove { } //Length: 158
	}

	[Token(Token = "0x14000008")]
	public static event Action<UIMode, Boolean> windowStateChanged
	{
		[Address(RVA = "0x2BDE380", Offset = "0x2BDD780", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x600065A")]
		 add { } //Length: 261
		[Address(RVA = "0x2BDE8D0", Offset = "0x2BDDCD0", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x600065B")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x17000062")]
	public bool displayEditorUI
	{
		[Address(RVA = "0x2BDE490", Offset = "0x2BDD890", Length = "0x1E")]
		[Token(Token = "0x600065C")]
		 get { } //Length: 30
		[Address(RVA = "0x2BDD5A0", Offset = "0x2BDC9A0", Length = "0x21")]
		[Token(Token = "0x600065D")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000065")]
	public bool displayPersistentRuntimeUI
	{
		[Address(RVA = "0x2BDE4B0", Offset = "0x2BDD8B0", Length = "0x7D")]
		[Token(Token = "0x6000662")]
		 get { } //Length: 125
		[Address(RVA = "0x2BDE9E0", Offset = "0x2BDDDE0", Length = "0x92")]
		[Token(Token = "0x6000663")]
		 set { } //Length: 146
	}

	[Token(Token = "0x17000064")]
	public bool displayRuntimeUI
	{
		[Address(RVA = "0x2BDE530", Offset = "0x2BDD930", Length = "0x7D")]
		[Token(Token = "0x6000660")]
		 get { } //Length: 125
		[Address(RVA = "0x2BDEA80", Offset = "0x2BDDE80", Length = "0x27E")]
		[Token(Token = "0x6000661")]
		 set { } //Length: 638
	}

	[Token(Token = "0x17000063")]
	public bool enableRuntimeUI
	{
		[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
		[Token(Token = "0x600065E")]
		 get { } //Length: 8
		[Address(RVA = "0x2BDED00", Offset = "0x2BDE100", Length = "0x1C")]
		[Token(Token = "0x600065F")]
		 set { } //Length: 28
	}

	[Token(Token = "0x1700005F")]
	public static DebugManager instance
	{
		[Address(RVA = "0x2BDE5B0", Offset = "0x2BDD9B0", Length = "0x6F")]
		[Token(Token = "0x6000636")]
		 get { } //Length: 111
	}

	[Token(Token = "0x17000061")]
	public bool isAnyDebugUIActive
	{
		[Address(RVA = "0x2BDE620", Offset = "0x2BDDA20", Length = "0x8C")]
		[Token(Token = "0x600063F")]
		 get { } //Length: 140
	}

	[Token(Token = "0x17000060")]
	public ReadOnlyCollection<Panel> panels
	{
		[Address(RVA = "0x2BDE6B0", Offset = "0x2BDDAB0", Length = "0x2B")]
		[Token(Token = "0x6000638")]
		 get { } //Length: 43
	}

	[Address(RVA = "0x2BDDD90", Offset = "0x2BDD190", Length = "0x101")]
	[Token(Token = "0x6000665")]
	private static DebugManager() { }

	[Address(RVA = "0x2BDDEA0", Offset = "0x2BDD2A0", Length = "0x2E8")]
	[Token(Token = "0x6000640")]
	private DebugManager() { }

	[Address(RVA = "0x2BDE190", Offset = "0x2BDD590", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x6000639")]
	public void add_onDisplayRuntimeUIChanged(Action<Boolean> value) { }

	[Address(RVA = "0x2BDE240", Offset = "0x2BDD640", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600063B")]
	public void add_onSetDirty(Action value) { }

	[Address(RVA = "0x2BDE2E0", Offset = "0x2BDD6E0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600063D")]
	private void add_resetData(Action value) { }

	[Address(RVA = "0x2BDE380", Offset = "0x2BDD780", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x600065A")]
	public static void add_windowStateChanged(Action<UIMode, Boolean> value) { }

	[Address(RVA = "0x2BDA5F0", Offset = "0x2BD99F0", Length = "0x115")]
	[Token(Token = "0x600062E")]
	private void AddAction(DebugAction action, DebugActionDesc desc) { }

	[Address(RVA = "0x2BDA710", Offset = "0x2BD9B10", Length = "0x1E")]
	[Token(Token = "0x6000648")]
	internal void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext) { }

	[Address(RVA = "0x2BDA730", Offset = "0x2BD9B30", Length = "0x19E")]
	[Token(Token = "0x600062D")]
	internal void EnableInputActions() { }

	[Address(RVA = "0x2BDA8D0", Offset = "0x2BD9CD0", Length = "0x211")]
	[Token(Token = "0x600064A")]
	private void EnsurePersistentCanvas() { }

	[Address(RVA = "0x2BDAAF0", Offset = "0x2BD9EF0", Length = "0xD6")]
	[Token(Token = "0x6000653")]
	public int FindPanelIndex(string displayName) { }

	[Address(RVA = "0x2BDE490", Offset = "0x2BDD890", Length = "0x1E")]
	[Token(Token = "0x600065C")]
	public bool get_displayEditorUI() { }

	[Address(RVA = "0x2BDE4B0", Offset = "0x2BDD8B0", Length = "0x7D")]
	[Token(Token = "0x6000662")]
	public bool get_displayPersistentRuntimeUI() { }

	[Address(RVA = "0x2BDE530", Offset = "0x2BDD930", Length = "0x7D")]
	[Token(Token = "0x6000660")]
	public bool get_displayRuntimeUI() { }

	[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
	[Token(Token = "0x600065E")]
	public bool get_enableRuntimeUI() { }

	[Address(RVA = "0x2BDE5B0", Offset = "0x2BDD9B0", Length = "0x6F")]
	[Token(Token = "0x6000636")]
	public static DebugManager get_instance() { }

	[Address(RVA = "0x2BDE620", Offset = "0x2BDDA20", Length = "0x8C")]
	[Token(Token = "0x600063F")]
	public bool get_isAnyDebugUIActive() { }

	[Address(RVA = "0x2BDE6B0", Offset = "0x2BDDAB0", Length = "0x2B")]
	[Token(Token = "0x6000638")]
	public ReadOnlyCollection<Panel> get_panels() { }

	[Address(RVA = "0x2BDAFD0", Offset = "0x2BDA3D0", Length = "0x35")]
	[Token(Token = "0x6000632")]
	internal float GetAction(DebugAction action) { }

	[Address(RVA = "0x2BDABD0", Offset = "0x2BD9FD0", Length = "0x189")]
	[Token(Token = "0x6000634")]
	internal bool GetActionReleaseScrollTarget() { }

	[Address(RVA = "0x2BDAD60", Offset = "0x2BDA160", Length = "0x267")]
	[Token(Token = "0x6000633")]
	internal bool GetActionToggleDebugMenuWithTouch() { }

	[Address(RVA = "0x2BDB210", Offset = "0x2BDA610", Length = "0x147")]
	[Token(Token = "0x6000658")]
	public Widget GetItem(string queryPath) { }

	[Address(RVA = "0x2BDB010", Offset = "0x2BDA410", Length = "0x1F8")]
	[Token(Token = "0x6000659")]
	private Widget GetItem(string queryPath, IContainer container) { }

	[Address(RVA = "0x2BDB700", Offset = "0x2BDAB00", Length = "0x258")]
	[Token(Token = "0x6000656")]
	public Widget[] GetItems(Flags flags) { }

	[Address(RVA = "0x2BDB360", Offset = "0x2BDA760", Length = "0x395")]
	[Token(Token = "0x6000657")]
	internal Widget[] GetItemsFromContainer(Flags flags, IContainer container) { }

	[Address(RVA = "0x2BDB960", Offset = "0x2BDAD60", Length = "0x34E")]
	[Token(Token = "0x6000652")]
	public Panel GetPanel(string displayName, bool createIfNull = false, int groupIndex = 0, bool overrideIfExist = false) { }

	[Address(RVA = "0x2BDBCB0", Offset = "0x2BDB0B0", Length = "0xB")]
	[Token(Token = "0x6000651")]
	internal Nullable<Int32> GetRequestedEditorWindowPanelIndex() { }

	[Address(RVA = "0x2BDBCC0", Offset = "0x2BDB0C0", Length = "0x13B")]
	[Token(Token = "0x6000646")]
	public int GetState() { }

	[Address(RVA = "0x2BDBE00", Offset = "0x2BDB200", Length = "0x25")]
	[Token(Token = "0x600064C")]
	private void OnPanelDirty(Panel panel) { }

	[Address(RVA = "0x2BDBE30", Offset = "0x2BDB230", Length = "0x94")]
	[Obsolete("Method is obsolete. Use PanelDisplayName instead. #from(6000.4) (UnityUpgradable) -> PanelDisplayName", True)]
	[Token(Token = "0x600064E")]
	public string PanelDiplayName(int panelIndex) { }

	[Address(RVA = "0x2BDBED0", Offset = "0x2BDB2D0", Length = "0x94")]
	[Token(Token = "0x600064F")]
	public string PanelDisplayName(int panelIndex) { }

	[Address(RVA = "0x2BDBF70", Offset = "0x2BDB370", Length = "0xDA")]
	[Token(Token = "0x600064D")]
	public int PanelIndex(string displayName) { }

	[Address(RVA = "0x2BDC050", Offset = "0x2BDB450", Length = "0x2F")]
	[Token(Token = "0x6000643")]
	public void ReDrawOnScreenDebug() { }

	[Address(RVA = "0x2BDC080", Offset = "0x2BDB480", Length = "0x5")]
	[Token(Token = "0x6000641")]
	public void RefreshEditor() { }

	[Address(RVA = "0x2BDC090", Offset = "0x2BDB490", Length = "0x4C9")]
	[Token(Token = "0x600062C")]
	private void RegisterActions() { }

	[Address(RVA = "0x2BDC560", Offset = "0x2BDB960", Length = "0xE4")]
	[Token(Token = "0x6000644")]
	public void RegisterData(IDebugData data) { }

	[Address(RVA = "0x2BDC650", Offset = "0x2BDBA50", Length = "0x997")]
	[Token(Token = "0x6000635")]
	private void RegisterInputs() { }

	[Address(RVA = "0x2BDCFF0", Offset = "0x2BDC3F0", Length = "0x4E")]
	[Token(Token = "0x6000647")]
	internal void RegisterRootCanvas(DebugUIHandlerCanvas root) { }

	[Address(RVA = "0x2BDE6E0", Offset = "0x2BDDAE0", Length = "0xAC")]
	[CompilerGenerated]
	[Token(Token = "0x600063A")]
	public void remove_onDisplayRuntimeUIChanged(Action<Boolean> value) { }

	[Address(RVA = "0x2BDE790", Offset = "0x2BDDB90", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600063C")]
	public void remove_onSetDirty(Action value) { }

	[Address(RVA = "0x2BDE830", Offset = "0x2BDDC30", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600063E")]
	private void remove_resetData(Action value) { }

	[Address(RVA = "0x2BDE8D0", Offset = "0x2BDDCD0", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x600065B")]
	public static void remove_windowStateChanged(Action<UIMode, Boolean> value) { }

	[Address(RVA = "0x2BDD040", Offset = "0x2BDC440", Length = "0x1FC")]
	[Token(Token = "0x6000654")]
	public void RemovePanel(string displayName) { }

	[Address(RVA = "0x2BDD240", Offset = "0x2BDC640", Length = "0x63")]
	[Token(Token = "0x6000655")]
	public void RemovePanel(Panel panel) { }

	[Address(RVA = "0x2BDD2B0", Offset = "0x2BDC6B0", Length = "0x5B")]
	[Token(Token = "0x6000650")]
	public void RequestEditorWindowPanelIndex(int index) { }

	[Address(RVA = "0x2BDD310", Offset = "0x2BDC710", Length = "0x49")]
	[Token(Token = "0x6000642")]
	public void Reset() { }

	[Address(RVA = "0x2BDD360", Offset = "0x2BDC760", Length = "0x1AA")]
	[Token(Token = "0x600062F")]
	private void SampleAction(int actionIndex) { }

	[Address(RVA = "0x2BDD5A0", Offset = "0x2BDC9A0", Length = "0x21")]
	[Token(Token = "0x600065D")]
	public void set_displayEditorUI(bool value) { }

	[Address(RVA = "0x2BDE9E0", Offset = "0x2BDDDE0", Length = "0x92")]
	[Token(Token = "0x6000663")]
	public void set_displayPersistentRuntimeUI(bool value) { }

	[Address(RVA = "0x2BDEA80", Offset = "0x2BDDE80", Length = "0x27E")]
	[Token(Token = "0x6000661")]
	public void set_displayRuntimeUI(bool value) { }

	[Address(RVA = "0x2BDED00", Offset = "0x2BDE100", Length = "0x1C")]
	[Token(Token = "0x600065F")]
	public void set_enableRuntimeUI(bool value) { }

	[Address(RVA = "0x2BDD510", Offset = "0x2BDC910", Length = "0x84")]
	[Token(Token = "0x6000649")]
	internal void SetScrollTarget(DebugUIHandlerWidget widget) { }

	[Address(RVA = "0x2BDD5A0", Offset = "0x2BDC9A0", Length = "0x21")]
	[Obsolete("Use DebugManager.instance.displayEditorUI property instead. #from(2023.1)")]
	[Token(Token = "0x6000664")]
	public void ToggleEditorUI(bool open) { }

	[Address(RVA = "0x2BDD5D0", Offset = "0x2BDC9D0", Length = "0x407")]
	[Token(Token = "0x600064B")]
	internal void TogglePersistent(Widget widget, Nullable<Int32> forceTupleIndex = null) { }

	[Address(RVA = "0x2BDD9E0", Offset = "0x2BDCDE0", Length = "0xE4")]
	[Token(Token = "0x6000645")]
	public void UnregisterData(IDebugData data) { }

	[Address(RVA = "0x2BDDAD0", Offset = "0x2BDCED0", Length = "0x1D2")]
	[Token(Token = "0x6000630")]
	private void UpdateAction(int actionIndex) { }

	[Address(RVA = "0x2BDDCB0", Offset = "0x2BDD0B0", Length = "0x5E")]
	[Token(Token = "0x6000631")]
	internal void UpdateActions() { }

	[Address(RVA = "0x2BDDD10", Offset = "0x2BDD110", Length = "0x75")]
	[Token(Token = "0x6000637")]
	private void UpdateReadOnlyCollection() { }

}

