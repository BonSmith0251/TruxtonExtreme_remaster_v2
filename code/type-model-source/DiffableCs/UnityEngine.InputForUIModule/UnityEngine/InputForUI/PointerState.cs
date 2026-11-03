namespace UnityEngine.InputForUI;

[Token(Token = "0x200002C")]
internal struct PointerState
{
	[Token(Token = "0x40000E0")]
	private static readonly DiscreteTime kClickDelay; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D9")]
	private Button <LastPressedButton>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000DA")]
	private ButtonsState _buttonsState; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000DB")]
	private DiscreteTime <NextPressTime>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000DC")]
	private int <ClickCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000DD")]
	private Vector2 <LastPosition>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000DE")]
	private int <LastDisplayIndex>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000DF")]
	private bool <LastPositionValid>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000044")]
	public ButtonsState ButtonsState
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000046")]
	public private int ClickCount
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60000DD")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000DE")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000048")]
	public private int LastDisplayIndex
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60000E1")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000E2")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000047")]
	public private Vector2 LastPosition
	{
		[Address(RVA = "0x1806A80", Offset = "0x1805E80", Length = "0x13")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60000DF")]
		 get { } //Length: 19
		[Address(RVA = "0x3110120", Offset = "0x310F520", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000E0")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000049")]
	public bool LastPositionValid
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60000E4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000043")]
	public private Button LastPressedButton
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60000D8")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x60000D9")]
		private set { } //Length: 3
	}

	[Token(Token = "0x17000045")]
	public private DiscreteTime NextPressTime
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60000DB")]
		 get { } //Length: 5
		[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60000DC")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x3110080", Offset = "0x310F480", Length = "0x9D")]
	[Token(Token = "0x60000EA")]
	private static PointerState() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60000DA")]
	public ButtonsState get_ButtonsState() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60000DD")]
	public int get_ClickCount() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60000E1")]
	public int get_LastDisplayIndex() { }

	[Address(RVA = "0x1806A80", Offset = "0x1805E80", Length = "0x13")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60000DF")]
	public Vector2 get_LastPosition() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60000E3")]
	public bool get_LastPositionValid() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60000D8")]
	public Button get_LastPressedButton() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60000DB")]
	public DiscreteTime get_NextPressTime() { }

	[Address(RVA = "0x310FCC0", Offset = "0x310F0C0", Length = "0xB5")]
	[Token(Token = "0x60000E7")]
	public void OnButtonChange(DiscreteTime currentTime, Button button, bool previousState, bool newState) { }

	[Address(RVA = "0x310FD80", Offset = "0x310F180", Length = "0x13E")]
	[Token(Token = "0x60000E5")]
	public void OnButtonDown(DiscreteTime currentTime, Button button) { }

	[Address(RVA = "0x310FEC0", Offset = "0x310F2C0", Length = "0x71")]
	[Token(Token = "0x60000E6")]
	public void OnButtonUp(DiscreteTime currentTime, Button button) { }

	[Address(RVA = "0x310FF40", Offset = "0x310F340", Length = "0x6E")]
	[Token(Token = "0x60000E8")]
	public void OnMove(DiscreteTime currentTime, Vector2 position, int displayIndex) { }

	[Address(RVA = "0x310FFB0", Offset = "0x310F3B0", Length = "0xCE")]
	[Token(Token = "0x60000E9")]
	public void Reset() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000DE")]
	private void set_ClickCount(int value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000E2")]
	private void set_LastDisplayIndex(int value) { }

	[Address(RVA = "0x3110120", Offset = "0x310F520", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000E0")]
	private void set_LastPosition(Vector2 value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60000E4")]
	public void set_LastPositionValid(bool value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x60000D9")]
	private void set_LastPressedButton(Button value) { }

	[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60000DC")]
	private void set_NextPressTime(DiscreteTime value) { }

}

