namespace UnityEngine.InputForUI;

[Token(Token = "0x2000024")]
internal class InputManagerProvider : IEventProviderImpl
{
	[Token(Token = "0x2000025")]
	private struct ButtonEventsIterator : IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CA")]
		private uint _mask; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000CB")]
		private int _bit; //Field offset: 0x4

		[Token(Token = "0x17000033")]
		public bool Current
		{
			[Address(RVA = "0x3106AE0", Offset = "0x3105EE0", Length = "0x9")]
			[Token(Token = "0x60000AF")]
			 get { } //Length: 9
		}

		[Token(Token = "0x17000034")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x3106AB0", Offset = "0x3105EB0", Length = "0x26")]
			[Token(Token = "0x60000B2")]
			private get { } //Length: 38
		}

		[Address(RVA = "0x3106A00", Offset = "0x3105E00", Length = "0x5A")]
		[Token(Token = "0x60000B3")]
		public static ButtonEventsIterator FromState(bool previous, bool down, bool up, bool current) { }

		[Address(RVA = "0x3106AE0", Offset = "0x3105EE0", Length = "0x9")]
		[Token(Token = "0x60000AF")]
		public bool get_Current() { }

		[Address(RVA = "0x3106A60", Offset = "0x3105E60", Length = "0x31")]
		[Token(Token = "0x60000B0")]
		public override bool MoveNext() { }

		[Address(RVA = "0x3106AA0", Offset = "0x3105EA0", Length = "0x8")]
		[Token(Token = "0x60000B1")]
		public override void Reset() { }

		[Address(RVA = "0x3106AB0", Offset = "0x3105EB0", Length = "0x26")]
		[Token(Token = "0x60000B2")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x2000026")]
	internal struct Configuration
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CC")]
		public string HorizontalAxis; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000CD")]
		public string VerticalAxis; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CE")]
		public string SubmitButton; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000CF")]
		public string CancelButton; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000D0")]
		public string NavigateNextButton; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000D1")]
		public string NavigatePreviousButton; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40000D2")]
		public float InputActionsPerSecond; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40000D3")]
		public float RepeatDelay; //Field offset: 0x34

		[Address(RVA = "0x3106DD0", Offset = "0x31061D0", Length = "0x149")]
		[Token(Token = "0x60000B4")]
		public static Configuration GetDefaultConfiguration() { }

	}

	[Token(Token = "0x2000027")]
	public interface IInput
	{

		[Token(Token = "0x17000035")]
		public string compositionString
		{
			[Token(Token = "0x60000B5")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000039")]
		public Vector3 mousePosition
		{
			[Token(Token = "0x60000C1")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000038")]
		public bool mousePresent
		{
			[Token(Token = "0x60000BD")]
			 get { } //Length: 0
		}

		[Token(Token = "0x1700003A")]
		public Vector2 mouseScrollDelta
		{
			[Token(Token = "0x60000C2")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000037")]
		public int touchCount
		{
			[Token(Token = "0x60000BB")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000036")]
		public bool touchSupported
		{
			[Token(Token = "0x60000BA")]
			 get { } //Length: 0
		}

		[Token(Token = "0x60000B5")]
		public string get_compositionString() { }

		[Token(Token = "0x60000C1")]
		public Vector3 get_mousePosition() { }

		[Token(Token = "0x60000BD")]
		public bool get_mousePresent() { }

		[Token(Token = "0x60000C2")]
		public Vector2 get_mouseScrollDelta() { }

		[Token(Token = "0x60000BB")]
		public int get_touchCount() { }

		[Token(Token = "0x60000BA")]
		public bool get_touchSupported() { }

		[Token(Token = "0x60000B8")]
		public float GetAxisRaw(string axis) { }

		[Token(Token = "0x60000B7")]
		public bool GetButtonDown(string button) { }

		[Token(Token = "0x60000B6")]
		public bool GetKey(KeyCode keyCode) { }

		[Token(Token = "0x60000B9")]
		public PenData GetLastPenContactEvent() { }

		[Token(Token = "0x60000BE")]
		public bool GetMouseButton(int button) { }

		[Token(Token = "0x60000BF")]
		public bool GetMouseButtonDown(int button) { }

		[Token(Token = "0x60000C0")]
		public bool GetMouseButtonUp(int button) { }

		[Token(Token = "0x60000BC")]
		public Touch GetTouch(int index) { }

	}

	[Token(Token = "0x2000028")]
	private class Input : IInput
	{

		[Token(Token = "0x1700003B")]
		public override string compositionString
		{
			[Address(RVA = "0x310E590", Offset = "0x310D990", Length = "0x7")]
			[Token(Token = "0x60000C3")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700003F")]
		public override Vector3 mousePosition
		{
			[Address(RVA = "0x310E5A0", Offset = "0x310D9A0", Length = "0x2C")]
			[Token(Token = "0x60000CF")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700003E")]
		public override bool mousePresent
		{
			[Address(RVA = "0x310E5D0", Offset = "0x310D9D0", Length = "0x7")]
			[Token(Token = "0x60000CB")]
			 get { } //Length: 7
		}

		[Token(Token = "0x17000040")]
		public override Vector2 mouseScrollDelta
		{
			[Address(RVA = "0x310E5E0", Offset = "0x310D9E0", Length = "0x7")]
			[Token(Token = "0x60000D0")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700003D")]
		public override int touchCount
		{
			[Address(RVA = "0x310E5F0", Offset = "0x310D9F0", Length = "0x7")]
			[Token(Token = "0x60000C9")]
			 get { } //Length: 7
		}

		[Token(Token = "0x1700003C")]
		public override bool touchSupported
		{
			[Address(RVA = "0x310E600", Offset = "0x310DA00", Length = "0x7")]
			[Token(Token = "0x60000C8")]
			 get { } //Length: 7
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000D1")]
		public Input() { }

		[Address(RVA = "0x310E590", Offset = "0x310D990", Length = "0x7")]
		[Token(Token = "0x60000C3")]
		public override string get_compositionString() { }

		[Address(RVA = "0x310E5A0", Offset = "0x310D9A0", Length = "0x2C")]
		[Token(Token = "0x60000CF")]
		public override Vector3 get_mousePosition() { }

		[Address(RVA = "0x310E5D0", Offset = "0x310D9D0", Length = "0x7")]
		[Token(Token = "0x60000CB")]
		public override bool get_mousePresent() { }

		[Address(RVA = "0x310E5E0", Offset = "0x310D9E0", Length = "0x7")]
		[Token(Token = "0x60000D0")]
		public override Vector2 get_mouseScrollDelta() { }

		[Address(RVA = "0x310E5F0", Offset = "0x310D9F0", Length = "0x7")]
		[Token(Token = "0x60000C9")]
		public override int get_touchCount() { }

		[Address(RVA = "0x310E600", Offset = "0x310DA00", Length = "0x7")]
		[Token(Token = "0x60000C8")]
		public override bool get_touchSupported() { }

		[Address(RVA = "0x310E4A0", Offset = "0x310D8A0", Length = "0xA")]
		[Token(Token = "0x60000C6")]
		public override float GetAxisRaw(string axis) { }

		[Address(RVA = "0x310E4B0", Offset = "0x310D8B0", Length = "0xA")]
		[Token(Token = "0x60000C5")]
		public override bool GetButtonDown(string button) { }

		[Address(RVA = "0x310E4C0", Offset = "0x310D8C0", Length = "0x9")]
		[Token(Token = "0x60000C4")]
		public override bool GetKey(KeyCode key) { }

		[Address(RVA = "0x310E4D0", Offset = "0x310D8D0", Length = "0x36")]
		[Token(Token = "0x60000C7")]
		public override PenData GetLastPenContactEvent() { }

		[Address(RVA = "0x310E530", Offset = "0x310D930", Length = "0x9")]
		[Token(Token = "0x60000CC")]
		public override bool GetMouseButton(int button) { }

		[Address(RVA = "0x310E510", Offset = "0x310D910", Length = "0x9")]
		[Token(Token = "0x60000CD")]
		public override bool GetMouseButtonDown(int button) { }

		[Address(RVA = "0x310E520", Offset = "0x310D920", Length = "0x9")]
		[Token(Token = "0x60000CE")]
		public override bool GetMouseButtonUp(int button) { }

		[Address(RVA = "0x310E540", Offset = "0x310D940", Length = "0x46")]
		[Token(Token = "0x60000CA")]
		public override Touch GetTouch(int index) { }

	}

	[Token(Token = "0x2000029")]
	public interface ITime
	{

		[Token(Token = "0x17000041")]
		public RationalTime timeAsRational
		{
			[Token(Token = "0x60000D2")]
			 get { } //Length: 0
		}

		[Token(Token = "0x60000D2")]
		public RationalTime get_timeAsRational() { }

	}

	[Token(Token = "0x200002A")]
	private class Time : ITime
	{

		[Token(Token = "0x17000042")]
		public override RationalTime timeAsRational
		{
			[Address(RVA = "0x31101D0", Offset = "0x310F5D0", Length = "0x24")]
			[Token(Token = "0x60000D3")]
			 get { } //Length: 36
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000D4")]
		public Time() { }

		[Address(RVA = "0x31101D0", Offset = "0x310F5D0", Length = "0x24")]
		[Token(Token = "0x60000D3")]
		public override RationalTime get_timeAsRational() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000BB")]
	private InputEventPartialProvider _inputEventPartialProvider; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000BC")]
	private string _compositionString; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000BD")]
	private Configuration _configuration; //Field offset: 0x20
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000BE")]
	private IInput _input; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000BF")]
	private ITime _time; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000C0")]
	private NavigationEventRepeatHelper _navigationEventRepeatHelper; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000C1")]
	private PointerState _mouseState; //Field offset: 0x70
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000C2")]
	private bool _isPenPresent; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x40000C3")]
	private bool _seenAtLeastOnePenPosition; //Field offset: 0x99
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40000C4")]
	private Vector2 _lastSeenPenPositionForDetection; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000C5")]
	private PointerState _penState; //Field offset: 0xA8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000C6")]
	private PenData _lastPenData; //Field offset: 0xD0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40000C7")]
	private Dictionary<Int32, Int32> _touchFingerIdToFingerIndex; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40000C8")]
	private int _touchNextFingerIndex; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40000C9")]
	private PointerState _touchState; //Field offset: 0x108

	[Token(Token = "0x17000032")]
	private EventModifiers _eventModifiers
	{
		[Address(RVA = "0x28F7FB0", Offset = "0x28F73B0", Length = "0x1A")]
		[Token(Token = "0x6000091")]
		private get { } //Length: 26
	}

	[Address(RVA = "0x310E1A0", Offset = "0x310D5A0", Length = "0x2FA")]
	[Token(Token = "0x6000092")]
	public InputManagerProvider() { }

	[Address(RVA = "0xE22E20", Offset = "0xE22220", Length = "0xA0")]
	[Token(Token = "0x60000A9")]
	internal static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	[Address(RVA = "0x310AB60", Offset = "0x3109F60", Length = "0x2AE")]
	[Token(Token = "0x600009F")]
	private void CheckIfIMEChanged(DiscreteTime currentTime) { }

	[Address(RVA = "0x310AE10", Offset = "0x310A210", Length = "0x7A7")]
	[Token(Token = "0x600009A")]
	private void CheckMouseEvents(DiscreteTime currentTime, bool muted = false) { }

	[Address(RVA = "0x310B5C0", Offset = "0x310A9C0", Length = "0x41C")]
	[Token(Token = "0x600009B")]
	private void CheckMouseScroll(DiscreteTime currentTime) { }

	[Address(RVA = "0x310B9E0", Offset = "0x310ADE0", Length = "0x516")]
	[Token(Token = "0x6000099")]
	private bool CheckPenEvent(DiscreteTime currentTime, in PenData currentPenData) { }

	[Address(RVA = "0x310BF00", Offset = "0x310B300", Length = "0x717")]
	[Token(Token = "0x6000096")]
	private bool CheckTouchEvents(DiscreteTime currentTime) { }

	[Address(RVA = "0x310C620", Offset = "0x310BA20", Length = "0xB8")]
	[Token(Token = "0x6000097")]
	private void DetectPen() { }

	[Address(RVA = "0x310C6E0", Offset = "0x310BAE0", Length = "0x450")]
	[Token(Token = "0x600009E")]
	private void DirectionNavigation(DiscreteTime currentTime) { }

	[Address(RVA = "0x28F7FB0", Offset = "0x28F73B0", Length = "0x1A")]
	[Token(Token = "0x6000091")]
	private EventModifiers get__eventModifiers() { }

	[Address(RVA = "0x310CB40", Offset = "0x310BF40", Length = "0xF6")]
	[Token(Token = "0x60000A1")]
	private EventSource GetEventSourceFromPressedKey() { }

	[Address(RVA = "0x310CC40", Offset = "0x310C040", Length = "0x146")]
	[Token(Token = "0x6000093")]
	public override void Initialize() { }

	[Address(RVA = "0x310CD90", Offset = "0x310C190", Length = "0xE3")]
	[Token(Token = "0x60000A4")]
	private float InputManagerGetAxisRawOrDefault(string axisName) { }

	[Address(RVA = "0x310CE80", Offset = "0x310C280", Length = "0xE9")]
	[Token(Token = "0x60000A5")]
	private bool InputManagerGetButtonDownOrDefault(string axisName) { }

	[Address(RVA = "0x310CF70", Offset = "0x310C370", Length = "0x78")]
	[Token(Token = "0x60000A2")]
	private bool InputManagerJoystickWasPressed() { }

	[Address(RVA = "0x310CFF0", Offset = "0x310C3F0", Length = "0x78")]
	[Token(Token = "0x60000A3")]
	private bool InputManagerKeyboardWasPressed() { }

	[Address(RVA = "0x310D070", Offset = "0x310C470", Length = "0x28A")]
	[Token(Token = "0x60000AB")]
	private static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int targetDisplay) { }

	[Address(RVA = "0x310D300", Offset = "0x310C700", Length = "0x1AC")]
	[Token(Token = "0x60000AC")]
	private static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<Int32>& targetDisplay) { }

	[Address(RVA = "0x310D4B0", Offset = "0x310C8B0", Length = "0x1DA")]
	[Token(Token = "0x600009C")]
	private void NextPreviousNavigation(DiscreteTime currentTime) { }

	[Address(RVA = "0x310D690", Offset = "0x310CA90", Length = "0x33")]
	[Token(Token = "0x60000A0")]
	public override void OnFocusChanged(bool focus) { }

	[Address(RVA = "0x310D6D0", Offset = "0x310CAD0", Length = "0x1C")]
	[Token(Token = "0x6000098")]
	private static Button PenStatusToButton(PenStatus status) { }

	[Address(RVA = "0x310D6F0", Offset = "0x310CAF0", Length = "0x138")]
	[Token(Token = "0x60000A6")]
	private ValueTuple<Vector2, Boolean> ReadCurrentNavigationMoveVector() { }

	[Address(RVA = "0x310D830", Offset = "0x310CC30", Length = "0x1E")]
	[Token(Token = "0x60000AE")]
	private static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }

	[Address(RVA = "0x310D850", Offset = "0x310CC50", Length = "0xD5")]
	[Token(Token = "0x60000AD")]
	private static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000094")]
	public override void Shutdown() { }

	[Address(RVA = "0x310D930", Offset = "0x310CD30", Length = "0x2A9")]
	[Token(Token = "0x600009D")]
	private void SubmitCancelNavigation(DiscreteTime currentTime) { }

	[Address(RVA = "0xE26480", Offset = "0xE25880", Length = "0x4C")]
	[Token(Token = "0x60000AA")]
	internal static float TiltToAltitude(Vector2 tilt) { }

	[Address(RVA = "0xE264D0", Offset = "0xE258D0", Length = "0x102")]
	[Token(Token = "0x60000A8")]
	internal static float TiltToAzimuth(Vector2 tilt) { }

	[Address(RVA = "0x310DBE0", Offset = "0x310CFE0", Length = "0x8A")]
	[Token(Token = "0x60000A7")]
	private IMECompositionEvent ToIMECompositionEvent(DiscreteTime currentTime, string compositionString) { }

	[Address(RVA = "0x310DC70", Offset = "0x310D070", Length = "0x52F")]
	[Token(Token = "0x6000095")]
	public override void Update() { }

}

