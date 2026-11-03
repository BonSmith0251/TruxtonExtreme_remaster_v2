namespace UnityEngine.InputSystem;

[Token(Token = "0x2000097")]
internal class FastTouchscreen : Touchscreen
{
	[Token(Token = "0x4000406")]
	public const string metadata = "AutoWindowSpace;Touch;Vector2;Delta;Analog;TouchPress;Button;Axis;Integer;TouchPhase;Double;Touchscreen;Pointer"; //Field offset: 0x0

	[Address(RVA = "0x298C530", Offset = "0x298B930", Length = "0x64CD")]
	[Token(Token = "0x6000853")]
	public FastTouchscreen() { }

	[Address(RVA = "0x295DF00", Offset = "0x295D300", Length = "0x22F")]
	[Token(Token = "0x6000856")]
	private DeltaControl Initialize_ctrlTouchscreendelta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x295E130", Offset = "0x295D530", Length = "0x281")]
	[Token(Token = "0x6000881")]
	private AxisControl Initialize_ctrlTouchscreendeltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x295E3C0", Offset = "0x295D7C0", Length = "0x281")]
	[Token(Token = "0x6000882")]
	private AxisControl Initialize_ctrlTouchscreendeltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x295E650", Offset = "0x295DA50", Length = "0x27A")]
	[Token(Token = "0x6000883")]
	private AxisControl Initialize_ctrlTouchscreendeltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x295E8D0", Offset = "0x295DCD0", Length = "0x27A")]
	[Token(Token = "0x6000880")]
	private AxisControl Initialize_ctrlTouchscreendeltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x295EB50", Offset = "0x295DF50", Length = "0x250")]
	[Token(Token = "0x6000884")]
	private AxisControl Initialize_ctrlTouchscreendeltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x295EDB0", Offset = "0x295E1B0", Length = "0x250")]
	[Token(Token = "0x6000885")]
	private AxisControl Initialize_ctrlTouchscreendeltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x295F010", Offset = "0x295E410", Length = "0x207")]
	[Token(Token = "0x600085A")]
	private IntegerControl Initialize_ctrlTouchscreendisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x295F220", Offset = "0x295E620", Length = "0x24F")]
	[Token(Token = "0x6000855")]
	private Vector2Control Initialize_ctrlTouchscreenposition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x295F470", Offset = "0x295E870", Length = "0x270")]
	[Token(Token = "0x600087E")]
	private AxisControl Initialize_ctrlTouchscreenpositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x295F6F0", Offset = "0x295EAF0", Length = "0x270")]
	[Token(Token = "0x600087F")]
	private AxisControl Initialize_ctrlTouchscreenpositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x295F970", Offset = "0x295ED70", Length = "0x263")]
	[Token(Token = "0x6000859")]
	private TouchPressControl Initialize_ctrlTouchscreenpress(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x295FBE0", Offset = "0x295EFE0", Length = "0x24A")]
	[Token(Token = "0x6000857")]
	private AxisControl Initialize_ctrlTouchscreenpressure(InternedString kAnalogLayout, InputControl parent) { }

	[Address(RVA = "0x295FE30", Offset = "0x295F230", Length = "0x226")]
	[Token(Token = "0x6000854")]
	private TouchControl Initialize_ctrlTouchscreenprimaryTouch(InternedString kTouchLayout, InputControl parent) { }

	[Address(RVA = "0x2960060", Offset = "0x295F460", Length = "0x264")]
	[Token(Token = "0x6000867")]
	private DeltaControl Initialize_ctrlTouchscreenprimaryTouchdelta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x29602D0", Offset = "0x295F6D0", Length = "0x281")]
	[Token(Token = "0x6000875")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2960560", Offset = "0x295F960", Length = "0x281")]
	[Token(Token = "0x6000876")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29607F0", Offset = "0x295FBF0", Length = "0x27A")]
	[Token(Token = "0x6000877")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2960A70", Offset = "0x295FE70", Length = "0x27A")]
	[Token(Token = "0x6000874")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2960CF0", Offset = "0x29600F0", Length = "0x250")]
	[Token(Token = "0x6000878")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2960F50", Offset = "0x2960350", Length = "0x250")]
	[Token(Token = "0x6000879")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchdeltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29611B0", Offset = "0x29605B0", Length = "0x250")]
	[Token(Token = "0x600086D")]
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2961410", Offset = "0x2960810", Length = "0x2AC")]
	[Token(Token = "0x600086E")]
	private ButtonControl Initialize_ctrlTouchscreenprimaryTouchindirectTouch(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x29616C0", Offset = "0x2960AC0", Length = "0x25D")]
	[Token(Token = "0x600086A")]
	private TouchPhaseControl Initialize_ctrlTouchscreenprimaryTouchphase(InternedString kTouchPhaseLayout, InputControl parent) { }

	[Address(RVA = "0x2961920", Offset = "0x2960D20", Length = "0x284")]
	[Token(Token = "0x6000866")]
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchposition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2961BB0", Offset = "0x2960FB0", Length = "0x270")]
	[Token(Token = "0x6000872")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2961E30", Offset = "0x2961230", Length = "0x270")]
	[Token(Token = "0x6000873")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29620B0", Offset = "0x29614B0", Length = "0x29F")]
	[Token(Token = "0x600086B")]
	private TouchPressControl Initialize_ctrlTouchscreenprimaryTouchpress(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x2962350", Offset = "0x2961750", Length = "0x250")]
	[Token(Token = "0x6000868")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchpressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29625B0", Offset = "0x29619B0", Length = "0x264")]
	[Token(Token = "0x6000869")]
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchradius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2962820", Offset = "0x2961C20", Length = "0x250")]
	[Token(Token = "0x600087A")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2962A80", Offset = "0x2961E80", Length = "0x250")]
	[Token(Token = "0x600087B")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchradiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2962CE0", Offset = "0x29620E0", Length = "0x271")]
	[Token(Token = "0x6000871")]
	private Vector2Control Initialize_ctrlTouchscreenprimaryTouchstartPosition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2962F60", Offset = "0x2962360", Length = "0x250")]
	[Token(Token = "0x600087C")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29631C0", Offset = "0x29625C0", Length = "0x250")]
	[Token(Token = "0x600087D")]
	private AxisControl Initialize_ctrlTouchscreenprimaryTouchstartPositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2963420", Offset = "0x2962820", Length = "0x25D")]
	[Token(Token = "0x6000870")]
	private DoubleControl Initialize_ctrlTouchscreenprimaryTouchstartTime(InternedString kDoubleLayout, InputControl parent) { }

	[Address(RVA = "0x29638E0", Offset = "0x2962CE0", Length = "0x2B1")]
	[Token(Token = "0x600086F")]
	private ButtonControl Initialize_ctrlTouchscreenprimaryTouchtap(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2963680", Offset = "0x2962A80", Length = "0x250")]
	[Token(Token = "0x600086C")]
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtapCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2963BA0", Offset = "0x2962FA0", Length = "0x27B")]
	[Token(Token = "0x6000865")]
	private IntegerControl Initialize_ctrlTouchscreenprimaryTouchtouchId(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2963E20", Offset = "0x2963220", Length = "0x22F")]
	[Token(Token = "0x6000858")]
	private Vector2Control Initialize_ctrlTouchscreenradius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2964050", Offset = "0x2963450", Length = "0x250")]
	[Token(Token = "0x6000886")]
	private AxisControl Initialize_ctrlTouchscreenradiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29642B0", Offset = "0x29636B0", Length = "0x250")]
	[Token(Token = "0x6000887")]
	private AxisControl Initialize_ctrlTouchscreenradiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2964510", Offset = "0x2963910", Length = "0x21B")]
	[Token(Token = "0x600085B")]
	private TouchControl Initialize_ctrlTouchscreentouch0(InternedString kTouchLayout, InputControl parent) { }

	[Address(RVA = "0x2964730", Offset = "0x2963B30", Length = "0x264")]
	[Token(Token = "0x600088A")]
	private DeltaControl Initialize_ctrlTouchscreentouch0delta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x29649A0", Offset = "0x2963DA0", Length = "0x281")]
	[Token(Token = "0x6000898")]
	private AxisControl Initialize_ctrlTouchscreentouch0deltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2964C30", Offset = "0x2964030", Length = "0x281")]
	[Token(Token = "0x6000899")]
	private AxisControl Initialize_ctrlTouchscreentouch0deltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2964EC0", Offset = "0x29642C0", Length = "0x27A")]
	[Token(Token = "0x600089A")]
	private AxisControl Initialize_ctrlTouchscreentouch0deltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2965140", Offset = "0x2964540", Length = "0x27A")]
	[Token(Token = "0x6000897")]
	private AxisControl Initialize_ctrlTouchscreentouch0deltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29653C0", Offset = "0x29647C0", Length = "0x250")]
	[Token(Token = "0x600089B")]
	private AxisControl Initialize_ctrlTouchscreentouch0deltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2965620", Offset = "0x2964A20", Length = "0x250")]
	[Token(Token = "0x600089C")]
	private AxisControl Initialize_ctrlTouchscreentouch0deltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2965880", Offset = "0x2964C80", Length = "0x250")]
	[Token(Token = "0x6000890")]
	private IntegerControl Initialize_ctrlTouchscreentouch0displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2965AE0", Offset = "0x2964EE0", Length = "0x2AC")]
	[Token(Token = "0x6000891")]
	private ButtonControl Initialize_ctrlTouchscreentouch0indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2965D90", Offset = "0x2965190", Length = "0x25D")]
	[Token(Token = "0x600088D")]
	private TouchPhaseControl Initialize_ctrlTouchscreentouch0phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	[Address(RVA = "0x2965FF0", Offset = "0x29653F0", Length = "0x284")]
	[Token(Token = "0x6000889")]
	private Vector2Control Initialize_ctrlTouchscreentouch0position(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2966280", Offset = "0x2965680", Length = "0x270")]
	[Token(Token = "0x6000895")]
	private AxisControl Initialize_ctrlTouchscreentouch0positionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2966500", Offset = "0x2965900", Length = "0x270")]
	[Token(Token = "0x6000896")]
	private AxisControl Initialize_ctrlTouchscreentouch0positiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2966780", Offset = "0x2965B80", Length = "0x29F")]
	[Token(Token = "0x600088E")]
	private TouchPressControl Initialize_ctrlTouchscreentouch0press(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x2966A20", Offset = "0x2965E20", Length = "0x250")]
	[Token(Token = "0x600088B")]
	private AxisControl Initialize_ctrlTouchscreentouch0pressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2966C80", Offset = "0x2966080", Length = "0x264")]
	[Token(Token = "0x600088C")]
	private Vector2Control Initialize_ctrlTouchscreentouch0radius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2966EF0", Offset = "0x29662F0", Length = "0x250")]
	[Token(Token = "0x600089D")]
	private AxisControl Initialize_ctrlTouchscreentouch0radiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2967150", Offset = "0x2966550", Length = "0x250")]
	[Token(Token = "0x600089E")]
	private AxisControl Initialize_ctrlTouchscreentouch0radiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29673B0", Offset = "0x29667B0", Length = "0x271")]
	[Token(Token = "0x6000894")]
	private Vector2Control Initialize_ctrlTouchscreentouch0startPosition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2967630", Offset = "0x2966A30", Length = "0x250")]
	[Token(Token = "0x600089F")]
	private AxisControl Initialize_ctrlTouchscreentouch0startPositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2967890", Offset = "0x2966C90", Length = "0x250")]
	[Token(Token = "0x60008A0")]
	private AxisControl Initialize_ctrlTouchscreentouch0startPositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2967AF0", Offset = "0x2966EF0", Length = "0x25D")]
	[Token(Token = "0x6000893")]
	private DoubleControl Initialize_ctrlTouchscreentouch0startTime(InternedString kDoubleLayout, InputControl parent) { }

	[Address(RVA = "0x2967FB0", Offset = "0x29673B0", Length = "0x2A6")]
	[Token(Token = "0x6000892")]
	private ButtonControl Initialize_ctrlTouchscreentouch0tap(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2967D50", Offset = "0x2967150", Length = "0x250")]
	[Token(Token = "0x600088F")]
	private IntegerControl Initialize_ctrlTouchscreentouch0tapCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2968260", Offset = "0x2967660", Length = "0x27D")]
	[Token(Token = "0x6000888")]
	private IntegerControl Initialize_ctrlTouchscreentouch0touchId(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x29684E0", Offset = "0x29678E0", Length = "0x21B")]
	[Token(Token = "0x600085C")]
	private TouchControl Initialize_ctrlTouchscreentouch1(InternedString kTouchLayout, InputControl parent) { }

	[Address(RVA = "0x2968700", Offset = "0x2967B00", Length = "0x264")]
	[Token(Token = "0x60008A3")]
	private DeltaControl Initialize_ctrlTouchscreentouch1delta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x2968970", Offset = "0x2967D70", Length = "0x281")]
	[Token(Token = "0x60008B1")]
	private AxisControl Initialize_ctrlTouchscreentouch1deltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2968C00", Offset = "0x2968000", Length = "0x281")]
	[Token(Token = "0x60008B2")]
	private AxisControl Initialize_ctrlTouchscreentouch1deltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2968E90", Offset = "0x2968290", Length = "0x27A")]
	[Token(Token = "0x60008B3")]
	private AxisControl Initialize_ctrlTouchscreentouch1deltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2969110", Offset = "0x2968510", Length = "0x27A")]
	[Token(Token = "0x60008B0")]
	private AxisControl Initialize_ctrlTouchscreentouch1deltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2969390", Offset = "0x2968790", Length = "0x250")]
	[Token(Token = "0x60008B4")]
	private AxisControl Initialize_ctrlTouchscreentouch1deltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29695F0", Offset = "0x29689F0", Length = "0x250")]
	[Token(Token = "0x60008B5")]
	private AxisControl Initialize_ctrlTouchscreentouch1deltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2969850", Offset = "0x2968C50", Length = "0x250")]
	[Token(Token = "0x60008A9")]
	private IntegerControl Initialize_ctrlTouchscreentouch1displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2969AB0", Offset = "0x2968EB0", Length = "0x2AC")]
	[Token(Token = "0x60008AA")]
	private ButtonControl Initialize_ctrlTouchscreentouch1indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2969D60", Offset = "0x2969160", Length = "0x25D")]
	[Token(Token = "0x60008A6")]
	private TouchPhaseControl Initialize_ctrlTouchscreentouch1phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	[Address(RVA = "0x2969FC0", Offset = "0x29693C0", Length = "0x284")]
	[Token(Token = "0x60008A2")]
	private Vector2Control Initialize_ctrlTouchscreentouch1position(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x296A250", Offset = "0x2969650", Length = "0x270")]
	[Token(Token = "0x60008AE")]
	private AxisControl Initialize_ctrlTouchscreentouch1positionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296A4D0", Offset = "0x29698D0", Length = "0x270")]
	[Token(Token = "0x60008AF")]
	private AxisControl Initialize_ctrlTouchscreentouch1positiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296A750", Offset = "0x2969B50", Length = "0x29F")]
	[Token(Token = "0x60008A7")]
	private TouchPressControl Initialize_ctrlTouchscreentouch1press(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x296A9F0", Offset = "0x2969DF0", Length = "0x250")]
	[Token(Token = "0x60008A4")]
	private AxisControl Initialize_ctrlTouchscreentouch1pressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296AC50", Offset = "0x296A050", Length = "0x264")]
	[Token(Token = "0x60008A5")]
	private Vector2Control Initialize_ctrlTouchscreentouch1radius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x296AEC0", Offset = "0x296A2C0", Length = "0x250")]
	[Token(Token = "0x60008B6")]
	private AxisControl Initialize_ctrlTouchscreentouch1radiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296B120", Offset = "0x296A520", Length = "0x250")]
	[Token(Token = "0x60008B7")]
	private AxisControl Initialize_ctrlTouchscreentouch1radiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296B380", Offset = "0x296A780", Length = "0x271")]
	[Token(Token = "0x60008AD")]
	private Vector2Control Initialize_ctrlTouchscreentouch1startPosition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x296B600", Offset = "0x296AA00", Length = "0x250")]
	[Token(Token = "0x60008B8")]
	private AxisControl Initialize_ctrlTouchscreentouch1startPositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296B860", Offset = "0x296AC60", Length = "0x250")]
	[Token(Token = "0x60008B9")]
	private AxisControl Initialize_ctrlTouchscreentouch1startPositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296BAC0", Offset = "0x296AEC0", Length = "0x25D")]
	[Token(Token = "0x60008AC")]
	private DoubleControl Initialize_ctrlTouchscreentouch1startTime(InternedString kDoubleLayout, InputControl parent) { }

	[Address(RVA = "0x296BF80", Offset = "0x296B380", Length = "0x2A6")]
	[Token(Token = "0x60008AB")]
	private ButtonControl Initialize_ctrlTouchscreentouch1tap(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x296BD20", Offset = "0x296B120", Length = "0x250")]
	[Token(Token = "0x60008A8")]
	private IntegerControl Initialize_ctrlTouchscreentouch1tapCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x296C230", Offset = "0x296B630", Length = "0x27D")]
	[Token(Token = "0x60008A1")]
	private IntegerControl Initialize_ctrlTouchscreentouch1touchId(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x296C4B0", Offset = "0x296B8B0", Length = "0x21B")]
	[Token(Token = "0x600085D")]
	private TouchControl Initialize_ctrlTouchscreentouch2(InternedString kTouchLayout, InputControl parent) { }

	[Address(RVA = "0x296C6D0", Offset = "0x296BAD0", Length = "0x264")]
	[Token(Token = "0x60008BC")]
	private DeltaControl Initialize_ctrlTouchscreentouch2delta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x296C940", Offset = "0x296BD40", Length = "0x281")]
	[Token(Token = "0x60008CA")]
	private AxisControl Initialize_ctrlTouchscreentouch2deltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296CBD0", Offset = "0x296BFD0", Length = "0x281")]
	[Token(Token = "0x60008CB")]
	private AxisControl Initialize_ctrlTouchscreentouch2deltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296CE60", Offset = "0x296C260", Length = "0x27A")]
	[Token(Token = "0x60008CC")]
	private AxisControl Initialize_ctrlTouchscreentouch2deltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296D0E0", Offset = "0x296C4E0", Length = "0x27A")]
	[Token(Token = "0x60008C9")]
	private AxisControl Initialize_ctrlTouchscreentouch2deltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296D360", Offset = "0x296C760", Length = "0x250")]
	[Token(Token = "0x60008CD")]
	private AxisControl Initialize_ctrlTouchscreentouch2deltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296D5C0", Offset = "0x296C9C0", Length = "0x250")]
	[Token(Token = "0x60008CE")]
	private AxisControl Initialize_ctrlTouchscreentouch2deltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296D820", Offset = "0x296CC20", Length = "0x250")]
	[Token(Token = "0x60008C2")]
	private IntegerControl Initialize_ctrlTouchscreentouch2displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x296DA80", Offset = "0x296CE80", Length = "0x2AC")]
	[Token(Token = "0x60008C3")]
	private ButtonControl Initialize_ctrlTouchscreentouch2indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x296DD30", Offset = "0x296D130", Length = "0x25D")]
	[Token(Token = "0x60008BF")]
	private TouchPhaseControl Initialize_ctrlTouchscreentouch2phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	[Address(RVA = "0x296DF90", Offset = "0x296D390", Length = "0x284")]
	[Token(Token = "0x60008BB")]
	private Vector2Control Initialize_ctrlTouchscreentouch2position(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x296E220", Offset = "0x296D620", Length = "0x270")]
	[Token(Token = "0x60008C7")]
	private AxisControl Initialize_ctrlTouchscreentouch2positionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296E4A0", Offset = "0x296D8A0", Length = "0x270")]
	[Token(Token = "0x60008C8")]
	private AxisControl Initialize_ctrlTouchscreentouch2positiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296E720", Offset = "0x296DB20", Length = "0x29F")]
	[Token(Token = "0x60008C0")]
	private TouchPressControl Initialize_ctrlTouchscreentouch2press(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x296E9C0", Offset = "0x296DDC0", Length = "0x250")]
	[Token(Token = "0x60008BD")]
	private AxisControl Initialize_ctrlTouchscreentouch2pressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296EC20", Offset = "0x296E020", Length = "0x264")]
	[Token(Token = "0x60008BE")]
	private Vector2Control Initialize_ctrlTouchscreentouch2radius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x296EE90", Offset = "0x296E290", Length = "0x250")]
	[Token(Token = "0x60008CF")]
	private AxisControl Initialize_ctrlTouchscreentouch2radiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296F0F0", Offset = "0x296E4F0", Length = "0x250")]
	[Token(Token = "0x60008D0")]
	private AxisControl Initialize_ctrlTouchscreentouch2radiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296F350", Offset = "0x296E750", Length = "0x271")]
	[Token(Token = "0x60008C6")]
	private Vector2Control Initialize_ctrlTouchscreentouch2startPosition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x296F5D0", Offset = "0x296E9D0", Length = "0x250")]
	[Token(Token = "0x60008D1")]
	private AxisControl Initialize_ctrlTouchscreentouch2startPositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296F830", Offset = "0x296EC30", Length = "0x250")]
	[Token(Token = "0x60008D2")]
	private AxisControl Initialize_ctrlTouchscreentouch2startPositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x296FA90", Offset = "0x296EE90", Length = "0x25D")]
	[Token(Token = "0x60008C5")]
	private DoubleControl Initialize_ctrlTouchscreentouch2startTime(InternedString kDoubleLayout, InputControl parent) { }

	[Address(RVA = "0x296FF50", Offset = "0x296F350", Length = "0x2A6")]
	[Token(Token = "0x60008C4")]
	private ButtonControl Initialize_ctrlTouchscreentouch2tap(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x296FCF0", Offset = "0x296F0F0", Length = "0x250")]
	[Token(Token = "0x60008C1")]
	private IntegerControl Initialize_ctrlTouchscreentouch2tapCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2970200", Offset = "0x296F600", Length = "0x27D")]
	[Token(Token = "0x60008BA")]
	private IntegerControl Initialize_ctrlTouchscreentouch2touchId(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2970480", Offset = "0x296F880", Length = "0x21B")]
	[Token(Token = "0x600085E")]
	private TouchControl Initialize_ctrlTouchscreentouch3(InternedString kTouchLayout, InputControl parent) { }

	[Address(RVA = "0x29706A0", Offset = "0x296FAA0", Length = "0x267")]
	[Token(Token = "0x60008D5")]
	private DeltaControl Initialize_ctrlTouchscreentouch3delta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x2970910", Offset = "0x296FD10", Length = "0x284")]
	[Token(Token = "0x60008E3")]
	private AxisControl Initialize_ctrlTouchscreentouch3deltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2970BA0", Offset = "0x296FFA0", Length = "0x284")]
	[Token(Token = "0x60008E4")]
	private AxisControl Initialize_ctrlTouchscreentouch3deltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2970E30", Offset = "0x2970230", Length = "0x27D")]
	[Token(Token = "0x60008E5")]
	private AxisControl Initialize_ctrlTouchscreentouch3deltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29710B0", Offset = "0x29704B0", Length = "0x27D")]
	[Token(Token = "0x60008E2")]
	private AxisControl Initialize_ctrlTouchscreentouch3deltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2971330", Offset = "0x2970730", Length = "0x253")]
	[Token(Token = "0x60008E6")]
	private AxisControl Initialize_ctrlTouchscreentouch3deltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2971590", Offset = "0x2970990", Length = "0x253")]
	[Token(Token = "0x60008E7")]
	private AxisControl Initialize_ctrlTouchscreentouch3deltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29717F0", Offset = "0x2970BF0", Length = "0x253")]
	[Token(Token = "0x60008DB")]
	private IntegerControl Initialize_ctrlTouchscreentouch3displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2971A50", Offset = "0x2970E50", Length = "0x2AF")]
	[Token(Token = "0x60008DC")]
	private ButtonControl Initialize_ctrlTouchscreentouch3indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2971D00", Offset = "0x2971100", Length = "0x260")]
	[Token(Token = "0x60008D8")]
	private TouchPhaseControl Initialize_ctrlTouchscreentouch3phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	[Address(RVA = "0x2971F70", Offset = "0x2971370", Length = "0x287")]
	[Token(Token = "0x60008D4")]
	private Vector2Control Initialize_ctrlTouchscreentouch3position(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2972200", Offset = "0x2971600", Length = "0x273")]
	[Token(Token = "0x60008E0")]
	private AxisControl Initialize_ctrlTouchscreentouch3positionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2972480", Offset = "0x2971880", Length = "0x273")]
	[Token(Token = "0x60008E1")]
	private AxisControl Initialize_ctrlTouchscreentouch3positiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2972700", Offset = "0x2971B00", Length = "0x2A2")]
	[Token(Token = "0x60008D9")]
	private TouchPressControl Initialize_ctrlTouchscreentouch3press(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x29729B0", Offset = "0x2971DB0", Length = "0x253")]
	[Token(Token = "0x60008D6")]
	private AxisControl Initialize_ctrlTouchscreentouch3pressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2972C10", Offset = "0x2972010", Length = "0x267")]
	[Token(Token = "0x60008D7")]
	private Vector2Control Initialize_ctrlTouchscreentouch3radius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2972E80", Offset = "0x2972280", Length = "0x253")]
	[Token(Token = "0x60008E8")]
	private AxisControl Initialize_ctrlTouchscreentouch3radiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29730E0", Offset = "0x29724E0", Length = "0x253")]
	[Token(Token = "0x60008E9")]
	private AxisControl Initialize_ctrlTouchscreentouch3radiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2973340", Offset = "0x2972740", Length = "0x274")]
	[Token(Token = "0x60008DF")]
	private Vector2Control Initialize_ctrlTouchscreentouch3startPosition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x29735C0", Offset = "0x29729C0", Length = "0x253")]
	[Token(Token = "0x60008EA")]
	private AxisControl Initialize_ctrlTouchscreentouch3startPositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2973820", Offset = "0x2972C20", Length = "0x253")]
	[Token(Token = "0x60008EB")]
	private AxisControl Initialize_ctrlTouchscreentouch3startPositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2973A80", Offset = "0x2972E80", Length = "0x260")]
	[Token(Token = "0x60008DE")]
	private DoubleControl Initialize_ctrlTouchscreentouch3startTime(InternedString kDoubleLayout, InputControl parent) { }

	[Address(RVA = "0x2973F50", Offset = "0x2973350", Length = "0x2A9")]
	[Token(Token = "0x60008DD")]
	private ButtonControl Initialize_ctrlTouchscreentouch3tap(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2973CF0", Offset = "0x29730F0", Length = "0x253")]
	[Token(Token = "0x60008DA")]
	private IntegerControl Initialize_ctrlTouchscreentouch3tapCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2974200", Offset = "0x2973600", Length = "0x27D")]
	[Token(Token = "0x60008D3")]
	private IntegerControl Initialize_ctrlTouchscreentouch3touchId(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2974480", Offset = "0x2973880", Length = "0x21B")]
	[Token(Token = "0x600085F")]
	private TouchControl Initialize_ctrlTouchscreentouch4(InternedString kTouchLayout, InputControl parent) { }

	[Address(RVA = "0x29746A0", Offset = "0x2973AA0", Length = "0x267")]
	[Token(Token = "0x60008EE")]
	private DeltaControl Initialize_ctrlTouchscreentouch4delta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x2974910", Offset = "0x2973D10", Length = "0x284")]
	[Token(Token = "0x60008FC")]
	private AxisControl Initialize_ctrlTouchscreentouch4deltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2974BA0", Offset = "0x2973FA0", Length = "0x284")]
	[Token(Token = "0x60008FD")]
	private AxisControl Initialize_ctrlTouchscreentouch4deltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2974E30", Offset = "0x2974230", Length = "0x27D")]
	[Token(Token = "0x60008FE")]
	private AxisControl Initialize_ctrlTouchscreentouch4deltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29750B0", Offset = "0x29744B0", Length = "0x27D")]
	[Token(Token = "0x60008FB")]
	private AxisControl Initialize_ctrlTouchscreentouch4deltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2975330", Offset = "0x2974730", Length = "0x253")]
	[Token(Token = "0x60008FF")]
	private AxisControl Initialize_ctrlTouchscreentouch4deltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2975590", Offset = "0x2974990", Length = "0x253")]
	[Token(Token = "0x6000900")]
	private AxisControl Initialize_ctrlTouchscreentouch4deltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29757F0", Offset = "0x2974BF0", Length = "0x253")]
	[Token(Token = "0x60008F4")]
	private IntegerControl Initialize_ctrlTouchscreentouch4displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2975A50", Offset = "0x2974E50", Length = "0x2AF")]
	[Token(Token = "0x60008F5")]
	private ButtonControl Initialize_ctrlTouchscreentouch4indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2975D00", Offset = "0x2975100", Length = "0x260")]
	[Token(Token = "0x60008F1")]
	private TouchPhaseControl Initialize_ctrlTouchscreentouch4phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	[Address(RVA = "0x2975F70", Offset = "0x2975370", Length = "0x287")]
	[Token(Token = "0x60008ED")]
	private Vector2Control Initialize_ctrlTouchscreentouch4position(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2976200", Offset = "0x2975600", Length = "0x273")]
	[Token(Token = "0x60008F9")]
	private AxisControl Initialize_ctrlTouchscreentouch4positionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2976480", Offset = "0x2975880", Length = "0x273")]
	[Token(Token = "0x60008FA")]
	private AxisControl Initialize_ctrlTouchscreentouch4positiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2976700", Offset = "0x2975B00", Length = "0x2A2")]
	[Token(Token = "0x60008F2")]
	private TouchPressControl Initialize_ctrlTouchscreentouch4press(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x29769B0", Offset = "0x2975DB0", Length = "0x253")]
	[Token(Token = "0x60008EF")]
	private AxisControl Initialize_ctrlTouchscreentouch4pressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2976C10", Offset = "0x2976010", Length = "0x267")]
	[Token(Token = "0x60008F0")]
	private Vector2Control Initialize_ctrlTouchscreentouch4radius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2976E80", Offset = "0x2976280", Length = "0x253")]
	[Token(Token = "0x6000901")]
	private AxisControl Initialize_ctrlTouchscreentouch4radiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29770E0", Offset = "0x29764E0", Length = "0x253")]
	[Token(Token = "0x6000902")]
	private AxisControl Initialize_ctrlTouchscreentouch4radiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2977340", Offset = "0x2976740", Length = "0x274")]
	[Token(Token = "0x60008F8")]
	private Vector2Control Initialize_ctrlTouchscreentouch4startPosition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x29775C0", Offset = "0x29769C0", Length = "0x253")]
	[Token(Token = "0x6000903")]
	private AxisControl Initialize_ctrlTouchscreentouch4startPositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2977820", Offset = "0x2976C20", Length = "0x253")]
	[Token(Token = "0x6000904")]
	private AxisControl Initialize_ctrlTouchscreentouch4startPositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2977A80", Offset = "0x2976E80", Length = "0x260")]
	[Token(Token = "0x60008F7")]
	private DoubleControl Initialize_ctrlTouchscreentouch4startTime(InternedString kDoubleLayout, InputControl parent) { }

	[Address(RVA = "0x2977F50", Offset = "0x2977350", Length = "0x2A9")]
	[Token(Token = "0x60008F6")]
	private ButtonControl Initialize_ctrlTouchscreentouch4tap(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2977CF0", Offset = "0x29770F0", Length = "0x253")]
	[Token(Token = "0x60008F3")]
	private IntegerControl Initialize_ctrlTouchscreentouch4tapCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2978200", Offset = "0x2977600", Length = "0x280")]
	[Token(Token = "0x60008EC")]
	private IntegerControl Initialize_ctrlTouchscreentouch4touchId(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2978490", Offset = "0x2977890", Length = "0x221")]
	[Token(Token = "0x6000860")]
	private TouchControl Initialize_ctrlTouchscreentouch5(InternedString kTouchLayout, InputControl parent) { }

	[Address(RVA = "0x29786C0", Offset = "0x2977AC0", Length = "0x267")]
	[Token(Token = "0x6000907")]
	private DeltaControl Initialize_ctrlTouchscreentouch5delta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x2978930", Offset = "0x2977D30", Length = "0x284")]
	[Token(Token = "0x6000915")]
	private AxisControl Initialize_ctrlTouchscreentouch5deltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2978BC0", Offset = "0x2977FC0", Length = "0x284")]
	[Token(Token = "0x6000916")]
	private AxisControl Initialize_ctrlTouchscreentouch5deltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2978E50", Offset = "0x2978250", Length = "0x27D")]
	[Token(Token = "0x6000917")]
	private AxisControl Initialize_ctrlTouchscreentouch5deltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29790D0", Offset = "0x29784D0", Length = "0x27D")]
	[Token(Token = "0x6000914")]
	private AxisControl Initialize_ctrlTouchscreentouch5deltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2979350", Offset = "0x2978750", Length = "0x253")]
	[Token(Token = "0x6000918")]
	private AxisControl Initialize_ctrlTouchscreentouch5deltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29795B0", Offset = "0x29789B0", Length = "0x253")]
	[Token(Token = "0x6000919")]
	private AxisControl Initialize_ctrlTouchscreentouch5deltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2979810", Offset = "0x2978C10", Length = "0x253")]
	[Token(Token = "0x600090D")]
	private IntegerControl Initialize_ctrlTouchscreentouch5displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2979A70", Offset = "0x2978E70", Length = "0x2AF")]
	[Token(Token = "0x600090E")]
	private ButtonControl Initialize_ctrlTouchscreentouch5indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2979D20", Offset = "0x2979120", Length = "0x260")]
	[Token(Token = "0x600090A")]
	private TouchPhaseControl Initialize_ctrlTouchscreentouch5phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	[Address(RVA = "0x2979F90", Offset = "0x2979390", Length = "0x287")]
	[Token(Token = "0x6000906")]
	private Vector2Control Initialize_ctrlTouchscreentouch5position(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x297A220", Offset = "0x2979620", Length = "0x273")]
	[Token(Token = "0x6000912")]
	private AxisControl Initialize_ctrlTouchscreentouch5positionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297A4A0", Offset = "0x29798A0", Length = "0x273")]
	[Token(Token = "0x6000913")]
	private AxisControl Initialize_ctrlTouchscreentouch5positiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297A720", Offset = "0x2979B20", Length = "0x2A2")]
	[Token(Token = "0x600090B")]
	private TouchPressControl Initialize_ctrlTouchscreentouch5press(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x297A9D0", Offset = "0x2979DD0", Length = "0x253")]
	[Token(Token = "0x6000908")]
	private AxisControl Initialize_ctrlTouchscreentouch5pressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297AC30", Offset = "0x297A030", Length = "0x267")]
	[Token(Token = "0x6000909")]
	private Vector2Control Initialize_ctrlTouchscreentouch5radius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x297AEA0", Offset = "0x297A2A0", Length = "0x253")]
	[Token(Token = "0x600091A")]
	private AxisControl Initialize_ctrlTouchscreentouch5radiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297B100", Offset = "0x297A500", Length = "0x253")]
	[Token(Token = "0x600091B")]
	private AxisControl Initialize_ctrlTouchscreentouch5radiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297B360", Offset = "0x297A760", Length = "0x274")]
	[Token(Token = "0x6000911")]
	private Vector2Control Initialize_ctrlTouchscreentouch5startPosition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x297B5E0", Offset = "0x297A9E0", Length = "0x253")]
	[Token(Token = "0x600091C")]
	private AxisControl Initialize_ctrlTouchscreentouch5startPositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297B840", Offset = "0x297AC40", Length = "0x253")]
	[Token(Token = "0x600091D")]
	private AxisControl Initialize_ctrlTouchscreentouch5startPositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297BAA0", Offset = "0x297AEA0", Length = "0x260")]
	[Token(Token = "0x6000910")]
	private DoubleControl Initialize_ctrlTouchscreentouch5startTime(InternedString kDoubleLayout, InputControl parent) { }

	[Address(RVA = "0x297BF70", Offset = "0x297B370", Length = "0x2A9")]
	[Token(Token = "0x600090F")]
	private ButtonControl Initialize_ctrlTouchscreentouch5tap(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x297BD10", Offset = "0x297B110", Length = "0x253")]
	[Token(Token = "0x600090C")]
	private IntegerControl Initialize_ctrlTouchscreentouch5tapCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x297C220", Offset = "0x297B620", Length = "0x280")]
	[Token(Token = "0x6000905")]
	private IntegerControl Initialize_ctrlTouchscreentouch5touchId(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x297C4B0", Offset = "0x297B8B0", Length = "0x221")]
	[Token(Token = "0x6000861")]
	private TouchControl Initialize_ctrlTouchscreentouch6(InternedString kTouchLayout, InputControl parent) { }

	[Address(RVA = "0x297C6E0", Offset = "0x297BAE0", Length = "0x267")]
	[Token(Token = "0x6000920")]
	private DeltaControl Initialize_ctrlTouchscreentouch6delta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x297C950", Offset = "0x297BD50", Length = "0x284")]
	[Token(Token = "0x600092E")]
	private AxisControl Initialize_ctrlTouchscreentouch6deltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297CBE0", Offset = "0x297BFE0", Length = "0x284")]
	[Token(Token = "0x600092F")]
	private AxisControl Initialize_ctrlTouchscreentouch6deltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297CE70", Offset = "0x297C270", Length = "0x27D")]
	[Token(Token = "0x6000930")]
	private AxisControl Initialize_ctrlTouchscreentouch6deltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297D0F0", Offset = "0x297C4F0", Length = "0x27D")]
	[Token(Token = "0x600092D")]
	private AxisControl Initialize_ctrlTouchscreentouch6deltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297D370", Offset = "0x297C770", Length = "0x253")]
	[Token(Token = "0x6000931")]
	private AxisControl Initialize_ctrlTouchscreentouch6deltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297D5D0", Offset = "0x297C9D0", Length = "0x253")]
	[Token(Token = "0x6000932")]
	private AxisControl Initialize_ctrlTouchscreentouch6deltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297D830", Offset = "0x297CC30", Length = "0x253")]
	[Token(Token = "0x6000926")]
	private IntegerControl Initialize_ctrlTouchscreentouch6displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x297DA90", Offset = "0x297CE90", Length = "0x2AF")]
	[Token(Token = "0x6000927")]
	private ButtonControl Initialize_ctrlTouchscreentouch6indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x297DD40", Offset = "0x297D140", Length = "0x260")]
	[Token(Token = "0x6000923")]
	private TouchPhaseControl Initialize_ctrlTouchscreentouch6phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	[Address(RVA = "0x297DFB0", Offset = "0x297D3B0", Length = "0x287")]
	[Token(Token = "0x600091F")]
	private Vector2Control Initialize_ctrlTouchscreentouch6position(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x297E240", Offset = "0x297D640", Length = "0x273")]
	[Token(Token = "0x600092B")]
	private AxisControl Initialize_ctrlTouchscreentouch6positionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297E4C0", Offset = "0x297D8C0", Length = "0x273")]
	[Token(Token = "0x600092C")]
	private AxisControl Initialize_ctrlTouchscreentouch6positiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297E740", Offset = "0x297DB40", Length = "0x2A2")]
	[Token(Token = "0x6000924")]
	private TouchPressControl Initialize_ctrlTouchscreentouch6press(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x297E9F0", Offset = "0x297DDF0", Length = "0x253")]
	[Token(Token = "0x6000921")]
	private AxisControl Initialize_ctrlTouchscreentouch6pressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297EC50", Offset = "0x297E050", Length = "0x267")]
	[Token(Token = "0x6000922")]
	private Vector2Control Initialize_ctrlTouchscreentouch6radius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x297EEC0", Offset = "0x297E2C0", Length = "0x253")]
	[Token(Token = "0x6000933")]
	private AxisControl Initialize_ctrlTouchscreentouch6radiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297F120", Offset = "0x297E520", Length = "0x253")]
	[Token(Token = "0x6000934")]
	private AxisControl Initialize_ctrlTouchscreentouch6radiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297F380", Offset = "0x297E780", Length = "0x274")]
	[Token(Token = "0x600092A")]
	private Vector2Control Initialize_ctrlTouchscreentouch6startPosition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x297F600", Offset = "0x297EA00", Length = "0x253")]
	[Token(Token = "0x6000935")]
	private AxisControl Initialize_ctrlTouchscreentouch6startPositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297F860", Offset = "0x297EC60", Length = "0x253")]
	[Token(Token = "0x6000936")]
	private AxisControl Initialize_ctrlTouchscreentouch6startPositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x297FAC0", Offset = "0x297EEC0", Length = "0x260")]
	[Token(Token = "0x6000929")]
	private DoubleControl Initialize_ctrlTouchscreentouch6startTime(InternedString kDoubleLayout, InputControl parent) { }

	[Address(RVA = "0x297FF90", Offset = "0x297F390", Length = "0x2A9")]
	[Token(Token = "0x6000928")]
	private ButtonControl Initialize_ctrlTouchscreentouch6tap(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x297FD30", Offset = "0x297F130", Length = "0x253")]
	[Token(Token = "0x6000925")]
	private IntegerControl Initialize_ctrlTouchscreentouch6tapCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2980240", Offset = "0x297F640", Length = "0x280")]
	[Token(Token = "0x600091E")]
	private IntegerControl Initialize_ctrlTouchscreentouch6touchId(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x29804D0", Offset = "0x297F8D0", Length = "0x221")]
	[Token(Token = "0x6000862")]
	private TouchControl Initialize_ctrlTouchscreentouch7(InternedString kTouchLayout, InputControl parent) { }

	[Address(RVA = "0x2980700", Offset = "0x297FB00", Length = "0x267")]
	[Token(Token = "0x6000939")]
	private DeltaControl Initialize_ctrlTouchscreentouch7delta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x2980970", Offset = "0x297FD70", Length = "0x284")]
	[Token(Token = "0x6000947")]
	private AxisControl Initialize_ctrlTouchscreentouch7deltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2980C00", Offset = "0x2980000", Length = "0x284")]
	[Token(Token = "0x6000948")]
	private AxisControl Initialize_ctrlTouchscreentouch7deltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2980E90", Offset = "0x2980290", Length = "0x27D")]
	[Token(Token = "0x6000949")]
	private AxisControl Initialize_ctrlTouchscreentouch7deltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2981110", Offset = "0x2980510", Length = "0x27D")]
	[Token(Token = "0x6000946")]
	private AxisControl Initialize_ctrlTouchscreentouch7deltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2981390", Offset = "0x2980790", Length = "0x253")]
	[Token(Token = "0x600094A")]
	private AxisControl Initialize_ctrlTouchscreentouch7deltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29815F0", Offset = "0x29809F0", Length = "0x253")]
	[Token(Token = "0x600094B")]
	private AxisControl Initialize_ctrlTouchscreentouch7deltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2981850", Offset = "0x2980C50", Length = "0x253")]
	[Token(Token = "0x600093F")]
	private IntegerControl Initialize_ctrlTouchscreentouch7displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2981AB0", Offset = "0x2980EB0", Length = "0x2AF")]
	[Token(Token = "0x6000940")]
	private ButtonControl Initialize_ctrlTouchscreentouch7indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2981D60", Offset = "0x2981160", Length = "0x260")]
	[Token(Token = "0x600093C")]
	private TouchPhaseControl Initialize_ctrlTouchscreentouch7phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	[Address(RVA = "0x2981FD0", Offset = "0x29813D0", Length = "0x287")]
	[Token(Token = "0x6000938")]
	private Vector2Control Initialize_ctrlTouchscreentouch7position(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2982260", Offset = "0x2981660", Length = "0x273")]
	[Token(Token = "0x6000944")]
	private AxisControl Initialize_ctrlTouchscreentouch7positionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29824E0", Offset = "0x29818E0", Length = "0x273")]
	[Token(Token = "0x6000945")]
	private AxisControl Initialize_ctrlTouchscreentouch7positiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2982760", Offset = "0x2981B60", Length = "0x2A2")]
	[Token(Token = "0x600093D")]
	private TouchPressControl Initialize_ctrlTouchscreentouch7press(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x2982A10", Offset = "0x2981E10", Length = "0x253")]
	[Token(Token = "0x600093A")]
	private AxisControl Initialize_ctrlTouchscreentouch7pressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2982C70", Offset = "0x2982070", Length = "0x267")]
	[Token(Token = "0x600093B")]
	private Vector2Control Initialize_ctrlTouchscreentouch7radius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2982EE0", Offset = "0x29822E0", Length = "0x253")]
	[Token(Token = "0x600094C")]
	private AxisControl Initialize_ctrlTouchscreentouch7radiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2983140", Offset = "0x2982540", Length = "0x253")]
	[Token(Token = "0x600094D")]
	private AxisControl Initialize_ctrlTouchscreentouch7radiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29833A0", Offset = "0x29827A0", Length = "0x274")]
	[Token(Token = "0x6000943")]
	private Vector2Control Initialize_ctrlTouchscreentouch7startPosition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2983620", Offset = "0x2982A20", Length = "0x253")]
	[Token(Token = "0x600094E")]
	private AxisControl Initialize_ctrlTouchscreentouch7startPositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2983880", Offset = "0x2982C80", Length = "0x253")]
	[Token(Token = "0x600094F")]
	private AxisControl Initialize_ctrlTouchscreentouch7startPositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2983AE0", Offset = "0x2982EE0", Length = "0x260")]
	[Token(Token = "0x6000942")]
	private DoubleControl Initialize_ctrlTouchscreentouch7startTime(InternedString kDoubleLayout, InputControl parent) { }

	[Address(RVA = "0x2983FB0", Offset = "0x29833B0", Length = "0x2A9")]
	[Token(Token = "0x6000941")]
	private ButtonControl Initialize_ctrlTouchscreentouch7tap(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2983D50", Offset = "0x2983150", Length = "0x253")]
	[Token(Token = "0x600093E")]
	private IntegerControl Initialize_ctrlTouchscreentouch7tapCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2984260", Offset = "0x2983660", Length = "0x280")]
	[Token(Token = "0x6000937")]
	private IntegerControl Initialize_ctrlTouchscreentouch7touchId(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x29844F0", Offset = "0x29838F0", Length = "0x221")]
	[Token(Token = "0x6000863")]
	private TouchControl Initialize_ctrlTouchscreentouch8(InternedString kTouchLayout, InputControl parent) { }

	[Address(RVA = "0x2984720", Offset = "0x2983B20", Length = "0x267")]
	[Token(Token = "0x6000952")]
	private DeltaControl Initialize_ctrlTouchscreentouch8delta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x2984990", Offset = "0x2983D90", Length = "0x284")]
	[Token(Token = "0x6000960")]
	private AxisControl Initialize_ctrlTouchscreentouch8deltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2984C20", Offset = "0x2984020", Length = "0x284")]
	[Token(Token = "0x6000961")]
	private AxisControl Initialize_ctrlTouchscreentouch8deltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2984EB0", Offset = "0x29842B0", Length = "0x27D")]
	[Token(Token = "0x6000962")]
	private AxisControl Initialize_ctrlTouchscreentouch8deltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2985130", Offset = "0x2984530", Length = "0x27D")]
	[Token(Token = "0x600095F")]
	private AxisControl Initialize_ctrlTouchscreentouch8deltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29853B0", Offset = "0x29847B0", Length = "0x253")]
	[Token(Token = "0x6000963")]
	private AxisControl Initialize_ctrlTouchscreentouch8deltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2985610", Offset = "0x2984A10", Length = "0x253")]
	[Token(Token = "0x6000964")]
	private AxisControl Initialize_ctrlTouchscreentouch8deltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2985870", Offset = "0x2984C70", Length = "0x253")]
	[Token(Token = "0x6000958")]
	private IntegerControl Initialize_ctrlTouchscreentouch8displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2985AD0", Offset = "0x2984ED0", Length = "0x2AF")]
	[Token(Token = "0x6000959")]
	private ButtonControl Initialize_ctrlTouchscreentouch8indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2985D80", Offset = "0x2985180", Length = "0x260")]
	[Token(Token = "0x6000955")]
	private TouchPhaseControl Initialize_ctrlTouchscreentouch8phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	[Address(RVA = "0x2985FF0", Offset = "0x29853F0", Length = "0x287")]
	[Token(Token = "0x6000951")]
	private Vector2Control Initialize_ctrlTouchscreentouch8position(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2986280", Offset = "0x2985680", Length = "0x273")]
	[Token(Token = "0x600095D")]
	private AxisControl Initialize_ctrlTouchscreentouch8positionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2986500", Offset = "0x2985900", Length = "0x273")]
	[Token(Token = "0x600095E")]
	private AxisControl Initialize_ctrlTouchscreentouch8positiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2986780", Offset = "0x2985B80", Length = "0x2A2")]
	[Token(Token = "0x6000956")]
	private TouchPressControl Initialize_ctrlTouchscreentouch8press(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x2986A30", Offset = "0x2985E30", Length = "0x253")]
	[Token(Token = "0x6000953")]
	private AxisControl Initialize_ctrlTouchscreentouch8pressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2986C90", Offset = "0x2986090", Length = "0x267")]
	[Token(Token = "0x6000954")]
	private Vector2Control Initialize_ctrlTouchscreentouch8radius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2986F00", Offset = "0x2986300", Length = "0x253")]
	[Token(Token = "0x6000965")]
	private AxisControl Initialize_ctrlTouchscreentouch8radiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2987160", Offset = "0x2986560", Length = "0x253")]
	[Token(Token = "0x6000966")]
	private AxisControl Initialize_ctrlTouchscreentouch8radiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29873C0", Offset = "0x29867C0", Length = "0x274")]
	[Token(Token = "0x600095C")]
	private Vector2Control Initialize_ctrlTouchscreentouch8startPosition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2987640", Offset = "0x2986A40", Length = "0x253")]
	[Token(Token = "0x6000967")]
	private AxisControl Initialize_ctrlTouchscreentouch8startPositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29878A0", Offset = "0x2986CA0", Length = "0x253")]
	[Token(Token = "0x6000968")]
	private AxisControl Initialize_ctrlTouchscreentouch8startPositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2987B00", Offset = "0x2986F00", Length = "0x260")]
	[Token(Token = "0x600095B")]
	private DoubleControl Initialize_ctrlTouchscreentouch8startTime(InternedString kDoubleLayout, InputControl parent) { }

	[Address(RVA = "0x2987FD0", Offset = "0x29873D0", Length = "0x2A9")]
	[Token(Token = "0x600095A")]
	private ButtonControl Initialize_ctrlTouchscreentouch8tap(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2987D70", Offset = "0x2987170", Length = "0x253")]
	[Token(Token = "0x6000957")]
	private IntegerControl Initialize_ctrlTouchscreentouch8tapCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2988280", Offset = "0x2987680", Length = "0x280")]
	[Token(Token = "0x6000950")]
	private IntegerControl Initialize_ctrlTouchscreentouch8touchId(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2988510", Offset = "0x2987910", Length = "0x221")]
	[Token(Token = "0x6000864")]
	private TouchControl Initialize_ctrlTouchscreentouch9(InternedString kTouchLayout, InputControl parent) { }

	[Address(RVA = "0x2988740", Offset = "0x2987B40", Length = "0x267")]
	[Token(Token = "0x600096B")]
	private DeltaControl Initialize_ctrlTouchscreentouch9delta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x29889B0", Offset = "0x2987DB0", Length = "0x284")]
	[Token(Token = "0x6000979")]
	private AxisControl Initialize_ctrlTouchscreentouch9deltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2988C40", Offset = "0x2988040", Length = "0x284")]
	[Token(Token = "0x600097A")]
	private AxisControl Initialize_ctrlTouchscreentouch9deltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2988ED0", Offset = "0x29882D0", Length = "0x27D")]
	[Token(Token = "0x600097B")]
	private AxisControl Initialize_ctrlTouchscreentouch9deltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2989150", Offset = "0x2988550", Length = "0x27D")]
	[Token(Token = "0x6000978")]
	private AxisControl Initialize_ctrlTouchscreentouch9deltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29893D0", Offset = "0x29887D0", Length = "0x253")]
	[Token(Token = "0x600097C")]
	private AxisControl Initialize_ctrlTouchscreentouch9deltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2989630", Offset = "0x2988A30", Length = "0x253")]
	[Token(Token = "0x600097D")]
	private AxisControl Initialize_ctrlTouchscreentouch9deltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2989890", Offset = "0x2988C90", Length = "0x253")]
	[Token(Token = "0x6000971")]
	private IntegerControl Initialize_ctrlTouchscreentouch9displayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2989AF0", Offset = "0x2988EF0", Length = "0x2AF")]
	[Token(Token = "0x6000972")]
	private ButtonControl Initialize_ctrlTouchscreentouch9indirectTouch(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2989DA0", Offset = "0x29891A0", Length = "0x260")]
	[Token(Token = "0x600096E")]
	private TouchPhaseControl Initialize_ctrlTouchscreentouch9phase(InternedString kTouchPhaseLayout, InputControl parent) { }

	[Address(RVA = "0x298A010", Offset = "0x2989410", Length = "0x287")]
	[Token(Token = "0x600096A")]
	private Vector2Control Initialize_ctrlTouchscreentouch9position(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x298A2A0", Offset = "0x29896A0", Length = "0x273")]
	[Token(Token = "0x6000976")]
	private AxisControl Initialize_ctrlTouchscreentouch9positionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x298A520", Offset = "0x2989920", Length = "0x273")]
	[Token(Token = "0x6000977")]
	private AxisControl Initialize_ctrlTouchscreentouch9positiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x298A7A0", Offset = "0x2989BA0", Length = "0x2A2")]
	[Token(Token = "0x600096F")]
	private TouchPressControl Initialize_ctrlTouchscreentouch9press(InternedString kTouchPressLayout, InputControl parent) { }

	[Address(RVA = "0x298AA50", Offset = "0x2989E50", Length = "0x253")]
	[Token(Token = "0x600096C")]
	private AxisControl Initialize_ctrlTouchscreentouch9pressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x298ACB0", Offset = "0x298A0B0", Length = "0x267")]
	[Token(Token = "0x600096D")]
	private Vector2Control Initialize_ctrlTouchscreentouch9radius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x298AF20", Offset = "0x298A320", Length = "0x253")]
	[Token(Token = "0x600097E")]
	private AxisControl Initialize_ctrlTouchscreentouch9radiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x298B180", Offset = "0x298A580", Length = "0x253")]
	[Token(Token = "0x600097F")]
	private AxisControl Initialize_ctrlTouchscreentouch9radiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x298B3E0", Offset = "0x298A7E0", Length = "0x274")]
	[Token(Token = "0x6000975")]
	private Vector2Control Initialize_ctrlTouchscreentouch9startPosition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x298B660", Offset = "0x298AA60", Length = "0x253")]
	[Token(Token = "0x6000980")]
	private AxisControl Initialize_ctrlTouchscreentouch9startPositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x298B8C0", Offset = "0x298ACC0", Length = "0x253")]
	[Token(Token = "0x6000981")]
	private AxisControl Initialize_ctrlTouchscreentouch9startPositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x298BB20", Offset = "0x298AF20", Length = "0x260")]
	[Token(Token = "0x6000974")]
	private DoubleControl Initialize_ctrlTouchscreentouch9startTime(InternedString kDoubleLayout, InputControl parent) { }

	[Address(RVA = "0x298BFF0", Offset = "0x298B3F0", Length = "0x2A9")]
	[Token(Token = "0x6000973")]
	private ButtonControl Initialize_ctrlTouchscreentouch9tap(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x298BD90", Offset = "0x298B190", Length = "0x253")]
	[Token(Token = "0x6000970")]
	private IntegerControl Initialize_ctrlTouchscreentouch9tapCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x298C2A0", Offset = "0x298B6A0", Length = "0x280")]
	[Token(Token = "0x6000969")]
	private IntegerControl Initialize_ctrlTouchscreentouch9touchId(InternedString kIntegerLayout, InputControl parent) { }

}

