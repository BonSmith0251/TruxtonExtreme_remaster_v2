namespace UnityEngine.UIElements;

[Token(Token = "0x2000084")]
public class TreeViewExpansionChangedArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002DA")]
	private int <id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002DB")]
	private bool <isExpanded>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x40002DC")]
	private bool <isAppliedToAllChildren>k__BackingField; //Field offset: 0x15

	[Token(Token = "0x170000C0")]
	public int id
	{
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60004EB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000C2")]
	public bool isAppliedToAllChildren
	{
		[Address(RVA = "0x1F8C9F0", Offset = "0x1F8BDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60004ED")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000C1")]
	public bool isExpanded
	{
		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60004EC")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60004EE")]
	public TreeViewExpansionChangedArgs() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60004EB")]
	public void set_id(int value) { }

	[Address(RVA = "0x1F8C9F0", Offset = "0x1F8BDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60004ED")]
	public void set_isAppliedToAllChildren(bool value) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60004EC")]
	public void set_isExpanded(bool value) { }

}

