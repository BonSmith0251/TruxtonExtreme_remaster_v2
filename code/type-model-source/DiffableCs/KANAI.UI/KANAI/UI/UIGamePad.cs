namespace KANAI.UI;

[DefaultExecutionOrder(-1)]
[Token(Token = "0x200001D")]
public class UIGamePad : MonoBehaviourSingleton<UIGamePad>
{
	[CompilerGenerated]
	[Token(Token = "0x2000020")]
	private sealed class <>c
	{
		[Token(Token = "0x40000CF")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000D0")]
		public static Func<Boolean, Boolean> <>9__24_0; //Field offset: 0x8
		[Token(Token = "0x40000D1")]
		public static Func<Gamepad, Int32> <>9__90_0; //Field offset: 0x10

		[Address(RVA = "0x1E17D80", Offset = "0x1E17180", Length = "0x67")]
		[Token(Token = "0x60000E7")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000E8")]
		public <>c() { }

		[Address(RVA = "0x1E17B70", Offset = "0x1E16F70", Length = "0x19")]
		[Token(Token = "0x60000EA")]
		internal int <get_DeviceIds>b__90_0(Gamepad p) { }

		[Address(RVA = "0xF59F30", Offset = "0xF59330", Length = "0x4")]
		[Token(Token = "0x60000E9")]
		internal bool <IsKeyboardPlayer>b__24_0(bool kp) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000021")]
	private sealed class <>c__DisplayClass21_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000D2")]
		public int playerNo; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000D3")]
		public UIGamePad <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000EB")]
		public <>c__DisplayClass21_0() { }

		[Address(RVA = "0x1E17C50", Offset = "0x1E17050", Length = "0x43")]
		[Token(Token = "0x60000EC")]
		internal bool <OnInputDeviceChange>b__1(Gamepad pad) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000022")]
	private sealed class <>c__DisplayClass21_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000D4")]
		public int playerNo; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000D5")]
		public UIGamePad <>4__this; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000ED")]
		public <>c__DisplayClass21_1() { }

		[Address(RVA = "0x1E17C50", Offset = "0x1E17050", Length = "0x43")]
		[Token(Token = "0x60000EE")]
		internal bool <OnInputDeviceChange>b__2(Gamepad pad) { }

	}

	[Token(Token = "0x200001E")]
	private enum ButtonIndex : int
	{
		iUP = 0,
		iDown = 1,
		iLeft = 2,
		iRight = 3,
		iTriangle = 4,
		iSquare = 5,
		iCircle = 6,
		iCross = 7,
		iL1 = 8,
		iR1 = 9,
		iL2 = 10,
		iR2 = 11,
		iL3 = 12,
		iR3 = 13,
		iStart = 14,
		iSelect = 15,
		iRUP = 16,
		iRDown = 17,
		iRLeft = 18,
		iRRight = 19,
	}

	[Flags]
	[Token(Token = "0x200001F")]
	internal enum Buttons : int
	{
		UP = 1,
		DOWN = 2,
		LEFT = 4,
		RIGHT = 8,
		TRIANGLE = 16,
		SQUARE = 32,
		CIRCLE = 64,
		CROSS = 128,
		L1 = 256,
		R1 = 512,
		L2 = 1024,
		R2 = 2048,
		L3 = 4096,
		R3 = 8192,
		START = 16384,
		SELECT = 32768,
		RUP = 65536,
		RDOWN = 131072,
		RLEFT = 262144,
		RRIGHT = 524288,
		None = 0,
		BUTTONS = 53232,
		SUBBUTTONS = 12288,
		DIRECTIONS = 15,
		RDIRECTIONS = 983040,
		ALL = 1048575,
		ASSIGN_BUTTONS = 4080,
	}

	[Token(Token = "0x400008D")]
	public const int GamePadMax = 2; //Field offset: 0x0
	[Token(Token = "0x400008E")]
	private static readonly int ButtonCountMax; //Field offset: 0x0
	[Token(Token = "0x400008F")]
	public const int NO_DEVICE_ID = -1; //Field offset: 0x0
	[Token(Token = "0x4000090")]
	public const int KEYBOARD_DEVICE_ID = -2; //Field offset: 0x0
	[Token(Token = "0x4000091")]
	private const int KeyboardDeviceId = 0; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400008B")]
	private bool <LastButtonPressWasKeyboard>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400008C")]
	private Boolean[] _keyboardPlayers; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000092")]
	private Dictionary<Int32, UIGamePadInfos[]> _ButtonDics; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000093")]
	private Buttons[] _isOnBits; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000094")]
	private Buttons[] _isOffBits; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000095")]
	private Buttons[] _isPresentBits; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000096")]
	private Buttons[] _isRapidBits; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000097")]
	private Buttons[] _isRepeatBits; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000098")]
	private Vector2[] _stickL; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000099")]
	private Vector2[] _stickR; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400009A")]
	private Int32[] _PadDeviceId; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400009B")]
	private Single[] _vibrationSecond; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400009C")]
	private bool _isDisableUpdate; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400009D")]
	protected UIKeyboardPad _keyboard; //Field offset: 0x88

	[Token(Token = "0x1700001E")]
	public Int32[] DeviceIds
	{
		[Address(RVA = "0x1E1FA40", Offset = "0x1E1EE40", Length = "0x15F")]
		[Token(Token = "0x60000DD")]
		 get { } //Length: 351
	}

	[Token(Token = "0x1700001C")]
	public bool HasGamepadConnected
	{
		[Address(RVA = "0x1E1FBA0", Offset = "0x1E1EFA0", Length = "0x3E")]
		[Token(Token = "0x600009D")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700001A")]
	public private bool LastButtonPressWasKeyboard
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600009A")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600009B")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700001B")]
	public int NumberOfConnectedGamepads
	{
		[Address(RVA = "0x1E1FBE0", Offset = "0x1E1EFE0", Length = "0x39")]
		[Token(Token = "0x600009C")]
		 get { } //Length: 57
	}

	[Token(Token = "0x1700001D")]
	public Int32[] PadDeviceId
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x60000DC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000D3")]
	private void _checkDisconnnet(ReadOnlyArray<Gamepad> allpads) { }

	[Address(RVA = "0x1E1E860", Offset = "0x1E1DC60", Length = "0x14D")]
	[Token(Token = "0x60000D0")]
	private void _clearPadStatus(int padno) { }

	[Address(RVA = "0x1E1EBF0", Offset = "0x1E1DFF0", Length = "0x2C3")]
	[Token(Token = "0x60000A4")]
	private void _updateButtonBit(Gamepad pad, int padNo, UIGamePadInfos[] lists, float deltaTime) { }

	[Address(RVA = "0x1E1EEC0", Offset = "0x1E1E2C0", Length = "0x563")]
	[Token(Token = "0x60000A2")]
	private void _updateButtons(ReadOnlyArray<Gamepad> allpads, float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000A6")]
	protected override void _updateDebugButtons() { }

	[Address(RVA = "0x1E1F430", Offset = "0x1E1E830", Length = "0x4A5")]
	[Token(Token = "0x60000A5")]
	private void _updateStick(Gamepad aPad, int tpadno) { }

	[Address(RVA = "0x1E1F8E0", Offset = "0x1E1ECE0", Length = "0x5C")]
	[Token(Token = "0x60000A3")]
	private void _updateVibration(float dt, int p) { }

	[Address(RVA = "0x1E1E7B0", Offset = "0x1E1DBB0", Length = "0xA0")]
	[Token(Token = "0x60000E5")]
	private static UIGamePad() { }

	[Address(RVA = "0x1E1E9B0", Offset = "0x1E1DDB0", Length = "0x238")]
	[Token(Token = "0x60000E4")]
	public UIGamePad() { }

	[Address(RVA = "0x1E1E670", Offset = "0x1E1DA70", Length = "0x59")]
	[CompilerGenerated]
	[Token(Token = "0x60000E6")]
	private bool <OnInputDeviceChange>b__21_0(Gamepad pad) { }

	[Address(RVA = "0x1E1AD60", Offset = "0x1E1A160", Length = "0x60")]
	[Token(Token = "0x60000AA")]
	public int AssignDeviceID(int playerNo, Buttons gamepadButton) { }

	[Address(RVA = "0x1E1ADC0", Offset = "0x1E1A1C0", Length = "0x2C")]
	[Token(Token = "0x60000AC")]
	public void AssignKeyboard(int playerNo) { }

	[Address(RVA = "0x1E1ADF0", Offset = "0x1E1A1F0", Length = "0x98")]
	[Token(Token = "0x60000A9")]
	public int AssignSingleDeviceID_OK(int playerNo) { }

	[Address(RVA = "0x1E1AE90", Offset = "0x1E1A290", Length = "0x7C")]
	[Token(Token = "0x60000DA")]
	public static Buttons CancelButtons() { }

	[Address(RVA = "0x1E1AF10", Offset = "0x1E1A310", Length = "0x260")]
	[Token(Token = "0x60000D5")]
	public static void ClearCounter() { }

	[Address(RVA = "0x1E1B180", Offset = "0x1E1A580", Length = "0x4D")]
	[Token(Token = "0x60000AE")]
	public void ClearKeyboardAssignment() { }

	[Address(RVA = "0x1E1F940", Offset = "0x1E1ED40", Length = "0xFE")]
	[Token(Token = "0x60000D2")]
	private UIGamePadInfos[] createGamePadButtonInfos() { }

	[Address(RVA = "0x1E1B4F0", Offset = "0x1E1A8F0", Length = "0x27E")]
	[Token(Token = "0x60000B2")]
	public Vector3 Direction(int padno = 2) { }

	[Address(RVA = "0x1E1B1D0", Offset = "0x1E1A5D0", Length = "0x316")]
	[Token(Token = "0x60000B4")]
	public Vector3 Direction2D(int padno = 2) { }

	[Address(RVA = "0x1E1B770", Offset = "0x1E1AB70", Length = "0x266")]
	[Token(Token = "0x60000D7")]
	public static void DownRepeat() { }

	[Address(RVA = "0x1E1B9E0", Offset = "0x1E1ADE0", Length = "0x70")]
	[Token(Token = "0x60000E1")]
	public static bool EnoughGamepadsForDualPlay() { }

	[Address(RVA = "0x1E1BA50", Offset = "0x1E1AE50", Length = "0x39")]
	[Token(Token = "0x60000E0")]
	public static int GamepadsCount() { }

	[Address(RVA = "0x1E1FA40", Offset = "0x1E1EE40", Length = "0x15F")]
	[Token(Token = "0x60000DD")]
	public Int32[] get_DeviceIds() { }

	[Address(RVA = "0x1E1FBA0", Offset = "0x1E1EFA0", Length = "0x3E")]
	[Token(Token = "0x600009D")]
	public bool get_HasGamepadConnected() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600009A")]
	public bool get_LastButtonPressWasKeyboard() { }

	[Address(RVA = "0x1E1FBE0", Offset = "0x1E1EFE0", Length = "0x39")]
	[Token(Token = "0x600009C")]
	public int get_NumberOfConnectedGamepads() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x60000DC")]
	public Int32[] get_PadDeviceId() { }

	[Address(RVA = "0x1E1BA90", Offset = "0x1E1AE90", Length = "0x179")]
	[Token(Token = "0x60000D1")]
	private Gamepad GetPad(int pno) { }

	[Address(RVA = "0x1E1BC10", Offset = "0x1E1B010", Length = "0x207")]
	[Token(Token = "0x600009E")]
	public override void Initialize() { }

	[Address(RVA = "0x1E1BE20", Offset = "0x1E1B220", Length = "0xB7")]
	[Token(Token = "0x60000C5")]
	public bool IsAny(int padno) { }

	[Address(RVA = "0x1E1BEE0", Offset = "0x1E1B2E0", Length = "0x45C")]
	[Token(Token = "0x60000E2")]
	protected override bool IsButtonOn(Gamepad aPad, Buttons target) { }

	[Address(RVA = "0x1E1C340", Offset = "0x1E1B740", Length = "0x10E")]
	[Token(Token = "0x60000C3")]
	public bool IsCancel(int padno) { }

	[Address(RVA = "0x1E1C450", Offset = "0x1E1B850", Length = "0x142")]
	[Token(Token = "0x60000D4")]
	private bool IsEnableDevice(ReadOnlyArray<Gamepad> allpads, int deviceID) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60000E3")]
	protected override bool IsKeyboardOn(Buttons target) { }

	[Address(RVA = "0x1E1C760", Offset = "0x1E1BB60", Length = "0x16D")]
	[Token(Token = "0x60000AD")]
	public bool IsKeyboardPlayer(int playerNo) { }

	[Address(RVA = "0x1E1C5A0", Offset = "0x1E1B9A0", Length = "0x21")]
	[Token(Token = "0x60000CB")]
	public bool IsKeyCancel() { }

	[Address(RVA = "0x1E1C5D0", Offset = "0x1E1B9D0", Length = "0x5A")]
	[Token(Token = "0x60000CA")]
	public bool IsKeyOk() { }

	[Address(RVA = "0x1E1C630", Offset = "0x1E1BA30", Length = "0x1C")]
	[Token(Token = "0x60000C6")]
	public override bool IsKeyOn(UIKeyboard code) { }

	[Address(RVA = "0x1E1C650", Offset = "0x1E1BA50", Length = "0x3A")]
	[Token(Token = "0x60000C7")]
	public override bool IsKeyOn(Buttons tbtn) { }

	[Address(RVA = "0x1E1C690", Offset = "0x1E1BA90", Length = "0x1C")]
	[Token(Token = "0x60000C8")]
	public override bool IsKeyPresent(UIKeyboard code) { }

	[Address(RVA = "0x1E1C6B0", Offset = "0x1E1BAB0", Length = "0xAB")]
	[Token(Token = "0x60000C9")]
	public override bool IsKeyPresent(Buttons tbtn) { }

	[Address(RVA = "0x1E1C9F0", Offset = "0x1E1BDF0", Length = "0x2E")]
	[Token(Token = "0x60000BD")]
	public bool IsOff(Buttons target, int padno) { }

	[Address(RVA = "0x1E1C9C0", Offset = "0x1E1BDC0", Length = "0x2B")]
	[Token(Token = "0x60000B8")]
	public Buttons IsOffBit(int padno) { }

	[Address(RVA = "0x1E1C8D0", Offset = "0x1E1BCD0", Length = "0xE8")]
	[Token(Token = "0x60000C2")]
	public bool IsOK(int padno) { }

	[Address(RVA = "0x1E1CA90", Offset = "0x1E1BE90", Length = "0x2E")]
	[Token(Token = "0x60000BC")]
	public bool IsOn(Buttons target, int padno) { }

	[Address(RVA = "0x1E1CA20", Offset = "0x1E1BE20", Length = "0x2B")]
	[Token(Token = "0x60000B7")]
	public Buttons IsOnBit(int padno) { }

	[Address(RVA = "0x1E1CA50", Offset = "0x1E1BE50", Length = "0x31")]
	[Token(Token = "0x60000BE")]
	public bool IsOnSameTime(Buttons target, int padno) { }

	[Address(RVA = "0x1E1CAF0", Offset = "0x1E1BEF0", Length = "0x2E")]
	[Token(Token = "0x60000BF")]
	public bool IsPresent(Buttons target, int padno) { }

	[Address(RVA = "0x1E1CAC0", Offset = "0x1E1BEC0", Length = "0x2B")]
	[Token(Token = "0x60000B9")]
	public Buttons IsPresentBit(int padno) { }

	[Address(RVA = "0x1E1CB50", Offset = "0x1E1BF50", Length = "0x2E")]
	[Token(Token = "0x60000C0")]
	public bool IsRapid(Buttons target, int padno) { }

	[Address(RVA = "0x1E1CB20", Offset = "0x1E1BF20", Length = "0x2B")]
	[Token(Token = "0x60000BB")]
	public Buttons IsRapidBit(int padno) { }

	[Address(RVA = "0x1E1CBB0", Offset = "0x1E1BFB0", Length = "0x2E")]
	[Token(Token = "0x60000C1")]
	public bool IsRepeat(Buttons target, int padno) { }

	[Address(RVA = "0x1E1CB80", Offset = "0x1E1BF80", Length = "0x2B")]
	[Token(Token = "0x60000BA")]
	public Buttons IsRepeatBit(int padno) { }

	[Address(RVA = "0x1E1BE20", Offset = "0x1E1B220", Length = "0xB7")]
	[Token(Token = "0x60000C4")]
	public bool IsSkip(int padno) { }

	[Address(RVA = "0x1E1CBE0", Offset = "0x1E1BFE0", Length = "0xFA")]
	[Token(Token = "0x60000CE")]
	public static bool IsTouched() { }

	[Address(RVA = "0x1E1CCE0", Offset = "0x1E1C0E0", Length = "0x13C")]
	[Token(Token = "0x60000CC")]
	private Vector2 LStickKeyBoard(Vector2 tvec) { }

	[Address(RVA = "0x1E1CEA0", Offset = "0x1E1C2A0", Length = "0x7C")]
	[Token(Token = "0x60000D8")]
	public static Buttons OKButtons() { }

	[Address(RVA = "0x1E1CE20", Offset = "0x1E1C220", Length = "0x72")]
	[Token(Token = "0x60000D9")]
	private ButtonIndex OKButtonsIndex() { }

	[Address(RVA = "0x1E1CF20", Offset = "0x1E1C320", Length = "0x4E1")]
	[Token(Token = "0x60000AB")]
	public void OnInputDeviceChange() { }

	[Address(RVA = "0x1E1D410", Offset = "0x1E1C810", Length = "0x23E")]
	[Token(Token = "0x60000CF")]
	public static bool PresentTouchedPosition(out Vector3 tpos) { }

	[Address(RVA = "0x1E1D650", Offset = "0x1E1CA50", Length = "0x288")]
	[Token(Token = "0x60000B3")]
	public Vector3 RDirection(int padno = 2) { }

	[Address(RVA = "0x1E1DA20", Offset = "0x1E1CE20", Length = "0x21")]
	[Token(Token = "0x60000DF")]
	public string RecoverKeyboardSprite(Buttons asButton) { }

	[Address(RVA = "0x1E1DA50", Offset = "0x1E1CE50", Length = "0x266")]
	[Token(Token = "0x60000D6")]
	public static void ResetRepeat() { }

	[Address(RVA = "0x1E1D8E0", Offset = "0x1E1CCE0", Length = "0x13C")]
	[Token(Token = "0x60000CD")]
	private Vector2 RStickKeyBoard(Vector2 tvec) { }

	[Address(RVA = "0x1E1DCC0", Offset = "0x1E1D0C0", Length = "0x3B4")]
	[Token(Token = "0x60000A8")]
	public int SearchDeviceID(Buttons button) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600009B")]
	private void set_LastButtonPressWasKeyboard(bool value) { }

	[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
	[Token(Token = "0x60000A0")]
	public void SetDisableUpdate(bool tflag) { }

	[Address(RVA = "0x1E1E080", Offset = "0x1E1D480", Length = "0xE7")]
	[Token(Token = "0x60000A7")]
	public void SetPadDeviceId(int playerNo, int deviceId, bool clearOldAssignments = true) { }

	[Address(RVA = "0x1E1E240", Offset = "0x1E1D640", Length = "0xEB")]
	[Token(Token = "0x60000AF")]
	public void SetVibration(int padno, float nlow, float nhigh, float nsecond) { }

	[Address(RVA = "0x1E1E170", Offset = "0x1E1D570", Length = "0xC6")]
	[Token(Token = "0x60000B0")]
	public void SetVibrationAndTime(int padno, float nlow, float nhigh, float nsecond) { }

	[Address(RVA = "0x1E1E330", Offset = "0x1E1D730", Length = "0x45")]
	[Token(Token = "0x60000DB")]
	public static Buttons SkipButtons() { }

	[Address(RVA = "0x1E1E380", Offset = "0x1E1D780", Length = "0x66")]
	[Token(Token = "0x60000B6")]
	public Vector2 StickL(int padno = -1) { }

	[Address(RVA = "0x1E1E3F0", Offset = "0x1E1D7F0", Length = "0x66")]
	[Token(Token = "0x60000B5")]
	public Vector2 StickR(int padno = -1) { }

	[Address(RVA = "0x1E1E460", Offset = "0x1E1D860", Length = "0x68")]
	[Token(Token = "0x60000B1")]
	public void StopVibration(int padno) { }

	[Address(RVA = "0x1E1E4D0", Offset = "0x1E1D8D0", Length = "0x196")]
	[Token(Token = "0x600009F")]
	public void Terminate() { }

	[Address(RVA = "0x1E1E6D0", Offset = "0x1E1DAD0", Length = "0x78")]
	[Token(Token = "0x60000DE")]
	public bool UIIsEmulatedByKeyboard() { }

	[Address(RVA = "0x1E1E750", Offset = "0x1E1DB50", Length = "0x59")]
	[Token(Token = "0x60000A1")]
	public void UpdateButtonsAndSticks(float dt) { }

}

