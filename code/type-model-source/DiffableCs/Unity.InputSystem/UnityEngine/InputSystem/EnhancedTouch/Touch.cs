namespace UnityEngine.InputSystem.EnhancedTouch;

[Token(Token = "0x2000154")]
public struct Touch : IEquatable<Touch>
{
	[CompilerGenerated]
	[Token(Token = "0x2000158")]
	private sealed class <>c
	{
		[Token(Token = "0x400089F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40008A0")]
		public static TypedRestore<GlobalState> <>9__80_0; //Field offset: 0x8
		[Token(Token = "0x40008A1")]
		public static Action <>9__80_1; //Field offset: 0x10

		[Address(RVA = "0x2A00BC0", Offset = "0x29FFFC0", Length = "0x67")]
		[Token(Token = "0x6000F12")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000F13")]
		public <>c() { }

		[Address(RVA = "0x2A00A10", Offset = "0x29FFE10", Length = "0x183")]
		[Token(Token = "0x6000F14")]
		internal void <SaveAndResetState>b__80_0(ref GlobalState state) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000F15")]
		internal void <SaveAndResetState>b__80_1() { }

	}

	[Token(Token = "0x2000157")]
	public struct ExtraDataPerTouchState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400089D")]
		public Vector2 accumulatedDelta; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400089E")]
		public uint uniqueId; //Field offset: 0x8

	}

	[Token(Token = "0x2000156")]
	public struct FingerAndTouchState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000892")]
		public InputUpdateType updateMask; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000893")]
		public Finger[] fingers; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000894")]
		public Finger[] activeFingers; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000895")]
		public Touch[] activeTouches; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000896")]
		public int activeFingerCount; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000897")]
		public int activeTouchCount; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000898")]
		public int totalFingerCount; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000899")]
		public uint lastId; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400089A")]
		public bool haveBuiltActiveTouches; //Field offset: 0x30
		[FieldOffset(Offset = "0x31")]
		[Token(Token = "0x400089B")]
		public bool haveActiveTouchesNeedingRefreshNextUpdate; //Field offset: 0x31
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400089C")]
		public InputStateHistory<TouchState> activeTouchState; //Field offset: 0x38

		[Address(RVA = "0x29EF910", Offset = "0x29EED10", Length = "0x12F")]
		[Token(Token = "0x6000F0D")]
		public void AddFingers(Touchscreen screen) { }

		[Address(RVA = "0x29EFA40", Offset = "0x29EEE40", Length = "0x8F")]
		[Token(Token = "0x6000F0F")]
		public void Destroy() { }

		[Address(RVA = "0x29EFAD0", Offset = "0x29EEED0", Length = "0x155")]
		[Token(Token = "0x6000F0E")]
		public void RemoveFingers(Touchscreen screen) { }

		[Address(RVA = "0x29EFC30", Offset = "0x29EF030", Length = "0x158")]
		[Token(Token = "0x6000F10")]
		public void UpdateActiveFingers() { }

		[Address(RVA = "0x29EFD90", Offset = "0x29EF190", Length = "0x6D6")]
		[Token(Token = "0x6000F11")]
		public void UpdateActiveTouches() { }

	}

	[Token(Token = "0x2000155")]
	public struct GlobalState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400088C")]
		internal InlinedArray<Touchscreen> touchscreens; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400088D")]
		internal int historyLengthPerFinger; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400088E")]
		internal CallbackArray<Action`1<Finger>> onFingerDown; //Field offset: 0x20
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400088F")]
		internal CallbackArray<Action`1<Finger>> onFingerMove; //Field offset: 0x70
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000890")]
		internal CallbackArray<Action`1<Finger>> onFingerUp; //Field offset: 0xC0
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x4000891")]
		internal FingerAndTouchState playerState; //Field offset: 0x110

	}

	[Token(Token = "0x400088B")]
	internal static GlobalState s_GlobalState; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000889")]
	private readonly Finger m_Finger; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400088A")]
	internal Record<TouchState> m_TouchRecord; //Field offset: 0x8

	[Token(Token = "0x14000023")]
	public static event Action<Finger> onFingerDown
	{
		[Address(RVA = "0x29FF760", Offset = "0x29FEB60", Length = "0xB9")]
		[Token(Token = "0x6000EFB")]
		 add { } //Length: 185
		[Address(RVA = "0x2A006E0", Offset = "0x29FFAE0", Length = "0xB9")]
		[Token(Token = "0x6000EFC")]
		 remove { } //Length: 185
	}

	[Token(Token = "0x14000025")]
	public static event Action<Finger> onFingerMove
	{
		[Address(RVA = "0x29FF820", Offset = "0x29FEC20", Length = "0xB9")]
		[Token(Token = "0x6000EFF")]
		 add { } //Length: 185
		[Address(RVA = "0x2A007A0", Offset = "0x29FFBA0", Length = "0xB9")]
		[Token(Token = "0x6000F00")]
		 remove { } //Length: 185
	}

	[Token(Token = "0x14000024")]
	public static event Action<Finger> onFingerUp
	{
		[Address(RVA = "0x29FF8E0", Offset = "0x29FECE0", Length = "0xBC")]
		[Token(Token = "0x6000EFD")]
		 add { } //Length: 188
		[Address(RVA = "0x2A00860", Offset = "0x29FFC60", Length = "0xBC")]
		[Token(Token = "0x6000EFE")]
		 remove { } //Length: 188
	}

	[Token(Token = "0x1700040E")]
	public static ReadOnlyArray<Finger> activeFingers
	{
		[Address(RVA = "0x29FF9A0", Offset = "0x29FEDA0", Length = "0xA4")]
		[Token(Token = "0x6000EF9")]
		 get { } //Length: 164
	}

	[Token(Token = "0x1700040C")]
	public static ReadOnlyArray<Touch> activeTouches
	{
		[Address(RVA = "0x29FFA50", Offset = "0x29FEE50", Length = "0xA4")]
		[Token(Token = "0x6000EF7")]
		 get { } //Length: 164
	}

	[Token(Token = "0x170003F7")]
	public bool began
	{
		[Address(RVA = "0x29FFB00", Offset = "0x29FEF00", Length = "0x50")]
		[Token(Token = "0x6000EE2")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000402")]
	public Vector2 delta
	{
		[Address(RVA = "0x29FFB50", Offset = "0x29FEF50", Length = "0x7E")]
		[Token(Token = "0x6000EED")]
		 get { } //Length: 126
	}

	[Token(Token = "0x17000405")]
	public int displayIndex
	{
		[Address(RVA = "0x29FFBD0", Offset = "0x29FEFD0", Length = "0x70")]
		[Token(Token = "0x6000EF0")]
		 get { } //Length: 112
	}

	[Token(Token = "0x170003F9")]
	public bool ended
	{
		[Address(RVA = "0x29FFC40", Offset = "0x29FF040", Length = "0x7C")]
		[Token(Token = "0x6000EE4")]
		 get { } //Length: 124
	}

	[Token(Token = "0x1700040A")]
	private ExtraDataPerTouchState extraData
	{
		[Address(RVA = "0x29FFCC0", Offset = "0x29FF0C0", Length = "0x3A")]
		[Token(Token = "0x6000EF5")]
		private get { } //Length: 58
	}

	[Token(Token = "0x170003F5")]
	public Finger finger
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000EE0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700040D")]
	public static ReadOnlyArray<Finger> fingers
	{
		[Address(RVA = "0x29FFD00", Offset = "0x29FF100", Length = "0x88")]
		[Token(Token = "0x6000EF8")]
		 get { } //Length: 136
	}

	[Token(Token = "0x1700040B")]
	public TouchHistory history
	{
		[Address(RVA = "0x29FFD90", Offset = "0x29FF190", Length = "0x121")]
		[Token(Token = "0x6000EF6")]
		 get { } //Length: 289
	}

	[Token(Token = "0x170003F8")]
	public bool inProgress
	{
		[Address(RVA = "0x29FFEC0", Offset = "0x29FF2C0", Length = "0xA0")]
		[Token(Token = "0x6000EE3")]
		 get { } //Length: 160
	}

	[Token(Token = "0x17000406")]
	public bool isInProgress
	{
		[Address(RVA = "0x29FFF60", Offset = "0x29FF360", Length = "0x60")]
		[Token(Token = "0x6000EF1")]
		 get { } //Length: 96
	}

	[Token(Token = "0x17000404")]
	public bool isTap
	{
		[Address(RVA = "0x29FFFC0", Offset = "0x29FF3C0", Length = "0x73")]
		[Token(Token = "0x6000EEF")]
		 get { } //Length: 115
	}

	[Token(Token = "0x17000410")]
	public static int maxHistoryLengthPerFinger
	{
		[Address(RVA = "0x2A00040", Offset = "0x29FF440", Length = "0x4E")]
		[Token(Token = "0x6000F01")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170003F6")]
	public TouchPhase phase
	{
		[Address(RVA = "0x2A00090", Offset = "0x29FF490", Length = "0x70")]
		[Token(Token = "0x6000EE1")]
		 get { } //Length: 112
	}

	[Token(Token = "0x170003FB")]
	public float pressure
	{
		[Address(RVA = "0x2A00100", Offset = "0x29FF500", Length = "0x71")]
		[Token(Token = "0x6000EE6")]
		 get { } //Length: 113
	}

	[Token(Token = "0x170003FC")]
	public Vector2 radius
	{
		[Address(RVA = "0x2A00180", Offset = "0x29FF580", Length = "0x7E")]
		[Token(Token = "0x6000EE7")]
		 get { } //Length: 126
	}

	[Token(Token = "0x170003FF")]
	public Touchscreen screen
	{
		[Address(RVA = "0x2A00280", Offset = "0x29FF680", Length = "0x51")]
		[Token(Token = "0x6000EEA")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000400")]
	public Vector2 screenPosition
	{
		[Address(RVA = "0x2A00200", Offset = "0x29FF600", Length = "0x7E")]
		[Token(Token = "0x6000EEB")]
		 get { } //Length: 126
	}

	[Token(Token = "0x1700040F")]
	public static IEnumerable<Touchscreen> screens
	{
		[Address(RVA = "0x2A002E0", Offset = "0x29FF6E0", Length = "0x7B")]
		[Token(Token = "0x6000EFA")]
		 get { } //Length: 123
	}

	[Token(Token = "0x17000401")]
	public Vector2 startScreenPosition
	{
		[Address(RVA = "0x2A00360", Offset = "0x29FF760", Length = "0x7E")]
		[Token(Token = "0x6000EEC")]
		 get { } //Length: 126
	}

	[Token(Token = "0x170003FD")]
	public double startTime
	{
		[Address(RVA = "0x2A003E0", Offset = "0x29FF7E0", Length = "0x71")]
		[Token(Token = "0x6000EE8")]
		 get { } //Length: 113
	}

	[Token(Token = "0x17000409")]
	private TouchState state
	{
		[Address(RVA = "0x2A00460", Offset = "0x29FF860", Length = "0x3A")]
		[Token(Token = "0x6000EF4")]
		private get { } //Length: 58
	}

	[Token(Token = "0x17000403")]
	public int tapCount
	{
		[Address(RVA = "0x2A004A0", Offset = "0x29FF8A0", Length = "0x70")]
		[Token(Token = "0x6000EEE")]
		 get { } //Length: 112
	}

	[Token(Token = "0x170003FE")]
	public double time
	{
		[Address(RVA = "0x2A00510", Offset = "0x29FF910", Length = "0x3A")]
		[Token(Token = "0x6000EE9")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003FA")]
	public int touchId
	{
		[Address(RVA = "0x2A00550", Offset = "0x29FF950", Length = "0x6E")]
		[Token(Token = "0x6000EE5")]
		 get { } //Length: 110
	}

	[Token(Token = "0x17000408")]
	internal uint uniqueId
	{
		[Address(RVA = "0x2A005C0", Offset = "0x29FF9C0", Length = "0x6F")]
		[Token(Token = "0x6000EF3")]
		internal get { } //Length: 111
	}

	[Token(Token = "0x17000407")]
	internal uint updateStepCount
	{
		[Address(RVA = "0x2A00630", Offset = "0x29FFA30", Length = "0x6F")]
		[Token(Token = "0x6000EF2")]
		internal get { } //Length: 111
	}

	[Token(Token = "0x170003F4")]
	public bool valid
	{
		[Address(RVA = "0x2A006A0", Offset = "0x29FFAA0", Length = "0x3A")]
		[Token(Token = "0x6000EDF")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29FF660", Offset = "0x29FEA60", Length = "0xF7")]
	[Token(Token = "0x6000F0C")]
	private static Touch() { }

	[Address(RVA = "0xAEE2A0", Offset = "0xAED6A0", Length = "0x34")]
	[Token(Token = "0x6000F02")]
	internal Touch(Finger finger, Record<TouchState> touchRecord) { }

	[Address(RVA = "0x29FF760", Offset = "0x29FEB60", Length = "0xB9")]
	[Token(Token = "0x6000EFB")]
	public static void add_onFingerDown(Action<Finger> value) { }

	[Address(RVA = "0x29FF820", Offset = "0x29FEC20", Length = "0xB9")]
	[Token(Token = "0x6000EFF")]
	public static void add_onFingerMove(Action<Finger> value) { }

	[Address(RVA = "0x29FF8E0", Offset = "0x29FECE0", Length = "0xBC")]
	[Token(Token = "0x6000EFD")]
	public static void add_onFingerUp(Action<Finger> value) { }

	[Address(RVA = "0x29FEB30", Offset = "0x29FDF30", Length = "0x8E")]
	[Token(Token = "0x6000F07")]
	internal static void AddTouchscreen(Touchscreen screen) { }

	[Address(RVA = "0x29FEBC0", Offset = "0x29FDFC0", Length = "0x74")]
	[Token(Token = "0x6000F09")]
	internal static void BeginUpdate() { }

	[Address(RVA = "0x29FEC40", Offset = "0x29FE040", Length = "0x26")]
	[Token(Token = "0x6000F0A")]
	private static GlobalState CreateGlobalState() { }

	[Address(RVA = "0x29FED10", Offset = "0x29FE110", Length = "0x100")]
	[Token(Token = "0x6000F05")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x29FEC70", Offset = "0x29FE070", Length = "0x94")]
	[Token(Token = "0x6000F04")]
	public override bool Equals(Touch other) { }

	[Address(RVA = "0x29FF9A0", Offset = "0x29FEDA0", Length = "0xA4")]
	[Token(Token = "0x6000EF9")]
	public static ReadOnlyArray<Finger> get_activeFingers() { }

	[Address(RVA = "0x29FFA50", Offset = "0x29FEE50", Length = "0xA4")]
	[Token(Token = "0x6000EF7")]
	public static ReadOnlyArray<Touch> get_activeTouches() { }

	[Address(RVA = "0x29FFB00", Offset = "0x29FEF00", Length = "0x50")]
	[Token(Token = "0x6000EE2")]
	public bool get_began() { }

	[Address(RVA = "0x29FFB50", Offset = "0x29FEF50", Length = "0x7E")]
	[Token(Token = "0x6000EED")]
	public Vector2 get_delta() { }

	[Address(RVA = "0x29FFBD0", Offset = "0x29FEFD0", Length = "0x70")]
	[Token(Token = "0x6000EF0")]
	public int get_displayIndex() { }

	[Address(RVA = "0x29FFC40", Offset = "0x29FF040", Length = "0x7C")]
	[Token(Token = "0x6000EE4")]
	public bool get_ended() { }

	[Address(RVA = "0x29FFCC0", Offset = "0x29FF0C0", Length = "0x3A")]
	[Token(Token = "0x6000EF5")]
	private ExtraDataPerTouchState get_extraData() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000EE0")]
	public Finger get_finger() { }

	[Address(RVA = "0x29FFD00", Offset = "0x29FF100", Length = "0x88")]
	[Token(Token = "0x6000EF8")]
	public static ReadOnlyArray<Finger> get_fingers() { }

	[Address(RVA = "0x29FFD90", Offset = "0x29FF190", Length = "0x121")]
	[Token(Token = "0x6000EF6")]
	public TouchHistory get_history() { }

	[Address(RVA = "0x29FFEC0", Offset = "0x29FF2C0", Length = "0xA0")]
	[Token(Token = "0x6000EE3")]
	public bool get_inProgress() { }

	[Address(RVA = "0x29FFF60", Offset = "0x29FF360", Length = "0x60")]
	[Token(Token = "0x6000EF1")]
	public bool get_isInProgress() { }

	[Address(RVA = "0x29FFFC0", Offset = "0x29FF3C0", Length = "0x73")]
	[Token(Token = "0x6000EEF")]
	public bool get_isTap() { }

	[Address(RVA = "0x2A00040", Offset = "0x29FF440", Length = "0x4E")]
	[Token(Token = "0x6000F01")]
	public static int get_maxHistoryLengthPerFinger() { }

	[Address(RVA = "0x2A00090", Offset = "0x29FF490", Length = "0x70")]
	[Token(Token = "0x6000EE1")]
	public TouchPhase get_phase() { }

	[Address(RVA = "0x2A00100", Offset = "0x29FF500", Length = "0x71")]
	[Token(Token = "0x6000EE6")]
	public float get_pressure() { }

	[Address(RVA = "0x2A00180", Offset = "0x29FF580", Length = "0x7E")]
	[Token(Token = "0x6000EE7")]
	public Vector2 get_radius() { }

	[Address(RVA = "0x2A00280", Offset = "0x29FF680", Length = "0x51")]
	[Token(Token = "0x6000EEA")]
	public Touchscreen get_screen() { }

	[Address(RVA = "0x2A00200", Offset = "0x29FF600", Length = "0x7E")]
	[Token(Token = "0x6000EEB")]
	public Vector2 get_screenPosition() { }

	[Address(RVA = "0x2A002E0", Offset = "0x29FF6E0", Length = "0x7B")]
	[Token(Token = "0x6000EFA")]
	public static IEnumerable<Touchscreen> get_screens() { }

	[Address(RVA = "0x2A00360", Offset = "0x29FF760", Length = "0x7E")]
	[Token(Token = "0x6000EEC")]
	public Vector2 get_startScreenPosition() { }

	[Address(RVA = "0x2A003E0", Offset = "0x29FF7E0", Length = "0x71")]
	[Token(Token = "0x6000EE8")]
	public double get_startTime() { }

	[Address(RVA = "0x2A00460", Offset = "0x29FF860", Length = "0x3A")]
	[Token(Token = "0x6000EF4")]
	private TouchState get_state() { }

	[Address(RVA = "0x2A004A0", Offset = "0x29FF8A0", Length = "0x70")]
	[Token(Token = "0x6000EEE")]
	public int get_tapCount() { }

	[Address(RVA = "0x2A00510", Offset = "0x29FF910", Length = "0x3A")]
	[Token(Token = "0x6000EE9")]
	public double get_time() { }

	[Address(RVA = "0x2A00550", Offset = "0x29FF950", Length = "0x6E")]
	[Token(Token = "0x6000EE5")]
	public int get_touchId() { }

	[Address(RVA = "0x2A005C0", Offset = "0x29FF9C0", Length = "0x6F")]
	[Token(Token = "0x6000EF3")]
	internal uint get_uniqueId() { }

	[Address(RVA = "0x2A00630", Offset = "0x29FFA30", Length = "0x6F")]
	[Token(Token = "0x6000EF2")]
	internal uint get_updateStepCount() { }

	[Address(RVA = "0x2A006A0", Offset = "0x29FFAA0", Length = "0x3A")]
	[Token(Token = "0x6000EDF")]
	public bool get_valid() { }

	[Address(RVA = "0x29FEE20", Offset = "0x29FE220", Length = "0x6E")]
	[Token(Token = "0x6000F06")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A006E0", Offset = "0x29FFAE0", Length = "0xB9")]
	[Token(Token = "0x6000EFC")]
	public static void remove_onFingerDown(Action<Finger> value) { }

	[Address(RVA = "0x2A007A0", Offset = "0x29FFBA0", Length = "0xB9")]
	[Token(Token = "0x6000F00")]
	public static void remove_onFingerMove(Action<Finger> value) { }

	[Address(RVA = "0x2A00860", Offset = "0x29FFC60", Length = "0xBC")]
	[Token(Token = "0x6000EFE")]
	public static void remove_onFingerUp(Action<Finger> value) { }

	[Address(RVA = "0x29FEE90", Offset = "0x29FE290", Length = "0xCB")]
	[Token(Token = "0x6000F08")]
	internal static void RemoveTouchscreen(Touchscreen screen) { }

	[Address(RVA = "0x29FEF60", Offset = "0x29FE360", Length = "0x321")]
	[Token(Token = "0x6000F0B")]
	internal static ISavedState SaveAndResetState() { }

	[Address(RVA = "0x29FF290", Offset = "0x29FE690", Length = "0x3C1")]
	[Token(Token = "0x6000F03")]
	public virtual string ToString() { }

}

