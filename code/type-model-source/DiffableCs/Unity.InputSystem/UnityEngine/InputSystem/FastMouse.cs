namespace UnityEngine.InputSystem;

[Token(Token = "0x2000096")]
internal class FastMouse : Mouse, IInputStateCallbackReceiver, IEventMerger
{
	[Token(Token = "0x4000405")]
	public const string metadata = "AutoWindowSpace;Vector2;Delta;Button;Axis;Digital;Integer;Mouse;Pointer"; //Field offset: 0x0

	[Address(RVA = "0x2998830", Offset = "0x2997C30", Length = "0x13E3")]
	[Token(Token = "0x600082E")]
	public FastMouse() { }

	[Address(RVA = "0x2993800", Offset = "0x2992C00", Length = "0x271")]
	[Token(Token = "0x6000837")]
	private ButtonControl Initialize_ctrlMousebackButton(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2993A80", Offset = "0x2992E80", Length = "0x21A")]
	[Token(Token = "0x600083C")]
	private IntegerControl Initialize_ctrlMouseclickCount(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2993CA0", Offset = "0x29930A0", Length = "0x22F")]
	[Token(Token = "0x6000830")]
	private DeltaControl Initialize_ctrlMousedelta(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x2993ED0", Offset = "0x29932D0", Length = "0x281")]
	[Token(Token = "0x6000840")]
	private AxisControl Initialize_ctrlMousedeltadown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2994160", Offset = "0x2993560", Length = "0x281")]
	[Token(Token = "0x6000841")]
	private AxisControl Initialize_ctrlMousedeltaleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29943F0", Offset = "0x29937F0", Length = "0x27A")]
	[Token(Token = "0x6000842")]
	private AxisControl Initialize_ctrlMousedeltaright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2994670", Offset = "0x2993A70", Length = "0x27A")]
	[Token(Token = "0x600083F")]
	private AxisControl Initialize_ctrlMousedeltaup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29948F0", Offset = "0x2993CF0", Length = "0x250")]
	[Token(Token = "0x6000843")]
	private AxisControl Initialize_ctrlMousedeltax(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2994B50", Offset = "0x2993F50", Length = "0x250")]
	[Token(Token = "0x6000844")]
	private AxisControl Initialize_ctrlMousedeltay(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2994DB0", Offset = "0x29941B0", Length = "0x20D")]
	[Token(Token = "0x600083B")]
	private IntegerControl Initialize_ctrlMousedisplayIndex(InternedString kIntegerLayout, InputControl parent) { }

	[Address(RVA = "0x2994FC0", Offset = "0x29943C0", Length = "0x271")]
	[Token(Token = "0x6000836")]
	private ButtonControl Initialize_ctrlMouseforwardButton(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2995240", Offset = "0x2994640", Length = "0x2B9")]
	[Token(Token = "0x6000833")]
	private ButtonControl Initialize_ctrlMouseleftButton(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2995500", Offset = "0x2994900", Length = "0x2AC")]
	[Token(Token = "0x6000835")]
	private ButtonControl Initialize_ctrlMousemiddleButton(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x29957B0", Offset = "0x2994BB0", Length = "0x1FB")]
	[Token(Token = "0x600083A")]
	private IntegerControl Initialize_ctrlMousepointerId(InternedString kDigitalLayout, InputControl parent) { }

	[Address(RVA = "0x29959B0", Offset = "0x2994DB0", Length = "0x243")]
	[Token(Token = "0x600082F")]
	private Vector2Control Initialize_ctrlMouseposition(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x2995C00", Offset = "0x2995000", Length = "0x26E")]
	[Token(Token = "0x600083D")]
	private AxisControl Initialize_ctrlMousepositionx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2995E70", Offset = "0x2995270", Length = "0x270")]
	[Token(Token = "0x600083E")]
	private AxisControl Initialize_ctrlMousepositiony(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29960F0", Offset = "0x29954F0", Length = "0x263")]
	[Token(Token = "0x6000832")]
	private ButtonControl Initialize_ctrlMousepress(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2996360", Offset = "0x2995760", Length = "0x24A")]
	[Token(Token = "0x6000838")]
	private AxisControl Initialize_ctrlMousepressure(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29965B0", Offset = "0x29959B0", Length = "0x22F")]
	[Token(Token = "0x6000839")]
	private Vector2Control Initialize_ctrlMouseradius(InternedString kVector2Layout, InputControl parent) { }

	[Address(RVA = "0x29967E0", Offset = "0x2995BE0", Length = "0x250")]
	[Token(Token = "0x600084B")]
	private AxisControl Initialize_ctrlMouseradiusx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2996A40", Offset = "0x2995E40", Length = "0x250")]
	[Token(Token = "0x600084C")]
	private AxisControl Initialize_ctrlMouseradiusy(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2996CA0", Offset = "0x29960A0", Length = "0x2C0")]
	[Token(Token = "0x6000834")]
	private ButtonControl Initialize_ctrlMouserightButton(InternedString kButtonLayout, InputControl parent) { }

	[Address(RVA = "0x2996F70", Offset = "0x2996370", Length = "0x21B")]
	[Token(Token = "0x6000831")]
	private DeltaControl Initialize_ctrlMousescroll(InternedString kDeltaLayout, InputControl parent) { }

	[Address(RVA = "0x2997190", Offset = "0x2996590", Length = "0x281")]
	[Token(Token = "0x6000846")]
	private AxisControl Initialize_ctrlMousescrolldown(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2997420", Offset = "0x2996820", Length = "0x281")]
	[Token(Token = "0x6000847")]
	private AxisControl Initialize_ctrlMousescrollleft(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29976B0", Offset = "0x2996AB0", Length = "0x27A")]
	[Token(Token = "0x6000848")]
	private AxisControl Initialize_ctrlMousescrollright(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2997930", Offset = "0x2996D30", Length = "0x27A")]
	[Token(Token = "0x6000845")]
	private AxisControl Initialize_ctrlMousescrollup(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2997BB0", Offset = "0x2996FB0", Length = "0x26F")]
	[Token(Token = "0x6000849")]
	private AxisControl Initialize_ctrlMousescrollx(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x2997E20", Offset = "0x2997220", Length = "0x284")]
	[Token(Token = "0x600084A")]
	private AxisControl Initialize_ctrlMousescrolly(InternedString kAxisLayout, InputControl parent) { }

	[Address(RVA = "0x29980B0", Offset = "0x29974B0", Length = "0x135")]
	[Token(Token = "0x6000851")]
	internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	[Address(RVA = "0x29981F0", Offset = "0x29975F0", Length = "0x156")]
	[Token(Token = "0x600084D")]
	protected void OnNextUpdate() { }

	[Address(RVA = "0x2998350", Offset = "0x2997750", Length = "0x1CE")]
	[Token(Token = "0x600084E")]
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	[Address(RVA = "0x2998520", Offset = "0x2997920", Length = "0x135")]
	[Token(Token = "0x6000852")]
	private override bool UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

	[Address(RVA = "0x29981F0", Offset = "0x29975F0", Length = "0x156")]
	[Token(Token = "0x600084F")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	[Address(RVA = "0x2998660", Offset = "0x2997A60", Length = "0x1CF")]
	[Token(Token = "0x6000850")]
	private override void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

}

