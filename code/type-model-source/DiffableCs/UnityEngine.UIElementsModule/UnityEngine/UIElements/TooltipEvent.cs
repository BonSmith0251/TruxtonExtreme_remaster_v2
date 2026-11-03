namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Tooltip (16))]
[Token(Token = "0x200023E")]
public class TooltipEvent : EventBase<TooltipEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x200023F")]
	private sealed class <>c
	{
		[Token(Token = "0x40008EE")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33E0140", Offset = "0x33DF540", Length = "0x67")]
		[Token(Token = "0x6000F9F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000FA0")]
		public <>c() { }

		[Address(RVA = "0x33DDF50", Offset = "0x33DD350", Length = "0xB2")]
		[Token(Token = "0x6000FA1")]
		internal TooltipEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008EC")]
	private string <tooltip>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008ED")]
	private Rect <rect>k__BackingField; //Field offset: 0x70

	[Token(Token = "0x170002DB")]
	public Rect rect
	{
		[Address(RVA = "0x2161F30", Offset = "0x2161330", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6000F9A")]
		 get { } //Length: 11
		[Address(RVA = "0x2162000", Offset = "0x2161400", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000F9B")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170002DA")]
	public string tooltip
	{
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000F99")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x33DB8E0", Offset = "0x33DACE0", Length = "0xD1")]
	[Token(Token = "0x6000F98")]
	private static TooltipEvent() { }

	[Address(RVA = "0x33DB9C0", Offset = "0x33DADC0", Length = "0x86")]
	[Token(Token = "0x6000F9E")]
	public TooltipEvent() { }

	[Address(RVA = "0x2161F30", Offset = "0x2161330", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6000F9A")]
	public Rect get_rect() { }

	[Address(RVA = "0x33DB840", Offset = "0x33DAC40", Length = "0x65")]
	[Token(Token = "0x6000F9C")]
	protected virtual void Init() { }

	[Address(RVA = "0x33DB8B0", Offset = "0x33DACB0", Length = "0x2C")]
	[Token(Token = "0x6000F9D")]
	private void LocalInit() { }

	[Address(RVA = "0x2162000", Offset = "0x2161400", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000F9B")]
	public void set_rect(Rect value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000F99")]
	public void set_tooltip(string value) { }

}

