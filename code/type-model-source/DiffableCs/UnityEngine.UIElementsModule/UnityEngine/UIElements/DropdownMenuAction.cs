namespace UnityEngine.UIElements;

[Token(Token = "0x20001A7")]
public class DropdownMenuAction : DropdownMenuItem
{
	[Flags]
	[Token(Token = "0x20001A8")]
	internal enum Status : int
	{
		None = 0,
		Normal = 1,
		Disabled = 2,
		Checked = 4,
		Hidden = 8,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007D2")]
	private readonly string <name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007D3")]
	private Status <status>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007D4")]
	private DropdownMenuEventInfo <eventInfo>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007D5")]
	private object <userData>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007D6")]
	private readonly Action<DropdownMenuAction> actionCallback; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007D7")]
	private readonly Func<DropdownMenuAction, Status> actionStatusCallback; //Field offset: 0x38

	[Token(Token = "0x17000234")]
	private DropdownMenuEventInfo eventInfo
	{
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000C4A")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000232")]
	public string name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C48")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000233")]
	private Status status
	{
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000C49")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000235")]
	private object userData
	{
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000C4B")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x33C7710", Offset = "0x33C6B10", Length = "0x7D")]
	[Token(Token = "0x6000C4E")]
	public DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null) { }

	[Address(RVA = "0x33C76A0", Offset = "0x33C6AA0", Length = "0x8")]
	[Token(Token = "0x6000C4D")]
	public static Status AlwaysDisabled(DropdownMenuAction a) { }

	[Address(RVA = "0x33C76B0", Offset = "0x33C6AB0", Length = "0x8")]
	[Token(Token = "0x6000C4C")]
	public static Status AlwaysEnabled(DropdownMenuAction a) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C48")]
	public string get_name() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000C4A")]
	private void set_eventInfo(DropdownMenuEventInfo value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000C49")]
	private void set_status(Status value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000C4B")]
	private void set_userData(object value) { }

	[Address(RVA = "0x33C76C0", Offset = "0x33C6AC0", Length = "0x46")]
	[Token(Token = "0x6000C4F")]
	public void UpdateActionStatus(DropdownMenuEventInfo eventInfo) { }

}

