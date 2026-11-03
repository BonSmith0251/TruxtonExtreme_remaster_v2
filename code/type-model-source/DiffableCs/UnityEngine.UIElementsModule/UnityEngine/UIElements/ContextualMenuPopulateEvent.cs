namespace UnityEngine.UIElements;

[Token(Token = "0x2000207")]
public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000208")]
	private sealed class <>c
	{
		[Token(Token = "0x4000884")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33DF8F0", Offset = "0x33DECF0", Length = "0x67")]
		[Token(Token = "0x6000E69")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000E6A")]
		public <>c() { }

		[Address(RVA = "0x33DE080", Offset = "0x33DD480", Length = "0x6F")]
		[Token(Token = "0x6000E6B")]
		internal ContextualMenuPopulateEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000881")]
	private DropdownMenu <menu>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000882")]
	private EventBase <triggerEvent>k__BackingField; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000883")]
	private ContextualMenuManager m_ContextualMenuManager; //Field offset: 0xB0

	[Token(Token = "0x1700028B")]
	public private DropdownMenu menu
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000E60")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000E61")]
		private set { } //Length: 19
	}

	[Token(Token = "0x1700028C")]
	public private EventBase triggerEvent
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000E62")]
		 get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000E63")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x33C7130", Offset = "0x33C6530", Length = "0xD1")]
	[Token(Token = "0x6000E5F")]
	private static ContextualMenuPopulateEvent() { }

	[Address(RVA = "0x33C7210", Offset = "0x33C6610", Length = "0x43")]
	[Token(Token = "0x6000E67")]
	public ContextualMenuPopulateEvent() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000E60")]
	public DropdownMenu get_menu() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000E62")]
	public EventBase get_triggerEvent() { }

	[Address(RVA = "0x33C6B90", Offset = "0x33C5F90", Length = "0x3C9")]
	[Token(Token = "0x6000E64")]
	public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager) { }

	[Address(RVA = "0x33C6F60", Offset = "0x33C6360", Length = "0x43")]
	[Token(Token = "0x6000E65")]
	protected virtual void Init() { }

	[Address(RVA = "0x33C6FB0", Offset = "0x33C63B0", Length = "0x83")]
	[Token(Token = "0x6000E66")]
	private void LocalInit() { }

	[Address(RVA = "0x33C7040", Offset = "0x33C6440", Length = "0xE4")]
	[Token(Token = "0x6000E68")]
	protected private virtual void PostDispatch(IPanel panel) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000E61")]
	private void set_menu(DropdownMenu value) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000E63")]
	private void set_triggerEvent(EventBase value) { }

}

