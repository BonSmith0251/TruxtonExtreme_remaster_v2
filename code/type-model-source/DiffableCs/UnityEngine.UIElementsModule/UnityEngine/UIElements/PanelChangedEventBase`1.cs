namespace UnityEngine.UIElements;

[EventCategory(EventCategory::ChangePanel (12))]
[Token(Token = "0x2000215")]
public abstract class PanelChangedEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000898")]
	private IPanel <originPanel>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000899")]
	private IPanel <destinationPanel>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000296")]
	public private IPanel destinationPanel
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E98")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000E99")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000295")]
	public private IPanel originPanel
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E96")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000E97")]
		private set { } //Length: 13
	}

	[Address(RVA = "0xE13090", Offset = "0xE12490", Length = "0x82")]
	[Token(Token = "0x6000E9D")]
	protected PanelChangedEventBase`1() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E98")]
	public IPanel get_destinationPanel() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E96")]
	public IPanel get_originPanel() { }

	[Address(RVA = "0xE12F00", Offset = "0xE12300", Length = "0xED")]
	[Token(Token = "0x6000E9C")]
	public static T GetPooled(IPanel originPanel, IPanel destinationPanel) { }

	[Address(RVA = "0xE12FF0", Offset = "0xE123F0", Length = "0x52")]
	[Token(Token = "0x6000E9A")]
	protected virtual void Init() { }

	[Address(RVA = "0xE13050", Offset = "0xE12450", Length = "0x34")]
	[Token(Token = "0x6000E9B")]
	private void LocalInit() { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000E99")]
	private void set_destinationPanel(IPanel value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000E97")]
	private void set_originPanel(IPanel value) { }

}

