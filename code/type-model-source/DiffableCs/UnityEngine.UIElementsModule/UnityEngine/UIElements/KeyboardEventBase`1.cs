namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Keyboard (6))]
[Token(Token = "0x20001E6")]
public abstract class KeyboardEventBase : EventBase<T>, IKeyboardEvent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000863")]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000864")]
	private char <character>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000865")]
	private KeyCode <keyCode>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700026F")]
	public override bool actionKey
	{
		[Address(RVA = "0xAF0700", Offset = "0xAEFB00", Length = "0x84")]
		[Token(Token = "0x6000DB0")]
		 get { } //Length: 132
	}

	[Token(Token = "0x1700026D")]
	public override bool altKey
	{
		[Address(RVA = "0xAF0790", Offset = "0xAEFB90", Length = "0xA")]
		[Token(Token = "0x6000DAE")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000268")]
	public override char character
	{
		[Address(RVA = "0xAF07A0", Offset = "0xAEFBA0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA7")]
		 get { } //Length: 5
		[Address(RVA = "0xAF0810", Offset = "0xAEFC10", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA8")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700026C")]
	public override bool commandKey
	{
		[Address(RVA = "0xAF07B0", Offset = "0xAEFBB0", Length = "0xA")]
		[Token(Token = "0x6000DAD")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700026B")]
	public override bool ctrlKey
	{
		[Address(RVA = "0xAF07C0", Offset = "0xAEFBC0", Length = "0xA")]
		[Token(Token = "0x6000DAC")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700026E")]
	internal bool functionKey
	{
		[Address(RVA = "0xAF07D0", Offset = "0xAEFBD0", Length = "0xA")]
		[Token(Token = "0x6000DAF")]
		internal get { } //Length: 10
	}

	[Token(Token = "0x17000269")]
	public override KeyCode keyCode
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA9")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000DAA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000267")]
	public override EventModifiers modifiers
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA5")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000DA6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700026A")]
	public override bool shiftKey
	{
		[Address(RVA = "0xAF0800", Offset = "0xAEFC00", Length = "0xA")]
		[Token(Token = "0x6000DAB")]
		 get { } //Length: 10
	}

	[Address(RVA = "0xAF0670", Offset = "0xAEFA70", Length = "0x80")]
	[Token(Token = "0x6000DB6")]
	protected KeyboardEventBase`1() { }

	[Address(RVA = "0xAF03B0", Offset = "0xAEF7B0", Length = "0x8")]
	[Token(Token = "0x6000DB5")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0xAF0700", Offset = "0xAEFB00", Length = "0x84")]
	[Token(Token = "0x6000DB0")]
	public override bool get_actionKey() { }

	[Address(RVA = "0xAF0790", Offset = "0xAEFB90", Length = "0xA")]
	[Token(Token = "0x6000DAE")]
	public override bool get_altKey() { }

	[Address(RVA = "0xAF07A0", Offset = "0xAEFBA0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000DA7")]
	public override char get_character() { }

	[Address(RVA = "0xAF07B0", Offset = "0xAEFBB0", Length = "0xA")]
	[Token(Token = "0x6000DAD")]
	public override bool get_commandKey() { }

	[Address(RVA = "0xAF07C0", Offset = "0xAEFBC0", Length = "0xA")]
	[Token(Token = "0x6000DAC")]
	public override bool get_ctrlKey() { }

	[Address(RVA = "0xAF07D0", Offset = "0xAEFBD0", Length = "0xA")]
	[Token(Token = "0x6000DAF")]
	internal bool get_functionKey() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000DA9")]
	public override KeyCode get_keyCode() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000DA5")]
	public override EventModifiers get_modifiers() { }

	[Address(RVA = "0xAF0800", Offset = "0xAEFC00", Length = "0xA")]
	[Token(Token = "0x6000DAB")]
	public override bool get_shiftKey() { }

	[Address(RVA = "0xAF03C0", Offset = "0xAEF7C0", Length = "0xF9")]
	[Token(Token = "0x6000DB3")]
	public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers) { }

	[Address(RVA = "0xAF04C0", Offset = "0xAEF8C0", Length = "0x122")]
	[Token(Token = "0x6000DB4")]
	public static T GetPooled(Event systemEvent) { }

	[Address(RVA = "0xAF05F0", Offset = "0xAEF9F0", Length = "0x40")]
	[Token(Token = "0x6000DB1")]
	protected virtual void Init() { }

	[Address(RVA = "0xAF0640", Offset = "0xAEFA40", Length = "0x26")]
	[Token(Token = "0x6000DB2")]
	private void LocalInit() { }

	[Address(RVA = "0xAF0810", Offset = "0xAEFC10", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000DA8")]
	protected void set_character(char value) { }

	[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000DAA")]
	protected void set_keyCode(KeyCode value) { }

	[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000DA6")]
	protected void set_modifiers(EventModifiers value) { }

}

