namespace UnityEngine.UIElements;

[Token(Token = "0x2000072")]
public abstract class ContextualMenuManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000224")]
	private bool <displayMenuHandledOSX>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000090")]
	internal bool displayMenuHandledOSX
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000408")]
		internal get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000409")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000411")]
	protected ContextualMenuManager() { }

	[Address(RVA = "0x2170560", Offset = "0x216F960", Length = "0x5")]
	[Token(Token = "0x6000410")]
	internal void AfterPointerUp() { }

	[Address(RVA = "0x2170560", Offset = "0x216F960", Length = "0x5")]
	[Token(Token = "0x600040F")]
	internal void BeforePointerDown() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600040A")]
	internal override bool CheckIfEventMatches(EventBase evt) { }

	[Address(RVA = "0x32222F0", Offset = "0x32216F0", Length = "0x81")]
	[Token(Token = "0x600040B")]
	public void DisplayMenu(EventBase triggerEvent, IEventHandler target) { }

	[Address(RVA = "0x3222070", Offset = "0x3221470", Length = "0x27C")]
	[Token(Token = "0x600040C")]
	internal void DisplayMenu(EventBase triggerEvent, IEventHandler target, DropdownMenu menu) { }

	[Token(Token = "0x600040D")]
	protected private abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000408")]
	internal bool get_displayMenuHandledOSX() { }

	[Address(RVA = "0x3222380", Offset = "0x3221780", Length = "0x47")]
	[Token(Token = "0x600040E")]
	internal static void ResetPointerDown(int pointerId) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000409")]
	internal void set_displayMenuHandledOSX(bool value) { }

}

