namespace UnityEngine.UIElements;

[Token(Token = "0x20002B5")]
internal class RepaintData
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AF1")]
	private Matrix4x4 <currentOffset>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000AF2")]
	private Vector2 <mousePosition>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000AF3")]
	private Rect <currentWorldClip>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000AF4")]
	private Event <repaintEvent>k__BackingField; //Field offset: 0x68

	[Token(Token = "0x17000385")]
	public Matrix4x4 currentOffset
	{
		[Address(RVA = "0xAEF510", Offset = "0xAEE910", Length = "0x23")]
		[CompilerGenerated]
		[Token(Token = "0x600127E")]
		 get { } //Length: 35
	}

	[Token(Token = "0x17000386")]
	public Rect currentWorldClip
	{
		[Address(RVA = "0x2A05730", Offset = "0x2A04B30", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x600127F")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000387")]
	public Event repaintEvent
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001280")]
		 get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001281")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x340B890", Offset = "0x340AC90", Length = "0x62")]
	[Token(Token = "0x6001282")]
	public RepaintData() { }

	[Address(RVA = "0xAEF510", Offset = "0xAEE910", Length = "0x23")]
	[CompilerGenerated]
	[Token(Token = "0x600127E")]
	public Matrix4x4 get_currentOffset() { }

	[Address(RVA = "0x2A05730", Offset = "0x2A04B30", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x600127F")]
	public Rect get_currentWorldClip() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001280")]
	public Event get_repaintEvent() { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001281")]
	public void set_repaintEvent(Event value) { }

}

