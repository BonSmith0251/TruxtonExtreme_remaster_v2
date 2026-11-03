namespace UnityEngine.InputForUI;

[Token(Token = "0x2000018")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct PointerEvent : IEventProperties
{
	[Flags]
	[Token(Token = "0x200001A")]
	internal enum Button : uint
	{
		None = 0,
		Primary = 1,
		FingerInTouch = 1,
		PenTipInTouch = 1,
		PenEraserInTouch = 2,
		PenBarrelButton = 4,
		MouseLeft = 1,
		MouseRight = 2,
		MouseMiddle = 4,
		MouseForward = 8,
		MouseBack = 16,
	}

	[Token(Token = "0x200001B")]
	internal struct ButtonsState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000A1")]
		private uint _state; //Field offset: 0x0

		[Address(RVA = "0x3106BB0", Offset = "0x3105FB0", Length = "0x8")]
		[Token(Token = "0x6000065")]
		public bool Get(Button button) { }

		[Address(RVA = "0x1CA23C0", Offset = "0x1CA17C0", Length = "0x7")]
		[Token(Token = "0x6000066")]
		public void Reset() { }

		[Address(RVA = "0x2679C40", Offset = "0x2679040", Length = "0x13")]
		[Token(Token = "0x6000064")]
		public void Set(Button button, bool pressed) { }

		[Address(RVA = "0x3106CD0", Offset = "0x31060D0", Length = "0x54")]
		[Token(Token = "0x6000067")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000019")]
	internal enum Type : int
	{
		PointerMoved = 1,
		Scroll = 2,
		ButtonPressed = 3,
		ButtonReleased = 4,
		State = 5,
		TouchCanceled = 6,
		TrackedCanceled = 6,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000079")]
	public Type type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400007A")]
	public int pointerIndex; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400007B")]
	public Vector2 position; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007C")]
	public Vector2 deltaPosition; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007D")]
	public Vector3 worldPosition; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400007E")]
	public Quaternion worldOrientation; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400007F")]
	public float maxDistance; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000080")]
	public Vector2 scroll; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000081")]
	public int displayIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000082")]
	public Vector2 tilt; //Field offset: 0x44
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000083")]
	public float twist; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000084")]
	public float pressure; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000085")]
	public bool isInverted; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000086")]
	public Button button; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000087")]
	public ButtonsState buttonsState; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000088")]
	public int clickCount; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000089")]
	private DiscreteTime <timestamp>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400008A")]
	private EventSource <eventSource>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400008B")]
	private uint <playerId>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400008C")]
	private EventModifiers <eventModifiers>k__BackingField; //Field offset: 0x78

	[Token(Token = "0x17000029")]
	public float altitude
	{
		[Address(RVA = "0x310F9E0", Offset = "0x310EDE0", Length = "0x4B")]
		[Token(Token = "0x600005A")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000028")]
	public float azimuth
	{
		[Address(RVA = "0x310FA30", Offset = "0x310EE30", Length = "0xD4")]
		[Token(Token = "0x6000059")]
		 get { } //Length: 212
	}

	[Token(Token = "0x1700002D")]
	public override EventModifiers eventModifiers
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000060")]
		 get { } //Length: 4
		[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000061")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002B")]
	public override EventSource eventSource
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600005D")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600005E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000026")]
	public bool isPrimaryPointer
	{
		[Address(RVA = "0x29217E0", Offset = "0x2920BE0", Length = "0x8")]
		[Token(Token = "0x6000057")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700002C")]
	public uint playerId
	{
		[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600005F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002A")]
	public override DiscreteTime timestamp
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600005B")]
		 get { } //Length: 5
		[Address(RVA = "0x16D0C90", Offset = "0x16D0090", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600005C")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000027")]
	public Ray worldRay
	{
		[Address(RVA = "0x310FB10", Offset = "0x310EF10", Length = "0x1A1")]
		[Token(Token = "0x6000058")]
		 get { } //Length: 417
	}

	[Address(RVA = "0x310EB00", Offset = "0x310DF00", Length = "0x10")]
	[Token(Token = "0x6000063")]
	internal static Button ButtonFromButtonIndex(int index) { }

	[Address(RVA = "0x310F9E0", Offset = "0x310EDE0", Length = "0x4B")]
	[Token(Token = "0x600005A")]
	public float get_altitude() { }

	[Address(RVA = "0x310FA30", Offset = "0x310EE30", Length = "0xD4")]
	[Token(Token = "0x6000059")]
	public float get_azimuth() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000060")]
	public override EventModifiers get_eventModifiers() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600005D")]
	public override EventSource get_eventSource() { }

	[Address(RVA = "0x29217E0", Offset = "0x2920BE0", Length = "0x8")]
	[Token(Token = "0x6000057")]
	public bool get_isPrimaryPointer() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600005B")]
	public override DiscreteTime get_timestamp() { }

	[Address(RVA = "0x310FB10", Offset = "0x310EF10", Length = "0x1A1")]
	[Token(Token = "0x6000058")]
	public Ray get_worldRay() { }

	[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000061")]
	public void set_eventModifiers(EventModifiers value) { }

	[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600005E")]
	public void set_eventSource(EventSource value) { }

	[Address(RVA = "0x1E24880", Offset = "0x1E23C80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600005F")]
	public void set_playerId(uint value) { }

	[Address(RVA = "0x16D0C90", Offset = "0x16D0090", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600005C")]
	public void set_timestamp(DiscreteTime value) { }

	[Address(RVA = "0x310EB10", Offset = "0x310DF10", Length = "0xEC1")]
	[Token(Token = "0x6000062")]
	public virtual string ToString() { }

}

