namespace UnityEngine.InputForUI;

[Token(Token = "0x2000023")]
internal class InputEventPartialProvider : IEventProviderImpl
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B5")]
	private Event _ev; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B6")]
	private OperatingSystemFamily _operatingSystemFamily; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000B7")]
	private ButtonsState _keyboardButtonsState; //Field offset: 0x1C
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000B8")]
	internal EventModifiers _eventModifiers; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000B9")]
	internal bool _sendNavigationEventOnTabKey; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000BA")]
	private IDictionary<String, Command> _IMGUICommandToInputForUICommandType; //Field offset: 0x50

	[Address(RVA = "0x310A6F0", Offset = "0x3109AF0", Length = "0x462")]
	[Token(Token = "0x6000090")]
	public InputEventPartialProvider() { }

	[Address(RVA = "0x3109790", Offset = "0x3108B90", Length = "0x29")]
	[Token(Token = "0x600008A")]
	private DiscreteTime GetTimestamp(in Event ev) { }

	[Address(RVA = "0x31097C0", Offset = "0x3108BC0", Length = "0x2D")]
	[Token(Token = "0x6000085")]
	public override void Initialize() { }

	[Address(RVA = "0x31097F0", Offset = "0x3108BF0", Length = "0x1D")]
	[Token(Token = "0x6000088")]
	public override void OnFocusChanged(bool focus) { }

	[Address(RVA = "0x3109810", Offset = "0x3108C10", Length = "0x195")]
	[Token(Token = "0x6000089")]
	public override bool RequestCurrentState(Type type) { }

	[Address(RVA = "0x31099B0", Offset = "0x3108DB0", Length = "0x1D8")]
	[Token(Token = "0x600008E")]
	private void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(in Event ev) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000086")]
	public override void Shutdown() { }

	[Address(RVA = "0x3109B90", Offset = "0x3108F90", Length = "0x205")]
	[Token(Token = "0x600008F")]
	private CommandEvent ToCommandEvent(in Event ev) { }

	[Address(RVA = "0x3109DA0", Offset = "0x31091A0", Length = "0x1EF")]
	[Token(Token = "0x600008C")]
	private KeyEvent ToKeyEvent(in Event ev) { }

	[Address(RVA = "0x3109F90", Offset = "0x3109390", Length = "0xA0")]
	[Token(Token = "0x600008D")]
	private TextInputEvent ToTextInputEvent(in Event ev) { }

	[Address(RVA = "0x310A340", Offset = "0x3109740", Length = "0x3A6")]
	[Token(Token = "0x6000087")]
	public override void Update() { }

	[Address(RVA = "0x310A040", Offset = "0x3109440", Length = "0x2D0")]
	[Token(Token = "0x600008B")]
	private void UpdateEventModifiers(in Event ev) { }

}

