namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Focus (11))]
[Token(Token = "0x20001D8")]
public abstract class FocusEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000856")]
	private Focusable <relatedTarget>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000857")]
	private FocusChangeDirection <direction>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000858")]
	private FocusController <focusController>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000859")]
	private bool <IsFocusDelegated>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700025E")]
	public private override FocusChangeDirection direction
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000D6B")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000D6C")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700025F")]
	protected private FocusController focusController
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000D6D")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000D6E")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000260")]
	internal bool IsFocusDelegated
	{
		[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000D6F")]
		internal get { } //Length: 8
		[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000D70")]
		private set { } //Length: 7
	}

	[Token(Token = "0x1700025D")]
	public private override Focusable relatedTarget
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000D69")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000D6A")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1C0B580", Offset = "0x1C0A980", Length = "0x79")]
	[Token(Token = "0x6000D74")]
	protected FocusEventBase`1() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000D6B")]
	public override FocusChangeDirection get_direction() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000D6D")]
	protected FocusController get_focusController() { }

	[Address(RVA = "0x1C0B600", Offset = "0x1C0AA00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000D6F")]
	internal bool get_IsFocusDelegated() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000D69")]
	public override Focusable get_relatedTarget() { }

	[Address(RVA = "0x1C0B2B0", Offset = "0x1C0A6B0", Length = "0x1AD")]
	[Token(Token = "0x6000D73")]
	public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false) { }

	[Address(RVA = "0x1C0B460", Offset = "0x1C0A860", Length = "0x4F")]
	[Token(Token = "0x6000D71")]
	protected virtual void Init() { }

	[Address(RVA = "0x1C0B4B0", Offset = "0x1C0A8B0", Length = "0xC9")]
	[Token(Token = "0x6000D72")]
	private void LocalInit() { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000D6C")]
	private void set_direction(FocusChangeDirection value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000D6E")]
	private void set_focusController(FocusController value) { }

	[Address(RVA = "0x1C0B610", Offset = "0x1C0AA10", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000D70")]
	private void set_IsFocusDelegated(bool value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000D6A")]
	private void set_relatedTarget(Focusable value) { }

}

