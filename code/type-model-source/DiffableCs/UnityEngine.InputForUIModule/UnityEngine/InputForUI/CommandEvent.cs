namespace UnityEngine.InputForUI;

[Token(Token = "0x2000002")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct CommandEvent : IEventProperties
{
	[Token(Token = "0x2000004")]
	internal enum Command : int
	{
		Invalid = 0,
		Cut = 1,
		Copy = 2,
		Paste = 3,
		SelectAll = 4,
		DeselectAll = 5,
		InvertSelection = 6,
		Duplicate = 7,
		Rename = 8,
		Delete = 9,
		SoftDelete = 10,
		Find = 11,
		SelectChildren = 12,
		SelectPrefabRoot = 13,
		UndoRedoPerformed = 14,
		OnLostFocus = 15,
		NewKeyboardFocus = 16,
		ModifierKeysChanged = 17,
		EyeDropperUpdate = 18,
		EyeDropperClicked = 19,
		EyeDropperCancelled = 20,
		ColorPickerChanged = 21,
		FrameSelected = 22,
		FrameSelectedWithLock = 23,
	}

	[Token(Token = "0x2000003")]
	internal enum Type : int
	{
		Validate = 1,
		Execute = 2,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	public Type type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000002")]
	public Command command; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000003")]
	private DiscreteTime <timestamp>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000004")]
	private EventSource <eventSource>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000005")]
	private uint <playerId>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000006")]
	private EventModifiers <eventModifiers>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000004")]
	public override EventModifiers eventModifiers
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000005")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000006")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000002")]
	public override EventSource eventSource
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000002")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000003")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000003")]
	public uint playerId
	{
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000004")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000001")]
	public DiscreteTime timestamp
	{
		[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000001")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000005")]
	public override EventModifiers get_eventModifiers() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000002")]
	public override EventSource get_eventSource() { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000006")]
	public void set_eventModifiers(EventModifiers value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000003")]
	public void set_eventSource(EventSource value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000004")]
	public void set_playerId(uint value) { }

	[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000001")]
	public void set_timestamp(DiscreteTime value) { }

	[Address(RVA = "0x3106D30", Offset = "0x3106130", Length = "0x93")]
	[Token(Token = "0x6000007")]
	public virtual string ToString() { }

}

