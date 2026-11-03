namespace UnityEngine.UIElements;

[Token(Token = "0x20001A9")]
public class DropdownMenu
{
	[CompilerGenerated]
	[Token(Token = "0x20001AA")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007E1")]
		public Status status; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C59")]
		public <>c__DisplayClass14_0() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000C5A")]
		internal Status <AppendAction>b__0(DropdownMenuAction e) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001AB")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007E2")]
		public string subMenuPath; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C5B")]
		public <>c__DisplayClass17_0() { }

		[Address(RVA = "0x33DF470", Offset = "0x33DE870", Length = "0x8D")]
		[Token(Token = "0x6000C5C")]
		internal bool <AppendSeparator>b__0(DropdownMenuItem item) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007DE")]
	private List<DropdownMenuItem> m_MenuItems; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007DF")]
	private DropdownMenuEventInfo m_DropdownMenuEventInfo; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007E0")]
	private bool <repaintPanelBeforeDisplay>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000236")]
	internal int Count
	{
		[Address(RVA = "0x33C8340", Offset = "0x33C7740", Length = "0x3C")]
		[Token(Token = "0x6000C50")]
		internal get { } //Length: 60
	}

	[Token(Token = "0x17000237")]
	internal bool repaintPanelBeforeDisplay
	{
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C51")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x33C82C0", Offset = "0x33C76C0", Length = "0x77")]
	[Token(Token = "0x6000C58")]
	public DropdownMenu() { }

	[Address(RVA = "0x33C7B60", Offset = "0x33C6F60", Length = "0x12F")]
	[Token(Token = "0x6000C53")]
	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null) { }

	[Address(RVA = "0x33C7A40", Offset = "0x33C6E40", Length = "0x11B")]
	[Token(Token = "0x6000C54")]
	public void AppendAction(string actionName, Action<DropdownMenuAction> action, Status status = 1) { }

	[Address(RVA = "0x33C7C90", Offset = "0x33C7090", Length = "0x264")]
	[Token(Token = "0x6000C55")]
	public void AppendSeparator(string subMenuPath = null) { }

	[Address(RVA = "0x33C8340", Offset = "0x33C7740", Length = "0x3C")]
	[Token(Token = "0x6000C50")]
	internal int get_Count() { }

	[Address(RVA = "0x33C7F00", Offset = "0x33C7300", Length = "0x143")]
	[Token(Token = "0x6000C56")]
	public void InsertSeparator(string subMenuPath, int atIndex) { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x6000C52")]
	public List<DropdownMenuItem> MenuItems() { }

	[Address(RVA = "0x33C8050", Offset = "0x33C7450", Length = "0x26A")]
	[Token(Token = "0x6000C57")]
	public void PrepareForDisplay(EventBase e) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C51")]
	internal void set_repaintPanelBeforeDisplay(bool value) { }

}

