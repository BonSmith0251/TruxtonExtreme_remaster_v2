namespace UnityEngine.InputForUI;

[Token(Token = "0x200001C")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct TextInputEvent : IEventProperties
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A2")]
	public char character; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000A3")]
	private DiscreteTime <timestamp>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A4")]
	private EventSource <eventSource>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000A5")]
	private uint <playerId>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A6")]
	private EventModifiers <eventModifiers>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000031")]
	public override EventModifiers eventModifiers
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600006C")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600006D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002F")]
	public override EventSource eventSource
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000069")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600006A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000030")]
	public uint playerId
	{
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600006B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002E")]
	public DiscreteTime timestamp
	{
		[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000068")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600006C")]
	public override EventModifiers get_eventModifiers() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000069")]
	public override EventSource get_eventSource() { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600006D")]
	public void set_eventModifiers(EventModifiers value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600006A")]
	public void set_eventSource(EventSource value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600006B")]
	public void set_playerId(uint value) { }

	[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000068")]
	public void set_timestamp(DiscreteTime value) { }

	[Address(RVA = "0x3110130", Offset = "0x310F530", Length = "0x9C")]
	[Token(Token = "0x600006E")]
	public virtual string ToString() { }

}

