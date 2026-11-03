namespace UnityEngine.InputSystem.HID;

[Token(Token = "0x200013C")]
public class HID : InputDevice
{
	[CompilerGenerated]
	[Token(Token = "0x200014A")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400084D")]
		public HIDLayoutBuilder layout; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000EB9")]
		public <>c__DisplayClass13_0() { }

		[Address(RVA = "0x2A00BA0", Offset = "0x29FFFA0", Length = "0x1D")]
		[Token(Token = "0x6000EBA")]
		internal InputControlLayout <OnFindLayoutForDevice>b__0() { }

	}

	[Token(Token = "0x2000149")]
	internal enum Button : int
	{
		Undefined = 0,
		Primary = 1,
		Secondary = 2,
		Tertiary = 3,
	}

	[Token(Token = "0x2000147")]
	internal enum GenericDesktop : int
	{
		Undefined = 0,
		Pointer = 1,
		Mouse = 2,
		Joystick = 4,
		Gamepad = 5,
		Keyboard = 6,
		Keypad = 7,
		MultiAxisController = 8,
		TabletPCControls = 9,
		AssistiveControl = 10,
		X = 48,
		Y = 49,
		Z = 50,
		Rx = 51,
		Ry = 52,
		Rz = 53,
		Slider = 54,
		Dial = 55,
		Wheel = 56,
		HatSwitch = 57,
		CountedBuffer = 58,
		ByteCount = 59,
		MotionWakeup = 60,
		Start = 61,
		Select = 62,
		Vx = 64,
		Vy = 65,
		Vz = 66,
		Vbrx = 67,
		Vbry = 68,
		Vbrz = 69,
		Vno = 70,
		FeatureNotification = 71,
		ResolutionMultiplier = 72,
		SystemControl = 128,
		SystemPowerDown = 129,
		SystemSleep = 130,
		SystemWakeUp = 131,
		SystemContextMenu = 132,
		SystemMainMenu = 133,
		SystemAppMenu = 134,
		SystemMenuHelp = 135,
		SystemMenuExit = 136,
		SystemMenuSelect = 137,
		SystemMenuRight = 138,
		SystemMenuLeft = 139,
		SystemMenuUp = 140,
		SystemMenuDown = 141,
		SystemColdRestart = 142,
		SystemWarmRestart = 143,
		DpadUp = 144,
		DpadDown = 145,
		DpadRight = 146,
		DpadLeft = 147,
		SystemDock = 160,
		SystemUndock = 161,
		SystemSetup = 162,
		SystemBreak = 163,
		SystemDebuggerBreak = 164,
		ApplicationBreak = 165,
		ApplicationDebuggerBreak = 166,
		SystemSpeakerMute = 167,
		SystemHibernate = 168,
		SystemDisplayInvert = 176,
		SystemDisplayInternal = 177,
		SystemDisplayExternal = 178,
		SystemDisplayBoth = 179,
		SystemDisplayDual = 180,
		SystemDisplayToggleIntExt = 181,
		SystemDisplaySwapPrimarySecondary = 182,
		SystemDisplayLCDAutoScale = 183,
	}

	[Token(Token = "0x2000143")]
	internal struct HIDCollectionDescriptor
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000798")]
		public HIDCollectionType type; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000799")]
		public int usage; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400079A")]
		public UsagePage usagePage; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400079B")]
		public int parent; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400079C")]
		public int childCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400079D")]
		public int firstChild; //Field offset: 0x14

	}

	[Token(Token = "0x2000140")]
	internal enum HIDCollectionType : int
	{
		Physical = 0,
		Application = 1,
		Logical = 2,
		Report = 3,
		NamedArray = 4,
		UsageSwitch = 5,
		UsageModifier = 6,
	}

	[Token(Token = "0x2000144")]
	internal struct HIDDeviceDescriptor
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400079E")]
		public int vendorId; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400079F")]
		public int productId; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007A0")]
		public int usage; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40007A1")]
		public UsagePage usagePage; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007A2")]
		public int inputReportSize; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40007A3")]
		public int outputReportSize; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007A4")]
		public int featureReportSize; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007A5")]
		public HIDElementDescriptor[] elements; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007A6")]
		public HIDCollectionDescriptor[] collections; //Field offset: 0x28

		[Address(RVA = "0x29F2190", Offset = "0x29F1590", Length = "0x1076")]
		[Token(Token = "0x6000EB0")]
		public static HIDDeviceDescriptor FromJson(string json) { }

		[Address(RVA = "0x29F3210", Offset = "0x29F2610", Length = "0x63")]
		[Token(Token = "0x6000EAF")]
		public string ToJson() { }

	}

	[Token(Token = "0x2000145")]
	internal struct HIDDeviceDescriptorBuilder
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007A7")]
		public UsagePage usagePage; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40007A8")]
		public int usage; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007A9")]
		private int m_CurrentReportId; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40007AA")]
		private HIDReportType m_CurrentReportType; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007AB")]
		private int m_CurrentReportOffsetInBits; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007AC")]
		private List<HIDElementDescriptor> m_Elements; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007AD")]
		private List<HIDCollectionDescriptor> m_Collections; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007AE")]
		private int m_InputReportSize; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40007AF")]
		private int m_OutputReportSize; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40007B0")]
		private int m_FeatureReportSize; //Field offset: 0x30

		[Address(RVA = "0x29F2160", Offset = "0x29F1560", Length = "0x21")]
		[Token(Token = "0x6000EB1")]
		public HIDDeviceDescriptorBuilder(UsagePage usagePage, int usage) { }

		[Address(RVA = "0x29F2130", Offset = "0x29F1530", Length = "0x24")]
		[Token(Token = "0x6000EB2")]
		public HIDDeviceDescriptorBuilder(GenericDesktop usage) { }

		[Address(RVA = "0x29F18C0", Offset = "0x29F0CC0", Length = "0x3CA")]
		[Token(Token = "0x6000EB4")]
		public HIDDeviceDescriptorBuilder AddElement(UsagePage usagePage, int usage, int sizeInBits) { }

		[Address(RVA = "0x29F1C90", Offset = "0x29F1090", Length = "0x53")]
		[Token(Token = "0x6000EB5")]
		public HIDDeviceDescriptorBuilder AddElement(GenericDesktop usage, int sizeInBits) { }

		[Address(RVA = "0x29F1CF0", Offset = "0x29F10F0", Length = "0xBD")]
		[Token(Token = "0x6000EB8")]
		public HIDDeviceDescriptor Finish() { }

		[Address(RVA = "0x29F1DB0", Offset = "0x29F11B0", Length = "0x33")]
		[Token(Token = "0x6000EB3")]
		public HIDDeviceDescriptorBuilder StartReport(HIDReportType reportType, int reportId = 1) { }

		[Address(RVA = "0x29F1DF0", Offset = "0x29F11F0", Length = "0x192")]
		[Token(Token = "0x6000EB7")]
		public HIDDeviceDescriptorBuilder WithLogicalMinMax(int min, int max) { }

		[Address(RVA = "0x29F1F90", Offset = "0x29F1390", Length = "0x192")]
		[Token(Token = "0x6000EB6")]
		public HIDDeviceDescriptorBuilder WithPhysicalMinMax(int min, int max) { }

	}

	[Token(Token = "0x2000142")]
	internal struct HIDElementDescriptor
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000788")]
		public int usage; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000789")]
		public UsagePage usagePage; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400078A")]
		public int unit; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400078B")]
		public int unitExponent; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400078C")]
		public int logicalMin; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400078D")]
		public int logicalMax; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400078E")]
		public int physicalMin; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400078F")]
		public int physicalMax; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000790")]
		public HIDReportType reportType; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000791")]
		public int collectionIndex; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000792")]
		public int reportId; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000793")]
		public int reportSizeInBits; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000794")]
		public int reportOffsetInBits; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000795")]
		public HIDElementFlags flags; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000796")]
		public Nullable<Int32> usageMin; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000797")]
		public Nullable<Int32> usageMax; //Field offset: 0x40

		[Token(Token = "0x170003E1")]
		public bool hasNullState
		{
			[Address(RVA = "0x29F4550", Offset = "0x29F3950", Length = "0x9")]
			[Token(Token = "0x6000E99")]
			 get { } //Length: 9
		}

		[Token(Token = "0x170003E2")]
		public bool hasPreferredState
		{
			[Address(RVA = "0x29F4560", Offset = "0x29F3960", Length = "0xB")]
			[Token(Token = "0x6000E9A")]
			 get { } //Length: 11
		}

		[Token(Token = "0x170003E3")]
		public bool isArray
		{
			[Address(RVA = "0x29F4570", Offset = "0x29F3970", Length = "0xA")]
			[Token(Token = "0x6000E9B")]
			 get { } //Length: 10
		}

		[Token(Token = "0x170003E6")]
		public bool isConstant
		{
			[Address(RVA = "0x27217E0", Offset = "0x2720BE0", Length = "0x7")]
			[Token(Token = "0x6000E9E")]
			 get { } //Length: 7
		}

		[Token(Token = "0x170003E4")]
		public bool isNonLinear
		{
			[Address(RVA = "0x29F4580", Offset = "0x29F3980", Length = "0x9")]
			[Token(Token = "0x6000E9C")]
			 get { } //Length: 9
		}

		[Token(Token = "0x170003E5")]
		public bool isRelative
		{
			[Address(RVA = "0x29F4590", Offset = "0x29F3990", Length = "0x9")]
			[Token(Token = "0x6000E9D")]
			 get { } //Length: 9
		}

		[Token(Token = "0x170003E8")]
		internal bool isSigned
		{
			[Address(RVA = "0x29F45A0", Offset = "0x29F39A0", Length = "0x7")]
			[Token(Token = "0x6000EA0")]
			internal get { } //Length: 7
		}

		[Token(Token = "0x170003E7")]
		public bool isWrapping
		{
			[Address(RVA = "0x29F45B0", Offset = "0x29F39B0", Length = "0x9")]
			[Token(Token = "0x6000E9F")]
			 get { } //Length: 9
		}

		[Token(Token = "0x170003EA")]
		internal float maxFloatValue
		{
			[Address(RVA = "0x29F45C0", Offset = "0x29F39C0", Length = "0xD3")]
			[Token(Token = "0x6000EA2")]
			internal get { } //Length: 211
		}

		[Token(Token = "0x170003E9")]
		internal float minFloatValue
		{
			[Address(RVA = "0x29F46A0", Offset = "0x29F3AA0", Length = "0xD3")]
			[Token(Token = "0x6000EA1")]
			internal get { } //Length: 211
		}

		[Address(RVA = "0x29F3280", Offset = "0x29F2680", Length = "0x756")]
		[Token(Token = "0x6000EAE")]
		internal void AddChildControls(ref HIDElementDescriptor element, string controlName, ref Builder builder) { }

		[Address(RVA = "0x29F39E0", Offset = "0x29F2DE0", Length = "0x197")]
		[Token(Token = "0x6000EAB")]
		private string DetermineAxisNormalizationParameters() { }

		[Address(RVA = "0x29F3B80", Offset = "0x29F2F80", Length = "0xC4")]
		[Token(Token = "0x6000EAD")]
		internal PrimitiveValue DetermineDefaultState() { }

		[Address(RVA = "0x29F3C70", Offset = "0x29F3070", Length = "0xC0")]
		[Token(Token = "0x6000EA5")]
		internal string DetermineDisplayName() { }

		[Address(RVA = "0x29F3D30", Offset = "0x29F3130", Length = "0x176")]
		[Token(Token = "0x6000EA8")]
		internal FourCC DetermineFormat() { }

		[Address(RVA = "0x29F3EB0", Offset = "0x29F32B0", Length = "0xC4")]
		[Token(Token = "0x6000EA7")]
		internal string DetermineLayout() { }

		[Address(RVA = "0x29F3FA0", Offset = "0x29F33A0", Length = "0x1D7")]
		[Token(Token = "0x6000EA4")]
		internal string DetermineName() { }

		[Address(RVA = "0x29F4180", Offset = "0x29F3580", Length = "0x11C")]
		[Token(Token = "0x6000EAA")]
		internal string DetermineParameters() { }

		[Address(RVA = "0x29F42C0", Offset = "0x29F36C0", Length = "0x52")]
		[Token(Token = "0x6000EAC")]
		internal string DetermineProcessors() { }

		[Address(RVA = "0x29F4320", Offset = "0x29F3720", Length = "0x1EE")]
		[Token(Token = "0x6000EA9")]
		internal InternedString[] DetermineUsages() { }

		[Address(RVA = "0x29F4550", Offset = "0x29F3950", Length = "0x9")]
		[Token(Token = "0x6000E99")]
		public bool get_hasNullState() { }

		[Address(RVA = "0x29F4560", Offset = "0x29F3960", Length = "0xB")]
		[Token(Token = "0x6000E9A")]
		public bool get_hasPreferredState() { }

		[Address(RVA = "0x29F4570", Offset = "0x29F3970", Length = "0xA")]
		[Token(Token = "0x6000E9B")]
		public bool get_isArray() { }

		[Address(RVA = "0x27217E0", Offset = "0x2720BE0", Length = "0x7")]
		[Token(Token = "0x6000E9E")]
		public bool get_isConstant() { }

		[Address(RVA = "0x29F4580", Offset = "0x29F3980", Length = "0x9")]
		[Token(Token = "0x6000E9C")]
		public bool get_isNonLinear() { }

		[Address(RVA = "0x29F4590", Offset = "0x29F3990", Length = "0x9")]
		[Token(Token = "0x6000E9D")]
		public bool get_isRelative() { }

		[Address(RVA = "0x29F45A0", Offset = "0x29F39A0", Length = "0x7")]
		[Token(Token = "0x6000EA0")]
		internal bool get_isSigned() { }

		[Address(RVA = "0x29F45B0", Offset = "0x29F39B0", Length = "0x9")]
		[Token(Token = "0x6000E9F")]
		public bool get_isWrapping() { }

		[Address(RVA = "0x29F45C0", Offset = "0x29F39C0", Length = "0xD3")]
		[Token(Token = "0x6000EA2")]
		internal float get_maxFloatValue() { }

		[Address(RVA = "0x29F46A0", Offset = "0x29F3AA0", Length = "0xD3")]
		[Token(Token = "0x6000EA1")]
		internal float get_minFloatValue() { }

		[Address(RVA = "0x29F4540", Offset = "0x29F3940", Length = "0xF")]
		[Token(Token = "0x6000EA3")]
		public bool Is(UsagePage usagePage, int usage) { }

		[Address(RVA = "0x29F4510", Offset = "0x29F3910", Length = "0x2C")]
		[Token(Token = "0x6000EA6")]
		internal bool IsUsableElement() { }

	}

	[Flags]
	[Token(Token = "0x2000141")]
	internal enum HIDElementFlags : int
	{
		Constant = 1,
		Variable = 2,
		Relative = 4,
		Wrap = 8,
		NonLinear = 16,
		NoPreferred = 32,
		NullState = 64,
		Volatile = 128,
		BufferedBytes = 256,
	}

	[Token(Token = "0x200013D")]
	private class HIDLayoutBuilder
	{
		[CompilerGenerated]
		[Token(Token = "0x200013E")]
		private sealed class <>c
		{
			[Token(Token = "0x400076D")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x400076E")]
			public static Predicate<HIDElementDescriptor> <>9__4_0; //Field offset: 0x8
			[Token(Token = "0x400076F")]
			public static Predicate<HIDElementDescriptor> <>9__4_1; //Field offset: 0x10
			[Token(Token = "0x4000770")]
			public static Func<ControlItem, String> <>9__4_2; //Field offset: 0x18

			[Address(RVA = "0x2A00C30", Offset = "0x2A00030", Length = "0x67")]
			[Token(Token = "0x6000E94")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000E95")]
			public <>c() { }

			[Address(RVA = "0x2A009B0", Offset = "0x29FFDB0", Length = "0x1C")]
			[Token(Token = "0x6000E96")]
			internal bool <Build>b__4_0(HIDElementDescriptor element) { }

			[Address(RVA = "0x2A009D0", Offset = "0x29FFDD0", Length = "0x1C")]
			[Token(Token = "0x6000E97")]
			internal bool <Build>b__4_1(HIDElementDescriptor element) { }

			[Address(RVA = "0x2A009F0", Offset = "0x29FFDF0", Length = "0x1D")]
			[Token(Token = "0x6000E98")]
			internal string <Build>b__4_2(ControlItem x) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000769")]
		public string displayName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400076A")]
		public HIDDeviceDescriptor hidDescriptor; //Field offset: 0x18
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400076B")]
		public string parentLayout; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400076C")]
		public Type deviceType; //Field offset: 0x50

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E93")]
		public HIDLayoutBuilder() { }

		[Address(RVA = "0x29D63C0", Offset = "0x29D57C0", Length = "0xF38")]
		[Token(Token = "0x6000E92")]
		public InputControlLayout Build() { }

	}

	[Token(Token = "0x200013F")]
	internal enum HIDReportType : int
	{
		Unknown = 0,
		Input = 1,
		Output = 2,
		Feature = 3,
	}

	[Token(Token = "0x2000148")]
	internal enum Simulation : int
	{
		Undefined = 0,
		FlightSimulationDevice = 1,
		AutomobileSimulationDevice = 2,
		TankSimulationDevice = 3,
		SpaceshipSimulationDevice = 4,
		SubmarineSimulationDevice = 5,
		SailingSimulationDevice = 6,
		MotorcycleSimulationDevice = 7,
		SportsSimulationDevice = 8,
		AirplaneSimulationDevice = 9,
		HelicopterSimulationDevice = 10,
		MagicCarpetSimulationDevice = 11,
		BicylcleSimulationDevice = 12,
		FlightControlStick = 32,
		FlightStick = 33,
		CyclicControl = 34,
		CyclicTrim = 35,
		FlightYoke = 36,
		TrackControl = 37,
		Aileron = 176,
		AileronTrim = 177,
		AntiTorqueControl = 178,
		AutopilotEnable = 179,
		ChaffRelease = 180,
		CollectiveControl = 181,
		DiveBreak = 182,
		ElectronicCountermeasures = 183,
		Elevator = 184,
		ElevatorTrim = 185,
		Rudder = 186,
		Throttle = 187,
		FlightCommunications = 188,
		FlareRelease = 189,
		LandingGear = 190,
		ToeBreak = 191,
		Trigger = 192,
		WeaponsArm = 193,
		WeaponsSelect = 194,
		WingFlaps = 195,
		Accelerator = 196,
		Brake = 197,
		Clutch = 198,
		Shifter = 199,
		Steering = 200,
		TurretDirection = 201,
		BarrelElevation = 202,
		DivePlane = 203,
		Ballast = 204,
		BicycleCrank = 205,
		HandleBars = 206,
		FrontBrake = 207,
		RearBrake = 208,
	}

	[Token(Token = "0x2000146")]
	internal enum UsagePage : int
	{
		Undefined = 0,
		GenericDesktop = 1,
		Simulation = 2,
		VRControls = 3,
		SportControls = 4,
		GameControls = 5,
		GenericDeviceControls = 6,
		Keyboard = 7,
		LEDs = 8,
		Button = 9,
		Ordinal = 10,
		Telephony = 11,
		Consumer = 12,
		Digitizer = 13,
		PID = 15,
		Unicode = 16,
		AlphanumericDisplay = 20,
		MedicalInstruments = 64,
		Monitor = 128,
		Power = 132,
		BarCodeScanner = 140,
		MagneticStripeReader = 142,
		Camera = 144,
		Arcade = 145,
		VendorDefined = 65280,
	}

	[Token(Token = "0x4000764")]
	internal const string kHIDInterface = "HID"; //Field offset: 0x0
	[Token(Token = "0x4000765")]
	internal const string kHIDNamespace = "HID"; //Field offset: 0x0
	[Token(Token = "0x4000768")]
	private static readonly ProfilerMarker k_HIDParseDescriptorFallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000766")]
	private bool m_HaveParsedHIDDescriptor; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000767")]
	private HIDDeviceDescriptor m_HIDDescriptor; //Field offset: 0x198

	[Token(Token = "0x170003E0")]
	public HIDDeviceDescriptor hidDescriptor
	{
		[Address(RVA = "0x29D87A0", Offset = "0x29D7BA0", Length = "0x12A")]
		[Token(Token = "0x6000E8B")]
		 get { } //Length: 298
	}

	[Token(Token = "0x170003DF")]
	public static FourCC QueryHIDParsedReportDescriptorDeviceCommandType
	{
		[Address(RVA = "0x29D86E0", Offset = "0x29D7AE0", Length = "0x3A")]
		[Token(Token = "0x6000E8A")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003DD")]
	public static FourCC QueryHIDReportDescriptorDeviceCommandType
	{
		[Address(RVA = "0x29D8720", Offset = "0x29D7B20", Length = "0x3A")]
		[Token(Token = "0x6000E88")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170003DE")]
	public static FourCC QueryHIDReportDescriptorSizeDeviceCommandType
	{
		[Address(RVA = "0x29D8760", Offset = "0x29D7B60", Length = "0x3A")]
		[Token(Token = "0x6000E89")]
		 get { } //Length: 58
	}

	[Address(RVA = "0x29D8680", Offset = "0x29D7A80", Length = "0x5E")]
	[Token(Token = "0x6000E91")]
	private static HID() { }

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000E90")]
	public HID() { }

	[Address(RVA = "0x29D87A0", Offset = "0x29D7BA0", Length = "0x12A")]
	[Token(Token = "0x6000E8B")]
	public HIDDeviceDescriptor get_hidDescriptor() { }

	[Address(RVA = "0x29D86E0", Offset = "0x29D7AE0", Length = "0x3A")]
	[Token(Token = "0x6000E8A")]
	public static FourCC get_QueryHIDParsedReportDescriptorDeviceCommandType() { }

	[Address(RVA = "0x29D8720", Offset = "0x29D7B20", Length = "0x3A")]
	[Token(Token = "0x6000E88")]
	public static FourCC get_QueryHIDReportDescriptorDeviceCommandType() { }

	[Address(RVA = "0x29D8760", Offset = "0x29D7B60", Length = "0x3A")]
	[Token(Token = "0x6000E89")]
	public static FourCC get_QueryHIDReportDescriptorSizeDeviceCommandType() { }

	[Address(RVA = "0x29D7300", Offset = "0x29D6700", Length = "0xA15")]
	[Token(Token = "0x6000E8C")]
	internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeDeviceCommand) { }

	[Address(RVA = "0x29D7D20", Offset = "0x29D7120", Length = "0x839")]
	[Token(Token = "0x6000E8D")]
	internal static HIDDeviceDescriptor ReadHIDDeviceDescriptor(ref InputDeviceDescription deviceDescription, InputDeviceExecuteCommandDelegate executeCommandDelegate) { }

	[Address(RVA = "0x29D8560", Offset = "0x29D7960", Length = "0x70")]
	[Token(Token = "0x6000E8E")]
	public static string UsagePageToString(UsagePage usagePage) { }

	[Address(RVA = "0x29D85D0", Offset = "0x29D79D0", Length = "0xAD")]
	[Token(Token = "0x6000E8F")]
	public static string UsageToString(UsagePage usagePage, int usage) { }

}

