namespace UnityEngine.UIElements.Experimental;

[EventCategory(EventCategory::PointerMove (2))]
[Token(Token = "0x2000656")]
public class PointerMoveLinkTagEvent : PointerEventBase<PointerMoveLinkTagEvent>
{
	[CompilerGenerated]
	[Token(Token = "0x2000657")]
	private sealed class <>c
	{
		[Token(Token = "0x40017D9")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x33733C0", Offset = "0x33727C0", Length = "0x67")]
		[Token(Token = "0x6002CFE")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002CFF")]
		public <>c() { }

		[Address(RVA = "0x3373190", Offset = "0x3372590", Length = "0x6C")]
		[Token(Token = "0x6002D00")]
		internal PointerMoveLinkTagEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40017D7")]
	private string <linkID>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40017D8")]
	private string <linkText>k__BackingField; //Field offset: 0x108

	[Token(Token = "0x17000B63")]
	private string linkID
	{
		[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002CF8")]
		private set { } //Length: 19
	}

	[Token(Token = "0x17000B64")]
	private string linkText
	{
		[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6002CF9")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x336B690", Offset = "0x336AA90", Length = "0xD1")]
	[Token(Token = "0x6002CF7")]
	private static PointerMoveLinkTagEvent() { }

	[Address(RVA = "0x336B770", Offset = "0x336AB70", Length = "0x41")]
	[Token(Token = "0x6002CFD")]
	public PointerMoveLinkTagEvent() { }

	[Address(RVA = "0x336B5B0", Offset = "0x336A9B0", Length = "0x8F")]
	[Token(Token = "0x6002CFC")]
	public static PointerMoveLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	[Address(RVA = "0x336B640", Offset = "0x336AA40", Length = "0x41")]
	[Token(Token = "0x6002CFA")]
	protected virtual void Init() { }

	[Address(RVA = "0x336B470", Offset = "0x336A870", Length = "0x8")]
	[Token(Token = "0x6002CFB")]
	private void LocalInit() { }

	[Address(RVA = "0x20D5820", Offset = "0x20D4C20", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002CF8")]
	private void set_linkID(string value) { }

	[Address(RVA = "0xE7D080", Offset = "0xE7C480", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6002CF9")]
	private void set_linkText(string value) { }

}

