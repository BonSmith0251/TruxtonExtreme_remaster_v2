namespace KANAI.UI;

[DefaultExecutionOrder(-10)]
[Token(Token = "0x2000035")]
public class UIManager : MonoBehaviourSingleton<UIManager>
{
	[CompilerGenerated]
	[Token(Token = "0x2000037")]
	private sealed class <>c
	{
		[Token(Token = "0x4000179")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400017A")]
		public static Func<PadButtonInfo, Boolean> <>9__37_0; //Field offset: 0x8
		[Token(Token = "0x400017B")]
		public static Func<UIBase, IEnumerator> <>9__82_0; //Field offset: 0x10

		[Address(RVA = "0x1E17CA0", Offset = "0x1E170A0", Length = "0x67")]
		[Token(Token = "0x6000184")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000185")]
		public <>c() { }

		[Address(RVA = "0x1E17B50", Offset = "0x1E16F50", Length = "0x1A")]
		[Token(Token = "0x6000186")]
		internal bool <_stepFloor>b__37_0(PadButtonInfo b) { }

		[Address(RVA = "0x1E17B20", Offset = "0x1E16F20", Length = "0x2C")]
		[Token(Token = "0x6000187")]
		internal IEnumerator <WaitAnimation>b__82_0(UIBase aUI) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000038")]
	private sealed class <>c__DisplayClass38_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400017C")]
		public int nextFloor; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000188")]
		public <>c__DisplayClass38_0() { }

		[Address(RVA = "0x1E0E510", Offset = "0x1E0D910", Length = "0x1C")]
		[Token(Token = "0x6000189")]
		internal bool <_changeFloor>b__0(PadButtonInfo b) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000039")]
	private sealed class <WaitAnimation>d__82 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400017D")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400017E")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400017F")]
		public UIManager <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000030")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600018D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000031")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600018F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600018A")]
		public <WaitAnimation>d__82(int <>1__state) { }

		[Address(RVA = "0x1E17DF0", Offset = "0x1E171F0", Length = "0x1C3")]
		[Token(Token = "0x600018C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600018D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600018F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1E17FC0", Offset = "0x1E173C0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600018E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600018B")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000036")]
	private class PadButtonInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000176")]
		public ButtonBase _button; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000177")]
		public int _floor; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000178")]
		public int _index; //Field offset: 0x1C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000183")]
		public PadButtonInfo() { }

	}

	[Token(Token = "0x4000171")]
	private static readonly String[] _reserveKeys; //Field offset: 0x0
	[Token(Token = "0x4000172")]
	private static readonly string commonKeyName; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400015F")]
	private bool _clickedOnThisFrame; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000160")]
	private bool isUnlockClickEvent; //Field offset: 0x21
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000161")]
	private Camera _canvasCamera; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000162")]
	private RectTransform _canvasRect; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000163")]
	private UIInputLocker _inputLocker; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000164")]
	private float _scaleFactor; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000165")]
	public Func<Boolean> OnClickBackCheck; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000166")]
	public Func<Int32> IsExitPopupCheck; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000167")]
	private Dictionary<Int32, List`1<PadButtonInfo>> _PadBridge; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000168")]
	private List<Int32> _DisableLayerLists; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000169")]
	private int _currentLayer; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400016A")]
	private int _currentFloor; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400016B")]
	private int _currentIndex; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400016C")]
	private int _currentPadId; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400016D")]
	public UnityEvent _onMoveAction; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400016E")]
	public UnityEvent _onSelectedAction; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400016F")]
	public UnityEvent _onCanceledAction; //Field offset: 0x88
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000170")]
	private Area <LocalizeArea>k__BackingField; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000173")]
	private Dictionary<String, UILocalizeText> _localizeText; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000174")]
	private List<UISpritePalette> _spritePalette; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000175")]
	private List<UIBase> _uiBaseLists; //Field offset: 0xA8

	[Token(Token = "0x17000028")]
	public Camera CanvasCamera
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000156")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000029")]
	public RectTransform CanvasRect
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000157")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002D")]
	public int CurrentFloor
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[Token(Token = "0x6000168")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700002E")]
	public int CurrentIndex
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x6000169")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700002A")]
	public Transform DebugAreaRoot
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000158")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700002B")]
	public UIInputLocker InputLocker
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000159")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002F")]
	public private Area LocalizeArea
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600016A")]
		 get { } //Length: 7
		[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600016B")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700002C")]
	public float ScaleFactor
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x600015A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1E25500", Offset = "0x1E24900", Length = "0x2F7")]
	[Token(Token = "0x6000164")]
	private void _changeFloor(int nextFloor) { }

	[Address(RVA = "0x1E259E0", Offset = "0x1E24DE0", Length = "0xF6")]
	[Token(Token = "0x6000166")]
	private ButtonBase _getCurrentButton() { }

	[Address(RVA = "0x1E25AE0", Offset = "0x1E24EE0", Length = "0xAF")]
	[Token(Token = "0x6000173")]
	private static string _getKeyHeader(string s) { }

	[Address(RVA = "0x1E25B90", Offset = "0x1E24F90", Length = "0x47")]
	[Token(Token = "0x6000167")]
	private bool _isDisableControll() { }

	[Address(RVA = "0x1E25BE0", Offset = "0x1E24FE0", Length = "0x24B")]
	[Token(Token = "0x6000165")]
	private bool _moveInFloor(int step) { }

	[Address(RVA = "0x1E25E30", Offset = "0x1E25230", Length = "0x11A")]
	[Token(Token = "0x6000155")]
	private bool _onClickBackButton() { }

	[Address(RVA = "0x1E25F50", Offset = "0x1E25350", Length = "0x1D0")]
	[Token(Token = "0x6000163")]
	private bool _stepFloor(int step) { }

	[Address(RVA = "0x1E25260", Offset = "0x1E24660", Length = "0x291")]
	[Token(Token = "0x6000180")]
	private static UIManager() { }

	[Address(RVA = "0x1E25800", Offset = "0x1E24C00", Length = "0x1D5")]
	[Token(Token = "0x600017F")]
	public UIManager() { }

	[Address(RVA = "0x1E24C00", Offset = "0x1E24000", Length = "0x2B")]
	[CompilerGenerated]
	[Token(Token = "0x6000182")]
	private bool <_getCurrentButton>b__40_0(PadButtonInfo n) { }

	[Address(RVA = "0x1E24C30", Offset = "0x1E24030", Length = "0x1C")]
	[CompilerGenerated]
	[Token(Token = "0x6000181")]
	private bool <_moveInFloor>b__39_0(PadButtonInfo b) { }

	[Address(RVA = "0x1E22C40", Offset = "0x1E22040", Length = "0xAC")]
	[Token(Token = "0x6000178")]
	public void Add(UIBase value) { }

	[Address(RVA = "0x1E22CF0", Offset = "0x1E220F0", Length = "0xDD")]
	[Token(Token = "0x6000175")]
	public void Add(UISpritePalette value) { }

	[Address(RVA = "0x1E22DD0", Offset = "0x1E221D0", Length = "0x200")]
	[Token(Token = "0x600016E")]
	public void Add(Sheet s) { }

	[Address(RVA = "0x1E22FE0", Offset = "0x1E223E0", Length = "0x129")]
	[Token(Token = "0x6000174")]
	private static string ChangePlatformKey(string keystr) { }

	[Address(RVA = "0x1E23110", Offset = "0x1E22510", Length = "0x2E0")]
	[Token(Token = "0x600015D")]
	public void ClearAllBridge() { }

	[Address(RVA = "0x1E23400", Offset = "0x1E22800", Length = "0x12F")]
	[Token(Token = "0x600015C")]
	public void ClearBridge(int layerId) { }

	[Address(RVA = "0x1E23530", Offset = "0x1E22930", Length = "0x12E")]
	[Token(Token = "0x600016D")]
	public void DecodeAdd(UILocalizeText d) { }

	[Address(RVA = "0x1E23660", Offset = "0x1E22A60", Length = "0xD1")]
	[Token(Token = "0x6000161")]
	public void DisableControll(int nLayer) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000152")]
	public void DisplayCursor(bool isDisplay) { }

	[Address(RVA = "0x1E23740", Offset = "0x1E22B40", Length = "0x1C0")]
	[Token(Token = "0x600015B")]
	public void EntryBridge(int layerId, int floor, int index, ButtonBase button) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000156")]
	public Camera get_CanvasCamera() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000157")]
	public RectTransform get_CanvasRect() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[Token(Token = "0x6000168")]
	public int get_CurrentFloor() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x6000169")]
	public int get_CurrentIndex() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000158")]
	public Transform get_DebugAreaRoot() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000159")]
	public UIInputLocker get_InputLocker() { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600016A")]
	public Area get_LocalizeArea() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x600015A")]
	public float get_ScaleFactor() { }

	[Address(RVA = "0x1E23910", Offset = "0x1E22D10", Length = "0x25E")]
	[Token(Token = "0x6000177")]
	public Sprite GetSprite(string keyValue) { }

	[Address(RVA = "0x1E23B70", Offset = "0x1E22F70", Length = "0x2D8")]
	[Token(Token = "0x6000171")]
	public string GetString(string keyValue) { }

	[Address(RVA = "0x1E23F00", Offset = "0x1E23300", Length = "0x1A4")]
	[Token(Token = "0x6000170")]
	public bool HasString(string keyValue) { }

	[Address(RVA = "0x1E240B0", Offset = "0x1E234B0", Length = "0x119")]
	[Token(Token = "0x600017C")]
	public void Hidden() { }

	[Address(RVA = "0x1E241D0", Offset = "0x1E235D0", Length = "0x1FA")]
	[Token(Token = "0x600014B")]
	public void Initialize() { }

	[Address(RVA = "0x1E243D0", Offset = "0x1E237D0", Length = "0x134")]
	[Token(Token = "0x600017D")]
	public bool IsAnimation() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x600014D")]
	public bool IsMultiTouchAction() { }

	[Address(RVA = "0x1E24510", Offset = "0x1E23910", Length = "0x50")]
	[Token(Token = "0x6000151")]
	public bool IsUILock() { }

	[Address(RVA = "0x1E24570", Offset = "0x1E23970", Length = "0x147")]
	[Token(Token = "0x6000154")]
	private void LateUpdate() { }

	[Address(RVA = "0x1E24750", Offset = "0x1E23B50", Length = "0x56")]
	[Token(Token = "0x6000179")]
	public bool Remove(UIBase value) { }

	[Address(RVA = "0x1E247B0", Offset = "0x1E23BB0", Length = "0x56")]
	[Token(Token = "0x6000176")]
	public bool Remove(UISpritePalette value) { }

	[Address(RVA = "0x1E246C0", Offset = "0x1E23AC0", Length = "0x82")]
	[Token(Token = "0x600016F")]
	public void RemoveLocalizeText(string label) { }

	[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600016B")]
	private void set_LocalizeArea(Area value) { }

	[Address(RVA = "0x1E24810", Offset = "0x1E23C10", Length = "0x14")]
	[Token(Token = "0x600016C")]
	public bool SetArea(Area area) { }

	[Address(RVA = "0x1E24830", Offset = "0x1E23C30", Length = "0x2F")]
	[Token(Token = "0x600015F")]
	public void SetCurrentFloor(int nFloor, int nIndex = 0) { }

	[Address(RVA = "0x1E24860", Offset = "0x1E23C60", Length = "0x17")]
	[Token(Token = "0x600015E")]
	public void SetCurrentLayer(int nLayer, int nFloor = 0, int nIndex = 0) { }

	[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
	[Token(Token = "0x6000160")]
	public void SetCurrentPad(int npad) { }

	[Address(RVA = "0x1E24890", Offset = "0x1E23C90", Length = "0x16")]
	[Token(Token = "0x600014E")]
	public bool SetMultiTouchAction() { }

	[Address(RVA = "0x1E248B0", Offset = "0x1E23CB0", Length = "0x34")]
	[Token(Token = "0x6000150")]
	public void SetUILock(bool isValue) { }

	[Address(RVA = "0x1E248F0", Offset = "0x1E23CF0", Length = "0x119")]
	[Token(Token = "0x600017B")]
	public void Show() { }

	[Address(RVA = "0x1E24A10", Offset = "0x1E23E10", Length = "0x52")]
	[Token(Token = "0x600014C")]
	public void Terminate() { }

	[Address(RVA = "0x1E24A70", Offset = "0x1E23E70", Length = "0x18D")]
	[Token(Token = "0x6000172")]
	public void ToLocalize(GameObject target) { }

	[Address(RVA = "0x1E24C50", Offset = "0x1E24050", Length = "0x3D")]
	[Token(Token = "0x600017A")]
	public int UICount() { }

	[Address(RVA = "0x1E24C90", Offset = "0x1E24090", Length = "0x5")]
	[Token(Token = "0x600014F")]
	public void UnlockClickEvent() { }

	[Address(RVA = "0x1E24FA0", Offset = "0x1E243A0", Length = "0x24B")]
	[Token(Token = "0x6000153")]
	private void Update() { }

	[Address(RVA = "0x1E24CA0", Offset = "0x1E240A0", Length = "0x2F6")]
	[Token(Token = "0x6000162")]
	public void UpdatePadControll(UIGamePad pad) { }

	[Address(RVA = "0x1E251F0", Offset = "0x1E245F0", Length = "0x67")]
	[IteratorStateMachine(typeof(<WaitAnimation>d__82))]
	[Token(Token = "0x600017E")]
	public IEnumerator WaitAnimation() { }

}

