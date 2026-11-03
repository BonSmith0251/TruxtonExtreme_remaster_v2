namespace UnityEngine;

[Token(Token = "0x2000007")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct EventInterests
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003A")]
	private bool <wantsMouseMove>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x400003B")]
	private bool <wantsMouseEnterLeaveWindow>k__BackingField; //Field offset: 0x1
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x400003C")]
	private bool <wantsLessLayoutEvents>k__BackingField; //Field offset: 0x2

	[Token(Token = "0x17000020")]
	public bool wantsLessLayoutEvents
	{
		[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000056")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001F")]
	public bool wantsMouseEnterLeaveWindow
	{
		[Address(RVA = "0xDA0E10", Offset = "0xDA0210", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000054")]
		 get { } //Length: 5
		[Address(RVA = "0x290B440", Offset = "0x290A840", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000055")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001E")]
	public bool wantsMouseMove
	{
		[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000052")]
		 get { } //Length: 4
		[Address(RVA = "0x123BF80", Offset = "0x123B380", Length = "0x3")]
		[CompilerGenerated]
		[Token(Token = "0x6000053")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x1E1AD50", Offset = "0x1E1A150", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000056")]
	public bool get_wantsLessLayoutEvents() { }

	[Address(RVA = "0xDA0E10", Offset = "0xDA0210", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000054")]
	public bool get_wantsMouseEnterLeaveWindow() { }

	[Address(RVA = "0xDA8C30", Offset = "0xDA8030", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000052")]
	public bool get_wantsMouseMove() { }

	[Address(RVA = "0x290B440", Offset = "0x290A840", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000055")]
	public void set_wantsMouseEnterLeaveWindow(bool value) { }

	[Address(RVA = "0x123BF80", Offset = "0x123B380", Length = "0x3")]
	[CompilerGenerated]
	[Token(Token = "0x6000053")]
	public void set_wantsMouseMove(bool value) { }

	[Address(RVA = "0x30DC620", Offset = "0x30DBA20", Length = "0x19")]
	[Token(Token = "0x6000057")]
	public bool WantsEvent(EventType type) { }

	[Address(RVA = "0x30DC640", Offset = "0x30DBA40", Length = "0xD4")]
	[Token(Token = "0x6000058")]
	public bool WantsLayoutPass(EventType type) { }

}

